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
using OfficeOpenXml.Export.HtmlExport.StyleCollectors.StyleContracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using System.Net.NetworkInformation;
#endregion
namespace GcproExtensionApp
{

    public partial class FormBin : Form, IGcForm
    {
        public FormBin()
        {
            InitializeComponent();
        }

        #region Public object in this class
        Bin myBin = new Bin(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private string DEMO_NAME_BIN = "BIN401";
        private string DEMO_NAME_RULE_BIN = "401";
        private string DEMO_DESCRIPTION_BIN = "F401:401号基粉仓";
        private string DEMO_DESCRIPTION_RULE_BIN = "401";
        #endregion
        private int value24 = 0;
        private int value30 = 0;
        private int value31 = 0;
        private int tempInt = 0;
        //private float tempFloat = 0.0f;
        private bool tempBool = false;
        private string descPrefixRule = string.Empty;
        private string descPrefixPart = string.Empty;
        private string descPart= string.Empty;
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
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={Bin.OTypeValue}",
                null, $"{GcproTable.SubType.FieldSub_Type_Desc.Name} ASC",
                GcproTable.SubType.FieldSubType.Name, GcproTable.SubType.FieldSub_Type_Desc.Name);
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.SubType.TableName) + AppGlobal.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>($"{GcproTable.SubType.FieldSub_Type_Desc.Name}");
                ComboEquipmentSubType.Items.Add(itemInfo);

            }
            ComboEquipmentSubType.SelectedIndex = 0;
            ///<ProcessFct> Read [ProcessFct] </ProcessFct>
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {Bin.OTypeValue}",
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
            ///</ReadInfoFromProjectDB>
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
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
            txtSymbolRule.Text = Bin.Rule.Common.NameRule;
            txtSymbolIncRule.Text = Bin.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = Bin.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = Bin.Rule.Common.DescriptionRuleInc;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + Bin.OType);
            toolTip.SetToolTip(btnConnectChild, AppGlobal.CONNECT_CONNECTOR);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_BIN);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_BIN);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_BIN);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_BIN);
           
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Bin.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Bin.ImpExpRuleName}'", null);
                    CreateBinImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateBinImpExp(oledb);
            }

        }
        public void Default()
        {
            tabCreateMode.Controls[1].Enabled = false;
            txtSymbol.Text= DEMO_NAME_BIN;
            txtDescription.Text = DEMO_DESCRIPTION_BIN;
            var args = new KeyEventArgs(Keys.Enter);
            txtDescription_KeyDown(txtDescription, args);
            txtSymbol.Focus();
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            //暂时隐藏BML Tab
            TabPage tabToHide = tabCreateMode.TabPages["tabBML"];
            tabCreateMode.TabPages.Remove(tabToHide); 
            //ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            //ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            txtValue24.Text = "4";
            txtValue30.Text = "0";
            txtValue31.Text = "0";
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "Bin导入文件 " + " " + myBin.FilePath;
        }

        #endregion Public interfaces
        private void CreateBinImpExp(OleDb oledb)
        {
            bool result = myBin.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void FormBin_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);
            ///<ImplementIGcForm>
            ///</ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormBin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->
        #region <------Check and store rule event------>
        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            txtBinNo.Text = txtSymbolRule.Text;
            myBin.Name = txtSymbol.Text;
        }
        private void txtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                Bin.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    Bin.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
           
        }
        private string GetBinIdentPrefix(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                return string.Empty;
            }

            int separatorIndex = description.IndexOf(GcObjectInfo.Bin.IdentDescSeparator);
            return separatorIndex >= 0 ? description.Substring(0, separatorIndex) : string.Empty;
        }
        //private string GetDescriptionRule(string description,string binIdentPrefix)
        //{
        //    string descriptionRule;
        //    descriptionRule = string.IsNullOrEmpty(binIdentPrefix) ? LibGlobalSource.StringHelper.ExtractNumericPart(description, false) :
        //                       LibGlobalSource.StringHelper.ExtractNumericPart(description.Replace(binIdentPrefix, ""), false);
        //    return descriptionRule;
        //}
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                descPrefixPart = GetBinIdentPrefix(txtDescription.Text);
                descPrefixRule = string.IsNullOrEmpty(descPrefixPart) ? string.Empty : LibGlobalSource.StringHelper.ExtractNumericPart(descPrefixPart, false);

                descPart = string.IsNullOrEmpty(descPrefixPart) ? txtDescription.Text :txtDescription.Text.Remove(0, descPrefixPart.Length);
             
             //   txtDescriptionRule.Text = GetDescriptionRule(txtDescription.Text, descPrefixPart);
                txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(descPart, false).ToString();
          
            }
        }
        private void txtDescriptionRule_TextChanged(object sender, EventArgs e)
        {

            if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
            {
                Bin.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        private void txtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    Bin.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value1.Name;
            objectBrowser.OType = Convert.ToString(Bin.OTypeValue);
            objectBrowser.Show();
        }
        private void txtHighLevel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value22.Name;
            objectBrowser.OType = Convert.ToString(DI.OTypeValue);
            objectBrowser.SubType = DI.HLBIN;
            objectBrowser.ShowDialog();
            txtHighLevel.Text = objectBrowser.ReturnedItem;
        }
        private void txtMiddleLevel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value22.Name;
            objectBrowser.OType = Convert.ToString(DI.OTypeValue);
            objectBrowser.ShowDialog();
            txtMiddleLevel.Text = objectBrowser.ReturnedItem;
        }
        private void txtLowLevel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value21.Name;
            objectBrowser.OType = Convert.ToString(DI.OTypeValue);
            objectBrowser.SubType = DI.LLBIN;
            objectBrowser.ShowDialog();
            txtLowLevel.Text = objectBrowser.ReturnedItem;
        }
        private void txtAnalogLevel_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void txtHighLevel_TextChanged(object sender, EventArgs e)
        {
            txtHighLevelRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtHighLevel.Text, false);
            chkReadHighLevel.Checked = !String.IsNullOrEmpty(txtHighLevelRule.Text) && !String.IsNullOrEmpty(txtHighLevel.Text);
        }

        private void txtMiddleLevel_TextChanged(object sender, EventArgs e)
        {
            txtMiddleLevelRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtMiddleLevel.Text, false);
            chkReadRefillLevel.Checked = !String.IsNullOrEmpty(txtMiddleLevelRule.Text) && !String.IsNullOrEmpty(txtMiddleLevel.Text);
        }

        private void txtLowLevel_TextChanged(object sender, EventArgs e)
        {
            txtLowLevelRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtLowLevel.Text, false);
            chkWithLL.Checked = chkReadLowLevel.Checked = !String.IsNullOrEmpty(txtLowLevelRule.Text) && !String.IsNullOrEmpty(txtLowLevel.Text);
        }

        private void txtAnalogLevel_TextChanged(object sender, EventArgs e)
        {
            txtAnalogLevelRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtAnalogLevel.Text, false);
            chkReadInFillLevel.Checked = !String.IsNullOrEmpty(txtAnalogLevelRule.Text) && !String.IsNullOrEmpty(txtAnalogLevel.Text);
        }
        private void txtBinNo_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtBinNo.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtEmptyingTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtEmptyingTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        private void txtOverFillingWeight_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtOverFillingWeight.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        private void txtDryFillingWeight_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtDryFillingWeight.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtRestdischargeWeight_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtRestdischargeWeight.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtHighLevelIncRule_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtHighLevelIncRule.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtMiddleLevelIncRule_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtMiddleLevelIncRule.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtLowLevelIncRule_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtLowLevelIncRule.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtAnalogLevelIncRule_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtAnalogLevelIncRule.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtRemoteHighLevel_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtRemoteHighLevel.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtRemoteMiddleLevel_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtRemoteMiddleLevel.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtRemoteLowLevel_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtRemoteLowLevel.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtRemoteAnalogLevel_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtInFillLevel.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtHighLevelRule_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtHighLevelRule.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtMiddleLevelRule_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtMiddleLevelRule.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtLowLevelRule_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtLowLevelRule.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtAnalogLevelRule_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtAnalogLevelRule.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }
        }
        private void txtValue24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value24 = AppGlobal.ParseInt(txtValue24.Text, out tempInt) ? tempInt : value24;
                GetValue24BitValue(value24);
            }
        }
        private void txtValue31_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value31 = AppGlobal.ParseInt(txtValue31.Text, out tempInt) ? tempInt : value31;
                GetValue31BitValue(value31);
            }
        }
        private void txtValue30_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value30 = AppGlobal.ParseInt(txtValue30.Text, out tempInt) ? tempInt : value30;
                GetValue30BitValue(value30);
            }
        }
        #endregion
        #region <------ Check and unchek "Value31","Value30 and "Value24"------>"    
        private void chkLLisBelowBin_CheckedChanged(object sender, EventArgs e)
        {
            value24 = int.Parse(txtValue24.Text);
            if (chkLLisBelowBin.Checked)

            { AppGlobal.SetBit(ref value24, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value24, (byte)0); }

            myBin.Value24 = value24.ToString();
            txtValue24.Text = myBin.Value24;
        }
        private void chkRestdischarge_CheckedChanged(object sender, EventArgs e)
        {
            value24 = int.Parse(txtValue24.Text);
            if (chkRestdischarge.Checked)

            { AppGlobal.SetBit(ref value24, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value24, (byte)1); }

            myBin.Value24 = value24.ToString();
            txtValue24.Text = myBin.Value24;
        }
        private void chkWithLL_CheckedChanged(object sender, EventArgs e)
        {
            value24 = int.Parse(txtValue24.Text);
            if (chkWithLL.Checked)

            { AppGlobal.SetBit(ref value24, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value24, (byte)2); }

            myBin.Value24 = value24.ToString();
            txtValue24.Text = myBin.Value24;
        }
        private void chKWithSWLL_CheckedChanged(object sender, EventArgs e)
        {
            value24 = int.Parse(txtValue24.Text);
            if (chKWithSWLL.Checked)

            { AppGlobal.SetBit(ref value24, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value24, (byte)4); }

            myBin.Value24 = value24.ToString();
            txtValue24.Text = myBin.Value24;
        }
        private void chkNoOverrideLLIfEmpty_CheckedChanged(object sender, EventArgs e)
        {
            value24 = int.Parse(txtValue24.Text);
            if (chkNoOverrideLLIfEmpty.Checked)

            { AppGlobal.SetBit(ref value24, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value24, (byte)3); }

            myBin.Value24 = value24.ToString();
            txtValue24.Text = myBin.Value24;
        }
        private void chkReadHighLevel_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkReadHighLevel.Checked)

            { AppGlobal.SetBit(ref value31, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)0); }

            myBin.Value31 = value31.ToString();
            txtValue31.Text = myBin.Value31;
        }
        private void chkReadRefillLevel_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkReadRefillLevel.Checked)

            { AppGlobal.SetBit(ref value31, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)1); }

            myBin.Value31 = value31.ToString();
            txtValue31.Text = myBin.Value31;
        }
        private void chkReadLowLevel_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkReadLowLevel.Checked)

            { AppGlobal.SetBit(ref value31, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)2); }

            myBin.Value31 = value31.ToString();
            txtValue31.Text = myBin.Value31;
        }
        private void chkReadInFillLevel_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkReadInFillLevel.Checked)

            { AppGlobal.SetBit(ref value31, (byte)3); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)3); }

            myBin.Value31 = value31.ToString();
            txtValue31.Text = myBin.Value31;
        }
        private void chkReadInOutEmpty_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkReadInOutEmpty.Checked)

            { AppGlobal.SetBit(ref value31, (byte)4); }

            else
            { AppGlobal.ClearBit(ref value31, (byte)4); }

            myBin.Value31 = value31.ToString();
            txtValue31.Text = myBin.Value31;
        }
        private void chkTestRefillLevel_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkTestRefillLevel.Checked)

            { AppGlobal.SetBit(ref value30, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)0); }

            myBin.Value30 = value30.ToString();
            txtValue30.Text = myBin.Value30;
        }
        private void chkEmptyLevel_CheckedChanged(object sender, EventArgs e)
        {
            value30 = int.Parse(txtValue30.Text);
            if (chkEmptyLevel.Checked)

            { AppGlobal.SetBit(ref value30, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value30, (byte)1); }

            myBin.Value30 = value30.ToString();
            txtValue30.Text = myBin.Value30;
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
  
        private void txtEmptyingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }

        private void txtBinNo_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value1";
        }

        private void txtOverFillingWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void txtDryFillingWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }
     
        private void txtRestdischargeWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }
        private void txtHighLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value2";
        }
        private void txtMiddleLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value4";
        }
        private void txtLowLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value3";
        }
        private void txtAnalogLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value14";
        }
        private void txtRemoteHighLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value41";
        }
        private void txtRemoteMiddleLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value42";
        }
        private void txtRemoteLowLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value43";
        }
        private void txtRemoteAnalogLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value44";
        }
        private void chkLLisBelowBin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24.Bit0";
        }
        private void chkRestdischarge_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24.Bit1";
        }
        private void chkWithLL_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24.Bit2";
        }
        private void chKWithSWLL_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24.Bit4";
        }
        private void chkNoOverrideLLIfEmpty_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24.Bit3";
        }
        private void chkReadHighLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit0";
        }
        private void chkReadRefillLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit1";
        }
        private void chkReadLowLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit2";
        }
        private void chkReadInFillLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit3";
        }
        private void chkReadInOutEmpty_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit4";
        }
        private void chkTestRefillLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit0";
        }
        private void chkEmptyLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30.Bit1";
        }
        void SubTypeChanged(string subType)
        {

        }
        void GetValue24BitValue(int value)
        {
            chkLLisBelowBin.Checked = AppGlobal.GetBitValue(value, 0);
            chkRestdischarge.Checked = AppGlobal.GetBitValue(value, 1);
            chkWithLL.Checked = AppGlobal.GetBitValue(value, 2);
            chKWithSWLL.Checked = AppGlobal.GetBitValue(value, 4);
            chkNoOverrideLLIfEmpty.Checked = AppGlobal.GetBitValue(value, 3);
        }
        void GetValue30BitValue(int value)
        {
            chkTestRefillLevel.Checked = AppGlobal.GetBitValue(value, 0);
            chkEmptyLevel.Checked = AppGlobal.GetBitValue(value, 0);
        }
        void GetValue31BitValue(int value)
        {
            chkReadHighLevel.Checked = AppGlobal.GetBitValue(value, 0);
            chkReadInFillLevel.Checked = AppGlobal.GetBitValue(value, 1);
            chkReadLowLevel.Checked = AppGlobal.GetBitValue(value, 2);
            chkReadInFillLevel.Checked = AppGlobal.GetBitValue(value, 3);
            chkReadInOutEmpty.Checked = AppGlobal.GetBitValue(value, 4);
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myBin.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SubTypeChanged(myBin.SubType);
                //GetValue24BitValue(value24);
                //GetValue30BitValue(value30);
                //GetValue30BitValue(value31);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion<------Field in database display
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
           // LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.DI.Path", BML.DI.BMLPath);
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
        private void CreateBMLDefault()
        {
            btnReadBML.Enabled = false;
            var alphabetList = AppGlobal.CreateAlphabetList<string>('A', 'Z', letter => letter.ToString());
            foreach (var item in alphabetList)
            {
                //comboNameBML.Items.Add(item);
                //comboDescBML.Items.Add(item);
                //comboTypeBML.Items.Add(item);
                //comboFloorBML.Items.Add(item);
                //comboSectionBML.Items.Add(item);
                //comboCabinetBML.Items.Add(item);
                //comboControlBML.Items.Add(item);
                //comboIORemarkBML.Items.Add(item);
                //comboLineBML.Items.Add(item);
                //comboNameBML.SelectedItem = "B";
                //comboDescBML.SelectedItem = "N";
                //comboTypeBML.SelectedItem = "C";
                //comboFloorBML.SelectedItem = "L";
                //comboCabinetBML.SelectedItem = "P";
                //comboSectionBML.SelectedItem = "Q";
                //comboControlBML.SelectedItem = "H";
                //comboIORemarkBML.SelectedItem = "R";
                //comboLineBML.SelectedItem = "X";
            }
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            //TxtExcelPath.Text = BML.Bin.BMLPath;
            //DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            //nameColumn.HeaderText = BML.DI.ColumnName;
            //nameColumn.Name = nameof(BML.DI.ColumnName);
            //dataGridBML.Columns.Add(nameColumn);

            //DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            //descColumn.HeaderText = BML.DI.ColumnDesc;
            //descColumn.Name = nameof(BML.DI.ColumnDesc);
            //dataGridBML.Columns.Add(descColumn);

            //DataGridViewTextBoxColumn diTypeColumn = new DataGridViewTextBoxColumn();
            //diTypeColumn.HeaderText = BML.DI.ColumnDIType;
            //diTypeColumn.Name = nameof(BML.DI.ColumnDIType);
            //dataGridBML.Columns.Add(diTypeColumn);

            //DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            //floorColumn.HeaderText = BML.DI.ColumnFloor;
            //floorColumn.Name = nameof(BML.DI.ColumnFloor);
            //dataGridBML.Columns.Add(floorColumn);

            //DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            //cabinetColumn.HeaderText = BML.DI.ColumnCabinet;
            //cabinetColumn.Name = nameof(BML.DI.ColumnCabinet);
            //dataGridBML.Columns.Add(cabinetColumn);

            //DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            //cabinetColumnGroup.HeaderText = BML.DI.ColumnCabinetGroup;
            //cabinetColumnGroup.Name = nameof(BML.DI.ColumnCabinetGroup);
            //dataGridBML.Columns.Add(cabinetColumnGroup);

            //DataGridViewTextBoxColumn ioRemarkColumn = new DataGridViewTextBoxColumn();
            //ioRemarkColumn.HeaderText = BML.DI.ColumnIORemark;
            //ioRemarkColumn.Name = nameof(BML.DI.ColumnIORemark);
            //dataGridBML.Columns.Add(ioRemarkColumn);

            //DataGridViewTextBoxColumn lineColumn = new DataGridViewTextBoxColumn();
            //lineColumn.HeaderText = BML.DI.ColumnLine;
            //lineColumn.Name = nameof(BML.DI.ColumnLine);
            //dataGridBML.Columns.Add(lineColumn);

        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            return;
           // string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboTypeBML.Text,comboFloorBML.Text,
           //     comboCabinetBML.Text ,comboSectionBML.Text,comboIORemarkBML.Text,comboLineBML.Text};
           // StringBuilder sbFilters = new StringBuilder();
           // sbFilters.Append($@"Value LIKE ""%{BML.DI.BeltMonitor}"" || ").Append($@"Value LIKE ""%{BML.DI.EmergencyStop}"" || ").Append($@"Value LIKE ""%{BML.DI.Explosion}"" || ")
           //      .Append($@"Value LIKE ""%{BML.DI.HighLevel}"" || ").Append($@"Value LIKE ""%{BML.DI.LimitSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.LowLevel}"" || ")
           //      .Append($@"Value LIKE ""%{BML.DI.MiddleLevel}"" || ").Append($@"Value LIKE ""%{BML.DI.Overflow}"" ||").Append($@"Value LIKE ""%{BML.DI.PSw}"" || ")
           //      .Append($@"Value LIKE ""%{BML.DI.PushButton}"" || ").Append($@"Value LIKE ""%{BML.DI.SafetySwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.SpeedMonitor}"" || ")
           //      .Append($@"Value LIKE ""%{BML.DI.TemperatureSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.VibrationSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.ZeroSpeedMonitor}""");
           // StringBuilder sbValveFilters = new StringBuilder();
           // sbValveFilters.Append($@"Value NOT LIKE ""%{BML.VLS.ManualFlap}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneFlap}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneTwoWayValve}"" && ")
           //.Append($@"Value NOT LIKE ""%{BML.VLS.PneSlideGate}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.ManualSlideGate}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneShutOffValve}"" && ")
           //.Append($@"Value NOT LIKE ""%{BML.VLS.PneAspValve}""");
           // DataTable dataTable = new DataTable();
           // string[] filters = { sbFilters.ToString(), sbValveFilters.ToString() };
           // string[] filterColumns = { comboTypeBML.Text, comboDescBML.Text };
           // dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);

           // dataGridBML.DataSource = dataTable;
           // dataGridBML.AutoGenerateColumns = false;
           // dataGridBML.Columns[nameof(BML.DI.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
           // dataGridBML.Columns[nameof(BML.DI.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
           // dataGridBML.Columns[nameof(BML.DI.ColumnDIType)].DataPropertyName = dataTable.Columns[2].ColumnName;
           // dataGridBML.Columns[nameof(BML.DI.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
           // dataGridBML.Columns[nameof(BML.DI.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
           // dataGridBML.Columns[nameof(BML.DI.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
           // dataGridBML.Columns[nameof(BML.DI.ColumnIORemark)].DataPropertyName = dataTable.Columns[6].ColumnName;
           // dataGridBML.Columns[nameof(BML.DI.ColumnLine)].DataPropertyName = dataTable.Columns[7].ColumnName;
           // TxtQuantity.Text = dataTable.Rows.Count.ToString();
        }
        #endregion
        #region Common used
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                txtSymbolRule.Text = Bin.Rule.Common.NameRule;
                txtSymbolIncRule.Text = Bin.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_BIN;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = Bin.Rule.Common.NameRule;
                txtSymbolIncRule.Text = Bin.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                GrpSymbolRule.Visible = false;
                LblSymbol.Text = AppGlobal.KEY_WORD_AUTOSEARCH;
                txtSymbol.Text = "BIN100";
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
        private void btnConnectChild_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(AppGlobal.CONNECT_CONNECTOR, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                RuleSubDataSet highLevel = new RuleSubDataSet
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
                RuleSubDataSet lowLevel = new RuleSubDataSet
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
                RuleSubDataSet middleLevel = new RuleSubDataSet
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
                RuleSubDataSet analogLevel = new RuleSubDataSet
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
                bool connectLLWithDesc, connectHLWithDesc, connectMLWithDesc, connectALWithDesc;
                connectLLWithDesc = string.IsNullOrEmpty(txtLowLevel.Text);
                connectHLWithDesc = string.IsNullOrEmpty(txtHighLevel.Text);
                connectMLWithDesc = string.IsNullOrEmpty(txtMiddleLevel.Text);
                connectALWithDesc = string.IsNullOrEmpty(txtAnalogLevel.Text);
                try
                {
                    bool all = !chkOnlyFree.Checked;
                    List<(string name, string desc, double binNo,double value2, double value3, double value4, double value14) > binList = new List<(string, string,double, double, double, double, double)>();
                  //  List<Dictionary<string, double>> binListD = new List<Dictionary<string, double>>();
                    List<Dictionary<string, string>> binLLList = new List<Dictionary<string, string>>();
                    List<Dictionary<string, string>> binHLList = new List<Dictionary<string, string>> ();
                   // List<Dictionary<string, string>> binMLList = new List<Dictionary<string, string>>();
                 //   List<Dictionary<string, string>> binALList = new List<Dictionary<string, string>>();
                    OleDb oledb = new OleDb();
                    DataTable dataTable = new DataTable();
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;                  
                    if (connectLLWithDesc)
                    {
                        dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name} = {DI.OTypeValue} AND {GcproTable.ObjData.SubType.Name } = '{DI.LLBIN}'",
                            null, $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
                        binLLList = OleDb.GetColumnsData<string>(dataTable, GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
                    }
                    if (connectHLWithDesc)
                    {
                        dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name} = {DI.OTypeValue} AND {GcproTable.ObjData.SubType.Name} = '{DI.HLBIN}'",
                            null, $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
                        binHLList = OleDb.GetColumnsData<string>(dataTable, GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
                    }
                    //if (connectMLWithDesc)
                    //{
                    //    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name} = {DI.OTypeValue} AND ({GcproTable.ObjData.SubType.Name} = '{DI.HLBIN}'" +
                    //         $"OR {GcproTable.ObjData.SubType.Name} = '{DI.LLBIN}')", null, $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);

                    //    binMLList = OleDb.GetColumnsData<string>(dataTable, GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
                    //}
                    //if (connectALWithDesc)
                    //{
                    //    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name} = {AI.OTypeValue} ",
                    //        null, $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
                    //    binALList = OleDb.GetColumnsData<string>(dataTable, GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name);
                    //}
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={Bin.OTypeValue}", null,
                   $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name, GcproTable.ObjData.Value1.Name,
                   GcproTable.ObjData.Value2.Name, GcproTable.ObjData.Value3.Name, GcproTable.ObjData.Value4.Name, GcproTable.ObjData.Value14.Name);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        binList.Add((row.Field<string>(GcproTable.ObjData.Text0.Name), row.Field<string>(GcproTable.ObjData.Text1.Name), row.Field<double>(GcproTable.ObjData.Value1.Name),
                            row.Field<double>(GcproTable.ObjData.Value2.Name), row.Field<double>(GcproTable.ObjData.Value3.Name), row.Field<double>(GcproTable.ObjData.Value4.Name),
                            row.Field<double>(GcproTable.ObjData.Value14.Name)));
                    }
                    ProgressBar.Maximum = binList.Count - 1;
                    ProgressBar.Value = 0;
                    Bin.Clear(myBin.FileConnectorPath);
                    for (var count = 0; count <= binList.Count - 1; count++)
                    {
                        string binName = binList[count].name;
                        string binDesc = binList[count].desc;
                        binDesc = binDesc.Contains(GcObjectInfo.Bin.IdentDescSeparator) ? GetBinIdentPrefix(binDesc) : string.Empty;
                        string binNo = binList[count].binNo.ToString();

                        dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Key.Name}={binList[count].value2}", null,
                            null, GcproTable.ObjData.Value11.Name);
                        bool needCreateHLRel = dataTable.Rows.Count == 0 ? false : (dataTable.Rows[0].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all);

                        //dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Key.Name}={binList[count].value4}", null,
                        //null, GcproTable.ObjData.Value11.Name);
                       // bool needCreateMLRel = dataTable.Rows.Count == 0 ? false : (dataTable.Rows[0].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all);

                        dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Key.Name}={binList[count].value3}", null,
                                 null, GcproTable.ObjData.Value11.Name);
                        bool needCreateLLRel = dataTable.Rows.Count == 0 ? false : (dataTable.Rows[0].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all);

                        //dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Key.Name}={binList[count].value14}", null,
                        //   null, GcproTable.ObjData.Value11.Name);
                        //bool needCreateALRel = dataTable.Rows.Count == 0? false:(dataTable.Rows[0].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all);

                        if (connectHLWithDesc)
                        {
                           
                            var descOfThisBin = binHLList
                                 .Where(dict => dict["Text1"].Contains(binNo) || (dict["Text1"].Contains(binDesc) && !string.IsNullOrEmpty(dict["Text1"])))
                                 .Select(dict => dict["Text0"])
                                 .Where(value => value != null)
                                 .ToList();
                            if (descOfThisBin.Count >= 1 && needCreateHLRel)
                            {
                                highLevel.Name = descOfThisBin[0];
                                Bin.CreateRelation(binName, highLevel.Name, GcproTable.ObjData.Value2.Name, myBin.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else
                        {
                            if (needCreateHLRel)
                            {
                                Bin.CreateRelation(binName, highLevel.Name, GcproTable.ObjData.Value2.Name, myBin.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        //if (connectMLWithDesc)
                        //{
                        //    var descOfThisBin = binMLList
                        //          .Where(dict => dict["Text1"].Contains(binNo) || (dict["Text1"].Contains(binDesc) && !string.IsNullOrEmpty(dict["Text1"])))
                        //         .Select(dict => dict["Text0"])
                        //         .Where(value => value != null)
                        //         .ToList();
                        //    if (descOfThisBin.Count >= 1)
                        //    {
                        //        middleLevel.Name = descOfThisBin[0];
                        //        Bin.CreateRelation(binName, middleLevel.Name, GcproTable.ObjData.Value4.Name, myBin.FileConnectorPath, Encoding.Unicode);
                        //    }
                        //}
                        //else
                        //{
                        //    if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value4.Name) == 0 || all)
                        //    {
                        //        Bin.CreateRelation(binName, highLevel.Name, GcproTable.ObjData.Value4.Name, myBin.FileConnectorPath, Encoding.Unicode);
                        //    }
                        //}
                        if (connectLLWithDesc)
                        {
                            var descOfThisBin = binLLList
                                 .Where(dict => dict["Text1"].Contains(binNo) || (dict["Text1"].Contains(binDesc) && !string.IsNullOrEmpty(dict["Text1"])))
                                 .Select(dict => dict["Text0"])
                                 .Where(value => value != null)
                                 .ToList();
                            if (descOfThisBin.Count >= 1 && needCreateLLRel)
                            {
                                lowLevel.Name = descOfThisBin[0];
                                Bin.CreateRelation(binName, lowLevel.Name, GcproTable.ObjData.Value3.Name, myBin.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else
                        {
                            if (needCreateLLRel)
                            {
                                Bin.CreateRelation(binName ,lowLevel.Name, GcproTable.ObjData.Value3.Name, myBin.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        //if (connectALWithDesc)
                        //{
                        //    var descOfThisBin = binALList
                        //         .Where(dict => dict["Text1"].Contains(binNo) || (dict["Text1"].Contains(binDesc) && !string.IsNullOrEmpty(dict["Text1"])))
                        //         .Select(dict => dict["Text0"])
                        //         .Where(value => value != null)
                        //         .ToList();
                        //    if (descOfThisBin.Count >= 1 && needCreateALRel)
                        //    {
                        //        analogLevel.Name = descOfThisBin[0];
                        //        Bin.CreateRelation(binName, analogLevel.Name, GcproTable.ObjData.Value14.Name, myBin.FileConnectorPath, Encoding.Unicode);
                        //    }
                        //}
                        //else
                        //{
                        //    if (needCreateALRel)
                        //    {
                        //        Bin.CreateRelation(binName, analogLevel.Name, GcproTable.ObjData.Value14.Name, myBin.FileConnectorPath, Encoding.Unicode);
                        //    }
                        //}
                        ProgressBar.Value = count;
                    }
                      Bin.SaveFileAs(myBin.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
                    ProgressBar.Value = ProgressBar.Maximum;
                    dataTable.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("寻找料位与关联过程出错:" + ex, AppGlobal.INFO + ":" + AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_CLEAR_FILE, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)

            {
                myBin.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            Bin.SaveFileAs(myBin.FilePath, LibGlobalSource.CREATE_OBJECT);
            Bin.SaveFileAs(myBin.FileRelationPath, LibGlobalSource.CREATE_RELATION);
        }
        private void BtnNewImpExpDef_Click(object sender, EventArgs e)
        {
            CreateImpExp();
        }
        //void AppendInfoToBuilder(CheckBox checkBox, string info, StringBuilder builder)
        //{
        //    if (checkBox.Checked)
        //    {
        //        builder.Append(info);
        //    }
        //}
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                OleDb oledb = new OleDb();
                //  DataTable dataTable = new DataTable();
                #region common used variables declaration       
                StringBuilder descTotalBuilder = new StringBuilder();
                int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                bool moreThanOne = quantityNeedToBeCreate > 1;
                bool onlyOne = quantityNeedToBeCreate == 1;
                int binNo = 0;
                string descTotal = txtDescription.Text;
                RuleSubDataSet description, name, descPrefix, highLevel, lowLevel, middleLevel, analogLevel;
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
                descPrefix = new RuleSubDataSet
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
                highLevel = new RuleSubDataSet
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
                lowLevel = new RuleSubDataSet
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
                middleLevel = new RuleSubDataSet
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
                analogLevel = new RuleSubDataSet
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
                #region Prepare export bin file
                ///<OType>is set when object generated</OType>
                ///<SubType></SubType>
                string selectedSubTypeItem;
                if (ComboEquipmentSubType.SelectedItem != null)
                {
                    selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                    myBin.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

                }
                else
                {
                    myBin.SubType = Bin.BINB;
                }
                ///<ParEmptyingTime></ParEmptyingTime
                myBin.ParEmptyingTime = AppGlobal.ParseInt(txtEmptyingTime.Text, out tempInt) ? (tempInt).ToString("F0") : "0";
                ///<ParOverfillingWeight></ParOverfillingWeight>
                myBin.ParOverfillingWeight = AppGlobal.ParseInt(txtOverFillingWeight.Text, out tempInt) ? (tempInt).ToString("F0") : "100";
                ///<ParDryFillingWeight></ParDryFillingWeight>
                myBin.ParDryFillingWeight = AppGlobal.ParseInt(txtDryFillingWeight.Text, out tempInt) ? (tempInt).ToString("F0") : "0";
                ///<ParRestdischargeWeight></ParRestdischargeWeight>
                myBin.ParRestdischargeWeight = AppGlobal.ParseInt(txtRestdischargeWeight.Text, out tempInt) ? (tempInt).ToString("F0") : "0";
                ///<ParBinNo>Value is set when corresponding check box's check state changed</ParBinNo>
                tempBool = AppGlobal.ParseInt(txtBinNo.Text, out binNo);
                ///<value31>Value is set when corresponding check box's check state changed</value31>
                ///<Value30>Value is set when corresponding check box's check state changed</Value30>
                ///<Value24>Value is set when corresponding check box's check state changed</Value24>
                ///<Name>Value is set in TxtSymbol text changed event</Name>   
                ///<ProcessFct></ProcessFct>
                string selectedProcessFct = string.Empty;
                if (ComboProcessFct.SelectedItem != null)
                {
                    selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                    myBin.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Diagram></Diagram>
                string selectedDiagram;
                if (ComboDiagram.SelectedItem != null)
                {
                    selectedDiagram = ComboDiagram.SelectedItem.ToString();
                    myBin.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Page></Page>
                myBin.Page = txtPage.Text;
                ///<Building></Building>
                string selectedBudling = "--";
                if (ComboBuilding.SelectedItem != null)
                {
                    selectedBudling = ComboBuilding.SelectedItem.ToString();
                    myBin.Building = selectedBudling;
                }
                ///<Elevation></Elevation>
                string selectedElevation;
                if (ComboElevation.SelectedItem != null)
                {
                    selectedElevation = ComboElevation.SelectedItem.ToString();
                    myBin.Elevation = selectedElevation;
                }
                ///<Panel_ID></Panel_ID>
                string selectedPanel_ID;
                if (ComboPanel.SelectedItem != null)
                {
                    selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                    myBin.Panel_ID = selectedPanel_ID;
                }
                ///<IsNew>is set when object generated,Default value is "No"</IsNew>       
                ///<HighLevel></HighLevel>
                myBin.HighLevel = string.Empty;
                ///<MiddleLevel></MiddleLevel>
                myBin.MiddleLevel = string.Empty;
                ///<LowLevel></LowLevel>
                myBin.LowLevel = string.Empty;
                ///<AnalogLevel ></AnalogLevel >
                myBin.AnalogLevel = string.Empty;
                ///<HighLevelRemote></HighLevelRemote>
                myBin.HighLevelRemote = txtRemoteHighLevel.Text;
                ///<MiddleLevelRemote></MiddleLevelRemote>
                myBin.MiddleLevelRemote = txtRemoteMiddleLevel.Text;
                ///<LowLevelRemote></LowLevelRemote>
                myBin.LowLevelRemote = txtRemoteLowLevel.Text;
                ///<InFillLevel ></InFillLevel>
                myBin.InFillLevel= txtInFillLevel.Text;
                #endregion
                if (createMode.BML)
                {

                }
                else if (createMode.AutoSearch)
                {

                }
                else if (createMode.Rule)
                {
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
                    ///<DescRule>生成描述规则</DescRule>
                    if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
                    {
                        description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(descPart, txtDescriptionRule.Text);
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
                            description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(descPart, txtDescriptionRule.Text);
                        }

                        ///<DescPrefixRule>生成描述规则</DescPrefixRule>
                        if (!String.IsNullOrEmpty(descPrefixPart))
                        {
                            descPrefix.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(descPrefixPart, descPrefixRule);
                            if (descPrefix.PosInfo.Len == -1)
                            {
                                if (moreThanOne)
                                {
                                    AppGlobal.RuleNotSetCorrect($"{GrpDescriptionRule.Text}.{descPrefixRule}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                                    // return;
                                }
                            }
                            else
                            {
                                descPrefix.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(descPrefixPart, descPrefixRule);
                            }
                        }
                    }
                    ///<HighLevel>高料位</HighLevel>
                    chkReadHighLevel.Checked = String.IsNullOrEmpty(txtHighLevel.Text) ? false : true;
                    if (!String.IsNullOrEmpty(txtHighLevel.Text))
                    {
                        highLevel.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtHighLevel.Text, txtHighLevelRule.Text);
                        if (highLevel.PosInfo.Len == -1)
                        {
                            if (moreThanOne)
                            {
                                AppGlobal.RuleNotSetCorrect($"{txtHighLevel.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                            }
                        }
                        else
                        {
                            highLevel.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtHighLevel.Text, txtHighLevelRule.Text);
                        }
                    }
                    ///<MiddleLevel>中料位</MiddleLevel>
                    chkReadRefillLevel.Checked = String.IsNullOrEmpty(txtMiddleLevel.Text) ? false : true;
                    if (!String.IsNullOrEmpty(txtMiddleLevel.Text))
                    {
                        middleLevel.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtMiddleLevel.Text, txtMiddleLevelRule.Text);
                        if (middleLevel.PosInfo.Len == -1)
                        {
                            if (moreThanOne)
                            {
                                AppGlobal.RuleNotSetCorrect($"{txtMiddleLevel.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                            }
                        }
                        else
                        {
                            middleLevel.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtMiddleLevel.Text, txtMiddleLevelRule.Text);
                        }
                    }
                    ///<LowLevel>低料位</LowLevel>
                    chkWithLL.Checked = chkReadLowLevel.Checked = String.IsNullOrEmpty(txtLowLevel.Text) ? false : true;
                    if (!String.IsNullOrEmpty(txtLowLevel.Text))
                    {
                        lowLevel.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtLowLevel.Text, txtLowLevelRule.Text);
                        if (lowLevel.PosInfo.Len == -1)
                        {
                            if (moreThanOne)
                            {
                                AppGlobal.RuleNotSetCorrect($"{txtLowLevel.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                            }
                        }
                        else
                        {
                            lowLevel.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtLowLevel.Text, txtLowLevelRule.Text);
                        }
                    }
                    ///<AnalogLevel>模拟量料位</AnalogLevel>
                    chkReadInFillLevel.Checked = String.IsNullOrEmpty(txtAnalogLevel.Text) ? false : true;
                    if (!String.IsNullOrEmpty(txtAnalogLevel.Text))
                    {
                        analogLevel.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtAnalogLevel.Text, txtAnalogLevelRule.Text);
                        if (analogLevel.PosInfo.Len == -1)
                        {
                            if (moreThanOne)
                            {
                                AppGlobal.RuleNotSetCorrect($"{txtAnalogLevel.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                            }
                        }
                        else
                        {
                            analogLevel.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtAnalogLevel.Text, txtAnalogLevelRule.Text);
                        }

                    }
                    #endregion
                    ProgressBar.Maximum = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt - 1 : 1;
                    ProgressBar.Value = 0;
                    ///<CreateObj>
                    ///</CreateObj>
                    int symbolInc, symbolRule, descriptionInc;
                    tempBool = AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
                    tempBool = AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
                    tempBool = AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
                    for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
                    {
                        name.Inc = i * symbolInc;
                        name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));

                        if (!String.IsNullOrEmpty(descPrefixPart))
                        {
                            if (descPrefix.PosInfo.Len != -1)
                            {
                                descPrefix.Inc = name.Inc;
                                descPrefix.Name = LibGlobalSource.StringHelper.GenerateObjectName(descPrefix.Sub, descPrefix.PosInfo, (int.Parse(descPrefixRule) + descPrefix.Inc).ToString().PadLeft(descPrefix.PosInfo.Len, '0'));
                            }
                            else
                            {
                                descPrefix.Name = descPrefixPart;
                            }

                        }
                        else
                        {
                            descPrefix.Name = "";
                        }
                        if (!String.IsNullOrEmpty(descPart))
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
                                description.Name = descPart;
                            }

                        }
                        else
                        {
                            description.Name = "仓";
                        }
                        if (!String.IsNullOrEmpty(txtHighLevel.Text))
                        {

                            if (!String.IsNullOrEmpty(txtHighLevelIncRule.Text) && !String.IsNullOrEmpty(txtHighLevelRule.Text)
                                && AppGlobal.CheckNumericString(txtHighLevelIncRule.Text) && AppGlobal.CheckNumericString(txtHighLevelIncRule.Text)
                                && (highLevel.PosInfo.Len != -1))
                            {
                                int highInc;
                                tempBool = AppGlobal.ParseInt(txtHighLevelIncRule.Text, out highInc);
                                highLevel.Inc = i * highInc;
                                highLevel.Name = LibGlobalSource.StringHelper.GenerateObjectName(highLevel.Sub, highLevel.PosInfo, (int.Parse(txtHighLevelRule.Text) + highLevel.Inc).ToString());
                            }
                            else
                            {
                                highLevel.Name = txtHighLevel.Text;
                            }

                        }
                        if (!String.IsNullOrEmpty(txtLowLevel.Text))
                        {

                            if (!String.IsNullOrEmpty(txtLowLevelIncRule.Text) && !String.IsNullOrEmpty(txtLowLevelRule.Text)
                                && AppGlobal.CheckNumericString(txtLowLevelIncRule.Text) && AppGlobal.CheckNumericString(txtLowLevelIncRule.Text)
                                && (lowLevel.PosInfo.Len != -1))
                            {
                                int lowInc;
                                tempBool = AppGlobal.ParseInt(txtLowLevelIncRule.Text, out lowInc);
                                lowLevel.Inc = i * lowInc;
                                lowLevel.Name = LibGlobalSource.StringHelper.GenerateObjectName(lowLevel.Sub, lowLevel.PosInfo, (int.Parse(txtLowLevelRule.Text) + lowLevel.Inc).ToString());
                            }
                            else
                            {
                                lowLevel.Name = txtLowLevel.Text;
                            }

                        }
                        if (!String.IsNullOrEmpty(txtMiddleLevel.Text))
                        {

                            if (!String.IsNullOrEmpty(txtMiddleLevelIncRule.Text) && !String.IsNullOrEmpty(txtMiddleLevelRule.Text)
                                && AppGlobal.CheckNumericString(txtMiddleLevelIncRule.Text) && AppGlobal.CheckNumericString(txtMiddleLevelIncRule.Text)
                                && (middleLevel.PosInfo.Len != -1))
                            {
                                int middleInc;
                                tempBool = AppGlobal.ParseInt(txtMiddleLevelIncRule.Text, out middleInc);
                                middleLevel.Inc = i * middleInc;
                                middleLevel.Name = LibGlobalSource.StringHelper.GenerateObjectName(middleLevel.Sub, middleLevel.PosInfo, (int.Parse(txtMiddleLevelRule.Text) + middleLevel.Inc).ToString());
                            }
                            else
                            {
                                middleLevel.Name = txtMiddleLevel.Text;
                            }

                        }
                        if (!String.IsNullOrEmpty(txtAnalogLevel.Text))
                        {

                            if (!String.IsNullOrEmpty(txtAnalogLevelIncRule.Text) && !String.IsNullOrEmpty(txtAnalogLevelRule.Text)
                                && AppGlobal.CheckNumericString(txtAnalogLevelIncRule.Text) && AppGlobal.CheckNumericString(txtAnalogLevelIncRule.Text)
                                && (analogLevel.PosInfo.Len != -1))
                            {
                                int analogInc;
                                tempBool = AppGlobal.ParseInt(txtAnalogLevelIncRule.Text, out analogInc);
                                analogLevel.Inc = i * analogInc;
                                analogLevel.Name = LibGlobalSource.StringHelper.GenerateObjectName(analogLevel.Sub, analogLevel.PosInfo, (int.Parse(txtAnalogLevelRule.Text) + analogLevel.Inc).ToString());
                            }
                            else
                            {
                                analogLevel.Name = txtAnalogLevel.Text;
                            }
                        }
                        descTotal = descPrefix.Name + description.Name;
                        myBin.Name = name.Name;
                        myBin.Description = descTotal;
                        myBin.ParBinNo = (binNo + name.Inc).ToString();
                        myBin.HighLevel = highLevel.Name;
                        myBin.MiddleLevel = middleLevel.Name;
                        myBin.LowLevel = lowLevel.Name;
                        myBin.AnalogLevel = analogLevel.Name;
                        myBin.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = i;
                    }
                    ProgressBar.Value = ProgressBar.Maximum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建对象过程出错:" + ex, AppGlobal.AppInfo.Title + ":" + AppGlobal.MSG_CREATE_WILL_TERMINATE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}