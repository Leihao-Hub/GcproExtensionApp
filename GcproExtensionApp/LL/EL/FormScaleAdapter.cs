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
    public partial class FormScaleAdapter : Form, IGcForm
    {
        public FormScaleAdapter()
        {
            InitializeComponent();
        }
        #region Public object in this class
        readonly ScaleAdapter myScaleAdapter = new ScaleAdapter(AppGlobal.GcproDBInfo.GcproTempPath);
        readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        readonly CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private readonly string DEMO_NAME_SCALE_ADAPTER = "=A-2001-PWC01";
        private readonly string DEMO_NAME_RULE_SCALE_ADAPTER = "2001";
        private readonly string DEMO_DESCRIPTION_SCALE_ADAPTER = "清理A线1楼101号毛麦仓流量平衡器/或者空白";
        private readonly string DEMO_DESCRIPTION_RULE_SCALE_ADAPTER = "";
        private readonly string scaleAdapterBMLSuffix = $"{AppGlobal.JS_BML}.{AppGlobal.JS_SCALE_ADAPTER}.";
        private int value9 ,value10,value60;
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
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={ScaleAdapter.OTypeValue}",
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
            ///<ProcessFct> Read [ProcessFct] </ProcessFct>
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {ScaleAdapter.OTypeValue}",
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
            ///Read [DPNode1],[DPNode2]
            ///</ReadInfoFromProjectDB>
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            ///<PType> Read [PType] </PType>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + ScaleAdapter.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboEquipmentInfoType.Items.Add(column.ToString());
            }
            ComboEquipmentInfoType.SelectedIndex = 0;
            ///<HornCode> Read [PType] </HornCode>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWParHornCode}'",
                null, $"{GcproTable.TranslationCbo.FieldText.Name} ASC", GcproTable.TranslationCbo.FieldText.Name);
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                comboHornCode.Items.Add(column.ToString());
            }
            comboHornCode.SelectedIndex = 0;
            ///<DPNode> Read [DPNode1] and [DPNode2]</DPNode>
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
            objDefaultInfo.NameRule = "2001";
            objDefaultInfo.DescLine = "清理A线";
            objDefaultInfo.DescFloor = "1楼";
            objDefaultInfo.Name = "=A-2001-PWC01";
            objDefaultInfo.DescObject = "101号毛麦仓流量平衡器";
            objDefaultInfo.DescriptionRuleInc = ScaleAdapter.Rule.Common.DescriptionRuleInc;
            objDefaultInfo.NameRuleInc = ScaleAdapter.Rule.Common.NameRuleInc;
            ScaleAdapter.Rule.Common.Cabinet = ScaleAdapter.Rule.Common.Power = string.Empty;

            objDefaultInfo.Description = ScaleAdapter.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix: GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: chkAddCabinetToDesc.Checked,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (String.IsNullOrEmpty(ScaleAdapter.Rule.Common.Description))
            { ScaleAdapter.Rule.Common.Description = objDefaultInfo.Description; }

            if (String.IsNullOrEmpty(ScaleAdapter.Rule.Common.Name))
            { ScaleAdapter.Rule.Common.Name = objDefaultInfo.Name; }

            if (String.IsNullOrEmpty(ScaleAdapter.Rule.Common.DescLine))
            { ScaleAdapter.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (String.IsNullOrEmpty(ScaleAdapter.Rule.Common.DescFloor))
            { ScaleAdapter.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (String.IsNullOrEmpty(ScaleAdapter.Rule.Common.DescObject))
            { ScaleAdapter.Rule.Common.DescObject = objDefaultInfo.DescObject; }

            txtSymbolRule.Text = ScaleAdapter.Rule.Common.NameRule;
            txtSymbolIncRule.Text = ScaleAdapter.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = ScaleAdapter.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = ScaleAdapter.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = ScaleAdapter.Rule.Common.Name;
            txtDescription.Text = ScaleAdapter.Rule.Common.Description;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + ScaleAdapter.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_SCALE_ADAPTER);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_SCALE_ADAPTER);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_SCALE_ADAPTER);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_SCALE_ADAPTER);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath,isNewOledbDriver);
            DataTable dataTable;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{ScaleAdapter.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{ScaleAdapter.ImpExpRuleName}'", null);
                    CreateScaleAdapterImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateScaleAdapterImpExp(oledb);
            }

        }
        public void Default()
        {

            txtSymbol.Focus();
            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            txtValue10.Text = myScaleAdapter.Value10.ToString();
            txtValue9.Text = myScaleAdapter.Value9.ToString().ToString();
            txtValue60.Text = myScaleAdapter.Value60.ToString().ToString();
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            //  ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            btnReadBML.Enabled = false;
            var alphabetList = AppGlobal.CreateAlphabetList<string>('A', 'Z', letter => letter.ToString());
            foreach (var item in alphabetList)
            {
                comboNameBML.Items.Add(item);
                comboDescBML.Items.Add(item);
                comboTypeBML.Items.Add(item);
                comboFloorBML.Items.Add(item);
                comboIORemarkBML.Items.Add(item);
                comboSectionBML.Items.Add(item);
                comboCabinetBML.Items.Add(item);
                comboControlBML.Items.Add(item);
            }
            comboNameBML.SelectedItem = "B";
            comboDescBML.SelectedItem = "N";
            comboTypeBML.SelectedItem = "C";
            comboFloorBML.SelectedItem = "L";
            comboIORemarkBML.SelectedItem = "R";
            comboCabinetBML.SelectedItem = "P";
            comboSectionBML.SelectedItem = "Q";
            comboControlBML.SelectedItem = "H";
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            ComboEquipmentSubType.SelectedIndex = 1;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(ToolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(ToolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(ToolStripMenuDelete_Click);
            this.Text = "ScaleAdapter导入文件 " + " " + myScaleAdapter.FilePath;
        }

        #endregion Public interfaces

        #region <---Rule and autosearch part---> 

        #region <------Check and store rule event------>
        private void UpdateDesc()
        {
            ScaleAdapter.EncodingDesc(
            baseRule: ref ScaleAdapter.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: chkAddCabinetToDesc.Checked,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = ScaleAdapter.Rule.Common.Description;
        }

        private void TxtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value21.Name,
                OType = Convert.ToString(ScaleAdapter.OTypeValue)
            };
            objectBrowser.Show();
        }
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            myScaleAdapter.Name = txtSymbol.Text;
            ScaleAdapter.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
        }
        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!ScaleAdapter.Rule.Common.Description.Equals(txtDescription.Text))
            {
                ScaleAdapter.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(ScaleAdapter.Rule.Common.DescObject, false);
            if (!txtDescription.Text.Contains(txtDescriptionRule.Text))
            { txtDescription.BackColor = Color.Red; }
            else
            { txtDescription.BackColor = Color.White; }
        }
        private void TxtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ScaleAdapter.Rule.Common.Description = txtDescription.Text;
                    ScaleAdapter.DecodingDesc(ref ScaleAdapter.Rule.Common, AppGlobal.DESC_SEPARATOR);
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
                ScaleAdapter.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    ScaleAdapter.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
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
                string descObjectNumber = LibGlobalSource.StringHelper.ExtractNumericPart(ScaleAdapter.Rule.Common.DescObject, false);
                if (!string.IsNullOrEmpty(descObjectNumber))
                {
                    ScaleAdapter.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                    ScaleAdapter.Rule.Common.DescObject = ScaleAdapter.Rule.Common.DescObject.Replace(descObjectNumber, ScaleAdapter.Rule.Common.DescriptionRule);
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
                    ScaleAdapter.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }

        }
        private void txtSenderBin_TextChanged(object sender, EventArgs e)
        {
            txtSenderBinRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSenderBin.Text, false);
        }

        private void txtFluidLiftAirlock_TextChanged(object sender, EventArgs e)
        {
            txtFluidLiftAirlockRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtFluidLiftAirlock.Text, false);
        }
        private void TxtParIOByte_TextChanged(object sender, EventArgs e)
        {
            if (!AppGlobal.CheckNumericString(txtParIOByte.Text))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void TxtIOByteIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtIOByteIncRule.Text))
                {

                   ScaleAdapter.Rule.ioByteInc = AppGlobal.ParseValue<int>(txtIOByteIncRule.Text, out tempInt) ? tempInt:0;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        #endregion <------Check and store rule event------>

        #region <------Check and unchek "Value9" ,"Value10 and "Value60"------>
        private void ChkParLogOff_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParLogOff.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)0); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)0); }

            myScaleAdapter.Value10 = value10;
            txtValue10.Text = myScaleAdapter.Value10.ToString();
        }

        private void ChkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParManual.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)1); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)1); }

            myScaleAdapter.Value10 = value10;
            txtValue10.Text = myScaleAdapter.Value10.ToString();
        }

        private void ChkParStartwarning_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParStartwarning.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)6); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)6); }

            myScaleAdapter.Value10 = value10;
            txtValue10.Text = myScaleAdapter.Value10.ToString();
        }

        private void ChkParDump_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParDump.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)2); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)2); }

            myScaleAdapter.Value10 = value10;
            txtValue10.Text = myScaleAdapter.Value10.ToString();
        }

        private void ChkParBlend_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParBlend.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)7); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)7); }

            myScaleAdapter.Value10 = value10;
            txtValue10.Text = myScaleAdapter.Value10.ToString();
        }

        private void ChkParFlowrateCauculateion_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParFlowrateCauculateion.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)8); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)8); }

            myScaleAdapter.Value10 = value10;
            txtValue10.Text = myScaleAdapter.Value10.ToString();
        }

        private void ChkParSendFlowrate_CheckedChanged(object sender, EventArgs e)
        {
            value60 = int.Parse(txtValue60.Text);
            if (chkParSendFlowrate.Checked)
            { AppGlobal.SetBit<int>(ref value60, (byte)0); }

            else
            { AppGlobal.ResetBit<int>(ref value60, (byte)0); }

            myScaleAdapter.Value60 = value60;
            txtValue60.Text = myScaleAdapter.Value60.ToString();
        }

        private void ChkParSendJobWeight_CheckedChanged(object sender, EventArgs e)
        {
            value60 = int.Parse(txtValue60.Text);
            if (chkParSendJobWeight.Checked)
            { AppGlobal.SetBit<int>(ref value60, (byte)1); }

            else
            { AppGlobal.ResetBit<int>(ref value60, (byte)1); }

            myScaleAdapter.Value60 = value60;
            txtValue60.Text = myScaleAdapter.Value60.ToString();
        }

        private void ChkParSendCutoffWeight_CheckedChanged(object sender, EventArgs e)
        {
            value60 = int.Parse(txtValue60.Text);
            if (chkParSendCutoffWeight.Checked)
            { AppGlobal.SetBit<int>(ref value60, (byte)2); }

            else
            { AppGlobal.ResetBit<int>(ref value60, (byte)2); }

            myScaleAdapter.Value60 = value60;
            txtValue60.Text = myScaleAdapter.Value60.ToString();
        }

        private void ChkParVerifiable_CheckedChanged(object sender, EventArgs e)
        {
            value60 = int.Parse(txtValue60.Text);
            if (chkParVerifiable.Checked)
            { AppGlobal.SetBit<int>(ref value60, (byte)10); }

            else
            { AppGlobal.ResetBit<int>(ref value60, (byte)10); }

            myScaleAdapter.Value60 = value60;
            txtValue60.Text = myScaleAdapter.Value60.ToString();
        }

        private void ChkParVolumetricDosing_CheckedChanged(object sender, EventArgs e)
        {
            value60 = int.Parse(txtValue60.Text);
            if (chkParVolumetricDosing.Checked)
            { AppGlobal.SetBit<int>(ref value60, (byte)11); }

            else
            { AppGlobal.ResetBit<int>(ref value60, (byte)11); }

            myScaleAdapter.Value60 = value60;
            txtValue60.Text = myScaleAdapter.Value60.ToString();
        }

        private void ChkWithRestDischarge_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkWithRestDischarge.Checked)
            { AppGlobal.SetBit<int>(ref value9, (byte)0); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)0); }

            myScaleAdapter.Value9 = value9;
            txtValue9.Text = myScaleAdapter.Value9.ToString();
        }

        private void ChkOutFlowrate_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkOutFlowrate.Checked)
            { AppGlobal.SetBit<int>(ref value9, (byte)16); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)16); }

            myScaleAdapter.Value9 = value9;
            txtValue9.Text = myScaleAdapter.Value9.ToString();
        }

        private void ChkOutJobweight_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkOutJobweight.Checked)
            { AppGlobal.SetBit<int>(ref value9, (byte)17); }

            else
            { AppGlobal.ResetBit<int>(ref value9, (byte)17); }

            myScaleAdapter.Value9 = value9;
            txtValue9.Text = myScaleAdapter.Value9.ToString();
        }
        #endregion <------ Check and unchek "Value9" ,"Value10 and "Value60"------>

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

        private void ComboDPNode2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "DPNode2";
        }
   
        private void TxtParIOByte_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void TxtParTimeOutStart_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value51";
        }

        private void TxtParPulseWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }

        private void TxtInFlowrate_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value28";
        }

        private void TxtInPreCuttoffWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }

        private void TxtInFlowrateLowLimit_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }

        private void TxtInFlowrateHighLimit_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value27";
        }

        private void TxtInDumpWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value32";
        }

        private void TxtSenderBin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value42";
        }

        private void TxtFluidLiftAirlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value43";
        }

        private void TxtAdapter_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Connector00";
        }

        private void TxtChannelID_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value33";
        }
        private void chkParLogOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value10 Bit0";
        }

        private void ChkParManual_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value10 Bit1";
        }

        private void ChkParStartwarning_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value10 Bit6";
        }

        private void ChkParDump_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value10 Bit2";
        }

        private void ChkParBlend_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value10 Bit7";
        }

        private void ChkParFlowrateCauculateion_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value10 Bit8";
        }

        private void ChkParSendFlowrate_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value60 Bit0";
        }

        private void ChkParSendJobWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value60 Bit1";
        }

        private void ChkParSendCutoffWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value60 Bit2";
        }

        private void ChkParVerifiable_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value60 Bit10";
        }

        private void ChkParVolumetricDosing_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value60 Bit11";
        }

        private void ChkWithRestDischarge_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value9 Bit0";
        }

        private void ChkOutFlowrate_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value9 Bit16";
        }

        private void ChkOutJobweight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = $"{AppGlobal.OBJECT_FIELD}Value9 Bit17";
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

        private void TxtExcelPath_TextChanged(object sender, EventArgs e)
        {
            excelFileHandle.FilePath = TxtExcelPath.Text;
            BML.ScaleAdapter.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{scaleAdapterBMLSuffix}{AppGlobal.JS_PATH}", BML.ScaleAdapter.BMLPath);
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
           // AddWorkSheets();
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

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnIORemark,
                Name = nameof(BML.ColumnIORemark)
            });

            dataGridBML.Columns[nameof(BML.ColumnDesc)].Width = 126;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].Width = 56;
            dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].Width = 66;
            dataGridBML.Columns[nameof(BML.ColumnCabinet)].Width = 66;
            dataGridBML.Columns[nameof(BML.ColumnControlMethod)].Width = 188;
            dataGridBML.Columns[nameof(BML.ColumnIORemark)].Width = 188;
        }
        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboFloorBML.Text, comboCabinetBML.Text,
                                    comboSectionBML.Text ,comboControlBML.Text,comboIORemarkBML.Text};
            DataTable dataTable ;
            MachineType machineType =new MachineType();
            string[] filters = { $@"Value LIKE ""%{machineType.FlowBlancer}%"" || Value LIKE ""%{machineType.Scale}%""" , $@"Value LIKE ""%{BML.ScaleAdapter.Weigher}%"" || Value LIKE ""%{BML.ScaleAdapter.FlowBalancer}%""" };
            string[] filterColumns = { comboDescBML.Text ,comboControlBML.Text};
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);
            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;

            dataGridBML.Columns[nameof(BML.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnFloor)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinet)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnControlMethod)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.ColumnIORemark)].DataPropertyName = dataTable.Columns[6].ColumnName;
            TxtQuantity.Text = dataTable.Rows.Count.ToString();
        }
        #endregion <---BML part--->

        #region  <---Common used--->
     
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string selectedItem = Convert.ToString(ComboEquipmentSubType.SelectedItem);
            myScaleAdapter.SubType = String.IsNullOrEmpty(selectedItem) ? ScaleAdapter.FB801DP :
                selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            
        }
   
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
        private void ChkAddPowerToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ChkNameOnlyNumber_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ComboPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboPanel.Text))
            {
                ScaleAdapter.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScaleAdapter.Rule.Common.DescFloor = ComboElevation.Text;
            UpdateDesc();
        }
        private void CreateScaleAdapterImpExp(OleDb oledb)
        {

            bool result = myScaleAdapter.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormScaleAdapter_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormScaleAdapter_FormClosed(object sender, FormClosedEventArgs e)
        {
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
                txtSymbolRule.Text = ScaleAdapter.Rule.Common.NameRule;
                txtSymbolIncRule.Text = ScaleAdapter.Rule.Common.NameRuleInc;
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
            //dataTable.Clear();
            DataTable dataTable = null;
            dataGridBML.DataSource = dataTable;

        }
        private void ToolStripMenuReload_Click(object sender, EventArgs e)
        {
            btnReadBML_Click(sender, e);
        }
        private void ToolStripMenuDelete_Click(object sender, EventArgs e)
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
                myScaleAdapter.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            ScaleAdapter.SaveFileAs(myScaleAdapter.FilePath, LibGlobalSource.CREATE_OBJECT);
            // ScaleAdapter.SaveFileAs(myScaleAdapter.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
                ScaleAdapter.ReGenerateDPNode(oledb);
            }
        }
        private void CreateObjectRule(ScaleAdapter objScaleAdapter,
          (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
          ref (int Value, int Max) processValue)
        {
            #region common used variables declaration
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);    
            int ioByte = AppGlobal.ParseValue<int>(txtParIOByte.Text, out tempInt) ? tempInt : 0;
            int ioByteInc = AppGlobal.ParseValue<int>(txtIOByteIncRule.Text, out tempInt) ? tempInt : 0;
            bool needDPNodeChanged = false;
            int quantityNeedToBeCreate = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
            RuleSubDataSet description, name, dpNode1,senderBin,fluidLiftAirlock;
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
            fluidLiftAirlock = new RuleSubDataSet
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
            #endregion common used variables declaration

            #region Prepare export scale adapter file
            ///<OType>is set when object generated</OType>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            objScaleAdapter.Description = txtDescription.Text;
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                objScaleAdapter.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                objScaleAdapter.SubType = ScaleAdapter.FB801DP;
            }
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                objScaleAdapter.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objScaleAdapter.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objScaleAdapter.Elevation = selectedElevation;
            }
            ///<FieldBusNode></FieldBusNode>  
            objScaleAdapter.FieldBusNode = AppGlobal.NO_DP_NODE;
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objScaleAdapter.Panel_ID = selectedPanel_ID;
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objScaleAdapter.Diagram = ScaleAdapter.ParseInfoValue(selectedDiagram, AppGlobal.FIELDS_SEPARATOR, AppGlobal.NO_DIAGRAM);
            }
            ///<Page></Page>
            objScaleAdapter.Page = txtPage.Text;
            ///<DPNode1></DPNode1>
            string selectDPNode1 = String.Empty;
            if (comboDPNode1.SelectedItem != null)
            {
                selectDPNode1 = comboDPNode1.SelectedItem.ToString();         
                AppGlobal.FieldbusNodeInfo = DI.ParseFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, selectDPNode1);

                objScaleAdapter.DPNode1 = AppGlobal.FieldbusNodeInfo.DPNodeNo;
                objScaleAdapter.FieldBusNode = AppGlobal.FieldbusNodeInfo.FieldBusNodeKey;
            }
            ///<HornCode></HornCode>
            if (comboHornCode.SelectedItem != null)
            {
                string hornCode = comboHornCode.SelectedItem.ToString();
                objScaleAdapter.HornCode = ScaleAdapter.ParseInfoValue(hornCode, AppGlobal.HORNCODE_FIELDS_SEPARATOR, AppGlobal.GROUP_HORNCODE);
            }
            ///<Value9>Value is set when corresponding check box's check state changed</Value9>
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Value60>Value is set when corresponding check box's check state changed</Value60>
            ///<ParTimeoutStart></ParTimeoutStart>
            objScaleAdapter.ParTimeoutStart = AppGlobal.ParseValue<float>(txtParTimeOutStart.Text, out tempFloat) ? Math.Round(tempFloat, 1) : 0;
            ///<ParPulseWeight></ParPulseWeight>
            objScaleAdapter.ParPulseWeight = AppGlobal.ParseValue<float>(txtParPulseWeight.Text, out tempFloat) ? Math.Round(tempFloat, 0) : 0.0;
            ///<InFlowrate></InFlowrate>
            objScaleAdapter.InFlowrate = AppGlobal.ParseValue<float>(txtInFlowrate.Text, out tempFloat) ? Math.Round(tempFloat, 0) : 0.0;
            ///<InPreCuttoffWeight></InPreCuttoffWeight>
            objScaleAdapter.InPreCutoffWeight = AppGlobal.ParseValue<float>(txtInPreCuttoffWeight.Text, out tempFloat) ? Math.Round(tempFloat, 0) : 0.0;
            ///<InFlowrateLowLimit></InFlowrateLowLimit>
            objScaleAdapter.InFlowrateLowLimit = AppGlobal.ParseValue<float>(txtInFlowrateLowLimit.Text, out tempFloat) ? Math.Round(tempFloat, 0) : 0.0;
            ///<InFlowrateHighLimit</InFlowrateHighLimit>
            objScaleAdapter.InFlowrateHighLimit = AppGlobal.ParseValue<float>(txtInFlowrateHighLimit.Text, out tempFloat) ? Math.Round(tempFloat, 0) : 0.0; ;
            ///<InDumpWeight</InDumpWeight>
            objScaleAdapter.InDumpWeight = AppGlobal.ParseValue<float>(txtInDumpWeight.Text, out tempFloat) ? Math.Round(tempFloat, 0) : 0.0; ;          
            ///<ParIOByteNo</ParIOByteNo>
            objScaleAdapter.IoByteNo = AppGlobal.ParseValue<float>(txtParIOByte.Text, out tempFloat) ? (tempFloat): 20000;               
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            #endregion Prepare export scale adapter file

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
            if (comboDPNode1.SelectedItem != null)
            {
                needDPNodeChanged = true;
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
            ///<DescRule>生成描述规则</DescRule>
            string desc = ScaleAdapter.Rule.Common.DescObject;
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
            ///<SenderBinRule>生成名称规则</SenderBinRule>
            senderBin.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtSenderBin.Text, txtSenderBinRule.Text);
            if (senderBin.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{GrpSymbolRule.Text}.{LblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                senderBin.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtSenderBin.Text, txtSenderBinRule.Text);
            }
            ///<FluidLiftAirlockRule>生成名称规则</FluidLiftAirlockRule>
            fluidLiftAirlock.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtFluidLiftAirlock.Text, txtFluidLiftAirlockRule.Text);
            if (fluidLiftAirlock.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{GrpSymbolRule.Text}.{LblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                fluidLiftAirlock.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtFluidLiftAirlock.Text, txtFluidLiftAirlockRule.Text);
            }
            #endregion Parse rules
            processValue.Max = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt - 1 : 1;
            processValue.Value = 0;
            ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
          //  int symbolInc, symbolRule, descriptionInc,senderBinInc,fluidLiftAirlockInc;
            AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out int symbolInc);
            AppGlobal.ParseValue<int>(txtSymbolRule.Text, out int symbolRule);
            AppGlobal.ParseValue<int>(txtDescriptionIncRule.Text, out int descriptionInc);
            AppGlobal.ParseValue<int>(txtSenderBinIncRule.Text, out int senderBinInc);
            AppGlobal.ParseValue<int>(txtFluidLiftAirlockIncRule.Text, out int fluidLiftAirlockInc);
            for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                if (needDPNodeChanged && moreThanOne)
                {
                    //dpNode1.Inc = i * symbolInc;
                    //dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());

                    AppGlobal.FieldbusNodeInfo = DI.ParseFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, objScaleAdapter.Name);

                    objScaleAdapter.DPNode1 = AppGlobal.FieldbusNodeInfo.DPNodeNo;
                    objScaleAdapter.FieldBusNode = AppGlobal.FieldbusNodeInfo.FieldBusNodeKey;
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
                    description.Name = "秤";
                }
                ///<RefSenderdBin></RefSenderBin>
                if (!string.IsNullOrEmpty(txtSenderBin.Text))
                {
                    senderBin.Inc = i * senderBinInc;
                    objScaleAdapter.RefSenderBin = AppGlobal.ParseValue<int>(txtSenderBinRule.Text, out int sndBinRule) ? GcObjectInfo.Bin.BinPrefix + (sndBinRule + senderBin.Inc) : txtSenderBin.Text;
                }
                ///<RefFluidLiftAirlock></RefFluidLiftAirlock>
                if (!string.IsNullOrEmpty(txtFluidLiftAirlock.Text) && !string.IsNullOrEmpty(txtFluidLiftAirlockRule.Text) && !string.IsNullOrEmpty(txtFluidLiftAirlockIncRule.Text))
                {                            
                    fluidLiftAirlock.Inc = i * fluidLiftAirlockInc;
                    objScaleAdapter.RefFluidliftAirlock = LibGlobalSource.StringHelper.GenerateObjectName(fluidLiftAirlock.Sub, fluidLiftAirlock.PosInfo, (int.Parse(txtFluidLiftAirlockRule.Text) + fluidLiftAirlock.Inc).ToString());
                }

                objScaleAdapter.Name = name.Name;
                ScaleAdapter.Rule.Common.Name = name.Name;
                ScaleAdapter.Rule.Common.DescObject = description.Name;
                objScaleAdapter.Description = ScaleAdapter.EncodingDesc(
                    baseRule: ref ScaleAdapter.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
                objScaleAdapter.IoByteNo = ioByte + i * ioByteInc;
                objScaleAdapter.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }



        public void CreateObjectBML(DataGridView dataFromBML, ScaleAdapter objScaleAdapter,
             (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
             out (int Value, int Max) processValue)
        {
            #region common used variables declaration
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);             
            DataTable dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={Bin.OTypeValue}",
             null, $"{GcproTable.ObjData.Text0.Name} ASC",
             GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
            int quantityNeedToBeCreate = dataFromBML.Rows.Count;          
            int ioByteInc = AppGlobal.ParseValue<int>(txtIOByteIncRule.Text, out tempInt) ? tempInt : 0;
            int ioByte = AppGlobal.ParseValue<int>(txtParIOByte.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            string desc = string.Empty;
            bool onlyOne = quantityNeedToBeCreate == 1;
            int nextIOByte = ioByte;
            #endregion common used variables declaration
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
           
            objDefaultInfo = ScaleAdapter.Rule.Common;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {

                DataGridViewCell cell;
                cell = dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                    continue;
                ///<Name> get Name </Name>
                objScaleAdapter.Name = Convert.ToString(cell.Value);
                ///<Description>   </Description>    
                desc = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value);
                if (addtionToDesc.Section)
                {
                    string nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, objScaleAdapter.Name);
                    if (!string.IsNullOrEmpty(nameNumberString))
                    {
                        if (AppGlobal.ParseValue<int>(nameNumberString, out tempInt))
                        {
                            ScaleAdapter.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.UserDefSection)
                {
                    ScaleAdapter.Rule.Common.DescLine = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value); ;
                }
                ///<Panel_ID>   </Panel_ID>  
                objScaleAdapter.Panel_ID = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value) +
                    Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                ///<Elevation>   </Elevation>  
                objScaleAdapter.Elevation = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);
                ///<SenderBin>Connect Sender bin </SenderBin>
                string ioRemark = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnIORemark)].Value);
                if (!string.IsNullOrEmpty(ioRemark))
                {
                    string senderBin = BML.ScaleAdapter.ParseIORemark(ioRemark, dataTable);
                    objScaleAdapter.RefSenderBin = senderBin;
                    if (!string.IsNullOrEmpty(senderBin))
                    {
                        chkParBlend.Checked = true;
                        chkParDump.Checked = false;
                    }
                    else
                    {
                        chkParBlend.Checked = false;
                        chkParDump.Checked = false;
                    }
                }
                string controlMethod = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnControlMethod)].Value);
                if (controlMethod.Contains(BML.ScaleAdapter.Weigher)) 
                {
                    chkParDump.Checked = true;
                    chkParBlend.Checked = false;
                }

                ScaleAdapter.Rule.Common.Name = objScaleAdapter.Name;
                ScaleAdapter.Rule.Common.DescFloor = $"{objScaleAdapter.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                ScaleAdapter.Rule.Common.DescObject = desc;
                ScaleAdapter.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{myScaleAdapter.Panel_ID}";
                objScaleAdapter.Description = ScaleAdapter.EncodingDesc(
                    baseRule: ref ScaleAdapter.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );          
                ///<ParTimeoutStart></ParTimeoutStart>
                objScaleAdapter.ParTimeoutStart = 0.0;
                ///<ParPulseWeight></ParPulseWeight>
                objScaleAdapter.ParPulseWeight = 0;
                ///<InFlowrate></InFlowrate>
                objScaleAdapter.InFlowrate = 0;
                ///<InPreCutoffWeight></InPreCutoffWeight>
                objScaleAdapter.InPreCutoffWeight =0;
                ///<InFlowrateLowLimit></InFlowrateLowLimit>
                objScaleAdapter.InFlowrateLowLimit = 0;
                ///<InFlowrateHighLimit</InFlowrateHighLimit>
                objScaleAdapter.InFlowrateHighLimit = 0;
                ///<InDumpWeight</InDumpWeight>
                objScaleAdapter.InDumpWeight =0;
                ///<IOByteNo>   </IOByteNo> 
                objScaleAdapter.IoByteNo = nextIOByte;
                nextIOByte += ioByteInc;
                ///<DPNode1>   </DPNode1>                                    
                           
                AppGlobal.FieldbusNodeInfo = ScaleAdapter.ParseFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, objScaleAdapter.Name);
                objScaleAdapter.DPNode1 = AppGlobal.FieldbusNodeInfo.DPNodeNo;
                objScaleAdapter.FieldBusNode = AppGlobal.FieldbusNodeInfo.FieldBusNodeKey;

                ///<HornCode>   </Horncode> 
                
                ///<CreateObject>   </CreateObject>
                objScaleAdapter.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            ScaleAdapter.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
           // int quantityNeedToBeCreate = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            //AppGlobal.ParseValue<int>(txtIOByteIncRule.Text, out int ioByteIncRule);         
            try
            {
                AppGlobal.ParseValue<int>(txtParIOByte.Text, out AppGlobal.IOAddr.IOByteStart);
                AppGlobal.ParseValue<int>(txtIOByteIncRule.Text, out AppGlobal.IOAddr.Len);        
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
                        objScaleAdapter: myScaleAdapter,
                        addtionToDesc: AppGlobal.AdditionDesc,
                        processValue: out AppGlobal.ProcessValue
                        );
                }

                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreateObjectRule(
                         objScaleAdapter: myScaleAdapter,
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