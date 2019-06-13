using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace mook_RemoteCMD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int port = 64000; //포트

        TcpClient tClient; //TCP 연결 클라이언트
        NetworkStream ns; //네트워크 스트림
        StreamReader sr; //스트림 읽기
        StreamWriter sw; //스트림 쓰기

        Thread MessageThre = null; //메시지 받기 보내기 스레드
        delegate void OnMessageDelegate(string s); //델리게이트
        OnMessageDelegate OnMessage = null;

        bool Run = true; //스트림 받기 플래그

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            try
            {
                tClient = new TcpClient(this.txtAgentIP.Text, port);
                ns = tClient.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);

                MessageThre = new Thread(MessageReceive);
                MessageThre.Start();
            }
            catch
            {
                Invoke(OnMessage, "접속 실패");
                return;
            }
        }

        private void MessageReceive()
        {
            try
            {
                while (Run)
                {
                    Thread.Sleep(1);
                    if (ns.CanRead)
                    {
                        string msg = sr.ReadLine();
                        if (msg != null)
                        {
                            Invoke(OnMessage, msg);
                        }
                    }
                }
            }
            catch { }
        }

        private void OnMessageView(string text)
        {
            this.tsslblConnect.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnMessage = new OnMessageDelegate(OnMessageView);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tClient != null) tClient.Close();
            Run = false;
            if (sr != null) sr.Close();
            if (sw != null) sr.Close();
            if (ns != null) ns.Close();
            if (MessageThre != null) MessageThre.Abort();
            Application.ExitThread();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            sw.WriteLine(this.txtCMD.Text);
            sw.Flush();
        }
    }
}
