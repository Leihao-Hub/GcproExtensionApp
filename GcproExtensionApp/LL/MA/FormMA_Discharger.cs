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
    public partial class FormMA_Discharger : Form, IGcForm
    {
        public FormMA_Discharger()
        {
            InitializeComponent();
        }
        #region Public object in this class
        Discharger myDischarger= new Discharger(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        List<KeyValuePair<string, int>> listBMLName = new List<KeyValuePair<string, int>>();
        private bool isNewOledbDriver = false;
        private GcBaseRule objDefaultInfo;
        
        #endregion
        private int value10 ;
        private int value9;
        private int tempInt = 0;
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
            ///Read [SubType],[ProcessFct]from GcsLibrary 
            ///</ReadInfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={Discharger.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {Discharger.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + Discharger.OTypeValue}'",
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
            objDefaultInfo.NameRule = "5100";
            objDefaultInfo.DescLine = "倒粉A线";
            objDefaultInfo.DescFloor = "2楼";
            objDefaultInfo.Name = "=A-5100";
            objDefaultInfo.DescObject = "出仓机";
            objDefaultInfo.Description = Discharger.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix :GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: false,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (String.IsNullOrEmpty(Discharger.Rule.Common.Description))
            { Discharger.Rule.Common.Description = objDefaultInfo.Description; }

            if (String.IsNullOrEmpty(Discharger.Rule.Common.Name))
            { Discharger.Rule.Common.Name = objDefaultInfo.Name; }

            if (String.IsNullOrEmpty(Discharger.Rule.Common.DescLine))
            { Discharger.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (String.IsNullOrEmpty(Discharger.Rule.Common.DescFloor))
            { Discharger.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (String.IsNullOrEmpty(Discharger.Rule.Common.DescObject))
            { Discharger.Rule.Common.DescObject = objDefaultInfo.DescObject; }

            //  myDischarger.DecodingDesc(ref Discharger.Rule.Common, AppGlobal.DESC_SEPARATOR);

            txtSymbolRule.Text = Discharger.Rule.Common.NameRule;
            txtSymbolIncRule.Text = Discharger.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = Discharger.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = Discharger.Rule.Common.DescriptionRuleInc;
            txtDescription.Text = Discharger.Rule.Common.Description;
            txtSymbol.Text =  Discharger.Rule.Common.Name;

            txtVibroIncRule.Text = Discharger.Rule.Common.NameRuleInc;
            txtDischargerIncRule.Text = Discharger.Rule.DischargerRuleInc;
            txtVibroIncRule.Text = Discharger.Rule.VibroRuleInc;
            txtLLBinIncRule.Text = Discharger.Rule.LLBinRuleInc;
            txtLSFlowIncRule.Text = Discharger.Rule.LSFlowRuleInc;
            txtReceiverIncRule.Text = Discharger.Rule.ReceiverRuleInc;
            txtSenderBinIncRule.Text = Discharger.Rule.SenderBinRuleInc;

        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + Discharger.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + objDefaultInfo.Name);
          //  toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + Mo);
            //toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_MOTOR_WITH_BYPASS);
            //toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_MOTOR_WITH_BYPASS);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Discharger.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Discharger.ImpExpRuleName}'", null);
                    CreateDischargerImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateDischargerImpExp(oledb);
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
            txtValue10.Text = myDischarger.Value10;
            value10 = int.Parse(txtValue10.Text);
            //暂时隐藏BML Tab
            TabPage tabToHide = tabCreateMode.TabPages["tabBML"];
            tabCreateMode.TabPages.Remove(tabToHide);
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "MA_Discharger导入文件 " + " " + myDischarger.FilePath;
        }
        #endregion
        private void CreateDischargerImpExp(OleDb oledb)
        {

            bool result = myDischarger.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormMA_Discharger_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetInfoFromDatabase();
            GetLastObjRule();        
            CreateTips();
            Default();
        }
        private void FormMA_Discharger_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>

        private void UpdateDesc()
        {
            Discharger.EncodingDesc(
            baseRule: ref Discharger.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: false,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = Discharger.Rule.Common.Description;
        }
        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            myDischarger.Name = txtSymbol.Text;
            Discharger.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
            SubTypeChanged();
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
           if (!Discharger.Rule.Common.Description.Equals(txtDescription.Text))
            {
                Discharger.Rule.Common.Description = txtDescription.Text;
               // myDischarger.DecodingDesc(ref Discharger.Rule.Common, AppGlobal.DESC_SEPARATOR);
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, txtDescription.Text);
        }
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Discharger.Rule.Common.Description = txtDescription.Text;
                Discharger.DecodingDesc(ref Discharger.Rule.Common, AppGlobal.DESC_SEPARATOR);
                UpdateDesc();
            }
        }
        private void txtDischarger_TextChanged(object sender, EventArgs e)
        {
            txtDischargerRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtDischarger.Text, false);
            chkParDischargerIsMotor.Checked = txtDischarger.Text.Contains(GcObjectInfo.Motor.SuffixMotor);       
        }

        private void txtVibro_TextChanged(object sender, EventArgs e)
        {
            txtVibroRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtVibro.Text, false);
            SetValue10AndElements();
        }

        private void txtLSFlow_TextChanged(object sender, EventArgs e)
        {
            txtLSFlowRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtLSFlow.Text, false);
            SetValue10AndElements();
        }

        private void txtLLBin_TextChanged(object sender, EventArgs e)
        {
            txtLLBinRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtLLBin.Text, false);
            SetValue10AndElements();
        }
     

        private void txtReceiver_TextChanged(object sender, EventArgs e)
        {
            txtReceiverRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtReceiver.Text, false);
        }
        private void txtSenderBin_TextChanged(object sender, EventArgs e)
        {
            txtSenderBinRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSenderBin.Text, false);
        }


        private void txtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                Discharger.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    Discharger.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtDescriptionRule_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescriptionRule.Text))
            { return; }
            if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
            {
                Discharger.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
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
                    Discharger.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtDischargerRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtDischargerRule.Text))
            {
                Discharger.Rule.DischargerRule = txtDischargerRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtDischargerIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtDischargerIncRule.Text))
            {
                Discharger.Rule.DischargerRuleInc = txtDischargerIncRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtVibroRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtVibroRule.Text))
            {
                Discharger.Rule.VibroRule = txtVibroRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtVibroIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtVibroIncRule.Text))
            {
                Discharger.Rule.VibroRuleInc = txtVibroIncRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtLLBinRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtLLBinRule.Text))
            {
                Discharger.Rule.LLBinRule = txtLLBinRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtLLBinIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtLLBinIncRule.Text))
            {
                Discharger.Rule.LLBinRuleInc = txtLLBinIncRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtLSFlowRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtLSFlowRule.Text))
            {
                Discharger.Rule.LSFlowRule = txtLSFlowRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtLSFlowIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtLSFlowIncRule.Text))
            {
                Discharger.Rule.LSFlowRuleInc = txtLSFlowIncRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtReceiverRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtReceiverRule.Text))
            {
                Discharger.Rule.ReceiverRule = txtReceiverRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtReceiverIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtReceiverIncRule.Text))
            {
                Discharger.Rule.ReceiverRuleInc = txtReceiverIncRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtSenderBinRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSenderBinRule.Text))
            {
                Discharger.Rule.SenderBinRule = txtSenderBinRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtSenderBinIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSenderBinIncRule.Text))
            {
                Discharger.Rule.SenderBinRuleInc = txtSenderBinIncRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtSymbolIncRule_TextChanged(object sender, EventArgs e)
        {
            txtVibroIncRule.Text = txtSymbolIncRule.Text;
        }
        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"    

        private void chkParContinuous_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParContinuous.Checked)

            { AppGlobal.SetBit(ref value10, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)4); }

            myDischarger.Value10 = value10.ToString();
            txtValue10.Text = myDischarger.Value10;
        }

        private void chkParWithVibro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithVibro.Checked)

            { AppGlobal.SetBit(ref value10, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)0); }

            myDischarger.Value10 = value10.ToString();
            txtValue10.Text = myDischarger.Value10;
        }

        private void chkParWithLLBin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithLL.Checked)

            { AppGlobal.SetBit(ref value10, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myDischarger.Value10 = value10.ToString();
            txtValue10.Text = myDischarger.Value10;
        }

        private void chkParWithFlow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithFlow.Checked)

            { AppGlobal.SetBit(ref value10, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }

            myDischarger.Value10 = value10.ToString();
            txtValue10.Text = myDischarger.Value10;
        }

        private void chkParDischargerIsMotor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParDischargerIsMotor.Checked)

            { AppGlobal.SetBit(ref value10, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)3); }

            myDischarger.Value10 = value10.ToString();
            txtValue10.Text = myDischarger.Value10;
        }

      
     
        private void txtValue10_KeyDown(object sender, KeyEventArgs e)
        {
            GetValue10BitValue(value10);
            tempBool = AppGlobal.ParseInt(txtValue10.Text, out value10);
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

        private void txtDischarger_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }

        private void txtVibro_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }

        private void txtLLBin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value13";
        }

        private void txtLSFlow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value14";
        }
        private void txtParVibroOnTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }
        private void txtParVibroOffTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }

        private void txtParRestDischargeTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }
        private void txtReceiver_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value41";
        }
        private void chkParContinuous_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit4";
        }

        private void chkParWithVibro_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit0";
        }

        private void chkParWithLL_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit1";
        }

        private void chkParWithFlow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit2";
        }

        private void chkParDischargerIsMotor_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10 Bit3";
        }

        
        #endregion

        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value10.Name;
            objectBrowser.OType = Convert.ToString(Discharger.OTypeValue);
            objectBrowser.Show();
        }
 
        void SetValue10AndElements()
        {
            List<(TextBox, CheckBox)> subElements = new List<(TextBox, CheckBox)>
            {
                (txtLLBin,chkParWithLL),
                (txtVibro,chkParWithVibro),
                (txtLSFlow,chkParWithFlow),

            };
            foreach (var (textBox, checkBox) in subElements)
            {              
                checkBox.Checked = !string.IsNullOrEmpty(textBox.Text);
            }                
        }
        void SetElementsName(string subType,string name)
        {
            myDischarger.DischargerChild = txtDischarger.Text = $"{name}{GcObjectInfo.MA_Discharger.SuffixMotor}";
        }
        void SetElementsEnbale(string subType)
        {
            //if (subType == Discharger.ALL)
            //{            
                 
            //}
            //else if (subType == Discharger.MJZG)
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
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myDischarger.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SetElements(myDischarger.SubType);
             
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
               
        }
        void GetValue10BitValue(int value)
        {
          //  chkParManual.Checked = AppGlobal.GetBitValue(value, 5);
          
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Discharger.Rule.Common.DescFloor = ComboElevation.Text;
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
            //BML.MA_Discharger.BMLPath = excelFileHandle.FilePath;
            //LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_Discharger}.{AppGlobal.JS_PATH}", BML.MA_Discharger.BMLPath);
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
           // TxtExcelPath.Text =BML.MA_Discharger.BMLPath;
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
                //txtSymbolRule.Text = Discharger.Rule.Common.NameRule;
                //txtSymbolIncRule.Text = Discharger.Rule.Common.NameRuleInc;
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
                //txtSymbolRule.Text = Discharger.Rule.Common.NameRule;
                //txtSymbolIncRule.Text = Discharger.Rule.Common.NameRuleInc;
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
                    string objName = String.Empty;
                    string objSubType = String.Empty;
                    OleDb oledb = new OleDb();
                    DataTable dataTable = new DataTable();
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={Discharger.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Value11.Name,
                        GcproTable.ObjData.Value12.Name, GcproTable.ObjData.Value13.Name, GcproTable.ObjData.Value14.Name,
                        GcproTable.ObjData.Value41.Name, GcproTable.ObjData.Value42.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    Discharger.Clear(myDischarger.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        ProgressBar.Value = count;
                    }
                    Discharger.SaveFileAs(myDischarger.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
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
                myDischarger.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            Discharger.SaveFileAs(myDischarger.FilePath, LibGlobalSource.CREATE_OBJECT);
            Discharger.SaveFileAs(myDischarger.FileRelationPath, LibGlobalSource.CREATE_RELATION);
        }
        private void BtnNewImpExpDef_Click(object sender, EventArgs e)
        {
            CreateImpExp();
        }
    
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datafromBML">DataGridView</param>
        /// <param name="objDischarger">Class Discharger</param>
        /// <param name="parValue10"></param>
        /// <param name="addtionToDesc"></param>
        /// <param name="processValue"></param>
        /*
        public void CreatObjectBML(DataGridView datafromBML,Discharger objDischarger,string parValue10,
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

                objDischarger.Name = Convert.ToString(listName[i].Key.ToString());
                if (String.IsNullOrEmpty(objDischarger.Name))
                {
                    continue;
                }
                #region Subtype         
                noOfSubElements = (int)listName[i].Value;
                switch (noOfSubElements)
                {
                    case 4:
                    case 5:
                       objDischarger.SubType = Discharger.ALL;
                        break;                       
                    case 6:
                    case 7:
                       objDischarger.SubType = Discharger.MJZG;
                        break;
                    default:
                       objDischarger.SubType = Discharger.ALL;
                        break;
                }                           
                    SetElementsName(objDischarger.SubType,objDischarger.Name);
                    SetValue10AndElements();
              
                objDischarger.Value10= parValue10;           
                #endregion              
                descTotalBuilder.Clear();
                bool additionInfToDesc = addtionToDesc.identNumber || addtionToDesc.elevation;
                numberString = LibGlobalSource.StringHelper.ExtractNumericPart(objDischarger.Name, false);
                if (addtionToDesc.section)
                {                
                    if (!string.IsNullOrEmpty(numberString))
                    {
                        if (AppGlobal.ParseInt(numberString.Substring(0, 4), out tempInt))
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
                   AppGlobal.AppendInfoToBuilder(addtionToDesc.elevation, $"{objDischarger.Elevation}{GcObjectInfo.General.AddInfoElevation}", descTotalBuilder);
                    string descName = chkNameOnlyNumber.Checked ? numberString : objDischarger.Name;
                    descName = descName.Contains(GcObjectInfo.General.PrefixName) ? descName.Replace(GcObjectInfo.General.PrefixName, string.Empty) : descName;
                    AppGlobal.AppendInfoToBuilder(addtionToDesc.identNumber, $"({descName})", descTotalBuilder);
                }
                descTotalBuilder.Append($"{BML.MachineType.RollerMiller}");
             
                objDischarger.Description = descTotalBuilder.ToString();
                objDischarger.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
            
        }
        */
        private void CreatObjectRule((bool section, bool userDefSection, bool elevation, bool identNumber, bool cabinet, bool power, bool onlyNumber) addtionToDesc,
            ref (int Value, int Max) processValue)
        {
            int quantityNeedToBeCreate = processValue.Max;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            StringBuilder descTotalBuilder = new StringBuilder();
            RuleSubDataSet description, name;
            RuleSubDataSet discharger, vibro;
            RuleSubDataSet llBin, lsFlow;
            RuleSubDataSet receiver, senderBin;
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
            discharger = new RuleSubDataSet
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
            vibro = new RuleSubDataSet
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
            llBin = new RuleSubDataSet
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
            lsFlow= new RuleSubDataSet
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
            receiver = new RuleSubDataSet
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
            senderBin = new RuleSubDataSet
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
                myDischarger.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            else
            {
                myDischarger.SubType = Discharger.FB56;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (ComboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                myDischarger.PType = selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            else
            {
                myDischarger.PType = Discharger.P2056.ToString();
            }

            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            myDischarger.Value10= value10.ToString();
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            myDischarger.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                myDischarger.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                myDischarger.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Page></Page>
            myDischarger.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                myDischarger.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                myDischarger.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                myDischarger.Panel_ID = selectedPanel_ID;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            myDischarger.FieldBusNode = string.Empty;
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

            ///<DischargerRule>生成名称规则</DischargerRule>
            discharger.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtDischarger.Text, txtDischargerRule.Text);
            if (discharger.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblDischargerRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                discharger.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtDischarger.Text, txtDischargerRule.Text);
            }

            ///<VibroRule>生成名称规则</VibroRule>
            vibro.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtVibro.Text, txtVibroRule.Text);
            if (vibro.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblVibroRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                vibro.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtVibro.Text, txtVibroRule.Text);
            }

            ///<LLBinRule>生成名称规则</LLBin>
            llBin.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtLLBin.Text, txtLLBinRule.Text);
            if (llBin.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblLLBinRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                llBin.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtLLBin.Text, txtLLBinRule.Text);
            }

            ///<LLBinRule>生成名称规则</LLBin>
            lsFlow.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtLSFlow.Text, txtLSFlowRule.Text);
            if (lsFlow.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblLSFlowRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                lsFlow.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtLSFlow.Text, txtLSFlowRule.Text);
            }

            ///<ReceiverRule>生成名称规则</PressureRule>
            receiver.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtReceiver.Text, txtReceiverRule.Text);
            if (receiver.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblReceiverRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                receiver.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtReceiver.Text, txtReceiverRule.Text);
            }
            ///<SenderBinRule>生成名称规则</PressureRule>
            senderBin.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtSenderBin.Text, txtSenderBinRule.Text);
            if (senderBin.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblSenderBinRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                senderBin.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtSenderBin.Text, txtSenderBinRule.Text);
            }

            string selectedDPNode1Item = string.Empty;

            ///<DescRule>生成描述规则</DescRule>
            if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
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
            int symbolInc, symbolRule, descriptionInc, dischargerInc, vibroInc, llBinInc, lsFlowInc, receiverInc, senderBinInc;
            int vibroOnTime, vibroOffTime,restDischargeTime;
            tempBool = AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
            tempBool = AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
            tempBool = AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
            tempBool = AppGlobal.ParseInt(txtDischargerIncRule.Text, out dischargerInc);
            tempBool = AppGlobal.ParseInt(txtDischargerIncRule.Text, out vibroInc);
            tempBool = AppGlobal.ParseInt(txtLLBinIncRule.Text, out llBinInc);
            tempBool = AppGlobal.ParseInt(txtLSFlowIncRule.Text, out lsFlowInc);
            tempBool = AppGlobal.ParseInt(txtReceiverIncRule.Text, out receiverInc);
            tempBool = AppGlobal.ParseInt(txtSenderBinIncRule.Text, out senderBinInc);
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

                if (!String.IsNullOrEmpty(txtDischarger.Text))
                {
                    if (!String.IsNullOrEmpty(txtDischargerIncRule.Text) && !String.IsNullOrEmpty(txtDischargerRule.Text)
                        && AppGlobal.CheckNumericString(txtDischargerIncRule.Text) && AppGlobal.CheckNumericString(txtDischargerIncRule.Text)
                        && (discharger.PosInfo.Len != -1))
                    {
                        discharger.Inc = i * dischargerInc;
                        discharger.Name = LibGlobalSource.StringHelper.GenerateObjectName(discharger.Sub, discharger.PosInfo, (int.Parse(txtDischargerRule.Text) + discharger.Inc).ToString().PadLeft(discharger.PosInfo.Len, '0'));
                    }
                    else
                    {
                        discharger.Name = txtDischarger.Text;
                    }

                }
                else
                {
                    discharger.Name = string.Empty;
                }

                if (!String.IsNullOrEmpty(txtVibro.Text))
                {
                    if (!String.IsNullOrEmpty(txtVibroIncRule.Text) && !String.IsNullOrEmpty(txtVibroRule.Text)
                        && AppGlobal.CheckNumericString(txtVibroIncRule.Text) && AppGlobal.CheckNumericString(txtVibroIncRule.Text)
                        && (vibro.PosInfo.Len != -1))
                    {
                        vibro.Inc = i * vibroInc;
                        vibro.Name = LibGlobalSource.StringHelper.GenerateObjectName(vibro.Sub, vibro.PosInfo, (int.Parse(txtVibroRule.Text) + vibro.Inc).ToString().PadLeft(vibro.PosInfo.Len, '0'));
                    }
                    else
                    {
                        vibro.Name = txtVibro.Text;
                    }

                }
                else
                {
                    vibro.Name = string.Empty;
                }
                if (!String.IsNullOrEmpty(txtLLBin.Text))
                {
                    if (!String.IsNullOrEmpty(txtLLBinIncRule.Text) && !String.IsNullOrEmpty(txtLLBinRule.Text)
                        && AppGlobal.CheckNumericString(txtLLBinIncRule.Text) && AppGlobal.CheckNumericString(txtLLBinIncRule.Text)
                        && (llBin.PosInfo.Len != -1))
                    {
                        llBin.Inc = i * llBinInc;
                        llBin.Name = LibGlobalSource.StringHelper.GenerateObjectName(llBin.Sub, llBin.PosInfo, (int.Parse(txtLLBinRule.Text) + llBin.Inc).ToString().PadLeft(llBin.PosInfo.Len, '0'));
                    }
                    else
                    {
                        llBin.Name = txtLLBin.Text;
                    }

                }
                else
                {
                    llBin.Name = string.Empty;
                }
                if (!String.IsNullOrEmpty(txtLSFlow.Text))
                {
                    if (!String.IsNullOrEmpty(txtLSFlowIncRule.Text) && !String.IsNullOrEmpty(txtLSFlowRule.Text)
                        && AppGlobal.CheckNumericString(txtLSFlowIncRule.Text) && AppGlobal.CheckNumericString(txtLSFlowIncRule.Text)
                        && (lsFlow.PosInfo.Len != -1))
                    {
                        lsFlow.Inc = i * lsFlowInc;
                        lsFlow.Name = LibGlobalSource.StringHelper.GenerateObjectName(lsFlow.Sub, lsFlow.PosInfo, (int.Parse(txtLSFlowRule.Text) + lsFlow.Inc).ToString().PadLeft(lsFlow.PosInfo.Len, '0'));
                    }
                    else
                    {
                        lsFlow.Name = txtLSFlow.Text;
                    }

                }
                else
                {
                    lsFlow.Name = string.Empty;
                }

              
                if (!String.IsNullOrEmpty(txtReceiver.Text))
                {
                    if (!String.IsNullOrEmpty(txtReceiverIncRule.Text) && !String.IsNullOrEmpty(txtReceiverRule.Text)
                        && AppGlobal.CheckNumericString(txtReceiverIncRule.Text) && AppGlobal.CheckNumericString(txtReceiverIncRule.Text)
                        && (receiver.PosInfo.Len != -1))
                    {
                        receiver.Inc = i * receiverInc;
                        receiver.Name = LibGlobalSource.StringHelper.GenerateObjectName(receiver.Sub, receiver.PosInfo, (int.Parse(txtReceiverRule.Text) + receiver.Inc).ToString().PadLeft(receiver.PosInfo.Len, '0'));
                    }
                    else
                    {
                        receiver.Name = txtReceiver.Text;
                    }

                }
                else
                {
                    receiver.Name = string.Empty;
                }

                if (!String.IsNullOrEmpty(txtSenderBin.Text))
                {
                    if (!String.IsNullOrEmpty(txtSenderBinIncRule.Text) && !String.IsNullOrEmpty(txtSenderBinRule.Text)
                        && AppGlobal.CheckNumericString(txtSenderBinIncRule.Text) && AppGlobal.CheckNumericString(txtSenderBinIncRule.Text)
                        && (senderBin.PosInfo.Len != -1))
                    {
                        senderBin.Inc = i * senderBinInc;
                        senderBin.Name = LibGlobalSource.StringHelper.GenerateObjectName(senderBin.Sub, senderBin.PosInfo, (int.Parse(txtSenderBinRule.Text) + senderBin.Inc).ToString().PadLeft(senderBin.PosInfo.Len, '0'));
                    }
                    else
                    {
                        senderBin.Name = txtReceiver.Text;
                    }

                }
                else
                {
                    senderBin.Name = string.Empty;
                }

                myDischarger.Name = name.Name;
                myDischarger.DischargerChild = discharger.Name;
                myDischarger.Vibro= vibro.Name;
                myDischarger.LLBin = llBin.Name;
                myDischarger.LSFlow = lsFlow.Name;
                myDischarger.RefReceiver = receiver.Name;
                myDischarger.RefSenderBin = senderBin.Name;
                myDischarger.Value10 = txtValue10.Text;
                tempBool = AppGlobal.ParseInt(txtParVibroOnTime.Text, out vibroOnTime);
                myDischarger.ParVibroOnTime = tempBool ? (vibroOnTime * 10.0 ).ToString("F1") : "100.0";
                tempBool = AppGlobal.ParseInt(txtParVibroOffTime.Text, out vibroOffTime);
                myDischarger.ParVibroOffTime = tempBool ? (vibroOffTime * 10.0).ToString("F1") : "300.0";
                tempBool = AppGlobal.ParseInt(txtParRestDischargeTime.Text, out restDischargeTime);
                myDischarger.ParRestDischargeTime = tempBool ? (restDischargeTime * 10.0).ToString("F1") : "0.0";
                descTotalBuilder.Clear();
                descTotalBuilder.Append(description.Name);         
                myDischarger.Description = descTotalBuilder.ToString();
                myDischarger.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
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
         int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
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
             myDischarger.Name = objList[i];
             switch (noOfSubElements)
             {                              
                 case 4:
                     if (isVfc)
                     {
                         myDischarger.SubType = Discharger.ALL;
                     }
                     break;          
                 case 6:
                     myDischarger.SubType = Discharger.MJZG;              
                     break;
                 default:
                     myDischarger.SubType = Discharger.ALL;
                     goto case 4;

             }

             SetElementsName(myDischarger.SubType, myDischarger.Name);
             SetValue10AndElements();

             myDischarger.Description = txtDescription.Text;
             myDischarger.Value10 = txtValue10.Text;
             myDischarger.CreateObject(Encoding.Unicode);
             ProgressBar.Value = i;
         }
         ProgressBar.Value = quantityNeedToBeCreate;
     
    }
            */
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myDischarger.Elevation = ComboElevation.Text;
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet =false;
                AppGlobal.AdditionDesc.Power = false;
                if (createMode.BML)
                {

                 //  CreatObjectBML(dataGridBML, myDischarger, txtValue10.Text,AppGlobal.AdditionDesc, out AppGlobal.ProcessValue);
                }
                else if (createMode.AutoSearch)
                {
                   // CreatObjectAutoSearch();
                }
                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreatObjectRule(AppGlobal.AdditionDesc, ref AppGlobal.ProcessValue);
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
