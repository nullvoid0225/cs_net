namespace mook_RemoteMessage
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
            this.plGroup = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.plMessage = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tsBar = new System.Windows.Forms.ToolStrip();
            this.tsbtnConn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDisconn = new System.Windows.Forms.ToolStripButton();
            this.tlstxtIp = new System.Windows.Forms.ToolStripTextBox();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.plGroup.SuspendLayout();
            this.plMessage.SuspendLayout();
            this.tsBar.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.RoyalBlue;
            this.plGroup.Controls.Add(this.btnSend);
            this.plGroup.Controls.Add(this.plMessage);
            this.plGroup.Location = new System.Drawing.Point(0, 268);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(292, 53);
            this.plGroup.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Enabled = false;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(222, 10);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(65, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // plMessage
            // 
            this.plMessage.BackColor = System.Drawing.Color.White;
            this.plMessage.Controls.Add(this.txtMessage);
            this.plMessage.Location = new System.Drawing.Point(6, 10);
            this.plMessage.Name = "plMessage";
            this.plMessage.Size = new System.Drawing.Size(210, 35);
            this.plMessage.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(5, 10);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(201, 14);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.Color.White;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.Location = new System.Drawing.Point(0, 28);
            this.rtbText.Name = "rtbText";
            this.rtbText.ReadOnly = true;
            this.rtbText.Size = new System.Drawing.Size(292, 238);
            this.rtbText.TabIndex = 13;
            this.rtbText.TabStop = false;
            this.rtbText.Text = "";
            // 
            // tsBar
            // 
            this.tsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnConn,
            this.tsbtnDisconn,
            this.tlstxtIp});
            this.tsBar.Location = new System.Drawing.Point(0, 0);
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(294, 25);
            this.tsBar.TabIndex = 12;
            this.tsBar.Text = "ToolStrip1";
            // 
            // tsbtnConn
            // 
            this.tsbtnConn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConn.Image = global::mook_RemoteMessage.Properties.Resources.connection;
            this.tsbtnConn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConn.Name = "tsbtnConn";
            this.tsbtnConn.Size = new System.Drawing.Size(23, 22);
            this.tsbtnConn.Text = "연결";
            this.tsbtnConn.Click += new System.EventHandler(this.tsbtnConn_Click);
            // 
            // tsbtnDisconn
            // 
            this.tsbtnDisconn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDisconn.Enabled = false;
            this.tsbtnDisconn.Image = global::mook_RemoteMessage.Properties.Resources.disconnection;
            this.tsbtnDisconn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDisconn.Name = "tsbtnDisconn";
            this.tsbtnDisconn.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDisconn.Text = "끊기";
            this.tsbtnDisconn.ToolTipText = "끊기";
            this.tsbtnDisconn.Click += new System.EventHandler(this.tsbtnDisconn_Click);
            // 
            // tlstxtIp
            // 
            this.tlstxtIp.Name = "tlstxtIp";
            this.tlstxtIp.Size = new System.Drawing.Size(100, 25);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblTime});
            this.ssBar.Location = new System.Drawing.Point(0, 325);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(294, 22);
            this.ssBar.TabIndex = 11;
            this.ssBar.Text = "StatusStrip1";
            // 
            // tsslblTime
            // 
            this.tsslblTime.Name = "tsslblTime";
            this.tsslblTime.Size = new System.Drawing.Size(127, 17);
            this.tsslblTime.Text = "메시지 받은 시간 출력";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 347);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tsBar);
            this.Controls.Add(this.ssBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "1:1 채팅 관리자";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.plGroup.ResumeLayout(false);
            this.plMessage.ResumeLayout(false);
            this.plMessage.PerformLayout();
            this.tsBar.ResumeLayout(false);
            this.tsBar.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ToolStripButton tsbtnConn;
        internal System.Windows.Forms.ToolStripButton tsbtnDisconn;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel plMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStrip tsBar;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTime;
        private System.Windows.Forms.ToolStripTextBox tlstxtIp;
    }
}



