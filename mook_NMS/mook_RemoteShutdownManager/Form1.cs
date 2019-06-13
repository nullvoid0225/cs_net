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

namespace mook_RemoteShutdownManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int port = 63000;

        TcpClient tClient;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        Thread MessageThre = null;
        delegate void OnMessageDelegate(string s);
        OnMessageDelegate OnMessage = null;

        bool Run = true;

        GetIPAddress gip = new GetIPAddress();

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

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rbShutdown.Checked == true)
            {
                sw.WriteLine("###SHUTDOWN###");
            }
            if (rbReboot.Checked == true)
            {
                sw.WriteLine("###REBOOT###");
            }
            if (rbLogOff.Checked == true)
            {
                sw.WriteLine("###LOGOFF###");
            }
            if (rbNothing.Checked == true)
            {
                sw.WriteLine("###Nothing###");
            }
            sw.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblManagerIP.Text = gip.GetRealIpAddress().ToString();
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
    }
}
