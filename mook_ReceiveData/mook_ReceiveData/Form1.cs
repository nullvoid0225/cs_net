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

namespace mook_ReceiveData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Runflags = true;

        private void btnReceive_Click(object sender, EventArgs e)
        {
            while (Runflags)
            {
                System.Threading.Thread.Sleep(1);
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
        }
    }
}