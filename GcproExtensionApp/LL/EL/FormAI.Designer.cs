using System;

namespace GcproExtensionApp
{
    partial class FormAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grpWinCOS = new System.Windows.Forms.GroupBox();
            this.chkOutValueRel = new System.Windows.Forms.CheckBox();
            this.chkOutValueUnits = new System.Windows.Forms.CheckBox();
            this.lblOffsetUnits = new System.Windows.Forms.Label();
            this.txtOffsetUnits = new System.Windows.Forms.TextBox();
            this.txtParLimitHighHigh = new System.Windows.Forms.TextBox();
            this.lblParLimitHighHigh = new System.Windows.Forms.Label();
            this.txtParLimitHigh = new System.Windows.Forms.TextBox();
            this.lblParLimitHigh = new System.Windows.Forms.Label();
            this.txtParLimitLow = new System.Windows.Forms.TextBox();
            this.lblParLimitLow = new System.Windows.Forms.Label();
            this.txtParLimitLowLow = new System.Windows.Forms.TextBox();
            this.lblParLimitLowLow = new System.Windows.Forms.Label();
            this.chkParPreAlarmHighHigh = new System.Windows.Forms.CheckBox();
            this.chkParPreAlarmHigh = new System.Windows.Forms.CheckBox();
            this.chkParPreAlarmMiddle = new System.Windows.Forms.CheckBox();
            this.lblUnitsBy100 = new System.Windows.Forms.Label();
            this.chkParPreAlarmLow = new System.Windows.Forms.CheckBox();
            this.txtUnitsBy100 = new System.Windows.Forms.TextBox();
            this.chkParPreAlarmLowLow = new System.Windows.Forms.CheckBox();
            this.lblDelayTimeDown = new System.Windows.Forms.Label();
            this.chkParWarningHighHigh = new System.Windows.Forms.CheckBox();
            this.txtDelayTimeDown = new System.Windows.Forms.TextBox();
            this.chkParWarningHigh = new System.Windows.Forms.CheckBox();
            this.lblDelayTimeUp = new System.Windows.Forms.Label();
            this.chkParWarningMiddle = new System.Windows.Forms.CheckBox();
            this.txtDelayTimeUp = new System.Windows.Forms.TextBox();
            this.chkParWarningLow = new System.Windows.Forms.CheckBox();
            this.lblDelayTimeFault = new System.Windows.Forms.Label();
            this.chkParWarningLowLow = new System.Windows.Forms.CheckBox();
            this.txtDelayTimeFault = new System.Windows.Forms.TextBox();
            this.txtMonTimeHighHigh = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblHighHighMonTime = new System.Windows.Forms.Label();
            this.chkParLogOff = new System.Windows.Forms.CheckBox();
            this.txtMonTimeHigh = new System.Windows.Forms.TextBox();
            this.chkParLimitsRel = new System.Windows.Forms.CheckBox();
            this.lblHighMonTime = new System.Windows.Forms.Label();
            this.chkParNoHornByWarning = new System.Windows.Forms.CheckBox();
            this.txtMonTimeMiddle = new System.Windows.Forms.TextBox();
            this.GroupBoxGroupTree = new System.Windows.Forms.GroupBox();
            this.chkWinCC = new System.Windows.Forms.CheckBox();
            this.chkInDisable = new System.Windows.Forms.CheckBox();
            this.chkMonNotMiddle = new System.Windows.Forms.CheckBox();
            this.chkMonNotHighHigh = new System.Windows.Forms.CheckBox();
            this.lblValue9 = new System.Windows.Forms.Label();
            this.chkMonNotHigh = new System.Windows.Forms.CheckBox();
            this.chkMonNotLow = new System.Windows.Forms.CheckBox();
            this.txtValue9 = new System.Windows.Forms.TextBox();
            this.chkMonNotLowLow = new System.Windows.Forms.CheckBox();
            this.chkInterlocking = new System.Windows.Forms.CheckBox();
            this.lblMiddleMonTime = new System.Windows.Forms.Label();
            this.txtValue10 = new System.Windows.Forms.TextBox();
            this.txtMonTimeLow = new System.Windows.Forms.TextBox();
            this.lblValue10 = new System.Windows.Forms.Label();
            this.lblLowMonTime = new System.Windows.Forms.Label();
            this.txtMonTimeLowLow = new System.Windows.Forms.TextBox();
            this.lblLowLowMonTime = new System.Windows.Forms.Label();
            this.comboUnit = new System.Windows.Forms.ComboBox();
            this.chkOnlyFree = new System.Windows.Forms.CheckBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.txtSuffixInpHighHigh = new System.Windows.Forms.TextBox();
            this.txtSuffixInpHigh = new System.Windows.Forms.TextBox();
            this.txtSuffixInpLow = new System.Windows.Forms.TextBox();
            this.txtInpHighHigh = new System.Windows.Forms.TextBox();
            this.lblInpHighHigh = new System.Windows.Forms.Label();
            this.txtInpHigh = new System.Windows.Forms.TextBox();
            this.lblInpHigh = new System.Windows.Forms.Label();
            this.txtInpLow = new System.Windows.Forms.TextBox();
            this.lblInpLow = new System.Windows.Forms.Label();
            this.txtInpLowLow = new System.Windows.Forms.TextBox();
            this.lblInpLowLow = new System.Windows.Forms.Label();
            this.txtSuffixInpLowLow = new System.Windows.Forms.TextBox();
            this.lblSuffixInpDigital = new System.Windows.Forms.Label();
            this.grpAddInfoToDesc = new System.Windows.Forms.GroupBox();
            this.chkNameOnlyNumber = new System.Windows.Forms.CheckBox();
            this.chkAddSectionToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddFloorToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddNameToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddCabinetToDesc = new System.Windows.Forms.CheckBox();
            this.lblInHWStop = new System.Windows.Forms.Label();
            this.txtInHWStop = new System.Windows.Forms.TextBox();
            this.lblInpFaultDev = new System.Windows.Forms.Label();
            this.lblInpFaultDevSuffix = new System.Windows.Forms.Label();
            this.txtInpFaultDev = new System.Windows.Forms.TextBox();
            this.txtInpFaultDevSuffix = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.grpDescriptionRule = new System.Windows.Forms.GroupBox();
            this.lblDescriptionRule = new System.Windows.Forms.Label();
            this.txtDescriptionIncRule = new System.Windows.Forms.TextBox();
            this.lblDescriptionIncRule = new System.Windows.Forms.Label();
            this.txtDescriptionRule = new System.Windows.Forms.TextBox();
            this.txtInpValue = new System.Windows.Forms.TextBox();
            this.GrpSymbolRule = new System.Windows.Forms.GroupBox();
            this.lblSymbolRule = new System.Windows.Forms.Label();
            this.txtSymbolRule = new System.Windows.Forms.TextBox();
            this.txtSymbolIncRule = new System.Windows.Forms.TextBox();
            this.lblSymbolIncRule = new System.Windows.Forms.Label();
            this.LblInpValue = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtInpValeSuffix = new System.Windows.Forms.TextBox();
            this.lblInpTrueSuffix = new System.Windows.Forms.Label();
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
            this.chkUpdateUnitsByMaxDigits = new System.Windows.Forms.CheckBox();
            this.btnReadBML = new System.Windows.Forms.Button();
            this.dataGridBML = new System.Windows.Forms.DataGridView();
            this.lblWorkSheet = new System.Windows.Forms.Label();
            this.comboWorkSheetsBML = new System.Windows.Forms.ComboBox();
            this.grpBoxExcelColumn = new System.Windows.Forms.GroupBox();
            this.grpBoxBMLColum = new System.Windows.Forms.GroupBox();
            this.comboPowerBML = new System.Windows.Forms.ComboBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.comboLineBML = new System.Windows.Forms.ComboBox();
            this.lblLineBML = new System.Windows.Forms.Label();
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
            this.chkAddUserSectionToDesc = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            this.tabCreateMode.SuspendLayout();
            this.contextMenuStripBML.SuspendLayout();
            this.tabRule.SuspendLayout();
            this.PalGcObject.SuspendLayout();
            this.grpWinCOS.SuspendLayout();
            this.GroupBoxGroupTree.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpAddInfoToDesc.SuspendLayout();
            this.grpDescriptionRule.SuspendLayout();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 796);
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
            this.tabCreateMode.Size = new System.Drawing.Size(731, 606);
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
            this.tabRule.Size = new System.Drawing.Size(723, 580);
            this.tabRule.TabIndex = 0;
            this.tabRule.Text = "设定规则创建";
            // 
            // PalGcObject
            // 
            this.PalGcObject.AutoScroll = true;
            this.PalGcObject.AutoSize = true;
            this.PalGcObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PalGcObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PalGcObject.Controls.Add(this.grpWinCOS);
            this.PalGcObject.Controls.Add(this.lblOffsetUnits);
            this.PalGcObject.Controls.Add(this.txtOffsetUnits);
            this.PalGcObject.Controls.Add(this.txtParLimitHighHigh);
            this.PalGcObject.Controls.Add(this.lblParLimitHighHigh);
            this.PalGcObject.Controls.Add(this.txtParLimitHigh);
            this.PalGcObject.Controls.Add(this.lblParLimitHigh);
            this.PalGcObject.Controls.Add(this.txtParLimitLow);
            this.PalGcObject.Controls.Add(this.lblParLimitLow);
            this.PalGcObject.Controls.Add(this.txtParLimitLowLow);
            this.PalGcObject.Controls.Add(this.lblParLimitLowLow);
            this.PalGcObject.Controls.Add(this.chkParPreAlarmHighHigh);
            this.PalGcObject.Controls.Add(this.chkParPreAlarmHigh);
            this.PalGcObject.Controls.Add(this.chkParPreAlarmMiddle);
            this.PalGcObject.Controls.Add(this.lblUnitsBy100);
            this.PalGcObject.Controls.Add(this.chkParPreAlarmLow);
            this.PalGcObject.Controls.Add(this.txtUnitsBy100);
            this.PalGcObject.Controls.Add(this.chkParPreAlarmLowLow);
            this.PalGcObject.Controls.Add(this.lblDelayTimeDown);
            this.PalGcObject.Controls.Add(this.chkParWarningHighHigh);
            this.PalGcObject.Controls.Add(this.txtDelayTimeDown);
            this.PalGcObject.Controls.Add(this.chkParWarningHigh);
            this.PalGcObject.Controls.Add(this.lblDelayTimeUp);
            this.PalGcObject.Controls.Add(this.chkParWarningMiddle);
            this.PalGcObject.Controls.Add(this.txtDelayTimeUp);
            this.PalGcObject.Controls.Add(this.chkParWarningLow);
            this.PalGcObject.Controls.Add(this.lblDelayTimeFault);
            this.PalGcObject.Controls.Add(this.chkParWarningLowLow);
            this.PalGcObject.Controls.Add(this.txtDelayTimeFault);
            this.PalGcObject.Controls.Add(this.txtMonTimeHighHigh);
            this.PalGcObject.Controls.Add(this.lblUnit);
            this.PalGcObject.Controls.Add(this.lblHighHighMonTime);
            this.PalGcObject.Controls.Add(this.chkParLogOff);
            this.PalGcObject.Controls.Add(this.txtMonTimeHigh);
            this.PalGcObject.Controls.Add(this.chkParLimitsRel);
            this.PalGcObject.Controls.Add(this.lblHighMonTime);
            this.PalGcObject.Controls.Add(this.chkParNoHornByWarning);
            this.PalGcObject.Controls.Add(this.txtMonTimeMiddle);
            this.PalGcObject.Controls.Add(this.GroupBoxGroupTree);
            this.PalGcObject.Controls.Add(this.lblMiddleMonTime);
            this.PalGcObject.Controls.Add(this.txtValue10);
            this.PalGcObject.Controls.Add(this.txtMonTimeLow);
            this.PalGcObject.Controls.Add(this.lblValue10);
            this.PalGcObject.Controls.Add(this.lblLowMonTime);
            this.PalGcObject.Controls.Add(this.txtMonTimeLowLow);
            this.PalGcObject.Controls.Add(this.lblLowLowMonTime);
            this.PalGcObject.Controls.Add(this.comboUnit);
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
            this.PalGcObject.Size = new System.Drawing.Size(717, 574);
            this.PalGcObject.TabIndex = 105;
            // 
            // grpWinCOS
            // 
            this.grpWinCOS.Controls.Add(this.chkOutValueRel);
            this.grpWinCOS.Controls.Add(this.chkOutValueUnits);
            this.grpWinCOS.Location = new System.Drawing.Point(537, 445);
            this.grpWinCOS.Name = "grpWinCOS";
            this.grpWinCOS.Size = new System.Drawing.Size(173, 60);
            this.grpWinCOS.TabIndex = 143;
            this.grpWinCOS.TabStop = false;
            this.grpWinCOS.Text = "WinCos:Trending";
            // 
            // chkOutValueRel
            // 
            this.chkOutValueRel.AutoSize = true;
            this.chkOutValueRel.Location = new System.Drawing.Point(6, 35);
            this.chkOutValueRel.Name = "chkOutValueRel";
            this.chkOutValueRel.Size = new System.Drawing.Size(86, 17);
            this.chkOutValueRel.TabIndex = 42;
            this.chkOutValueRel.Text = "OutValueRel";
            this.chkOutValueRel.UseVisualStyleBackColor = true;
            this.chkOutValueRel.CheckedChanged += new System.EventHandler(this.chkOutValueRel_CheckedChanged);
            this.chkOutValueRel.MouseEnter += new System.EventHandler(this.chkOutValueRel_MouseEnter);
            // 
            // chkOutValueUnits
            // 
            this.chkOutValueUnits.AutoSize = true;
            this.chkOutValueUnits.Location = new System.Drawing.Point(6, 15);
            this.chkOutValueUnits.Name = "chkOutValueUnits";
            this.chkOutValueUnits.Size = new System.Drawing.Size(94, 17);
            this.chkOutValueUnits.TabIndex = 41;
            this.chkOutValueUnits.Text = "OutValueUnits";
            this.chkOutValueUnits.UseVisualStyleBackColor = true;
            this.chkOutValueUnits.CheckedChanged += new System.EventHandler(this.chkOutValueUnits_CheckedChanged);
            this.chkOutValueUnits.MouseEnter += new System.EventHandler(this.chkOutValueUnits_MouseEnter);
            // 
            // lblOffsetUnits
            // 
            this.lblOffsetUnits.AutoSize = true;
            this.lblOffsetUnits.Location = new System.Drawing.Point(1, 361);
            this.lblOffsetUnits.Name = "lblOffsetUnits";
            this.lblOffsetUnits.Size = new System.Drawing.Size(75, 13);
            this.lblOffsetUnits.TabIndex = 174;
            this.lblOffsetUnits.Text = "ParOffsetUnits";
            // 
            // txtOffsetUnits
            // 
            this.txtOffsetUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOffsetUnits.Location = new System.Drawing.Point(114, 361);
            this.txtOffsetUnits.Name = "txtOffsetUnits";
            this.txtOffsetUnits.Size = new System.Drawing.Size(56, 13);
            this.txtOffsetUnits.TabIndex = 175;
            this.txtOffsetUnits.Text = "0";
            this.txtOffsetUnits.MouseEnter += new System.EventHandler(this.txtOffsetUnits_MouseEnter);
            // 
            // txtParLimitHighHigh
            // 
            this.txtParLimitHighHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParLimitHighHigh.Location = new System.Drawing.Point(324, 395);
            this.txtParLimitHighHigh.Name = "txtParLimitHighHigh";
            this.txtParLimitHighHigh.Size = new System.Drawing.Size(56, 13);
            this.txtParLimitHighHigh.TabIndex = 173;
            this.txtParLimitHighHigh.Text = "0";
            this.txtParLimitHighHigh.MouseEnter += new System.EventHandler(this.txtParLimitHighHigh_MouseEnter);
            // 
            // lblParLimitHighHigh
            // 
            this.lblParLimitHighHigh.AutoSize = true;
            this.lblParLimitHighHigh.Location = new System.Drawing.Point(226, 397);
            this.lblParLimitHighHigh.Name = "lblParLimitHighHigh";
            this.lblParLimitHighHigh.Size = new System.Drawing.Size(88, 13);
            this.lblParLimitHighHigh.TabIndex = 172;
            this.lblParLimitHighHigh.Text = "ParLimitHighHigh";
            // 
            // txtParLimitHigh
            // 
            this.txtParLimitHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParLimitHigh.Location = new System.Drawing.Point(324, 378);
            this.txtParLimitHigh.Name = "txtParLimitHigh";
            this.txtParLimitHigh.Size = new System.Drawing.Size(56, 13);
            this.txtParLimitHigh.TabIndex = 171;
            this.txtParLimitHigh.Text = "0";
            this.txtParLimitHigh.MouseEnter += new System.EventHandler(this.txtParLimitHigh_MouseEnter);
            // 
            // lblParLimitHigh
            // 
            this.lblParLimitHigh.AutoSize = true;
            this.lblParLimitHigh.Location = new System.Drawing.Point(226, 379);
            this.lblParLimitHigh.Name = "lblParLimitHigh";
            this.lblParLimitHigh.Size = new System.Drawing.Size(66, 13);
            this.lblParLimitHigh.TabIndex = 170;
            this.lblParLimitHigh.Text = "ParLimitHigh";
            // 
            // txtParLimitLow
            // 
            this.txtParLimitLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParLimitLow.Location = new System.Drawing.Point(324, 361);
            this.txtParLimitLow.Name = "txtParLimitLow";
            this.txtParLimitLow.Size = new System.Drawing.Size(56, 13);
            this.txtParLimitLow.TabIndex = 169;
            this.txtParLimitLow.Text = "0";
            this.txtParLimitLow.MouseEnter += new System.EventHandler(this.txtParLimitLow_MouseEnter);
            // 
            // lblParLimitLow
            // 
            this.lblParLimitLow.AutoSize = true;
            this.lblParLimitLow.Location = new System.Drawing.Point(226, 361);
            this.lblParLimitLow.Name = "lblParLimitLow";
            this.lblParLimitLow.Size = new System.Drawing.Size(64, 13);
            this.lblParLimitLow.TabIndex = 168;
            this.lblParLimitLow.Text = "ParLimitLow";
            // 
            // txtParLimitLowLow
            // 
            this.txtParLimitLowLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParLimitLowLow.Location = new System.Drawing.Point(324, 344);
            this.txtParLimitLowLow.Name = "txtParLimitLowLow";
            this.txtParLimitLowLow.Size = new System.Drawing.Size(56, 13);
            this.txtParLimitLowLow.TabIndex = 167;
            this.txtParLimitLowLow.Text = "0";
            this.txtParLimitLowLow.MouseEnter += new System.EventHandler(this.txtParLimitLowLow_MouseEnter);
            // 
            // lblParLimitLowLow
            // 
            this.lblParLimitLowLow.AutoSize = true;
            this.lblParLimitLowLow.Location = new System.Drawing.Point(226, 343);
            this.lblParLimitLowLow.Name = "lblParLimitLowLow";
            this.lblParLimitLowLow.Size = new System.Drawing.Size(84, 13);
            this.lblParLimitLowLow.TabIndex = 166;
            this.lblParLimitLowLow.Text = "ParLimitLowLow";
            // 
            // chkParPreAlarmHighHigh
            // 
            this.chkParPreAlarmHighHigh.AutoSize = true;
            this.chkParPreAlarmHighHigh.Location = new System.Drawing.Point(386, 545);
            this.chkParPreAlarmHighHigh.Name = "chkParPreAlarmHighHigh";
            this.chkParPreAlarmHighHigh.Size = new System.Drawing.Size(112, 17);
            this.chkParPreAlarmHighHigh.TabIndex = 165;
            this.chkParPreAlarmHighHigh.Text = "PreAlarmHighHigh";
            this.chkParPreAlarmHighHigh.UseVisualStyleBackColor = true;
            this.chkParPreAlarmHighHigh.CheckedChanged += new System.EventHandler(this.chkParPreAlarmHighHigh_CheckedChanged);
            this.chkParPreAlarmHighHigh.MouseEnter += new System.EventHandler(this.chkParPreAlarmHighHigh_MouseEnter);
            // 
            // chkParPreAlarmHigh
            // 
            this.chkParPreAlarmHigh.AutoSize = true;
            this.chkParPreAlarmHigh.Location = new System.Drawing.Point(386, 526);
            this.chkParPreAlarmHigh.Name = "chkParPreAlarmHigh";
            this.chkParPreAlarmHigh.Size = new System.Drawing.Size(90, 17);
            this.chkParPreAlarmHigh.TabIndex = 164;
            this.chkParPreAlarmHigh.Text = "PreAlarmHigh";
            this.chkParPreAlarmHigh.UseVisualStyleBackColor = true;
            this.chkParPreAlarmHigh.CheckedChanged += new System.EventHandler(this.chkParPreAlarmHigh_CheckedChanged);
            this.chkParPreAlarmHigh.MouseEnter += new System.EventHandler(this.chkParPreAlarmHigh_MouseEnter);
            // 
            // chkParPreAlarmMiddle
            // 
            this.chkParPreAlarmMiddle.AutoSize = true;
            this.chkParPreAlarmMiddle.Location = new System.Drawing.Point(386, 507);
            this.chkParPreAlarmMiddle.Name = "chkParPreAlarmMiddle";
            this.chkParPreAlarmMiddle.Size = new System.Drawing.Size(99, 17);
            this.chkParPreAlarmMiddle.TabIndex = 163;
            this.chkParPreAlarmMiddle.Text = "PreAlarmMiddle";
            this.chkParPreAlarmMiddle.UseVisualStyleBackColor = true;
            this.chkParPreAlarmMiddle.CheckedChanged += new System.EventHandler(this.chkParPreAlarmMiddle_CheckedChanged);
            this.chkParPreAlarmMiddle.MouseEnter += new System.EventHandler(this.chkParPreAlarmMiddle_MouseEnter);
            // 
            // lblUnitsBy100
            // 
            this.lblUnitsBy100.AutoSize = true;
            this.lblUnitsBy100.Location = new System.Drawing.Point(1, 343);
            this.lblUnitsBy100.Name = "lblUnitsBy100";
            this.lblUnitsBy100.Size = new System.Drawing.Size(77, 13);
            this.lblUnitsBy100.TabIndex = 130;
            this.lblUnitsBy100.Text = "ParUnitsBy100";
            // 
            // chkParPreAlarmLow
            // 
            this.chkParPreAlarmLow.AutoSize = true;
            this.chkParPreAlarmLow.Location = new System.Drawing.Point(386, 488);
            this.chkParPreAlarmLow.Name = "chkParPreAlarmLow";
            this.chkParPreAlarmLow.Size = new System.Drawing.Size(88, 17);
            this.chkParPreAlarmLow.TabIndex = 162;
            this.chkParPreAlarmLow.Text = "PreAlarmLow";
            this.chkParPreAlarmLow.UseVisualStyleBackColor = true;
            this.chkParPreAlarmLow.CheckedChanged += new System.EventHandler(this.chkParPreAlarmLow_CheckedChanged);
            this.chkParPreAlarmLow.MouseEnter += new System.EventHandler(this.chkParPreAlarmLow_MouseEnter);
            // 
            // txtUnitsBy100
            // 
            this.txtUnitsBy100.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitsBy100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUnitsBy100.Location = new System.Drawing.Point(114, 343);
            this.txtUnitsBy100.Name = "txtUnitsBy100";
            this.txtUnitsBy100.Size = new System.Drawing.Size(56, 13);
            this.txtUnitsBy100.TabIndex = 131;
            this.txtUnitsBy100.Text = "100.0";
            this.txtUnitsBy100.MouseEnter += new System.EventHandler(this.txtUnitsBy100_MouseEnter);
            // 
            // chkParPreAlarmLowLow
            // 
            this.chkParPreAlarmLowLow.AutoSize = true;
            this.chkParPreAlarmLowLow.Location = new System.Drawing.Point(386, 469);
            this.chkParPreAlarmLowLow.Name = "chkParPreAlarmLowLow";
            this.chkParPreAlarmLowLow.Size = new System.Drawing.Size(108, 17);
            this.chkParPreAlarmLowLow.TabIndex = 161;
            this.chkParPreAlarmLowLow.Text = "PreAlarmLowLow";
            this.chkParPreAlarmLowLow.UseVisualStyleBackColor = true;
            this.chkParPreAlarmLowLow.CheckedChanged += new System.EventHandler(this.chkParPreAlarmLowLow_CheckedChanged);
            this.chkParPreAlarmLowLow.MouseEnter += new System.EventHandler(this.chkParPreAlarmLowLow_MouseEnter);
            // 
            // lblDelayTimeDown
            // 
            this.lblDelayTimeDown.AutoSize = true;
            this.lblDelayTimeDown.Location = new System.Drawing.Point(1, 379);
            this.lblDelayTimeDown.Name = "lblDelayTimeDown";
            this.lblDelayTimeDown.Size = new System.Drawing.Size(112, 13);
            this.lblDelayTimeDown.TabIndex = 132;
            this.lblDelayTimeDown.Text = "ParDelayTimeDown[s]";
            // 
            // chkParWarningHighHigh
            // 
            this.chkParWarningHighHigh.AutoSize = true;
            this.chkParWarningHighHigh.Location = new System.Drawing.Point(251, 544);
            this.chkParWarningHighHigh.Name = "chkParWarningHighHigh";
            this.chkParWarningHighHigh.Size = new System.Drawing.Size(126, 17);
            this.chkParWarningHighHigh.TabIndex = 160;
            this.chkParWarningHighHigh.Text = "ParWarningHighHigh";
            this.chkParWarningHighHigh.UseVisualStyleBackColor = true;
            this.chkParWarningHighHigh.CheckedChanged += new System.EventHandler(this.chkParWarningHighHigh_CheckedChanged);
            this.chkParWarningHighHigh.MouseEnter += new System.EventHandler(this.chkParWarningHighHigh_MouseEnter);
            // 
            // txtDelayTimeDown
            // 
            this.txtDelayTimeDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelayTimeDown.Location = new System.Drawing.Point(114, 379);
            this.txtDelayTimeDown.Name = "txtDelayTimeDown";
            this.txtDelayTimeDown.Size = new System.Drawing.Size(56, 13);
            this.txtDelayTimeDown.TabIndex = 133;
            this.txtDelayTimeDown.Text = "1.0";
            this.txtDelayTimeDown.MouseEnter += new System.EventHandler(this.txtDelayTimeDown_MouseEnter);
            // 
            // chkParWarningHigh
            // 
            this.chkParWarningHigh.AutoSize = true;
            this.chkParWarningHigh.Location = new System.Drawing.Point(251, 525);
            this.chkParWarningHigh.Name = "chkParWarningHigh";
            this.chkParWarningHigh.Size = new System.Drawing.Size(104, 17);
            this.chkParWarningHigh.TabIndex = 159;
            this.chkParWarningHigh.Text = "ParWarningHigh";
            this.chkParWarningHigh.UseVisualStyleBackColor = true;
            this.chkParWarningHigh.CheckedChanged += new System.EventHandler(this.chkParWarningHigh_CheckedChanged);
            this.chkParWarningHigh.MouseEnter += new System.EventHandler(this.chkParWarningHigh_MouseEnter);
            // 
            // lblDelayTimeUp
            // 
            this.lblDelayTimeUp.AutoSize = true;
            this.lblDelayTimeUp.Location = new System.Drawing.Point(1, 397);
            this.lblDelayTimeUp.Name = "lblDelayTimeUp";
            this.lblDelayTimeUp.Size = new System.Drawing.Size(82, 13);
            this.lblDelayTimeUp.TabIndex = 134;
            this.lblDelayTimeUp.Text = "DelayTimeUp[s]";
            // 
            // chkParWarningMiddle
            // 
            this.chkParWarningMiddle.AutoSize = true;
            this.chkParWarningMiddle.Location = new System.Drawing.Point(251, 506);
            this.chkParWarningMiddle.Name = "chkParWarningMiddle";
            this.chkParWarningMiddle.Size = new System.Drawing.Size(113, 17);
            this.chkParWarningMiddle.TabIndex = 158;
            this.chkParWarningMiddle.Text = "ParWarningMiddle";
            this.chkParWarningMiddle.UseVisualStyleBackColor = true;
            this.chkParWarningMiddle.CheckedChanged += new System.EventHandler(this.chkParWarningMiddle_CheckedChanged);
            this.chkParWarningMiddle.MouseEnter += new System.EventHandler(this.chkParWarningMiddle_MouseEnter);
            // 
            // txtDelayTimeUp
            // 
            this.txtDelayTimeUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelayTimeUp.Location = new System.Drawing.Point(114, 396);
            this.txtDelayTimeUp.Name = "txtDelayTimeUp";
            this.txtDelayTimeUp.Size = new System.Drawing.Size(56, 13);
            this.txtDelayTimeUp.TabIndex = 135;
            this.txtDelayTimeUp.Text = "1.0";
            this.txtDelayTimeUp.MouseEnter += new System.EventHandler(this.txtDelayTimeUp_MouseEnter);
            // 
            // chkParWarningLow
            // 
            this.chkParWarningLow.AutoSize = true;
            this.chkParWarningLow.Location = new System.Drawing.Point(251, 487);
            this.chkParWarningLow.Name = "chkParWarningLow";
            this.chkParWarningLow.Size = new System.Drawing.Size(102, 17);
            this.chkParWarningLow.TabIndex = 157;
            this.chkParWarningLow.Text = "ParWarningLow";
            this.chkParWarningLow.UseVisualStyleBackColor = true;
            this.chkParWarningLow.CheckedChanged += new System.EventHandler(this.chkParWarningLow_CheckedChanged);
            this.chkParWarningLow.MouseEnter += new System.EventHandler(this.chkParWarningLow_MouseEnter);
            // 
            // lblDelayTimeFault
            // 
            this.lblDelayTimeFault.AutoSize = true;
            this.lblDelayTimeFault.Location = new System.Drawing.Point(1, 415);
            this.lblDelayTimeFault.Name = "lblDelayTimeFault";
            this.lblDelayTimeFault.Size = new System.Drawing.Size(91, 13);
            this.lblDelayTimeFault.TabIndex = 136;
            this.lblDelayTimeFault.Text = "DelayTimeFault[s]";
            // 
            // chkParWarningLowLow
            // 
            this.chkParWarningLowLow.AutoSize = true;
            this.chkParWarningLowLow.Location = new System.Drawing.Point(251, 468);
            this.chkParWarningLowLow.Name = "chkParWarningLowLow";
            this.chkParWarningLowLow.Size = new System.Drawing.Size(122, 17);
            this.chkParWarningLowLow.TabIndex = 156;
            this.chkParWarningLowLow.Text = "ParWarningLowLow";
            this.chkParWarningLowLow.UseVisualStyleBackColor = true;
            this.chkParWarningLowLow.CheckedChanged += new System.EventHandler(this.chkParWarningLowLow_CheckedChanged);
            this.chkParWarningLowLow.MouseEnter += new System.EventHandler(this.chkParWarningLowLow_MouseEnter);
            // 
            // txtDelayTimeFault
            // 
            this.txtDelayTimeFault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelayTimeFault.Location = new System.Drawing.Point(114, 414);
            this.txtDelayTimeFault.Name = "txtDelayTimeFault";
            this.txtDelayTimeFault.Size = new System.Drawing.Size(56, 13);
            this.txtDelayTimeFault.TabIndex = 137;
            this.txtDelayTimeFault.Text = "1.0";
            this.txtDelayTimeFault.MouseEnter += new System.EventHandler(this.txtDelayTimeFault_MouseEnter);
            // 
            // txtMonTimeHighHigh
            // 
            this.txtMonTimeHighHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonTimeHighHigh.Location = new System.Drawing.Point(172, 547);
            this.txtMonTimeHighHigh.Name = "txtMonTimeHighHigh";
            this.txtMonTimeHighHigh.Size = new System.Drawing.Size(56, 13);
            this.txtMonTimeHighHigh.TabIndex = 155;
            this.txtMonTimeHighHigh.Text = "2.0";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(1, 436);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 138;
            this.lblUnit.Text = "Unit";
            // 
            // lblHighHighMonTime
            // 
            this.lblHighHighMonTime.AutoSize = true;
            this.lblHighHighMonTime.Location = new System.Drawing.Point(1, 548);
            this.lblHighHighMonTime.Name = "lblHighHighMonTime";
            this.lblHighHighMonTime.Size = new System.Drawing.Size(122, 13);
            this.lblHighHighMonTime.TabIndex = 154;
            this.lblHighHighMonTime.Text = "ParMonTimeHighHigh[s]";
            // 
            // chkParLogOff
            // 
            this.chkParLogOff.AutoSize = true;
            this.chkParLogOff.Location = new System.Drawing.Point(387, 301);
            this.chkParLogOff.Name = "chkParLogOff";
            this.chkParLogOff.Size = new System.Drawing.Size(74, 17);
            this.chkParLogOff.TabIndex = 139;
            this.chkParLogOff.Text = "ParLogOff";
            this.chkParLogOff.UseVisualStyleBackColor = true;
            this.chkParLogOff.CheckedChanged += new System.EventHandler(this.chkParLogOff_CheckedChanged);
            this.chkParLogOff.MouseEnter += new System.EventHandler(this.chkParLogOff_MouseEnter);
            // 
            // txtMonTimeHigh
            // 
            this.txtMonTimeHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonTimeHigh.Location = new System.Drawing.Point(172, 528);
            this.txtMonTimeHigh.Name = "txtMonTimeHigh";
            this.txtMonTimeHigh.Size = new System.Drawing.Size(56, 13);
            this.txtMonTimeHigh.TabIndex = 153;
            this.txtMonTimeHigh.Text = "1.0";
            // 
            // chkParLimitsRel
            // 
            this.chkParLimitsRel.AutoSize = true;
            this.chkParLimitsRel.Location = new System.Drawing.Point(387, 319);
            this.chkParLimitsRel.Name = "chkParLimitsRel";
            this.chkParLimitsRel.Size = new System.Drawing.Size(84, 17);
            this.chkParLimitsRel.TabIndex = 140;
            this.chkParLimitsRel.Text = "ParLimitsRel";
            this.chkParLimitsRel.UseVisualStyleBackColor = true;
            this.chkParLimitsRel.CheckedChanged += new System.EventHandler(this.chkParLimitsRel_CheckedChanged);
            this.chkParLimitsRel.MouseEnter += new System.EventHandler(this.chkParLimitsRel_MouseEnter);
            // 
            // lblHighMonTime
            // 
            this.lblHighMonTime.AutoSize = true;
            this.lblHighMonTime.Location = new System.Drawing.Point(1, 528);
            this.lblHighMonTime.Name = "lblHighMonTime";
            this.lblHighMonTime.Size = new System.Drawing.Size(100, 13);
            this.lblHighMonTime.TabIndex = 152;
            this.lblHighMonTime.Text = "ParMonTimeHigh[s]";
            // 
            // chkParNoHornByWarning
            // 
            this.chkParNoHornByWarning.AutoSize = true;
            this.chkParNoHornByWarning.Checked = true;
            this.chkParNoHornByWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkParNoHornByWarning.Location = new System.Drawing.Point(387, 338);
            this.chkParNoHornByWarning.Name = "chkParNoHornByWarning";
            this.chkParNoHornByWarning.Size = new System.Drawing.Size(131, 17);
            this.chkParNoHornByWarning.TabIndex = 141;
            this.chkParNoHornByWarning.Text = "ParNoHornByWarning";
            this.chkParNoHornByWarning.UseVisualStyleBackColor = true;
            this.chkParNoHornByWarning.CheckedChanged += new System.EventHandler(this.chkParNoHornByWarning_CheckedChanged);
            this.chkParNoHornByWarning.MouseEnter += new System.EventHandler(this.chkParNoHornByWarning_MouseEnter);
            // 
            // txtMonTimeMiddle
            // 
            this.txtMonTimeMiddle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonTimeMiddle.Location = new System.Drawing.Point(172, 509);
            this.txtMonTimeMiddle.Name = "txtMonTimeMiddle";
            this.txtMonTimeMiddle.Size = new System.Drawing.Size(56, 13);
            this.txtMonTimeMiddle.TabIndex = 151;
            this.txtMonTimeMiddle.Text = "1.0";
            // 
            // GroupBoxGroupTree
            // 
            this.GroupBoxGroupTree.Controls.Add(this.chkWinCC);
            this.GroupBoxGroupTree.Controls.Add(this.chkInDisable);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonNotMiddle);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonNotHighHigh);
            this.GroupBoxGroupTree.Controls.Add(this.lblValue9);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonNotHigh);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonNotLow);
            this.GroupBoxGroupTree.Controls.Add(this.txtValue9);
            this.GroupBoxGroupTree.Controls.Add(this.chkMonNotLowLow);
            this.GroupBoxGroupTree.Controls.Add(this.chkInterlocking);
            this.GroupBoxGroupTree.Location = new System.Drawing.Point(537, 266);
            this.GroupBoxGroupTree.Name = "GroupBoxGroupTree";
            this.GroupBoxGroupTree.Size = new System.Drawing.Size(173, 173);
            this.GroupBoxGroupTree.TabIndex = 142;
            this.GroupBoxGroupTree.TabStop = false;
            this.GroupBoxGroupTree.Text = "Gcpro";
            // 
            // chkWinCC
            // 
            this.chkWinCC.AutoSize = true;
            this.chkWinCC.Location = new System.Drawing.Point(6, 149);
            this.chkWinCC.Name = "chkWinCC";
            this.chkWinCC.Size = new System.Drawing.Size(140, 17);
            this.chkWinCC.TabIndex = 67;
            this.chkWinCC.Text = "WinCC:Negative Values";
            this.chkWinCC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkWinCC.UseVisualStyleBackColor = true;
            this.chkWinCC.CheckedChanged += new System.EventHandler(this.chkWinCC_CheckedChanged);
            this.chkWinCC.MouseEnter += new System.EventHandler(this.chkWinCC_MouseEnter);
            // 
            // chkInDisable
            // 
            this.chkInDisable.AutoSize = true;
            this.chkInDisable.Location = new System.Drawing.Point(6, 131);
            this.chkInDisable.Name = "chkInDisable";
            this.chkInDisable.Size = new System.Drawing.Size(105, 17);
            this.chkInDisable.TabIndex = 66;
            this.chkInDisable.Text = "InDisable:=Local";
            this.chkInDisable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkInDisable.UseVisualStyleBackColor = true;
            this.chkInDisable.CheckedChanged += new System.EventHandler(this.chkInDisable_CheckedChanged);
            this.chkInDisable.MouseEnter += new System.EventHandler(this.chkInDisable_MouseEnter);
            // 
            // chkMonNotMiddle
            // 
            this.chkMonNotMiddle.AutoSize = true;
            this.chkMonNotMiddle.Location = new System.Drawing.Point(6, 73);
            this.chkMonNotMiddle.Name = "chkMonNotMiddle";
            this.chkMonNotMiddle.Size = new System.Drawing.Size(123, 17);
            this.chkMonNotMiddle.TabIndex = 65;
            this.chkMonNotMiddle.Text = "Set InMonNotMiddle";
            this.chkMonNotMiddle.UseVisualStyleBackColor = true;
            this.chkMonNotMiddle.CheckedChanged += new System.EventHandler(this.chkMonNotMiddle_CheckedChanged);
            this.chkMonNotMiddle.MouseEnter += new System.EventHandler(this.chkMonNotMiddle_MouseEnter);
            // 
            // chkMonNotHighHigh
            // 
            this.chkMonNotHighHigh.AutoSize = true;
            this.chkMonNotHighHigh.Checked = true;
            this.chkMonNotHighHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonNotHighHigh.Location = new System.Drawing.Point(6, 112);
            this.chkMonNotHighHigh.Name = "chkMonNotHighHigh";
            this.chkMonNotHighHigh.Size = new System.Drawing.Size(136, 17);
            this.chkMonNotHighHigh.TabIndex = 64;
            this.chkMonNotHighHigh.Text = "Set InMonNotHighHigh";
            this.chkMonNotHighHigh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkMonNotHighHigh.UseVisualStyleBackColor = true;
            this.chkMonNotHighHigh.CheckedChanged += new System.EventHandler(this.chkMonNotHighHigh_CheckedChanged);
            this.chkMonNotHighHigh.MouseEnter += new System.EventHandler(this.chkMonNotHighHigh_MouseEnter);
            // 
            // lblValue9
            // 
            this.lblValue9.AutoSize = true;
            this.lblValue9.Location = new System.Drawing.Point(129, 59);
            this.lblValue9.Name = "lblValue9";
            this.lblValue9.Size = new System.Drawing.Size(40, 13);
            this.lblValue9.TabIndex = 61;
            this.lblValue9.Text = "Value9";
            // 
            // chkMonNotHigh
            // 
            this.chkMonNotHigh.AutoSize = true;
            this.chkMonNotHigh.Location = new System.Drawing.Point(6, 93);
            this.chkMonNotHigh.Name = "chkMonNotHigh";
            this.chkMonNotHigh.Size = new System.Drawing.Size(114, 17);
            this.chkMonNotHigh.TabIndex = 63;
            this.chkMonNotHigh.Text = "Set InMonNotHigh";
            this.chkMonNotHigh.UseVisualStyleBackColor = true;
            this.chkMonNotHigh.CheckedChanged += new System.EventHandler(this.chkMonNotHigh_CheckedChanged);
            this.chkMonNotHigh.MouseEnter += new System.EventHandler(this.chkMonNotHigh_MouseEnter);
            // 
            // chkMonNotLow
            // 
            this.chkMonNotLow.AutoSize = true;
            this.chkMonNotLow.Location = new System.Drawing.Point(6, 54);
            this.chkMonNotLow.Name = "chkMonNotLow";
            this.chkMonNotLow.Size = new System.Drawing.Size(112, 17);
            this.chkMonNotLow.TabIndex = 62;
            this.chkMonNotLow.Text = "Set InMonNotLow";
            this.chkMonNotLow.UseVisualStyleBackColor = true;
            this.chkMonNotLow.CheckedChanged += new System.EventHandler(this.chkMonNotLow_CheckedChanged);
            this.chkMonNotLow.MouseEnter += new System.EventHandler(this.chkMonNotLow_MouseEnter);
            // 
            // txtValue9
            // 
            this.txtValue9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue9.Location = new System.Drawing.Point(131, 78);
            this.txtValue9.Name = "txtValue9";
            this.txtValue9.Size = new System.Drawing.Size(36, 13);
            this.txtValue9.TabIndex = 60;
            // 
            // chkMonNotLowLow
            // 
            this.chkMonNotLowLow.AutoSize = true;
            this.chkMonNotLowLow.Location = new System.Drawing.Point(6, 35);
            this.chkMonNotLowLow.Name = "chkMonNotLowLow";
            this.chkMonNotLowLow.Size = new System.Drawing.Size(132, 17);
            this.chkMonNotLowLow.TabIndex = 42;
            this.chkMonNotLowLow.Text = "Set InMonNotLowLow";
            this.chkMonNotLowLow.UseVisualStyleBackColor = true;
            this.chkMonNotLowLow.CheckedChanged += new System.EventHandler(this.chkMonNotLowLow_CheckedChanged);
            this.chkMonNotLowLow.MouseEnter += new System.EventHandler(this.chkMonNotLowLow_MouseEnter);
            // 
            // chkInterlocking
            // 
            this.chkInterlocking.AutoSize = true;
            this.chkInterlocking.Location = new System.Drawing.Point(6, 15);
            this.chkInterlocking.Name = "chkInterlocking";
            this.chkInterlocking.Size = new System.Drawing.Size(81, 17);
            this.chkInterlocking.TabIndex = 41;
            this.chkInterlocking.Text = "Interlocking";
            this.chkInterlocking.UseVisualStyleBackColor = true;
            this.chkInterlocking.CheckedChanged += new System.EventHandler(this.chkInterlocking_CheckedChanged);
            this.chkInterlocking.MouseEnter += new System.EventHandler(this.chkInterlocking_MouseEnter);
            // 
            // lblMiddleMonTime
            // 
            this.lblMiddleMonTime.AutoSize = true;
            this.lblMiddleMonTime.Location = new System.Drawing.Point(1, 508);
            this.lblMiddleMonTime.Name = "lblMiddleMonTime";
            this.lblMiddleMonTime.Size = new System.Drawing.Size(109, 13);
            this.lblMiddleMonTime.TabIndex = 150;
            this.lblMiddleMonTime.Text = "ParMonTimeMiddle[s]";
            // 
            // txtValue10
            // 
            this.txtValue10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue10.Location = new System.Drawing.Point(490, 322);
            this.txtValue10.Name = "txtValue10";
            this.txtValue10.Size = new System.Drawing.Size(36, 13);
            this.txtValue10.TabIndex = 143;
            this.txtValue10.Text = "0";
            // 
            // txtMonTimeLow
            // 
            this.txtMonTimeLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonTimeLow.Location = new System.Drawing.Point(172, 490);
            this.txtMonTimeLow.Name = "txtMonTimeLow";
            this.txtMonTimeLow.Size = new System.Drawing.Size(56, 13);
            this.txtMonTimeLow.TabIndex = 149;
            this.txtMonTimeLow.Text = "1.0";
            // 
            // lblValue10
            // 
            this.lblValue10.AutoSize = true;
            this.lblValue10.Location = new System.Drawing.Point(486, 302);
            this.lblValue10.Name = "lblValue10";
            this.lblValue10.Size = new System.Drawing.Size(46, 13);
            this.lblValue10.TabIndex = 144;
            this.lblValue10.Text = "Value10";
            // 
            // lblLowMonTime
            // 
            this.lblLowMonTime.AutoSize = true;
            this.lblLowMonTime.Location = new System.Drawing.Point(1, 488);
            this.lblLowMonTime.Name = "lblLowMonTime";
            this.lblLowMonTime.Size = new System.Drawing.Size(98, 13);
            this.lblLowMonTime.TabIndex = 148;
            this.lblLowMonTime.Text = "ParMonTimeLow[s]";
            // 
            // txtMonTimeLowLow
            // 
            this.txtMonTimeLowLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonTimeLowLow.Location = new System.Drawing.Point(172, 471);
            this.txtMonTimeLowLow.Name = "txtMonTimeLowLow";
            this.txtMonTimeLowLow.Size = new System.Drawing.Size(56, 13);
            this.txtMonTimeLowLow.TabIndex = 147;
            this.txtMonTimeLowLow.Text = "1.0";
            // 
            // lblLowLowMonTime
            // 
            this.lblLowLowMonTime.AutoSize = true;
            this.lblLowLowMonTime.Location = new System.Drawing.Point(1, 468);
            this.lblLowLowMonTime.Name = "lblLowLowMonTime";
            this.lblLowLowMonTime.Size = new System.Drawing.Size(118, 13);
            this.lblLowLowMonTime.TabIndex = 146;
            this.lblLowLowMonTime.Text = "ParMonTimeLowLow[s]";
            // 
            // comboUnit
            // 
            this.comboUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboUnit.FormattingEnabled = true;
            this.comboUnit.IntegralHeight = false;
            this.comboUnit.Location = new System.Drawing.Point(114, 433);
            this.comboUnit.Name = "comboUnit";
            this.comboUnit.Size = new System.Drawing.Size(117, 21);
            this.comboUnit.TabIndex = 145;
            this.comboUnit.MouseEnter += new System.EventHandler(this.comboUnit_MouseEnter);
            // 
            // chkOnlyFree
            // 
            this.chkOnlyFree.AutoSize = true;
            this.chkOnlyFree.Checked = true;
            this.chkOnlyFree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyFree.Location = new System.Drawing.Point(133, 230);
            this.chkOnlyFree.Name = "chkOnlyFree";
            this.chkOnlyFree.Size = new System.Drawing.Size(110, 17);
            this.chkOnlyFree.TabIndex = 62;
            this.chkOnlyFree.Text = "仅关联丢失连接";
            this.chkOnlyFree.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.txtSuffixInpHighHigh);
            this.grpGeneral.Controls.Add(this.txtSuffixInpHigh);
            this.grpGeneral.Controls.Add(this.txtSuffixInpLow);
            this.grpGeneral.Controls.Add(this.txtInpHighHigh);
            this.grpGeneral.Controls.Add(this.lblInpHighHigh);
            this.grpGeneral.Controls.Add(this.txtInpHigh);
            this.grpGeneral.Controls.Add(this.lblInpHigh);
            this.grpGeneral.Controls.Add(this.txtInpLow);
            this.grpGeneral.Controls.Add(this.lblInpLow);
            this.grpGeneral.Controls.Add(this.txtInpLowLow);
            this.grpGeneral.Controls.Add(this.lblInpLowLow);
            this.grpGeneral.Controls.Add(this.txtSuffixInpLowLow);
            this.grpGeneral.Controls.Add(this.lblSuffixInpDigital);
            this.grpGeneral.Controls.Add(this.grpAddInfoToDesc);
            this.grpGeneral.Controls.Add(this.lblInHWStop);
            this.grpGeneral.Controls.Add(this.txtInHWStop);
            this.grpGeneral.Controls.Add(this.lblInpFaultDev);
            this.grpGeneral.Controls.Add(this.lblInpFaultDevSuffix);
            this.grpGeneral.Controls.Add(this.txtInpFaultDev);
            this.grpGeneral.Controls.Add(this.txtInpFaultDevSuffix);
            this.grpGeneral.Controls.Add(this.lblSymbol);
            this.grpGeneral.Controls.Add(this.grpDescriptionRule);
            this.grpGeneral.Controls.Add(this.txtInpValue);
            this.grpGeneral.Controls.Add(this.GrpSymbolRule);
            this.grpGeneral.Controls.Add(this.LblInpValue);
            this.grpGeneral.Controls.Add(this.txtDescription);
            this.grpGeneral.Controls.Add(this.txtSymbol);
            this.grpGeneral.Controls.Add(this.lblDescription);
            this.grpGeneral.Controls.Add(this.txtInpValeSuffix);
            this.grpGeneral.Controls.Add(this.lblInpTrueSuffix);
            this.grpGeneral.Location = new System.Drawing.Point(6, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(703, 216);
            this.grpGeneral.TabIndex = 118;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "常规";
            // 
            // txtSuffixInpHighHigh
            // 
            this.txtSuffixInpHighHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuffixInpHighHigh.Location = new System.Drawing.Point(441, 137);
            this.txtSuffixInpHighHigh.Name = "txtSuffixInpHighHigh";
            this.txtSuffixInpHighHigh.Size = new System.Drawing.Size(36, 13);
            this.txtSuffixInpHighHigh.TabIndex = 135;
            this.txtSuffixInpHighHigh.Text = ":I";
            this.txtSuffixInpHighHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSuffixInpHighHigh.TextChanged += new System.EventHandler(this.txtSuffixInpHighHigh_TextChanged);
            this.txtSuffixInpHighHigh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuffixInpHighHigh_KeyDown);
            // 
            // txtSuffixInpHigh
            // 
            this.txtSuffixInpHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuffixInpHigh.Location = new System.Drawing.Point(441, 118);
            this.txtSuffixInpHigh.Name = "txtSuffixInpHigh";
            this.txtSuffixInpHigh.Size = new System.Drawing.Size(36, 13);
            this.txtSuffixInpHigh.TabIndex = 134;
            this.txtSuffixInpHigh.Text = ":I";
            this.txtSuffixInpHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSuffixInpHigh.TextChanged += new System.EventHandler(this.txtSuffixInpHigh_TextChanged);
            this.txtSuffixInpHigh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuffixInpHigh_KeyDown);
            // 
            // txtSuffixInpLow
            // 
            this.txtSuffixInpLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuffixInpLow.Location = new System.Drawing.Point(441, 99);
            this.txtSuffixInpLow.Name = "txtSuffixInpLow";
            this.txtSuffixInpLow.Size = new System.Drawing.Size(36, 13);
            this.txtSuffixInpLow.TabIndex = 133;
            this.txtSuffixInpLow.Text = ":I";
            this.txtSuffixInpLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSuffixInpLow.TextChanged += new System.EventHandler(this.txtSuffixInpLow_TextChanged);
            this.txtSuffixInpLow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuffixInpLow_KeyDown);
            // 
            // txtInpHighHigh
            // 
            this.txtInpHighHigh.BackColor = System.Drawing.Color.LightGray;
            this.txtInpHighHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpHighHigh.Enabled = false;
            this.txtInpHighHigh.Location = new System.Drawing.Point(318, 137);
            this.txtInpHighHigh.Name = "txtInpHighHigh";
            this.txtInpHighHigh.Size = new System.Drawing.Size(100, 13);
            this.txtInpHighHigh.TabIndex = 132;
            this.txtInpHighHigh.MouseEnter += new System.EventHandler(this.txtInpHighHigh_MouseEnter);
            // 
            // lblInpHighHigh
            // 
            this.lblInpHighHigh.AutoSize = true;
            this.lblInpHighHigh.Location = new System.Drawing.Point(239, 137);
            this.lblInpHighHigh.Name = "lblInpHighHigh";
            this.lblInpHighHigh.Size = new System.Drawing.Size(66, 13);
            this.lblInpHighHigh.TabIndex = 131;
            this.lblInpHighHigh.Text = "InpHighHigh";
            // 
            // txtInpHigh
            // 
            this.txtInpHigh.BackColor = System.Drawing.Color.LightGray;
            this.txtInpHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpHigh.Enabled = false;
            this.txtInpHigh.Location = new System.Drawing.Point(318, 118);
            this.txtInpHigh.Name = "txtInpHigh";
            this.txtInpHigh.Size = new System.Drawing.Size(100, 13);
            this.txtInpHigh.TabIndex = 130;
            this.txtInpHigh.MouseEnter += new System.EventHandler(this.txtInpHigh_MouseEnter);
            // 
            // lblInpHigh
            // 
            this.lblInpHigh.AutoSize = true;
            this.lblInpHigh.Location = new System.Drawing.Point(239, 118);
            this.lblInpHigh.Name = "lblInpHigh";
            this.lblInpHigh.Size = new System.Drawing.Size(44, 13);
            this.lblInpHigh.TabIndex = 129;
            this.lblInpHigh.Text = "InpHigh";
            // 
            // txtInpLow
            // 
            this.txtInpLow.BackColor = System.Drawing.Color.LightGray;
            this.txtInpLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpLow.Enabled = false;
            this.txtInpLow.Location = new System.Drawing.Point(318, 99);
            this.txtInpLow.Name = "txtInpLow";
            this.txtInpLow.Size = new System.Drawing.Size(100, 13);
            this.txtInpLow.TabIndex = 128;
            this.txtInpLow.MouseEnter += new System.EventHandler(this.txtInpLow_MouseEnter);
            // 
            // lblInpLow
            // 
            this.lblInpLow.AutoSize = true;
            this.lblInpLow.Location = new System.Drawing.Point(239, 99);
            this.lblInpLow.Name = "lblInpLow";
            this.lblInpLow.Size = new System.Drawing.Size(42, 13);
            this.lblInpLow.TabIndex = 127;
            this.lblInpLow.Text = "InpLow";
            // 
            // txtInpLowLow
            // 
            this.txtInpLowLow.BackColor = System.Drawing.Color.LightGray;
            this.txtInpLowLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpLowLow.Enabled = false;
            this.txtInpLowLow.Location = new System.Drawing.Point(318, 79);
            this.txtInpLowLow.Name = "txtInpLowLow";
            this.txtInpLowLow.Size = new System.Drawing.Size(100, 13);
            this.txtInpLowLow.TabIndex = 124;
            this.txtInpLowLow.MouseEnter += new System.EventHandler(this.txtInpLowLow_MouseEnter);
            // 
            // lblInpLowLow
            // 
            this.lblInpLowLow.AutoSize = true;
            this.lblInpLowLow.Location = new System.Drawing.Point(239, 79);
            this.lblInpLowLow.Name = "lblInpLowLow";
            this.lblInpLowLow.Size = new System.Drawing.Size(62, 13);
            this.lblInpLowLow.TabIndex = 123;
            this.lblInpLowLow.Text = "InpLowLow";
            // 
            // txtSuffixInpLowLow
            // 
            this.txtSuffixInpLowLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuffixInpLowLow.Location = new System.Drawing.Point(441, 79);
            this.txtSuffixInpLowLow.Name = "txtSuffixInpLowLow";
            this.txtSuffixInpLowLow.Size = new System.Drawing.Size(36, 13);
            this.txtSuffixInpLowLow.TabIndex = 125;
            this.txtSuffixInpLowLow.Text = ":I";
            this.txtSuffixInpLowLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSuffixInpLowLow.TextChanged += new System.EventHandler(this.txtSuffixInpLowLow_TextChanged);
            this.txtSuffixInpLowLow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuffixInpLowLow_KeyDown);
            // 
            // lblSuffixInpDigital
            // 
            this.lblSuffixInpDigital.AutoSize = true;
            this.lblSuffixInpDigital.Location = new System.Drawing.Point(444, 59);
            this.lblSuffixInpDigital.Name = "lblSuffixInpDigital";
            this.lblSuffixInpDigital.Size = new System.Drawing.Size(31, 13);
            this.lblSuffixInpDigital.TabIndex = 126;
            this.lblSuffixInpDigital.Text = "后缀";
            // 
            // grpAddInfoToDesc
            // 
            this.grpAddInfoToDesc.Controls.Add(this.chkAddUserSectionToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkNameOnlyNumber);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddSectionToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddFloorToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddNameToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddCabinetToDesc);
            this.grpAddInfoToDesc.Location = new System.Drawing.Point(9, 170);
            this.grpAddInfoToDesc.Name = "grpAddInfoToDesc";
            this.grpAddInfoToDesc.Size = new System.Drawing.Size(530, 39);
            this.grpAddInfoToDesc.TabIndex = 122;
            this.grpAddInfoToDesc.TabStop = false;
            this.grpAddInfoToDesc.Text = "附加信息到描述";
            // 
            // chkNameOnlyNumber
            // 
            this.chkNameOnlyNumber.AutoSize = true;
            this.chkNameOnlyNumber.Checked = true;
            this.chkNameOnlyNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNameOnlyNumber.Location = new System.Drawing.Point(423, 17);
            this.chkNameOnlyNumber.Name = "chkNameOnlyNumber";
            this.chkNameOnlyNumber.Size = new System.Drawing.Size(98, 17);
            this.chkNameOnlyNumber.TabIndex = 176;
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
            // lblInHWStop
            // 
            this.lblInHWStop.AutoSize = true;
            this.lblInHWStop.Location = new System.Drawing.Point(5, 134);
            this.lblInHWStop.Name = "lblInHWStop";
            this.lblInHWStop.Size = new System.Drawing.Size(63, 13);
            this.lblInHWStop.TabIndex = 116;
            this.lblInHWStop.Text = "[InHWStop]";
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
            this.txtInHWStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtInHWStop_MouseDown);
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
            this.txtInpFaultDev.MouseEnter += new System.EventHandler(this.txtInpFaultDev_MouseEnter);
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
            this.txtInpFaultDevSuffix.TextChanged += new System.EventHandler(this.txtInpFaultDevSuffix_TextChanged);
            this.txtInpFaultDevSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInpFaultDevSuffix_KeyDown);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(6, 16);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(31, 13);
            this.lblSymbol.TabIndex = 0;
            this.lblSymbol.Text = "名称";
            // 
            // grpDescriptionRule
            // 
            this.grpDescriptionRule.Controls.Add(this.lblDescriptionRule);
            this.grpDescriptionRule.Controls.Add(this.txtDescriptionIncRule);
            this.grpDescriptionRule.Controls.Add(this.lblDescriptionIncRule);
            this.grpDescriptionRule.Controls.Add(this.txtDescriptionRule);
            this.grpDescriptionRule.Location = new System.Drawing.Point(603, 16);
            this.grpDescriptionRule.Name = "grpDescriptionRule";
            this.grpDescriptionRule.Size = new System.Drawing.Size(78, 88);
            this.grpDescriptionRule.TabIndex = 74;
            this.grpDescriptionRule.TabStop = false;
            this.grpDescriptionRule.Text = "描述规则";
            // 
            // lblDescriptionRule
            // 
            this.lblDescriptionRule.AutoSize = true;
            this.lblDescriptionRule.Location = new System.Drawing.Point(7, 14);
            this.lblDescriptionRule.Name = "lblDescriptionRule";
            this.lblDescriptionRule.Size = new System.Drawing.Size(55, 13);
            this.lblDescriptionRule.TabIndex = 9;
            this.lblDescriptionRule.Text = "规则字段";
            // 
            // txtDescriptionIncRule
            // 
            this.txtDescriptionIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescriptionIncRule.Location = new System.Drawing.Point(6, 67);
            this.txtDescriptionIncRule.Name = "txtDescriptionIncRule";
            this.txtDescriptionIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtDescriptionIncRule.TabIndex = 72;
            this.txtDescriptionIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescriptionIncRule_KeyDown);
            // 
            // lblDescriptionIncRule
            // 
            this.lblDescriptionIncRule.AutoSize = true;
            this.lblDescriptionIncRule.Location = new System.Drawing.Point(6, 50);
            this.lblDescriptionIncRule.Name = "lblDescriptionIncRule";
            this.lblDescriptionIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblDescriptionIncRule.TabIndex = 73;
            this.lblDescriptionIncRule.Text = "递增规则";
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
            // txtInpValue
            // 
            this.txtInpValue.BackColor = System.Drawing.Color.LightGray;
            this.txtInpValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpValue.Enabled = false;
            this.txtInpValue.Location = new System.Drawing.Point(8, 79);
            this.txtInpValue.Name = "txtInpValue";
            this.txtInpValue.Size = new System.Drawing.Size(100, 13);
            this.txtInpValue.TabIndex = 6;
            this.txtInpValue.MouseEnter += new System.EventHandler(this.txtInpValue_MouseEnter);
            // 
            // GrpSymbolRule
            // 
            this.GrpSymbolRule.Controls.Add(this.lblSymbolRule);
            this.GrpSymbolRule.Controls.Add(this.txtSymbolRule);
            this.GrpSymbolRule.Controls.Add(this.txtSymbolIncRule);
            this.GrpSymbolRule.Controls.Add(this.lblSymbolIncRule);
            this.GrpSymbolRule.Location = new System.Drawing.Point(151, 16);
            this.GrpSymbolRule.Name = "GrpSymbolRule";
            this.GrpSymbolRule.Size = new System.Drawing.Size(78, 88);
            this.GrpSymbolRule.TabIndex = 75;
            this.GrpSymbolRule.TabStop = false;
            this.GrpSymbolRule.Text = "名称规则";
            // 
            // lblSymbolRule
            // 
            this.lblSymbolRule.AutoSize = true;
            this.lblSymbolRule.Location = new System.Drawing.Point(8, 14);
            this.lblSymbolRule.Name = "lblSymbolRule";
            this.lblSymbolRule.Size = new System.Drawing.Size(55, 13);
            this.lblSymbolRule.TabIndex = 8;
            this.lblSymbolRule.Text = "规则字段";
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
            this.txtSymbolIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSymbolIncRule_KeyDown);
            // 
            // lblSymbolIncRule
            // 
            this.lblSymbolIncRule.AutoSize = true;
            this.lblSymbolIncRule.Location = new System.Drawing.Point(4, 50);
            this.lblSymbolIncRule.Name = "lblSymbolIncRule";
            this.lblSymbolIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblSymbolIncRule.TabIndex = 70;
            this.lblSymbolIncRule.Text = "递增规则";
            // 
            // LblInpValue
            // 
            this.LblInpValue.AutoSize = true;
            this.LblInpValue.Location = new System.Drawing.Point(5, 59);
            this.LblInpValue.Name = "LblInpValue";
            this.LblInpValue.Size = new System.Drawing.Size(65, 13);
            this.LblInpValue.TabIndex = 4;
            this.LblInpValue.Text = "InpValue(AI)";
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
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(242, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "描述";
            // 
            // txtInpValeSuffix
            // 
            this.txtInpValeSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInpValeSuffix.Location = new System.Drawing.Point(111, 79);
            this.txtInpValeSuffix.Name = "txtInpValeSuffix";
            this.txtInpValeSuffix.Size = new System.Drawing.Size(36, 13);
            this.txtInpValeSuffix.TabIndex = 86;
            this.txtInpValeSuffix.Text = ":AI";
            this.txtInpValeSuffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInpValeSuffix.TextChanged += new System.EventHandler(this.txtInpTrueSuffix_TextChanged);
            this.txtInpValeSuffix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInpValueSuffix_KeyDown);
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
            // BtnRegenerateDPNode
            // 
            this.BtnRegenerateDPNode.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegenerateDPNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegenerateDPNode.BackgroundImage")));
            this.BtnRegenerateDPNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRegenerateDPNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegenerateDPNode.Location = new System.Drawing.Point(48, 222);
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
            this.BtnNewImpExpDef.Location = new System.Drawing.Point(6, 222);
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
            this.LblEquipmentInfoType.Location = new System.Drawing.Point(2, 269);
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
            this.ComboEquipmentInfoType.Location = new System.Drawing.Point(112, 266);
            this.ComboEquipmentInfoType.Name = "ComboEquipmentInfoType";
            this.ComboEquipmentInfoType.Size = new System.Drawing.Size(357, 21);
            this.ComboEquipmentInfoType.TabIndex = 13;
            this.ComboEquipmentInfoType.MouseEnter += new System.EventHandler(this.ComboEquipmentInfoType_MouseEnter);
            // 
            // LblHornCode
            // 
            this.LblHornCode.AutoSize = true;
            this.LblHornCode.Location = new System.Drawing.Point(2, 294);
            this.LblHornCode.Name = "LblHornCode";
            this.LblHornCode.Size = new System.Drawing.Size(71, 13);
            this.LblHornCode.TabIndex = 14;
            this.LblHornCode.Text = "ParHornCode";
            // 
            // ComboHornCode
            // 
            this.ComboHornCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHornCode.FormattingEnabled = true;
            this.ComboHornCode.Location = new System.Drawing.Point(112, 290);
            this.ComboHornCode.Name = "ComboHornCode";
            this.ComboHornCode.Size = new System.Drawing.Size(146, 21);
            this.ComboHornCode.TabIndex = 15;
            this.ComboHornCode.MouseEnter += new System.EventHandler(this.ComboHornCode_MouseEnter);
            // 
            // LblDPNode1
            // 
            this.LblDPNode1.AutoSize = true;
            this.LblDPNode1.Location = new System.Drawing.Point(2, 319);
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
            this.BtnConnectIO.Location = new System.Drawing.Point(90, 222);
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
            this.ComboDPNode1.Location = new System.Drawing.Point(112, 313);
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
            this.tabBML.Size = new System.Drawing.Size(723, 580);
            this.tabBML.TabIndex = 1;
            this.tabBML.Text = "通过BML创建";
            // 
            // grpBoxExcelData
            // 
            this.grpBoxExcelData.Controls.Add(this.chkUpdateUnitsByMaxDigits);
            this.grpBoxExcelData.Controls.Add(this.btnReadBML);
            this.grpBoxExcelData.Controls.Add(this.dataGridBML);
            this.grpBoxExcelData.Controls.Add(this.lblWorkSheet);
            this.grpBoxExcelData.Controls.Add(this.comboWorkSheetsBML);
            this.grpBoxExcelData.Location = new System.Drawing.Point(5, 132);
            this.grpBoxExcelData.Name = "grpBoxExcelData";
            this.grpBoxExcelData.Size = new System.Drawing.Size(711, 445);
            this.grpBoxExcelData.TabIndex = 16;
            this.grpBoxExcelData.TabStop = false;
            this.grpBoxExcelData.Text = "BML数据";
            // 
            // chkUpdateUnitsByMaxDigits
            // 
            this.chkUpdateUnitsByMaxDigits.AutoSize = true;
            this.chkUpdateUnitsByMaxDigits.Checked = true;
            this.chkUpdateUnitsByMaxDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdateUnitsByMaxDigits.Location = new System.Drawing.Point(422, 26);
            this.chkUpdateUnitsByMaxDigits.Name = "chkUpdateUnitsByMaxDigits";
            this.chkUpdateUnitsByMaxDigits.Size = new System.Drawing.Size(154, 17);
            this.chkUpdateUnitsByMaxDigits.TabIndex = 177;
            this.chkUpdateUnitsByMaxDigits.Text = "更新[ParUnitsByMaxDigits]";
            this.chkUpdateUnitsByMaxDigits.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataGridBML.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridBML.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBML.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.Location = new System.Drawing.Point(6, 51);
            this.dataGridBML.Name = "dataGridBML";
            this.dataGridBML.Size = new System.Drawing.Size(701, 388);
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
            this.grpBoxExcelColumn.Size = new System.Drawing.Size(709, 115);
            this.grpBoxExcelColumn.TabIndex = 0;
            this.grpBoxExcelColumn.TabStop = false;
            this.grpBoxExcelColumn.Text = "BML清单信息";
            // 
            // grpBoxBMLColum
            // 
            this.grpBoxBMLColum.Controls.Add(this.comboPowerBML);
            this.grpBoxBMLColum.Controls.Add(this.lblPower);
            this.grpBoxBMLColum.Controls.Add(this.comboLineBML);
            this.grpBoxBMLColum.Controls.Add(this.lblLineBML);
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
            // comboPowerBML
            // 
            this.comboPowerBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPowerBML.FormattingEnabled = true;
            this.comboPowerBML.IntegralHeight = false;
            this.comboPowerBML.Location = new System.Drawing.Point(206, 42);
            this.comboPowerBML.Name = "comboPowerBML";
            this.comboPowerBML.Size = new System.Drawing.Size(66, 21);
            this.comboPowerBML.TabIndex = 35;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(157, 47);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(43, 13);
            this.lblPower.TabIndex = 34;
            this.lblPower.Text = "功率：";
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
            this.ComboPanel.SelectedIndexChanged += new System.EventHandler(this.ComboPanel_SelectedIndexChanged_1);
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
            this.PalCommon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PalCommon.Location = new System.Drawing.Point(7, 609);
            this.PalCommon.Name = "PalCommon";
            this.PalCommon.Size = new System.Drawing.Size(703, 184);
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
            // chkAddUserSectionToDesc
            // 
            this.chkAddUserSectionToDesc.AutoSize = true;
            this.chkAddUserSectionToDesc.Location = new System.Drawing.Point(83, 17);
            this.chkAddUserSectionToDesc.Name = "chkAddUserSectionToDesc";
            this.chkAddUserSectionToDesc.Size = new System.Drawing.Size(86, 17);
            this.chkAddUserSectionToDesc.TabIndex = 177;
            this.chkAddUserSectionToDesc.Text = "自定义工段";
            this.chkAddUserSectionToDesc.UseVisualStyleBackColor = true;
            this.chkAddUserSectionToDesc.CheckedChanged += new System.EventHandler(this.chkAddUserSectionToDesc_CheckedChanged);
            // 
            // FormAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(731, 818);
            this.Controls.Add(this.PalCommon);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabCreateMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAI";
            this.Text = "EL_AI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAI_FormClosed);
            this.Load += new System.EventHandler(this.FormAI_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCreateMode.ResumeLayout(false);
            this.contextMenuStripBML.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.tabRule.PerformLayout();
            this.PalGcObject.ResumeLayout(false);
            this.PalGcObject.PerformLayout();
            this.grpWinCOS.ResumeLayout(false);
            this.grpWinCOS.PerformLayout();
            this.GroupBoxGroupTree.ResumeLayout(false);
            this.GroupBoxGroupTree.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpAddInfoToDesc.ResumeLayout(false);
            this.grpAddInfoToDesc.PerformLayout();
            this.grpDescriptionRule.ResumeLayout(false);
            this.grpDescriptionRule.PerformLayout();
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
        internal System.Windows.Forms.Label lblSymbol;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.Button BtnNewImpExpDef;
        internal System.Windows.Forms.TextBox txtSymbol;
        internal System.Windows.Forms.Button BtnConnectIO;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label LblInpValue;
        internal System.Windows.Forms.GroupBox GrpSymbolRule;
        internal System.Windows.Forms.Label lblSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolIncRule;
        internal System.Windows.Forms.Label lblSymbolIncRule;
        internal System.Windows.Forms.TextBox txtInpValue;
        internal System.Windows.Forms.GroupBox grpDescriptionRule;
        internal System.Windows.Forms.Label lblDescriptionRule;
        internal System.Windows.Forms.TextBox txtDescriptionIncRule;
        internal System.Windows.Forms.Label lblDescriptionIncRule;
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
        internal System.Windows.Forms.Label lblInpTrueSuffix;
        internal System.Windows.Forms.TextBox txtInpValeSuffix;
        private System.Windows.Forms.GroupBox grpGeneral;
        internal System.Windows.Forms.CheckBox chkOnlyFree;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        internal System.Windows.Forms.ComboBox ComboDPNode1;
        internal System.Windows.Forms.Label lblInHWStop;
        internal System.Windows.Forms.TextBox txtInHWStop;
        internal System.Windows.Forms.Label lblInpFaultDev;
        internal System.Windows.Forms.Label lblInpFaultDevSuffix;
        internal System.Windows.Forms.TextBox txtInpFaultDev;
        internal System.Windows.Forms.TextBox txtInpFaultDevSuffix;
        private System.Windows.Forms.GroupBox grpAddInfoToDesc;
        internal System.Windows.Forms.CheckBox chkAddSectionToDesc;
        internal System.Windows.Forms.CheckBox chkAddFloorToDesc;
        internal System.Windows.Forms.CheckBox chkAddNameToDesc;
        internal System.Windows.Forms.CheckBox chkAddCabinetToDesc;
        internal System.Windows.Forms.ComboBox comboLineBML;
        private System.Windows.Forms.Label lblLineBML;
        internal System.Windows.Forms.TextBox txtParLimitHighHigh;
        internal System.Windows.Forms.Label lblParLimitHighHigh;
        internal System.Windows.Forms.TextBox txtParLimitHigh;
        internal System.Windows.Forms.Label lblParLimitHigh;
        internal System.Windows.Forms.TextBox txtParLimitLow;
        internal System.Windows.Forms.Label lblParLimitLow;
        internal System.Windows.Forms.TextBox txtParLimitLowLow;
        internal System.Windows.Forms.Label lblParLimitLowLow;
        internal System.Windows.Forms.CheckBox chkParPreAlarmHighHigh;
        internal System.Windows.Forms.CheckBox chkParPreAlarmHigh;
        internal System.Windows.Forms.CheckBox chkParPreAlarmMiddle;
        internal System.Windows.Forms.Label lblUnitsBy100;
        internal System.Windows.Forms.CheckBox chkParPreAlarmLow;
        internal System.Windows.Forms.TextBox txtUnitsBy100;
        internal System.Windows.Forms.CheckBox chkParPreAlarmLowLow;
        internal System.Windows.Forms.Label lblDelayTimeDown;
        internal System.Windows.Forms.CheckBox chkParWarningHighHigh;
        internal System.Windows.Forms.TextBox txtDelayTimeDown;
        internal System.Windows.Forms.CheckBox chkParWarningHigh;
        internal System.Windows.Forms.Label lblDelayTimeUp;
        internal System.Windows.Forms.CheckBox chkParWarningMiddle;
        internal System.Windows.Forms.TextBox txtDelayTimeUp;
        internal System.Windows.Forms.CheckBox chkParWarningLow;
        internal System.Windows.Forms.Label lblDelayTimeFault;
        internal System.Windows.Forms.CheckBox chkParWarningLowLow;
        internal System.Windows.Forms.TextBox txtDelayTimeFault;
        internal System.Windows.Forms.TextBox txtMonTimeHighHigh;
        internal System.Windows.Forms.Label lblUnit;
        internal System.Windows.Forms.Label lblHighHighMonTime;
        internal System.Windows.Forms.CheckBox chkParLogOff;
        internal System.Windows.Forms.TextBox txtMonTimeHigh;
        internal System.Windows.Forms.CheckBox chkParLimitsRel;
        internal System.Windows.Forms.Label lblHighMonTime;
        internal System.Windows.Forms.CheckBox chkParNoHornByWarning;
        internal System.Windows.Forms.TextBox txtMonTimeMiddle;
        internal System.Windows.Forms.GroupBox GroupBoxGroupTree;
        internal System.Windows.Forms.CheckBox chkMonNotMiddle;
        private System.Windows.Forms.CheckBox chkMonNotHighHigh;
        internal System.Windows.Forms.CheckBox chkMonNotHigh;
        internal System.Windows.Forms.CheckBox chkMonNotLow;
        internal System.Windows.Forms.Label lblValue9;
        internal System.Windows.Forms.CheckBox chkMonNotLowLow;
        internal System.Windows.Forms.TextBox txtValue9;
        internal System.Windows.Forms.CheckBox chkInterlocking;
        internal System.Windows.Forms.Label lblMiddleMonTime;
        internal System.Windows.Forms.TextBox txtValue10;
        internal System.Windows.Forms.TextBox txtMonTimeLow;
        internal System.Windows.Forms.Label lblValue10;
        internal System.Windows.Forms.Label lblLowMonTime;
        internal System.Windows.Forms.TextBox txtMonTimeLowLow;
        internal System.Windows.Forms.Label lblLowLowMonTime;
        internal System.Windows.Forms.ComboBox comboUnit;
        internal System.Windows.Forms.Label lblOffsetUnits;
        internal System.Windows.Forms.TextBox txtOffsetUnits;
        internal System.Windows.Forms.CheckBox chkNameOnlyNumber;
        internal System.Windows.Forms.GroupBox grpWinCOS;
        internal System.Windows.Forms.CheckBox chkOutValueRel;
        internal System.Windows.Forms.CheckBox chkOutValueUnits;
        private System.Windows.Forms.CheckBox chkWinCC;
        private System.Windows.Forms.CheckBox chkInDisable;
        internal System.Windows.Forms.TextBox txtInpLowLow;
        internal System.Windows.Forms.Label lblInpLowLow;
        internal System.Windows.Forms.TextBox txtSuffixInpLowLow;
        internal System.Windows.Forms.Label lblSuffixInpDigital;
        internal System.Windows.Forms.TextBox txtInpHighHigh;
        internal System.Windows.Forms.Label lblInpHighHigh;
        internal System.Windows.Forms.TextBox txtInpHigh;
        internal System.Windows.Forms.Label lblInpHigh;
        internal System.Windows.Forms.TextBox txtInpLow;
        internal System.Windows.Forms.Label lblInpLow;
        internal System.Windows.Forms.TextBox txtSuffixInpHighHigh;
        internal System.Windows.Forms.TextBox txtSuffixInpHigh;
        internal System.Windows.Forms.TextBox txtSuffixInpLow;
        internal System.Windows.Forms.ComboBox comboPowerBML;
        private System.Windows.Forms.Label lblPower;
        internal System.Windows.Forms.CheckBox chkUpdateUnitsByMaxDigits;
        internal System.Windows.Forms.CheckBox chkAddUserSectionToDesc;
    }
}

