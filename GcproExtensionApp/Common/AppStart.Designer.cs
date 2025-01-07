namespace GcproExtensionApp
{
    partial class AppStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppStart));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnOpenGcproTempPath = new System.Windows.Forms.Button();
            this.grpBoxTempPath = new System.Windows.Forms.GroupBox();
            this.txtGcproTempPath = new System.Windows.Forms.TextBox();
            this.lblGcproTempPath = new System.Windows.Forms.Label();
            this.pictureBoxBuhlerCode = new System.Windows.Forms.PictureBox();
            this.BtnOpenGcsLibraryDB = new System.Windows.Forms.Button();
            this.GcproDB = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.BtnOpenProjectDB = new System.Windows.Forms.Button();
            this.comboProjectType = new System.Windows.Forms.ComboBox();
            this.lblProjectType = new System.Windows.Forms.Label();
            this.TxtGcsLibraryPath = new System.Windows.Forms.TextBox();
            this.TxtProjectPath = new System.Windows.Forms.TextBox();
            this.LblGcproLibaryPath = new System.Windows.Forms.Label();
            this.LblGcproProjectPath = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpEngineer = new System.Windows.Forms.GroupBox();
            this.txtDemo = new System.Windows.Forms.TextBox();
            this.txtRegexNamePrefix = new System.Windows.Forms.TextBox();
            this.lblRegexNamePrefix = new System.Windows.Forms.Label();
            this.txtRegexNameOnlyWithNumberTypeLL = new System.Windows.Forms.TextBox();
            this.lblRegexNameOnlyWithNumberTypeLL = new System.Windows.Forms.Label();
            this.txtRegexNameWithoutTypeLL = new System.Windows.Forms.TextBox();
            this.lblNameWithoutTypeLL = new System.Windows.Forms.Label();
            this.grpBoxOther = new System.Windows.Forms.GroupBox();
            this.btnAddDPSlave = new System.Windows.Forms.Button();
            this.lblDPSlave = new System.Windows.Forms.Label();
            this.btnAddDischargerVertex = new System.Windows.Forms.Button();
            this.lblDischargerVertex = new System.Windows.Forms.Label();
            this.btnAddBin = new System.Windows.Forms.Button();
            this.lblBin = new System.Windows.Forms.Label();
            this.grpMachine = new System.Windows.Forms.GroupBox();
            this.btnAddMA_MDDY = new System.Windows.Forms.Button();
            this.lblMA_MDDY = new System.Windows.Forms.Label();
            this.btnAddMA_Roll8Stand = new System.Windows.Forms.Button();
            this.lblMA_Roll8Stand = new System.Windows.Forms.Label();
            this.btnAddMADischarger = new System.Windows.Forms.Button();
            this.lblMA_Discharger = new System.Windows.Forms.Label();
            this.btnAddMotorWithBypass = new System.Windows.Forms.Button();
            this.lblMA_MotorWithPass = new System.Windows.Forms.Label();
            this.grpBoxElement = new System.Windows.Forms.GroupBox();
            this.btnAddRollStandPhoenix = new System.Windows.Forms.Button();
            this.lblRollStandPhoenix = new System.Windows.Forms.Label();
            this.btnAddFBAL = new System.Windows.Forms.Button();
            this.lblFBAL = new System.Windows.Forms.Label();
            this.btnAddScaleAdapter = new System.Windows.Forms.Button();
            this.lblScaleAdapter = new System.Windows.Forms.Label();
            this.btnAddVFC = new System.Windows.Forms.Button();
            this.lblVFCAdapter = new System.Windows.Forms.Label();
            this.btnAddMDDx = new System.Windows.Forms.Button();
            this.lblMDDx = new System.Windows.Forms.Label();
            this.btnAddValve = new System.Windows.Forms.Button();
            this.lblValve = new System.Windows.Forms.Label();
            this.btnAddDI = new System.Windows.Forms.Button();
            this.lblDI = new System.Windows.Forms.Label();
            this.btnAddAI = new System.Windows.Forms.Button();
            this.lblAI = new System.Windows.Forms.Label();
            this.btnAddMotor = new System.Windows.Forms.Button();
            this.lblMotor = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnAddDO = new System.Windows.Forms.Button();
            this.lblDO = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBoxTempPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuhlerCode)).BeginInit();
            this.GcproDB.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpEngineer.SuspendLayout();
            this.grpBoxOther.SuspendLayout();
            this.grpMachine.SuspendLayout();
            this.grpBoxElement.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.AccessibleDescription = "";
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(830, 384);
            this.tabMain.TabIndex = 112;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.BtnOpenGcproTempPath);
            this.tabPage1.Controls.Add(this.grpBoxTempPath);
            this.tabPage1.Controls.Add(this.pictureBoxBuhlerCode);
            this.tabPage1.Controls.Add(this.BtnOpenGcsLibraryDB);
            this.tabPage1.Controls.Add(this.GcproDB);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "项目信息";
            // 
            // BtnOpenGcproTempPath
            // 
            this.BtnOpenGcproTempPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOpenGcproTempPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnOpenGcproTempPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenGcproTempPath.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenGcproTempPath.Image")));
            this.BtnOpenGcproTempPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenGcproTempPath.Location = new System.Drawing.Point(550, 151);
            this.BtnOpenGcproTempPath.Name = "BtnOpenGcproTempPath";
            this.BtnOpenGcproTempPath.Size = new System.Drawing.Size(89, 27);
            this.BtnOpenGcproTempPath.TabIndex = 18;
            this.BtnOpenGcproTempPath.Text = "    浏 览";
            this.BtnOpenGcproTempPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOpenGcproTempPath.UseVisualStyleBackColor = true;
            this.BtnOpenGcproTempPath.Click += new System.EventHandler(this.BtnOpenGcproTempPath_Click);
            // 
            // grpBoxTempPath
            // 
            this.grpBoxTempPath.Controls.Add(this.txtGcproTempPath);
            this.grpBoxTempPath.Controls.Add(this.lblGcproTempPath);
            this.grpBoxTempPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxTempPath.Location = new System.Drawing.Point(6, 135);
            this.grpBoxTempPath.Name = "grpBoxTempPath";
            this.grpBoxTempPath.Size = new System.Drawing.Size(643, 49);
            this.grpBoxTempPath.TabIndex = 13;
            this.grpBoxTempPath.TabStop = false;
            this.grpBoxTempPath.Text = "临时导入文件存放区";
            // 
            // txtGcproTempPath
            // 
            this.txtGcproTempPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGcproTempPath.Location = new System.Drawing.Point(107, 23);
            this.txtGcproTempPath.Name = "txtGcproTempPath";
            this.txtGcproTempPath.Size = new System.Drawing.Size(425, 13);
            this.txtGcproTempPath.TabIndex = 2;
            this.txtGcproTempPath.DoubleClick += new System.EventHandler(this.txtGcproTempPath_DoubleClick);
            this.txtGcproTempPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGcproTempPath_KeyDown);
            // 
            // lblGcproTempPath
            // 
            this.lblGcproTempPath.Image = global::GcproExtensionApp.Properties.Resources._1__26_1;
            this.lblGcproTempPath.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblGcproTempPath.Location = new System.Drawing.Point(6, 18);
            this.lblGcproTempPath.Name = "lblGcproTempPath";
            this.lblGcproTempPath.Size = new System.Drawing.Size(95, 22);
            this.lblGcproTempPath.TabIndex = 0;
            this.lblGcproTempPath.Text = "文件夹";
            this.lblGcproTempPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxBuhlerCode
            // 
            this.pictureBoxBuhlerCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBuhlerCode.ErrorImage = null;
            this.pictureBoxBuhlerCode.Image = global::GcproExtensionApp.Properties.Resources.buhlerCode;
            this.pictureBoxBuhlerCode.Location = new System.Drawing.Point(708, 15);
            this.pictureBoxBuhlerCode.Name = "pictureBoxBuhlerCode";
            this.pictureBoxBuhlerCode.Size = new System.Drawing.Size(86, 87);
            this.pictureBoxBuhlerCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBuhlerCode.TabIndex = 17;
            this.pictureBoxBuhlerCode.TabStop = false;
            // 
            // BtnOpenGcsLibraryDB
            // 
            this.BtnOpenGcsLibraryDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOpenGcsLibraryDB.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnOpenGcsLibraryDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenGcsLibraryDB.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenGcsLibraryDB.Image")));
            this.BtnOpenGcsLibraryDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenGcsLibraryDB.Location = new System.Drawing.Point(550, 59);
            this.BtnOpenGcsLibraryDB.Name = "BtnOpenGcsLibraryDB";
            this.BtnOpenGcsLibraryDB.Size = new System.Drawing.Size(89, 27);
            this.BtnOpenGcsLibraryDB.TabIndex = 15;
            this.BtnOpenGcsLibraryDB.Text = "    浏 览";
            this.BtnOpenGcsLibraryDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOpenGcsLibraryDB.UseVisualStyleBackColor = true;
            this.BtnOpenGcsLibraryDB.Click += new System.EventHandler(this.BtnOpenGcsLibraryDB_Click);
            // 
            // GcproDB
            // 
            this.GcproDB.Controls.Add(this.btnQuery);
            this.GcproDB.Controls.Add(this.BtnOpenProjectDB);
            this.GcproDB.Controls.Add(this.comboProjectType);
            this.GcproDB.Controls.Add(this.lblProjectType);
            this.GcproDB.Controls.Add(this.TxtGcsLibraryPath);
            this.GcproDB.Controls.Add(this.TxtProjectPath);
            this.GcproDB.Controls.Add(this.LblGcproLibaryPath);
            this.GcproDB.Controls.Add(this.LblGcproProjectPath);
            this.GcproDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GcproDB.Location = new System.Drawing.Point(6, 8);
            this.GcproDB.Name = "GcproDB";
            this.GcproDB.Size = new System.Drawing.Size(643, 119);
            this.GcproDB.TabIndex = 12;
            this.GcproDB.TabStop = false;
            this.GcproDB.Text = "GCRPO项目信息";
            // 
            // btnQuery
            // 
            this.btnQuery.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Image = global::GcproExtensionApp.Properties.Resources.Access;
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(544, 86);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(88, 27);
            this.btnQuery.TabIndex = 114;
            this.btnQuery.Text = "查询数据";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // BtnOpenProjectDB
            // 
            this.BtnOpenProjectDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOpenProjectDB.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnOpenProjectDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenProjectDB.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenProjectDB.Image")));
            this.BtnOpenProjectDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenProjectDB.Location = new System.Drawing.Point(544, 16);
            this.BtnOpenProjectDB.Name = "BtnOpenProjectDB";
            this.BtnOpenProjectDB.Size = new System.Drawing.Size(89, 27);
            this.BtnOpenProjectDB.TabIndex = 19;
            this.BtnOpenProjectDB.Text = "    浏 览";
            this.BtnOpenProjectDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOpenProjectDB.UseVisualStyleBackColor = true;
            this.BtnOpenProjectDB.Click += new System.EventHandler(this.BtnOpenProjectDB_Click);
            // 
            // comboProjectType
            // 
            this.comboProjectType.Enabled = false;
            this.comboProjectType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboProjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProjectType.FormattingEnabled = true;
            this.comboProjectType.Location = new System.Drawing.Point(108, 86);
            this.comboProjectType.Name = "comboProjectType";
            this.comboProjectType.Size = new System.Drawing.Size(216, 21);
            this.comboProjectType.TabIndex = 5;
            // 
            // lblProjectType
            // 
            this.lblProjectType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProjectType.Location = new System.Drawing.Point(6, 85);
            this.lblProjectType.Name = "lblProjectType";
            this.lblProjectType.Size = new System.Drawing.Size(90, 22);
            this.lblProjectType.TabIndex = 1;
            this.lblProjectType.Text = "项目类型";
            this.lblProjectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtGcsLibraryPath
            // 
            this.TxtGcsLibraryPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGcsLibraryPath.Location = new System.Drawing.Point(107, 55);
            this.TxtGcsLibraryPath.Name = "TxtGcsLibraryPath";
            this.TxtGcsLibraryPath.Size = new System.Drawing.Size(425, 13);
            this.TxtGcsLibraryPath.TabIndex = 3;
            this.TxtGcsLibraryPath.DoubleClick += new System.EventHandler(this.TxtGcsLibraryPath_DoubleClick);
            // 
            // TxtProjectPath
            // 
            this.TxtProjectPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProjectPath.Location = new System.Drawing.Point(107, 23);
            this.TxtProjectPath.Name = "TxtProjectPath";
            this.TxtProjectPath.Size = new System.Drawing.Size(425, 13);
            this.TxtProjectPath.TabIndex = 2;
            this.TxtProjectPath.DoubleClick += new System.EventHandler(this.TxtProjectPath_DoubleClick);
            // 
            // LblGcproLibaryPath
            // 
            this.LblGcproLibaryPath.Image = global::GcproExtensionApp.Properties.Resources.AccessSmall;
            this.LblGcproLibaryPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblGcproLibaryPath.Location = new System.Drawing.Point(6, 50);
            this.LblGcproLibaryPath.Name = "LblGcproLibaryPath";
            this.LblGcproLibaryPath.Size = new System.Drawing.Size(90, 22);
            this.LblGcproLibaryPath.TabIndex = 1;
            this.LblGcproLibaryPath.Text = "GCPRO库";
            this.LblGcproLibaryPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblGcproProjectPath
            // 
            this.LblGcproProjectPath.Image = global::GcproExtensionApp.Properties.Resources.AccessSmall;
            this.LblGcproProjectPath.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblGcproProjectPath.Location = new System.Drawing.Point(6, 18);
            this.LblGcproProjectPath.Name = "LblGcproProjectPath";
            this.LblGcproProjectPath.Size = new System.Drawing.Size(90, 22);
            this.LblGcproProjectPath.TabIndex = 0;
            this.LblGcproProjectPath.Text = "项目库";
            this.LblGcproProjectPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.grpEngineer);
            this.tabPage2.Controls.Add(this.grpBoxOther);
            this.tabPage2.Controls.Add(this.grpMachine);
            this.tabPage2.Controls.Add(this.grpBoxElement);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新建对象";
            // 
            // grpEngineer
            // 
            this.grpEngineer.Controls.Add(this.txtDemo);
            this.grpEngineer.Controls.Add(this.txtRegexNamePrefix);
            this.grpEngineer.Controls.Add(this.lblRegexNamePrefix);
            this.grpEngineer.Controls.Add(this.txtRegexNameOnlyWithNumberTypeLL);
            this.grpEngineer.Controls.Add(this.lblRegexNameOnlyWithNumberTypeLL);
            this.grpEngineer.Controls.Add(this.txtRegexNameWithoutTypeLL);
            this.grpEngineer.Controls.Add(this.lblNameWithoutTypeLL);
            this.grpEngineer.Location = new System.Drawing.Point(6, 267);
            this.grpEngineer.Name = "grpEngineer";
            this.grpEngineer.Size = new System.Drawing.Size(810, 81);
            this.grpEngineer.TabIndex = 5;
            this.grpEngineer.TabStop = false;
            this.grpEngineer.Text = "开发者选项";
            // 
            // txtDemo
            // 
            this.txtDemo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDemo.Location = new System.Drawing.Point(512, 50);
            this.txtDemo.Multiline = true;
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.Size = new System.Drawing.Size(294, 24);
            this.txtDemo.TabIndex = 14;
            this.txtDemo.Text = "示例: 1:[=A1-1001a.1]  2:[=A1-1001a.1-]  3:[1001a.1]";
            // 
            // txtRegexNamePrefix
            // 
            this.txtRegexNamePrefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegexNamePrefix.Location = new System.Drawing.Point(171, 49);
            this.txtRegexNamePrefix.Multiline = true;
            this.txtRegexNamePrefix.Name = "txtRegexNamePrefix";
            this.txtRegexNamePrefix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRegexNamePrefix.Size = new System.Drawing.Size(326, 26);
            this.txtRegexNamePrefix.TabIndex = 13;
            this.txtRegexNamePrefix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNamePrefix_KeyDown);
            // 
            // lblRegexNamePrefix
            // 
            this.lblRegexNamePrefix.AutoSize = true;
            this.lblRegexNamePrefix.Location = new System.Drawing.Point(6, 53);
            this.lblRegexNamePrefix.Name = "lblRegexNamePrefix";
            this.lblRegexNamePrefix.Size = new System.Drawing.Size(156, 13);
            this.lblRegexNamePrefix.TabIndex = 12;
            this.lblRegexNamePrefix.Text = "2.Element名称前缀(含分隔符)";
            // 
            // txtRegexNameOnlyWithNumberTypeLL
            // 
            this.txtRegexNameOnlyWithNumberTypeLL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegexNameOnlyWithNumberTypeLL.Location = new System.Drawing.Point(645, 15);
            this.txtRegexNameOnlyWithNumberTypeLL.Multiline = true;
            this.txtRegexNameOnlyWithNumberTypeLL.Name = "txtRegexNameOnlyWithNumberTypeLL";
            this.txtRegexNameOnlyWithNumberTypeLL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRegexNameOnlyWithNumberTypeLL.Size = new System.Drawing.Size(159, 26);
            this.txtRegexNameOnlyWithNumberTypeLL.TabIndex = 11;
            this.txtRegexNameOnlyWithNumberTypeLL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegexNameOnlyWithNumberTypeLL_KeyDown);
            // 
            // lblRegexNameOnlyWithNumberTypeLL
            // 
            this.lblRegexNameOnlyWithNumberTypeLL.AutoSize = true;
            this.lblRegexNameOnlyWithNumberTypeLL.Location = new System.Drawing.Point(509, 23);
            this.lblRegexNameOnlyWithNumberTypeLL.Name = "lblRegexNameOnlyWithNumberTypeLL";
            this.lblRegexNameOnlyWithNumberTypeLL.Size = new System.Drawing.Size(88, 13);
            this.lblRegexNameOnlyWithNumberTypeLL.TabIndex = 10;
            this.lblRegexNameOnlyWithNumberTypeLL.Text = "3.设备编号规则";
            // 
            // txtRegexNameWithoutTypeLL
            // 
            this.txtRegexNameWithoutTypeLL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegexNameWithoutTypeLL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegexNameWithoutTypeLL.Location = new System.Drawing.Point(171, 15);
            this.txtRegexNameWithoutTypeLL.Multiline = true;
            this.txtRegexNameWithoutTypeLL.Name = "txtRegexNameWithoutTypeLL";
            this.txtRegexNameWithoutTypeLL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRegexNameWithoutTypeLL.Size = new System.Drawing.Size(326, 26);
            this.txtRegexNameWithoutTypeLL.TabIndex = 9;
            this.txtRegexNameWithoutTypeLL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textRegexNameWithoutTypeLL_KeyDown);
            // 
            // lblNameWithoutTypeLL
            // 
            this.lblNameWithoutTypeLL.AutoSize = true;
            this.lblNameWithoutTypeLL.Location = new System.Drawing.Point(6, 23);
            this.lblNameWithoutTypeLL.Name = "lblNameWithoutTypeLL";
            this.lblNameWithoutTypeLL.Size = new System.Drawing.Size(105, 13);
            this.lblNameWithoutTypeLL.TabIndex = 8;
            this.lblNameWithoutTypeLL.Text = "1.Machine名称规则";
            // 
            // grpBoxOther
            // 
            this.grpBoxOther.Controls.Add(this.btnAddDPSlave);
            this.grpBoxOther.Controls.Add(this.lblDPSlave);
            this.grpBoxOther.Controls.Add(this.btnAddDischargerVertex);
            this.grpBoxOther.Controls.Add(this.lblDischargerVertex);
            this.grpBoxOther.Controls.Add(this.btnAddBin);
            this.grpBoxOther.Controls.Add(this.lblBin);
            this.grpBoxOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOther.Location = new System.Drawing.Point(6, 180);
            this.grpBoxOther.Name = "grpBoxOther";
            this.grpBoxOther.Size = new System.Drawing.Size(810, 81);
            this.grpBoxOther.TabIndex = 4;
            this.grpBoxOther.TabStop = false;
            this.grpBoxOther.Text = "OtherObjects";
            // 
            // btnAddDPSlave
            // 
            this.btnAddDPSlave.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddDPSlave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDPSlave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDPSlave.Location = new System.Drawing.Point(316, 19);
            this.btnAddDPSlave.Name = "btnAddDPSlave";
            this.btnAddDPSlave.Size = new System.Drawing.Size(30, 21);
            this.btnAddDPSlave.TabIndex = 5;
            this.btnAddDPSlave.UseVisualStyleBackColor = true;
            this.btnAddDPSlave.Click += new System.EventHandler(this.btnAddDPSlave_Click);
            // 
            // lblDPSlave
            // 
            this.lblDPSlave.AutoSize = true;
            this.lblDPSlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPSlave.Location = new System.Drawing.Point(184, 20);
            this.lblDPSlave.Name = "lblDPSlave";
            this.lblDPSlave.Size = new System.Drawing.Size(107, 16);
            this.lblDPSlave.TabIndex = 4;
            this.lblDPSlave.Text = "DP_Slave_Diag:";
            // 
            // btnAddDischargerVertex
            // 
            this.btnAddDischargerVertex.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddDischargerVertex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDischargerVertex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDischargerVertex.Location = new System.Drawing.Point(129, 50);
            this.btnAddDischargerVertex.Name = "btnAddDischargerVertex";
            this.btnAddDischargerVertex.Size = new System.Drawing.Size(30, 21);
            this.btnAddDischargerVertex.TabIndex = 3;
            this.btnAddDischargerVertex.UseVisualStyleBackColor = true;
            this.btnAddDischargerVertex.Click += new System.EventHandler(this.btnAddDischargerVertex_Click);
            // 
            // lblDischargerVertex
            // 
            this.lblDischargerVertex.AutoSize = true;
            this.lblDischargerVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDischargerVertex.Location = new System.Drawing.Point(6, 51);
            this.lblDischargerVertex.Name = "lblDischargerVertex";
            this.lblDischargerVertex.Size = new System.Drawing.Size(114, 16);
            this.lblDischargerVertex.TabIndex = 2;
            this.lblDischargerVertex.Text = "DischargerVertex:";
            // 
            // btnAddBin
            // 
            this.btnAddBin.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBin.Location = new System.Drawing.Point(129, 19);
            this.btnAddBin.Name = "btnAddBin";
            this.btnAddBin.Size = new System.Drawing.Size(30, 21);
            this.btnAddBin.TabIndex = 1;
            this.btnAddBin.UseVisualStyleBackColor = true;
            this.btnAddBin.Click += new System.EventHandler(this.btnAddBin_Click);
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBin.Location = new System.Drawing.Point(6, 20);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(81, 16);
            this.lblBin.TabIndex = 0;
            this.lblBin.Text = "Storage/Bin:";
            // 
            // grpMachine
            // 
            this.grpMachine.Controls.Add(this.btnAddMA_MDDY);
            this.grpMachine.Controls.Add(this.lblMA_MDDY);
            this.grpMachine.Controls.Add(this.btnAddMA_Roll8Stand);
            this.grpMachine.Controls.Add(this.lblMA_Roll8Stand);
            this.grpMachine.Controls.Add(this.btnAddMADischarger);
            this.grpMachine.Controls.Add(this.lblMA_Discharger);
            this.grpMachine.Controls.Add(this.btnAddMotorWithBypass);
            this.grpMachine.Controls.Add(this.lblMA_MotorWithPass);
            this.grpMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMachine.Location = new System.Drawing.Point(6, 93);
            this.grpMachine.Name = "grpMachine";
            this.grpMachine.Size = new System.Drawing.Size(810, 81);
            this.grpMachine.TabIndex = 2;
            this.grpMachine.TabStop = false;
            this.grpMachine.Text = "Machines";
            // 
            // btnAddMA_MDDY
            // 
            this.btnAddMA_MDDY.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddMA_MDDY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMA_MDDY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMA_MDDY.Location = new System.Drawing.Point(318, 20);
            this.btnAddMA_MDDY.Name = "btnAddMA_MDDY";
            this.btnAddMA_MDDY.Size = new System.Drawing.Size(30, 21);
            this.btnAddMA_MDDY.TabIndex = 7;
            this.btnAddMA_MDDY.UseVisualStyleBackColor = true;
            this.btnAddMA_MDDY.Click += new System.EventHandler(this.btnAddMA_MDDY_Click);
            // 
            // lblMA_MDDY
            // 
            this.lblMA_MDDY.AutoSize = true;
            this.lblMA_MDDY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMA_MDDY.Location = new System.Drawing.Point(185, 20);
            this.lblMA_MDDY.Name = "lblMA_MDDY";
            this.lblMA_MDDY.Size = new System.Drawing.Size(133, 16);
            this.lblMA_MDDY.TabIndex = 6;
            this.lblMA_MDDY.Text = "MA_MDDYZPhoenix:";
            // 
            // btnAddMA_Roll8Stand
            // 
            this.btnAddMA_Roll8Stand.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddMA_Roll8Stand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMA_Roll8Stand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMA_Roll8Stand.Location = new System.Drawing.Point(318, 51);
            this.btnAddMA_Roll8Stand.Name = "btnAddMA_Roll8Stand";
            this.btnAddMA_Roll8Stand.Size = new System.Drawing.Size(30, 21);
            this.btnAddMA_Roll8Stand.TabIndex = 5;
            this.btnAddMA_Roll8Stand.UseVisualStyleBackColor = true;
            this.btnAddMA_Roll8Stand.Click += new System.EventHandler(this.btnAddMA_Roll8Stand_Click);
            // 
            // lblMA_Roll8Stand
            // 
            this.lblMA_Roll8Stand.AutoSize = true;
            this.lblMA_Roll8Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMA_Roll8Stand.Location = new System.Drawing.Point(185, 51);
            this.lblMA_Roll8Stand.Name = "lblMA_Roll8Stand";
            this.lblMA_Roll8Stand.Size = new System.Drawing.Size(103, 16);
            this.lblMA_Roll8Stand.TabIndex = 4;
            this.lblMA_Roll8Stand.Text = "MA_Roll8Stand:";
            // 
            // btnAddMADischarger
            // 
            this.btnAddMADischarger.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddMADischarger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMADischarger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMADischarger.Location = new System.Drawing.Point(129, 51);
            this.btnAddMADischarger.Name = "btnAddMADischarger";
            this.btnAddMADischarger.Size = new System.Drawing.Size(30, 21);
            this.btnAddMADischarger.TabIndex = 3;
            this.btnAddMADischarger.UseVisualStyleBackColor = true;
            this.btnAddMADischarger.Click += new System.EventHandler(this.btnAddMADischarger_Click);
            // 
            // lblMA_Discharger
            // 
            this.lblMA_Discharger.AutoSize = true;
            this.lblMA_Discharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMA_Discharger.Location = new System.Drawing.Point(6, 51);
            this.lblMA_Discharger.Name = "lblMA_Discharger";
            this.lblMA_Discharger.Size = new System.Drawing.Size(103, 16);
            this.lblMA_Discharger.TabIndex = 2;
            this.lblMA_Discharger.Text = "MA_Discharger:";
            // 
            // btnAddMotorWithBypass
            // 
            this.btnAddMotorWithBypass.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddMotorWithBypass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMotorWithBypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMotorWithBypass.Location = new System.Drawing.Point(129, 20);
            this.btnAddMotorWithBypass.Name = "btnAddMotorWithBypass";
            this.btnAddMotorWithBypass.Size = new System.Drawing.Size(30, 21);
            this.btnAddMotorWithBypass.TabIndex = 1;
            this.btnAddMotorWithBypass.UseVisualStyleBackColor = true;
            this.btnAddMotorWithBypass.Click += new System.EventHandler(this.btnAddMotorWithBypass_Click);
            // 
            // lblMA_MotorWithPass
            // 
            this.lblMA_MotorWithPass.AutoSize = true;
            this.lblMA_MotorWithPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMA_MotorWithPass.Location = new System.Drawing.Point(6, 20);
            this.lblMA_MotorWithPass.Name = "lblMA_MotorWithPass";
            this.lblMA_MotorWithPass.Size = new System.Drawing.Size(117, 16);
            this.lblMA_MotorWithPass.TabIndex = 0;
            this.lblMA_MotorWithPass.Text = "MA_MotorBypass:";
            // 
            // grpBoxElement
            // 
            this.grpBoxElement.Controls.Add(this.btnAddDO);
            this.grpBoxElement.Controls.Add(this.lblDO);
            this.grpBoxElement.Controls.Add(this.btnAddRollStandPhoenix);
            this.grpBoxElement.Controls.Add(this.lblRollStandPhoenix);
            this.grpBoxElement.Controls.Add(this.btnAddFBAL);
            this.grpBoxElement.Controls.Add(this.lblFBAL);
            this.grpBoxElement.Controls.Add(this.btnAddScaleAdapter);
            this.grpBoxElement.Controls.Add(this.lblScaleAdapter);
            this.grpBoxElement.Controls.Add(this.btnAddVFC);
            this.grpBoxElement.Controls.Add(this.lblVFCAdapter);
            this.grpBoxElement.Controls.Add(this.btnAddMDDx);
            this.grpBoxElement.Controls.Add(this.lblMDDx);
            this.grpBoxElement.Controls.Add(this.btnAddValve);
            this.grpBoxElement.Controls.Add(this.lblValve);
            this.grpBoxElement.Controls.Add(this.btnAddDI);
            this.grpBoxElement.Controls.Add(this.lblDI);
            this.grpBoxElement.Controls.Add(this.btnAddAI);
            this.grpBoxElement.Controls.Add(this.lblAI);
            this.grpBoxElement.Controls.Add(this.btnAddMotor);
            this.grpBoxElement.Controls.Add(this.lblMotor);
            this.grpBoxElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxElement.Location = new System.Drawing.Point(6, 6);
            this.grpBoxElement.Name = "grpBoxElement";
            this.grpBoxElement.Size = new System.Drawing.Size(810, 81);
            this.grpBoxElement.TabIndex = 0;
            this.grpBoxElement.TabStop = false;
            this.grpBoxElement.Text = "Elements";
            // 
            // btnAddRollStandPhoenix
            // 
            this.btnAddRollStandPhoenix.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddRollStandPhoenix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRollStandPhoenix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRollStandPhoenix.Location = new System.Drawing.Point(698, 20);
            this.btnAddRollStandPhoenix.Name = "btnAddRollStandPhoenix";
            this.btnAddRollStandPhoenix.Size = new System.Drawing.Size(30, 21);
            this.btnAddRollStandPhoenix.TabIndex = 17;
            this.btnAddRollStandPhoenix.UseVisualStyleBackColor = true;
            this.btnAddRollStandPhoenix.Click += new System.EventHandler(this.btnAddRollStandPhoenix_Click);
            // 
            // lblRollStandPhoenix
            // 
            this.lblRollStandPhoenix.AutoSize = true;
            this.lblRollStandPhoenix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollStandPhoenix.Location = new System.Drawing.Point(557, 22);
            this.lblRollStandPhoenix.Name = "lblRollStandPhoenix";
            this.lblRollStandPhoenix.Size = new System.Drawing.Size(140, 16);
            this.lblRollStandPhoenix.TabIndex = 16;
            this.lblRollStandPhoenix.Text = "EL_RollStandPhoenix:";
            // 
            // btnAddFBAL
            // 
            this.btnAddFBAL.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddFBAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddFBAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFBAL.Location = new System.Drawing.Point(318, 17);
            this.btnAddFBAL.Name = "btnAddFBAL";
            this.btnAddFBAL.Size = new System.Drawing.Size(30, 21);
            this.btnAddFBAL.TabIndex = 15;
            this.btnAddFBAL.UseVisualStyleBackColor = true;
            this.btnAddFBAL.Click += new System.EventHandler(this.btnAddFBAL_Click);
            // 
            // lblFBAL
            // 
            this.lblFBAL.AutoSize = true;
            this.lblFBAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBAL.Location = new System.Drawing.Point(245, 19);
            this.lblFBAL.Name = "lblFBAL";
            this.lblFBAL.Size = new System.Drawing.Size(66, 16);
            this.lblFBAL.TabIndex = 14;
            this.lblFBAL.Text = "EL_FBAL:";
            // 
            // btnAddScaleAdapter
            // 
            this.btnAddScaleAdapter.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddScaleAdapter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddScaleAdapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddScaleAdapter.Location = new System.Drawing.Point(496, 17);
            this.btnAddScaleAdapter.Name = "btnAddScaleAdapter";
            this.btnAddScaleAdapter.Size = new System.Drawing.Size(30, 21);
            this.btnAddScaleAdapter.TabIndex = 13;
            this.btnAddScaleAdapter.UseVisualStyleBackColor = true;
            this.btnAddScaleAdapter.Click += new System.EventHandler(this.btnAddScaleAdapter_Click);
            // 
            // lblScaleAdapter
            // 
            this.lblScaleAdapter.AutoSize = true;
            this.lblScaleAdapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScaleAdapter.Location = new System.Drawing.Point(381, 19);
            this.lblScaleAdapter.Name = "lblScaleAdapter";
            this.lblScaleAdapter.Size = new System.Drawing.Size(116, 16);
            this.lblScaleAdapter.TabIndex = 12;
            this.lblScaleAdapter.Text = "EL_ScaleAdapter:";
            // 
            // btnAddVFC
            // 
            this.btnAddVFC.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddVFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddVFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVFC.Location = new System.Drawing.Point(496, 47);
            this.btnAddVFC.Name = "btnAddVFC";
            this.btnAddVFC.Size = new System.Drawing.Size(30, 21);
            this.btnAddVFC.TabIndex = 3;
            this.btnAddVFC.UseVisualStyleBackColor = true;
            this.btnAddVFC.Click += new System.EventHandler(this.btnAddVFC_Click);
            // 
            // lblVFCAdapter
            // 
            this.lblVFCAdapter.AutoSize = true;
            this.lblVFCAdapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVFCAdapter.Location = new System.Drawing.Point(381, 50);
            this.lblVFCAdapter.Name = "lblVFCAdapter";
            this.lblVFCAdapter.Size = new System.Drawing.Size(84, 16);
            this.lblVFCAdapter.TabIndex = 2;
            this.lblVFCAdapter.Text = "VFCAdapter:";
            // 
            // btnAddMDDx
            // 
            this.btnAddMDDx.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddMDDx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMDDx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMDDx.Location = new System.Drawing.Point(699, 50);
            this.btnAddMDDx.Name = "btnAddMDDx";
            this.btnAddMDDx.Size = new System.Drawing.Size(30, 21);
            this.btnAddMDDx.TabIndex = 11;
            this.btnAddMDDx.UseVisualStyleBackColor = true;
            this.btnAddMDDx.Click += new System.EventHandler(this.btnAddMDDx_Click);
            // 
            // lblMDDx
            // 
            this.lblMDDx.AutoSize = true;
            this.lblMDDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDDx.Location = new System.Drawing.Point(557, 53);
            this.lblMDDx.Name = "lblMDDx";
            this.lblMDDx.Size = new System.Drawing.Size(96, 16);
            this.lblMDDx.TabIndex = 10;
            this.lblMDDx.Text = "EL_MDDx_DP:";
            // 
            // btnAddValve
            // 
            this.btnAddValve.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddValve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddValve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddValve.Location = new System.Drawing.Point(80, 47);
            this.btnAddValve.Name = "btnAddValve";
            this.btnAddValve.Size = new System.Drawing.Size(30, 21);
            this.btnAddValve.TabIndex = 9;
            this.btnAddValve.UseVisualStyleBackColor = true;
            this.btnAddValve.Click += new System.EventHandler(this.btnAddValve_Click);
            // 
            // lblValve
            // 
            this.lblValve.AutoSize = true;
            this.lblValve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValve.Location = new System.Drawing.Point(6, 50);
            this.lblValve.Name = "lblValve";
            this.lblValve.Size = new System.Drawing.Size(68, 16);
            this.lblValve.TabIndex = 8;
            this.lblValve.Text = "EL_Valve:";
            // 
            // btnAddDI
            // 
            this.btnAddDI.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddDI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDI.Location = new System.Drawing.Point(189, 47);
            this.btnAddDI.Name = "btnAddDI";
            this.btnAddDI.Size = new System.Drawing.Size(30, 21);
            this.btnAddDI.TabIndex = 7;
            this.btnAddDI.UseVisualStyleBackColor = true;
            this.btnAddDI.Click += new System.EventHandler(this.btnAddDI_Click);
            // 
            // lblDI
            // 
            this.lblDI.AutoSize = true;
            this.lblDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDI.Location = new System.Drawing.Point(136, 50);
            this.lblDI.Name = "lblDI";
            this.lblDI.Size = new System.Drawing.Size(46, 16);
            this.lblDI.TabIndex = 6;
            this.lblDI.Text = "EL_DI:";
            // 
            // btnAddAI
            // 
            this.btnAddAI.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAI.Location = new System.Drawing.Point(189, 17);
            this.btnAddAI.Name = "btnAddAI";
            this.btnAddAI.Size = new System.Drawing.Size(30, 21);
            this.btnAddAI.TabIndex = 5;
            this.btnAddAI.UseVisualStyleBackColor = true;
            this.btnAddAI.Click += new System.EventHandler(this.btnAddAI_Click);
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAI.Location = new System.Drawing.Point(136, 19);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(45, 16);
            this.lblAI.TabIndex = 4;
            this.lblAI.Text = "EL_AI:";
            // 
            // btnAddMotor
            // 
            this.btnAddMotor.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMotor.Location = new System.Drawing.Point(80, 17);
            this.btnAddMotor.Name = "btnAddMotor";
            this.btnAddMotor.Size = new System.Drawing.Size(30, 21);
            this.btnAddMotor.TabIndex = 1;
            this.btnAddMotor.UseVisualStyleBackColor = true;
            this.btnAddMotor.Click += new System.EventHandler(this.btnAddMotor_Click);
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotor.Location = new System.Drawing.Point(6, 19);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(67, 16);
            this.lblMotor.TabIndex = 0;
            this.lblMotor.Text = "EL_Motor:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tableLayoutPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(822, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "软件信息";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.01156F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.98844F));
            this.tableLayoutPanel.Controls.Add(this.lblApplicationTitle, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34867F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.363085F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.954436F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.954436F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.48375F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.895625F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(816, 349);
            this.tableLayoutPanel.TabIndex = 25;
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.Location = new System.Drawing.Point(218, 0);
            this.lblApplicationTitle.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblApplicationTitle.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(595, 17);
            this.lblApplicationTitle.TabIndex = 19;
            this.lblApplicationTitle.Text = "Product Name";
            this.lblApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(218, 36);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(595, 17);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(218, 68);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(595, 17);
            this.lblCopyright.TabIndex = 21;
            this.lblCopyright.Text = "Copyright";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompanyName.Location = new System.Drawing.Point(218, 102);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(595, 17);
            this.lblCompanyName.TabIndex = 22;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(218, 139);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(595, 187);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.TabStop = false;
            this.txtDescription.Text = "Description";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::GcproExtensionApp.Properties.Resources.buhlerCode;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(206, 343);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // btnAddDO
            // 
            this.btnAddDO.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddDO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDO.Location = new System.Drawing.Point(318, 50);
            this.btnAddDO.Name = "btnAddDO";
            this.btnAddDO.Size = new System.Drawing.Size(30, 21);
            this.btnAddDO.TabIndex = 19;
            this.btnAddDO.UseVisualStyleBackColor = true;
            this.btnAddDO.Click += new System.EventHandler(this.btnAddDO_Click);
            // 
            // lblDO
            // 
            this.lblDO.AutoSize = true;
            this.lblDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDO.Location = new System.Drawing.Point(245, 52);
            this.lblDO.Name = "lblDO";
            this.lblDO.Size = new System.Drawing.Size(53, 16);
            this.lblDO.TabIndex = 18;
            this.lblDO.Text = "EL_DO:";
            // 
            // AppStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 384);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AppStart";
            this.Text = "GCPRO Extension Application";
            this.Load += new System.EventHandler(this.AppStart_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpBoxTempPath.ResumeLayout(false);
            this.grpBoxTempPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuhlerCode)).EndInit();
            this.GcproDB.ResumeLayout(false);
            this.GcproDB.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpEngineer.ResumeLayout(false);
            this.grpEngineer.PerformLayout();
            this.grpBoxOther.ResumeLayout(false);
            this.grpBoxOther.PerformLayout();
            this.grpMachine.ResumeLayout(false);
            this.grpMachine.PerformLayout();
            this.grpBoxElement.ResumeLayout(false);
            this.grpBoxElement.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion      
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Button BtnOpenGcsLibraryDB;
        internal System.Windows.Forms.GroupBox GcproDB;
        internal System.Windows.Forms.TextBox TxtGcsLibraryPath;
        internal System.Windows.Forms.TextBox TxtProjectPath;
        internal System.Windows.Forms.Label LblGcproLibaryPath;
        internal System.Windows.Forms.Label LblGcproProjectPath;
        private System.Windows.Forms.PictureBox pictureBoxBuhlerCode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpBoxElement;
        private System.Windows.Forms.Button btnAddMotor;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.GroupBox grpMachine;
        private System.Windows.Forms.Button btnAddMotorWithBypass;
        private System.Windows.Forms.Label lblMA_MotorWithPass;
        private System.Windows.Forms.Button btnAddVFC;
        private System.Windows.Forms.Label lblVFCAdapter;
        private System.Windows.Forms.Button btnAddMDDx;
        private System.Windows.Forms.Label lblMDDx;
        private System.Windows.Forms.Button btnAddValve;
        private System.Windows.Forms.Label lblValve;
        private System.Windows.Forms.Button btnAddDI;
        private System.Windows.Forms.Label lblDI;
        private System.Windows.Forms.Button btnAddAI;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.Button btnAddScaleAdapter;
        private System.Windows.Forms.Label lblScaleAdapter;
        private System.Windows.Forms.Button btnAddFBAL;
        private System.Windows.Forms.Label lblFBAL;
        private System.Windows.Forms.Button btnAddMADischarger;
        private System.Windows.Forms.Label lblMA_Discharger;
        private System.Windows.Forms.GroupBox grpBoxOther;
        private System.Windows.Forms.Button btnAddDischargerVertex;
        private System.Windows.Forms.Label lblDischargerVertex;
        private System.Windows.Forms.Button btnAddBin;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Button btnAddMA_MDDY;
        private System.Windows.Forms.Label lblMA_MDDY;
        private System.Windows.Forms.Button btnAddMA_Roll8Stand;
        private System.Windows.Forms.Label lblMA_Roll8Stand;
        private System.Windows.Forms.Button btnAddRollStandPhoenix;
        private System.Windows.Forms.Label lblRollStandPhoenix;
        private System.Windows.Forms.Button btnAddDPSlave;
        private System.Windows.Forms.Label lblDPSlave;
        internal System.Windows.Forms.Button BtnOpenGcproTempPath;
        internal System.Windows.Forms.GroupBox grpBoxTempPath;
        internal System.Windows.Forms.TextBox txtGcproTempPath;
        internal System.Windows.Forms.Label lblGcproTempPath;
        private System.Windows.Forms.ComboBox comboProjectType;
        internal System.Windows.Forms.Label lblProjectType;
        internal System.Windows.Forms.Button BtnOpenProjectDB;
        private System.Windows.Forms.TextBox txtRegexNameWithoutTypeLL;
        private System.Windows.Forms.Label lblNameWithoutTypeLL;
        private System.Windows.Forms.GroupBox grpEngineer;
        private System.Windows.Forms.TextBox txtRegexNameOnlyWithNumberTypeLL;
        private System.Windows.Forms.Label lblRegexNameOnlyWithNumberTypeLL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblApplicationTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtRegexNamePrefix;
        private System.Windows.Forms.Label lblRegexNamePrefix;
        private System.Windows.Forms.TextBox txtDemo;
        private System.Windows.Forms.Button btnAddDO;
        private System.Windows.Forms.Label lblDO;
    }
}
