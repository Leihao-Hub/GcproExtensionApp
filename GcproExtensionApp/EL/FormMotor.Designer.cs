using System;

namespace GcproExtensionApp
{
    partial class FormMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMotor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.LblFieldInDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblField = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LblProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabCreateMode = new System.Windows.Forms.TabControl();
            this.contextMenuStripBML = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabRule = new System.Windows.Forms.TabPage();
            this.PalGcObject = new System.Windows.Forms.Panel();
            this.BtnSetParentAndChild = new System.Windows.Forms.Button();
            this.BtnRegenerateDPNode = new System.Windows.Forms.Button();
            this.LblSymbol = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.GrUnit = new System.Windows.Forms.GroupBox();
            this.ComboUnit = new System.Windows.Forms.ComboBox();
            this.LblSpeed = new System.Windows.Forms.Label();
            this.BtnNewImpExpDef = new System.Windows.Forms.Button();
            this.TxtSymbol = new System.Windows.Forms.TextBox();
            this.BtnConnectIO = new System.Windows.Forms.Button();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.GrVFCAndAO = new System.Windows.Forms.GroupBox();
            this.TxtVFCRule = new System.Windows.Forms.TextBox();
            this.LblAOlRule = new System.Windows.Forms.Label();
            this.LblVFCIncRule = new System.Windows.Forms.Label();
            this.TxtAOIncRule = new System.Windows.Forms.TextBox();
            this.TxtVFCIncRule = new System.Windows.Forms.TextBox();
            this.LblAOIncRule = new System.Windows.Forms.Label();
            this.TxtAO = new System.Windows.Forms.TextBox();
            this.LblAO = new System.Windows.Forms.Label();
            this.BtnConnectVFC = new System.Windows.Forms.Button();
            this.TxtAORule = new System.Windows.Forms.TextBox();
            this.TxtVFCAdapter = new System.Windows.Forms.TextBox();
            this.LblVFCAdapter = new System.Windows.Forms.Label();
            this.LblVFClRule = new System.Windows.Forms.Label();
            this.LblInpRunFwd = new System.Windows.Forms.Label();
            this.LblOutpRunFwd = new System.Windows.Forms.Label();
            this.GrpSymbolRule = new System.Windows.Forms.GroupBox();
            this.LblSymbolRule = new System.Windows.Forms.Label();
            this.TxtSymbolRule = new System.Windows.Forms.TextBox();
            this.TxtSymbolIncRule = new System.Windows.Forms.TextBox();
            this.LblSymbolIncRule = new System.Windows.Forms.Label();
            this.TxtInpRunFwd = new System.Windows.Forms.TextBox();
            this.GrpDescriptionRule = new System.Windows.Forms.GroupBox();
            this.LblDescriptionRule = new System.Windows.Forms.Label();
            this.TxtDescriptionIncRule = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.TxtDescriptionRule = new System.Windows.Forms.TextBox();
            this.TxtOutpRunFwd = new System.Windows.Forms.TextBox();
            this.ChKPower = new System.Windows.Forms.CheckBox();
            this.LblEquipmentInfoType = new System.Windows.Forms.Label();
            this.TxtInHWStop = new System.Windows.Forms.TextBox();
            this.ComboEquipmentInfoType = new System.Windows.Forms.ComboBox();
            this.LblInHwstop = new System.Windows.Forms.Label();
            this.LblHornCode = new System.Windows.Forms.Label();
            this.ComboHornCode = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LblDPNode1 = new System.Windows.Forms.Label();
            this.TxtValue10 = new System.Windows.Forms.TextBox();
            this.LblDPNode2 = new System.Windows.Forms.Label();
            this.ComboDPNode1 = new System.Windows.Forms.ComboBox();
            this.ComboDPNode2 = new System.Windows.Forms.ComboBox();
            this.LblMonTime = new System.Windows.Forms.Label();
            this.TxtMonTime = new System.Windows.Forms.TextBox();
            this.LblStartDelayTime = new System.Windows.Forms.Label();
            this.TxtStartDelayTime = new System.Windows.Forms.TextBox();
            this.LblStartingTime = new System.Windows.Forms.Label();
            this.TxtStartingTime = new System.Windows.Forms.TextBox();
            this.LblStoppingTime = new System.Windows.Forms.Label();
            this.TxtStoppingTime = new System.Windows.Forms.TextBox();
            this.LblIdlingTime = new System.Windows.Forms.Label();
            this.TxtIdlingTime = new System.Windows.Forms.TextBox();
            this.LblFaultDelayTime = new System.Windows.Forms.Label();
            this.TxtFaultDelayTime = new System.Windows.Forms.TextBox();
            this.LblKW = new System.Windows.Forms.Label();
            this.GroupBoxGroupTree = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ChkStartingInterlock = new System.Windows.Forms.CheckBox();
            this.TxtValue9 = new System.Windows.Forms.TextBox();
            this.ChkRunInterlock = new System.Windows.Forms.CheckBox();
            this.TxtKW = new System.Windows.Forms.TextBox();
            this.ChkRevNotAllowed = new System.Windows.Forms.CheckBox();
            this.ChkParManual = new System.Windows.Forms.CheckBox();
            this.ChkRestartDelay = new System.Windows.Forms.CheckBox();
            this.tabBML = new System.Windows.Forms.TabPage();
            this.grpBoxExcelData = new System.Windows.Forms.GroupBox();
            this.comboStartRow = new System.Windows.Forms.ComboBox();
            this.lblStartRow = new System.Windows.Forms.Label();
            this.btnReadBML = new System.Windows.Forms.Button();
            this.dataGridBML = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboWorkSheetsBML = new System.Windows.Forms.ComboBox();
            this.grpBoxExcelColumn = new System.Windows.Forms.GroupBox();
            this.grpBoxBMLColum = new System.Windows.Forms.GroupBox();
            this.comboSectionBML = new System.Windows.Forms.ComboBox();
            this.comboPowerBML = new System.Windows.Forms.ComboBox();
            this.comboDescBML = new System.Windows.Forms.ComboBox();
            this.comboCabinetBML = new System.Windows.Forms.ComboBox();
            this.comboFloorBML = new System.Windows.Forms.ComboBox();
            this.comboTypeBML = new System.Windows.Forms.ComboBox();
            this.comboNameBML = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCabibetNo = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblBMLDescription = new System.Windows.Forms.Label();
            this.lblBMLSymbol = new System.Windows.Forms.Label();
            this.TxtExcelPath = new System.Windows.Forms.TextBox();
            this.BtnOpenProjectDB = new System.Windows.Forms.Button();
            this.LblGcproProjectPath = new System.Windows.Forms.Label();
            this.LblPanel = new System.Windows.Forms.Label();
            this.ComboPanel = new System.Windows.Forms.ComboBox();
            this.ComboElevation = new System.Windows.Forms.ComboBox();
            this.LblDiagram = new System.Windows.Forms.Label();
            this.LblElevation = new System.Windows.Forms.Label();
            this.ComboDiagram = new System.Windows.Forms.ComboBox();
            this.LblBuilding = new System.Windows.Forms.Label();
            this.ComboProcessFct = new System.Windows.Forms.ComboBox();
            this.GroupBoxSave = new System.Windows.Forms.GroupBox();
            this.ComboCreateMode = new System.Windows.Forms.ComboBox();
            this.BtnSaveAs = new System.Windows.Forms.Button();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblProcessFct = new System.Windows.Forms.Label();
            this.ComboEquipmentSubType = new System.Windows.Forms.ComboBox();
            this.LblEquipmentSubType = new System.Windows.Forms.Label();
            this.ComboBuilding = new System.Windows.Forms.ComboBox();
            this.PalCommon = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.tabCreateMode.SuspendLayout();
            this.contextMenuStripBML.SuspendLayout();
            this.tabRule.SuspendLayout();
            this.PalGcObject.SuspendLayout();
            this.GrUnit.SuspendLayout();
            this.GrVFCAndAO.SuspendLayout();
            this.GrpSymbolRule.SuspendLayout();
            this.GrpDescriptionRule.SuspendLayout();
            this.GroupBoxGroupTree.SuspendLayout();
            this.tabBML.SuspendLayout();
            this.grpBoxExcelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBML)).BeginInit();
            this.grpBoxExcelColumn.SuspendLayout();
            this.grpBoxBMLColum.SuspendLayout();
            this.GroupBoxSave.SuspendLayout();
            this.PalCommon.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblFieldInDatabase,
            this.LblField,
            this.toolStripSplitButton1,
            this.LblProcess,
            this.ProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 778);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(726, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusBar";
            // 
            // LblFieldInDatabase
            // 
            this.LblFieldInDatabase.Name = "LblFieldInDatabase";
            this.LblFieldInDatabase.Size = new System.Drawing.Size(107, 17);
            this.LblFieldInDatabase.Text = "Field in database";
            // 
            // LblField
            // 
            this.LblField.Name = "LblField";
            this.LblField.Size = new System.Drawing.Size(24, 17);
            this.LblField.Text = "    ";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 20);
            this.toolStripSplitButton1.Text = "分割符";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 22);
            this.toolStripMenuItem2.Text = "|";
            // 
            // LblProcess
            // 
            this.LblProcess.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LblProcess.Name = "LblProcess";
            this.LblProcess.Size = new System.Drawing.Size(32, 17);
            this.LblProcess.Text = "进度";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(1, 3, 10, 3);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(366, 16);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tabCreateMode
            // 
            this.tabCreateMode.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCreateMode.ContextMenuStrip = this.contextMenuStripBML;
            this.tabCreateMode.Controls.Add(this.tabRule);
            this.tabCreateMode.Controls.Add(this.tabBML);
            this.tabCreateMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabCreateMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabCreateMode.ItemSize = new System.Drawing.Size(100, 18);
            this.tabCreateMode.Location = new System.Drawing.Point(0, 0);
            this.tabCreateMode.Margin = new System.Windows.Forms.Padding(0);
            this.tabCreateMode.Name = "tabCreateMode";
            this.tabCreateMode.SelectedIndex = 0;
            this.tabCreateMode.Size = new System.Drawing.Size(726, 579);
            this.tabCreateMode.TabIndex = 107;
            this.tabCreateMode.SelectedIndexChanged += new System.EventHandler(this.tabCreateMode_SelectedIndexChanged);
            // 
            // contextMenuStripBML
            // 
            this.contextMenuStripBML.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuClearList,
            this.toolStripMenuReload,
            this.toolStripSeparator1});
            this.contextMenuStripBML.Name = "contextMenuStripBML";
            this.contextMenuStripBML.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripBML.Size = new System.Drawing.Size(151, 54);
            // 
            // toolStripMenuClearList
            // 
            this.toolStripMenuClearList.DoubleClickEnabled = true;
            this.toolStripMenuClearList.Name = "toolStripMenuClearList";
            this.toolStripMenuClearList.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuClearList.Text = "清除表格内容";
            // 
            // toolStripMenuReload
            // 
            this.toolStripMenuReload.Name = "toolStripMenuReload";
            this.toolStripMenuReload.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuReload.Text = "重新读取BML";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // tabRule
            // 
            this.tabRule.AutoScroll = true;
            this.tabRule.BackColor = System.Drawing.SystemColors.Control;
            this.tabRule.Controls.Add(this.PalGcObject);
            this.tabRule.Location = new System.Drawing.Point(4, 22);
            this.tabRule.Name = "tabRule";
            this.tabRule.Padding = new System.Windows.Forms.Padding(3);
            this.tabRule.Size = new System.Drawing.Size(718, 553);
            this.tabRule.TabIndex = 0;
            this.tabRule.Text = "设定规则创建";
            // 
            // PalGcObject
            // 
            this.PalGcObject.AutoScroll = true;
            this.PalGcObject.AutoSize = true;
            this.PalGcObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PalGcObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PalGcObject.Controls.Add(this.BtnSetParentAndChild);
            this.PalGcObject.Controls.Add(this.BtnRegenerateDPNode);
            this.PalGcObject.Controls.Add(this.LblSymbol);
            this.PalGcObject.Controls.Add(this.LblDescription);
            this.PalGcObject.Controls.Add(this.GrUnit);
            this.PalGcObject.Controls.Add(this.BtnNewImpExpDef);
            this.PalGcObject.Controls.Add(this.TxtSymbol);
            this.PalGcObject.Controls.Add(this.BtnConnectIO);
            this.PalGcObject.Controls.Add(this.TxtDescription);
            this.PalGcObject.Controls.Add(this.GrVFCAndAO);
            this.PalGcObject.Controls.Add(this.LblInpRunFwd);
            this.PalGcObject.Controls.Add(this.LblOutpRunFwd);
            this.PalGcObject.Controls.Add(this.GrpSymbolRule);
            this.PalGcObject.Controls.Add(this.TxtInpRunFwd);
            this.PalGcObject.Controls.Add(this.GrpDescriptionRule);
            this.PalGcObject.Controls.Add(this.TxtOutpRunFwd);
            this.PalGcObject.Controls.Add(this.ChKPower);
            this.PalGcObject.Controls.Add(this.LblEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.TxtInHWStop);
            this.PalGcObject.Controls.Add(this.ComboEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.LblInHwstop);
            this.PalGcObject.Controls.Add(this.LblHornCode);
            this.PalGcObject.Controls.Add(this.ComboHornCode);
            this.PalGcObject.Controls.Add(this.Label1);
            this.PalGcObject.Controls.Add(this.LblDPNode1);
            this.PalGcObject.Controls.Add(this.TxtValue10);
            this.PalGcObject.Controls.Add(this.LblDPNode2);
            this.PalGcObject.Controls.Add(this.ComboDPNode1);
            this.PalGcObject.Controls.Add(this.ComboDPNode2);
            this.PalGcObject.Controls.Add(this.LblMonTime);
            this.PalGcObject.Controls.Add(this.TxtMonTime);
            this.PalGcObject.Controls.Add(this.LblStartDelayTime);
            this.PalGcObject.Controls.Add(this.TxtStartDelayTime);
            this.PalGcObject.Controls.Add(this.LblStartingTime);
            this.PalGcObject.Controls.Add(this.TxtStartingTime);
            this.PalGcObject.Controls.Add(this.LblStoppingTime);
            this.PalGcObject.Controls.Add(this.TxtStoppingTime);
            this.PalGcObject.Controls.Add(this.LblIdlingTime);
            this.PalGcObject.Controls.Add(this.TxtIdlingTime);
            this.PalGcObject.Controls.Add(this.LblFaultDelayTime);
            this.PalGcObject.Controls.Add(this.TxtFaultDelayTime);
            this.PalGcObject.Controls.Add(this.LblKW);
            this.PalGcObject.Controls.Add(this.GroupBoxGroupTree);
            this.PalGcObject.Controls.Add(this.TxtKW);
            this.PalGcObject.Controls.Add(this.ChkRevNotAllowed);
            this.PalGcObject.Controls.Add(this.ChkParManual);
            this.PalGcObject.Controls.Add(this.ChkRestartDelay);
            this.PalGcObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalGcObject.Location = new System.Drawing.Point(3, 3);
            this.PalGcObject.Name = "PalGcObject";
            this.PalGcObject.Size = new System.Drawing.Size(712, 547);
            this.PalGcObject.TabIndex = 105;
            // 
            // BtnSetParentAndChild
            // 
            this.BtnSetParentAndChild.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSetParentAndChild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSetParentAndChild.BackgroundImage")));
            this.BtnSetParentAndChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSetParentAndChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetParentAndChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetParentAndChild.Location = new System.Drawing.Point(269, 98);
            this.BtnSetParentAndChild.Name = "BtnSetParentAndChild";
            this.BtnSetParentAndChild.Size = new System.Drawing.Size(66, 26);
            this.BtnSetParentAndChild.TabIndex = 99;
            this.BtnSetParentAndChild.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSetParentAndChild.UseVisualStyleBackColor = false;
            // 
            // BtnRegenerateDPNode
            // 
            this.BtnRegenerateDPNode.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegenerateDPNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegenerateDPNode.BackgroundImage")));
            this.BtnRegenerateDPNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRegenerateDPNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegenerateDPNode.Location = new System.Drawing.Point(69, 223);
            this.BtnRegenerateDPNode.Name = "BtnRegenerateDPNode";
            this.BtnRegenerateDPNode.Size = new System.Drawing.Size(53, 30);
            this.BtnRegenerateDPNode.TabIndex = 88;
            this.BtnRegenerateDPNode.UseVisualStyleBackColor = false;
            this.BtnRegenerateDPNode.Click += new System.EventHandler(this.BtnRegenerateDPNode_Click);
            // 
            // LblSymbol
            // 
            this.LblSymbol.AutoSize = true;
            this.LblSymbol.Location = new System.Drawing.Point(3, 7);
            this.LblSymbol.Name = "LblSymbol";
            this.LblSymbol.Size = new System.Drawing.Size(55, 13);
            this.LblSymbol.TabIndex = 0;
            this.LblSymbol.Text = "电机名称";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(239, 7);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(55, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "电机描述";
            // 
            // GrUnit
            // 
            this.GrUnit.Controls.Add(this.ComboUnit);
            this.GrUnit.Controls.Add(this.LblSpeed);
            this.GrUnit.Location = new System.Drawing.Point(460, 130);
            this.GrUnit.Name = "GrUnit";
            this.GrUnit.Size = new System.Drawing.Size(163, 48);
            this.GrUnit.TabIndex = 62;
            this.GrUnit.TabStop = false;
            this.GrUnit.Text = "WinCos:单位";
            // 
            // ComboUnit
            // 
            this.ComboUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboUnit.FormattingEnabled = true;
            this.ComboUnit.Location = new System.Drawing.Point(58, 16);
            this.ComboUnit.Name = "ComboUnit";
            this.ComboUnit.Size = new System.Drawing.Size(99, 21);
            this.ComboUnit.TabIndex = 99;
            this.ComboUnit.MouseEnter += new System.EventHandler(this.ComboUnit_MouseEnter);
            // 
            // LblSpeed
            // 
            this.LblSpeed.AutoSize = true;
            this.LblSpeed.Location = new System.Drawing.Point(6, 19);
            this.LblSpeed.Name = "LblSpeed";
            this.LblSpeed.Size = new System.Drawing.Size(55, 13);
            this.LblSpeed.TabIndex = 99;
            this.LblSpeed.Text = "速度单位";
            // 
            // BtnNewImpExpDef
            // 
            this.BtnNewImpExpDef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewImpExpDef.BackgroundImage")));
            this.BtnNewImpExpDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewImpExpDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewImpExpDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewImpExpDef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewImpExpDef.Location = new System.Drawing.Point(6, 223);
            this.BtnNewImpExpDef.Name = "BtnNewImpExpDef";
            this.BtnNewImpExpDef.Size = new System.Drawing.Size(49, 30);
            this.BtnNewImpExpDef.TabIndex = 76;
            this.BtnNewImpExpDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewImpExpDef.UseVisualStyleBackColor = true;
            this.BtnNewImpExpDef.Click += new System.EventHandler(this.BtnNewImpExpDef_Click);
            // 
            // TxtSymbol
            // 
            this.TxtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSymbol.Location = new System.Drawing.Point(5, 23);
            this.TxtSymbol.Name = "TxtSymbol";
            this.TxtSymbol.Size = new System.Drawing.Size(137, 13);
            this.TxtSymbol.TabIndex = 2;
            this.TxtSymbol.TextChanged += new System.EventHandler(this.TxtSymbol_TextChanged);
            this.TxtSymbol.MouseEnter += new System.EventHandler(this.TxtSymbol_MouseEnter);
            // 
            // BtnConnectIO
            // 
            this.BtnConnectIO.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConnectIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConnectIO.BackgroundImage")));
            this.BtnConnectIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConnectIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnectIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnectIO.Location = new System.Drawing.Point(376, 98);
            this.BtnConnectIO.Name = "BtnConnectIO";
            this.BtnConnectIO.Size = new System.Drawing.Size(66, 26);
            this.BtnConnectIO.TabIndex = 98;
            this.BtnConnectIO.UseVisualStyleBackColor = false;
            // 
            // TxtDescription
            // 
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescription.Location = new System.Drawing.Point(242, 23);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(346, 13);
            this.TxtDescription.TabIndex = 3;
            this.TxtDescription.MouseEnter += new System.EventHandler(this.TxtDescription_MouseEnter);
            // 
            // GrVFCAndAO
            // 
            this.GrVFCAndAO.Controls.Add(this.TxtVFCRule);
            this.GrVFCAndAO.Controls.Add(this.LblAOlRule);
            this.GrVFCAndAO.Controls.Add(this.LblVFCIncRule);
            this.GrVFCAndAO.Controls.Add(this.TxtAOIncRule);
            this.GrVFCAndAO.Controls.Add(this.TxtVFCIncRule);
            this.GrVFCAndAO.Controls.Add(this.LblAOIncRule);
            this.GrVFCAndAO.Controls.Add(this.TxtAO);
            this.GrVFCAndAO.Controls.Add(this.LblAO);
            this.GrVFCAndAO.Controls.Add(this.BtnConnectVFC);
            this.GrVFCAndAO.Controls.Add(this.TxtAORule);
            this.GrVFCAndAO.Controls.Add(this.TxtVFCAdapter);
            this.GrVFCAndAO.Controls.Add(this.LblVFCAdapter);
            this.GrVFCAndAO.Controls.Add(this.LblVFClRule);
            this.GrVFCAndAO.Location = new System.Drawing.Point(1, 130);
            this.GrVFCAndAO.Name = "GrVFCAndAO";
            this.GrVFCAndAO.Size = new System.Drawing.Size(453, 87);
            this.GrVFCAndAO.TabIndex = 97;
            this.GrVFCAndAO.TabStop = false;
            this.GrVFCAndAO.Text = "变频和AO";
            // 
            // TxtVFCRule
            // 
            this.TxtVFCRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVFCRule.Location = new System.Drawing.Point(243, 16);
            this.TxtVFCRule.Name = "TxtVFCRule";
            this.TxtVFCRule.Size = new System.Drawing.Size(66, 13);
            this.TxtVFCRule.TabIndex = 75;
            this.TxtVFCRule.Visible = false;
            this.TxtVFCRule.TextChanged += new System.EventHandler(this.TxtVFCRule_TextChanged);
            // 
            // LblAOlRule
            // 
            this.LblAOlRule.AutoSize = true;
            this.LblAOlRule.Location = new System.Drawing.Point(187, 35);
            this.LblAOlRule.Name = "LblAOlRule";
            this.LblAOlRule.Size = new System.Drawing.Size(55, 13);
            this.LblAOlRule.TabIndex = 84;
            this.LblAOlRule.Text = "规则字段";
            this.LblAOlRule.Visible = false;
            // 
            // LblVFCIncRule
            // 
            this.LblVFCIncRule.AutoSize = true;
            this.LblVFCIncRule.Location = new System.Drawing.Point(316, 17);
            this.LblVFCIncRule.Name = "LblVFCIncRule";
            this.LblVFCIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblVFCIncRule.TabIndex = 77;
            this.LblVFCIncRule.Text = "递增规则";
            this.LblVFCIncRule.Visible = false;
            // 
            // TxtAOIncRule
            // 
            this.TxtAOIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAOIncRule.Location = new System.Drawing.Point(375, 35);
            this.TxtAOIncRule.Name = "TxtAOIncRule";
            this.TxtAOIncRule.Size = new System.Drawing.Size(66, 13);
            this.TxtAOIncRule.TabIndex = 86;
            this.TxtAOIncRule.Visible = false;
            this.TxtAOIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAOIncRule_KeyDown);
            // 
            // TxtVFCIncRule
            // 
            this.TxtVFCIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVFCIncRule.Location = new System.Drawing.Point(375, 16);
            this.TxtVFCIncRule.Name = "TxtVFCIncRule";
            this.TxtVFCIncRule.Size = new System.Drawing.Size(66, 13);
            this.TxtVFCIncRule.TabIndex = 76;
            this.TxtVFCIncRule.Visible = false;
            this.TxtVFCIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtVFCIncRule_KeyDown);
            // 
            // LblAOIncRule
            // 
            this.LblAOIncRule.AutoSize = true;
            this.LblAOIncRule.Location = new System.Drawing.Point(316, 35);
            this.LblAOIncRule.Name = "LblAOIncRule";
            this.LblAOIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblAOIncRule.TabIndex = 87;
            this.LblAOIncRule.Text = "递增规则";
            this.LblAOIncRule.Visible = false;
            // 
            // TxtAO
            // 
            this.TxtAO.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtAO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAO.Location = new System.Drawing.Point(68, 36);
            this.TxtAO.Name = "TxtAO";
            this.TxtAO.Size = new System.Drawing.Size(116, 13);
            this.TxtAO.TabIndex = 67;
            this.TxtAO.MouseEnter += new System.EventHandler(this.TxtAO_MouseEnter);
            // 
            // LblAO
            // 
            this.LblAO.AutoSize = true;
            this.LblAO.Location = new System.Drawing.Point(2, 37);
            this.LblAO.Name = "LblAO";
            this.LblAO.Size = new System.Drawing.Size(67, 13);
            this.LblAO.TabIndex = 66;
            this.LblAO.Text = "模拟量输出";
            // 
            // BtnConnectVFC
            // 
            this.BtnConnectVFC.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConnectVFC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConnectVFC.BackgroundImage")));
            this.BtnConnectVFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConnectVFC.Enabled = false;
            this.BtnConnectVFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnectVFC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnectVFC.Location = new System.Drawing.Point(375, 55);
            this.BtnConnectVFC.Name = "BtnConnectVFC";
            this.BtnConnectVFC.Size = new System.Drawing.Size(66, 26);
            this.BtnConnectVFC.TabIndex = 57;
            this.BtnConnectVFC.UseVisualStyleBackColor = false;
            // 
            // TxtAORule
            // 
            this.TxtAORule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAORule.Location = new System.Drawing.Point(243, 35);
            this.TxtAORule.Name = "TxtAORule";
            this.TxtAORule.Size = new System.Drawing.Size(66, 13);
            this.TxtAORule.TabIndex = 85;
            this.TxtAORule.Visible = false;
            this.TxtAORule.TextChanged += new System.EventHandler(this.TxtAORule_TextChanged);
            // 
            // TxtVFCAdapter
            // 
            this.TxtVFCAdapter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtVFCAdapter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVFCAdapter.Enabled = false;
            this.TxtVFCAdapter.Location = new System.Drawing.Point(68, 17);
            this.TxtVFCAdapter.Name = "TxtVFCAdapter";
            this.TxtVFCAdapter.Size = new System.Drawing.Size(116, 13);
            this.TxtVFCAdapter.TabIndex = 65;
            this.TxtVFCAdapter.MouseEnter += new System.EventHandler(this.TxtVFCAdapter_MouseEnter);
            // 
            // LblVFCAdapter
            // 
            this.LblVFCAdapter.AutoSize = true;
            this.LblVFCAdapter.Location = new System.Drawing.Point(2, 17);
            this.LblVFCAdapter.Name = "LblVFCAdapter";
            this.LblVFCAdapter.Size = new System.Drawing.Size(67, 13);
            this.LblVFCAdapter.TabIndex = 64;
            this.LblVFCAdapter.Text = "变频适配器";
            // 
            // LblVFClRule
            // 
            this.LblVFClRule.AutoSize = true;
            this.LblVFClRule.Location = new System.Drawing.Point(187, 17);
            this.LblVFClRule.Name = "LblVFClRule";
            this.LblVFClRule.Size = new System.Drawing.Size(55, 13);
            this.LblVFClRule.TabIndex = 74;
            this.LblVFClRule.Text = "规则字段";
            this.LblVFClRule.Visible = false;
            // 
            // LblInpRunFwd
            // 
            this.LblInpRunFwd.AutoSize = true;
            this.LblInpRunFwd.Location = new System.Drawing.Point(2, 50);
            this.LblInpRunFwd.Name = "LblInpRunFwd";
            this.LblInpRunFwd.Size = new System.Drawing.Size(79, 13);
            this.LblInpRunFwd.TabIndex = 4;
            this.LblInpRunFwd.Text = "正向运行反馈";
            // 
            // LblOutpRunFwd
            // 
            this.LblOutpRunFwd.AutoSize = true;
            this.LblOutpRunFwd.Location = new System.Drawing.Point(239, 50);
            this.LblOutpRunFwd.Name = "LblOutpRunFwd";
            this.LblOutpRunFwd.Size = new System.Drawing.Size(79, 13);
            this.LblOutpRunFwd.TabIndex = 5;
            this.LblOutpRunFwd.Text = "正向启动控制";
            // 
            // GrpSymbolRule
            // 
            this.GrpSymbolRule.Controls.Add(this.LblSymbolRule);
            this.GrpSymbolRule.Controls.Add(this.TxtSymbolRule);
            this.GrpSymbolRule.Controls.Add(this.TxtSymbolIncRule);
            this.GrpSymbolRule.Controls.Add(this.LblSymbolIncRule);
            this.GrpSymbolRule.Location = new System.Drawing.Point(148, 7);
            this.GrpSymbolRule.Name = "GrpSymbolRule";
            this.GrpSymbolRule.Size = new System.Drawing.Size(78, 88);
            this.GrpSymbolRule.TabIndex = 75;
            this.GrpSymbolRule.TabStop = false;
            this.GrpSymbolRule.Text = "名称规则";
            // 
            // LblSymbolRule
            // 
            this.LblSymbolRule.AutoSize = true;
            this.LblSymbolRule.Location = new System.Drawing.Point(8, 14);
            this.LblSymbolRule.Name = "LblSymbolRule";
            this.LblSymbolRule.Size = new System.Drawing.Size(55, 13);
            this.LblSymbolRule.TabIndex = 8;
            this.LblSymbolRule.Text = "规则字段";
            // 
            // TxtSymbolRule
            // 
            this.TxtSymbolRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSymbolRule.Location = new System.Drawing.Point(6, 30);
            this.TxtSymbolRule.Name = "TxtSymbolRule";
            this.TxtSymbolRule.Size = new System.Drawing.Size(66, 13);
            this.TxtSymbolRule.TabIndex = 10;
            this.TxtSymbolRule.TextChanged += new System.EventHandler(this.TxtSymbolRule_TextChanged);
            // 
            // TxtSymbolIncRule
            // 
            this.TxtSymbolIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSymbolIncRule.Location = new System.Drawing.Point(6, 67);
            this.TxtSymbolIncRule.Name = "TxtSymbolIncRule";
            this.TxtSymbolIncRule.Size = new System.Drawing.Size(66, 13);
            this.TxtSymbolIncRule.TabIndex = 71;
            this.TxtSymbolIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSymbolIncRule_KeyDown);
            // 
            // LblSymbolIncRule
            // 
            this.LblSymbolIncRule.AutoSize = true;
            this.LblSymbolIncRule.Location = new System.Drawing.Point(4, 50);
            this.LblSymbolIncRule.Name = "LblSymbolIncRule";
            this.LblSymbolIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblSymbolIncRule.TabIndex = 70;
            this.LblSymbolIncRule.Text = "递增规则";
            // 
            // TxtInpRunFwd
            // 
            this.TxtInpRunFwd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtInpRunFwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInpRunFwd.Enabled = false;
            this.TxtInpRunFwd.Location = new System.Drawing.Point(5, 70);
            this.TxtInpRunFwd.Name = "TxtInpRunFwd";
            this.TxtInpRunFwd.Size = new System.Drawing.Size(137, 13);
            this.TxtInpRunFwd.TabIndex = 6;
            this.TxtInpRunFwd.MouseEnter += new System.EventHandler(this.TxtInpRunFwd_MouseEnter);
            // 
            // GrpDescriptionRule
            // 
            this.GrpDescriptionRule.Controls.Add(this.LblDescriptionRule);
            this.GrpDescriptionRule.Controls.Add(this.TxtDescriptionIncRule);
            this.GrpDescriptionRule.Controls.Add(this.Lbl);
            this.GrpDescriptionRule.Controls.Add(this.TxtDescriptionRule);
            this.GrpDescriptionRule.Location = new System.Drawing.Point(600, 7);
            this.GrpDescriptionRule.Name = "GrpDescriptionRule";
            this.GrpDescriptionRule.Size = new System.Drawing.Size(78, 88);
            this.GrpDescriptionRule.TabIndex = 74;
            this.GrpDescriptionRule.TabStop = false;
            this.GrpDescriptionRule.Text = "描述规则";
            // 
            // LblDescriptionRule
            // 
            this.LblDescriptionRule.AutoSize = true;
            this.LblDescriptionRule.Location = new System.Drawing.Point(7, 14);
            this.LblDescriptionRule.Name = "LblDescriptionRule";
            this.LblDescriptionRule.Size = new System.Drawing.Size(55, 13);
            this.LblDescriptionRule.TabIndex = 9;
            this.LblDescriptionRule.Text = "规则字段";
            // 
            // TxtDescriptionIncRule
            // 
            this.TxtDescriptionIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescriptionIncRule.Location = new System.Drawing.Point(6, 67);
            this.TxtDescriptionIncRule.Name = "TxtDescriptionIncRule";
            this.TxtDescriptionIncRule.Size = new System.Drawing.Size(66, 13);
            this.TxtDescriptionIncRule.TabIndex = 72;
            this.TxtDescriptionIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescriptionIncRule_KeyDown);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(6, 50);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(55, 13);
            this.Lbl.TabIndex = 73;
            this.Lbl.Text = "递增规则";
            // 
            // TxtDescriptionRule
            // 
            this.TxtDescriptionRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescriptionRule.Location = new System.Drawing.Point(6, 30);
            this.TxtDescriptionRule.Name = "TxtDescriptionRule";
            this.TxtDescriptionRule.Size = new System.Drawing.Size(66, 13);
            this.TxtDescriptionRule.TabIndex = 11;
            this.TxtDescriptionRule.TextChanged += new System.EventHandler(this.TxtDescriptionRule_TextChanged);
            // 
            // TxtOutpRunFwd
            // 
            this.TxtOutpRunFwd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtOutpRunFwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOutpRunFwd.Enabled = false;
            this.TxtOutpRunFwd.Location = new System.Drawing.Point(242, 70);
            this.TxtOutpRunFwd.Name = "TxtOutpRunFwd";
            this.TxtOutpRunFwd.Size = new System.Drawing.Size(136, 13);
            this.TxtOutpRunFwd.TabIndex = 7;
            this.TxtOutpRunFwd.MouseEnter += new System.EventHandler(this.TxtOutpRunFwd_MouseEnter);
            // 
            // ChKPower
            // 
            this.ChKPower.AutoSize = true;
            this.ChKPower.Location = new System.Drawing.Point(261, 351);
            this.ChKPower.Name = "ChKPower";
            this.ChKPower.Size = new System.Drawing.Size(74, 17);
            this.ChKPower.TabIndex = 68;
            this.ChKPower.Text = "功率消耗";
            this.ChKPower.UseVisualStyleBackColor = true;
            this.ChKPower.CheckedChanged += new System.EventHandler(this.ChKPower_CheckedChanged);
            this.ChKPower.MouseEnter += new System.EventHandler(this.ChKPower_MouseEnter);
            // 
            // LblEquipmentInfoType
            // 
            this.LblEquipmentInfoType.AutoSize = true;
            this.LblEquipmentInfoType.Location = new System.Drawing.Point(2, 270);
            this.LblEquipmentInfoType.Name = "LblEquipmentInfoType";
            this.LblEquipmentInfoType.Size = new System.Drawing.Size(79, 13);
            this.LblEquipmentInfoType.TabIndex = 12;
            this.LblEquipmentInfoType.Text = "设备信息类型";
            // 
            // TxtInHWStop
            // 
            this.TxtInHWStop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInHWStop.Location = new System.Drawing.Point(29, 90);
            this.TxtInHWStop.Name = "TxtInHWStop";
            this.TxtInHWStop.Size = new System.Drawing.Size(113, 13);
            this.TxtInHWStop.TabIndex = 63;
            this.TxtInHWStop.MouseEnter += new System.EventHandler(this.TxtInHWStop_MouseEnter);
            // 
            // ComboEquipmentInfoType
            // 
            this.ComboEquipmentInfoType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboEquipmentInfoType.FormattingEnabled = true;
            this.ComboEquipmentInfoType.IntegralHeight = false;
            this.ComboEquipmentInfoType.Location = new System.Drawing.Point(97, 267);
            this.ComboEquipmentInfoType.Name = "ComboEquipmentInfoType";
            this.ComboEquipmentInfoType.Size = new System.Drawing.Size(357, 21);
            this.ComboEquipmentInfoType.TabIndex = 13;
            this.ComboEquipmentInfoType.MouseEnter += new System.EventHandler(this.ComboEquipmentInfoType_MouseEnter);
            // 
            // LblInHwstop
            // 
            this.LblInHwstop.AutoSize = true;
            this.LblInHwstop.Location = new System.Drawing.Point(2, 90);
            this.LblInHwstop.Name = "LblInHwstop";
            this.LblInHwstop.Size = new System.Drawing.Size(31, 13);
            this.LblInHwstop.TabIndex = 62;
            this.LblInHwstop.Text = "急停";
            // 
            // LblHornCode
            // 
            this.LblHornCode.AutoSize = true;
            this.LblHornCode.Location = new System.Drawing.Point(2, 295);
            this.LblHornCode.Name = "LblHornCode";
            this.LblHornCode.Size = new System.Drawing.Size(55, 13);
            this.LblHornCode.TabIndex = 14;
            this.LblHornCode.Text = "报警喇叭";
            // 
            // ComboHornCode
            // 
            this.ComboHornCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHornCode.FormattingEnabled = true;
            this.ComboHornCode.Location = new System.Drawing.Point(97, 291);
            this.ComboHornCode.Name = "ComboHornCode";
            this.ComboHornCode.Size = new System.Drawing.Size(146, 21);
            this.ComboHornCode.TabIndex = 15;
            this.ComboHornCode.MouseEnter += new System.EventHandler(this.ComboHornCode_MouseEnter);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(336, 296);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 60;
            this.Label1.Text = "Value10";
            // 
            // LblDPNode1
            // 
            this.LblDPNode1.AutoSize = true;
            this.LblDPNode1.Location = new System.Drawing.Point(2, 320);
            this.LblDPNode1.Name = "LblDPNode1";
            this.LblDPNode1.Size = new System.Drawing.Size(52, 13);
            this.LblDPNode1.TabIndex = 16;
            this.LblDPNode1.Text = "DP站点1";
            // 
            // TxtValue10
            // 
            this.TxtValue10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValue10.Enabled = false;
            this.TxtValue10.Location = new System.Drawing.Point(340, 316);
            this.TxtValue10.Name = "TxtValue10";
            this.TxtValue10.Size = new System.Drawing.Size(36, 13);
            this.TxtValue10.TabIndex = 59;
            this.TxtValue10.Text = "2";
            // 
            // LblDPNode2
            // 
            this.LblDPNode2.AutoSize = true;
            this.LblDPNode2.Location = new System.Drawing.Point(2, 343);
            this.LblDPNode2.Name = "LblDPNode2";
            this.LblDPNode2.Size = new System.Drawing.Size(52, 13);
            this.LblDPNode2.TabIndex = 17;
            this.LblDPNode2.Text = "DP站点2";
            // 
            // ComboDPNode1
            // 
            this.ComboDPNode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboDPNode1.FormattingEnabled = true;
            this.ComboDPNode1.Location = new System.Drawing.Point(97, 314);
            this.ComboDPNode1.Name = "ComboDPNode1";
            this.ComboDPNode1.Size = new System.Drawing.Size(146, 21);
            this.ComboDPNode1.TabIndex = 18;
            this.ComboDPNode1.MouseEnter += new System.EventHandler(this.ComboDPNode1_MouseEnter);
            // 
            // ComboDPNode2
            // 
            this.ComboDPNode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboDPNode2.FormattingEnabled = true;
            this.ComboDPNode2.Location = new System.Drawing.Point(97, 338);
            this.ComboDPNode2.Name = "ComboDPNode2";
            this.ComboDPNode2.Size = new System.Drawing.Size(146, 21);
            this.ComboDPNode2.TabIndex = 19;
            this.ComboDPNode2.MouseEnter += new System.EventHandler(this.ComboDPNode2_MouseEnter);
            // 
            // LblMonTime
            // 
            this.LblMonTime.AutoSize = true;
            this.LblMonTime.Location = new System.Drawing.Point(2, 366);
            this.LblMonTime.Name = "LblMonTime";
            this.LblMonTime.Size = new System.Drawing.Size(66, 13);
            this.LblMonTime.TabIndex = 20;
            this.LblMonTime.Text = "监控时间[s]";
            // 
            // TxtMonTime
            // 
            this.TxtMonTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMonTime.Location = new System.Drawing.Point(97, 366);
            this.TxtMonTime.Name = "TxtMonTime";
            this.TxtMonTime.Size = new System.Drawing.Size(56, 13);
            this.TxtMonTime.TabIndex = 21;
            this.TxtMonTime.Text = "6.0";
            this.TxtMonTime.TextChanged += new System.EventHandler(this.TxtMonTime_TextChanged);
            this.TxtMonTime.MouseEnter += new System.EventHandler(this.TxtMonTime_MouseEnter);
            // 
            // LblStartDelayTime
            // 
            this.LblStartDelayTime.AutoSize = true;
            this.LblStartDelayTime.Location = new System.Drawing.Point(2, 385);
            this.LblStartDelayTime.Name = "LblStartDelayTime";
            this.LblStartDelayTime.Size = new System.Drawing.Size(66, 13);
            this.LblStartDelayTime.TabIndex = 22;
            this.LblStartDelayTime.Text = "启动延迟[s]";
            // 
            // TxtStartDelayTime
            // 
            this.TxtStartDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStartDelayTime.Location = new System.Drawing.Point(97, 385);
            this.TxtStartDelayTime.Name = "TxtStartDelayTime";
            this.TxtStartDelayTime.Size = new System.Drawing.Size(56, 13);
            this.TxtStartDelayTime.TabIndex = 23;
            this.TxtStartDelayTime.Text = "0.0";
            this.TxtStartDelayTime.MouseEnter += new System.EventHandler(this.TxtStartDelayTime_MouseEnter);
            // 
            // LblStartingTime
            // 
            this.LblStartingTime.AutoSize = true;
            this.LblStartingTime.Location = new System.Drawing.Point(2, 402);
            this.LblStartingTime.Name = "LblStartingTime";
            this.LblStartingTime.Size = new System.Drawing.Size(66, 13);
            this.LblStartingTime.TabIndex = 24;
            this.LblStartingTime.Text = "启动时间[s]";
            // 
            // TxtStartingTime
            // 
            this.TxtStartingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStartingTime.Location = new System.Drawing.Point(97, 402);
            this.TxtStartingTime.Name = "TxtStartingTime";
            this.TxtStartingTime.Size = new System.Drawing.Size(56, 13);
            this.TxtStartingTime.TabIndex = 25;
            this.TxtStartingTime.Text = "3.0";
            this.TxtStartingTime.MouseEnter += new System.EventHandler(this.TxtStartingTime_MouseEnter);
            // 
            // LblStoppingTime
            // 
            this.LblStoppingTime.AutoSize = true;
            this.LblStoppingTime.Location = new System.Drawing.Point(2, 421);
            this.LblStoppingTime.Name = "LblStoppingTime";
            this.LblStoppingTime.Size = new System.Drawing.Size(66, 13);
            this.LblStoppingTime.TabIndex = 26;
            this.LblStoppingTime.Text = "停止时间[s]";
            // 
            // TxtStoppingTime
            // 
            this.TxtStoppingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtStoppingTime.Location = new System.Drawing.Point(97, 421);
            this.TxtStoppingTime.Name = "TxtStoppingTime";
            this.TxtStoppingTime.Size = new System.Drawing.Size(56, 13);
            this.TxtStoppingTime.TabIndex = 27;
            this.TxtStoppingTime.Text = "0.0";
            this.TxtStoppingTime.MouseEnter += new System.EventHandler(this.TxtStoppingTime_MouseEnter);
            // 
            // LblIdlingTime
            // 
            this.LblIdlingTime.AutoSize = true;
            this.LblIdlingTime.Location = new System.Drawing.Point(2, 439);
            this.LblIdlingTime.Name = "LblIdlingTime";
            this.LblIdlingTime.Size = new System.Drawing.Size(66, 13);
            this.LblIdlingTime.TabIndex = 28;
            this.LblIdlingTime.Text = "空转时间[s]";
            // 
            // TxtIdlingTime
            // 
            this.TxtIdlingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdlingTime.Location = new System.Drawing.Point(97, 439);
            this.TxtIdlingTime.Name = "TxtIdlingTime";
            this.TxtIdlingTime.Size = new System.Drawing.Size(56, 13);
            this.TxtIdlingTime.TabIndex = 29;
            this.TxtIdlingTime.Text = "1.0";
            this.TxtIdlingTime.MouseEnter += new System.EventHandler(this.TxtIdlingTime_MouseEnter);
            // 
            // LblFaultDelayTime
            // 
            this.LblFaultDelayTime.AutoSize = true;
            this.LblFaultDelayTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblFaultDelayTime.Location = new System.Drawing.Point(2, 456);
            this.LblFaultDelayTime.Name = "LblFaultDelayTime";
            this.LblFaultDelayTime.Size = new System.Drawing.Size(90, 13);
            this.LblFaultDelayTime.TabIndex = 30;
            this.LblFaultDelayTime.Text = "报警延迟时间[s]";
            // 
            // TxtFaultDelayTime
            // 
            this.TxtFaultDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFaultDelayTime.Location = new System.Drawing.Point(97, 456);
            this.TxtFaultDelayTime.Name = "TxtFaultDelayTime";
            this.TxtFaultDelayTime.Size = new System.Drawing.Size(56, 13);
            this.TxtFaultDelayTime.TabIndex = 31;
            this.TxtFaultDelayTime.Text = "3.0";
            this.TxtFaultDelayTime.MouseEnter += new System.EventHandler(this.TxtFaultDelayTime_MouseEnter);
            // 
            // LblKW
            // 
            this.LblKW.AutoSize = true;
            this.LblKW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblKW.Location = new System.Drawing.Point(2, 476);
            this.LblKW.Name = "LblKW";
            this.LblKW.Size = new System.Drawing.Size(75, 13);
            this.LblKW.TabIndex = 32;
            this.LblKW.Text = "额定功率[kw]";
            // 
            // GroupBoxGroupTree
            // 
            this.GroupBoxGroupTree.Controls.Add(this.Label2);
            this.GroupBoxGroupTree.Controls.Add(this.ChkStartingInterlock);
            this.GroupBoxGroupTree.Controls.Add(this.TxtValue9);
            this.GroupBoxGroupTree.Controls.Add(this.ChkRunInterlock);
            this.GroupBoxGroupTree.Location = new System.Drawing.Point(214, 447);
            this.GroupBoxGroupTree.Name = "GroupBoxGroupTree";
            this.GroupBoxGroupTree.Size = new System.Drawing.Size(121, 53);
            this.GroupBoxGroupTree.TabIndex = 40;
            this.GroupBoxGroupTree.TabStop = false;
            this.GroupBoxGroupTree.Text = "组内连锁";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(77, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "Value9";
            // 
            // ChkStartingInterlock
            // 
            this.ChkStartingInterlock.AutoSize = true;
            this.ChkStartingInterlock.Location = new System.Drawing.Point(6, 31);
            this.ChkStartingInterlock.Name = "ChkStartingInterlock";
            this.ChkStartingInterlock.Size = new System.Drawing.Size(50, 17);
            this.ChkStartingInterlock.TabIndex = 42;
            this.ChkStartingInterlock.Text = "启动";
            this.ChkStartingInterlock.UseVisualStyleBackColor = true;
            this.ChkStartingInterlock.CheckedChanged += new System.EventHandler(this.ChkStartingInterlock_CheckedChanged);
            this.ChkStartingInterlock.MouseEnter += new System.EventHandler(this.ChkStartingInterlock_MouseEnter);
            // 
            // TxtValue9
            // 
            this.TxtValue9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValue9.Enabled = false;
            this.TxtValue9.Location = new System.Drawing.Point(79, 31);
            this.TxtValue9.Name = "TxtValue9";
            this.TxtValue9.Size = new System.Drawing.Size(36, 13);
            this.TxtValue9.TabIndex = 60;
            // 
            // ChkRunInterlock
            // 
            this.ChkRunInterlock.AutoSize = true;
            this.ChkRunInterlock.Checked = true;
            this.ChkRunInterlock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRunInterlock.Location = new System.Drawing.Point(6, 15);
            this.ChkRunInterlock.Name = "ChkRunInterlock";
            this.ChkRunInterlock.Size = new System.Drawing.Size(50, 17);
            this.ChkRunInterlock.TabIndex = 41;
            this.ChkRunInterlock.Text = "运行";
            this.ChkRunInterlock.UseVisualStyleBackColor = true;
            this.ChkRunInterlock.CheckedChanged += new System.EventHandler(this.ChkRunInterlock_CheckedChanged);
            this.ChkRunInterlock.MouseEnter += new System.EventHandler(this.ChkRunInterlock_MouseEnter);
            // 
            // TxtKW
            // 
            this.TxtKW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKW.Location = new System.Drawing.Point(97, 476);
            this.TxtKW.Name = "TxtKW";
            this.TxtKW.Size = new System.Drawing.Size(56, 13);
            this.TxtKW.TabIndex = 33;
            this.TxtKW.MouseEnter += new System.EventHandler(this.TxtKW_MouseEnter);
            // 
            // ChkRevNotAllowed
            // 
            this.ChkRevNotAllowed.AutoSize = true;
            this.ChkRevNotAllowed.Location = new System.Drawing.Point(261, 332);
            this.ChkRevNotAllowed.Name = "ChkRevNotAllowed";
            this.ChkRevNotAllowed.Size = new System.Drawing.Size(74, 17);
            this.ChkRevNotAllowed.TabIndex = 39;
            this.ChkRevNotAllowed.Text = "禁止反转";
            this.ChkRevNotAllowed.UseVisualStyleBackColor = true;
            this.ChkRevNotAllowed.CheckedChanged += new System.EventHandler(this.ChkRevNotAllowed_CheckedChanged);
            this.ChkRevNotAllowed.MouseEnter += new System.EventHandler(this.ChkRevNotAllowed_MouseEnter);
            // 
            // ChkParManual
            // 
            this.ChkParManual.AutoSize = true;
            this.ChkParManual.Checked = true;
            this.ChkParManual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkParManual.Location = new System.Drawing.Point(261, 295);
            this.ChkParManual.Name = "ChkParManual";
            this.ChkParManual.Size = new System.Drawing.Size(74, 17);
            this.ChkParManual.TabIndex = 37;
            this.ChkParManual.Text = "允许手动";
            this.ChkParManual.UseVisualStyleBackColor = true;
            this.ChkParManual.CheckedChanged += new System.EventHandler(this.ChkParManual_CheckedChanged);
            this.ChkParManual.MouseEnter += new System.EventHandler(this.ChkParManual_MouseEnter);
            // 
            // ChkRestartDelay
            // 
            this.ChkRestartDelay.AutoSize = true;
            this.ChkRestartDelay.Location = new System.Drawing.Point(261, 314);
            this.ChkRestartDelay.Name = "ChkRestartDelay";
            this.ChkRestartDelay.Size = new System.Drawing.Size(74, 17);
            this.ChkRestartDelay.TabIndex = 38;
            this.ChkRestartDelay.Text = "启动延迟";
            this.ChkRestartDelay.UseVisualStyleBackColor = true;
            this.ChkRestartDelay.CheckedChanged += new System.EventHandler(this.ChkRestartDelay_CheckedChanged);
            this.ChkRestartDelay.MouseEnter += new System.EventHandler(this.ChkRestartDelay_MouseEnter);
            // 
            // tabBML
            // 
            this.tabBML.AutoScroll = true;
            this.tabBML.BackColor = System.Drawing.SystemColors.Control;
            this.tabBML.ContextMenuStrip = this.contextMenuStripBML;
            this.tabBML.Controls.Add(this.grpBoxExcelData);
            this.tabBML.Controls.Add(this.grpBoxExcelColumn);
            this.tabBML.Location = new System.Drawing.Point(4, 22);
            this.tabBML.Margin = new System.Windows.Forms.Padding(0);
            this.tabBML.Name = "tabBML";
            this.tabBML.Padding = new System.Windows.Forms.Padding(3);
            this.tabBML.Size = new System.Drawing.Size(718, 553);
            this.tabBML.TabIndex = 1;
            this.tabBML.Text = "通过BML创建";
            // 
            // grpBoxExcelData
            // 
            this.grpBoxExcelData.Controls.Add(this.comboStartRow);
            this.grpBoxExcelData.Controls.Add(this.lblStartRow);
            this.grpBoxExcelData.Controls.Add(this.btnReadBML);
            this.grpBoxExcelData.Controls.Add(this.dataGridBML);
            this.grpBoxExcelData.Controls.Add(this.label3);
            this.grpBoxExcelData.Controls.Add(this.comboWorkSheetsBML);
            this.grpBoxExcelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxExcelData.Location = new System.Drawing.Point(3, 121);
            this.grpBoxExcelData.Name = "grpBoxExcelData";
            this.grpBoxExcelData.Size = new System.Drawing.Size(712, 429);
            this.grpBoxExcelData.TabIndex = 16;
            this.grpBoxExcelData.TabStop = false;
            this.grpBoxExcelData.Text = "读取到的数据";
            // 
            // comboStartRow
            // 
            this.comboStartRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStartRow.FormattingEnabled = true;
            this.comboStartRow.IntegralHeight = false;
            this.comboStartRow.Location = new System.Drawing.Point(540, 24);
            this.comboStartRow.Name = "comboStartRow";
            this.comboStartRow.Size = new System.Drawing.Size(66, 21);
            this.comboStartRow.TabIndex = 28;
            // 
            // lblStartRow
            // 
            this.lblStartRow.AutoSize = true;
            this.lblStartRow.Location = new System.Drawing.Point(443, 27);
            this.lblStartRow.Name = "lblStartRow";
            this.lblStartRow.Size = new System.Drawing.Size(91, 13);
            this.lblStartRow.TabIndex = 28;
            this.lblStartRow.Text = "有效信息起始行";
            // 
            // btnReadBML
            // 
            this.btnReadBML.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btnReadBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadBML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReadBML.Image = ((System.Drawing.Image)(resources.GetObject("btnReadBML.Image")));
            this.btnReadBML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadBML.Location = new System.Drawing.Point(612, 20);
            this.btnReadBML.Name = "btnReadBML";
            this.btnReadBML.Size = new System.Drawing.Size(89, 27);
            this.btnReadBML.TabIndex = 19;
            this.btnReadBML.Text = "   读取BML";
            this.btnReadBML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadBML.UseVisualStyleBackColor = true;
            this.btnReadBML.Click += new System.EventHandler(this.btnReadBML_Click);
            // 
            // dataGridBML
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridBML.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBML.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBML.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.Location = new System.Drawing.Point(6, 51);
            this.dataGridBML.Name = "dataGridBML";
            this.dataGridBML.Size = new System.Drawing.Size(701, 372);
            this.dataGridBML.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "选取工作表";
            // 
            // comboWorkSheetsBML
            // 
            this.comboWorkSheetsBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboWorkSheetsBML.FormattingEnabled = true;
            this.comboWorkSheetsBML.IntegralHeight = false;
            this.comboWorkSheetsBML.Location = new System.Drawing.Point(78, 24);
            this.comboWorkSheetsBML.Name = "comboWorkSheetsBML";
            this.comboWorkSheetsBML.Size = new System.Drawing.Size(357, 21);
            this.comboWorkSheetsBML.TabIndex = 15;
            this.comboWorkSheetsBML.SelectedIndexChanged += new System.EventHandler(this.comboWorkSheetsBML_SelectedIndexChanged);
            this.comboWorkSheetsBML.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboWorkSheetsBML_MouseDown);
            // 
            // grpBoxExcelColumn
            // 
            this.grpBoxExcelColumn.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.grpBoxExcelColumn.Controls.Add(this.grpBoxBMLColum);
            this.grpBoxExcelColumn.Controls.Add(this.TxtExcelPath);
            this.grpBoxExcelColumn.Controls.Add(this.BtnOpenProjectDB);
            this.grpBoxExcelColumn.Controls.Add(this.LblGcproProjectPath);
            this.grpBoxExcelColumn.Location = new System.Drawing.Point(6, 6);
            this.grpBoxExcelColumn.Name = "grpBoxExcelColumn";
            this.grpBoxExcelColumn.Size = new System.Drawing.Size(704, 115);
            this.grpBoxExcelColumn.TabIndex = 0;
            this.grpBoxExcelColumn.TabStop = false;
            this.grpBoxExcelColumn.Text = "BML清单信息";
            // 
            // grpBoxBMLColum
            // 
            this.grpBoxBMLColum.Controls.Add(this.comboSectionBML);
            this.grpBoxBMLColum.Controls.Add(this.comboPowerBML);
            this.grpBoxBMLColum.Controls.Add(this.comboDescBML);
            this.grpBoxBMLColum.Controls.Add(this.comboCabinetBML);
            this.grpBoxBMLColum.Controls.Add(this.comboFloorBML);
            this.grpBoxBMLColum.Controls.Add(this.comboTypeBML);
            this.grpBoxBMLColum.Controls.Add(this.comboNameBML);
            this.grpBoxBMLColum.Controls.Add(this.lblFloor);
            this.grpBoxBMLColum.Controls.Add(this.lblSection);
            this.grpBoxBMLColum.Controls.Add(this.lblType);
            this.grpBoxBMLColum.Controls.Add(this.lblCabibetNo);
            this.grpBoxBMLColum.Controls.Add(this.lblPower);
            this.grpBoxBMLColum.Controls.Add(this.lblBMLDescription);
            this.grpBoxBMLColum.Controls.Add(this.lblBMLSymbol);
            this.grpBoxBMLColum.Location = new System.Drawing.Point(6, 40);
            this.grpBoxBMLColum.Name = "grpBoxBMLColum";
            this.grpBoxBMLColum.Size = new System.Drawing.Size(582, 68);
            this.grpBoxBMLColum.TabIndex = 16;
            this.grpBoxBMLColum.TabStop = false;
            this.grpBoxBMLColum.Text = "信息列";
            // 
            // comboSectionBML
            // 
            this.comboSectionBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSectionBML.FormattingEnabled = true;
            this.comboSectionBML.IntegralHeight = false;
            this.comboSectionBML.Location = new System.Drawing.Point(462, 44);
            this.comboSectionBML.Name = "comboSectionBML";
            this.comboSectionBML.Size = new System.Drawing.Size(66, 21);
            this.comboSectionBML.TabIndex = 27;
            // 
            // comboPowerBML
            // 
            this.comboPowerBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPowerBML.FormattingEnabled = true;
            this.comboPowerBML.IntegralHeight = false;
            this.comboPowerBML.Location = new System.Drawing.Point(188, 44);
            this.comboPowerBML.Name = "comboPowerBML";
            this.comboPowerBML.Size = new System.Drawing.Size(66, 21);
            this.comboPowerBML.TabIndex = 25;
            // 
            // comboDescBML
            // 
            this.comboDescBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDescBML.FormattingEnabled = true;
            this.comboDescBML.IntegralHeight = false;
            this.comboDescBML.Location = new System.Drawing.Point(67, 44);
            this.comboDescBML.Name = "comboDescBML";
            this.comboDescBML.Size = new System.Drawing.Size(66, 21);
            this.comboDescBML.TabIndex = 24;
            // 
            // comboCabinetBML
            // 
            this.comboCabinetBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCabinetBML.FormattingEnabled = true;
            this.comboCabinetBML.IntegralHeight = false;
            this.comboCabinetBML.Location = new System.Drawing.Point(462, 18);
            this.comboCabinetBML.Name = "comboCabinetBML";
            this.comboCabinetBML.Size = new System.Drawing.Size(66, 21);
            this.comboCabinetBML.TabIndex = 23;
            // 
            // comboFloorBML
            // 
            this.comboFloorBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFloorBML.FormattingEnabled = true;
            this.comboFloorBML.IntegralHeight = false;
            this.comboFloorBML.Location = new System.Drawing.Point(319, 18);
            this.comboFloorBML.Name = "comboFloorBML";
            this.comboFloorBML.Size = new System.Drawing.Size(66, 21);
            this.comboFloorBML.TabIndex = 22;
            // 
            // comboTypeBML
            // 
            this.comboTypeBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTypeBML.FormattingEnabled = true;
            this.comboTypeBML.IntegralHeight = false;
            this.comboTypeBML.Location = new System.Drawing.Point(188, 18);
            this.comboTypeBML.Name = "comboTypeBML";
            this.comboTypeBML.Size = new System.Drawing.Size(66, 21);
            this.comboTypeBML.TabIndex = 21;
            // 
            // comboNameBML
            // 
            this.comboNameBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboNameBML.FormattingEnabled = true;
            this.comboNameBML.IntegralHeight = false;
            this.comboNameBML.Location = new System.Drawing.Point(67, 18);
            this.comboNameBML.Name = "comboNameBML";
            this.comboNameBML.Size = new System.Drawing.Size(66, 21);
            this.comboNameBML.TabIndex = 20;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(270, 21);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(43, 13);
            this.lblFloor.TabIndex = 12;
            this.lblFloor.Text = "楼层：";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(401, 47);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(55, 13);
            this.lblSection.TabIndex = 10;
            this.lblSection.Text = "电柜组：";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(139, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "类型：";
            // 
            // lblCabibetNo
            // 
            this.lblCabibetNo.AutoSize = true;
            this.lblCabibetNo.Location = new System.Drawing.Point(401, 19);
            this.lblCabibetNo.Name = "lblCabibetNo";
            this.lblCabibetNo.Size = new System.Drawing.Size(43, 13);
            this.lblCabibetNo.TabIndex = 6;
            this.lblCabibetNo.Text = "电柜：";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(139, 49);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(43, 13);
            this.lblPower.TabIndex = 4;
            this.lblPower.Text = "功率：";
            // 
            // lblBMLDescription
            // 
            this.lblBMLDescription.AutoSize = true;
            this.lblBMLDescription.Location = new System.Drawing.Point(8, 49);
            this.lblBMLDescription.Name = "lblBMLDescription";
            this.lblBMLDescription.Size = new System.Drawing.Size(43, 13);
            this.lblBMLDescription.TabIndex = 2;
            this.lblBMLDescription.Text = "描述：";
            // 
            // lblBMLSymbol
            // 
            this.lblBMLSymbol.AutoSize = true;
            this.lblBMLSymbol.Location = new System.Drawing.Point(8, 21);
            this.lblBMLSymbol.Name = "lblBMLSymbol";
            this.lblBMLSymbol.Size = new System.Drawing.Size(43, 13);
            this.lblBMLSymbol.TabIndex = 0;
            this.lblBMLSymbol.Text = "名称：";
            // 
            // TxtExcelPath
            // 
            this.TxtExcelPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtExcelPath.Location = new System.Drawing.Point(88, 21);
            this.TxtExcelPath.Name = "TxtExcelPath";
            this.TxtExcelPath.Size = new System.Drawing.Size(500, 13);
            this.TxtExcelPath.TabIndex = 18;
            this.TxtExcelPath.TextChanged += new System.EventHandler(this.TxtExcelPath_TextChanged);
            this.TxtExcelPath.DoubleClick += new System.EventHandler(this.TxtExcelPath_DoubleClick);
            // 
            // BtnOpenProjectDB
            // 
            this.BtnOpenProjectDB.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.BtnOpenProjectDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenProjectDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOpenProjectDB.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenProjectDB.Image")));
            this.BtnOpenProjectDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenProjectDB.Location = new System.Drawing.Point(609, 11);
            this.BtnOpenProjectDB.Name = "BtnOpenProjectDB";
            this.BtnOpenProjectDB.Size = new System.Drawing.Size(89, 27);
            this.BtnOpenProjectDB.TabIndex = 17;
            this.BtnOpenProjectDB.Text = "    浏 览";
            this.BtnOpenProjectDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOpenProjectDB.UseVisualStyleBackColor = true;
            this.BtnOpenProjectDB.Click += new System.EventHandler(this.BtnOpenProjectDB_Click);
            // 
            // LblGcproProjectPath
            // 
            this.LblGcproProjectPath.Image = ((System.Drawing.Image)(resources.GetObject("LblGcproProjectPath.Image")));
            this.LblGcproProjectPath.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblGcproProjectPath.Location = new System.Drawing.Point(6, 16);
            this.LblGcproProjectPath.Name = "LblGcproProjectPath";
            this.LblGcproProjectPath.Size = new System.Drawing.Size(77, 22);
            this.LblGcproProjectPath.TabIndex = 16;
            this.LblGcproProjectPath.Text = "BML表格";
            this.LblGcproProjectPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPanel
            // 
            this.LblPanel.AutoSize = true;
            this.LblPanel.Location = new System.Drawing.Point(298, 96);
            this.LblPanel.Name = "LblPanel";
            this.LblPanel.Size = new System.Drawing.Size(31, 13);
            this.LblPanel.TabIndex = 49;
            this.LblPanel.Text = "电柜";
            // 
            // ComboPanel
            // 
            this.ComboPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboPanel.FormattingEnabled = true;
            this.ComboPanel.IntegralHeight = false;
            this.ComboPanel.Location = new System.Drawing.Point(357, 93);
            this.ComboPanel.Name = "ComboPanel";
            this.ComboPanel.Size = new System.Drawing.Size(128, 21);
            this.ComboPanel.TabIndex = 50;
            // 
            // ComboElevation
            // 
            this.ComboElevation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboElevation.FormattingEnabled = true;
            this.ComboElevation.IntegralHeight = false;
            this.ComboElevation.Location = new System.Drawing.Point(98, 145);
            this.ComboElevation.Name = "ComboElevation";
            this.ComboElevation.Size = new System.Drawing.Size(182, 21);
            this.ComboElevation.TabIndex = 48;
            // 
            // LblDiagram
            // 
            this.LblDiagram.AutoSize = true;
            this.LblDiagram.Location = new System.Drawing.Point(298, 121);
            this.LblDiagram.Name = "LblDiagram";
            this.LblDiagram.Size = new System.Drawing.Size(31, 13);
            this.LblDiagram.TabIndex = 51;
            this.LblDiagram.Text = "图纸";
            // 
            // LblElevation
            // 
            this.LblElevation.AutoSize = true;
            this.LblElevation.Location = new System.Drawing.Point(3, 148);
            this.LblElevation.Name = "LblElevation";
            this.LblElevation.Size = new System.Drawing.Size(31, 13);
            this.LblElevation.TabIndex = 47;
            this.LblElevation.Text = "楼层";
            // 
            // ComboDiagram
            // 
            this.ComboDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboDiagram.FormattingEnabled = true;
            this.ComboDiagram.IntegralHeight = false;
            this.ComboDiagram.Location = new System.Drawing.Point(357, 118);
            this.ComboDiagram.Name = "ComboDiagram";
            this.ComboDiagram.Size = new System.Drawing.Size(128, 21);
            this.ComboDiagram.TabIndex = 52;
            // 
            // LblBuilding
            // 
            this.LblBuilding.AutoSize = true;
            this.LblBuilding.Location = new System.Drawing.Point(3, 121);
            this.LblBuilding.Name = "LblBuilding";
            this.LblBuilding.Size = new System.Drawing.Size(31, 13);
            this.LblBuilding.TabIndex = 45;
            this.LblBuilding.Text = "车间";
            // 
            // ComboProcessFct
            // 
            this.ComboProcessFct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboProcessFct.FormattingEnabled = true;
            this.ComboProcessFct.IntegralHeight = false;
            this.ComboProcessFct.Location = new System.Drawing.Point(98, 93);
            this.ComboProcessFct.Name = "ComboProcessFct";
            this.ComboProcessFct.Size = new System.Drawing.Size(182, 21);
            this.ComboProcessFct.TabIndex = 44;
            // 
            // GroupBoxSave
            // 
            this.GroupBoxSave.Controls.Add(this.ComboCreateMode);
            this.GroupBoxSave.Controls.Add(this.BtnSaveAs);
            this.GroupBoxSave.Controls.Add(this.TxtQuantity);
            this.GroupBoxSave.Controls.Add(this.BtnConfirm);
            this.GroupBoxSave.Controls.Add(this.LblQuantity);
            this.GroupBoxSave.Controls.Add(this.BtnClear);
            this.GroupBoxSave.Location = new System.Drawing.Point(600, 1);
            this.GroupBoxSave.Name = "GroupBoxSave";
            this.GroupBoxSave.Size = new System.Drawing.Size(100, 180);
            this.GroupBoxSave.TabIndex = 57;
            this.GroupBoxSave.TabStop = false;
            // 
            // ComboCreateMode
            // 
            this.ComboCreateMode.DropDownWidth = 90;
            this.ComboCreateMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboCreateMode.FormattingEnabled = true;
            this.ComboCreateMode.IntegralHeight = false;
            this.ComboCreateMode.ItemHeight = 13;
            this.ComboCreateMode.Location = new System.Drawing.Point(5, 16);
            this.ComboCreateMode.Name = "ComboCreateMode";
            this.ComboCreateMode.Size = new System.Drawing.Size(90, 21);
            this.ComboCreateMode.TabIndex = 104;
            this.ComboCreateMode.SelectedIndexChanged += new System.EventHandler(this.ComboCreateMode_SelectedIndexChanged);
            // 
            // BtnSaveAs
            // 
            this.BtnSaveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveAs.Image")));
            this.BtnSaveAs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveAs.Location = new System.Drawing.Point(8, 147);
            this.BtnSaveAs.Name = "BtnSaveAs";
            this.BtnSaveAs.Size = new System.Drawing.Size(85, 26);
            this.BtnSaveAs.TabIndex = 70;
            this.BtnSaveAs.Text = "另存为";
            this.BtnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSaveAs.UseVisualStyleBackColor = true;
            this.BtnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtQuantity.Location = new System.Drawing.Point(8, 59);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(79, 13);
            this.TxtQuantity.TabIndex = 55;
            this.TxtQuantity.Text = "1";
            this.TxtQuantity.TextChanged += new System.EventHandler(this.TxtQuantity_TextChanged);
            this.TxtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuantity_KeyDown);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirm.Image")));
            this.BtnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirm.Location = new System.Drawing.Point(8, 82);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(85, 26);
            this.BtnConfirm.TabIndex = 54;
            this.BtnConfirm.Text = "新建";
            this.BtnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(8, 41);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(55, 13);
            this.LblQuantity.TabIndex = 56;
            this.LblQuantity.Text = "新建数量";
            // 
            // BtnClear
            // 
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClear.Location = new System.Drawing.Point(8, 115);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 26);
            this.BtnClear.TabIndex = 69;
            this.BtnClear.Text = "清除";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblProcessFct
            // 
            this.LblProcessFct.AutoSize = true;
            this.LblProcessFct.Location = new System.Drawing.Point(3, 96);
            this.LblProcessFct.Name = "LblProcessFct";
            this.LblProcessFct.Size = new System.Drawing.Size(55, 13);
            this.LblProcessFct.TabIndex = 43;
            this.LblProcessFct.Text = "过程控制";
            // 
            // ComboEquipmentSubType
            // 
            this.ComboEquipmentSubType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboEquipmentSubType.FormattingEnabled = true;
            this.ComboEquipmentSubType.IntegralHeight = false;
            this.ComboEquipmentSubType.Location = new System.Drawing.Point(98, 68);
            this.ComboEquipmentSubType.Name = "ComboEquipmentSubType";
            this.ComboEquipmentSubType.Size = new System.Drawing.Size(182, 21);
            this.ComboEquipmentSubType.TabIndex = 42;
            this.ComboEquipmentSubType.SelectedIndexChanged += new System.EventHandler(this.ComboEquipmentSubType_SelectedIndexChanged);
            // 
            // LblEquipmentSubType
            // 
            this.LblEquipmentSubType.AutoSize = true;
            this.LblEquipmentSubType.Location = new System.Drawing.Point(3, 71);
            this.LblEquipmentSubType.Name = "LblEquipmentSubType";
            this.LblEquipmentSubType.Size = new System.Drawing.Size(79, 13);
            this.LblEquipmentSubType.TabIndex = 41;
            this.LblEquipmentSubType.Text = "设备控制类型";
            // 
            // ComboBuilding
            // 
            this.ComboBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBuilding.FormattingEnabled = true;
            this.ComboBuilding.IntegralHeight = false;
            this.ComboBuilding.Location = new System.Drawing.Point(98, 118);
            this.ComboBuilding.Name = "ComboBuilding";
            this.ComboBuilding.Size = new System.Drawing.Size(182, 21);
            this.ComboBuilding.TabIndex = 46;
            // 
            // PalCommon
            // 
            this.PalCommon.AutoScroll = true;
            this.PalCommon.AutoSize = true;
            this.PalCommon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PalCommon.Controls.Add(this.txtPage);
            this.PalCommon.Controls.Add(this.lblPage);
            this.PalCommon.Controls.Add(this.ComboBuilding);
            this.PalCommon.Controls.Add(this.LblEquipmentSubType);
            this.PalCommon.Controls.Add(this.ComboEquipmentSubType);
            this.PalCommon.Controls.Add(this.LblProcessFct);
            this.PalCommon.Controls.Add(this.GroupBoxSave);
            this.PalCommon.Controls.Add(this.ComboProcessFct);
            this.PalCommon.Controls.Add(this.LblBuilding);
            this.PalCommon.Controls.Add(this.ComboDiagram);
            this.PalCommon.Controls.Add(this.LblElevation);
            this.PalCommon.Controls.Add(this.LblDiagram);
            this.PalCommon.Controls.Add(this.ComboElevation);
            this.PalCommon.Controls.Add(this.ComboPanel);
            this.PalCommon.Controls.Add(this.LblPanel);
            this.PalCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalCommon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PalCommon.Location = new System.Drawing.Point(0, 579);
            this.PalCommon.Name = "PalCommon";
            this.PalCommon.Size = new System.Drawing.Size(726, 199);
            this.PalCommon.TabIndex = 106;
            // 
            // txtPage
            // 
            this.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPage.Location = new System.Drawing.Point(357, 148);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(66, 13);
            this.txtPage.TabIndex = 88;
            this.txtPage.Visible = false;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(298, 148);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(31, 13);
            this.lblPage.TabIndex = 58;
            this.lblPage.Text = "页码";
            // 
            // FormMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(726, 800);
            this.Controls.Add(this.PalCommon);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabCreateMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMotor";
            this.Text = "EL_Motor";
            this.Load += new System.EventHandler(this.FormMotor_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCreateMode.ResumeLayout(false);
            this.contextMenuStripBML.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.tabRule.PerformLayout();
            this.PalGcObject.ResumeLayout(false);
            this.PalGcObject.PerformLayout();
            this.GrUnit.ResumeLayout(false);
            this.GrUnit.PerformLayout();
            this.GrVFCAndAO.ResumeLayout(false);
            this.GrVFCAndAO.PerformLayout();
            this.GrpSymbolRule.ResumeLayout(false);
            this.GrpSymbolRule.PerformLayout();
            this.GrpDescriptionRule.ResumeLayout(false);
            this.GrpDescriptionRule.PerformLayout();
            this.GroupBoxGroupTree.ResumeLayout(false);
            this.GroupBoxGroupTree.PerformLayout();
            this.tabBML.ResumeLayout(false);
            this.grpBoxExcelData.ResumeLayout(false);
            this.grpBoxExcelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBML)).EndInit();
            this.grpBoxExcelColumn.ResumeLayout(false);
            this.grpBoxExcelColumn.PerformLayout();
            this.grpBoxBMLColum.ResumeLayout(false);
            this.grpBoxBMLColum.PerformLayout();
            this.GroupBoxSave.ResumeLayout(false);
            this.GroupBoxSave.PerformLayout();
            this.PalCommon.ResumeLayout(false);
            this.PalCommon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LblFieldInDatabase;
        private System.Windows.Forms.ToolStripStatusLabel LblField;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel LblProcess;
        private System.Windows.Forms.TabControl tabCreateMode;
        private System.Windows.Forms.TabPage tabBML;
        internal System.Windows.Forms.Label LblPanel;
        internal System.Windows.Forms.ComboBox ComboPanel;
        internal System.Windows.Forms.ComboBox ComboElevation;
        internal System.Windows.Forms.Label LblDiagram;
        internal System.Windows.Forms.Label LblElevation;
        internal System.Windows.Forms.ComboBox ComboDiagram;
        internal System.Windows.Forms.Label LblBuilding;
        internal System.Windows.Forms.ComboBox ComboProcessFct;
        internal System.Windows.Forms.GroupBox GroupBoxSave;
        internal System.Windows.Forms.ComboBox ComboCreateMode;
        internal System.Windows.Forms.Button BtnSaveAs;
        internal System.Windows.Forms.TextBox TxtQuantity;
        internal System.Windows.Forms.Button BtnConfirm;
        internal System.Windows.Forms.Label LblQuantity;
        internal System.Windows.Forms.Button BtnClear;
        internal System.Windows.Forms.Label LblProcessFct;
        internal System.Windows.Forms.ComboBox ComboEquipmentSubType;
        internal System.Windows.Forms.Label LblEquipmentSubType;
        internal System.Windows.Forms.ComboBox ComboBuilding;
        internal System.Windows.Forms.Panel PalCommon;
        private System.Windows.Forms.TabPage tabRule;
        internal System.Windows.Forms.Panel PalGcObject;
        internal System.Windows.Forms.Button BtnSetParentAndChild;
        internal System.Windows.Forms.Button BtnRegenerateDPNode;
        internal System.Windows.Forms.Label LblSymbol;
        internal System.Windows.Forms.Label LblDescription;
        internal System.Windows.Forms.GroupBox GrUnit;
        internal System.Windows.Forms.ComboBox ComboUnit;
        internal System.Windows.Forms.Label LblSpeed;
        internal System.Windows.Forms.Button BtnNewImpExpDef;
        internal System.Windows.Forms.TextBox TxtSymbol;
        internal System.Windows.Forms.Button BtnConnectIO;
        internal System.Windows.Forms.TextBox TxtDescription;
        internal System.Windows.Forms.GroupBox GrVFCAndAO;
        internal System.Windows.Forms.TextBox TxtVFCRule;
        internal System.Windows.Forms.Label LblAOlRule;
        internal System.Windows.Forms.Label LblVFCIncRule;
        internal System.Windows.Forms.TextBox TxtAOIncRule;
        internal System.Windows.Forms.TextBox TxtVFCIncRule;
        internal System.Windows.Forms.Label LblAOIncRule;
        internal System.Windows.Forms.TextBox TxtAO;
        internal System.Windows.Forms.Label LblAO;
        internal System.Windows.Forms.Button BtnConnectVFC;
        internal System.Windows.Forms.TextBox TxtAORule;
        internal System.Windows.Forms.TextBox TxtVFCAdapter;
        internal System.Windows.Forms.Label LblVFCAdapter;
        internal System.Windows.Forms.Label LblVFClRule;
        internal System.Windows.Forms.Label LblInpRunFwd;
        internal System.Windows.Forms.Label LblOutpRunFwd;
        internal System.Windows.Forms.GroupBox GrpSymbolRule;
        internal System.Windows.Forms.Label LblSymbolRule;
        internal System.Windows.Forms.TextBox TxtSymbolRule;
        internal System.Windows.Forms.TextBox TxtSymbolIncRule;
        internal System.Windows.Forms.Label LblSymbolIncRule;
        internal System.Windows.Forms.TextBox TxtInpRunFwd;
        internal System.Windows.Forms.GroupBox GrpDescriptionRule;
        internal System.Windows.Forms.Label LblDescriptionRule;
        internal System.Windows.Forms.TextBox TxtDescriptionIncRule;
        internal System.Windows.Forms.Label Lbl;
        internal System.Windows.Forms.TextBox TxtDescriptionRule;
        internal System.Windows.Forms.TextBox TxtOutpRunFwd;
        internal System.Windows.Forms.CheckBox ChKPower;
        internal System.Windows.Forms.Label LblEquipmentInfoType;
        internal System.Windows.Forms.TextBox TxtInHWStop;
        internal System.Windows.Forms.ComboBox ComboEquipmentInfoType;
        internal System.Windows.Forms.Label LblInHwstop;
        internal System.Windows.Forms.Label LblHornCode;
        internal System.Windows.Forms.ComboBox ComboHornCode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LblDPNode1;
        internal System.Windows.Forms.TextBox TxtValue10;
        internal System.Windows.Forms.Label LblDPNode2;
        internal System.Windows.Forms.ComboBox ComboDPNode1;
        internal System.Windows.Forms.ComboBox ComboDPNode2;
        internal System.Windows.Forms.Label LblMonTime;
        internal System.Windows.Forms.TextBox TxtMonTime;
        internal System.Windows.Forms.Label LblStartDelayTime;
        internal System.Windows.Forms.TextBox TxtStartDelayTime;
        internal System.Windows.Forms.Label LblStartingTime;
        internal System.Windows.Forms.TextBox TxtStartingTime;
        internal System.Windows.Forms.Label LblStoppingTime;
        internal System.Windows.Forms.TextBox TxtStoppingTime;
        internal System.Windows.Forms.Label LblIdlingTime;
        internal System.Windows.Forms.TextBox TxtIdlingTime;
        internal System.Windows.Forms.Label LblFaultDelayTime;
        internal System.Windows.Forms.TextBox TxtFaultDelayTime;
        internal System.Windows.Forms.Label LblKW;
        internal System.Windows.Forms.GroupBox GroupBoxGroupTree;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.CheckBox ChkStartingInterlock;
        internal System.Windows.Forms.TextBox TxtValue9;
        internal System.Windows.Forms.CheckBox ChkRunInterlock;
        internal System.Windows.Forms.TextBox TxtKW;
        internal System.Windows.Forms.CheckBox ChkRevNotAllowed;
        internal System.Windows.Forms.CheckBox ChkParManual;
        internal System.Windows.Forms.CheckBox ChkRestartDelay;
        private System.Windows.Forms.GroupBox grpBoxExcelColumn;
        private System.Windows.Forms.Label lblBMLSymbol;
        private System.Windows.Forms.Label lblBMLDescription;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox comboWorkSheetsBML;
        internal System.Windows.Forms.TextBox txtPage;
        internal System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        internal System.Windows.Forms.Button BtnOpenProjectDB;
        internal System.Windows.Forms.Label LblGcproProjectPath;
        internal System.Windows.Forms.TextBox TxtExcelPath;
        private System.Windows.Forms.GroupBox grpBoxBMLColum;
        private System.Windows.Forms.Label lblCabibetNo;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.GroupBox grpBoxExcelData;
        private System.Windows.Forms.DataGridView dataGridBML;
        internal System.Windows.Forms.Button btnReadBML;
        internal System.Windows.Forms.ComboBox comboSectionBML;
        internal System.Windows.Forms.ComboBox comboPowerBML;
        internal System.Windows.Forms.ComboBox comboDescBML;
        internal System.Windows.Forms.ComboBox comboCabinetBML;
        internal System.Windows.Forms.ComboBox comboFloorBML;
        internal System.Windows.Forms.ComboBox comboTypeBML;
        internal System.Windows.Forms.ComboBox comboNameBML;
        internal System.Windows.Forms.ComboBox comboStartRow;
        private System.Windows.Forms.Label lblStartRow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClearList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

