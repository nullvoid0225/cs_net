using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; //Process 클래스사용
using System.Runtime.InteropServices;
using System.Threading;

namespace mook_NMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private const int WM_CHAR = 0x0102;

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int FindWindowEx(int parentHandle, IntPtr childAfter, string className, string lpsz2);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        int iHandle = 0; //윈도우핸들 정보

        Thread TextThre = null;
        string ItemIpT = "";

        Thread MessageThre = null;

        Thread CmdThre = null;

        Thread CpuThre = null;

        public string ItemIp //Item의 IP를 설정
        {
            set
            {
                this.txtIp.Text = value;
                ItemIpT = value;
            }
        }

        public Point Itemxy // Location 설정을 위한 Set 접근자
        {
            set
            {
                LocationXY = value;
            }
        }

        Point LocationXY = new Point(); //Form2의 Location 설정을 위한 Point


        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = LocationXY;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private bool IPCheck(string StrIp)
        {
            if (StrIp == "0.0.0.0")
                return false;
            else
                return true;
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (IPCheck(ItemIpT) == true)
            {
                Process ps = new Process();
                ps.StartInfo.FileName = "mook_RemoteMessage.exe";
                ps.Start();

                MessageThre = new Thread(MessageSend);
                MessageThre.Start();
            }
            else
            {
                MessageBox.Show("유효한 IP가 아닙니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MessageSend()
        {
            Thread.Sleep(500);
            iHandle = FindWindow(null, "1:1 채팅 관리자");
            Thread.Sleep(300);
            int childHandle1 = FindWindowEx(iHandle, IntPtr.Zero, "WindowsForms10.Window.8.app.0.141b42a_r29_ad1", "ToolStrip1");
            Thread.Sleep(300);
            int childHandle2 = FindWindowEx(childHandle1, IntPtr.Zero, "WindowsForms10.EDIT.app.0.141b42a_r29_ad1", "");
            Thread.Sleep(300);
            for (int i = 0; i < ItemIpT.Length; i++)
            {
                char c = (char)ItemIpT[i];
                SendMessage(childHandle2, WM_CHAR, c, 1);
                Thread.Sleep(50);
            }
            MessageThre.Abort();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (IPCheck(ItemIpT) == true)
            {
                Process ps = new Process();
                ps.StartInfo.FileName = "mook_RemoteShutdownManager.exe";
                ps.Start();

                TextThre = new Thread(TextSend);
                TextThre.Start();
            }
            else
            {
                MessageBox.Show("유효한 IP가 아닙니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextSend()
        {
            Thread.Sleep(500);
            iHandle = FindWindow(null, "NMS 전원제어 관리자");
            Thread.Sleep(500);
            int childHandle1 = FindWindowEx(iHandle, IntPtr.Zero, "WindowsForms10.EDIT.app.0.141b42a_r29_ad1", "");
            for (int i = 0; i < ItemIpT.Length; i++)
            {
                char c = (char)ItemIpT[i];
                SendMessage(childHandle1, WM_CHAR, c, 1);
                Thread.Sleep(50);
            }
            TextThre.Abort();
        }

        private void btnNetCheck_Click(object sender, EventArgs e)
        {
            if (IPCheck(ItemIpT) == true)
            {
                Form3 frm3 = new Form3();
                frm3.ItemIp = this.txtIp.Text;
                frm3.Show();
            }
            else
            {
                MessageBox.Show("유효한 IP가 아닙니다.", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCMD_Click(object sender, EventArgs e)
        {
            if (IPCheck(ItemIpT) == true)
            {
                Process ps = new Process();
                ps.StartInfo.FileName = "mook_RemoteCMD.exe";
                ps.Start();

                CmdThre = new Thread(CommandCmd);
                CmdThre.Start();
            }
            else
            {
                MessageBox.Show("유효한 IP가 아닙니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CommandCmd()
        {
            Thread.Sleep(500);
            iHandle = FindWindow(null, "CMD 명령 관리자");
            Thread.Sleep(500);
            int childHandle1 = FindWindowEx(iHandle, IntPtr.Zero, "WindowsForms10.EDIT.app.0.141b42a_r29_ad1", "아이피");
            for (int i = 0; i < ItemIpT.Length; i++)
            {
                char c = (char)ItemIpT[i];
                SendMessage(childHandle1, WM_CHAR, c, 1);
                Thread.Sleep(50);
            }
            CmdThre.Abort();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            if (IPCheck(ItemIpT) == true)
            {
                Process ps = new Process();
                ps.StartInfo.FileName = "mook_RemoteCPU.exe";
                ps.Start();

                CpuThre = new Thread(CPUMonitor);
                CpuThre.Start();
            }
            else
            {
                MessageBox.Show("유효한 IP가 아닙니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CPUMonitor()
        {
            Thread.Sleep(500);
            iHandle = FindWindow(null, "CPU 모니터 관리자");
            Thread.Sleep(500);
            int childHandle1 = FindWindowEx(iHandle, IntPtr.Zero, "WindowsForms10.EDIT.app.0.141b42a_r29_ad1", "");
            for (int i = 0; i < ItemIpT.Length; i++)
            {
                char c = (char)ItemIpT[i];
                SendMessage(childHandle1, WM_CHAR, c, 1);
                Thread.Sleep(50);
            }
            CpuThre.Abort();
        }
    }
}
