using System;

namespace GcproExtensionApp
{
    partial class FormMA_Discharger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMA_Discharger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtParRestDischargeTime = new System.Windows.Forms.TextBox();
            this.lblParRestDischargeTime = new System.Windows.Forms.Label();
            this.txtParVibroOffTime = new System.Windows.Forms.TextBox();
            this.lblParVibroOffTime = new System.Windows.Forms.Label();
            this.txtParVibroOnTime = new System.Windows.Forms.TextBox();
            this.lblParVibroOnTime = new System.Windows.Forms.Label();
            this.lblDischarger = new System.Windows.Forms.Label();
            this.lblVibro = new System.Windows.Forms.Label();
            this.txtDischarger = new System.Windows.Forms.TextBox();
            this.lblLSFlow = new System.Windows.Forms.Label();
            this.lblLLBin = new System.Windows.Forms.Label();
            this.txtVibro = new System.Windows.Forms.TextBox();
            this.txtLSFlow = new System.Windows.Forms.TextBox();
            this.txtDischargerRule = new System.Windows.Forms.TextBox();
            this.txtDischargerIncRule = new System.Windows.Forms.TextBox();
            this.txtLLBin = new System.Windows.Forms.TextBox();
            this.lblDischargerRule = new System.Windows.Forms.Label();
            this.LblLLBinIncRule = new System.Windows.Forms.Label();
            this.LblDischargerIncRule = new System.Windows.Forms.Label();
            this.lblLLBinRule = new System.Windows.Forms.Label();
            this.txtVibroRule = new System.Windows.Forms.TextBox();
            this.txtLLBinIncRule = new System.Windows.Forms.TextBox();
            this.txtVibroIncRule = new System.Windows.Forms.TextBox();
            this.txtLLBinRule = new System.Windows.Forms.TextBox();
            this.lblVibroRule = new System.Windows.Forms.Label();
            this.LblLSFlowIncRule = new System.Windows.Forms.Label();
            this.LblVibroIncRule = new System.Windows.Forms.Label();
            this.lblLSFlowRule = new System.Windows.Forms.Label();
            this.txtLSFlowRule = new System.Windows.Forms.TextBox();
            this.txtLSFlowIncRule = new System.Windows.Forms.TextBox();
            this.chkParContinuous = new System.Windows.Forms.CheckBox();
            this.chkParWithVibro = new System.Windows.Forms.CheckBox();
            this.chkParWithLL = new System.Windows.Forms.CheckBox();
            this.chkParWithFlow = new System.Windows.Forms.CheckBox();
            this.chkParDischargerIsMotor = new System.Windows.Forms.CheckBox();
            this.txtValue10 = new System.Windows.Forms.TextBox();
            this.lblValue10 = new System.Windows.Forms.Label();
            this.grpReferences = new System.Windows.Forms.GroupBox();
            this.lblSenderBinIncRule = new System.Windows.Forms.Label();
            this.lblSenderBinRule = new System.Windows.Forms.Label();
            this.txtSenderBin = new System.Windows.Forms.TextBox();
            this.txtSenderBinIncRule = new System.Windows.Forms.TextBox();
            this.lblSenderBin = new System.Windows.Forms.Label();
            this.txtSenderBinRule = new System.Windows.Forms.TextBox();
            this.lblReceiverIncRule = new System.Windows.Forms.Label();
            this.lblReceiverRule = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtReceiverIncRule = new System.Windows.Forms.TextBox();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.txtReceiverRule = new System.Windows.Forms.TextBox();
            this.chkOnlyFree = new System.Windows.Forms.CheckBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.grpAddInfoToDesc = new System.Windows.Forms.GroupBox();
            this.chkAddUserSectionToDesc = new System.Windows.Forms.CheckBox();
            this.chkNameOnlyNumber = new System.Windows.Forms.CheckBox();
            this.chkAddSectionToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddNameToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddFloorToDesc = new System.Windows.Forms.CheckBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.grpDescriptionRule = new System.Windows.Forms.GroupBox();
            this.lblDescriptionRule = new System.Windows.Forms.Label();
            this.txtDescriptionIncRule = new System.Windows.Forms.TextBox();
            this.lblDescriptionIncRule = new System.Windows.Forms.Label();
            this.txtDescriptionRule = new System.Windows.Forms.TextBox();
            this.grpSymbolRule = new System.Windows.Forms.GroupBox();
            this.lblSymbolRule = new System.Windows.Forms.Label();
            this.txtSymbolRule = new System.Windows.Forms.TextBox();
            this.txtSymbolIncRule = new System.Windows.Forms.TextBox();
            this.lblSymbolIncRule = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.BtnNewImpExpDef = new System.Windows.Forms.Button();
            this.LblEquipmentInfoType = new System.Windows.Forms.Label();
            this.ComboEquipmentInfoType = new System.Windows.Forms.ComboBox();
            this.BtnConnectIO = new System.Windows.Forms.Button();
            this.tabBML = new System.Windows.Forms.TabPage();
            this.grpBoxExcelData = new System.Windows.Forms.GroupBox();
            this.btnReadBML = new System.Windows.Forms.Button();
            this.dataGridBML = new System.Windows.Forms.DataGridView();
            this.lblWorkSheet = new System.Windows.Forms.Label();
            this.comboWorkSheetsBML = new System.Windows.Forms.ComboBox();
            this.grpBoxExcelColumn = new System.Windows.Forms.GroupBox();
            this.grpBoxBMLColum = new System.Windows.Forms.GroupBox();
            this.comboControlBML = new System.Windows.Forms.ComboBox();
            this.lblControlBML = new System.Windows.Forms.Label();
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
            this.statusStrip.SuspendLayout();
            this.tabCreateMode.SuspendLayout();
            this.contextMenuStripBML.SuspendLayout();
            this.tabRule.SuspendLayout();
            this.PalGcObject.SuspendLayout();
            this.grpReferences.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpAddInfoToDesc.SuspendLayout();
            this.grpDescriptionRule.SuspendLayout();
            this.grpSymbolRule.SuspendLayout();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 732);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(730, 22);
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
            this.tabCreateMode.Size = new System.Drawing.Size(730, 528);
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
            this.tabRule.Size = new System.Drawing.Size(722, 502);
            this.tabRule.TabIndex = 0;
            this.tabRule.Text = "设定规则创建";
            // 
            // PalGcObject
            // 
            this.PalGcObject.AutoScroll = true;
            this.PalGcObject.AutoSize = true;
            this.PalGcObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PalGcObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PalGcObject.Controls.Add(this.txtParRestDischargeTime);
            this.PalGcObject.Controls.Add(this.lblParRestDischargeTime);
            this.PalGcObject.Controls.Add(this.txtParVibroOffTime);
            this.PalGcObject.Controls.Add(this.lblParVibroOffTime);
            this.PalGcObject.Controls.Add(this.txtParVibroOnTime);
            this.PalGcObject.Controls.Add(this.lblParVibroOnTime);
            this.PalGcObject.Controls.Add(this.lblDischarger);
            this.PalGcObject.Controls.Add(this.lblVibro);
            this.PalGcObject.Controls.Add(this.txtDischarger);
            this.PalGcObject.Controls.Add(this.lblLSFlow);
            this.PalGcObject.Controls.Add(this.lblLLBin);
            this.PalGcObject.Controls.Add(this.txtVibro);
            this.PalGcObject.Controls.Add(this.txtLSFlow);
            this.PalGcObject.Controls.Add(this.txtDischargerRule);
            this.PalGcObject.Controls.Add(this.txtDischargerIncRule);
            this.PalGcObject.Controls.Add(this.txtLLBin);
            this.PalGcObject.Controls.Add(this.lblDischargerRule);
            this.PalGcObject.Controls.Add(this.LblLLBinIncRule);
            this.PalGcObject.Controls.Add(this.LblDischargerIncRule);
            this.PalGcObject.Controls.Add(this.lblLLBinRule);
            this.PalGcObject.Controls.Add(this.txtVibroRule);
            this.PalGcObject.Controls.Add(this.txtLLBinIncRule);
            this.PalGcObject.Controls.Add(this.txtVibroIncRule);
            this.PalGcObject.Controls.Add(this.txtLLBinRule);
            this.PalGcObject.Controls.Add(this.lblVibroRule);
            this.PalGcObject.Controls.Add(this.LblLSFlowIncRule);
            this.PalGcObject.Controls.Add(this.LblVibroIncRule);
            this.PalGcObject.Controls.Add(this.lblLSFlowRule);
            this.PalGcObject.Controls.Add(this.txtLSFlowRule);
            this.PalGcObject.Controls.Add(this.txtLSFlowIncRule);
            this.PalGcObject.Controls.Add(this.chkParContinuous);
            this.PalGcObject.Controls.Add(this.chkParWithVibro);
            this.PalGcObject.Controls.Add(this.chkParWithLL);
            this.PalGcObject.Controls.Add(this.chkParWithFlow);
            this.PalGcObject.Controls.Add(this.chkParDischargerIsMotor);
            this.PalGcObject.Controls.Add(this.txtValue10);
            this.PalGcObject.Controls.Add(this.lblValue10);
            this.PalGcObject.Controls.Add(this.grpReferences);
            this.PalGcObject.Controls.Add(this.chkOnlyFree);
            this.PalGcObject.Controls.Add(this.grpGeneral);
            this.PalGcObject.Controls.Add(this.BtnNewImpExpDef);
            this.PalGcObject.Controls.Add(this.LblEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.ComboEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.BtnConnectIO);
            this.PalGcObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalGcObject.Location = new System.Drawing.Point(3, 3);
            this.PalGcObject.Name = "PalGcObject";
            this.PalGcObject.Size = new System.Drawing.Size(716, 496);
            this.PalGcObject.TabIndex = 105;
            // 
            // txtParRestDischargeTime
            // 
            this.txtParRestDischargeTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtParRestDischargeTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParRestDischargeTime.Location = new System.Drawing.Point(381, 317);
            this.txtParRestDischargeTime.Name = "txtParRestDischargeTime";
            this.txtParRestDischargeTime.Size = new System.Drawing.Size(73, 13);
            this.txtParRestDischargeTime.TabIndex = 318;
            this.txtParRestDischargeTime.Text = "0.0";
            this.txtParRestDischargeTime.MouseEnter += new System.EventHandler(this.txtParRestDischargeTime_MouseEnter);
            // 
            // lblParRestDischargeTime
            // 
            this.lblParRestDischargeTime.AutoSize = true;
            this.lblParRestDischargeTime.Location = new System.Drawing.Point(228, 317);
            this.lblParRestDischargeTime.Name = "lblParRestDischargeTime";
            this.lblParRestDischargeTime.Size = new System.Drawing.Size(127, 13);
            this.lblParRestDischargeTime.TabIndex = 317;
            this.lblParRestDischargeTime.Text = "ParRestDischargeTime[s]";
            // 
            // txtParVibroOffTime
            // 
            this.txtParVibroOffTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtParVibroOffTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParVibroOffTime.Location = new System.Drawing.Point(118, 341);
            this.txtParVibroOffTime.Name = "txtParVibroOffTime";
            this.txtParVibroOffTime.Size = new System.Drawing.Size(73, 13);
            this.txtParVibroOffTime.TabIndex = 316;
            this.txtParVibroOffTime.Text = "30.0";
            this.txtParVibroOffTime.MouseEnter += new System.EventHandler(this.txtParVibroOffTime_MouseEnter);
            // 
            // lblParVibroOffTime
            // 
            this.lblParVibroOffTime.AutoSize = true;
            this.lblParVibroOffTime.Location = new System.Drawing.Point(2, 339);
            this.lblParVibroOffTime.Name = "lblParVibroOffTime";
            this.lblParVibroOffTime.Size = new System.Drawing.Size(95, 13);
            this.lblParVibroOffTime.TabIndex = 315;
            this.lblParVibroOffTime.Text = "ParVibroOffTime[s]";
            // 
            // txtParVibroOnTime
            // 
            this.txtParVibroOnTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtParVibroOnTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParVibroOnTime.Location = new System.Drawing.Point(119, 317);
            this.txtParVibroOnTime.Name = "txtParVibroOnTime";
            this.txtParVibroOnTime.Size = new System.Drawing.Size(73, 13);
            this.txtParVibroOnTime.TabIndex = 314;
            this.txtParVibroOnTime.Text = "10.0";
            this.txtParVibroOnTime.MouseEnter += new System.EventHandler(this.txtParVibroOnTime_MouseEnter);
            // 
            // lblParVibroOnTime
            // 
            this.lblParVibroOnTime.AutoSize = true;
            this.lblParVibroOnTime.Location = new System.Drawing.Point(3, 315);
            this.lblParVibroOnTime.Name = "lblParVibroOnTime";
            this.lblParVibroOnTime.Size = new System.Drawing.Size(95, 13);
            this.lblParVibroOnTime.TabIndex = 313;
            this.lblParVibroOnTime.Text = "ParVibroOnTime[s]";
            // 
            // lblDischarger
            // 
            this.lblDischarger.AutoSize = true;
            this.lblDischarger.Location = new System.Drawing.Point(6, 204);
            this.lblDischarger.Name = "lblDischarger";
            this.lblDischarger.Size = new System.Drawing.Size(58, 13);
            this.lblDischarger.TabIndex = 274;
            this.lblDischarger.Text = "Discharger";
            // 
            // lblVibro
            // 
            this.lblVibro.AutoSize = true;
            this.lblVibro.Location = new System.Drawing.Point(6, 227);
            this.lblVibro.Name = "lblVibro";
            this.lblVibro.Size = new System.Drawing.Size(31, 13);
            this.lblVibro.TabIndex = 275;
            this.lblVibro.Text = "Vibro";
            // 
            // txtDischarger
            // 
            this.txtDischarger.BackColor = System.Drawing.SystemColors.Window;
            this.txtDischarger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDischarger.Location = new System.Drawing.Point(119, 205);
            this.txtDischarger.Name = "txtDischarger";
            this.txtDischarger.Size = new System.Drawing.Size(100, 13);
            this.txtDischarger.TabIndex = 276;
            this.txtDischarger.TextChanged += new System.EventHandler(this.txtDischarger_TextChanged);
            // 
            // lblLSFlow
            // 
            this.lblLSFlow.AutoSize = true;
            this.lblLSFlow.Location = new System.Drawing.Point(6, 250);
            this.lblLSFlow.Name = "lblLSFlow";
            this.lblLSFlow.Size = new System.Drawing.Size(45, 13);
            this.lblLSFlow.TabIndex = 277;
            this.lblLSFlow.Text = "LS Flow";
            // 
            // lblLLBin
            // 
            this.lblLLBin.AutoSize = true;
            this.lblLLBin.Location = new System.Drawing.Point(6, 273);
            this.lblLLBin.Name = "lblLLBin";
            this.lblLLBin.Size = new System.Drawing.Size(37, 13);
            this.lblLLBin.TabIndex = 278;
            this.lblLLBin.Text = "LL Bin";
            // 
            // txtVibro
            // 
            this.txtVibro.BackColor = System.Drawing.SystemColors.Window;
            this.txtVibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVibro.Location = new System.Drawing.Point(119, 228);
            this.txtVibro.Name = "txtVibro";
            this.txtVibro.Size = new System.Drawing.Size(100, 13);
            this.txtVibro.TabIndex = 279;
            this.txtVibro.TextChanged += new System.EventHandler(this.txtVibro_TextChanged);
            // 
            // txtLSFlow
            // 
            this.txtLSFlow.BackColor = System.Drawing.SystemColors.Window;
            this.txtLSFlow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLSFlow.Location = new System.Drawing.Point(119, 251);
            this.txtLSFlow.Name = "txtLSFlow";
            this.txtLSFlow.Size = new System.Drawing.Size(100, 13);
            this.txtLSFlow.TabIndex = 280;
            this.txtLSFlow.TextChanged += new System.EventHandler(this.txtLSFlow_TextChanged);
            this.txtLSFlow.MouseEnter += new System.EventHandler(this.txtLSFlow_MouseEnter);
            // 
            // txtDischargerRule
            // 
            this.txtDischargerRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDischargerRule.Location = new System.Drawing.Point(278, 205);
            this.txtDischargerRule.Name = "txtDischargerRule";
            this.txtDischargerRule.Size = new System.Drawing.Size(66, 13);
            this.txtDischargerRule.TabIndex = 271;
            this.txtDischargerRule.TextChanged += new System.EventHandler(this.txtDischargerRule_TextChanged);
            // 
            // txtDischargerIncRule
            // 
            this.txtDischargerIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDischargerIncRule.Location = new System.Drawing.Point(408, 205);
            this.txtDischargerIncRule.Name = "txtDischargerIncRule";
            this.txtDischargerIncRule.Size = new System.Drawing.Size(46, 13);
            this.txtDischargerIncRule.TabIndex = 272;
            this.txtDischargerIncRule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDischargerIncRule.TextChanged += new System.EventHandler(this.txtDischargerIncRule_TextChanged);
            // 
            // txtLLBin
            // 
            this.txtLLBin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLLBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLLBin.Location = new System.Drawing.Point(119, 274);
            this.txtLLBin.Name = "txtLLBin";
            this.txtLLBin.Size = new System.Drawing.Size(100, 13);
            this.txtLLBin.TabIndex = 281;
            this.txtLLBin.TextChanged += new System.EventHandler(this.txtLLBin_TextChanged);
            // 
            // lblDischargerRule
            // 
            this.lblDischargerRule.AutoSize = true;
            this.lblDischargerRule.Location = new System.Drawing.Point(222, 204);
            this.lblDischargerRule.Name = "lblDischargerRule";
            this.lblDischargerRule.Size = new System.Drawing.Size(55, 13);
            this.lblDischargerRule.TabIndex = 270;
            this.lblDischargerRule.Text = "规则字段";
            // 
            // LblLLBinIncRule
            // 
            this.LblLLBinIncRule.AutoSize = true;
            this.LblLLBinIncRule.Location = new System.Drawing.Point(348, 273);
            this.LblLLBinIncRule.Name = "LblLLBinIncRule";
            this.LblLLBinIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblLLBinIncRule.TabIndex = 293;
            this.LblLLBinIncRule.Text = "递增规则";
            // 
            // LblDischargerIncRule
            // 
            this.LblDischargerIncRule.AutoSize = true;
            this.LblDischargerIncRule.Location = new System.Drawing.Point(348, 204);
            this.LblDischargerIncRule.Name = "LblDischargerIncRule";
            this.LblDischargerIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblDischargerIncRule.TabIndex = 273;
            this.LblDischargerIncRule.Text = "递增规则";
            // 
            // lblLLBinRule
            // 
            this.lblLLBinRule.AutoSize = true;
            this.lblLLBinRule.Location = new System.Drawing.Point(222, 273);
            this.lblLLBinRule.Name = "lblLLBinRule";
            this.lblLLBinRule.Size = new System.Drawing.Size(55, 13);
            this.lblLLBinRule.TabIndex = 290;
            this.lblLLBinRule.Text = "规则字段";
            // 
            // txtVibroRule
            // 
            this.txtVibroRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVibroRule.Location = new System.Drawing.Point(278, 228);
            this.txtVibroRule.Name = "txtVibroRule";
            this.txtVibroRule.Size = new System.Drawing.Size(66, 13);
            this.txtVibroRule.TabIndex = 283;
            this.txtVibroRule.TextChanged += new System.EventHandler(this.txtVibroRule_TextChanged);
            // 
            // txtLLBinIncRule
            // 
            this.txtLLBinIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLLBinIncRule.Location = new System.Drawing.Point(408, 274);
            this.txtLLBinIncRule.Name = "txtLLBinIncRule";
            this.txtLLBinIncRule.Size = new System.Drawing.Size(46, 13);
            this.txtLLBinIncRule.TabIndex = 292;
            this.txtLLBinIncRule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLLBinIncRule.TextChanged += new System.EventHandler(this.txtLLBinIncRule_TextChanged);
            // 
            // txtVibroIncRule
            // 
            this.txtVibroIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVibroIncRule.Location = new System.Drawing.Point(408, 228);
            this.txtVibroIncRule.Name = "txtVibroIncRule";
            this.txtVibroIncRule.Size = new System.Drawing.Size(46, 13);
            this.txtVibroIncRule.TabIndex = 284;
            this.txtVibroIncRule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVibroIncRule.TextChanged += new System.EventHandler(this.txtVibroIncRule_TextChanged);
            // 
            // txtLLBinRule
            // 
            this.txtLLBinRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLLBinRule.Location = new System.Drawing.Point(278, 274);
            this.txtLLBinRule.Name = "txtLLBinRule";
            this.txtLLBinRule.Size = new System.Drawing.Size(66, 13);
            this.txtLLBinRule.TabIndex = 291;
            this.txtLLBinRule.TextChanged += new System.EventHandler(this.txtLLBinRule_TextChanged);
            // 
            // lblVibroRule
            // 
            this.lblVibroRule.AutoSize = true;
            this.lblVibroRule.Location = new System.Drawing.Point(222, 227);
            this.lblVibroRule.Name = "lblVibroRule";
            this.lblVibroRule.Size = new System.Drawing.Size(55, 13);
            this.lblVibroRule.TabIndex = 282;
            this.lblVibroRule.Text = "规则字段";
            // 
            // LblLSFlowIncRule
            // 
            this.LblLSFlowIncRule.AutoSize = true;
            this.LblLSFlowIncRule.Location = new System.Drawing.Point(348, 250);
            this.LblLSFlowIncRule.Name = "LblLSFlowIncRule";
            this.LblLSFlowIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblLSFlowIncRule.TabIndex = 289;
            this.LblLSFlowIncRule.Text = "递增规则";
            // 
            // LblVibroIncRule
            // 
            this.LblVibroIncRule.AutoSize = true;
            this.LblVibroIncRule.Location = new System.Drawing.Point(348, 227);
            this.LblVibroIncRule.Name = "LblVibroIncRule";
            this.LblVibroIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblVibroIncRule.TabIndex = 285;
            this.LblVibroIncRule.Text = "递增规则";
            // 
            // lblLSFlowRule
            // 
            this.lblLSFlowRule.AutoSize = true;
            this.lblLSFlowRule.Location = new System.Drawing.Point(222, 250);
            this.lblLSFlowRule.Name = "lblLSFlowRule";
            this.lblLSFlowRule.Size = new System.Drawing.Size(55, 13);
            this.lblLSFlowRule.TabIndex = 286;
            this.lblLSFlowRule.Text = "规则字段";
            // 
            // txtLSFlowRule
            // 
            this.txtLSFlowRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLSFlowRule.Location = new System.Drawing.Point(278, 251);
            this.txtLSFlowRule.Name = "txtLSFlowRule";
            this.txtLSFlowRule.Size = new System.Drawing.Size(66, 13);
            this.txtLSFlowRule.TabIndex = 287;
            this.txtLSFlowRule.TextChanged += new System.EventHandler(this.txtLSFlowRule_TextChanged);
            // 
            // txtLSFlowIncRule
            // 
            this.txtLSFlowIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLSFlowIncRule.Location = new System.Drawing.Point(408, 251);
            this.txtLSFlowIncRule.Name = "txtLSFlowIncRule";
            this.txtLSFlowIncRule.Size = new System.Drawing.Size(46, 13);
            this.txtLSFlowIncRule.TabIndex = 288;
            this.txtLSFlowIncRule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLSFlowIncRule.TextChanged += new System.EventHandler(this.txtLSFlowIncRule_TextChanged);
            // 
            // chkParContinuous
            // 
            this.chkParContinuous.AutoSize = true;
            this.chkParContinuous.Location = new System.Drawing.Point(492, 170);
            this.chkParContinuous.Name = "chkParContinuous";
            this.chkParContinuous.Size = new System.Drawing.Size(95, 17);
            this.chkParContinuous.TabIndex = 258;
            this.chkParContinuous.Text = "ParContinuous";
            this.chkParContinuous.UseVisualStyleBackColor = true;
            this.chkParContinuous.CheckedChanged += new System.EventHandler(this.chkParContinuous_CheckedChanged);
            this.chkParContinuous.MouseEnter += new System.EventHandler(this.chkParContinuous_MouseEnter);
            // 
            // chkParWithVibro
            // 
            this.chkParWithVibro.AutoSize = true;
            this.chkParWithVibro.Location = new System.Drawing.Point(492, 191);
            this.chkParWithVibro.Name = "chkParWithVibro";
            this.chkParWithVibro.Size = new System.Drawing.Size(88, 17);
            this.chkParWithVibro.TabIndex = 259;
            this.chkParWithVibro.Text = "ParWithVibro";
            this.chkParWithVibro.UseVisualStyleBackColor = true;
            this.chkParWithVibro.CheckedChanged += new System.EventHandler(this.chkParWithVibro_CheckedChanged);
            this.chkParWithVibro.MouseEnter += new System.EventHandler(this.chkParWithVibro_MouseEnter);
            // 
            // chkParWithLL
            // 
            this.chkParWithLL.AutoSize = true;
            this.chkParWithLL.Location = new System.Drawing.Point(492, 212);
            this.chkParWithLL.Name = "chkParWithLL";
            this.chkParWithLL.Size = new System.Drawing.Size(76, 17);
            this.chkParWithLL.TabIndex = 260;
            this.chkParWithLL.Tag = "";
            this.chkParWithLL.Text = "ParWithLL";
            this.chkParWithLL.UseVisualStyleBackColor = true;
            this.chkParWithLL.CheckedChanged += new System.EventHandler(this.chkParWithLLBin_CheckedChanged);
            this.chkParWithLL.MouseEnter += new System.EventHandler(this.chkParWithLL_MouseEnter);
            // 
            // chkParWithFlow
            // 
            this.chkParWithFlow.AutoSize = true;
            this.chkParWithFlow.Location = new System.Drawing.Point(492, 233);
            this.chkParWithFlow.Name = "chkParWithFlow";
            this.chkParWithFlow.Size = new System.Drawing.Size(86, 17);
            this.chkParWithFlow.TabIndex = 261;
            this.chkParWithFlow.Tag = "";
            this.chkParWithFlow.Text = "ParWithFlow";
            this.chkParWithFlow.UseVisualStyleBackColor = true;
            this.chkParWithFlow.CheckedChanged += new System.EventHandler(this.chkParWithFlow_CheckedChanged);
            this.chkParWithFlow.MouseEnter += new System.EventHandler(this.chkParWithFlow_MouseEnter);
            // 
            // chkParDischargerIsMotor
            // 
            this.chkParDischargerIsMotor.AccessibleDescription = "DischargerIsMotor";
            this.chkParDischargerIsMotor.AutoSize = true;
            this.chkParDischargerIsMotor.Enabled = false;
            this.chkParDischargerIsMotor.Location = new System.Drawing.Point(492, 254);
            this.chkParDischargerIsMotor.Name = "chkParDischargerIsMotor";
            this.chkParDischargerIsMotor.Size = new System.Drawing.Size(128, 17);
            this.chkParDischargerIsMotor.TabIndex = 262;
            this.chkParDischargerIsMotor.Tag = "";
            this.chkParDischargerIsMotor.Text = "ParDischargerIsMotor";
            this.chkParDischargerIsMotor.UseVisualStyleBackColor = true;
            this.chkParDischargerIsMotor.CheckedChanged += new System.EventHandler(this.chkParDischargerIsMotor_CheckedChanged);
            this.chkParDischargerIsMotor.MouseEnter += new System.EventHandler(this.chkParDischargerIsMotor_MouseEnter);
            // 
            // txtValue10
            // 
            this.txtValue10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue10.Location = new System.Drawing.Point(618, 195);
            this.txtValue10.Name = "txtValue10";
            this.txtValue10.Size = new System.Drawing.Size(49, 13);
            this.txtValue10.TabIndex = 185;
            this.txtValue10.Text = "0";
            this.txtValue10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue10_KeyDown);
            // 
            // lblValue10
            // 
            this.lblValue10.AutoSize = true;
            this.lblValue10.Location = new System.Drawing.Point(616, 174);
            this.lblValue10.Name = "lblValue10";
            this.lblValue10.Size = new System.Drawing.Size(46, 13);
            this.lblValue10.TabIndex = 186;
            this.lblValue10.Text = "Value10";
            // 
            // grpReferences
            // 
            this.grpReferences.Controls.Add(this.lblSenderBinIncRule);
            this.grpReferences.Controls.Add(this.lblSenderBinRule);
            this.grpReferences.Controls.Add(this.txtSenderBin);
            this.grpReferences.Controls.Add(this.txtSenderBinIncRule);
            this.grpReferences.Controls.Add(this.lblSenderBin);
            this.grpReferences.Controls.Add(this.txtSenderBinRule);
            this.grpReferences.Controls.Add(this.lblReceiverIncRule);
            this.grpReferences.Controls.Add(this.lblReceiverRule);
            this.grpReferences.Controls.Add(this.txtReceiver);
            this.grpReferences.Controls.Add(this.txtReceiverIncRule);
            this.grpReferences.Controls.Add(this.lblReceiver);
            this.grpReferences.Controls.Add(this.txtReceiverRule);
            this.grpReferences.Location = new System.Drawing.Point(5, 365);
            this.grpReferences.Name = "grpReferences";
            this.grpReferences.Size = new System.Drawing.Size(471, 84);
            this.grpReferences.TabIndex = 187;
            this.grpReferences.TabStop = false;
            this.grpReferences.Text = "References";
            // 
            // lblSenderBinIncRule
            // 
            this.lblSenderBinIncRule.AutoSize = true;
            this.lblSenderBinIncRule.Location = new System.Drawing.Point(348, 49);
            this.lblSenderBinIncRule.Name = "lblSenderBinIncRule";
            this.lblSenderBinIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblSenderBinIncRule.TabIndex = 322;
            this.lblSenderBinIncRule.Text = "递增规则";
            // 
            // lblSenderBinRule
            // 
            this.lblSenderBinRule.AutoSize = true;
            this.lblSenderBinRule.Location = new System.Drawing.Point(222, 49);
            this.lblSenderBinRule.Name = "lblSenderBinRule";
            this.lblSenderBinRule.Size = new System.Drawing.Size(55, 13);
            this.lblSenderBinRule.TabIndex = 319;
            this.lblSenderBinRule.Text = "规则字段";
            // 
            // txtSenderBin
            // 
            this.txtSenderBin.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenderBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenderBin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSenderBin.Location = new System.Drawing.Point(111, 49);
            this.txtSenderBin.Name = "txtSenderBin";
            this.txtSenderBin.Size = new System.Drawing.Size(108, 13);
            this.txtSenderBin.TabIndex = 318;
            this.txtSenderBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenderBin.TextChanged += new System.EventHandler(this.txtSenderBin_TextChanged);
            // 
            // txtSenderBinIncRule
            // 
            this.txtSenderBinIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenderBinIncRule.Location = new System.Drawing.Point(408, 50);
            this.txtSenderBinIncRule.Name = "txtSenderBinIncRule";
            this.txtSenderBinIncRule.Size = new System.Drawing.Size(46, 13);
            this.txtSenderBinIncRule.TabIndex = 321;
            this.txtSenderBinIncRule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenderBinIncRule.TextChanged += new System.EventHandler(this.txtSenderBinIncRule_TextChanged);
            // 
            // lblSenderBin
            // 
            this.lblSenderBin.AutoSize = true;
            this.lblSenderBin.Location = new System.Drawing.Point(3, 49);
            this.lblSenderBin.Name = "lblSenderBin";
            this.lblSenderBin.Size = new System.Drawing.Size(59, 13);
            this.lblSenderBin.TabIndex = 317;
            this.lblSenderBin.Text = "Sender Bin";
            // 
            // txtSenderBinRule
            // 
            this.txtSenderBinRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenderBinRule.Location = new System.Drawing.Point(278, 50);
            this.txtSenderBinRule.Name = "txtSenderBinRule";
            this.txtSenderBinRule.Size = new System.Drawing.Size(66, 13);
            this.txtSenderBinRule.TabIndex = 320;
            this.txtSenderBinRule.TextChanged += new System.EventHandler(this.txtSenderBinRule_TextChanged);
            // 
            // lblReceiverIncRule
            // 
            this.lblReceiverIncRule.AutoSize = true;
            this.lblReceiverIncRule.Location = new System.Drawing.Point(348, 20);
            this.lblReceiverIncRule.Name = "lblReceiverIncRule";
            this.lblReceiverIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblReceiverIncRule.TabIndex = 316;
            this.lblReceiverIncRule.Text = "递增规则";
            // 
            // lblReceiverRule
            // 
            this.lblReceiverRule.AutoSize = true;
            this.lblReceiverRule.Location = new System.Drawing.Point(222, 20);
            this.lblReceiverRule.Name = "lblReceiverRule";
            this.lblReceiverRule.Size = new System.Drawing.Size(55, 13);
            this.lblReceiverRule.TabIndex = 313;
            this.lblReceiverRule.Text = "规则字段";
            // 
            // txtReceiver
            // 
            this.txtReceiver.BackColor = System.Drawing.SystemColors.Window;
            this.txtReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiver.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtReceiver.Location = new System.Drawing.Point(111, 20);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(108, 13);
            this.txtReceiver.TabIndex = 85;
            this.txtReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceiver.TextChanged += new System.EventHandler(this.txtReceiver_TextChanged);
            this.txtReceiver.MouseEnter += new System.EventHandler(this.txtReceiver_MouseEnter);
            // 
            // txtReceiverIncRule
            // 
            this.txtReceiverIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiverIncRule.Location = new System.Drawing.Point(408, 21);
            this.txtReceiverIncRule.Name = "txtReceiverIncRule";
            this.txtReceiverIncRule.Size = new System.Drawing.Size(46, 13);
            this.txtReceiverIncRule.TabIndex = 315;
            this.txtReceiverIncRule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceiverIncRule.TextChanged += new System.EventHandler(this.txtReceiverIncRule_TextChanged);
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Location = new System.Drawing.Point(3, 20);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(50, 13);
            this.lblReceiver.TabIndex = 84;
            this.lblReceiver.Text = "Receiver";
            // 
            // txtReceiverRule
            // 
            this.txtReceiverRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiverRule.Location = new System.Drawing.Point(278, 21);
            this.txtReceiverRule.Name = "txtReceiverRule";
            this.txtReceiverRule.Size = new System.Drawing.Size(66, 13);
            this.txtReceiverRule.TabIndex = 314;
            this.txtReceiverRule.TextChanged += new System.EventHandler(this.txtReceiverRule_TextChanged);
            // 
            // chkOnlyFree
            // 
            this.chkOnlyFree.AutoSize = true;
            this.chkOnlyFree.Checked = true;
            this.chkOnlyFree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyFree.Location = new System.Drawing.Point(91, 136);
            this.chkOnlyFree.Name = "chkOnlyFree";
            this.chkOnlyFree.Size = new System.Drawing.Size(110, 17);
            this.chkOnlyFree.TabIndex = 62;
            this.chkOnlyFree.Text = "仅关联丢失连接";
            this.chkOnlyFree.UseVisualStyleBackColor = true;
            this.chkOnlyFree.Visible = false;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.grpAddInfoToDesc);
            this.grpGeneral.Controls.Add(this.lblSymbol);
            this.grpGeneral.Controls.Add(this.grpDescriptionRule);
            this.grpGeneral.Controls.Add(this.grpSymbolRule);
            this.grpGeneral.Controls.Add(this.txtDescription);
            this.grpGeneral.Controls.Add(this.txtSymbol);
            this.grpGeneral.Controls.Add(this.lblDescription);
            this.grpGeneral.Location = new System.Drawing.Point(6, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(703, 113);
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
            this.grpAddInfoToDesc.Location = new System.Drawing.Point(235, 59);
            this.grpAddInfoToDesc.Name = "grpAddInfoToDesc";
            this.grpAddInfoToDesc.Size = new System.Drawing.Size(360, 39);
            this.grpAddInfoToDesc.TabIndex = 147;
            this.grpAddInfoToDesc.TabStop = false;
            this.grpAddInfoToDesc.Text = "附加信息到描述(BML)";
            // 
            // chkAddUserSectionToDesc
            // 
            this.chkAddUserSectionToDesc.AutoSize = true;
            this.chkAddUserSectionToDesc.Location = new System.Drawing.Point(60, 17);
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
            this.chkNameOnlyNumber.Location = new System.Drawing.Point(255, 17);
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
            this.chkAddNameToDesc.Location = new System.Drawing.Point(202, 17);
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
            this.chkAddFloorToDesc.Location = new System.Drawing.Point(149, 17);
            this.chkAddFloorToDesc.Name = "chkAddFloorToDesc";
            this.chkAddFloorToDesc.Size = new System.Drawing.Size(50, 17);
            this.chkAddFloorToDesc.TabIndex = 121;
            this.chkAddFloorToDesc.Text = "楼层";
            this.chkAddFloorToDesc.UseVisualStyleBackColor = true;
            this.chkAddFloorToDesc.CheckedChanged += new System.EventHandler(this.chkAddFloorToDesc_CheckedChanged);
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
            // grpSymbolRule
            // 
            this.grpSymbolRule.Controls.Add(this.lblSymbolRule);
            this.grpSymbolRule.Controls.Add(this.txtSymbolRule);
            this.grpSymbolRule.Controls.Add(this.txtSymbolIncRule);
            this.grpSymbolRule.Controls.Add(this.lblSymbolIncRule);
            this.grpSymbolRule.Location = new System.Drawing.Point(151, 16);
            this.grpSymbolRule.Name = "grpSymbolRule";
            this.grpSymbolRule.Size = new System.Drawing.Size(78, 88);
            this.grpSymbolRule.TabIndex = 75;
            this.grpSymbolRule.TabStop = false;
            this.grpSymbolRule.Text = "名称规则";
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
            this.txtSymbolIncRule.TextChanged += new System.EventHandler(this.txtSymbolIncRule_TextChanged);
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
            this.lblDescription.Size = new System.Drawing.Size(55, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "输入描述";
            // 
            // BtnNewImpExpDef
            // 
            this.BtnNewImpExpDef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewImpExpDef.BackgroundImage")));
            this.BtnNewImpExpDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNewImpExpDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewImpExpDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewImpExpDef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewImpExpDef.Location = new System.Drawing.Point(7, 128);
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
            this.LblEquipmentInfoType.Location = new System.Drawing.Point(3, 169);
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
            this.ComboEquipmentInfoType.Location = new System.Drawing.Point(102, 166);
            this.ComboEquipmentInfoType.Name = "ComboEquipmentInfoType";
            this.ComboEquipmentInfoType.Size = new System.Drawing.Size(357, 21);
            this.ComboEquipmentInfoType.TabIndex = 13;
            this.ComboEquipmentInfoType.MouseEnter += new System.EventHandler(this.ComboEquipmentInfoType_MouseEnter);
            // 
            // BtnConnectIO
            // 
            this.BtnConnectIO.BackColor = System.Drawing.SystemColors.Control;
            this.BtnConnectIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConnectIO.BackgroundImage")));
            this.BtnConnectIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConnectIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnectIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConnectIO.Location = new System.Drawing.Point(48, 128);
            this.BtnConnectIO.Name = "BtnConnectIO";
            this.BtnConnectIO.Size = new System.Drawing.Size(36, 30);
            this.BtnConnectIO.TabIndex = 98;
            this.BtnConnectIO.UseVisualStyleBackColor = false;
            this.BtnConnectIO.Visible = false;
            this.BtnConnectIO.Click += new System.EventHandler(this.BtnConnectIO_Click);
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
            this.tabBML.Size = new System.Drawing.Size(722, 502);
            this.tabBML.TabIndex = 1;
            this.tabBML.Text = "通过BML创建";
            // 
            // grpBoxExcelData
            // 
            this.grpBoxExcelData.Controls.Add(this.btnReadBML);
            this.grpBoxExcelData.Controls.Add(this.dataGridBML);
            this.grpBoxExcelData.Controls.Add(this.lblWorkSheet);
            this.grpBoxExcelData.Controls.Add(this.comboWorkSheetsBML);
            this.grpBoxExcelData.Location = new System.Drawing.Point(6, 127);
            this.grpBoxExcelData.Name = "grpBoxExcelData";
            this.grpBoxExcelData.Size = new System.Drawing.Size(712, 369);
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dataGridBML.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridBML.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBML.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.Location = new System.Drawing.Point(5, 51);
            this.dataGridBML.Name = "dataGridBML";
            this.dataGridBML.Size = new System.Drawing.Size(701, 312);
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
            this.grpBoxExcelColumn.Size = new System.Drawing.Size(712, 115);
            this.grpBoxExcelColumn.TabIndex = 0;
            this.grpBoxExcelColumn.TabStop = false;
            this.grpBoxExcelColumn.Text = "BML清单信息";
            // 
            // grpBoxBMLColum
            // 
            this.grpBoxBMLColum.Controls.Add(this.comboControlBML);
            this.grpBoxBMLColum.Controls.Add(this.lblControlBML);
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
            this.grpBoxBMLColum.Size = new System.Drawing.Size(698, 68);
            this.grpBoxBMLColum.TabIndex = 16;
            this.grpBoxBMLColum.TabStop = false;
            this.grpBoxBMLColum.Text = "信息列";
            // 
            // comboControlBML
            // 
            this.comboControlBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboControlBML.FormattingEnabled = true;
            this.comboControlBML.IntegralHeight = false;
            this.comboControlBML.Location = new System.Drawing.Point(206, 42);
            this.comboControlBML.Name = "comboControlBML";
            this.comboControlBML.Size = new System.Drawing.Size(66, 21);
            this.comboControlBML.TabIndex = 35;
            // 
            // lblControlBML
            // 
            this.lblControlBML.AutoSize = true;
            this.lblControlBML.Location = new System.Drawing.Point(146, 44);
            this.lblControlBML.Name = "lblControlBML";
            this.lblControlBML.Size = new System.Drawing.Size(67, 13);
            this.lblControlBML.TabIndex = 34;
            this.lblControlBML.Text = "控制方法：";
            // 
            // comboLineBML
            // 
            this.comboLineBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLineBML.FormattingEnabled = true;
            this.comboLineBML.IntegralHeight = false;
            this.comboLineBML.Location = new System.Drawing.Point(626, 16);
            this.comboLineBML.Name = "comboLineBML";
            this.comboLineBML.Size = new System.Drawing.Size(66, 21);
            this.comboLineBML.TabIndex = 33;
            // 
            // lblLineBML
            // 
            this.lblLineBML.AutoSize = true;
            this.lblLineBML.Location = new System.Drawing.Point(552, 19);
            this.lblLineBML.Name = "lblLineBML";
            this.lblLineBML.Size = new System.Drawing.Size(79, 13);
            this.lblLineBML.TabIndex = 32;
            this.lblLineBML.Text = "自定义工段：";
            // 
            // comboStartRow
            // 
            this.comboStartRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStartRow.FormattingEnabled = true;
            this.comboStartRow.IntegralHeight = false;
            this.comboStartRow.Location = new System.Drawing.Point(627, 43);
            this.comboStartRow.Name = "comboStartRow";
            this.comboStartRow.Size = new System.Drawing.Size(66, 21);
            this.comboStartRow.TabIndex = 28;
            // 
            // lblStartRow
            // 
            this.lblStartRow.AutoSize = true;
            this.lblStartRow.Location = new System.Drawing.Point(558, 46);
            this.lblStartRow.Name = "lblStartRow";
            this.lblStartRow.Size = new System.Drawing.Size(55, 13);
            this.lblStartRow.TabIndex = 28;
            this.lblStartRow.Text = "起始行：";
            // 
            // comboSectionBML
            // 
            this.comboSectionBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSectionBML.FormattingEnabled = true;
            this.comboSectionBML.IntegralHeight = false;
            this.comboSectionBML.Location = new System.Drawing.Point(476, 44);
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
            this.comboCabinetBML.Location = new System.Drawing.Point(476, 18);
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
            this.lblSection.Location = new System.Drawing.Point(415, 49);
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
            this.lblCabibetNo.Location = new System.Drawing.Point(415, 19);
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
            this.PalCommon.Location = new System.Drawing.Point(8, 531);
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
            // FormMA_Discharger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(730, 754);
            this.Controls.Add(this.PalCommon);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabCreateMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMA_Discharger";
            this.Text = "MA_Discharger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMA_Discharger_FormClosed);
            this.Load += new System.EventHandler(this.FormMA_Discharger_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCreateMode.ResumeLayout(false);
            this.contextMenuStripBML.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.tabRule.PerformLayout();
            this.PalGcObject.ResumeLayout(false);
            this.PalGcObject.PerformLayout();
            this.grpReferences.ResumeLayout(false);
            this.grpReferences.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpAddInfoToDesc.ResumeLayout(false);
            this.grpAddInfoToDesc.PerformLayout();
            this.grpDescriptionRule.ResumeLayout(false);
            this.grpDescriptionRule.PerformLayout();
            this.grpSymbolRule.ResumeLayout(false);
            this.grpSymbolRule.PerformLayout();
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
        internal System.Windows.Forms.Button BtnNewImpExpDef;
        internal System.Windows.Forms.Button BtnConnectIO;
        internal System.Windows.Forms.Label LblEquipmentInfoType;
        internal System.Windows.Forms.ComboBox ComboEquipmentInfoType;
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
        internal System.Windows.Forms.CheckBox chkOnlyFree;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        internal System.Windows.Forms.ComboBox comboLineBML;
        private System.Windows.Forms.Label lblLineBML;
        private System.Windows.Forms.GroupBox grpGeneral;
        internal System.Windows.Forms.Label lblSymbol;
        internal System.Windows.Forms.GroupBox grpDescriptionRule;
        internal System.Windows.Forms.Label lblDescriptionRule;
        internal System.Windows.Forms.TextBox txtDescriptionIncRule;
        internal System.Windows.Forms.Label lblDescriptionIncRule;
        internal System.Windows.Forms.TextBox txtDescriptionRule;
        internal System.Windows.Forms.GroupBox grpSymbolRule;
        internal System.Windows.Forms.Label lblSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolIncRule;
        internal System.Windows.Forms.Label lblSymbolIncRule;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtSymbol;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.TextBox txtValue10;
        internal System.Windows.Forms.Label lblValue10;
        internal System.Windows.Forms.GroupBox grpReferences;
        internal System.Windows.Forms.TextBox txtReceiver;
        internal System.Windows.Forms.Label lblReceiver;
        internal System.Windows.Forms.ComboBox comboControlBML;
        private System.Windows.Forms.Label lblControlBML;
        private System.Windows.Forms.GroupBox grpAddInfoToDesc;
        internal System.Windows.Forms.CheckBox chkNameOnlyNumber;
        internal System.Windows.Forms.CheckBox chkAddSectionToDesc;
        internal System.Windows.Forms.CheckBox chkAddFloorToDesc;
        internal System.Windows.Forms.CheckBox chkAddNameToDesc;
        internal System.Windows.Forms.CheckBox chkAddUserSectionToDesc;
        internal System.Windows.Forms.Label lblDischarger;
        internal System.Windows.Forms.Label lblVibro;
        internal System.Windows.Forms.TextBox txtDischarger;
        internal System.Windows.Forms.Label lblLSFlow;
        internal System.Windows.Forms.Label lblLLBin;
        internal System.Windows.Forms.TextBox txtVibro;
        internal System.Windows.Forms.TextBox txtLSFlow;
        internal System.Windows.Forms.TextBox txtDischargerRule;
        internal System.Windows.Forms.TextBox txtDischargerIncRule;
        internal System.Windows.Forms.TextBox txtLLBin;
        internal System.Windows.Forms.Label lblDischargerRule;
        internal System.Windows.Forms.Label LblLLBinIncRule;
        internal System.Windows.Forms.Label LblDischargerIncRule;
        internal System.Windows.Forms.Label lblLLBinRule;
        internal System.Windows.Forms.TextBox txtVibroRule;
        internal System.Windows.Forms.TextBox txtLLBinIncRule;
        internal System.Windows.Forms.TextBox txtVibroIncRule;
        internal System.Windows.Forms.TextBox txtLLBinRule;
        internal System.Windows.Forms.Label lblVibroRule;
        internal System.Windows.Forms.Label LblLSFlowIncRule;
        internal System.Windows.Forms.Label LblVibroIncRule;
        internal System.Windows.Forms.Label lblLSFlowRule;
        internal System.Windows.Forms.TextBox txtLSFlowRule;
        internal System.Windows.Forms.TextBox txtLSFlowIncRule;
        internal System.Windows.Forms.CheckBox chkParContinuous;
        internal System.Windows.Forms.CheckBox chkParWithVibro;
        internal System.Windows.Forms.CheckBox chkParWithLL;
        internal System.Windows.Forms.CheckBox chkParWithFlow;
        internal System.Windows.Forms.CheckBox chkParDischargerIsMotor;
        internal System.Windows.Forms.Label lblReceiverIncRule;
        internal System.Windows.Forms.Label lblReceiverRule;
        internal System.Windows.Forms.TextBox txtReceiverIncRule;
        internal System.Windows.Forms.TextBox txtReceiverRule;
        internal System.Windows.Forms.TextBox txtParVibroOnTime;
        internal System.Windows.Forms.Label lblParVibroOnTime;
        internal System.Windows.Forms.TextBox txtParRestDischargeTime;
        internal System.Windows.Forms.Label lblParRestDischargeTime;
        internal System.Windows.Forms.TextBox txtParVibroOffTime;
        internal System.Windows.Forms.Label lblParVibroOffTime;
        internal System.Windows.Forms.Label lblSenderBinIncRule;
        internal System.Windows.Forms.Label lblSenderBinRule;
        internal System.Windows.Forms.TextBox txtSenderBin;
        internal System.Windows.Forms.TextBox txtSenderBinIncRule;
        internal System.Windows.Forms.Label lblSenderBin;
        internal System.Windows.Forms.TextBox txtSenderBinRule;
    }
}

