﻿using System;
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
    public partial class FormMA_Roll8Stand : Form, IGcForm
    {
        public FormMA_Roll8Stand()
        {
            InitializeComponent();
        }
        #region Public object in this class
        readonly Roll8Stand myRoll8Stand = new Roll8Stand(AppGlobal.GcproDBInfo.GcproTempPath);
        readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        List<KeyValuePair<string, int>> listBMLName = new List<KeyValuePair<string, int>>();
        readonly CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private GcBaseRule objDefaultInfo;
        private readonly string DEMO_NAME_ROLL8STAND = "=A-4001";
        private readonly string DEMO_NAME_RULE_ROLL8STAND = "4001";
        private readonly string DEMO_DESCRIPTION_ROLL8STAND = "制粉A线2楼(4001)磨粉机";
        private readonly string DEMO_DESCRIPTION_RULE_ROLL8STAND = "制粉A线2楼(4001)磨粉机/或者空白";
        #endregion
        private int value10 ;
        private int tempInt = 0;
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
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={Roll8Stand.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {Roll8Stand.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + Roll8Stand.OTypeValue}'",
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
            objDefaultInfo.NameRule = "4001";
            objDefaultInfo.DescLine = "制粉A线";
            objDefaultInfo.DescFloor = "2楼";
            objDefaultInfo.Name = "=A-4001";
            objDefaultInfo.DescObject = "磨粉机";
            objDefaultInfo.DescriptionRuleInc = Roll8Stand.Rule.Common.DescriptionRuleInc;
            objDefaultInfo.NameRuleInc = Roll8Stand.Rule.Common.NameRuleInc;
            Roll8Stand.Rule.Common.Cabinet = Roll8Stand.Rule.Common.Power = string.Empty;

            objDefaultInfo.Description = Roll8Stand.EncodingDesc(
              baseRule: ref objDefaultInfo,
              namePrefix: GcObjectInfo.General.PrefixName,
              nameRule: Engineering.PatternMachineName,
              withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
              withFloorInfo: chkAddFloorToDesc.Checked,
              withNameInfo: chkAddNameToDesc.Checked,
              withCabinet: false,
              withPower: false,
              nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (String.IsNullOrEmpty(Roll8Stand.Rule.Common.Description))
            { Roll8Stand.Rule.Common.Description = objDefaultInfo.Description; }

            if (String.IsNullOrEmpty(Roll8Stand.Rule.Common.Name))
            { Roll8Stand.Rule.Common.Name = objDefaultInfo.Name; }

            if (String.IsNullOrEmpty(Roll8Stand.Rule.Common.DescLine))
            { Roll8Stand.Rule.Common.DescLine = objDefaultInfo.DescLine; }

            if (String.IsNullOrEmpty(Roll8Stand.Rule.Common.DescFloor))
            { Roll8Stand.Rule.Common.DescFloor = objDefaultInfo.DescFloor; }

            if (String.IsNullOrEmpty(Roll8Stand.Rule.Common.DescObject))
            { Roll8Stand.Rule.Common.DescObject = objDefaultInfo.DescObject; }

            txtSymbolRule.Text = Roll8Stand.Rule.Common.NameRule;
            txtSymbolIncRule.Text = Roll8Stand.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = Roll8Stand.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = Roll8Stand.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = Roll8Stand.Rule.Common.Name;
            txtDescription.Text = Roll8Stand.Rule.Common.Description;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + Roll8Stand.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_ROLL8STAND);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_ROLL8STAND);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_ROLL8STAND);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_ROLL8STAND);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb
            {
                DataSource = AppGlobal.GcproDBInfo.ProjectDBPath,
                IsNewOLEDBDriver = isNewOledbDriver
            };
            DataTable dataTable;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Roll8Stand.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Roll8Stand.ImpExpRuleName}'", null);
                    CreateRoll8StandImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateRoll8StandImpExp(oledb);
            }

        }
        public void Default()
        {
            txtSymbol.Focus();
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
          
            txtValue10.Text = myRoll8Stand.Value10.ToString().ToString();
            value10 = int.Parse(txtValue10.Text);
            chkParManual.Checked = true;
            ComboEquipmentSubType.SelectedIndex = 1;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "MA_Roll8Stand导入文件 " + " " + myRoll8Stand.FilePath;
        }

        #endregion
        private void CreateRoll8StandImpExp(OleDb oledb)
        {

            bool result = myRoll8Stand.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormMA_Roller8Stand_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);
            GetInfoFromDatabase();
            GetLastObjRule();
            CreateTips();
            Default();
        }
        private void FormMA_Roller8Stand_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            myRoll8Stand.Name = txtSymbol.Text;
            Roll8Stand.Rule.Common.Name = txtSymbol.Text;
            SubTypeChanged();
            UpdateDesc();
        }

        private void UpdateDesc()
        {
            Roll8Stand.EncodingDesc(
            baseRule: ref Roll8Stand.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: false,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = Roll8Stand.Rule.Common.Description;
        }
        private void SubElementsName_Changed(object sender, EventArgs e)
        {
            SetValue10AndElements();
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
           
            if (!Roll8Stand.Rule.Common.Description.Equals(txtDescription.Text))
            {
                Roll8Stand.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(Roll8Stand.Rule.Common.DescObject, false);
            if (!txtDescription.Text.Contains(txtDescriptionRule.Text))
            {
                txtDescription.BackColor = Color.Red;
            }
            else
            {
                txtDescription.BackColor = Color.White;
            }
        }
        private void txtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                Roll8Stand.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    Roll8Stand.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }

        private void txtDescriptionRule_TextChanged(object sender, EventArgs e)
        {

            if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
            {
                Roll8Stand.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Roll8Stand.Rule.Common.Description = txtDescription.Text;
                    Roll8Stand.DecodingDesc(ref Roll8Stand.Rule.Common, AppGlobal.DESC_SEPARATOR);
                    UpdateDesc();
                }
                catch
                {
                }
            }
        }
        private void txtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    Roll8Stand.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }

        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"    

        private void chkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParManual.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)5); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)5); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }
        private void chkParWithHLInletS1_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithHLInletS1.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)1); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)1); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkParWithHLInletS2_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithHLInletS2.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)2); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)2); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkParWithSMS1_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithSMS1.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)3); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)3); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkParWithSMS2_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithSMS2.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)4); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)4); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkPar4Rolls_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkPar4Rolls.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)6); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)6); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkParWithMDDx_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithMDDx.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)7); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)7); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkParWithHLInletS1Div_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithHLInletS1Div.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)8); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)8); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkParWithHLInletS2Div_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParWithHLInletS2Div.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)9); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)9); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithMotorUpS1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithMotorUpS1.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)10); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)10); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithMotorUpS2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithMotorUpS2.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)11); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)11); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithHLOutlet1S1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithHLOutlet1S1.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)12); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)12); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithHLOutlet2S1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithHLOutlet2S1.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)13); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)13); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithHLOutlet1S2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithHLOutlet1S2.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)14); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)14); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithHLOutlet2S2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithHLOutlet2S2.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)15); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)15); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithHLOutlet3S1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithHLOutlet3S1.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)16); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)16); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithHLOutlet3S2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithHLOutlet3S2.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)17); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)17); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithATVForFeedRolls_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithATVForFeedRolls.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)18); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)18); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }

        private void chkWithCurrentTransform_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWithCurrentTransform.Checked)

            { AppGlobal.SetBit<int>(ref value10, (byte)19); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)19); }

            myRoll8Stand.Value10 = value10;
            txtValue10.Text = myRoll8Stand.Value10.ToString();
        }
        private void txtValue10_KeyDown(object sender, KeyEventArgs e)
        {
            GetValue10BitValue(value10);
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

        private void chkParManualOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit5";
        }
        private void txtMotorLowS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }

        private void txtMotorUpS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }

        private void txtHLBackupLeftS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value13";
        }

        private void txtHLBackupRightS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value42";
        }

        private void txtHLInletS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value14";
        }
        private void txtHLInletS1Div_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }
        private void txtSMS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value15";
        }

        private void txtHLOutlet3S1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value43";
        }

        private void txtInpPressureS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value16";
        }

        private void txtFeedrollS1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }

        private void txtFeedrollS1Div_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value27";
        }

        private void txtHLOutlet1S1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value35";
        }

        private void txtHLOutlet2S1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value36";
        }

        private void txtMotorLowS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value17";
        }

        private void txtMotorUpS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value18";
        }

        private void txtHLBackupLeftS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value19";
        }

        private void txtHLBackupRightS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value44";
        }

        private void txtHLInletS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value20";
        }

        private void txtHLInletS2Div_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }

        private void txtSMS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void txtHLOutlet3S2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value45";
        }

        private void txtInpPressureS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }

        private void txtFeedrollS2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value28";
        }

        private void txtFeedrollS2Div_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value29";
        }

        private void txtHLOutlet1S2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value37";
        }

        private void txtHLOutlet2S2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value38";
        }

        private void txtMDDx_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value41";
        }

        private void txtSide1Bottom_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31";
        }

        private void txtSide1Top_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30";
        }

        private void txtSide2Bottom_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value33";
        }

        private void txtSide2Top_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value32";
        }
        #endregion

        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value10.Name,
                OType = Convert.ToString(Roll8Stand.OTypeValue)
            };
            objectBrowser.Show();
        }

      
        void SetValue10AndElements()
        {
            CheckBox tempChk = new CheckBox();
            CheckBox[] tempCheckCurrent = new CheckBox[4] { tempChk, tempChk, tempChk, tempChk };
            CheckBox[] tempCheckFeedRoll = new CheckBox[2] { tempChk, tempChk};
            List<(TextBox, CheckBox)> subElements = new List<(TextBox, CheckBox)>
            {
                (txtHLInletS1,chkParWithHLInletS1),
                (txtHLInletS2,chkParWithHLInletS2),
                (txtSMS1,chkParWithSMS1),
                (txtSMS2,chkParWithSMS2),
                (txtHLInletS1Div,chkParWithHLInletS1Div),
                (txtHLInletS2Div,chkParWithHLInletS2Div),
                (txtMotorUpS1,chkWithMotorUpS1),
                (txtMotorUpS2,chkWithMotorUpS2),
                (txtHLOutlet1S1,chkWithHLOutlet1S1),
                (txtHLOutlet2S1,chkWithHLOutlet2S1),
                (txtHLOutlet1S2,chkWithHLOutlet1S2),
                (txtHLOutlet2S2,chkWithHLOutlet2S2),
                (txtHLOutlet3S1,chkWithHLOutlet3S1),
                (txtHLOutlet3S2,chkWithHLOutlet3S2),
                (txtSide1Bottom,tempCheckCurrent[0]),
                (txtSide1Top,tempCheckCurrent[1]),
                (txtSide2Bottom,tempCheckCurrent[2]),
                (txtSide2Top,tempCheckCurrent[3]),
                (txtHLBackupLeftS1,tempChk),
                (txtHLBackupLeftS2,tempChk),
                (txtHLBackupRightS1,tempChk),
                (txtHLBackupRightS2,tempChk),
                (txtInpPressureS1,tempChk),
                (txtInpPressureS2,tempChk),
                (txtFeedrollS1,tempCheckFeedRoll[0]),
                (txtFeedrollS2,tempCheckFeedRoll[1]),
                (txtFeedrollS1Div,tempChk),
                (txtFeedrollS2Div,tempChk),
                (txtMDDx,tempChk)
            };
            foreach (var (textBox, checkBox) in subElements)
            {
                if (!textBox.Enabled)
                {
                    textBox.Text = string.Empty;
                }
                checkBox.Checked = !string.IsNullOrEmpty(textBox.Text);
            }
            chkWithCurrentTransform.Checked = tempCheckCurrent[0].Checked || tempCheckCurrent[1].Checked
                || tempCheckCurrent[2].Checked || tempCheckCurrent[3].Checked;
            chkWithATVForFeedRolls.Checked = tempCheckFeedRoll[1].Checked || tempCheckFeedRoll[0].Checked;
        }
        void SetElementsName(string subType,string name)
        {
            myRoll8Stand.Side1.MotorLow = txtMotorLowS1.Text = name + GcObjectInfo.MA_Roll8Stand.SiffixSide1.MotorLow;
            myRoll8Stand.Side2.MotorLow = txtMotorLowS2.Text = name + GcObjectInfo.MA_Roll8Stand.SiffixSide2.MotorLow;
            if (subType == Roll8Stand.ROLL8)
            {
                myRoll8Stand.Side1.MotorUp = txtMotorUpS1.Text = name + GcObjectInfo.MA_Roll8Stand.SiffixSide1.MotorUp;
                myRoll8Stand.Side2.MotorUp = txtMotorUpS2.Text = name + GcObjectInfo.MA_Roll8Stand.SiffixSide2.MotorUp;
            }
            else if (subType == Roll8Stand.ROLL4M || subType == Roll8Stand.ROLL8M2M || subType == Roll8Stand.ROLL8M)
            {

                myRoll8Stand.Side1.FeedRoll = txtFeedrollS1.Text = name + GcObjectInfo.MA_Roll8Stand.SiffixSide1.FeedRoll;
                myRoll8Stand.Side2.FeedRoll = txtFeedrollS2.Text = name + GcObjectInfo.MA_Roll8Stand.SiffixSide2.FeedRoll;
                myRoll8Stand.MDDx= txtMDDx.Text = name + GcObjectInfo.MA_Roll8Stand.SuffixMDDx;
                if (subType == Roll8Stand.ROLL8M)
                {
                    myRoll8Stand.Side1.MotorUp = txtMotorUpS1.Text = name + GcObjectInfo.MA_Roll8Stand.SiffixSide1.MotorUp;
                    myRoll8Stand.Side2.MotorUp = txtMotorUpS2.Text = name + GcObjectInfo.MA_Roll8Stand.SiffixSide2.MotorUp;
                    myRoll8Stand.Side1.MotorLowCur = txtSide1Bottom.Text = txtMotorLowS1.Text + GcObjectInfo.MA_Roll8Stand.SuffixCurrent;
                    myRoll8Stand.Side2.MotorLowCur = txtSide2Bottom.Text = txtMotorLowS2.Text + GcObjectInfo.MA_Roll8Stand.SuffixCurrent;
                    myRoll8Stand.Side1.MotorUpCur = txtSide1Top.Text = txtMotorUpS1.Text + GcObjectInfo.MA_Roll8Stand.SuffixCurrent;
                    myRoll8Stand.Side1.MotorUpCur = txtSide2Top.Text = txtMotorUpS2.Text + GcObjectInfo.MA_Roll8Stand.SuffixCurrent;
                }
                else
                {
                    myRoll8Stand.Side1.MotorUpCur = txtSide1Top.Text = txtMotorLowS1.Text + GcObjectInfo.MA_Roll8Stand.SuffixCurrent;
                    myRoll8Stand.Side2.MotorUpCur = txtSide2Top.Text = txtMotorLowS2.Text + GcObjectInfo.MA_Roll8Stand.SuffixCurrent;
                }
            }
          
        }
        void SetElementsEnbale(string subType)
        {
            if (subType == Roll8Stand.ROLL4 || subType == Roll8Stand.ROLL8)
            {
                bool roll4 = subType == Roll8Stand.ROLL4;
                chkParWithMDDx.Checked = false;
                chkPar4Rolls.Checked = roll4;

                txtMotorUpS1.Enabled = !roll4;
                txtMotorUpS2.Enabled = !roll4;
                txtHLBackupLeftS1.Enabled = !roll4;
                txtHLBackupLeftS2.Enabled = !roll4;
                txtHLBackupRightS1.Enabled = !roll4;
                txtHLBackupRightS2.Enabled = !roll4;
                txtHLInletS1.Enabled = true;
                txtHLInletS2.Enabled = true;
                txtHLInletS1Div.Enabled = false;
                txtHLInletS2Div.Enabled = false;
                txtSMS1.Enabled = true;
                txtSMS2.Enabled = true;
                txtHLOutlet3S1.Enabled = false;
                txtHLOutlet3S2.Enabled = false;
                txtInpPressureS1.Enabled = true;
                txtInpPressureS2.Enabled = true;
                txtFeedrollS1.Enabled = false;
                txtFeedrollS2.Enabled = false;
                txtFeedrollS1Div.Enabled = false;
                txtFeedrollS2Div.Enabled = false;
                txtHLOutlet1S1.Enabled = true;
                txtHLOutlet2S1.Enabled = true;
                txtHLOutlet1S2.Enabled = true;
                txtHLOutlet2S2.Enabled = true;
                txtMDDx.Enabled = false;
                txtSide1Bottom.Enabled = false;
                txtSide2Bottom.Enabled = false;
                txtSide1Top.Enabled = false;
                txtSide2Top.Enabled = false;
            }
            else if (subType == Roll8Stand.ROLL4M || subType == Roll8Stand.ROLL8M2M)
            {
                bool roll4m = subType == Roll8Stand.ROLL4M;
                chkPar4Rolls.Checked = roll4m;
                chkParWithMDDx.Checked = true;
                txtMotorUpS1.Enabled = false;
                txtMotorUpS2.Enabled = false;
                txtHLBackupLeftS1.Enabled = !roll4m;
                txtHLBackupLeftS2.Enabled = !roll4m;
                txtHLBackupRightS1.Enabled = !roll4m;
                txtHLBackupRightS2.Enabled = !roll4m;
                txtHLInletS1.Enabled = true;
                txtHLInletS2.Enabled = true;
                txtHLInletS1Div.Enabled = roll4m;
                txtHLInletS2Div.Enabled = roll4m;
                txtSMS1.Enabled = false;
                txtSMS2.Enabled = false;
                txtHLOutlet3S1.Enabled = true;
                txtHLOutlet3S2.Enabled = true;
                txtInpPressureS1.Enabled = false;
                txtInpPressureS2.Enabled = false;
                txtFeedrollS1.Enabled = true;
                txtFeedrollS2.Enabled = true;
                txtFeedrollS1Div.Enabled = roll4m;
                txtFeedrollS2Div.Enabled = roll4m;
                txtHLOutlet1S1.Enabled = true;
                txtHLOutlet2S1.Enabled = true;
                txtHLOutlet1S2.Enabled = true;
                txtHLOutlet2S2.Enabled = true;
                txtMDDx.Enabled = true;
                txtSide1Bottom.Enabled = false;
                txtSide2Bottom.Enabled = false;
                txtSide1Top.Enabled = true;
                txtSide2Top.Enabled = true;
            }
            else if (subType == Roll8Stand.ROLL8M)
            {
                chkPar4Rolls.Checked = false;
                chkParWithMDDx.Checked = true;
                txtMotorUpS1.Enabled = true;
                txtMotorUpS2.Enabled = true;
                txtHLBackupLeftS1.Enabled = true;
                txtHLBackupLeftS2.Enabled = true;
                txtHLBackupRightS1.Enabled = true;
                txtHLBackupRightS2.Enabled = true;
                txtHLInletS1.Enabled = true;
                txtHLInletS2.Enabled = true;
                txtHLInletS1Div.Enabled = false;
                txtHLInletS2Div.Enabled = false;
                txtSMS1.Enabled = false;
                txtSMS2.Enabled = false;
                txtHLOutlet3S1.Enabled = true;
                txtHLOutlet3S2.Enabled = true;
                txtInpPressureS1.Enabled = false;
                txtInpPressureS2.Enabled = false;
                txtFeedrollS1.Enabled = true;
                txtFeedrollS2.Enabled = true;
                txtFeedrollS1Div.Enabled = false;
                txtFeedrollS2Div.Enabled = false;
                txtHLOutlet1S1.Enabled = true;
                txtHLOutlet2S1.Enabled = true;
                txtHLOutlet1S2.Enabled = true;
                txtHLOutlet2S2.Enabled = true;
                txtMDDx.Enabled = true;
                txtSide1Bottom.Enabled = true;
                txtSide2Bottom.Enabled = true;
                txtSide1Top.Enabled = true;
                txtSide2Top.Enabled = true;
            }
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
                    myRoll8Stand.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SetElements(myRoll8Stand.SubType);
                //GetValue10BitValue(value10);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
               
        }
        void GetValue10BitValue(int value)
        {
            chkParManual.Checked = AppGlobal.GetBit<int>(value, 5);
            chkParWithHLInletS1.Checked = AppGlobal.GetBit<int>(value, 1);
            chkParWithHLInletS2.Checked = AppGlobal.GetBit<int>(value, 2);
            chkParWithSMS1.Checked = AppGlobal.GetBit<int>(value, 3);
            chkParWithSMS2.Checked = AppGlobal.GetBit<int>(value, 4);
            chkPar4Rolls.Checked = AppGlobal. GetBit<int>(value, 6);
            chkParWithMDDx.Checked = AppGlobal.GetBit<int>(value, 7);
            chkParWithHLInletS1Div.Checked = AppGlobal. GetBit<int>(value, 8);
            chkParWithHLInletS2Div.Checked = AppGlobal. GetBit<int>(value, 9);
            chkWithMotorUpS1.Checked = AppGlobal.GetBit<int>(value, 10);
            chkWithMotorUpS2.Checked = AppGlobal.GetBit<int>(value, 11);
            chkWithHLOutlet1S1.Checked = AppGlobal.GetBit<int>(value, 12);
            chkWithHLOutlet2S1.Checked = AppGlobal.GetBit<int>(value, 13);
            chkWithHLOutlet1S2.Checked = AppGlobal.GetBit<int>(value, 14);
            chkWithHLOutlet2S2.Checked = AppGlobal.GetBit<int>(value, 15);
            chkWithHLOutlet3S1.Checked = AppGlobal.GetBit<int>(value, 16);
            chkWithHLOutlet3S2.Checked = AppGlobal.GetBit<int>(value, 17);
            chkWithATVForFeedRolls.Checked = AppGlobal.GetBit<int>(value, 18);
            chkWithCurrentTransform.Checked = AppGlobal.GetBit<int>(value, 19);
        }

        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubTypeChanged();
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
            BML.MA_Roll8Stand.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_BML}.{AppGlobal.JS_ROLL8STAND}.Path", BML.MA_Roll8Stand.BMLPath);
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
            listBMLName = LibGlobalSource.BMLHelper.ExtractMachineNameWithCount(dataGridBML, nameof(BML.ColumnName), Engineering.PatternMachineName);
            TxtQuantity.Text = listBMLName.Count.ToString();
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
                comboLineBML.Items.Add(item);       
            }
            comboNameBML.SelectedItem = "B";
            comboDescBML.SelectedItem = "N";
            comboTypeBML.SelectedItem = "C";
            comboFloorBML.SelectedItem = "L";
            comboCabinetBML.SelectedItem = "P";
            comboSectionBML.SelectedItem = "Q";
            comboLineBML.SelectedItem = "X";
            comboControlBML.SelectedItem = "H";
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text = BML.MA_Roll8Stand.BMLPath;
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
                HeaderText = BML.ColumnType,
                Name = nameof(BML.ColumnType)
            });

            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnControlMethod,
                Name = nameof(BML.ColumnControlMethod)
            });
            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnFloor,
                Name = nameof(BML.ColumnFloor)
            });
            dataGridBML.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = BML.ColumnLine,
                Name = nameof(BML.ColumnLine)
            });  
        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
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

            var rowsContainingMDDY = dataTable.AsEnumerable()
                .Where(row => row.Field<string>(3). Contains(BML.MDDx.TypeMDDY) ||
                              row.Field<string>(3).Contains(BML.MDDx.TypeMDDZ) ||
                              row.Field<string>(3).Contains(BML.MDDx.TypeMRRA4) ||
                              row.Field<string>(3).Contains(BML.MDDx.TypeMRRA8))
                .ToList();
            var uniquePrefixes = rowsContainingMDDY
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
        }
        #endregion
        #region Common used
        private void chkAddSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddSectionToDesc.Checked)
            {
                chkAddUserSectionToDesc.Checked = false;
            }
            UpdateDesc();
        }

        private void chkAddUserSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddUserSectionToDesc.Checked)
            {
                chkAddSectionToDesc.Checked = false;
            }
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
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Roll8Stand.Rule.Common.DescFloor = ComboElevation.Text;
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
                txtSymbolRule.Text = Roll8Stand.Rule.Common.NameRule;
                txtSymbolIncRule.Text = Roll8Stand.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                grpSymbolRule.Visible = true;
                lblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_ROLL8STAND;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = Roll8Stand.Rule.Common.NameRule;
                txtSymbolIncRule.Text = Roll8Stand.Rule.Common.NameRuleInc;
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
                    OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
                    DataTable dataTable;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={Roll8Stand.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Value11.Name,
                        GcproTable.ObjData.Value13.Name, GcproTable.ObjData.Value19.Name, GcproTable.ObjData.Value14.Name,
                        GcproTable.ObjData.Value47.Name, GcproTable.ObjData.Value42.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    Roll8Stand.Clear(myRoll8Stand.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        ProgressBar.Value = count;
                    }
                    Roll8Stand.SaveFileAs(myRoll8Stand.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
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
                myRoll8Stand.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            Roll8Stand.SaveFileAs(myRoll8Stand.FilePath, LibGlobalSource.CREATE_OBJECT);
            Roll8Stand.SaveFileAs(myRoll8Stand.FileRelationPath, LibGlobalSource.CREATE_RELATION);
        }

        private void BtnNewImpExpDef_Click(object sender, EventArgs e)
        {
            CreateImpExp();
        }
  
        private void AppendInfoToBuilder(CheckBox checkBox, string info, StringBuilder builder)
        {
            if (checkBox.Checked)
            {
                builder.Append(info);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datafromBML"></param>
        /// <param name="objRoll8Stand"></param>
        /// <param name="parValue10"></param>
        /// <param name="addtionToDesc"></param>
        /// <param name="processValue"></param>
        public void CreatObjectBML(DataGridView datafromBML, Roll8Stand objRoll8Stand, double parValue10,
          (bool section, bool userDefSection, bool elevation, bool identNumber, bool cabinet, bool power, bool onlyNumber) addtionToDesc,
          out (int Value, int Max) processValue)
         { 
            StringBuilder objBuilder = new StringBuilder();
            TextFileHandle objTextFileHandle = new TextFileHandle();
            int noOfSubElements;
            List<KeyValuePair<string, int>> listName = LibGlobalSource.BMLHelper.ExtractMachineNameWithCount(dataGridBML, nameof(BML.ColumnName), Engineering.PatternMachineName);
            int quantityNeedToBeCreate = listName.Count;
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            string _nameNumberString = string.Empty;
            int line = 0, nextLine = 0;
            // string subTypePrev;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                myRoll8Stand.Name = Convert.ToString(listName[i].Key.ToString());
                if (String.IsNullOrEmpty(objRoll8Stand.Name))
                {
                    continue;
                }
                #region Subtype         
                noOfSubElements = (int)listName[i].Value;
                switch (noOfSubElements)
                {
                    case 1:
                        line = nextLine;
                        nextLine += 1;
                        myRoll8Stand.SubType = Roll8Stand.ROLL4;
                        break;
                    case 2:
                        myRoll8Stand.SubType = Roll8Stand.ROLL4;
                        line = nextLine;
                        nextLine += 2;
                        break;
                    case 3:
                        myRoll8Stand.SubType = Roll8Stand.ROLL4;
                        line = nextLine;
                        nextLine += 3;
                        break;
                    case 4:
                        myRoll8Stand.SubType = Roll8Stand.ROLL8;
                        line = nextLine;
                        nextLine += 4;
                        break;
                    case 5:
                        myRoll8Stand.SubType = Roll8Stand.ROLL4M;
                        line = nextLine;
                        nextLine += 5;
                        break;                
                    case 7:
                        myRoll8Stand.SubType = Roll8Stand.ROLL8M;
                        line = nextLine;
                        nextLine += 7;
                        break;
                    default:                    
                        goto case 5;                   
                }
                            
                    SetElementsName(objRoll8Stand.SubType, objRoll8Stand.Name);
                    SetValue10AndElements();
                objRoll8Stand.Value10= value10;
                #endregion
                if (addtionToDesc.section)
                {
                    if (!string.IsNullOrEmpty(_nameNumberString))
                    {
                        if (AppGlobal.ParseValue<int>(_nameNumberString, out tempInt))
                        {
                            Roll8Stand.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.userDefSection)
                {
                    Roll8Stand.Rule.Common.DescLine = Convert.ToString(datafromBML.Rows[line].Cells[nameof(BML.ColumnLine)].Value);
                }

                if (addtionToDesc.elevation)
                {
                    objRoll8Stand.Elevation = Convert.ToString(datafromBML.Rows[line].Cells[nameof(BML.ColumnFloor)].Value);
                    Roll8Stand.Rule.Common.DescFloor = $"{objRoll8Stand.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                }
                else
                {
                    Roll8Stand.Rule.Common.DescFloor = string.Empty;
                }
                 objRoll8Stand.Description = Roll8Stand.EncodingDesc(
                 baseRule: ref Roll8Stand.Rule.Common,
                 namePrefix: GcObjectInfo.General.PrefixName,
                 nameRule: Engineering.PatternMachineName,
                 withLineInfo: addtionToDesc.section || addtionToDesc.userDefSection,
                 withFloorInfo: addtionToDesc.elevation,
                 withNameInfo: addtionToDesc.identNumber,
                 withCabinet: false,
                 withPower: false,
                 nameOnlyWithNumber: addtionToDesc.onlyNumber
                );
                objRoll8Stand.CreateObject(objTextFileHandle, objBuilder, Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }
        private void CreatObjectRule((bool section, bool userDefSection, bool elevation, bool identNumber, bool cabinet, bool power, bool onlyNumber) addtionToDesc,
            (int IOByteStart, int Len) IOAddr,
            ref (int Value, int Max) processValue)
        {           
            StringBuilder objBuilder = new StringBuilder();
            TextFileHandle objTextFileHandle = new TextFileHandle();
            int quantityNeedToBeCreate = processValue.Max;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            string desc;
            objDefaultInfo = Roll8Stand.Rule.Common;
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
            #region UnChanged field
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                myRoll8Stand.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            else
            {
                myRoll8Stand.SubType = Roll8Stand.ROLL4M;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (ComboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                myRoll8Stand.PType = Roll8Stand.ParseInfoValue(selectedPTypeItem, AppGlobal.FIELDS_SEPARATOR, Roll8Stand.P2046);   
            }
            else
            {
                myRoll8Stand.PType = Roll8Stand.P2046;
            }

            ///<Value9>Value is set when corresponding check box's check state changed</Value9>
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            myRoll8Stand.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                myRoll8Stand.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                myRoll8Stand.Diagram = Roll8Stand.ParseInfoValue(selectedDiagram, AppGlobal.FIELDS_SEPARATOR, AppGlobal.NO_DIAGRAM);
            }
            ///<Page></Page>
            myRoll8Stand.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling ;
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                myRoll8Stand.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                myRoll8Stand.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                myRoll8Stand.Panel_ID = selectedPanel_ID;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            myRoll8Stand.FieldBusNode = AppGlobal.NO_DP_NODE;
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
            ///<DescRule>生成描述规则</DescRule>
            desc = Roll8Stand.Rule.Common.DescObject;
            if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
            {
                description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(desc, txtDescriptionRule.Text);
                if (description.PosInfo.Len == -1)
                {
                    if (moreThanOne)
                    {
                        AppGlobal.RuleNotSetCorrect($"{grpDescriptionRule.Text}.{lblDescriptionRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    }
                }
                else
                {
                    description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(desc, txtDescriptionRule.Text);
                }
            }
            #endregion
             ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
          //  int symbolInc, symbolRule, descriptionInc;
            AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out int symbolInc);
            AppGlobal.ParseValue<int>(txtSymbolRule.Text, out int symbolRule);
            AppGlobal.ParseValue<int>(txtDescriptionIncRule.Text, out int descriptionInc);
            for (int i = 0; i < quantityNeedToBeCreate ; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));

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
                    description.Name = BML.MachineType.RollerMiller;
                }
                SetElementsName(myRoll8Stand.SubType, name.Name);
                myRoll8Stand.Value10 = value10;
                myRoll8Stand.Name = name.Name;
                Roll8Stand.Rule.Common.Name = name.Name;
                Roll8Stand.Rule.Common.DescObject = description.Name;
                Roll8Stand.Rule.Common.DescFloor = $"{myRoll8Stand.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                myRoll8Stand.Description = Roll8Stand.EncodingDesc(
                    baseRule: ref Roll8Stand.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.section || addtionToDesc.userDefSection,
                    withFloorInfo: addtionToDesc.elevation,
                    withNameInfo: addtionToDesc.identNumber,
                    withCabinet: false,
                    withPower: false,
                    nameOnlyWithNumber: addtionToDesc.onlyNumber
                 );
                myRoll8Stand.CreateObject(objTextFileHandle, objBuilder, Encoding.Unicode);
                processValue.Value = i;
            }
            processValue.Value = processValue.Max;
        }
        private void CreatObjectAutoSearch()
        {
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
           DataTable dataTable ;
            #region common used variables declaration  
            StringBuilder objBuilder = new StringBuilder();
            TextFileHandle objTextFileHandle = new TextFileHandle();
            int quantityNeedToBeCreate;
           // AppGlobal.ParseValue<int>(TxtQuantity.Text, out int quantityNeedToBeCreate);
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

            List<string> objList;
            List<string> objVFC;
            List<int> objSubs;
            bool isVfc = false;
            int noOfSubElements;
            string filter = $@"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.EL_MDDx} AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER}";
            filter = string.IsNullOrEmpty(txtSymbol.Text) ? filter : $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";

            dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, null, GcproTable.ObjData.Text0.Name);
            objList = OleDb.GetColumnData<string>(dataTable, GcproTable.ObjData.Text0.Name);
            for (int i = 0; i <= objList.Count - 1; i++)
            {
                objList[i] = GcObject.GetObjectSymbolFromIO(objList[i], GcObjectInfo.General.SuffixIO.Delimiter);
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
                myRoll8Stand.Name = objList[i];
                switch (noOfSubElements)
                {
                    case 1:
                    case 2:
                        myRoll8Stand.SubType = Roll8Stand.ROLL4;
                        break;
                    case 3:                      
                    case 4:
                        if (isVfc)
                        {
                            myRoll8Stand.SubType = Roll8Stand.ROLL4M;
                            //myRoll8Stand.Side1.MotorUpCur = $"{myRoll8Stand.Side1.MotorLow}{GcObjectInfo.Roll8Stand.SuffixCurrent}";
                            //myRoll8Stand.Side2.MotorUpCur = $"{myRoll8Stand.Side2.MotorLow}{GcObjectInfo.Roll8Stand.SuffixCurrent}";
                            //myRoll8Stand.MDDx = $"{myRoll8Stand.Name}{GcObjectInfo.Roll8Stand.SuffixMDDx}";
                        }
                        else
                        {
                            myRoll8Stand.SubType = Roll8Stand.ROLL8;
                            //myRoll8Stand.Side1.MotorUp = $"{myRoll8Stand.Name}{GcObjectInfo.Roll8Stand.SiffixSide1.MotorUp}";
                            //myRoll8Stand.Side2.MotorUp = $"{myRoll8Stand.Name}{GcObjectInfo.Roll8Stand.SiffixSide2.MotorUp}";
                        }
                        break;          
                    case 6:
                        myRoll8Stand.SubType = Roll8Stand.ROLL8M;
                        //myRoll8Stand.Side1.MotorLowCur = $"{myRoll8Stand.Side1.MotorLow}{GcObjectInfo.Roll8Stand.SuffixCurrent}";
                        //myRoll8Stand.Side2.MotorLowCur = $"{myRoll8Stand.Side2.MotorLow}{GcObjectInfo.Roll8Stand.SuffixCurrent}";
                        //myRoll8Stand.Side1.MotorUpCur = $"{myRoll8Stand.Side1.MotorUp}{GcObjectInfo.Roll8Stand.SuffixCurrent}";
                        //myRoll8Stand.Side2.MotorUpCur = $"{myRoll8Stand.Side2.MotorUp}{GcObjectInfo.Roll8Stand.SuffixCurrent}";
                        //myRoll8Stand.MDDx = $"{myRoll8Stand.Name}{GcObjectInfo.Roll8Stand.SuffixMDDx}";
                        break;
                    default:
                        myRoll8Stand.SubType = Roll8Stand.ROLL4M;
                        goto case 4;

                }
            
                SetElementsName(myRoll8Stand.SubType, myRoll8Stand.Name);
                SetValue10AndElements();
           
                myRoll8Stand.Description = txtDescription.Text;
                myRoll8Stand.Value10 = value10;
                myRoll8Stand.CreateObject(objTextFileHandle, objBuilder, Encoding.Unicode);
                ProgressBar.Value = i;
            }
            ProgressBar.Value = quantityNeedToBeCreate;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet = false;
                AppGlobal.AdditionDesc.Power = false;
                if (createMode.BML)
                {
                    CreatObjectBML(dataGridBML, myRoll8Stand, value10, AppGlobal.AdditionDesc, out AppGlobal.ProcessValue);
                }
                else if (createMode.AutoSearch)
                {
                    CreatObjectAutoSearch();
                }
                else if (createMode.Rule)
                {
                    AppGlobal.ProcessValue.Max = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                    CreatObjectRule(AppGlobal.AdditionDesc, AppGlobal.IOAddr, ref AppGlobal.ProcessValue);
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
