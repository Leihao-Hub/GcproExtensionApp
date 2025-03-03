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
    #pragma warning disable IDE1006
    public partial class FormMA_MotorWithBypass : Form, IGcForm
    {
        public FormMA_MotorWithBypass()
        {
            InitializeComponent();
        }
        #region Public object in this class
        readonly MotorWithBypass myMotorWithBypass= new MotorWithBypass(AppGlobal.GcproDBInfo.GcproTempPath);
        readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        readonly CreateMode createMode = new CreateMode();
        List<KeyValuePair<string, int>> listBMLName = new List<KeyValuePair<string, int>>();
        private bool isNewOledbDriver;
        private const string MON1 = "Mon1";
        private const string OSILLATION_SENSOR= "OscillationSensor";
        private const string AI= "AI";
        private const string TEMPERATURE_SENSOR = "TemperatureSensor";
        private GcBaseRule objDefaultInfo;
        
        #endregion
        private int value10 ;
        private int value9;
        private int tempInt = 0;
      //  private bool tempBool = false;
        #region Public interfaces
        public void GetInfoFromDatabase()
        {
            string itemInfo;
            List<string> list;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.GcsLibaryPath, isNewOledbDriver);
            DataTable dataTable;
            ///<ReadInfoFromGcsLibrary> 
            ///Read [SubType],[ProcessFct]from GcsLibrary 
            ///</ReadInfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={MotorWithBypass.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {MotorWithBypass.OTypeValue}",
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
            ///</ReadInfoFromProjectDB>
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            ///<PType> Read [PType] </PType>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + MotorWithBypass.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboEquipmentInfoType.Items.Add(column.ToString());
            }
            ComboEquipmentInfoType.SelectedIndex = 0;

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
            objDefaultInfo.NameRule = "4100";
            objDefaultInfo.DescLine = "制粉A线";
            objDefaultInfo.DescFloor = "4楼";
            objDefaultInfo.Name = "=A-4100";
            objDefaultInfo.DescObject = "打麸机";
            objDefaultInfo.Description = MotorWithBypass.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix :GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: false,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (string.IsNullOrEmpty(MotorWithBypass.Rule.Common.Description))
            { MotorWithBypass.Rule.Common.Description = objDefaultInfo.Description; }

            if (string.IsNullOrEmpty(MotorWithBypass.Rule.Common.Name))
            { MotorWithBypass.Rule.Common.Name = objDefaultInfo.Name; }

            if (string.IsNullOrEmpty(MotorWithBypass.Rule.Common.DescLine))
            { MotorWithBypass.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (string.IsNullOrEmpty(MotorWithBypass.Rule.Common.DescFloor))
            { MotorWithBypass.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (string.IsNullOrEmpty(MotorWithBypass.Rule.Common.DescObject))
            { MotorWithBypass.Rule.Common.DescObject = objDefaultInfo.DescObject; }

            //  myMotorWithBypass.DecodingDesc(ref MotorWithBypass.Rule.Common, AppGlobal.DESC_SEPARATOR);

            txtSymbolRule.Text = MotorWithBypass.Rule.Common.NameRule;
            txtSymbolIncRule.Text = MotorWithBypass.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = MotorWithBypass.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = MotorWithBypass.Rule.Common.DescriptionRuleInc;
            txtDescription.Text = MotorWithBypass.Rule.Common.Description;
            txtSymbol.Text =  MotorWithBypass.Rule.Common.Name;

            txtMotorIncRule.Text = MotorWithBypass.Rule.Common.NameRuleInc;
            txtMon1IncRule.Text = MotorWithBypass.Rule.Mon1RuleInc.ToString();
            txtMon2IncRule.Text = MotorWithBypass.Rule.Mon2RuleInc.ToString();
            txtVLS1IncRule.Text = MotorWithBypass.Rule.VLS1RuleInc.ToString();
            txtVLS2IncRule.Text = MotorWithBypass.Rule.VLS2RuleInc.ToString();
            txtAIIncRule.Text = MotorWithBypass.Rule.AIRuleInc.ToString();
            txtSealIncRule.Text = MotorWithBypass.Rule.SealRuleInc.ToString();
            txtPressureIncRule.Text = MotorWithBypass.Rule.PressureRuleInc.ToString();

            
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + MotorWithBypass.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + objDefaultInfo.Name);
          //  toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + Mo);
            //toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_MOTOR_WITH_BYPASS);
            //toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_MOTOR_WITH_BYPASS);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            DataTable dataTable;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{MotorWithBypass.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{MotorWithBypass.ImpExpRuleName}'", null);
                    CreateMotorWithBypassImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateMotorWithBypassImpExp(oledb);
            }

        }
        public void Default()
        {
            txtSymbol.Focus();
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
         //   ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
         //   ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;      
            txtValue10.Text = myMotorWithBypass.Value10.ToString().ToString();
            value10 = int.Parse(txtValue10.Text);
            txtValue9.Text = myMotorWithBypass.Value9.ToString().ToString();
            value9 = int.Parse(txtValue9.Text);
            //暂时隐藏BML Tab
            TabPage tabToHide = tabCreateMode.TabPages["tabBML"];
            tabCreateMode.TabPages.Remove(tabToHide);
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "MA_MotorWithBypass导入文件 " + " " + myMotorWithBypass.FilePath;
        }
        #endregion
        private void CreateMotorWithBypassImpExp(OleDb oledb)
        {

            bool result = myMotorWithBypass.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormMA_MotorWithBypass_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetInfoFromDatabase();
            GetLastObjRule();        
            CreateTips();
            Default();
        }
        private void FormMA_MotorWithBypassClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>

        private void UpdateDesc()
        {
            MotorWithBypass.EncodingDesc(
            baseRule: ref MotorWithBypass.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: false,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = MotorWithBypass.Rule.Common.Description;
        }
        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            myMotorWithBypass.Name = txtSymbol.Text;
            MotorWithBypass.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
            SubTypeChanged();
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
           if (!MotorWithBypass.Rule.Common.Description.Equals(txtDescription.Text))
            {
                MotorWithBypass.Rule.Common.Description = txtDescription.Text;
               // myMotorWithBypass.DecodingDesc(ref MotorWithBypass.Rule.Common, AppGlobal.DESC_SEPARATOR);
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, txtDescription.Text);
        }
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MotorWithBypass.Rule.Common.Description = txtDescription.Text;
                MotorWithBypass.DecodingDesc(ref MotorWithBypass.Rule.Common, AppGlobal.DESC_SEPARATOR);
                UpdateDesc();
            }
        }
        private void txtMon1_TextChanged(object sender, EventArgs e)
        {
            txtMon1Rule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtMon1.Text, false);
            SetValue10AndElements();
        }

        private void txtMotor_TextChanged(object sender, EventArgs e)
        {
            txtMotorRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtMotor.Text, false);
        }

        private void txtVLS1_TextChanged(object sender, EventArgs e)
        {
            txtVLS1Rule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtVLS1.Text, false);
        }

        private void txtMon2_TextChanged(object sender, EventArgs e)
        {
            txtMon2Rule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtMon2.Text, false);
            SetValue10AndElements();
        }

        private void txtVLS2_TextChanged(object sender, EventArgs e)
        {
            txtVLS2Rule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtVLS2.Text, false);
            SetValue10AndElements();
        }

        private void txtSeal_TextChanged(object sender, EventArgs e)
        {
            txtSealRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSeal.Text, false);
            SetValue10AndElements();
        }
    

        private void txtAI_TextChanged(object sender, EventArgs e)
        {
            txtAIRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtAI.Text, false);
            SetValue10AndElements();
        }

        private void txtPressure_TextChanged(object sender, EventArgs e)
        {
            txtPressureRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtPressure.Text, false);
        }
    
        private void txtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                MotorWithBypass.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    MotorWithBypass.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtDescriptionRule_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescriptionRule.Text))
            { return; }
            if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
            {
                MotorWithBypass.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
            }
            else
            {
                if (chkAddNameToDesc.Checked)
                { AppGlobal.MessageNotNumeric(); }
            }

        }
        private void txtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    MotorWithBypass.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtMon1Rule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtMon1Rule.Text))
            {
                MotorWithBypass.Rule.Mon1Rule = txtMon1Rule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtMon1IncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtMon1IncRule.Text))
            {
                AppGlobal.ParseValue<int>(txtMon1IncRule.Text, out MotorWithBypass.Rule.Mon1RuleInc);
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtVLS1Rule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtVLS1Rule.Text))
            {
                MotorWithBypass.Rule.VLS1Rule = txtVLS1Rule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtMon2Rule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtMon2Rule.Text))
            {
                MotorWithBypass.Rule.Mon2Rule = txtMon2Rule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtVLS2Rule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtVLS2Rule.Text))
            {
                MotorWithBypass.Rule.VLS2Rule = txtVLS2Rule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtSealRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSealRule.Text))
            {
                MotorWithBypass.Rule.SealRule = txtSealRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtAIRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtAIRule.Text))
            {
                MotorWithBypass.Rule.AIRule = txtAIRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtAIIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtAIIncRule.Text))
            {
                AppGlobal.ParseValue<int>(txtAIIncRule.Text, out MotorWithBypass.Rule.AIRuleInc);
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
     
        private void txtVLS1IncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtVLS1IncRule.Text))
            {
                AppGlobal.ParseValue<int>(txtVLS1IncRule.Text, out MotorWithBypass.Rule.VLS1RuleInc);
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtMon2IncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtMon2IncRule.Text))
            {
                AppGlobal.ParseValue<int>(txtMon2IncRule.Text, out MotorWithBypass.Rule.Mon2RuleInc);
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtVLS2IncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtVLS2IncRule.Text))
            {
                AppGlobal.ParseValue<int>(txtVLS2IncRule.Text, out MotorWithBypass.Rule.VLS2RuleInc);
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtSealIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSealIncRule.Text))
            {
                AppGlobal.ParseValue<int>(txtSealIncRule.Text, out MotorWithBypass.Rule.SealRuleInc);
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtPressureRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtPressureRule.Text))
            {
                MotorWithBypass.Rule.PressureRule = txtPressureRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtPressureIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtPressureIncRule.Text))
            {
                AppGlobal.ParseValue<int>(txtPressureIncRule.Text, out MotorWithBypass.Rule.PressureRuleInc);
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtSymbolIncRule_TextChanged(object sender, EventArgs e)
        {
            txtMotorIncRule.Text = txtSymbolIncRule.Text;
        }
        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"    

        private void chkParMon1IsLS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParMon1IsLS.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)2); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)2); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParMon1IsHL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParMon1IsHL.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)3); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)3); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString().ToString();
        }

        private void chkParMon1StopByFault_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParMon1StopByFault.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)4); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)4); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParLocalPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParLocalPosition.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)5); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)5); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParWithMon1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithMon1.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)6); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)6); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParWithMon2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithMon2.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)7); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)7); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParWithVLS2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithVLS2.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)8); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)8); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParWithSeal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithSeal.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)9); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)9); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParMon2IsLS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParMon2IsLS.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)10); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)10); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParMon2IsHL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParMon2IsHL.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)11); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)11); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParMon2StopByFault_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParMon2StopByFault.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)12); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)12); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkParWithAI_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithAI.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)13); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)13); }

            myMotorWithBypass.Value10 = value10;
            txtValue10.Text = myMotorWithBypass.Value10.ToString();
        }

        private void chkRunInterlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRunInterlock.Checked)
            { AppGlobal.SetBit<int>(ref value9, (byte)0); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)0); }

            myMotorWithBypass.Value9 = value9;
            txtValue9.Text = myMotorWithBypass.Value9.ToString();
        }

        private void chkStartingInterlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartingInterlock.Checked)
            { AppGlobal.SetBit<int>(ref value9, (byte)1); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)1); }

            myMotorWithBypass.Value9 = value9;
            txtValue9.Text = myMotorWithBypass.Value9.ToString();
        }
        private void txtValue10_KeyDown(object sender, KeyEventArgs e)
        {
            GetValue10BitValue(value10);
            AppGlobal.ParseValue<int>(txtValue10.Text, out value10);
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

        private void txtMon1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }

        private void txtMotor_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }

        private void txtVLS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value13";
        }

        private void txtMon2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value14";
        }

        private void txtVLS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value15";
        }

        private void txtSeal_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value16";
        }

        private void txtAI_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value17";
        }

        private void txtCleaningTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void txtPressure_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30";
        }
        private void chkParMon1IsLS_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit2";
        }

        private void chkParMon1IsHL_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit3";
        }

        private void chkParMon1StopByFault_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit4";
        }

        private void chkParLocalPosition_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit5";
        }

        private void chkParWithMon1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit6";
        }

        private void chkParWithMon2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit7";
        }

        private void chkParWithVLS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit8";
        }

        private void chkParWithSeal_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit9";
        }

        private void chkParMon2IsLS_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit10";
        }

        private void chkParMon2IsHL_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit11";
        }

        private void chkParMon2StopByFault_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit12";
        }

        private void chkParWithAI_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit13";
        }

        private void chkRunInterlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9 Bit0";
        }

        private void chkStartingInterlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9 Bit1";
        }
        #endregion

        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value10.Name,
                OType = Convert.ToString(MotorWithBypass.OTypeValue)
            };
            objectBrowser.Show();
        }
 
        void SetValue10AndElements()
        {
            List<(TextBox, CheckBox)> subElements = new List<(TextBox, CheckBox)>
            {
                (txtMon1,chkParWithMon1),
                (txtMon2,chkParWithMon2),
                (txtVLS2,chkParWithVLS2),
                (txtSeal,chkParWithSeal),
                (txtAI,chkParWithAI),
            };
            foreach (var (textBox, checkBox) in subElements)
            {              
                checkBox.Checked = !string.IsNullOrEmpty(textBox.Text);
            }                
        }
        void SetElementsName(string subType,string name)
        {
            myMotorWithBypass.Motor = txtMotor.Text = name + GcObjectInfo.MA_MotorWithBypass.SuffixMotor;
            myMotorWithBypass.VLS1 = txtVLS1.Text = name + GcObjectInfo.MA_MotorWithBypass.SuffixVLS1;

            if (subType == MotorWithBypass.MJZG)
            {
                myMotorWithBypass.Mon1= txtMon1.Text = name + GcObjectInfo.MA_MotorWithBypass.SuffixOscillationSensor;
                myMotorWithBypass.AI = txtAI.Text = name + GcObjectInfo.MA_MotorWithBypass.SuffixTempeatureSensor;
                lblMon1.Text = OSILLATION_SENSOR;
                lblAI.Text = TEMPERATURE_SENSOR;
            }    
            else
            {
                myMotorWithBypass.Mon1 = txtMon1.Text = string.Empty;
                myMotorWithBypass.AI = txtAI.Text = string.Empty;
                lblMon1.Text = MON1;
                lblAI.Text = AI;
            }
        }
        void SetElementsEnbale(string subType)
        {
            //if (subType == MotorWithBypass.ALL)
            //{            
                 
            //}
            //else if (subType == MotorWithBypass.MJZG)
            //{
             
            //}      
        }
        void SetElements(string subType)
        {
           
            SetElementsEnbale(subType);
            SetValue10AndElements();
            SetElementsName(subType, txtSymbol.Text);
        }
        void SubTypeChanged()
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedItem))
                {
                    myMotorWithBypass.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SetElements(myMotorWithBypass.SubType);
             
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
               
        }
        void GetValue10BitValue(int value)
        {
          //  chkParManual.Checked = AppGlobal. GetBit<int>(value, 5);
          
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            MotorWithBypass.Rule.Common.DescFloor = ComboElevation.Text;
            UpdateDesc();
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubTypeChanged();
        }
        #endregion
        #region <---BML part--->
        private void AddWorkSheets()
        {
            /*
          
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
            */
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
            //BML.MA_MotorWithBypass.BMLPath = excelFileHandle.FilePath;
            //LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_MotorWithBypass}.{AppGlobal.JS_PATH}", BML.MA_MotorWithBypass.BMLPath);
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
          //  AddWorkSheets();
        }
        private void comboWorkSheetsBML_SelectedIndexChanged(object sender, EventArgs e)
        {

            excelFileHandle.WorkSheet = comboWorkSheetsBML.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(excelFileHandle.WorkSheet))
            {
                btnReadBML.Enabled = true;
            }
        }
        private void dataGridBML_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            listBMLName = LibGlobalSource.BMLHelper.ExtractMachineNameWithCount(dataGridBML, nameof(BML.ColumnName), Engineering.PatternMachineName);
            TxtQuantity.Text = listBMLName.Count.ToString();
        }
        private void CreateBMLDefault()
        {
            /*
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
                comboLineBML.Items.Add(item);
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
                comboLineBML.SelectedItem = "X";
                comboControlBML.SelectedItem = "H";
            }
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
           // TxtExcelPath.Text =BML.MA_MotorWithBypass.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.ColumnName;
            nameColumn.Name = nameof(BML.ColumnName);
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.ColumnDesc;
            descColumn.Name = nameof(BML.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);

            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.HeaderText = BML.ColumnType;
            typeColumn.Name = nameof(BML.ColumnType);
            dataGridBML.Columns.Add(typeColumn);

            DataGridViewTextBoxColumn controlColumn = new DataGridViewTextBoxColumn();
            controlColumn.HeaderText = BML.ColumnControlMethod;
            controlColumn.Name = nameof(BML.ColumnControlMethod);
            dataGridBML.Columns.Add(controlColumn);

            DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            floorColumn.HeaderText = BML.ColumnFloor;
            floorColumn.Name = nameof(BML.ColumnFloor);
            dataGridBML.Columns.Add(floorColumn);

            DataGridViewTextBoxColumn lineColumn = new DataGridViewTextBoxColumn();
            lineColumn.HeaderText = BML.ColumnLine;
            lineColumn.Name = nameof(BML.ColumnLine);
            dataGridBML.Columns.Add(lineColumn);
*/
        }
        private void btnReadBML_Click(object sender, EventArgs e)
        {
            /*
            string[] columnList = { comboNameBML.Text, comboDescBML.Text, comboTypeBML.Text, comboControlBML.Text, comboFloorBML.Text, comboLineBML.Text };

            StringBuilder sbDescs = new StringBuilder();
            sbDescs.Append($@"Value LIKE ""%{BML.MachineType.RollerMiller}"" || ").Append($@"Value LIKE ""%{BML.MachineType.FeederRollerMiller}""");
            DataTable dataTable = new DataTable();
            string[] filters = { sbDescs.ToString() };
            string[] filterColumns = { comboDescBML.Text };
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);

            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnType)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnControlMethod)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnLine)].DataPropertyName = dataTable.Columns[5].ColumnName;

            var rowsContainingMDDx = dataTable.AsEnumerable()
                .Where(row => row.Field<string>(3). Contains(BML.MDDx.TypeMDDx))
                .ToList();
            var uniquePrefixes = rowsContainingMDDx
                .Select(row => {
                    string name = row.Field<string>(0);          
                    return LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternMachineName,name);
                })
                .Distinct()
                .ToList();

            var rowsToDelete = dataTable.AsEnumerable()
                .Where(row => uniquePrefixes.Any(prefix => row.Field<string>(0).StartsWith(prefix)))
                .ToList();
            foreach (DataRow row in rowsToDelete)
            {
                dataTable.Rows.Remove(row);
            }  
            dataGridBML.DataSource = dataTable;
            listBMLName = LibGlobalSource.BMLHelper.ExtractMachineNameWithCount(dataTable, dataTable.Columns[0].ColumnName, Engineering.PatternMachineName);
            TxtQuantity.Text = listBMLName.Count.ToString();
            listBMLName.Clear();
            */
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
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                //txtSymbolRule.Text = MotorWithBypass.Rule.Common.NameRule;
                //txtSymbolIncRule.Text = MotorWithBypass.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                grpSymbolRule.Visible = true;
                lblSymbol.Text = AppGlobal.NAME;
                //txtSymbol.Text = DEMO_NAME_MOTOR_WITH_BYPASS;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                //txtSymbolRule.Text = MotorWithBypass.Rule.Common.NameRule;
                //txtSymbolIncRule.Text = MotorWithBypass.Rule.Common.NameRuleInc;
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
            listBMLName = LibGlobalSource.BMLHelper.ExtractMachineNameWithCount(dataGridBML, nameof(BML.ColumnName), Engineering.PatternMachineName);
            TxtQuantity.Text = listBMLName.Count.ToString();
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
                    string objName = string.Empty;
                    string objSubType = string.Empty;
                    OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
                    DataTable dataTable;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={MotorWithBypass.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Value11.Name,
                        GcproTable.ObjData.Value13.Name, GcproTable.ObjData.Value19.Name, GcproTable.ObjData.Value14.Name,
                        GcproTable.ObjData.Value47.Name, GcproTable.ObjData.Value42.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    MotorWithBypass.Clear(myMotorWithBypass.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        ProgressBar.Value = count;
                    }
                    MotorWithBypass.SaveFileAs(myMotorWithBypass.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
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
                myMotorWithBypass.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            MotorWithBypass.SaveFileAs(myMotorWithBypass.FilePath, LibGlobalSource.CREATE_OBJECT);
            MotorWithBypass.SaveFileAs(myMotorWithBypass.FileRelationPath, LibGlobalSource.CREATE_RELATION);
        }
        private void BtnNewImpExpDef_Click(object sender, EventArgs e)
        {
            CreateImpExp();
        }
    
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datafromBML">DataGridView</param>
        /// <param name="objMotorWithBypass">Class MotorWithBypass</param>
        /// <param name="parValue10"></param>
        /// <param name="addtionToDesc"></param>
        /// <param name="processValue"></param>
        /*
        public void CreatObjectBML(DataGridView datafromBML,MotorWithBypass objMotorWithBypass,string parValue10,
            (bool section, bool userDefSection, bool elevation, bool identNumber, bool cabinet, bool power, bool onlyNumber) addtionToDesc,
            out (int Value, int Max) processValue)
        {
            
            StringBuilder descTotalBuilder = new StringBuilder();
            List<KeyValuePair<string, int>> listName = new List<KeyValuePair<string, int>>();
            int noOfSubElements = 0;
            listName = LibGlobalSource.BMLHelper.ExtractMachineNameWithCount(datafromBML, nameof(BML.ColumnName), Engineering.PatternMachineName);
            int quantityNeedToBeCreate = listName.Count;
        //    int subElements = datafromBML.Rows.Count;     
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            string numberString=string.Empty;
          //  string subTypePrev=string.Empty;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {

                objMotorWithBypass.Name = Convert.ToString(listName[i].Key.ToString());
                if (string.IsNullOrEmpty(objMotorWithBypass.Name))
                {
                    continue;
                }
                #region Subtype         
                noOfSubElements = (int)listName[i].Value;
                switch (noOfSubElements)
                {
                    case 4:
                    case 5:
                       objMotorWithBypass.SubType = MotorWithBypass.ALL;
                        break;                       
                    case 6:
                    case 7:
                       objMotorWithBypass.SubType = MotorWithBypass.MJZG;
                        break;
                    default:
                       objMotorWithBypass.SubType = MotorWithBypass.ALL;
                        break;
                }                           
                    SetElementsName(objMotorWithBypass.SubType,objMotorWithBypass.Name);
                    SetValue10AndElements();
              
                objMotorWithBypass.Value10= parValue10;           
                #endregion              
                descTotalBuilder.Clear();
                bool additionInfToDesc = addtionToDesc.identNumber || addtionToDesc.elevation;
                numberString = LibGlobalSource.StringHelper.ExtractNumericPart(objMotorWithBypass.Name, false);
                if (addtionToDesc.section)
                {                
                    if (!string.IsNullOrEmpty(numberString))
                    {
                        if (AppGlobal.ParseValue<int>(numberString.Substring(0, 4), out tempInt))
                        {
                            descTotalBuilder.Append(GcObjectInfo.Section.ReturnSection(tempInt));
                        }
                    }
                }
                if (addtionToDesc.userDefSection)
                {
                    descTotalBuilder.Append(Convert.ToString(datafromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value));
                }
                if (additionInfToDesc)
                {
                   AppGlobal.AppendInfoToBuilder(addtionToDesc.elevation, $"{objMotorWithBypass.Elevation}{GcObjectInfo.General.AddInfoElevation}", descTotalBuilder);
                    string descName = chkNameOnlyNumber.Checked ? numberString : objMotorWithBypass.Name;
                    descName = descName.Contains(GcObjectInfo.General.PrefixName) ? descName.Replace(GcObjectInfo.General.PrefixName, string.Empty) : descName;
                    AppGlobal.AppendInfoToBuilder(addtionToDesc.identNumber, $"({descName})", descTotalBuilder);
                }
                descTotalBuilder.Append($"{BML.MachineType.RollerMiller}");
             
                objMotorWithBypass.Description = descTotalBuilder.ToString();
                objMotorWithBypass.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
            
        }
        */
        private void CreatObjectRule(MotorWithBypass objMotorWithBypass,(bool section, bool userDefSection, bool elevation, bool identNumber, bool cabinet, bool power, bool onlyNumber) addtionToDesc,
            ref (int Value, int Max) processValue)
        {
            StringBuilder objBuilder = new StringBuilder();
            TextFileHandle objTextFileHandle = new TextFileHandle();
            int quantityNeedToBeCreate = processValue.Max;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            StringBuilder descTotalBuilder = new StringBuilder();
            RuleSubDataSet description, name;
            RuleSubDataSet mon1, mon2;
            RuleSubDataSet vls1, vls2;
            RuleSubDataSet seal, pressure;
            RuleSubDataSet ai;
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
            mon1 = new RuleSubDataSet
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
            mon2 = new RuleSubDataSet
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
            vls1 = new RuleSubDataSet
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
            vls2= new RuleSubDataSet
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
            ai = new RuleSubDataSet
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
            seal = new RuleSubDataSet
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
            pressure = new RuleSubDataSet
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
            processValue.Value = 0;
            #region UnChanged field
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                objMotorWithBypass.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            else
            {
                objMotorWithBypass.SubType = MotorWithBypass.ALL;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (ComboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                objMotorWithBypass.PType = MotorWithBypass.ParseInfoValue(selectedPTypeItem, AppGlobal.FIELDS_SEPARATOR, MotorWithBypass.P2052);
            }
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            objMotorWithBypass.Value10= value10;
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            objMotorWithBypass.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                objMotorWithBypass.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objMotorWithBypass.Diagram = (int)MotorWithBypass.ParseInfoValue(selectedDiagram, AppGlobal.FIELDS_SEPARATOR, AppGlobal.NO_DIAGRAM);
            }
            ///<Page></Page>
            objMotorWithBypass.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling ;
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objMotorWithBypass.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objMotorWithBypass.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objMotorWithBypass.Panel_ID = selectedPanel_ID;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            objMotorWithBypass.FieldBusNode = AppGlobal.NO_DP_NODE;
            #endregion
            #region Parse rules
            ///<ParseRule> </ParseRule>
            if (!AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out tempInt))
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

            ///<Mon1Rule>生成名称规则</Mon1Rule>
            mon1.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtMon1.Text, txtMon1Rule.Text);
            if (mon1.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblMon1Rule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                mon1.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtMon1.Text, txtMon1Rule.Text);
            }

            ///<Mon2Rule>生成名称规则</Mon2Rule>
            mon2.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtMon2.Text, txtMon2Rule.Text);
            if (mon2.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblMon2Rule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                mon2.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtMon2.Text, txtMon2Rule.Text);
            }

            ///<VLS1Rule>生成名称规则</VLS1Rule>
            vls1.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtVLS1.Text, txtVLS1Rule.Text);
            if (vls1.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblVLS1Rule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                vls1.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtVLS1.Text, txtVLS1Rule.Text);
            }


            ///<VLS2Rule>生成名称规则</VLS2Rule>
            vls2.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtVLS2.Text, txtVLS2Rule.Text);
            if (vls2.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblVLS2Rule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                vls2.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtVLS2.Text, txtVLS2Rule.Text);
            }

            ///<SealRule>生成名称规则</SealRule>
            seal.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtSeal.Text, txtSealRule.Text);
            if (seal.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblSealRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                seal.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtSeal.Text, txtSealRule.Text);
            }
            ///<AIRule>生成名称规则</AIRule>
            ai.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtAI.Text, txtAIRule.Text);
            if (ai.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblAIRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
               ai.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtAI.Text, txtAIRule.Text);
            }
            ///<PressureRule>生成名称规则</PressureRule>
            pressure.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtPressure.Text, txtPressureRule.Text);
            if (pressure.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblPressureRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                pressure.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtPressure.Text, txtPressureRule.Text);
            }
            ///<DescRule>生成描述规则</DescRule>
            if (!string.IsNullOrEmpty(txtDescriptionRule.Text))
            {
                description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtDescription.Text, txtDescriptionRule.Text);
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
                    description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtDescription.Text, txtDescriptionRule.Text);
                }
            }
            #endregion

            processValue.Value = 0;
            ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
            AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out int symbolInc);
            AppGlobal.ParseValue<int>(txtSymbolRule.Text, out int symbolRule);
            AppGlobal.ParseValue<int>(txtDescriptionIncRule.Text, out int descriptionInc);
            AppGlobal.ParseValue<int>(txtMon1IncRule.Text, out int mon1Inc);
            AppGlobal.ParseValue<int>(txtMon2IncRule.Text, out int mon2Inc);
            AppGlobal.ParseValue<int>(txtVLS1IncRule.Text, out int vls1Inc);
            AppGlobal.ParseValue<int>(txtVLS2IncRule.Text, out int vls2Inc);
            AppGlobal.ParseValue<int>(txtSealIncRule.Text, out int sealInc);
            AppGlobal.ParseValue<int>(txtPressureIncRule.Text, out int pressureInc);
            AppGlobal.ParseValue<int>(txtAIIncRule.Text, out int aiInc);
            for (int i = 0; i < quantityNeedToBeCreate ; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));

                if (!string.IsNullOrEmpty(txtDescription.Text))
                {
                    if (!string.IsNullOrEmpty(txtDescriptionIncRule.Text) && !string.IsNullOrEmpty(txtDescriptionRule.Text)
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

                if (!string.IsNullOrEmpty(txtMon1.Text))
                {
                    if (!string.IsNullOrEmpty(txtMon1IncRule.Text) && !string.IsNullOrEmpty(txtMon1Rule.Text)
                        && AppGlobal.CheckNumericString(txtMon1IncRule.Text) && AppGlobal.CheckNumericString(txtMon1IncRule.Text)
                        && (mon1.PosInfo.Len != -1))
                    {
                        mon1.Inc = i * mon1Inc;
                        mon1.Name = LibGlobalSource.StringHelper.GenerateObjectName(mon1.Sub, mon1.PosInfo, (int.Parse(txtMon1Rule.Text) + mon1.Inc).ToString().PadLeft(mon1.PosInfo.Len, '0'));
                    }
                    else
                    {
                        mon1.Name = txtMon1.Text;
                    }

                }
                else
                {
                    mon1.Name = string.Empty;
                }

                if (!string.IsNullOrEmpty(txtMon2.Text))
                {
                    if (!string.IsNullOrEmpty(txtMon2IncRule.Text) && !string.IsNullOrEmpty(txtMon2Rule.Text)
                        && AppGlobal.CheckNumericString(txtMon2IncRule.Text) && AppGlobal.CheckNumericString(txtMon2IncRule.Text)
                        && (mon2.PosInfo.Len != -1))
                    {
                        mon2.Inc = i * mon2Inc;
                        mon2.Name = LibGlobalSource.StringHelper.GenerateObjectName(mon2.Sub, mon2.PosInfo, (int.Parse(txtMon2Rule.Text) + mon2.Inc).ToString().PadLeft(mon2.PosInfo.Len, '0'));
                    }
                    else
                    {
                        mon2.Name = txtMon2.Text;
                    }

                }
                else
                {
                    mon2.Name = string.Empty;
                }
                if (!string.IsNullOrEmpty(txtVLS1.Text))
                {
                    if (!string.IsNullOrEmpty(txtVLS1IncRule.Text) && !string.IsNullOrEmpty(txtVLS1Rule.Text)
                        && AppGlobal.CheckNumericString(txtVLS1IncRule.Text) && AppGlobal.CheckNumericString(txtVLS1IncRule.Text)
                        && (vls1.PosInfo.Len != -1))
                    {
                        vls1.Inc = i * vls1Inc;
                        vls1.Name = LibGlobalSource.StringHelper.GenerateObjectName(vls1.Sub, vls1.PosInfo, (int.Parse(txtVLS1Rule.Text) + vls1.Inc).ToString().PadLeft(vls1.PosInfo.Len, '0'));
                    }
                    else
                    {
                        vls1.Name = txtMon2.Text;
                    }

                }
                else
                {
                    vls1.Name = string.Empty;
                }

                if (!string.IsNullOrEmpty(txtVLS2.Text))
                {
                    if (!string.IsNullOrEmpty(txtVLS2IncRule.Text) && !string.IsNullOrEmpty(txtVLS2Rule.Text)
                        && AppGlobal.CheckNumericString(txtVLS2IncRule.Text) && AppGlobal.CheckNumericString(txtVLS2IncRule.Text)
                        && (vls2.PosInfo.Len != -1))
                    {
                        vls2.Inc = i * vls2Inc;
                        vls2.Name = LibGlobalSource.StringHelper.GenerateObjectName(vls2.Sub, vls2.PosInfo, (int.Parse(txtVLS2Rule.Text) + vls2.Inc).ToString().PadLeft(vls2.PosInfo.Len, '0'));
                    }
                    else
                    {
                        vls2.Name = txtMon2.Text;
                    }

                }
                else
                {
                    vls2.Name = string.Empty;
                }

                if (!string.IsNullOrEmpty(txtSeal.Text))
                {
                    if (!string.IsNullOrEmpty(txtSealIncRule.Text) && !string.IsNullOrEmpty(txtSealRule.Text)
                        && AppGlobal.CheckNumericString(txtSealIncRule.Text) && AppGlobal.CheckNumericString(txtSealIncRule.Text)
                        && (seal.PosInfo.Len != -1))
                    {
                        seal.Inc = i * sealInc;
                       seal.Name = LibGlobalSource.StringHelper.GenerateObjectName(seal.Sub, seal.PosInfo, (int.Parse(txtSealRule.Text) + seal.Inc).ToString().PadLeft(seal.PosInfo.Len, '0'));
                    }
                    else
                    {
                        seal.Name = txtSeal.Text;
                    }

                }
                else
                {
                    seal.Name = string.Empty;
                }


                if (!string.IsNullOrEmpty(txtPressure.Text))
                {
                    if (!string.IsNullOrEmpty(txtPressureIncRule.Text) && !string.IsNullOrEmpty(txtPressureRule.Text)
                        && AppGlobal.CheckNumericString(txtPressureIncRule.Text) && AppGlobal.CheckNumericString(txtPressureIncRule.Text)
                        && (pressure.PosInfo.Len != -1))
                    {
                        pressure.Inc = i * sealInc;
                        pressure.Name = LibGlobalSource.StringHelper.GenerateObjectName(pressure.Sub, pressure.PosInfo, (int.Parse(txtPressureRule.Text) + pressure.Inc).ToString().PadLeft(pressure.PosInfo.Len, '0'));
                    }
                    else
                    {
                        pressure.Name = txtPressure.Text;
                    }

                }
                else
                {
                    pressure.Name = string.Empty;
                }

                if (!string.IsNullOrEmpty(txtAI.Text))
                {
                    if (!string.IsNullOrEmpty(txtAIIncRule.Text) && !string.IsNullOrEmpty(txtAIRule.Text)
                        && AppGlobal.CheckNumericString(txtAIIncRule.Text) && AppGlobal.CheckNumericString(txtAIIncRule.Text)
                        && (ai.PosInfo.Len != -1))
                    {
                        ai.Inc = i * sealInc;
                        ai.Name = LibGlobalSource.StringHelper.GenerateObjectName(ai.Sub,ai.PosInfo, (int.Parse(txtPressureRule.Text) + ai.Inc).ToString().PadLeft(ai.PosInfo.Len, '0'));
                    }
                    else
                    {
                       ai.Name = txtPressure.Text;
                    }

                }
                else
                {
                    ai.Name = string.Empty;
                }
                objMotorWithBypass.Name = name.Name;
                objMotorWithBypass.Motor = name.Name + GcObjectInfo.MA_MotorWithBypass.SuffixMotor;
                objMotorWithBypass.Mon1= mon1.Name;
                objMotorWithBypass.Mon2 = mon2.Name;
                objMotorWithBypass.VLS1 = vls1.Name;
                objMotorWithBypass.VLS2 = vls2.Name;
                objMotorWithBypass.Seal = seal.Name;
                objMotorWithBypass.AI = ai.Name;
                objMotorWithBypass.Pressure = pressure.Name;
                objMotorWithBypass.Value10 = value10;
                objMotorWithBypass.Value9 = value9;

                bool tempBool = AppGlobal.ParseValue<int>(txtCleaningTime.Text, out int cleaningTime);
                objMotorWithBypass.ParCleaningTime = tempBool ? Math.Round(Convert.ToDouble(cleaningTime),1): 60.0;
                descTotalBuilder.Clear();
                descTotalBuilder.Append(description.Name);         
                objMotorWithBypass.Description = descTotalBuilder.ToString();
                objMotorWithBypass.CreateObjectRecordAndRelation(objBuilder);
                processValue.Value = i;
            }
            objMotorWithBypass.CreateObject(objTextFileHandle, Encoding.Unicode, objMotorWithBypass.FileRelationPath);
            processValue.Value = processValue.Max;
        }
        /*
     private void CreatObjectAutoSearch()
     {

         OleDb oledb = new OleDb();
         DataTable dataTable = new DataTable();
         oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
         oledb.IsNewOLEDBDriver = isNewOledbDriver;
         #region common used variables declaration       
         int quantityNeedToBeCreate = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
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

         List<string> objList = new List<string>();
         List<string> objVFC = new List<string>();
         List<int> objSubs = new List<int>();
         bool isVfc = false;
         int noOfSubElements = 0;
         string filter = $@"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.EL_MDDx} AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER}";
         filter = string.IsNullOrEmpty(txtSymbol.Text) ? filter : $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";

         dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, null, GcproTable.ObjData.Text0.Name);
         objList = OleDb.GetColumnData<string>(dataTable, GcproTable.ObjData.Text0.Name);
         for (int i = 0; i <= objList.Count - 1; i++)
         {
             objList[i] = AppGlobal.GetObjectSymbolFromIO(objList[i]);
         }
         quantityNeedToBeCreate = objList.Count;
         ProgressBar.Maximum= quantityNeedToBeCreate;
         for (int i = 0; i < quantityNeedToBeCreate; i++)
         {
             filter = $@"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.EL_Motor} AND {GcproTable.ObjData.Text0.Name} LIKE '{objList[i]}%'";        

             dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, null, GcproTable.ObjData.Key.Name,GcproTable.ObjData.SubType.Name);
             objSubs = OleDb.GetColumnData<int>(dataTable, GcproTable.ObjData.Key.Name);
             noOfSubElements= objSubs.Count;
             objVFC = OleDb.GetColumnData<String>(dataTable, GcproTable.ObjData.SubType.Name);
             foreach(string vfc in objVFC)
             {
                 if (vfc.Equals(Motor.M1VFC))
                 {
                     isVfc = true;
                     break;
                 }
             }
             objMotorWithBypass.Name = objList[i];
             switch (noOfSubElements)
             {                              
                 case 4:
                     if (isVfc)
                     {
                         objMotorWithBypass.SubType = MotorWithBypass.ALL;
                     }
                     break;          
                 case 6:
                     objMotorWithBypass.SubType = MotorWithBypass.MJZG;              
                     break;
                 default:
                     objMotorWithBypass.SubType = MotorWithBypass.ALL;
                     goto case 4;

             }

             SetElementsName(objMotorWithBypass.SubType, objMotorWithBypass.Name);
             SetValue10AndElements();

             objMotorWithBypass.Description = txtDescription.Text;
             objMotorWithBypass.Value10 = txtValue10.Text;
             objMotorWithBypass.CreateObject(Encoding.Unicode);
             ProgressBar.Value = i;
         }
         ProgressBar.Value = quantityNeedToBeCreate;
     
    }
            */
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myMotorWithBypass.Elevation = ComboElevation.Text;
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet =false;
                AppGlobal.AdditionDesc.Power = false;
                if (createMode.BML)
                {

                 //  CreatObjectBML(dataGridBML, myMotorWithBypass, txtValue10.Text,AppGlobal.AdditionDesc, out AppGlobal.ProcessValue);
                }
                else if (createMode.AutoSearch)
                {
                   // CreatObjectAutoSearch();
                }
                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreatObjectRule(myMotorWithBypass,AppGlobal.AdditionDesc, ref AppGlobal.ProcessValue);
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
