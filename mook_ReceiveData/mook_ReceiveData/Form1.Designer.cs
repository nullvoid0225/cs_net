namespace mook_ReceiveData
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
            this.lblReceive01 = new System.Windows.Forms.Label();
            this.lblReceive02 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReceive01
            // 
            this.lblReceive01.AutoSize = true;
            this.lblReceive01.Location = new System.Drawing.Point(27, 58);
            this.lblReceive01.Name = "lblReceive01";
            this.lblReceive01.Size = new System.Drawing.Size(133, 12);
            this.lblReceive01.TabIndex = 0;
            this.lblReceive01.Text = "외부에서 받은 데이터 : ";
            // 
            // lblReceive02
            // 
            this.lblReceive02.AutoSize = true;
            this.lblReceive02.Location = new System.Drawing.Point(166, 58);
            this.lblReceive02.Name = "lblReceive02";
            this.lblReceive02.Size = new System.Drawing.Size(29, 12);
            this.lblReceive02.TabIndex = 1;
            this.lblReceive02.Text = "결과";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(250, 92);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "전달받기";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 146);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblReceive02);
            this.Controls.Add(this.lblReceive01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "외부 데이터 받기(Without Thread)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceive01;
        private System.Windows.Forms.Label lblReceive02;
        private System.Windows.Forms.Button btnReceive;
    }
}

