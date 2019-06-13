using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; //Process 클래스 사용
using System.Threading;

namespace mook_ThreadReceiveData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread ReceThread = null;
        bool Runflags = true;

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ReceThread = new Thread(ReceiveData);
            ReceThread.Start();
        }

        private void ReceiveData()
        {
            while (Runflags)
            {
                Thread.Sleep(1);
                foreach (var proc in Process.GetProcesses())
                {
                    if (proc.ProcessName.ToString() == "mook_SendData")
                    {
                        Runflags = false;
                        this.lblReceive02.Text = "실행되었고 값은 "
                            + mook_SendData.Form1.SendName;
                    }
                }
            }
            ReceThread.Abort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ReceThread != null)
                ReceThread.Abort();
        }
    }
}
