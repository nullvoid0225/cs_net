namespace mook_NMS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnPC = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSVF = new System.Windows.Forms.ToolStripButton();
            this.tsbtnR = new System.Windows.Forms.ToolStripButton();
            this.tsbtnS = new System.Windows.Forms.ToolStripButton();
            this.tsbtnD = new System.Windows.Forms.ToolStripButton();
            this.tsbtnW = new System.Windows.Forms.ToolStripButton();
            this.plMap = new System.Windows.Forms.Panel();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.tsslblItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.ImgListError = new System.Windows.Forms.ImageList(this.components);
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.btnItemConfig = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.gbMonitor = new System.Windows.Forms.GroupBox();
            this.plGB = new System.Windows.Forms.Panel();
            this.rbSoundOn = new System.Windows.Forms.RadioButton();
            this.rbSoundOff = new System.Windows.Forms.RadioButton();
            this.plGA = new System.Windows.Forms.Panel();
            this.rbLogOn = new System.Windows.Forms.RadioButton();
            this.rbLogOff = new System.Windows.Forms.RadioButton();
            this.btnMonitorConfig = new System.Windows.Forms.Button();
            this.cbInterval = new System.Windows.Forms.ComboBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.ImgListNormal = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.tsMenu.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.gbItem.SuspendLayout();
            this.gbMonitor.SuspendLayout();
            this.plGB.SuspendLayout();
            this.plGA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPC,
            this.tsbtnSVF,
            this.tsbtnR,
            this.tsbtnS,
            this.tsbtnD,
            this.tsbtnW});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1043, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMenu_ItemClicked);
            // 
            // tsbtnPC
            // 
            this.tsbtnPC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPC.Image = global::mook_NMS.Properties.Resources.pc1;
            this.tsbtnPC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPC.Name = "tsbtnPC";
            this.tsbtnPC.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPC.Tag = "0";
            this.tsbtnPC.Text = "tsbtnPC";
            this.tsbtnPC.ToolTipText = "UserPC";
            // 
            // tsbtnSVF
            // 
            this.tsbtnSVF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSVF.Image = global::mook_NMS.Properties.Resources.file1;
            this.tsbtnSVF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSVF.Name = "tsbtnSVF";
            this.tsbtnSVF.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSVF.Tag = "1";
            this.tsbtnSVF.Text = "tsbtnSVF";
            this.tsbtnSVF.ToolTipText = "FileServer";
            // 
            // tsbtnR
            // 
            this.tsbtnR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnR.Image = global::mook_NMS.Properties.Resources.router1;
            this.tsbtnR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnR.Name = "tsbtnR";
            this.tsbtnR.Size = new System.Drawing.Size(23, 22);
            this.tsbtnR.Tag = "2";
            this.tsbtnR.Text = "tsbtnR";
            this.tsbtnR.ToolTipText = "Router";
            // 
            // tsbtnS
            // 
            this.tsbtnS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnS.Image = global::mook_NMS.Properties.Resources.sw2;
            this.tsbtnS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnS.Name = "tsbtnS";
            this.tsbtnS.Size = new System.Drawing.Size(23, 22);
            this.tsbtnS.Tag = "3";
            this.tsbtnS.Text = "tsbtnS";
            this.tsbtnS.ToolTipText = "Switch";
            // 
            // tsbtnD
            // 
            this.tsbtnD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnD.Image = global::mook_NMS.Properties.Resources.db1;
            this.tsbtnD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnD.Name = "tsbtnD";
            this.tsbtnD.Size = new System.Drawing.Size(23, 22);
            this.tsbtnD.Tag = "4";
            this.tsbtnD.Text = "tsbtnD";
            this.tsbtnD.ToolTipText = "DBServer";
            // 
            // tsbtnW
            // 
            this.tsbtnW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnW.Image = global::mook_NMS.Properties.Resources.sv1;
            this.tsbtnW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnW.Name = "tsbtnW";
            this.tsbtnW.Size = new System.Drawing.Size(23, 22);
            this.tsbtnW.Tag = "5";
            this.tsbtnW.Text = "tsbtnW";
            this.tsbtnW.ToolTipText = "WorkStation";
            // 
            // plMap
            // 
            this.plMap.BackColor = System.Drawing.Color.White;
            this.plMap.Location = new System.Drawing.Point(12, 28);
            this.plMap.Name = "plMap";
            this.plMap.Size = new System.Drawing.Size(760, 421);
            this.plMap.TabIndex = 1;
            // 
            // stsBar
            // 
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblItem});
            this.stsBar.Location = new System.Drawing.Point(0, 473);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(1043, 22);
            this.stsBar.TabIndex = 2;
            this.stsBar.Text = "statusStrip1";
            // 
            // tsslblItem
            // 
            this.tsslblItem.Name = "tsslblItem";
            this.tsslblItem.Size = new System.Drawing.Size(42, 17);
            this.tsslblItem.Text = "결과 : ";
            // 
            // ImgListError
            // 
            this.ImgListError.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListError.ImageStream")));
            this.ImgListError.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListError.Images.SetKeyName(0, "pc1_error.jpg");
            this.ImgListError.Images.SetKeyName(1, "file1_error.jpg");
            this.ImgListError.Images.SetKeyName(2, "router1_error.jpg");
            this.ImgListError.Images.SetKeyName(3, "sw2_error.jpg");
            this.ImgListError.Images.SetKeyName(4, "db1_error.jpg");
            this.ImgListError.Images.SetKeyName(5, "sv1_error.jpg");
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.btnItemConfig);
            this.gbItem.Controls.Add(this.txtIp);
            this.gbItem.Controls.Add(this.lblIp);
            this.gbItem.Controls.Add(this.txtName);
            this.gbItem.Controls.Add(this.lblName);
            this.gbItem.Controls.Add(this.txtId);
            this.gbItem.Controls.Add(this.lblId);
            this.gbItem.Location = new System.Drawing.Point(788, 28);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(243, 138);
            this.gbItem.TabIndex = 3;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "아이템 설정";
            // 
            // btnItemConfig
            // 
            this.btnItemConfig.Location = new System.Drawing.Point(151, 101);
            this.btnItemConfig.Name = "btnItemConfig";
            this.btnItemConfig.Size = new System.Drawing.Size(75, 23);
            this.btnItemConfig.TabIndex = 6;
            this.btnItemConfig.Text = "적용";
            this.btnItemConfig.UseVisualStyleBackColor = true;
            this.btnItemConfig.Click += new System.EventHandler(this.btnItemConfig_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(67, 74);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(159, 21);
            this.txtIp.TabIndex = 5;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(17, 77);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(49, 12);
            this.lblIp.TabIndex = 4;
            this.lblIp.Text = "아이피 :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "이름 :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(67, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(49, 12);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "아이디 :";
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // gbMonitor
            // 
            this.gbMonitor.Controls.Add(this.plGB);
            this.gbMonitor.Controls.Add(this.plGA);
            this.gbMonitor.Controls.Add(this.btnMonitorConfig);
            this.gbMonitor.Controls.Add(this.cbInterval);
            this.gbMonitor.Controls.Add(this.lblInterval);
            this.gbMonitor.Location = new System.Drawing.Point(788, 184);
            this.gbMonitor.Name = "gbMonitor";
            this.gbMonitor.Size = new System.Drawing.Size(243, 175);
            this.gbMonitor.TabIndex = 4;
            this.gbMonitor.TabStop = false;
            this.gbMonitor.Text = "모니터 설정";
            // 
            // plGB
            // 
            this.plGB.Controls.Add(this.rbSoundOn);
            this.plGB.Controls.Add(this.rbSoundOff);
            this.plGB.Location = new System.Drawing.Point(19, 61);
            this.plGB.Name = "plGB";
            this.plGB.Size = new System.Drawing.Size(207, 34);
            this.plGB.TabIndex = 9;
            // 
            // rbSoundOn
            // 
            this.rbSoundOn.AutoSize = true;
            this.rbSoundOn.Checked = true;
            this.rbSoundOn.Location = new System.Drawing.Point(19, 11);
            this.rbSoundOn.Name = "rbSoundOn";
            this.rbSoundOn.Size = new System.Drawing.Size(79, 16);
            this.rbSoundOn.TabIndex = 4;
            this.rbSoundOn.TabStop = true;
            this.rbSoundOn.Text = "Sound On";
            this.rbSoundOn.UseVisualStyleBackColor = true;
            // 
            // rbSoundOff
            // 
            this.rbSoundOff.AutoSize = true;
            this.rbSoundOff.Location = new System.Drawing.Point(113, 11);
            this.rbSoundOff.Name = "rbSoundOff";
            this.rbSoundOff.Size = new System.Drawing.Size(78, 16);
            this.rbSoundOff.TabIndex = 5;
            this.rbSoundOff.Text = "Sound Off";
            this.rbSoundOff.UseVisualStyleBackColor = true;
            // 
            // plGA
            // 
            this.plGA.Controls.Add(this.rbLogOn);
            this.plGA.Controls.Add(this.rbLogOff);
            this.plGA.Location = new System.Drawing.Point(19, 25);
            this.plGA.Name = "plGA";
            this.plGA.Size = new System.Drawing.Size(207, 34);
            this.plGA.TabIndex = 8;
            // 
            // rbLogOn
            // 
            this.rbLogOn.AutoSize = true;
            this.rbLogOn.Checked = true;
            this.rbLogOn.Location = new System.Drawing.Point(19, 9);
            this.rbLogOn.Name = "rbLogOn";
            this.rbLogOn.Size = new System.Drawing.Size(64, 16);
            this.rbLogOn.TabIndex = 0;
            this.rbLogOn.TabStop = true;
            this.rbLogOn.Text = "Log On";
            this.rbLogOn.UseVisualStyleBackColor = true;
            // 
            // rbLogOff
            // 
            this.rbLogOff.AutoSize = true;
            this.rbLogOff.Location = new System.Drawing.Point(113, 9);
            this.rbLogOff.Name = "rbLogOff";
            this.rbLogOff.Size = new System.Drawing.Size(63, 16);
            this.rbLogOff.TabIndex = 1;
            this.rbLogOff.Text = "Log Off";
            this.rbLogOff.UseVisualStyleBackColor = true;
            // 
            // btnMonitorConfig
            // 
            this.btnMonitorConfig.Location = new System.Drawing.Point(151, 138);
            this.btnMonitorConfig.Name = "btnMonitorConfig";
            this.btnMonitorConfig.Size = new System.Drawing.Size(75, 23);
            this.btnMonitorConfig.TabIndex = 7;
            this.btnMonitorConfig.Text = "적용";
            this.btnMonitorConfig.UseVisualStyleBackColor = true;
            this.btnMonitorConfig.Click += new System.EventHandler(this.btnMonitorConfig_Click);
            // 
            // cbInterval
            // 
            this.cbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Items.AddRange(new object[] {
            "30 초",
            "60 초",
            "2 분",
            "5 분"});
            this.cbInterval.Location = new System.Drawing.Point(85, 105);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(110, 20);
            this.cbInterval.TabIndex = 3;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(38, 108);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(41, 12);
            this.lblInterval.TabIndex = 2;
            this.lblInterval.Text = "주기 : ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(788, 383);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 66);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "NMS 시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ImgListNormal
            // 
            this.ImgListNormal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListNormal.ImageStream")));
            this.ImgListNormal.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListNormal.Images.SetKeyName(0, "pc1.jpg");
            this.ImgListNormal.Images.SetKeyName(1, "file1.jpg");
            this.ImgListNormal.Images.SetKeyName(2, "router1.jpg");
            this.ImgListNormal.Images.SetKeyName(3, "sw2.jpg");
            this.ImgListNormal.Images.SetKeyName(4, "db1.jpg");
            this.ImgListNormal.Images.SetKeyName(5, "sv1.jpg");
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(918, 383);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 66);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "NMS 정지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 495);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbMonitor);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.plMap);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Network Monitor System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.gbMonitor.ResumeLayout(false);
            this.gbMonitor.PerformLayout();
            this.plGB.ResumeLayout(false);
            this.plGB.PerformLayout();
            this.plGA.ResumeLayout(false);
            this.plGA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.Panel plMap;
        private System.Windows.Forms.ToolStripButton tsbtnPC;
        private System.Windows.Forms.ToolStripButton tsbtnSVF;
        private System.Windows.Forms.ToolStripButton tsbtnR;
        private System.Windows.Forms.ToolStripButton tsbtnS;
        private System.Windows.Forms.ToolStripButton tsbtnD;
        private System.Windows.Forms.ToolStripButton tsbtnW;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslblItem;
        private System.Windows.Forms.ImageList ImgListError;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.Button btnItemConfig;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox gbMonitor;
        private System.Windows.Forms.ComboBox cbInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.RadioButton rbLogOff;
        private System.Windows.Forms.RadioButton rbLogOn;
        private System.Windows.Forms.Button btnMonitorConfig;
        private System.Windows.Forms.RadioButton rbSoundOff;
        private System.Windows.Forms.RadioButton rbSoundOn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel plGA;
        private System.Windows.Forms.Panel plGB;
        private System.Windows.Forms.ImageList ImgListNormal;
        private System.Windows.Forms.Button btnStop;
    }
}


