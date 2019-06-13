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

namespace mook_RemoteCPU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int port = 64100; //포트

        TcpClient tClient;
        NetworkStream ns; //네트워크 스트림
        StreamReader sr; //스트림 읽기

        Thread MessageThre = null; //메시지 수신 스레드
        delegate void OnMessageDelegate(string s); //델리게이트
        OnMessageDelegate OnMessage = null;

        bool Run = true;

        string lblMsg = ""; 

        private void btnConn_Click(object sender, EventArgs e)
        {
            try
            {
                tClient = new TcpClient(this.txtAgentIP.Text, port);
                ns = tClient.GetStream();
                sr = new StreamReader(ns);

                MessageThre = new Thread(MessageReceive);
                MessageThre.Start();
            }
            catch
            {
                Invoke(OnMessage, "접속 실패&0");
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
            if (text.Split('&')[1] == "0")
            {
                this.lblCPU.Text = "상태 : " + text.Split('&')[0];
            }
            else
            {
                this.lblCPU.Text = lblMsg + text.Split('&')[0] + "%";

                double ValueAdd = Convert.ToDouble(text.Split('&')[0]);
                CPUMonitor.AddValue((float)ValueAdd);
                CPUMonitor.RefreshControl();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg = this.lblCPU.Text;
            OnMessage = new OnMessageDelegate(OnMessageView);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tClient != null) tClient.Close();
            Run = false;
            if (sr != null) sr.Close();
            if (ns != null) ns.Close();
            if (MessageThre != null) MessageThre.Abort();
            Application.ExitThread();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
