using System;

namespace GcproExtensionApp
{
    partial class FormMDDx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDDx));
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
            this.grpReferences = new System.Windows.Forms.GroupBox();
            this.lblPassageNoS2Bottom = new System.Windows.Forms.Label();
            this.txtPassageNoS2Bottom = new System.Windows.Forms.TextBox();
            this.lblPassageNoS2Top = new System.Windows.Forms.Label();
            this.txtPassageNoS2Top = new System.Windows.Forms.TextBox();
            this.lblPassageNoS1Bottom = new System.Windows.Forms.Label();
            this.txtPassageNoS1Bottom = new System.Windows.Forms.TextBox();
            this.lblPassageNoS1Top = new System.Windows.Forms.Label();
            this.txtPassageNoS1Top = new System.Windows.Forms.TextBox();
            this.txSide2BottomRule = new System.Windows.Forms.TextBox();
            this.lblSide2BottomIncRule = new System.Windows.Forms.Label();
            this.txtSide2BottomIncRule = new System.Windows.Forms.TextBox();
            this.txtSide2Bottom = new System.Windows.Forms.TextBox();
            this.lblSide2Bottom = new System.Windows.Forms.Label();
            this.LblSide2BottomRule = new System.Windows.Forms.Label();
            this.txtSide2TopRule = new System.Windows.Forms.TextBox();
            this.lblSide2TopIncRule = new System.Windows.Forms.Label();
            this.txtSide2TopIncRule = new System.Windows.Forms.TextBox();
            this.txtSide2Top = new System.Windows.Forms.TextBox();
            this.lblSide2Top = new System.Windows.Forms.Label();
            this.LblSide2TopRule = new System.Windows.Forms.Label();
            this.txtSide1BottomRule = new System.Windows.Forms.TextBox();
            this.lblAirlockIncRule = new System.Windows.Forms.Label();
            this.txtSide1BottomIncRule = new System.Windows.Forms.TextBox();
            this.txtSide1Bottom = new System.Windows.Forms.TextBox();
            this.lblSide1Bottom = new System.Windows.Forms.Label();
            this.LblAirlockRule = new System.Windows.Forms.Label();
            this.txtSide1TopRule = new System.Windows.Forms.TextBox();
            this.lblSenderBinIncRule = new System.Windows.Forms.Label();
            this.txtSide1TopIncRule = new System.Windows.Forms.TextBox();
            this.txtSide1Top = new System.Windows.Forms.TextBox();
            this.lblSide1Top = new System.Windows.Forms.Label();
            this.LblSenderBinRule = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblValue27 = new System.Windows.Forms.Label();
            this.txtValue27 = new System.Windows.Forms.TextBox();
            this.lblValue25 = new System.Windows.Forms.Label();
            this.txtValue25 = new System.Windows.Forms.TextBox();
            this.LblValue28 = new System.Windows.Forms.Label();
            this.txtValue28 = new System.Windows.Forms.TextBox();
            this.lblValue26 = new System.Windows.Forms.Label();
            this.chkWarningA116CylDWN = new System.Windows.Forms.CheckBox();
            this.txtValue26 = new System.Windows.Forms.TextBox();
            this.chkWarningA115CylUp = new System.Windows.Forms.CheckBox();
            this.chkWarningA110Gap = new System.Windows.Forms.CheckBox();
            this.chkWarningA078Service = new System.Windows.Forms.CheckBox();
            this.chkWarningA077DigOut = new System.Windows.Forms.CheckBox();
            this.chkWarningA076HighTemp = new System.Windows.Forms.CheckBox();
            this.chkWarningW075WarnTemp = new System.Windows.Forms.CheckBox();
            this.chkWarningA072CANDOUT = new System.Windows.Forms.CheckBox();
            this.chkWarningA071CANMOD = new System.Windows.Forms.CheckBox();
            this.chkWarningA070CANCOM = new System.Windows.Forms.CheckBox();
            this.chkWarningAx69DosMax = new System.Windows.Forms.CheckBox();
            this.chkWarningAx68InletFull = new System.Windows.Forms.CheckBox();
            this.chkWarningW067HLBackupRight = new System.Windows.Forms.CheckBox();
            this.chkWarningA066HLBackupRight = new System.Windows.Forms.CheckBox();
            this.chkWarningW065HLBackupLeft = new System.Windows.Forms.CheckBox();
            this.chkWarningA064HLBackupLeft = new System.Windows.Forms.CheckBox();
            this.chkWarningA063HLOut3 = new System.Windows.Forms.CheckBox();
            this.chkWarningA062HLOut2 = new System.Windows.Forms.CheckBox();
            this.chkWarningA061HLOut1 = new System.Windows.Forms.CheckBox();
            this.chkWarningAx60HLInlet = new System.Windows.Forms.CheckBox();
            this.chkWarningA059M_Stop = new System.Windows.Forms.CheckBox();
            this.chkA116CylDWN = new System.Windows.Forms.CheckBox();
            this.chkA115CylUp = new System.Windows.Forms.CheckBox();
            this.chkA110Gap = new System.Windows.Forms.CheckBox();
            this.chkA078Service = new System.Windows.Forms.CheckBox();
            this.chkA077DigOut = new System.Windows.Forms.CheckBox();
            this.chkA076HighTemp = new System.Windows.Forms.CheckBox();
            this.chkW075WarnTemp = new System.Windows.Forms.CheckBox();
            this.chkA072CANDOUT = new System.Windows.Forms.CheckBox();
            this.chkA071CANMOD = new System.Windows.Forms.CheckBox();
            this.chkA070CANCOM = new System.Windows.Forms.CheckBox();
            this.chkAx69DosMax = new System.Windows.Forms.CheckBox();
            this.chkAx68InletFull = new System.Windows.Forms.CheckBox();
            this.chkW067HLBackupRight = new System.Windows.Forms.CheckBox();
            this.chkA066HLBackupRight = new System.Windows.Forms.CheckBox();
            this.chKW065HLBackupLeft = new System.Windows.Forms.CheckBox();
            this.chkA064HLBackupLeft = new System.Windows.Forms.CheckBox();
            this.chkAx63HLOut3 = new System.Windows.Forms.CheckBox();
            this.chkAx62HLOut2 = new System.Windows.Forms.CheckBox();
            this.chkAx61HLOut1 = new System.Windows.Forms.CheckBox();
            this.chkAx60HLInlet = new System.Windows.Forms.CheckBox();
            this.chkA059M_Stop = new System.Windows.Forms.CheckBox();
            this.chkWarningA112GapAct = new System.Windows.Forms.CheckBox();
            this.chkWarningA111GapSet = new System.Windows.Forms.CheckBox();
            this.chkWarningA058M_Stop = new System.Windows.Forms.CheckBox();
            this.chkWarningA057STBYDN = new System.Windows.Forms.CheckBox();
            this.chkWarningA056STBYUP = new System.Windows.Forms.CheckBox();
            this.chkWarningA055MotLow = new System.Windows.Forms.CheckBox();
            this.chkWarningA054MotUp = new System.Windows.Forms.CheckBox();
            this.chkWarningA053RollLow = new System.Windows.Forms.CheckBox();
            this.chkWarningA052RollUp = new System.Windows.Forms.CheckBox();
            this.chkWarningAx51FRoll2 = new System.Windows.Forms.CheckBox();
            this.chkWarningAx50FRoll1 = new System.Windows.Forms.CheckBox();
            this.chkWarningAx32Rod = new System.Windows.Forms.CheckBox();
            this.chkWarningAx30Zero = new System.Windows.Forms.CheckBox();
            this.chkWarningA024Empty = new System.Windows.Forms.CheckBox();
            this.chkWarningA018Battery = new System.Windows.Forms.CheckBox();
            this.chkWarningAx07Range = new System.Windows.Forms.CheckBox();
            this.chkWarningA005No24V = new System.Windows.Forms.CheckBox();
            this.chkWarningAxxxUnknow = new System.Windows.Forms.CheckBox();
            this.chkWarningAxxxDisplay = new System.Windows.Forms.CheckBox();
            this.chkWarningAxxxCommunication = new System.Windows.Forms.CheckBox();
            this.chkWarningAxxxSoftware = new System.Windows.Forms.CheckBox();
            this.chkA112GapAct = new System.Windows.Forms.CheckBox();
            this.chkA111GapSet = new System.Windows.Forms.CheckBox();
            this.chkA058M_Stop = new System.Windows.Forms.CheckBox();
            this.chkA057STBYDN = new System.Windows.Forms.CheckBox();
            this.chkA056STBYUP = new System.Windows.Forms.CheckBox();
            this.chkA055MotLow = new System.Windows.Forms.CheckBox();
            this.chkA054MotUp = new System.Windows.Forms.CheckBox();
            this.chkA053RollLow = new System.Windows.Forms.CheckBox();
            this.chkA052RollUp = new System.Windows.Forms.CheckBox();
            this.chkAx51FRoll2 = new System.Windows.Forms.CheckBox();
            this.chkAx50FRoll1 = new System.Windows.Forms.CheckBox();
            this.chkAx32Rod = new System.Windows.Forms.CheckBox();
            this.chkAx30Zero = new System.Windows.Forms.CheckBox();
            this.chkA024Empty = new System.Windows.Forms.CheckBox();
            this.chkA018Battery = new System.Windows.Forms.CheckBox();
            this.chkAx07Range = new System.Windows.Forms.CheckBox();
            this.chkA005No24V = new System.Windows.Forms.CheckBox();
            this.chkAxxxUnknow = new System.Windows.Forms.CheckBox();
            this.chkAxxxDisplay = new System.Windows.Forms.CheckBox();
            this.chkAxxxCommunication = new System.Windows.Forms.CheckBox();
            this.chkAxxxSoftware = new System.Windows.Forms.CheckBox();
            this.chkParWithRollerGapRecipe = new System.Windows.Forms.CheckBox();
            this.chkParWithRollerTemp = new System.Windows.Forms.CheckBox();
            this.chkParWithFeedRollRecipe = new System.Windows.Forms.CheckBox();
            this.chkParWithBearTemp = new System.Windows.Forms.CheckBox();
            this.chkParLogOff = new System.Windows.Forms.CheckBox();
            this.chkParSide1Divided = new System.Windows.Forms.CheckBox();
            this.lblValue10 = new System.Windows.Forms.Label();
            this.chkParSide2Divided = new System.Windows.Forms.CheckBox();
            this.txtValue10 = new System.Windows.Forms.TextBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.GrpIOByte = new System.Windows.Forms.GroupBox();
            this.txtIOByteIncRule = new System.Windows.Forms.TextBox();
            this.lblFParIOByte = new System.Windows.Forms.Label();
            this.lblIOByteIncRule = new System.Windows.Forms.Label();
            this.txtParIOByte = new System.Windows.Forms.TextBox();
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
            this.LblDPNode1 = new System.Windows.Forms.Label();
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
            this.comboControlBML = new System.Windows.Forms.ComboBox();
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
            this.grpReferences.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.GrpIOByte.SuspendLayout();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 961);
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
            this.tabCreateMode.Size = new System.Drawing.Size(742, 771);
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
            this.tabRule.Size = new System.Drawing.Size(734, 745);
            this.tabRule.TabIndex = 0;
            this.tabRule.Text = "设定规则创建";
            // 
            // PalGcObject
            // 
            this.PalGcObject.AutoScroll = true;
            this.PalGcObject.AutoSize = true;
            this.PalGcObject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PalGcObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PalGcObject.Controls.Add(this.grpReferences);
            this.PalGcObject.Controls.Add(this.grpFilter);
            this.PalGcObject.Controls.Add(this.chkParWithRollerGapRecipe);
            this.PalGcObject.Controls.Add(this.chkParWithRollerTemp);
            this.PalGcObject.Controls.Add(this.chkParWithFeedRollRecipe);
            this.PalGcObject.Controls.Add(this.chkParWithBearTemp);
            this.PalGcObject.Controls.Add(this.chkParLogOff);
            this.PalGcObject.Controls.Add(this.chkParSide1Divided);
            this.PalGcObject.Controls.Add(this.lblValue10);
            this.PalGcObject.Controls.Add(this.chkParSide2Divided);
            this.PalGcObject.Controls.Add(this.txtValue10);
            this.PalGcObject.Controls.Add(this.grpGeneral);
            this.PalGcObject.Controls.Add(this.BtnRegenerateDPNode);
            this.PalGcObject.Controls.Add(this.BtnNewImpExpDef);
            this.PalGcObject.Controls.Add(this.LblEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.ComboEquipmentInfoType);
            this.PalGcObject.Controls.Add(this.LblHornCode);
            this.PalGcObject.Controls.Add(this.ComboHornCode);
            this.PalGcObject.Controls.Add(this.LblDPNode1);
            this.PalGcObject.Controls.Add(this.ComboDPNode1);
            this.PalGcObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PalGcObject.Location = new System.Drawing.Point(3, 3);
            this.PalGcObject.Name = "PalGcObject";
            this.PalGcObject.Size = new System.Drawing.Size(728, 739);
            this.PalGcObject.TabIndex = 105;
            // 
            // grpReferences
            // 
            this.grpReferences.Controls.Add(this.lblPassageNoS2Bottom);
            this.grpReferences.Controls.Add(this.txtPassageNoS2Bottom);
            this.grpReferences.Controls.Add(this.lblPassageNoS2Top);
            this.grpReferences.Controls.Add(this.txtPassageNoS2Top);
            this.grpReferences.Controls.Add(this.lblPassageNoS1Bottom);
            this.grpReferences.Controls.Add(this.txtPassageNoS1Bottom);
            this.grpReferences.Controls.Add(this.lblPassageNoS1Top);
            this.grpReferences.Controls.Add(this.txtPassageNoS1Top);
            this.grpReferences.Controls.Add(this.txSide2BottomRule);
            this.grpReferences.Controls.Add(this.lblSide2BottomIncRule);
            this.grpReferences.Controls.Add(this.txtSide2BottomIncRule);
            this.grpReferences.Controls.Add(this.txtSide2Bottom);
            this.grpReferences.Controls.Add(this.lblSide2Bottom);
            this.grpReferences.Controls.Add(this.LblSide2BottomRule);
            this.grpReferences.Controls.Add(this.txtSide2TopRule);
            this.grpReferences.Controls.Add(this.lblSide2TopIncRule);
            this.grpReferences.Controls.Add(this.txtSide2TopIncRule);
            this.grpReferences.Controls.Add(this.txtSide2Top);
            this.grpReferences.Controls.Add(this.lblSide2Top);
            this.grpReferences.Controls.Add(this.LblSide2TopRule);
            this.grpReferences.Controls.Add(this.txtSide1BottomRule);
            this.grpReferences.Controls.Add(this.lblAirlockIncRule);
            this.grpReferences.Controls.Add(this.txtSide1BottomIncRule);
            this.grpReferences.Controls.Add(this.txtSide1Bottom);
            this.grpReferences.Controls.Add(this.lblSide1Bottom);
            this.grpReferences.Controls.Add(this.LblAirlockRule);
            this.grpReferences.Controls.Add(this.txtSide1TopRule);
            this.grpReferences.Controls.Add(this.lblSenderBinIncRule);
            this.grpReferences.Controls.Add(this.txtSide1TopIncRule);
            this.grpReferences.Controls.Add(this.txtSide1Top);
            this.grpReferences.Controls.Add(this.lblSide1Top);
            this.grpReferences.Controls.Add(this.LblSenderBinRule);
            this.grpReferences.Location = new System.Drawing.Point(7, 678);
            this.grpReferences.Name = "grpReferences";
            this.grpReferences.Size = new System.Drawing.Size(697, 114);
            this.grpReferences.TabIndex = 129;
            this.grpReferences.TabStop = false;
            this.grpReferences.Text = "MYTA Reference";
            // 
            // lblPassageNoS2Bottom
            // 
            this.lblPassageNoS2Bottom.AutoSize = true;
            this.lblPassageNoS2Bottom.Location = new System.Drawing.Point(388, 90);
            this.lblPassageNoS2Bottom.Name = "lblPassageNoS2Bottom";
            this.lblPassageNoS2Bottom.Size = new System.Drawing.Size(65, 13);
            this.lblPassageNoS2Bottom.TabIndex = 110;
            this.lblPassageNoS2Bottom.Text = "Passage No";
            // 
            // txtPassageNoS2Bottom
            // 
            this.txtPassageNoS2Bottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassageNoS2Bottom.Location = new System.Drawing.Point(454, 90);
            this.txtPassageNoS2Bottom.Name = "txtPassageNoS2Bottom";
            this.txtPassageNoS2Bottom.Size = new System.Drawing.Size(36, 13);
            this.txtPassageNoS2Bottom.TabIndex = 109;
            this.txtPassageNoS2Bottom.Text = "4";
            this.txtPassageNoS2Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassageNoS2Top
            // 
            this.lblPassageNoS2Top.AutoSize = true;
            this.lblPassageNoS2Top.Location = new System.Drawing.Point(388, 68);
            this.lblPassageNoS2Top.Name = "lblPassageNoS2Top";
            this.lblPassageNoS2Top.Size = new System.Drawing.Size(65, 13);
            this.lblPassageNoS2Top.TabIndex = 108;
            this.lblPassageNoS2Top.Text = "Passage No";
            // 
            // txtPassageNoS2Top
            // 
            this.txtPassageNoS2Top.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassageNoS2Top.Location = new System.Drawing.Point(454, 68);
            this.txtPassageNoS2Top.Name = "txtPassageNoS2Top";
            this.txtPassageNoS2Top.Size = new System.Drawing.Size(36, 13);
            this.txtPassageNoS2Top.TabIndex = 107;
            this.txtPassageNoS2Top.Text = "3";
            this.txtPassageNoS2Top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassageNoS1Bottom
            // 
            this.lblPassageNoS1Bottom.AutoSize = true;
            this.lblPassageNoS1Bottom.Location = new System.Drawing.Point(388, 42);
            this.lblPassageNoS1Bottom.Name = "lblPassageNoS1Bottom";
            this.lblPassageNoS1Bottom.Size = new System.Drawing.Size(65, 13);
            this.lblPassageNoS1Bottom.TabIndex = 106;
            this.lblPassageNoS1Bottom.Text = "Passage No";
            // 
            // txtPassageNoS1Bottom
            // 
            this.txtPassageNoS1Bottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassageNoS1Bottom.Location = new System.Drawing.Point(454, 42);
            this.txtPassageNoS1Bottom.Name = "txtPassageNoS1Bottom";
            this.txtPassageNoS1Bottom.Size = new System.Drawing.Size(36, 13);
            this.txtPassageNoS1Bottom.TabIndex = 105;
            this.txtPassageNoS1Bottom.Text = "2";
            this.txtPassageNoS1Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassageNoS1Top
            // 
            this.lblPassageNoS1Top.AutoSize = true;
            this.lblPassageNoS1Top.Location = new System.Drawing.Point(388, 17);
            this.lblPassageNoS1Top.Name = "lblPassageNoS1Top";
            this.lblPassageNoS1Top.Size = new System.Drawing.Size(65, 13);
            this.lblPassageNoS1Top.TabIndex = 104;
            this.lblPassageNoS1Top.Text = "Passage No";
            // 
            // txtPassageNoS1Top
            // 
            this.txtPassageNoS1Top.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassageNoS1Top.Location = new System.Drawing.Point(454, 17);
            this.txtPassageNoS1Top.Name = "txtPassageNoS1Top";
            this.txtPassageNoS1Top.Size = new System.Drawing.Size(36, 13);
            this.txtPassageNoS1Top.TabIndex = 103;
            this.txtPassageNoS1Top.Text = "1";
            this.txtPassageNoS1Top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txSide2BottomRule
            // 
            this.txSide2BottomRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSide2BottomRule.Location = new System.Drawing.Point(220, 91);
            this.txSide2BottomRule.Name = "txSide2BottomRule";
            this.txSide2BottomRule.Size = new System.Drawing.Size(56, 13);
            this.txSide2BottomRule.TabIndex = 100;
            // 
            // lblSide2BottomIncRule
            // 
            this.lblSide2BottomIncRule.AutoSize = true;
            this.lblSide2BottomIncRule.Location = new System.Drawing.Point(284, 91);
            this.lblSide2BottomIncRule.Name = "lblSide2BottomIncRule";
            this.lblSide2BottomIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblSide2BottomIncRule.TabIndex = 102;
            this.lblSide2BottomIncRule.Text = "递增规则";
            // 
            // txtSide2BottomIncRule
            // 
            this.txtSide2BottomIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide2BottomIncRule.Location = new System.Drawing.Point(339, 91);
            this.txtSide2BottomIncRule.Name = "txtSide2BottomIncRule";
            this.txtSide2BottomIncRule.Size = new System.Drawing.Size(36, 13);
            this.txtSide2BottomIncRule.TabIndex = 101;
            this.txtSide2BottomIncRule.Text = "1";
            // 
            // txtSide2Bottom
            // 
            this.txtSide2Bottom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSide2Bottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide2Bottom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSide2Bottom.Location = new System.Drawing.Point(74, 91);
            this.txtSide2Bottom.Name = "txtSide2Bottom";
            this.txtSide2Bottom.Size = new System.Drawing.Size(85, 13);
            this.txtSide2Bottom.TabIndex = 98;
            // 
            // lblSide2Bottom
            // 
            this.lblSide2Bottom.AutoSize = true;
            this.lblSide2Bottom.Location = new System.Drawing.Point(3, 91);
            this.lblSide2Bottom.Name = "lblSide2Bottom";
            this.lblSide2Bottom.Size = new System.Drawing.Size(70, 13);
            this.lblSide2Bottom.TabIndex = 97;
            this.lblSide2Bottom.Text = "Side2 Bottom";
            // 
            // LblSide2BottomRule
            // 
            this.LblSide2BottomRule.AutoSize = true;
            this.LblSide2BottomRule.Location = new System.Drawing.Point(165, 90);
            this.LblSide2BottomRule.Name = "LblSide2BottomRule";
            this.LblSide2BottomRule.Size = new System.Drawing.Size(55, 13);
            this.LblSide2BottomRule.TabIndex = 99;
            this.LblSide2BottomRule.Text = "规则字段";
            // 
            // txtSide2TopRule
            // 
            this.txtSide2TopRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide2TopRule.Location = new System.Drawing.Point(220, 68);
            this.txtSide2TopRule.Name = "txtSide2TopRule";
            this.txtSide2TopRule.Size = new System.Drawing.Size(56, 13);
            this.txtSide2TopRule.TabIndex = 94;
            // 
            // lblSide2TopIncRule
            // 
            this.lblSide2TopIncRule.AutoSize = true;
            this.lblSide2TopIncRule.Location = new System.Drawing.Point(284, 68);
            this.lblSide2TopIncRule.Name = "lblSide2TopIncRule";
            this.lblSide2TopIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblSide2TopIncRule.TabIndex = 96;
            this.lblSide2TopIncRule.Text = "递增规则";
            // 
            // txtSide2TopIncRule
            // 
            this.txtSide2TopIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide2TopIncRule.Location = new System.Drawing.Point(339, 68);
            this.txtSide2TopIncRule.Name = "txtSide2TopIncRule";
            this.txtSide2TopIncRule.Size = new System.Drawing.Size(36, 13);
            this.txtSide2TopIncRule.TabIndex = 95;
            this.txtSide2TopIncRule.Text = "1";
            // 
            // txtSide2Top
            // 
            this.txtSide2Top.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSide2Top.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide2Top.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSide2Top.Location = new System.Drawing.Point(74, 68);
            this.txtSide2Top.Name = "txtSide2Top";
            this.txtSide2Top.Size = new System.Drawing.Size(85, 13);
            this.txtSide2Top.TabIndex = 92;
            // 
            // lblSide2Top
            // 
            this.lblSide2Top.AutoSize = true;
            this.lblSide2Top.Location = new System.Drawing.Point(3, 68);
            this.lblSide2Top.Name = "lblSide2Top";
            this.lblSide2Top.Size = new System.Drawing.Size(56, 13);
            this.lblSide2Top.TabIndex = 91;
            this.lblSide2Top.Text = "Side2 Top";
            // 
            // LblSide2TopRule
            // 
            this.LblSide2TopRule.AutoSize = true;
            this.LblSide2TopRule.Location = new System.Drawing.Point(165, 67);
            this.LblSide2TopRule.Name = "LblSide2TopRule";
            this.LblSide2TopRule.Size = new System.Drawing.Size(55, 13);
            this.LblSide2TopRule.TabIndex = 93;
            this.LblSide2TopRule.Text = "规则字段";
            // 
            // txtSide1BottomRule
            // 
            this.txtSide1BottomRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide1BottomRule.Location = new System.Drawing.Point(220, 42);
            this.txtSide1BottomRule.Name = "txtSide1BottomRule";
            this.txtSide1BottomRule.Size = new System.Drawing.Size(56, 13);
            this.txtSide1BottomRule.TabIndex = 87;
            // 
            // lblAirlockIncRule
            // 
            this.lblAirlockIncRule.AutoSize = true;
            this.lblAirlockIncRule.Location = new System.Drawing.Point(284, 42);
            this.lblAirlockIncRule.Name = "lblAirlockIncRule";
            this.lblAirlockIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblAirlockIncRule.TabIndex = 89;
            this.lblAirlockIncRule.Text = "递增规则";
            // 
            // txtSide1BottomIncRule
            // 
            this.txtSide1BottomIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide1BottomIncRule.Location = new System.Drawing.Point(339, 42);
            this.txtSide1BottomIncRule.Name = "txtSide1BottomIncRule";
            this.txtSide1BottomIncRule.Size = new System.Drawing.Size(36, 13);
            this.txtSide1BottomIncRule.TabIndex = 88;
            this.txtSide1BottomIncRule.Text = "1";
            // 
            // txtSide1Bottom
            // 
            this.txtSide1Bottom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSide1Bottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide1Bottom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSide1Bottom.Location = new System.Drawing.Point(74, 42);
            this.txtSide1Bottom.Name = "txtSide1Bottom";
            this.txtSide1Bottom.Size = new System.Drawing.Size(85, 13);
            this.txtSide1Bottom.TabIndex = 85;
            // 
            // lblSide1Bottom
            // 
            this.lblSide1Bottom.AutoSize = true;
            this.lblSide1Bottom.Location = new System.Drawing.Point(3, 42);
            this.lblSide1Bottom.Name = "lblSide1Bottom";
            this.lblSide1Bottom.Size = new System.Drawing.Size(70, 13);
            this.lblSide1Bottom.TabIndex = 84;
            this.lblSide1Bottom.Text = "Side1 Bottom";
            // 
            // LblAirlockRule
            // 
            this.LblAirlockRule.AutoSize = true;
            this.LblAirlockRule.Location = new System.Drawing.Point(165, 41);
            this.LblAirlockRule.Name = "LblAirlockRule";
            this.LblAirlockRule.Size = new System.Drawing.Size(55, 13);
            this.LblAirlockRule.TabIndex = 86;
            this.LblAirlockRule.Text = "规则字段";
            // 
            // txtSide1TopRule
            // 
            this.txtSide1TopRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide1TopRule.Location = new System.Drawing.Point(220, 17);
            this.txtSide1TopRule.Name = "txtSide1TopRule";
            this.txtSide1TopRule.Size = new System.Drawing.Size(56, 13);
            this.txtSide1TopRule.TabIndex = 81;
            // 
            // lblSenderBinIncRule
            // 
            this.lblSenderBinIncRule.AutoSize = true;
            this.lblSenderBinIncRule.Location = new System.Drawing.Point(284, 17);
            this.lblSenderBinIncRule.Name = "lblSenderBinIncRule";
            this.lblSenderBinIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblSenderBinIncRule.TabIndex = 83;
            this.lblSenderBinIncRule.Text = "递增规则";
            // 
            // txtSide1TopIncRule
            // 
            this.txtSide1TopIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide1TopIncRule.Location = new System.Drawing.Point(339, 17);
            this.txtSide1TopIncRule.Name = "txtSide1TopIncRule";
            this.txtSide1TopIncRule.Size = new System.Drawing.Size(36, 13);
            this.txtSide1TopIncRule.TabIndex = 82;
            this.txtSide1TopIncRule.Text = "1";
            // 
            // txtSide1Top
            // 
            this.txtSide1Top.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSide1Top.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSide1Top.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSide1Top.Location = new System.Drawing.Point(74, 17);
            this.txtSide1Top.Name = "txtSide1Top";
            this.txtSide1Top.Size = new System.Drawing.Size(85, 13);
            this.txtSide1Top.TabIndex = 79;
            // 
            // lblSide1Top
            // 
            this.lblSide1Top.AutoSize = true;
            this.lblSide1Top.Location = new System.Drawing.Point(3, 17);
            this.lblSide1Top.Name = "lblSide1Top";
            this.lblSide1Top.Size = new System.Drawing.Size(56, 13);
            this.lblSide1Top.TabIndex = 78;
            this.lblSide1Top.Text = "Side1 Top";
            // 
            // LblSenderBinRule
            // 
            this.LblSenderBinRule.AutoSize = true;
            this.LblSenderBinRule.Location = new System.Drawing.Point(165, 16);
            this.LblSenderBinRule.Name = "LblSenderBinRule";
            this.LblSenderBinRule.Size = new System.Drawing.Size(55, 13);
            this.LblSenderBinRule.TabIndex = 80;
            this.LblSenderBinRule.Text = "规则字段";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.lblValue27);
            this.grpFilter.Controls.Add(this.txtValue27);
            this.grpFilter.Controls.Add(this.lblValue25);
            this.grpFilter.Controls.Add(this.txtValue25);
            this.grpFilter.Controls.Add(this.LblValue28);
            this.grpFilter.Controls.Add(this.txtValue28);
            this.grpFilter.Controls.Add(this.lblValue26);
            this.grpFilter.Controls.Add(this.chkWarningA116CylDWN);
            this.grpFilter.Controls.Add(this.txtValue26);
            this.grpFilter.Controls.Add(this.chkWarningA115CylUp);
            this.grpFilter.Controls.Add(this.chkWarningA110Gap);
            this.grpFilter.Controls.Add(this.chkWarningA078Service);
            this.grpFilter.Controls.Add(this.chkWarningA077DigOut);
            this.grpFilter.Controls.Add(this.chkWarningA076HighTemp);
            this.grpFilter.Controls.Add(this.chkWarningW075WarnTemp);
            this.grpFilter.Controls.Add(this.chkWarningA072CANDOUT);
            this.grpFilter.Controls.Add(this.chkWarningA071CANMOD);
            this.grpFilter.Controls.Add(this.chkWarningA070CANCOM);
            this.grpFilter.Controls.Add(this.chkWarningAx69DosMax);
            this.grpFilter.Controls.Add(this.chkWarningAx68InletFull);
            this.grpFilter.Controls.Add(this.chkWarningW067HLBackupRight);
            this.grpFilter.Controls.Add(this.chkWarningA066HLBackupRight);
            this.grpFilter.Controls.Add(this.chkWarningW065HLBackupLeft);
            this.grpFilter.Controls.Add(this.chkWarningA064HLBackupLeft);
            this.grpFilter.Controls.Add(this.chkWarningA063HLOut3);
            this.grpFilter.Controls.Add(this.chkWarningA062HLOut2);
            this.grpFilter.Controls.Add(this.chkWarningA061HLOut1);
            this.grpFilter.Controls.Add(this.chkWarningAx60HLInlet);
            this.grpFilter.Controls.Add(this.chkWarningA059M_Stop);
            this.grpFilter.Controls.Add(this.chkA116CylDWN);
            this.grpFilter.Controls.Add(this.chkA115CylUp);
            this.grpFilter.Controls.Add(this.chkA110Gap);
            this.grpFilter.Controls.Add(this.chkA078Service);
            this.grpFilter.Controls.Add(this.chkA077DigOut);
            this.grpFilter.Controls.Add(this.chkA076HighTemp);
            this.grpFilter.Controls.Add(this.chkW075WarnTemp);
            this.grpFilter.Controls.Add(this.chkA072CANDOUT);
            this.grpFilter.Controls.Add(this.chkA071CANMOD);
            this.grpFilter.Controls.Add(this.chkA070CANCOM);
            this.grpFilter.Controls.Add(this.chkAx69DosMax);
            this.grpFilter.Controls.Add(this.chkAx68InletFull);
            this.grpFilter.Controls.Add(this.chkW067HLBackupRight);
            this.grpFilter.Controls.Add(this.chkA066HLBackupRight);
            this.grpFilter.Controls.Add(this.chKW065HLBackupLeft);
            this.grpFilter.Controls.Add(this.chkA064HLBackupLeft);
            this.grpFilter.Controls.Add(this.chkAx63HLOut3);
            this.grpFilter.Controls.Add(this.chkAx62HLOut2);
            this.grpFilter.Controls.Add(this.chkAx61HLOut1);
            this.grpFilter.Controls.Add(this.chkAx60HLInlet);
            this.grpFilter.Controls.Add(this.chkA059M_Stop);
            this.grpFilter.Controls.Add(this.chkWarningA112GapAct);
            this.grpFilter.Controls.Add(this.chkWarningA111GapSet);
            this.grpFilter.Controls.Add(this.chkWarningA058M_Stop);
            this.grpFilter.Controls.Add(this.chkWarningA057STBYDN);
            this.grpFilter.Controls.Add(this.chkWarningA056STBYUP);
            this.grpFilter.Controls.Add(this.chkWarningA055MotLow);
            this.grpFilter.Controls.Add(this.chkWarningA054MotUp);
            this.grpFilter.Controls.Add(this.chkWarningA053RollLow);
            this.grpFilter.Controls.Add(this.chkWarningA052RollUp);
            this.grpFilter.Controls.Add(this.chkWarningAx51FRoll2);
            this.grpFilter.Controls.Add(this.chkWarningAx50FRoll1);
            this.grpFilter.Controls.Add(this.chkWarningAx32Rod);
            this.grpFilter.Controls.Add(this.chkWarningAx30Zero);
            this.grpFilter.Controls.Add(this.chkWarningA024Empty);
            this.grpFilter.Controls.Add(this.chkWarningA018Battery);
            this.grpFilter.Controls.Add(this.chkWarningAx07Range);
            this.grpFilter.Controls.Add(this.chkWarningA005No24V);
            this.grpFilter.Controls.Add(this.chkWarningAxxxUnknow);
            this.grpFilter.Controls.Add(this.chkWarningAxxxDisplay);
            this.grpFilter.Controls.Add(this.chkWarningAxxxCommunication);
            this.grpFilter.Controls.Add(this.chkWarningAxxxSoftware);
            this.grpFilter.Controls.Add(this.chkA112GapAct);
            this.grpFilter.Controls.Add(this.chkA111GapSet);
            this.grpFilter.Controls.Add(this.chkA058M_Stop);
            this.grpFilter.Controls.Add(this.chkA057STBYDN);
            this.grpFilter.Controls.Add(this.chkA056STBYUP);
            this.grpFilter.Controls.Add(this.chkA055MotLow);
            this.grpFilter.Controls.Add(this.chkA054MotUp);
            this.grpFilter.Controls.Add(this.chkA053RollLow);
            this.grpFilter.Controls.Add(this.chkA052RollUp);
            this.grpFilter.Controls.Add(this.chkAx51FRoll2);
            this.grpFilter.Controls.Add(this.chkAx50FRoll1);
            this.grpFilter.Controls.Add(this.chkAx32Rod);
            this.grpFilter.Controls.Add(this.chkAx30Zero);
            this.grpFilter.Controls.Add(this.chkA024Empty);
            this.grpFilter.Controls.Add(this.chkA018Battery);
            this.grpFilter.Controls.Add(this.chkAx07Range);
            this.grpFilter.Controls.Add(this.chkA005No24V);
            this.grpFilter.Controls.Add(this.chkAxxxUnknow);
            this.grpFilter.Controls.Add(this.chkAxxxDisplay);
            this.grpFilter.Controls.Add(this.chkAxxxCommunication);
            this.grpFilter.Controls.Add(this.chkAxxxSoftware);
            this.grpFilter.Location = new System.Drawing.Point(7, 270);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(697, 405);
            this.grpFilter.TabIndex = 128;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "ParFilter";
            // 
            // lblValue27
            // 
            this.lblValue27.AutoSize = true;
            this.lblValue27.Location = new System.Drawing.Point(451, 343);
            this.lblValue27.Name = "lblValue27";
            this.lblValue27.Size = new System.Drawing.Size(46, 13);
            this.lblValue27.TabIndex = 206;
            this.lblValue27.Text = "Value26";
            // 
            // txtValue27
            // 
            this.txtValue27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue27.Location = new System.Drawing.Point(455, 363);
            this.txtValue27.Name = "txtValue27";
            this.txtValue27.Size = new System.Drawing.Size(42, 13);
            this.txtValue27.TabIndex = 205;
            this.txtValue27.Text = "0";
            // 
            // lblValue25
            // 
            this.lblValue25.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblValue25.AutoSize = true;
            this.lblValue25.Location = new System.Drawing.Point(98, 345);
            this.lblValue25.Name = "lblValue25";
            this.lblValue25.Size = new System.Drawing.Size(46, 13);
            this.lblValue25.TabIndex = 204;
            this.lblValue25.Text = "Value25";
            // 
            // txtValue25
            // 
            this.txtValue25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue25.Location = new System.Drawing.Point(102, 365);
            this.txtValue25.Name = "txtValue25";
            this.txtValue25.Size = new System.Drawing.Size(42, 13);
            this.txtValue25.TabIndex = 203;
            this.txtValue25.Text = "0";
            // 
            // LblValue28
            // 
            this.LblValue28.AutoSize = true;
            this.LblValue28.Location = new System.Drawing.Point(627, 342);
            this.LblValue28.Name = "LblValue28";
            this.LblValue28.Size = new System.Drawing.Size(46, 13);
            this.LblValue28.TabIndex = 202;
            this.LblValue28.Text = "Value28";
            // 
            // txtValue28
            // 
            this.txtValue28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue28.Location = new System.Drawing.Point(631, 362);
            this.txtValue28.Name = "txtValue28";
            this.txtValue28.Size = new System.Drawing.Size(45, 13);
            this.txtValue28.TabIndex = 201;
            this.txtValue28.Text = "0";
            // 
            // lblValue26
            // 
            this.lblValue26.AutoSize = true;
            this.lblValue26.Location = new System.Drawing.Point(304, 342);
            this.lblValue26.Name = "lblValue26";
            this.lblValue26.Size = new System.Drawing.Size(46, 13);
            this.lblValue26.TabIndex = 120;
            this.lblValue26.Text = "Value26";
            // 
            // chkWarningA116CylDWN
            // 
            this.chkWarningA116CylDWN.AutoSize = true;
            this.chkWarningA116CylDWN.Enabled = false;
            this.chkWarningA116CylDWN.Location = new System.Drawing.Point(506, 379);
            this.chkWarningA116CylDWN.Name = "chkWarningA116CylDWN";
            this.chkWarningA116CylDWN.Size = new System.Drawing.Size(135, 17);
            this.chkWarningA116CylDWN.TabIndex = 200;
            this.chkWarningA116CylDWN.TabStop = false;
            this.chkWarningA116CylDWN.Text = "Warning.A116CylDWN";
            this.chkWarningA116CylDWN.UseVisualStyleBackColor = true;
            // 
            // txtValue26
            // 
            this.txtValue26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue26.Location = new System.Drawing.Point(308, 362);
            this.txtValue26.Name = "txtValue26";
            this.txtValue26.Size = new System.Drawing.Size(42, 13);
            this.txtValue26.TabIndex = 119;
            this.txtValue26.Text = "0";
            // 
            // chkWarningA115CylUp
            // 
            this.chkWarningA115CylUp.AutoSize = true;
            this.chkWarningA115CylUp.Enabled = false;
            this.chkWarningA115CylUp.Location = new System.Drawing.Point(506, 361);
            this.chkWarningA115CylUp.Name = "chkWarningA115CylUp";
            this.chkWarningA115CylUp.Size = new System.Drawing.Size(122, 17);
            this.chkWarningA115CylUp.TabIndex = 199;
            this.chkWarningA115CylUp.TabStop = false;
            this.chkWarningA115CylUp.Text = "Warning.A115CylUp";
            this.chkWarningA115CylUp.UseVisualStyleBackColor = true;
            // 
            // chkWarningA110Gap
            // 
            this.chkWarningA110Gap.AutoSize = true;
            this.chkWarningA110Gap.Checked = true;
            this.chkWarningA110Gap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningA110Gap.Location = new System.Drawing.Point(506, 343);
            this.chkWarningA110Gap.Name = "chkWarningA110Gap";
            this.chkWarningA110Gap.Size = new System.Drawing.Size(114, 17);
            this.chkWarningA110Gap.TabIndex = 198;
            this.chkWarningA110Gap.TabStop = false;
            this.chkWarningA110Gap.Text = "Warning.A110Gap";
            this.chkWarningA110Gap.UseVisualStyleBackColor = true;
            this.chkWarningA110Gap.CheckedChanged += new System.EventHandler(this.chkWarningA110Gap_CheckedChanged);
            // 
            // chkWarningA078Service
            // 
            this.chkWarningA078Service.AutoSize = true;
            this.chkWarningA078Service.Enabled = false;
            this.chkWarningA078Service.Location = new System.Drawing.Point(506, 325);
            this.chkWarningA078Service.Name = "chkWarningA078Service";
            this.chkWarningA078Service.Size = new System.Drawing.Size(130, 17);
            this.chkWarningA078Service.TabIndex = 197;
            this.chkWarningA078Service.Text = "Warning.A078Service";
            this.chkWarningA078Service.UseVisualStyleBackColor = true;
            // 
            // chkWarningA077DigOut
            // 
            this.chkWarningA077DigOut.AutoSize = true;
            this.chkWarningA077DigOut.Enabled = false;
            this.chkWarningA077DigOut.Location = new System.Drawing.Point(506, 307);
            this.chkWarningA077DigOut.Name = "chkWarningA077DigOut";
            this.chkWarningA077DigOut.Size = new System.Drawing.Size(127, 17);
            this.chkWarningA077DigOut.TabIndex = 196;
            this.chkWarningA077DigOut.TabStop = false;
            this.chkWarningA077DigOut.Text = "Warning.A077DigOut";
            this.chkWarningA077DigOut.UseVisualStyleBackColor = true;
            // 
            // chkWarningA076HighTemp
            // 
            this.chkWarningA076HighTemp.AutoSize = true;
            this.chkWarningA076HighTemp.Enabled = false;
            this.chkWarningA076HighTemp.Location = new System.Drawing.Point(506, 289);
            this.chkWarningA076HighTemp.Name = "chkWarningA076HighTemp";
            this.chkWarningA076HighTemp.Size = new System.Drawing.Size(143, 17);
            this.chkWarningA076HighTemp.TabIndex = 195;
            this.chkWarningA076HighTemp.TabStop = false;
            this.chkWarningA076HighTemp.Text = "Warning.A076HighTemp";
            this.chkWarningA076HighTemp.UseVisualStyleBackColor = true;
            // 
            // chkWarningW075WarnTemp
            // 
            this.chkWarningW075WarnTemp.AutoSize = true;
            this.chkWarningW075WarnTemp.Checked = true;
            this.chkWarningW075WarnTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningW075WarnTemp.Enabled = false;
            this.chkWarningW075WarnTemp.Location = new System.Drawing.Point(506, 271);
            this.chkWarningW075WarnTemp.Name = "chkWarningW075WarnTemp";
            this.chkWarningW075WarnTemp.Size = new System.Drawing.Size(151, 17);
            this.chkWarningW075WarnTemp.TabIndex = 194;
            this.chkWarningW075WarnTemp.Text = "Warning.W075WarnTemp";
            this.chkWarningW075WarnTemp.UseVisualStyleBackColor = true;
            this.chkWarningW075WarnTemp.CheckedChanged += new System.EventHandler(this.chkWarningW075WarnTemp_CheckedChanged);
            // 
            // chkWarningA072CANDOUT
            // 
            this.chkWarningA072CANDOUT.AutoSize = true;
            this.chkWarningA072CANDOUT.Enabled = false;
            this.chkWarningA072CANDOUT.Location = new System.Drawing.Point(506, 253);
            this.chkWarningA072CANDOUT.Name = "chkWarningA072CANDOUT";
            this.chkWarningA072CANDOUT.Size = new System.Drawing.Size(147, 17);
            this.chkWarningA072CANDOUT.TabIndex = 193;
            this.chkWarningA072CANDOUT.TabStop = false;
            this.chkWarningA072CANDOUT.Text = "Warning.A072CANDOUT";
            this.chkWarningA072CANDOUT.UseVisualStyleBackColor = true;
            // 
            // chkWarningA071CANMOD
            // 
            this.chkWarningA071CANMOD.AutoSize = true;
            this.chkWarningA071CANMOD.Enabled = false;
            this.chkWarningA071CANMOD.Location = new System.Drawing.Point(506, 235);
            this.chkWarningA071CANMOD.Name = "chkWarningA071CANMOD";
            this.chkWarningA071CANMOD.Size = new System.Drawing.Size(141, 17);
            this.chkWarningA071CANMOD.TabIndex = 192;
            this.chkWarningA071CANMOD.TabStop = false;
            this.chkWarningA071CANMOD.Text = "Warning.A071CANMOD";
            this.chkWarningA071CANMOD.UseVisualStyleBackColor = true;
            // 
            // chkWarningA070CANCOM
            // 
            this.chkWarningA070CANCOM.AutoSize = true;
            this.chkWarningA070CANCOM.Enabled = false;
            this.chkWarningA070CANCOM.Location = new System.Drawing.Point(506, 217);
            this.chkWarningA070CANCOM.Name = "chkWarningA070CANCOM";
            this.chkWarningA070CANCOM.Size = new System.Drawing.Size(140, 17);
            this.chkWarningA070CANCOM.TabIndex = 191;
            this.chkWarningA070CANCOM.TabStop = false;
            this.chkWarningA070CANCOM.Text = "Warning.A070CANCOM";
            this.chkWarningA070CANCOM.UseVisualStyleBackColor = true;
            // 
            // chkWarningAx69DosMax
            // 
            this.chkWarningAx69DosMax.AutoSize = true;
            this.chkWarningAx69DosMax.Checked = true;
            this.chkWarningAx69DosMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningAx69DosMax.Location = new System.Drawing.Point(506, 199);
            this.chkWarningAx69DosMax.Name = "chkWarningAx69DosMax";
            this.chkWarningAx69DosMax.Size = new System.Drawing.Size(132, 17);
            this.chkWarningAx69DosMax.TabIndex = 190;
            this.chkWarningAx69DosMax.TabStop = false;
            this.chkWarningAx69DosMax.Text = "Warning.Ax69DosMax";
            this.chkWarningAx69DosMax.UseVisualStyleBackColor = true;
            this.chkWarningAx69DosMax.CheckedChanged += new System.EventHandler(this.chkWarningAx69DosMax_CheckedChanged);
            // 
            // chkWarningAx68InletFull
            // 
            this.chkWarningAx68InletFull.AutoSize = true;
            this.chkWarningAx68InletFull.Checked = true;
            this.chkWarningAx68InletFull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningAx68InletFull.Location = new System.Drawing.Point(506, 181);
            this.chkWarningAx68InletFull.Name = "chkWarningAx68InletFull";
            this.chkWarningAx68InletFull.Size = new System.Drawing.Size(129, 17);
            this.chkWarningAx68InletFull.TabIndex = 189;
            this.chkWarningAx68InletFull.Text = "Warning.Ax68InletFull";
            this.chkWarningAx68InletFull.UseVisualStyleBackColor = true;
            this.chkWarningAx68InletFull.CheckedChanged += new System.EventHandler(this.chkWarningAx68InletFull_CheckedChanged);
            // 
            // chkWarningW067HLBackupRight
            // 
            this.chkWarningW067HLBackupRight.AutoSize = true;
            this.chkWarningW067HLBackupRight.Checked = true;
            this.chkWarningW067HLBackupRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningW067HLBackupRight.Location = new System.Drawing.Point(506, 163);
            this.chkWarningW067HLBackupRight.Name = "chkWarningW067HLBackupRight";
            this.chkWarningW067HLBackupRight.Size = new System.Drawing.Size(174, 17);
            this.chkWarningW067HLBackupRight.TabIndex = 188;
            this.chkWarningW067HLBackupRight.TabStop = false;
            this.chkWarningW067HLBackupRight.Text = "Warning.W067HLBackupRight";
            this.chkWarningW067HLBackupRight.UseVisualStyleBackColor = true;
            this.chkWarningW067HLBackupRight.CheckedChanged += new System.EventHandler(this.chkWarningW067HLBackupRight_CheckedChanged);
            // 
            // chkWarningA066HLBackupRight
            // 
            this.chkWarningA066HLBackupRight.AutoSize = true;
            this.chkWarningA066HLBackupRight.Location = new System.Drawing.Point(506, 145);
            this.chkWarningA066HLBackupRight.Name = "chkWarningA066HLBackupRight";
            this.chkWarningA066HLBackupRight.Size = new System.Drawing.Size(170, 17);
            this.chkWarningA066HLBackupRight.TabIndex = 187;
            this.chkWarningA066HLBackupRight.TabStop = false;
            this.chkWarningA066HLBackupRight.Text = "Warning.A066HLBackupRight";
            this.chkWarningA066HLBackupRight.UseVisualStyleBackColor = true;
            this.chkWarningA066HLBackupRight.CheckedChanged += new System.EventHandler(this.chkWarningA066HLBackupRight_CheckedChanged);
            // 
            // chkWarningW065HLBackupLeft
            // 
            this.chkWarningW065HLBackupLeft.AutoSize = true;
            this.chkWarningW065HLBackupLeft.Checked = true;
            this.chkWarningW065HLBackupLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningW065HLBackupLeft.Location = new System.Drawing.Point(506, 127);
            this.chkWarningW065HLBackupLeft.Name = "chkWarningW065HLBackupLeft";
            this.chkWarningW065HLBackupLeft.Size = new System.Drawing.Size(167, 17);
            this.chkWarningW065HLBackupLeft.TabIndex = 186;
            this.chkWarningW065HLBackupLeft.Text = "Warning.W065HLBackupLeft";
            this.chkWarningW065HLBackupLeft.UseVisualStyleBackColor = true;
            this.chkWarningW065HLBackupLeft.CheckedChanged += new System.EventHandler(this.chkWarningW065HLBackupLeft_CheckedChanged);
            // 
            // chkWarningA064HLBackupLeft
            // 
            this.chkWarningA064HLBackupLeft.AutoSize = true;
            this.chkWarningA064HLBackupLeft.Location = new System.Drawing.Point(506, 109);
            this.chkWarningA064HLBackupLeft.Name = "chkWarningA064HLBackupLeft";
            this.chkWarningA064HLBackupLeft.Size = new System.Drawing.Size(163, 17);
            this.chkWarningA064HLBackupLeft.TabIndex = 185;
            this.chkWarningA064HLBackupLeft.TabStop = false;
            this.chkWarningA064HLBackupLeft.Text = "Warning.A064HLBackupLeft";
            this.chkWarningA064HLBackupLeft.UseVisualStyleBackColor = true;
            this.chkWarningA064HLBackupLeft.CheckedChanged += new System.EventHandler(this.chkWarningA064HLBackupLeft_CheckedChanged);
            // 
            // chkWarningA063HLOut3
            // 
            this.chkWarningA063HLOut3.AutoSize = true;
            this.chkWarningA063HLOut3.Location = new System.Drawing.Point(506, 91);
            this.chkWarningA063HLOut3.Name = "chkWarningA063HLOut3";
            this.chkWarningA063HLOut3.Size = new System.Drawing.Size(131, 17);
            this.chkWarningA063HLOut3.TabIndex = 184;
            this.chkWarningA063HLOut3.TabStop = false;
            this.chkWarningA063HLOut3.Text = "Warning.A063HLOut3";
            this.chkWarningA063HLOut3.UseVisualStyleBackColor = true;
            this.chkWarningA063HLOut3.CheckedChanged += new System.EventHandler(this.chkWarningA063HLOut3_CheckedChanged);
            // 
            // chkWarningA062HLOut2
            // 
            this.chkWarningA062HLOut2.AutoSize = true;
            this.chkWarningA062HLOut2.Location = new System.Drawing.Point(506, 73);
            this.chkWarningA062HLOut2.Name = "chkWarningA062HLOut2";
            this.chkWarningA062HLOut2.Size = new System.Drawing.Size(131, 17);
            this.chkWarningA062HLOut2.TabIndex = 183;
            this.chkWarningA062HLOut2.Text = "Warning.A062HLOut2";
            this.chkWarningA062HLOut2.UseVisualStyleBackColor = true;
            this.chkWarningA062HLOut2.CheckedChanged += new System.EventHandler(this.chkWarningA062HLOut2_CheckedChanged);
            // 
            // chkWarningA061HLOut1
            // 
            this.chkWarningA061HLOut1.AutoSize = true;
            this.chkWarningA061HLOut1.Location = new System.Drawing.Point(506, 55);
            this.chkWarningA061HLOut1.Name = "chkWarningA061HLOut1";
            this.chkWarningA061HLOut1.Size = new System.Drawing.Size(131, 17);
            this.chkWarningA061HLOut1.TabIndex = 182;
            this.chkWarningA061HLOut1.TabStop = false;
            this.chkWarningA061HLOut1.Text = "Warning.A061HLOut1";
            this.chkWarningA061HLOut1.UseVisualStyleBackColor = true;
            this.chkWarningA061HLOut1.CheckedChanged += new System.EventHandler(this.chkWarningA061HLOut1_CheckedChanged);
            // 
            // chkWarningAx60HLInlet
            // 
            this.chkWarningAx60HLInlet.AutoSize = true;
            this.chkWarningAx60HLInlet.Location = new System.Drawing.Point(506, 37);
            this.chkWarningAx60HLInlet.Name = "chkWarningAx60HLInlet";
            this.chkWarningAx60HLInlet.Size = new System.Drawing.Size(127, 17);
            this.chkWarningAx60HLInlet.TabIndex = 181;
            this.chkWarningAx60HLInlet.TabStop = false;
            this.chkWarningAx60HLInlet.Text = "Warning.Ax60HLInlet";
            this.chkWarningAx60HLInlet.UseVisualStyleBackColor = true;
            this.chkWarningAx60HLInlet.CheckedChanged += new System.EventHandler(this.chkWarningAx60HLInlet_CheckedChanged);
            // 
            // chkWarningA059M_Stop
            // 
            this.chkWarningA059M_Stop.AutoSize = true;
            this.chkWarningA059M_Stop.Enabled = false;
            this.chkWarningA059M_Stop.Location = new System.Drawing.Point(506, 19);
            this.chkWarningA059M_Stop.Name = "chkWarningA059M_Stop";
            this.chkWarningA059M_Stop.Size = new System.Drawing.Size(131, 17);
            this.chkWarningA059M_Stop.TabIndex = 180;
            this.chkWarningA059M_Stop.Text = "Warning.A059M_Stop";
            this.chkWarningA059M_Stop.UseVisualStyleBackColor = true;
            // 
            // chkA116CylDWN
            // 
            this.chkA116CylDWN.AutoSize = true;
            this.chkA116CylDWN.Enabled = false;
            this.chkA116CylDWN.Location = new System.Drawing.Point(356, 379);
            this.chkA116CylDWN.Name = "chkA116CylDWN";
            this.chkA116CylDWN.Size = new System.Drawing.Size(92, 17);
            this.chkA116CylDWN.TabIndex = 179;
            this.chkA116CylDWN.TabStop = false;
            this.chkA116CylDWN.Text = "A116CylDWN";
            this.chkA116CylDWN.UseVisualStyleBackColor = true;
            // 
            // chkA115CylUp
            // 
            this.chkA115CylUp.AutoSize = true;
            this.chkA115CylUp.Enabled = false;
            this.chkA115CylUp.Location = new System.Drawing.Point(356, 361);
            this.chkA115CylUp.Name = "chkA115CylUp";
            this.chkA115CylUp.Size = new System.Drawing.Size(79, 17);
            this.chkA115CylUp.TabIndex = 178;
            this.chkA115CylUp.TabStop = false;
            this.chkA115CylUp.Text = "A115CylUp";
            this.chkA115CylUp.UseVisualStyleBackColor = true;
            // 
            // chkA110Gap
            // 
            this.chkA110Gap.AutoSize = true;
            this.chkA110Gap.Enabled = false;
            this.chkA110Gap.Location = new System.Drawing.Point(356, 343);
            this.chkA110Gap.Name = "chkA110Gap";
            this.chkA110Gap.Size = new System.Drawing.Size(71, 17);
            this.chkA110Gap.TabIndex = 177;
            this.chkA110Gap.TabStop = false;
            this.chkA110Gap.Text = "A110Gap";
            this.chkA110Gap.UseVisualStyleBackColor = true;
            // 
            // chkA078Service
            // 
            this.chkA078Service.AutoSize = true;
            this.chkA078Service.Enabled = false;
            this.chkA078Service.Location = new System.Drawing.Point(356, 325);
            this.chkA078Service.Name = "chkA078Service";
            this.chkA078Service.Size = new System.Drawing.Size(87, 17);
            this.chkA078Service.TabIndex = 176;
            this.chkA078Service.Text = "A078Service";
            this.chkA078Service.UseVisualStyleBackColor = true;
            // 
            // chkA077DigOut
            // 
            this.chkA077DigOut.AutoSize = true;
            this.chkA077DigOut.Enabled = false;
            this.chkA077DigOut.Location = new System.Drawing.Point(356, 307);
            this.chkA077DigOut.Name = "chkA077DigOut";
            this.chkA077DigOut.Size = new System.Drawing.Size(84, 17);
            this.chkA077DigOut.TabIndex = 175;
            this.chkA077DigOut.TabStop = false;
            this.chkA077DigOut.Text = "A077DigOut";
            this.chkA077DigOut.UseVisualStyleBackColor = true;
            // 
            // chkA076HighTemp
            // 
            this.chkA076HighTemp.AutoSize = true;
            this.chkA076HighTemp.Enabled = false;
            this.chkA076HighTemp.Location = new System.Drawing.Point(356, 289);
            this.chkA076HighTemp.Name = "chkA076HighTemp";
            this.chkA076HighTemp.Size = new System.Drawing.Size(100, 17);
            this.chkA076HighTemp.TabIndex = 174;
            this.chkA076HighTemp.TabStop = false;
            this.chkA076HighTemp.Text = "A076HighTemp";
            this.chkA076HighTemp.UseVisualStyleBackColor = true;
            // 
            // chkW075WarnTemp
            // 
            this.chkW075WarnTemp.AutoSize = true;
            this.chkW075WarnTemp.Enabled = false;
            this.chkW075WarnTemp.Location = new System.Drawing.Point(356, 271);
            this.chkW075WarnTemp.Name = "chkW075WarnTemp";
            this.chkW075WarnTemp.Size = new System.Drawing.Size(108, 17);
            this.chkW075WarnTemp.TabIndex = 173;
            this.chkW075WarnTemp.Text = "W075WarnTemp";
            this.chkW075WarnTemp.UseVisualStyleBackColor = true;
            // 
            // chkA072CANDOUT
            // 
            this.chkA072CANDOUT.AutoSize = true;
            this.chkA072CANDOUT.Enabled = false;
            this.chkA072CANDOUT.Location = new System.Drawing.Point(356, 253);
            this.chkA072CANDOUT.Name = "chkA072CANDOUT";
            this.chkA072CANDOUT.Size = new System.Drawing.Size(104, 17);
            this.chkA072CANDOUT.TabIndex = 172;
            this.chkA072CANDOUT.TabStop = false;
            this.chkA072CANDOUT.Text = "A072CANDOUT";
            this.chkA072CANDOUT.UseVisualStyleBackColor = true;
            // 
            // chkA071CANMOD
            // 
            this.chkA071CANMOD.AutoSize = true;
            this.chkA071CANMOD.Enabled = false;
            this.chkA071CANMOD.Location = new System.Drawing.Point(356, 235);
            this.chkA071CANMOD.Name = "chkA071CANMOD";
            this.chkA071CANMOD.Size = new System.Drawing.Size(98, 17);
            this.chkA071CANMOD.TabIndex = 171;
            this.chkA071CANMOD.TabStop = false;
            this.chkA071CANMOD.Text = "A071CANMOD";
            this.chkA071CANMOD.UseVisualStyleBackColor = true;
            // 
            // chkA070CANCOM
            // 
            this.chkA070CANCOM.AutoSize = true;
            this.chkA070CANCOM.Enabled = false;
            this.chkA070CANCOM.Location = new System.Drawing.Point(356, 217);
            this.chkA070CANCOM.Name = "chkA070CANCOM";
            this.chkA070CANCOM.Size = new System.Drawing.Size(97, 17);
            this.chkA070CANCOM.TabIndex = 170;
            this.chkA070CANCOM.TabStop = false;
            this.chkA070CANCOM.Text = "A070CANCOM";
            this.chkA070CANCOM.UseVisualStyleBackColor = true;
            // 
            // chkAx69DosMax
            // 
            this.chkAx69DosMax.AutoSize = true;
            this.chkAx69DosMax.Enabled = false;
            this.chkAx69DosMax.Location = new System.Drawing.Point(356, 199);
            this.chkAx69DosMax.Name = "chkAx69DosMax";
            this.chkAx69DosMax.Size = new System.Drawing.Size(89, 17);
            this.chkAx69DosMax.TabIndex = 169;
            this.chkAx69DosMax.TabStop = false;
            this.chkAx69DosMax.Text = "Ax69DosMax";
            this.chkAx69DosMax.UseVisualStyleBackColor = true;
            // 
            // chkAx68InletFull
            // 
            this.chkAx68InletFull.AutoSize = true;
            this.chkAx68InletFull.Enabled = false;
            this.chkAx68InletFull.Location = new System.Drawing.Point(356, 181);
            this.chkAx68InletFull.Name = "chkAx68InletFull";
            this.chkAx68InletFull.Size = new System.Drawing.Size(86, 17);
            this.chkAx68InletFull.TabIndex = 168;
            this.chkAx68InletFull.Text = "Ax68InletFull";
            this.chkAx68InletFull.UseVisualStyleBackColor = true;
            // 
            // chkW067HLBackupRight
            // 
            this.chkW067HLBackupRight.AutoSize = true;
            this.chkW067HLBackupRight.Enabled = false;
            this.chkW067HLBackupRight.Location = new System.Drawing.Point(356, 163);
            this.chkW067HLBackupRight.Name = "chkW067HLBackupRight";
            this.chkW067HLBackupRight.Size = new System.Drawing.Size(131, 17);
            this.chkW067HLBackupRight.TabIndex = 167;
            this.chkW067HLBackupRight.TabStop = false;
            this.chkW067HLBackupRight.Text = "W067HLBackupRight";
            this.chkW067HLBackupRight.UseVisualStyleBackColor = true;
            // 
            // chkA066HLBackupRight
            // 
            this.chkA066HLBackupRight.AutoSize = true;
            this.chkA066HLBackupRight.Enabled = false;
            this.chkA066HLBackupRight.Location = new System.Drawing.Point(356, 145);
            this.chkA066HLBackupRight.Name = "chkA066HLBackupRight";
            this.chkA066HLBackupRight.Size = new System.Drawing.Size(127, 17);
            this.chkA066HLBackupRight.TabIndex = 166;
            this.chkA066HLBackupRight.TabStop = false;
            this.chkA066HLBackupRight.Text = "A066HLBackupRight";
            this.chkA066HLBackupRight.UseVisualStyleBackColor = true;
            // 
            // chKW065HLBackupLeft
            // 
            this.chKW065HLBackupLeft.AutoSize = true;
            this.chKW065HLBackupLeft.Enabled = false;
            this.chKW065HLBackupLeft.Location = new System.Drawing.Point(356, 127);
            this.chKW065HLBackupLeft.Name = "chKW065HLBackupLeft";
            this.chKW065HLBackupLeft.Size = new System.Drawing.Size(124, 17);
            this.chKW065HLBackupLeft.TabIndex = 165;
            this.chKW065HLBackupLeft.Text = "W065HLBackupLeft";
            this.chKW065HLBackupLeft.UseVisualStyleBackColor = true;
            // 
            // chkA064HLBackupLeft
            // 
            this.chkA064HLBackupLeft.AutoSize = true;
            this.chkA064HLBackupLeft.Enabled = false;
            this.chkA064HLBackupLeft.Location = new System.Drawing.Point(356, 109);
            this.chkA064HLBackupLeft.Name = "chkA064HLBackupLeft";
            this.chkA064HLBackupLeft.Size = new System.Drawing.Size(120, 17);
            this.chkA064HLBackupLeft.TabIndex = 164;
            this.chkA064HLBackupLeft.TabStop = false;
            this.chkA064HLBackupLeft.Text = "A064HLBackupLeft";
            this.chkA064HLBackupLeft.UseVisualStyleBackColor = true;
            // 
            // chkAx63HLOut3
            // 
            this.chkAx63HLOut3.AutoSize = true;
            this.chkAx63HLOut3.Enabled = false;
            this.chkAx63HLOut3.Location = new System.Drawing.Point(356, 91);
            this.chkAx63HLOut3.Name = "chkAx63HLOut3";
            this.chkAx63HLOut3.Size = new System.Drawing.Size(87, 17);
            this.chkAx63HLOut3.TabIndex = 163;
            this.chkAx63HLOut3.TabStop = false;
            this.chkAx63HLOut3.Text = "Ax63HLOut3";
            this.chkAx63HLOut3.UseVisualStyleBackColor = true;
            // 
            // chkAx62HLOut2
            // 
            this.chkAx62HLOut2.AutoSize = true;
            this.chkAx62HLOut2.Enabled = false;
            this.chkAx62HLOut2.Location = new System.Drawing.Point(356, 73);
            this.chkAx62HLOut2.Name = "chkAx62HLOut2";
            this.chkAx62HLOut2.Size = new System.Drawing.Size(87, 17);
            this.chkAx62HLOut2.TabIndex = 162;
            this.chkAx62HLOut2.Text = "Ax62HLOut2";
            this.chkAx62HLOut2.UseVisualStyleBackColor = true;
            // 
            // chkAx61HLOut1
            // 
            this.chkAx61HLOut1.AutoSize = true;
            this.chkAx61HLOut1.Enabled = false;
            this.chkAx61HLOut1.Location = new System.Drawing.Point(356, 55);
            this.chkAx61HLOut1.Name = "chkAx61HLOut1";
            this.chkAx61HLOut1.Size = new System.Drawing.Size(87, 17);
            this.chkAx61HLOut1.TabIndex = 161;
            this.chkAx61HLOut1.TabStop = false;
            this.chkAx61HLOut1.Text = "Ax61HLOut1";
            this.chkAx61HLOut1.UseVisualStyleBackColor = true;
            // 
            // chkAx60HLInlet
            // 
            this.chkAx60HLInlet.AutoSize = true;
            this.chkAx60HLInlet.Enabled = false;
            this.chkAx60HLInlet.Location = new System.Drawing.Point(356, 37);
            this.chkAx60HLInlet.Name = "chkAx60HLInlet";
            this.chkAx60HLInlet.Size = new System.Drawing.Size(84, 17);
            this.chkAx60HLInlet.TabIndex = 160;
            this.chkAx60HLInlet.TabStop = false;
            this.chkAx60HLInlet.Text = "Ax60HLInlet";
            this.chkAx60HLInlet.UseVisualStyleBackColor = true;
            // 
            // chkA059M_Stop
            // 
            this.chkA059M_Stop.AutoSize = true;
            this.chkA059M_Stop.Enabled = false;
            this.chkA059M_Stop.Location = new System.Drawing.Point(356, 19);
            this.chkA059M_Stop.Name = "chkA059M_Stop";
            this.chkA059M_Stop.Size = new System.Drawing.Size(88, 17);
            this.chkA059M_Stop.TabIndex = 159;
            this.chkA059M_Stop.Text = "A059M_Stop";
            this.chkA059M_Stop.UseVisualStyleBackColor = true;
            // 
            // chkWarningA112GapAct
            // 
            this.chkWarningA112GapAct.AutoSize = true;
            this.chkWarningA112GapAct.Enabled = false;
            this.chkWarningA112GapAct.Location = new System.Drawing.Point(157, 379);
            this.chkWarningA112GapAct.Name = "chkWarningA112GapAct";
            this.chkWarningA112GapAct.Size = new System.Drawing.Size(130, 17);
            this.chkWarningA112GapAct.TabIndex = 158;
            this.chkWarningA112GapAct.TabStop = false;
            this.chkWarningA112GapAct.Text = "Warning.A112GapAct";
            this.chkWarningA112GapAct.UseVisualStyleBackColor = true;
            // 
            // chkWarningA111GapSet
            // 
            this.chkWarningA111GapSet.AutoSize = true;
            this.chkWarningA111GapSet.Checked = true;
            this.chkWarningA111GapSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningA111GapSet.Location = new System.Drawing.Point(157, 361);
            this.chkWarningA111GapSet.Name = "chkWarningA111GapSet";
            this.chkWarningA111GapSet.Size = new System.Drawing.Size(130, 17);
            this.chkWarningA111GapSet.TabIndex = 157;
            this.chkWarningA111GapSet.TabStop = false;
            this.chkWarningA111GapSet.Text = "Warning.A111GapSet";
            this.chkWarningA111GapSet.UseVisualStyleBackColor = true;
            this.chkWarningA111GapSet.CheckedChanged += new System.EventHandler(this.chkWarningA111GapSet_CheckedChanged);
            // 
            // chkWarningA058M_Stop
            // 
            this.chkWarningA058M_Stop.AutoSize = true;
            this.chkWarningA058M_Stop.Enabled = false;
            this.chkWarningA058M_Stop.Location = new System.Drawing.Point(157, 343);
            this.chkWarningA058M_Stop.Name = "chkWarningA058M_Stop";
            this.chkWarningA058M_Stop.Size = new System.Drawing.Size(131, 17);
            this.chkWarningA058M_Stop.TabIndex = 156;
            this.chkWarningA058M_Stop.TabStop = false;
            this.chkWarningA058M_Stop.Text = "Warning.A058M_Stop";
            this.chkWarningA058M_Stop.UseVisualStyleBackColor = true;
            // 
            // chkWarningA057STBYDN
            // 
            this.chkWarningA057STBYDN.AutoSize = true;
            this.chkWarningA057STBYDN.Location = new System.Drawing.Point(157, 325);
            this.chkWarningA057STBYDN.Name = "chkWarningA057STBYDN";
            this.chkWarningA057STBYDN.Size = new System.Drawing.Size(138, 17);
            this.chkWarningA057STBYDN.TabIndex = 155;
            this.chkWarningA057STBYDN.Text = "Warning.A057STBYDN";
            this.chkWarningA057STBYDN.UseVisualStyleBackColor = true;
            this.chkWarningA057STBYDN.CheckedChanged += new System.EventHandler(this.chkWarningA057STBYDN_CheckedChanged);
            // 
            // chkWarningA056STBYUP
            // 
            this.chkWarningA056STBYUP.AutoSize = true;
            this.chkWarningA056STBYUP.Location = new System.Drawing.Point(157, 307);
            this.chkWarningA056STBYUP.Name = "chkWarningA056STBYUP";
            this.chkWarningA056STBYUP.Size = new System.Drawing.Size(137, 17);
            this.chkWarningA056STBYUP.TabIndex = 154;
            this.chkWarningA056STBYUP.TabStop = false;
            this.chkWarningA056STBYUP.Text = "Warning.A056STBYUP";
            this.chkWarningA056STBYUP.UseVisualStyleBackColor = true;
            this.chkWarningA056STBYUP.CheckedChanged += new System.EventHandler(this.chkWarningA056STBYUP_CheckedChanged);
            // 
            // chkWarningA055MotLow
            // 
            this.chkWarningA055MotLow.AutoSize = true;
            this.chkWarningA055MotLow.Checked = true;
            this.chkWarningA055MotLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningA055MotLow.Location = new System.Drawing.Point(157, 289);
            this.chkWarningA055MotLow.Name = "chkWarningA055MotLow";
            this.chkWarningA055MotLow.Size = new System.Drawing.Size(132, 17);
            this.chkWarningA055MotLow.TabIndex = 153;
            this.chkWarningA055MotLow.TabStop = false;
            this.chkWarningA055MotLow.Text = "Warning.A055MotLow";
            this.chkWarningA055MotLow.UseVisualStyleBackColor = true;
            this.chkWarningA055MotLow.CheckedChanged += new System.EventHandler(this.chkWarningA055MotLow_CheckedChanged);
            // 
            // chkWarningA054MotUp
            // 
            this.chkWarningA054MotUp.AutoSize = true;
            this.chkWarningA054MotUp.Checked = true;
            this.chkWarningA054MotUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningA054MotUp.Location = new System.Drawing.Point(157, 271);
            this.chkWarningA054MotUp.Name = "chkWarningA054MotUp";
            this.chkWarningA054MotUp.Size = new System.Drawing.Size(126, 17);
            this.chkWarningA054MotUp.TabIndex = 152;
            this.chkWarningA054MotUp.Text = "Warning.A054MotUp";
            this.chkWarningA054MotUp.UseVisualStyleBackColor = true;
            this.chkWarningA054MotUp.CheckedChanged += new System.EventHandler(this.chkWarningA054MotUp_CheckedChanged);
            // 
            // chkWarningA053RollLow
            // 
            this.chkWarningA053RollLow.AutoSize = true;
            this.chkWarningA053RollLow.Location = new System.Drawing.Point(157, 253);
            this.chkWarningA053RollLow.Name = "chkWarningA053RollLow";
            this.chkWarningA053RollLow.Size = new System.Drawing.Size(132, 17);
            this.chkWarningA053RollLow.TabIndex = 151;
            this.chkWarningA053RollLow.TabStop = false;
            this.chkWarningA053RollLow.Text = "Warning.A053RollLow";
            this.chkWarningA053RollLow.UseVisualStyleBackColor = true;
            this.chkWarningA053RollLow.CheckedChanged += new System.EventHandler(this.chkWarningA053RollLow_CheckedChanged);
            // 
            // chkWarningA052RollUp
            // 
            this.chkWarningA052RollUp.AutoSize = true;
            this.chkWarningA052RollUp.Location = new System.Drawing.Point(157, 235);
            this.chkWarningA052RollUp.Name = "chkWarningA052RollUp";
            this.chkWarningA052RollUp.Size = new System.Drawing.Size(126, 17);
            this.chkWarningA052RollUp.TabIndex = 150;
            this.chkWarningA052RollUp.TabStop = false;
            this.chkWarningA052RollUp.Text = "Warning.A052RollUp";
            this.chkWarningA052RollUp.UseVisualStyleBackColor = true;
            this.chkWarningA052RollUp.CheckedChanged += new System.EventHandler(this.chkWarningA052RollUp_CheckedChanged);
            // 
            // chkWarningAx51FRoll2
            // 
            this.chkWarningAx51FRoll2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.chkWarningAx51FRoll2.AutoSize = true;
            this.chkWarningAx51FRoll2.Location = new System.Drawing.Point(157, 217);
            this.chkWarningAx51FRoll2.Name = "chkWarningAx51FRoll2";
            this.chkWarningAx51FRoll2.Size = new System.Drawing.Size(123, 17);
            this.chkWarningAx51FRoll2.TabIndex = 149;
            this.chkWarningAx51FRoll2.TabStop = false;
            this.chkWarningAx51FRoll2.Text = "Warning.Ax51FRoll2";
            this.chkWarningAx51FRoll2.UseVisualStyleBackColor = true;
            this.chkWarningAx51FRoll2.CheckedChanged += new System.EventHandler(this.chkWarningAx51FRoll2_CheckedChanged);
            // 
            // chkWarningAx50FRoll1
            // 
            this.chkWarningAx50FRoll1.AutoSize = true;
            this.chkWarningAx50FRoll1.Location = new System.Drawing.Point(157, 199);
            this.chkWarningAx50FRoll1.Name = "chkWarningAx50FRoll1";
            this.chkWarningAx50FRoll1.Size = new System.Drawing.Size(123, 17);
            this.chkWarningAx50FRoll1.TabIndex = 148;
            this.chkWarningAx50FRoll1.TabStop = false;
            this.chkWarningAx50FRoll1.Text = "Warning.Ax50FRoll1";
            this.chkWarningAx50FRoll1.UseVisualStyleBackColor = true;
            this.chkWarningAx50FRoll1.CheckedChanged += new System.EventHandler(this.chkWarningAx50FRoll1_CheckedChanged);
            // 
            // chkWarningAx32Rod
            // 
            this.chkWarningAx32Rod.AutoSize = true;
            this.chkWarningAx32Rod.Location = new System.Drawing.Point(157, 181);
            this.chkWarningAx32Rod.Name = "chkWarningAx32Rod";
            this.chkWarningAx32Rod.Size = new System.Drawing.Size(113, 17);
            this.chkWarningAx32Rod.TabIndex = 147;
            this.chkWarningAx32Rod.Text = "Warning.Ax32Rod";
            this.chkWarningAx32Rod.UseVisualStyleBackColor = true;
            this.chkWarningAx32Rod.CheckedChanged += new System.EventHandler(this.chkWarningAx32Rod_CheckedChanged);
            // 
            // chkWarningAx30Zero
            // 
            this.chkWarningAx30Zero.AutoSize = true;
            this.chkWarningAx30Zero.Location = new System.Drawing.Point(157, 163);
            this.chkWarningAx30Zero.Name = "chkWarningAx30Zero";
            this.chkWarningAx30Zero.Size = new System.Drawing.Size(115, 17);
            this.chkWarningAx30Zero.TabIndex = 146;
            this.chkWarningAx30Zero.TabStop = false;
            this.chkWarningAx30Zero.Text = "Warning.Ax30Zero";
            this.chkWarningAx30Zero.UseVisualStyleBackColor = true;
            this.chkWarningAx30Zero.CheckedChanged += new System.EventHandler(this.chkWarningAx30Zero_CheckedChanged);
            // 
            // chkWarningA024Empty
            // 
            this.chkWarningA024Empty.AutoSize = true;
            this.chkWarningA024Empty.Checked = true;
            this.chkWarningA024Empty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningA024Empty.Location = new System.Drawing.Point(157, 145);
            this.chkWarningA024Empty.Name = "chkWarningA024Empty";
            this.chkWarningA024Empty.Size = new System.Drawing.Size(123, 17);
            this.chkWarningA024Empty.TabIndex = 145;
            this.chkWarningA024Empty.TabStop = false;
            this.chkWarningA024Empty.Text = "Warning.A024Empty";
            this.chkWarningA024Empty.UseVisualStyleBackColor = true;
            this.chkWarningA024Empty.CheckedChanged += new System.EventHandler(this.chkWarningA024Empty_CheckedChanged);
            // 
            // chkWarningA018Battery
            // 
            this.chkWarningA018Battery.AutoSize = true;
            this.chkWarningA018Battery.Checked = true;
            this.chkWarningA018Battery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWarningA018Battery.Location = new System.Drawing.Point(157, 127);
            this.chkWarningA018Battery.Name = "chkWarningA018Battery";
            this.chkWarningA018Battery.Size = new System.Drawing.Size(127, 17);
            this.chkWarningA018Battery.TabIndex = 144;
            this.chkWarningA018Battery.Text = "Warning.A018Battery";
            this.chkWarningA018Battery.UseVisualStyleBackColor = true;
            this.chkWarningA018Battery.CheckedChanged += new System.EventHandler(this.chkWarningA018Battery_CheckedChanged);
            // 
            // chkWarningAx07Range
            // 
            this.chkWarningAx07Range.AutoSize = true;
            this.chkWarningAx07Range.Location = new System.Drawing.Point(157, 109);
            this.chkWarningAx07Range.Name = "chkWarningAx07Range";
            this.chkWarningAx07Range.Size = new System.Drawing.Size(125, 17);
            this.chkWarningAx07Range.TabIndex = 143;
            this.chkWarningAx07Range.TabStop = false;
            this.chkWarningAx07Range.Text = "Warning.Ax07Range";
            this.chkWarningAx07Range.UseVisualStyleBackColor = true;
            this.chkWarningAx07Range.CheckedChanged += new System.EventHandler(this.chkWarningAx07Range_CheckedChanged);
            // 
            // chkWarningA005No24V
            // 
            this.chkWarningA005No24V.AutoSize = true;
            this.chkWarningA005No24V.Enabled = false;
            this.chkWarningA005No24V.Location = new System.Drawing.Point(157, 91);
            this.chkWarningA005No24V.Name = "chkWarningA005No24V";
            this.chkWarningA005No24V.Size = new System.Drawing.Size(127, 17);
            this.chkWarningA005No24V.TabIndex = 142;
            this.chkWarningA005No24V.TabStop = false;
            this.chkWarningA005No24V.Text = "Warning.A005No24V";
            this.chkWarningA005No24V.UseVisualStyleBackColor = true;
            // 
            // chkWarningAxxxUnknow
            // 
            this.chkWarningAxxxUnknow.AutoSize = true;
            this.chkWarningAxxxUnknow.Enabled = false;
            this.chkWarningAxxxUnknow.Location = new System.Drawing.Point(157, 73);
            this.chkWarningAxxxUnknow.Name = "chkWarningAxxxUnknow";
            this.chkWarningAxxxUnknow.Size = new System.Drawing.Size(131, 17);
            this.chkWarningAxxxUnknow.TabIndex = 141;
            this.chkWarningAxxxUnknow.Text = "Warning.AxxxUnknow";
            this.chkWarningAxxxUnknow.UseVisualStyleBackColor = true;
            // 
            // chkWarningAxxxDisplay
            // 
            this.chkWarningAxxxDisplay.AutoSize = true;
            this.chkWarningAxxxDisplay.Enabled = false;
            this.chkWarningAxxxDisplay.Location = new System.Drawing.Point(157, 55);
            this.chkWarningAxxxDisplay.Name = "chkWarningAxxxDisplay";
            this.chkWarningAxxxDisplay.Size = new System.Drawing.Size(125, 17);
            this.chkWarningAxxxDisplay.TabIndex = 140;
            this.chkWarningAxxxDisplay.TabStop = false;
            this.chkWarningAxxxDisplay.Text = "Warning.AxxxDisplay";
            this.chkWarningAxxxDisplay.UseVisualStyleBackColor = true;
            // 
            // chkWarningAxxxCommunication
            // 
            this.chkWarningAxxxCommunication.AutoSize = true;
            this.chkWarningAxxxCommunication.Enabled = false;
            this.chkWarningAxxxCommunication.Location = new System.Drawing.Point(157, 37);
            this.chkWarningAxxxCommunication.Name = "chkWarningAxxxCommunication";
            this.chkWarningAxxxCommunication.Size = new System.Drawing.Size(163, 17);
            this.chkWarningAxxxCommunication.TabIndex = 139;
            this.chkWarningAxxxCommunication.TabStop = false;
            this.chkWarningAxxxCommunication.Text = "Warning.AxxxCommunication";
            this.chkWarningAxxxCommunication.UseVisualStyleBackColor = true;
            // 
            // chkWarningAxxxSoftware
            // 
            this.chkWarningAxxxSoftware.AutoSize = true;
            this.chkWarningAxxxSoftware.Enabled = false;
            this.chkWarningAxxxSoftware.Location = new System.Drawing.Point(157, 19);
            this.chkWarningAxxxSoftware.Name = "chkWarningAxxxSoftware";
            this.chkWarningAxxxSoftware.Size = new System.Drawing.Size(133, 17);
            this.chkWarningAxxxSoftware.TabIndex = 138;
            this.chkWarningAxxxSoftware.Text = "Warning.AxxxSoftware";
            this.chkWarningAxxxSoftware.UseVisualStyleBackColor = true;
            // 
            // chkA112GapAct
            // 
            this.chkA112GapAct.AutoSize = true;
            this.chkA112GapAct.Enabled = false;
            this.chkA112GapAct.Location = new System.Drawing.Point(11, 379);
            this.chkA112GapAct.Name = "chkA112GapAct";
            this.chkA112GapAct.Size = new System.Drawing.Size(87, 17);
            this.chkA112GapAct.TabIndex = 137;
            this.chkA112GapAct.TabStop = false;
            this.chkA112GapAct.Text = "A112GapAct";
            this.chkA112GapAct.UseVisualStyleBackColor = true;
            // 
            // chkA111GapSet
            // 
            this.chkA111GapSet.AutoSize = true;
            this.chkA111GapSet.Enabled = false;
            this.chkA111GapSet.Location = new System.Drawing.Point(11, 361);
            this.chkA111GapSet.Name = "chkA111GapSet";
            this.chkA111GapSet.Size = new System.Drawing.Size(87, 17);
            this.chkA111GapSet.TabIndex = 136;
            this.chkA111GapSet.TabStop = false;
            this.chkA111GapSet.Text = "A111GapSet";
            this.chkA111GapSet.UseVisualStyleBackColor = true;
            // 
            // chkA058M_Stop
            // 
            this.chkA058M_Stop.AutoSize = true;
            this.chkA058M_Stop.Enabled = false;
            this.chkA058M_Stop.Location = new System.Drawing.Point(11, 343);
            this.chkA058M_Stop.Name = "chkA058M_Stop";
            this.chkA058M_Stop.Size = new System.Drawing.Size(88, 17);
            this.chkA058M_Stop.TabIndex = 135;
            this.chkA058M_Stop.TabStop = false;
            this.chkA058M_Stop.Text = "A058M_Stop";
            this.chkA058M_Stop.UseVisualStyleBackColor = true;
            // 
            // chkA057STBYDN
            // 
            this.chkA057STBYDN.AutoSize = true;
            this.chkA057STBYDN.Enabled = false;
            this.chkA057STBYDN.Location = new System.Drawing.Point(11, 325);
            this.chkA057STBYDN.Name = "chkA057STBYDN";
            this.chkA057STBYDN.Size = new System.Drawing.Size(95, 17);
            this.chkA057STBYDN.TabIndex = 134;
            this.chkA057STBYDN.Text = "A057STBYDN";
            this.chkA057STBYDN.UseVisualStyleBackColor = true;
            // 
            // chkA056STBYUP
            // 
            this.chkA056STBYUP.AutoSize = true;
            this.chkA056STBYUP.Enabled = false;
            this.chkA056STBYUP.Location = new System.Drawing.Point(11, 307);
            this.chkA056STBYUP.Name = "chkA056STBYUP";
            this.chkA056STBYUP.Size = new System.Drawing.Size(94, 17);
            this.chkA056STBYUP.TabIndex = 133;
            this.chkA056STBYUP.TabStop = false;
            this.chkA056STBYUP.Text = "A056STBYUP";
            this.chkA056STBYUP.UseVisualStyleBackColor = true;
            // 
            // chkA055MotLow
            // 
            this.chkA055MotLow.AutoSize = true;
            this.chkA055MotLow.Enabled = false;
            this.chkA055MotLow.Location = new System.Drawing.Point(11, 289);
            this.chkA055MotLow.Name = "chkA055MotLow";
            this.chkA055MotLow.Size = new System.Drawing.Size(89, 17);
            this.chkA055MotLow.TabIndex = 132;
            this.chkA055MotLow.TabStop = false;
            this.chkA055MotLow.Text = "A055MotLow";
            this.chkA055MotLow.UseVisualStyleBackColor = true;
            // 
            // chkA054MotUp
            // 
            this.chkA054MotUp.AutoSize = true;
            this.chkA054MotUp.Enabled = false;
            this.chkA054MotUp.Location = new System.Drawing.Point(11, 271);
            this.chkA054MotUp.Name = "chkA054MotUp";
            this.chkA054MotUp.Size = new System.Drawing.Size(83, 17);
            this.chkA054MotUp.TabIndex = 131;
            this.chkA054MotUp.Text = "A054MotUp";
            this.chkA054MotUp.UseVisualStyleBackColor = true;
            // 
            // chkA053RollLow
            // 
            this.chkA053RollLow.AutoSize = true;
            this.chkA053RollLow.Enabled = false;
            this.chkA053RollLow.Location = new System.Drawing.Point(11, 253);
            this.chkA053RollLow.Name = "chkA053RollLow";
            this.chkA053RollLow.Size = new System.Drawing.Size(89, 17);
            this.chkA053RollLow.TabIndex = 130;
            this.chkA053RollLow.TabStop = false;
            this.chkA053RollLow.Text = "A053RollLow";
            this.chkA053RollLow.UseVisualStyleBackColor = true;
            // 
            // chkA052RollUp
            // 
            this.chkA052RollUp.AutoSize = true;
            this.chkA052RollUp.Enabled = false;
            this.chkA052RollUp.Location = new System.Drawing.Point(11, 235);
            this.chkA052RollUp.Name = "chkA052RollUp";
            this.chkA052RollUp.Size = new System.Drawing.Size(83, 17);
            this.chkA052RollUp.TabIndex = 129;
            this.chkA052RollUp.TabStop = false;
            this.chkA052RollUp.Text = "A052RollUp";
            this.chkA052RollUp.UseVisualStyleBackColor = true;
            // 
            // chkAx51FRoll2
            // 
            this.chkAx51FRoll2.AutoSize = true;
            this.chkAx51FRoll2.Enabled = false;
            this.chkAx51FRoll2.Location = new System.Drawing.Point(11, 217);
            this.chkAx51FRoll2.Name = "chkAx51FRoll2";
            this.chkAx51FRoll2.Size = new System.Drawing.Size(80, 17);
            this.chkAx51FRoll2.TabIndex = 128;
            this.chkAx51FRoll2.TabStop = false;
            this.chkAx51FRoll2.Text = "Ax51FRoll2";
            this.chkAx51FRoll2.UseVisualStyleBackColor = true;
            // 
            // chkAx50FRoll1
            // 
            this.chkAx50FRoll1.AutoSize = true;
            this.chkAx50FRoll1.Enabled = false;
            this.chkAx50FRoll1.Location = new System.Drawing.Point(11, 199);
            this.chkAx50FRoll1.Name = "chkAx50FRoll1";
            this.chkAx50FRoll1.Size = new System.Drawing.Size(80, 17);
            this.chkAx50FRoll1.TabIndex = 127;
            this.chkAx50FRoll1.TabStop = false;
            this.chkAx50FRoll1.Text = "Ax50FRoll1";
            this.chkAx50FRoll1.UseVisualStyleBackColor = true;
            // 
            // chkAx32Rod
            // 
            this.chkAx32Rod.AutoSize = true;
            this.chkAx32Rod.Enabled = false;
            this.chkAx32Rod.Location = new System.Drawing.Point(11, 181);
            this.chkAx32Rod.Name = "chkAx32Rod";
            this.chkAx32Rod.Size = new System.Drawing.Size(70, 17);
            this.chkAx32Rod.TabIndex = 126;
            this.chkAx32Rod.Text = "Ax32Rod";
            this.chkAx32Rod.UseVisualStyleBackColor = true;
            // 
            // chkAx30Zero
            // 
            this.chkAx30Zero.AutoSize = true;
            this.chkAx30Zero.Enabled = false;
            this.chkAx30Zero.Location = new System.Drawing.Point(11, 163);
            this.chkAx30Zero.Name = "chkAx30Zero";
            this.chkAx30Zero.Size = new System.Drawing.Size(72, 17);
            this.chkAx30Zero.TabIndex = 125;
            this.chkAx30Zero.TabStop = false;
            this.chkAx30Zero.Text = "Ax30Zero";
            this.chkAx30Zero.UseVisualStyleBackColor = true;
            // 
            // chkA024Empty
            // 
            this.chkA024Empty.AutoSize = true;
            this.chkA024Empty.Enabled = false;
            this.chkA024Empty.Location = new System.Drawing.Point(11, 145);
            this.chkA024Empty.Name = "chkA024Empty";
            this.chkA024Empty.Size = new System.Drawing.Size(80, 17);
            this.chkA024Empty.TabIndex = 124;
            this.chkA024Empty.TabStop = false;
            this.chkA024Empty.Text = "A024Empty";
            this.chkA024Empty.UseVisualStyleBackColor = true;
            // 
            // chkA018Battery
            // 
            this.chkA018Battery.AutoSize = true;
            this.chkA018Battery.Enabled = false;
            this.chkA018Battery.Location = new System.Drawing.Point(11, 127);
            this.chkA018Battery.Name = "chkA018Battery";
            this.chkA018Battery.Size = new System.Drawing.Size(84, 17);
            this.chkA018Battery.TabIndex = 123;
            this.chkA018Battery.Text = "A018Battery";
            this.chkA018Battery.UseVisualStyleBackColor = true;
            // 
            // chkAx07Range
            // 
            this.chkAx07Range.AutoSize = true;
            this.chkAx07Range.Enabled = false;
            this.chkAx07Range.Location = new System.Drawing.Point(11, 109);
            this.chkAx07Range.Name = "chkAx07Range";
            this.chkAx07Range.Size = new System.Drawing.Size(82, 17);
            this.chkAx07Range.TabIndex = 122;
            this.chkAx07Range.TabStop = false;
            this.chkAx07Range.Text = "Ax07Range";
            this.chkAx07Range.UseVisualStyleBackColor = true;
            // 
            // chkA005No24V
            // 
            this.chkA005No24V.AutoSize = true;
            this.chkA005No24V.Enabled = false;
            this.chkA005No24V.Location = new System.Drawing.Point(11, 91);
            this.chkA005No24V.Name = "chkA005No24V";
            this.chkA005No24V.Size = new System.Drawing.Size(84, 17);
            this.chkA005No24V.TabIndex = 121;
            this.chkA005No24V.TabStop = false;
            this.chkA005No24V.Text = "A005No24V";
            this.chkA005No24V.UseVisualStyleBackColor = true;
            // 
            // chkAxxxUnknow
            // 
            this.chkAxxxUnknow.AutoSize = true;
            this.chkAxxxUnknow.Enabled = false;
            this.chkAxxxUnknow.Location = new System.Drawing.Point(11, 73);
            this.chkAxxxUnknow.Name = "chkAxxxUnknow";
            this.chkAxxxUnknow.Size = new System.Drawing.Size(88, 17);
            this.chkAxxxUnknow.TabIndex = 120;
            this.chkAxxxUnknow.Text = "AxxxUnknow";
            this.chkAxxxUnknow.UseVisualStyleBackColor = true;
            // 
            // chkAxxxDisplay
            // 
            this.chkAxxxDisplay.AutoSize = true;
            this.chkAxxxDisplay.Enabled = false;
            this.chkAxxxDisplay.Location = new System.Drawing.Point(11, 55);
            this.chkAxxxDisplay.Name = "chkAxxxDisplay";
            this.chkAxxxDisplay.Size = new System.Drawing.Size(82, 17);
            this.chkAxxxDisplay.TabIndex = 119;
            this.chkAxxxDisplay.TabStop = false;
            this.chkAxxxDisplay.Text = "AxxxDisplay";
            this.chkAxxxDisplay.UseVisualStyleBackColor = true;
            // 
            // chkAxxxCommunication
            // 
            this.chkAxxxCommunication.AutoSize = true;
            this.chkAxxxCommunication.Enabled = false;
            this.chkAxxxCommunication.Location = new System.Drawing.Point(11, 37);
            this.chkAxxxCommunication.Name = "chkAxxxCommunication";
            this.chkAxxxCommunication.Size = new System.Drawing.Size(120, 17);
            this.chkAxxxCommunication.TabIndex = 118;
            this.chkAxxxCommunication.TabStop = false;
            this.chkAxxxCommunication.Text = "AxxxCommunication";
            this.chkAxxxCommunication.UseVisualStyleBackColor = true;
            // 
            // chkAxxxSoftware
            // 
            this.chkAxxxSoftware.AutoSize = true;
            this.chkAxxxSoftware.Enabled = false;
            this.chkAxxxSoftware.Location = new System.Drawing.Point(11, 19);
            this.chkAxxxSoftware.Name = "chkAxxxSoftware";
            this.chkAxxxSoftware.Size = new System.Drawing.Size(90, 17);
            this.chkAxxxSoftware.TabIndex = 117;
            this.chkAxxxSoftware.Text = "AxxxSoftware";
            this.chkAxxxSoftware.UseVisualStyleBackColor = true;
            // 
            // chkParWithRollerGapRecipe
            // 
            this.chkParWithRollerGapRecipe.AutoSize = true;
            this.chkParWithRollerGapRecipe.Location = new System.Drawing.Point(559, 234);
            this.chkParWithRollerGapRecipe.Name = "chkParWithRollerGapRecipe";
            this.chkParWithRollerGapRecipe.Size = new System.Drawing.Size(145, 17);
            this.chkParWithRollerGapRecipe.TabIndex = 127;
            this.chkParWithRollerGapRecipe.Tag = "";
            this.chkParWithRollerGapRecipe.Text = "ParWithRollerGapRecipe";
            this.chkParWithRollerGapRecipe.UseVisualStyleBackColor = true;
            this.chkParWithRollerGapRecipe.CheckedChanged += new System.EventHandler(this.chkParWithRollerGapRecipe_CheckedChanged);
            // 
            // chkParWithRollerTemp
            // 
            this.chkParWithRollerTemp.AutoSize = true;
            this.chkParWithRollerTemp.Location = new System.Drawing.Point(559, 211);
            this.chkParWithRollerTemp.Name = "chkParWithRollerTemp";
            this.chkParWithRollerTemp.Size = new System.Drawing.Size(118, 17);
            this.chkParWithRollerTemp.TabIndex = 126;
            this.chkParWithRollerTemp.Tag = "ParWithRollerTempParWithRollerTemp";
            this.chkParWithRollerTemp.Text = "ParWithRollerTemp";
            this.chkParWithRollerTemp.UseVisualStyleBackColor = true;
            this.chkParWithRollerTemp.CheckedChanged += new System.EventHandler(this.chkParWithRollerTemp_CheckedChanged);
            // 
            // chkParWithFeedRollRecipe
            // 
            this.chkParWithFeedRollRecipe.AutoSize = true;
            this.chkParWithFeedRollRecipe.Location = new System.Drawing.Point(559, 190);
            this.chkParWithFeedRollRecipe.Name = "chkParWithFeedRollRecipe";
            this.chkParWithFeedRollRecipe.Size = new System.Drawing.Size(140, 17);
            this.chkParWithFeedRollRecipe.TabIndex = 125;
            this.chkParWithFeedRollRecipe.Tag = "";
            this.chkParWithFeedRollRecipe.Text = "ParWithFeedRollRecipe";
            this.chkParWithFeedRollRecipe.UseVisualStyleBackColor = true;
            this.chkParWithFeedRollRecipe.CheckedChanged += new System.EventHandler(this.chkParWithFeedRollRecipe_CheckedChanged);
            // 
            // chkParWithBearTemp
            // 
            this.chkParWithBearTemp.AutoSize = true;
            this.chkParWithBearTemp.Location = new System.Drawing.Point(559, 170);
            this.chkParWithBearTemp.Name = "chkParWithBearTemp";
            this.chkParWithBearTemp.Size = new System.Drawing.Size(113, 17);
            this.chkParWithBearTemp.TabIndex = 124;
            this.chkParWithBearTemp.Tag = "";
            this.chkParWithBearTemp.Text = "ParWithBearTemp";
            this.chkParWithBearTemp.UseVisualStyleBackColor = true;
            this.chkParWithBearTemp.CheckedChanged += new System.EventHandler(this.chkParWithBearTemp_CheckedChanged);
            // 
            // chkParLogOff
            // 
            this.chkParLogOff.AutoSize = true;
            this.chkParLogOff.Location = new System.Drawing.Point(457, 174);
            this.chkParLogOff.Name = "chkParLogOff";
            this.chkParLogOff.Size = new System.Drawing.Size(72, 17);
            this.chkParLogOff.TabIndex = 119;
            this.chkParLogOff.Text = "ParLogoff";
            this.chkParLogOff.UseVisualStyleBackColor = true;
            this.chkParLogOff.CheckedChanged += new System.EventHandler(this.chkParLogOff_CheckedChanged);
            // 
            // chkParSide1Divided
            // 
            this.chkParSide1Divided.AutoSize = true;
            this.chkParSide1Divided.Location = new System.Drawing.Point(457, 192);
            this.chkParSide1Divided.Name = "chkParSide1Divided";
            this.chkParSide1Divided.Size = new System.Drawing.Size(105, 17);
            this.chkParSide1Divided.TabIndex = 120;
            this.chkParSide1Divided.Text = "ParSide1Divided";
            this.chkParSide1Divided.UseVisualStyleBackColor = true;
            this.chkParSide1Divided.CheckedChanged += new System.EventHandler(this.chkParSide1Divided_CheckedChanged);
            // 
            // lblValue10
            // 
            this.lblValue10.AutoSize = true;
            this.lblValue10.Location = new System.Drawing.Point(459, 229);
            this.lblValue10.Name = "lblValue10";
            this.lblValue10.Size = new System.Drawing.Size(46, 13);
            this.lblValue10.TabIndex = 123;
            this.lblValue10.Text = "Value10";
            // 
            // chkParSide2Divided
            // 
            this.chkParSide2Divided.AutoSize = true;
            this.chkParSide2Divided.Location = new System.Drawing.Point(457, 211);
            this.chkParSide2Divided.Name = "chkParSide2Divided";
            this.chkParSide2Divided.Size = new System.Drawing.Size(105, 17);
            this.chkParSide2Divided.TabIndex = 121;
            this.chkParSide2Divided.Tag = "";
            this.chkParSide2Divided.Text = "ParSide2Divided";
            this.chkParSide2Divided.UseVisualStyleBackColor = true;
            this.chkParSide2Divided.CheckedChanged += new System.EventHandler(this.chkParSide2Divided_CheckedChanged);
            // 
            // txtValue10
            // 
            this.txtValue10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue10.Location = new System.Drawing.Point(463, 249);
            this.txtValue10.Name = "txtValue10";
            this.txtValue10.Size = new System.Drawing.Size(39, 13);
            this.txtValue10.TabIndex = 122;
            this.txtValue10.Text = "0";
            this.txtValue10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue10_KeyDown);
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.GrpIOByte);
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
            // GrpIOByte
            // 
            this.GrpIOByte.Controls.Add(this.txtIOByteIncRule);
            this.GrpIOByte.Controls.Add(this.lblFParIOByte);
            this.GrpIOByte.Controls.Add(this.lblIOByteIncRule);
            this.GrpIOByte.Controls.Add(this.txtParIOByte);
            this.GrpIOByte.Location = new System.Drawing.Point(242, 61);
            this.GrpIOByte.Name = "GrpIOByte";
            this.GrpIOByte.Size = new System.Drawing.Size(349, 43);
            this.GrpIOByte.TabIndex = 124;
            this.GrpIOByte.TabStop = false;
            this.GrpIOByte.Text = "IO Byte和规则";
            // 
            // txtIOByteIncRule
            // 
            this.txtIOByteIncRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIOByteIncRule.Location = new System.Drawing.Point(225, 17);
            this.txtIOByteIncRule.Name = "txtIOByteIncRule";
            this.txtIOByteIncRule.Size = new System.Drawing.Size(66, 13);
            this.txtIOByteIncRule.TabIndex = 73;
            // 
            // lblFParIOByte
            // 
            this.lblFParIOByte.AutoSize = true;
            this.lblFParIOByte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFParIOByte.Location = new System.Drawing.Point(9, 17);
            this.lblFParIOByte.Name = "lblFParIOByte";
            this.lblFParIOByte.Size = new System.Drawing.Size(55, 13);
            this.lblFParIOByte.TabIndex = 30;
            this.lblFParIOByte.Text = "ParIOByte";
            // 
            // lblIOByteIncRule
            // 
            this.lblIOByteIncRule.AutoSize = true;
            this.lblIOByteIncRule.Location = new System.Drawing.Point(169, 17);
            this.lblIOByteIncRule.Name = "lblIOByteIncRule";
            this.lblIOByteIncRule.Size = new System.Drawing.Size(55, 13);
            this.lblIOByteIncRule.TabIndex = 72;
            this.lblIOByteIncRule.Text = "递增规则";
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
            this.grpAddInfoToDesc.Text = "附加信息到描述";
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
            this.LblDescription.Size = new System.Drawing.Size(103, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "磨粉机控制器描述";
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
            this.LblEquipmentInfoType.Location = new System.Drawing.Point(1, 199);
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
            this.ComboEquipmentInfoType.Location = new System.Drawing.Point(100, 196);
            this.ComboEquipmentInfoType.Name = "ComboEquipmentInfoType";
            this.ComboEquipmentInfoType.Size = new System.Drawing.Size(337, 21);
            this.ComboEquipmentInfoType.TabIndex = 13;
            this.ComboEquipmentInfoType.MouseEnter += new System.EventHandler(this.ComboEquipmentInfoType_MouseEnter);
            // 
            // LblHornCode
            // 
            this.LblHornCode.AutoSize = true;
            this.LblHornCode.Location = new System.Drawing.Point(1, 224);
            this.LblHornCode.Name = "LblHornCode";
            this.LblHornCode.Size = new System.Drawing.Size(71, 13);
            this.LblHornCode.TabIndex = 14;
            this.LblHornCode.Text = "ParHornCode";
            // 
            // ComboHornCode
            // 
            this.ComboHornCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboHornCode.FormattingEnabled = true;
            this.ComboHornCode.Location = new System.Drawing.Point(100, 220);
            this.ComboHornCode.Name = "ComboHornCode";
            this.ComboHornCode.Size = new System.Drawing.Size(146, 21);
            this.ComboHornCode.TabIndex = 15;
            this.ComboHornCode.MouseEnter += new System.EventHandler(this.ComboHornCode_MouseEnter);
            // 
            // LblDPNode1
            // 
            this.LblDPNode1.AutoSize = true;
            this.LblDPNode1.Location = new System.Drawing.Point(1, 249);
            this.LblDPNode1.Name = "LblDPNode1";
            this.LblDPNode1.Size = new System.Drawing.Size(64, 13);
            this.LblDPNode1.TabIndex = 16;
            this.LblDPNode1.Text = "ParDPNode";
            // 
            // ComboDPNode1
            // 
            this.ComboDPNode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboDPNode1.FormattingEnabled = true;
            this.ComboDPNode1.Location = new System.Drawing.Point(100, 243);
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
            this.tabBML.Size = new System.Drawing.Size(734, 745);
            this.tabBML.TabIndex = 1;
            this.tabBML.Text = "通过BML创建";
            // 
            // grpBoxExcelData
            // 
            this.grpBoxExcelData.Controls.Add(this.btnReadBML);
            this.grpBoxExcelData.Controls.Add(this.dataGridBML);
            this.grpBoxExcelData.Controls.Add(this.lblWorkSheet);
            this.grpBoxExcelData.Controls.Add(this.comboWorkSheetsBML);
            this.grpBoxExcelData.Location = new System.Drawing.Point(3, 121);
            this.grpBoxExcelData.Name = "grpBoxExcelData";
            this.grpBoxExcelData.Size = new System.Drawing.Size(717, 618);
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridBML.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBML.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridBML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBML.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridBML.Location = new System.Drawing.Point(5, 53);
            this.dataGridBML.Name = "dataGridBML";
            this.dataGridBML.Size = new System.Drawing.Size(701, 559);
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
            this.grpBoxExcelColumn.Size = new System.Drawing.Size(714, 115);
            this.grpBoxExcelColumn.TabIndex = 0;
            this.grpBoxExcelColumn.TabStop = false;
            this.grpBoxExcelColumn.Text = "BML清单信息";
            // 
            // grpBoxBMLColum
            // 
            this.grpBoxBMLColum.Controls.Add(this.comboLineBML);
            this.grpBoxBMLColum.Controls.Add(this.lblLineBML);
            this.grpBoxBMLColum.Controls.Add(this.comboControlBML);
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
            // comboControlBML
            // 
            this.comboControlBML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboControlBML.FormattingEnabled = true;
            this.comboControlBML.IntegralHeight = false;
            this.comboControlBML.Location = new System.Drawing.Point(206, 45);
            this.comboControlBML.Name = "comboControlBML";
            this.comboControlBML.Size = new System.Drawing.Size(66, 21);
            this.comboControlBML.TabIndex = 29;
            this.comboControlBML.Visible = false;
            // 
            // lblControlBML
            // 
            this.lblControlBML.AutoSize = true;
            this.lblControlBML.Location = new System.Drawing.Point(146, 47);
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
            this.PalCommon.Location = new System.Drawing.Point(13, 774);
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
            // FormMDDx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(742, 983);
            this.Controls.Add(this.PalCommon);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabCreateMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMDDx";
            this.Text = "EL_MDDx";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMDDx_FormClosed);
            this.Load += new System.EventHandler(this.FormMDDx_Load);
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
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.GrpIOByte.ResumeLayout(false);
            this.GrpIOByte.PerformLayout();
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
        internal System.Windows.Forms.ComboBox comboControlBML;
        private System.Windows.Forms.Label lblControlBML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        internal System.Windows.Forms.ComboBox ComboDPNode1;
        internal System.Windows.Forms.ComboBox comboLineBML;
        private System.Windows.Forms.Label lblLineBML;
        private System.Windows.Forms.GroupBox grpGeneral;
        internal System.Windows.Forms.GroupBox GrpIOByte;
        internal System.Windows.Forms.TextBox txtIOByteIncRule;
        internal System.Windows.Forms.Label lblFParIOByte;
        internal System.Windows.Forms.Label lblIOByteIncRule;
        internal System.Windows.Forms.TextBox txtParIOByte;
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
        internal System.Windows.Forms.CheckBox chkParWithRollerGapRecipe;
        internal System.Windows.Forms.CheckBox chkParWithRollerTemp;
        internal System.Windows.Forms.CheckBox chkParWithFeedRollRecipe;
        internal System.Windows.Forms.CheckBox chkParWithBearTemp;
        internal System.Windows.Forms.CheckBox chkParLogOff;
        internal System.Windows.Forms.CheckBox chkParSide1Divided;
        internal System.Windows.Forms.Label lblValue10;
        internal System.Windows.Forms.CheckBox chkParSide2Divided;
        internal System.Windows.Forms.TextBox txtValue10;
        internal System.Windows.Forms.GroupBox grpReferences;
        internal System.Windows.Forms.Label lblPassageNoS2Bottom;
        internal System.Windows.Forms.TextBox txtPassageNoS2Bottom;
        internal System.Windows.Forms.Label lblPassageNoS2Top;
        internal System.Windows.Forms.TextBox txtPassageNoS2Top;
        internal System.Windows.Forms.Label lblPassageNoS1Bottom;
        internal System.Windows.Forms.TextBox txtPassageNoS1Bottom;
        internal System.Windows.Forms.Label lblPassageNoS1Top;
        internal System.Windows.Forms.TextBox txtPassageNoS1Top;
        internal System.Windows.Forms.TextBox txSide2BottomRule;
        internal System.Windows.Forms.Label lblSide2BottomIncRule;
        internal System.Windows.Forms.TextBox txtSide2BottomIncRule;
        internal System.Windows.Forms.TextBox txtSide2Bottom;
        internal System.Windows.Forms.Label lblSide2Bottom;
        internal System.Windows.Forms.Label LblSide2BottomRule;
        internal System.Windows.Forms.TextBox txtSide2TopRule;
        internal System.Windows.Forms.Label lblSide2TopIncRule;
        internal System.Windows.Forms.TextBox txtSide2TopIncRule;
        internal System.Windows.Forms.TextBox txtSide2Top;
        internal System.Windows.Forms.Label lblSide2Top;
        internal System.Windows.Forms.Label LblSide2TopRule;
        internal System.Windows.Forms.TextBox txtSide1BottomRule;
        internal System.Windows.Forms.Label lblAirlockIncRule;
        internal System.Windows.Forms.TextBox txtSide1BottomIncRule;
        internal System.Windows.Forms.TextBox txtSide1Bottom;
        internal System.Windows.Forms.Label lblSide1Bottom;
        internal System.Windows.Forms.Label LblAirlockRule;
        internal System.Windows.Forms.TextBox txtSide1TopRule;
        internal System.Windows.Forms.Label lblSenderBinIncRule;
        internal System.Windows.Forms.TextBox txtSide1TopIncRule;
        internal System.Windows.Forms.TextBox txtSide1Top;
        internal System.Windows.Forms.Label lblSide1Top;
        internal System.Windows.Forms.Label LblSenderBinRule;
        internal System.Windows.Forms.GroupBox grpFilter;
        internal System.Windows.Forms.Label LblValue28;
        internal System.Windows.Forms.TextBox txtValue28;
        internal System.Windows.Forms.Label lblValue26;
        internal System.Windows.Forms.CheckBox chkWarningA116CylDWN;
        internal System.Windows.Forms.TextBox txtValue26;
        internal System.Windows.Forms.CheckBox chkWarningA115CylUp;
        internal System.Windows.Forms.CheckBox chkWarningA110Gap;
        internal System.Windows.Forms.CheckBox chkWarningA078Service;
        internal System.Windows.Forms.CheckBox chkWarningA077DigOut;
        internal System.Windows.Forms.CheckBox chkWarningA076HighTemp;
        internal System.Windows.Forms.CheckBox chkWarningW075WarnTemp;
        internal System.Windows.Forms.CheckBox chkWarningA072CANDOUT;
        internal System.Windows.Forms.CheckBox chkWarningA071CANMOD;
        internal System.Windows.Forms.CheckBox chkWarningA070CANCOM;
        internal System.Windows.Forms.CheckBox chkWarningAx69DosMax;
        internal System.Windows.Forms.CheckBox chkWarningAx68InletFull;
        internal System.Windows.Forms.CheckBox chkWarningW067HLBackupRight;
        internal System.Windows.Forms.CheckBox chkWarningA066HLBackupRight;
        internal System.Windows.Forms.CheckBox chkWarningW065HLBackupLeft;
        internal System.Windows.Forms.CheckBox chkWarningA064HLBackupLeft;
        internal System.Windows.Forms.CheckBox chkWarningA063HLOut3;
        internal System.Windows.Forms.CheckBox chkWarningA062HLOut2;
        internal System.Windows.Forms.CheckBox chkWarningA061HLOut1;
        internal System.Windows.Forms.CheckBox chkWarningAx60HLInlet;
        internal System.Windows.Forms.CheckBox chkWarningA059M_Stop;
        internal System.Windows.Forms.CheckBox chkA116CylDWN;
        internal System.Windows.Forms.CheckBox chkA115CylUp;
        internal System.Windows.Forms.CheckBox chkA110Gap;
        internal System.Windows.Forms.CheckBox chkA078Service;
        internal System.Windows.Forms.CheckBox chkA077DigOut;
        internal System.Windows.Forms.CheckBox chkA076HighTemp;
        internal System.Windows.Forms.CheckBox chkW075WarnTemp;
        internal System.Windows.Forms.CheckBox chkA072CANDOUT;
        internal System.Windows.Forms.CheckBox chkA071CANMOD;
        internal System.Windows.Forms.CheckBox chkA070CANCOM;
        internal System.Windows.Forms.CheckBox chkAx69DosMax;
        internal System.Windows.Forms.CheckBox chkAx68InletFull;
        internal System.Windows.Forms.CheckBox chkW067HLBackupRight;
        internal System.Windows.Forms.CheckBox chkA066HLBackupRight;
        internal System.Windows.Forms.CheckBox chKW065HLBackupLeft;
        internal System.Windows.Forms.CheckBox chkA064HLBackupLeft;
        internal System.Windows.Forms.CheckBox chkAx63HLOut3;
        internal System.Windows.Forms.CheckBox chkAx62HLOut2;
        internal System.Windows.Forms.CheckBox chkAx61HLOut1;
        internal System.Windows.Forms.CheckBox chkAx60HLInlet;
        internal System.Windows.Forms.CheckBox chkA059M_Stop;
        internal System.Windows.Forms.CheckBox chkWarningA112GapAct;
        internal System.Windows.Forms.CheckBox chkWarningA111GapSet;
        internal System.Windows.Forms.CheckBox chkWarningA058M_Stop;
        internal System.Windows.Forms.CheckBox chkWarningA057STBYDN;
        internal System.Windows.Forms.CheckBox chkWarningA056STBYUP;
        internal System.Windows.Forms.CheckBox chkWarningA055MotLow;
        internal System.Windows.Forms.CheckBox chkWarningA054MotUp;
        internal System.Windows.Forms.CheckBox chkWarningA053RollLow;
        internal System.Windows.Forms.CheckBox chkWarningA052RollUp;
        internal System.Windows.Forms.CheckBox chkWarningAx51FRoll2;
        internal System.Windows.Forms.CheckBox chkWarningAx50FRoll1;
        internal System.Windows.Forms.CheckBox chkWarningAx32Rod;
        internal System.Windows.Forms.CheckBox chkWarningAx30Zero;
        internal System.Windows.Forms.CheckBox chkWarningA024Empty;
        internal System.Windows.Forms.CheckBox chkWarningA018Battery;
        internal System.Windows.Forms.CheckBox chkWarningAx07Range;
        internal System.Windows.Forms.CheckBox chkWarningA005No24V;
        internal System.Windows.Forms.CheckBox chkWarningAxxxUnknow;
        internal System.Windows.Forms.CheckBox chkWarningAxxxDisplay;
        internal System.Windows.Forms.CheckBox chkWarningAxxxCommunication;
        internal System.Windows.Forms.CheckBox chkWarningAxxxSoftware;
        internal System.Windows.Forms.CheckBox chkA112GapAct;
        internal System.Windows.Forms.CheckBox chkA111GapSet;
        internal System.Windows.Forms.CheckBox chkA058M_Stop;
        internal System.Windows.Forms.CheckBox chkA057STBYDN;
        internal System.Windows.Forms.CheckBox chkA056STBYUP;
        internal System.Windows.Forms.CheckBox chkA055MotLow;
        internal System.Windows.Forms.CheckBox chkA054MotUp;
        internal System.Windows.Forms.CheckBox chkA053RollLow;
        internal System.Windows.Forms.CheckBox chkA052RollUp;
        internal System.Windows.Forms.CheckBox chkAx51FRoll2;
        internal System.Windows.Forms.CheckBox chkAx50FRoll1;
        internal System.Windows.Forms.CheckBox chkAx32Rod;
        internal System.Windows.Forms.CheckBox chkAx30Zero;
        internal System.Windows.Forms.CheckBox chkA024Empty;
        internal System.Windows.Forms.CheckBox chkA018Battery;
        internal System.Windows.Forms.CheckBox chkAx07Range;
        internal System.Windows.Forms.CheckBox chkA005No24V;
        internal System.Windows.Forms.CheckBox chkAxxxUnknow;
        internal System.Windows.Forms.CheckBox chkAxxxDisplay;
        internal System.Windows.Forms.CheckBox chkAxxxCommunication;
        internal System.Windows.Forms.CheckBox chkAxxxSoftware;
        internal System.Windows.Forms.Label lblValue25;
        internal System.Windows.Forms.TextBox txtValue25;
        internal System.Windows.Forms.Label lblValue27;
        internal System.Windows.Forms.TextBox txtValue27;
        internal System.Windows.Forms.CheckBox chkNameOnlyNumber;
    }
}

