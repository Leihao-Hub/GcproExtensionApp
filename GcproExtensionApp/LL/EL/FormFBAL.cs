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
    public partial class FormFBAL : Form, IGcForm
    {
        public FormFBAL()
        {
            InitializeComponent();
        }
        #region Public object in this class
        readonly FBAL myFBAL = new FBAL(AppGlobal.GcproDBInfo.GcproTempPath);
        readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        readonly CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private readonly string DEMO_NAME= "=A-2001-PWC01";
        private readonly string DEMO_NAME_RULE = "2001";
        private readonly string DEMO_DESCRIPTION= "101号毛麦仓流量平衡器/或者空白";
        private readonly string DEMO_DESCRIPTION_RULE = "";
        private readonly string fbalBMLSuffix = $"{AppGlobal.JS_BML}.{AppGlobal.JS_FBAL}.";
        private int value10 ,value9,value30,value31;
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
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={FBAL.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {FBAL.OTypeValue}",
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

            ///<PType> Read [PType] </PType>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + FBAL.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboEquipmentInfoType.Items.Add(column.ToString());
            }
            ComboEquipmentInfoType.SelectedIndex = 0;
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
            objDefaultInfo.NameRule = "2001";
            objDefaultInfo.DescLine = "清理A线";
            objDefaultInfo.DescFloor = "1楼";
            objDefaultInfo.Name = "=A-2001-PWC01";
            objDefaultInfo.DescObject = "101号毛麦仓流量平衡器";
            objDefaultInfo.DescriptionRuleInc = FBAL.Rule.Common.DescriptionRuleInc;
            objDefaultInfo.NameRuleInc = FBAL.Rule.Common.NameRuleInc;
            FBAL.Rule.Common.Cabinet = FBAL.Rule.Common.Power = string.Empty;

            objDefaultInfo.Description = FBAL.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix: GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: chkAddCabinetToDesc.Checked,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (String.IsNullOrEmpty(FBAL.Rule.Common.Description))
            { FBAL.Rule.Common.Description = objDefaultInfo.Description; }

            if (String.IsNullOrEmpty(FBAL.Rule.Common.Name))
            { FBAL.Rule.Common.Name = objDefaultInfo.Name; }

            if (String.IsNullOrEmpty(FBAL.Rule.Common.DescLine))
            { FBAL.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (String.IsNullOrEmpty(FBAL.Rule.Common.DescFloor))
            { FBAL.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (String.IsNullOrEmpty(FBAL.Rule.Common.DescObject))
            { FBAL.Rule.Common.DescObject = objDefaultInfo.DescObject; }

            txtSymbolRule.Text = FBAL.Rule.Common.NameRule;
            txtSymbolIncRule.Text = FBAL.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = FBAL.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = FBAL.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = FBAL.Rule.Common.Name;
            txtDescription.Text = FBAL.Rule.Common.Description;
         //   txtIOByteIncRule.Text = FBAL.Rule.ioByteInc;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + FBAL.OType);
      
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath,isNewOledbDriver);
            DataTable dataTable;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{FBAL.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{FBAL.ImpExpRuleName}'", null);
                    CreateFBALImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateFBALImpExp(oledb);
            }

        }
        public void Default()
        {

            txtSymbol.Focus();
            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            txtValue10.Text = myFBAL.Value10;
            txtValue9.Text = myFBAL.Value9;
            txtValue30.Text = myFBAL.Value30;
            txtValue31.Text = myFBAL.Value31;
            txtIOByteIncRule.Text = AppGlobal.MEAG_EXT_LONG.ToString(); 
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            //  ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            btnReadBML.Enabled = false;  
            comboStartRow.SelectedItem = BML.StartRow;
          //  ComboEquipmentSubType.SelectedIndex = 2;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(ToolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(ToolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(ToolStripMenuDelete_Click);
            this.Text = "FBAL导入文件 " + " " + myFBAL.FilePath;
        }

        #endregion Public interfaces

        #region <---Rule and autosearch part---> 

        #region <------Check and store rule event------>
        private void UpdateDesc()
        {
            FBAL.EncodingDesc(
            baseRule: ref FBAL.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: chkAddCabinetToDesc.Checked,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = FBAL.Rule.Common.Description;
        }

        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value21.Name,
                OType = Convert.ToString(FBAL.OTypeValue)
            };
            objectBrowser.Show();
        }
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            myFBAL.Name = txtSymbol.Text;
            FBAL.Rule.Common.Name = txtSymbol.Text;
            UpdateDesc();
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!FBAL.Rule.Common.Description.Equals(txtDescription.Text))
            {
                FBAL.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(FBAL.Rule.Common.DescObject, false);
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
                    FBAL.Rule.Common.Description = txtDescription.Text;
                    FBAL.DecodingDesc(ref FBAL.Rule.Common, AppGlobal.DESC_SEPARATOR);
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
                FBAL.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    FBAL.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
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
                string descObjectNumber = LibGlobalSource.StringHelper.ExtractNumericPart(FBAL.Rule.Common.DescObject, false);
                if (!string.IsNullOrEmpty(descObjectNumber))
                {
                    FBAL.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                    FBAL.Rule.Common.DescObject = FBAL.Rule.Common.DescObject.Replace(descObjectNumber, FBAL.Rule.Common.DescriptionRule);
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
                    FBAL.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
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

        private void TxtSenderBin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSenderBin.Text))
            {
                txtSenderBinRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSenderBin.Text, false);
            }
            chkParBlend.Checked = !string.IsNullOrEmpty(txtSenderBin.Text);
        }
        #endregion <------Check and store rule event------>

        #region <------Check and unchek "Value9","Value10",Value30 and value31------>
        private void ChkParLogOff_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParLogOff.Checked)
            { AppGlobal.SetBit(ref value10, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)0); }

            myFBAL.Value10 = value10.ToString();
            txtValue10.Text = myFBAL.Value10;
        }

        private void ChkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParManual.Checked)
            { AppGlobal.SetBit(ref value10, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myFBAL.Value10 = value10.ToString();
            txtValue10.Text = myFBAL.Value10;
        }

        private void ChkParWithFlowrateRel_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithFlowrateRel.Checked)
            { AppGlobal.SetBit(ref value10, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }

            myFBAL.Value10 = value10.ToString();
            txtValue10.Text = myFBAL.Value10;
        }

        private void ChkParMZAH_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParMZAH.Checked)
            { AppGlobal.SetBit(ref value10, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)3); }

            myFBAL.Value10 = value10.ToString();
            txtValue10.Text = myFBAL.Value10;
        }

        private void ChkParOpto22_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParOpto22.Checked)
            { AppGlobal.SetBit(ref value10, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)4); }

            myFBAL.Value10 = value10.ToString();
            txtValue10.Text = myFBAL.Value10;
        }

        private void ChkParMZDE_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParMZDE.Checked)
            { AppGlobal.SetBit(ref value10, (byte)5); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)5); }

            myFBAL.Value10 = value10.ToString();
            txtValue10.Text = myFBAL.Value10;
        }

        private void ChkParBlend_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParBlend.Checked)
            { AppGlobal.SetBit(ref value10, (byte)6); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)6); }

            myFBAL.Value10 = value10.ToString();
            txtValue10.Text = myFBAL.Value10;
        }
        private void ChkOutFlowrate_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkOutFlowrate.Checked)
            { AppGlobal.SetBit(ref value9, (byte)16); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)16); }

            myFBAL.Value9 = value9.ToString();
            txtValue9.Text = myFBAL.Value9;
        }

        private void ChkOutJobweight_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(txtValue9.Text);
            if (chkOutJobweight.Checked)
            { AppGlobal.SetBit(ref value9, (byte)17); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)17); }

            myFBAL.Value9 = value9.ToString();
            txtValue9.Text = myFBAL.Value9;
        }
        private void ChkFilterSumFault_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterSumFault.Checked)
            { AppGlobal.SetBit(ref value30, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)0); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA05_24VToLow_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA05_24VToLow.Checked)
            { AppGlobal.SetBit(ref value30, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)1); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA07ADRange_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA07ADRange.Checked)
            { AppGlobal.SetBit(ref value30, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)2); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA08Calibration_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA08Calibration.Checked)
            { AppGlobal.SetBit(ref value30, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)3); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA09ADFunction_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA09ADFunction.Checked)
            { AppGlobal.SetBit(ref value30, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)4); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA10ADSupply_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA10ADSupply.Checked)
            { AppGlobal.SetBit(ref value30, (byte)5); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)5); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA11AnalogInput_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA11AnalogInput.Checked)
            { AppGlobal.SetBit(ref value30, (byte)6); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)6); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterAxxComunication_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterAxxComunication.Checked)
            { AppGlobal.SetBit(ref value30, (byte)7); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)7); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA13RemoteControl_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA13RemoteControl.Checked)
            { AppGlobal.SetBit(ref value30, (byte)8); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)8); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA16Printer_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA16Printer.Checked)
            { AppGlobal.SetBit(ref value30, (byte)9); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)9); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA24WeightHopper_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA24WeightHopper.Checked)
            { AppGlobal.SetBit(ref value30, (byte)10); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)10); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA25FrequencyConverter_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA25FrequencyConverter.Checked)
            { AppGlobal.SetBit(ref value30, (byte)11); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)11); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA26Tolerance_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA26Tolerance.Checked)
            { AppGlobal.SetBit(ref value30, (byte)12); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)12); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA27Measurement_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA27Measurement.Checked)
            { AppGlobal.SetBit(ref value30, (byte)13); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)13); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA28FeedDrive_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA28FeedDrive.Checked)
            { AppGlobal.SetBit(ref value30, (byte)14); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)14); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA29FeedingTime_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkFilterA29FeedingTime.Checked)
            { AppGlobal.SetBit(ref value30, (byte)15); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)15); }

            myFBAL.Value30 = value30.ToString();
            txtValue30.Text = myFBAL.Value30;
        }

        private void ChkFilterA30ZeroTara_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkFilterA30ZeroTara.Checked)
            { AppGlobal.SetBit(ref value31, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)0); }

            myFBAL.Value31 = value31.ToString();
            txtValue31.Text = myFBAL.Value31;
        }

        private void ChkFilterA32InletSlideGate_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkFilterA32InletSlideGate.Checked)
            { AppGlobal.SetBit(ref value31, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)1); }

            myFBAL.Value31 = value31.ToString();
            txtValue31.Text = myFBAL.Value31;
        }

        private void ChkFilterA33AirPressure_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkFilterA33AirPressure.Checked)
            { AppGlobal.SetBit(ref value31, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)2); }

            myFBAL.Value31 = value31.ToString();
            txtValue31.Text = myFBAL.Value31;
        }

        private void ChkFilterA34NoProduct_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkFilterA34NoProduct.Checked)
            { AppGlobal.SetBit(ref value31, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)3); }

            myFBAL.Value31 = value31.ToString();
            txtValue31.Text = myFBAL.Value31;
        }

        private void ChkFilterA37Empty_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkFilterA37Empty.Checked)
            { AppGlobal.SetBit(ref value31, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)4); }

            myFBAL.Value31 = value31.ToString();
            txtValue31.Text = myFBAL.Value31;
        }

        private void ChkFilterA38Slide_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkFilterA38Slide.Checked)
            { AppGlobal.SetBit(ref value31, (byte)5); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)5); }

            myFBAL.Value31 = value31.ToString();
            txtValue31.Text = myFBAL.Value31;
        }

        private void ChkFilterA39AirPressure_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkFilterA39AirPressure.Checked)
            { AppGlobal.SetBit(ref value31, (byte)6); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)6); }

            myFBAL.Value31 = value31.ToString();
            txtValue31.Text = myFBAL.Value31;
        }

        private void ChkFilterA54Relais_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkFilterA54Relais.Checked)
            { AppGlobal.SetBit(ref value31, (byte)7); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)7); }

            myFBAL.Value31 = value31.ToString();
            txtValue31.Text = myFBAL.Value31;
        }

        #endregion <------Check and unchek "Value9","Value10",Value30 and value31------>

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


        private void TxtParIOByte_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void TxtParIOByteExt_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }

        private void TxtParLoopNo_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }

        private void TxtParLCAddr_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }

        private void TxtParMonTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }

        private void ChkParLogOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit0";
        }

        private void ChkParManual_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }

        private void ChkParWithFlowrateRel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit2";
        }

        private void ChkParMZAH_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit3";
        }

        private void ChkParOpto22_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit4";
        }

        private void ChkParMZDE_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit5";
        }

        private void ChkParBlend_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit6";
        }

        private void chkOutFlowrate_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit16";
        }

        private void chkOutJobweight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit17";
        }
        private void ChkFilterSumFault_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit0";
        }

        private void ChkFilterA05_24VToLow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit1";
        }

        private void ChkFilterA07ADRange_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit2";
        }

        private void ChkFilterA08Calibration_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit3";
        }

        private void ChkFilterA09ADFunction_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit4";
        }

        private void ChkFilterA10ADSupply_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit5";
        }

        private void ChkFilterA11AnalogInput_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit6";
        }

        private void ChkFilterAxxComunication_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit7";
        }

        private void ChkFilterA13RemoteControl_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit8";
        }

        private void ChkFilterA16Printer_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit9";
        }

        private void ChkFilterA24WeightHopper_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit10";
        }

        private void ChkFilterA25FrequencyConverter_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit11";
        }

        private void ChkFilterA26Tolerance_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit12";
        }

        private void ChkFilterA27Measurement_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit13";
        }

        private void ChkFilterA28FeedDrive_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit14";
        }

        private void ChkFilterA29FeedingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit15";
        }

        private void ChkFilterA30ZeroTara_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit0";
        }

        private void ChkFilterA32InletSlideGate_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit1";
        }

        private void ChkFilterA33AirPressure_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit2";
        }

        private void ChkFilterA34NoProduct_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit3";
        }

        private void ChkFilterA37Empty_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit4";
        }

        private void ChkFilterA38Slide_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit5";
        }

        private void ChkFilterA39AirPressure_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit6";
        }

        private void ChkFilterA54Relais_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit7";
        }
        private void txtSenderBin_MouseEnter(object sender, EventArgs e)
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
            BML.Motor.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{fbalBMLSuffix}{AppGlobal.JS_PATH}", BML.FBAL.BMLPath);
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
                comboControlBML.Items.Add(item);

            }
            comboNameBML.SelectedItem = "B";
            comboDescBML.SelectedItem = "N";
            comboTypeBML.SelectedItem = "C";
            comboFloorBML.SelectedItem = "L";  
            comboCabinetBML.SelectedItem = "P";
            comboSectionBML.SelectedItem = "Q";
            comboControlBML.SelectedItem = "H";
            comboIORemarkBML.SelectedItem = "R";
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text = BML.Motor.BMLPath;         
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
        private void BtnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboFloorBML.Text, comboCabinetBML.Text ,
                                   comboSectionBML.Text,comboControlBML.Text,comboIORemarkBML.Text};
            DataTable dataTable;
            string[] filters = {$@"Value LIKE ""%{BML.FBAL.FlowBalancer}%"""};
            string[] filterColumns = { comboControlBML.Text };
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
            myFBAL.SubType = String.IsNullOrEmpty(selectedItem) ? FBAL.MZAHDP :
                selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));


            if (myFBAL.SubType.StartsWith("DTWE"))
            {
                foreach (var item in ComboEquipmentInfoType.Items)
                {
                    if (item.ToString().StartsWith(FBAL.P7373.ToString()))
                    {
                        ComboEquipmentInfoType.SelectedItem = item;
                        break;
                    }
                }
            }
            else if (myFBAL.SubType.StartsWith("MZAH"))
            {
                foreach (var item in ComboEquipmentInfoType.Items)
                {
                    if (item.ToString().StartsWith(FBAL.P7372.ToString()))
                    {
                        ComboEquipmentInfoType.SelectedItem = item;
                        break;
                    }
                }
            }
            else if (myFBAL.SubType.StartsWith("MZDE"))
            {
                foreach (var item in ComboEquipmentInfoType.Items)
                {
                    if (item.ToString().StartsWith(FBAL.P7372.ToString()))
                    {
                        ComboEquipmentInfoType.SelectedItem = item;
                        break;
                    }
                }
            }
            else if (myFBAL.SubType.StartsWith("MZAG"))
            {
                foreach (var item in ComboEquipmentInfoType.Items)
                {
                    if (item.ToString().StartsWith(FBAL.P7372.ToString()))
                    {
                        ComboEquipmentInfoType.SelectedItem = item;
                        break;
                    }
                }
            }
            chkFilterSumFault.Checked = !myFBAL.SubType.StartsWith("DTWE");
            chkParMZAH.Checked = myFBAL.SubType.StartsWith("MZAH");
            chkParMZDE.Checked = myFBAL.SubType.StartsWith("MZDE");
            chkParOpto22.Checked = txtParLoopNo.Enabled = txtParLCAddr.Enabled = myFBAL.SubType.Contains("22");
            ///<CommonUsedPar></CommonUsedPar>
            if (chkParOpto22.Checked)
            {
                txtParLoopNo.Text = "91";
                txtParLCAddr.Text = "1";
            }

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
                FBAL.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FBAL.Rule.Common.DescFloor = ComboElevation.Text;
            UpdateDesc();
        }
        private void CreateFBALImpExp(OleDb oledb)
        {

            bool result = myFBAL.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormFBAL_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormFBAL_FormClosed(object sender, FormClosedEventArgs e)
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
                txtSymbolRule.Text = FBAL.Rule.Common.NameRule;
                txtSymbolIncRule.Text = FBAL.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

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
            //dataTable.Clear();
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
                myFBAL.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            FBAL.SaveFileAs(myFBAL.FilePath, LibGlobalSource.CREATE_OBJECT);
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
                FBAL.ReGenerateDPNode(oledb);
            }
        }


        private void CreateObjectRule(FBAL objFBAL,
          (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
          ref (int Value, int Max) processValue)
        {
            #region common used variables declaration
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);    
            int ioByte = AppGlobal.ParseInt(txtParIOByte.Text, out tempInt) ? tempInt : 0;
            int ioByteInc = AppGlobal.MEAG_EXT_LONG;
            bool needDPNodeChanged = false;
            int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
            RuleSubDataSet description, name, dpNode1,senderBin;
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
            #endregion common used variables declaration

            #region Prepare export fbal file
            ///<OType>is set when object generated</OType>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            objFBAL.Description = txtDescription.Text;
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                objFBAL.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                objFBAL.SubType = FBAL.MZAHDP;
            }
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                objFBAL.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objFBAL.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objFBAL.Elevation = selectedElevation;
            }
            ///<FieldBusNode></FieldBusNode>  
            objFBAL.FieldBusNode = LibGlobalSource.NOCHILD;
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objFBAL.Panel_ID = selectedPanel_ID;
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objFBAL.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Page></Page>
            objFBAL.Page = txtPage.Text;
            ///<DPNode1></DPNode1>
            string selectDPNode1 = String.Empty;
            if (ComboDPNode1.SelectedItem != null)
            {
                selectDPNode1 = ComboDPNode1.SelectedItem.ToString();             
                int dpnode1 = int.Parse(objFBAL.DPNode1);
                objFBAL.DPNode1 = FBAL.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, selectDPNode1);

                if (String.IsNullOrEmpty(objFBAL.DPNode1))
                { objFBAL.FieldBusNode = string.Empty; }
                else
                {
                    objFBAL.FieldBusNode = FBAL.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, dpnode1);
                }
            }
            ///<Value9>Value is set when corresponding check box's check state changed</Value9>
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Value30>Value is set when corresponding check box's check state changed</Value30>
            ///<Value31>Value is set when corresponding check box's check state changed</Value31>
            ///<ParMonTime></ParMonTime>
            objFBAL.ParMonTime = AppGlobal.ParseInt(txtParMonTime.Text, out tempInt) ? (tempInt*10).ToString() : "200";
            ///<ParIOByteNoExt></ParIOByteNoExt>
            objFBAL.IoByteNoExt= AppGlobal.ParseInt(txtParIOByteNoExt.Text, out tempInt) ? (tempInt).ToString() : "0";
            ///<ParLoopNo></ParLoopNo>
            objFBAL.ParLoopNo = AppGlobal.ParseInt(txtParLoopNo.Text, out tempInt) ? (tempInt).ToString() : "91";
            ///<txtParLCAddr></txtParLCAddr>
            objFBAL.ParLCAddr = AppGlobal.ParseInt(txtParLCAddr.Text, out tempInt) ? (tempInt).ToString() : "1";        
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            #endregion Prepare export fbal file

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
            string desc = FBAL.Rule.Common.DescObject;
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
            #endregion Parse rules

            processValue.Max = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt - 1 : 1;
            processValue.Value = 0;
            ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
            int symbolInc, symbolRule, descriptionInc,senderBinInc;
            AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
            AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
            AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
            AppGlobal.ParseInt(txtSenderBinIncRule.Text, out senderBinInc);
            for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                if (needDPNodeChanged && moreThanOne)
                {
                    dpNode1.Inc = i * symbolInc;
                    dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());
                    objFBAL.DPNode1 = FBAL.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, objFBAL.Name);

                    if (String.IsNullOrEmpty(objFBAL.DPNode1))
                    { objFBAL.FieldBusNode = string.Empty; }
                    else
                    {
                        objFBAL.FieldBusNode = FBAL.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                        {
                            return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                        }, int.Parse(objFBAL.DPNode1));
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
                    description.Name = "";
                }
                ///<RefSenderdBin></RefSenderBin>
                if (!string.IsNullOrEmpty(txtSenderBin.Text))
                {
                    senderBin.Inc = i * senderBinInc;
                    objFBAL.RefSenderBin = AppGlobal.ParseInt(txtSenderBinRule.Text, out int sndBinRule) ? GcObjectInfo.Bin.BinPrefix + (sndBinRule + senderBin.Inc) : txtSenderBin.Text;
                }
                objFBAL.Name = name.Name;

                FBAL.Rule.Common.Name = name.Name;
                FBAL.Rule.Common.DescObject = description.Name;
                objFBAL.Description = FBAL.EncodingDesc(
                    baseRule: ref FBAL.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
                // objFBAL.Description = description.Name;
                objFBAL.IoByteNo = Convert.ToString(ioByte + i * ioByteInc);
                objFBAL.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }
        public void CreateObjectBML(DataGridView dataFromBML, FBAL objFBAL,
             (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
             out (int Value, int Max) processValue)
        {
            #region common used variables declaration
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            DataTable dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={Bin.OTypeValue}",
            null, $"{GcproTable.ObjData.Text0.Name} ASC",
            GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
            int quantityNeedToBeCreate = dataFromBML.Rows.Count;
            int ioByteInc = AppGlobal.MEAG_EXT_LONG;
            int ioByte = AppGlobal.ParseInt(txtParIOByte.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            string desc = string.Empty;
            bool onlyOne = quantityNeedToBeCreate == 1;
            int nextIOByte = ioByte;
            #endregion common used variables declaration
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0; 
            objDefaultInfo = FBAL.Rule.Common;
            objFBAL.SubType = FBAL.DTWxDP;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {

                DataGridViewCell cell;
                cell = dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                    continue;
                ///<Name>   </Name>
                objFBAL.Name = Convert.ToString(cell.Value);
                ///<Description>   </Description>    
                desc = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value);
                if (addtionToDesc.Section)
                {
                    string nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameNumber, objFBAL.Name);
                    if (!string.IsNullOrEmpty(nameNumberString))
                    {
                        if (AppGlobal.ParseInt(nameNumberString, out tempInt))
                        {
                            FBAL.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.UserDefSection)
                {
                    FBAL.Rule.Common.DescLine = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value); ;
                }

                FBAL.Rule.Common.Name = objFBAL.Name;
                FBAL.Rule.Common.DescFloor = $"{objFBAL.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                FBAL.Rule.Common.DescObject = desc;
                FBAL.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{myFBAL.Panel_ID}";
                objFBAL.Description = FBAL.EncodingDesc(
                    baseRule: ref FBAL.Rule.Common,
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
                objFBAL.Panel_ID = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value) +
                    Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                ///<Elevation>   </Elevation>  
                objFBAL.Elevation = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);
              
              //  string controlMethod = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnControlMethod)].Value);
                objFBAL.SubType = FBAL.MZAHDP;
                ///<IOByteNo>   </IOByteNo> 
                objFBAL.IoByteNo = Convert.ToString(nextIOByte);
                nextIOByte += ioByteInc;
                ///<ParMonTime>   </ParMonTime> 
                objFBAL.ParMonTime = AppGlobal.ParseInt(txtParMonTime.Text, out tempInt) ? (tempInt * 10).ToString() : "200"; 
                nextIOByte += ioByteInc;
                ///<DPNode1>   </DPNode1>                                    
                objFBAL.DPNode1 = FBAL.FindDPNodeNo((tableName, whereClause, parameters, sortBy, fieldList) =>
                {
                    return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                }, objFBAL.Name);

                if (String.IsNullOrEmpty(objFBAL.DPNode1))
                { objFBAL.FieldBusNode = string.Empty; }
                else
                {
                    objFBAL.FieldBusNode = FBAL.FindFieldbusNodeKey((tableName, whereClause, parameters, sortBy, fieldList) =>
                    {
                        return oledb.QueryDataTable(tableName, whereClause, parameters, sortBy, fieldList);
                    }, int.Parse(objFBAL.DPNode1));
                }
                ///<SenderBin>Connect Sender bin </SenderBin>
                string ioRemark = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnIORemark)].Value);
                if (!string.IsNullOrEmpty(ioRemark))
                {
                    string senderBin = BML.ScaleAdapter.ParseIORemark(ioRemark, dataTable);
                    objFBAL.RefSenderBin = senderBin;                
                    chkParBlend.Checked = (!string.IsNullOrEmpty(senderBin));
                                                       
                }                       
                ///<CreateObject>   </CreateObject>
                objFBAL.CreateObject(Encoding.Unicode);
                processValue.Value = i;
            }
            FBAL.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
        
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
                        objFBAL: myFBAL,
                        addtionToDesc: AppGlobal.AdditionDesc,
                        processValue: out AppGlobal.ProcessValue
                        );
                }

                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreateObjectRule(
                         objFBAL: myFBAL,
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