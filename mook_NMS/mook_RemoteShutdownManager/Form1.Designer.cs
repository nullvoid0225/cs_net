namespace mook_RemoteShutdownManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblManger = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbNothing = new System.Windows.Forms.RadioButton();
            this.rbLogOff = new System.Windows.Forms.RadioButton();
            this.rbReboot = new System.Windows.Forms.RadioButton();
            this.txtAgentIP = new System.Windows.Forms.TextBox();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.lblAgent = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblManagerIP = new System.Windows.Forms.Label();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.tsslblConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConn = new System.Windows.Forms.Button();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManger
            // 
            this.lblManger.Location = new System.Drawing.Point(20, 16);
            this.lblManger.Name = "lblManger";
            this.lblManger.Size = new System.Drawing.Size(132, 16);
            this.lblManger.TabIndex = 98;
            this.lblManger.Text = "관리자 아이피 주소 :";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(244, 98);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 21);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "종료";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbNothing
            // 
            this.rbNothing.Checked = true;
            this.rbNothing.Location = new System.Drawing.Point(141, 91);
            this.rbNothing.Name = "rbNothing";
            this.rbNothing.Size = new System.Drawing.Size(93, 22);
            this.rbNothing.TabIndex = 5;
            this.rbNothing.TabStop = true;
            this.rbNothing.Text = "Nothing";
            // 
            // rbLogOff
            // 
            this.rbLogOff.Location = new System.Drawing.Point(141, 69);
            this.rbLogOff.Name = "rbLogOff";
            this.rbLogOff.Size = new System.Drawing.Size(93, 22);
            this.rbLogOff.TabIndex = 3;
            this.rbLogOff.Text = "LogOff";
            // 
            // rbReboot
            // 
            this.rbReboot.Location = new System.Drawing.Point(20, 91);
            this.rbReboot.Name = "rbReboot";
            this.rbReboot.Size = new System.Drawing.Size(93, 22);
            this.rbReboot.TabIndex = 4;
            this.rbReboot.Text = "Reboot";
            // 
            // txtAgentIP
            // 
            this.txtAgentIP.Location = new System.Drawing.Point(158, 39);
            this.txtAgentIP.Name = "txtAgentIP";
            this.txtAgentIP.Size = new System.Drawing.Size(121, 21);
            this.txtAgentIP.TabIndex = 0;
            this.txtAgentIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbShutdown
            // 
            this.rbShutdown.Location = new System.Drawing.Point(20, 69);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(93, 22);
            this.rbShutdown.TabIndex = 2;
            this.rbShutdown.Text = "Shutdown";
            // 
            // lblAgent
            // 
            this.lblAgent.Location = new System.Drawing.Point(20, 39);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(132, 21);
            this.lblAgent.TabIndex = 92;
            this.lblAgent.Text = "에이전트 아이피 주소 :";
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRun.Location = new System.Drawing.Point(244, 69);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(106, 22);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "명령";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblManagerIP
            // 
            this.lblManagerIP.Location = new System.Drawing.Point(158, 16);
            this.lblManagerIP.Name = "lblManagerIP";
            this.lblManagerIP.Size = new System.Drawing.Size(121, 15);
            this.lblManagerIP.TabIndex = 99;
            this.lblManagerIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stsBar
            // 
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblConnect});
            this.stsBar.Location = new System.Drawing.Point(0, 137);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(362, 22);
            this.stsBar.TabIndex = 100;
            this.stsBar.Text = "statusStrip1";
            // 
            // tsslblConnect
            // 
            this.tsslblConnect.Name = "tsslblConnect";
            this.tsslblConnect.Size = new System.Drawing.Size(52, 17);
            this.tsslblConnect.Text = "연결중...";
            // 
            // btnConn
            // 
            this.btnConn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConn.Location = new System.Drawing.Point(285, 39);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(65, 22);
            this.btnConn.TabIndex = 1;
            this.btnConn.Text = "연결";
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 159);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.lblManger);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rbNothing);
            this.Controls.Add(this.rbLogOff);
            this.Controls.Add(this.rbReboot);
            this.Controls.Add(this.txtAgentIP);
            this.Controls.Add(this.rbShutdown);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblManagerIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NMS 전원제어 관리자";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblManger;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.RadioButton rbNothing;
        internal System.Windows.Forms.RadioButton rbLogOff;
        internal System.Windows.Forms.RadioButton rbReboot;
        internal System.Windows.Forms.TextBox txtAgentIP;
        internal System.Windows.Forms.RadioButton rbShutdown;
        internal System.Windows.Forms.Label lblAgent;
        internal System.Windows.Forms.Button btnRun;
        internal System.Windows.Forms.Label lblManagerIP;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblConnect;
        internal System.Windows.Forms.Button btnConn;
    }
}


