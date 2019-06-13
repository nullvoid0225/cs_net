namespace mook_RemoteCMD
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
            this.btnConn = new System.Windows.Forms.Button();
            this.txtAgentIP = new System.Windows.Forms.TextBox();
            this.lblAgent = new System.Windows.Forms.Label();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.tsslblConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtCMD = new System.Windows.Forms.TextBox();
            this.lblCMD = new System.Windows.Forms.Label();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConn
            // 
            this.btnConn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConn.Location = new System.Drawing.Point(291, 21);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(65, 22);
            this.btnConn.TabIndex = 101;
            this.btnConn.Text = "연결";
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // txtAgentIP
            // 
            this.txtAgentIP.Location = new System.Drawing.Point(164, 21);
            this.txtAgentIP.Name = "txtAgentIP";
            this.txtAgentIP.Size = new System.Drawing.Size(121, 21);
            this.txtAgentIP.TabIndex = 100;
            this.txtAgentIP.Text = "아이피";
            this.txtAgentIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAgent
            // 
            this.lblAgent.Location = new System.Drawing.Point(26, 21);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(132, 21);
            this.lblAgent.TabIndex = 102;
            this.lblAgent.Text = "에이전트 아이피 주소 :";
            // 
            // stsBar
            // 
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblConnect});
            this.stsBar.Location = new System.Drawing.Point(0, 132);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(379, 22);
            this.stsBar.TabIndex = 105;
            this.stsBar.Text = "statusStrip1";
            // 
            // tsslblConnect
            // 
            this.tsslblConnect.Name = "tsslblConnect";
            this.tsslblConnect.Size = new System.Drawing.Size(52, 17);
            this.tsslblConnect.Text = "연결중...";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(291, 91);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 21);
            this.btnExit.TabIndex = 107;
            this.btnExit.Text = "종료";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRun.Location = new System.Drawing.Point(291, 62);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(65, 22);
            this.btnRun.TabIndex = 106;
            this.btnRun.Text = "명령";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtCMD
            // 
            this.txtCMD.Location = new System.Drawing.Point(125, 63);
            this.txtCMD.Name = "txtCMD";
            this.txtCMD.Size = new System.Drawing.Size(160, 21);
            this.txtCMD.TabIndex = 108;
            // 
            // lblCMD
            // 
            this.lblCMD.AutoSize = true;
            this.lblCMD.Location = new System.Drawing.Point(26, 67);
            this.lblCMD.Name = "lblCMD";
            this.lblCMD.Size = new System.Drawing.Size(73, 12);
            this.lblCMD.TabIndex = 109;
            this.lblCMD.Text = "CMD 명령 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 154);
            this.Controls.Add(this.lblCMD);
            this.Controls.Add(this.txtCMD);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.txtAgentIP);
            this.Controls.Add(this.lblAgent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CMD 명령 관리자";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnConn;
        internal System.Windows.Forms.TextBox txtAgentIP;
        internal System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblConnect;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtCMD;
        private System.Windows.Forms.Label lblCMD;
    }
}

