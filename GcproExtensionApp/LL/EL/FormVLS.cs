using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.Common;
#region GcproExtensionLibary
using GcproExtensionLibrary.Gcpro.GCObject;
using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using System.Windows.Documents;
using System.Xml.Linq;
using System.Security.Cryptography;
#endregion
namespace GcproExtensionApp
{
    public partial class FormVLS : Form, IGcForm
    {

        public FormVLS()
        {
            InitializeComponent();
        }
        #region Public object in this class
        VLS myVLS = new VLS(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();

        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;

        private string DEMO_NAME_VLS = "=A-1001-01/02";
        private string DEMO_NAME_RULE_VLS = "1001";
        private string DEMO_DESCRIPTION_VLS = "100号毛麦仓下闸门/或者空白";
        private string DEMO_DESCRIPTION_RULE_VLS = "100/或者空白";
        private string namePrefix=string.Empty;
        #endregion
       // private int value9 = 0;
        private int value10 = 10;
        private int tempInt = 0;
        //private long tempLong = 0;
        private float tempFloat = (float)0.0;
        private bool tempBool = false;
        private int nameLen = 0;
        List<KeyValuePair<string, int>> listBMLName = new List<KeyValuePair<string, int>>();
        #region Public interfaces
        public void GetInfoFromDatabase()
        {
            string itemInfo;
            List<string> list;
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.GcsLibaryPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            ///<ReadInfoFromGcsLibrary> 
            ///Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary 
            ///</ReadInfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={VLS.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {VLS.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + VLS.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboEquipmentInfoType.Items.Add(column.ToString());
            }
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
                ComboDPNode2.Items.Add(column.ToString());
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
            txtSymbolRule.Text = VLS.Rule.Common.NameRule;
            txtSymbolIncRule.Text = VLS.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = VLS.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = VLS.Rule.Common.DescriptionRuleInc;          
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + VLS.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);      
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_VLS);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_VLS);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_VLS);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_VLS);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;          
            dataTable=oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{VLS.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);         
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{VLS.ImpExpRuleName}'", null);
                    CreateVLSImpExp(oledb);
                }
                else
                { 
                    return; 
                }
            }
            else
            { 
                CreateVLSImpExp(oledb); 
            }

        }
        public void Default()
        {

            txtSymbol.Focus();
            txtInpLNSuffix.Text = GcObjectInfo.VLS.SuffixInpLN;
            txtInpHNSuffix.Text = GcObjectInfo.VLS.SuffixInpHN;
            txtOutpLNSuffix.Text = GcObjectInfo.VLS.SuffixOutpLN;
            txtOutpHNSuffix.Text = GcObjectInfo.VLS.SuffixOutpHN;
            txtInpRunFwdSuffix.Text = GcObjectInfo.VLS.SuffixInpRunFwd;
            txtInpRunRevSuffix.Text = GcObjectInfo.VLS.SuffixInpRunRev;
            txtInpRunFwd.Text = txtSymbol.Text + txtInpLNSuffix.Text;
             //nameLen=      
            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;          
            myVLS.Value9 = "0";           
            ComboEquipmentSubType.SelectedIndex = 2;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "VLS导入文件 " + " " + myVLS.FilePath;
        }
        #endregion
        private void CreateVLSImpExp(OleDb oledb)
        {

            bool result = myVLS.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertMultipleRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormVLS_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormVLS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                VLS.Rule.Common.NameRule = txtSymbolRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtRcvLN_TextChanged(object sender, EventArgs e)
        {
            txtRcvLNRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtRcvLN.Text, false);
        }

        private void txtRcvHN_TextChanged(object sender, EventArgs e)
        {
            txtRcvHNRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtRcvHN.Text, false);
        }

        private void txtSndBin_TextChanged(object sender, EventArgs e)
        {
            txtSndBinRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSndBin.Text, false);
        }

        private void txtAsp_TextChanged(object sender, EventArgs e)
        {
            txtAspRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtAsp.Text, false);
        }
        private void TxtSymbolIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (AppGlobal.CheckNumericString(txtSymbolIncRule.Text))
                {
                    VLS.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void TxtDescriptionRule_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescriptionRule.Text))
            {
                if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
                {
                    VLS.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void TxtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    VLS.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }

        }   
        private void TxtInpFaultDevSuffix_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpHWSuffix_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpFaultDev_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInHWStop_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtOutpLN_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtOutpHN_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtInpLN_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpLNSuffix_TextChanged(object sender, EventArgs e)
        {
            TxtInpLN.Text = namePrefix + txtInpLNSuffix.Text;
        }
        private void txtInpLNSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpLNSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.VLS.Suffix.InpLN", newJsonKeyValue);
                GcObjectInfo.VLS.SuffixInpLN = newJsonKeyValue;

            }
        }
        private void txtOutpLNSuffix_TextChanged(object sender, EventArgs e)
        {
            TxtOutpLN.Text = namePrefix + txtOutpLNSuffix.Text;
        }
        private void txtOutpLNSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpLNSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.VLS.Suffix.OutpLN", newJsonKeyValue);
                GcObjectInfo.VLS.SuffixOutpLN = newJsonKeyValue;
               
            }
        }
        private void TxtInpHN_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtInpHN_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txtInpHNSuffix_TextChanged(object sender, EventArgs e)
        {
            TxtInpHN.Text = namePrefix + txtInpHNSuffix.Text;
        }
        private void txtInpHNSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpHNSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.VLS.Suffix.InpHN", newJsonKeyValue);
                GcObjectInfo.VLS.SuffixInpHN = newJsonKeyValue;

            }
        }
        private void txtOutpHNSuffix_TextChanged(object sender, EventArgs e)
        {
            TxtOutpHN.Text = namePrefix + txtOutpHNSuffix.Text;
        }
        private void txtOutpHNSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpHNSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.VLS.Suffix.OutpHN", newJsonKeyValue);
                GcObjectInfo.VLS.SuffixOutpHN = newJsonKeyValue;              
            }
        }

        private void txtInpRunRev_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpRunRevSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRunRev.Text = namePrefix + txtInpRunRevSuffix.Text;
        }
        private void txtInpRunRevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpRunRevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.VLS.Suffix.InpRunRev", newJsonKeyValue);
                GcObjectInfo.VLS.SuffixInpRunRev = newJsonKeyValue;
            }
        }
        private void txtInpRunFwd_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpRunFwdSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRunFwd.Text = namePrefix + txtInpRunFwdSuffix.Text;
        } 
        private void txtInpRunFwdSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpRunFwdSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.VLS.Suffix.InpRunFwd", newJsonKeyValue);
                GcObjectInfo.VLS.SuffixInpRunFwd = newJsonKeyValue;
            }
        }

        private void TxtMonTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtMonTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
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

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }
        private void chkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParManual.Checked)
            { AppGlobal.SetBit(ref value10, (byte)1); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }
        private void chkPulseValve_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkPulseValve.Checked)
            { AppGlobal.SetBit(ref value10, (byte)2); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }

        private void chkContValve_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkContValve.Checked)
            { AppGlobal.SetBit(ref value10, (byte)3); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)3); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }

        private void chkManualFlap_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkManualFlap.Checked)
            { AppGlobal.SetBit(ref value10, (byte)4); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)4); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }

        private void chkStartwarningLN_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkStartwarningLN.Checked)
            { AppGlobal.SetBit(ref value10, (byte)5); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)5); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }

        private void chkStartwarningHN_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkStartwarningHN.Checked)
            { AppGlobal.SetBit(ref value10, (byte)6); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)6); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }
        #endregion

        #region <------Field in database display
        private void TxtSymbol_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Text0";
        }
        private void TxtDescription_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Text1";
        }
        private void TxtInpLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }
        private void TxtInpHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value13";
        }
        private void TxtOutpLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }
        private void TxtOutpHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value14";
        }
        private void txtInpRunRev_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value15";
        }
        private void txtInpRunFwd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value16";
        }
        private void txtInpFaultDev_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value19";
        }

        private void TxtInHWStop_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value47";
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

        private void ComboDPNode2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "DPNode2";
        }

        private void txtMonTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void txtPulseTimeLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }

        private void txtPulseTimeHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }
        private void txtStartDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }

        private void txtIdlingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }
        private void txtFaultDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }
        #region Check value10
        private void chkParLogOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value0.Bit0";
        }
        private void chkParManual_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }  
        private void chkPulseValve_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit2";
        }
        private void chkContValve_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit3";
        }
        private void chkManualFlap_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit4";
        }

        private void chkStartwarningLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit5";
        }
        private void chkStartwarningHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit6";
        }
        #endregion
        private void txtRcvLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30";
        }

        private void txtRcvHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31";
        }

        private void txtSndBin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value32";
        }

        private void txtAsp_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value34";
        }
        #endregion

        private void txtSndBin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value1.Name;
            objectBrowser.OType = Convert.ToString(Bin.OTypeValue);
            objectBrowser.ShowDialog();
            txtSndBin.Text = objectBrowser.ReturnedItem;
          
        }

        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value21.Name;
            objectBrowser.OType = Convert.ToString(VLS.OTypeValue);
            objectBrowser.Show();
        }
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            NamePrefix();
            NameSubElements(namePrefix);
            myVLS.Name = txtSymbol.Text;
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtDescription.Text, false);
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(selectedItem))
            {

                myVLS.SubType= selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                NameSubElements(namePrefix);
                SubtypeChanged();
            }  
            try
            {
                if (myVLS.SubType == VLS.VCO)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(VLS.P7081.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myVLS.SubType == VLS.VPO || myVLS.SubType == VLS.VPOR)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(VLS.P7082.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myVLS.SubType == VLS.VPOM)
                {
                    txtOutpHNSuffix.Text = GcObjectInfo.VLS.SuffixOutpRunFwd;
                    txtOutpLNSuffix.Text = GcObjectInfo.VLS.SuffixOutpRunRev;
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(VLS.P7081.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }          
                  
                }         
                else if (myVLS.SubType == VLS.VMF)
                {
                    //foreach (var item in ComboEquipmentInfoType.Items)
                    //{
                    //    if (item.ToString().StartsWith(VLS.P7081))
                    //    {
                    //        ComboEquipmentInfoType.SelectedItem = item;
                    //        break;
                    //    }
                    //}
                }
                if ((myVLS.SubType != VLS.VPOM))
                {
                    txtOutpHNSuffix.Text = GcObjectInfo.VLS.SuffixOutpHN;
                    txtOutpLNSuffix.Text = GcObjectInfo.VLS.SuffixOutpLN;
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
        #region <---BML part--->
        private void txtVLSSuffixBML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtVLSSuffixBML.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.VLS.Suffix.VLS", newJsonKeyValue);
                GcObjectInfo.VLS.SuffixVLS = newJsonKeyValue;
            }
        }

        private void txtLocalPanelPrefix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtLocalPanelPrefix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.Prefix.LocalPanel", newJsonKeyValue);
                BML.PrefixLocalPanel = newJsonKeyValue;
            }
        }
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
        private void BtnOpenProjectBML_Click(object sender, EventArgs e)
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
            BML.VLS.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Path", BML.VLS.BMLPath);
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
            AddWorkSheets();
        }
        private void comboWorkSheetsBML_SelectedIndexChanged(object sender, EventArgs e)
        {

            excelFileHandle.WorkSheet = comboWorkSheetsBML.SelectedItem.ToString();
            if (! String.IsNullOrEmpty(excelFileHandle.WorkSheet))
            {
                btnReadBML.Enabled= true;   
            }
        }
        private void dataGridBML_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TxtQuantity.Text = dataGridBML.Rows.Count.ToString();
        }
        private void CreateBMLDefault()
        {
            BML.VLS.SuffixVLS = GcObjectInfo.VLS.SuffixVLS;
            BML.VLS.NameDelimiter = GcObjectInfo.General.DelimiterSymbol;
            BML.VLS.PrefixName = GcObjectInfo.General.PrefixName;
            btnReadBML.Enabled = false;
            //txtVFCPrefixBML.Text = ;
            var alphabetList = AppGlobal.CreateAlphabetList<string>('A', 'Z', letter => letter.ToString());
            foreach (var item in alphabetList)
            {
                comboNameBML.Items.Add(item);
                comboDescBML.Items.Add(item);
                comboTypeBML.Items.Add(item);
                comboFloorBML.Items.Add(item);
                comboSectionBML.Items.Add(item);
                comboCabinetBML.Items.Add(item);
                comboIORemarkBML.Items.Add(item);
                comboLineBML.Items.Add(item);
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
                comboIORemarkBML.SelectedItem = "R";
                comboLineBML.SelectedItem = "X";

            }
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text = BML.VLS.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.VLS.ColumnName; 
            nameColumn.Name = nameof(BML.VLS.ColumnName);                                              
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.VLS.ColumnDesc;
            descColumn.Name = nameof(BML.VLS.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);

            DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            floorColumn.HeaderText = BML.VLS.ColumnFloor;
            floorColumn.Name = nameof(BML.VLS.ColumnFloor);
            dataGridBML.Columns.Add(floorColumn);

            DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            cabinetColumn.HeaderText = BML.VLS.ColumnCabinet;
            cabinetColumn.Name = nameof(BML.VLS.ColumnCabinet);
            dataGridBML.Columns.Add(cabinetColumn);

            DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            cabinetColumnGroup.HeaderText = BML.VLS.ColumnCabinetGroup;
            cabinetColumnGroup.Name = nameof(BML.VLS.ColumnCabinetGroup);
            dataGridBML.Columns.Add(cabinetColumnGroup);

            DataGridViewTextBoxColumn ioRemarkColumn = new DataGridViewTextBoxColumn();
            ioRemarkColumn.HeaderText = BML.VLS.ColumnIORemark;
            ioRemarkColumn.Name = nameof(BML.VLS.ColumnIORemark);
            dataGridBML.Columns.Add(ioRemarkColumn);

            DataGridViewTextBoxColumn lineColumn = new DataGridViewTextBoxColumn();
            lineColumn.HeaderText = BML.VLS.ColumnLine;
            lineColumn.Name = nameof(BML.VLS.ColumnLine);
            dataGridBML.Columns.Add(lineColumn);
        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboIORemarkBML.Text,comboLineBML.Text};
            DataTable dataTable = new DataTable();
            StringBuilder sbFilter= new StringBuilder();
            sbFilter.Append($@"Value LIKE ""%{BML.VLS.ManualFlap}"" || ").Append($@"Value LIKE ""%{BML.VLS.PneFlap}"" || ").Append($@"Value LIKE ""%{BML.VLS.PneTwoWayValve}"" || ")
                .Append($@"Value LIKE ""%{BML.VLS.PneSlideGate}"" || ").Append($@"Value LIKE ""%{BML.VLS.ManualSlideGate}"" || ").Append($@"Value LIKE ""%{BML.VLS.PneShutOffValve}"" || ")
                .Append($@"Value LIKE ""%{BML.VLS.PneAspValve}""");   
            string[] filters = { $@"{sbFilter.ToString()}" };
            string[] filterColumns = { comboDescBML.Text };
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);
            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.VLS.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnFloor)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnCabinet)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnIORemark)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnLine)].DataPropertyName = dataTable.Columns[6].ColumnName;
            listBMLName = LibGlobalSource.BMLHelper.ExtractUniqueCommonSubstringsWithCount(dataTable, dataTable.Columns[0].ColumnName);
            TxtQuantity.Text = listBMLName.Count.ToString();
            listBMLName.Clear();
        }
        #endregion
        #region Common used
        #region Genate elements name

        private void SubtypeChanged()
        {
            if (myVLS.SubType==VLS.VMF)
            {
                chkContValve.Checked = false;
                chkPulseValve.Checked = false;
                chkManualFlap.Checked = true;
            }
            else if (myVLS.SubType == VLS.VCO)
            {
                chkContValve.Checked = true;
                chkPulseValve.Checked = false;
                chkManualFlap.Checked = false;
            }
            else if (myVLS.SubType == VLS.VPO || myVLS.SubType == VLS.VPOM || myVLS.SubType == VLS.VPOR)
            {
                chkContValve.Checked = false;
                chkPulseValve.Checked = true;
                chkManualFlap.Checked = false;
            }

        }
        private void NamePrefix()
        {
           // namePrefix = txtSymbol.Text.Substring(0, txtSymbol.Text.IndexOf(txtSymbolRule.Text)) + txtSymbolRule.Text + GcObjectInfo.General.DelimiterSymbol;
            namePrefix= txtSymbol.Text.Replace(LibGlobalSource.StringHelper.ExtractStringPart($@"{GcObjectInfo.VLS.SuffixVLSPattern}", txtSymbol.Text),"");
            nameLen= namePrefix.Length;
        }
        private void InpSubElements(string _namePrefix)
        {
            TxtInpLN.Text = _namePrefix + txtInpLNSuffix.Text;
            TxtInpHN.Text = _namePrefix + txtInpHNSuffix.Text;
            txtInpRunRev.Text = string.Empty;
            txtInpRunFwd.Text = string.Empty;
        }
        private void InpMSubElements(string _namePrefix)
        {
            txtInpRunRev.Text = _namePrefix + txtInpRunRevSuffix.Text;
            txtInpRunFwd.Text = _namePrefix + txtInpRunRevSuffix.Text;
        }
        private void VMFSubElements(string _namePrefix)
        {
            InpSubElements(_namePrefix);
            TxtOutpLN.Text = string.Empty;  
            TxtOutpHN.Text = string.Empty;
        }
        private void VCOSubElements(string _namePrefix) 
        {
            txtOutpHNSuffix.Text = GcObjectInfo.VLS.SuffixOutpHN;
            txtOutpLNSuffix.Text = GcObjectInfo.VLS.SuffixOutpLN;
            InpSubElements(_namePrefix);
            TxtOutpHN.Text = _namePrefix + txtOutpHNSuffix.Text;
            TxtOutpLN.Text= string.Empty;   
        }
        private void VPOSubElements(string _namePrefix)
        {
            VCOSubElements(_namePrefix);
            TxtOutpLN.Text = _namePrefix + txtOutpLNSuffix.Text;         
        }
        private void VPOMSubElements(string _namePrefix)
        {
          
            TxtInpLN.Text = _namePrefix + txtInpLNSuffix.Text;
            TxtInpHN.Text = _namePrefix + txtInpHNSuffix.Text;
            TxtOutpHN.Text = _namePrefix + txtOutpHNSuffix.Text;
            TxtOutpLN.Text = _namePrefix + txtOutpLNSuffix.Text;
            txtInpRunRev.Text = _namePrefix+txtInpRunRevSuffix.Text; 
            txtInpRunFwd.Text = _namePrefix + txtInpRunFwdSuffix.Text;
        }

        private void NameSubElements(string _namePrefix)
        {
            if (myVLS.SubType == VLS.VCO)          
            {
                VCOSubElements(_namePrefix);
            }
            else if (myVLS.SubType == VLS.VPO || myVLS.SubType==VLS.VPOR)
            {
                VPOSubElements(_namePrefix);

            }
            else if (myVLS.SubType == VLS.VPOM )
            {
                VPOMSubElements(_namePrefix);

            }
            else if (myVLS.SubType == VLS.VMF)
            {
                VMFSubElements(_namePrefix);
            }
        }
        #endregion
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                txtSymbolRule.Text = VLS.Rule.Common.NameRule;
                txtSymbolIncRule.Text = VLS.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_VLS;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;
               
            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = VLS.Rule.Common.NameRule;
                txtSymbolIncRule.Text = VLS.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                GrpSymbolRule.Visible = false;
                LblSymbol.Text = AppGlobal.KEY_WORD_AUTOSEARCH;
                tabRule.Text = CreateMode.ObjectCreateMode.AutoSearch;
                
            }

            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.BML)
            {
                createMode.Rule = false;
                createMode.BML = true;
                createMode.AutoSearch = false;
                tabCreateMode.SelectedTab = tabBML;
                txtVLSSuffixBML.Text = GcObjectInfo.VLS.SuffixVLS;
                txtLocalPanelPrefix.Text = BML.PrefixLocalPanel;
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
            if (MessageBox.Show(AppGlobal.CONNECT_IO, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                try
                {
                    bool all=!chkOnlyFree.Checked;
                    string objName = String.Empty;
                    string objNamePrefix = String.Empty;
                    string objSubType = String.Empty;
                    OleDb oledb= new OleDb();
                    DataTable dataTable = new DataTable();
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={VLS.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.SubType.Name,
                        GcproTable.ObjData.Value11.Name, GcproTable.ObjData.Value12.Name, GcproTable.ObjData.Value13.Name,
                        GcproTable.ObjData.Value14.Name, GcproTable.ObjData.Value15.Name, GcproTable.ObjData.Value16.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    VLS.Clear(myVLS.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objNamePrefix = objName.Replace(GcObjectInfo.VLS.SuffixVLS, "");
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        if (objSubType == VLS.VCO)
                        {
                            string inpLN, inpHN, outpHN;
                            inpLN = objNamePrefix + GcObjectInfo.VLS.SuffixInpLN;
                            inpHN = objNamePrefix + GcObjectInfo.VLS.SuffixInpHN;
                            outpHN = objNamePrefix + GcObjectInfo.VLS.SuffixOutpHN;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpLN, GcproTable.ObjData.Value11.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value13.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpHN, GcproTable.ObjData.Value13.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value14.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, outpHN, GcproTable.ObjData.Value14.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else if (objSubType == VLS.VPO || objSubType == VLS.VPOR)
                        {
                            string inpLN, inpHN, outpLN, outpHN;
                            inpLN = objNamePrefix + GcObjectInfo.VLS.SuffixInpLN;
                            outpLN = objNamePrefix + GcObjectInfo.VLS.SuffixOutpLN;
                            inpHN = objNamePrefix + GcObjectInfo.VLS.SuffixInpHN;
                            outpHN = objNamePrefix + GcObjectInfo.VLS.SuffixOutpHN;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpLN, GcproTable.ObjData.Value11.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, outpLN, GcproTable.ObjData.Value12.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value13.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpHN, GcproTable.ObjData.Value13.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value14.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, outpHN, GcproTable.ObjData.Value14.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else if (objSubType == VLS.VPOM)
                        {
                            string inpRunRev, inpRunFwd, outpRunRev, outpRunFwd, inpLN, inpHN;
                            inpLN = objNamePrefix + GcObjectInfo.VLS.SuffixInpLN;
                            inpHN = objNamePrefix + GcObjectInfo.VLS.SuffixInpHN;
                            outpRunRev = objNamePrefix + GcObjectInfo.VLS.SuffixOutpRunRev;
                            outpRunFwd = objNamePrefix + GcObjectInfo.VLS.SuffixOutpRunFwd;
                            inpRunRev = objNamePrefix + GcObjectInfo.VLS.SuffixInpRunRev;
                            inpRunFwd = objNamePrefix + GcObjectInfo.VLS.SuffixInpRunFwd;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpLN, GcproTable.ObjData.Value11.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, outpRunRev, GcproTable.ObjData.Value12.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value13.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpHN, GcproTable.ObjData.Value13.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value14.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, outpRunFwd, GcproTable.ObjData.Value14.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value15.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpRunRev, GcproTable.ObjData.Value15.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value16.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpRunFwd, GcproTable.ObjData.Value16.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else if (objSubType == VLS.VMF)
                        {
                            string inpLN, inpHN;
                            inpLN = objNamePrefix + GcObjectInfo.VLS.SuffixInpLN;
                            inpHN = objNamePrefix + GcObjectInfo.VLS.SuffixInpHN;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpLN, GcproTable.ObjData.Value11.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value13.Name) == 0 || all)
                            {
                                VLS.CreateRelation(objName, inpHN, GcproTable.ObjData.Value13.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                        }                                                   
                        ProgressBar.Value=count;
                    }
                    VLS.SaveFileAs(myVLS.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
                    dataTable.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("寻找IO与关联过程出错:"+ex, AppGlobal.INFO+":"+AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }   
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_CLEAR_FILE, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)

            {
                myVLS.Clear();
                ProgressBar.Value = 0;  
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            VLS.SaveFileAs(myVLS.FilePath, LibGlobalSource.CREATE_OBJECT);
            VLS.SaveFileAs(myVLS.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
        void AppendInfoToBuilder(CheckBox checkBox, string info, StringBuilder builder)
        {
            if (checkBox.Checked)
            {
                builder.Append(info);
            }
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                OleDb oledb = new OleDb();
                oledb.DataSource = AppGlobal.GcproDBInfo.GcsLibaryPath;
                oledb.IsNewOLEDBDriver = isNewOledbDriver;
                DataTable dataTable = new DataTable();
                #region common used variables declaration
                int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                bool moreThanOne = quantityNeedToBeCreate > 1;
                bool onlyOne = quantityNeedToBeCreate == 1;
                bool additionInfToDesc = false;
                StringBuilder descTotalBuilder = new StringBuilder();
                RuleSubDataSet description, name, dpNode1;
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
                dpNode1 = new RuleSubDataSet
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
                #region Prepare export motor file
                ///<OType>is set when object generated</OType>
                ///<Name>Value is set in TxtSymbol text changed event</Name>
                ///<Description></Description>
                myVLS.Description = txtDescription.Text;
                ///<ProcessFct></ProcessFct>
                string selectedProcessFct = string.Empty;
                if (ComboProcessFct.SelectedItem != null)
                {
                    selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                    myVLS.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Building></Building>
                string selectedBudling = "--";
                if (ComboBuilding.SelectedItem != null)
                {
                    selectedBudling = ComboBuilding.SelectedItem.ToString();
                    myVLS.Building = selectedBudling;
                }
                ///<Diagram></Diagram>
                string selectedDiagram;
                if (ComboDiagram.SelectedItem != null)
                {
                    selectedDiagram = ComboDiagram.SelectedItem.ToString();
                    myVLS.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Page></Page>
                myVLS.Page = txtPage.Text;
                ///<HornCode></HornCode>
                myVLS.HornCode = "00";
                ///<ParMonTime></ParMonTime>
                myVLS.MonTime = AppGlobal.ParseFloat(txtMonTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "200.0";
                ///<ParpulseTimeLN></ParpulseTimeLN>
                myVLS.PulseTimeLN = AppGlobal.ParseFloat(txtPulseTimeLN.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "5.0";
                ///<ParpulseTimeHN></ParpulseTimeHN>
                myVLS.PulseTimeHN = AppGlobal.ParseFloat(txtPulseTimeHN.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "5.0";
                ///<ParIdlingTime></ParIdlingTime>
                myVLS.IdlingTime = AppGlobal.ParseFloat(txtIdlingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "10.0";
                ///<ParFaultDelayTime></ParFaultDelayTime>
                myVLS.FaultDelay = AppGlobal.ParseFloat(txtFaultDelayTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "30.0";
                ///<ParStartDelay></ParStartDelay>
                myVLS.StartDelay = AppGlobal.ParseFloat(txtStartDelayTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
                ///<Value10>Value is set when corresponding check box's check state changed</Value10>
                ///                       
                ///<InpLN></InpLN>
                myVLS.InpLN = LibGlobalSource.NOCHILD;
                ///<OutpFwd></OutFwd>
                myVLS.OutpLN = LibGlobalSource.NOCHILD;
                ///<InpRHN></InpHN>
                myVLS.InpHN = LibGlobalSource.NOCHILD;
                ///<OutpHN</OutpHN>
                myVLS.OutpHN = LibGlobalSource.NOCHILD;
                ///<InpFaultDev></InpFaultDev>
                myVLS.InpRunRev = txtInpFaultDev.Text;
                ///<InpRunRev></InpRunRev>
                myVLS.InpRunFwd = LibGlobalSource.NOCHILD;
                ///<InpRunRev></InpRunRev>
                myVLS.InpRunRev = LibGlobalSource.NOCHILD;
                ///<InHWStop></InHWStop>
                myVLS.HwStop = string.Empty;
                ///<RefRcvLN></RefRcvLN>
                myVLS.RefRcvLN = string.Empty;
                ///<RefRcvHN></RefRcvHN>
                myVLS.RefRcvHN = string.Empty;
                ///<RefSndBin></RefSndBin>
                myVLS.RefSndBin = string.Empty;
                ///<RefAsp></RefAsp>
                myVLS.RefAsp = string.Empty;
                #endregion
                if (createMode.BML)
                {
                    string commName;
                    int noOfSubIO = 0;
                    int IO = dataGridBML.Rows.Count;
                    bool[] objChecked = new bool[dataGridBML.Rows.Count];
                    string vlsDesc = string.Empty;
                    string vlsType = string.Empty;
                    string cabinet = string.Empty;
                    string cabinetGroup = string.Empty;
                    string vlsIORemark = string.Empty;
                    string vlsElevation = string.Empty;
                    string _nameNumberString = string.Empty;
                    string vlsRcvLN, vlsRcvHN, vlsAsp, vlsSndBin;
                    vlsRcvLN = vlsRcvHN = vlsAsp = vlsSndBin = string.Empty;
                    DataGridViewCell cell;
                    listBMLName = LibGlobalSource.BMLHelper.ExtractUniqueCommonSubstringsWithCount(dataGridBML, nameof(BML.VLS.ColumnName));
                    ProgressBar.Maximum = quantityNeedToBeCreate - 1;
                    ProgressBar.Value = 0;
                    for (int i = 0; i < quantityNeedToBeCreate; i++)
                    {
                        commName = Convert.ToString(listBMLName[i].Key.ToString());
                        noOfSubIO = (int)listBMLName[i].Value;
                        int noOfSubChecked = 0;
                        //cell = dataGridBML.Rows[i].Cells[nameof(BML.VLS.ColumnName)];
                        if (String.IsNullOrEmpty(commName))
                        {
                            continue;
                        }
                      
                        for (int row = 0; row < dataGridBML.Rows.Count; row++)
                        {
                            if (objChecked[row])
                            { continue; }
                            if (noOfSubChecked >= noOfSubIO)
                            { break; }
                            cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnName)];
                            string bmlObjName = Convert.ToString(cell.Value);
                            if (bmlObjName.StartsWith(commName))
                            {
                                noOfSubChecked += 1;
                                objChecked[row] = true;
                                cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnDesc)];
                                vlsType = Convert.ToString(cell.Value);
                                vlsDesc = Convert.ToString(cell.Value);
                                ///<Summary>
                                ///Select Subtype
                                ///Select PType
                                ///</Summary>
                                if (vlsType.Equals(BML.VLS.ManualFlap))
                                {
                                    myVLS.SubType = VLS.VMF;
                                    myVLS.PType = VLS.P7082.ToString();
                                    chkContValve.Checked = false;
                                    chkPulseValve.Checked = false;
                                    chkManualFlap.Checked = true;
                                }
                                else if (vlsType.Equals(BML.VLS.PneFlap))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                    }
                                    myVLS.PType = VLS.P7082.ToString();
                                }
                                else if (vlsType.Equals(BML.VLS.ManualSlideGate))
                                {
                                    myVLS.SubType = VLS.VMF;
                                    myVLS.PType = VLS.P7081.ToString();
                                }
                                else if (vlsType.Equals(BML.VLS.PneSlideGate))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                    }
                                    myVLS.PType = VLS.P7081.ToString();
                                }
                                else if (vlsType.Equals(BML.VLS.PneTwoWayValve))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                    }
                                    myVLS.PType = VLS.P7082.ToString();
                                }
                                else if (vlsType.Equals(BML.VLS.PneShutOffValve))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                    }
                                    myVLS.PType = VLS.P7081.ToString();
                                }
                                else if (vlsType.Equals(BML.VLS.PneAspValve))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                    }
                                    myVLS.PType = VLS.P7081.ToString();
                                }
                                if (noOfSubChecked == 1)
                                {
                                    cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnCabinet)];
                                    cabinet = Convert.ToString(cell.Value);
                                    cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnCabinetGroup)];
                                    cabinetGroup = Convert.ToString(cell.Value);
                                    cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnFloor)];
                                    vlsElevation = Convert.ToString(cell.Value);
                                }
                                string bmlObjNameSuffix = bmlObjName.Replace(commName, "");
                                if (bmlObjNameSuffix.Equals(GcObjectInfo.VLS.SuffixOutpLN.Replace(":O", ""), StringComparison.InvariantCultureIgnoreCase)
                                    || bmlObjNameSuffix.Equals(GcObjectInfo.VLS.SuffixInpLN.Replace(":I", ""), StringComparison.InvariantCultureIgnoreCase))
                                {
                                    cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnIORemark)];
                                    vlsIORemark = Convert.ToString(cell.Value);
                                    if (!string.IsNullOrEmpty(vlsIORemark))
                                    {
                                        vlsRcvLN = BML.VLS.ParseIORemark(vlsIORemark);
                                    }
                                }
                                else if (bmlObjNameSuffix.Equals(GcObjectInfo.VLS.SuffixOutpHN.Replace(":O", ""), StringComparison.InvariantCultureIgnoreCase)
                                    || bmlObjNameSuffix.Equals(GcObjectInfo.VLS.SuffixInpHN.Replace(":I", ""), StringComparison.InvariantCultureIgnoreCase))
                                {
                                    cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnIORemark)];
                                    vlsIORemark = Convert.ToString(cell.Value);
                                    if (!string.IsNullOrEmpty(vlsIORemark))
                                    {
                                        vlsRcvHN = BML.VLS.ParseIORemark(vlsIORemark);
                                    }
                                }
                            }
                        }

                        commName = myVLS.SubType==VLS.VMF? LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNamePrefix,commName):commName;
                        myVLS.Name= commName + txtVLSSuffixBML.Text;
                        NameSubElements(commName);
                        SubtypeChanged();
                        myVLS.InpLN = String.IsNullOrEmpty(TxtInpLN.Text) ? LibGlobalSource.NOCHILD : TxtInpLN.Text;
                        myVLS.OutpLN = String.IsNullOrEmpty(TxtOutpLN.Text) ? LibGlobalSource.NOCHILD : TxtOutpLN.Text;
                        myVLS.InpHN = String.IsNullOrEmpty(TxtInpHN.Text) ? LibGlobalSource.NOCHILD : TxtInpHN.Text;
                        myVLS.OutpHN = String.IsNullOrEmpty(TxtOutpHN.Text) ? LibGlobalSource.NOCHILD : TxtOutpHN.Text;
                        myVLS.InpRunRev = String.IsNullOrEmpty(txtInpRunRev.Text) ? LibGlobalSource.NOCHILD : txtInpRunRev.Text;
                        myVLS.InpRunFwd = String.IsNullOrEmpty(txtInpRunFwd.Text) ? LibGlobalSource.NOCHILD : txtInpRunFwd.Text;
                    
                        ///<AdditionInfoToDesc>
                        ///</AdditionInfoToDesc>
                        descTotalBuilder.Clear();

                        additionInfToDesc = chkAddNameToDesc.Checked || chkAddFloorToDesc.Checked ||
                            chkAddCabinetToDesc.Checked;
                        if (chkAddSectionToDesc.Checked)
                        {
                             _nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameOnlyWithNumber, myVLS.Name);
                            if (!string.IsNullOrEmpty(_nameNumberString))
                            {
                                if (AppGlobal.ParseInt(_nameNumberString.Substring(0,4), out tempInt))
                                {
                                    descTotalBuilder.Append(GcObjectInfo.Section.ReturnSection(tempInt));
                                }
                            }
                        }
                        if (additionInfToDesc)
                        {
                            AppendInfoToBuilder(chkAddFloorToDesc, $"{myVLS.Elevation}{GcObjectInfo.General.AddInfoElevation}", descTotalBuilder);
                            string descName = chkNameOnlyNumber.Checked ? _nameNumberString : LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameWithoutTypeLL, myVLS.Name);
                            descName = descName.Contains(GcObjectInfo.General.PrefixName) ? descName.Replace(GcObjectInfo.General.PrefixName, string.Empty) : descName;
                            AppendInfoToBuilder(chkAddNameToDesc, $"({descName})", descTotalBuilder);
                        }
                        descTotalBuilder.Append($"{vlsDesc}");
                        if (additionInfToDesc)
                        {
                            descTotalBuilder.Append("[");
                           // AppendInfoToBuilder(chkAddNameToDesc, $"{GcObjectInfo.General.AddInfoSymbol}{LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameWithoutTypeLL, myVLS.Name)}", descTotalBuilder);
                           // AppendInfoToBuilder(chkAddFloorToDesc, $" {GcObjectInfo.General.AddInfoElevation}{myVLS.Elevation}", descTotalBuilder);
                            AppendInfoToBuilder(chkAddCabinetToDesc, $"{GcObjectInfo.General.AddInfoCabinet}{myVLS.Panel_ID}", descTotalBuilder);                          
                            descTotalBuilder.Append("]");
                        }

                        myVLS.Description = descTotalBuilder.ToString();
                      //  myVLS.Description = vlsDesc;
                        myVLS.Panel_ID = cabinet.StartsWith(BML.PrefixLocalPanel) ? cabinet : cabinetGroup + cabinet;
                        myVLS.Elevation = vlsElevation;
                        myVLS.RefRcvLN = vlsRcvLN;
                        myVLS.RefRcvHN = vlsRcvHN;
                        myVLS.RefAsp = vlsAsp;
                        myVLS.RefSndBin = vlsSndBin;
                        myVLS.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = i;
                    }
                    listBMLName.Clear();
                }
                else if (createMode.AutoSearch)
                {
                    //未完成
                    List<Dictionary<string, string>> objSubList = new List<Dictionary<string, string>>();
                    List<GcObjectInfo.VLS.SimpleInfo> obj = new List<GcObjectInfo.VLS.SimpleInfo>();
                    List<GcObjectInfo.VLS.SimpleInfo> objOut = new List<GcObjectInfo.VLS.SimpleInfo>();
                    string filter = $@"({GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.DOC} OR {GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.DIC}) " +
                                    $@"AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER} AND ({GcproTable.ObjData.Text0.Name} LIKE '%{GcObjectInfo.VLS.SuffixInpLN}%' " +
                                    $@"{GcproTable.ObjData.Text0.Name} LIKE '%{GcObjectInfo.VLS.SuffixInpHN}%' OR {GcproTable.ObjData.Text0.Name} LIKE '%{GcObjectInfo.VLS.SuffixOutpLN}%' " +
                                    $@"{GcproTable.ObjData.Text0.Name} LIKE '%{GcObjectInfo.VLS.SuffixOutpHN}%' OR {GcproTable.ObjData.Text0.Name} LIKE '%{GcObjectInfo.VLS.SuffixInpRunFwd}%' " +
                                    $@"{GcproTable.ObjData.Text0.Name} LIKE '%{GcObjectInfo.VLS.SuffixInpRunRev}%'";

                    filter = string.IsNullOrEmpty(txtSymbol.Text) ? filter : $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, $"[{GcproTable.ObjData.Key.Name}] ASC", $"[{GcproTable.ObjData.Key.Name}]", $"[{GcproTable.ObjData.Text0.Name}]", $"[{GcproTable.ObjData.OType.Name}]");
                    objSubList = OleDb.GetColumnsData<string>(dataTable, GcproTable.ObjData.Text0.Name, GcproTable.ObjData.OType.Name);
                    for (int listIndex = 0; listIndex <= objSubList.Count - 1; listIndex++)
                    {

                        var dictionary = objSubList[listIndex];
                        var keys = new List<string>(dictionary.Keys);
                        byte _count = 0;
                        byte _countOutp = 0;
                        byte _countInp = 0;
                       
                        string _nameInp = AppGlobal.GetObjectSymbolFromPattern(dictionary[keys[0]], GcObjectInfo.VLS.SuffixInpPattern);
                        string _nameOutp= AppGlobal.GetObjectSymbolFromPattern(dictionary[keys[0]], GcObjectInfo.VLS.SuffixOutpPattern);
                        string _nameMotorValve = AppGlobal.GetObjectSymbolFromPattern(dictionary[keys[0]], GcObjectInfo.VLS.SuffixOutpRunPattern);
                        bool isMotorValve = string.IsNullOrEmpty(_nameMotorValve) ? false : true;
                        if(!string.IsNullOrEmpty(_nameInp))
                        { }
                        string _name = string.IsNullOrEmpty(_nameMotorValve) ? _nameMotorValve : _nameInp;          
                        if (listIndex == 0)
                        {
                            obj.Add(new GcObjectInfo.VLS.SimpleInfo(_name, isMotorValve, _count, _countInp, _countOutp));                         
                        }
                        else if (listIndex > 0)
                        {
                            bool found = false;
                            for (int listIndexPrev = 0; listIndexPrev <= listIndex - 1; listIndexPrev++)
                            {
                                var dictionaryPrev = objSubList[listIndexPrev];
                                var keysPrev = new List<string>(dictionaryPrev.Keys);
                                var dictionaryOutPrev = objSubList[listIndexPrev];
                                var keysOutPrev = new List<string>(dictionaryPrev.Keys);
                                string _nameOutpPrev = AppGlobal.GetObjectSymbolFromIO(dictionaryPrev[keysPrev[0]]);
                                string _nameMotorValvePrev = AppGlobal.GetObjectSymbolFromIO(dictionaryPrev[keysPrev[0]], GcObjectInfo.Motor.SuffixVFC);
                                string _namePrev = string.IsNullOrEmpty(_nameOutpPrev) ? _nameMotorValvePrev : _nameOutpPrev;

                                if (_name.Equals(_namePrev))
                                {
                                    found = true;
                                    for (int indexObj = 0; indexObj <= obj.Count - 1; indexObj++)
                                    {
                                        GcObjectInfo.VLS.SimpleInfo updatedItem = obj[indexObj];
                                        if (updatedItem.Name.Equals(_name))
                                        {
                                            updatedItem.Count += 1;
                                            obj[indexObj] = updatedItem;

                                        }
                                    }
                                    continue;
                                }

                            }
                            if (!found)
                            {
                                obj.Add(new GcObjectInfo.VLS.SimpleInfo(_name, isMotorValve, _count, _countInp, _countOutp));
                            }
                        }

                        ProgressBar.Maximum = quantityNeedToBeCreate - 1;
                        ProgressBar.Value = 0;
                        ///<DescRule>生成描述规则</DescRule>
                        if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
                        {
                            description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtDescription.Text, txtDescriptionRule.Text);
                            if (description.PosInfo.Len == -1)
                            {
                                if (moreThanOne)
                                {
                                    AppGlobal.RuleNotSetCorrect($"{GrpDescriptionRule.Text}.{LblDescriptionRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                                    // return;
                                }
                            }
                            else
                            { description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtDescription.Text, txtDescriptionRule.Text); }
                        }
                        for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
                        {
                            myVLS.CreateObject(Encoding.Unicode);
                            ProgressBar.Value = i;
                        }
                        ProgressBar.Value = ProgressBar.Maximum;
                    }
                }
                else if (createMode.Rule)
                {
                    ///<Elevation></Elevation>                 
                    if (ComboElevation.SelectedItem != null)
                    {
                        string selectedElevation;
                        selectedElevation = ComboElevation.SelectedItem.ToString();
                        myVLS.Elevation = selectedElevation;
                    }
                    ///<Panel_ID></Panel_ID>                   
                    if (ComboPanel.SelectedItem != null)
                    {
                        string selectedPanel_ID;
                        selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                        myVLS.Panel_ID = selectedPanel_ID;
                    }
                    ///<IsNew>is set when object generated,Default value is "No"</IsNew>
                    ///<SubType></SubType>                  
                    if (ComboEquipmentSubType.SelectedItem != null)
                    {
                        string selectedSubTypeItem;
                        selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                        myVLS.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                    }
                    else
                    {
                        myVLS.SubType = VLS.VCO;
                    }
                    ///<PType></PType>                
                    if (ComboEquipmentInfoType.SelectedItem != null)
                    {
                        string selectedPTypeItem;
                        selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                        myVLS.PType = selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                    }
                    else
                    {
                        myVLS.PType = VLS.P7081.ToString();
                    }
                    ///<FieldBusNode></FieldBusNode>
                    myVLS.FieldBusNode = LibGlobalSource.NOCHILD; ;
                    ///<DPNode1></DPNode1>                 
                    if (ComboDPNode1.SelectedItem != null)
                    {
                        string selectDPNode1 = ComboDPNode1.SelectedItem.ToString();
                        oledb.IsNewOLEDBDriver = isNewOledbDriver;
                        oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                        myVLS.DPNode1 = AppGlobal.FindDPNodeNo(oledb, selectDPNode1);
                        int dpnode1 = 0;
                        myVLS.FieldBusNode = AppGlobal.ParseInt(myVLS.DPNode1, out dpnode1) ? AppGlobal.FindFieldbusNodeKey(oledb, dpnode1) : LibGlobalSource.NOCHILD;
                    }
                    #region Parse rules
                    ///<ParseRule> </ParseRule>
                    if (!AppGlobal.ParseInt(txtSymbolIncRule.Text, out tempInt))
                    {
                        if (moreThanOne)
                        {
                            AppGlobal.MessageNotNumeric($"({GrpSymbolRule.Text}.{LblSymbolIncRule.Text})");
                            return;
                        }
                    }
                    ///<NameRule>准备生成名称规则</NameRule>
                    name.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtSymbol.Text, txtSymbolRule.Text);
                    if (name.PosInfo.Len == -1)
                    {
                        if (moreThanOne)
                        {
                            AppGlobal.RuleNotSetCorrect($"{GrpSymbolRule.Text}.{LblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                            return;
                        }
                    }
                    else
                    {
                        name.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtSymbol.Text, txtSymbolRule.Text);
                    }
                    ///<DescRule>准备生成描述规则</DescRule>
                    if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
                    {
                        description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtDescription.Text, txtDescriptionRule.Text);
                        if (description.PosInfo.Len == -1)
                        {
                            if (moreThanOne)
                            {
                                AppGlobal.RuleNotSetCorrect($"{GrpDescriptionRule.Text}.{LblDescriptionRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                            }
                        }
                        else
                        {
                            description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtDescription.Text, txtDescriptionRule.Text);
                        }
                    }
                    #endregion
                    ProgressBar.Maximum = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt - 1 : 1;
                    ProgressBar.Value = 0;
                    ///<CreateObj>
                    ///Search IO key,DPNode
                    ///</CreateObj>
                    int symbolInc, symbolRule, descriptionInc;
                    tempBool = AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
                    tempBool = AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
                    tempBool = AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
                    for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
                    {
                        name.Inc = i * symbolInc;
                        name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                        myVLS.HwStop = String.IsNullOrEmpty(txtInHWStop.Text) ? string.Empty : txtInHWStop.Text;
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
                            description.Name = "阀门";
                        }
                        myVLS.Name = name.Name;
                        myVLS.Description = description.Name;

                        string _nameSuffix = LibGlobalSource.StringHelper.ExtractStringPart($@"{GcObjectInfo.VLS.SuffixVLSPattern}", name.Name);
                        if (!string.IsNullOrEmpty(_nameSuffix))
                        {
                            string _name = name.Name.Replace(_nameSuffix, string.Empty);
                            ///<InpLN></InpLN>
                            myVLS.InpLN = _name + txtInpLNSuffix.Text;
                            ///<OutpFwd></OutFwd>
                            myVLS.OutpLN = _name + txtOutpLNSuffix.Text;
                            ///<InpHN></InpHN>
                            myVLS.InpHN = _name + txtInpHNSuffix.Text;
                            ///<OutpHN</OutpHN>
                            myVLS.OutpHN = _name + txtOutpHNSuffix.Text;
                            ///<InpFaultDev></InpFaultDev>
                            myVLS.InpRunRev = _name + txtInpFaultDevSuffix.Text;
                            ///<InpRunRev></InpRunRev>
                            myVLS.InpRunFwd = _name + txtInpRunFwdSuffix.Text;
                            ///<InpRunRev></InpRunRev>
                            myVLS.InpRunRev = _name + txtInpRunRevSuffix.Text;
                            ///<InHWStop></InHWStop>
                            myVLS.HwStop = txtInHWStop.Text;
                        }
                        ///<RefSndBin></RefSndBin>
                        if (!string.IsNullOrEmpty(txtSndBin.Text))
                        {
                            RuleSubDataSet sndBin;
                            int sndBinInc, sndBinRule;
                            tempBool = AppGlobal.ParseInt(txtSndBinIncRule.Text, out sndBinInc);
                            sndBin.Inc = tempBool ? i * sndBinInc : 0;
                            tempBool = AppGlobal.ParseInt(txtSndBinRule.Text, out sndBinRule);
                            myVLS.RefSndBin = tempBool ? GcObjectInfo.Bin.BinPrefix + (sndBinRule + sndBin.Inc) : txtSndBin.Text;
                        }
                        ///<RefAsp></RefAsp>
                        myVLS.RefAsp = txtAsp.Text;
                        myVLS.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = i ;
                    }
                    ProgressBar.Value = ProgressBar.Maximum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建对象过程出错:" + ex, AppGlobal.AppInfo.Title + ":" + AppGlobal.MSG_CREATE_WILL_TERMINATE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion     
    }
}
