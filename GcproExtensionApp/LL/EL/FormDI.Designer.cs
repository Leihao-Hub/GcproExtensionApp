using System;

namespace GcproExtensionApp
{
    partial class FormDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDI));
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
            this.PalGcObject = new System.Windows.Forms.Panel();
            this.chkParBinLevel = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtValue10 = new System.Windows.Forms.TextBox();
            this.LblDelayChange = new System.Windows.Forms.Label();
            this.txtDelayChange = new System.Windows.Forms.TextBox();
            this.LblDelayTrue = new System.Windows.Forms.Label();
            this.txtDelayTrue = new System.Windows.Forms.TextBox();
            this.LblDelayFalse = new System.Windows.Forms.Label();
            this.txtDelayFalse = new System.Windows.Forms.TextBox();
            this.LblTimeoutTrue = new System.Windows.Forms.Label();
            this.txtTimeoutTrue = new System.Windows.Forms.TextBox();
            this.LblTimeoutFalse = new System.Windows.Forms.Label();
            this.txtTimeoutFalse = new System.Windows.Forms.TextBox();
            this.chkParLogOff = new System.Windows.Forms.CheckBox();
            this.chkParPulsing = new System.Windows.Forms.CheckBox();
            this.GroupBoxGroupTree = new System.Windows.Forms.GroupBox();
            this.chKInpFaultDev = new System.Windows.Forms.CheckBox();
            this.chkInPreAlarm = new System.Windows.Forms.CheckBox();
            this.chkMonUnCovered = new System.Windows.Forms.CheckBox();
            this.chkMonFalse = new System.Windows.Forms.CheckBox();
            this.chkMonCovered = new System.Windows.Forms.CheckBox();
            this.chkMonTrue = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.chkInvertInput = new System.Windows.Forms.CheckBox();
            this.txtValue9 = new System.Windows.Forms.TextBox();
            this.chkInterlockNextObject = new System.Windows.Forms.CheckBox();
            this.chkParFaultRetry = new System.Windows.Forms.CheckBox();
            this.chkOnlyFree = new System.Windows.Forms.CheckBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
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
            this.txtInpTrue = new System.Windows.Forms.TextBox();
            this.GrpSymbolRule = new System.Windows.Forms.GroupBox();
            this.LblSymbolRule = new System.Windows.Forms.Label();
            this.txtSymbolRule = new System.Windows.Forms.TextBox();
            this.txtSymbolIncRule = new System.Windows.Forms.TextBox();
            this.LblSymbolIncRule = new System.Windows.Forms.Label();
            this.lblOutpRevSuffix = new System.Windows.Forms.Label();
            this.txtOutpPowerOffSuffix = new System.Windows.Forms.TextBox();
            this.LblInpTrue = new System.Windows.Forms.Label();
            this.txtOutpFaultResetSuffix = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblOutpFaultResetSuffix = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.txtInpTrueSuffix = new System.Windows.Forms.TextBox();
            this.txtOutpFaultReset = new System.Windows.Forms.TextBox();
            this.lblInpTrueSuffix = new System.Windows.Forms.Label();
            this.LblOutpFaultReset = new System.Windows.Forms.Label();
            this.LblOutRunRev = new System.Windows.Forms.Label();
            this.txtOutpPowerOff = new System.Windows.Forms.TextBox();
            this.BtnRegenerateDPNode = new System.Windows.Forms.Button();
            this.BtnNewImpExpDef = new System.Windows.Forms.Button();
            this.LblEquipmentInfoType = new System.Windows.Forms.Label();
            this.ComboEquipmentInfoType = new System.Windows.Forms.ComboBox();
            this.LblHornCode = new System.Windows.Forms.Label();
            this.ComboHornCode = new System.Windows.Forms.ComboBox();
            this.LblDPNode1 = new System.Windows.Forms.Label();
            this.BtnConnectIO = new System.Windows.Forms.Button();
            this.ComboDPNode1 = new System.Windows.Forms.ComboBox();
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
            this.GroupBoxGroupTree.SuspendLayout();
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
            this.PalGcObject.Controls.Add(this.chkParBinLevel);
            this.PalGcObject.Controls.Add(this.Label1);
            this.PalGcObject.Controls.Add(this.txtValue10);
            this.PalGcObject.Controls.Add(this.LblDelayChange);
            this.PalGcObject.Controls.Add(this.txtDelayChange);
            this.PalGcObject.Controls.Add(this.LblDelayTrue);
            this.PalGcObject.Controls.Add(this.txtDelayTrue);
            this.PalGcObject.Controls.Add(this.LblDelayFalse);
            this.PalGcObject.Controls.Add(this.txtDelayFalse);
            this.PalGcObject.Controls.Add(this.LblTimeoutTrue);
            this.PalGcObject.Controls.Add(this.txtTimeoutTrue);
            this.PalGcObject.Controls.Add(this.LblTimeoutFalse);
            this.PalGcObject.Controls.Add(this.txtTimeoutFalse);
            this.PalGcObject.Controls.Add(this.chkParLogOff);
            this.PalGcObject.Controls.Add(this.chkParPulsing);
            this.PalGcObject.Controls.Add(this.GroupBoxGroupTree);
            this.PalGcObject.Controls.Add(this.chkParFaultRetry);
            this.PalGcObject.Controls.Add(this.chkOnlyFree);
            this.PalGcObject.Controls.Add(this.grpGeneral);
            this.PalGcObject.Controls.Add(this.BtnRegenerateDPNode);
            this.PalGcObject.Controls.Add(this.BtnNewImpExpDef);
            this.PalGcObject.Controls.Add(this.LblEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.ComboEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.LblHornCode);
            this.PalGcObject.Controls.Add(this.ComboHornCode);
            this.PalGcObject.Controls.Add(this.LblDPNode1);
            this.PalGcObject.Controls.Add(this.BtnConnectIO);
            this.PalGcObject.Controls.Add(this.ComboDPNode1);
            this.PalGcObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalGcObject.Location = new System.Drawing.Point(3, 3);
            this.PalGcObject.Name = "PalGcObject";
            this.PalGcObject.Size = new System.Drawing.Size(717, 547);
            this.PalGcObject.TabIndex = 105;
            // 
            // chkParBinLevel
            // 
            this.chkParBinLevel.AutoSize = true;
            this.chkParBinLevel.Location = new System.Drawing.Point(330, 385);
            this.chkParBinLevel.Name = "chkParBinLevel";
            this.chkParBinLevel.Size = new System.Drawing.Size(83, 17);
            this.chkParBinLevel.TabIndex = 135;
            this.chkParBinLevel.Text = "ParBinLevel";
            this.chkParBinLevel.UseVisualStyleBackColor = true;
            this.chkParBinLevel.CheckedChanged += new System.EventHandler(this.chkParBinLevel_CheckedChanged);
            this.chkParBinLevel.MouseEnter += new System.EventHandler(this.chkParBinLevel_MouseEnter);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(405, 332);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 134;
            this.Label1.Text = "Value10";
            // 
            // txtValue10
            // 
            this.txtValue10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue10.Location = new System.Drawing.Point(409, 352);
            this.txtValue10.Name = "txtValue10";
            this.txtValue10.Size = new System.Drawing.Size(36, 13);
            this.txtValue10.TabIndex = 133;
            this.txtValue10.Text = "0";
            this.txtValue10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue10_KeyDown);
            // 
            // LblDelayChange
            // 
            this.LblDelayChange.AutoSize = true;
            this.LblDelayChange.Location = new System.Drawing.Point(3, 377);
            this.LblDelayChange.Name = "LblDelayChange";
            this.LblDelayChange.Size = new System.Drawing.Size(98, 13);
            this.LblDelayChange.TabIndex = 119;
            this.LblDelayChange.Text = "ParDelayChange[s]";
            // 
            // txtDelayChange
            // 
            this.txtDelayChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelayChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelayChange.Location = new System.Drawing.Point(102, 377);
            this.txtDelayChange.Name = "txtDelayChange";
            this.txtDelayChange.Size = new System.Drawing.Size(56, 13);
            this.txtDelayChange.TabIndex = 120;
            this.txtDelayChange.Text = "2.0";
            this.txtDelayChange.MouseEnter += new System.EventHandler(this.txtDelayChange_MouseEnter);
            // 
            // LblDelayTrue
            // 
            this.LblDelayTrue.AutoSize = true;
            this.LblDelayTrue.Location = new System.Drawing.Point(3, 396);
            this.LblDelayTrue.Name = "LblDelayTrue";
            this.LblDelayTrue.Size = new System.Drawing.Size(83, 13);
            this.LblDelayTrue.TabIndex = 121;
            this.LblDelayTrue.Text = "ParDelayTrue[s]";
            // 
            // txtDelayTrue
            // 
            this.txtDelayTrue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelayTrue.Location = new System.Drawing.Point(102, 396);
            this.txtDelayTrue.Name = "txtDelayTrue";
            this.txtDelayTrue.Size = new System.Drawing.Size(56, 13);
            this.txtDelayTrue.TabIndex = 122;
            this.txtDelayTrue.Text = "0.0";
            this.txtDelayTrue.MouseEnter += new System.EventHandler(this.txtDelayTrue_MouseEnter);
            // 
            // LblDelayFalse
            // 
            this.LblDelayFalse.AutoSize = true;
            this.LblDelayFalse.Location = new System.Drawing.Point(3, 413);
            this.LblDelayFalse.Name = "LblDelayFalse";
            this.LblDelayFalse.Size = new System.Drawing.Size(86, 13);
            this.LblDelayFalse.TabIndex = 123;
            this.LblDelayFalse.Text = "ParDelayFalse[s]";
            // 
            // txtDelayFalse
            // 
            this.txtDelayFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelayFalse.Location = new System.Drawing.Point(102, 413);
            this.txtDelayFalse.Name = "txtDelayFalse";
            this.txtDelayFalse.Size = new System.Drawing.Size(56, 13);
            this.txtDelayFalse.TabIndex = 124;
            this.txtDelayFalse.Text = "0.0";
            this.txtDelayFalse.MouseEnter += new System.EventHandler(this.txtDelayFalse_MouseEnter);
            // 
            // LblTimeoutTrue
            // 
            this.LblTimeoutTrue.AutoSize = true;
            this.LblTimeoutTrue.Location = new System.Drawing.Point(3, 431);
            this.LblTimeoutTrue.Name = "LblTimeoutTrue";
            this.LblTimeoutTrue.Size = new System.Drawing.Size(94, 13);
            this.LblTimeoutTrue.TabIndex = 125;
            this.LblTimeoutTrue.Text = "ParTimeoutTrue[s]";
            // 
            // txtTimeoutTrue
            // 
            this.txtTimeoutTrue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeoutTrue.Location = new System.Drawing.Point(102, 431);
            this.txtTimeoutTrue.Name = "txtTimeoutTrue";
            this.txtTimeoutTrue.Size = new System.Drawing.Size(56, 13);
            this.txtTimeoutTrue.TabIndex = 126;
            this.txtTimeoutTrue.Text = "0.0";
            this.txtTimeoutTrue.MouseEnter += new System.EventHandler(this.txtTimeoutTrue_MouseEnter);
            // 
            // LblTimeoutFalse
            // 
            this.LblTimeoutFalse.AutoSize = true;
            this.LblTimeoutFalse.Location = new System.Drawing.Point(3, 450);
            this.LblTimeoutFalse.Name = "LblTimeoutFalse";
            this.LblTimeoutFalse.Size = new System.Drawing.Size(97, 13);
            this.LblTimeoutFalse.TabIndex = 127;
            this.LblTimeoutFalse.Text = "ParTimeoutFalse[s]";
            // 
            // txtTimeoutFalse
            // 
            this.txtTimeoutFalse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeoutFalse.Location = new System.Drawing.Point(102, 450);
            this.txtTimeoutFalse.Name = "txtTimeoutFalse";
            this.txtTimeoutFalse.Size = new System.Drawing.Size(56, 13);
            this.txtTimeoutFalse.TabIndex = 128;
            this.txtTimeoutFalse.Text = "0.0";
            this.txtTimeoutFalse.MouseEnter += new System.EventHandler(this.txtTimeoutFalse_MouseEnter);
            // 
            // chkParLogOff
            // 
            this.chkParLogOff.AutoSize = true;
            this.chkParLogOff.Location = new System.Drawing.Point(330, 331);
            this.chkParLogOff.Name = "chkParLogOff";
            this.chkParLogOff.Size = new System.Drawing.Size(74, 17);
            this.chkParLogOff.TabIndex = 129;
            this.chkParLogOff.Text = "ParLogOff";
            this.chkParLogOff.UseVisualStyleBackColor = true;
            this.chkParLogOff.CheckedChanged += new System.EventHandler(this.chkParLogOff_CheckedChanged);
            this.chkParLogOff.MouseEnter += new System.EventHandler(this.chkParLogOff_MouseEnter);
            // 
            // chkParPulsing
            // 
            this.chkParPulsing.AutoSize = true;
            this.chkParPulsing.Location = new System.Drawing.Point(330, 349);
            this.chkParPulsing.Name = "chkParPulsing";
            this.chkParPulsing.Size = new System.Drawing.Size(76, 17);
            this.chkParPulsing.TabIndex = 130;
            this.chkParPulsing.Text = "ParPulsing";
            this.chkParPulsing.UseVisualStyleBackColor = true;
            this.chkParPulsing.CheckedChanged += new System.EventHandler(this.chkParPulsing_CheckedChanged);
            this.chkParPulsing.MouseEnter += new System.EventHandler(this.chkParPulsing_MouseEnter);
            // 
            // GroupBoxGroupTree
            // 
            this.GroupBoxGroupTree.Controls.Add(this.chKInpFaultDev);
            this.GroupBoxGroupTree.Controls.Add(this.chkInPreAlarm);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonUnCovered);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonFalse);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonCovered);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonTrue);
            this.GroupBoxGroupTree.Controls.Add(this.Label2);
            this.GroupBoxGroupTree.Controls.Add(this.chkInvertInput);
            this.GroupBoxGroupTree.Controls.Add(this.txtValue9);
            this.GroupBoxGroupTree.Controls.Add(this.chkInterlockNextObject);
            this.GroupBoxGroupTree.Location = new System.Drawing.Point(507, 296);
            this.GroupBoxGroupTree.Name = "GroupBoxGroupTree";
            this.GroupBoxGroupTree.Size = new System.Drawing.Size(177, 180);
            this.GroupBoxGroupTree.TabIndex = 132;
            this.GroupBoxGroupTree.TabStop = false;
            this.GroupBoxGroupTree.Text = "Gcpro";
            // 
            // chKInpFaultDev
            // 
            this.chKInpFaultDev.AutoSize = true;
            this.chKInpFaultDev.Location = new System.Drawing.Point(6, 155);
            this.chKInpFaultDev.Name = "chKInpFaultDev";
            this.chKInpFaultDev.Size = new System.Drawing.Size(114, 17);
            this.chKInpFaultDev.TabIndex = 67;
            this.chKInpFaultDev.Text = "Invert InpFaultDev";
            this.chKInpFaultDev.UseVisualStyleBackColor = true;
            this.chKInpFaultDev.CheckedChanged += new System.EventHandler(this.chKInpFaultDev_CheckedChanged);
            this.chKInpFaultDev.MouseEnter += new System.EventHandler(this.chKInpFaultDev_MouseEnter);
            // 
            // chkInPreAlarm
            // 
            this.chkInPreAlarm.AutoSize = true;
            this.chkInPreAlarm.Location = new System.Drawing.Point(6, 135);
            this.chkInPreAlarm.Name = "chkInPreAlarm";
            this.chkInPreAlarm.Size = new System.Drawing.Size(96, 17);
            this.chkInPreAlarm.TabIndex = 66;
            this.chkInPreAlarm.Text = "Set InPreAlarm";
            this.chkInPreAlarm.UseVisualStyleBackColor = true;
            this.chkInPreAlarm.CheckedChanged += new System.EventHandler(this.chkInPreAlarm_CheckedChanged);
            this.chkInPreAlarm.MouseEnter += new System.EventHandler(this.chkInPreAlarm_MouseEnter);
            // 
            // chkMonUnCovered
            // 
            this.chkMonUnCovered.AutoSize = true;
            this.chkMonUnCovered.Location = new System.Drawing.Point(6, 115);
            this.chkMonUnCovered.Name = "chkMonUnCovered";
            this.chkMonUnCovered.Size = new System.Drawing.Size(129, 17);
            this.chkMonUnCovered.TabIndex = 65;
            this.chkMonUnCovered.Text = "Set InMonUnCovered";
            this.chkMonUnCovered.UseVisualStyleBackColor = true;
            this.chkMonUnCovered.CheckedChanged += new System.EventHandler(this.chkMonUnCovered_CheckedChanged);
            this.chkMonUnCovered.MouseEnter += new System.EventHandler(this.chkMonUnCovered_MouseEnter);
            // 
            // chkMonFalse
            // 
            this.chkMonFalse.AutoSize = true;
            this.chkMonFalse.Location = new System.Drawing.Point(6, 95);
            this.chkMonFalse.Name = "chkMonFalse";
            this.chkMonFalse.Size = new System.Drawing.Size(100, 17);
            this.chkMonFalse.TabIndex = 64;
            this.chkMonFalse.Text = "Set InMonFalse";
            this.chkMonFalse.UseVisualStyleBackColor = true;
            this.chkMonFalse.CheckedChanged += new System.EventHandler(this.chkMonFalse_CheckedChanged);
            this.chkMonFalse.MouseEnter += new System.EventHandler(this.chkMonFalse_MouseEnter);
            // 
            // chkMonCovered
            // 
            this.chkMonCovered.AutoSize = true;
            this.chkMonCovered.Location = new System.Drawing.Point(6, 75);
            this.chkMonCovered.Name = "chkMonCovered";
            this.chkMonCovered.Size = new System.Drawing.Size(115, 17);
            this.chkMonCovered.TabIndex = 63;
            this.chkMonCovered.Text = "Set InMonCovered";
            this.chkMonCovered.UseVisualStyleBackColor = true;
            this.chkMonCovered.CheckedChanged += new System.EventHandler(this.chkMonCovered_CheckedChanged);
            this.chkMonCovered.MouseEnter += new System.EventHandler(this.chkMonCovered_MouseEnter);
            // 
            // chkMonTrue
            // 
            this.chkMonTrue.AutoSize = true;
            this.chkMonTrue.Location = new System.Drawing.Point(6, 55);
            this.chkMonTrue.Name = "chkMonTrue";
            this.chkMonTrue.Size = new System.Drawing.Size(97, 17);
            this.chkMonTrue.TabIndex = 62;
            this.chkMonTrue.Text = "Set InMonTrue";
            this.chkMonTrue.UseVisualStyleBackColor = true;
            this.chkMonTrue.CheckedChanged += new System.EventHandler(this.chkMonTrue_CheckedChanged);
            this.chkMonTrue.MouseEnter += new System.EventHandler(this.chkMonTrue_MouseEnter);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(133, 17);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "Value9";
            // 
            // chkInvertInput
            // 
            this.chkInvertInput.AutoSize = true;
            this.chkInvertInput.Location = new System.Drawing.Point(6, 35);
            this.chkInvertInput.Name = "chkInvertInput";
            this.chkInvertInput.Size = new System.Drawing.Size(127, 17);
            this.chkInvertInput.TabIndex = 42;
            this.chkInvertInput.Text = "Invert Input(LL or HL)";
            this.chkInvertInput.UseVisualStyleBackColor = true;
            this.chkInvertInput.CheckedChanged += new System.EventHandler(this.chkInvertInput_CheckedChanged);
            this.chkInvertInput.MouseEnter += new System.EventHandler(this.chkInvertInput_MouseEnter);
            // 
            // txtValue9
            // 
            this.txtValue9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue9.Location = new System.Drawing.Point(135, 36);
            this.txtValue9.Name = "txtValue9";
            this.txtValue9.Size = new System.Drawing.Size(36, 13);
            this.txtValue9.TabIndex = 60;
            this.txtValue9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue9_KeyDown);
            // 
            // chkInterlockNextObject
            // 
            this.chkInterlockNextObject.AutoSize = true;
            this.chkInterlockNextObject.Location = new System.Drawing.Point(6, 15);
            this.chkInterlockNextObject.Name = "chkInterlockNextObject";
            this.chkInterlockNextObject.Size = new System.Drawing.Size(120, 17);
            this.chkInterlockNextObject.TabIndex = 41;
            this.chkInterlockNextObject.Text = "InterlockNextObject";
            this.chkInterlockNextObject.UseVisualStyleBackColor = true;
            this.chkInterlockNextObject.CheckedChanged += new System.EventHandler(this.chkInterlockNextObject_CheckedChanged);
            this.chkInterlockNextObject.MouseEnter += new System.EventHandler(this.chkInterlockNextObject_MouseEnter);
            // 
            // chkParFaultRetry
            // 
            this.chkParFaultRetry.AutoSize = true;
            this.chkParFaultRetry.Location = new System.Drawing.Point(330, 367);
            this.chkParFaultRetry.Name = "chkParFaultRetry";
            this.chkParFaultRetry.Size = new System.Drawing.Size(90, 17);
            this.chkParFaultRetry.TabIndex = 131;
            this.chkParFaultRetry.Text = "ParFaultRetry";
            this.chkParFaultRetry.UseVisualStyleBackColor = true;
            this.chkParFaultRetry.CheckedChanged += new System.EventHandler(this.chkParFaultRetry_CheckedChanged);
            this.chkParFaultRetry.MouseEnter += new System.EventHandler(this.chkParFaultRetry_MouseEnter);
            // 
            // chkOnlyFree
            // 
            this.chkOnlyFree.AutoSize = true;
            this.chkOnlyFree.Checked = true;
            this.chkOnlyFree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyFree.Location = new System.Drawing.Point(133, 260);
            this.chkOnlyFree.Name = "chkOnlyFree";
            this.chkOnlyFree.Size = new System.Drawing.Size(110, 17);
            this.chkOnlyFree.TabIndex = 62;
            this.chkOnlyFree.Text = "仅关联丢失连接";
            this.chkOnlyFree.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
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
            this.grpGeneral.Controls.Add(this.txtInpTrue);
            this.grpGeneral.Controls.Add(this.GrpSymbolRule);
            this.grpGeneral.Controls.Add(this.lblOutpRevSuffix);
            this.grpGeneral.Controls.Add(this.txtOutpPowerOffSuffix);
            this.grpGeneral.Controls.Add(this.LblInpTrue);
            this.grpGeneral.Controls.Add(this.txtOutpFaultResetSuffix);
            this.grpGeneral.Controls.Add(this.txtDescription);
            this.grpGeneral.Controls.Add(this.lblOutpFaultResetSuffix);
            this.grpGeneral.Controls.Add(this.txtSymbol);
            this.grpGeneral.Controls.Add(this.LblDescription);
            this.grpGeneral.Controls.Add(this.txtInpTrueSuffix);
            this.grpGeneral.Controls.Add(this.txtOutpFaultReset);
            this.grpGeneral.Controls.Add(this.lblInpTrueSuffix);
            this.grpGeneral.Controls.Add(this.LblOutpFaultReset);
            this.grpGeneral.Controls.Add(this.LblOutRunRev);
            this.grpGeneral.Controls.Add(this.txtOutpPowerOff);
            this.grpGeneral.Location = new System.Drawing.Point(6, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(703, 221);
            this.grpGeneral.TabIndex = 118;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "常规";
            // 
            // grpAddInfoToDesc
            // 
            this.grpAddInfoToDesc.Controls.Add(this.chkAddUserSectionToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkNameOnlyNumber);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddSectionToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddNameToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddFloorToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddCabinetToDesc);
            this.grpAddInfoToDesc.Location = new System.Drawing.Point(9, 170);
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
            this.lblInHWStop.Location = new System.Drawing.Point(5, 134);
            this.lblInHWStop.Name = "lblInHWStop";
            this.lblInHWStop.Size = new System.Drawing.Size(63, 13);
            this.lblInHWStop.TabIndex = 116;
            this.lblInHWStop.Text = "[InHWStop]";
            // 
            // lblInHWStopSuffix
            // 
            this.lblInHWStopSuffix.AutoSize = true;
            this.lblInHWStopSuffix.Location = new System.Drawing.Point(114, 134);
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
            this.txtInHWStop.Location = new System.Drawing.Point(9, 150);
            this.txtInHWStop.Name = "txtInHWStop";
            this.txtInHWStop.Size = new System.Drawing.Size(100, 13);
            this.txtInHWStop.TabIndex = 114;
            // 
            // txtInHWStopSuffix
            // 
            this.txtInHWStopSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInHWStopSuffix.Location = new System.Drawing.Point(112, 150);
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
            // txtInpTrue
            // 
            this.txtInpTrue.BackColor = System.Drawing.Color.LightGray;
            this.txtInpTrue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpTrue.Enabled = false;
            this.txtInpTrue.Location = new System.Drawing.Point(8, 79);
            this.txtInpTrue.Name = "txtInpTrue";
            this.txtInpTrue.Size = new System.Drawing.Size(100, 13);
            this.txtInpTrue.TabIndex = 6;
            this.txtInpTrue.MouseEnter += new System.EventHandler(this.txtInpTrue_MouseEnter);
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
            // lblOutpRevSuffix
            // 
            this.lblOutpRevSuffix.AutoSize = true;
            this.lblOutpRevSuffix.Location = new System.Drawing.Point(343, 95);
            this.lblOutpRevSuffix.Name = "lblOutpRevSuffix";
            this.lblOutpRevSuffix.Size = new System.Drawing.Size(31, 13);
            this.lblOutpRevSuffix.TabIndex = 109;
            this.lblOutpRevSuffix.Text = "后缀";
            // 
            // txtOutpPowerOffSuffix
            // 
            this.txtOutpPowerOffSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpPowerOffSuffix.Location = new System.Drawing.Point(346, 115);
            this.txtOutpPowerOffSuffix.Name = "txtOutpPowerOffSuffix";
            this.txtOutpPowerOffSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtOutpPowerOffSuffix.TabIndex = 108;
            this.txtOutpPowerOffSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOutpPowerOffSuffix.TextChanged += new System.EventHandler(this.txtOutRevSuffix_TextChanged);
            this.txtOutpPowerOffSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutpPowerOffSuffix_KeyDown);
            // 
            // LblInpTrue
            // 
            this.LblInpTrue.AutoSize = true;
            this.LblInpTrue.Location = new System.Drawing.Point(5, 59);
            this.LblInpTrue.Name = "LblInpTrue";
            this.LblInpTrue.Size = new System.Drawing.Size(44, 13);
            this.LblInpTrue.TabIndex = 4;
            this.LblInpTrue.Text = "InpTrue";
            // 
            // txtOutpFaultResetSuffix
            // 
            this.txtOutpFaultResetSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpFaultResetSuffix.Location = new System.Drawing.Point(346, 79);
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
            this.lblOutpFaultResetSuffix.Location = new System.Drawing.Point(343, 59);
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
            // txtInpTrueSuffix
            // 
            this.txtInpTrueSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpTrueSuffix.Location = new System.Drawing.Point(111, 79);
            this.txtInpTrueSuffix.Name = "txtInpTrueSuffix";
            this.txtInpTrueSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtInpTrueSuffix.TabIndex = 86;
            this.txtInpTrueSuffix.Text = ":I";
            this.txtInpTrueSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInpTrueSuffix.TextChanged += new System.EventHandler(this.txtInpTrueSuffix_TextChanged);
            this.txtInpTrueSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInpTrueSuffix_KeyDown);
            // 
            // txtOutpFaultReset
            // 
            this.txtOutpFaultReset.BackColor = System.Drawing.Color.LightGray;
            this.txtOutpFaultReset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpFaultReset.Location = new System.Drawing.Point(238, 79);
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
            this.LblOutpFaultReset.Location = new System.Drawing.Point(235, 59);
            this.LblOutpFaultReset.Name = "LblOutpFaultReset";
            this.LblOutpFaultReset.Size = new System.Drawing.Size(81, 13);
            this.LblOutpFaultReset.TabIndex = 100;
            this.LblOutpFaultReset.Text = "OutpFaultReset";
            // 
            // LblOutRunRev
            // 
            this.LblOutRunRev.AutoSize = true;
            this.LblOutRunRev.Location = new System.Drawing.Point(236, 95);
            this.LblOutRunRev.Name = "LblOutRunRev";
            this.LblOutRunRev.Size = new System.Drawing.Size(74, 13);
            this.LblOutRunRev.TabIndex = 102;
            this.LblOutRunRev.Text = "OutpPowerOff";
            // 
            // txtOutpPowerOff
            // 
            this.txtOutpPowerOff.BackColor = System.Drawing.Color.LightGray;
            this.txtOutpPowerOff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpPowerOff.Location = new System.Drawing.Point(239, 115);
            this.txtOutpPowerOff.Name = "txtOutpPowerOff";
            this.txtOutpPowerOff.Size = new System.Drawing.Size(100, 13);
            this.txtOutpPowerOff.TabIndex = 103;
            // 
            // BtnRegenerateDPNode
            // 
            this.BtnRegenerateDPNode.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegenerateDPNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegenerateDPNode.BackgroundImage")));
            this.BtnRegenerateDPNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRegenerateDPNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegenerateDPNode.Location = new System.Drawing.Point(48, 252);
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
            this.BtnNewImpExpDef.Location = new System.Drawing.Point(6, 252);
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
            this.LblEquipmentInfoType.Location = new System.Drawing.Point(2, 299);
            this.LblEquipmentInfoType.Name = "LblEquipmentInfoType";
            this.LblEquipmentInfoType.Size = new System.Drawing.Size(99, 13);
            this.LblEquipmentInfoType.TabIndex = 12;
            this.LblEquipmentInfoType.Text = "EquipmentInfoType";
            // 
            // ComboEquipmentInfoType
            // 
            this.ComboEquipmentInfoType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboEquipmentInfoType.FormattingEnabled = true;
            this.ComboEquipmentInfoType.IntegralHeight = false;
            this.ComboEquipmentInfoType.Location = new System.Drawing.Point(101, 296);
            this.ComboEquipmentInfoType.Name = "ComboEquipmentInfoType";
            this.ComboEquipmentInfoType.Size = new System.Drawing.Size(357, 21);
            this.ComboEquipmentInfoType.TabIndex = 13;
            this.ComboEquipmentInfoType.MouseEnter += new System.EventHandler(this.ComboEquipmentInfoType_MouseEnter);
            // 
            // LblHornCode
            // 
            this.LblHornCode.AutoSize = true;
            this.LblHornCode.Location = new System.Drawing.Point(2, 324);
            this.LblHornCode.Name = "LblHornCode";
            this.LblHornCode.Size = new System.Drawing.Size(71, 13);
            this.LblHornCode.TabIndex = 14;
            this.LblHornCode.Text = "ParHornCode";
            // 
            // ComboHornCode
            // 
            this.ComboHornCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHornCode.FormattingEnabled = true;
            this.ComboHornCode.Location = new System.Drawing.Point(101, 320);
            this.ComboHornCode.Name = "ComboHornCode";
            this.ComboHornCode.Size = new System.Drawing.Size(146, 21);
            this.ComboHornCode.TabIndex = 15;
            this.ComboHornCode.MouseEnter += new System.EventHandler(this.ComboHornCode_MouseEnter);
            // 
            // LblDPNode1
            // 
            this.LblDPNode1.AutoSize = true;
            this.LblDPNode1.Location = new System.Drawing.Point(2, 349);
            this.LblDPNode1.Name = "LblDPNode1";
            this.LblDPNode1.Size = new System.Drawing.Size(64, 13);
            this.LblDPNode1.TabIndex = 16;
            this.LblDPNode1.Text = "ParDPNode";
            // 
            // BtnConnectIO
            // 
            this.BtnConnectIO.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConnectIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConnectIO.BackgroundImage")));
            this.BtnConnectIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConnectIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnectIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnectIO.Location = new System.Drawing.Point(90, 252);
            this.BtnConnectIO.Name = "BtnConnectIO";
            this.BtnConnectIO.Size = new System.Drawing.Size(36, 30);
            this.BtnConnectIO.TabIndex = 98;
            this.BtnConnectIO.UseVisualStyleBackColor = false;
            this.BtnConnectIO.Click += new System.EventHandler(this.BtnConnectIO_Click);
            // 
            // ComboDPNode1
            // 
            this.ComboDPNode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboDPNode1.FormattingEnabled = true;
            this.ComboDPNode1.Location = new System.Drawing.Point(101, 343);
            this.ComboDPNode1.Name = "ComboDPNode1";
            this.ComboDPNode1.Size = new System.Drawing.Size(146, 21);
            this.ComboDPNode1.TabIndex = 18;
            this.ComboDPNode1.MouseEnter += new System.EventHandler(this.ComboDPNode1_MouseEnter);
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
            this.comboControlBML.Visible = false;
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
            this.lblControlBML.Visible = false;
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
            // FormDI
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
            this.Name = "FormDI";
            this.Text = "EL_DI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDI_FormClosed);
            this.Load += new System.EventHandler(this.FormDI_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCreateMode.ResumeLayout(false);
            this.contextMenuStripBML.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.tabRule.PerformLayout();
            this.PalGcObject.ResumeLayout(false);
            this.PalGcObject.PerformLayout();
            this.GroupBoxGroupTree.ResumeLayout(false);
            this.GroupBoxGroupTree.PerformLayout();
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
        internal System.Windows.Forms.Label LblInpTrue;
        internal System.Windows.Forms.GroupBox GrpSymbolRule;
        internal System.Windows.Forms.Label LblSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolIncRule;
        internal System.Windows.Forms.Label LblSymbolIncRule;
        internal System.Windows.Forms.TextBox txtInpTrue;
        internal System.Windows.Forms.GroupBox GrpDescriptionRule;
        internal System.Windows.Forms.Label LblDescriptionRule;
        internal System.Windows.Forms.TextBox txtDescriptionIncRule;
        internal System.Windows.Forms.Label Lbl;
        internal System.Windows.Forms.TextBox txtDescriptionRule;
        internal System.Windows.Forms.Label LblEquipmentInfoType;
        internal System.Windows.Forms.ComboBox ComboEquipmentInfoType;
        internal System.Windows.Forms.Label LblHornCode;
        internal System.Windows.Forms.ComboBox ComboHornCode;
        internal System.Windows.Forms.Label LblDPNode1;
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
        internal System.Windows.Forms.Label LblOutRunRev;
        internal System.Windows.Forms.TextBox txtOutpPowerOff;
        internal System.Windows.Forms.Label LblOutpFaultReset;
        internal System.Windows.Forms.TextBox txtOutpFaultReset;
        internal System.Windows.Forms.Label lblInpTrueSuffix;
        internal System.Windows.Forms.TextBox txtInpTrueSuffix;
        internal System.Windows.Forms.Label lblOutpRevSuffix;
        internal System.Windows.Forms.TextBox txtOutpPowerOffSuffix;
        internal System.Windows.Forms.TextBox txtOutpFaultResetSuffix;
        internal System.Windows.Forms.Label lblOutpFaultResetSuffix;
        private System.Windows.Forms.GroupBox grpGeneral;
        internal System.Windows.Forms.CheckBox chkOnlyFree;
        internal System.Windows.Forms.ComboBox comboControlBML;
        private System.Windows.Forms.Label lblControlBML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        internal System.Windows.Forms.CheckBox chkParBinLevel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtValue10;
        internal System.Windows.Forms.Label LblDelayChange;
        internal System.Windows.Forms.TextBox txtDelayChange;
        internal System.Windows.Forms.Label LblDelayTrue;
        internal System.Windows.Forms.TextBox txtDelayTrue;
        internal System.Windows.Forms.Label LblDelayFalse;
        internal System.Windows.Forms.TextBox txtDelayFalse;
        internal System.Windows.Forms.Label LblTimeoutTrue;
        internal System.Windows.Forms.TextBox txtTimeoutTrue;
        internal System.Windows.Forms.Label LblTimeoutFalse;
        internal System.Windows.Forms.TextBox txtTimeoutFalse;
        internal System.Windows.Forms.CheckBox chkParLogOff;
        internal System.Windows.Forms.CheckBox chkParPulsing;
        internal System.Windows.Forms.GroupBox GroupBoxGroupTree;
        internal System.Windows.Forms.CheckBox chKInpFaultDev;
        internal System.Windows.Forms.CheckBox chkInPreAlarm;
        internal System.Windows.Forms.CheckBox chkMonUnCovered;
        private System.Windows.Forms.CheckBox chkMonFalse;
        internal System.Windows.Forms.CheckBox chkMonCovered;
        internal System.Windows.Forms.CheckBox chkMonTrue;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.CheckBox chkInvertInput;
        internal System.Windows.Forms.TextBox txtValue9;
        internal System.Windows.Forms.CheckBox chkInterlockNextObject;
        internal System.Windows.Forms.CheckBox chkParFaultRetry;
        internal System.Windows.Forms.ComboBox ComboDPNode1;
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
    }
}

