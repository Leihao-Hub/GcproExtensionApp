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
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;
using OfficeOpenXml.Drawing.Slicer.Style;
using System.Net.NetworkInformation;
#endregion
namespace GcproExtensionApp
{
   // #pragma warning disable IDE1006
    public partial class FormAI : Form, IGcForm
    {

        public FormAI()
        {
            InitializeComponent();
        }

        #region Public object in this class
        readonly AI myAI = new AI(AppGlobal.GcproDBInfo.GcproTempPath);
        readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        readonly CreateMode createMode = new CreateMode();

        private bool isNewOledbDriver;
        private readonly string DEMO_NAME_AI = "=A-4020-MXZ01AI";
        private readonly string DEMO_NAME_RULE_AI = "4020";
        private readonly string DEMO_DESCRIPTION_AI = "制粉A线2楼(4020)磨粉机电流/或者空白";
        private readonly string DEMO_DESCRIPTION_RULE_AI = "4020/或者空白";
        private readonly string MSG_CREATE_TEMP_AND_PRE_VIA_FILTER = "搜寻数据库中除尘器并创建温度与压差";
        private readonly string aiBMLSuffix = $"{AppGlobal.JS_BML}.{AppGlobal.JS_AI}.";
        private readonly string aiSuffix = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_AI}.{AppGlobal.JS_SUFFIX}.";
        #endregion
        private int value9 = 32;
        private int value10 = 32;
        private int tempInt = 0;
        //  private long tempLong = 0;
        private float tempFloat = 0.0f;
     //   private bool tempBool;
        private GcBaseRule objDefaultInfo;
        #region Public interfaces
        public void GetInfoFromDatabase()
        {
            string itemInfo;
            List<string> list;
            DataTable dataTable ;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.GcsLibaryPath, isNewOledbDriver);      
            ///<ReadInfoFromGcsLibrary> 
            ///Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary 
            ///</ReadInfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={AI.OTypeValue}",
                null, $"{GcproTable.SubType.FieldSub_Type_Desc.Name} ASC",
                GcproTable.SubType.FieldSubType.Name, GcproTable.SubType.FieldSub_Type_Desc.Name);
            // List<string> list = OleDb.GetColumnData<string>(dataTable, "SubType");

            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.SubType.TableName) + AppGlobal.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>($"{GcproTable.SubType.FieldSub_Type_Desc.Name}");
                ComboEquipmentSubType.Items.Add(itemInfo);

            }

            ComboEquipmentSubType.SelectedIndex = 1;
            ///<Unit>Read [unit] </Unit>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_UnitCfg}%'",
                null, $"{GcproTable.TranslationCbo.FieldValue.Name} ASC",
                GcproTable.TranslationCbo.FieldValue.Name, GcproTable.TranslationCbo.FieldText.Name);
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {

                itemInfo = dataTable.Rows[count].Field<double>(GcproTable.TranslationCbo.FieldValue.Name) + AppGlobal.FIELDS_SEPARATOR +
                      dataTable.Rows[count].Field<string>(GcproTable.TranslationCbo.FieldText.Name);
                comboUnit.Items.Add(itemInfo);
            }
            comboUnit.SelectedIndex = 0;
            ///<ProcessFct> Read [ProcessFct] </ProcessFct>
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {AI.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + AI.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboEquipmentInfoType.Items.Add(column.ToString());
            }
            ComboEquipmentInfoType.SelectedIndex = 15;
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
            objDefaultInfo.NameRule = "4020";
            objDefaultInfo.DescLine = "制粉A线";
            objDefaultInfo.DescFloor = "2楼";
            objDefaultInfo.Name = "=A-4020-MXZ01AI";
            objDefaultInfo.DescObject = "磨粉机电流";
            AI.Rule.Common.Cabinet = AI.Rule.Common.Power = string.Empty;
            objDefaultInfo.Description = AI.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix: GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: chkAddCabinetToDesc.Checked,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);

            if (String.IsNullOrEmpty(AI.Rule.Common.Description))
            { AI.Rule.Common.Description = objDefaultInfo.Description; }

            if (String.IsNullOrEmpty(AI.Rule.Common.Name))
            { AI.Rule.Common.Name = objDefaultInfo.Name; }

            if (String.IsNullOrEmpty(AI.Rule.Common.DescLine))
            { AI.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (String.IsNullOrEmpty(AI.Rule.Common.DescFloor))
            { AI.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (String.IsNullOrEmpty(AI.Rule.Common.DescObject))
            { AI.Rule.Common.DescObject = objDefaultInfo.DescObject; }

            txtSymbolRule.Text = AI.Rule.Common.NameRule;
            txtSymbolIncRule.Text = AI.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = AI.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = AI.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = AI.Rule.Common.Name;
            txtDescription.Text = AI.Rule.Common.Description;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + AI.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_AI);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_AI);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_AI);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_AI);
            toolTip.SetToolTip(chkUpdateUnitsByMaxDigits, AppGlobal.UPDATE_AI_UNITSMAXDIGITS);
            toolTip.SetToolTip(BtnRegenerateDPNode, AppGlobal.MSG_REGENERATE_DPNODE);
            toolTip.SetToolTip(btnCreateTempAndPre, MSG_CREATE_TEMP_AND_PRE_VIA_FILTER);
        }
        public void CreateImpExp()
        {
            DataTable dataTable ;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{AI.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{AI.ImpExpRuleName}'", null);
                    CreateAIImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateAIImpExp(oledb);
            }

        }
        public void Default()
        {
            txtSymbol.Focus();
            txtInpValeSuffix.Text = GcObjectInfo.AI.SuffixInpValue;
            txtInpFaultDevSuffix.Text = GcObjectInfo.AI.SuffixInpFaultDev;
            txtSuffixInpLowLow.Text = GcObjectInfo.AI.SuffixInpLowLow;
            txtSuffixInpLow.Text = GcObjectInfo.AI.SuffixInpLow;
            txtSuffixInpHigh.Text = GcObjectInfo.AI.SuffixInpHigh;
            txtSuffixInpHighHigh.Text = GcObjectInfo.AI.SuffixInpHighHigh;
           // txtInpValue.Text = txtSymbol.Text + txtInpValeSuffix.Text;
            txtSymbolIncRule.Text = AI.Rule.Common.NameRuleInc;
            txtDescriptionIncRule.Text = AI.Rule.Common.DescriptionRuleInc;
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            //txtDelayTimeUp.Text = myAI.DelayTimeUp;
            //txtDelayTimeDown.Text = myAI.DelayTimeDown;
            //txtDelayTimeFault.Text = myAI.DelayFaultTime;
            //txtMonTimeLowLow.Text = myAI.MonTimeLowLow;
            //txtMonTimeLow.Text = myAI.MonTimeLowLow;
            //txtMonTimeMiddle.Text = myAI.MonTimeMiddle;
            //txtMonTimeHigh.Text = myAI.MonTimeHigh;
            //txtMonTimeHighHigh.Text = myAI.MonTimeHighHigh;
            txtValue9.Text = myAI.Value10.ToString();
            txtValue10.Text = myAI.Value9.ToString();
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(ToolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(ToolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(ToolStripMenuDelete_Click);
            this.Text = "AI导入文件 " + " " + myAI.FilePath;
        }

        #endregion
        private void CreateAIImpExp(OleDb oledb)
        {

            bool result = myAI.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormAI_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormAI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->
        #region <------Check and store rule event------>
        private void TxtInpValueSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpValeSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{aiSuffix}InpValue", newJsonKeyValue);
                GcObjectInfo.AI.SuffixInpValue = newJsonKeyValue;
            }
        }
        private void TxtSuffixInpLowLow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtSuffixInpLowLow.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{aiSuffix}InpLowLow", newJsonKeyValue);
                GcObjectInfo.AI.SuffixInpValue = newJsonKeyValue;
            }
        }

        private void TxtSuffixInpLow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtSuffixInpLow.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{aiSuffix}InpLow", newJsonKeyValue);
                GcObjectInfo.AI.SuffixInpValue = newJsonKeyValue;
            }
        }

        private void TxtSuffixInpHigh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtSuffixInpHigh.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{aiSuffix}InpHigh", newJsonKeyValue);
                GcObjectInfo.AI.SuffixInpValue = newJsonKeyValue;
            }
        }

        private void TxtSuffixInpHighHigh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtSuffixInpHighHigh.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{aiSuffix}InpHighHigh", newJsonKeyValue);
                GcObjectInfo.AI.SuffixInpValue = newJsonKeyValue;
            }
        }
        private void TxtInpFaultDevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpFaultDevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{aiSuffix}InpFaultDev", newJsonKeyValue);
                GcObjectInfo.AI.SuffixInpFaultDev = newJsonKeyValue;
            }
        }
        private void TxtInpFaultDevSuffix_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSuffixInpHighHigh_TextChanged(object sender, EventArgs e)
        {
            txtInpHighHigh.Text = txtSymbol.Text + txtSuffixInpHighHigh.Text;
        }

        private void TxtSuffixInpHigh_TextChanged(object sender, EventArgs e)
        {
            txtInpHigh.Text = txtSymbol.Text + txtSuffixInpHigh.Text;
        }

        private void TxtSuffixInpLow_TextChanged(object sender, EventArgs e)
        {
            txtInpLow.Text = txtSymbol.Text + txtSuffixInpLow.Text;
        }

        private void TxtSuffixInpLowLow_TextChanged(object sender, EventArgs e)
        {
            txtInpLowLow.Text = txtSymbol.Text + txtSuffixInpLowLow.Text;
        }
        private void TxtInpTrueSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpValue.Text = txtSymbol.Text + txtInpValeSuffix.Text;
        }

        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSymbolRule.Text))
            { return; }
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                AI.Rule.Common.NameRule = txtSymbolRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        private void TxtSymbolIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (AppGlobal.CheckNumericString(txtSymbolIncRule.Text))
                {
                    AI.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
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
                string descObjectNumber = LibGlobalSource.StringHelper.ExtractNumericPart(AI.Rule.Common.DescObject, false);
                if (!string.IsNullOrEmpty(descObjectNumber))
                {
                    AI.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                    AI.Rule.Common.DescObject =AI.Rule.Common.DescObject.Replace(descObjectNumber, AI.Rule.Common.DescriptionRule);
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
                    AI.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }

        private void TxtValue10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value10 = AppGlobal.ParseValue<int>(txtValue10.Text, out tempInt) ? tempInt : value10;
                GetValue10BitValue(value10);
            }
        }

        private void TxtValue9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value9 = AppGlobal.ParseValue<int>(txtValue9.Text, out tempInt) ? tempInt : value9;
                GetValue10BitValue(value9);
            }
        }
        #endregion
        #region <------Check and unchek "Value9" and "Value10------>"    

        private void ChkInterlocking_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkInterlocking.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)0); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)0); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }

        private void ChkMonNotLowLow_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonNotLowLow.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)1); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)1); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }

        private void ChkMonNotLow_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonNotLow.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)2); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)2); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }

        private void ChkMonNotMiddle_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonNotMiddle.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)3); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)3); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }

        private void ChkMonNotHigh_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonNotHigh.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)4); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)4); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }

        private void ChkMonNotHighHigh_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkMonNotHighHigh.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)5); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)5); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }

        private void ChkInDisable_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkInDisable.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)6); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)6); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }

        private void ChkWinCC_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkWinCC.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)7); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)7); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }
        private void ChkOutValueUnits_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkOutValueUnits.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)16); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)16); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }

        private void ChkOutValueRel_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkOutValueRel.Checked)

            { AppGlobal.SetBit<int>(ref value9, (byte)17); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)17); }

            myAI.Value9 = value9;
            txtValue9.Text = myAI.Value9.ToString();
        }
        private void ChkParLogOff_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParLogOff.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)0); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)0); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value9.ToString();
        }

        private void ChkParLimitsRel_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParLimitsRel.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)3); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)3); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParNoHornByWarning_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParNoHornByWarning.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)5); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)5); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }
        private void ChkParWarningLowLow_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWarningLowLow.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)6); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)6); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParWarningLow_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWarningLow.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)7); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)7); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParWarningMiddle_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWarningMiddle.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)8); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)8); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParWarningHigh_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWarningHigh.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)9); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)9); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParWarningHighHigh_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWarningHighHigh.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)10); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)10); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParPreAlarmLowLow_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPreAlarmLowLow.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)11); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)11); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParPreAlarmLow_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPreAlarmLow.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)12); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)12); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParPreAlarmMiddle_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPreAlarmMiddle.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)13); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)13); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParPreAlarmHigh_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPreAlarmHigh.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)14); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)14); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
        }

        private void ChkParPreAlarmHighHigh_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPreAlarmHighHigh.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)15); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)15); }

            myAI.Value10 = value10;
            txtValue10.Text = myAI.Value10.ToString();
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
        private void TxtInpValue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
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

        private void TxtInpFaultDev_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value19";
        }

        private void TxtInHWStop_MouseDown(object sender, MouseEventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value47";
        }

        private void TxtInpLowLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }

        private void TxtInpLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value13";
        }

        private void TxtInpHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value14";
        }

        private void TxtInpHighHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value15";
        }

        private void TxtUnitsBy100_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }

        private void TxtOffsetUnits_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value41";
        }

        private void TxtDelayTimeDown_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value33";
        }

        private void TxtDelayTimeUp_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value34";
        }

        private void TxtDelayTimeFault_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value35";
        }

        private void TxtParLimitLowLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }

        private void TxtParLimitLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }

        private void TxtParLimitHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }

        private void TxtParLimitHighHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value27";
        }

        private void ComboUnit_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value38";
        }

        private void ChkParLogOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit0";
        }

        private void ChkParLimitsRel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit3";
        }

        private void ChkParNoHornByWarning_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit5";
        }

        private void ChkParWarningLowLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit6";
        }

        private void ChkParWarningLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit7";
        }

        private void ChkParWarningMiddle_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit8";
        }

        private void ChkParWarningHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit9";
        }

        private void ChkParWarningHighHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit10";
        }

        private void ChkParPreAlarmLowLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit11";
        }

        private void ChkParPreAlarmLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit12";
        }

        private void ChkParPreAlarmMiddle_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit13";
        }

        private void ChkParPreAlarmHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit14";
        }

        private void ChkParPreAlarmHighHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit15";
        }

        private void ChkInterlocking_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit0";
        }

        private void ChkMonNotLowLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit1";
        }

        private void ChkMonNotLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit2";
        }

        private void ChkMonNotMiddle_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit3";
        }

        private void ChkMonNotHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit4";
        }

        private void ChkMonNotHighHigh_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit5";
        }

        private void ChkInDisable_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit6";
        }

        private void ChkWinCC_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit7";
        }

        private void ChkOutValueUnits_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit16";
        }

        private void ChkOutValueRel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit17";
        }

        #endregion
        private void UpdateDesc()
        {
            AI.Rule.Common.Description = AI.EncodingDesc(
            baseRule: ref AI.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: chkAddCabinetToDesc.Checked,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = AI.Rule.Common.Description;
        }
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            txtInpValue.Text = (txtSymbol.Text.Contains(GcObjectInfo.AI.SuffixName) ? txtSymbol.Text.Replace(GcObjectInfo.AI.SuffixName, string.Empty) : txtSymbol.Text)
                + txtInpValeSuffix.Text;
            myAI.Name = txtSymbol.Text;
            AI.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
        }
        private void TxtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value27.Name,
                OType = Convert.ToString(AI.OTypeValue)
            };
            objectBrowser.Show();
        }
        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {   
            if (!AI.Rule.Common.Description.Equals(txtDescription.Text))
            {
                AI.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(AI.Rule.Common.DescObject, false);
            if (!txtDescription.Text.Contains(txtDescriptionRule.Text))
            { txtDescription.BackColor = Color.Red; }
            else
            { txtDescription.BackColor = Color.White; }
        }

        private void TxtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AI.Rule.Common.Description = txtDescription.Text;
                AI.DecodingDesc(ref AI.Rule.Common, AppGlobal.DESC_SEPARATOR);                
                UpdateDesc();
            }
        }
        void SubTypeChanged(string subType)
        {
            if (subType == AI.AIT)
            {
                //myAI.PType = AI.P7163;
                //myAI.DelayChange =txtDelayChange.Text= "0.0";
                //myAI.DelayTrue =txtDelayTrue.Text= "10.0";
                //myAI.DelayFalse = txtDelayFalse.Text="0.0";
                //myAI.TimeoutTrue = txtTimeoutTrue.Text= "50.0";
                //myAI.TimeoutFalse =txtTimeoutFalse.Text= "0.0";
                //value9 = 4;
                //value10 = 0;
            }

        }
        void GetValue10BitValue(int value)
        {
            chkParLogOff.Checked = AppGlobal. GetBit<int>(value, 0);
            chkParLimitsRel.Checked = AppGlobal. GetBit<int>(value, 3);
            chkParNoHornByWarning.Checked = AppGlobal. GetBit<int>(value, 5);
            chkParWarningLowLow.Checked = AppGlobal. GetBit<int>(value, 6);
            chkParWarningLow.Checked = AppGlobal. GetBit<int>(value, 7);
            chkParWarningMiddle.Checked = AppGlobal. GetBit<int>(value, 8);
            chkParWarningHigh.Checked = AppGlobal. GetBit<int>(value, 9);
            chkParWarningHighHigh.Checked = AppGlobal. GetBit<int>(value, 10);
            chkParPreAlarmLowLow.Checked = AppGlobal. GetBit<int>(value, 11);
            chkParPreAlarmLow.Checked = AppGlobal. GetBit<int>(value, 12);
            chkParPreAlarmMiddle.Checked = AppGlobal. GetBit<int>(value, 13);
            chkParPreAlarmHigh.Checked = AppGlobal. GetBit<int>(value, 14);
            chkParPreAlarmHighHigh.Checked = AppGlobal. GetBit<int>(value, 15);
        }
        void GetValue9BitValue(int value)
        {
            chkInterlocking.Checked = AppGlobal. GetBit<int>(value, 0);
            chkMonNotLowLow.Checked = AppGlobal. GetBit<int>(value, 1);
            chkMonNotLow.Checked = AppGlobal. GetBit<int>(value, 2);
            chkMonNotMiddle.Checked = AppGlobal. GetBit<int>(value, 3);
            chkMonNotHigh.Checked = AppGlobal. GetBit<int>(value, 4);
            chkMonNotHighHigh.Checked = AppGlobal. GetBit<int>(value, 5);
            chkInDisable.Checked = AppGlobal. GetBit<int>(value, 6);
            chkWinCC.Checked = AppGlobal. GetBit<int>(value, 7);
            chkOutValueUnits.Checked = AppGlobal. GetBit<int>(value, 16);
            chkOutValueRel.Checked = AppGlobal. GetBit<int>(value, 17);
        }
        private void BtnCreateTempAndPre_Click(object sender, EventArgs e)
        {
            DataTable dataTable ;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.SubType.Name} = 'DOCFilter'",
                null, $"{GcproTable.ObjData.Text0.Name} ASC",
                GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name, GcproTable.ObjData.Panel_ID.Name, GcproTable.ObjData.Elevation.Name);
            ProgressBar.Maximum= dataTable.Rows.Count-1;
            ///<Building></Building>
            string selectedBudling ;
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                myAI.Building = selectedBudling;
            }
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                string nameFilterController , desc ;
                nameFilterController = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                desc = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text1.Name);
                myAI.Panel_ID = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Panel_ID.Name);
                myAI.Elevation = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Elevation.Name);
                
                if (chkAddSectionToDesc.Checked)
                {
                    string nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, nameFilterController);
                    if (!string.IsNullOrEmpty(nameNumberString))
                    {
                        if (AppGlobal.ParseValue<int>(nameNumberString, out tempInt))
                        {
                            AI.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                    else
                    {
                        AI.Rule.Common.DescLine = string.Empty;
                    }
                }                                
                ///<CreateTemperature>Create temperature </CreateTemperature>
                CreateTempAndPreForFilter(myAI, nameFilterController, desc, AppGlobal.AdditionDesc, true);
                ///<CreatePressure >Create pressure </CreatePressure >
                CreateTempAndPreForFilter(myAI, nameFilterController, desc, AppGlobal.AdditionDesc, false);
                ProgressBar.Value = count;
            }
       
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myAI.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SubTypeChanged(myAI.SubType);
                if (myAI.SubType == AI.AIT)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(AI.P7252.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (myAI.SubType == AI.AIMF)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(AI.P7400.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myAI.SubType == AI.AIMT)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(AI.P7407.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myAI.SubType == AI.AIWT)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(AI.P7420.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myAI.SubType == AI.AIDI)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(AI.P7252.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }

                GetValue9BitValue(value9);
                GetValue10BitValue(value10);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message + "错误源:ComboEquipmentSubType_SelectedIndexChanged", AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region <---BML part--->
        private void AddWorkSheets()
        { 
            try
            {
                List<string> workSheets = new List<string>();
                workSheets = excelFileHandle.GetWorkSheets();                                             
                comboWorkSheetsBML.Items.Clear();
                foreach (string sheet in workSheets)
                {
                     comboWorkSheetsBML.Items.Add(sheet);
                }
                if (comboWorkSheetsBML.Items.Count > 0)
                { comboWorkSheetsBML.SelectedIndex = 0; }
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
            BML.AI.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{aiBMLSuffix}Path", BML.AI.BMLPath);
        }
        private void ComboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
           // AddWorkSheets();
        }
        private void ComboWorkSheetsBML_SelectedIndexChanged(object sender, EventArgs e)
        {

            excelFileHandle.WorkSheet = comboWorkSheetsBML.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(excelFileHandle.WorkSheet))
            {
                btnReadBML.Enabled = true;
            }
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
                comboPowerBML.Items.Add(item);
                comboLineBML.Items.Add(item);
             
            }
            comboNameBML.SelectedItem = "B";
            comboDescBML.SelectedItem = "N";
            comboPowerBML.SelectedItem = "E";
            comboTypeBML.SelectedItem = "C";
            comboFloorBML.SelectedItem = "L";
            comboCabinetBML.SelectedItem = "P";
            comboSectionBML.SelectedItem = "Q";
            comboLineBML.SelectedItem = "X";
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text = BML.AI.BMLPath;
            AddWorkSheets();
            dataGridBML.Columns.Add( new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnName,
                Name = nameof(BML.ColumnName)
            });

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnDesc,
                Name = nameof(BML.ColumnDesc)
            });

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnPower,
                Name = nameof(BML.ColumnPower)
            });
            dataGridBML.Columns[2].Width = 100;

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnFloor,
                Name = nameof(BML.ColumnFloor)
            });

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnCabinet,
                Name = nameof(BML.ColumnCabinet)
            });

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnCabinetGroup,
                Name = nameof(BML.ColumnCabinetGroup)
            });

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnLine,
                Name = nameof(BML.ColumnLine)
            });
        }

        private void BtnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboPowerBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboLineBML.Text,comboTypeBML.Text };
            StringBuilder sbPowerFilters = new StringBuilder();
            sbPowerFilters.Append(@"Value > ""0.37""");
            StringBuilder sbDescFilters = new StringBuilder();
            sbDescFilters.Append($@"Value LIKE ""%{BML.MachineType.RollerMiller}""");
            DataTable dataTable;
            string[] filters = { sbPowerFilters.ToString(), sbDescFilters.ToString() };
            string[] filterColumns = { comboPowerBML.Text, comboDescBML.Text };
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);
            if (chkCreateTempAndPreBML.Checked)
            {
                sbDescFilters.Clear();
                sbDescFilters.Append($@"Value == ""{BML.DO.FilterController}""");
                filters = new string[] { sbDescFilters.ToString() };
                filterColumns = new string[] { comboTypeBML.Text };
                dataTable.Merge(excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true));
            }
            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnPower)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnLine)].DataPropertyName = dataTable.Columns[6].ColumnName;
            TxtQuantity.Text = dataTable.Rows.Count.ToString();
        }
        #endregion

        #region Common used
        private void ChkAddSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddSectionToDesc.Checked)
            { chkAddUserSectionToDesc.Checked = false; }
            UpdateDesc();
        }
        private void ChkAddUserSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddUserSectionToDesc.Checked)
            { chkAddSectionToDesc.Checked = false; }
            UpdateDesc();
        }
        private void ChkAddNameToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ChkAddFloorToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ChkNameOnlyNumber_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ChkAddCabinetToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            AI.Rule.Common.DescFloor = ComboElevation.Text;
            UpdateDesc();
        }
        private void ComboPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboPanel.Text))
            {
                AI.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void ComboPanel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboPanel.Text))
            {
                AI.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void GetAdditionDesc()
        {
            AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
            AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
            AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
            AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
            AppGlobal.AdditionDesc.Cabinet = chkAddCabinetToDesc.Checked;
            AppGlobal.AdditionDesc.Power = false;
            AppGlobal.AdditionDesc.OnlyNumber = chkNameOnlyNumber.Checked;
        }
        /// <summary>
        /// 创建除尘器温度与压差AI对象
        /// </summary>
        /// <param name="objAI">AI对象</param>
        /// <param name="nameFilterController">除尘器名称</param>
        /// <param name="addtionToDesc">附件信息到对象描述</param>
        /// <param name="createTempature">true=创建除尘器温度AI;false=创建除尘器压差对象</param>
        private void CreateTempAndPreForFilter(AI objAI,string nameFilterController, string desc,
            (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
            bool createTempature)
        {
            GetAdditionDesc();
            string objName;
            objName = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternMachineName, nameFilterController);         
            AI.Rule.Common.DescFloor = string.IsNullOrEmpty(objAI.Elevation)?string.Empty: $"{objAI.Elevation}{GcObjectInfo.General.AddInfoElevation}";         
            AI.Rule.Common.Cabinet = string.IsNullOrEmpty(objAI.Panel_ID) ? string.Empty : $"{GcObjectInfo.General.AddInfoCabinet}{objAI.Panel_ID}";
            if (createTempature)
            {
                objAI.Name = $"{objName}{GcObjectInfo.AI.SuffixTemperature}";
                AI.Rule.Common.Name = objAI.Name;
                AI.Rule.Common.DescObject = $"{desc}{GcObjectInfo.AI.SuffixDescTemperature}";
            }
            else
            {
                objAI.Name = $"{objName}{GcObjectInfo.AI.SuffixPressure}";
                AI.Rule.Common.Name = objAI.Name;
                AI.Rule.Common.DescObject = $"{desc}{GcObjectInfo.AI.SuffixDescPressure}";
            }
                objAI.Description = AI.EncodingDesc(
                 baseRule: ref AI.Rule.Common,
                 namePrefix: GcObjectInfo.General.PrefixName,
                 nameRule: Engineering.PatternMachineName,
                 withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                 withFloorInfo: addtionToDesc.Elevation,
                 withNameInfo: addtionToDesc.IdentNumber,
                 withCabinet: addtionToDesc.Cabinet,
                 withPower: addtionToDesc.Power,
                 nameOnlyWithNumber: addtionToDesc.OnlyNumber
              );

          
            if (createTempature)
            {              
                objAI.PType = AI.P7406;
                objAI.UnitsBy100 =100.0;
                objAI.Unit = 3;//oC
                objAI.LimitLowLow = 5.0;
                objAI.LimitLow = 10.0;
                objAI.LimitHigh = 60.0;
                objAI.LimitHighHigh = 70.0;
                objAI.MonTimeHighHigh = 10.0;
            }
            else
            {
                objAI.PType = AI.P7404_1;
                objAI.UnitsBy100 = 1500.0;
                objAI.Unit = 24;//pa
                objAI.LimitLowLow = 0.0;
                objAI.LimitLow = 300.0;
                objAI.LimitHigh = 600.0;
                objAI.LimitHighHigh = 1000.0;
                objAI.MonTimeHighHigh = 10.0;
            }         
            objAI.CreateObject(Encoding.Unicode);           
            }
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                txtSymbolRule.Text = AI.Rule.Common.NameRule;
                txtSymbolIncRule.Text = AI.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                lblSymbol.Text = AppGlobal.NAME;
                //     txtSymbol.Text = DEMO_NAME_AI;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = AI.Rule.Common.NameRule;
                txtSymbolIncRule.Text = AI.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                GrpSymbolRule.Visible = false;
                //   lblSymbol.Text = AppGlobal.KEY_WORD_AUTOSEARCH;
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
        private void TabCreateMode_SelectedIndexChanged(object sender, EventArgs e)
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
        private void ToolStripMenuClearList_Click(object sender, EventArgs e)
        {
            DataTable dataTable = null;
            dataGridBML.DataSource = dataTable;

        }
        private void ToolStripMenuReload_Click(object sender, EventArgs e)
        {
            BtnReadBML_Click(sender, e);
        }
        private void ToolStripMenuDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridBML.SelectedRows)
            {
                dataGridBML.Rows.RemoveAt(row.Index);
            }
            dataGridBML.ClearSelection();
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
                    DataTable dataTable ;
                    OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);                    
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={AI.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Value11.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    AI.Clear(myAI.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        string inpValue = objName + txtInpValeSuffix.Text;
                        if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                        {
                            AI.CreateRelation(objName, inpValue, GcproTable.ObjData.Value11.Name, myAI.FileConnectorPath, Encoding.Unicode);
                        }

                        ProgressBar.Value = count;
                    }
                    AI.SaveFileAs(myAI.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
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
                myAI.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            AI.SaveFileAs(myAI.FilePath, LibGlobalSource.CREATE_OBJECT);
            AI.SaveFileAs(myAI.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
                OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
                AI.ReGenerateDPNode(oledb);
            }
        }
  
        private void CreateObjectCommon(AI objAI)
        {
            ///<UnitsBy100</UnitsBy100>
            objAI.UnitsBy100 = AppGlobal.ParseValue<float>(txtUnitsBy100.Text, out tempFloat) ? (Math.Round(tempFloat,0)) : 100;
            ///<OffsetUnits</OffsetUnits>
            objAI.OffsetUnits = AppGlobal.ParseValue<float>(txtOffsetUnits.Text, out tempFloat) ? (Math.Round(tempFloat, 0)) : 0.0;
            ///<DelayTimeDown></DelayTimeDown>
            objAI.DelayTimeDown = AppGlobal.ParseValue<float>(txtDelayTimeDown.Text, out tempFloat) ? (Math.Round(tempFloat, 1)) : 1.0;
            ///<DelayTimeUp></DelayTimeUp>
            objAI.DelayTimeUp = AppGlobal.ParseValue<float>(txtDelayTimeUp.Text, out tempFloat) ? (Math.Round(tempFloat, 1)) : 1.0;
            ///<DelayFaultTime ></DelayFaultTime >
            objAI.DelayFaultTime = AppGlobal.ParseValue<float>(txtDelayTimeFault.Text, out tempFloat) ? (Math.Round(tempFloat, 1)) : 1.0;
            ///<Unit ></Unit >
            string selectedUnit;
            if (comboUnit.SelectedItem != null)
            {
                selectedUnit = comboUnit.SelectedItem.ToString();
                AppGlobal.ParseValue<int>(selectedUnit.Substring(0, selectedUnit.IndexOf(AppGlobal.FIELDS_SEPARATOR)),out tempInt);
                objAI.Unit = tempInt;
                  
            }
            ///<Building></Building>
           string selectedBudling ;
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objAI.Building = selectedBudling;
            }
            ///<ParLimitLowLow></ParLimitLowLow>
            objAI.LimitLowLow = AppGlobal.ParseValue<float>(txtParLimitLowLow.Text, out tempFloat) ? (Math.Round(tempFloat, 0)) : 0;
            ///<ParLimitLow></ParLimitLow>
            objAI.LimitLowLow = AppGlobal.ParseValue<float>(txtParLimitLow.Text, out tempFloat) ? (Math.Round(tempFloat, 0)) : 1;
            ///<ParLimitHigh></ParLimitHigh>
            objAI.LimitHigh = AppGlobal.ParseValue<float>(txtParLimitHigh.Text, out tempFloat) ? (Math.Round(tempFloat, 0)) : 5;
            ///<ParLimitHighHigh></ParLimitHighHigh>
            objAI.LimitHighHigh = AppGlobal.ParseValue<float>(txtParLimitHighHigh.Text, out tempFloat) ? (Math.Round(tempFloat, 0)) : 10;
            ///<ParMonTimeLowLow></ParMonTimeLowLow>
            objAI.MonTimeLowLow = AppGlobal.ParseValue<float>(txtMonTimeLowLow.Text, out tempFloat) ? (Math.Round(tempFloat, 1)) : 1.0;
            ///<ParMonTimeLow></ParMonTimeLow>
            objAI.MonTimeLow = AppGlobal.ParseValue<float>(txtMonTimeLow.Text, out tempFloat) ? (Math.Round(tempFloat, 1)) : 1.0;
            ///<ParMonTimeMiddle></ParMonTimeMiddle>
            objAI.MonTimeMiddle = AppGlobal.ParseValue<float>(txtMonTimeMiddle.Text, out tempFloat) ? (Math.Round(tempFloat, 1)) : 1.0;
            ///<ParMonTimeHigh></ParMonTimeHigh>
            objAI.MonTimeHigh = AppGlobal.ParseValue<float>(txtMonTimeHigh.Text, out tempFloat) ? (Math.Round(tempFloat, 1)) : 1.0;
            ///<ParMonTimeHighHigh></ParMonTimeHighHigh>
            objAI.MonTimeHighHigh = AppGlobal.ParseValue<float>(txtMonTimeHighHigh.Text, out tempFloat) ? (Math.Round(tempFloat, 1)) : 2.0;
        }
        private void CreateObjectRule(AI objAI,
            (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc, 
            ref (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);   
            DataTable dataTable = new DataTable();
            string desc = string.Empty;
            // StringBuilder descTotalBuilder = new StringBuilder();
            int quantityNeedToBeCreate = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
            bool needDPNodeChanged = false;
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
            #region Prepare export motor file
            ///<OType>is set when object generated</OType>
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                objAI.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                objAI.SubType = AI.AIT;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (ComboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                AppGlobal.ParseValue<float>(selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR)), out tempFloat);
                objAI.PType = tempFloat;
            }
            else
            {
                objAI.PType = AI.P7252;
            }

            ///<Value9>Value is set when corresponding check box's check state changed</Value9>
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            objAI.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                objAI.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objAI.Diagram = AI.ParseInfoValue(selectedDiagram, AppGlobal.FIELDS_SEPARATOR, AppGlobal.NO_DIAGRAM);
            }

            ///<Page></Page>
            objAI.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objAI.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objAI.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objAI.Panel_ID = selectedPanel_ID;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            ///<DPNode1></DPNode1>
            string selectDPNode1 = String.Empty;
            if (ComboDPNode1.SelectedItem != null)
            {
                selectDPNode1 = ComboDPNode1.SelectedItem.ToString();   
                
                AppGlobal.FieldbusNodeInfo = AI.ParseFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, selectDPNode1);

                objAI.DPNode1 = AppGlobal.FieldbusNodeInfo.DPNodeNo;
                objAI.FieldBusNode = AppGlobal.FieldbusNodeInfo.FieldBusNodeKey;
            }
            ///<HornCode></HornCode>
            if (ComboHornCode.SelectedItem != null)
            {
                string hornCode = ComboHornCode.SelectedItem.ToString();
                objAI.HornCode = AI.ParseInfoValue(hornCode, AppGlobal.HORNCODE_FIELDS_SEPARATOR, AppGlobal.GROUP_HORNCODE);
            }
            #endregion

            #region Parse rules
            ///<ParseRule> </ParseRule>
            if (!AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out tempInt))
            {
                if (moreThanOne)
                {
                    AppGlobal.MessageNotNumeric($"({GrpSymbolRule.Text}.{lblSymbolIncRule.Text})");
                    return;
                }
            }
            ///<NameRule>生成名称规则</NameRule>
            name.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtSymbol.Text, txtSymbolRule.Text);
            if (name.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{GrpSymbolRule.Text}.{lblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
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
                    AppGlobal.RuleNotSetCorrect($"{GrpSymbolRule.Text}.{lblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
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
            desc = AI.Rule.Common.DescObject;
            if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
            {
                description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(desc, txtDescriptionRule.Text);
                if (description.PosInfo.Len == -1)
                {
                    if (moreThanOne)
                    {
                        AppGlobal.RuleNotSetCorrect($"{grpDescriptionRule.Text}.{lblDescriptionRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                        // return;
                    }
                }
                else
                {
                    description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(desc, txtDescriptionRule.Text);
                }
            }
            #endregion
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            ///<CreateObj>
            ///DPNode
            ///</CreateObj>
         //   int symbolInc, symbolRule, descriptionInc;
            AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out int symbolInc);
            AppGlobal.ParseValue<int>(txtSymbolRule.Text, out int symbolRule);
            AppGlobal.ParseValue<int>(txtDescriptionIncRule.Text, out int descriptionInc);
            objDefaultInfo = AI.Rule.Common;

            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                if (needDPNodeChanged && moreThanOne)
                {
                    dpNode1.Inc = i * symbolInc;
                    dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());         
                    objAI.DPNode1 = AI.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, dpNode1.Name);

                    if (objAI.DPNode1 == AppGlobal.NO_DP_NODE)
                    { objAI.FieldBusNode = AppGlobal.NO_DP_NODE; }
                    else
                    {
                        objAI.FieldBusNode = AI.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                        {
                            return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                        }, objAI.DPNode1);
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
                    description.Name = GcObjectInfo.AI.SuffixDescCurrent;
                }
                objAI.Name = name.Name;
                if (objAI.SubType == AI.AIT)
                {
                    objAI.InpValue = (objAI.Name.Contains(GcObjectInfo.AI.SuffixName) ? objAI.Name.Replace(GcObjectInfo.AI.SuffixName, string.Empty) : objAI.Name)
                                + txtInpValeSuffix.Text;

                }
                else if (objAI.SubType == AI.AIDI)
                {
                    objAI.InpLowLow = objAI.Name + txtSuffixInpLowLow.Text;
                    objAI.InpLow = objAI.Name + txtSuffixInpLow.Text;
                    objAI.InpHigh = objAI.Name + txtSuffixInpHigh.Text;
                    objAI.InpHighHigh = objAI.Name + txtSuffixInpHighHigh.Text;
                }
                AI.Rule.Common.Name = objAI.Name;
                AI.Rule.Common.DescFloor = $"{objAI.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                AI.Rule.Common.DescObject = $"{desc}{GcObjectInfo.AI.SuffixDescCurrent}";
                AI.Rule.Common.Cabinet =$"{GcObjectInfo.General.AddInfoCabinet}{objAI.Panel_ID}";

                objAI.Description = AI.EncodingDesc(
                    baseRule: ref AI.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
                objAI.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            AI.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
        private void CreateObjectBML(DataGridView dataFromBML, AI objAI,
        (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
        out (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            DataTable dataTable ;
            processValue.Max= dataFromBML.Rows.Count;
            processValue.Value = 0;
            //SuffixObject suffixObject = new SuffixObject();
            string cabinet, cabinetGroup;
            string nameNumberString;
            string name,nameMotor=string.Empty,nameFilterController=string.Empty;
            float motorPower = 0.0f;
            string motorPowerStr= string.Empty;
            bool isFilterController;
            (float rateCurrent, float ctRatio) motorCurrent = (0.0f, 0.0f);
            Dictionary<string, (float, float)> motorPowerInfo = new Dictionary<string, (float, float)>();
            MotorHelper motorHelper = new MotorHelper();
          
            objDefaultInfo = AI.Rule.Common;
            for (int i = 0; i < dataFromBML.Rows.Count; i++)
            {
                DataGridViewCell cell;
                cell = dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                { continue; }
                name = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)].Value);
                objAI.Name = name;
                string desc = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value);
                if (desc.Contains(BML.MachineType.Filter))
                {
                    isFilterController = true;
                    nameFilterController = name;
                }
                else
                {
                    isFilterController = false;
                    nameMotor = name;
                    motorPower = (float)Convert.ToDouble(dataFromBML.Rows[i].Cells[nameof(BML.ColumnPower)].Value);
                    motorPowerStr = motorPower.ToString();
                }
                
                objAI.Elevation = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);         
                cabinet = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                cabinetGroup = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value);
                objAI.Panel_ID = cabinet.StartsWith(BML.PrefixLocalPanel) ? cabinet : cabinetGroup + cabinet;
                if (!isFilterController)
                {
                    if (motorPowerInfo == null || !motorPowerInfo.ContainsKey(motorPowerStr))
                    {
                        if (motorHelper.GetConfig(motorPowerStr))
                        {
                            motorCurrent.rateCurrent = motorHelper.RatedCurrent;
                            motorCurrent.ctRatio = motorHelper.CTRatio;
                        }
                        else
                        {
                            motorCurrent.rateCurrent = motorHelper.CalcRateCurrent(motorPower);
                            motorCurrent.ctRatio = Motor.GetCTRatio(motorPower);
                        }
                        motorPowerInfo.Add(motorPowerStr, motorCurrent);

                    }
                    else
                    {
                        motorPowerInfo.TryGetValue(motorPowerStr, out motorCurrent);
                    }
                }
                ///<AdditionInfoToDesc>
                ///</AdditionInfoToDesc>
                if (addtionToDesc.Section)
                {
                    nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, name);
                    if (!string.IsNullOrEmpty(nameNumberString))
                    {
                        if (AppGlobal.ParseValue<int>(nameNumberString, out tempInt))
                        {
                            AI.Rule.Common.DescLine=GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.UserDefSection)
                {
                    AI.Rule.Common.DescLine = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value); ;
                }
                AI.Rule.Common.DescFloor = $"{objAI.Elevation}{GcObjectInfo.General.AddInfoElevation}";           
                AI.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{myAI.Panel_ID}";
                if (isFilterController)
                {
                    ///<CreateTemperature>Create temperature </CreateTemperature>
                    CreateTempAndPreForFilter(objAI, nameFilterController, desc, addtionToDesc, true);
                    ///<CreatePressure >Create pressure </CreatePressure >
                    CreateTempAndPreForFilter(objAI, nameFilterController, desc, addtionToDesc, false);
                }
                else
                {
                    AI.Rule.Common.Name = nameMotor;
                    AI.Rule.Common.DescObject = $"{desc}{GcObjectInfo.AI.SuffixDescCurrent}";
                    objAI.Description = AI.EncodingDesc(
                        baseRule: ref AI.Rule.Common,
                        namePrefix: GcObjectInfo.General.PrefixName,
                        nameRule: Engineering.PatternMachineName,
                        withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                        withFloorInfo: addtionToDesc.Elevation,
                        withNameInfo: addtionToDesc.IdentNumber,
                        withCabinet: addtionToDesc.Cabinet,
                        withPower: addtionToDesc.Power,
                        nameOnlyWithNumber: addtionToDesc.OnlyNumber
                     );

                    objAI.Name = $"{nameMotor}{GcObjectInfo.AI.SuffixName}";
                    objAI.PType = AI.P7408_1;
                    objAI.InpValue = $"{nameMotor}{GcObjectInfo.AI.SuffixInpValue}";
                    objAI.UnitsBy100 = Math.Round(motorCurrent.rateCurrent,1);
                    objAI.Unit = 11;//A
                    objAI.LimitLowLow = Math.Round(motorCurrent.rateCurrent * 0.1f,0);
                    objAI.LimitLow = Math.Round(motorCurrent.rateCurrent * 0.3f,0);
                    objAI.LimitHigh = Math.Round(motorCurrent.rateCurrent * 0.9f,0);
                    objAI.LimitHighHigh = Math.Round(motorCurrent.rateCurrent * 1.1f,0);
                    objAI.MonTimeHighHigh = Motor.GetStartingTime(motorCurrent.rateCurrent);
                    objAI.CreateObject(Encoding.Unicode);
                }
                ///<UpdateFiled>
                ///Update Value22 for Analog input
                ///</UpdateFiled>
                if (!isFilterController && chkUpdateUnitsByMaxDigits.Checked)
                {
                    string filter = $@"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.AIC}  AND {GcproTable.ObjData.Text0.Name} = '{nameMotor}{GcObjectInfo.AI.SuffixInpValue}'";
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, null, GcproTable.ObjData.Key.Name);
                    if (dataTable.Rows.Count > 0)
                    {
                        List<int> inpValueKeyList = OleDb.GetColumnData<int>(dataTable, GcproTable.ObjData.Key.Name);
                        string filterInpValue = $@"{GcproTable.ObjData.Key.Name} = {inpValueKeyList[0]}";
                        List<GcproExtensionLibrary.Gcpro.DbParameter> updateField = new List<GcproExtensionLibrary.Gcpro.DbParameter>
                                    {
                                         new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ObjData.Value22.Name, Value = (double)motorCurrent.ctRatio},
                                         new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ObjData.Value21.Name, Value = 0.0},
                                         new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ObjData.IsNew.Name, Value =false},
                                         new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ObjData.Text8.Name, Value = "A"},
                                    };

                        oledb.UpdateRecord(GcproTable.ObjData.TableName, updateField, filterInpValue);
                    }
                }
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
            AI.Rule.Common = objDefaultInfo;
        }
        private void CreatObjectAutoSearch(AI objAI,ref (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            DataTable dataTable;
            string filter = $@"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.AIC} AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER} ";
            filter = String.IsNullOrEmpty(txtSymbol.Text) ? filter : $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";
            dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, null, GcproTable.ObjData.Key.Name, GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
            List<string> objList = OleDb.GetColumnData<string>(dataTable, GcproTable.ObjData.Text0.Name);
            List<string> objDescList = OleDb.GetColumnData<string>(dataTable, GcproTable.ObjData.Text1.Name);
            for (int i = 0; i <objList.Count; i++)
            {
                objList[i] = GcObject.GetObjectSymbolFromIO(objList[i], GcObjectInfo.General.SuffixIO.Delimiter);
            }
            processValue.Max = objList.Count;
            processValue.Value = 0;
            for (int i = 0; i < objList.Count; i++)
            {
                objAI.Name = GcObject.GetObjectSymbolFromIO(objList[i], GcObjectInfo.General.SuffixIO.Delimiter);
                objAI.InpValue = objList[i];
                objAI.Description = objDescList[i];
                objAI.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                GetAdditionDesc();
                AppGlobal.ProcessValue.Value = ProgressBar.Value = 0;
                if (createMode.Rule || createMode.AutoSearch)
                {
                    CreateObjectCommon(myAI);             
                }
                string selectedBudling = "--";
                if (ComboBuilding.SelectedItem != null)
                {
                    selectedBudling = ComboBuilding.SelectedItem.ToString();
                    myAI.Building = selectedBudling;
                }
                if (createMode.BML)
                {
                    CreateObjectBML(
                        dataFromBML:dataGridBML,
                        objAI:myAI,
                        addtionToDesc:AppGlobal.AdditionDesc,
                        processValue:out AppGlobal.ProcessValue
                        );
                }
                else if (createMode.AutoSearch)
                {
                    CreatObjectAutoSearch(
                        objAI:myAI,
                        processValue: ref AppGlobal.ProcessValue
                         );
                }
                else if (createMode.Rule)
                {
                    CreateObjectRule(
                       objAI: myAI,
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
