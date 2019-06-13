namespace mook_NMS
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnNetCheck = new System.Windows.Forms.Button();
            this.btnCMD = new System.Windows.Forms.Button();
            this.btnCPU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(80, 18);
            this.txtIp.Name = "txtIp";
            this.txtIp.ReadOnly = true;
            this.txtIp.Size = new System.Drawing.Size(119, 21);
            this.txtIp.TabIndex = 1;
            this.txtIp.TabStop = false;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(80, 57);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(119, 23);
            this.btnMessage.TabIndex = 2;
            this.btnMessage.Text = "메시지";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(124, 228);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(21, 21);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(53, 12);
            this.lblIp.TabIndex = 4;
            this.lblIp.Text = "아이피 : ";
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(80, 89);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(119, 23);
            this.btnPower.TabIndex = 1;
            this.btnPower.Text = "전원관리";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnNetCheck
            // 
            this.btnNetCheck.Location = new System.Drawing.Point(80, 121);
            this.btnNetCheck.Name = "btnNetCheck";
            this.btnNetCheck.Size = new System.Drawing.Size(119, 23);
            this.btnNetCheck.TabIndex = 6;
            this.btnNetCheck.Text = "네트워크 체크";
            this.btnNetCheck.UseVisualStyleBackColor = true;
            this.btnNetCheck.Click += new System.EventHandler(this.btnNetCheck_Click);
            // 
            // btnCMD
            // 
            this.btnCMD.Location = new System.Drawing.Point(80, 154);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(119, 23);
            this.btnCMD.TabIndex = 7;
            this.btnCMD.Text = "CMD";
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.btnCMD_Click);
            // 
            // btnCPU
            // 
            this.btnCPU.Location = new System.Drawing.Point(80, 188);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(119, 23);
            this.btnCPU.TabIndex = 8;
            this.btnCPU.Text = "CPU 모니터";
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 278);
            this.Controls.Add(this.btnCPU);
            this.Controls.Add(this.btnCMD);
            this.Controls.Add(this.btnNetCheck);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.txtIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "옵션 메뉴";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblIp;
        internal System.Windows.Forms.Button btnMessage;
        internal System.Windows.Forms.TextBox txtIp;
        internal System.Windows.Forms.Button btnPower;
        internal System.Windows.Forms.Button btnNetCheck;
        internal System.Windows.Forms.Button btnCMD;
        internal System.Windows.Forms.Button btnCPU;
    }
}