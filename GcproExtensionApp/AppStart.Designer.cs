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
            this.BtnOpenProjectDB = new System.Windows.Forms.Button();
            this.GcproDB = new System.Windows.Forms.GroupBox();
            this.TxtGcsLibraryPath = new System.Windows.Forms.TextBox();
            this.TxtProjectPath = new System.Windows.Forms.TextBox();
            this.LblGcproLibaryPath = new System.Windows.Forms.Label();
            this.LblGcproProjectPath = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpBoxOther = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBin = new System.Windows.Forms.Label();
            this.grpMachine = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddRoll8Stand = new System.Windows.Forms.Button();
            this.lblRoll8Stand = new System.Windows.Forms.Label();
            this.btnAddMADischarger = new System.Windows.Forms.Button();
            this.lblMADischarger = new System.Windows.Forms.Label();
            this.btnAddMotorWithBypass = new System.Windows.Forms.Button();
            this.lblMotorWithPass = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDI = new System.Windows.Forms.Button();
            this.lblDI = new System.Windows.Forms.Label();
            this.btnAddAI = new System.Windows.Forms.Button();
            this.lblAI = new System.Windows.Forms.Label();
            this.btnAddMotor = new System.Windows.Forms.Button();
            this.lblMotor = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxBuhler2 = new System.Windows.Forms.PictureBox();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBoxTempPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuhlerCode)).BeginInit();
            this.GcproDB.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpBoxOther.SuspendLayout();
            this.grpMachine.SuspendLayout();
            this.grpBoxElement.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuhler2)).BeginInit();
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
            this.tabMain.Size = new System.Drawing.Size(830, 189);
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
            this.tabPage1.Controls.Add(this.BtnOpenProjectDB);
            this.tabPage1.Controls.Add(this.GcproDB);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 160);
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
            this.BtnOpenGcproTempPath.Location = new System.Drawing.Point(550, 119);
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
            this.grpBoxTempPath.Location = new System.Drawing.Point(6, 101);
            this.grpBoxTempPath.Name = "grpBoxTempPath";
            this.grpBoxTempPath.Size = new System.Drawing.Size(538, 49);
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
            this.lblGcproTempPath.Image = global::GcproExtensionApp.Properties.Resources.Folder;
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
            this.BtnOpenGcsLibraryDB.Location = new System.Drawing.Point(550, 63);
            this.BtnOpenGcsLibraryDB.Name = "BtnOpenGcsLibraryDB";
            this.BtnOpenGcsLibraryDB.Size = new System.Drawing.Size(89, 27);
            this.BtnOpenGcsLibraryDB.TabIndex = 15;
            this.BtnOpenGcsLibraryDB.Text = "    浏 览";
            this.BtnOpenGcsLibraryDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOpenGcsLibraryDB.UseVisualStyleBackColor = true;
            this.BtnOpenGcsLibraryDB.Click += new System.EventHandler(this.BtnOpenGcsLibraryDB_Click);
            // 
            // BtnOpenProjectDB
            // 
            this.BtnOpenProjectDB.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.BtnOpenProjectDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenProjectDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOpenProjectDB.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenProjectDB.Image")));
            this.BtnOpenProjectDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenProjectDB.Location = new System.Drawing.Point(550, 24);
            this.BtnOpenProjectDB.Name = "BtnOpenProjectDB";
            this.BtnOpenProjectDB.Size = new System.Drawing.Size(89, 27);
            this.BtnOpenProjectDB.TabIndex = 14;
            this.BtnOpenProjectDB.Text = "    浏 览";
            this.BtnOpenProjectDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOpenProjectDB.UseVisualStyleBackColor = true;
            this.BtnOpenProjectDB.Click += new System.EventHandler(this.BtnOpenProjectDB_Click);
            // 
            // GcproDB
            // 
            this.GcproDB.Controls.Add(this.TxtGcsLibraryPath);
            this.GcproDB.Controls.Add(this.TxtProjectPath);
            this.GcproDB.Controls.Add(this.LblGcproLibaryPath);
            this.GcproDB.Controls.Add(this.LblGcproProjectPath);
            this.GcproDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GcproDB.Location = new System.Drawing.Point(6, 15);
            this.GcproDB.Name = "GcproDB";
            this.GcproDB.Size = new System.Drawing.Size(538, 80);
            this.GcproDB.TabIndex = 12;
            this.GcproDB.TabStop = false;
            this.GcproDB.Text = "GCRPO项目信息";
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
            this.LblGcproLibaryPath.Size = new System.Drawing.Size(94, 22);
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
            this.tabPage2.Controls.Add(this.grpBoxOther);
            this.tabPage2.Controls.Add(this.grpMachine);
            this.tabPage2.Controls.Add(this.grpBoxElement);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新建对象";
            // 
            // grpBoxOther
            // 
            this.grpBoxOther.Controls.Add(this.button4);
            this.grpBoxOther.Controls.Add(this.label3);
            this.grpBoxOther.Controls.Add(this.button1);
            this.grpBoxOther.Controls.Add(this.label1);
            this.grpBoxOther.Controls.Add(this.button2);
            this.grpBoxOther.Controls.Add(this.lblBin);
            this.grpBoxOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOther.Location = new System.Drawing.Point(8, 180);
            this.grpBoxOther.Name = "grpBoxOther";
            this.grpBoxOther.Size = new System.Drawing.Size(812, 81);
            this.grpBoxOther.TabIndex = 4;
            this.grpBoxOther.TabStop = false;
            this.grpBoxOther.Text = "OtherObjects";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(316, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 21);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DP_Slave_Diag:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(129, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 21);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "DischargerVertex:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(129, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBin.Location = new System.Drawing.Point(6, 16);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(81, 16);
            this.lblBin.TabIndex = 0;
            this.lblBin.Text = "Storage/Bin:";
            // 
            // grpMachine
            // 
            this.grpMachine.Controls.Add(this.button3);
            this.grpMachine.Controls.Add(this.label4);
            this.grpMachine.Controls.Add(this.btnAddRoll8Stand);
            this.grpMachine.Controls.Add(this.lblRoll8Stand);
            this.grpMachine.Controls.Add(this.btnAddMADischarger);
            this.grpMachine.Controls.Add(this.lblMADischarger);
            this.grpMachine.Controls.Add(this.btnAddMotorWithBypass);
            this.grpMachine.Controls.Add(this.lblMotorWithPass);
            this.grpMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMachine.Location = new System.Drawing.Point(6, 93);
            this.grpMachine.Name = "grpMachine";
            this.grpMachine.Size = new System.Drawing.Size(812, 81);
            this.grpMachine.TabIndex = 2;
            this.grpMachine.TabStop = false;
            this.grpMachine.Text = "Machines";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(318, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 21);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "MA_MDDYZPhoenix:";
            // 
            // btnAddRoll8Stand
            // 
            this.btnAddRoll8Stand.BackgroundImage = global::GcproExtensionApp.Properties.Resources._new;
            this.btnAddRoll8Stand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRoll8Stand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoll8Stand.Location = new System.Drawing.Point(318, 22);
            this.btnAddRoll8Stand.Name = "btnAddRoll8Stand";
            this.btnAddRoll8Stand.Size = new System.Drawing.Size(30, 21);
            this.btnAddRoll8Stand.TabIndex = 5;
            this.btnAddRoll8Stand.UseVisualStyleBackColor = true;
            // 
            // lblRoll8Stand
            // 
            this.lblRoll8Stand.AutoSize = true;
            this.lblRoll8Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll8Stand.Location = new System.Drawing.Point(185, 22);
            this.lblRoll8Stand.Name = "lblRoll8Stand";
            this.lblRoll8Stand.Size = new System.Drawing.Size(103, 16);
            this.lblRoll8Stand.TabIndex = 4;
            this.lblRoll8Stand.Text = "MA_Roll8Stand:";
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
            // 
            // lblMADischarger
            // 
            this.lblMADischarger.AutoSize = true;
            this.lblMADischarger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMADischarger.Location = new System.Drawing.Point(6, 51);
            this.lblMADischarger.Name = "lblMADischarger";
            this.lblMADischarger.Size = new System.Drawing.Size(103, 16);
            this.lblMADischarger.TabIndex = 2;
            this.lblMADischarger.Text = "MA_Discharger:";
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
            // 
            // lblMotorWithPass
            // 
            this.lblMotorWithPass.AutoSize = true;
            this.lblMotorWithPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorWithPass.Location = new System.Drawing.Point(6, 20);
            this.lblMotorWithPass.Name = "lblMotorWithPass";
            this.lblMotorWithPass.Size = new System.Drawing.Size(117, 16);
            this.lblMotorWithPass.TabIndex = 0;
            this.lblMotorWithPass.Text = "MA_MotorBypass:";
            // 
            // grpBoxElement
            // 
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
            this.grpBoxElement.Controls.Add(this.label2);
            this.grpBoxElement.Controls.Add(this.btnAddDI);
            this.grpBoxElement.Controls.Add(this.lblDI);
            this.grpBoxElement.Controls.Add(this.btnAddAI);
            this.grpBoxElement.Controls.Add(this.lblAI);
            this.grpBoxElement.Controls.Add(this.btnAddMotor);
            this.grpBoxElement.Controls.Add(this.lblMotor);
            this.grpBoxElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxElement.Location = new System.Drawing.Point(6, 6);
            this.grpBoxElement.Name = "grpBoxElement";
            this.grpBoxElement.Size = new System.Drawing.Size(812, 81);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "EL_Valve:";
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
            this.tabPage3.Controls.Add(this.pictureBoxBuhler2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(822, 160);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "软件信息";
            // 
            // pictureBoxBuhler2
            // 
            this.pictureBoxBuhler2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBuhler2.Image = global::GcproExtensionApp.Properties.Resources.buhlerCode;
            this.pictureBoxBuhler2.Location = new System.Drawing.Point(708, 15);
            this.pictureBoxBuhler2.Name = "pictureBoxBuhler2";
            this.pictureBoxBuhler2.Size = new System.Drawing.Size(86, 87);
            this.pictureBoxBuhler2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBuhler2.TabIndex = 18;
            this.pictureBoxBuhler2.TabStop = false;
            // 
            // AppStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 189);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AppStart";
            this.Text = "GCPRO Extension Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpBoxTempPath.ResumeLayout(false);
            this.grpBoxTempPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuhlerCode)).EndInit();
            this.GcproDB.ResumeLayout(false);
            this.GcproDB.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpBoxOther.ResumeLayout(false);
            this.grpBoxOther.PerformLayout();
            this.grpMachine.ResumeLayout(false);
            this.grpMachine.PerformLayout();
            this.grpBoxElement.ResumeLayout(false);
            this.grpBoxElement.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuhler2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion      
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Button BtnOpenGcsLibraryDB;
        internal System.Windows.Forms.Button BtnOpenProjectDB;
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
        private System.Windows.Forms.Label lblMotorWithPass;
        private System.Windows.Forms.Button btnAddVFC;
        private System.Windows.Forms.Label lblVFCAdapter;
        private System.Windows.Forms.Button btnAddMDDx;
        private System.Windows.Forms.Label lblMDDx;
        private System.Windows.Forms.Button btnAddValve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDI;
        private System.Windows.Forms.Label lblDI;
        private System.Windows.Forms.Button btnAddAI;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.Button btnAddScaleAdapter;
        private System.Windows.Forms.Label lblScaleAdapter;
        private System.Windows.Forms.Button btnAddFBAL;
        private System.Windows.Forms.Label lblFBAL;
        private System.Windows.Forms.Button btnAddMADischarger;
        private System.Windows.Forms.Label lblMADischarger;
        private System.Windows.Forms.PictureBox pictureBoxBuhler2;
        private System.Windows.Forms.GroupBox grpBoxOther;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddRoll8Stand;
        private System.Windows.Forms.Label lblRoll8Stand;
        private System.Windows.Forms.Button btnAddRollStandPhoenix;
        private System.Windows.Forms.Label lblRollStandPhoenix;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button BtnOpenGcproTempPath;
        internal System.Windows.Forms.GroupBox grpBoxTempPath;
        internal System.Windows.Forms.TextBox txtGcproTempPath;
        internal System.Windows.Forms.Label lblGcproTempPath;
    }
}

