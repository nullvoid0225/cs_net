using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Threading;
using System.Data.OleDb;

namespace mook_NMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox frmPic = null; //Item 관리를 위한 개체
        bool Dragging = false; //드래그 여부
        int mouseX, mouseY; //마우스 포인터 좌표
        int ItemNum = 0;

        List<string> IPList = new List<string>(); //IP 관리

        int MonitorConfA = 0; //Log 관리
        int MonitorConfB = 0; //Sound 관리

        string ConSql = ""; // MS ACCESS 연결문

        private void tsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.tsMenu.Items.Count > 0)
            {
                PictureBox myPicBox = new PictureBox();
                myPicBox.MouseDown += new MouseEventHandler(MyMouseClick);
                myPicBox.MouseMove += new MouseEventHandler(MyMouseMove);
                myPicBox.MouseUp += new MouseEventHandler(MyMouseUp);
                myPicBox.MouseDoubleClick += new MouseEventHandler(MyMouseDoubleClick);

                this.plMap.Controls.Add(myPicBox);
                myPicBox.Location = new Point(plMap.Location.X, plMap.Location.Y);
                myPicBox.BringToFront();
                myPicBox.BackgroundImageLayout = ImageLayout.Stretch;

                int tagId = Convert.ToInt32(e.ClickedItem.Tag);
                myPicBox.BackgroundImage = tsMenu.Items[tagId].Image;
                myPicBox.Name = tsMenu.Items[tagId].ToolTipText;
                myPicBox.Tag = ItemNum.ToString() + "_" + tagId.ToString();
                //myPicBox.Size = new System.Drawing.Size(80, 60);
                myPicBox.Size = new System.Drawing.Size(160, 120);
                myPicBox.Invalidate();
                IPList.Add("0.0.0.0");
                ItemNum++;
            }
        }
        private void MyMouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (e.Button == MouseButtons.Right)
            {
                int X = pic.Location.X + pic.Width + 50 + Location.X;
                int Y = pic.Location.Y + Location.Y;

                Form2 frm2 = new Form2();
                frm2.ItemIp = IPList[Convert.ToInt32(pic.Tag.ToString().Split('_')[0])];
                frm2.Itemxy = new Point(X, Y);
                frmPic = pic;
                frm2.ShowDialog();
            }
            else if (e.Button == MouseButtons.Left)
            {
                pic.Cursor = Cursors.Hand;
                Dragging = true;
                mouseX = -e.X;
                mouseY = -e.Y;
                int clipleft = this.plMap.PointToClient(MousePosition).X
                    - pic.Location.X;
                int cliptop = this.plMap.PointToClient(MousePosition).Y
                    - pic.Location.Y;
                int clipwidth = this.plMap.ClientSize.Width -
                    (pic.Width - clipleft);
                int clipheight = this.plMap.ClientSize.Height -
                    (pic.Height - cliptop);
                Cursor.Clip = this.plMap.RectangleToScreen(new Rectangle
                    (clipleft, cliptop, clipwidth, clipheight));
                pic.Invalidate();
            }
        }

        private void MyMouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Dragging = false;
            Cursor.Clip = Rectangle.Empty;
            this.tsslblItem.Text = "아이디 : " + pic.Tag.ToString() + " 이름 : " + pic.Name.ToString();

            this.txtId.Text = pic.Tag.ToString();
            this.txtName.Text = pic.Name;
            this.txtIp.Text = IPList[Convert.ToInt32(pic.Tag.ToString().Split('_')[0])];
        }

        private void MyMouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (Dragging)
            {
                Point MPostion = new Point();
                MPostion = this.plMap.PointToClient(MousePosition);
                MPostion.Offset(mouseX, mouseY);
                pic.Location = MPostion;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("MonitorConfig.ini") == false)
                this.cbInterval.Text = "30 초";
            else
            {
                StreamReader sr = new StreamReader("MonitorConfig.ini");
                for(int i = 0; i < 3; i++)
                {
                    string str = sr.ReadLine();
                    if (i == 0)
                        if (str.Split(':')[1] == "0") rbLogOn.Checked = true; else rbLogOff.Checked = true;
                    else if (i == 1)
                        if (str.Split(':')[1] == "0") rbSoundOn.Checked = true; else rbSoundOff.Checked = true;
                    else if (i == 2)
                        this.cbInterval.Text = str.Split(':')[1];
                }
                sr.Close();

                if (this.rbLogOn.Checked == true)
                    MonitorConfA = 0;
                else if (this.rbLogOff.Checked == true)
                    MonitorConfA = 1;

                if (this.rbSoundOn.Checked == true)
                    MonitorConfB = 0;
                else if (this.rbLogOff.Checked == true)
                    MonitorConfB = 1;
            }
            string DbPath = Application.StartupPath;
            ConSql = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DbPath + @"\NMS.accdb;Mode=ReadWrite";
        }

        private void btnItemConfig_Click(object sender, EventArgs e)
        {
            if(this.txtId.Text == "")
            {
                MessageBox.Show("수정할 아이템을 먼저 더블 클릭하세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.txtName.Text == "")
                {
                    MessageBox.Show("이름을 입력하세요", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtName.Focus();
                    return;
                }
                if (this.txtIp.Text == "")
                {
                    MessageBox.Show("아이피를 입력하세요", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtIp.Focus();
                    return;
                }
                if (IPList.Contains(this.txtIp.Text) == true)
                {
                    MessageBox.Show("동일한 아이피가 존재합니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtIp.Focus();
                    return;
                }
                var dlg = MessageBox.Show("적용하시겠습니까?", "알림",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    int n = Convert.ToInt32(this.txtId.Text.Split('_')[0]);
                    this.plMap.Controls[(this.plMap.Controls.Count - 1) - 
                        Convert.ToInt32(this.txtId.Text.Split('_')[0])].Name = this.txtName.Text;
                    IPList[n] = this.txtIp.Text;
                    MessageBox.Show("적용되었습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtIp.Text = "";
                    this.txtId.Text = "";
                    this.txtName.Text = "";
                }
            }
        }

        private void btnMonitorConfig_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("적용하겠습니까?", "알림", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                if (this.rbLogOn.Checked == true)
                    MonitorConfA = 0;
                else if (this.rbLogOff.Checked == true)
                    MonitorConfA = 1;

                if (this.rbSoundOn.Checked == true)
                    MonitorConfB = 0;
                else if (this.rbLogOff.Checked == true)
                    MonitorConfB = 1;

                if (this.cbInterval.Text.Split(' ')[0] == "30")
                    this.Timer.Interval = 30000;
                else if (this.cbInterval.Text.Split(' ')[0] == "60")
                    this.Timer.Interval = 60000;
                else if (this.cbInterval.Text.Split(' ')[0] == "2")
                    this.Timer.Interval = 120000;
                else if (this.cbInterval.Text.Split(' ')[0] == "5")
                    this.Timer.Interval = 300000;

                StreamWriter sw = new StreamWriter("MonitorConfig.ini");
                sw.WriteLine("[Log Config]:" + MonitorConfA.ToString());
                sw.WriteLine("[Sound Config]:" + MonitorConfB.ToString());
                sw.WriteLine("[Interval Config]:" + this.cbInterval.Text);
                sw.Close();
                MessageBox.Show("적용되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NetworkCheck ntc = new NetworkCheck();
            ntc.OnError += new NetworkCheck.ErrorEventHandler(ItemChange);
            ntc.LogConf = MonitorConfA;
            ntc.SoundConf = MonitorConfB;
            ntc.NetCheckRun();
        }

        private void ItemChange(int i, int n, bool f)
        {
            if (f == false)
                this.plMap.Controls[(this.plMap.Controls.Count - 1) - i].BackgroundImage 
                    = (Bitmap)ImgListError.Images[n];
            else
                this.plMap.Controls[(this.plMap.Controls.Count - 1) - i].BackgroundImage
                    = (Bitmap)ImgListNormal.Images[n];
        }

        private void ItemSave()
        {
            var Conn = new OleDbConnection(ConSql);
            Conn.Open();

            string Sql = "Delete from ItemManage";
            var Comm = new OleDbCommand(Sql, Conn);
            Comm.ExecuteNonQuery();

            int p = 0;
            for (int n = this.plMap.Controls.Count -1; n >= 0; n--)
            {
                Sql = "Insert into ItemManage(N_ItemID, N_ItemName, N_ItemIp)";
                Sql += "values('" + this.plMap.Controls[n].Tag.ToString() + "', '" +
                    this.plMap.Controls[n].Name + "', '" + IPList[p] + "')";
                var iComm = new OleDbCommand(Sql, Conn);
                iComm.ExecuteNonQuery();
                p++;
            }

            Conn.Close();
            for(int k=0;k<this.Controls.Count;k++)
            {
                this.Controls[k].Enabled = false;
            }

            if (this.cbInterval.Text.Split(' ')[0] == "30")
                this.Timer.Interval = 30000;
            else if (this.cbInterval.Text.Split(' ')[0] == "60")
                this.Timer.Interval = 60000;
            else if (this.cbInterval.Text.Split(' ')[0] == "2")
                this.Timer.Interval = 120000;
            else if (this.cbInterval.Text.Split(' ')[0] == "5")
                this.Timer.Interval = 300000;

            this.Timer.Enabled = true;
            this.btnStop.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.plMap.Controls.Count == 0)
            {
                MessageBox.Show("저장할 아이템이 없습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IPList.Contains("0.0.0.0") == true)
            {
                MessageBox.Show("IP 정보를 수정하세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ItemSave();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < this.Controls.Count; k++)
            {
                this.Controls[k].Enabled = Enabled;
            }
            this.Timer.Enabled = false;
            this.btnStop.Enabled = false;
        }

        private void MyMouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (Dragging)
            {
                Dragging = false;
                Cursor.Clip = Rectangle.Empty;
                pic.Invalidate();
            }
            pic.Cursor = Cursors.Arrow;
        }
    }
}
