using System;

namespace GcproExtensionApp
{
    partial class FormBin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.palGcObject = new System.Windows.Forms.Panel();
            this.chkOnlyFree = new System.Windows.Forms.CheckBox();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.lblHighLevel = new System.Windows.Forms.Label();
            this.LblAnalogLevelRule = new System.Windows.Forms.Label();
            this.txtHighLevel = new System.Windows.Forms.TextBox();
            this.txtAnalogLevelIncRule = new System.Windows.Forms.TextBox();
            this.LblMiddleLevel = new System.Windows.Forms.Label();
            this.LblAnalogLevelIncRule = new System.Windows.Forms.Label();
            this.txtMiddleLevel = new System.Windows.Forms.TextBox();
            this.txtAnalogLevelRule = new System.Windows.Forms.TextBox();
            this.LblStartingTime = new System.Windows.Forms.Label();
            this.LblLowLevelRule = new System.Windows.Forms.Label();
            this.txtLowLevel = new System.Windows.Forms.TextBox();
            this.txtLowLevelIncRule = new System.Windows.Forms.TextBox();
            this.LblAnalogLevel = new System.Windows.Forms.Label();
            this.LblLowLevelIncRule = new System.Windows.Forms.Label();
            this.txtAnalogLevel = new System.Windows.Forms.TextBox();
            this.txtLowLevelRule = new System.Windows.Forms.TextBox();
            this.txtHighLevelRule = new System.Windows.Forms.TextBox();
            this.LblMiddleLevelRule = new System.Windows.Forms.Label();
            this.LblHighLevelIncRule = new System.Windows.Forms.Label();
            this.txtMiddleLevelIncRule = new System.Windows.Forms.TextBox();
            this.txtHighLevelIncRule = new System.Windows.Forms.TextBox();
            this.LblMiddleLevelIncRule = new System.Windows.Forms.Label();
            this.txtMiddleLevelRule = new System.Windows.Forms.TextBox();
            this.LblHighLevelRule = new System.Windows.Forms.Label();
            this.grpImportFromRemotrPLC = new System.Windows.Forms.GroupBox();
            this.txtInFillLevel = new System.Windows.Forms.TextBox();
            this.lblRemoteHighLevel = new System.Windows.Forms.Label();
            this.lblRemoteInFillLevel = new System.Windows.Forms.Label();
            this.txtRemoteHighLevel = new System.Windows.Forms.TextBox();
            this.txtRemoteLowLevel = new System.Windows.Forms.TextBox();
            this.lblRemoteMiddleLevel = new System.Windows.Forms.Label();
            this.lblRemoteLowLevel = new System.Windows.Forms.Label();
            this.txtRemoteMiddleLevel = new System.Windows.Forms.TextBox();
            this.grpGcpro = new System.Windows.Forms.GroupBox();
            this.lblValue30 = new System.Windows.Forms.Label();
            this.chkEmptyLevel = new System.Windows.Forms.CheckBox();
            this.txtValue30 = new System.Windows.Forms.TextBox();
            this.chkTestRefillLevel = new System.Windows.Forms.CheckBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.chkNoOverrideLLIfEmpty = new System.Windows.Forms.CheckBox();
            this.lblBinNo = new System.Windows.Forms.Label();
            this.txtBinNo = new System.Windows.Forms.TextBox();
            this.chkLLisBelowBin = new System.Windows.Forms.CheckBox();
            this.txtRestdischargeWeight = new System.Windows.Forms.TextBox();
            this.chkRestdischarge = new System.Windows.Forms.CheckBox();
            this.lblRestdischargeWeight = new System.Windows.Forms.Label();
            this.chkWithLL = new System.Windows.Forms.CheckBox();
            this.txtDryFillingWeight = new System.Windows.Forms.TextBox();
            this.lblDryFillingWeight = new System.Windows.Forms.Label();
            this.txtValue24 = new System.Windows.Forms.TextBox();
            this.lblVaue24 = new System.Windows.Forms.Label();
            this.chKWithSWLL = new System.Windows.Forms.CheckBox();
            this.lblEmptyingTime = new System.Windows.Forms.Label();
            this.txtOverFillingWeight = new System.Windows.Forms.TextBox();
            this.txtEmptyingTime = new System.Windows.Forms.TextBox();
            this.lblOverFillingWeight = new System.Windows.Forms.Label();
            this.LblSymbol = new System.Windows.Forms.Label();
            this.GrpDescriptionRule = new System.Windows.Forms.GroupBox();
            this.LblDescriptionRule = new System.Windows.Forms.Label();
            this.txtDescriptionIncRule = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.txtDescriptionRule = new System.Windows.Forms.TextBox();
            this.GrpSymbolRule = new System.Windows.Forms.GroupBox();
            this.LblSymbolRule = new System.Windows.Forms.Label();
            this.txtSymbolRule = new System.Windows.Forms.TextBox();
            this.txtSymbolIncRule = new System.Windows.Forms.TextBox();
            this.LblSymbolIncRule = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnNewImpExpDef = new System.Windows.Forms.Button();
            this.btnConnectChild = new System.Windows.Forms.Button();
            this.grpWincos = new System.Windows.Forms.GroupBox();
            this.chkReadInOutEmpty = new System.Windows.Forms.CheckBox();
            this.chkReadInFillLevel = new System.Windows.Forms.CheckBox();
            this.chkReadLowLevel = new System.Windows.Forms.CheckBox();
            this.lblVaue31 = new System.Windows.Forms.Label();
            this.chkReadRefillLevel = new System.Windows.Forms.CheckBox();
            this.txtValue31 = new System.Windows.Forms.TextBox();
            this.chkReadHighLevel = new System.Windows.Forms.CheckBox();
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
            this.lblIORemarkBML = new System.Windows.Forms.Label();
            this.comboStartRow = new System.Windows.Forms.ComboBox();
            this.lblStartRow = new System.Windows.Forms.Label();
            this.comboDescBML = new System.Windows.Forms.ComboBox();
            this.comboFloorBML = new System.Windows.Forms.ComboBox();
            this.comboTypeBML = new System.Windows.Forms.ComboBox();
            this.comboNameBML = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
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
            this.palGcObject.SuspendLayout();
            this.grpLevel.SuspendLayout();
            this.grpImportFromRemotrPLC.SuspendLayout();
            this.grpGcpro.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.GrpDescriptionRule.SuspendLayout();
            this.GrpSymbolRule.SuspendLayout();
            this.grpWincos.SuspendLayout();
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
            this.tabRule.Controls.Add(this.palGcObject);
            this.tabRule.Location = new System.Drawing.Point(4, 22);
            this.tabRule.Name = "tabRule";
            this.tabRule.Padding = new System.Windows.Forms.Padding(3);
            this.tabRule.Size = new System.Drawing.Size(723, 553);
            this.tabRule.TabIndex = 0;
            this.tabRule.Text = "设定规则创建";
            // 
            // palGcObject
            // 
            this.palGcObject.AutoScroll = true;
            this.palGcObject.AutoSize = true;
            this.palGcObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.palGcObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.palGcObject.Controls.Add(this.chkOnlyFree);
            this.palGcObject.Controls.Add(this.grpLevel);
            this.palGcObject.Controls.Add(this.grpImportFromRemotrPLC);
            this.palGcObject.Controls.Add(this.grpGcpro);
            this.palGcObject.Controls.Add(this.grpGeneral);
            this.palGcObject.Controls.Add(this.BtnNewImpExpDef);
            this.palGcObject.Controls.Add(this.btnConnectChild);
            this.palGcObject.Controls.Add(this.grpWincos);
            this.palGcObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palGcObject.Location = new System.Drawing.Point(3, 3);
            this.palGcObject.Name = "palGcObject";
            this.palGcObject.Size = new System.Drawing.Size(717, 547);
            this.palGcObject.TabIndex = 105;
            // 
            // chkOnlyFree
            // 
            this.chkOnlyFree.AutoSize = true;
            this.chkOnlyFree.Checked = true;
            this.chkOnlyFree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyFree.Location = new System.Drawing.Point(90, 238);
            this.chkOnlyFree.Name = "chkOnlyFree";
            this.chkOnlyFree.Size = new System.Drawing.Size(110, 17);
            this.chkOnlyFree.TabIndex = 122;
            this.chkOnlyFree.Text = "仅关联丢失连接";
            this.chkOnlyFree.UseVisualStyleBackColor = true;
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.lblHighLevel);
            this.grpLevel.Controls.Add(this.LblAnalogLevelRule);
            this.grpLevel.Controls.Add(this.txtHighLevel);
            this.grpLevel.Controls.Add(this.txtAnalogLevelIncRule);
            this.grpLevel.Controls.Add(this.LblMiddleLevel);
            this.grpLevel.Controls.Add(this.LblAnalogLevelIncRule);
            this.grpLevel.Controls.Add(this.txtMiddleLevel);
            this.grpLevel.Controls.Add(this.txtAnalogLevelRule);
            this.grpLevel.Controls.Add(this.LblStartingTime);
            this.grpLevel.Controls.Add(this.LblLowLevelRule);
            this.grpLevel.Controls.Add(this.txtLowLevel);
            this.grpLevel.Controls.Add(this.txtLowLevelIncRule);
            this.grpLevel.Controls.Add(this.LblAnalogLevel);
            this.grpLevel.Controls.Add(this.LblLowLevelIncRule);
            this.grpLevel.Controls.Add(this.txtAnalogLevel);
            this.grpLevel.Controls.Add(this.txtLowLevelRule);
            this.grpLevel.Controls.Add(this.txtHighLevelRule);
            this.grpLevel.Controls.Add(this.LblMiddleLevelRule);
            this.grpLevel.Controls.Add(this.LblHighLevelIncRule);
            this.grpLevel.Controls.Add(this.txtMiddleLevelIncRule);
            this.grpLevel.Controls.Add(this.txtHighLevelIncRule);
            this.grpLevel.Controls.Add(this.LblMiddleLevelIncRule);
            this.grpLevel.Controls.Add(this.txtMiddleLevelRule);
            this.grpLevel.Controls.Add(this.LblHighLevelRule);
            this.grpLevel.Location = new System.Drawing.Point(6, 270);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(437, 100);
            this.grpLevel.TabIndex = 121;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "Level";
            // 
            // lblHighLevel
            // 
            this.lblHighLevel.AutoSize = true;
            this.lblHighLevel.Location = new System.Drawing.Point(3, 20);
            this.lblHighLevel.Name = "lblHighLevel";
            this.lblHighLevel.Size = new System.Drawing.Size(58, 13);
            this.lblHighLevel.TabIndex = 20;
            this.lblHighLevel.Text = "High Level";
            // 
            // LblAnalogLevelRule
            // 
            this.LblAnalogLevelRule.AutoSize = true;
            this.LblAnalogLevelRule.Location = new System.Drawing.Point(183, 74);
            this.LblAnalogLevelRule.Name = "LblAnalogLevelRule";
            this.LblAnalogLevelRule.Size = new System.Drawing.Size(55, 13);
            this.LblAnalogLevelRule.TabIndex = 92;
            this.LblAnalogLevelRule.Text = "规则字段";
            // 
            // txtHighLevel
            // 
            this.txtHighLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHighLevel.Location = new System.Drawing.Point(77, 22);
            this.txtHighLevel.Name = "txtHighLevel";
            this.txtHighLevel.Size = new System.Drawing.Size(96, 13);
            this.txtHighLevel.TabIndex = 21;
            this.txtHighLevel.TextChanged += new System.EventHandler(this.txtHighLevel_TextChanged);
            this.txtHighLevel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtHighLevel_MouseDoubleClick);
            this.txtHighLevel.MouseEnter += new System.EventHandler(this.txtHighLevel_MouseEnter);
            // 
            // txtAnalogLevelIncRule
            // 
            this.txtAnalogLevelIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnalogLevelIncRule.Location = new System.Drawing.Point(371, 76);
            this.txtAnalogLevelIncRule.Name = "txtAnalogLevelIncRule";
            this.txtAnalogLevelIncRule.Size = new System.Drawing.Size(56, 13);
            this.txtAnalogLevelIncRule.TabIndex = 94;
            this.txtAnalogLevelIncRule.Text = "1";
            this.txtAnalogLevelIncRule.TextChanged += new System.EventHandler(this.txtAnalogLevelIncRule_TextChanged);
            // 
            // LblMiddleLevel
            // 
            this.LblMiddleLevel.AutoSize = true;
            this.LblMiddleLevel.Location = new System.Drawing.Point(3, 38);
            this.LblMiddleLevel.Name = "LblMiddleLevel";
            this.LblMiddleLevel.Size = new System.Drawing.Size(67, 13);
            this.LblMiddleLevel.TabIndex = 22;
            this.LblMiddleLevel.Text = "Middle Level";
            // 
            // LblAnalogLevelIncRule
            // 
            this.LblAnalogLevelIncRule.AutoSize = true;
            this.LblAnalogLevelIncRule.Location = new System.Drawing.Point(312, 74);
            this.LblAnalogLevelIncRule.Name = "LblAnalogLevelIncRule";
            this.LblAnalogLevelIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblAnalogLevelIncRule.TabIndex = 95;
            this.LblAnalogLevelIncRule.Text = "递增规则";
            // 
            // txtMiddleLevel
            // 
            this.txtMiddleLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleLevel.Location = new System.Drawing.Point(77, 40);
            this.txtMiddleLevel.Name = "txtMiddleLevel";
            this.txtMiddleLevel.Size = new System.Drawing.Size(96, 13);
            this.txtMiddleLevel.TabIndex = 23;
            this.txtMiddleLevel.TextChanged += new System.EventHandler(this.txtMiddleLevel_TextChanged);
            this.txtMiddleLevel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtMiddleLevel_MouseDoubleClick);
            this.txtMiddleLevel.MouseEnter += new System.EventHandler(this.txtMiddleLevel_MouseEnter);
            // 
            // txtAnalogLevelRule
            // 
            this.txtAnalogLevelRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnalogLevelRule.Location = new System.Drawing.Point(239, 76);
            this.txtAnalogLevelRule.Name = "txtAnalogLevelRule";
            this.txtAnalogLevelRule.Size = new System.Drawing.Size(66, 13);
            this.txtAnalogLevelRule.TabIndex = 93;
            this.txtAnalogLevelRule.TextChanged += new System.EventHandler(this.txtAnalogLevelRule_TextChanged);
            // 
            // LblStartingTime
            // 
            this.LblStartingTime.AutoSize = true;
            this.LblStartingTime.Location = new System.Drawing.Point(3, 56);
            this.LblStartingTime.Name = "LblStartingTime";
            this.LblStartingTime.Size = new System.Drawing.Size(56, 13);
            this.LblStartingTime.TabIndex = 24;
            this.LblStartingTime.Text = "Low Level";
            // 
            // LblLowLevelRule
            // 
            this.LblLowLevelRule.AutoSize = true;
            this.LblLowLevelRule.Location = new System.Drawing.Point(183, 56);
            this.LblLowLevelRule.Name = "LblLowLevelRule";
            this.LblLowLevelRule.Size = new System.Drawing.Size(55, 13);
            this.LblLowLevelRule.TabIndex = 88;
            this.LblLowLevelRule.Text = "规则字段";
            // 
            // txtLowLevel
            // 
            this.txtLowLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLowLevel.Location = new System.Drawing.Point(77, 58);
            this.txtLowLevel.Name = "txtLowLevel";
            this.txtLowLevel.Size = new System.Drawing.Size(96, 13);
            this.txtLowLevel.TabIndex = 25;
            this.txtLowLevel.TextChanged += new System.EventHandler(this.txtLowLevel_TextChanged);
            this.txtLowLevel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtLowLevel_MouseDoubleClick);
            this.txtLowLevel.MouseEnter += new System.EventHandler(this.txtLowLevel_MouseEnter);
            // 
            // txtLowLevelIncRule
            // 
            this.txtLowLevelIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLowLevelIncRule.Location = new System.Drawing.Point(371, 57);
            this.txtLowLevelIncRule.Name = "txtLowLevelIncRule";
            this.txtLowLevelIncRule.Size = new System.Drawing.Size(56, 13);
            this.txtLowLevelIncRule.TabIndex = 90;
            this.txtLowLevelIncRule.Text = "1";
            this.txtLowLevelIncRule.TextChanged += new System.EventHandler(this.txtLowLevelIncRule_TextChanged);
            // 
            // LblAnalogLevel
            // 
            this.LblAnalogLevel.AutoSize = true;
            this.LblAnalogLevel.Location = new System.Drawing.Point(3, 74);
            this.LblAnalogLevel.Name = "LblAnalogLevel";
            this.LblAnalogLevel.Size = new System.Drawing.Size(69, 13);
            this.LblAnalogLevel.TabIndex = 26;
            this.LblAnalogLevel.Text = "Analog Level";
            // 
            // LblLowLevelIncRule
            // 
            this.LblLowLevelIncRule.AutoSize = true;
            this.LblLowLevelIncRule.Location = new System.Drawing.Point(312, 56);
            this.LblLowLevelIncRule.Name = "LblLowLevelIncRule";
            this.LblLowLevelIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblLowLevelIncRule.TabIndex = 91;
            this.LblLowLevelIncRule.Text = "递增规则";
            // 
            // txtAnalogLevel
            // 
            this.txtAnalogLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnalogLevel.Location = new System.Drawing.Point(77, 76);
            this.txtAnalogLevel.Name = "txtAnalogLevel";
            this.txtAnalogLevel.Size = new System.Drawing.Size(96, 13);
            this.txtAnalogLevel.TabIndex = 27;
            this.txtAnalogLevel.TextChanged += new System.EventHandler(this.txtAnalogLevel_TextChanged);
            this.txtAnalogLevel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtAnalogLevel_MouseDoubleClick);
            this.txtAnalogLevel.MouseEnter += new System.EventHandler(this.txtAnalogLevel_MouseEnter);
            // 
            // txtLowLevelRule
            // 
            this.txtLowLevelRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLowLevelRule.Location = new System.Drawing.Point(239, 57);
            this.txtLowLevelRule.Name = "txtLowLevelRule";
            this.txtLowLevelRule.Size = new System.Drawing.Size(66, 13);
            this.txtLowLevelRule.TabIndex = 89;
            this.txtLowLevelRule.TextChanged += new System.EventHandler(this.txtLowLevelRule_TextChanged);
            // 
            // txtHighLevelRule
            // 
            this.txtHighLevelRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHighLevelRule.Location = new System.Drawing.Point(239, 21);
            this.txtHighLevelRule.Name = "txtHighLevelRule";
            this.txtHighLevelRule.Size = new System.Drawing.Size(66, 13);
            this.txtHighLevelRule.TabIndex = 75;
            this.txtHighLevelRule.TextChanged += new System.EventHandler(this.txtHighLevelRule_TextChanged);
            // 
            // LblMiddleLevelRule
            // 
            this.LblMiddleLevelRule.AutoSize = true;
            this.LblMiddleLevelRule.Location = new System.Drawing.Point(183, 39);
            this.LblMiddleLevelRule.Name = "LblMiddleLevelRule";
            this.LblMiddleLevelRule.Size = new System.Drawing.Size(55, 13);
            this.LblMiddleLevelRule.TabIndex = 84;
            this.LblMiddleLevelRule.Text = "规则字段";
            // 
            // LblHighLevelIncRule
            // 
            this.LblHighLevelIncRule.AutoSize = true;
            this.LblHighLevelIncRule.Location = new System.Drawing.Point(312, 22);
            this.LblHighLevelIncRule.Name = "LblHighLevelIncRule";
            this.LblHighLevelIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblHighLevelIncRule.TabIndex = 77;
            this.LblHighLevelIncRule.Text = "递增规则";
            // 
            // txtMiddleLevelIncRule
            // 
            this.txtMiddleLevelIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleLevelIncRule.Location = new System.Drawing.Point(371, 39);
            this.txtMiddleLevelIncRule.Name = "txtMiddleLevelIncRule";
            this.txtMiddleLevelIncRule.Size = new System.Drawing.Size(56, 13);
            this.txtMiddleLevelIncRule.TabIndex = 86;
            this.txtMiddleLevelIncRule.Text = "1";
            this.txtMiddleLevelIncRule.TextChanged += new System.EventHandler(this.txtMiddleLevelIncRule_TextChanged);
            // 
            // txtHighLevelIncRule
            // 
            this.txtHighLevelIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHighLevelIncRule.Location = new System.Drawing.Point(371, 21);
            this.txtHighLevelIncRule.Name = "txtHighLevelIncRule";
            this.txtHighLevelIncRule.Size = new System.Drawing.Size(56, 13);
            this.txtHighLevelIncRule.TabIndex = 76;
            this.txtHighLevelIncRule.Text = "1";
            this.txtHighLevelIncRule.TextChanged += new System.EventHandler(this.txtHighLevelIncRule_TextChanged);
            // 
            // LblMiddleLevelIncRule
            // 
            this.LblMiddleLevelIncRule.AutoSize = true;
            this.LblMiddleLevelIncRule.Location = new System.Drawing.Point(312, 39);
            this.LblMiddleLevelIncRule.Name = "LblMiddleLevelIncRule";
            this.LblMiddleLevelIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblMiddleLevelIncRule.TabIndex = 87;
            this.LblMiddleLevelIncRule.Text = "递增规则";
            // 
            // txtMiddleLevelRule
            // 
            this.txtMiddleLevelRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleLevelRule.Location = new System.Drawing.Point(239, 39);
            this.txtMiddleLevelRule.Name = "txtMiddleLevelRule";
            this.txtMiddleLevelRule.Size = new System.Drawing.Size(66, 13);
            this.txtMiddleLevelRule.TabIndex = 85;
            this.txtMiddleLevelRule.TextChanged += new System.EventHandler(this.txtMiddleLevelRule_TextChanged);
            // 
            // LblHighLevelRule
            // 
            this.LblHighLevelRule.AutoSize = true;
            this.LblHighLevelRule.Location = new System.Drawing.Point(183, 22);
            this.LblHighLevelRule.Name = "LblHighLevelRule";
            this.LblHighLevelRule.Size = new System.Drawing.Size(55, 13);
            this.LblHighLevelRule.TabIndex = 74;
            this.LblHighLevelRule.Text = "规则字段";
            // 
            // grpImportFromRemotrPLC
            // 
            this.grpImportFromRemotrPLC.Controls.Add(this.txtInFillLevel);
            this.grpImportFromRemotrPLC.Controls.Add(this.lblRemoteHighLevel);
            this.grpImportFromRemotrPLC.Controls.Add(this.lblRemoteInFillLevel);
            this.grpImportFromRemotrPLC.Controls.Add(this.txtRemoteHighLevel);
            this.grpImportFromRemotrPLC.Controls.Add(this.txtRemoteLowLevel);
            this.grpImportFromRemotrPLC.Controls.Add(this.lblRemoteMiddleLevel);
            this.grpImportFromRemotrPLC.Controls.Add(this.lblRemoteLowLevel);
            this.grpImportFromRemotrPLC.Controls.Add(this.txtRemoteMiddleLevel);
            this.grpImportFromRemotrPLC.Location = new System.Drawing.Point(463, 270);
            this.grpImportFromRemotrPLC.Name = "grpImportFromRemotrPLC";
            this.grpImportFromRemotrPLC.Size = new System.Drawing.Size(198, 100);
            this.grpImportFromRemotrPLC.TabIndex = 119;
            this.grpImportFromRemotrPLC.TabStop = false;
            this.grpImportFromRemotrPLC.Text = "Import From Remote PLC";
            // 
            // txtInFillLevel
            // 
            this.txtInFillLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInFillLevel.Location = new System.Drawing.Point(104, 73);
            this.txtInFillLevel.Name = "txtInFillLevel";
            this.txtInFillLevel.Size = new System.Drawing.Size(66, 13);
            this.txtInFillLevel.TabIndex = 90;
            this.txtInFillLevel.Text = "0";
            this.txtInFillLevel.TextChanged += new System.EventHandler(this.txtRemoteAnalogLevel_TextChanged);
            // 
            // lblRemoteHighLevel
            // 
            this.lblRemoteHighLevel.AutoSize = true;
            this.lblRemoteHighLevel.Location = new System.Drawing.Point(4, 20);
            this.lblRemoteHighLevel.Name = "lblRemoteHighLevel";
            this.lblRemoteHighLevel.Size = new System.Drawing.Size(58, 13);
            this.lblRemoteHighLevel.TabIndex = 83;
            this.lblRemoteHighLevel.Text = "High Level";
            // 
            // lblRemoteInFillLevel
            // 
            this.lblRemoteInFillLevel.AutoSize = true;
            this.lblRemoteInFillLevel.Location = new System.Drawing.Point(4, 74);
            this.lblRemoteInFillLevel.Name = "lblRemoteInFillLevel";
            this.lblRemoteInFillLevel.Size = new System.Drawing.Size(50, 13);
            this.lblRemoteInFillLevel.TabIndex = 89;
            this.lblRemoteInFillLevel.Text = "InFilllevel";
            // 
            // txtRemoteHighLevel
            // 
            this.txtRemoteHighLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemoteHighLevel.Location = new System.Drawing.Point(104, 22);
            this.txtRemoteHighLevel.Name = "txtRemoteHighLevel";
            this.txtRemoteHighLevel.Size = new System.Drawing.Size(66, 13);
            this.txtRemoteHighLevel.TabIndex = 84;
            this.txtRemoteHighLevel.Text = "0";
            this.txtRemoteHighLevel.TextChanged += new System.EventHandler(this.txtRemoteHighLevel_TextChanged);
            this.txtRemoteHighLevel.MouseEnter += new System.EventHandler(this.txtRemoteHighLevel_MouseEnter);
            // 
            // txtRemoteLowLevel
            // 
            this.txtRemoteLowLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemoteLowLevel.Location = new System.Drawing.Point(104, 56);
            this.txtRemoteLowLevel.Name = "txtRemoteLowLevel";
            this.txtRemoteLowLevel.Size = new System.Drawing.Size(66, 13);
            this.txtRemoteLowLevel.TabIndex = 88;
            this.txtRemoteLowLevel.Text = "0";
            this.txtRemoteLowLevel.TextChanged += new System.EventHandler(this.txtRemoteLowLevel_TextChanged);
            this.txtRemoteLowLevel.MouseEnter += new System.EventHandler(this.txtRemoteLowLevel_MouseEnter);
            // 
            // lblRemoteMiddleLevel
            // 
            this.lblRemoteMiddleLevel.AutoSize = true;
            this.lblRemoteMiddleLevel.Location = new System.Drawing.Point(4, 38);
            this.lblRemoteMiddleLevel.Name = "lblRemoteMiddleLevel";
            this.lblRemoteMiddleLevel.Size = new System.Drawing.Size(67, 13);
            this.lblRemoteMiddleLevel.TabIndex = 85;
            this.lblRemoteMiddleLevel.Text = "Middle Level";
            // 
            // lblRemoteLowLevel
            // 
            this.lblRemoteLowLevel.AutoSize = true;
            this.lblRemoteLowLevel.Location = new System.Drawing.Point(4, 56);
            this.lblRemoteLowLevel.Name = "lblRemoteLowLevel";
            this.lblRemoteLowLevel.Size = new System.Drawing.Size(56, 13);
            this.lblRemoteLowLevel.TabIndex = 87;
            this.lblRemoteLowLevel.Text = "Low Level";
            // 
            // txtRemoteMiddleLevel
            // 
            this.txtRemoteMiddleLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemoteMiddleLevel.Location = new System.Drawing.Point(104, 39);
            this.txtRemoteMiddleLevel.Name = "txtRemoteMiddleLevel";
            this.txtRemoteMiddleLevel.Size = new System.Drawing.Size(66, 13);
            this.txtRemoteMiddleLevel.TabIndex = 86;
            this.txtRemoteMiddleLevel.Text = "0";
            this.txtRemoteMiddleLevel.TextChanged += new System.EventHandler(this.txtRemoteMiddleLevel_TextChanged);
            this.txtRemoteMiddleLevel.MouseEnter += new System.EventHandler(this.txtRemoteMiddleLevel_MouseEnter);
            // 
            // grpGcpro
            // 
            this.grpGcpro.Controls.Add(this.lblValue30);
            this.grpGcpro.Controls.Add(this.chkEmptyLevel);
            this.grpGcpro.Controls.Add(this.txtValue30);
            this.grpGcpro.Controls.Add(this.chkTestRefillLevel);
            this.grpGcpro.Location = new System.Drawing.Point(6, 453);
            this.grpGcpro.Name = "grpGcpro";
            this.grpGcpro.Size = new System.Drawing.Size(437, 50);
            this.grpGcpro.TabIndex = 120;
            this.grpGcpro.TabStop = false;
            this.grpGcpro.Text = "Gcpro";
            // 
            // lblValue30
            // 
            this.lblValue30.AutoSize = true;
            this.lblValue30.Location = new System.Drawing.Point(368, 12);
            this.lblValue30.Name = "lblValue30";
            this.lblValue30.Size = new System.Drawing.Size(46, 13);
            this.lblValue30.TabIndex = 61;
            this.lblValue30.Text = "Value30";
            // 
            // chkEmptyLevel
            // 
            this.chkEmptyLevel.AutoSize = true;
            this.chkEmptyLevel.Location = new System.Drawing.Point(167, 19);
            this.chkEmptyLevel.Name = "chkEmptyLevel";
            this.chkEmptyLevel.Size = new System.Drawing.Size(165, 17);
            this.chkEmptyLevel.TabIndex = 42;
            this.chkEmptyLevel.Text = " Test Empty Level by WinCos";
            this.chkEmptyLevel.UseVisualStyleBackColor = true;
            this.chkEmptyLevel.CheckedChanged += new System.EventHandler(this.chkEmptyLevel_CheckedChanged);
            this.chkEmptyLevel.MouseEnter += new System.EventHandler(this.chkEmptyLevel_MouseEnter);
            // 
            // txtValue30
            // 
            this.txtValue30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue30.Location = new System.Drawing.Point(370, 28);
            this.txtValue30.Name = "txtValue30";
            this.txtValue30.Size = new System.Drawing.Size(47, 13);
            this.txtValue30.TabIndex = 60;
            this.txtValue30.Text = "0";
            this.txtValue30.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue30_KeyDown);
            // 
            // chkTestRefillLevel
            // 
            this.chkTestRefillLevel.AutoSize = true;
            this.chkTestRefillLevel.Location = new System.Drawing.Point(13, 19);
            this.chkTestRefillLevel.Name = "chkTestRefillLevel";
            this.chkTestRefillLevel.Size = new System.Drawing.Size(102, 17);
            this.chkTestRefillLevel.TabIndex = 41;
            this.chkTestRefillLevel.Text = "Test Refill Level";
            this.chkTestRefillLevel.UseVisualStyleBackColor = true;
            this.chkTestRefillLevel.CheckedChanged += new System.EventHandler(this.chkTestRefillLevel_CheckedChanged);
            this.chkTestRefillLevel.MouseEnter += new System.EventHandler(this.chkTestRefillLevel_MouseEnter);
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.chkNoOverrideLLIfEmpty);
            this.grpGeneral.Controls.Add(this.lblBinNo);
            this.grpGeneral.Controls.Add(this.txtBinNo);
            this.grpGeneral.Controls.Add(this.chkLLisBelowBin);
            this.grpGeneral.Controls.Add(this.txtRestdischargeWeight);
            this.grpGeneral.Controls.Add(this.chkRestdischarge);
            this.grpGeneral.Controls.Add(this.lblRestdischargeWeight);
            this.grpGeneral.Controls.Add(this.chkWithLL);
            this.grpGeneral.Controls.Add(this.txtDryFillingWeight);
            this.grpGeneral.Controls.Add(this.lblDryFillingWeight);
            this.grpGeneral.Controls.Add(this.txtValue24);
            this.grpGeneral.Controls.Add(this.lblVaue24);
            this.grpGeneral.Controls.Add(this.chKWithSWLL);
            this.grpGeneral.Controls.Add(this.lblEmptyingTime);
            this.grpGeneral.Controls.Add(this.txtOverFillingWeight);
            this.grpGeneral.Controls.Add(this.txtEmptyingTime);
            this.grpGeneral.Controls.Add(this.lblOverFillingWeight);
            this.grpGeneral.Controls.Add(this.LblSymbol);
            this.grpGeneral.Controls.Add(this.GrpDescriptionRule);
            this.grpGeneral.Controls.Add(this.GrpSymbolRule);
            this.grpGeneral.Controls.Add(this.txtDescription);
            this.grpGeneral.Controls.Add(this.txtSymbol);
            this.grpGeneral.Controls.Add(this.LblDescription);
            this.grpGeneral.Location = new System.Drawing.Point(6, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(703, 221);
            this.grpGeneral.TabIndex = 118;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "常规";
            // 
            // chkNoOverrideLLIfEmpty
            // 
            this.chkNoOverrideLLIfEmpty.AutoSize = true;
            this.chkNoOverrideLLIfEmpty.Location = new System.Drawing.Point(330, 185);
            this.chkNoOverrideLLIfEmpty.Name = "chkNoOverrideLLIfEmpty";
            this.chkNoOverrideLLIfEmpty.Size = new System.Drawing.Size(143, 17);
            this.chkNoOverrideLLIfEmpty.TabIndex = 102;
            this.chkNoOverrideLLIfEmpty.Text = "ParNoOverrideLLIfEmpty";
            this.chkNoOverrideLLIfEmpty.UseVisualStyleBackColor = true;
            this.chkNoOverrideLLIfEmpty.CheckedChanged += new System.EventHandler(this.chkNoOverrideLLIfEmpty_CheckedChanged);
            this.chkNoOverrideLLIfEmpty.MouseEnter += new System.EventHandler(this.chkNoOverrideLLIfEmpty_MouseEnter);
            // 
            // lblBinNo
            // 
            this.lblBinNo.AutoSize = true;
            this.lblBinNo.Location = new System.Drawing.Point(5, 111);
            this.lblBinNo.Name = "lblBinNo";
            this.lblBinNo.Size = new System.Drawing.Size(52, 13);
            this.lblBinNo.TabIndex = 84;
            this.lblBinNo.Text = "ParBinNo";
            // 
            // txtBinNo
            // 
            this.txtBinNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBinNo.Location = new System.Drawing.Point(157, 111);
            this.txtBinNo.Name = "txtBinNo";
            this.txtBinNo.Size = new System.Drawing.Size(66, 13);
            this.txtBinNo.TabIndex = 85;
            this.txtBinNo.TextChanged += new System.EventHandler(this.txtBinNo_TextChanged);
            this.txtBinNo.MouseEnter += new System.EventHandler(this.txtBinNo_MouseEnter);
            // 
            // chkLLisBelowBin
            // 
            this.chkLLisBelowBin.AutoSize = true;
            this.chkLLisBelowBin.Location = new System.Drawing.Point(330, 109);
            this.chkLLisBelowBin.Name = "chkLLisBelowBin";
            this.chkLLisBelowBin.Size = new System.Drawing.Size(112, 17);
            this.chkLLisBelowBin.TabIndex = 86;
            this.chkLLisBelowBin.Text = "ParLL_IsBelowBin";
            this.chkLLisBelowBin.UseVisualStyleBackColor = true;
            this.chkLLisBelowBin.CheckedChanged += new System.EventHandler(this.chkLLisBelowBin_CheckedChanged);
            this.chkLLisBelowBin.MouseEnter += new System.EventHandler(this.chkLLisBelowBin_CheckedChanged);
            // 
            // txtRestdischargeWeight
            // 
            this.txtRestdischargeWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRestdischargeWeight.Location = new System.Drawing.Point(157, 185);
            this.txtRestdischargeWeight.Name = "txtRestdischargeWeight";
            this.txtRestdischargeWeight.Size = new System.Drawing.Size(66, 13);
            this.txtRestdischargeWeight.TabIndex = 101;
            this.txtRestdischargeWeight.Text = "0";
            this.txtRestdischargeWeight.TextChanged += new System.EventHandler(this.txtRestdischargeWeight_TextChanged);
            this.txtRestdischargeWeight.MouseEnter += new System.EventHandler(this.txtRestdischargeWeight_MouseEnter);
            // 
            // chkRestdischarge
            // 
            this.chkRestdischarge.AutoSize = true;
            this.chkRestdischarge.Location = new System.Drawing.Point(330, 128);
            this.chkRestdischarge.Name = "chkRestdischarge";
            this.chkRestdischarge.Size = new System.Drawing.Size(110, 17);
            this.chkRestdischarge.TabIndex = 87;
            this.chkRestdischarge.Text = "ParRestdischarge";
            this.chkRestdischarge.UseVisualStyleBackColor = true;
            this.chkRestdischarge.CheckedChanged += new System.EventHandler(this.chkRestdischarge_CheckedChanged);
            // 
            // lblRestdischargeWeight
            // 
            this.lblRestdischargeWeight.AutoSize = true;
            this.lblRestdischargeWeight.Location = new System.Drawing.Point(5, 185);
            this.lblRestdischargeWeight.Name = "lblRestdischargeWeight";
            this.lblRestdischargeWeight.Size = new System.Drawing.Size(143, 13);
            this.lblRestdischargeWeight.TabIndex = 100;
            this.lblRestdischargeWeight.Text = "ParRestdischargeWeight[kg]";
            // 
            // chkWithLL
            // 
            this.chkWithLL.AutoSize = true;
            this.chkWithLL.Location = new System.Drawing.Point(330, 146);
            this.chkWithLL.Name = "chkWithLL";
            this.chkWithLL.Size = new System.Drawing.Size(76, 17);
            this.chkWithLL.TabIndex = 88;
            this.chkWithLL.Text = "ParWithLL";
            this.chkWithLL.UseVisualStyleBackColor = true;
            this.chkWithLL.CheckedChanged += new System.EventHandler(this.chkWithLL_CheckedChanged);
            this.chkWithLL.MouseEnter += new System.EventHandler(this.chkWithLL_MouseEnter);
            // 
            // txtDryFillingWeight
            // 
            this.txtDryFillingWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDryFillingWeight.Location = new System.Drawing.Point(157, 166);
            this.txtDryFillingWeight.Name = "txtDryFillingWeight";
            this.txtDryFillingWeight.Size = new System.Drawing.Size(66, 13);
            this.txtDryFillingWeight.TabIndex = 99;
            this.txtDryFillingWeight.Text = "0";
            this.txtDryFillingWeight.TextChanged += new System.EventHandler(this.txtDryFillingWeight_TextChanged);
            this.txtDryFillingWeight.MouseEnter += new System.EventHandler(this.txtDryFillingWeight_MouseEnter);
            // 
            // lblDryFillingWeight
            // 
            this.lblDryFillingWeight.AutoSize = true;
            this.lblDryFillingWeight.Location = new System.Drawing.Point(5, 166);
            this.lblDryFillingWeight.Name = "lblDryFillingWeight";
            this.lblDryFillingWeight.Size = new System.Drawing.Size(117, 13);
            this.lblDryFillingWeight.TabIndex = 98;
            this.lblDryFillingWeight.Text = "ParDryFillingWeight[kg]";
            // 
            // txtValue24
            // 
            this.txtValue24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue24.Location = new System.Drawing.Point(453, 130);
            this.txtValue24.Name = "txtValue24";
            this.txtValue24.Size = new System.Drawing.Size(36, 13);
            this.txtValue24.TabIndex = 90;
            this.txtValue24.Text = "0";
            this.txtValue24.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue24_KeyDown);
            // 
            // lblVaue24
            // 
            this.lblVaue24.AutoSize = true;
            this.lblVaue24.Location = new System.Drawing.Point(449, 110);
            this.lblVaue24.Name = "lblVaue24";
            this.lblVaue24.Size = new System.Drawing.Size(46, 13);
            this.lblVaue24.TabIndex = 91;
            this.lblVaue24.Text = "Value24";
            // 
            // chKWithSWLL
            // 
            this.chKWithSWLL.AutoSize = true;
            this.chKWithSWLL.Location = new System.Drawing.Point(330, 165);
            this.chKWithSWLL.Name = "chKWithSWLL";
            this.chKWithSWLL.Size = new System.Drawing.Size(94, 17);
            this.chKWithSWLL.TabIndex = 96;
            this.chKWithSWLL.Text = "ParWithSWLL";
            this.chKWithSWLL.UseVisualStyleBackColor = true;
            this.chKWithSWLL.CheckedChanged += new System.EventHandler(this.chKWithSWLL_CheckedChanged);
            this.chKWithSWLL.MouseEnter += new System.EventHandler(this.chKWithSWLL_MouseEnter);
            // 
            // lblEmptyingTime
            // 
            this.lblEmptyingTime.AutoSize = true;
            this.lblEmptyingTime.Location = new System.Drawing.Point(5, 130);
            this.lblEmptyingTime.Name = "lblEmptyingTime";
            this.lblEmptyingTime.Size = new System.Drawing.Size(89, 13);
            this.lblEmptyingTime.TabIndex = 92;
            this.lblEmptyingTime.Text = "ParEmptyingTime";
            // 
            // txtOverFillingWeight
            // 
            this.txtOverFillingWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOverFillingWeight.Location = new System.Drawing.Point(157, 148);
            this.txtOverFillingWeight.Name = "txtOverFillingWeight";
            this.txtOverFillingWeight.Size = new System.Drawing.Size(66, 13);
            this.txtOverFillingWeight.TabIndex = 95;
            this.txtOverFillingWeight.Text = "100";
            this.txtOverFillingWeight.TextChanged += new System.EventHandler(this.txtOverFillingWeight_TextChanged);
            this.txtOverFillingWeight.MouseEnter += new System.EventHandler(this.txtOverFillingWeight_MouseEnter);
            // 
            // txtEmptyingTime
            // 
            this.txtEmptyingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmptyingTime.Location = new System.Drawing.Point(157, 130);
            this.txtEmptyingTime.Name = "txtEmptyingTime";
            this.txtEmptyingTime.Size = new System.Drawing.Size(66, 13);
            this.txtEmptyingTime.TabIndex = 93;
            this.txtEmptyingTime.Text = "0";
            this.txtEmptyingTime.TextChanged += new System.EventHandler(this.txtEmptyingTime_TextChanged);
            this.txtEmptyingTime.MouseEnter += new System.EventHandler(this.txtEmptyingTime_MouseEnter);
            // 
            // lblOverFillingWeight
            // 
            this.lblOverFillingWeight.AutoSize = true;
            this.lblOverFillingWeight.Location = new System.Drawing.Point(5, 149);
            this.lblOverFillingWeight.Name = "lblOverFillingWeight";
            this.lblOverFillingWeight.Size = new System.Drawing.Size(124, 13);
            this.lblOverFillingWeight.TabIndex = 94;
            this.lblOverFillingWeight.Text = "ParOverFillingWeight[kg]";
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
            this.txtDescriptionIncRule.Text = "1";
            this.txtDescriptionIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescriptionIncRule_KeyDown);
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
            this.txtDescriptionRule.TextChanged += new System.EventHandler(this.txtDescriptionRule_TextChanged);
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
            this.txtSymbolRule.TextChanged += new System.EventHandler(this.txtSymbolRule_TextChanged);
            // 
            // txtSymbolIncRule
            // 
            this.txtSymbolIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbolIncRule.Location = new System.Drawing.Point(6, 67);
            this.txtSymbolIncRule.Name = "txtSymbolIncRule";
            this.txtSymbolIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtSymbolIncRule.TabIndex = 71;
            this.txtSymbolIncRule.Text = "1";
            this.txtSymbolIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSymbolIncRule_KeyDown);
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
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(245, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(346, 13);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.MouseEnter += new System.EventHandler(this.txtDescription_MouseEnter);
            // 
            // txtSymbol
            // 
            this.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbol.Location = new System.Drawing.Point(8, 32);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(137, 13);
            this.txtSymbol.TabIndex = 2;
            this.txtSymbol.TextChanged += new System.EventHandler(this.txtSymbol_TextChanged);
            this.txtSymbol.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSymbol_MouseDoubleClick);
            this.txtSymbol.MouseEnter += new System.EventHandler(this.txtSymbol_MouseEnter);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(242, 16);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(43, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "仓描述";
            // 
            // BtnNewImpExpDef
            // 
            this.BtnNewImpExpDef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewImpExpDef.BackgroundImage")));
            this.BtnNewImpExpDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewImpExpDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewImpExpDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewImpExpDef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewImpExpDef.Location = new System.Drawing.Point(6, 230);
            this.BtnNewImpExpDef.Name = "BtnNewImpExpDef";
            this.BtnNewImpExpDef.Size = new System.Drawing.Size(36, 30);
            this.BtnNewImpExpDef.TabIndex = 76;
            this.BtnNewImpExpDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewImpExpDef.UseVisualStyleBackColor = true;
            this.BtnNewImpExpDef.Click += new System.EventHandler(this.BtnNewImpExpDef_Click);
            // 
            // btnConnectChild
            // 
            this.btnConnectChild.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnectChild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnectChild.BackgroundImage")));
            this.btnConnectChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnectChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectChild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectChild.Location = new System.Drawing.Point(48, 230);
            this.btnConnectChild.Name = "btnConnectChild";
            this.btnConnectChild.Size = new System.Drawing.Size(36, 30);
            this.btnConnectChild.TabIndex = 98;
            this.btnConnectChild.UseVisualStyleBackColor = false;
            this.btnConnectChild.Click += new System.EventHandler(this.btnConnectChild_Click);
            // 
            // grpWincos
            // 
            this.grpWincos.Controls.Add(this.chkReadInOutEmpty);
            this.grpWincos.Controls.Add(this.chkReadInFillLevel);
            this.grpWincos.Controls.Add(this.chkReadLowLevel);
            this.grpWincos.Controls.Add(this.lblVaue31);
            this.grpWincos.Controls.Add(this.chkReadRefillLevel);
            this.grpWincos.Controls.Add(this.txtValue31);
            this.grpWincos.Controls.Add(this.chkReadHighLevel);
            this.grpWincos.Location = new System.Drawing.Point(463, 387);
            this.grpWincos.Name = "grpWincos";
            this.grpWincos.Size = new System.Drawing.Size(198, 116);
            this.grpWincos.TabIndex = 89;
            this.grpWincos.TabStop = false;
            this.grpWincos.Text = "Wincos.r2";
            // 
            // chkReadInOutEmpty
            // 
            this.chkReadInOutEmpty.AutoSize = true;
            this.chkReadInOutEmpty.Location = new System.Drawing.Point(6, 89);
            this.chkReadInOutEmpty.Name = "chkReadInOutEmpty";
            this.chkReadInOutEmpty.Size = new System.Drawing.Size(110, 17);
            this.chkReadInOutEmpty.TabIndex = 64;
            this.chkReadInOutEmpty.Text = "Read InOutEmpty";
            this.chkReadInOutEmpty.UseVisualStyleBackColor = true;
            this.chkReadInOutEmpty.CheckedChanged += new System.EventHandler(this.chkReadInOutEmpty_CheckedChanged);
            this.chkReadInOutEmpty.MouseEnter += new System.EventHandler(this.chkReadInOutEmpty_MouseEnter);
            // 
            // chkReadInFillLevel
            // 
            this.chkReadInFillLevel.AutoSize = true;
            this.chkReadInFillLevel.Location = new System.Drawing.Point(6, 70);
            this.chkReadInFillLevel.Name = "chkReadInFillLevel";
            this.chkReadInFillLevel.Size = new System.Drawing.Size(102, 17);
            this.chkReadInFillLevel.TabIndex = 63;
            this.chkReadInFillLevel.Text = "Read InFillLevel";
            this.chkReadInFillLevel.UseVisualStyleBackColor = true;
            this.chkReadInFillLevel.CheckedChanged += new System.EventHandler(this.chkReadInFillLevel_CheckedChanged);
            this.chkReadInFillLevel.MouseEnter += new System.EventHandler(this.chkReadInFillLevel_MouseEnter);
            // 
            // chkReadLowLevel
            // 
            this.chkReadLowLevel.AutoSize = true;
            this.chkReadLowLevel.Location = new System.Drawing.Point(6, 52);
            this.chkReadLowLevel.Name = "chkReadLowLevel";
            this.chkReadLowLevel.Size = new System.Drawing.Size(110, 17);
            this.chkReadLowLevel.TabIndex = 62;
            this.chkReadLowLevel.Text = "Read InLowLevel";
            this.chkReadLowLevel.UseVisualStyleBackColor = true;
            this.chkReadLowLevel.CheckedChanged += new System.EventHandler(this.chkReadLowLevel_CheckedChanged);
            this.chkReadLowLevel.MouseEnter += new System.EventHandler(this.chkReadLowLevel_MouseEnter);
            // 
            // lblVaue31
            // 
            this.lblVaue31.AutoSize = true;
            this.lblVaue31.Location = new System.Drawing.Point(132, 15);
            this.lblVaue31.Name = "lblVaue31";
            this.lblVaue31.Size = new System.Drawing.Size(46, 13);
            this.lblVaue31.TabIndex = 61;
            this.lblVaue31.Text = "Value31";
            // 
            // chkReadRefillLevel
            // 
            this.chkReadRefillLevel.AutoSize = true;
            this.chkReadRefillLevel.Location = new System.Drawing.Point(6, 34);
            this.chkReadRefillLevel.Name = "chkReadRefillLevel";
            this.chkReadRefillLevel.Size = new System.Drawing.Size(113, 17);
            this.chkReadRefillLevel.TabIndex = 42;
            this.chkReadRefillLevel.Text = "Read InRefillLevel";
            this.chkReadRefillLevel.UseVisualStyleBackColor = true;
            this.chkReadRefillLevel.CheckedChanged += new System.EventHandler(this.chkReadRefillLevel_CheckedChanged);
            this.chkReadRefillLevel.MouseEnter += new System.EventHandler(this.chkReadRefillLevel_MouseEnter);
            // 
            // txtValue31
            // 
            this.txtValue31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue31.Location = new System.Drawing.Point(134, 33);
            this.txtValue31.Name = "txtValue31";
            this.txtValue31.Size = new System.Drawing.Size(36, 13);
            this.txtValue31.TabIndex = 60;
            this.txtValue31.Text = "0";
            this.txtValue31.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue31_KeyDown);
            // 
            // chkReadHighLevel
            // 
            this.chkReadHighLevel.AutoSize = true;
            this.chkReadHighLevel.Location = new System.Drawing.Point(6, 15);
            this.chkReadHighLevel.Name = "chkReadHighLevel";
            this.chkReadHighLevel.Size = new System.Drawing.Size(112, 17);
            this.chkReadHighLevel.TabIndex = 41;
            this.chkReadHighLevel.Text = "Read InHighLevel";
            this.chkReadHighLevel.UseVisualStyleBackColor = true;
            this.chkReadHighLevel.CheckedChanged += new System.EventHandler(this.chkReadHighLevel_CheckedChanged);
            this.chkReadHighLevel.MouseEnter += new System.EventHandler(this.chkReadHighLevel_MouseEnter);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridBML.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBML.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBML.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.Location = new System.Drawing.Point(6, 51);
            this.dataGridBML.Name = "dataGridBML";
            this.dataGridBML.Size = new System.Drawing.Size(701, 372);
            this.dataGridBML.TabIndex = 16;
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
            this.grpBoxBMLColum.Controls.Add(this.lblIORemarkBML);
            this.grpBoxBMLColum.Controls.Add(this.comboStartRow);
            this.grpBoxBMLColum.Controls.Add(this.lblStartRow);
            this.grpBoxBMLColum.Controls.Add(this.comboDescBML);
            this.grpBoxBMLColum.Controls.Add(this.comboFloorBML);
            this.grpBoxBMLColum.Controls.Add(this.comboTypeBML);
            this.grpBoxBMLColum.Controls.Add(this.comboNameBML);
            this.grpBoxBMLColum.Controls.Add(this.lblFloor);
            this.grpBoxBMLColum.Controls.Add(this.lblType);
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
            this.comboLineBML.Location = new System.Drawing.Point(466, 17);
            this.comboLineBML.Name = "comboLineBML";
            this.comboLineBML.Size = new System.Drawing.Size(66, 21);
            this.comboLineBML.TabIndex = 33;
            // 
            // lblLineBML
            // 
            this.lblLineBML.AutoSize = true;
            this.lblLineBML.Location = new System.Drawing.Point(420, 20);
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
            // lblIORemarkBML
            // 
            this.lblIORemarkBML.AutoSize = true;
            this.lblIORemarkBML.Location = new System.Drawing.Point(146, 49);
            this.lblIORemarkBML.Name = "lblIORemarkBML";
            this.lblIORemarkBML.Size = new System.Drawing.Size(54, 13);
            this.lblIORemarkBML.TabIndex = 30;
            this.lblIORemarkBML.Text = "IO注释：";
            // 
            // comboStartRow
            // 
            this.comboStartRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStartRow.FormattingEnabled = true;
            this.comboStartRow.IntegralHeight = false;
            this.comboStartRow.Location = new System.Drawing.Point(467, 44);
            this.comboStartRow.Name = "comboStartRow";
            this.comboStartRow.Size = new System.Drawing.Size(66, 21);
            this.comboStartRow.TabIndex = 28;
            // 
            // lblStartRow
            // 
            this.lblStartRow.AutoSize = true;
            this.lblStartRow.Location = new System.Drawing.Point(426, 47);
            this.lblStartRow.Name = "lblStartRow";
            this.lblStartRow.Size = new System.Drawing.Size(43, 13);
            this.lblStartRow.TabIndex = 28;
            this.lblStartRow.Text = "起始行";
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
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(157, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "类型：";
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
            // FormBin
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
            this.Name = "FormBin";
            this.Text = "UL_Bin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBin_FormClosed);
            this.Load += new System.EventHandler(this.FormBin_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCreateMode.ResumeLayout(false);
            this.contextMenuStripBML.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.tabRule.PerformLayout();
            this.palGcObject.ResumeLayout(false);
            this.palGcObject.PerformLayout();
            this.grpLevel.ResumeLayout(false);
            this.grpLevel.PerformLayout();
            this.grpImportFromRemotrPLC.ResumeLayout(false);
            this.grpImportFromRemotrPLC.PerformLayout();
            this.grpGcpro.ResumeLayout(false);
            this.grpGcpro.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.GrpDescriptionRule.ResumeLayout(false);
            this.GrpDescriptionRule.PerformLayout();
            this.GrpSymbolRule.ResumeLayout(false);
            this.GrpSymbolRule.PerformLayout();
            this.grpWincos.ResumeLayout(false);
            this.grpWincos.PerformLayout();
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
        internal System.Windows.Forms.Panel palGcObject;
        internal System.Windows.Forms.Button BtnNewImpExpDef;
        internal System.Windows.Forms.Button btnConnectChild;
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
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.GroupBox grpBoxExcelData;
        private System.Windows.Forms.DataGridView dataGridBML;
        internal System.Windows.Forms.Button btnReadBML;
        internal System.Windows.Forms.ComboBox comboDescBML;
        internal System.Windows.Forms.ComboBox comboFloorBML;
        internal System.Windows.Forms.ComboBox comboTypeBML;
        internal System.Windows.Forms.ComboBox comboNameBML;
        internal System.Windows.Forms.ComboBox comboStartRow;
        private System.Windows.Forms.Label lblStartRow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClearList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        internal System.Windows.Forms.ComboBox comboIORemarkBML;
        private System.Windows.Forms.Label lblIORemarkBML;
        internal System.Windows.Forms.ComboBox comboLineBML;
        private System.Windows.Forms.Label lblLineBML;
        private System.Windows.Forms.GroupBox grpGeneral;
        internal System.Windows.Forms.Label LblSymbol;
        internal System.Windows.Forms.GroupBox GrpDescriptionRule;
        internal System.Windows.Forms.Label LblDescriptionRule;
        internal System.Windows.Forms.TextBox txtDescriptionIncRule;
        internal System.Windows.Forms.Label Lbl;
        internal System.Windows.Forms.TextBox txtDescriptionRule;
        internal System.Windows.Forms.GroupBox GrpSymbolRule;
        internal System.Windows.Forms.Label LblSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolIncRule;
        internal System.Windows.Forms.Label LblSymbolIncRule;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtSymbol;
        internal System.Windows.Forms.Label LblDescription;
        internal System.Windows.Forms.GroupBox grpLevel;
        internal System.Windows.Forms.Label lblHighLevel;
        internal System.Windows.Forms.Label LblAnalogLevelRule;
        internal System.Windows.Forms.TextBox txtHighLevel;
        internal System.Windows.Forms.TextBox txtAnalogLevelIncRule;
        internal System.Windows.Forms.Label LblMiddleLevel;
        internal System.Windows.Forms.Label LblAnalogLevelIncRule;
        internal System.Windows.Forms.TextBox txtMiddleLevel;
        internal System.Windows.Forms.TextBox txtAnalogLevelRule;
        internal System.Windows.Forms.Label LblStartingTime;
        internal System.Windows.Forms.Label LblLowLevelRule;
        internal System.Windows.Forms.TextBox txtLowLevel;
        internal System.Windows.Forms.TextBox txtLowLevelIncRule;
        internal System.Windows.Forms.Label LblAnalogLevel;
        internal System.Windows.Forms.Label LblLowLevelIncRule;
        internal System.Windows.Forms.TextBox txtAnalogLevel;
        internal System.Windows.Forms.TextBox txtLowLevelRule;
        internal System.Windows.Forms.TextBox txtHighLevelRule;
        internal System.Windows.Forms.Label LblMiddleLevelRule;
        internal System.Windows.Forms.Label LblHighLevelIncRule;
        internal System.Windows.Forms.TextBox txtMiddleLevelIncRule;
        internal System.Windows.Forms.TextBox txtHighLevelIncRule;
        internal System.Windows.Forms.Label LblMiddleLevelIncRule;
        internal System.Windows.Forms.TextBox txtMiddleLevelRule;
        internal System.Windows.Forms.Label LblHighLevelRule;
        internal System.Windows.Forms.GroupBox grpImportFromRemotrPLC;
        internal System.Windows.Forms.TextBox txtInFillLevel;
        internal System.Windows.Forms.Label lblRemoteHighLevel;
        internal System.Windows.Forms.Label lblRemoteInFillLevel;
        internal System.Windows.Forms.TextBox txtRemoteHighLevel;
        internal System.Windows.Forms.TextBox txtRemoteLowLevel;
        internal System.Windows.Forms.Label lblRemoteMiddleLevel;
        internal System.Windows.Forms.Label lblRemoteLowLevel;
        internal System.Windows.Forms.TextBox txtRemoteMiddleLevel;
        internal System.Windows.Forms.GroupBox grpGcpro;
        internal System.Windows.Forms.Label lblValue30;
        internal System.Windows.Forms.CheckBox chkEmptyLevel;
        internal System.Windows.Forms.TextBox txtValue30;
        internal System.Windows.Forms.CheckBox chkTestRefillLevel;
        internal System.Windows.Forms.CheckBox chkNoOverrideLLIfEmpty;
        internal System.Windows.Forms.Label lblBinNo;
        internal System.Windows.Forms.TextBox txtBinNo;
        internal System.Windows.Forms.CheckBox chkLLisBelowBin;
        internal System.Windows.Forms.TextBox txtRestdischargeWeight;
        internal System.Windows.Forms.CheckBox chkRestdischarge;
        internal System.Windows.Forms.Label lblRestdischargeWeight;
        internal System.Windows.Forms.CheckBox chkWithLL;
        internal System.Windows.Forms.TextBox txtDryFillingWeight;
        internal System.Windows.Forms.GroupBox grpWincos;
        internal System.Windows.Forms.CheckBox chkReadInOutEmpty;
        internal System.Windows.Forms.CheckBox chkReadInFillLevel;
        internal System.Windows.Forms.CheckBox chkReadLowLevel;
        internal System.Windows.Forms.Label lblVaue31;
        internal System.Windows.Forms.CheckBox chkReadRefillLevel;
        internal System.Windows.Forms.TextBox txtValue31;
        internal System.Windows.Forms.CheckBox chkReadHighLevel;
        internal System.Windows.Forms.Label lblDryFillingWeight;
        internal System.Windows.Forms.TextBox txtValue24;
        internal System.Windows.Forms.Label lblVaue24;
        internal System.Windows.Forms.CheckBox chKWithSWLL;
        internal System.Windows.Forms.Label lblEmptyingTime;
        internal System.Windows.Forms.TextBox txtOverFillingWeight;
        internal System.Windows.Forms.TextBox txtEmptyingTime;
        internal System.Windows.Forms.Label lblOverFillingWeight;
        internal System.Windows.Forms.CheckBox chkOnlyFree;
        private System.Windows.Forms.TabPage tabBML;
    }
}

