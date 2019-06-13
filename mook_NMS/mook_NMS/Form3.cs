using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.NetworkInformation;
using System.IO;
using System.Threading;

namespace mook_NMS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string ItemIpS = "";

        public string ItemIp
        {
            set
            {
                this.lblIp.Text = value + this.lblIp.Text;
                ItemIpS = value;
            }
        }

        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        const int timeout = 120;

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Byte[] buffer = Encoding.ASCII.GetBytes(data);
            options.DontFragment = true;
            string strLog = "";

            PingReply reply = pingSender.Send(ItemIpS, timeout, buffer, options);

            if (reply.Status == IPStatus.Success)
            {
                strLog += ItemIpS + " : " + DateTime.Now.ToString() + "  " + reply.Buffer.Length.ToString() + " Bytes  " +
                    reply.RoundtripTime.ToString() + " ms  " + reply.Options.Ttl.ToString();
            }
            else
            {
                strLog += ItemIpS + " : 실패";
            }

            this.txtView.AppendText(strLog + "\n");
        }
    }
}
