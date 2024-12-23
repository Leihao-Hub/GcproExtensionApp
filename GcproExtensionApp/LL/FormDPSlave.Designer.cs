using System;

namespace GcproExtensionApp
{
    partial class FormDPSlave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDPSlave));
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
            this.txtParSlaveNoIncRule = new System.Windows.Forms.TextBox();
            this.LblParSlaveNoIncRule = new System.Windows.Forms.Label();
            this.txtIPAddressIncRule = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblIPAddressIncRule = new System.Windows.Forms.Label();
            this.txtParSlaveNo = new System.Windows.Forms.TextBox();
            this.LblParDPNode = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.LblIPAddress = new System.Windows.Forms.Label();
            this.lblParSlaveNo = new System.Windows.Forms.Label();
            this.grpProfinet = new System.Windows.Forms.GroupBox();
            this.chkUpdateTimeManCalc = new System.Windows.Forms.CheckBox();
            this.lblValue31 = new System.Windows.Forms.Label();
            this.txtValue31 = new System.Windows.Forms.TextBox();
            this.txtWatchDogTime = new System.Windows.Forms.TextBox();
            this.lblWatchDogTime = new System.Windows.Forms.Label();
            this.txtWatchDogFactor = new System.Windows.Forms.TextBox();
            this.lblWatchDogFactor = new System.Windows.Forms.Label();
            this.txtUpdateTime = new System.Windows.Forms.TextBox();
            this.lblUpdateTime = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.grpAddInfoToDesc = new System.Windows.Forms.GroupBox();
            this.chkNameOnlyNumber = new System.Windows.Forms.CheckBox();
            this.chkAddSectionToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddFloorToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddNameToDesc = new System.Windows.Forms.CheckBox();
            this.chkAddCabinetToDesc = new System.Windows.Forms.CheckBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.grpDescriptionRule = new System.Windows.Forms.GroupBox();
            this.lblDescriptionRule = new System.Windows.Forms.Label();
            this.txtDescriptionIncRule = new System.Windows.Forms.TextBox();
            this.lblDescriptionlIncRule = new System.Windows.Forms.Label();
            this.txtDescriptionRule = new System.Windows.Forms.TextBox();
            this.grpSymbolRule = new System.Windows.Forms.GroupBox();
            this.lblSymbolRule = new System.Windows.Forms.Label();
            this.txtSymbolRule = new System.Windows.Forms.TextBox();
            this.txtSymbolIncRule = new System.Windows.Forms.TextBox();
            this.lblSymbolIncRule = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnRegenerateDPNode = new System.Windows.Forms.Button();
            this.BtnNewImpExpDef = new System.Windows.Forms.Button();
            this.LblEquipmentInfoType = new System.Windows.Forms.Label();
            this.ComboEquipmentInfoType = new System.Windows.Forms.ComboBox();
            this.LblHornCode = new System.Windows.Forms.Label();
            this.ComboHornCode = new System.Windows.Forms.ComboBox();
            this.tabBML = new System.Windows.Forms.TabPage();
            this.grpBoxExcelData = new System.Windows.Forms.GroupBox();
            this.chkUserDifinedExcel = new System.Windows.Forms.CheckBox();
            this.btnReadBML = new System.Windows.Forms.Button();
            this.dataGridBML = new System.Windows.Forms.DataGridView();
            this.lblWorkSheet = new System.Windows.Forms.Label();
            this.comboWorkSheetsBML = new System.Windows.Forms.ComboBox();
            this.grpBoxExcelColumn = new System.Windows.Forms.GroupBox();
            this.grpBoxBMLColum = new System.Windows.Forms.GroupBox();
            this.comboControl_SlaveNoBML = new System.Windows.Forms.ComboBox();
            this.lblControl_SlaveNo = new System.Windows.Forms.Label();
            this.comboStartRow = new System.Windows.Forms.ComboBox();
            this.lblStartRow = new System.Windows.Forms.Label();
            this.comboSectionBML = new System.Windows.Forms.ComboBox();
            this.comboDescBML = new System.Windows.Forms.ComboBox();
            this.comboCabinetBML = new System.Windows.Forms.ComboBox();
            this.comboFloorBML = new System.Windows.Forms.ComboBox();
            this.comboType_IPAddrBML = new System.Windows.Forms.ComboBox();
            this.comboNameBML = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblType_IPAddr = new System.Windows.Forms.Label();
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
            this.grpProfinet.SuspendLayout();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 706);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(742, 22);
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
            this.tabCreateMode.Size = new System.Drawing.Size(742, 504);
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
            this.tabRule.Size = new System.Drawing.Size(734, 478);
            this.tabRule.TabIndex = 0;
            this.tabRule.Text = "设定规则创建";
            // 
            // PalGcObject
            // 
            this.PalGcObject.AutoScroll = true;
            this.PalGcObject.AutoSize = true;
            this.PalGcObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PalGcObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PalGcObject.Controls.Add(this.txtParSlaveNoIncRule);
            this.PalGcObject.Controls.Add(this.LblParSlaveNoIncRule);
            this.PalGcObject.Controls.Add(this.txtIPAddressIncRule);
            this.PalGcObject.Controls.Add(this.textBox1);
            this.PalGcObject.Controls.Add(this.LblIPAddressIncRule);
            this.PalGcObject.Controls.Add(this.txtParSlaveNo);
            this.PalGcObject.Controls.Add(this.LblParDPNode);
            this.PalGcObject.Controls.Add(this.txtIPAddress);
            this.PalGcObject.Controls.Add(this.LblIPAddress);
            this.PalGcObject.Controls.Add(this.lblParSlaveNo);
            this.PalGcObject.Controls.Add(this.grpProfinet);
            this.PalGcObject.Controls.Add(this.grpGeneral);
            this.PalGcObject.Controls.Add(this.BtnRegenerateDPNode);
            this.PalGcObject.Controls.Add(this.BtnNewImpExpDef);
            this.PalGcObject.Controls.Add(this.LblEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.ComboEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.LblHornCode);
            this.PalGcObject.Controls.Add(this.ComboHornCode);
            this.PalGcObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalGcObject.Location = new System.Drawing.Point(3, 3);
            this.PalGcObject.Name = "PalGcObject";
            this.PalGcObject.Size = new System.Drawing.Size(728, 472);
            this.PalGcObject.TabIndex = 105;
            // 
            // txtParSlaveNoIncRule
            // 
            this.txtParSlaveNoIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSlaveNoIncRule.Location = new System.Drawing.Point(285, 278);
            this.txtParSlaveNoIncRule.Name = "txtParSlaveNoIncRule";
            this.txtParSlaveNoIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtParSlaveNoIncRule.TabIndex = 157;
            this.txtParSlaveNoIncRule.TextChanged += new System.EventHandler(this.txtParSlaveNoIncRule_TextChanged);
            // 
            // LblParSlaveNoIncRule
            // 
            this.LblParSlaveNoIncRule.AutoSize = true;
            this.LblParSlaveNoIncRule.Location = new System.Drawing.Point(224, 278);
            this.LblParSlaveNoIncRule.Name = "LblParSlaveNoIncRule";
            this.LblParSlaveNoIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblParSlaveNoIncRule.TabIndex = 156;
            this.LblParSlaveNoIncRule.Text = "递增规则";
            // 
            // txtIPAddressIncRule
            // 
            this.txtIPAddressIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIPAddressIncRule.Location = new System.Drawing.Point(285, 256);
            this.txtIPAddressIncRule.Name = "txtIPAddressIncRule";
            this.txtIPAddressIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtIPAddressIncRule.TabIndex = 149;
            this.txtIPAddressIncRule.TextChanged += new System.EventHandler(this.txtIPAddressIncRule_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(100, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 155;
            this.textBox1.Text = "系统自动生成";
            // 
            // LblIPAddressIncRule
            // 
            this.LblIPAddressIncRule.AutoSize = true;
            this.LblIPAddressIncRule.Location = new System.Drawing.Point(224, 256);
            this.LblIPAddressIncRule.Name = "LblIPAddressIncRule";
            this.LblIPAddressIncRule.Size = new System.Drawing.Size(55, 13);
            this.LblIPAddressIncRule.TabIndex = 148;
            this.LblIPAddressIncRule.Text = "递增规则";
            // 
            // txtParSlaveNo
            // 
            this.txtParSlaveNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtParSlaveNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParSlaveNo.Location = new System.Drawing.Point(100, 279);
            this.txtParSlaveNo.Name = "txtParSlaveNo";
            this.txtParSlaveNo.Size = new System.Drawing.Size(100, 13);
            this.txtParSlaveNo.TabIndex = 154;
            this.txtParSlaveNo.TextChanged += new System.EventHandler(this.txtParSlaveNo_TextChanged);
            this.txtParSlaveNo.MouseEnter += new System.EventHandler(this.txtParSlaveNo_MouseEnter);
            // 
            // LblParDPNode
            // 
            this.LblParDPNode.AutoSize = true;
            this.LblParDPNode.Location = new System.Drawing.Point(4, 302);
            this.LblParDPNode.Name = "LblParDPNode";
            this.LblParDPNode.Size = new System.Drawing.Size(70, 13);
            this.LblParDPNode.TabIndex = 153;
            this.LblParDPNode.Text = "ParDPNode1";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIPAddress.Location = new System.Drawing.Point(100, 256);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 13);
            this.txtIPAddress.TabIndex = 152;
            this.txtIPAddress.TextChanged += new System.EventHandler(this.txtIPAddress_TextChanged);
            this.txtIPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIPAddress_KeyDown);
            this.txtIPAddress.MouseEnter += new System.EventHandler(this.txtIPAddress_MouseEnter);
            // 
            // LblIPAddress
            // 
            this.LblIPAddress.AutoSize = true;
            this.LblIPAddress.Location = new System.Drawing.Point(4, 256);
            this.LblIPAddress.Name = "LblIPAddress";
            this.LblIPAddress.Size = new System.Drawing.Size(58, 13);
            this.LblIPAddress.TabIndex = 150;
            this.LblIPAddress.Text = "IP Address";
            // 
            // lblParSlaveNo
            // 
            this.lblParSlaveNo.AutoSize = true;
            this.lblParSlaveNo.Location = new System.Drawing.Point(4, 279);
            this.lblParSlaveNo.Name = "lblParSlaveNo";
            this.lblParSlaveNo.Size = new System.Drawing.Size(64, 13);
            this.lblParSlaveNo.TabIndex = 151;
            this.lblParSlaveNo.Text = "ParSlaveNo";
            // 
            // grpProfinet
            // 
            this.grpProfinet.Controls.Add(this.chkUpdateTimeManCalc);
            this.grpProfinet.Controls.Add(this.lblValue31);
            this.grpProfinet.Controls.Add(this.txtValue31);
            this.grpProfinet.Controls.Add(this.txtWatchDogTime);
            this.grpProfinet.Controls.Add(this.lblWatchDogTime);
            this.grpProfinet.Controls.Add(this.txtWatchDogFactor);
            this.grpProfinet.Controls.Add(this.lblWatchDogFactor);
            this.grpProfinet.Controls.Add(this.txtUpdateTime);
            this.grpProfinet.Controls.Add(this.lblUpdateTime);
            this.grpProfinet.Location = new System.Drawing.Point(1, 345);
            this.grpProfinet.Name = "grpProfinet";
            this.grpProfinet.Size = new System.Drawing.Size(697, 114);
            this.grpProfinet.TabIndex = 129;
            this.grpProfinet.TabStop = false;
            this.grpProfinet.Text = "Profinet：UpdateTime/WatchDog";
            // 
            // chkUpdateTimeManCalc
            // 
            this.chkUpdateTimeManCalc.AutoSize = true;
            this.chkUpdateTimeManCalc.Location = new System.Drawing.Point(444, 34);
            this.chkUpdateTimeManCalc.Name = "chkUpdateTimeManCalc";
            this.chkUpdateTimeManCalc.Size = new System.Drawing.Size(174, 17);
            this.chkUpdateTimeManCalc.TabIndex = 125;
            this.chkUpdateTimeManCalc.Text = "UpdateTime ManualCalculation";
            this.chkUpdateTimeManCalc.UseVisualStyleBackColor = true;
            this.chkUpdateTimeManCalc.CheckedChanged += new System.EventHandler(this.chkUpdateTimeManCalc_CheckedChanged);
            this.chkUpdateTimeManCalc.MouseEnter += new System.EventHandler(this.chkUpdateTimeManCalc_MouseEnter);
            // 
            // lblValue31
            // 
            this.lblValue31.AutoSize = true;
            this.lblValue31.Location = new System.Drawing.Point(620, 17);
            this.lblValue31.Name = "lblValue31";
            this.lblValue31.Size = new System.Drawing.Size(46, 13);
            this.lblValue31.TabIndex = 123;
            this.lblValue31.Text = "Value31";
            // 
            // txtValue31
            // 
            this.txtValue31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue31.Location = new System.Drawing.Point(624, 37);
            this.txtValue31.Name = "txtValue31";
            this.txtValue31.Size = new System.Drawing.Size(39, 13);
            this.txtValue31.TabIndex = 122;
            this.txtValue31.Text = "0";
            // 
            // txtWatchDogTime
            // 
            this.txtWatchDogTime.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtWatchDogTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWatchDogTime.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtWatchDogTime.Location = new System.Drawing.Point(114, 68);
            this.txtWatchDogTime.Name = "txtWatchDogTime";
            this.txtWatchDogTime.Size = new System.Drawing.Size(85, 13);
            this.txtWatchDogTime.TabIndex = 92;
            this.txtWatchDogTime.MouseEnter += new System.EventHandler(this.txtWatchDogTime_MouseEnter);
            // 
            // lblWatchDogTime
            // 
            this.lblWatchDogTime.AutoSize = true;
            this.lblWatchDogTime.Location = new System.Drawing.Point(3, 68);
            this.lblWatchDogTime.Name = "lblWatchDogTime";
            this.lblWatchDogTime.Size = new System.Drawing.Size(101, 13);
            this.lblWatchDogTime.TabIndex = 91;
            this.lblWatchDogTime.Text = "WatchDogTime[ms]";
            // 
            // txtWatchDogFactor
            // 
            this.txtWatchDogFactor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtWatchDogFactor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWatchDogFactor.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtWatchDogFactor.Location = new System.Drawing.Point(114, 42);
            this.txtWatchDogFactor.Name = "txtWatchDogFactor";
            this.txtWatchDogFactor.Size = new System.Drawing.Size(85, 13);
            this.txtWatchDogFactor.TabIndex = 85;
            this.txtWatchDogFactor.MouseEnter += new System.EventHandler(this.txtWatchDogFactor_MouseEnter);
            // 
            // lblWatchDogFactor
            // 
            this.lblWatchDogFactor.AutoSize = true;
            this.lblWatchDogFactor.Location = new System.Drawing.Point(3, 42);
            this.lblWatchDogFactor.Name = "lblWatchDogFactor";
            this.lblWatchDogFactor.Size = new System.Drawing.Size(89, 13);
            this.lblWatchDogFactor.TabIndex = 84;
            this.lblWatchDogFactor.Text = "WatchDogFactor";
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUpdateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateTime.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtUpdateTime.Location = new System.Drawing.Point(114, 17);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.Size = new System.Drawing.Size(85, 13);
            this.txtUpdateTime.TabIndex = 79;
            this.txtUpdateTime.MouseEnter += new System.EventHandler(this.txtUpdateTime_MouseEnter);
            // 
            // lblUpdateTime
            // 
            this.lblUpdateTime.AutoSize = true;
            this.lblUpdateTime.Location = new System.Drawing.Point(3, 17);
            this.lblUpdateTime.Name = "lblUpdateTime";
            this.lblUpdateTime.Size = new System.Drawing.Size(84, 13);
            this.lblUpdateTime.TabIndex = 78;
            this.lblUpdateTime.Text = "UpdateTime[ms]";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.grpAddInfoToDesc);
            this.grpGeneral.Controls.Add(this.lblSymbol);
            this.grpGeneral.Controls.Add(this.grpDescriptionRule);
            this.grpGeneral.Controls.Add(this.grpSymbolRule);
            this.grpGeneral.Controls.Add(this.txtDescription);
            this.grpGeneral.Controls.Add(this.txtSymbol);
            this.grpGeneral.Controls.Add(this.LblDescription);
            this.grpGeneral.Location = new System.Drawing.Point(6, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(698, 157);
            this.grpGeneral.TabIndex = 118;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "常规";
            // 
            // grpAddInfoToDesc
            // 
            this.grpAddInfoToDesc.Controls.Add(this.chkNameOnlyNumber);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddSectionToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddFloorToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddNameToDesc);
            this.grpAddInfoToDesc.Controls.Add(this.chkAddCabinetToDesc);
            this.grpAddInfoToDesc.Location = new System.Drawing.Point(151, 110);
            this.grpAddInfoToDesc.Name = "grpAddInfoToDesc";
            this.grpAddInfoToDesc.Size = new System.Drawing.Size(530, 39);
            this.grpAddInfoToDesc.TabIndex = 122;
            this.grpAddInfoToDesc.TabStop = false;
            this.grpAddInfoToDesc.Text = "附加信息到描述(BML)";
            this.grpAddInfoToDesc.Visible = false;
            // 
            // chkNameOnlyNumber
            // 
            this.chkNameOnlyNumber.AutoSize = true;
            this.chkNameOnlyNumber.Checked = true;
            this.chkNameOnlyNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNameOnlyNumber.Location = new System.Drawing.Point(425, 15);
            this.chkNameOnlyNumber.Name = "chkNameOnlyNumber";
            this.chkNameOnlyNumber.Size = new System.Drawing.Size(98, 17);
            this.chkNameOnlyNumber.TabIndex = 124;
            this.chkNameOnlyNumber.Text = "编号仅含数字";
            this.chkNameOnlyNumber.UseVisualStyleBackColor = true;
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
            // 
            // chkAddFloorToDesc
            // 
            this.chkAddFloorToDesc.AutoSize = true;
            this.chkAddFloorToDesc.Checked = true;
            this.chkAddFloorToDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddFloorToDesc.Location = new System.Drawing.Point(169, 17);
            this.chkAddFloorToDesc.Name = "chkAddFloorToDesc";
            this.chkAddFloorToDesc.Size = new System.Drawing.Size(50, 17);
            this.chkAddFloorToDesc.TabIndex = 121;
            this.chkAddFloorToDesc.Text = "楼层";
            this.chkAddFloorToDesc.UseVisualStyleBackColor = true;
            // 
            // chkAddNameToDesc
            // 
            this.chkAddNameToDesc.AutoSize = true;
            this.chkAddNameToDesc.Checked = true;
            this.chkAddNameToDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddNameToDesc.Location = new System.Drawing.Point(88, 17);
            this.chkAddNameToDesc.Name = "chkAddNameToDesc";
            this.chkAddNameToDesc.Size = new System.Drawing.Size(50, 17);
            this.chkAddNameToDesc.TabIndex = 119;
            this.chkAddNameToDesc.Text = "编号";
            this.chkAddNameToDesc.UseVisualStyleBackColor = true;
            // 
            // chkAddCabinetToDesc
            // 
            this.chkAddCabinetToDesc.AutoSize = true;
            this.chkAddCabinetToDesc.Checked = true;
            this.chkAddCabinetToDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddCabinetToDesc.Location = new System.Drawing.Point(250, 17);
            this.chkAddCabinetToDesc.Name = "chkAddCabinetToDesc";
            this.chkAddCabinetToDesc.Size = new System.Drawing.Size(50, 17);
            this.chkAddCabinetToDesc.TabIndex = 120;
            this.chkAddCabinetToDesc.Text = "电柜";
            this.chkAddCabinetToDesc.UseVisualStyleBackColor = true;
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
            this.grpDescriptionRule.Controls.Add(this.lblDescriptionlIncRule);
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
            // lblDescriptionlIncRule
            // 
            this.lblDescriptionlIncRule.AutoSize = true;
            this.lblDescriptionlIncRule.Location = new System.Drawing.Point(6, 50);
            this.lblDescriptionlIncRule.Name = "lblDescriptionlIncRule";
            this.lblDescriptionlIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblDescriptionlIncRule.TabIndex = 73;
            this.lblDescriptionlIncRule.Text = "递增规则";
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
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(245, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(346, 13);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
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
            this.LblDescription.Size = new System.Drawing.Size(79, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "通信站点描述";
            // 
            // BtnRegenerateDPNode
            // 
            this.BtnRegenerateDPNode.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRegenerateDPNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegenerateDPNode.BackgroundImage")));
            this.BtnRegenerateDPNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRegenerateDPNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegenerateDPNode.Location = new System.Drawing.Point(46, 166);
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
            this.BtnNewImpExpDef.Location = new System.Drawing.Point(4, 166);
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
            this.LblEquipmentInfoType.Location = new System.Drawing.Point(1, 206);
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
            this.ComboEquipmentInfoType.Location = new System.Drawing.Point(100, 203);
            this.ComboEquipmentInfoType.Name = "ComboEquipmentInfoType";
            this.ComboEquipmentInfoType.Size = new System.Drawing.Size(337, 21);
            this.ComboEquipmentInfoType.TabIndex = 13;
            this.ComboEquipmentInfoType.MouseEnter += new System.EventHandler(this.ComboEquipmentInfoType_MouseEnter);
            // 
            // LblHornCode
            // 
            this.LblHornCode.AutoSize = true;
            this.LblHornCode.Location = new System.Drawing.Point(1, 231);
            this.LblHornCode.Name = "LblHornCode";
            this.LblHornCode.Size = new System.Drawing.Size(71, 13);
            this.LblHornCode.TabIndex = 14;
            this.LblHornCode.Text = "ParHornCode";
            // 
            // ComboHornCode
            // 
            this.ComboHornCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHornCode.FormattingEnabled = true;
            this.ComboHornCode.Location = new System.Drawing.Point(100, 227);
            this.ComboHornCode.Name = "ComboHornCode";
            this.ComboHornCode.Size = new System.Drawing.Size(146, 21);
            this.ComboHornCode.TabIndex = 15;
            this.ComboHornCode.MouseEnter += new System.EventHandler(this.ComboHornCode_MouseEnter);
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
            this.tabBML.Size = new System.Drawing.Size(734, 478);
            this.tabBML.TabIndex = 1;
            this.tabBML.Text = "通过BML创建";
            // 
            // grpBoxExcelData
            // 
            this.grpBoxExcelData.Controls.Add(this.chkUserDifinedExcel);
            this.grpBoxExcelData.Controls.Add(this.btnReadBML);
            this.grpBoxExcelData.Controls.Add(this.dataGridBML);
            this.grpBoxExcelData.Controls.Add(this.lblWorkSheet);
            this.grpBoxExcelData.Controls.Add(this.comboWorkSheetsBML);
            this.grpBoxExcelData.Location = new System.Drawing.Point(3, 121);
            this.grpBoxExcelData.Name = "grpBoxExcelData";
            this.grpBoxExcelData.Size = new System.Drawing.Size(723, 354);
            this.grpBoxExcelData.TabIndex = 16;
            this.grpBoxExcelData.TabStop = false;
            this.grpBoxExcelData.Text = "BML数据";
            // 
            // chkUserDifinedExcel
            // 
            this.chkUserDifinedExcel.AutoSize = true;
            this.chkUserDifinedExcel.Checked = true;
            this.chkUserDifinedExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUserDifinedExcel.Location = new System.Drawing.Point(510, 19);
            this.chkUserDifinedExcel.Name = "chkUserDifinedExcel";
            this.chkUserDifinedExcel.Size = new System.Drawing.Size(86, 17);
            this.chkUserDifinedExcel.TabIndex = 121;
            this.chkUserDifinedExcel.Text = "自定义表格";
            this.chkUserDifinedExcel.UseVisualStyleBackColor = true;
            this.chkUserDifinedExcel.CheckedChanged += new System.EventHandler(this.chkUserDifinedExcel_CheckedChanged);
            // 
            // btnReadBML
            // 
            this.btnReadBML.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btnReadBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadBML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReadBML.Image = ((System.Drawing.Image)(resources.GetObject("btnReadBML.Image")));
            this.btnReadBML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadBML.Location = new System.Drawing.Point(614, 13);
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
            this.dataGridBML.Location = new System.Drawing.Point(4, 53);
            this.dataGridBML.Name = "dataGridBML";
            this.dataGridBML.Size = new System.Drawing.Size(714, 295);
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
            this.grpBoxExcelColumn.Size = new System.Drawing.Size(720, 115);
            this.grpBoxExcelColumn.TabIndex = 0;
            this.grpBoxExcelColumn.TabStop = false;
            this.grpBoxExcelColumn.Text = "BML清单信息";
            // 
            // grpBoxBMLColum
            // 
            this.grpBoxBMLColum.Controls.Add(this.comboControl_SlaveNoBML);
            this.grpBoxBMLColum.Controls.Add(this.lblControl_SlaveNo);
            this.grpBoxBMLColum.Controls.Add(this.comboStartRow);
            this.grpBoxBMLColum.Controls.Add(this.lblStartRow);
            this.grpBoxBMLColum.Controls.Add(this.comboSectionBML);
            this.grpBoxBMLColum.Controls.Add(this.comboDescBML);
            this.grpBoxBMLColum.Controls.Add(this.comboCabinetBML);
            this.grpBoxBMLColum.Controls.Add(this.comboFloorBML);
            this.grpBoxBMLColum.Controls.Add(this.comboType_IPAddrBML);
            this.grpBoxBMLColum.Controls.Add(this.comboNameBML);
            this.grpBoxBMLColum.Controls.Add(this.lblFloor);
            this.grpBoxBMLColum.Controls.Add(this.lblSection);
            this.grpBoxBMLColum.Controls.Add(this.lblType_IPAddr);
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
            // comboControl_SlaveNoBML
            // 
            this.comboControl_SlaveNoBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboControl_SlaveNoBML.FormattingEnabled = true;
            this.comboControl_SlaveNoBML.IntegralHeight = false;
            this.comboControl_SlaveNoBML.Location = new System.Drawing.Point(214, 43);
            this.comboControl_SlaveNoBML.Name = "comboControl_SlaveNoBML";
            this.comboControl_SlaveNoBML.Size = new System.Drawing.Size(66, 21);
            this.comboControl_SlaveNoBML.TabIndex = 29;
            // 
            // lblControl_SlaveNo
            // 
            this.lblControl_SlaveNo.AutoSize = true;
            this.lblControl_SlaveNo.Location = new System.Drawing.Point(154, 46);
            this.lblControl_SlaveNo.Name = "lblControl_SlaveNo";
            this.lblControl_SlaveNo.Size = new System.Drawing.Size(67, 13);
            this.lblControl_SlaveNo.TabIndex = 28;
            this.lblControl_SlaveNo.Text = "控制类型：";
            this.lblControl_SlaveNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboStartRow
            // 
            this.comboStartRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStartRow.FormattingEnabled = true;
            this.comboStartRow.IntegralHeight = false;
            this.comboStartRow.Location = new System.Drawing.Point(620, 16);
            this.comboStartRow.Name = "comboStartRow";
            this.comboStartRow.Size = new System.Drawing.Size(66, 21);
            this.comboStartRow.TabIndex = 28;
            // 
            // lblStartRow
            // 
            this.lblStartRow.AutoSize = true;
            this.lblStartRow.Location = new System.Drawing.Point(579, 19);
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
            this.comboFloorBML.Location = new System.Drawing.Point(351, 18);
            this.comboFloorBML.Name = "comboFloorBML";
            this.comboFloorBML.Size = new System.Drawing.Size(66, 21);
            this.comboFloorBML.TabIndex = 22;
            // 
            // comboType_IPAddrBML
            // 
            this.comboType_IPAddrBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboType_IPAddrBML.FormattingEnabled = true;
            this.comboType_IPAddrBML.IntegralHeight = false;
            this.comboType_IPAddrBML.Location = new System.Drawing.Point(214, 16);
            this.comboType_IPAddrBML.Name = "comboType_IPAddrBML";
            this.comboType_IPAddrBML.Size = new System.Drawing.Size(66, 21);
            this.comboType_IPAddrBML.TabIndex = 21;
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
            this.lblFloor.Location = new System.Drawing.Point(302, 23);
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
            // lblType_IPAddr
            // 
            this.lblType_IPAddr.AutoSize = true;
            this.lblType_IPAddr.Location = new System.Drawing.Point(154, 19);
            this.lblType_IPAddr.Name = "lblType_IPAddr";
            this.lblType_IPAddr.Size = new System.Drawing.Size(67, 13);
            this.lblType_IPAddr.TabIndex = 8;
            this.lblType_IPAddr.Text = "设备类型：";
            this.lblType_IPAddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.PalCommon.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.PalCommon.Location = new System.Drawing.Point(7, 507);
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
            // FormDPSlave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(742, 728);
            this.Controls.Add(this.PalCommon);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabCreateMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDPSlave";
            this.Text = "DPSlave";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDPSlave_FormClosed);
            this.Load += new System.EventHandler(this.FormDPSlave_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabCreateMode.ResumeLayout(false);
            this.contextMenuStripBML.ResumeLayout(false);
            this.tabRule.ResumeLayout(false);
            this.tabRule.PerformLayout();
            this.PalGcObject.ResumeLayout(false);
            this.PalGcObject.PerformLayout();
            this.grpProfinet.ResumeLayout(false);
            this.grpProfinet.PerformLayout();
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
        internal System.Windows.Forms.Button BtnRegenerateDPNode;
        internal System.Windows.Forms.Button BtnNewImpExpDef;
        internal System.Windows.Forms.Label LblEquipmentInfoType;
        internal System.Windows.Forms.ComboBox ComboEquipmentInfoType;
        internal System.Windows.Forms.Label LblHornCode;
        internal System.Windows.Forms.ComboBox ComboHornCode;
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
        private System.Windows.Forms.Label lblType_IPAddr;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.GroupBox grpBoxExcelData;
        private System.Windows.Forms.DataGridView dataGridBML;
        internal System.Windows.Forms.Button btnReadBML;
        internal System.Windows.Forms.ComboBox comboSectionBML;
        internal System.Windows.Forms.ComboBox comboDescBML;
        internal System.Windows.Forms.ComboBox comboCabinetBML;
        internal System.Windows.Forms.ComboBox comboFloorBML;
        internal System.Windows.Forms.ComboBox comboType_IPAddrBML;
        internal System.Windows.Forms.ComboBox comboNameBML;
        internal System.Windows.Forms.ComboBox comboStartRow;
        private System.Windows.Forms.Label lblStartRow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClearList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ComboBox comboControl_SlaveNoBML;
        private System.Windows.Forms.Label lblControl_SlaveNo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.GroupBox grpAddInfoToDesc;
        internal System.Windows.Forms.CheckBox chkAddSectionToDesc;
        internal System.Windows.Forms.CheckBox chkAddFloorToDesc;
        internal System.Windows.Forms.CheckBox chkAddNameToDesc;
        internal System.Windows.Forms.CheckBox chkAddCabinetToDesc;
        internal System.Windows.Forms.Label lblSymbol;
        internal System.Windows.Forms.GroupBox grpDescriptionRule;
        internal System.Windows.Forms.Label lblDescriptionRule;
        internal System.Windows.Forms.TextBox txtDescriptionIncRule;
        internal System.Windows.Forms.Label lblDescriptionlIncRule;
        internal System.Windows.Forms.TextBox txtDescriptionRule;
        internal System.Windows.Forms.GroupBox grpSymbolRule;
        internal System.Windows.Forms.Label lblSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolRule;
        internal System.Windows.Forms.TextBox txtSymbolIncRule;
        internal System.Windows.Forms.Label lblSymbolIncRule;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtSymbol;
        internal System.Windows.Forms.Label LblDescription;
        internal System.Windows.Forms.Label lblValue31;
        internal System.Windows.Forms.TextBox txtValue31;
        internal System.Windows.Forms.GroupBox grpProfinet;
        internal System.Windows.Forms.TextBox txtWatchDogTime;
        internal System.Windows.Forms.Label lblWatchDogTime;
        internal System.Windows.Forms.TextBox txtWatchDogFactor;
        internal System.Windows.Forms.Label lblWatchDogFactor;
        internal System.Windows.Forms.TextBox txtUpdateTime;
        internal System.Windows.Forms.Label lblUpdateTime;
        internal System.Windows.Forms.CheckBox chkNameOnlyNumber;
        internal System.Windows.Forms.TextBox txtParSlaveNoIncRule;
        internal System.Windows.Forms.Label LblParSlaveNoIncRule;
        internal System.Windows.Forms.TextBox txtIPAddressIncRule;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label LblIPAddressIncRule;
        internal System.Windows.Forms.TextBox txtParSlaveNo;
        internal System.Windows.Forms.Label LblParDPNode;
        internal System.Windows.Forms.TextBox txtIPAddress;
        internal System.Windows.Forms.Label LblIPAddress;
        internal System.Windows.Forms.Label lblParSlaveNo;
        internal System.Windows.Forms.CheckBox chkUserDifinedExcel;
        internal System.Windows.Forms.CheckBox chkUpdateTimeManCalc;
    }
}

