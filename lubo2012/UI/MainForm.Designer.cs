namespace lubo2012.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.plStudent = new System.Windows.Forms.Panel();
            this.plTeacher = new System.Windows.Forms.Panel();
            this.plTitlebar = new System.Windows.Forms.Panel();
            this.btnMin = new DMSkin.Controls.DMButtonMinLight();
            this.btnClose = new DMSkin.Controls.DMButtonCloseLight();
            this.plPreview = new System.Windows.Forms.Panel();
            this.plSetting = new System.Windows.Forms.Panel();
            this.btnSettingCancel = new System.Windows.Forms.Button();
            this.btnSettingSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sbStuAudioInput = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.sbTeaAudioInput = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.sbScrAudioInput = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.sbRecordStu = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.sbRecordTea = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sbRecordScreen = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCloseSetting = new DMSkin.Controls.DMButtonCloseLight();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plTools = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbRecordTime = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRecordControl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plBar = new System.Windows.Forms.Panel();
            this.plVideoTab = new System.Windows.Forms.Panel();
            this.plRecordTab = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plTitlebar.SuspendLayout();
            this.plPreview.SuspendLayout();
            this.plSetting.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.plTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // plStudent
            // 
            this.plStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.plStudent.Location = new System.Drawing.Point(36, 169);
            this.plStudent.Name = "plStudent";
            this.plStudent.Size = new System.Drawing.Size(460, 259);
            this.plStudent.TabIndex = 0;
            // 
            // plTeacher
            // 
            this.plTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.plTeacher.Location = new System.Drawing.Point(529, 169);
            this.plTeacher.Name = "plTeacher";
            this.plTeacher.Size = new System.Drawing.Size(460, 259);
            this.plTeacher.TabIndex = 1;
            // 
            // plTitlebar
            // 
            this.plTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.plTitlebar.Controls.Add(this.btnMin);
            this.plTitlebar.Controls.Add(this.btnClose);
            this.plTitlebar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plTitlebar.Location = new System.Drawing.Point(0, 678);
            this.plTitlebar.Name = "plTitlebar";
            this.plTitlebar.Size = new System.Drawing.Size(1024, 40);
            this.plTitlebar.TabIndex = 2;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Location = new System.Drawing.Point(957, 11);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 27);
            this.btnMin.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(993, 11);
            this.btnClose.MaximumSize = new System.Drawing.Size(30, 27);
            this.btnClose.MinimumSize = new System.Drawing.Size(30, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // plPreview
            // 
            this.plPreview.Controls.Add(this.plSetting);
            this.plPreview.Controls.Add(this.label2);
            this.plPreview.Controls.Add(this.label1);
            this.plPreview.Controls.Add(this.plStudent);
            this.plPreview.Controls.Add(this.plTeacher);
            this.plPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPreview.Location = new System.Drawing.Point(0, 0);
            this.plPreview.Name = "plPreview";
            this.plPreview.Size = new System.Drawing.Size(1024, 593);
            this.plPreview.TabIndex = 3;
            // 
            // plSetting
            // 
            this.plSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSetting.Controls.Add(this.btnSettingCancel);
            this.plSetting.Controls.Add(this.btnSettingSave);
            this.plSetting.Controls.Add(this.label8);
            this.plSetting.Controls.Add(this.label7);
            this.plSetting.Controls.Add(this.sbStuAudioInput);
            this.plSetting.Controls.Add(this.sbTeaAudioInput);
            this.plSetting.Controls.Add(this.sbScrAudioInput);
            this.plSetting.Controls.Add(this.sbRecordStu);
            this.plSetting.Controls.Add(this.sbRecordTea);
            this.plSetting.Controls.Add(this.label4);
            this.plSetting.Controls.Add(this.label5);
            this.plSetting.Controls.Add(this.label6);
            this.plSetting.Controls.Add(this.label3);
            this.plSetting.Controls.Add(this.label10);
            this.plSetting.Controls.Add(this.label11);
            this.plSetting.Controls.Add(this.sbRecordScreen);
            this.plSetting.Controls.Add(this.panel9);
            this.plSetting.Location = new System.Drawing.Point(212, 98);
            this.plSetting.Name = "plSetting";
            this.plSetting.Size = new System.Drawing.Size(600, 400);
            this.plSetting.TabIndex = 4;
            this.plSetting.Visible = false;
            // 
            // btnSettingCancel
            // 
            this.btnSettingCancel.BackgroundImage = global::lubo2012.Properties.Resources.取消_默认;
            this.btnSettingCancel.FlatAppearance.BorderSize = 0;
            this.btnSettingCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnSettingCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnSettingCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnSettingCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingCancel.Location = new System.Drawing.Point(508, 352);
            this.btnSettingCancel.Name = "btnSettingCancel";
            this.btnSettingCancel.Size = new System.Drawing.Size(70, 28);
            this.btnSettingCancel.TabIndex = 32;
            this.btnSettingCancel.UseVisualStyleBackColor = true;
            this.btnSettingCancel.Click += new System.EventHandler(this.btnSettingCancel_Click);
            // 
            // btnSettingSave
            // 
            this.btnSettingSave.BackgroundImage = global::lubo2012.Properties.Resources.保存_默认;
            this.btnSettingSave.FlatAppearance.BorderSize = 0;
            this.btnSettingSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnSettingSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnSettingSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnSettingSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingSave.Location = new System.Drawing.Point(429, 352);
            this.btnSettingSave.Name = "btnSettingSave";
            this.btnSettingSave.Size = new System.Drawing.Size(70, 28);
            this.btnSettingSave.TabIndex = 31;
            this.btnSettingSave.UseVisualStyleBackColor = true;
            this.btnSettingSave.Click += new System.EventHandler(this.btnSettingSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(230, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(145, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "软件版本：";
            // 
            // sbStuAudioInput
            // 
            // 
            // 
            // 
            this.sbStuAudioInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbStuAudioInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.sbStuAudioInput.Location = new System.Drawing.Point(418, 214);
            this.sbStuAudioInput.Name = "sbStuAudioInput";
            this.sbStuAudioInput.OffBackColor = System.Drawing.Color.Black;
            this.sbStuAudioInput.OffTextColor = System.Drawing.Color.Gray;
            this.sbStuAudioInput.OnBackColor = System.Drawing.Color.DarkGreen;
            this.sbStuAudioInput.OnTextColor = System.Drawing.Color.White;
            this.sbStuAudioInput.Size = new System.Drawing.Size(66, 22);
            this.sbStuAudioInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sbStuAudioInput.SwitchBackColor = System.Drawing.SystemColors.WindowFrame;
            this.sbStuAudioInput.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sbStuAudioInput.TabIndex = 28;
            // 
            // sbTeaAudioInput
            // 
            // 
            // 
            // 
            this.sbTeaAudioInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbTeaAudioInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.sbTeaAudioInput.Location = new System.Drawing.Point(418, 166);
            this.sbTeaAudioInput.Name = "sbTeaAudioInput";
            this.sbTeaAudioInput.OffBackColor = System.Drawing.Color.Black;
            this.sbTeaAudioInput.OffTextColor = System.Drawing.Color.Gray;
            this.sbTeaAudioInput.OnBackColor = System.Drawing.Color.DarkGreen;
            this.sbTeaAudioInput.OnTextColor = System.Drawing.Color.White;
            this.sbTeaAudioInput.Size = new System.Drawing.Size(66, 22);
            this.sbTeaAudioInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sbTeaAudioInput.SwitchBackColor = System.Drawing.SystemColors.WindowFrame;
            this.sbTeaAudioInput.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sbTeaAudioInput.TabIndex = 27;
            // 
            // sbScrAudioInput
            // 
            // 
            // 
            // 
            this.sbScrAudioInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbScrAudioInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.sbScrAudioInput.Location = new System.Drawing.Point(418, 118);
            this.sbScrAudioInput.Name = "sbScrAudioInput";
            this.sbScrAudioInput.OffBackColor = System.Drawing.Color.Black;
            this.sbScrAudioInput.OffTextColor = System.Drawing.Color.Gray;
            this.sbScrAudioInput.OnBackColor = System.Drawing.Color.DarkGreen;
            this.sbScrAudioInput.OnTextColor = System.Drawing.Color.White;
            this.sbScrAudioInput.Size = new System.Drawing.Size(66, 22);
            this.sbScrAudioInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sbScrAudioInput.SwitchBackColor = System.Drawing.SystemColors.WindowFrame;
            this.sbScrAudioInput.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sbScrAudioInput.TabIndex = 26;
            // 
            // sbRecordStu
            // 
            // 
            // 
            // 
            this.sbRecordStu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbRecordStu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.sbRecordStu.Location = new System.Drawing.Point(229, 214);
            this.sbRecordStu.Name = "sbRecordStu";
            this.sbRecordStu.OffBackColor = System.Drawing.Color.Black;
            this.sbRecordStu.OffTextColor = System.Drawing.Color.Gray;
            this.sbRecordStu.OnBackColor = System.Drawing.Color.DarkGreen;
            this.sbRecordStu.OnTextColor = System.Drawing.Color.White;
            this.sbRecordStu.Size = new System.Drawing.Size(66, 22);
            this.sbRecordStu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sbRecordStu.SwitchBackColor = System.Drawing.SystemColors.WindowFrame;
            this.sbRecordStu.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sbRecordStu.TabIndex = 25;
            // 
            // sbRecordTea
            // 
            // 
            // 
            // 
            this.sbRecordTea.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbRecordTea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.sbRecordTea.Location = new System.Drawing.Point(229, 166);
            this.sbRecordTea.Name = "sbRecordTea";
            this.sbRecordTea.OffBackColor = System.Drawing.Color.Black;
            this.sbRecordTea.OffTextColor = System.Drawing.Color.Gray;
            this.sbRecordTea.OnBackColor = System.Drawing.Color.DarkGreen;
            this.sbRecordTea.OnTextColor = System.Drawing.Color.White;
            this.sbRecordTea.Size = new System.Drawing.Size(66, 22);
            this.sbRecordTea.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sbRecordTea.SwitchBackColor = System.Drawing.SystemColors.WindowFrame;
            this.sbRecordTea.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sbRecordTea.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(360, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "声音：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(360, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "声音：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(360, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "声音：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "录制学生画面：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(116, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "录制教师画面：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(144, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "录制屏幕：";
            // 
            // sbRecordScreen
            // 
            // 
            // 
            // 
            this.sbRecordScreen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbRecordScreen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.sbRecordScreen.Location = new System.Drawing.Point(229, 118);
            this.sbRecordScreen.Name = "sbRecordScreen";
            this.sbRecordScreen.OffBackColor = System.Drawing.Color.Black;
            this.sbRecordScreen.OffTextColor = System.Drawing.Color.Gray;
            this.sbRecordScreen.OnBackColor = System.Drawing.Color.DarkGreen;
            this.sbRecordScreen.OnTextColor = System.Drawing.Color.White;
            this.sbRecordScreen.Size = new System.Drawing.Size(66, 22);
            this.sbRecordScreen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sbRecordScreen.SwitchBackColor = System.Drawing.SystemColors.WindowFrame;
            this.sbRecordScreen.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sbRecordScreen.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel9.Controls.Add(this.pictureBox3);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.btnCloseSetting);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(598, 30);
            this.panel9.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::lubo2012.Properties.Resources.设置;
            this.pictureBox3.Location = new System.Drawing.Point(12, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "录播设置";
            // 
            // btnCloseSetting
            // 
            this.btnCloseSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSetting.Location = new System.Drawing.Point(570, 2);
            this.btnCloseSetting.MaximumSize = new System.Drawing.Size(30, 27);
            this.btnCloseSetting.MinimumSize = new System.Drawing.Size(30, 27);
            this.btnCloseSetting.Name = "btnCloseSetting";
            this.btnCloseSetting.Size = new System.Drawing.Size(30, 27);
            this.btnCloseSetting.TabIndex = 0;
            this.btnCloseSetting.Click += new System.EventHandler(this.btnCloseSetting_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(717, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "教师画面";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "学生画面";
            // 
            // plTools
            // 
            this.plTools.Controls.Add(this.label12);
            this.plTools.Controls.Add(this.lbRecordTime);
            this.plTools.Controls.Add(this.btnSetting);
            this.plTools.Controls.Add(this.pictureBox2);
            this.plTools.Controls.Add(this.pictureBox1);
            this.plTools.Controls.Add(this.btnPlay);
            this.plTools.Controls.Add(this.btnRecordControl);
            this.plTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plTools.Location = new System.Drawing.Point(0, 628);
            this.plTools.Name = "plTools";
            this.plTools.Size = new System.Drawing.Size(1024, 50);
            this.plTools.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(544, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "20170101120000.mp4 时长:96m";
            // 
            // lbRecordTime
            // 
            this.lbRecordTime.AutoSize = true;
            this.lbRecordTime.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbRecordTime.ForeColor = System.Drawing.Color.White;
            this.lbRecordTime.Location = new System.Drawing.Point(361, 15);
            this.lbRecordTime.Name = "lbRecordTime";
            this.lbRecordTime.Size = new System.Drawing.Size(63, 20);
            this.lbRecordTime.TabIndex = 5;
            this.lbRecordTime.Text = "00:00:00";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = global::lubo2012.Properties.Resources.设置_默认;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(817, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(65, 50);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::lubo2012.Properties.Resources.最近一次录制;
            this.pictureBox2.Location = new System.Drawing.Point(430, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lubo2012.Properties.Resources.录制时长;
            this.pictureBox1.Location = new System.Drawing.Point(290, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPlay.BackgroundImage = global::lubo2012.Properties.Resources.播放录制_默认;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(213, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(65, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRecordControl
            // 
            this.btnRecordControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnRecordControl.BackgroundImage = global::lubo2012.Properties.Resources.开始录制;
            this.btnRecordControl.FlatAppearance.BorderSize = 0;
            this.btnRecordControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnRecordControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnRecordControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordControl.Location = new System.Drawing.Point(142, 0);
            this.btnRecordControl.Name = "btnRecordControl";
            this.btnRecordControl.Size = new System.Drawing.Size(65, 50);
            this.btnRecordControl.TabIndex = 0;
            this.btnRecordControl.UseVisualStyleBackColor = false;
            this.btnRecordControl.Click += new System.EventHandler(this.btnRecordControl_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(112, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 2);
            this.panel1.TabIndex = 4;
            // 
            // plBar
            // 
            this.plBar.Controls.Add(this.plVideoTab);
            this.plBar.Controls.Add(this.plRecordTab);
            this.plBar.Controls.Add(this.panel1);
            this.plBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBar.Location = new System.Drawing.Point(0, 593);
            this.plBar.Name = "plBar";
            this.plBar.Size = new System.Drawing.Size(1024, 35);
            this.plBar.TabIndex = 5;
            // 
            // plVideoTab
            // 
            this.plVideoTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plVideoTab.BackgroundImage = global::lubo2012.Properties.Resources.视频管理_默认;
            this.plVideoTab.Location = new System.Drawing.Point(504, 1);
            this.plVideoTab.Name = "plVideoTab";
            this.plVideoTab.Size = new System.Drawing.Size(120, 30);
            this.plVideoTab.TabIndex = 6;
            this.plVideoTab.Click += new System.EventHandler(this.plVideoTab_Click);
            // 
            // plRecordTab
            // 
            this.plRecordTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plRecordTab.BackgroundImage = global::lubo2012.Properties.Resources.录播_选中;
            this.plRecordTab.Location = new System.Drawing.Point(384, 1);
            this.plRecordTab.Name = "plRecordTab";
            this.plRecordTab.Size = new System.Drawing.Size(120, 30);
            this.plRecordTab.TabIndex = 5;
            this.plRecordTab.Click += new System.EventHandler(this.plRecordTab_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1024, 718);
            this.Controls.Add(this.plPreview);
            this.Controls.Add(this.plBar);
            this.Controls.Add(this.plTools);
            this.Controls.Add(this.plTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.plTitlebar.ResumeLayout(false);
            this.plPreview.ResumeLayout(false);
            this.plPreview.PerformLayout();
            this.plSetting.ResumeLayout(false);
            this.plSetting.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.plTools.ResumeLayout(false);
            this.plTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plStudent;
        private System.Windows.Forms.Panel plTeacher;
        private System.Windows.Forms.Panel plTitlebar;
        private DMSkin.Controls.DMButtonMinLight btnMin;
        private DMSkin.Controls.DMButtonCloseLight btnClose;
        private System.Windows.Forms.Panel plPreview;
        private System.Windows.Forms.Panel plTools;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecordControl;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRecordTime;
        private System.Windows.Forms.Panel plRecordTab;
        private System.Windows.Forms.Panel plVideoTab;
        private System.Windows.Forms.Panel plBar;
        private System.Windows.Forms.Panel plSetting;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private DMSkin.Controls.DMButtonCloseLight btnCloseSetting;
        private System.Windows.Forms.Button btnSettingCancel;
        private System.Windows.Forms.Button btnSettingSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.SwitchButton sbStuAudioInput;
        private DevComponents.DotNetBar.Controls.SwitchButton sbTeaAudioInput;
        private DevComponents.DotNetBar.Controls.SwitchButton sbScrAudioInput;
        private DevComponents.DotNetBar.Controls.SwitchButton sbRecordStu;
        private DevComponents.DotNetBar.Controls.SwitchButton sbRecordTea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevComponents.DotNetBar.Controls.SwitchButton sbRecordScreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
    }
}