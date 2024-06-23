using System;

namespace GcproExtensionApp
{
    partial class FormVFCAdapter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVFCAdapter));
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
            this.grpSinamics = new System.Windows.Forms.GroupBox();
            this.txtParRefPower = new System.Windows.Forms.TextBox();
            this.lblParRefPower = new System.Windows.Forms.Label();
            this.chkWithMultiMotorCfg = new System.Windows.Forms.CheckBox();
            this.txtParRefTorque = new System.Windows.Forms.TextBox();
            this.lblParRefTorque = new System.Windows.Forms.Label();
            this.txtParRefCurrent = new System.Windows.Forms.TextBox();
            this.lblParRefCurrent = new System.Windows.Forms.Label();
            this.grpTelegramm5 = new System.Windows.Forms.GroupBox();
            this.txtParUnitsPerDigit_T5 = new System.Windows.Forms.TextBox();
            this.lblParUnitsPerDigit_T5 = new System.Windows.Forms.Label();
            this.txtParPNO_T5 = new System.Windows.Forms.TextBox();
            this.lblParPNO_T5 = new System.Windows.Forms.Label();
            this.grpTelegramm4 = new System.Windows.Forms.GroupBox();
            this.txtParUnitsPerDigit_T4 = new System.Windows.Forms.TextBox();
            this.lblParUnitsPerDigit_T4 = new System.Windows.Forms.Label();
            this.txtParPNO_T4 = new System.Windows.Forms.TextBox();
            this.lblParPNO_T4 = new System.Windows.Forms.Label();
            this.grpTelegramm3 = new System.Windows.Forms.GroupBox();
            this.txtParUnitsPerDigit_T3 = new System.Windows.Forms.TextBox();
            this.lblParUnitsPerDigit_T3 = new System.Windows.Forms.Label();
            this.txtParPNO_T3 = new System.Windows.Forms.TextBox();
            this.lblParPNO_T3 = new System.Windows.Forms.Label();
            this.grpTelegramm2 = new System.Windows.Forms.GroupBox();
            this.txtParUnitsPerDigit_T2 = new System.Windows.Forms.TextBox();
            this.lblParUnitsPerDigit_T2 = new System.Windows.Forms.Label();
            this.txtParPNO_T2 = new System.Windows.Forms.TextBox();
            this.lblParPNO_T2 = new System.Windows.Forms.Label();
            this.grpTelegramm1 = new System.Windows.Forms.GroupBox();
            this.txtParUnitsPerDigit_T1 = new System.Windows.Forms.TextBox();
            this.lblParUnitsPerDigit_T1 = new System.Windows.Forms.Label();
            this.txtParPNO_T1 = new System.Windows.Forms.TextBox();
            this.lblParPNO_T1 = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.txtParSlaveIndexIncRule = new System.Windows.Forms.TextBox();
            this.lblParSlaveIndexIncRule = new System.Windows.Forms.Label();
            this.txtParUnitsPerDigits = new System.Windows.Forms.TextBox();
            this.lblUnitsPerDigits = new System.Windows.Forms.Label();
            this.txtOutpHardwareStop = new System.Windows.Forms.TextBox();
            this.txtParSalveIndex = new System.Windows.Forms.TextBox();
            this.lblOutpHardwareStop = new System.Windows.Forms.Label();
            this.lblParSlaveIndex = new System.Windows.Forms.Label();
            this.txtMEAGGateway = new System.Windows.Forms.TextBox();
            this.lblMEAGGateway = new System.Windows.Forms.Label();
            this.chkParWithActivePower = new System.Windows.Forms.CheckBox();
            this.LblSymbol = new System.Windows.Forms.Label();
            this.grpIOByte = new System.Windows.Forms.GroupBox();
            this.txtIOByteIncRule = new System.Windows.Forms.TextBox();
            this.tblFParIOByte = new System.Windows.Forms.Label();
            this.tblIOByteIncRule = new System.Windows.Forms.Label();
            this.txtParIOByte = new System.Windows.Forms.TextBox();
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
            this.LblDPNode1 = new System.Windows.Forms.Label();
            this.BtnRegenerateDPNode = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.BtnNewImpExpDef = new System.Windows.Forms.Button();
            this.BtnConnectIO = new System.Windows.Forms.Button();
            this.ComboDPNode1 = new System.Windows.Forms.ComboBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.lblSpeedMaxDigits = new System.Windows.Forms.Label();
            this.chkParProfinet = new System.Windows.Forms.CheckBox();
            this.chkParPZDConsistent = new System.Windows.Forms.CheckBox();
            this.txtParSpeedMaxDigits = new System.Windows.Forms.TextBox();
            this.txtValue10 = new System.Windows.Forms.TextBox();
            this.txtParLenPKW = new System.Windows.Forms.TextBox();
            this.lblSpeedUnitsByZeroDigits = new System.Windows.Forms.Label();
            this.lblValue10 = new System.Windows.Forms.Label();
            this.txtParLenPZDInp = new System.Windows.Forms.TextBox();
            this.lblParLenPKW = new System.Windows.Forms.Label();
            this.txtParSpeedUnitsByZeroDigits = new System.Windows.Forms.TextBox();
            this.txtParSpeedLimitMax = new System.Windows.Forms.TextBox();
            this.lblParLenPZDInp = new System.Windows.Forms.Label();
            this.LblSpeedLimitMax = new System.Windows.Forms.Label();
            this.lblSpeedUnitsByMaxDigits = new System.Windows.Forms.Label();
            this.txtParSpeedLimitMin = new System.Windows.Forms.TextBox();
            this.txtParLenPZD = new System.Windows.Forms.TextBox();
            this.LblSpeedLimitMin = new System.Windows.Forms.Label();
            this.txtParSpeedUnitsByMaxDigits = new System.Windows.Forms.TextBox();
            this.lblParLenPZD = new System.Windows.Forms.Label();
            this.tabBML = new System.Windows.Forms.TabPage();
            this.grpBoxExcelData = new System.Windows.Forms.GroupBox();
            this.txtVFCSufffixBML = new System.Windows.Forms.TextBox();
            this.lblVFCSufffixBML = new System.Windows.Forms.Label();
            this.txtVFCPrefixBML = new System.Windows.Forms.TextBox();
            this.lblVFCPrefixBML = new System.Windows.Forms.Label();
            this.btnReadBML = new System.Windows.Forms.Button();
            this.dataGridBML = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboWorkSheetsBML = new System.Windows.Forms.ComboBox();
            this.grpBoxExcelColumn = new System.Windows.Forms.GroupBox();
            this.grpBoxBMLColum = new System.Windows.Forms.GroupBox();
            this.comboControlBML = new System.Windows.Forms.ComboBox();
            this.lblControlBML = new System.Windows.Forms.Label();
            this.comboStartRow = new System.Windows.Forms.ComboBox();
            this.comboSectionBML = new System.Windows.Forms.ComboBox();
            this.lblStartRow = new System.Windows.Forms.Label();
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
            this.BtnOpenProjectBML = new System.Windows.Forms.Button();
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
            this.grpSinamics.SuspendLayout();
            this.grpTelegramm5.SuspendLayout();
            this.grpTelegramm4.SuspendLayout();
            this.grpTelegramm3.SuspendLayout();
            this.grpTelegramm2.SuspendLayout();
            this.grpTelegramm1.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpIOByte.SuspendLayout();
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
            this.tabRule.Text = "设定规则创建";
            // 
            // PalGcObject
            // 
            this.PalGcObject.AutoScroll = true;
            this.PalGcObject.AutoSize = true;
            this.PalGcObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PalGcObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PalGcObject.Controls.Add(this.grpSinamics);
            this.PalGcObject.Controls.Add(this.grpTelegramm5);
            this.PalGcObject.Controls.Add(this.grpTelegramm4);
            this.PalGcObject.Controls.Add(this.grpTelegramm3);
            this.PalGcObject.Controls.Add(this.grpTelegramm2);
            this.PalGcObject.Controls.Add(this.grpTelegramm1);
            this.PalGcObject.Controls.Add(this.grpGeneral);
            this.PalGcObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalGcObject.Location = new System.Drawing.Point(3, 3);
            this.PalGcObject.Name = "PalGcObject";
            this.PalGcObject.Size = new System.Drawing.Size(717, 547);
            this.PalGcObject.TabIndex = 105;
            // 
            // grpSinamics
            // 
            this.grpSinamics.Controls.Add(this.txtParRefPower);
            this.grpSinamics.Controls.Add(this.lblParRefPower);
            this.grpSinamics.Controls.Add(this.chkWithMultiMotorCfg);
            this.grpSinamics.Controls.Add(this.txtParRefTorque);
            this.grpSinamics.Controls.Add(this.lblParRefTorque);
            this.grpSinamics.Controls.Add(this.txtParRefCurrent);
            this.grpSinamics.Controls.Add(this.lblParRefCurrent);
            this.grpSinamics.Location = new System.Drawing.Point(6, 447);
            this.grpSinamics.Name = "grpSinamics";
            this.grpSinamics.Size = new System.Drawing.Size(189, 95);
            this.grpSinamics.TabIndex = 146;
            this.grpSinamics.TabStop = false;
            this.grpSinamics.Text = "Sinamics";
            // 
            // txtParRefPower
            // 
            this.txtParRefPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParRefPower.Location = new System.Drawing.Point(111, 76);
            this.txtParRefPower.Name = "txtParRefPower";
            this.txtParRefPower.Size = new System.Drawing.Size(63, 13);
            this.txtParRefPower.TabIndex = 157;
            this.txtParRefPower.Text = "0";
            this.txtParRefPower.MouseEnter += new System.EventHandler(this.txtParRefPower_MouseEnter);
            // 
            // lblParRefPower
            // 
            this.lblParRefPower.AutoSize = true;
            this.lblParRefPower.Location = new System.Drawing.Point(6, 76);
            this.lblParRefPower.Name = "lblParRefPower";
            this.lblParRefPower.Size = new System.Drawing.Size(70, 13);
            this.lblParRefPower.TabIndex = 158;
            this.lblParRefPower.Text = "ParRefPower";
            // 
            // chkWithMultiMotorCfg
            // 
            this.chkWithMultiMotorCfg.AutoSize = true;
            this.chkWithMultiMotorCfg.Enabled = false;
            this.chkWithMultiMotorCfg.Location = new System.Drawing.Point(6, 19);
            this.chkWithMultiMotorCfg.Name = "chkWithMultiMotorCfg";
            this.chkWithMultiMotorCfg.Size = new System.Drawing.Size(113, 17);
            this.chkWithMultiMotorCfg.TabIndex = 156;
            this.chkWithMultiMotorCfg.Text = "WithMultiMotorCfg";
            this.chkWithMultiMotorCfg.UseVisualStyleBackColor = true;
            this.chkWithMultiMotorCfg.CheckedChanged += new System.EventHandler(this.chkWithMultiMotorCfg_CheckedChanged);
            this.chkWithMultiMotorCfg.MouseEnter += new System.EventHandler(this.chkWithMultiMotorCfg_MouseEnter);
            // 
            // txtParRefTorque
            // 
            this.txtParRefTorque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParRefTorque.Location = new System.Drawing.Point(111, 57);
            this.txtParRefTorque.Name = "txtParRefTorque";
            this.txtParRefTorque.Size = new System.Drawing.Size(63, 13);
            this.txtParRefTorque.TabIndex = 83;
            this.txtParRefTorque.Text = "0";
            this.txtParRefTorque.MouseEnter += new System.EventHandler(this.txtParRefTorque_MouseEnter);
            // 
            // lblParRefTorque
            // 
            this.lblParRefTorque.AutoSize = true;
            this.lblParRefTorque.Location = new System.Drawing.Point(6, 57);
            this.lblParRefTorque.Name = "lblParRefTorque";
            this.lblParRefTorque.Size = new System.Drawing.Size(74, 13);
            this.lblParRefTorque.TabIndex = 84;
            this.lblParRefTorque.Text = "ParRefTorque";
            // 
            // txtParRefCurrent
            // 
            this.txtParRefCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParRefCurrent.Location = new System.Drawing.Point(111, 38);
            this.txtParRefCurrent.Name = "txtParRefCurrent";
            this.txtParRefCurrent.Size = new System.Drawing.Size(63, 13);
            this.txtParRefCurrent.TabIndex = 82;
            this.txtParRefCurrent.Text = "0";
            this.txtParRefCurrent.MouseEnter += new System.EventHandler(this.txtParRefCurrent_MouseEnter);
            // 
            // lblParRefCurrent
            // 
            this.lblParRefCurrent.AutoSize = true;
            this.lblParRefCurrent.Location = new System.Drawing.Point(6, 38);
            this.lblParRefCurrent.Name = "lblParRefCurrent";
            this.lblParRefCurrent.Size = new System.Drawing.Size(74, 13);
            this.lblParRefCurrent.TabIndex = 82;
            this.lblParRefCurrent.Text = "ParRefCurrent";
            // 
            // grpTelegramm5
            // 
            this.grpTelegramm5.Controls.Add(this.txtParUnitsPerDigit_T5);
            this.grpTelegramm5.Controls.Add(this.lblParUnitsPerDigit_T5);
            this.grpTelegramm5.Controls.Add(this.txtParPNO_T5);
            this.grpTelegramm5.Controls.Add(this.lblParPNO_T5);
            this.grpTelegramm5.Location = new System.Drawing.Point(221, 386);
            this.grpTelegramm5.Name = "grpTelegramm5";
            this.grpTelegramm5.Size = new System.Drawing.Size(189, 60);
            this.grpTelegramm5.TabIndex = 145;
            this.grpTelegramm5.TabStop = false;
            this.grpTelegramm5.Text = "Telegramm 5";
            // 
            // txtParUnitsPerDigit_T5
            // 
            this.txtParUnitsPerDigit_T5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParUnitsPerDigit_T5.Location = new System.Drawing.Point(111, 36);
            this.txtParUnitsPerDigit_T5.Name = "txtParUnitsPerDigit_T5";
            this.txtParUnitsPerDigit_T5.Size = new System.Drawing.Size(63, 13);
            this.txtParUnitsPerDigit_T5.TabIndex = 83;
            this.txtParUnitsPerDigit_T5.Text = "0";
            this.txtParUnitsPerDigit_T5.MouseEnter += new System.EventHandler(this.txtParUnitsPerDigit_T5_MouseEnter);
            // 
            // lblParUnitsPerDigit_T5
            // 
            this.lblParUnitsPerDigit_T5.AutoSize = true;
            this.lblParUnitsPerDigit_T5.Location = new System.Drawing.Point(6, 36);
            this.lblParUnitsPerDigit_T5.Name = "lblParUnitsPerDigit_T5";
            this.lblParUnitsPerDigit_T5.Size = new System.Drawing.Size(84, 13);
            this.lblParUnitsPerDigit_T5.TabIndex = 84;
            this.lblParUnitsPerDigit_T5.Text = "ParUnitsPerDigit";
            // 
            // txtParPNO_T5
            // 
            this.txtParPNO_T5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParPNO_T5.Location = new System.Drawing.Point(111, 18);
            this.txtParPNO_T5.Name = "txtParPNO_T5";
            this.txtParPNO_T5.Size = new System.Drawing.Size(63, 13);
            this.txtParPNO_T5.TabIndex = 82;
            this.txtParPNO_T5.Text = "0";
            this.txtParPNO_T5.MouseEnter += new System.EventHandler(this.txtParPNO_T5_MouseEnter);
            // 
            // lblParPNO_T5
            // 
            this.lblParPNO_T5.AutoSize = true;
            this.lblParPNO_T5.Location = new System.Drawing.Point(6, 18);
            this.lblParPNO_T5.Name = "lblParPNO_T5";
            this.lblParPNO_T5.Size = new System.Drawing.Size(46, 13);
            this.lblParPNO_T5.TabIndex = 82;
            this.lblParPNO_T5.Text = "ParPNO";
            // 
            // grpTelegramm4
            // 
            this.grpTelegramm4.Controls.Add(this.txtParUnitsPerDigit_T4);
            this.grpTelegramm4.Controls.Add(this.lblParUnitsPerDigit_T4);
            this.grpTelegramm4.Controls.Add(this.txtParPNO_T4);
            this.grpTelegramm4.Controls.Add(this.lblParPNO_T4);
            this.grpTelegramm4.Location = new System.Drawing.Point(6, 386);
            this.grpTelegramm4.Name = "grpTelegramm4";
            this.grpTelegramm4.Size = new System.Drawing.Size(189, 60);
            this.grpTelegramm4.TabIndex = 144;
            this.grpTelegramm4.TabStop = false;
            this.grpTelegramm4.Text = "Telegramm 4";
            // 
            // txtParUnitsPerDigit_T4
            // 
            this.txtParUnitsPerDigit_T4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParUnitsPerDigit_T4.Location = new System.Drawing.Point(111, 36);
            this.txtParUnitsPerDigit_T4.Name = "txtParUnitsPerDigit_T4";
            this.txtParUnitsPerDigit_T4.Size = new System.Drawing.Size(63, 13);
            this.txtParUnitsPerDigit_T4.TabIndex = 83;
            this.txtParUnitsPerDigit_T4.Text = "0";
            this.txtParUnitsPerDigit_T4.MouseEnter += new System.EventHandler(this.txtParUnitsPerDigit_T4_MouseEnter);
            // 
            // lblParUnitsPerDigit_T4
            // 
            this.lblParUnitsPerDigit_T4.AutoSize = true;
            this.lblParUnitsPerDigit_T4.Location = new System.Drawing.Point(6, 36);
            this.lblParUnitsPerDigit_T4.Name = "lblParUnitsPerDigit_T4";
            this.lblParUnitsPerDigit_T4.Size = new System.Drawing.Size(84, 13);
            this.lblParUnitsPerDigit_T4.TabIndex = 84;
            this.lblParUnitsPerDigit_T4.Text = "ParUnitsPerDigit";
            // 
            // txtParPNO_T4
            // 
            this.txtParPNO_T4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParPNO_T4.Location = new System.Drawing.Point(111, 18);
            this.txtParPNO_T4.Name = "txtParPNO_T4";
            this.txtParPNO_T4.Size = new System.Drawing.Size(63, 13);
            this.txtParPNO_T4.TabIndex = 82;
            this.txtParPNO_T4.Text = "0";
            this.txtParPNO_T4.MouseEnter += new System.EventHandler(this.txtParPNO_T4_MouseEnter);
            // 
            // lblParPNO_T4
            // 
            this.lblParPNO_T4.AutoSize = true;
            this.lblParPNO_T4.Location = new System.Drawing.Point(6, 18);
            this.lblParPNO_T4.Name = "lblParPNO_T4";
            this.lblParPNO_T4.Size = new System.Drawing.Size(46, 13);
            this.lblParPNO_T4.TabIndex = 82;
            this.lblParPNO_T4.Text = "ParPNO";
            // 
            // grpTelegramm3
            // 
            this.grpTelegramm3.Controls.Add(this.txtParUnitsPerDigit_T3);
            this.grpTelegramm3.Controls.Add(this.lblParUnitsPerDigit_T3);
            this.grpTelegramm3.Controls.Add(this.txtParPNO_T3);
            this.grpTelegramm3.Controls.Add(this.lblParPNO_T3);
            this.grpTelegramm3.Location = new System.Drawing.Point(436, 327);
            this.grpTelegramm3.Name = "grpTelegramm3";
            this.grpTelegramm3.Size = new System.Drawing.Size(189, 60);
            this.grpTelegramm3.TabIndex = 143;
            this.grpTelegramm3.TabStop = false;
            this.grpTelegramm3.Text = "Telegramm 3";
            // 
            // txtParUnitsPerDigit_T3
            // 
            this.txtParUnitsPerDigit_T3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParUnitsPerDigit_T3.Location = new System.Drawing.Point(111, 36);
            this.txtParUnitsPerDigit_T3.Name = "txtParUnitsPerDigit_T3";
            this.txtParUnitsPerDigit_T3.Size = new System.Drawing.Size(63, 13);
            this.txtParUnitsPerDigit_T3.TabIndex = 83;
            this.txtParUnitsPerDigit_T3.Text = "0";
            this.txtParUnitsPerDigit_T3.MouseEnter += new System.EventHandler(this.txtParUnitsPerDigit_T3_MouseEnter);
            // 
            // lblParUnitsPerDigit_T3
            // 
            this.lblParUnitsPerDigit_T3.AutoSize = true;
            this.lblParUnitsPerDigit_T3.Location = new System.Drawing.Point(6, 36);
            this.lblParUnitsPerDigit_T3.Name = "lblParUnitsPerDigit_T3";
            this.lblParUnitsPerDigit_T3.Size = new System.Drawing.Size(84, 13);
            this.lblParUnitsPerDigit_T3.TabIndex = 84;
            this.lblParUnitsPerDigit_T3.Text = "ParUnitsPerDigit";
            // 
            // txtParPNO_T3
            // 
            this.txtParPNO_T3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParPNO_T3.Location = new System.Drawing.Point(111, 18);
            this.txtParPNO_T3.Name = "txtParPNO_T3";
            this.txtParPNO_T3.Size = new System.Drawing.Size(63, 13);
            this.txtParPNO_T3.TabIndex = 82;
            this.txtParPNO_T3.Text = "0";
            this.txtParPNO_T3.MouseEnter += new System.EventHandler(this.txtParPNO_T3_MouseEnter);
            // 
            // lblParPNO_T3
            // 
            this.lblParPNO_T3.AutoSize = true;
            this.lblParPNO_T3.Location = new System.Drawing.Point(6, 18);
            this.lblParPNO_T3.Name = "lblParPNO_T3";
            this.lblParPNO_T3.Size = new System.Drawing.Size(46, 13);
            this.lblParPNO_T3.TabIndex = 82;
            this.lblParPNO_T3.Text = "ParPNO";
            // 
            // grpTelegramm2
            // 
            this.grpTelegramm2.Controls.Add(this.txtParUnitsPerDigit_T2);
            this.grpTelegramm2.Controls.Add(this.lblParUnitsPerDigit_T2);
            this.grpTelegramm2.Controls.Add(this.txtParPNO_T2);
            this.grpTelegramm2.Controls.Add(this.lblParPNO_T2);
            this.grpTelegramm2.Location = new System.Drawing.Point(221, 327);
            this.grpTelegramm2.Name = "grpTelegramm2";
            this.grpTelegramm2.Size = new System.Drawing.Size(189, 60);
            this.grpTelegramm2.TabIndex = 142;
            this.grpTelegramm2.TabStop = false;
            this.grpTelegramm2.Text = "Telegramm 2";
            // 
            // txtParUnitsPerDigit_T2
            // 
            this.txtParUnitsPerDigit_T2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParUnitsPerDigit_T2.Location = new System.Drawing.Point(111, 36);
            this.txtParUnitsPerDigit_T2.Name = "txtParUnitsPerDigit_T2";
            this.txtParUnitsPerDigit_T2.Size = new System.Drawing.Size(63, 13);
            this.txtParUnitsPerDigit_T2.TabIndex = 83;
            this.txtParUnitsPerDigit_T2.Text = "0";
            this.txtParUnitsPerDigit_T2.MouseEnter += new System.EventHandler(this.txtParUnitsPerDigit_T2_MouseEnter);
            // 
            // lblParUnitsPerDigit_T2
            // 
            this.lblParUnitsPerDigit_T2.AutoSize = true;
            this.lblParUnitsPerDigit_T2.Location = new System.Drawing.Point(6, 36);
            this.lblParUnitsPerDigit_T2.Name = "lblParUnitsPerDigit_T2";
            this.lblParUnitsPerDigit_T2.Size = new System.Drawing.Size(84, 13);
            this.lblParUnitsPerDigit_T2.TabIndex = 84;
            this.lblParUnitsPerDigit_T2.Text = "ParUnitsPerDigit";
            // 
            // txtParPNO_T2
            // 
            this.txtParPNO_T2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParPNO_T2.Location = new System.Drawing.Point(111, 18);
            this.txtParPNO_T2.Name = "txtParPNO_T2";
            this.txtParPNO_T2.Size = new System.Drawing.Size(63, 13);
            this.txtParPNO_T2.TabIndex = 82;
            this.txtParPNO_T2.Text = "0";
            this.txtParPNO_T2.MouseEnter += new System.EventHandler(this.txtParPNO_T2_MouseEnter);
            // 
            // lblParPNO_T2
            // 
            this.lblParPNO_T2.AutoSize = true;
            this.lblParPNO_T2.Location = new System.Drawing.Point(6, 18);
            this.lblParPNO_T2.Name = "lblParPNO_T2";
            this.lblParPNO_T2.Size = new System.Drawing.Size(46, 13);
            this.lblParPNO_T2.TabIndex = 82;
            this.lblParPNO_T2.Text = "ParPNO";
            // 
            // grpTelegramm1
            // 
            this.grpTelegramm1.Controls.Add(this.txtParUnitsPerDigit_T1);
            this.grpTelegramm1.Controls.Add(this.lblParUnitsPerDigit_T1);
            this.grpTelegramm1.Controls.Add(this.txtParPNO_T1);
            this.grpTelegramm1.Controls.Add(this.lblParPNO_T1);
            this.grpTelegramm1.Location = new System.Drawing.Point(6, 327);
            this.grpTelegramm1.Name = "grpTelegramm1";
            this.grpTelegramm1.Size = new System.Drawing.Size(189, 60);
            this.grpTelegramm1.TabIndex = 141;
            this.grpTelegramm1.TabStop = false;
            this.grpTelegramm1.Text = "Telegramm 1";
            // 
            // txtParUnitsPerDigit_T1
            // 
            this.txtParUnitsPerDigit_T1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParUnitsPerDigit_T1.Location = new System.Drawing.Point(111, 36);
            this.txtParUnitsPerDigit_T1.Name = "txtParUnitsPerDigit_T1";
            this.txtParUnitsPerDigit_T1.Size = new System.Drawing.Size(63, 13);
            this.txtParUnitsPerDigit_T1.TabIndex = 83;
            this.txtParUnitsPerDigit_T1.Text = "0";
            this.txtParUnitsPerDigit_T1.MouseEnter += new System.EventHandler(this.txtParUnitsPerDigit_T1_MouseEnter);
            // 
            // lblParUnitsPerDigit_T1
            // 
            this.lblParUnitsPerDigit_T1.AutoSize = true;
            this.lblParUnitsPerDigit_T1.Location = new System.Drawing.Point(6, 36);
            this.lblParUnitsPerDigit_T1.Name = "lblParUnitsPerDigit_T1";
            this.lblParUnitsPerDigit_T1.Size = new System.Drawing.Size(84, 13);
            this.lblParUnitsPerDigit_T1.TabIndex = 84;
            this.lblParUnitsPerDigit_T1.Text = "ParUnitsPerDigit";
            // 
            // txtParPNO_T1
            // 
            this.txtParPNO_T1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParPNO_T1.Location = new System.Drawing.Point(111, 18);
            this.txtParPNO_T1.Name = "txtParPNO_T1";
            this.txtParPNO_T1.Size = new System.Drawing.Size(63, 13);
            this.txtParPNO_T1.TabIndex = 82;
            this.txtParPNO_T1.Text = "0";
            this.txtParPNO_T1.MouseEnter += new System.EventHandler(this.txtParPNO_T1_MouseEnter);
            // 
            // lblParPNO_T1
            // 
            this.lblParPNO_T1.AutoSize = true;
            this.lblParPNO_T1.Location = new System.Drawing.Point(6, 18);
            this.lblParPNO_T1.Name = "lblParPNO_T1";
            this.lblParPNO_T1.Size = new System.Drawing.Size(46, 13);
            this.lblParPNO_T1.TabIndex = 82;
            this.lblParPNO_T1.Text = "ParPNO";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.txtParSlaveIndexIncRule);
            this.grpGeneral.Controls.Add(this.lblParSlaveIndexIncRule);
            this.grpGeneral.Controls.Add(this.txtParUnitsPerDigits);
            this.grpGeneral.Controls.Add(this.lblUnitsPerDigits);
            this.grpGeneral.Controls.Add(this.txtOutpHardwareStop);
            this.grpGeneral.Controls.Add(this.txtParSalveIndex);
            this.grpGeneral.Controls.Add(this.lblOutpHardwareStop);
            this.grpGeneral.Controls.Add(this.lblParSlaveIndex);
            this.grpGeneral.Controls.Add(this.txtMEAGGateway);
            this.grpGeneral.Controls.Add(this.lblMEAGGateway);
            this.grpGeneral.Controls.Add(this.chkParWithActivePower);
            this.grpGeneral.Controls.Add(this.LblSymbol);
            this.grpGeneral.Controls.Add(this.grpIOByte);
            this.grpGeneral.Controls.Add(this.GrpDescriptionRule);
            this.grpGeneral.Controls.Add(this.GrpSymbolRule);
            this.grpGeneral.Controls.Add(this.LblDPNode1);
            this.grpGeneral.Controls.Add(this.BtnRegenerateDPNode);
            this.grpGeneral.Controls.Add(this.txtDescription);
            this.grpGeneral.Controls.Add(this.BtnNewImpExpDef);
            this.grpGeneral.Controls.Add(this.BtnConnectIO);
            this.grpGeneral.Controls.Add(this.ComboDPNode1);
            this.grpGeneral.Controls.Add(this.txtSymbol);
            this.grpGeneral.Controls.Add(this.LblDescription);
            this.grpGeneral.Controls.Add(this.lblSpeedMaxDigits);
            this.grpGeneral.Controls.Add(this.chkParProfinet);
            this.grpGeneral.Controls.Add(this.chkParPZDConsistent);
            this.grpGeneral.Controls.Add(this.txtParSpeedMaxDigits);
            this.grpGeneral.Controls.Add(this.txtValue10);
            this.grpGeneral.Controls.Add(this.txtParLenPKW);
            this.grpGeneral.Controls.Add(this.lblSpeedUnitsByZeroDigits);
            this.grpGeneral.Controls.Add(this.lblValue10);
            this.grpGeneral.Controls.Add(this.txtParLenPZDInp);
            this.grpGeneral.Controls.Add(this.lblParLenPKW);
            this.grpGeneral.Controls.Add(this.txtParSpeedUnitsByZeroDigits);
            this.grpGeneral.Controls.Add(this.txtParSpeedLimitMax);
            this.grpGeneral.Controls.Add(this.lblParLenPZDInp);
            this.grpGeneral.Controls.Add(this.LblSpeedLimitMax);
            this.grpGeneral.Controls.Add(this.lblSpeedUnitsByMaxDigits);
            this.grpGeneral.Controls.Add(this.txtParSpeedLimitMin);
            this.grpGeneral.Controls.Add(this.txtParLenPZD);
            this.grpGeneral.Controls.Add(this.LblSpeedLimitMin);
            this.grpGeneral.Controls.Add(this.txtParSpeedUnitsByMaxDigits);
            this.grpGeneral.Controls.Add(this.lblParLenPZD);
            this.grpGeneral.Location = new System.Drawing.Point(6, 4);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(704, 324);
            this.grpGeneral.TabIndex = 118;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "常规";
            // 
            // txtParSlaveIndexIncRule
            // 
            this.txtParSlaveIndexIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSlaveIndexIncRule.Enabled = false;
            this.txtParSlaveIndexIncRule.Location = new System.Drawing.Point(286, 163);
            this.txtParSlaveIndexIncRule.Name = "txtParSlaveIndexIncRule";
            this.txtParSlaveIndexIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtParSlaveIndexIncRule.TabIndex = 75;
            // 
            // lblParSlaveIndexIncRule
            // 
            this.lblParSlaveIndexIncRule.AutoSize = true;
            this.lblParSlaveIndexIncRule.Location = new System.Drawing.Point(230, 163);
            this.lblParSlaveIndexIncRule.Name = "lblParSlaveIndexIncRule";
            this.lblParSlaveIndexIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblParSlaveIndexIncRule.TabIndex = 74;
            this.lblParSlaveIndexIncRule.Text = "递增规则";
            // 
            // txtParUnitsPerDigits
            // 
            this.txtParUnitsPerDigits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParUnitsPerDigits.Location = new System.Drawing.Point(147, 255);
            this.txtParUnitsPerDigits.Name = "txtParUnitsPerDigits";
            this.txtParUnitsPerDigits.Size = new System.Drawing.Size(63, 13);
            this.txtParUnitsPerDigits.TabIndex = 155;
            this.txtParUnitsPerDigits.Text = "0.1";
            this.txtParUnitsPerDigits.MouseEnter += new System.EventHandler(this.txtParUnitsPerDigits_MouseEnter);
            // 
            // lblUnitsPerDigits
            // 
            this.lblUnitsPerDigits.AutoSize = true;
            this.lblUnitsPerDigits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnitsPerDigits.Location = new System.Drawing.Point(4, 255);
            this.lblUnitsPerDigits.Name = "lblUnitsPerDigits";
            this.lblUnitsPerDigits.Size = new System.Drawing.Size(73, 13);
            this.lblUnitsPerDigits.TabIndex = 154;
            this.lblUnitsPerDigits.Text = "UnitsPerDigits";
            // 
            // txtOutpHardwareStop
            // 
            this.txtOutpHardwareStop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutpHardwareStop.Location = new System.Drawing.Point(147, 182);
            this.txtOutpHardwareStop.Name = "txtOutpHardwareStop";
            this.txtOutpHardwareStop.Size = new System.Drawing.Size(147, 13);
            this.txtOutpHardwareStop.TabIndex = 153;
            this.txtOutpHardwareStop.MouseEnter += new System.EventHandler(this.txtOutpHardwareStop_MouseEnter);
            // 
            // txtParSalveIndex
            // 
            this.txtParSalveIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSalveIndex.Location = new System.Drawing.Point(147, 164);
            this.txtParSalveIndex.Name = "txtParSalveIndex";
            this.txtParSalveIndex.Size = new System.Drawing.Size(63, 13);
            this.txtParSalveIndex.TabIndex = 152;
            this.txtParSalveIndex.Text = "0";
            this.txtParSalveIndex.MouseEnter += new System.EventHandler(this.txtParSalveIndex_MouseEnter);
            // 
            // lblOutpHardwareStop
            // 
            this.lblOutpHardwareStop.AutoSize = true;
            this.lblOutpHardwareStop.Location = new System.Drawing.Point(4, 180);
            this.lblOutpHardwareStop.Name = "lblOutpHardwareStop";
            this.lblOutpHardwareStop.Size = new System.Drawing.Size(98, 13);
            this.lblOutpHardwareStop.TabIndex = 151;
            this.lblOutpHardwareStop.Text = "OutpHardwareStop";
            // 
            // lblParSlaveIndex
            // 
            this.lblParSlaveIndex.AutoSize = true;
            this.lblParSlaveIndex.Location = new System.Drawing.Point(4, 163);
            this.lblParSlaveIndex.Name = "lblParSlaveIndex";
            this.lblParSlaveIndex.Size = new System.Drawing.Size(60, 13);
            this.lblParSlaveIndex.TabIndex = 150;
            this.lblParSlaveIndex.Text = "SlaveIndex";
            // 
            // txtMEAGGateway
            // 
            this.txtMEAGGateway.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMEAGGateway.Location = new System.Drawing.Point(147, 146);
            this.txtMEAGGateway.Name = "txtMEAGGateway";
            this.txtMEAGGateway.Size = new System.Drawing.Size(341, 13);
            this.txtMEAGGateway.TabIndex = 149;
            this.txtMEAGGateway.MouseEnter += new System.EventHandler(this.txtMEAGGateway_MouseEnter);
            // 
            // lblMEAGGateway
            // 
            this.lblMEAGGateway.AutoSize = true;
            this.lblMEAGGateway.Location = new System.Drawing.Point(4, 146);
            this.lblMEAGGateway.Name = "lblMEAGGateway";
            this.lblMEAGGateway.Size = new System.Drawing.Size(83, 13);
            this.lblMEAGGateway.TabIndex = 148;
            this.lblMEAGGateway.Text = "MEAG Gateway";
            // 
            // chkParWithActivePower
            // 
            this.chkParWithActivePower.AutoSize = true;
            this.chkParWithActivePower.Location = new System.Drawing.Point(234, 305);
            this.chkParWithActivePower.Name = "chkParWithActivePower";
            this.chkParWithActivePower.Size = new System.Drawing.Size(124, 17);
            this.chkParWithActivePower.TabIndex = 147;
            this.chkParWithActivePower.Text = "ParWithActivePower";
            this.chkParWithActivePower.UseVisualStyleBackColor = true;
            this.chkParWithActivePower.CheckedChanged += new System.EventHandler(this.chkParWithActivePower_CheckedChanged);
            this.chkParWithActivePower.MouseEnter += new System.EventHandler(this.chkParWithActivePower_MouseEnter);
            // 
            // LblSymbol
            // 
            this.LblSymbol.AutoSize = true;
            this.LblSymbol.Location = new System.Drawing.Point(6, 16);
            this.LblSymbol.Name = "LblSymbol";
            this.LblSymbol.Size = new System.Drawing.Size(55, 13);
            this.LblSymbol.TabIndex = 0;
            this.LblSymbol.Text = "变频名称";
            // 
            // grpIOByte
            // 
            this.grpIOByte.Controls.Add(this.txtIOByteIncRule);
            this.grpIOByte.Controls.Add(this.tblFParIOByte);
            this.grpIOByte.Controls.Add(this.tblIOByteIncRule);
            this.grpIOByte.Controls.Add(this.txtParIOByte);
            this.grpIOByte.Location = new System.Drawing.Point(234, 201);
            this.grpIOByte.Name = "grpIOByte";
            this.grpIOByte.Size = new System.Drawing.Size(349, 50);
            this.grpIOByte.TabIndex = 146;
            this.grpIOByte.TabStop = false;
            this.grpIOByte.Text = "IO Byte和规则";
            // 
            // txtIOByteIncRule
            // 
            this.txtIOByteIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIOByteIncRule.Location = new System.Drawing.Point(225, 17);
            this.txtIOByteIncRule.Name = "txtIOByteIncRule";
            this.txtIOByteIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtIOByteIncRule.TabIndex = 73;
            this.txtIOByteIncRule.Text = "0";
            this.txtIOByteIncRule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIOByteIncRule_KeyDown);
            // 
            // tblFParIOByte
            // 
            this.tblFParIOByte.AutoSize = true;
            this.tblFParIOByte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tblFParIOByte.Location = new System.Drawing.Point(9, 17);
            this.tblFParIOByte.Name = "tblFParIOByte";
            this.tblFParIOByte.Size = new System.Drawing.Size(55, 13);
            this.tblFParIOByte.TabIndex = 30;
            this.tblFParIOByte.Text = "ParIOByte";
            // 
            // tblIOByteIncRule
            // 
            this.tblIOByteIncRule.AutoSize = true;
            this.tblIOByteIncRule.Location = new System.Drawing.Point(169, 17);
            this.tblIOByteIncRule.Name = "tblIOByteIncRule";
            this.tblIOByteIncRule.Size = new System.Drawing.Size(55, 13);
            this.tblIOByteIncRule.TabIndex = 72;
            this.tblIOByteIncRule.Text = "递增规则";
            // 
            // txtParIOByte
            // 
            this.txtParIOByte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParIOByte.Location = new System.Drawing.Point(88, 17);
            this.txtParIOByte.Name = "txtParIOByte";
            this.txtParIOByte.Size = new System.Drawing.Size(63, 13);
            this.txtParIOByte.TabIndex = 31;
            this.txtParIOByte.Text = "1000";
            this.txtParIOByte.TextChanged += new System.EventHandler(this.txtParIOByte_TextChanged);
            this.txtParIOByte.MouseEnter += new System.EventHandler(this.txtParIOByte_MouseEnter);
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
            this.txtSymbolIncRule.Text = "1";
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
            // LblDPNode1
            // 
            this.LblDPNode1.AutoSize = true;
            this.LblDPNode1.Location = new System.Drawing.Point(242, 107);
            this.LblDPNode1.Name = "LblDPNode1";
            this.LblDPNode1.Size = new System.Drawing.Size(52, 13);
            this.LblDPNode1.TabIndex = 119;
            this.LblDPNode1.Text = "DP站点1";
            // 
            // BtnRegenerateDPNode
            // 
            this.BtnRegenerateDPNode.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegenerateDPNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegenerateDPNode.BackgroundImage")));
            this.BtnRegenerateDPNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRegenerateDPNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegenerateDPNode.Location = new System.Drawing.Point(48, 67);
            this.BtnRegenerateDPNode.Name = "BtnRegenerateDPNode";
            this.BtnRegenerateDPNode.Size = new System.Drawing.Size(36, 30);
            this.BtnRegenerateDPNode.TabIndex = 88;
            this.BtnRegenerateDPNode.UseVisualStyleBackColor = false;
            this.BtnRegenerateDPNode.Click += new System.EventHandler(this.BtnRegenerateDPNode_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(245, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(346, 13);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.MouseEnter += new System.EventHandler(this.TxtDescription_MouseEnter);
            // 
            // BtnNewImpExpDef
            // 
            this.BtnNewImpExpDef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewImpExpDef.BackgroundImage")));
            this.BtnNewImpExpDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewImpExpDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewImpExpDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewImpExpDef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewImpExpDef.Location = new System.Drawing.Point(6, 67);
            this.BtnNewImpExpDef.Name = "BtnNewImpExpDef";
            this.BtnNewImpExpDef.Size = new System.Drawing.Size(36, 30);
            this.BtnNewImpExpDef.TabIndex = 76;
            this.BtnNewImpExpDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewImpExpDef.UseVisualStyleBackColor = true;
            this.BtnNewImpExpDef.Click += new System.EventHandler(this.BtnNewImpExpDef_Click);
            // 
            // BtnConnectIO
            // 
            this.BtnConnectIO.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConnectIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConnectIO.BackgroundImage")));
            this.BtnConnectIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConnectIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnectIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnectIO.Location = new System.Drawing.Point(90, 67);
            this.BtnConnectIO.Name = "BtnConnectIO";
            this.BtnConnectIO.Size = new System.Drawing.Size(36, 30);
            this.BtnConnectIO.TabIndex = 98;
            this.BtnConnectIO.UseVisualStyleBackColor = false;
            this.BtnConnectIO.Visible = false;
            // 
            // ComboDPNode1
            // 
            this.ComboDPNode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboDPNode1.FormattingEnabled = true;
            this.ComboDPNode1.Location = new System.Drawing.Point(298, 105);
            this.ComboDPNode1.Name = "ComboDPNode1";
            this.ComboDPNode1.Size = new System.Drawing.Size(293, 21);
            this.ComboDPNode1.TabIndex = 120;
            // 
            // txtSymbol
            // 
            this.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbol.Location = new System.Drawing.Point(8, 32);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(137, 13);
            this.txtSymbol.TabIndex = 2;
            this.txtSymbol.TextChanged += new System.EventHandler(this.TxtSymbol_TextChanged);
            this.txtSymbol.MouseEnter += new System.EventHandler(this.TxtSymbol_MouseEnter);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(242, 16);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(55, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "变频描述";
            // 
            // lblSpeedMaxDigits
            // 
            this.lblSpeedMaxDigits.AutoSize = true;
            this.lblSpeedMaxDigits.Location = new System.Drawing.Point(4, 204);
            this.lblSpeedMaxDigits.Name = "lblSpeedMaxDigits";
            this.lblSpeedMaxDigits.Size = new System.Drawing.Size(84, 13);
            this.lblSpeedMaxDigits.TabIndex = 121;
            this.lblSpeedMaxDigits.Text = "SpeedMaxDigits";
            // 
            // chkParProfinet
            // 
            this.chkParProfinet.AutoSize = true;
            this.chkParProfinet.Location = new System.Drawing.Point(234, 287);
            this.chkParProfinet.Name = "chkParProfinet";
            this.chkParProfinet.Size = new System.Drawing.Size(78, 17);
            this.chkParProfinet.TabIndex = 134;
            this.chkParProfinet.Text = "ParProfinet";
            this.chkParProfinet.UseVisualStyleBackColor = true;
            this.chkParProfinet.CheckedChanged += new System.EventHandler(this.chkParProfinet_CheckedChanged);
            this.chkParProfinet.MouseEnter += new System.EventHandler(this.chkParProfinet_MouseEnter);
            // 
            // chkParPZDConsistent
            // 
            this.chkParPZDConsistent.AutoSize = true;
            this.chkParPZDConsistent.Checked = true;
            this.chkParPZDConsistent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkParPZDConsistent.Location = new System.Drawing.Point(234, 269);
            this.chkParPZDConsistent.Name = "chkParPZDConsistent";
            this.chkParPZDConsistent.Size = new System.Drawing.Size(113, 17);
            this.chkParPZDConsistent.TabIndex = 133;
            this.chkParPZDConsistent.Text = "ParPZDConsistent";
            this.chkParPZDConsistent.UseVisualStyleBackColor = true;
            this.chkParPZDConsistent.CheckedChanged += new System.EventHandler(this.chkParPZDConsistent_CheckedChanged);
            this.chkParPZDConsistent.MouseEnter += new System.EventHandler(this.chkParPZDConsistent_MouseEnter);
            // 
            // txtParSpeedMaxDigits
            // 
            this.txtParSpeedMaxDigits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSpeedMaxDigits.Location = new System.Drawing.Point(147, 204);
            this.txtParSpeedMaxDigits.Name = "txtParSpeedMaxDigits";
            this.txtParSpeedMaxDigits.Size = new System.Drawing.Size(63, 13);
            this.txtParSpeedMaxDigits.TabIndex = 122;
            this.txtParSpeedMaxDigits.Text = "16384";
            this.txtParSpeedMaxDigits.MouseEnter += new System.EventHandler(this.txtParSpeedMaxDigits_MouseEnter);
            // 
            // txtValue10
            // 
            this.txtValue10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue10.Enabled = false;
            this.txtValue10.Location = new System.Drawing.Point(376, 289);
            this.txtValue10.Name = "txtValue10";
            this.txtValue10.Size = new System.Drawing.Size(42, 13);
            this.txtValue10.TabIndex = 135;
            this.txtValue10.Text = "1";
            // 
            // txtParLenPKW
            // 
            this.txtParLenPKW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParLenPKW.Location = new System.Drawing.Point(147, 272);
            this.txtParLenPKW.Name = "txtParLenPKW";
            this.txtParLenPKW.Size = new System.Drawing.Size(63, 13);
            this.txtParLenPKW.TabIndex = 132;
            this.txtParLenPKW.Text = "0";
            this.txtParLenPKW.MouseEnter += new System.EventHandler(this.txtParLenPKW_MouseEnter);
            // 
            // lblSpeedUnitsByZeroDigits
            // 
            this.lblSpeedUnitsByZeroDigits.AutoSize = true;
            this.lblSpeedUnitsByZeroDigits.Location = new System.Drawing.Point(4, 221);
            this.lblSpeedUnitsByZeroDigits.Name = "lblSpeedUnitsByZeroDigits";
            this.lblSpeedUnitsByZeroDigits.Size = new System.Drawing.Size(122, 13);
            this.lblSpeedUnitsByZeroDigits.TabIndex = 123;
            this.lblSpeedUnitsByZeroDigits.Text = "SpeedUnitsByZeroDigits";
            // 
            // lblValue10
            // 
            this.lblValue10.AutoSize = true;
            this.lblValue10.Location = new System.Drawing.Point(372, 270);
            this.lblValue10.Name = "lblValue10";
            this.lblValue10.Size = new System.Drawing.Size(46, 13);
            this.lblValue10.TabIndex = 136;
            this.lblValue10.Text = "Value10";
            // 
            // txtParLenPZDInp
            // 
            this.txtParLenPZDInp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParLenPZDInp.Location = new System.Drawing.Point(147, 306);
            this.txtParLenPZDInp.Name = "txtParLenPZDInp";
            this.txtParLenPZDInp.Size = new System.Drawing.Size(63, 13);
            this.txtParLenPZDInp.TabIndex = 140;
            this.txtParLenPZDInp.Text = "0";
            this.txtParLenPZDInp.MouseEnter += new System.EventHandler(this.txtParLenPZDInp_MouseEnter);
            // 
            // lblParLenPKW
            // 
            this.lblParLenPKW.AutoSize = true;
            this.lblParLenPKW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblParLenPKW.Location = new System.Drawing.Point(4, 272);
            this.lblParLenPKW.Name = "lblParLenPKW";
            this.lblParLenPKW.Size = new System.Drawing.Size(66, 13);
            this.lblParLenPKW.TabIndex = 131;
            this.lblParLenPKW.Text = "ParLenPKW";
            // 
            // txtParSpeedUnitsByZeroDigits
            // 
            this.txtParSpeedUnitsByZeroDigits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSpeedUnitsByZeroDigits.Location = new System.Drawing.Point(147, 221);
            this.txtParSpeedUnitsByZeroDigits.Name = "txtParSpeedUnitsByZeroDigits";
            this.txtParSpeedUnitsByZeroDigits.Size = new System.Drawing.Size(63, 13);
            this.txtParSpeedUnitsByZeroDigits.TabIndex = 124;
            this.txtParSpeedUnitsByZeroDigits.Text = "0";
            this.txtParSpeedUnitsByZeroDigits.MouseEnter += new System.EventHandler(this.txtParSpeedUnitsByZeroDigits_MouseEnter);
            // 
            // txtParSpeedLimitMax
            // 
            this.txtParSpeedLimitMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSpeedLimitMax.Location = new System.Drawing.Point(147, 124);
            this.txtParSpeedLimitMax.Name = "txtParSpeedLimitMax";
            this.txtParSpeedLimitMax.Size = new System.Drawing.Size(63, 13);
            this.txtParSpeedLimitMax.TabIndex = 130;
            this.txtParSpeedLimitMax.Text = "100";
            this.txtParSpeedLimitMax.MouseEnter += new System.EventHandler(this.txtParSpeedLimitMax_MouseEnter);
            // 
            // lblParLenPZDInp
            // 
            this.lblParLenPZDInp.AutoSize = true;
            this.lblParLenPZDInp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblParLenPZDInp.Location = new System.Drawing.Point(4, 306);
            this.lblParLenPZDInp.Name = "lblParLenPZDInp";
            this.lblParLenPZDInp.Size = new System.Drawing.Size(78, 13);
            this.lblParLenPZDInp.TabIndex = 139;
            this.lblParLenPZDInp.Text = "ParLenPZDInp";
            this.lblParLenPZDInp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSpeedLimitMax
            // 
            this.LblSpeedLimitMax.AutoSize = true;
            this.LblSpeedLimitMax.Location = new System.Drawing.Point(4, 124);
            this.LblSpeedLimitMax.Name = "LblSpeedLimitMax";
            this.LblSpeedLimitMax.Size = new System.Drawing.Size(79, 13);
            this.LblSpeedLimitMax.TabIndex = 129;
            this.LblSpeedLimitMax.Text = "SpeedLimitMax";
            // 
            // lblSpeedUnitsByMaxDigits
            // 
            this.lblSpeedUnitsByMaxDigits.AutoSize = true;
            this.lblSpeedUnitsByMaxDigits.Location = new System.Drawing.Point(4, 238);
            this.lblSpeedUnitsByMaxDigits.Name = "lblSpeedUnitsByMaxDigits";
            this.lblSpeedUnitsByMaxDigits.Size = new System.Drawing.Size(120, 13);
            this.lblSpeedUnitsByMaxDigits.TabIndex = 125;
            this.lblSpeedUnitsByMaxDigits.Text = "SpeedUnitsByMaxDigits";
            // 
            // txtParSpeedLimitMin
            // 
            this.txtParSpeedLimitMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSpeedLimitMin.Location = new System.Drawing.Point(147, 107);
            this.txtParSpeedLimitMin.Name = "txtParSpeedLimitMin";
            this.txtParSpeedLimitMin.Size = new System.Drawing.Size(63, 13);
            this.txtParSpeedLimitMin.TabIndex = 128;
            this.txtParSpeedLimitMin.Text = "0";
            this.txtParSpeedLimitMin.MouseEnter += new System.EventHandler(this.txtParSpeedLimitMin_MouseEnter);
            // 
            // txtParLenPZD
            // 
            this.txtParLenPZD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParLenPZD.Location = new System.Drawing.Point(147, 289);
            this.txtParLenPZD.Name = "txtParLenPZD";
            this.txtParLenPZD.Size = new System.Drawing.Size(63, 13);
            this.txtParLenPZD.TabIndex = 138;
            this.txtParLenPZD.Text = "0";
            this.txtParLenPZD.MouseEnter += new System.EventHandler(this.txtParLenPZD_MouseEnter);
            // 
            // LblSpeedLimitMin
            // 
            this.LblSpeedLimitMin.AutoSize = true;
            this.LblSpeedLimitMin.Location = new System.Drawing.Point(4, 107);
            this.LblSpeedLimitMin.Name = "LblSpeedLimitMin";
            this.LblSpeedLimitMin.Size = new System.Drawing.Size(76, 13);
            this.LblSpeedLimitMin.TabIndex = 127;
            this.LblSpeedLimitMin.Text = "SpeedLimitMin";
            // 
            // txtParSpeedUnitsByMaxDigits
            // 
            this.txtParSpeedUnitsByMaxDigits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSpeedUnitsByMaxDigits.Location = new System.Drawing.Point(147, 238);
            this.txtParSpeedUnitsByMaxDigits.Name = "txtParSpeedUnitsByMaxDigits";
            this.txtParSpeedUnitsByMaxDigits.Size = new System.Drawing.Size(63, 13);
            this.txtParSpeedUnitsByMaxDigits.TabIndex = 126;
            this.txtParSpeedUnitsByMaxDigits.Text = "100";
            this.txtParSpeedUnitsByMaxDigits.MouseEnter += new System.EventHandler(this.txtParSpeedUnitsByMaxDigits_MouseEnter);
            // 
            // lblParLenPZD
            // 
            this.lblParLenPZD.AutoSize = true;
            this.lblParLenPZD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblParLenPZD.Location = new System.Drawing.Point(4, 289);
            this.lblParLenPZD.Name = "lblParLenPZD";
            this.lblParLenPZD.Size = new System.Drawing.Size(63, 13);
            this.lblParLenPZD.TabIndex = 137;
            this.lblParLenPZD.Text = "ParLenPZD";
            this.lblParLenPZD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.grpBoxExcelData.Controls.Add(this.txtVFCSufffixBML);
            this.grpBoxExcelData.Controls.Add(this.lblVFCSufffixBML);
            this.grpBoxExcelData.Controls.Add(this.txtVFCPrefixBML);
            this.grpBoxExcelData.Controls.Add(this.lblVFCPrefixBML);
            this.grpBoxExcelData.Controls.Add(this.btnReadBML);
            this.grpBoxExcelData.Controls.Add(this.dataGridBML);
            this.grpBoxExcelData.Controls.Add(this.label3);
            this.grpBoxExcelData.Controls.Add(this.comboWorkSheetsBML);
            this.grpBoxExcelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxExcelData.Location = new System.Drawing.Point(3, 121);
            this.grpBoxExcelData.Name = "grpBoxExcelData";
            this.grpBoxExcelData.Size = new System.Drawing.Size(717, 429);
            this.grpBoxExcelData.TabIndex = 16;
            this.grpBoxExcelData.TabStop = false;
            this.grpBoxExcelData.Text = "BML数据";
            // 
            // txtVFCSufffixBML
            // 
            this.txtVFCSufffixBML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVFCSufffixBML.Location = new System.Drawing.Point(550, 27);
            this.txtVFCSufffixBML.Name = "txtVFCSufffixBML";
            this.txtVFCSufffixBML.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtVFCSufffixBML.Size = new System.Drawing.Size(56, 13);
            this.txtVFCSufffixBML.TabIndex = 30;
            this.txtVFCSufffixBML.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVFCSufffixBML
            // 
            this.lblVFCSufffixBML.AutoSize = true;
            this.lblVFCSufffixBML.Location = new System.Drawing.Point(489, 27);
            this.lblVFCSufffixBML.Name = "lblVFCSufffixBML";
            this.lblVFCSufffixBML.Size = new System.Drawing.Size(55, 13);
            this.lblVFCSufffixBML.TabIndex = 31;
            this.lblVFCSufffixBML.Text = "变频后缀";
            // 
            // txtVFCPrefixBML
            // 
            this.txtVFCPrefixBML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVFCPrefixBML.Location = new System.Drawing.Point(421, 27);
            this.txtVFCPrefixBML.Name = "txtVFCPrefixBML";
            this.txtVFCPrefixBML.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtVFCPrefixBML.Size = new System.Drawing.Size(56, 13);
            this.txtVFCPrefixBML.TabIndex = 19;
            this.txtVFCPrefixBML.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVFCPrefixBML
            // 
            this.lblVFCPrefixBML.AutoSize = true;
            this.lblVFCPrefixBML.Location = new System.Drawing.Point(367, 27);
            this.lblVFCPrefixBML.Name = "lblVFCPrefixBML";
            this.lblVFCPrefixBML.Size = new System.Drawing.Size(53, 13);
            this.lblVFCPrefixBML.TabIndex = 29;
            this.lblVFCPrefixBML.Text = "BML前缀";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "工作表";
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
            this.grpBoxExcelColumn.Controls.Add(this.BtnOpenProjectBML);
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
            this.grpBoxBMLColum.Controls.Add(this.comboControlBML);
            this.grpBoxBMLColum.Controls.Add(this.lblControlBML);
            this.grpBoxBMLColum.Controls.Add(this.comboStartRow);
            this.grpBoxBMLColum.Controls.Add(this.comboSectionBML);
            this.grpBoxBMLColum.Controls.Add(this.lblStartRow);
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
            this.grpBoxBMLColum.Size = new System.Drawing.Size(692, 68);
            this.grpBoxBMLColum.TabIndex = 16;
            this.grpBoxBMLColum.TabStop = false;
            this.grpBoxBMLColum.Text = "信息列";
            // 
            // comboControlBML
            // 
            this.comboControlBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboControlBML.FormattingEnabled = true;
            this.comboControlBML.IntegralHeight = false;
            this.comboControlBML.Location = new System.Drawing.Point(349, 19);
            this.comboControlBML.Name = "comboControlBML";
            this.comboControlBML.Size = new System.Drawing.Size(66, 21);
            this.comboControlBML.TabIndex = 29;
            // 
            // lblControlBML
            // 
            this.lblControlBML.AutoSize = true;
            this.lblControlBML.Location = new System.Drawing.Point(289, 21);
            this.lblControlBML.Name = "lblControlBML";
            this.lblControlBML.Size = new System.Drawing.Size(67, 13);
            this.lblControlBML.TabIndex = 28;
            this.lblControlBML.Text = "控制方法：";
            // 
            // comboStartRow
            // 
            this.comboStartRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStartRow.FormattingEnabled = true;
            this.comboStartRow.IntegralHeight = false;
            this.comboStartRow.Location = new System.Drawing.Point(622, 16);
            this.comboStartRow.Name = "comboStartRow";
            this.comboStartRow.Size = new System.Drawing.Size(66, 21);
            this.comboStartRow.TabIndex = 28;
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
            // lblStartRow
            // 
            this.lblStartRow.AutoSize = true;
            this.lblStartRow.Location = new System.Drawing.Point(581, 19);
            this.lblStartRow.Name = "lblStartRow";
            this.lblStartRow.Size = new System.Drawing.Size(43, 13);
            this.lblStartRow.TabIndex = 28;
            this.lblStartRow.Text = "起始行";
            // 
            // comboPowerBML
            // 
            this.comboPowerBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPowerBML.FormattingEnabled = true;
            this.comboPowerBML.IntegralHeight = false;
            this.comboPowerBML.Location = new System.Drawing.Point(206, 44);
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
            this.comboFloorBML.Location = new System.Drawing.Point(349, 44);
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
            this.lblFloor.Location = new System.Drawing.Point(300, 47);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(43, 13);
            this.lblFloor.TabIndex = 12;
            this.lblFloor.Text = "楼层：";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(440, 47);
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
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(157, 49);
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
            // BtnOpenProjectBML
            // 
            this.BtnOpenProjectBML.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.BtnOpenProjectBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenProjectBML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOpenProjectBML.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenProjectBML.Image")));
            this.BtnOpenProjectBML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenProjectBML.Location = new System.Drawing.Point(609, 11);
            this.BtnOpenProjectBML.Name = "BtnOpenProjectBML";
            this.BtnOpenProjectBML.Size = new System.Drawing.Size(89, 27);
            this.BtnOpenProjectBML.TabIndex = 17;
            this.BtnOpenProjectBML.Text = "    浏 览";
            this.BtnOpenProjectBML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOpenProjectBML.UseVisualStyleBackColor = true;
            this.BtnOpenProjectBML.Click += new System.EventHandler(this.BtnOpenProjectBML_Click);
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
            this.LblPanel.Size = new System.Drawing.Size(37, 13);
            this.LblPanel.TabIndex = 49;
            this.LblPanel.Text = "Panel:";
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
            this.LblElevation.Size = new System.Drawing.Size(33, 13);
            this.LblElevation.TabIndex = 47;
            this.LblElevation.Text = "Floor:";
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
            this.LblBuilding.Size = new System.Drawing.Size(49, 13);
            this.LblBuilding.TabIndex = 45;
            this.LblBuilding.Text = "Buildling:";
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
            this.LblProcessFct.Size = new System.Drawing.Size(66, 13);
            this.LblProcessFct.TabIndex = 43;
            this.LblProcessFct.Text = "Process Fct:";
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
            this.LblEquipmentSubType.Size = new System.Drawing.Size(49, 13);
            this.LblEquipmentSubType.TabIndex = 41;
            this.LblEquipmentSubType.Text = "Subtype:";
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
            this.lblPage.Size = new System.Drawing.Size(35, 13);
            this.lblPage.TabIndex = 58;
            this.lblPage.Text = "Page:";
            // 
            // FormVFCAdapter
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
            this.Name = "FormVFCAdapter";
            this.Text = "EL_VFCAdapter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVFCAdapter_FormClosed);
            this.Load += new System.EventHandler(this.FormVFCAdapter_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCreateMode.ResumeLayout(false);
            this.contextMenuStripBML.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.tabRule.PerformLayout();
            this.PalGcObject.ResumeLayout(false);
            this.grpSinamics.ResumeLayout(false);
            this.grpSinamics.PerformLayout();
            this.grpTelegramm5.ResumeLayout(false);
            this.grpTelegramm5.PerformLayout();
            this.grpTelegramm4.ResumeLayout(false);
            this.grpTelegramm4.PerformLayout();
            this.grpTelegramm3.ResumeLayout(false);
            this.grpTelegramm3.PerformLayout();
            this.grpTelegramm2.ResumeLayout(false);
            this.grpTelegramm2.PerformLayout();
            this.grpTelegramm1.ResumeLayout(false);
            this.grpTelegramm1.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpIOByte.ResumeLayout(false);
            this.grpIOByte.PerformLayout();
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
        internal System.Windows.Forms.Button BtnNewImpExpDef;
        internal System.Windows.Forms.Button BtnConnectIO;
        private System.Windows.Forms.GroupBox grpBoxExcelColumn;
        private System.Windows.Forms.Label lblBMLSymbol;
        private System.Windows.Forms.Label lblBMLDescription;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox comboWorkSheetsBML;
        internal System.Windows.Forms.TextBox txtPage;
        internal System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        internal System.Windows.Forms.Button BtnOpenProjectBML;
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
        internal System.Windows.Forms.ComboBox comboControlBML;
        private System.Windows.Forms.Label lblControlBML;
        internal System.Windows.Forms.TextBox txtVFCPrefixBML;
        private System.Windows.Forms.Label lblVFCPrefixBML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        internal System.Windows.Forms.CheckBox chkParWithActivePower;
        internal System.Windows.Forms.GroupBox grpIOByte;
        internal System.Windows.Forms.TextBox txtIOByteIncRule;
        internal System.Windows.Forms.Label tblFParIOByte;
        internal System.Windows.Forms.Label tblIOByteIncRule;
        internal System.Windows.Forms.TextBox txtParIOByte;
        internal System.Windows.Forms.GroupBox grpTelegramm5;
        internal System.Windows.Forms.TextBox txtParUnitsPerDigit_T5;
        internal System.Windows.Forms.Label lblParUnitsPerDigit_T5;
        internal System.Windows.Forms.TextBox txtParPNO_T5;
        internal System.Windows.Forms.Label lblParPNO_T5;
        internal System.Windows.Forms.Label LblDPNode1;
        internal System.Windows.Forms.GroupBox grpTelegramm4;
        internal System.Windows.Forms.TextBox txtParUnitsPerDigit_T4;
        internal System.Windows.Forms.Label lblParUnitsPerDigit_T4;
        internal System.Windows.Forms.TextBox txtParPNO_T4;
        internal System.Windows.Forms.Label lblParPNO_T4;
        internal System.Windows.Forms.ComboBox ComboDPNode1;
        internal System.Windows.Forms.GroupBox grpTelegramm3;
        internal System.Windows.Forms.TextBox txtParUnitsPerDigit_T3;
        internal System.Windows.Forms.Label lblParUnitsPerDigit_T3;
        internal System.Windows.Forms.TextBox txtParPNO_T3;
        internal System.Windows.Forms.Label lblParPNO_T3;
        internal System.Windows.Forms.Label lblSpeedMaxDigits;
        internal System.Windows.Forms.GroupBox grpTelegramm2;
        internal System.Windows.Forms.TextBox txtParUnitsPerDigit_T2;
        internal System.Windows.Forms.Label lblParUnitsPerDigit_T2;
        internal System.Windows.Forms.TextBox txtParPNO_T2;
        internal System.Windows.Forms.Label lblParPNO_T2;
        internal System.Windows.Forms.TextBox txtParSpeedMaxDigits;
        internal System.Windows.Forms.GroupBox grpTelegramm1;
        internal System.Windows.Forms.TextBox txtParUnitsPerDigit_T1;
        internal System.Windows.Forms.Label lblParUnitsPerDigit_T1;
        internal System.Windows.Forms.TextBox txtParPNO_T1;
        internal System.Windows.Forms.Label lblParPNO_T1;
        internal System.Windows.Forms.Label lblSpeedUnitsByZeroDigits;
        internal System.Windows.Forms.TextBox txtParLenPZDInp;
        internal System.Windows.Forms.TextBox txtParSpeedUnitsByZeroDigits;
        internal System.Windows.Forms.Label lblParLenPZDInp;
        internal System.Windows.Forms.Label lblSpeedUnitsByMaxDigits;
        internal System.Windows.Forms.TextBox txtParLenPZD;
        internal System.Windows.Forms.TextBox txtParSpeedUnitsByMaxDigits;
        internal System.Windows.Forms.Label lblParLenPZD;
        internal System.Windows.Forms.Label LblSpeedLimitMin;
        internal System.Windows.Forms.TextBox txtParSpeedLimitMin;
        internal System.Windows.Forms.Label LblSpeedLimitMax;
        internal System.Windows.Forms.TextBox txtParSpeedLimitMax;
        internal System.Windows.Forms.Label lblParLenPKW;
        internal System.Windows.Forms.Label lblValue10;
        internal System.Windows.Forms.TextBox txtParLenPKW;
        internal System.Windows.Forms.TextBox txtValue10;
        internal System.Windows.Forms.CheckBox chkParPZDConsistent;
        internal System.Windows.Forms.CheckBox chkParProfinet;
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
        internal System.Windows.Forms.Label lblMEAGGateway;
        internal System.Windows.Forms.TextBox txtMEAGGateway;
        internal System.Windows.Forms.Label lblParSlaveIndex;
        internal System.Windows.Forms.TextBox txtOutpHardwareStop;
        internal System.Windows.Forms.TextBox txtParSalveIndex;
        internal System.Windows.Forms.Label lblOutpHardwareStop;
        internal System.Windows.Forms.TextBox txtParUnitsPerDigits;
        internal System.Windows.Forms.Label lblUnitsPerDigits;
        internal System.Windows.Forms.GroupBox grpSinamics;
        internal System.Windows.Forms.CheckBox chkWithMultiMotorCfg;
        internal System.Windows.Forms.TextBox txtParRefTorque;
        internal System.Windows.Forms.Label lblParRefTorque;
        internal System.Windows.Forms.TextBox txtParRefCurrent;
        internal System.Windows.Forms.Label lblParRefCurrent;
        internal System.Windows.Forms.TextBox txtParRefPower;
        internal System.Windows.Forms.Label lblParRefPower;
        internal System.Windows.Forms.TextBox txtParSlaveIndexIncRule;
        internal System.Windows.Forms.Label lblParSlaveIndexIncRule;
        internal System.Windows.Forms.TextBox txtVFCSufffixBML;
        private System.Windows.Forms.Label lblVFCSufffixBML;
    }
}

