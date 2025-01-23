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
using Microsoft.Extensions.Primitives;
#endregion
namespace GcproExtensionApp
{
    #pragma warning disable IDE1006
    public partial class FormDO : Form, IGcForm
    {

        public FormDO()
        {
            InitializeComponent();
        }

        #region Public object in this class
        readonly DO myDO = new DO(AppGlobal.GcproDBInfo.GcproTempPath);
        readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        readonly CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private readonly string DEMO_NAME_DO = "=A-4001-KFC01";
        private readonly string DEMO_NAME_RULE_DO = "4001";
        private readonly string DEMO_DESCRIPTION_DO = "前路高压除尘控制器";
        private readonly string DEMO_DESCRIPTION_RULE_DO = "";
        private readonly string doSuffix = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_DO}.{AppGlobal.JS_SUFFIX}.";
        private readonly string doBMLSuffix = $"{AppGlobal.JS_BML}.{AppGlobal.JS_DO}.";
        private GcBaseRule objDefaultInfo;
        #endregion
    
        private int value10 = 0;
        private int tempInt = 0;
        private float tempFloat = (float)0.0;
        private bool tempBool = false;
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
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={DO.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {DO.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + DO.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                comboEquipmentInfoType.Items.Add(column.ToString());
            }
            comboEquipmentInfoType.SelectedIndex = 0;
            ///<HornCode> Read [HornCode] </HornCode>
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
                comboDPNode1.Items.Add(column.ToString());
                comboDPNode2.Items.Add(column.ToString());

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
            objDefaultInfo.NameRule = "4001";
            objDefaultInfo.DescLine = "制粉A线";
            objDefaultInfo.DescFloor = "6楼";
            objDefaultInfo.Name = "=A-4001-KFC01";
            objDefaultInfo.DescObject = "前路高压除尘控制器";
            objDefaultInfo.DescriptionRuleInc = DO.Rule.Common.DescriptionRuleInc;
            objDefaultInfo.NameRuleInc = DO.Rule.Common.NameRuleInc;
            DO.Rule.Common.Cabinet = DO.Rule.Common.Power = string.Empty;

            objDefaultInfo.Description = DO.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix: GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: chkAddCabinetToDesc.Checked,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (String.IsNullOrEmpty(DO.Rule.Common.Description))
            { DO.Rule.Common.Description = objDefaultInfo.Description; }

            if (String.IsNullOrEmpty(DO.Rule.Common.Name))
            { DO.Rule.Common.Name = objDefaultInfo.Name; }

            if (String.IsNullOrEmpty(DO.Rule.Common.DescLine))
            { DO.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (String.IsNullOrEmpty(DO.Rule.Common.DescFloor))
            { DO.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (String.IsNullOrEmpty(DO.Rule.Common.DescObject))
            { DO.Rule.Common.DescObject = objDefaultInfo.DescObject; }
            txtSymbolRule.Text = DO.Rule.Common.NameRule;
            txtSymbolIncRule.Text = DO.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = DO.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = DO.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = DO.Rule.Common.Name;
            txtDescription.Text = DO.Rule.Common.Description;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + DO.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_DO);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_DO);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_DO);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_DO);
            toolTip.SetToolTip(BtnRegenerateDPNode, AppGlobal.MSG_REGENERATE_DPNODE);
        }
        public void CreateImpExp()
        {
            DataTable dataTable ;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{DO.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{DO.ImpExpRuleName}'", null);
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
            txtInpRunSuffix.Text = GcObjectInfo.DO.SuffixInpRun;
            txtInpFaultDevSuffix.Text = GcObjectInfo.DO.SuffixInpFaultDev;
            txtInpAlarmResetSuffix.Text = GcObjectInfo.DO.SuffixInpAlarmReset;
            txtOutpFaultResetSuffix.Text = GcObjectInfo.DO.SuffixOutpFaultReset;
            txtOutpRunSuffix.Text = GcObjectInfo.DO.SuffixOutpRun;
            txtOutpLampSuffix.Text = GcObjectInfo.DO.SuffixOutpLamp;
            txtOutpFinalClearing.Text = GcObjectInfo.DO.SuffixOutpFinalClearing;
            txtOutpRun.Text = txtSymbol.Text + txtOutpRunSuffix.Text;

            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            txtValue10.Text = myDO.Value10;
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "DO导入文件 " + " " + myDO.FilePath;
        }
        #endregion
        private void CreateDIImpExp(OleDb oledb)
        {

            bool result = myDO.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormDO_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormDO_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
        private void txtInpRunSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpRunSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{doSuffix}InpRun", newJsonKeyValue);
                GcObjectInfo.DO.SuffixInpRun = newJsonKeyValue;
            }
        }

        private void txtInpFaultDevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpFaultDevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{doSuffix}InpFaultDev", newJsonKeyValue);
                GcObjectInfo.DO.SuffixInpFaultDev = newJsonKeyValue;
            }
        }

        private void txtOutpFaultResetSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpFaultResetSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{doSuffix}OutpFaultReset", newJsonKeyValue);
                GcObjectInfo.DO.SuffixOutpFaultReset = newJsonKeyValue;
            }
        }

        private void txtOutpRunSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpRunSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{doSuffix}.OutpRun", newJsonKeyValue);
                GcObjectInfo.DO.SuffixOutpRun= newJsonKeyValue;
            }
        }

        private void txtOutpLampSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpLampSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{doSuffix}OutpLamp", newJsonKeyValue);
                GcObjectInfo.DO.SuffixOutpLamp = newJsonKeyValue;
            }
        }
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (createMode.AutoSearch)
            { return; }
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                DO.Rule.Common.NameRule = txtSymbolRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            txtInpRun.Text = txtSymbol.Text + txtInpRunSuffix.Text;
            myDO.Name = txtSymbol.Text;
            myDO.Name = txtSymbol.Text;
            DO.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
        }
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value21.Name,
                OType = Convert.ToString(DO.OTypeValue)
            };
            objectBrowser.Show();
        }
        private void TxtSymbolIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtSymbolIncRule.Text))
                {
                    DO.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!DO.Rule.Common.Description.Equals(txtDescription.Text))
            {
                DO.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(DO.Rule.Common.DescObject, false);
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
                    DO.Rule.Common.Description = txtDescription.Text;
                    DO.DecodingDesc(ref DO.Rule.Common, AppGlobal.DESC_SEPARATOR);
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
                string descObjectNumber = LibGlobalSource.StringHelper.ExtractNumericPart(DO.Rule.Common.DescObject, false);
                if (!string.IsNullOrEmpty(descObjectNumber))
                {
                    DO.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                    DO.Rule.Common.DescObject = DO.Rule.Common.DescObject.Replace(descObjectNumber, DO.Rule.Common.DescriptionRule);
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
                    DO.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtInpRunSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRun.Text = txtSymbol.Text + txtInpRunSuffix.Text;
        }
        private void txtOutpRunSuffix_TextChanged(object sender, EventArgs e)
        {
            txtOutpRun.Text = txtSymbol.Text + txtOutpRunSuffix.Text;
        }
        private void txtParStartDelay_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtParStartDelay.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        private void txtParStartingTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtParStartingTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtParOnTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtParOnTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtParOffTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtParOffTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtParIdlingTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtParIdlingTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtParDelayFaultTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtParDelayFaultTime.Text)))
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

            myDO.Value10 = value10.ToString();
            txtValue10.Text = myDO.Value10;
        }
        private void chkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParManual.Checked)

            { AppGlobal.SetBit(ref value10, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myDO.Value10 = value10.ToString();
            txtValue10.Text = myDO.Value10;
        }
        private void chkParContinuous_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParContinuous.Checked)

            { AppGlobal.SetBit(ref value10, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }

            myDO.Value10 = value10.ToString();
            txtValue10.Text = myDO.Value10;
        }      
        private void chkParPulse_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPulse.Checked)

            { AppGlobal.SetBit(ref value10, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)3); }

            myDO.Value10 = value10.ToString();
            txtValue10.Text = myDO.Value10;
        }
        private void chkParPulsing_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPulsing.Checked)

            { AppGlobal.SetBit(ref value10, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)4); }

            myDO.Value10 = value10.ToString();
            txtValue10.Text = myDO.Value10;
        }

        private void chkParFilter_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParFilter.Checked)

            { AppGlobal.SetBit(ref value10, (byte)5); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)5); }

            myDO.Value10 = value10.ToString();
            txtValue10.Text = myDO.Value10;
        }

        private void chkParStartwarning_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParStartingwarning.Checked)

            { AppGlobal.SetBit(ref value10, (byte)6); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)6); }

            myDO.Value10 = value10.ToString();
            txtValue10.Text = myDO.Value10;
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
        private void txtInpRun_MouseEnter(object sender, EventArgs e)
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
        private void comboDPNode1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "DPNode1";
        }

        private void txtParStartDelay_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }
        private void txtParStartingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value20";
        }
        private void txtParOnTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }
        private void txtParOffTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }
        private void txtParIdlingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }
        private void chkParLogOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit0";
        }
        private void chkParManual_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }
        private void chkParContinuous_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit2";
        }
        private void chkParPulse_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit3";
        }
        private void chkParPulsing_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit4";
        }
        private void chkParFilter_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit5";
        }
        private void chkParStartingwarning_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit6";
        }
        #endregion

        private void UpdateDesc()
        {
            DO.Rule.Common.Description = DO.EncodingDesc(
            baseRule: ref DO.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: chkAddCabinetToDesc.Checked,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = DO.Rule.Common.Description;
        }
        void SubTypeChanged(string subType)
        {
            if (subType == DO.DOC)
            {
                myDO.PType = DO.P7002.ToString();
                txtParStartDelay.Text = "0.0";
                txtParStartingTime.Text = "1.0";
                txtParOnTime.Text = "0.0";
                txtParOffTime.Text = "0.0";
                txtParIdlingTime.Text = "0.0";
                txtParDelayFaultTime.Text = "0.0";
                value10 = 70;
            }
            else if (subType == DO.DOP)
            {
                myDO.PType = DO.P7002.ToString();
                txtParStartDelay.Text = "0.0";
                txtParStartingTime.Text = "0.0";
                txtParOnTime.Text = "10.0";
                txtParOffTime.Text = "0.0";
                txtParIdlingTime.Text = "0.0";
                txtParDelayFaultTime.Text = "0.0";
                value10 = 74;
            }
            else if (subType == DO.DON)
            {
                myDO.PType = DO.P7002.ToString();
                txtParStartDelay.Text = "0.0";
                txtParStartingTime.Text = "0.0";
                txtParOnTime.Text = "1.0";
                txtParOffTime.Text = "5.0";
                txtParIdlingTime.Text = "0.0";
                txtParDelayFaultTime.Text = "0.0";
                value10 = 82;
            }
            else if (subType == DO.DOPHORN)
            {
                myDO.PType = DO.P7002.ToString();
                txtParStartDelay.Text = "0.0";
                txtParStartingTime.Text = "5.0";
                txtParOnTime.Text = "30.0";
                txtParOffTime.Text = "0.0";
                txtParIdlingTime.Text = "0.0";
                txtParDelayFaultTime.Text = "0.0";
                value10 = 10;
            }
            else if (subType == DO.DOCFilter)
            {
                myDO.PType = DO.P7002.ToString();
                txtParStartDelay.Text = "0.0";
                txtParStartingTime.Text = "5.0";
                txtParOnTime.Text = "0.0";
                txtParOffTime.Text = "0.0";
                txtParIdlingTime.Text = "120.0";
                txtParDelayFaultTime.Text = "0.0";
                value10 = 102;
            }
            else if (subType == DO.DOCADJREQ || subType == DO.DOCTARWT)
            {
                myDO.PType = DO.P7002.ToString();
                txtParStartDelay.Text = "0.0";
                txtParStartingTime.Text = "5.0";
                txtParOnTime.Text = "0.0";
                txtParOffTime.Text = "0.0";
                txtParIdlingTime.Text = "0.0";
                txtParDelayFaultTime.Text = "0.0";
                value10 = 4;
            }           
                 
            myDO.ParStartDelay = AppGlobal.ParseFloat(txtParStartDelay.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "1.0";
            myDO.ParStartingTime = AppGlobal.ParseFloat(txtParStartingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "1.0";
            myDO.ParOnTime= AppGlobal.ParseFloat(txtParOnTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            myDO.ParOffTime = AppGlobal.ParseFloat(txtParOffTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "5.0";
            myDO.ParIdlingTime = AppGlobal.ParseFloat(txtParIdlingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "1.0";
            myDO.ParDelayFaultTime = AppGlobal.ParseFloat(txtParDelayFaultTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "1.0";
        }
        void GetValue10BitValue(int value)
        {
            chkParLogOff.Checked = AppGlobal.GetBitValue(value, 0);
            chkParManual.Checked = AppGlobal.GetBitValue(value, 1);
            chkParContinuous.Checked = AppGlobal.GetBitValue(value, 2);
            chkParPulse.Checked = AppGlobal.GetBitValue(value, 3);
            chkParPulsing.Checked = AppGlobal.GetBitValue(value, 4);
            chkParFilter.Checked = AppGlobal.GetBitValue(value, 5);
            chkParStartingwarning.Checked = AppGlobal.GetBitValue(value, 6);
        } 
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myDO.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SubTypeChanged(myDO.SubType);
            
                    foreach (var item in comboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DO.P7002.ToString()))
                        {
                            comboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }                        
                GetValue10BitValue(value10);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion <---Rule and autosearch part---> 
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
                comboWorkSheetsBML.SelectedIndex = 0;
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
            BML.DO.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{doBMLSuffix}Path", BML.DO.BMLPath);
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
            //AddWorkSheets();
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
     
            }
            comboNameBML.SelectedItem = "B";
            comboDescBML.SelectedItem = "N";
            comboTypeBML.SelectedItem = "C";
            comboFloorBML.SelectedItem = "L";
            comboCabinetBML.SelectedItem = "P";
            comboSectionBML.SelectedItem = "Q";
            comboControlBML.SelectedItem = "H";
            comboIORemarkBML.SelectedItem = "R";
            comboLineBML.SelectedItem = "X";
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text = BML.DO.BMLPath;
            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
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
                HeaderText = BML.ColumnType,
                Name = nameof(BML.ColumnType)
            });

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
                HeaderText = BML.ColumnIORemark,
                Name = nameof(BML.ColumnIORemark)
            });

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnLine,
                Name = nameof(BML.ColumnLine)
            });
        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboTypeBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboIORemarkBML.Text,comboLineBML.Text,comboControlBML.Text };
            StringBuilder sbFilters = new StringBuilder();
            sbFilters.Append($@"Value LIKE ""%{BML.DO.Alarmhorn}"" || ").Append($@"Value LIKE ""%{BML.DO.Lamp}"" || ").Append($@"Value LIKE ""%{BML.DO.FilterController}"" || ")
                 .Append($@"Value LIKE ""%{BML.DO.SolenoidValve}""");
            StringBuilder sbValveFilters = new StringBuilder();
            sbValveFilters.Append($@"Value NOT LIKE ""%{BML.VLS.ManualFlap}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneFlap}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneTwoWayValve}"" && ")
           .Append($@"Value NOT LIKE ""%{BML.VLS.PneAspValve}"" &&").Append($@"Value NOT LIKE ""%{BML.VLS.ManualSlideGate}"" &&").Append($@"Value NOT LIKE ""%{BML.VLS.PneSlideGate}"" &&")
           .Append($@"Value NOT LIKE ""%{BML.VLS.PneShutOffValve}"" &&").Append($@"Value NOT LIKE ""%{BML.MachineType.ImpactMachine}"" &&").Append($@"Value NOT LIKE ""{BML.MachineType.Mixer}"" ||")
           .Append($@"Value LIKE ""%{BML.MachineType.Hammer}""");
            DataTable dataTable;
            string[] filters;
            string[] filterColumns;
            filters = new string[] { sbFilters.ToString(), sbValveFilters.ToString() };       
            filterColumns = new string[] { comboTypeBML.Text, comboDescBML.Text};
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);
            //sbFilters.Clear();
            //sbFilters.Append($@"Value LIKE ""%{BML.MachineType.Hammer}%""");
            //filters = new string[] { sbFilters.ToString()};
            //filterColumns = new string[] {comboDescBML.Text};
            //dataTable.Merge(excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true));
            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnType)].DataPropertyName = dataTable.Columns[2].ColumnName;
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
                DO.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DO.Rule.Common.DescFloor = ComboElevation.Text;
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
                txtSymbolRule.Text = DO.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DO.Rule.Common.NameRuleInc;
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
                txtSymbolRule.Text = DO.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DO.Rule.Common.NameRuleInc;
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
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={DO.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text1.Name, GcproTable.ObjData.Value11.Name,
                        GcproTable.ObjData.Value12.Name, GcproTable.ObjData.Value15.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    DO.Clear(myDO.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        string inpRun,outpRun;
                        inpRun = objName + txtInpRunSuffix.Text;
                        outpRun = objName + txtOutpRunSuffix.Text;
                        if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                        {
                            DO.CreateRelation(objName, inpRun, GcproTable.ObjData.Value11.Name, myDO.FileConnectorPath, Encoding.Unicode);
                        }
                        if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                        {
                            DO.CreateRelation(objName, outpRun, GcproTable.ObjData.Value12.Name, myDO.FileConnectorPath, Encoding.Unicode);
                        }
                        if (!String.IsNullOrEmpty(txtInHWStop.Text))
                        {
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value47.Name) == 0 || all)
                            {
                                string InHWStop = objName + txtInHWStop.Text; ;
                                DO.CreateRelation(objName, InHWStop, GcproTable.ObjData.Value47.Name, myDO.FileConnectorPath, Encoding.Unicode);
                            }
                        }

                        if (!String.IsNullOrEmpty(txtOutpLamp.Text))
                        {

                        }
                        ProgressBar.Value = count;
                    }
                    DO.SaveFileAs(myDO.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
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
                myDO.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            DO.SaveFileAs(myDO.FilePath, LibGlobalSource.CREATE_OBJECT);
            DO.SaveFileAs(myDO.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
                DO.ReGenerateDPNode(oledb);
            }
        }
    
        public void CreateObjectCommon(DO objDO)
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            //    DataTable dataTable = new DataTable();
            #region Prepare export DO file
            ///<OType>is set when object generated</OType>
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                objDO.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                objDO.SubType = DO.DOCFilter;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (comboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = comboEquipmentInfoType.SelectedItem.ToString();
                objDO.PType = selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            else
            {
                objDO.PType = DO.P7002.ToString();
            }
            ///<StartDelay</StartDelay>
            objDO.ParStartDelay = AppGlobal.ParseFloat(txtParStartDelay.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "20.0";
            ///<StartingTime></StartingTime>
            objDO.ParStartingTime= AppGlobal.ParseFloat(txtParStartingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            ///<OnTime></OnTime>
            objDO.ParOnTime = AppGlobal.ParseFloat(txtParOnTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            ///<OffTime></OffTime>
            objDO.ParOffTime = AppGlobal.ParseFloat(txtParOffTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            ///<IdlingTime></IdlingTime>
            objDO.ParIdlingTime = AppGlobal.ParseFloat(txtParIdlingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
            ///<DelayFaultTime></DelayFaultTime>
            objDO.ParDelayFaultTime = AppGlobal.ParseFloat(txtParDelayFaultTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F0") : "0";
            ///<Value9>Value is set when corresponding check box's check state changed</Value9>
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            objDO.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                objDO.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objDO.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }

            ///<Page></Page>
            objDO.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objDO.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objDO.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objDO.Panel_ID = selectedPanel_ID;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            objDO.FieldBusNode = LibGlobalSource.NOCHILD; ;
            ///<DPNode1></DPNode1>
            string selectDPNode1 = String.Empty;
            if (comboDPNode1.SelectedItem != null)
            {
                selectDPNode1 = comboDPNode1.SelectedItem.ToString();
                objDO.DPNode1 = DO.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, selectDPNode1);

                if (String.IsNullOrEmpty(objDO.DPNode1))
                { objDO.FieldBusNode = string.Empty; }
                else
                {
                    objDO.FieldBusNode = DO.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, int.Parse(objDO.DPNode1));
                }
            }
            ///<DPNode2></DPNode2>
            string selectDPNode2 = String.Empty;
            if (comboDPNode2.SelectedItem != null)
            {
                selectDPNode2 = comboDPNode1.SelectedItem.ToString();
                objDO.DPNode2 = DO.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, selectDPNode2);

                if (String.IsNullOrEmpty(objDO.DPNode2))
                { objDO.FieldBusNode = string.Empty; }
                else
                {
                    objDO.FieldBusNode = DO.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, int.Parse(objDO.DPNode1));
                }
            }
            ///<HornCode></HornCode>
            if (ComboHornCode.SelectedItem != null)
            {
                string hornCode = ComboHornCode.SelectedItem.ToString();
                objDO.HornCode = hornCode.Substring(0, 2);
            }
            ///<InpRun></InpRun>
            objDO.InpRun = LibGlobalSource.NOCHILD;
            ///<InpFaultDev></InpFaultDev>
            objDO.InpFaultDev = LibGlobalSource.NOCHILD;
            ///<InpAlarmReset></InpAlarmReset>
            objDO.InpAlarmReset = LibGlobalSource.NOCHILD;
            ///<InHWStop></InHWStop>
            objDO.InHWStop = LibGlobalSource.NOCHILD;
            ///<OutpFaultReset ></OutpFaultReset >
            objDO.OutpFaultReset = LibGlobalSource.NOCHILD;
            ///<OutpLamp></OutpLamp>
            objDO.OutpLamp = string.Empty;
            ///<OutpRun ></OutpRun>
            objDO.OutpRun = string.Empty;
            ///<OutpFinalClearing></OutpFinalClearing>
            objDO.OutpFinalClearing = string.Empty;
            #endregion
        }
        public void CreateObjectBML(DataGridView dataFromBML, DO objDO,
            (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
            out (int Value, int Max) processValue)
        {
         
            #region common used variables declaration       
            StringBuilder descToBuilder = new StringBuilder();
            int quantityNeedToBeCreate = dataFromBML.Rows.Count;
            #endregion
            #region Prepare export DO file     
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objDO.Building = selectedBudling;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            objDO.FieldBusNode = LibGlobalSource.NOCHILD; ;
            if (ComboHornCode.SelectedItem != null)
            {
                string hornCode = ComboHornCode.SelectedItem.ToString();
                objDO.HornCode = hornCode.Substring(0, 2);
            }
            #endregion
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            string cabinet, cabinetGroup;
            string stringNumber ;
            bool descUserDef = false;
            bool descUserDefConfirm = false;
            objDefaultInfo = DO.Rule.Common;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                DataGridViewCell cell;
                cell = dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                { continue; }
                string _subType = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnType)].Value);
                string desc = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value);

                objDO.Name = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)].Value);
                ///<AdditionInfoToDesc></AdditionInfoToDesc>   
                descToBuilder.Clear();
               // string ioRemark = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnIORemark)].Value);
                if (!descUserDefConfirm)
                {
                    //descUserDef = (MessageBox.Show(AppGlobal.USER_DEFINED_DESC, AppGlobal.INFO, MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) ?
                    //true : false;
                     descUserDef = false;
                }
                descUserDefConfirm = true;
                if (descUserDef)
                {
                    descToBuilder.Append(desc);
                }                      
                if (addtionToDesc.Section && !descUserDef)
                {
                    stringNumber = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, objDO.Name);
                    if (!string.IsNullOrEmpty(stringNumber))
                    {
                        if (AppGlobal.ParseInt(stringNumber.Substring(0, 4), out tempInt))
                        {
                            DO.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.UserDefSection && !descUserDef)
                {
                    DO.Rule.Common.DescLine = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value); ;
                }

                objDO.InpRun = $"{objDO.Name}{GcObjectInfo.DO.SuffixInpRun}";
                objDO.OutpRun = $"{objDO.Name}{GcObjectInfo.DO.SuffixOutpRun}";
                cabinet = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                cabinetGroup = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value);
                objDO.Panel_ID = cabinet.StartsWith(BML.PrefixLocalPanel) ? cabinet : cabinetGroup + cabinet;
                objDO.Elevation = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);

                #region Subtype and PType           
                if (_subType.Contains(BML.DO.Alarmhorn))
                {
                    objDO.SubType = DO.DOPHORN;
                    objDO.Value10 = "10";              
                }
          
                else if (_subType.Contains(BML.DO.FilterController))
                {
                    objDO.SubType = DO.DOCFilter;
                    objDO.Value10 = "102";
                }
                else if (_subType.Contains(BML.DO.Lamp))
                {
                    objDO.SubType = DO.DOC;
                    objDO.Value10 = "70";
                }
                else if (_subType.Contains(BML.DO.SolenoidValve) && desc.Contains(BML.MachineType.Hammer))
                {
                    objDO.SubType = DO.DON;
                    objDO.Value10 = "82";
                }
               else
                {
                    objDO.SubType = DO.DOC;
                    objDO.Value10 = "70";
                }
                #endregion
                SubTypeChanged(objDO.SubType);
                //  desc = descToBuilder.ToString();
                DO.Rule.Common.Name = objDO.Name;
                DO.Rule.Common.DescFloor = $"{objDO.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                DO.Rule.Common.DescObject = desc;
                DO.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{objDO.Panel_ID}";
                objDO.Description = DO.EncodingDesc(
                    baseRule: ref DO.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: (addtionToDesc.Section || addtionToDesc.UserDefSection) && !descUserDef,
                    withFloorInfo: addtionToDesc.Elevation && !descUserDef,
                    withNameInfo: addtionToDesc.IdentNumber && !descUserDef,
                    withCabinet: addtionToDesc.Cabinet && !descUserDef,
                    withPower: addtionToDesc.Power && !descUserDef,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
                objDO.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            DO.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
        private void CreateObjectRule(DO objDO, (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
         ref (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            // DataTable dataTable = new DataTable();
            #region common used variables declaration       
            bool needDPNodeChanged = false;
            StringBuilder descToBuilder = new StringBuilder();
            int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            processValue.Max = quantityNeedToBeCreate;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
            objDefaultInfo = DO.Rule.Common;
            string desc = string.Empty;
            RuleSubDataSet description, name, dpNode1, dpNode2;
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
            dpNode2 = new RuleSubDataSet
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
            if (comboDPNode1.SelectedItem != null)
            {

                selectedDPNode1Item = comboDPNode1.SelectedItem.ToString();
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
            string selectedDPNode2Item = string.Empty;
            if (comboDPNode2.SelectedItem != null)
            {

                selectedDPNode2Item = comboDPNode1.SelectedItem.ToString();
            }
            else
            {
                needDPNodeChanged = false;
            }
            if (needDPNodeChanged)
            {
                dpNode2.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(selectedDPNode2Item, txtSymbolRule.Text);
                if (dpNode2.PosInfo.Len == -1)
                {
                    AppGlobal.RuleNotSetCorrect($"{GrpSymbolRule.Text}.{LblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
                else
                {
                    dpNode2.Name = selectedDPNode2Item;
                    dpNode2.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(dpNode2.Name, txtSymbolRule.Text);
                }
            }
            else
            {
                dpNode2.Name = string.Empty;
            }
            ///<DescRule>生成描述规则</DescRule>
            desc = DO.Rule.Common.DescObject;
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
                    dpNode2.Inc = i * symbolInc;
                    dpNode2.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode2.Sub, dpNode2.PosInfo, (symbolRule + dpNode2.Inc).ToString());
                    objDO.DPNode1 = DO.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, dpNode1.Name);

                    objDO.DPNode2 = DO.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, dpNode2.Name);

                    if (String.IsNullOrEmpty(objDO.DPNode1))
                    { objDO.FieldBusNode = string.Empty; }
                    else
                    {
                        objDO.FieldBusNode = DO.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                        {
                            return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                        }, int.Parse(objDO.DPNode1));
                    }

                    if (String.IsNullOrEmpty(objDO.DPNode2))
                    { objDO.FieldBusNode = string.Empty; }
                    else
                    {
                        objDO.FieldBusNode = DO.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                        {
                            return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                        }, int.Parse(objDO.DPNode2));
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
                objDO.Name = name.Name;
                objDO.InpRun = $"{name.Name}{GcObjectInfo.DO.SuffixInpRun}";
                objDO.OutpRun = $"{name.Name}{GcObjectInfo.DO.SuffixOutpRun}";
                DO.Rule.Common.Name = name.Name;
                DO.Rule.Common.DescObject = description.Name;
                //  DO.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{objDO.Panel_ID}";
                objDO.Description = DO.EncodingDesc(
                    baseRule: ref DO.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );

                objDO.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
            DO.Rule.Common = objDefaultInfo;
        }
        private void CreateObjectAutoSearch(DO objDO, ref (int Value, int Max) processValue)
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            DataTable dataTable ;
            List<string> objList = new List<string>();
            // List<int> objOutpKeyList = new List<int>();
            string filter = $@"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.DOC} AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER}";
            filter = string.IsNullOrEmpty(txtSymbol.Text) ? filter : $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";
            dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, null, GcproTable.ObjData.Key.Name, GcproTable.ObjData.Text0.Name);

            // objInpKeyList = OleDb.GetColumnData<int>(dataTable, GcproTable.ObjData.Key.Name);
            List<string> objOutpKeyList = OleDb.GetColumnData<string>(dataTable, GcproTable.ObjData.Text0.Name);
            int quantityNeedToBeCreate = objOutpKeyList.Count;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {             
                objList.Add(GcObject.GetObjectSymbolFromIO(objOutpKeyList[i], GcObjectInfo.General.SuffixIO.Delimiter));
            }

            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;

            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                myDO.Name = objList[i];
                myDO.OutpRun = objOutpKeyList[i];
                myDO.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myDO.Elevation = ComboElevation.Text;
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet = chkAddCabinetToDesc.Checked;
                AppGlobal.AdditionDesc.Power = false;
                AppGlobal.AdditionDesc.OnlyNumber = chkNameOnlyNumber.Checked;
                AppGlobal.ProcessValue.Value = ProgressBar.Value = 0;

                CreateObjectCommon(myDO);
                if (createMode.BML)
                {
                    CreateObjectBML(
                         dataFromBML: dataGridBML,
                         objDO: myDO,
                         addtionToDesc: AppGlobal.AdditionDesc,
                         processValue: out AppGlobal.ProcessValue
                         );
                }
                else if (createMode.AutoSearch)
                {
                    CreateObjectAutoSearch(
                         objDO: myDO,
                         processValue: ref AppGlobal.ProcessValue
                         );
                }
                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreateObjectRule(
                        objDO: myDO,
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
