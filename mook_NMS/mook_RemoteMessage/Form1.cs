using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net; // IPAddress
using System.Net.Sockets; //TcpListener 클래스사용
using System.Threading; //스레드 클래스 사용
using System.IO; //파일 클래스 사용
using System.Runtime.InteropServices; //폼 깜박임 구현

namespace mook_RemoteMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpClient client; //TCP 네트워크 서비스에 대한 클라이언트 연결 제공
        private NetworkStream myStream; //네트워크 스트림
        private StreamReader myRead; //스트림 읽기
        private StreamWriter myWrite; //스트림 쓰기
        private Boolean ClientCon = false; //클라이언트 시작
        private int myPort = 62000; //포트
        private string myName = "관리자"; //별칭
        private Thread myReader; //스레드
        private Boolean TextChange = false; //입력 컨트롤의 데이터입력 체크

        private delegate void AddTextDelegate(string strText); //데리게이트 개체 생성
        private AddTextDelegate AddText = null; //델리게이트 개체 생성

        [DllImport("User32.dll")]
        private static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

        private void tsbtnConn_Click(object sender, EventArgs e)
        {
            if (this.tlstxtIp.Text == "")
            {
                MessageBox.Show("접속할 아이피가 입력되지 않았습니다.", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tlstxtIp.Focus();
            }
            else
            {
                AddText = new AddTextDelegate(MessageView);
                ClientConnection(); //ClientConnection() 함수 호출
            }
        }

        private void MessageView(string strText)
        {
            this.rtbText.AppendText(strText + "\r\n");
            this.rtbText.Focus();
            this.rtbText.ScrollToCaret();
            this.txtMessage.Focus();
            FlashWindow(this.Handle, true);
        }


        private void ClientConnection()
        {
            try
            {
                client = new TcpClient(this.tlstxtIp.Text, this.myPort);
                Invoke(AddText, "서버에 접속 했습니다.");
                myStream = client.GetStream();

                myRead = new StreamReader(myStream);
                myWrite = new StreamWriter(myStream);
                this.ClientCon = true;
                this.tsbtnConn.Enabled = false;
                this.tsbtnDisconn.Enabled = true;
                this.txtMessage.Enabled = true;
                this.btnSend.Enabled = true;
                this.txtMessage.Focus();

                myReader = new Thread(Receive);
                myReader.Start();
            }
            catch
            {
                this.ClientCon = false;
                Invoke(AddText, "서버에 접속하지 못 했습니다.");
            }
        }

        private void Receive()
        {
            try
            {
                while (this.ClientCon)
                {
                    Thread.Sleep(1);
                    if (myStream.CanRead)
                    {
                        var msg = myRead.ReadLine();
                        var Smsg = msg.Split('&');
                        if (Smsg[0] == "S001")
                        {
                            this.tsslblTime.Text = Smsg[1];
                        }
                        else
                        {
                            if (msg.Length > 0)
                            {
                                Invoke(AddText, Smsg[0] + " : " + Smsg[1]);
                            }
                            this.tsslblTime.Text = "마지막으로 받은 시각:" + Smsg[2];
                        }
                    }
                }
            }
            catch { }
        }

        private void tsbtnDisconn_Click(object sender, EventArgs e)
        {
            if (this.client.Connected)
            {
                var dt = Convert.ToString(DateTime.Now);
                myWrite.WriteLine(this.myName + "&" + "채팅 APP가 종료되었습니다." + "&" + dt);
                myWrite.Flush();
                Disconnection();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClientCon)
            {
                try
                { Disconnection(); }
                catch { Application.ExitThread(); }
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void Disconnection()
        {
            this.ClientCon = false;
            try
            {
                if (!(myRead == null))
                {
                    myRead.Close(); //StreamReader 클래스 개체 리소스 해제
                }
                if (!(myWrite == null))
                {
                    myWrite.Close(); //StreamWriter 클래스 개체 리소스 해제
                }
                if (!(myStream == null))
                {
                    myStream.Close(); //NetworkStream 클래스 개체 리소스 해제
                }
                if (!(client == null))
                {
                    client.Close(); //TcpClient 클래스 개체 리소스 해제
                }
                if (!(myReader == null))
                {
                    myReader.Abort(); //외부 스레드 종료
                }
            }
            catch
            {
                return;
            }
            this.tsbtnConn.Enabled = true;
            this.tsbtnDisconn.Enabled = false;
            Invoke(AddText, "연결이 끊어졌습니다.");
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (TextChange == false)
            {
                TextChange = true;
                myWrite.WriteLine("S001" + "&" + "상대방이 메시지 입력중입니다." + "&" + " ");
                myWrite.Flush();
            }
            else if (this.txtMessage.Text == "" && TextChange == true)
            {
                TextChange = false;
            }
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //엔터 키를 누를때
            {
                e.Handled = true; //소리 없앰
                if (this.txtMessage.Text == "")
                {
                    this.txtMessage.Focus();
                }
                else
                {
                    Msg_send(); //Msg_send()함수 호출
                }
            }
        }

        private void Msg_send()
        {
            try
            {
                var dt = Convert.ToString(DateTime.Now);
                myWrite.WriteLine(this.myName + "&" + this.txtMessage.Text + "&" + dt);
                myWrite.Flush();
                MessageView(this.myName + ": " + this.txtMessage.Text);
                this.txtMessage.Clear();

            }
            catch
            {
                Invoke(AddText, "데이터를 보내는 동안 오류가 발생하였습니다.");
                this.txtMessage.Clear();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.txtMessage.Text == "")
            {
                this.txtMessage.Focus();
            }
            else
            {
                Msg_send(); //Msg_send()함수 호출
            }
        }
    }
}
