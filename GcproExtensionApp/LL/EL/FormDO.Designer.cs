using System;

namespace GcproExtensionApp
{
    partial class FormDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDO));
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
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRule = new System.Windows.Forms.TabPage();
            this.PalGcObject = new System.Windows.Forms.Panel();
            this.lblParDelayFaultTime = new System.Windows.Forms.Label();
            this.txtParDelayFaultTime = new System.Windows.Forms.TextBox();
            this.lblParDPNode2 = new System.Windows.Forms.Label();
            this.comboDPNode2 = new System.Windows.Forms.ComboBox();
            this.chkParStartingwarning = new System.Windows.Forms.CheckBox();
            this.chkParFilter = new System.Windows.Forms.CheckBox();
            this.chkParPulsing = new System.Windows.Forms.CheckBox();
            this.chkParPulse = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtValue10 = new System.Windows.Forms.TextBox();
            this.lblStartDelay = new System.Windows.Forms.Label();
            this.txtParStartDelay = new System.Windows.Forms.TextBox();
            this.lblParStartingTime = new System.Windows.Forms.Label();
            this.txtParStartingTime = new System.Windows.Forms.TextBox();
            this.lblParOnTime = new System.Windows.Forms.Label();
            this.txtParOnTime = new System.Windows.Forms.TextBox();
            this.LblParOffTime = new System.Windows.Forms.Label();
            this.txtParOffTime = new System.Windows.Forms.TextBox();
            this.lblParIdlingTime = new System.Windows.Forms.Label();
            this.txtParIdlingTime = new System.Windows.Forms.TextBox();
            this.chkParLogOff = new System.Windows.Forms.CheckBox();
            this.chkParManual = new System.Windows.Forms.CheckBox();
            this.chkParContinuous = new System.Windows.Forms.CheckBox();
            this.chkOnlyFree = new System.Windows.Forms.CheckBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblInpAlarmReset = new System.Windows.Forms.Label();
            this.lblInpAlarmResetSuffix = new System.Windows.Forms.Label();
            this.txtInpAlarmReset = new System.Windows.Forms.TextBox();
            this.txtInpAlarmResetSuffix = new System.Windows.Forms.TextBox();
            this.lblOutpFinalClearingSuffix = new System.Windows.Forms.Label();
            this.txtOutpFinalClearingSuffix = new System.Windows.Forms.TextBox();
            this.lblOutpFinalClearing = new System.Windows.Forms.Label();
            this.txtOutpFinalClearing = new System.Windows.Forms.TextBox();
            this.grpAddInfoToDesc = new System.Windows.Forms.GroupBox();
            this.chkAddUserSectionToDesc = new System.Windows.Forms.CheckBox();
            this.chkNameOnlyNumber = new System.Windows.Forms.CheckBox();
            this.chkAddSectionToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddNameToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddFloorToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddCabinetToDesc = new System.Windows.Forms.CheckBox();
            this.lblOutpLampSuffix = new System.Windows.Forms.Label();
            this.txtOutpLampSuffix = new System.Windows.Forms.TextBox();
            this.lblOutpLamp = new System.Windows.Forms.Label();
            this.txtOutpLamp = new System.Windows.Forms.TextBox();
            this.lblInHWStop = new System.Windows.Forms.Label();
            this.lblInHWStopSuffix = new System.Windows.Forms.Label();
            this.txtInHWStop = new System.Windows.Forms.TextBox();
            this.txtInHWStopSuffix = new System.Windows.Forms.TextBox();
            this.lblInpFaultDev = new System.Windows.Forms.Label();
            this.lblInpFaultDevSuffix = new System.Windows.Forms.Label();
            this.txtInpFaultDev = new System.Windows.Forms.TextBox();
            this.txtInpFaultDevSuffix = new System.Windows.Forms.TextBox();
            this.LblSymbol = new System.Windows.Forms.Label();
            this.GrpDescriptionRule = new System.Windows.Forms.GroupBox();
            this.LblDescriptionRule = new System.Windows.Forms.Label();
            this.txtDescriptionIncRule = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.txtDescriptionRule = new System.Windows.Forms.TextBox();
            this.txtInpRun = new System.Windows.Forms.TextBox();
            this.GrpSymbolRule = new System.Windows.Forms.GroupBox();
            this.LblSymbolRule = new System.Windows.Forms.Label();
            this.txtSymbolRule = new System.Windows.Forms.TextBox();
            this.txtSymbolIncRule = new System.Windows.Forms.TextBox();
            this.LblSymbolIncRule = new System.Windows.Forms.Label();
            this.lblOutpRunSuffix = new System.Windows.Forms.Label();
            this.txtOutpRunSuffix = new System.Windows.Forms.TextBox();
            this.LblInpRun = new System.Windows.Forms.Label();
            this.txtOutpFaultResetSuffix = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblOutpFaultResetSuffix = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.txtInpRunSuffix = new System.Windows.Forms.TextBox();
            this.txtOutpFaultReset = new System.Windows.Forms.TextBox();
            this.lblInpTrueSuffix = new System.Windows.Forms.Label();
            this.LblOutpFaultReset = new System.Windows.Forms.Label();
            this.LblOutpRun = new System.Windows.Forms.Label();
            this.txtOutpRun = new System.Windows.Forms.TextBox();
            this.BtnRegenerateDPNode = new System.Windows.Forms.Button();
            this.BtnNewImpExpDef = new System.Windows.Forms.Button();
            this.LblEquipmentInfoType = new System.Windows.Forms.Label();
            this.comboEquipmentInfoType = new System.Windows.Forms.ComboBox();
            this.LblHornCode = new System.Windows.Forms.Label();
            this.ComboHornCode = new System.Windows.Forms.ComboBox();
            this.lblDPNode1 = new System.Windows.Forms.Label();
            this.BtnConnectIO = new System.Windows.Forms.Button();
            this.comboDPNode1 = new System.Windows.Forms.ComboBox();
            this.tabBML = new System.Windows.Forms.TabPage();
            this.grpBoxExcelData = new System.Windows.Forms.GroupBox();
            this.btnReadBML = new System.Windows.Forms.Button();
            this.dataGridBML = new System.Windows.Forms.DataGridView();
            this.lblWorkSheet = new System.Windows.Forms.Label();
            this.comboWorkSheetsBML = new System.Windows.Forms.ComboBox();
            this.grpBoxExcelColumn = new System.Windows.Forms.GroupBox();
            this.grpBoxBMLColum = new System.Windows.Forms.GroupBox();
            this.comboLineBML = new System.Windows.Forms.ComboBox();
            this.lblLineBML = new System.Windows.Forms.Label();
            this.comboIORemarkBML = new System.Windows.Forms.ComboBox();
            this.comboControlBML = new System.Windows.Forms.ComboBox();
            this.lblIORemarkBML = new System.Windows.Forms.Label();
            this.lblControlBML = new System.Windows.Forms.Label();
            this.comboStartRow = new System.Windows.Forms.ComboBox();
            this.lblStartRow = new System.Windows.Forms.Label();
            this.comboSectionBML = new System.Windows.Forms.ComboBox();
            this.comboDescBML = new System.Windows.Forms.ComboBox();
            this.comboCabinetBML = new System.Windows.Forms.ComboBox();
            this.comboFloorBML = new System.Windows.Forms.ComboBox();
            this.comboTypeBML = new System.Windows.Forms.ComboBox();
            this.comboNameBML = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCabibetNo = new System.Windows.Forms.Label();
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
            this.grpGeneral.SuspendLayout();
            this.grpAddInfoToDesc.SuspendLayout();
            this.GrpDescriptionRule.SuspendLayout();
            this.GrpSymbolRule.SuspendLayout();
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
            this.statusStrip.Size = new System.Drawing.Size(731, 22);
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
            this.tabCreateMode.Size = new System.Drawing.Size(731, 579);
            this.tabCreateMode.TabIndex = 107;
            this.tabCreateMode.SelectedIndexChanged += new System.EventHandler(this.tabCreateMode_SelectedIndexChanged);
            // 
            // contextMenuStripBML
            // 
            this.contextMenuStripBML.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuClearList,
            this.toolStripMenuDelete,
            this.toolStripSeparator1,
            this.toolStripMenuReload});
            this.contextMenuStripBML.Name = "contextMenuStripBML";
            this.contextMenuStripBML.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripBML.Size = new System.Drawing.Size(173, 76);
            // 
            // toolStripMenuClearList
            // 
            this.toolStripMenuClearList.DoubleClickEnabled = true;
            this.toolStripMenuClearList.Name = "toolStripMenuClearList";
            this.toolStripMenuClearList.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuClearList.Text = "清除表格内容";
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuDelete.Text = "清除表格所选类容";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuReload
            // 
            this.toolStripMenuReload.Name = "toolStripMenuReload";
            this.toolStripMenuReload.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuReload.Text = "重新读取BML";
            // 
            // tabRule
            // 
            this.tabRule.AutoScroll = true;
            this.tabRule.BackColor = System.Drawing.SystemColors.Control;
            this.tabRule.Controls.Add(this.PalGcObject);
            this.tabRule.Location = new System.Drawing.Point(4, 22);
            this.tabRule.Name = "tabRule";
            this.tabRule.Padding = new System.Windows.Forms.Padding(3);
            this.tabRule.Size = new System.Drawing.Size(723, 553);
            this.tabRule.TabIndex = 0;
            this.tabRule.Text = "设定规则创建";
            // 
            // PalGcObject
            // 
            this.PalGcObject.AutoScroll = true;
            this.PalGcObject.AutoSize = true;
            this.PalGcObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PalGcObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PalGcObject.Controls.Add(this.lblParDelayFaultTime);
            this.PalGcObject.Controls.Add(this.txtParDelayFaultTime);
            this.PalGcObject.Controls.Add(this.lblParDPNode2);
            this.PalGcObject.Controls.Add(this.comboDPNode2);
            this.PalGcObject.Controls.Add(this.chkParStartingwarning);
            this.PalGcObject.Controls.Add(this.chkParFilter);
            this.PalGcObject.Controls.Add(this.chkParPulsing);
            this.PalGcObject.Controls.Add(this.chkParPulse);
            this.PalGcObject.Controls.Add(this.Label1);
            this.PalGcObject.Controls.Add(this.txtValue10);
            this.PalGcObject.Controls.Add(this.lblStartDelay);
            this.PalGcObject.Controls.Add(this.txtParStartDelay);
            this.PalGcObject.Controls.Add(this.lblParStartingTime);
            this.PalGcObject.Controls.Add(this.txtParStartingTime);
            this.PalGcObject.Controls.Add(this.lblParOnTime);
            this.PalGcObject.Controls.Add(this.txtParOnTime);
            this.PalGcObject.Controls.Add(this.LblParOffTime);
            this.PalGcObject.Controls.Add(this.txtParOffTime);
            this.PalGcObject.Controls.Add(this.lblParIdlingTime);
            this.PalGcObject.Controls.Add(this.txtParIdlingTime);
            this.PalGcObject.Controls.Add(this.chkParLogOff);
            this.PalGcObject.Controls.Add(this.chkParManual);
            this.PalGcObject.Controls.Add(this.chkParContinuous);
            this.PalGcObject.Controls.Add(this.chkOnlyFree);
            this.PalGcObject.Controls.Add(this.grpGeneral);
            this.PalGcObject.Controls.Add(this.BtnRegenerateDPNode);
            this.PalGcObject.Controls.Add(this.BtnNewImpExpDef);
            this.PalGcObject.Controls.Add(this.LblEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.comboEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.LblHornCode);
            this.PalGcObject.Controls.Add(this.ComboHornCode);
            this.PalGcObject.Controls.Add(this.lblDPNode1);
            this.PalGcObject.Controls.Add(this.BtnConnectIO);
            this.PalGcObject.Controls.Add(this.comboDPNode1);
            this.PalGcObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalGcObject.Location = new System.Drawing.Point(3, 3);
            this.PalGcObject.Name = "PalGcObject";
            this.PalGcObject.Size = new System.Drawing.Size(717, 547);
            this.PalGcObject.TabIndex = 105;
            // 
            // lblParDelayFaultTime
            // 
            this.lblParDelayFaultTime.AutoSize = true;
            this.lblParDelayFaultTime.Location = new System.Drawing.Point(3, 521);
            this.lblParDelayFaultTime.Name = "lblParDelayFaultTime";
            this.lblParDelayFaultTime.Size = new System.Drawing.Size(118, 13);
            this.lblParDelayFaultTime.TabIndex = 141;
            this.lblParDelayFaultTime.Text = "ParDelayFaultTime[min]";
            // 
            // txtParDelayFaultTime
            // 
            this.txtParDelayFaultTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParDelayFaultTime.Location = new System.Drawing.Point(127, 521);
            this.txtParDelayFaultTime.Name = "txtParDelayFaultTime";
            this.txtParDelayFaultTime.Size = new System.Drawing.Size(56, 13);
            this.txtParDelayFaultTime.TabIndex = 142;
            this.txtParDelayFaultTime.Text = "0.0";
            this.txtParDelayFaultTime.TextChanged += new System.EventHandler(this.txtParDelayFaultTime_TextChanged);
            // 
            // lblParDPNode2
            // 
            this.lblParDPNode2.AutoSize = true;
            this.lblParDPNode2.Location = new System.Drawing.Point(2, 408);
            this.lblParDPNode2.Name = "lblParDPNode2";
            this.lblParDPNode2.Size = new System.Drawing.Size(70, 13);
            this.lblParDPNode2.TabIndex = 139;
            this.lblParDPNode2.Text = "ParDPNode2";
            // 
            // comboDPNode2
            // 
            this.comboDPNode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDPNode2.FormattingEnabled = true;
            this.comboDPNode2.Location = new System.Drawing.Point(126, 402);
            this.comboDPNode2.Name = "comboDPNode2";
            this.comboDPNode2.Size = new System.Drawing.Size(146, 21);
            this.comboDPNode2.TabIndex = 140;
            // 
            // chkParStartingwarning
            // 
            this.chkParStartingwarning.AutoSize = true;
            this.chkParStartingwarning.Location = new System.Drawing.Point(330, 466);
            this.chkParStartingwarning.Name = "chkParStartingwarning";
            this.chkParStartingwarning.Size = new System.Drawing.Size(101, 17);
            this.chkParStartingwarning.TabIndex = 138;
            this.chkParStartingwarning.Text = "ParStartwarning";
            this.chkParStartingwarning.UseVisualStyleBackColor = true;
            this.chkParStartingwarning.CheckedChanged += new System.EventHandler(this.chkParStartwarning_CheckedChanged);
            this.chkParStartingwarning.MouseEnter += new System.EventHandler(this.chkParStartwarning_CheckedChanged);
            // 
            // chkParFilter
            // 
            this.chkParFilter.AutoSize = true;
            this.chkParFilter.Location = new System.Drawing.Point(330, 449);
            this.chkParFilter.Name = "chkParFilter";
            this.chkParFilter.Size = new System.Drawing.Size(64, 17);
            this.chkParFilter.TabIndex = 137;
            this.chkParFilter.Text = "ParFilter";
            this.chkParFilter.UseVisualStyleBackColor = true;
            this.chkParFilter.CheckedChanged += new System.EventHandler(this.chkParFilter_CheckedChanged);
            this.chkParFilter.MouseEnter += new System.EventHandler(this.chkParFilter_CheckedChanged);
            // 
            // chkParPulsing
            // 
            this.chkParPulsing.AutoSize = true;
            this.chkParPulsing.Location = new System.Drawing.Point(330, 432);
            this.chkParPulsing.Name = "chkParPulsing";
            this.chkParPulsing.Size = new System.Drawing.Size(76, 17);
            this.chkParPulsing.TabIndex = 136;
            this.chkParPulsing.Text = "ParPulsing";
            this.chkParPulsing.UseVisualStyleBackColor = true;
            this.chkParPulsing.CheckedChanged += new System.EventHandler(this.chkParPulsing_CheckedChanged);
            // 
            // chkParPulse
            // 
            this.chkParPulse.AutoSize = true;
            this.chkParPulse.Location = new System.Drawing.Point(330, 415);
            this.chkParPulse.Name = "chkParPulse";
            this.chkParPulse.Size = new System.Drawing.Size(68, 17);
            this.chkParPulse.TabIndex = 135;
            this.chkParPulse.Text = "ParPulse";
            this.chkParPulse.UseVisualStyleBackColor = true;
            this.chkParPulse.CheckedChanged += new System.EventHandler(this.chkParPulse_CheckedChanged);
            this.chkParPulse.MouseEnter += new System.EventHandler(this.chkParPulse_MouseEnter);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(405, 365);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 134;
            this.Label1.Text = "Value10";
            // 
            // txtValue10
            // 
            this.txtValue10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue10.Location = new System.Drawing.Point(409, 385);
            this.txtValue10.Name = "txtValue10";
            this.txtValue10.Size = new System.Drawing.Size(36, 13);
            this.txtValue10.TabIndex = 133;
            this.txtValue10.Text = "0";
            this.txtValue10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue10_KeyDown);
            // 
            // lblStartDelay
            // 
            this.lblStartDelay.AutoSize = true;
            this.lblStartDelay.Location = new System.Drawing.Point(3, 429);
            this.lblStartDelay.Name = "lblStartDelay";
            this.lblStartDelay.Size = new System.Drawing.Size(83, 13);
            this.lblStartDelay.TabIndex = 119;
            this.lblStartDelay.Text = "ParStartDelay[s]";
            // 
            // txtParStartDelay
            // 
            this.txtParStartDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParStartDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParStartDelay.Location = new System.Drawing.Point(127, 429);
            this.txtParStartDelay.Name = "txtParStartDelay";
            this.txtParStartDelay.Size = new System.Drawing.Size(56, 13);
            this.txtParStartDelay.TabIndex = 120;
            this.txtParStartDelay.Text = "2.0";
            this.txtParStartDelay.MouseEnter += new System.EventHandler(this.txtParStartDelay_MouseEnter);
            // 
            // lblParStartingTime
            // 
            this.lblParStartingTime.AutoSize = true;
            this.lblParStartingTime.Location = new System.Drawing.Point(3, 448);
            this.lblParStartingTime.Name = "lblParStartingTime";
            this.lblParStartingTime.Size = new System.Drawing.Size(93, 13);
            this.lblParStartingTime.TabIndex = 121;
            this.lblParStartingTime.Text = "ParStartingTime[s]";
            // 
            // txtParStartingTime
            // 
            this.txtParStartingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParStartingTime.Location = new System.Drawing.Point(127, 448);
            this.txtParStartingTime.Name = "txtParStartingTime";
            this.txtParStartingTime.Size = new System.Drawing.Size(56, 13);
            this.txtParStartingTime.TabIndex = 122;
            this.txtParStartingTime.Text = "0.0";
            this.txtParStartingTime.TextChanged += new System.EventHandler(this.txtParStartingTime_TextChanged);
            this.txtParStartingTime.MouseEnter += new System.EventHandler(this.txtParStartingTime_MouseEnter);
            // 
            // lblParOnTime
            // 
            this.lblParOnTime.AutoSize = true;
            this.lblParOnTime.Location = new System.Drawing.Point(3, 465);
            this.lblParOnTime.Name = "lblParOnTime";
            this.lblParOnTime.Size = new System.Drawing.Size(71, 13);
            this.lblParOnTime.TabIndex = 123;
            this.lblParOnTime.Text = "ParOnTime[s]";
            // 
            // txtParOnTime
            // 
            this.txtParOnTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParOnTime.Location = new System.Drawing.Point(127, 465);
            this.txtParOnTime.Name = "txtParOnTime";
            this.txtParOnTime.Size = new System.Drawing.Size(56, 13);
            this.txtParOnTime.TabIndex = 124;
            this.txtParOnTime.Text = "0.0";
            this.txtParOnTime.TextChanged += new System.EventHandler(this.txtParOnTime_TextChanged);
            this.txtParOnTime.MouseEnter += new System.EventHandler(this.txtParOnTime_MouseEnter);
            // 
            // LblParOffTime
            // 
            this.LblParOffTime.AutoSize = true;
            this.LblParOffTime.Location = new System.Drawing.Point(3, 483);
            this.LblParOffTime.Name = "LblParOffTime";
            this.LblParOffTime.Size = new System.Drawing.Size(71, 13);
            this.LblParOffTime.TabIndex = 125;
            this.LblParOffTime.Text = "ParOffTime[s]";
            // 
            // txtParOffTime
            // 
            this.txtParOffTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParOffTime.Location = new System.Drawing.Point(127, 483);
            this.txtParOffTime.Name = "txtParOffTime";
            this.txtParOffTime.Size = new System.Drawing.Size(56, 13);
            this.txtParOffTime.TabIndex = 126;
            this.txtParOffTime.Text = "0.0";
            this.txtParOffTime.TextChanged += new System.EventHandler(this.txtParOffTime_TextChanged);
            this.txtParOffTime.MouseEnter += new System.EventHandler(this.txtParOffTime_MouseEnter);
            // 
            // lblParIdlingTime
            // 
            this.lblParIdlingTime.AutoSize = true;
            this.lblParIdlingTime.Location = new System.Drawing.Point(3, 502);
            this.lblParIdlingTime.Name = "lblParIdlingTime";
            this.lblParIdlingTime.Size = new System.Drawing.Size(82, 13);
            this.lblParIdlingTime.TabIndex = 127;
            this.lblParIdlingTime.Text = "ParIdlingTime[s]";
            // 
            // txtParIdlingTime
            // 
            this.txtParIdlingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParIdlingTime.Location = new System.Drawing.Point(127, 502);
            this.txtParIdlingTime.Name = "txtParIdlingTime";
            this.txtParIdlingTime.Size = new System.Drawing.Size(56, 13);
            this.txtParIdlingTime.TabIndex = 128;
            this.txtParIdlingTime.Text = "0.0";
            this.txtParIdlingTime.TextChanged += new System.EventHandler(this.txtParIdlingTime_TextChanged);
            this.txtParIdlingTime.MouseEnter += new System.EventHandler(this.txtParIdlingTime_MouseEnter);
            // 
            // chkParLogOff
            // 
            this.chkParLogOff.AutoSize = true;
            this.chkParLogOff.Location = new System.Drawing.Point(330, 364);
            this.chkParLogOff.Name = "chkParLogOff";
            this.chkParLogOff.Size = new System.Drawing.Size(74, 17);
            this.chkParLogOff.TabIndex = 129;
            this.chkParLogOff.Text = "ParLogOff";
            this.chkParLogOff.UseVisualStyleBackColor = true;
            this.chkParLogOff.CheckedChanged += new System.EventHandler(this.chkParLogOff_CheckedChanged);
            this.chkParLogOff.MouseEnter += new System.EventHandler(this.chkParLogOff_MouseEnter);
            // 
            // chkParManual
            // 
            this.chkParManual.AutoSize = true;
            this.chkParManual.Location = new System.Drawing.Point(330, 381);
            this.chkParManual.Name = "chkParManual";
            this.chkParManual.Size = new System.Drawing.Size(77, 17);
            this.chkParManual.TabIndex = 130;
            this.chkParManual.Text = "ParManual";
            this.chkParManual.UseVisualStyleBackColor = true;
            this.chkParManual.CheckedChanged += new System.EventHandler(this.chkParManual_CheckedChanged);
            this.chkParManual.MouseEnter += new System.EventHandler(this.chkParManual_MouseEnter);
            // 
            // chkParContinuous
            // 
            this.chkParContinuous.AutoSize = true;
            this.chkParContinuous.Location = new System.Drawing.Point(330, 398);
            this.chkParContinuous.Name = "chkParContinuous";
            this.chkParContinuous.Size = new System.Drawing.Size(95, 17);
            this.chkParContinuous.TabIndex = 131;
            this.chkParContinuous.Text = "ParContinuous";
            this.chkParContinuous.UseVisualStyleBackColor = true;
            this.chkParContinuous.CheckedChanged += new System.EventHandler(this.chkParContinuous_CheckedChanged);
            this.chkParContinuous.MouseEnter += new System.EventHandler(this.chkParContinuous_MouseEnter);
            // 
            // chkOnlyFree
            // 
            this.chkOnlyFree.AutoSize = true;
            this.chkOnlyFree.Checked = true;
            this.chkOnlyFree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyFree.Location = new System.Drawing.Point(133, 293);
            this.chkOnlyFree.Name = "chkOnlyFree";
            this.chkOnlyFree.Size = new System.Drawing.Size(110, 17);
            this.chkOnlyFree.TabIndex = 62;
            this.chkOnlyFree.Text = "仅关联丢失连接";
            this.chkOnlyFree.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblInpAlarmReset);
            this.grpGeneral.Controls.Add(this.lblInpAlarmResetSuffix);
            this.grpGeneral.Controls.Add(this.txtInpAlarmReset);
            this.grpGeneral.Controls.Add(this.txtInpAlarmResetSuffix);
            this.grpGeneral.Controls.Add(this.lblOutpFinalClearingSuffix);
            this.grpGeneral.Controls.Add(this.txtOutpFinalClearingSuffix);
            this.grpGeneral.Controls.Add(this.lblOutpFinalClearing);
            this.grpGeneral.Controls.Add(this.txtOutpFinalClearing);
            this.grpGeneral.Controls.Add(this.grpAddInfoToDesc);
            this.grpGeneral.Controls.Add(this.lblOutpLampSuffix);
            this.grpGeneral.Controls.Add(this.txtOutpLampSuffix);
            this.grpGeneral.Controls.Add(this.lblOutpLamp);
            this.grpGeneral.Controls.Add(this.txtOutpLamp);
            this.grpGeneral.Controls.Add(this.lblInHWStop);
            this.grpGeneral.Controls.Add(this.lblInHWStopSuffix);
            this.grpGeneral.Controls.Add(this.txtInHWStop);
            this.grpGeneral.Controls.Add(this.txtInHWStopSuffix);
            this.grpGeneral.Controls.Add(this.lblInpFaultDev);
            this.grpGeneral.Controls.Add(this.lblInpFaultDevSuffix);
            this.grpGeneral.Controls.Add(this.txtInpFaultDev);
            this.grpGeneral.Controls.Add(this.txtInpFaultDevSuffix);
            this.grpGeneral.Controls.Add(this.LblSymbol);
            this.grpGeneral.Controls.Add(this.GrpDescriptionRule);
            this.grpGeneral.Controls.Add(this.txtInpRun);
            this.grpGeneral.Controls.Add(this.GrpSymbolRule);
            this.grpGeneral.Controls.Add(this.lblOutpRunSuffix);
            this.grpGeneral.Controls.Add(this.txtOutpRunSuffix);
            this.grpGeneral.Controls.Add(this.LblInpRun);
            this.grpGeneral.Controls.Add(this.txtOutpFaultResetSuffix);
            this.grpGeneral.Controls.Add(this.txtDescription);
            this.grpGeneral.Controls.Add(this.lblOutpFaultResetSuffix);
            this.grpGeneral.Controls.Add(this.txtSymbol);
            this.grpGeneral.Controls.Add(this.LblDescription);
            this.grpGeneral.Controls.Add(this.txtInpRunSuffix);
            this.grpGeneral.Controls.Add(this.txtOutpFaultReset);
            this.grpGeneral.Controls.Add(this.lblInpTrueSuffix);
            this.grpGeneral.Controls.Add(this.LblOutpFaultReset);
            this.grpGeneral.Controls.Add(this.LblOutpRun);
            this.grpGeneral.Controls.Add(this.txtOutpRun);
            this.grpGeneral.Location = new System.Drawing.Point(6, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(703, 255);
            this.grpGeneral.TabIndex = 118;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "常规";
            // 
            // lblInpAlarmReset
            // 
            this.lblInpAlarmReset.AutoSize = true;
            this.lblInpAlarmReset.Location = new System.Drawing.Point(5, 134);
            this.lblInpAlarmReset.Name = "lblInpAlarmReset";
            this.lblInpAlarmReset.Size = new System.Drawing.Size(76, 13);
            this.lblInpAlarmReset.TabIndex = 129;
            this.lblInpAlarmReset.Text = "InpAlarmReset";
            // 
            // lblInpAlarmResetSuffix
            // 
            this.lblInpAlarmResetSuffix.AutoSize = true;
            this.lblInpAlarmResetSuffix.Location = new System.Drawing.Point(114, 134);
            this.lblInpAlarmResetSuffix.Name = "lblInpAlarmResetSuffix";
            this.lblInpAlarmResetSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblInpAlarmResetSuffix.TabIndex = 130;
            this.lblInpAlarmResetSuffix.Text = "后缀";
            // 
            // txtInpAlarmReset
            // 
            this.txtInpAlarmReset.BackColor = System.Drawing.Color.LightGray;
            this.txtInpAlarmReset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpAlarmReset.Enabled = false;
            this.txtInpAlarmReset.Location = new System.Drawing.Point(9, 150);
            this.txtInpAlarmReset.Name = "txtInpAlarmReset";
            this.txtInpAlarmReset.Size = new System.Drawing.Size(100, 13);
            this.txtInpAlarmReset.TabIndex = 127;
            // 
            // txtInpAlarmResetSuffix
            // 
            this.txtInpAlarmResetSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpAlarmResetSuffix.Location = new System.Drawing.Point(112, 150);
            this.txtInpAlarmResetSuffix.Name = "txtInpAlarmResetSuffix";
            this.txtInpAlarmResetSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtInpAlarmResetSuffix.TabIndex = 128;
            this.txtInpAlarmResetSuffix.Text = ":I";
            this.txtInpAlarmResetSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOutpFinalClearingSuffix
            // 
            this.lblOutpFinalClearingSuffix.AutoSize = true;
            this.lblOutpFinalClearingSuffix.Location = new System.Drawing.Point(342, 171);
            this.lblOutpFinalClearingSuffix.Name = "lblOutpFinalClearingSuffix";
            this.lblOutpFinalClearingSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblOutpFinalClearingSuffix.TabIndex = 126;
            this.lblOutpFinalClearingSuffix.Text = "后缀";
            // 
            // txtOutpFinalClearingSuffix
            // 
            this.txtOutpFinalClearingSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpFinalClearingSuffix.Location = new System.Drawing.Point(345, 191);
            this.txtOutpFinalClearingSuffix.Name = "txtOutpFinalClearingSuffix";
            this.txtOutpFinalClearingSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtOutpFinalClearingSuffix.TabIndex = 125;
            this.txtOutpFinalClearingSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOutpFinalClearing
            // 
            this.lblOutpFinalClearing.AutoSize = true;
            this.lblOutpFinalClearing.Location = new System.Drawing.Point(235, 171);
            this.lblOutpFinalClearing.Name = "lblOutpFinalClearing";
            this.lblOutpFinalClearing.Size = new System.Drawing.Size(90, 13);
            this.lblOutpFinalClearing.TabIndex = 123;
            this.lblOutpFinalClearing.Text = "OutpFinalClearing";
            // 
            // txtOutpFinalClearing
            // 
            this.txtOutpFinalClearing.BackColor = System.Drawing.Color.LightGray;
            this.txtOutpFinalClearing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpFinalClearing.Location = new System.Drawing.Point(238, 191);
            this.txtOutpFinalClearing.Name = "txtOutpFinalClearing";
            this.txtOutpFinalClearing.Size = new System.Drawing.Size(100, 13);
            this.txtOutpFinalClearing.TabIndex = 124;
            // 
            // grpAddInfoToDesc
            // 
            this.grpAddInfoToDesc.Controls.Add(this.chkAddUserSectionToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkNameOnlyNumber);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddSectionToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddNameToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddFloorToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddCabinetToDesc);
            this.grpAddInfoToDesc.Location = new System.Drawing.Point(9, 206);
            this.grpAddInfoToDesc.Name = "grpAddInfoToDesc";
            this.grpAddInfoToDesc.Size = new System.Drawing.Size(530, 39);
            this.grpAddInfoToDesc.TabIndex = 122;
            this.grpAddInfoToDesc.TabStop = false;
            this.grpAddInfoToDesc.Text = "附加信息到描述";
            // 
            // chkAddUserSectionToDesc
            // 
            this.chkAddUserSectionToDesc.AutoSize = true;
            this.chkAddUserSectionToDesc.Location = new System.Drawing.Point(83, 17);
            this.chkAddUserSectionToDesc.Name = "chkAddUserSectionToDesc";
            this.chkAddUserSectionToDesc.Size = new System.Drawing.Size(86, 17);
            this.chkAddUserSectionToDesc.TabIndex = 126;
            this.chkAddUserSectionToDesc.Text = "自定义工段";
            this.chkAddUserSectionToDesc.UseVisualStyleBackColor = true;
            this.chkAddUserSectionToDesc.CheckedChanged += new System.EventHandler(this.chkAddUserSectionToDesc_CheckedChanged);
            // 
            // chkNameOnlyNumber
            // 
            this.chkNameOnlyNumber.AutoSize = true;
            this.chkNameOnlyNumber.Checked = true;
            this.chkNameOnlyNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNameOnlyNumber.Location = new System.Drawing.Point(423, 17);
            this.chkNameOnlyNumber.Name = "chkNameOnlyNumber";
            this.chkNameOnlyNumber.Size = new System.Drawing.Size(98, 17);
            this.chkNameOnlyNumber.TabIndex = 125;
            this.chkNameOnlyNumber.Text = "编号仅含数字";
            this.chkNameOnlyNumber.UseVisualStyleBackColor = true;
            this.chkNameOnlyNumber.CheckedChanged += new System.EventHandler(this.chkNameOnlyNumber_CheckedChanged);
            // 
            // chkAddSectionToDesc
            // 
            this.chkAddSectionToDesc.AutoSize = true;
            this.chkAddSectionToDesc.Checked = true;
            this.chkAddSectionToDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddSectionToDesc.Location = new System.Drawing.Point(7, 17);
            this.chkAddSectionToDesc.Name = "chkAddSectionToDesc";
            this.chkAddSectionToDesc.Size = new System.Drawing.Size(50, 17);
            this.chkAddSectionToDesc.TabIndex = 123;
            this.chkAddSectionToDesc.Text = "工段";
            this.chkAddSectionToDesc.UseVisualStyleBackColor = true;
            this.chkAddSectionToDesc.CheckedChanged += new System.EventHandler(this.chkAddSectionToDesc_CheckedChanged);
            // 
            // chkAddNameToDesc
            // 
            this.chkAddNameToDesc.AutoSize = true;
            this.chkAddNameToDesc.Checked = true;
            this.chkAddNameToDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddNameToDesc.Location = new System.Drawing.Point(271, 17);
            this.chkAddNameToDesc.Name = "chkAddNameToDesc";
            this.chkAddNameToDesc.Size = new System.Drawing.Size(50, 17);
            this.chkAddNameToDesc.TabIndex = 119;
            this.chkAddNameToDesc.Text = "编号";
            this.chkAddNameToDesc.UseVisualStyleBackColor = true;
            this.chkAddNameToDesc.CheckedChanged += new System.EventHandler(this.chkAddNameToDesc_CheckedChanged);
            // 
            // chkAddFloorToDesc
            // 
            this.chkAddFloorToDesc.AutoSize = true;
            this.chkAddFloorToDesc.Checked = true;
            this.chkAddFloorToDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddFloorToDesc.Location = new System.Drawing.Point(195, 17);
            this.chkAddFloorToDesc.Name = "chkAddFloorToDesc";
            this.chkAddFloorToDesc.Size = new System.Drawing.Size(50, 17);
            this.chkAddFloorToDesc.TabIndex = 121;
            this.chkAddFloorToDesc.Text = "楼层";
            this.chkAddFloorToDesc.UseVisualStyleBackColor = true;
            this.chkAddFloorToDesc.CheckedChanged += new System.EventHandler(this.chkAddFloorToDesc_CheckedChanged);
            // 
            // chkAddCabinetToDesc
            // 
            this.chkAddCabinetToDesc.AutoSize = true;
            this.chkAddCabinetToDesc.Checked = true;
            this.chkAddCabinetToDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddCabinetToDesc.Location = new System.Drawing.Point(347, 17);
            this.chkAddCabinetToDesc.Name = "chkAddCabinetToDesc";
            this.chkAddCabinetToDesc.Size = new System.Drawing.Size(50, 17);
            this.chkAddCabinetToDesc.TabIndex = 120;
            this.chkAddCabinetToDesc.Text = "电柜";
            this.chkAddCabinetToDesc.UseVisualStyleBackColor = true;
            this.chkAddCabinetToDesc.CheckedChanged += new System.EventHandler(this.chkAddCabinetToDesc_CheckedChanged);
            // 
            // lblOutpLampSuffix
            // 
            this.lblOutpLampSuffix.AutoSize = true;
            this.lblOutpLampSuffix.Location = new System.Drawing.Point(342, 130);
            this.lblOutpLampSuffix.Name = "lblOutpLampSuffix";
            this.lblOutpLampSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblOutpLampSuffix.TabIndex = 121;
            this.lblOutpLampSuffix.Text = "后缀";
            // 
            // txtOutpLampSuffix
            // 
            this.txtOutpLampSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpLampSuffix.Location = new System.Drawing.Point(345, 150);
            this.txtOutpLampSuffix.Name = "txtOutpLampSuffix";
            this.txtOutpLampSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtOutpLampSuffix.TabIndex = 120;
            this.txtOutpLampSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOutpLampSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutpLampSuffix_KeyDown);
            // 
            // lblOutpLamp
            // 
            this.lblOutpLamp.AutoSize = true;
            this.lblOutpLamp.Location = new System.Drawing.Point(235, 130);
            this.lblOutpLamp.Name = "lblOutpLamp";
            this.lblOutpLamp.Size = new System.Drawing.Size(56, 13);
            this.lblOutpLamp.TabIndex = 118;
            this.lblOutpLamp.Text = "OutpLamp";
            // 
            // txtOutpLamp
            // 
            this.txtOutpLamp.BackColor = System.Drawing.Color.LightGray;
            this.txtOutpLamp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpLamp.Location = new System.Drawing.Point(238, 150);
            this.txtOutpLamp.Name = "txtOutpLamp";
            this.txtOutpLamp.Size = new System.Drawing.Size(100, 13);
            this.txtOutpLamp.TabIndex = 119;
            // 
            // lblInHWStop
            // 
            this.lblInHWStop.AutoSize = true;
            this.lblInHWStop.Location = new System.Drawing.Point(5, 171);
            this.lblInHWStop.Name = "lblInHWStop";
            this.lblInHWStop.Size = new System.Drawing.Size(63, 13);
            this.lblInHWStop.TabIndex = 116;
            this.lblInHWStop.Text = "[InHWStop]";
            // 
            // lblInHWStopSuffix
            // 
            this.lblInHWStopSuffix.AutoSize = true;
            this.lblInHWStopSuffix.Location = new System.Drawing.Point(114, 171);
            this.lblInHWStopSuffix.Name = "lblInHWStopSuffix";
            this.lblInHWStopSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblInHWStopSuffix.TabIndex = 117;
            this.lblInHWStopSuffix.Text = "后缀";
            // 
            // txtInHWStop
            // 
            this.txtInHWStop.BackColor = System.Drawing.Color.LightGray;
            this.txtInHWStop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInHWStop.Enabled = false;
            this.txtInHWStop.Location = new System.Drawing.Point(9, 187);
            this.txtInHWStop.Name = "txtInHWStop";
            this.txtInHWStop.Size = new System.Drawing.Size(100, 13);
            this.txtInHWStop.TabIndex = 114;
            // 
            // txtInHWStopSuffix
            // 
            this.txtInHWStopSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInHWStopSuffix.Location = new System.Drawing.Point(112, 187);
            this.txtInHWStopSuffix.Name = "txtInHWStopSuffix";
            this.txtInHWStopSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtInHWStopSuffix.TabIndex = 115;
            this.txtInHWStopSuffix.Text = ":I";
            this.txtInHWStopSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInpFaultDev
            // 
            this.lblInpFaultDev.AutoSize = true;
            this.lblInpFaultDev.Location = new System.Drawing.Point(5, 99);
            this.lblInpFaultDev.Name = "lblInpFaultDev";
            this.lblInpFaultDev.Size = new System.Drawing.Size(65, 13);
            this.lblInpFaultDev.TabIndex = 112;
            this.lblInpFaultDev.Text = "InpFaultDev";
            // 
            // lblInpFaultDevSuffix
            // 
            this.lblInpFaultDevSuffix.AutoSize = true;
            this.lblInpFaultDevSuffix.Location = new System.Drawing.Point(114, 99);
            this.lblInpFaultDevSuffix.Name = "lblInpFaultDevSuffix";
            this.lblInpFaultDevSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblInpFaultDevSuffix.TabIndex = 113;
            this.lblInpFaultDevSuffix.Text = "后缀";
            // 
            // txtInpFaultDev
            // 
            this.txtInpFaultDev.BackColor = System.Drawing.Color.LightGray;
            this.txtInpFaultDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpFaultDev.Enabled = false;
            this.txtInpFaultDev.Location = new System.Drawing.Point(9, 115);
            this.txtInpFaultDev.Name = "txtInpFaultDev";
            this.txtInpFaultDev.Size = new System.Drawing.Size(100, 13);
            this.txtInpFaultDev.TabIndex = 110;
            // 
            // txtInpFaultDevSuffix
            // 
            this.txtInpFaultDevSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpFaultDevSuffix.Location = new System.Drawing.Point(112, 115);
            this.txtInpFaultDevSuffix.Name = "txtInpFaultDevSuffix";
            this.txtInpFaultDevSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtInpFaultDevSuffix.TabIndex = 111;
            this.txtInpFaultDevSuffix.Text = ":I";
            this.txtInpFaultDevSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInpFaultDevSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInpFaultDevSuffix_KeyDown);
            // 
            // LblSymbol
            // 
            this.LblSymbol.AutoSize = true;
            this.LblSymbol.Location = new System.Drawing.Point(6, 16);
            this.LblSymbol.Name = "LblSymbol";
            this.LblSymbol.Size = new System.Drawing.Size(31, 13);
            this.LblSymbol.TabIndex = 0;
            this.LblSymbol.Text = "名称";
            // 
            // GrpDescriptionRule
            // 
            this.GrpDescriptionRule.Controls.Add(this.LblDescriptionRule);
            this.GrpDescriptionRule.Controls.Add(this.txtDescriptionIncRule);
            this.GrpDescriptionRule.Controls.Add(this.Lbl);
            this.GrpDescriptionRule.Controls.Add(this.txtDescriptionRule);
            this.GrpDescriptionRule.Location = new System.Drawing.Point(603, 16);
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
            // txtDescriptionIncRule
            // 
            this.txtDescriptionIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescriptionIncRule.Location = new System.Drawing.Point(6, 67);
            this.txtDescriptionIncRule.Name = "txtDescriptionIncRule";
            this.txtDescriptionIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtDescriptionIncRule.TabIndex = 72;
            this.txtDescriptionIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescriptionIncRule_KeyDown);
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
            // txtDescriptionRule
            // 
            this.txtDescriptionRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescriptionRule.Location = new System.Drawing.Point(6, 30);
            this.txtDescriptionRule.Name = "txtDescriptionRule";
            this.txtDescriptionRule.Size = new System.Drawing.Size(66, 13);
            this.txtDescriptionRule.TabIndex = 11;
            this.txtDescriptionRule.TextChanged += new System.EventHandler(this.TxtDescriptionRule_TextChanged);
            // 
            // txtInpRun
            // 
            this.txtInpRun.BackColor = System.Drawing.Color.LightGray;
            this.txtInpRun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpRun.Location = new System.Drawing.Point(8, 79);
            this.txtInpRun.Name = "txtInpRun";
            this.txtInpRun.Size = new System.Drawing.Size(100, 13);
            this.txtInpRun.TabIndex = 6;
            this.txtInpRun.MouseEnter += new System.EventHandler(this.txtInpRun_MouseEnter);
            // 
            // GrpSymbolRule
            // 
            this.GrpSymbolRule.Controls.Add(this.LblSymbolRule);
            this.GrpSymbolRule.Controls.Add(this.txtSymbolRule);
            this.GrpSymbolRule.Controls.Add(this.txtSymbolIncRule);
            this.GrpSymbolRule.Controls.Add(this.LblSymbolIncRule);
            this.GrpSymbolRule.Location = new System.Drawing.Point(151, 16);
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
            // txtSymbolRule
            // 
            this.txtSymbolRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbolRule.Location = new System.Drawing.Point(6, 30);
            this.txtSymbolRule.Name = "txtSymbolRule";
            this.txtSymbolRule.Size = new System.Drawing.Size(66, 13);
            this.txtSymbolRule.TabIndex = 10;
            this.txtSymbolRule.TextChanged += new System.EventHandler(this.TxtSymbolRule_TextChanged);
            // 
            // txtSymbolIncRule
            // 
            this.txtSymbolIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbolIncRule.Location = new System.Drawing.Point(6, 67);
            this.txtSymbolIncRule.Name = "txtSymbolIncRule";
            this.txtSymbolIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtSymbolIncRule.TabIndex = 71;
            this.txtSymbolIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSymbolIncRule_KeyDown);
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
            // lblOutpRunSuffix
            // 
            this.lblOutpRunSuffix.AutoSize = true;
            this.lblOutpRunSuffix.Location = new System.Drawing.Point(342, 53);
            this.lblOutpRunSuffix.Name = "lblOutpRunSuffix";
            this.lblOutpRunSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblOutpRunSuffix.TabIndex = 109;
            this.lblOutpRunSuffix.Text = "后缀";
            // 
            // txtOutpRunSuffix
            // 
            this.txtOutpRunSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpRunSuffix.Location = new System.Drawing.Point(345, 73);
            this.txtOutpRunSuffix.Name = "txtOutpRunSuffix";
            this.txtOutpRunSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtOutpRunSuffix.TabIndex = 108;
            this.txtOutpRunSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOutpRunSuffix.TextChanged += new System.EventHandler(this.txtOutpRunSuffix_TextChanged);
            this.txtOutpRunSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutpRunSuffix_KeyDown);
            // 
            // LblInpRun
            // 
            this.LblInpRun.AutoSize = true;
            this.LblInpRun.Location = new System.Drawing.Point(5, 59);
            this.LblInpRun.Name = "LblInpRun";
            this.LblInpRun.Size = new System.Drawing.Size(42, 13);
            this.LblInpRun.TabIndex = 4;
            this.LblInpRun.Text = "InpRun";
            // 
            // txtOutpFaultResetSuffix
            // 
            this.txtOutpFaultResetSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpFaultResetSuffix.Location = new System.Drawing.Point(345, 111);
            this.txtOutpFaultResetSuffix.Name = "txtOutpFaultResetSuffix";
            this.txtOutpFaultResetSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtOutpFaultResetSuffix.TabIndex = 106;
            this.txtOutpFaultResetSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOutpFaultResetSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutpFaultResetSuffix_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(245, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(346, 13);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.MouseEnter += new System.EventHandler(this.TxtDescription_MouseEnter);
            // 
            // lblOutpFaultResetSuffix
            // 
            this.lblOutpFaultResetSuffix.AutoSize = true;
            this.lblOutpFaultResetSuffix.Location = new System.Drawing.Point(342, 91);
            this.lblOutpFaultResetSuffix.Name = "lblOutpFaultResetSuffix";
            this.lblOutpFaultResetSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblOutpFaultResetSuffix.TabIndex = 107;
            this.lblOutpFaultResetSuffix.Text = "后缀";
            // 
            // txtSymbol
            // 
            this.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbol.Location = new System.Drawing.Point(8, 32);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(137, 13);
            this.txtSymbol.TabIndex = 2;
            this.txtSymbol.TextChanged += new System.EventHandler(this.TxtSymbol_TextChanged);
            this.txtSymbol.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSymbol_MouseDoubleClick);
            this.txtSymbol.MouseEnter += new System.EventHandler(this.TxtSymbol_MouseEnter);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(242, 16);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(55, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "输入描述";
            // 
            // txtInpRunSuffix
            // 
            this.txtInpRunSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpRunSuffix.Location = new System.Drawing.Point(111, 79);
            this.txtInpRunSuffix.Name = "txtInpRunSuffix";
            this.txtInpRunSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtInpRunSuffix.TabIndex = 86;
            this.txtInpRunSuffix.Text = ":I";
            this.txtInpRunSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInpRunSuffix.TextChanged += new System.EventHandler(this.txtInpRunSuffix_TextChanged);
            this.txtInpRunSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInpRunSuffix_KeyDown);
            // 
            // txtOutpFaultReset
            // 
            this.txtOutpFaultReset.BackColor = System.Drawing.Color.LightGray;
            this.txtOutpFaultReset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpFaultReset.Location = new System.Drawing.Point(237, 111);
            this.txtOutpFaultReset.Name = "txtOutpFaultReset";
            this.txtOutpFaultReset.Size = new System.Drawing.Size(100, 13);
            this.txtOutpFaultReset.TabIndex = 101;
            // 
            // lblInpTrueSuffix
            // 
            this.lblInpTrueSuffix.AutoSize = true;
            this.lblInpTrueSuffix.Location = new System.Drawing.Point(114, 59);
            this.lblInpTrueSuffix.Name = "lblInpTrueSuffix";
            this.lblInpTrueSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblInpTrueSuffix.TabIndex = 86;
            this.lblInpTrueSuffix.Text = "后缀";
            // 
            // LblOutpFaultReset
            // 
            this.LblOutpFaultReset.AutoSize = true;
            this.LblOutpFaultReset.Location = new System.Drawing.Point(234, 91);
            this.LblOutpFaultReset.Name = "LblOutpFaultReset";
            this.LblOutpFaultReset.Size = new System.Drawing.Size(81, 13);
            this.LblOutpFaultReset.TabIndex = 100;
            this.LblOutpFaultReset.Text = "OutpFaultReset";
            // 
            // LblOutpRun
            // 
            this.LblOutpRun.AutoSize = true;
            this.LblOutpRun.Location = new System.Drawing.Point(235, 53);
            this.LblOutpRun.Name = "LblOutpRun";
            this.LblOutpRun.Size = new System.Drawing.Size(50, 13);
            this.LblOutpRun.TabIndex = 102;
            this.LblOutpRun.Text = "OutpRun";
            // 
            // txtOutpRun
            // 
            this.txtOutpRun.BackColor = System.Drawing.Color.LightGray;
            this.txtOutpRun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpRun.Location = new System.Drawing.Point(238, 73);
            this.txtOutpRun.Name = "txtOutpRun";
            this.txtOutpRun.Size = new System.Drawing.Size(100, 13);
            this.txtOutpRun.TabIndex = 103;
            // 
            // BtnRegenerateDPNode
            // 
            this.BtnRegenerateDPNode.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegenerateDPNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegenerateDPNode.BackgroundImage")));
            this.BtnRegenerateDPNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRegenerateDPNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegenerateDPNode.Location = new System.Drawing.Point(48, 285);
            this.BtnRegenerateDPNode.Name = "BtnRegenerateDPNode";
            this.BtnRegenerateDPNode.Size = new System.Drawing.Size(36, 30);
            this.BtnRegenerateDPNode.TabIndex = 88;
            this.BtnRegenerateDPNode.UseVisualStyleBackColor = false;
            this.BtnRegenerateDPNode.Click += new System.EventHandler(this.BtnRegenerateDPNode_Click);
            // 
            // BtnNewImpExpDef
            // 
            this.BtnNewImpExpDef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewImpExpDef.BackgroundImage")));
            this.BtnNewImpExpDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewImpExpDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewImpExpDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewImpExpDef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewImpExpDef.Location = new System.Drawing.Point(6, 285);
            this.BtnNewImpExpDef.Name = "BtnNewImpExpDef";
            this.BtnNewImpExpDef.Size = new System.Drawing.Size(36, 30);
            this.BtnNewImpExpDef.TabIndex = 76;
            this.BtnNewImpExpDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewImpExpDef.UseVisualStyleBackColor = true;
            this.BtnNewImpExpDef.Click += new System.EventHandler(this.BtnNewImpExpDef_Click);
            // 
            // LblEquipmentInfoType
            // 
            this.LblEquipmentInfoType.AutoSize = true;
            this.LblEquipmentInfoType.Location = new System.Drawing.Point(2, 332);
            this.LblEquipmentInfoType.Name = "LblEquipmentInfoType";
            this.LblEquipmentInfoType.Size = new System.Drawing.Size(99, 13);
            this.LblEquipmentInfoType.TabIndex = 12;
            this.LblEquipmentInfoType.Text = "EquipmentInfoType";
            // 
            // comboEquipmentInfoType
            // 
            this.comboEquipmentInfoType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEquipmentInfoType.FormattingEnabled = true;
            this.comboEquipmentInfoType.IntegralHeight = false;
            this.comboEquipmentInfoType.Location = new System.Drawing.Point(126, 329);
            this.comboEquipmentInfoType.Name = "comboEquipmentInfoType";
            this.comboEquipmentInfoType.Size = new System.Drawing.Size(357, 21);
            this.comboEquipmentInfoType.TabIndex = 13;
            this.comboEquipmentInfoType.MouseEnter += new System.EventHandler(this.ComboEquipmentInfoType_MouseEnter);
            // 
            // LblHornCode
            // 
            this.LblHornCode.AutoSize = true;
            this.LblHornCode.Location = new System.Drawing.Point(2, 357);
            this.LblHornCode.Name = "LblHornCode";
            this.LblHornCode.Size = new System.Drawing.Size(71, 13);
            this.LblHornCode.TabIndex = 14;
            this.LblHornCode.Text = "ParHornCode";
            // 
            // ComboHornCode
            // 
            this.ComboHornCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHornCode.FormattingEnabled = true;
            this.ComboHornCode.Location = new System.Drawing.Point(126, 353);
            this.ComboHornCode.Name = "ComboHornCode";
            this.ComboHornCode.Size = new System.Drawing.Size(146, 21);
            this.ComboHornCode.TabIndex = 15;
            this.ComboHornCode.MouseEnter += new System.EventHandler(this.ComboHornCode_MouseEnter);
            // 
            // lblDPNode1
            // 
            this.lblDPNode1.AutoSize = true;
            this.lblDPNode1.Location = new System.Drawing.Point(2, 382);
            this.lblDPNode1.Name = "lblDPNode1";
            this.lblDPNode1.Size = new System.Drawing.Size(70, 13);
            this.lblDPNode1.TabIndex = 16;
            this.lblDPNode1.Text = "ParDPNode1";
            // 
            // BtnConnectIO
            // 
            this.BtnConnectIO.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConnectIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConnectIO.BackgroundImage")));
            this.BtnConnectIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConnectIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnectIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnectIO.Location = new System.Drawing.Point(90, 285);
            this.BtnConnectIO.Name = "BtnConnectIO";
            this.BtnConnectIO.Size = new System.Drawing.Size(36, 30);
            this.BtnConnectIO.TabIndex = 98;
            this.BtnConnectIO.UseVisualStyleBackColor = false;
            this.BtnConnectIO.Click += new System.EventHandler(this.BtnConnectIO_Click);
            // 
            // comboDPNode1
            // 
            this.comboDPNode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDPNode1.FormattingEnabled = true;
            this.comboDPNode1.Location = new System.Drawing.Point(126, 376);
            this.comboDPNode1.Name = "comboDPNode1";
            this.comboDPNode1.Size = new System.Drawing.Size(146, 21);
            this.comboDPNode1.TabIndex = 18;
            this.comboDPNode1.MouseEnter += new System.EventHandler(this.comboDPNode1_MouseEnter);
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
            this.tabBML.Size = new System.Drawing.Size(723, 553);
            this.tabBML.TabIndex = 1;
            this.tabBML.Text = "通过BML创建";
            // 
            // grpBoxExcelData
            // 
            this.grpBoxExcelData.Controls.Add(this.btnReadBML);
            this.grpBoxExcelData.Controls.Add(this.dataGridBML);
            this.grpBoxExcelData.Controls.Add(this.lblWorkSheet);
            this.grpBoxExcelData.Controls.Add(this.comboWorkSheetsBML);
            this.grpBoxExcelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxExcelData.Location = new System.Drawing.Point(3, 121);
            this.grpBoxExcelData.Name = "grpBoxExcelData";
            this.grpBoxExcelData.Size = new System.Drawing.Size(717, 429);
            this.grpBoxExcelData.TabIndex = 16;
            this.grpBoxExcelData.TabStop = false;
            this.grpBoxExcelData.Text = "BML数据";
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
            this.dataGridBML.AllowUserToAddRows = false;
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
            this.dataGridBML.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridBML_RowsRemoved);
            // 
            // lblWorkSheet
            // 
            this.lblWorkSheet.AutoSize = true;
            this.lblWorkSheet.Location = new System.Drawing.Point(6, 27);
            this.lblWorkSheet.Name = "lblWorkSheet";
            this.lblWorkSheet.Size = new System.Drawing.Size(43, 13);
            this.lblWorkSheet.TabIndex = 14;
            this.lblWorkSheet.Text = "工作表";
            // 
            // comboWorkSheetsBML
            // 
            this.comboWorkSheetsBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboWorkSheetsBML.FormattingEnabled = true;
            this.comboWorkSheetsBML.IntegralHeight = false;
            this.comboWorkSheetsBML.Location = new System.Drawing.Point(48, 24);
            this.comboWorkSheetsBML.Name = "comboWorkSheetsBML";
            this.comboWorkSheetsBML.Size = new System.Drawing.Size(313, 21);
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
            this.grpBoxBMLColum.Controls.Add(this.comboLineBML);
            this.grpBoxBMLColum.Controls.Add(this.lblLineBML);
            this.grpBoxBMLColum.Controls.Add(this.comboIORemarkBML);
            this.grpBoxBMLColum.Controls.Add(this.comboControlBML);
            this.grpBoxBMLColum.Controls.Add(this.lblIORemarkBML);
            this.grpBoxBMLColum.Controls.Add(this.lblControlBML);
            this.grpBoxBMLColum.Controls.Add(this.comboStartRow);
            this.grpBoxBMLColum.Controls.Add(this.lblStartRow);
            this.grpBoxBMLColum.Controls.Add(this.comboSectionBML);
            this.grpBoxBMLColum.Controls.Add(this.comboDescBML);
            this.grpBoxBMLColum.Controls.Add(this.comboCabinetBML);
            this.grpBoxBMLColum.Controls.Add(this.comboFloorBML);
            this.grpBoxBMLColum.Controls.Add(this.comboTypeBML);
            this.grpBoxBMLColum.Controls.Add(this.comboNameBML);
            this.grpBoxBMLColum.Controls.Add(this.lblFloor);
            this.grpBoxBMLColum.Controls.Add(this.lblSection);
            this.grpBoxBMLColum.Controls.Add(this.lblType);
            this.grpBoxBMLColum.Controls.Add(this.lblCabibetNo);
            this.grpBoxBMLColum.Controls.Add(this.lblBMLDescription);
            this.grpBoxBMLColum.Controls.Add(this.lblBMLSymbol);
            this.grpBoxBMLColum.Location = new System.Drawing.Point(6, 40);
            this.grpBoxBMLColum.Name = "grpBoxBMLColum";
            this.grpBoxBMLColum.Size = new System.Drawing.Size(692, 68);
            this.grpBoxBMLColum.TabIndex = 16;
            this.grpBoxBMLColum.TabStop = false;
            this.grpBoxBMLColum.Text = "信息列";
            // 
            // comboLineBML
            // 
            this.comboLineBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLineBML.FormattingEnabled = true;
            this.comboLineBML.IntegralHeight = false;
            this.comboLineBML.Location = new System.Drawing.Point(619, 16);
            this.comboLineBML.Name = "comboLineBML";
            this.comboLineBML.Size = new System.Drawing.Size(66, 21);
            this.comboLineBML.TabIndex = 33;
            // 
            // lblLineBML
            // 
            this.lblLineBML.AutoSize = true;
            this.lblLineBML.Location = new System.Drawing.Point(573, 19);
            this.lblLineBML.Name = "lblLineBML";
            this.lblLineBML.Size = new System.Drawing.Size(55, 13);
            this.lblLineBML.TabIndex = 32;
            this.lblLineBML.Text = "生产线：";
            // 
            // comboIORemarkBML
            // 
            this.comboIORemarkBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboIORemarkBML.FormattingEnabled = true;
            this.comboIORemarkBML.IntegralHeight = false;
            this.comboIORemarkBML.Location = new System.Drawing.Point(206, 44);
            this.comboIORemarkBML.Name = "comboIORemarkBML";
            this.comboIORemarkBML.Size = new System.Drawing.Size(66, 21);
            this.comboIORemarkBML.TabIndex = 31;
            // 
            // comboControlBML
            // 
            this.comboControlBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboControlBML.FormattingEnabled = true;
            this.comboControlBML.IntegralHeight = false;
            this.comboControlBML.Location = new System.Drawing.Point(341, 41);
            this.comboControlBML.Name = "comboControlBML";
            this.comboControlBML.Size = new System.Drawing.Size(66, 21);
            this.comboControlBML.TabIndex = 29;
            // 
            // lblIORemarkBML
            // 
            this.lblIORemarkBML.AutoSize = true;
            this.lblIORemarkBML.Location = new System.Drawing.Point(146, 49);
            this.lblIORemarkBML.Name = "lblIORemarkBML";
            this.lblIORemarkBML.Size = new System.Drawing.Size(54, 13);
            this.lblIORemarkBML.TabIndex = 30;
            this.lblIORemarkBML.Text = "IO注释：";
            // 
            // lblControlBML
            // 
            this.lblControlBML.AutoSize = true;
            this.lblControlBML.Location = new System.Drawing.Point(281, 45);
            this.lblControlBML.Name = "lblControlBML";
            this.lblControlBML.Size = new System.Drawing.Size(67, 13);
            this.lblControlBML.TabIndex = 28;
            this.lblControlBML.Text = "控制类型：";
            // 
            // comboStartRow
            // 
            this.comboStartRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStartRow.FormattingEnabled = true;
            this.comboStartRow.IntegralHeight = false;
            this.comboStartRow.Location = new System.Drawing.Point(620, 43);
            this.comboStartRow.Name = "comboStartRow";
            this.comboStartRow.Size = new System.Drawing.Size(66, 21);
            this.comboStartRow.TabIndex = 28;
            // 
            // lblStartRow
            // 
            this.lblStartRow.AutoSize = true;
            this.lblStartRow.Location = new System.Drawing.Point(579, 46);
            this.lblStartRow.Name = "lblStartRow";
            this.lblStartRow.Size = new System.Drawing.Size(43, 13);
            this.lblStartRow.TabIndex = 28;
            this.lblStartRow.Text = "起始行";
            // 
            // comboSectionBML
            // 
            this.comboSectionBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSectionBML.FormattingEnabled = true;
            this.comboSectionBML.IntegralHeight = false;
            this.comboSectionBML.Location = new System.Drawing.Point(501, 44);
            this.comboSectionBML.Name = "comboSectionBML";
            this.comboSectionBML.Size = new System.Drawing.Size(66, 21);
            this.comboSectionBML.TabIndex = 27;
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
            this.comboCabinetBML.Location = new System.Drawing.Point(501, 18);
            this.comboCabinetBML.Name = "comboCabinetBML";
            this.comboCabinetBML.Size = new System.Drawing.Size(66, 21);
            this.comboCabinetBML.TabIndex = 23;
            // 
            // comboFloorBML
            // 
            this.comboFloorBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFloorBML.FormattingEnabled = true;
            this.comboFloorBML.IntegralHeight = false;
            this.comboFloorBML.Location = new System.Drawing.Point(341, 19);
            this.comboFloorBML.Name = "comboFloorBML";
            this.comboFloorBML.Size = new System.Drawing.Size(66, 21);
            this.comboFloorBML.TabIndex = 22;
            // 
            // comboTypeBML
            // 
            this.comboTypeBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTypeBML.FormattingEnabled = true;
            this.comboTypeBML.IntegralHeight = false;
            this.comboTypeBML.Location = new System.Drawing.Point(206, 18);
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
            this.lblFloor.Location = new System.Drawing.Point(292, 24);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(43, 13);
            this.lblFloor.TabIndex = 12;
            this.lblFloor.Text = "楼层：";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(440, 49);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(55, 13);
            this.lblSection.TabIndex = 10;
            this.lblSection.Text = "电柜组：";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(157, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "类型：";
            // 
            // lblCabibetNo
            // 
            this.lblCabibetNo.AutoSize = true;
            this.lblCabibetNo.Location = new System.Drawing.Point(440, 19);
            this.lblCabibetNo.Name = "lblCabibetNo";
            this.lblCabibetNo.Size = new System.Drawing.Size(43, 13);
            this.lblCabibetNo.TabIndex = 6;
            this.lblCabibetNo.Text = "电柜：";
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
            this.LblPanel.Size = new System.Drawing.Size(34, 13);
            this.LblPanel.TabIndex = 49;
            this.LblPanel.Text = "Panel";
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
            this.ComboPanel.SelectedIndexChanged += new System.EventHandler(this.ComboPanel_SelectedIndexChanged);
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
            this.ComboElevation.SelectedIndexChanged += new System.EventHandler(this.ComboElevation_SelectedIndexChanged);
            // 
            // LblDiagram
            // 
            this.LblDiagram.AutoSize = true;
            this.LblDiagram.Location = new System.Drawing.Point(298, 121);
            this.LblDiagram.Name = "LblDiagram";
            this.LblDiagram.Size = new System.Drawing.Size(46, 13);
            this.LblDiagram.TabIndex = 51;
            this.LblDiagram.Text = "Diagram";
            // 
            // LblElevation
            // 
            this.LblElevation.AutoSize = true;
            this.LblElevation.Location = new System.Drawing.Point(3, 148);
            this.LblElevation.Name = "LblElevation";
            this.LblElevation.Size = new System.Drawing.Size(51, 13);
            this.LblElevation.TabIndex = 47;
            this.LblElevation.Text = "Elevation";
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
            this.LblBuilding.Size = new System.Drawing.Size(44, 13);
            this.LblBuilding.TabIndex = 45;
            this.LblBuilding.Text = "Buliding";
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
            this.LblProcessFct.Size = new System.Drawing.Size(63, 13);
            this.LblProcessFct.TabIndex = 43;
            this.LblProcessFct.Text = "Process Fct";
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
            this.LblEquipmentSubType.Size = new System.Drawing.Size(46, 13);
            this.LblEquipmentSubType.TabIndex = 41;
            this.LblEquipmentSubType.Text = "Subtype";
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
            this.PalCommon.Size = new System.Drawing.Size(731, 199);
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
            this.lblPage.Size = new System.Drawing.Size(32, 13);
            this.lblPage.TabIndex = 58;
            this.lblPage.Text = "Page";
            // 
            // FormDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(731, 800);
            this.Controls.Add(this.PalCommon);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabCreateMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDO";
            this.Text = "EL_DO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDO_FormClosed);
            this.Load += new System.EventHandler(this.FormDO_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCreateMode.ResumeLayout(false);
            this.contextMenuStripBML.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.tabRule.PerformLayout();
            this.PalGcObject.ResumeLayout(false);
            this.PalGcObject.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpAddInfoToDesc.ResumeLayout(false);
            this.grpAddInfoToDesc.PerformLayout();
            this.GrpDescriptionRule.ResumeLayout(false);
            this.GrpDescriptionRule.PerformLayout();
            this.GrpSymbolRule.ResumeLayout(false);
            this.GrpSymbolRule.PerformLayout();
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
        internal System.Windows.Forms.Button BtnRegenerateDPNode;
        internal System.Windows.Forms.Label LblSymbol;
        internal System.Windows.Forms.Label LblDescription;
        internal System.Windows.Forms.Button BtnNewImpExpDef;
        internal System.Windows.Forms.TextBox txtSymbol;
        internal System.Windows.Forms.Button BtnConnectIO;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label LblInpRun;
        internal System.Windows.Forms.GroupBox GrpSymbolRule;
        internal System.Windows.Forms.Label LblSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolIncRule;
        internal System.Windows.Forms.Label LblSymbolIncRule;
        internal System.Windows.Forms.TextBox txtInpRun;
        internal System.Windows.Forms.GroupBox GrpDescriptionRule;
        internal System.Windows.Forms.Label LblDescriptionRule;
        internal System.Windows.Forms.TextBox txtDescriptionIncRule;
        internal System.Windows.Forms.Label Lbl;
        internal System.Windows.Forms.TextBox txtDescriptionRule;
        internal System.Windows.Forms.Label LblEquipmentInfoType;
        internal System.Windows.Forms.ComboBox comboEquipmentInfoType;
        internal System.Windows.Forms.Label LblHornCode;
        internal System.Windows.Forms.ComboBox ComboHornCode;
        internal System.Windows.Forms.Label lblDPNode1;
        private System.Windows.Forms.GroupBox grpBoxExcelColumn;
        private System.Windows.Forms.Label lblBMLSymbol;
        private System.Windows.Forms.Label lblBMLDescription;
        internal System.Windows.Forms.Label lblWorkSheet;
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
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.GroupBox grpBoxExcelData;
        private System.Windows.Forms.DataGridView dataGridBML;
        internal System.Windows.Forms.Button btnReadBML;
        internal System.Windows.Forms.ComboBox comboSectionBML;
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
        internal System.Windows.Forms.Label LblOutpRun;
        internal System.Windows.Forms.TextBox txtOutpRun;
        internal System.Windows.Forms.Label LblOutpFaultReset;
        internal System.Windows.Forms.TextBox txtOutpFaultReset;
        internal System.Windows.Forms.Label lblInpTrueSuffix;
        internal System.Windows.Forms.TextBox txtInpRunSuffix;
        internal System.Windows.Forms.Label lblOutpRunSuffix;
        internal System.Windows.Forms.TextBox txtOutpRunSuffix;
        internal System.Windows.Forms.TextBox txtOutpFaultResetSuffix;
        internal System.Windows.Forms.Label lblOutpFaultResetSuffix;
        private System.Windows.Forms.GroupBox grpGeneral;
        internal System.Windows.Forms.CheckBox chkOnlyFree;
        internal System.Windows.Forms.ComboBox comboControlBML;
        private System.Windows.Forms.Label lblControlBML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        internal System.Windows.Forms.CheckBox chkParPulse;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtValue10;
        internal System.Windows.Forms.Label lblStartDelay;
        internal System.Windows.Forms.TextBox txtParStartDelay;
        internal System.Windows.Forms.Label lblParStartingTime;
        internal System.Windows.Forms.TextBox txtParStartingTime;
        internal System.Windows.Forms.Label lblParOnTime;
        internal System.Windows.Forms.TextBox txtParOnTime;
        internal System.Windows.Forms.Label LblParOffTime;
        internal System.Windows.Forms.TextBox txtParOffTime;
        internal System.Windows.Forms.Label lblParIdlingTime;
        internal System.Windows.Forms.TextBox txtParIdlingTime;
        internal System.Windows.Forms.CheckBox chkParLogOff;
        internal System.Windows.Forms.CheckBox chkParManual;
        internal System.Windows.Forms.CheckBox chkParContinuous;
        internal System.Windows.Forms.ComboBox comboDPNode1;
        internal System.Windows.Forms.Label lblOutpLampSuffix;
        internal System.Windows.Forms.TextBox txtOutpLampSuffix;
        internal System.Windows.Forms.Label lblOutpLamp;
        internal System.Windows.Forms.TextBox txtOutpLamp;
        internal System.Windows.Forms.Label lblInHWStop;
        internal System.Windows.Forms.Label lblInHWStopSuffix;
        internal System.Windows.Forms.TextBox txtInHWStop;
        internal System.Windows.Forms.TextBox txtInHWStopSuffix;
        internal System.Windows.Forms.Label lblInpFaultDev;
        internal System.Windows.Forms.Label lblInpFaultDevSuffix;
        internal System.Windows.Forms.TextBox txtInpFaultDev;
        internal System.Windows.Forms.TextBox txtInpFaultDevSuffix;
        internal System.Windows.Forms.ComboBox comboIORemarkBML;
        private System.Windows.Forms.Label lblIORemarkBML;
        private System.Windows.Forms.GroupBox grpAddInfoToDesc;
        internal System.Windows.Forms.CheckBox chkAddSectionToDesc;
        internal System.Windows.Forms.CheckBox chkAddFloorToDesc;
        internal System.Windows.Forms.CheckBox chkAddNameToDesc;
        internal System.Windows.Forms.CheckBox chkAddCabinetToDesc;
        internal System.Windows.Forms.ComboBox comboLineBML;
        private System.Windows.Forms.Label lblLineBML;
        internal System.Windows.Forms.CheckBox chkNameOnlyNumber;
        internal System.Windows.Forms.CheckBox chkAddUserSectionToDesc;
        internal System.Windows.Forms.CheckBox chkParStartingwarning;
        internal System.Windows.Forms.CheckBox chkParFilter;
        internal System.Windows.Forms.CheckBox chkParPulsing;
        internal System.Windows.Forms.Label lblParDPNode2;
        internal System.Windows.Forms.ComboBox comboDPNode2;
        internal System.Windows.Forms.Label lblInpAlarmReset;
        internal System.Windows.Forms.Label lblInpAlarmResetSuffix;
        internal System.Windows.Forms.TextBox txtInpAlarmReset;
        internal System.Windows.Forms.TextBox txtInpAlarmResetSuffix;
        internal System.Windows.Forms.Label lblOutpFinalClearingSuffix;
        internal System.Windows.Forms.TextBox txtOutpFinalClearingSuffix;
        internal System.Windows.Forms.Label lblOutpFinalClearing;
        internal System.Windows.Forms.TextBox txtOutpFinalClearing;
        internal System.Windows.Forms.Label lblParDelayFaultTime;
        internal System.Windows.Forms.TextBox txtParDelayFaultTime;
    }
}

