using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.Common;
#region GcproExtensionLibrary
using GcproExtensionLibrary.Gcpro.GCObject;
using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using static GcproExtensionLibrary.Gcpro.GcproTable;
using System.Linq;
using System.Xml.Linq;
#endregion
namespace GcproExtensionApp
{
    public partial class FormRollStandPhoenix : Form, IGcForm
    {
        public FormRollStandPhoenix()
        {
            InitializeComponent();
        }
 
        #region Public object in this class
        MDDYZ myMDDYZ= new MDDYZ(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private string DEMO_NAME_MDDYZ= "=A-4001-KCL30";
        private string DEMO_NAME_RULE_MDDYZ= "4001";
        private string DEMO_DESCRIPTION_MDDYZ= "xxx磨机控制器/或者空白";
        private string DEMO_DESCRIPTION_RULE_MDDYZ= "";
        #endregion
       // private long value21;
        private int value10 = 80;
        private int tempInt = 0;
        private float tempFloat;
        private bool tempBool = false;
    
        #region Public interfaces
        public void GetInfoFromDatabase()
        {
            string itemInfo;
            List<string> list;
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.GcsLibaryPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            ///<ReaMDDxnfoFromGcsLibrary> 
            ///Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary 
            ///</ReaMDDxnfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={MDDYZ.OTypeValue}",
                null, $"{GcproTable.SubType.FieldSub_Type_Desc.Name} ASC",
                GcproTable.SubType.FieldSubType.Name, GcproTable.SubType.FieldSub_Type_Desc.Name);
            // List<string> list = OleDb.GetColumnData<string>(dataTable, "SubType");

            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.SubType.TableName) + AppGlobal.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>($"{GcproTable.SubType.FieldSub_Type_Desc.Name}");
                ComboEquipmentSubType.Items.Add(itemInfo);

            }
          
            ComboEquipmentSubType.SelectedIndex = 0;
            ///<ProcessFct> Read [ProcessFct] </ProcessFct>
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {MDDYZ.OTypeValue}",
                null, $"{GcproTable.ProcessFct.FieldFct_Desc.Name} ASC",
                 GcproTable.ProcessFct.FieldProcessFct.Name, GcproTable.ProcessFct.FieldFct_Desc.Name);
            //list = OleDb.GetColumnData<string>(dataTable, "Fct_Desc");
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.ProcessFct.FieldProcessFct.Name) + AppGlobal.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>(GcproTable.ProcessFct.FieldFct_Desc.Name);
                ComboProcessFct.Items.Add(itemInfo);
            }
            ///<ReadInfoFromProjectDB> 
            ///Read [PType],[Building],[Elevation],[Panel]
            ///Read [DPNode1],[DPNode2],[HornCode]
            ///</ReadInfoFromProjectDB>
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            ///<PType> Read [PType] </PType>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + MDDYZ.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboEquipmentInfoType.Items.Add(column.ToString());
            }
            ComboEquipmentInfoType.SelectedIndex = 1;
            ///<HornCode> Read [PType] </HornCode>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWParHornCode}'",
                null, $"{GcproTable.TranslationCbo.FieldText.Name} ASC", GcproTable.TranslationCbo.FieldText.Name);
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboHornCode.Items.Add(column.ToString());
            }
            ComboHornCode.SelectedIndex = 0;
            ///<DPNode> Read [DPNode1],[DPNode2]</DPNode>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWInDPFault}'",
            null, $"{GcproTable.TranslationCbo.FieldText.Name} ASC", GcproTable.TranslationCbo.FieldText.Name);
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {
                ComboDPNode1.Items.Add(column.ToString());
               
            }
            ///<Elevation> Read [Elevation]</Elevation>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_Elevation}'",
            null, $"{GcproTable.TranslationCbo.FieldText.Name} ASC", GcproTable.TranslationCbo.FieldText.Name);
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboElevation.Items.Add(column.ToString());
            }
            ///<Building> Read [Building]</Building>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_Building}'",
            null, $"{GcproTable.TranslationCbo.FieldText.Name} ASC", GcproTable.TranslationCbo.FieldText.Name);
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboBuilding.Items.Add(column.ToString());
            }
            ///<Panel> Read [Panel]</Panel>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_PanelID}'",
            null, $"{GcproTable.TranslationCbo.FieldText.Name} ASC", GcproTable.TranslationCbo.FieldText.Name);
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboPanel.Items.Add(column.ToString());
            }
            ///<Diagram> Read [Diagram]</Diagram>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWDiagram}'",
            null, $"{GcproTable.TranslationCbo.FieldText.Name} ASC", GcproTable.TranslationCbo.FieldText.Name, GcproTable.TranslationCbo.FieldValue.Name);
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<double>(GcproTable.TranslationCbo.FieldValue.Name) + AppGlobal.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>(GcproTable.TranslationCbo.FieldText.Name);
                ComboDiagram.Items.Add(itemInfo);
            }


        }
        public void GetLastObjRule()
        {
            txtSymbolRule.Text = MDDYZ.Rule.Common.NameRule;
            txtSymbolIncRule.Text = MDDYZ.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = MDDYZ.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = MDDYZ.Rule.Common.DescriptionRuleInc;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + MDDYZ.OType);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_MDDYZ);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_MDDYZ);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_MDDYZ);
            toolTip.SetToolTip(BtnRegenerateDPNode, AppGlobal.MSG_REGENERATE_DPNODE);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_MDDYZ);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;          
            dataTable=oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{MDDYZ.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);         
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{MDDYZ.ImpExpRuleName}'", null);
                    CreateMDDYZImpExp(oledb);
                }
                else
                { 
                    return; 
                }
            }
            else
            { 
                CreateMDDYZImpExp(oledb); 
            }

        }
        private void CreateMDDYZImpExp(OleDb oledb)
        {

            bool result = myMDDYZ.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertMultipleRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Default()
        {
            txtSymbol.Focus();         
            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            txtValue10.Text = myMDDYZ.Value10;
            value10 = int.Parse(myMDDYZ.Value10);
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            txtIOByteIncRule.Text = MDDYZ.IOByteLen;
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "MDDYZ/MRMA导入文件 " + " " + myMDDYZ.FilePath;         
        }
        #endregion Public interfaces

        private void FormRollStandPhoenix_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormRollStandPhoenix_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
       
        private void txtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                MDDYZ.Rule.Common.NameRule = txtSymbolRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtSymbolIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (AppGlobal.CheckNumericString(txtSymbolIncRule.Text))
                {
                    MDDYZ.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }

        private void txtDescriptionRule_TextChanged(object sender, EventArgs e)
        {

            if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
            {
                MDDYZ.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        private void txtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    MDDYZ.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtParIOByte_TextChanged(object sender, EventArgs e)
        {
         
                if (AppGlobal.CheckNumericString(txtParIOByte.Text))
                {
                    MDDYZ.Rule.Common.DescriptionRuleInc = txtParIOByte.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }      
        }
        private void txtValue10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value10 = AppGlobal.ParseInt(txtValue10.Text, out tempInt) ? tempInt : value10;
                GetValue10BitValue(value10);
            }
        }

        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"    
        private void chkParLogOff_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParLogOff.Checked)

            { AppGlobal.SetBit(ref value10, (byte)0); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)0); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }
        private void chkParWithBearTemp_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithBearTemp.Checked)

            { AppGlobal.SetBit(ref value10, (byte)1); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }
        private void chkParWithFeedGapAdjust_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithFeedGapAdjust.Checked)

            { AppGlobal.SetBit(ref value10, (byte)2); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }

        private void chkParWithRollerTemp_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithRollerTemp.Checked)

            { AppGlobal.SetBit(ref value10, (byte)3); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)3); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }

        private void chkPar4Rolls_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkPar4Rolls.Checked)

            { AppGlobal.SetBit(ref value10, (byte)4); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)4); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }
        private void chkB1Rollstand_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParB1Rollstand.Checked)

            { AppGlobal.SetBit(ref value10, (byte)5); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)5); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }

        private void chkParMotorPLC_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParMotorPLC.Checked)

            { AppGlobal.SetBit(ref value10, (byte)6); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)6); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }

        private void chkParWithAutoGapAdjust_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithAutoGapAdjust.Checked)

            { AppGlobal.SetBit(ref value10, (byte)7); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)7); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }

        private void chkParSide1Divided_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParSide1Divided.Checked)

            { AppGlobal.SetBit(ref value10, (byte)8); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)8); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }

        private void chkParSide2Divided_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParSide2Divided.Checked)

            { AppGlobal.SetBit(ref value10, (byte)9); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)9); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }
    
        private void chkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParManual.Checked)

            { AppGlobal.SetBit(ref value10, (byte)11); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)11); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }

        private void chkStartingWarning_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParStartWarning.Checked)

            { AppGlobal.SetBit(ref value10, (byte)12); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)12); }
            myMDDYZ.Value10 = value10.ToString();
            txtValue10.Text = myMDDYZ.Value10;
        }
        #endregion
        #region <------Field in database display
        private void txtSymbol_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Text0";
        }
        private void txtDescription_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Text1";
        }
        
        private void ComboEquipmentInfoType_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value5";
        }
        private void ComboHornCode_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value2";
        }
        private void ComboDPNode1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "DPNode1";
        }
        private void txtParIOByte_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value20";
        }
        private void txtParTimeOutStart_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }
        #endregion
        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtDescription.Text, false);      
        }
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value20.Name;
            objectBrowser.OType = Convert.ToString(MDDYZ.OTypeValue);
            objectBrowser.Show();
        }
        void SubTypeChanged(string subType)
        {
            if (subType == MDDYZ.MDDYDP)

            {
                 chkPar4Rolls.Checked = true;
                 chkParMotorPLC.Checked = true;
            }         
            else if (subType == MDDYZ.MDDZDP)
            {
                chkPar4Rolls.Checked = false;
                chkParMotorPLC.Checked = true;
            }
            else if (subType == MDDYZ.MRRA_4DP)
            {
                chkPar4Rolls.Checked = true;
                chkParMotorPLC.Checked = false;
            }
            else
            {
                chkPar4Rolls.Checked = false;
                chkParMotorPLC.Checked = false;
            }
        }
        void GetValue10BitValue(int value)
        {
            chkParLogOff.Checked = AppGlobal.GetBitValue(value, 0);
            chkParWithBearTemp.Checked = AppGlobal.GetBitValue(value, 1);    
            chkParWithFeedGapAdjust.Checked = AppGlobal.GetBitValue(value, 2);
            chkParWithRollerTemp.Checked = AppGlobal.GetBitValue(value, 3);
            chkPar4Rolls.Checked = AppGlobal.GetBitValue(value, 4);
            chkParB1Rollstand.Checked = AppGlobal.GetBitValue(value, 5);
            chkParMotorPLC.Checked = AppGlobal.GetBitValue(value, 6); 
            chkParWithAutoGapAdjust.Checked = AppGlobal.GetBitValue(value, 7);
            chkParSide1Divided.Checked = AppGlobal.GetBitValue(value, 8);
            chkParSide2Divided.Checked = AppGlobal.GetBitValue(value, 9);
            chkParManual.Checked = AppGlobal.GetBitValue(value, 11);
            chkParStartWarning.Checked = AppGlobal.GetBitValue(value, 12);
        }
   
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myMDDYZ.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SubTypeChanged(myMDDYZ.SubType);                                                                    
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion
        #region <---BML part--->
        private void AddWorkSheets()
        {
            comboWorkSheetsBML.Items.Clear();
            try
            {
                List<string> workSheets = new List<string>();
                workSheets = excelFileHandle.GetWorkSheets();
                foreach (string sheet in workSheets)
                {
                    comboWorkSheetsBML.Items.Add(sheet);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(AppGlobal.EX_FILE_NOT_FOUND, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(AppGlobal.EX_UNAUTHORIZED_ACCESS, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(AppGlobal.EX_IO_ERROR + $"{ex.Message}", AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(AppGlobal.EX_UNKNOW + $"{ex.Message}", AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnOpenProjectDB_Click(object sender, EventArgs e)
        {
            TxtExcelPath.Text = ExcelFileHandle.BrowseFile();
            excelFileHandle.FilePath = TxtExcelPath.Text;
            AddWorkSheets();         
        }
        private void TxtExcelPath_DoubleClick(object sender, EventArgs e)
        {
            TxtExcelPath.Text = ExcelFileHandle.BrowseFile();
            AddWorkSheets();
        }
        private void TxtExcelPath_TextChanged(object sender, EventArgs e)
        {
            excelFileHandle.FilePath = TxtExcelPath.Text;
            BML.MDDx.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_BML}.{AppGlobal.JS_MDDX}.{AppGlobal.JS_PATH}", BML.MDDx.BMLPath);
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
            excelFileHandle.FilePath = TxtExcelPath.Text;
            AddWorkSheets();
        }
        private void comboWorkSheetsBML_SelectedIndexChanged(object sender, EventArgs e)
        {

            excelFileHandle.WorkSheet = comboWorkSheetsBML.SelectedItem !=null ?comboWorkSheetsBML.SelectedItem.ToString():string.Empty;
            if (! String.IsNullOrEmpty(excelFileHandle.WorkSheet))
            {
                btnReadBML.Enabled= true;   
            }
        }
        private void dataGridBML_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dataGridBML.Refresh();
            TxtQuantity.Text = dataGridBML.Rows.Count.ToString();
        }
        private void CreateBMLDefault()
        {
            btnReadBML.Enabled = false;
            var alphabetList = AppGlobal.CreateAlphabetList<string>('A', 'Z', letter => letter.ToString());
            lblLineBML.Text = BML.ColumnLine;
            foreach (var item in alphabetList)
            {
                comboNameBML.Items.Add(item);
                comboDescBML.Items.Add(item);
                comboTypeBML.Items.Add(item);
                comboFloorBML.Items.Add(item);
                comboSectionBML.Items.Add(item);
                comboCabinetBML.Items.Add(item);
                comboControlBML.Items.Add(item);
                comboLineBML.Items.Add(item);
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
                comboControlBML.SelectedItem = "H";
                comboLineBML.SelectedItem = "X";
            }
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text=BML.MDDx.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.ColumnName; 
            nameColumn.Name = nameof(BML.ColumnName);                                                
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.ColumnDesc;
            descColumn.Name = nameof(BML.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);

            DataGridViewTextBoxColumn diTypeColumn = new DataGridViewTextBoxColumn();
            diTypeColumn.HeaderText = BML.ColumnControlMethod;
            diTypeColumn.Name = nameof(BML.ColumnControlMethod);
            dataGridBML.Columns.Add(diTypeColumn);

            DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            floorColumn.HeaderText = BML.ColumnFloor;
            floorColumn.Name = nameof(BML.ColumnFloor);
            dataGridBML.Columns.Add(floorColumn);

            DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            cabinetColumn.HeaderText = BML.ColumnCabinet;
            cabinetColumn.Name = nameof(BML.ColumnCabinet);
            dataGridBML.Columns.Add(cabinetColumn);

            DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            cabinetColumnGroup.HeaderText = BML.ColumnCabinetGroup;
            cabinetColumnGroup.Name = nameof(BML.ColumnCabinetGroup);
            dataGridBML.Columns.Add(cabinetColumnGroup);

            DataGridViewTextBoxColumn lineColumn = new DataGridViewTextBoxColumn();
            lineColumn.HeaderText = BML.ColumnLine;
            lineColumn.Name = nameof(BML.ColumnLine);
            dataGridBML.Columns.Add(lineColumn);

        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboControlBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboLineBML.Text,comboTypeBML.Text};
            StringBuilder sbControlFilters = new StringBuilder();
            sbControlFilters.Append($@"Value LIKE ""%{BML.MDDx.TypeMDDY}%"" || Value LIKE ""%{BML.MDDx.TypeMDDZ}%"" || Value LIKE ""%{BML.MDDx.TypeMRRA4}%"" || Value LIKE ""%{BML.MDDx.TypeMRRA8}%""");
            StringBuilder sbTypeFilters = new StringBuilder();
            sbTypeFilters.Append($@"Value LIKE ""%{BML.MDDx.TypeKCL}""");
            DataTable dataTable = new DataTable();
            string[] filters = { sbControlFilters.ToString(), sbTypeFilters.ToString()};
            string[] filterColumns = { comboControlBML.Text ,comboTypeBML.Text};
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);

            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnControlMethod)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnLine)].DataPropertyName = dataTable.Columns[6].ColumnName;
            TxtQuantity.Text = dataTable.Rows.Count.ToString();
        }
        #endregion
        #region Common used
        private void chkAddSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddSectionToDesc.Checked)
            { chkAddUserSectionToDesc.Checked = false; }
        }
        private void chkAddUserSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddUserSectionToDesc.Checked)
            { chkAddSectionToDesc.Checked = false; }
        }
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                txtSymbolRule.Text = MDDYZ.Rule.Common.NameRule;
                txtSymbolIncRule.Text = MDDYZ.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                grpSymbolRule.Visible = true;
                lblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_MDDYZ;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;
               
            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = MDDYZ.Rule.Common.NameRule;
                txtSymbolIncRule.Text = MDDYZ.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                grpSymbolRule.Visible = false;
                lblSymbol.Text = AppGlobal.KEY_WORD_AUTOSEARCH;
            
                tabRule.Text = CreateMode.ObjectCreateMode.AutoSearch;
                
            }

            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.BML)
            {
                createMode.Rule = false;
                createMode.BML = true;
                createMode.AutoSearch = false;
                tabCreateMode.SelectedTab = tabBML;         
            }

        }
        private void tabCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCreateMode.SelectedTab == tabRule)

            { 
                ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule; 
            }
            else
            { 
                ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.BML;
            }
        }
        private void toolStripMenuClearList_Click(object sender, EventArgs e)
        {
            //dataTable.Clear();
            DataTable dataTable=null;
            dataGridBML.DataSource = dataTable;
            
        }
        private void toolStripMenuReload_Click(object sender, EventArgs e)
        {
            btnReadBML_Click(sender, e);
        }
        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridBML.SelectedRows)
            {             
                dataGridBML.Rows.RemoveAt(row.Index);
            }
            dataGridBML.ClearSelection();
            TxtQuantity.Text = dataGridBML.Rows.Count.ToString();
        }
        private void TxtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!AppGlobal.CheckNumericString(TxtQuantity.Text))
                { 
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!AppGlobal.CheckNumericString(TxtQuantity.Text))
            { 
                AppGlobal.MessageNotNumeric(); 
            }
        }
        private void BtnConnectIO_Click(object sender, EventArgs e)
        { 
       
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_CLEAR_FILE, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                myMDDYZ.Clear();
                ProgressBar.Value = 0;  
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            MDDYZ.SaveFileAs(myMDDYZ.FilePath, LibGlobalSource.CREATE_OBJECT);
            MDDYZ.SaveFileAs(myMDDYZ.FileRelationPath, LibGlobalSource.CREATE_RELATION);
        }

        private void BtnNewImpExpDef_Click(object sender, EventArgs e)
        {
            CreateImpExp();
        }
        private void BtnRegenerateDPNode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_REGENERATE_DPNODE, AppGlobal.AppInfo.Title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                OleDb oledb = new OleDb();
                oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                oledb.IsNewOLEDBDriver = isNewOledbDriver;
                AppGlobal.ReGenerateDPNode(oledb);
            }
        }
        public static void CreatObjectBML(DataGridView datafromBML,MDDYZ objMDDYZ, 
            (bool section, bool userDefSection, bool elevation, bool identNumber, bool cabinet, bool power,bool onlyNumber) addtionToDesc,
            (int IOByteStart, int Len) IOAddr,
            out (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);         
            StringBuilder descTotalBuilder = new StringBuilder();
            int quantityNeedToBeCreate = datafromBML.RowCount;
            int tempNumberInt;
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            SuffixObject suffixObject = new SuffixObject();
            string cabinet, cabinetGroup;
            string numberString = string.Empty;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                DataGridViewCell cell;
                cell = datafromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                { continue; }
                cabinet = Convert.ToString(datafromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                cabinetGroup = Convert.ToString(datafromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value);
                objMDDYZ.Panel_ID = cabinet.StartsWith(BML.PrefixLocalPanel) ? cabinet : cabinetGroup + cabinet;
                objMDDYZ.Elevation = Convert.ToString(datafromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);

                #region Subtype and PType                                          
                //SubTypeChanged(myMDDYZ.SubType);
                #endregion
                ///<AdditionInfoToDesc>
                ///</AdditionInfoToDesc>
                string desc = $"{Convert.ToString(datafromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value)}{suffixObject.SuffixObjectType["KCL"]}";
                descTotalBuilder.Clear();
                objMDDYZ.Name = Convert.ToString(datafromBML.Rows[i].Cells[nameof(BML.ColumnName)].Value);
                bool additionInfToDesc = addtionToDesc.identNumber || addtionToDesc.elevation || addtionToDesc.cabinet;

                numberString = LibGlobalSource.StringHelper.ExtractNumericPart(objMDDYZ.Name, false);
                if (addtionToDesc.section)
                {             
                    if (!string.IsNullOrEmpty(numberString))
                    {
                        if (AppGlobal.ParseInt(numberString, out tempNumberInt))
                        {
                            descTotalBuilder.Append(GcObjectInfo.Section.ReturnSection(tempNumberInt));
                        }
                    }
                }
                if (addtionToDesc.userDefSection)
                {
                    descTotalBuilder.Append(Convert.ToString(datafromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value));
                }
                if (additionInfToDesc)
                {
                    AppGlobal.AppendInfoToBuilder(addtionToDesc.elevation, $"{objMDDYZ.Elevation}{GcObjectInfo.General.AddInfoElevation}", descTotalBuilder);
                    string descName = addtionToDesc.onlyNumber ? numberString : LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameWithoutTypeLL,objMDDYZ.Name);
                    descName = descName.Contains(GcObjectInfo.General.PrefixName) ? descName.Replace(GcObjectInfo.General.PrefixName, string.Empty) : descName;
                    AppGlobal.AppendInfoToBuilder(addtionToDesc.identNumber, $"({descName})", descTotalBuilder);
                }
                descTotalBuilder.Append(desc);

                if (additionInfToDesc)
                {
                    descTotalBuilder.Append("[");
                    AppGlobal.AppendInfoToBuilder(addtionToDesc.cabinet, $"{GcObjectInfo.General.AddInfoCabinet}{objMDDYZ.Panel_ID}", descTotalBuilder);
                    descTotalBuilder.Append("]");
                }
               objMDDYZ.Description = descTotalBuilder.ToString();

               objMDDYZ.IoByteNo = (IOAddr.IOByteStart + IOAddr.Len * i).ToString();
                ///<DPNode1>   </DPNode1>                         
               string dpNode1BML = Convert.ToString(datafromBML.Rows[i].Cells[nameof(BML.ColumnName)].Value);
               objMDDYZ.DPNode1 = AppGlobal.FindDPNodeNo(oledb, dpNode1BML);
               objMDDYZ.FieldBusNode = String.IsNullOrEmpty(objMDDYZ.DPNode1) ? string.Empty :
                    AppGlobal.FindFieldbusNodeKey(oledb, int.Parse(objMDDYZ.DPNode1));
               objMDDYZ.CreateObject(Encoding.Unicode);
               processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }
        private void CreatObjectRule((bool section, bool userDefSection, bool elevation, bool identNumber, bool cabinet, bool power, bool onlyNumber) addtionToDesc,
            (int IOByteStart, int Len) IOAddr, 
            ref (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;        
            #region common used variables declaration       
            StringBuilder descTotalBuilder = new StringBuilder();
            int quantityNeedToBeCreate = processValue.Max;
            bool moreThanOne = quantityNeedToBeCreate > 1;         
            RuleSubDataSet description, name;
            description = new RuleSubDataSet
            {
                Sub = new string[] { },
                Inc = 0,
                PosInfo = new RuleSubPos
                {
                    StartPos = false,
                    MidPos = false,
                    EndPos = false,
                    PosInString = 0,
                    Len = 0,
                }
            };
            name = new RuleSubDataSet
            {
                Sub = new string[] { },
                Inc = 0,
                PosInfo = new RuleSubPos
                {
                    StartPos = false,
                    MidPos = false,
                    EndPos = false,
                    PosInString = 0,
                    Len = 0,
                }
            };
            #endregion
            processValue.Value = 0;
            #region Prepare export MDDYZfile
            ///<OType>is set when object generated</OType>
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                myMDDYZ.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                myMDDYZ.SubType = MDDYZ.MDDYDP;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (ComboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                myMDDYZ.PType = LibGlobalSource.StringHelper.ExtractNumericPart(selectedPTypeItem, false);
            }
            else
            {
                myMDDYZ.PType = MDDYZ.P7755_1.ToString();
            }
            ///<Value10</Value10>
            myMDDYZ.Value10 = value10.ToString();
            ///<ValueParTimeOutStart</ValueParTimeOutStart>
            myMDDYZ.ParTimeOutStart = AppGlobal.ParseFloat(txtParTimeOutStart.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "100.0";
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                myMDDYZ.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Page></Page>
            myMDDYZ.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                myMDDYZ.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                myMDDYZ.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                myMDDYZ.Panel_ID = selectedPanel_ID;
            }
            myMDDYZ.FieldBusNode = LibGlobalSource.NOCHILD; ;    
            if (ComboHornCode.SelectedItem != null)
            {
                string hornCode = ComboHornCode.SelectedItem.ToString();
                myMDDYZ.HornCode = hornCode.Substring(0, 2);
            }
            ///<IOByteNo></IOByteNo>
            myMDDYZ.IoByteNo = LibGlobalSource.NOCHILD;
            #endregion
            #region Parse rules
            ///<ParseRule> </ParseRule>
            if (!AppGlobal.ParseInt(txtSymbolIncRule.Text, out tempInt))
            {
                if (moreThanOne)
                {
                    AppGlobal.MessageNotNumeric($"({grpSymbolRule.Text}.{lblSymbolIncRule.Text})");
                    return;
                }
            }
            ///<NameRule>生成名称规则</NameRule>
            name.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtSymbol.Text, txtSymbolRule.Text);
            if (name.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{grpSymbolRule.Text}.{lblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                name.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtSymbol.Text, txtSymbolRule.Text);
            }          
            ///<DescRule>生成描述规则</DescRule>
            if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
            {
                description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtDescription.Text, txtDescriptionRule.Text);
                if (description.PosInfo.Len == -1)
                {
                    if (moreThanOne)
                    {
                        AppGlobal.RuleNotSetCorrect($"{grpDescriptionRule.Text}.{lblDescriptionRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                   
                    }
                }
                else
                {
                    description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtDescription.Text, txtDescriptionRule.Text);
                }
            }
            #endregion
            int symbolInc, symbolRule, descriptionInc;
            tempBool = AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
            tempBool = AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
            tempBool = AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
            for (int i = 0; i < quantityNeedToBeCreate ; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                if (!String.IsNullOrEmpty(txtDescription.Text))
                {
                    if (!String.IsNullOrEmpty(txtDescriptionIncRule.Text) && !String.IsNullOrEmpty(txtDescriptionRule.Text)
                    && AppGlobal.CheckNumericString(txtDescriptionIncRule.Text) && AppGlobal.CheckNumericString(txtDescriptionIncRule.Text)
                        && (description.PosInfo.Len != -1))
                    {
                        description.Inc = i * descriptionInc;
                        description.Name = LibGlobalSource.StringHelper.GenerateObjectName(description.Sub, description.PosInfo, (int.Parse(txtDescriptionRule.Text) + description.Inc).ToString().PadLeft(description.PosInfo.Len, '0'));
                    }
                    else
                    {
                        description.Name = txtDescription.Text;
                    }

                }
                else
                {
                    description.Name = "--";
                }
                myMDDYZ.Name = name.Name;
                descTotalBuilder.Clear();
                descTotalBuilder.Append(description.Name);
                if (addtionToDesc.cabinet)
                {
                    descTotalBuilder.Append("[");
                    AppGlobal.AppendInfoToBuilder(addtionToDesc.cabinet, $"{GcObjectInfo.General.AddInfoCabinet}{myMDDYZ.Panel_ID}", descTotalBuilder);
                    descTotalBuilder.Append("]");
                }
                myMDDYZ.Description = descTotalBuilder.ToString();
                myMDDYZ.IoByteNo = (IOAddr.IOByteStart+ IOAddr.Len * i).ToString();
                ///<DPNode1>   </DPNode1>                                               
                myMDDYZ.DPNode1 = AppGlobal.FindDPNodeNo(oledb, myMDDYZ.Name);
                myMDDYZ.FieldBusNode = String.IsNullOrEmpty(myMDDYZ.DPNode1) ? string.Empty :
                    AppGlobal.FindFieldbusNodeKey(oledb, int.Parse(myMDDYZ.DPNode1));
                myMDDYZ.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
       
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                AppGlobal.IOAddr.IOByteStart = int.Parse(txtParIOByte.Text);
                AppGlobal.IOAddr.Len = int.Parse(txtIOByteIncRule.Text);
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet = chkAddCabinetToDesc.Checked;
                AppGlobal.AdditionDesc.Power = false;

                if (createMode.BML)
                {
                 
                    CreatObjectBML(dataGridBML,myMDDYZ,AppGlobal.AdditionDesc,AppGlobal.IOAddr,out AppGlobal.ProcessValue);            
                }
                else if (createMode.AutoSearch)
                {
                    return;
                }
                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreatObjectRule(AppGlobal.AdditionDesc, AppGlobal.IOAddr,  ref AppGlobal.ProcessValue);
                }
                ProgressBar.Maximum = AppGlobal.ProcessValue.Max;
                ProgressBar.Value = AppGlobal.ProcessValue.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建对象过程出错:" + ex, AppGlobal.AppInfo.Title + ":" + AppGlobal.MSG_CREATE_WILL_TERMINATE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion  
    } 
}
