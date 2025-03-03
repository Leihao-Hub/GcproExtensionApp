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
using System.Xml.Linq;
using System.Security.Cryptography;
#endregion
namespace GcproExtensionApp
{
    #pragma warning disable IDE1006
    public partial class FormVFCAdapter : Form, IGcForm
    {
        public FormVFCAdapter()
        {
            InitializeComponent();
        }
        #region Public object in this class
        readonly VFCAdapter myVFCAdapter = new VFCAdapter(AppGlobal.GcproDBInfo.GcproTempPath);
             readonly VFCAdapter myVFCAdapter1 = new VFCAdapter(AppGlobal.GcproDBInfo.GcproTempPath);
        readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        readonly CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        //private string CONNECT_VFC = "关联VFC";
        //private string CONNECT_AO = "关联AO";
        private readonly string DEMO_NAME_VFC = "=A-4001-MXZ03-VFC";
        //private string DEMO_NAME_VFC_SUFFIX = "-VFC";
        private readonly string DEMO_NAME_RULE_VFC = "4001";
        private readonly string DEMO_DESCRIPTION_VFC = "磨粉机喂料辊变频器/或者空白";
        private readonly string DEMO_DESCRIPTION_RULE_VFC = "";
        private readonly string motorSuffix = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_MOTOR}.{AppGlobal.JS_SUFFIX}.";
        private readonly string motorBMLSuffix = $"{AppGlobal.JS_BML}.{AppGlobal.JS_MOTOR}.";
        private int value10 = 1;
        private int tempInt = 0;
        private float tempFloat = (float)0.0;
     //   private bool tempBool = false;
        private GcBaseRule objDefaultInfo;
        #endregion Public object in this class

        #region Public interfaces
        public void GetInfoFromDatabase()
        {
            string itemInfo;
            List<string> list;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.GcsLibaryPath, isNewOledbDriver);
            DataTable dataTable ;
            ///<ReadInfoFromGcsLibrary> 
            ///Read [SubType],[ProcessFct]from GcsLibrary 
            ///</ReadInfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={VFCAdapter.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {VFCAdapter.OTypeValue}",
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
            ///Read [Building],[Elevation],[Panel]
            ///Read [DPNode1]
            ///</ReadInfoFromProjectDB>
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            ///<DPNode> Read [DPNode1]</DPNode>
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
            objDefaultInfo.NameRule = "4001";
            objDefaultInfo.DescLine = "制粉A线";
            objDefaultInfo.DescFloor = "2楼";
            objDefaultInfo.Name = "=A-4001-MXZ03-VFC";
            objDefaultInfo.DescObject = "磨粉机喂料辊变频器";
            objDefaultInfo.DescriptionRuleInc = VFCAdapter.Rule.Common.DescriptionRuleInc;
            objDefaultInfo.NameRuleInc = VFCAdapter.Rule.Common.NameRuleInc;
            VFCAdapter.Rule.Common.Cabinet = VFCAdapter.Rule.Common.Power = string.Empty;

            objDefaultInfo.Description = VFCAdapter.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix: GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: chkAddCabinetToDesc.Checked,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (string.IsNullOrEmpty(VFCAdapter.Rule.Common.Description))
            { VFCAdapter.Rule.Common.Description = objDefaultInfo.Description; }

            if (string.IsNullOrEmpty(VFCAdapter.Rule.Common.Name))
            { VFCAdapter.Rule.Common.Name = objDefaultInfo.Name; }

            if (string.IsNullOrEmpty(VFCAdapter.Rule.Common.DescLine))
            { VFCAdapter.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (string.IsNullOrEmpty(VFCAdapter.Rule.Common.DescFloor))
            { VFCAdapter.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (string.IsNullOrEmpty(VFCAdapter.Rule.Common.DescObject))
            { VFCAdapter.Rule.Common.DescObject = objDefaultInfo.DescObject; }

            txtSymbolRule.Text = VFCAdapter.Rule.Common.NameRule;
            txtSymbolIncRule.Text = VFCAdapter.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = VFCAdapter.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = VFCAdapter.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = VFCAdapter.Rule.Common.Name;
            txtDescription.Text = VFCAdapter.Rule.Common.Description;
            txtIOByteIncRule.Text = VFCAdapter.Rule.ioByteInc.ToString();
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + VFCAdapter.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_VFC);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_VFC);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_VFC);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_VFC);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath,isNewOledbDriver);
            DataTable dataTable;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{VFCAdapter.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{VFCAdapter.ImpExpRuleName}'", null);
                    CreateVFCAdapterImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateVFCAdapterImpExp(oledb);
            }

        }
        public void Default()
        {

            txtSymbol.Focus();
            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            chkParPZDConsistent.Checked = true;
            txtValue10.Text = "1";
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            //  ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            btnReadBML.Enabled = false;
            txtVFCPrefixBML.Text = BML.Motor.PrefixVFC;
            txtVFCSufffixBML.Text = GcObjectInfo.Motor.SuffixVFC;
         
            comboStartRow.SelectedItem = BML.StartRow;
            ComboEquipmentSubType.SelectedIndex = 2;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "变频导入文件 " + " " + myVFCAdapter.FilePath;
        }

        #endregion Public interfaces

        #region <---Rule and autosearch part---> 

        #region <------Check and store rule event------>
        private void UpdateDesc()
        {
            VFCAdapter.EncodingDesc(
            baseRule: ref VFCAdapter.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: chkAddCabinetToDesc.Checked,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = VFCAdapter.Rule.Common.Description;
        }

        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value21.Name,
                OType = Convert.ToString(VFCAdapter.OTypeValue)
            };
            objectBrowser.Show();
        }
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            myVFCAdapter.Name = txtSymbol.Text;
            VFCAdapter.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!VFCAdapter.Rule.Common.Description.Equals(txtDescription.Text))
            {
                VFCAdapter.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(VFCAdapter.Rule.Common.DescObject, false);
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
                    VFCAdapter.Rule.Common.Description = txtDescription.Text;
                    VFCAdapter.DecodingDesc(ref VFCAdapter.Rule.Common, AppGlobal.DESC_SEPARATOR);
                    UpdateDesc();
                }
                catch
                {
                }
            }
        }
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                VFCAdapter.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    VFCAdapter.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
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
                string descObjectNumber = LibGlobalSource.StringHelper.ExtractNumericPart(VFCAdapter.Rule.Common.DescObject, false);
                if (!string.IsNullOrEmpty(descObjectNumber))
                {
                    VFCAdapter.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                    VFCAdapter.Rule.Common.DescObject = VFCAdapter.Rule.Common.DescObject.Replace(descObjectNumber, VFCAdapter.Rule.Common.DescriptionRule);
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
            if (!string.IsNullOrEmpty(txtDescriptionIncRule.Text) && e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    VFCAdapter.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }

        }
        private void txtParIOByte_TextChanged(object sender, EventArgs e)
        {
            if (!AppGlobal.CheckNumericString(txtParIOByte.Text))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtIOByteIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtIOByteIncRule.Text))
                {
                    AppGlobal.ParseValue<int> (txtIOByteIncRule.Text, out VFCAdapter.Rule.ioByteInc);
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        #endregion <------Check and store rule event------>

        #region <------Check and unchek "Value9" and "Value10"------>
        private void chkParPZDConsistent_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPZDConsistent.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)0); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)0); }

            myVFCAdapter.Value10 = value10;
            txtValue10.Text = myVFCAdapter.Value10.ToString();
        }

        private void chkParProfinet_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParProfinet.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)1); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)1); }

            myVFCAdapter.Value10 = value10;
            txtValue10.Text = myVFCAdapter.Value10.ToString();
        }

        private void chkParWithActivePower_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithActivePower.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)2); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)2); }

            myVFCAdapter.Value10 = value10;
            txtValue10.Text = myVFCAdapter.Value10.ToString();
        }

        private void chkWithMultiMotorCfg_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkWithMultiMotorCfg.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)16); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)16); }

            myVFCAdapter.Value10 = value10;
            txtValue10.Text = myVFCAdapter.Value10.ToString();
        }
        #endregion <------ Check and unchek "Value9" and "Value10------>

        #region <------Field in database display------>
        private void TxtSymbol_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Text0";
        }

        private void TxtDescription_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Text1";
        }

        private void ComboDPNode1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "DPNode1";
        }

        private void txtParSpeedLimitMin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value18";
        }

        private void txtParSpeedLimitMax_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value19";
        }

        private void txtMEAGGateway_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }

        private void txtParSalveIndex_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }

        private void txtOutpHardwareStop_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value13";
        }

        private void txtParSpeedMaxDigits_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value15";
        }

        private void txtParSpeedUnitsByZeroDigits_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value16";
        }

        private void txtParSpeedUnitsByMaxDigits_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value17";
        }

        private void txtParUnitsPerDigits_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value14";
        }

        private void txtParLenPKW_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }

        private void txtParLenPZD_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }

        private void txtParLenPZDInp_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value44";
        }

        private void txtParIOByte_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void chkParPZDConsistent_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit0";
        }

        private void chkParProfinet_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }

        private void chkParWithActivePower_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit2";
        }

        private void txtParPNO_T1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }

        private void txtParUnitsPerDigit_T1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value35";
        }

        private void txtParPNO_T2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }

        private void txtParUnitsPerDigit_T2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value36";
        }

        private void txtParPNO_T3_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value27";
        }

        private void txtParUnitsPerDigit_T3_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value37";
        }

        private void txtParPNO_T4_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value28";
        }
        private void txtParUnitsPerDigit_T4_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value38";
        }
        private void txtParPNO_T5_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value29";
        }

        private void txtParUnitsPerDigit_T5_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value39";
        }

        private void chkWithMultiMotorCfg_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit16";
        }
        private void txtParRefCurrent_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value40";
        }

        private void txtParRefTorque_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value41";
        }

        private void txtParRefPower_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value42";
        }
        #endregion  <------Field in database display------> 

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
        private void BtnOpenProjectBML_Click(object sender, EventArgs e)
        {
            TxtExcelPath.Text = ExcelFileHandle.BrowseFile();
            excelFileHandle.FilePath = TxtExcelPath.Text;
            AddWorkSheets();

        }
        private void TxtExcelPath_DoubleClick(object sender, EventArgs e)
        {
            TxtExcelPath.Text = ExcelFileHandle.BrowseFile();
            //   excelFileHandle.FilePath = TxtExcelPath.Text;
            AddWorkSheets();
        }
        private void txtVFCSufffixBML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtVFCSufffixBML.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorSuffix}VFC", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixVFC = newJsonKeyValue;

            }
        }
        private void txtVFCPrefixBML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtVFCPrefixBML.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_BML}.{AppGlobal.JS_MOTOR}.VFC", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixPowerApp = newJsonKeyValue;
            }
        }
        private void TxtExcelPath_TextChanged(object sender, EventArgs e)
        {
            excelFileHandle.FilePath = TxtExcelPath.Text;
            BML.Motor.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{motorBMLSuffix}{AppGlobal.JS_PATH}", BML.Motor.BMLPath);
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
           // AddWorkSheets();
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
            TxtQuantity.Text = dataGridBML.Rows.Count.ToString();
        }
        private void CreateBMLDefault()
        {
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

            }
            comboNameBML.SelectedItem = "B";
            comboDescBML.SelectedItem = "N";
            comboTypeBML.SelectedItem = "C";
            comboFloorBML.SelectedItem = "L";
            comboPowerBML.SelectedItem = "E";
            comboCabinetBML.SelectedItem = "P";
            comboSectionBML.SelectedItem = "Q";
            comboControlBML.SelectedItem = "H";
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
                HeaderText = BML.ColumnControlMethod,
                Name = nameof(BML.ColumnControlMethod)
            });

            dataGridBML.Columns[nameof(BML.ColumnDesc)].Width = 126;
            dataGridBML.Columns[nameof(BML.ColumnPower)].Width = 56;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].Width = 56;
            dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].Width = 66;
            dataGridBML.Columns[nameof(BML.ColumnCabinet)].Width = 66;
            dataGridBML.Columns[nameof(BML.ColumnControlMethod)].Width = 188;
            txtVFCSufffixBML.Text = GcObjectInfo.Motor.SuffixVFC;
            txtVFCPrefixBML.Text = BML.Motor.PrefixVFC;
        }
        private void btnReadBML_Click(object sender, EventArgs e)
        {
            // List<List<object>> allData = new List<List<object>>();
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboPowerBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboControlBML.Text};
            DataTable dataTable;
            string[] filters = { $"Value=={BML.Motor.Type}", $@"Value LIKE ""{BML.Motor.PrefixVFC}%""" };
            string[] filterColumns = { comboTypeBML.Text, comboControlBML.Text };
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);
            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;

            dataGridBML.Columns[nameof(BML.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnPower)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnControlMethod)].DataPropertyName = dataTable.Columns[6].ColumnName;

            TxtQuantity.Text = dataTable.Rows.Count.ToString();
        }
        #endregion <---BML part--->

        #region  <---Common used--->
        private double GetIOByteLen(double lenPKW,double lenPZD)
        {
            return (lenPKW + lenPZD);
        }
        private string GetIOByteLen(string lenPKW, string lenPZD)
        {
            AppGlobal.ParseValue<int>(lenPKW, out int _lenPKW);
            AppGlobal.ParseValue<int>(lenPZD, out int _lenPZD);
            return (_lenPKW + _lenPZD).ToString();
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BML.VFCAdapter.VFCAdapterParameters vfc = new BML.VFCAdapter.VFCAdapterParameters();
            string selectedItem = Convert.ToString(ComboEquipmentSubType.SelectedItem);
            myVFCAdapter.SubType = string.IsNullOrEmpty(selectedItem) ? VFCAdapter.ATVDP :
                selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
         
            ///<ATV>  
            if (myVFCAdapter.SubType.StartsWith("ATV"))
            {
              //  vfc.Name = BML.VFCAdapter.TypeEnmu.ATV930;
                txtParLenPZDInp.Enabled = false;
                txtParPNO_T1.Text = txtParUnitsPerDigit_T1.Text = "0";
                txtParPNO_T2.Text = txtParUnitsPerDigit_T2.Text = "0";
                txtParPNO_T3.Text = txtParUnitsPerDigit_T3.Text = "0";
                txtParPNO_T4.Text = txtParUnitsPerDigit_T4.Text = "0";
                txtParPNO_T5.Text = txtParUnitsPerDigit_T5.Text = "0";
                if (myVFCAdapter.SubType == VFCAdapter.ATVDP)
                {
                    txtParPNO_T1.BackColor = txtParUnitsPerDigit_T1.BackColor = Color.LightGreen;
                    txtParPNO_T2.BackColor = txtParUnitsPerDigit_T2.BackColor = Color.LightGreen;
                    txtParPNO_T3.BackColor = txtParUnitsPerDigit_T3.BackColor = Color.LightGreen;
                    txtParPNO_T4.BackColor = txtParUnitsPerDigit_T4.BackColor = Color.LightGreen;
                    txtParPNO_T5.BackColor = txtParUnitsPerDigit_T5.BackColor = Color.LightGreen;
                }
                else
                {
                    txtParPNO_T1.BackColor = txtParUnitsPerDigit_T1.BackColor = Color.White;
                    txtParPNO_T2.BackColor = txtParUnitsPerDigit_T2.BackColor = Color.White;
                    txtParPNO_T3.BackColor = txtParUnitsPerDigit_T3.BackColor = Color.White;
                    txtParPNO_T4.BackColor = txtParUnitsPerDigit_T4.BackColor = Color.White;
                    txtParPNO_T5.BackColor = txtParUnitsPerDigit_T5.BackColor = Color.White;
                }
            }
            ///</ATV>  

            ///<ABB>  
            if (myVFCAdapter.SubType == VFCAdapter.VFCA7)
            {
              //  vfc.Name = BML.VFCAdapter.TypeEnmu.ABB;
                txtParLenPZDInp.Enabled = false;

            }
            ///</ABB>

            ///<ATVMEAGGateWay>
            if (myVFCAdapter.SubType == VFCAdapter.ATVM)
            {           
                txtParLenPZDInp.Enabled = false;
                txtMEAGGateway.Enabled = true;
                txtParSalveIndex.Enabled = true;
                txtParSlaveIndexIncRule.Enabled = true;
                txtOutpHardwareStop.Enabled = true;
                chkParPZDConsistent.Checked = true;
            }
            else
            {
                txtMEAGGateway.Enabled = false;
                txtParSalveIndex.Enabled = false;
                txtParSlaveIndexIncRule.Enabled = false;
                txtOutpHardwareStop.Enabled = false;

            }
            ///</ATVMEAGGateWay>

            ///<VFCPNGateWay>
            if (myVFCAdapter.SubType == VFCAdapter.VFCPNG)
            {              
                txtParLenPZDInp.Enabled = false;     
            }
            ///</VFCPNGateWay>
            ///
            ///<DanfossFC>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA4)
            {
              //  vfc.Name = BML.VFCAdapter.TypeEnmu.DanfossFC;
                txtParLenPZDInp.Enabled = false;
                //txtParPNO_T1.Text = "414";
                //txtParUnitsPerDigit_T1.Text = "0.1";
                //txtParPNO_T2.Text = "120";
                //txtParUnitsPerDigit_T2.Text = "0.01";   
            }
            ///</DanfossFC>
            ///
            ///<DanfossProfidrive>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA5)
            {
               // vfc.Name = BML.VFCAdapter.TypeEnmu.DanfossProfidrive;
                txtParLenPZDInp.Enabled = false;
                //txtParPNO_T1.Text = "414";
                //txtParUnitsPerDigit_T1.Text = "0.1";
                //txtParPNO_T2.Text = "120";
                //txtParUnitsPerDigit_T2.Text = "0.01";
                txtParPNO_T1.BackColor = txtParUnitsPerDigit_T1.BackColor = Color.LightGreen;
                txtParPNO_T2.BackColor = txtParUnitsPerDigit_T2.BackColor = Color.LightGreen;
            }
            ///</DanfossProfidrive>
            ///
            ///<ET200SMotorStarter>
            if (myVFCAdapter.SubType == VFCAdapter.VFCMS3RK)
            {
              //  vfc.Name = BML.VFCAdapter.TypeEnmu.SSET200S;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</ET200SMotorStarter>
            ///
            ///<Lenze>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA11)
            {
              //  vfc.Name = BML.VFCAdapter.TypeEnmu.Lenze;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</Lenze>
            ///
            ///<LenzePos>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA12)
            {
              //  vfc.Name = BML.VFCAdapter.TypeEnmu.Lenze;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;

            }
            ///</LenzePos>
            ///
            ///<Leroy>
            if (myVFCAdapter.SubType == VFCAdapter.VFCLS)
            {
               // vfc.Name = BML.VFCAdapter.TypeEnmu.Leroy;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;

            }
            ///</<Leroy>
            ///
            ///<MOVIDRIVEIpos>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA10)
            {
               // vfc.Name = BML.VFCAdapter.TypeEnmu.MOVIDRIVE;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;

            }
            ///</MOVIDRIVEIpos>
            ///
            ///<MOVIDRIVESpeed>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA0)
            {

               // vfc.Name = BML.VFCAdapter.TypeEnmu.MOVIDRIVE;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</MOVIDRIVESpeed>
            ///
            ///<MOVIKIT>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA13)
            {

              //  vfc.Name = BML.VFCAdapter.TypeEnmu.MOVIDRIVE;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
                //txtParPNO_T1.Text = "8326";
                //txtParUnitsPerDigit_T1.Text = "0.001";
                //txtParPNO_T2.Text = "8323";
                //txtParUnitsPerDigit_T2.Text = "0.001";
                txtParPNO_T1.BackColor = txtParUnitsPerDigit_T1.BackColor = Color.LightGreen;
                txtParPNO_T2.BackColor = txtParUnitsPerDigit_T2.BackColor = Color.LightGreen;
            }
            ///</MOVIKIT>
            ///
            ///<MOVITRAC>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA6)
            {
             //   vfc.Name = BML.VFCAdapter.TypeEnmu.MOVIDRIVE;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</MOVITRAC>
            ///
            ///<MicroMaster>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA1)
            {
             //   vfc.Name = BML.VFCAdapter.TypeEnmu.MicroMaster;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</MicroMaster>
            ///
            ///<Nord>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA3)
            {
              //  vfc.Name = BML.VFCAdapter.TypeEnmu.NORD;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</Nord>
            ///
            ///<Sinamics>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA2)
            {
             //   vfc.Name = BML.VFCAdapter.TypeEnmu.Sinamics;

                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = true;
                txtParRefPower.Enabled = true;
                txtParRefTorque.Enabled = true;
                txtParRefCurrent.Enabled = true;
            }
            else
            {
                chkParWithActivePower.Enabled = false;
                txtParRefPower.Enabled = false;
                txtParRefTorque.Enabled = false;
                txtParRefCurrent.Enabled = false;
            }
            ///</Sinamics>
            ///
            ///<SoftStarter3RW44>
            if (myVFCAdapter.SubType == VFCAdapter.SST01DP)
            {

              //  vfc.Name = BML.VFCAdapter.TypeEnmu.SS3RW44;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</<SoftStarter3RW44>
            ///
            ///   ///<SoftStarter3RW44>
            if (myVFCAdapter.SubType == VFCAdapter.SST02DP)
            {

              //  vfc.Name = BML.VFCAdapter.TypeEnmu.SS3RW5x;
                txtParLenPZDInp.Enabled = true;
                chkParWithActivePower.Enabled = false;
            }
            ///<CommonUsedPar></CommonUsedPar>
            txtParLenPKW.Text = myVFCAdapter.LenPKW.ToString();
            txtParLenPZD.Text = myVFCAdapter.LenPZD.ToString();
            txtParLenPZDInp.Text = myVFCAdapter.LenPZDInp.ToString();
            txtParUnitsPerDigits.Text = myVFCAdapter.UnitsPerDigits.ToString();
            txtParSpeedMaxDigits.Text = myVFCAdapter.SpeedMaxDigits.ToString();
            txtParSpeedUnitsByMaxDigits.Text = myVFCAdapter.SpeedUnitsByMaxDigits.ToString();
            txtParSpeedUnitsByZeroDigits.Text = myVFCAdapter.SpeedUnitsByZeroDigits.ToString();
            txtParSpeedLimitMax.Text = myVFCAdapter.SpeedLimitMax.ToString();
            txtParSpeedLimitMin.Text = myVFCAdapter.SpeedLimitMin.ToString();

            txtParPNO_T1.Text = myVFCAdapter.Telegram1.ParPNO.ToString();
            txtParUnitsPerDigit_T1.Text = myVFCAdapter.Telegram1.ParUnitsPerDigit.ToString();
            txtParPNO_T2.Text = myVFCAdapter.Telegram2.ParPNO.ToString();
            txtParUnitsPerDigit_T2.Text = myVFCAdapter.Telegram2.ParUnitsPerDigit.ToString();
            chkParPZDConsistent.Checked = vfc.par.ParPZDConsistent;
            txtIOByteIncRule.Text = GetIOByteLen(txtParLenPKW.Text, txtParLenPZD.Text); 
        }

        private void txtParSpeedLimitMin_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.SpeedLimitMin = AppGlobal.ParseValue<int>(txtParSpeedLimitMin.Text, out tempInt) ? tempInt : 0;
        }

        private void txtParSpeedLimitMax_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.SpeedLimitMax = AppGlobal.ParseValue<int>(txtParSpeedLimitMax.Text, out tempInt) ? tempInt : 100;
        }

        private void txtParSpeedMaxDigits_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.SpeedMaxDigits = AppGlobal.ParseValue<int>(txtParSpeedMaxDigits.Text, out tempInt) ? tempInt : 500;
        }

        private void txtParSpeedUnitsByZeroDigits_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.SpeedUnitsByZeroDigits = AppGlobal.ParseValue<int>(txtParSpeedUnitsByZeroDigits.Text, out tempInt) ? tempInt : 0;
        }

        private void txtParSpeedUnitsByMaxDigits_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.SpeedUnitsByMaxDigits = AppGlobal.ParseValue<int>(txtParSpeedUnitsByMaxDigits.Text, out tempInt) ? tempInt : 100;
        }

        private void txtParUnitsPerDigits_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.UnitsPerDigits = AppGlobal.ParseValue<float>(txtParUnitsPerDigits.Text, out tempFloat) ? Math.Round(tempFloat, 1) : 0.1;
        }


        private void txtParLenPZDInp_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.LenPZDInp = AppGlobal.ParseValue<int>(txtParLenPZDInp.Text, out tempInt) ? tempInt : 0;
        }
        private void txtParLenPZD_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.LenPZD = AppGlobal.ParseValue<int>(txtParLenPZD.Text, out tempInt) ? tempInt : 6;
            txtIOByteIncRule.Text = GetIOByteLen(txtParLenPKW.Text, txtParLenPZD.Text);
        }         
        private void txtParLenPKW_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.LenPKW = AppGlobal.ParseValue<int>(txtParLenPKW.Text, out tempInt) ? tempInt : 0;
            txtIOByteIncRule.Text = GetIOByteLen(txtParLenPKW.Text, txtParLenPZD.Text);
        }
                                   
        private void txtParPNO_T1_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram1</Telegram1>
            myVFCAdapter.Telegram1.ParPNO = string.IsNullOrEmpty(txtParPNO_T1.Text) ? 0 :
                                    (AppGlobal.ParseValue<float>(txtParPNO_T1.Text, out tempFloat) ? tempFloat : 0);
           
        }

        private void txtParUnitsPerDigit_T1_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram1</Telegram1>
            myVFCAdapter.Telegram1.ParUnitsPerDigit = string.IsNullOrEmpty(txtParUnitsPerDigit_T1.Text) ? 0 :
                        (AppGlobal.ParseValue<float>(txtParUnitsPerDigit_T1.Text, out tempFloat) ? tempFloat : 0);
        }

        private void txtParPNO_T2_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram2</Telegram2>
            myVFCAdapter.Telegram2.ParPNO = string.IsNullOrEmpty(txtParPNO_T2.Text) ? 0 :
                                (AppGlobal.ParseValue<float>(txtParPNO_T2.Text, out tempFloat) ? tempFloat : 0);
        }

        private void txtParUnitsPerDigit_T2_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram2</Telegram2>
             myVFCAdapter.Telegram2.ParUnitsPerDigit = string.IsNullOrEmpty(txtParUnitsPerDigit_T2.Text)? 0 :
            (AppGlobal.ParseValue<float>(txtParUnitsPerDigit_T2.Text, out tempFloat) ? tempFloat : 0);
        }

        private void txtParPNO_T3_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram3</Telegram3>
            myVFCAdapter.Telegram3.ParPNO = string.IsNullOrEmpty(txtParPNO_T3.Text) ? 0 :
                                (AppGlobal.ParseValue<float>(txtParPNO_T3.Text, out tempFloat) ? tempFloat : 0);

        }

        private void txtParUnitsPerDigit_T3_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram3</Telegram3>
            myVFCAdapter.Telegram3.ParUnitsPerDigit = string.IsNullOrEmpty(txtParUnitsPerDigit_T3.Text) ? 0 :
                    (AppGlobal.ParseValue<float>(txtParUnitsPerDigit_T3.Text, out tempFloat) ? tempFloat : 0);
        }
              
        private void txtParPNO_T4_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram4</Telegram4>
            myVFCAdapter.Telegram4.ParPNO = string.IsNullOrEmpty(txtParPNO_T4.Text) ? 0 :
                                    (AppGlobal.ParseValue<float>(txtParPNO_T4.Text, out tempFloat) ? tempFloat : 0);
        }

        private void txtParUnitsPerDigit_T4_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram4</Telegram4>
            myVFCAdapter.Telegram4.ParUnitsPerDigit = string.IsNullOrEmpty(txtParUnitsPerDigit_T4.Text) ? 0 :
                   (AppGlobal.ParseValue<float>(txtParUnitsPerDigit_T4.Text, out tempFloat) ? tempFloat : 0);
        }

        private void txtParPNO_T5_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram5</Telegram5>
            myVFCAdapter.Telegram5.ParPNO = string.IsNullOrEmpty(txtParPNO_T5.Text) ? 0 :
                                (AppGlobal.ParseValue<float>(txtParPNO_T5.Text, out tempFloat) ? tempFloat : 0);
        }

        private void txtParUnitsPerDigit_T5_TextChanged(object sender, EventArgs e)
        {
            ///<Telegram5</Telegram5>
            myVFCAdapter.Telegram5.ParUnitsPerDigit = string.IsNullOrEmpty(txtParUnitsPerDigit_T5.Text) ? 0 :
                    (AppGlobal.ParseValue<float>(txtParUnitsPerDigit_T5.Text, out tempFloat) ? tempFloat : 0);
        }
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
                VFCAdapter.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            VFCAdapter.Rule.Common.DescFloor = ComboElevation.Text;
            UpdateDesc();
        }
        private void CreateVFCAdapterImpExp(OleDb oledb)
        {

            bool result = myVFCAdapter.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormVFCAdapter_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormVFCAdapter_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                txtSymbolRule.Text = VFCAdapter.Rule.Common.NameRule;
                txtSymbolIncRule.Text = VFCAdapter.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                //     txtSymbol.Text = DEMO_NAME_VFC;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.BML)
            {
                createMode.Rule = false;
                createMode.BML = true;
                createMode.AutoSearch = false;
                tabCreateMode.SelectedTab = tabBML;
                //  txtSymbol.Text = DEMO_NAME_VFC_SUFFIX;
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
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_CLEAR_FILE, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)

            {
                myVFCAdapter.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            VFCAdapter.SaveFileAs(myVFCAdapter.FilePath, LibGlobalSource.CREATE_OBJECT);
            // VFCAdapter.SaveFileAs(myVFCAdapter.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
                VFCAdapter.ReGenerateDPNode(oledb);
            }
        }
        private void CreateObjectRule(VFCAdapter objVFCAdapter,
          (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
          ref (int Value, int Max) processValue)
        {
            #region common used variables declaration
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            StringBuilder objBuilder = new StringBuilder();
            TextFileHandle objTextFileHandle = new TextFileHandle();
            int ioByte = AppGlobal.ParseValue<int>(txtParIOByte.Text, out tempInt) ? tempInt : 0;
            int ioByteInc = AppGlobal.ParseValue<int>(txtIOByteIncRule.Text, out tempInt) ? tempInt : 0;
            bool needDPNodeChanged = false;
            int quantityNeedToBeCreate = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
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
            //dpNode1 = new RuleSubDataSet
            //{
            //    Sub = new string[] { },
            //    Inc = 0,
            //    PosInfo = new RuleSubPos
            //    {
            //        StartPos = false,
            //        MidPos = false,
            //        EndPos = false,
            //        PosInString = 0,
            //        Len = 0,
            //    }
            //};
            #endregion common used variables declaration

            #region Prepare export vfc file
            ///<OType>is set when object generated</OType>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            objVFCAdapter.Description = txtDescription.Text;
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                objVFCAdapter.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                objVFCAdapter.SubType = VFCAdapter.ATVDP;
            }
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                objVFCAdapter.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objVFCAdapter.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objVFCAdapter.Elevation = selectedElevation;
            }
            ///<FieldBusNode></FieldBusNode>  
            objVFCAdapter.FieldBusNode = AppGlobal.NO_DP_NODE;
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objVFCAdapter.Panel_ID = selectedPanel_ID;
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objVFCAdapter.Diagram = (int)VFCAdapter.ParseInfoValue(selectedDiagram, AppGlobal.FIELDS_SEPARATOR, AppGlobal.NO_DIAGRAM);
            }
            ///<Page></Page>
            objVFCAdapter.Page = txtPage.Text;
            ///<DPNode1></DPNode1>
            string selectDPNode1 = string.Empty;
            if (ComboDPNode1.SelectedItem != null)
            {
                selectDPNode1 = ComboDPNode1.SelectedItem.ToString();          
                AppGlobal.FieldbusNodeInfo = DI.ParseFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, selectDPNode1);

                objVFCAdapter.DPNode1 = AppGlobal.FieldbusNodeInfo.DPNodeNo;
                objVFCAdapter.FieldBusNode = AppGlobal.FieldbusNodeInfo.FieldBusNodeKey;
            }
            ///<Value9>Value9 is not used here</Value9>
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>

            ///<ParSpeedLimitMin></ParSpeedLimitMin>
           // objVFCAdapter.SpeedLimitMin = AppGlobal.ParseValue<int>(txtParSpeedLimitMin.Text, out tempInt) ? tempInt : 0;
            ///<ParSpeedLimitMax></ParSpeedLimitMax>
           // objVFCAdapter.SpeedLimitMax = AppGlobal.ParseValue<int>(txtParSpeedLimitMax.Text, out tempInt) ? tempInt : 100;
            ///<ParSpeedMaxDigits></ParSpeedMaxDigits>
           // objVFCAdapter.SpeedMaxDigits = AppGlobal.ParseValue<int>(txtParSpeedMaxDigits.Text, out tempInt) ? tempInt : 500;
            ///<ParSpeedUnitsByZeroDigits></ParSpeedUnitsByZeroDigits>
          //  objVFCAdapter.SpeedUnitsByZeroDigits = AppGlobal.ParseValue<int>(txtParSpeedUnitsByZeroDigits.Text, out tempInt) ? tempInt : 0;
            ///<ParSpeedUnitsByZeroDigits></ParSpeedUnitsByZeroDigits>
          //  objVFCAdapter.SpeedUnitsByMaxDigits = AppGlobal.ParseValue<int>(txtParSpeedUnitsByMaxDigits.Text, out tempInt) ? tempInt : 100;
            ///<ParUnitsPerDigits</ParUnitsPerDigits>
          //  objVFCAdapter.UnitsPerDigits = AppGlobal.ParseValue<float>(txtParUnitsPerDigits.Text, out tempFloat) ? Math.Round(tempFloat,1) : 0.1;
            ///<ParLenPKW</ParLenPKW>
          //  objVFCAdapter.LenPKW = AppGlobal.ParseValue<int>(txtParLenPKW.Text, out tempInt) ? tempInt : 0;
            ///<ParLenPZD</ParLenPZD>
         //   objVFCAdapter.LenPZD = AppGlobal.ParseValue<int>(txtParLenPZD.Text, out tempInt) ? tempInt : 6;
            ///<ParLenPZDInp</ParLenPZDInp>
         //   objVFCAdapter.LenPZDInp = AppGlobal.ParseValue<int>(txtParLenPZDInp.Text, out tempInt) ? tempInt : 0;
            ///<ParIOByteNo</ParIOByteNo>
            objVFCAdapter.IoByteNo = AppGlobal.ParseValue<int>(txtParIOByte.Text, out tempInt) ? tempInt : 20000;
            ///<MEAGGateway</MEAGGateway<>
            objVFCAdapter.MeagGateway = objVFCAdapter.SubType == VFCAdapter.ATVM ? txtMEAGGateway.Text : "0";
            ///<SlaveIndex</SlaveIndex>      
            objVFCAdapter.SlaveIndex = objVFCAdapter.SubType == VFCAdapter.ATVM ?
                (AppGlobal.ParseValue<int>(txtParSalveIndex.Text, out tempInt) ? tempInt : 0) : 0;
            ///<OutpHardwareStop</OutpHardwareStop>
            objVFCAdapter.OutpHardwareStop = objVFCAdapter.SubType == VFCAdapter.ATVM ? txtOutpHardwareStop.Text : "0";


            ///<Sinamics>
            ///[RefCurrent],[RefTorque],[RefPower]
            ///don't need ,they will read from VFC            
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            #endregion Prepare export vfc file

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
                needDPNodeChanged = true;
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
            string desc = VFCAdapter.Rule.Common.DescObject;
            if (!string.IsNullOrEmpty(txtDescriptionRule.Text))
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
            #endregion Parse rules

            processValue.Max = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt - 1 : 1;
            processValue.Value = 0;
            ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
            AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out int symbolInc);
            AppGlobal.ParseValue<int>(txtSymbolRule.Text, out int symbolRule);
            AppGlobal.ParseValue<int>(txtDescriptionIncRule.Text, out int descriptionInc);
            for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                if (needDPNodeChanged && moreThanOne)
                {
                   // dpNode1.Inc = i * symbolInc;
                   // dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());
                   
                    AppGlobal.FieldbusNodeInfo = DI.ParseFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, objVFCAdapter.Name);

                    objVFCAdapter.DPNode1 = AppGlobal.FieldbusNodeInfo.DPNodeNo;
                    objVFCAdapter.FieldBusNode = AppGlobal.FieldbusNodeInfo.FieldBusNodeKey;
                }

                if (!string.IsNullOrEmpty(desc))
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
                        description.Name = desc;
                    }

                }
                else
                {
                    description.Name = "变频器";
                }
                objVFCAdapter.Name = name.Name;

                VFCAdapter.Rule.Common.Name = name.Name;
                VFCAdapter.Rule.Common.DescObject = description.Name;
                objVFCAdapter.Description = VFCAdapter.EncodingDesc(
                    baseRule: ref VFCAdapter.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
                // objVFCAdapter.Description = description.Name;
                objVFCAdapter.IoByteNo = ioByte + i * ioByteInc;
                objVFCAdapter.CreateObjectRecordAndRelation(objBuilder);
                processValue.Value = i;
            }
            objVFCAdapter.CreateObject(objTextFileHandle, Encoding.Unicode);
            processValue.Value = processValue.Max;
        }
        public void CreateObjectBML(DataGridView dataFromBML, VFCAdapter objVFCAdapter,
             (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
             out (int Value, int Max) processValue)
        {
            #region common used variables declaration
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            StringBuilder objBuilder = new StringBuilder();
            TextFileHandle objTextFileHandle = new TextFileHandle();
            int quantityNeedToBeCreate = dataFromBML.Rows.Count;
            int slaveIndexInc = AppGlobal.ParseValue<int>(txtParSlaveIndexIncRule.Text, out tempInt) ? tempInt : 1;
            int ioByteInc = AppGlobal.ParseValue<int>(txtIOByteIncRule.Text, out tempInt) ? tempInt : 0;
            int ioByte = AppGlobal.ParseValue<int>(txtParIOByte.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            string desc = string.Empty;
            string motor = string.Empty;
            bool onlyOne = quantityNeedToBeCreate == 1;
            int nextIOByte = ioByte;
            string nameNumberString;
            #endregion common used variables declaration
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            BML.VFCAdapter.VFCAdapterParameters vfc = new BML.VFCAdapter.VFCAdapterParameters();
            objDefaultInfo = VFCAdapter.Rule.Common;
            DataGridViewCell cell;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {      
                cell = dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || string.IsNullOrEmpty(cell.Value.ToString()))
                    continue;
                ///<Name>   </Name>
                motor = Convert.ToString(cell.Value);
                objVFCAdapter.Name = motor + GcObjectInfo.Motor.SuffixVFC;
                ///<Description>   </Description>    
                desc = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value);
                if (addtionToDesc.Section)
                {
                    nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, objVFCAdapter.Name);
                    if (!string.IsNullOrEmpty(nameNumberString))
                    {
                        if (AppGlobal.ParseValue<int>(nameNumberString, out tempInt))
                        {
                            VFCAdapter.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.UserDefSection)
                {
                    VFCAdapter.Rule.Common.DescLine = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value); ;
                }

                VFCAdapter.Rule.Common.Name = objVFCAdapter.Name;
                VFCAdapter.Rule.Common.DescFloor = $"{objVFCAdapter.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                VFCAdapter.Rule.Common.DescObject = $"{desc}{AppGlobal.VFC}";
                VFCAdapter.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{myVFCAdapter.Panel_ID}";
                objVFCAdapter.Description = VFCAdapter.EncodingDesc(
                    baseRule: ref VFCAdapter.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
                ///<Panel_ID>   </Panel_ID>  
                objVFCAdapter.Panel_ID = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value) +
                    Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                ///<Elevation>   </Elevation>  
                objVFCAdapter.Elevation = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);
                ///<IOByteNo>   </IOByteNo> 
                string controlMethod = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnControlMethod)].Value);

                if (controlMethod.Contains(BML.VFCAdapter.TypeEnmu.ATV320.Substring(0,3)))
                {
                    objVFCAdapter.SubType = VFCAdapter.ATVDP;
                    if (controlMethod.Contains(BML.VFCAdapter.TypeEnmu.ATV320))
                    {
                        vfc.Name = BML.VFCAdapter.TypeEnmu.ATV320;
                    }
                    else if (controlMethod.Contains(BML.VFCAdapter.TypeEnmu.ATV930))
                    {
                        vfc.Name = BML.VFCAdapter.TypeEnmu.ATV930;                       
                    }
                    else if (controlMethod.Contains(BML.VFCAdapter.TypeEnmu.ATV955))
                    {
                        vfc.Name = BML.VFCAdapter.TypeEnmu.ATV955;
                    }
                }
                else if (controlMethod.Contains(BML.VFCAdapter.TypeEnmu.ABB))
                {
                    vfc.Name = BML.VFCAdapter.TypeEnmu.ABB;
                    objVFCAdapter.SubType = VFCAdapter.VFCA7;
                }
                else if (controlMethod.Contains(BML.VFCAdapter.TypeEnmu.FC280))
                {
                    vfc.Name = BML.VFCAdapter.TypeEnmu.FC280;
                    objVFCAdapter.SubType = VFCAdapter.VFCA4;
                }
                ///The following parameters are changed in class interbal when sutype changed.
                ///<ParSpeedLimitMin></ParSpeedLimitMin>
                ///<ParSpeedLimitMax></ParSpeedLimitMax>
                ///<ParSpeedUnitsByZeroDigits></ParSpeedUnitsByZeroDigits>
                ///<ParSpeedUnitsByZeroDigits></ParSpeedUnitsByZeroDigits>
                ///<ParUnitsPerDigits</ParUnitsPerDigits>
                ///Overwrite <ParSpeedMaxDigits></ParSpeedMaxDigits>
                if (objVFCAdapter.Description.Contains(BML.MachineType.RollerMiller))
                { 
                    objVFCAdapter.SpeedMaxDigits = 1000;
                }
                /// Overwrite <ParLenPKW> and <ParLenPZD>
                ///<ParLenPKW></ParLenPKW></ParLenPKW>
                objVFCAdapter.LenPKW = vfc.Par.LenPKW;
                ///<ParLenPZD></ParLenPZD>
                objVFCAdapter.LenPZD = vfc.Par.LenPZD;
                ///<ParLenPZDInp</ParLenPZDInp>
               // objVFCAdapter.LenPZDInp = vfc.Par.LenPZDInp;
                ioByteInc = Convert.ToInt32(GetIOByteLen(vfc.Par.LenPKW, vfc.Par.LenPZD));
                // objVFCAdapter.IoByteNo = Convert.ToString(ioByte + i * ioByteInc);
                objVFCAdapter.IoByteNo = nextIOByte;
                nextIOByte += ioByteInc;
                ///<DPNode1>   </DPNode1>                                               
                AppGlobal.FieldbusNodeInfo = VFCAdapter.ParseFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, motor);

                objVFCAdapter.DPNode1 = AppGlobal.FieldbusNodeInfo.DPNodeNo;
                objVFCAdapter.FieldBusNode = AppGlobal.FieldbusNodeInfo.FieldBusNodeKey;
                ///<CreateObject>   </CreateObject>
                objVFCAdapter.CreateObjectRecordAndRelation(objBuilder);
                processValue.Value = i;
            }
            VFCAdapter.Rule.Common = objDefaultInfo;
            objVFCAdapter.CreateObject(objTextFileHandle, Encoding.Unicode);
            processValue.Value = processValue.Max;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            int quantityNeedToBeCreate = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            int slaveIndexInc = AppGlobal.ParseValue<int>(txtParSlaveIndexIncRule.Text, out tempInt) ? tempInt : 1;

            if (myVFCAdapter.SubType == VFCAdapter.ATVM)
            {
                TxtQuantity.Text = quantityNeedToBeCreate >= 63 ? "63" : Convert.ToString(quantityNeedToBeCreate);
                if (slaveIndexInc >= 1)
                {
                    DialogResult result = MessageBox.Show("站地址最大为63，确定要将规则设为大于1的数？", $"{AppGlobal.AppInfo.Title}:{AppGlobal.INFO}"
                         , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Cancel)
                    {
                        //  slaveIndexInc = 1;
                        txtParSlaveIndexIncRule.Text = Convert.ToString(slaveIndexInc);
                    }
                }
            }
            try
            {
                AppGlobal.IOAddr.IOByteStart = int.Parse(txtParIOByte.Text);
                AppGlobal.IOAddr.Len = int.Parse(txtIOByteIncRule.Text);
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet = chkAddCabinetToDesc.Checked;
                AppGlobal.AdditionDesc.OnlyNumber = chkNameOnlyNumber.Checked;
                AppGlobal.ProcessValue.Value = ProgressBar.Value = 0;
                AppGlobal.AdditionDesc.Power = false;

                if (createMode.BML)
                {
                    CreateObjectBML(
                        dataFromBML: dataGridBML,
                        objVFCAdapter: myVFCAdapter,
                        addtionToDesc: AppGlobal.AdditionDesc,
                        processValue: out AppGlobal.ProcessValue
                        );
                }

                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreateObjectRule(
                         objVFCAdapter: myVFCAdapter,
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
        #endregion <---Common used--->
    }
}