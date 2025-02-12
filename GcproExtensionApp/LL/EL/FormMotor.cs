using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
#region GcproExtensionLibary
using GcproExtensionLibrary.Gcpro.GCObject;
using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using System.Linq;
using System.Xml.Linq;
#endregion
namespace GcproExtensionApp
{
    #pragma warning disable IDE1006
    public partial class FormMotor : Form, IGcForm
    {
        public FormMotor()
        {
            InitializeComponent();
        }
        #region Public object in this class
        readonly Motor myMotor = new Motor(AppGlobal.GcproDBInfo.GcproTempPath);
        readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        readonly CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        //private string CONNECT_VFC = "关联VFC";
        //private string CONNECT_AO = "关联AO";
        private readonly  string DEMO_NAME_MOTOR = "=A-2001-MXZ01";
        private readonly string DEMO_NAME_RULE_MOTOR = "2001";
        private readonly string DEMO_DESCRIPTION_MOTOR = "清理线A线1楼(2001)出仓刮板机";
        private readonly string DEMO_DESCRIPTION_RULE_MOTOR = "";
        private readonly string motorSuffix = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_MOTOR}.{AppGlobal.JS_SUFFIX}.";
        private readonly string motorBMLSuffix = $"{AppGlobal.JS_BML}.{AppGlobal.JS_MOTOR}.";
        private int value9 = 2;
        private int value10 = 2;
        private int tempInt = 0;
        private long tempLong = 0;
        private float tempFloat = (float)0.0;
      //  private bool tempBool = false;
        private string namePrefix = string.Empty;
        private GcBaseRule objDefaultInfo;
        #endregion
      
        #region Public interfaces
        public void GetInfoFromDatabase()
        {
            string itemInfo;
            List<string> list;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.GcsLibaryPath, isNewOledbDriver);
            DataTable dataTable ;
            ///<ReadInfoFromGcsLibrary> 
            ///Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary 
            ///</ReadInfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={Motor.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {Motor.OTypeValue}",
                null, $"{GcproTable.ProcessFct.FieldFct_Desc.Name} ASC",
                 GcproTable.ProcessFct.FieldProcessFct.Name, GcproTable.ProcessFct.FieldFct_Desc.Name);
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.ProcessFct.FieldProcessFct.Name) + AppGlobal.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>(GcproTable.ProcessFct.FieldFct_Desc.Name);
                ComboProcessFct.Items.Add(itemInfo);
            }
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
            comboUnit.SelectedIndex = 2;

            ///<ReadInfoFromProjectDB> 
            ///Read [PType],[Building],[Elevation],[Panel]
            ///Read [DPNode1],[DPNode2],[HornCode]
            ///</ReadInfoFromProjectDB>
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            ///<PType> Read [PType] </PType>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + Motor.OTypeValue}'",
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
            objDefaultInfo.NameRule = "2001";
            objDefaultInfo.DescLine = "清理A线";
            objDefaultInfo.DescFloor = "1楼";
            objDefaultInfo.Name = "=A-2001-MXZ01";
            objDefaultInfo.DescObject = "刮板机";
            objDefaultInfo.DescriptionRuleInc = Motor.Rule.Common.DescriptionRuleInc;
            objDefaultInfo.NameRuleInc = Motor.Rule.Common.NameRuleInc;
            Motor.Rule.Common.Cabinet = Motor.Rule.Common.Power = string.Empty;

            objDefaultInfo.Description = Motor.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix: GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: chkAddCabinetToDesc.Checked,
                withPower: chkAddPowerToDesc.Checked,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (String.IsNullOrEmpty(Motor.Rule.Common.Description))
            { Motor.Rule.Common.Description = objDefaultInfo.Description; }

            if (String.IsNullOrEmpty(Motor.Rule.Common.Name))
            { Motor.Rule.Common.Name = objDefaultInfo.Name; }

            if (String.IsNullOrEmpty(Motor.Rule.Common.DescLine))
            { Motor.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (String.IsNullOrEmpty(Motor.Rule.Common.DescFloor))
            { Motor.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (String.IsNullOrEmpty(Motor.Rule.Common.DescObject))
            { Motor.Rule.Common.DescObject = objDefaultInfo.DescObject; }

            txtSymbolRule.Text = Motor.Rule.Common.NameRule;
            txtSymbolIncRule.Text = Motor.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = Motor.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = Motor.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = Motor.Rule.Common.Name;
            txtDescription.Text = Motor.Rule.Common.Description;

            txtVFCSuffix.Text = Motor.Rule.VFCRule;
            txtAOSuffix.Text = Motor.Rule.AORule;

        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + Motor.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_MOTOR);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_MOTOR);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_MOTOR);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_MOTOR);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            DataTable dataTable ;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Motor.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Motor.ImpExpRuleName}'", null);
                    CreateMotorImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateMotorImpExp(oledb);
            }

        }
        public void Default()
        {
            txtSymbol.Focus();
            txtInpFwdSuffix.Text = GcObjectInfo.Motor.SuffixInpRunFwd;
            txtOutpFwdSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunFwd;
            txtInpRevSuffix.Text = GcObjectInfo.Motor.SuffixInpRunRev;
            txtOutpRevSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunRev;
            txtVFCSuffix.Text = GcObjectInfo.Motor.SuffixVFC;
            txtPowerAppSuffix.Text = GcObjectInfo.Motor.SuffixPowerApp;
            txtAOSuffix.Text = GcObjectInfo.Motor.SuffixAO;
            txtAO.Text = String.Empty;
            txtInpRunFwd.Text = txtSymbol.Text + txtInpFwdSuffix.Text;
            txtOutpRunFwd.Text = txtSymbol.Text + txtOutpFwdSuffix.Text;

            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            TxtValue9.Text = "2";
            myMotor.Value9 = 2;

            // comboWorkSheetsBML.Enabled = false;

            CreateBMLDefault();
            ComboEquipmentSubType.SelectedIndex = 1;

            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "电机导入文件 " + " " + myMotor.FilePath;
        }
        #endregion    
        private void CreateMotorImpExp(OleDb oledb)
        {
            bool result = myMotor.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });

            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormMotor_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormMotor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSymbolRule.Text))
            { return; }
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                Motor.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    Motor.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
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
                string descObjectNumber = LibGlobalSource.StringHelper.ExtractNumericPart(Motor.Rule.Common.DescObject, false);
                if (!string.IsNullOrEmpty(descObjectNumber))
                {
                    Motor.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                    Motor.Rule.Common.DescObject = Motor.Rule.Common.DescObject.Replace(descObjectNumber, Motor.Rule.Common.DescriptionRule);
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
                    Motor.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }

        }
        private void TxtMonTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(TxtMonTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"
        private void ChkRunInterlock_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(TxtValue9.Text);
            if (ChkRunInterlock.Checked)

            { AppGlobal.SetBit(ref value9, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)1); }

            myMotor.Value9 = value9;
            TxtValue9.Text = myMotor.Value9.ToString();
        }

        private void ChkStartingInterlock_CheckedChanged(object sender, EventArgs e)
        {
            {
                value9 = int.Parse(TxtValue9.Text);
                if (ChkStartingInterlock.Checked)
                { AppGlobal.SetBit(ref value9, (byte)0); }

                else
                { AppGlobal.ClearBit(ref value9, (byte)0); }

                myMotor.Value9 = value9;
                TxtValue9.Text = myMotor.Value9.ToString();
            }
        }
        private void ChkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(TxtValue10.Text);
            if (ChkParManual.Checked)
            { AppGlobal.SetBit(ref value10, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myMotor.Value10 = value10;
            TxtValue10.Text = myMotor.Value10.ToString().ToString();
        }

        private void ChkRestartDelay_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(TxtValue10.Text);
            if (ChkRestartDelay.Checked)
            { AppGlobal.SetBit(ref value10, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }

            myMotor.Value10 = value10;
            TxtValue10.Text = myMotor.Value10.ToString();
        }

        private void ChkRevNotAllowed_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(TxtValue10.Text);
            if (ChkRevNotAllowed.Checked)
            { AppGlobal.SetBit(ref value10, (byte)7); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)7); }

            myMotor.Value10 = value10;
            TxtValue10.Text = myMotor.Value10.ToString();
        }

        private void ChKPower_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(TxtValue10.Text);
            if (ChKPower.Checked)
            { AppGlobal.SetBit(ref value10, (byte)8); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)8); }

            myMotor.Value10 = value10;
            TxtValue10.Text = myMotor.Value10.ToString();
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

        private void TxtInpRunFwd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }
        private void TxtOutpRunFwd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }
        private void TxtInHWStop_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value47";
        }

        private void TxtVFCAdapter_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value34";
        }

        private void TxtAO_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value33";
        }

        private void ComboUnit_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value40";
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

        private void TxtMonTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void TxtStartDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }

        private void TxtStartingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }

        private void TxtStoppingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }

        private void TxtIdlingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }

        private void TxtFaultDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }

        private void TxtKW_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value49";
        }
        private void txtPowerApp_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value50";
        }

        private void txtDosingBin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value32";
        }
        private void ChkParManual_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }

        private void ChkRestartDelay_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit2";
        }

        private void ChkRevNotAllowed_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit7";
        }

        private void ChKPower_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit8";
        }

        private void ChkRunInterlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit1";
        }

        private void ChkStartingInterlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit0";
        }
        #endregion
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value21.Name,
                OType = Convert.ToString(Motor.OTypeValue)
            };
            objectBrowser.Show();
        }
        private void UpdateDesc()
        {
            Motor.EncodingDesc(
            baseRule: ref Motor.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: chkAddCabinetToDesc.Checked,
            withPower: chkAddPowerToDesc.Checked,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = Motor.Rule.Common.Description;
        }
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {

            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            if (myMotor.SubType == Motor.M1VFC ||
                myMotor.SubType == Motor.M1VFC)
            {
                txtVFCAdapter.Text = txtSymbol.Text + txtVFCSuffix.Text;
            }
            else if (myMotor.SubType == Motor.M12)
            {
                txtInpRunRev.Text = txtSymbol.Text + txtInpRevSuffix.Text;
                txtOutpRunRev.Text = txtSymbol.Text + txtOutpRevSuffix.Text;
            }
            else
            {
                txtVFCAdapter.Text = AppGlobal.MOTOR_WITHOUT_VFC;
                txtInpRunFwd.Text = txtSymbol.Text + txtInpFwdSuffix.Text;
                txtOutpRunFwd.Text = txtSymbol.Text + txtOutpFwdSuffix.Text;
            }
            myMotor.Name = txtSymbol.Text;
            Motor.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!Motor.Rule.Common.Description.Equals(txtDescription.Text))
            {
                Motor.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(Motor.Rule.Common.DescObject, false);
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
                    Motor.Rule.Common.Description = txtDescription.Text;
                    Motor.DecodingDesc(ref Motor.Rule.Common, AppGlobal.DESC_SEPARATOR);
                    UpdateDesc();
                }
                catch
                {
                }
            }
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(selectedItem))
            {
                myMotor.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }

            SubtypeChanged();
            try
            {
                if (myMotor.SubType == Motor.M1VFC)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7042.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myMotor.SubType == Motor.M2VFC)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7041.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myMotor.SubType == Motor.M11)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7053.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (myMotor.SubType == Motor.M12)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7056.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (myMotor.SubType == Motor.M21)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7052.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (myMotor.SubType == Motor.M22)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7051.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtInpFwdSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRunFwd.Text = txtSymbol.Text + txtInpFwdSuffix.Text;
        }
        private void txtInpFwdSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpFwdSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorSuffix}InpRunFwd", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixInpRunFwd = newJsonKeyValue;
            }
        }
        private void txtOutpFwdSuffix_TextChanged(object sender, EventArgs e)
        {
            txtOutpRunFwd.Text = txtSymbol.Text + txtOutpFwdSuffix.Text;
        }
        private void txtOutpFwdSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpFwdSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorSuffix}OutpRunFwd", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixOutpRunFwd = newJsonKeyValue;
            }
        }

        private void txtInpRevSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRunRev.Text = txtSymbol.Text + txtInpRevSuffix.Text;
        }
        private void txtInpRevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpRevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorSuffix}InpRunRev", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixInpRunRev = newJsonKeyValue;
            }
        }
        private void txtOutRevSuffix_TextChanged(object sender, EventArgs e)
        {
            txtOutpRunRev.Text = txtSymbol.Text + txtOutpRevSuffix.Text;
        }
        private void txtOutpRevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpRevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorSuffix}OutpRunRev", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixOutpRunRev = newJsonKeyValue;
            }
        }
        private void BtnConnectVFC_Click(object sender, EventArgs e)
        {

        }
        private void txtVFCSuffix_TextChanged(object sender, EventArgs e)
        {
            txtVFCAdapter.Text = txtSymbol.Text + txtVFCSuffix.Text;
        }
        private void txtVFCSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtVFCSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorSuffix}VFC", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixVFC = newJsonKeyValue;
            }
        }
        private void txtAOSuffix_TextChanged(object sender, EventArgs e)
        {
            // txtAO.Text = txtSymbol.Text + txtAOSuffix.Text;
        }
        private void txtAOSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtAOSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorSuffix}AO", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixAO = newJsonKeyValue;
            }
        }
        private void txtPowerAppSuffix_TextChanged(object sender, EventArgs e)
        {
            //  txtPowerApp.Text = txtSymbol.Text + txtPowerAppSuffix.Text;
        }
        private void txtPowerAppSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtPowerAppSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorSuffix}PowerApp", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixPowerApp = newJsonKeyValue;
            }
        }
        private void TxtInpContactorSuffix_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txtInpHWSuffix_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txtPowerApp_TextChanged(object sender, EventArgs e)
        {

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
            BML.Motor.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorBMLSuffix}Path", BML.Motor.BMLPath);

        }

        private void txtVFCPrefixBML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtVFCPrefixBML.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorBMLSuffix}VFC", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixPowerApp = newJsonKeyValue;
            }
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
           
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
            txtVFCPrefixBML.Text = BML.Motor.PrefixVFC;
            var alphabetList = AppGlobal.CreateAlphabetList<string>('A', 'Z', letter => letter.ToString());
            foreach (var item in alphabetList)
            {
                comboNameBML.Items.Add(item);
                comboDescBML.Items.Add(item);
                comboTypeBML.Items.Add(item);
                comboFloorBML.Items.Add(item);
                comboPowerBML.Items.Add(item);
                comboSectionBML.Items.Add(item);
                comboCabinetBML.Items.Add(item);
                comboControlBML.Items.Add(item);
                comboLineBML.Items.Add(item);
            }
            comboNameBML.SelectedItem = "B";
            comboDescBML.SelectedItem = "N";
            comboTypeBML.SelectedItem = "C";
            comboFloorBML.SelectedItem = "L";
            comboPowerBML.SelectedItem = "E";
            comboCabinetBML.SelectedItem = "P";
            comboSectionBML.SelectedItem = "Q";
            comboControlBML.SelectedItem = "H";
            comboLineBML.SelectedItem = "X";
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text = BML.Motor.BMLPath;
            AddWorkSheets();
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

            dataGridBML.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = BML.ColumnIsVFC,
                Name = nameof(BML.ColumnIsVFC)
            });

            dataGridBML.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = BML.ColumnIsFCFan,
                Name = nameof(BML.ColumnIsFCFan)
            });

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnPower,
                Name = nameof(BML.ColumnPower)
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
                HeaderText = BML.ColumnLine,
                Name = nameof(BML.ColumnLine)
            });
        }
        private void btnReadBML_Click(object sender, EventArgs e)
        {
            // List<List<object>> allData = new List<List<object>>();
            string[] columnList = { comboNameBML.Text, comboDescBML.Text, comboControlBML.Text,"ZZ",comboPowerBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboLineBML.Text};
            DataTable dataTable;
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, BML.Motor.Type, comboTypeBML.Text);

            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnPower)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinet)].DataPropertyName = dataTable.Columns[6].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[7].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnLine)].DataPropertyName = dataTable.Columns[8].ColumnName;
            TxtQuantity.Text = dataTable.Rows.Count.ToString();
            foreach (DataRow row in dataTable.Rows)
            {
                bool vfc = row[2].ToString().StartsWith(!String.IsNullOrEmpty(txtVFCPrefixBML.Text) ? txtVFCPrefixBML.Text : BML.Motor.PrefixVFC);
                bool fcFan = row[2].ToString().Contains(BML.Motor.FCFan);
                int rowIndex = dataTable.Rows.IndexOf(row);
                DataGridViewRow dataGridViewRow = dataGridBML.Rows[rowIndex];
                dataGridViewRow.Cells[nameof(BML.ColumnIsVFC)].Value = vfc;
                dataGridViewRow.Cells[nameof(BML.ColumnIsFCFan)].Value = fcFan;

            }
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
        private void TxtKW_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtKW.Text))
            {
                Motor.Rule.Common.Power = $"{GcObjectInfo.General.AddInfoPower}{TxtKW.Text}";
                UpdateDesc();
            }
        }

        private void ComboPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboPanel.Text))
            {
                Motor.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motor.Rule.Common.DescFloor = ComboElevation.Text;
            UpdateDesc();
        }
        #region Genate elements name    
        private void NamePrefix()
        {
            namePrefix = txtSymbol.Text;
        }
        private void M11SubElements(string _namePrefix)
        {
            txtInpFwdSuffix.Text = GcObjectInfo.Motor.SuffixInpRunFwd;
            txtOutpFwdSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunFwd;
            txtInpRunFwd.Text = _namePrefix + txtInpFwdSuffix.Text;
            txtOutpRunFwd.Text = _namePrefix + txtOutpFwdSuffix.Text;
            txtInpRunRev.Text = string.Empty;
            txtOutpRunRev.Text = string.Empty;
            txtVFCAdapter.Text = AppGlobal.MOTOR_WITHOUT_VFC;
        }
        private void M12SubElements(string _namePrefix)
        {
            M11SubElements(_namePrefix);
            txtInpFwdSuffix.Text = GcObjectInfo.Motor.SuffixInpRunFwd + "1";
            txtOutpFwdSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunFwd + "1";

            txtInpRevSuffix.Text = GcObjectInfo.Motor.SuffixInpRunRev;
            txtOutpRevSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunRev;

            txtInpRunFwd.Text = _namePrefix + txtInpFwdSuffix.Text;
            txtOutpRunFwd.Text = _namePrefix + txtOutpFwdSuffix.Text;
            txtInpRunRev.Text = _namePrefix + txtInpRevSuffix.Text;
            txtOutpRunRev.Text = _namePrefix + txtOutpRevSuffix.Text;

        }
        private void VFCSubElements(string _namePrefix)
        {

            txtInpRunFwd.Text = string.Empty;
            txtOutpRunFwd.Text = string.Empty;
            txtInpRunRev.Text = string.Empty;
            txtOutpRunRev.Text = string.Empty;
            txtVFCAdapter.Text = _namePrefix + txtVFCSuffix.Text;
        }
        private void SubtypeChanged()
        {
            NamePrefix();
            if (myMotor.SubType == Motor.M11)
            {
                M11SubElements(namePrefix);
            }
            else if (myMotor.SubType == Motor.M12)
            {
                M12SubElements(namePrefix);
            }
            else if (myMotor.SubType == Motor.M1VFC || myMotor.SubType == Motor.M2VFC)
            {
                VFCSubElements(namePrefix);
            }
        }
        //private void NameSubElements(string _namePrefix)
        //{
        //    // NamePrefix();
        //    if (myMotor.SubType == Motor.M11)
        //    {

        //    }
        //    else if (myMotor.SubType == Motor.M12)
        //    {


        //    }
        //    else if (myMotor.SubType == Motor.M1VFC || myMotor.SubType == Motor.M2VFC)
        //    {


        //    }
        //}
        #endregion Genate elements name
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                // txtSymbolRule.Text = Motor.Rule.Common.NameRule;
                // txtSymbolIncRule.Text = Motor.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                //txtSymbol.Text = DEMO_NAME_MOTOR;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                //   txtSymbolRule.Text = Motor.Rule.Common.NameRule;
                //   txtSymbolIncRule.Text = Motor.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                GrpSymbolRule.Visible = false;
                LblSymbol.Text = AppGlobal.KEY_WORD_AUTOSEARCH;
                // txtSymbol.Text = "-MXZ";
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
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={Motor.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.SubType.Name,
                        GcproTable.ObjData.Value11.Name, GcproTable.ObjData.Value12.Name, GcproTable.ObjData.Value13.Name,
                        GcproTable.ObjData.Value14.Name, GcproTable.ObjData.Value38.Name, GcproTable.ObjData.Value47.Name,
                         GcproTable.ObjData.Value34.Name, GcproTable.ObjData.Value50.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    Motor.Clear(myMotor.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        if (objSubType == Motor.M11)
                        {
                            string inpFwd, outpFwd;
                            inpFwd = objName + txtInpFwdSuffix.Text;
                            outpFwd = objName + txtOutpFwdSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, outpFwd, GcproTable.ObjData.Value12.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else if (objSubType == Motor.M12)
                        {
                            string inpFwd, outpFwd, inpRev, outpRev;
                            inpFwd = objName + txtInpFwdSuffix.Text;
                            outpFwd = objName + txtOutpFwdSuffix.Text;
                            inpRev = objName + txtInpRevSuffix.Text;
                            outpRev = objName + txtOutpRevSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, outpFwd, GcproTable.ObjData.Value12.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value13.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, inpRev, GcproTable.ObjData.Value13.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value14.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, outpRev, GcproTable.ObjData.Value14.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else if (objSubType == Motor.M1VFC || objSubType == Motor.M2VFC)
                        {
                            if (all)
                            {
                                string vfc = objName + txtVFCSuffix.Text;
                                Motor.CreateRelation(objName, vfc, GcproTable.ObjData.Value34.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            else
                            {
                                double connectorKey = dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value34.Name);
                                if (connectorKey != 0)
                                {

                                    DataTable connectorTable = new DataTable();
                                    connectorTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Key.Name}={connectorKey}", null,
                                    null, GcproTable.ObjData.Value11.Name);
                                    if (connectorTable != null)
                                    {
                                        double connector = connectorTable.Rows[0].Field<double>(GcproTable.ObjData.Value11.Name);
                                        if (connector == LibGlobalSource.NO_PARENT)
                                        {
                                            string vfc = objName + txtVFCSuffix.Text;
                                            Motor.CreateRelation(objName, vfc, GcproTable.ObjData.Value34.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                                        }
                                    }
                                    connectorTable.Rows.Clear();
                                }
                            }

                        }
                        else
                        {
                            string inpFwd, outPFwd;
                            inpFwd = objName + txtInpFwdSuffix.Text;
                            outPFwd = objName + txtOutpFwdSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, outPFwd, GcproTable.ObjData.Value12.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        if (!String.IsNullOrEmpty(txtInpContactor.Text))
                        {
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value38.Name) == 0 || all)
                            {
                                string inpContactor = objName + txtInpContactor.Text;
                                Motor.CreateRelation(objName, inpContactor, GcproTable.ObjData.Value38.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        if (!String.IsNullOrEmpty(txtInHWStop.Text))
                        {
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value47.Name) == 0 || all)
                            {
                                string InHWStop = objName + txtInHWStop.Text; ;
                                Motor.CreateRelation(objName, InHWStop, GcproTable.ObjData.Value47.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        if (!String.IsNullOrEmpty(txtPowerApp.Text))
                        {
                            if (all)
                            {
                                string powerApp = objName + txtPowerAppSuffix.Text; ;
                                Motor.CreateRelation(objName, powerApp, GcproTable.ObjData.Value50.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            else
                            {
                                double connectorKey = dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value50.Name);
                                if (connectorKey != 0)
                                {
                                    DataTable connectorTable = new DataTable();
                                    connectorTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Key.Name}={connectorKey}", null,
                                    null, GcproTable.ObjData.Value11.Name);
                                    if (connectorTable != null)
                                    {
                                        double connector = connectorTable.Rows[0].Field<double>(GcproTable.ObjData.Value11.Name);
                                        if (connector == LibGlobalSource.NO_PARENT)
                                        {
                                            string powerApp = objName + txtPowerAppSuffix.Text;
                                            Motor.CreateRelation(objName, powerApp, GcproTable.ObjData.Value50.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                                        }
                                    }
                                    connectorTable.Rows.Clear();
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(txtAO.Text))
                        {
                            if (all)
                            {
                                string ao = objName + txtAOSuffix.Text;
                                Motor.CreateRelation(objName, ao, GcproTable.ObjData.Value33.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            else
                            {
                                double connectorKey = dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value33.Name);
                                if (connectorKey != 0)
                                {
                                    DataTable connectorTable = new DataTable();
                                    connectorTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Key.Name}={connectorKey}", null,
                                    null, GcproTable.ObjData.Value11.Name);
                                    if (connectorTable != null)
                                    {
                                        double connector = connectorTable.Rows[0].Field<double>(GcproTable.ObjData.Value11.Name);
                                        if (connector == LibGlobalSource.NO_PARENT)
                                        {
                                            string ao = objName + txtAOSuffix.Text;
                                            Motor.CreateRelation(objName, ao, GcproTable.ObjData.Value33.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                                        }
                                    }
                                    connectorTable.Rows.Clear();
                                }
                            }

                        }
                        ProgressBar.Value = count;
                    }
                    Motor.SaveFileAs(myMotor.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
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
                myMotor.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            Motor.SaveFileAs(myMotor.FilePath, LibGlobalSource.CREATE_OBJECT);
            Motor.SaveFileAs(myMotor.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
                OleDb oledb = new OleDb
                {
                    DataSource = AppGlobal.GcproDBInfo.ProjectDBPath,
                    IsNewOLEDBDriver = isNewOledbDriver
                };
                Motor.ReGenerateDPNode(oledb);

            }
        }
        private void CreateObjectCommon(Motor objMotor)
        {
            ///<ParMonTime></ParMonTime>
            objMotor.ParMonTime = AppGlobal.ParseValue<float>(TxtMonTime.Text, out tempFloat) ? Math.Round(tempFloat ,1) : 2.0;
            ///<ParStartDelay></ParStartDelay>
            objMotor.ParStartDelay = AppGlobal.ParseValue<float>(TxtStartDelayTime.Text, out tempFloat) ? Math.Round(tempFloat, 1) : 2.0;
            ///<ParStartingTime></ParStartingTime>
            objMotor.ParStartingTime = AppGlobal.ParseValue<float>(TxtStartingTime.Text, out tempFloat) ? Math.Round(tempFloat, 1) : 2.0;
            ///<ParStoppingTime></ParStoppingTime>
            objMotor.ParStoppingTime = AppGlobal.ParseValue<float>(TxtStoppingTime.Text, out tempFloat) ? Math.Round(tempFloat, 1) : 0.0;
            ///<ParIdlingTime></ParIdlingTime>
            objMotor.ParIdlingTime = AppGlobal.ParseValue<float>(TxtIdlingTime.Text, out tempFloat) ? Math.Round(tempFloat, 1) : 1.0;
            ///<ParFaultDelayTime></ParFaultDelayTime>
            objMotor.ParFaultDelayTime = AppGlobal.ParseValue<float>(TxtFaultDelayTime.Text, out tempFloat) ? Math.Round(tempFloat, 1) : 1.0;

            string selectedProcessFct;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                objMotor.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objMotor.Diagram = Motor.ParseInfoValue(selectedDiagram, AppGlobal.FIELDS_SEPARATOR, AppGlobal.NO_DIAGRAM); 
            }
            ///<Unit></Unit>
            string selectedUnit;
            if (comboUnit.SelectedItem != null)
            {
                selectedUnit = comboUnit.SelectedItem.ToString();
                objMotor.Unit = Motor.ParseInfoValue(selectedUnit, AppGlobal.FIELDS_SEPARATOR, AppGlobal.NONE_UNIT);
            }
            ///<Page></Page>
            objMotor.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling ;
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objMotor.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objMotor.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objMotor.Panel_ID = selectedPanel_ID;
            }
            ///<InpFwd></InpFwd>
            objMotor.InpFwd = LibGlobalSource.NOCHILD;
            ///<OutpFwd></OutFwd>
            objMotor.OutpFwd = LibGlobalSource.NOCHILD;
            ///<InpRev></InpRev>
            objMotor.InpRev = LibGlobalSource.NOCHILD;
            ///<OutpRev></OutpRev>
            objMotor.OutpRev = LibGlobalSource.NOCHILD;
            ///<InpContactor></InpContactor>
            objMotor.InpContactor = txtInpContactor.Text;
            ///<InHWStop></InHWStop>
            ///<Adapter></Adapter>
            objMotor.Adapter = LibGlobalSource.NOCHILD;
            ///<PowerApp></PowerApp>
            ///<AO></AO>
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datafromBML">DataGridView</param>
        /// <param name="objMotor">Class Motor</param>
        /// <param name="parValue9">parameter Value9</param> 
        /// <param name="addtionToDesc"></param>
        /// <param name="processValue"></param>
        public void CreateObjectBML(DataGridView dataFromBML, Motor objMotor, long parValue9,
            (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
            out (int Value, int Max) processValue)
        {
            int quantityNeedToBeCreate = dataFromBML.Rows.Count;
            SuffixObject suffixObject = new SuffixObject();
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
           
            bool numeric, motorWithVFC,fcFan;
            bool isMDDxFeeder;
            bool planSifter, purifier, laab, hm;
           // float power;
            int tmpInt;
            long parValue10 = 130;
            string _nameNumberString;
            string desc;
            string columnPower;;
            DataGridViewCell cell;
            objDefaultInfo = Motor.Rule.Common;
            MachineType machines = new MachineType();
            //   StringBuilder descBuilder = new StringBuilder();
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                parValue10 = 130;
                cell = dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                { continue; }             
                fcFan = Convert.ToBoolean(dataFromBML.Rows[i].Cells[nameof(BML.ColumnIsFCFan)].Value);
                if (fcFan)
                { continue; }
                desc = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value);
                if (desc.Contains(suffixObject.GetValue("KCL")))
                 { continue; }
                motorWithVFC = Convert.ToBoolean(dataFromBML.Rows[i].Cells[nameof(BML.ColumnIsVFC)].Value);
                objMotor.InpFwd = LibGlobalSource.NOCHILD;
                objMotor.OutpFwd = LibGlobalSource.NOCHILD;
                objMotor.Name = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)].Value);
              
                objMotor.SubType = motorWithVFC ? Motor.M1VFC : Motor.M11;
                objMotor.PType = motorWithVFC ? Motor.P7042: Motor.P7053;
                columnPower = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnPower)].Value);
                if (!String.IsNullOrEmpty(columnPower))
                {
                    numeric = AppGlobal.ParseValue<float>(Convert.ToString(columnPower), out float power);
                    //tmpInt = Motor.GetStartingTime(power);
                    //objMotor.ParMonTime = numeric ? tmpInt : 10.0;
                    //objMotor.ParStartingTime = numeric ? (tmpInt - 1.0) : 3.0;
                    objMotor.ParPowerNominal = numeric? power : 0;
                }
                else
                {
                    objMotor.ParMonTime = 5.0;
                    objMotor.ParStartingTime = 2.0;
                    objMotor.ParPowerNominal = 0;
                }
                //List need stopping time machines
                planSifter = desc.Contains(BML.MachineType.PlanSifter);
                purifier = desc.Contains(BML.MachineType.Purifier);
                laab = desc.Contains(BML.MachineType.LAAB);
                hm = desc.Contains(BML.MachineType.HammerMill);
                if (planSifter || purifier || laab || hm)
                {
                    AppGlobal.SetBit(ref parValue10, (byte)2);
                    if (planSifter)
                    {
                        numeric = AppGlobal.ParseValue<int>(machines.StoppingTime.PlanSifter, out tmpInt);
                        objMotor.ParStoppingTime = numeric ? tmpInt  : 150.0;
                    }
                    else if (purifier)
                    {
                        numeric = AppGlobal.ParseValue<int>(machines.StoppingTime.Purifier, out tmpInt);
                        objMotor.ParStoppingTime = numeric ? tmpInt : 120.0;
                    }
                    else if (laab)
                    {
                        numeric = AppGlobal.ParseValue<int>(machines.StoppingTime.LAAB, out tmpInt);
                        objMotor.ParStoppingTime = numeric ? tmpInt : 180.0;
                    }
                    else if (hm)
                    {
                        numeric = AppGlobal.ParseValue<int>(machines.StoppingTime.Hammermill, out tmpInt);
                        objMotor.ParStoppingTime = numeric ? tmpInt : 300.0;
                    }
                }
                else
                {
                    objMotor.ParStoppingTime = 1.0;
                }
                objMotor.Value9 = parValue9;
                objMotor.Value10 = parValue10;
                objMotor.Adapter = motorWithVFC ? $"{objMotor.Name}{txtVFCSuffix.Text}" : LibGlobalSource.NOCHILD;
                isMDDxFeeder = (((objMotor.Name.Contains(GcObjectInfo.MA_Roll8Stand.SiffixSide1.FeedRoll) || objMotor.Name.Contains(GcObjectInfo.MA_Roll8Stand.SiffixSide2.FeedRoll)) && motorWithVFC) &&
                     desc.Contains(BML.MachineType.RollerMiller)) || desc.Contains(BML.MachineType.FeederRollerMiller);
                objMotor.ProcessFct = isMDDxFeeder ? Motor.PF1012MDDXFEED : string.Empty;

                if (objMotor.SubType == Motor.M11)
                {
                    objMotor.InpFwd = $"{objMotor.Name}{txtInpFwdSuffix.Text}";
                    objMotor.OutpFwd = $"{objMotor.Name}{txtOutpFwdSuffix.Text}";
                }
                else if (objMotor.SubType == Motor.M12)
                {
                    objMotor.InpFwd = $"{objMotor.Name}{txtInpFwdSuffix.Text}";
                    objMotor.OutpFwd = $"{objMotor.Name}{txtOutpFwdSuffix.Text}";
                    objMotor.InpRev = $"{objMotor.Name}{txtInpRevSuffix.Text}";
                    objMotor.OutpRev = $"{objMotor.Name}{txtOutpRevSuffix.Text}";
                }
                objMotor.Panel_ID = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value) +
                    Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                objMotor.Elevation = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);
                ///<AdditionInfoToDesc>
                ///</AdditionInfoToDesc>
                if (addtionToDesc.Section)
                {
                    _nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, objMotor.Name);
                    if (!string.IsNullOrEmpty(_nameNumberString))
                    {
                        if (AppGlobal.ParseValue<int>(_nameNumberString.Substring(0, 4), out tempInt))
                        {
                            Motor.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.UserDefSection)
                {
                    Motor.Rule.Common.DescLine = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value); ;
                }

                Motor.Rule.Common.Name = objMotor.Name;
                Motor.Rule.Common.DescFloor = $"{objMotor.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                Motor.Rule.Common.DescObject = desc;
                Motor.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{objMotor.Panel_ID}";
                Motor.Rule.Common.Power = $"{GcObjectInfo.General.AddInfoPower}{objMotor.ParPowerNominal}";
                objMotor.Description = Motor.EncodingDesc(
                    baseRule: ref Motor.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );

                objMotor.CreateObject(Encoding.Unicode);
                processValue.Value = i;

            }
            Motor.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
        private void CreateObjectRule(Motor objMotor, (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
         ref (int Value, int Max) processValue)
        {

            int quantityNeedToBeCreate = processValue.Max;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
            string desc = string.Empty;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);        
            #region common used variables declaration
            bool motorWithVFC = false;
            bool needDPNodeChanged = false;
            // bool additionInfToDesc = false;
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
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                myMotor.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                motorWithVFC = myMotor.SubType == Motor.M1VFC || myMotor.SubType == Motor.M2VFC;
            }
            else
            {
                myMotor.SubType = Motor.M11;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (ComboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();

               AppGlobal.ParseValue<float>( selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR)),out tempFloat);
                myMotor.PType = tempFloat;
            }
            else
            {
                myMotor.PType = Motor.P7053;
            }
            ///<ParPowerNominal></ParPowerNominal>
            myMotor.ParPowerNominal = AppGlobal.ParseValue<float>(TxtKW.Text, out tempFloat) ? Math.Round(tempFloat,2) : 0.0;
            ///<Value9>Value is set when corresponding check box's check state changed</Value9>
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            myMotor.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>       
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            ///<DPNode1></DPNode1>
            string selectDPNode1 = String.Empty;
            if (ComboDPNode1.SelectedItem != null)
            {
                selectDPNode1 = ComboDPNode1.SelectedItem.ToString();
              
            }
            ///<DPNode2></DPNode2>
            string selectDPNode2 = String.Empty;
            if (ComboDPNode2.SelectedItem != null)
            {
                //    selectDPNode2 = ComboDPNode2.SelectedItem.ToString();
                //    objMotor.DPNode2 = Motor.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                //    {
                //        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                //    }, selectDPNode2);
            }
            if (ComboHornCode.SelectedItem != null)
            {
                string hornCode = ComboHornCode.SelectedItem.ToString();
                myMotor.HornCode = Motor.ParseInfoValue(hornCode, AppGlobal.HORNCODE_FIELDS_SEPARATOR, AppGlobal.GROUP_HORNCODE);
            }

            #endregion

            #region Parse rules
            ///<ParseRule> </ParseRule>
            if (!AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out tempInt))
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
                needDPNodeChanged = motorWithVFC;
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
            desc = Motor.Rule.Common.DescObject;
            if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
            {
                description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(desc, txtDescriptionRule.Text);
                if (description.PosInfo.Len == -1)
                {
                    if (moreThanOne)
                    {
                        AppGlobal.RuleNotSetCorrect($"{GrpDescriptionRule.Text}.{LblDescriptionRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                        // return;
                    }
                }
                else
                {
                    description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(desc, txtDescriptionRule.Text);
                }
            }
            #endregion

            processValue.Value = 0;
            objDefaultInfo = Motor.Rule.Common;
            ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
           // int symbolInc,symbolRule, descriptionInc;
            AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out int symbolInc);
            AppGlobal.ParseValue<int>(txtSymbolRule.Text, out int symbolRule);
            AppGlobal.ParseValue<int>(txtDescriptionIncRule.Text, out int descriptionInc);
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {

                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                if (!motorWithVFC)
                {
                    if (objMotor.SubType == Motor.M11)
                    {
                        objMotor.InpFwd = $"{name.Name}{txtInpFwdSuffix.Text}";
                        objMotor.OutpFwd = $"{name.Name}{txtOutpFwdSuffix.Text}";
                    }
                    else if (objMotor.SubType == Motor.M12)
                    {
                        objMotor.InpFwd = $"{name.Name}{txtInpFwdSuffix.Text}";
                        objMotor.OutpFwd = $"{name.Name}{txtOutpFwdSuffix.Text}";
                        objMotor.InpRev = $"{name.Name}{txtInpRevSuffix.Text}";
                        objMotor.OutpRev = $"{name.Name}{txtOutpRevSuffix.Text}";
                    }
                }
                else
                {
                    objMotor.Adapter = $"{name.Name}{txtVFCSuffix.Text}";
                }
                objMotor.PowerApp = String.IsNullOrEmpty(txtPowerApp.Text) ? string.Empty : $"{name.Name}{txtPowerAppSuffix.Text}";
                objMotor.AO = String.IsNullOrEmpty(txtAO.Text) ? string.Empty : $"{name.Name}{txtAOSuffix.Text}";
                objMotor.HWStop = String.IsNullOrEmpty(txtInHWStop.Text) ? string.Empty : txtInHWStop.Text;

                if (needDPNodeChanged && moreThanOne)
                {
                    dpNode1.Inc = i * symbolInc;
                    dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());
                    AppGlobal.FieldbusNodeInfo = DI.ParseFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, dpNode1.Name);

                    objMotor.DPNode1 = AppGlobal.FieldbusNodeInfo.DPNodeNo;
                    objMotor.FieldBusNode = AppGlobal.FieldbusNodeInfo.FieldBusNodeKey;
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
                    description.Name = "电机";
                }
                objMotor.Name = name.Name;
                Motor.Rule.Common.Name = name.Name;
                Motor.Rule.Common.DescObject = description.Name;
                // Motor.Rule.Common.Cabinet =$"{GcObjectInfo.General.AddInfoCabinet}{Motor.Rule.Common.Cabinet}";
                Motor.Rule.Common.Power = $"{GcObjectInfo.General.AddInfoPower}{objMotor.ParPowerNominal}";
                objMotor.Description = Motor.EncodingDesc(
                    baseRule: ref Motor.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );

                //  myMotor.Description = description.Name;

                objMotor.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            Motor.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
        private void CreateObjectAutoSearch(Motor objMotor, ref (int Value, int Max) processValue)
        {
            List<GcObjectInfo.Motor.SimpleInfo> obj = new List<GcObjectInfo.Motor.SimpleInfo>();
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);    
            DataTable dataTable ;
            string filter = $@"({GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.DOC} OR {GcproTable.ObjData.OType.Name} = {VFCAdapter.OTypeValue}) " +
                            $@"AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER} AND {GcproTable.ObjData.Text0.Name} LIKE '%{GcObjectInfo.Motor.SuffixMotor}%'";
            filter = string.IsNullOrEmpty(txtSymbol.Text) ? filter : $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";

            dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, $"[{GcproTable.ObjData.Key.Name}] ASC", $"[{GcproTable.ObjData.Key.Name}]", $"[{GcproTable.ObjData.Text0.Name}]", $"[{GcproTable.ObjData.OType.Name}]");
            List<Dictionary<string, string>> objSubList = OleDb.GetColumnsData<string>(dataTable, GcproTable.ObjData.Text0.Name, GcproTable.ObjData.OType.Name);
            GcObjectInfo.Motor.SimpleInfo updatedItem;
            for (int listIndex = 0; listIndex < objSubList.Count; listIndex++)
            {
                var dictionary = objSubList[listIndex];
                var keys = new List<string>(dictionary.Keys);
                bool isVFC = dictionary[keys[1]] == VFCAdapter.OTypeValue.ToString();
                string _nameIO = GcObject.GetObjectSymbolFromIO(dictionary[keys[0]], GcObjectInfo.General.SuffixIO.Delimiter);
                string _nameVFC = GcObject.GetObjectSymbolFromIO(dictionary[keys[0]], GcObjectInfo.Motor.SuffixVFC);
                string _name = string.IsNullOrEmpty(_nameIO) ? _nameVFC : _nameIO;             
                byte _count = 1;
                if (listIndex == 0)
                {
                    obj.Add(new GcObjectInfo.Motor.SimpleInfo(_name, isVFC, _count));

                }
                else if (listIndex > 0)
                {
                    bool found = false;
                    for (int listIndexPrev = 0; listIndexPrev < listIndex; listIndexPrev++)
                    {
                        var dictionaryPrev = objSubList[listIndexPrev];
                        var keysPrev = new List<string>(dictionaryPrev.Keys);
                        string _nameIOPrev = GcObject.GetObjectSymbolFromIO(dictionaryPrev[keysPrev[0]], GcObjectInfo.General.SuffixIO.Delimiter);
                        string _nameVFCPrev = GcObject.GetObjectSymbolFromIO(dictionaryPrev[keysPrev[0]], GcObjectInfo.Motor.SuffixVFC);
                        string _namePrev = string.IsNullOrEmpty(_nameIOPrev) ? _nameVFCPrev : _nameIOPrev;

                        if (_name.Equals(_namePrev))
                        {
                          
                            found = true;
                            for (int indexObj = 0; indexObj <= obj.Count - 1; indexObj++)
                            {
                                updatedItem = obj[indexObj];
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
                        obj.Add(new GcObjectInfo.Motor.SimpleInfo(_name, isVFC, _count));
                    }
                }
            }
            processValue.Max = obj.Count;
            processValue.Value = 0;
            for (int i = 0; i <= obj.Count - 1; i++)
            {
                //updatedItem = obj[i];
                objMotor.Name = obj[i].Name;
                objMotor.Description = txtDescription.Text;
                if (obj[i].IsVFC)
                {
                    objMotor.SubType = Motor.M1VFC;
                    objMotor.PType = Motor.P7042;
                    objMotor.Adapter = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixVFC}";
                }
                else if (obj[i].Count == 2)
                {
                    objMotor.SubType = Motor.M12;
                    objMotor.PType = Motor.P7056;
                    objMotor.OutpFwd = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixOutpRunFwd}1";
                    objMotor.InpFwd = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixInpRunFwd}1";
                    objMotor.OutpRev = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixOutpRunRev}";
                    objMotor.InpRev = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixInpRunRev}";
                }
                else
                {
                    objMotor.SubType = Motor.M11;
                    objMotor.PType = Motor.P7053;
                    objMotor.OutpFwd = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixOutpRunFwd}";
                    objMotor.InpFwd = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixInpRunFwd}";
                }

                objMotor.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myMotor.Elevation = ComboElevation.Text;
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet = chkAddCabinetToDesc.Checked;
                AppGlobal.AdditionDesc.Power = chkAddPowerToDesc.Checked;
                AppGlobal.AdditionDesc.OnlyNumber = chkNameOnlyNumber.Checked;
                AppGlobal.ProcessValue.Value = ProgressBar.Value = 0;
       
                CreateObjectCommon(myMotor);
                if (createMode.BML)
                {
                    AppGlobal.ParseValue<long>(TxtValue9.Text, out tempLong);
                    CreateObjectBML(
                        dataFromBML: dataGridBML,
                        objMotor: myMotor,
                        parValue9: tempLong,
                        addtionToDesc: AppGlobal.AdditionDesc,
                        processValue: out AppGlobal.ProcessValue
                        );
                }
                else if (createMode.AutoSearch)
                {
                    CreateObjectAutoSearch(
                         objMotor: myMotor,
                         processValue: ref AppGlobal.ProcessValue
                         );
                }
                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreateObjectRule(
                        objMotor: myMotor,
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
