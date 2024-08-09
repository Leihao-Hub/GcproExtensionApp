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
using System.Net;
#endregion
namespace GcproExtensionApp
{

    public partial class FormDI : Form, IGcForm
    {

        public FormDI()
        {
            InitializeComponent();
        }

        #region Public object in this class
        DI myDI = new DI(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private string DEMO_NAME_DI = "=A-4201-BLH01";
        private string DEMO_NAME_RULE_DI = "4201";
        private string DEMO_DESCRIPTION_DI = "401号基粉仓高料位/或者空白";
        private string DEMO_DESCRIPTION_RULE_DI = "401/或者空白";
        private string diSuffux = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_DI}.{AppGlobal.JS_SUFFIX}.";
        private GcBaseRule objDefaultInfo;
        #endregion
        private int value9 = 0;
        private int value10 = 0;
        private int tempInt = 0;
        private float tempFloat = (float)0.0;
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
            ///<ReadInfoFromGcsLibrary> 
            ///Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary 
            ///</ReadInfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={DI.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {DI.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + DI.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboEquipmentInfoType.Items.Add(column.ToString());
            }
            ComboEquipmentInfoType.SelectedIndex = 23;
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
            objDefaultInfo.NameRule = "4201";
            objDefaultInfo.DescLine = "制粉A线";
            objDefaultInfo.DescFloor = "6楼";
            objDefaultInfo.Name = "=A-4201-BLH01";
            objDefaultInfo.DescObject = "401号基粉仓高料位";
            objDefaultInfo.DescriptionRuleInc = DI.Rule.Common.DescriptionRuleInc;
            objDefaultInfo.NameRuleInc = DI.Rule.Common.NameRuleInc;
            DI.Rule.Common.Cabinet = DI.Rule.Common.Power = string.Empty;

            objDefaultInfo.Description = DI.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix: GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: chkAddCabinetToDesc.Checked,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (String.IsNullOrEmpty(DI.Rule.Common.Description))
            { DI.Rule.Common.Description = objDefaultInfo.Description; }

            if (String.IsNullOrEmpty(DI.Rule.Common.Name))
            { DI.Rule.Common.Name = objDefaultInfo.Name; }

            if (String.IsNullOrEmpty(DI.Rule.Common.DescLine))
            { DI.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (String.IsNullOrEmpty(DI.Rule.Common.DescFloor))
            { DI.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (String.IsNullOrEmpty(DI.Rule.Common.DescObject))
            { DI.Rule.Common.DescObject = objDefaultInfo.DescObject; }
            txtSymbolRule.Text = DI.Rule.Common.NameRule;
            txtSymbolIncRule.Text = DI.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = DI.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = DI.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = DI.Rule.Common.Name;
            txtDescription.Text = DI.Rule.Common.Description;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + DI.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_DI);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_DI);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_DI);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_DI);
            toolTip.SetToolTip(BtnRegenerateDPNode, AppGlobal.MSG_REGENERATE_DPNODE);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{DI.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{DI.ImpExpRuleName}'", null);
                    CreateDIImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateDIImpExp(oledb);
            }

        }
        public void Default()
        {
            txtSymbol.Focus();
            txtInpTrueSuffix.Text = GcObjectInfo.DI.SuffixInpTrue;
            txtInpFaultDevSuffix.Text = GcObjectInfo.DI.SuffixInpFaultDev;
            txtOutpFaultResetSuffix.Text = GcObjectInfo.DI.SuffixOutpFaultReset;
            txtOutpPowerOffSuffix.Text = GcObjectInfo.DI.SuffixOutpPowerOff;
            txtOutpLampSuffix.Text = GcObjectInfo.DI.SuffixOutpLamp;
            txtInpTrue.Text = txtSymbol.Text + txtInpTrueSuffix.Text;

            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            txtValue9.Text = "1";
            myDI.Value9 = "1";
            txtValue10.Text = "0";
            myDI.Value10 = "0";
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "DI导入文件 " + " " + myDI.FilePath;
        }
        #endregion
        private void CreateDIImpExp(OleDb oledb)
        {

            bool result = myDI.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertMultipleRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormDI_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
        private void txtInpTrueSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpTrueSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{diSuffux}InpTrue", newJsonKeyValue);
                GcObjectInfo.DI.SuffixInpTrue = newJsonKeyValue;
            }
        }

        private void txtInpFaultDevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpFaultDevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{diSuffux}InpFaultDev", newJsonKeyValue);
                GcObjectInfo.DI.SuffixInpFaultDev = newJsonKeyValue;
            }
        }

        private void txtOutpFaultResetSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpFaultResetSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{diSuffux}OutpFaultReset", newJsonKeyValue);
                GcObjectInfo.DI.SuffixOutpFaultReset = newJsonKeyValue;
            }
        }

        private void txtOutpPowerOffSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpPowerOffSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{diSuffux}.OutpPowerOff", newJsonKeyValue);
                GcObjectInfo.DI.SuffixOutpPowerOff = newJsonKeyValue;
            }
        }

        private void txtOutpLampSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpLampSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{diSuffux}OutpLamp", newJsonKeyValue);
                GcObjectInfo.DI.SuffixOutpLamp = newJsonKeyValue;
            }
        }
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (createMode.AutoSearch)
            { return; }
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                DI.Rule.Common.NameRule = txtSymbolRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            txtInpTrue.Text = txtSymbol.Text + txtInpTrueSuffix.Text;
            myDI.Name = txtSymbol.Text;
            myDI.Name = txtSymbol.Text;
            DI.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
        }
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value21.Name;
            objectBrowser.OType = Convert.ToString(DI.OTypeValue);
            objectBrowser.Show();
        }
        private void TxtSymbolIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtSymbolIncRule.Text))
                {
                    DI.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!DI.Rule.Common.Description.Equals(txtDescription.Text))
            {
                DI.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(DI.Rule.Common.DescObject, false);
            if (!txtDescription.Text.Contains(txtDescriptionRule.Text))
            { txtDescription.BackColor = Color.Red; }
            else
            { txtDescription.BackColor = Color.White; }
        }
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DI.Rule.Common.Description = txtDescription.Text;
                    DI.DecodingDesc(ref DI.Rule.Common, AppGlobal.DESC_SEPARATOR);
                    UpdateDesc();
                }
                catch
                {
                }
            }

        }
        private void TxtDescriptionRule_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescriptionRule.Text))
            { return; }

            if (!txtDescription.Text.Contains(txtDescriptionRule.Text))
            { txtDescription.BackColor = Color.Red; }
            else
            { txtDescription.BackColor = Color.White; }
            if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
            {
                string descObjectNumber = LibGlobalSource.StringHelper.ExtractNumericPart(DI.Rule.Common.DescObject, false);
                if (!string.IsNullOrEmpty(descObjectNumber))
                {
                    DI.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                    DI.Rule.Common.DescObject = DI.Rule.Common.DescObject.Replace(descObjectNumber, DI.Rule.Common.DescriptionRule);
                    UpdateDesc();
                }
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void TxtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    DI.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtInpTrueSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpTrue.Text = txtSymbol.Text + txtInpTrueSuffix.Text;
        }
        private void txtOutRevSuffix_TextChanged(object sender, EventArgs e)
        {
            txtOutpPowerOff.Text = txtSymbol.Text + txtOutpPowerOffSuffix.Text;
        }
        private void txtParDelayChange_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtDelayChange.Text)))
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

        private void txtValue9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value9 = AppGlobal.ParseInt(txtValue9.Text, out tempInt) ? tempInt : value9;
                GetValue10BitValue(value9);
            }
        }
        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"    
        private void chkInterlockNextObject_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkInterlockNextObject.Checked)

            { AppGlobal.SetBit(ref value9, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)0); }

            myDI.Value9 = value9.ToString();
            txtValue9.Text = myDI.Value9;
        }
        private void chkInvertInput_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkInvertInput.Checked)

            { AppGlobal.SetBit(ref value9, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)1); }

            myDI.Value9 = value9.ToString();
            txtValue9.Text = myDI.Value9;
        }
        private void chkMonTrue_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonTrue.Checked)

            { AppGlobal.SetBit(ref value9, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)2); }

            myDI.Value9 = value9.ToString();
            txtValue9.Text = myDI.Value9;
        }
        private void chkMonCovered_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonCovered.Checked)

            { AppGlobal.SetBit(ref value9, (byte)12); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)12); }

            myDI.Value9 = value9.ToString();
            txtValue9.Text = myDI.Value9;
        }
        private void chkMonFalse_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonFalse.Checked)

            { AppGlobal.SetBit(ref value9, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)3); }

            myDI.Value9 = value9.ToString();
            txtValue9.Text = myDI.Value9;
        }
        private void chkMonUnCovered_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonUnCovered.Checked)

            { AppGlobal.SetBit(ref value9, (byte)13); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)13); }

            myDI.Value9 = value9.ToString();
            txtValue9.Text = myDI.Value9;
        }
        private void chkInPreAlarm_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkInPreAlarm.Checked)

            { AppGlobal.SetBit(ref value9, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)4); }

            myDI.Value9 = value9.ToString();
            txtValue9.Text = myDI.Value9;
        }
        private void chKInpFaultDev_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chKInpFaultDev.Checked)

            { AppGlobal.SetBit(ref value9, (byte)6); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)6); }

            myDI.Value9 = value9.ToString();
            txtValue9.Text = myDI.Value9;
        }
        private void chkParLogOff_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParLogOff.Checked)

            { AppGlobal.SetBit(ref value10, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)0); }

            myDI.Value10 = value10.ToString();
            txtValue10.Text = myDI.Value10;
        }
        private void chkParPulsing_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPulsing.Checked)

            { AppGlobal.SetBit(ref value10, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myDI.Value10 = value10.ToString();
            txtValue10.Text = myDI.Value10;
        }
        private void chkParFaultRetry_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParFaultRetry.Checked)

            { AppGlobal.SetBit(ref value10, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)3); }

            myDI.Value10 = value10.ToString();
            txtValue10.Text = myDI.Value10;
        }
        private void chkParBinLevel_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParBinLevel.Checked)

            { AppGlobal.SetBit(ref value10, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)4); }

            myDI.Value10 = value10.ToString();
            txtValue10.Text = myDI.Value10;
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
        private void txtInpTrue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }
        private void txtInHWStop_MouseEnter(object sender, EventArgs e)
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
        private void txtDelayChange_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }
        private void txtDelayTrue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }
        private void txtDelayFalse_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }
        private void txtTimeoutTrue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }
        private void txtTimeoutFalse_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }
        private void chkParLogOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit0";
        }
        private void chkParPulsing_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }
        private void chkParFaultRetry_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit3";
        }
        private void chkParBinLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit4";
        }
        private void chkInterlockNextObject_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit0";
        }
        private void chkInvertInput_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit1";
        }
        private void chkMonTrue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit2";
        }
        private void chkMonCovered_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit12";
        }
        private void chkMonFalse_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit3";
        }
        private void chkMonUnCovered_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit13";
        }
        private void chkInPreAlarm_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit4";
        }
        private void chKInpFaultDev_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit6";
        }
        #endregion

        private void UpdateDesc()
        {
            DI.Rule.Common.Description = DI.EncodingDesc(
            baseRule: ref DI.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: chkAddCabinetToDesc.Checked,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = DI.Rule.Common.Description;
        }
        void SubTypeChanged(string subType)
        {
            if (subType == DI.MON2BS)
            {
                myDI.PType = DI.P7163.ToString();
                txtDelayChange.Text = "0.0";
                txtDelayTrue.Text = "1.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "5.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 4;
                value10 = 0;
            }
            else if (subType == DI.MON1MVC)
            {
                myDI.PType = DI.P7171.ToString();
                txtDelayChange.Text = "0.0";
                txtDelayTrue.Text = "1.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "0.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 4;
                value10 = 0;
            }
            else if (subType == DI.MON1M_LS)
            {
                myDI.PType = DI.P7167.ToString();
                txtDelayChange.Text = "0.0";
                txtDelayTrue.Text = "1.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "0.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 5;
                value10 = 0;
            }
            else if (subType == DI.HLBIN)
            {
                myDI.PType = DI.P7146.ToString();
                txtDelayChange.Text = "2.0";
                txtDelayTrue.Text = "15.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "0.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 2;
                value10 = 16;
            }
            else if (subType == DI.LLBIN)
            {
                myDI.PType = DI.P7145.ToString();
                txtDelayChange.Text = "2.0";
                txtDelayTrue.Text = "30.0";
                txtDelayFalse.Text = "5.0";
                txtTimeoutTrue.Text = "0.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 4098;
                value10 = 16;
            }
            else if (subType == DI.HLMA)
            {
                myDI.PType = DI.P7165.ToString();
                txtDelayChange.Text = "2.0";
                txtDelayTrue.Text = "1.0";
                txtDelayFalse.Text = "3.0";
                txtTimeoutTrue.Text = "0.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 8195;
                value10 = 0;
            }
            else if (subType == DI.MON1MPH)
            {
                myDI.PType = DI.P7143.ToString();
                txtDelayChange.Text = "1.0";
                txtDelayTrue.Text = "1.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "0.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 5;
                value10 = 0;
            }
            else if (subType == DI.DIC)
            {
                myDI.PType = DI.P7154.ToString();
                txtDelayChange.Text = "2.0";
                txtDelayTrue.Text = "1.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "0.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 0;
                value10 = 0;
            }
            else if (subType == DI.MON2SSP)
            {
                myDI.SubType = DI.MON2SSP;
                myDI.PType = DI.P7159.ToString();
                txtDelayChange.Text = "0.0";
                txtDelayTrue.Text = "0.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "5.0";
                txtTimeoutFalse.Text = "1.0";
                value9 = 4;
                value10 = 2;
            }
            else if (subType == DI.MON1M_TS)
            {
                myDI.PType = DI.P7131.ToString();
                txtDelayChange.Text = "0.0";
                txtDelayTrue.Text = "1.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "0.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 4;
                value10 = 0;
            }
            else if (subType == DI.MON2PRLSS)
            {
                myDI.PType = DI.P7156.ToString();
                txtDelayChange.Text = "0.0";
                txtDelayTrue.Text = "0.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "1.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 4;
                value10 = 0;
            }
            else if (subType == DI.MON2SS)
            {
                myDI.PType = DI.P7135.ToString();
                txtDelayChange.Text = "0.0";
                txtDelayTrue.Text = "1.0";
                txtDelayFalse.Text = "0.0";
                txtTimeoutTrue.Text = "5.0";
                txtTimeoutFalse.Text = "0.0";
                value9 = 4;
                value10 = 0;
            }
            myDI.DelayChange = AppGlobal.ParseFloat(txtDelayChange.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "1.0";
            myDI.DelayTrue = AppGlobal.ParseFloat(txtDelayTrue.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "1.0";
            myDI.DelayFalse = AppGlobal.ParseFloat(txtDelayFalse.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            myDI.TimeoutTrue = AppGlobal.ParseFloat(txtTimeoutTrue.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "5.0";
            myDI.TimeoutFalse = AppGlobal.ParseFloat(txtTimeoutFalse.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "1.0";
        }
        void GetValue10BitValue(int value)
        {
            chkParLogOff.Checked = AppGlobal.GetBitValue(value, 0);
            chkParPulsing.Checked = AppGlobal.GetBitValue(value, 1);
            chkParFaultRetry.Checked = AppGlobal.GetBitValue(value, 3);
            chkParBinLevel.Checked = AppGlobal.GetBitValue(value, 4);
        }
        void GetValue9BitValue(int value)
        {
            chkInterlockNextObject.Checked = AppGlobal.GetBitValue(value, 0);
            chkInvertInput.Checked = AppGlobal.GetBitValue(value, 1);
            chkMonTrue.Checked = AppGlobal.GetBitValue(value, 2);
            chkMonCovered.Checked = AppGlobal.GetBitValue(value, 12);
            chkMonFalse.Checked = AppGlobal.GetBitValue(value, 3);
            chkMonUnCovered.Checked = AppGlobal.GetBitValue(value, 13);
            chkInPreAlarm.Checked = AppGlobal.GetBitValue(value, 4);
            chKInpFaultDev.Checked = AppGlobal.GetBitValue(value, 6);
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myDI.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SubTypeChanged(myDI.SubType);
                if (myDI.SubType == DI.DIC || myDI.SubType == DI.MON1MVC)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7154.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (myDI.SubType == DI.HLBIN)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7146.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.HLMA)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7165.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.LLBIN)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7145.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.LLMA)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7170.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.MON2BS)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7163.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.MON1MDS)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7167.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.MON1M_LS)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7167.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.MON1MPPS)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7135.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.MON2SS)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7135.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myDI.SubType == DI.MON2SSP)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7159.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }

                GetValue9BitValue(value9);
                GetValue10BitValue(value10);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion <---Rule and autosearch part---> 
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
            BML.DI.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.DI.Path", BML.DI.BMLPath);
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
            AddWorkSheets();
        }
        private void comboWorkSheetsBML_SelectedIndexChanged(object sender, EventArgs e)
        {

            excelFileHandle.WorkSheet = comboWorkSheetsBML.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(excelFileHandle.WorkSheet))
            {
                btnReadBML.Enabled = true;
            }
        }
        private void dataGridBML_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TxtQuantity.Text = dataGridBML.Rows.Count.ToString();
        }
        private void CreateBMLDefault()
        {
            btnReadBML.Enabled = false;
            var alphabetList = AppGlobal.CreateAlphabetList<string>('A', 'Z', letter => letter.ToString());
            foreach (var item in alphabetList)
            {
                comboNameBML.Items.Add(item);
                comboDescBML.Items.Add(item);
                comboTypeBML.Items.Add(item);
                comboFloorBML.Items.Add(item);
                comboSectionBML.Items.Add(item);
                comboCabinetBML.Items.Add(item);
                comboControlBML.Items.Add(item);
                comboIORemarkBML.Items.Add(item);
                comboLineBML.Items.Add(item);
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
                comboControlBML.SelectedItem = "H";
                comboIORemarkBML.SelectedItem = "R";
                comboLineBML.SelectedItem = "X";
            }
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text = BML.DI.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.ColumnName;
            nameColumn.Name = nameof(BML.ColumnName);
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.ColumnDesc;
            descColumn.Name = nameof(BML.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);

            DataGridViewTextBoxColumn diTypeColumn = new DataGridViewTextBoxColumn();
            diTypeColumn.HeaderText = BML.ColumnDIType;
            diTypeColumn.Name = nameof(BML.ColumnDIType);
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

            DataGridViewTextBoxColumn ioRemarkColumn = new DataGridViewTextBoxColumn();
            ioRemarkColumn.HeaderText = BML.ColumnIORemark;
            ioRemarkColumn.Name = nameof(BML.ColumnIORemark);
            dataGridBML.Columns.Add(ioRemarkColumn);

            DataGridViewTextBoxColumn lineColumn = new DataGridViewTextBoxColumn();
            lineColumn.HeaderText = BML.ColumnLine;
            lineColumn.Name = nameof(BML.ColumnLine);
            dataGridBML.Columns.Add(lineColumn);

        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboTypeBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboIORemarkBML.Text,comboLineBML.Text};
            StringBuilder sbFilters = new StringBuilder();
            sbFilters.Append($@"Value LIKE ""%{BML.DI.BeltMonitor}"" || ").Append($@"Value LIKE ""%{BML.DI.EmergencyStop}"" || ").Append($@"Value LIKE ""%{BML.DI.Explosion}"" || ")
                 .Append($@"Value LIKE ""%{BML.DI.HighLevel}"" || ").Append($@"Value LIKE ""%{BML.DI.LimitSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.LowLevel}"" || ")
                 .Append($@"Value LIKE ""%{BML.DI.MiddleLevel}"" || ").Append($@"Value LIKE ""%{BML.DI.Overflow}"" ||").Append($@"Value LIKE ""%{BML.DI.PSw}"" || ")
                 .Append($@"Value LIKE ""%{BML.DI.PushButton}"" || ").Append($@"Value LIKE ""%{BML.DI.SafetySwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.SpeedMonitor}"" || ")
                 .Append($@"Value LIKE ""%{BML.DI.TemperatureSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.VibrationSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.ZeroSpeedMonitor}""");
            StringBuilder sbValveFilters = new StringBuilder();
            sbValveFilters.Append($@"Value NOT LIKE ""%{BML.VLS.ManualFlap}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneFlap}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneTwoWayValve}"" && ")
           .Append($@"Value NOT LIKE ""%{BML.VLS.PneSlideGate}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.ManualSlideGate}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneShutOffValve}"" && ")
           .Append($@"Value NOT LIKE ""%{BML.VLS.PneAspValve}""");
            DataTable dataTable = new DataTable();
            string[] filters = { sbFilters.ToString(), sbValveFilters.ToString() };
            string[] filterColumns = { comboTypeBML.Text, comboDescBML.Text };
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);

            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDIType)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnIORemark)].DataPropertyName = dataTable.Columns[6].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnLine)].DataPropertyName = dataTable.Columns[7].ColumnName;
            TxtQuantity.Text = dataTable.Rows.Count.ToString();
        }
        #endregion
        #region Common used
        private void chkAddSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddSectionToDesc.Checked)
            { chkAddUserSectionToDesc.Checked = false; }
            UpdateDesc();
        }
        private void chkAddUserSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddUserSectionToDesc.Checked)
            { chkAddSectionToDesc.Checked = false; }
            UpdateDesc();
        }
        private void chkAddNameToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }

        private void chkAddFloorToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }

        private void chkNameOnlyNumber_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void chkAddCabinetToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }

        private void chkAddPowerToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void chkNameOnlyNumber_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ComboPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboPanel.Text))
            {
                DI.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DI.Rule.Common.DescFloor = ComboElevation.Text;
            UpdateDesc();
        }
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                txtSymbolRule.Text = DI.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DI.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                // txtSymbol.Text = DEMO_NAME_DI;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = DI.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DI.Rule.Common.NameRuleInc;
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
            DataTable dataTable = null;
            dataGridBML.DataSource = dataTable;

        }
        private void toolStripMenuReload_Click(object sender, EventArgs e)
        {
            btnReadBML_Click(sender, e);
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridBML.SelectedRows)
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
                    bool all = !chkOnlyFree.Checked;
                    string objName = String.Empty;
                    string objSubType = String.Empty;
                    OleDb oledb = new OleDb();
                    DataTable dataTable = new DataTable();
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={DI.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Value11.Name,
                        GcproTable.ObjData.Value13.Name, GcproTable.ObjData.Value19.Name, GcproTable.ObjData.Value14.Name,
                        GcproTable.ObjData.Value47.Name, GcproTable.ObjData.Value42.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    DI.Clear(myDI.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        string inpTrue;
                        inpTrue = objName + txtInpTrueSuffix.Text;
                        if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                        {
                            DI.CreateRelation(objName, inpTrue, GcproTable.ObjData.Value11.Name, myDI.FileConnectorPath, Encoding.Unicode);
                        }

                        if (!String.IsNullOrEmpty(txtInHWStop.Text))
                        {
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value47.Name) == 0 || all)
                            {
                                string InHWStop = objName + txtInHWStop.Text; ;
                                DI.CreateRelation(objName, InHWStop, GcproTable.ObjData.Value47.Name, myDI.FileConnectorPath, Encoding.Unicode);
                            }
                        }

                        if (!String.IsNullOrEmpty(txtOutpLamp.Text))
                        {

                        }
                        ProgressBar.Value = count;
                    }
                    DI.SaveFileAs(myDI.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
                    dataTable.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("寻找IO与关联过程出错:" + ex, AppGlobal.INFO + ":" + AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_CLEAR_FILE, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)

            {
                myDI.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            DI.SaveFileAs(myDI.FilePath, LibGlobalSource.CREATE_OBJECT);
            DI.SaveFileAs(myDI.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
                DI.ReGenerateDPNode(oledb);
            }
        }
    
        public void CreateObjectCommon(DI objDI)
        {
            OleDb oledb = new OleDb();
            oledb.DataSource = AppGlobal.GcproDBInfo.GcsLibaryPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            DataTable dataTable = new DataTable();
            #region Prepare export DI file
            ///<OType>is set when object generated</OType>
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                objDI.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                objDI.SubType = DI.DIC;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (ComboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                objDI.PType = selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            else
            {
                objDI.PType = DI.P7154.ToString();
            }
            ///<DelayChange</DelayChange>
            objDI.DelayChange = AppGlobal.ParseFloat(txtDelayChange.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "20.0";
            ///<DelayTrue></DelayTrue>
            objDI.DelayTrue = AppGlobal.ParseFloat(txtDelayTrue.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            ///<DelayFalse></DelayFalse>
            objDI.DelayFalse = AppGlobal.ParseFloat(txtDelayFalse.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            ///<TimeoutTrue></TimeoutTrue>
            objDI.TimeoutTrue = AppGlobal.ParseFloat(txtTimeoutTrue.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            ///<TimeoutFalse></TimeoutFalse>
            objDI.TimeoutFalse = AppGlobal.ParseFloat(txtTimeoutFalse.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            ///<Value9>Value is set when corresponding check box's check state changed</Value9>
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            objDI.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                objDI.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objDI.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }

            ///<Page></Page>
            objDI.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objDI.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objDI.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objDI.Panel_ID = selectedPanel_ID;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            objDI.FieldBusNode = LibGlobalSource.NOCHILD; ;
            ///<DPNode1></DPNode1>
            string selectDPNode1 = String.Empty;
            if (ComboDPNode1.SelectedItem != null)
            {
                selectDPNode1 = ComboDPNode1.SelectedItem.ToString();
                oledb.IsNewOLEDBDriver = isNewOledbDriver;
                oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                objDI.DPNode1 = DI.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, selectDPNode1);

                if (String.IsNullOrEmpty(objDI.DPNode1))
                { objDI.FieldBusNode = string.Empty; }
                else
                {
                    objDI.FieldBusNode = MDDx.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, int.Parse(objDI.DPNode1));
                }
            }
            if (ComboHornCode.SelectedItem != null)
            {
                string hornCode = ComboHornCode.SelectedItem.ToString();
                objDI.HornCode = hornCode.Substring(0, 2);
            }
            ///<InpTrue></InpTrue>
            objDI.InpTrue = LibGlobalSource.NOCHILD;
            ///<InpFaultDev></InpFaultDev>
            objDI.InpFaultDev = LibGlobalSource.NOCHILD;
            ///<InHWStop></InHWStop>
            objDI.InHWStop = LibGlobalSource.NOCHILD;
            ///<OutpFaultReset ></OutpFaultReset >
            objDI.OutpFaultReset = LibGlobalSource.NOCHILD;
            ///<OutpLamp></OutpLamp>
            objDI.OutpLamp = string.Empty;
            ///<OutpPowerOff ></OutpPowerOff >
            objDI.OutpPowerOff = string.Empty;
            #endregion
        }
        public void CreateObjectBML(DataGridView dataFromBML, DI objDI,
            (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
            out (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb();
            oledb.DataSource = AppGlobal.GcproDBInfo.GcsLibaryPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            DataTable dataTable = new DataTable();
            #region common used variables declaration       
            StringBuilder descToBuilder = new StringBuilder();
            int quantityNeedToBeCreate = dataFromBML.Rows.Count;
            #endregion
            #region Prepare export DI file     
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objDI.Building = selectedBudling;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            objDI.FieldBusNode = LibGlobalSource.NOCHILD; ;
            if (ComboHornCode.SelectedItem != null)
            {
                string hornCode = ComboHornCode.SelectedItem.ToString();
                objDI.HornCode = hornCode.Substring(0, 2);
            }
            #endregion
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            SuffixObject suffixObject = new SuffixObject();
            string cabinet, cabinetGroup;
            string stringNumber = string.Empty;
            string remark;
            objDefaultInfo = DI.Rule.Common;
            Bin _bin = new Bin(AppGlobal.GcproDBInfo.GcproTempPath);
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                DataGridViewCell cell;
                cell = dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                { continue; }
                string _subType = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDIType)].Value);
                string desc = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value);

                if (_subType == BML.DI.SpeedMonitor && desc == BML.MachineType.Elevator)
                { continue; }
                objDI.Name = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)].Value);
                ///<AdditionInfoToDesc></AdditionInfoToDesc>   
                descToBuilder.Clear();
                string ioRemark = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnIORemark)].Value);

                if (!(myDI.Name.Contains(suffixObject.GetKey("BLH")) || objDI.Name.Contains(suffixObject.GetKey("BLL"))))
                {
                    descToBuilder.Append(desc);
                }

                if (addtionToDesc.Section)
                {
                    stringNumber = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, objDI.Name);
                    if (!string.IsNullOrEmpty(stringNumber))
                    {
                        if (AppGlobal.ParseInt(stringNumber.Substring(0, 4), out tempInt))
                        {
                            DI.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.UserDefSection)
                {
                    DI.Rule.Common.DescLine = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value); ;
                }

                objDI.InpTrue = $"{objDI.Name}{GcObjectInfo.DI.SuffixInpTrue}";    
                cabinet = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                cabinetGroup = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value);
                objDI.Panel_ID = cabinet.StartsWith(BML.PrefixLocalPanel) ? cabinet : cabinetGroup + cabinet;
                objDI.Elevation = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);

                #region Subtype and PType           
                if (myDI.Name.Contains(suffixObject.GetKey("BZA")))
                {
                    objDI.SubType = DI.MON2BS;
                    objDI.Value9 = "4";
                    objDI.Value10 = "0";
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["BZA"]}");
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("SHE")))
                {
                    objDI.SubType = DI.MON1MVC;
                    objDI.Value9 = "4";
                    objDI.Value10 = "0";
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("FYX")))
                {
                    objDI.SubType = DI.MON1M_LS;
                    objDI.Value9 = "5";
                    objDI.Value10 = "0";
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["FYX"]}");
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("BZS")))
                {
                    objDI.SubType = DI.MON1M_LS;
                    objDI.Value9 = "5";
                    objDI.Value10 = "0";
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["BZS"]}");
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("QYS")))
                {
                    objDI.SubType = DI.MON1M_LS;
                    objDI.Value9 = "5";
                    objDI.Value10 = "0";
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["QYS"]}");
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("BLH")))
                {
                    objDI.SubType = DI.HLBIN;
                    objDI.Value9 = "2";
                    objDI.Value10 = "16";
                    remark = BML.DI.ParseIORemark(ioRemark);
                    if (!string.IsNullOrEmpty(remark))
                    {
                        stringNumber = LibGlobalSource.StringHelper.ExtractNumericPart(remark, false);
                        if (AppGlobal.ParseInt(stringNumber, out tempInt))
                        {
                            descToBuilder.Append($"{stringNumber}号{GcObjectInfo.Bin.ReturnBin(tempInt)}");

                        }
                        Bin.CreateRelation(remark, objDI.Name, GcproTable.ObjData.Value2.Name, _bin.FileRelationPath, Encoding.Unicode);
                    }
                    else
                    {
                        descToBuilder.Append(ioRemark);
                    }
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["BLH"]}");
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("BLL")) || _subType == BML.DI.MiddleLevel)
                {
                    objDI.SubType = DI.LLBIN;
                    objDI.Value9 = "4098";
                    objDI.Value10 = "16";
                    remark = BML.DI.ParseIORemark(ioRemark);
                    if (!string.IsNullOrEmpty(remark))
                    {
                        stringNumber = LibGlobalSource.StringHelper.ExtractNumericPart(remark, false);
                        if (AppGlobal.ParseInt(stringNumber, out tempInt))
                        {
                            descToBuilder.Append($"{stringNumber}号{GcObjectInfo.Bin.ReturnBin(tempInt)}");
                        }

                        Bin.CreateRelation(remark, objDI.Name, GcproTable.ObjData.Value3.Name, _bin.FileRelationPath, Encoding.Unicode);
                    }
                    else
                    {
                        descToBuilder.Append(ioRemark);
                    }
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["BLL"]}");
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("BQS")))
                {
                    objDI.SubType = DI.HLMA;
                    objDI.Value9 = "8195";
                    objDI.Value10 = "0";
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["BQS"]}");
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("BPS")))
                {
                    objDI.SubType = DI.MON1MPH;
                    objDI.Value9 = "5";
                    objDI.Value10 = "0";
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["BPS"]}");
                }
                else if (_subType == BML.DI.PushButton)
                {
                    objDI.SubType = DI.DIC;
                    objDI.Value9 = "0";
                    objDI.Value10 = "0";
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("BST")))
                {
                    objDI.SubType = DI.MON2SSP;

                    objDI.Value9 = "4";
                    objDI.Value10 = "2";
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["BST"]}");
                }
                else if (_subType == BML.DI.TemperatureSwitch)
                {
                    objDI.SubType = DI.MON1M_TS;
                    objDI.PType = DI.P7131.ToString();
                    objDI.Value9 = "4";
                    objDI.Value10 = "0";
                }
                else if (_subType == BML.DI.VibrationSwitch)
                {
                    objDI.SubType = DI.DIC;
                    objDI.Value9 = "5";
                    objDI.Value10 = "0";
                }
                else if (myDI.Name.Contains(suffixObject.GetKey("BSA")))
                {
                    objDI.SubType = DI.MON2SS;
                    objDI.Value9 = "4";
                    objDI.Value10 = "0";
                    descToBuilder.Append($"{suffixObject.SuffixObjectType["BSA"]}");
                }
                SubTypeChanged(myDI.SubType);
                #endregion
                desc = descToBuilder.ToString();
                DI.Rule.Common.Name = objDI.Name;
                DI.Rule.Common.DescFloor = $"{objDI.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                DI.Rule.Common.DescObject = desc;
                DI.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{objDI.Panel_ID}";
                objDI.Description = DI.EncodingDesc(
                    baseRule: ref DI.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
                objDI.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            DI.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
        private void CreateObjectRule(DI objDI, (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
         ref (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb();
            oledb.DataSource = AppGlobal.GcproDBInfo.GcsLibaryPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            DataTable dataTable = new DataTable();
            #region common used variables declaration       
            bool needDPNodeChanged = false;
            StringBuilder descToBuilder = new StringBuilder();
            int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            processValue.Max = quantityNeedToBeCreate;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
            objDefaultInfo = DI.Rule.Common;
            string desc = string.Empty;
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
            ///<NameRule>生成名称规则</NameRule>
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

            string selectedDPNode1Item = string.Empty;
            if (ComboDPNode1.SelectedItem != null)
            {

                selectedDPNode1Item = ComboDPNode1.SelectedItem.ToString();
            }
            else
            {
                needDPNodeChanged = false;
            }
            if (needDPNodeChanged)
            {
                dpNode1.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(selectedDPNode1Item, txtSymbolRule.Text);
                if (dpNode1.PosInfo.Len == -1)
                {
                    AppGlobal.RuleNotSetCorrect($"{GrpSymbolRule.Text}.{LblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
                else
                {
                    dpNode1.Name = selectedDPNode1Item;
                    dpNode1.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(dpNode1.Name, txtSymbolRule.Text);
                }
            }
            else
            {
                dpNode1.Name = string.Empty;
            }
            ///<DescRule>生成描述规则</DescRule>
            desc = DI.Rule.Common.DescObject;
            if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
            {
                description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(desc, txtDescriptionRule.Text);
                if (description.PosInfo.Len == -1)
                {
                    if (moreThanOne)
                    {
                        AppGlobal.RuleNotSetCorrect($"{GrpDescriptionRule.Text}.{LblDescriptionRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    }
                }
                else
                {
                    description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(desc, txtDescriptionRule.Text);
                }
            }
            #endregion

            processValue.Value = 0;
            ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
            int symbolInc, symbolRule, descriptionInc;
            tempBool = AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
            tempBool = AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
            tempBool = AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));

                if (needDPNodeChanged && moreThanOne)
                {
                    dpNode1.Inc = i * symbolInc;
                    dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());
                    objDI.DPNode1 = DI.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, dpNode1.Name);

                    if (String.IsNullOrEmpty(objDI.DPNode1))
                    { objDI.FieldBusNode = string.Empty; }
                    else
                    {
                        objDI.FieldBusNode = MDDx.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                        {
                            return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                        }, int.Parse(objDI.DPNode1));
                    }
                }

                if (!String.IsNullOrEmpty(desc))
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
                        description.Name = desc;
                    }

                }
                else
                {
                    description.Name = "--";
                }
                objDI.Name = name.Name;
                objDI.InpTrue = $"{name.Name}{GcObjectInfo.DI.SuffixInpTrue}"; 
                DI.Rule.Common.Name = name.Name;
                DI.Rule.Common.DescObject = description.Name;
                //  DI.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{objDI.Panel_ID}";
                objDI.Description = DI.EncodingDesc(
                    baseRule: ref DI.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );

                objDI.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
            DI.Rule.Common = objDefaultInfo;
        }
        private void CreateObjectAutoSearch(DI objDI, ref (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb();
            oledb.DataSource = AppGlobal.GcproDBInfo.GcsLibaryPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            DataTable dataTable = new DataTable();
            List<string> objList = new List<string>();
            // List<int> objOutpKeyList = new List<int>();
            List<string> objInpKeyList = new List<string>();
            string filter = $@"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.DIC} AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER}";
            filter = string.IsNullOrEmpty(txtSymbol.Text) ? filter : $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, null, GcproTable.ObjData.Key.Name, GcproTable.ObjData.Text0.Name);

            // objInpKeyList = OleDb.GetColumnData<int>(dataTable, GcproTable.ObjData.Key.Name);
            objInpKeyList = OleDb.GetColumnData<string>(dataTable, GcproTable.ObjData.Text0.Name);
            int quantityNeedToBeCreate = objInpKeyList.Count;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                //objList[i] = objDI.GetObjectSymbolFromIO(objInpKeyList[i], GcObjectInfo.General.SuffixIO.Delimiter);
                objList.Add(GcObject.GetObjectSymbolFromIO(objInpKeyList[i], GcObjectInfo.General.SuffixIO.Delimiter));
            }

            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;

            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                myDI.Name = objList[i];
                myDI.InpTrue = objInpKeyList[i];
                myDI.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myDI.Elevation = ComboElevation.Text;
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet = chkAddCabinetToDesc.Checked;
                AppGlobal.AdditionDesc.Power = false;
                AppGlobal.AdditionDesc.OnlyNumber = chkNameOnlyNumber.Checked;
                AppGlobal.ProcessValue.Value = ProgressBar.Value = 0;

                CreateObjectCommon(myDI);
                if (createMode.BML)
                {
                    CreateObjectBML(
                         dataFromBML: dataGridBML,
                         objDI: myDI,
                         addtionToDesc: AppGlobal.AdditionDesc,
                         processValue: out AppGlobal.ProcessValue
                         );
                }
                else if (createMode.AutoSearch)
                {
                    CreateObjectAutoSearch(
                         objDI: myDI,
                         processValue: ref AppGlobal.ProcessValue
                         );
                }
                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreateObjectRule(
                        objDI: myDI,
                        addtionToDesc: AppGlobal.AdditionDesc,
                        processValue: ref AppGlobal.ProcessValue
                        );
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
