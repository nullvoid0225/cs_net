namespace mook_RemoteCPU
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
            this.lblCPU = new System.Windows.Forms.Label();
            this.CPUMonitor = new mook_RemoteCPUCore.mook_RemoteCPUCore();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConn
            // 
            this.btnConn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConn.Location = new System.Drawing.Point(295, 25);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(65, 22);
            this.btnConn.TabIndex = 104;
            this.btnConn.Text = "연결";
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // txtAgentIP
            // 
            this.txtAgentIP.Location = new System.Drawing.Point(168, 25);
            this.txtAgentIP.Name = "txtAgentIP";
            this.txtAgentIP.Size = new System.Drawing.Size(121, 21);
            this.txtAgentIP.TabIndex = 103;
            this.txtAgentIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAgent
            // 
            this.lblAgent.Location = new System.Drawing.Point(30, 25);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(132, 21);
            this.lblAgent.TabIndex = 105;
            this.lblAgent.Text = "에이전트 아이피 주소 :";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(30, 67);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(70, 12);
            this.lblCPU.TabIndex = 106;
            this.lblCPU.Text = "CPU 사용 : ";
            // 
            // CPUMonitor
            // 
            this.CPUMonitor.Location = new System.Drawing.Point(179, 67);
            this.CPUMonitor.Name = "CPUMonitor";
            this.CPUMonitor.Size = new System.Drawing.Size(556, 170);
            this.CPUMonitor.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(670, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 22);
            this.btnClose.TabIndex = 107;
            this.btnClose.Text = "종료";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 278);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.txtAgentIP);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.CPUMonitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CPU 모니터 관리자";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mook_RemoteCPUCore.mook_RemoteCPUCore CPUMonitor;
        internal System.Windows.Forms.Button btnConn;
        internal System.Windows.Forms.TextBox txtAgentIP;
        internal System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Label lblCPU;
        internal System.Windows.Forms.Button btnClose;
    }
}

