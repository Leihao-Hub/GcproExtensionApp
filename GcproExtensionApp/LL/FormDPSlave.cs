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
using System.Linq;
using System.Text.RegularExpressions;
#endregion
namespace GcproExtensionApp
{
    public partial class FormDPSlave : Form, IGcForm
    {
        public FormDPSlave()
        {
            InitializeComponent();
        }

        #region Public object in this class
        DPSlave myDPSlave = new DPSlave(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private string DEMO_NAME_DPSlave = "=A-4001-MXZ03U1";
        private string DEMO_NAME_RULE_DPSlave = "4001";
        private string DEMO_DESCRIPTION_DPSlave = "4001磨机喂料辊";
        private string DEMO_DESCRIPTION_RULE_DPSlave = "";
        #endregion
  
       // private int value10 = 0;
        private int value31 = 0;
        private int tempInt = 0;
        private (string ipAddrPrevSegment, string ipRule) ip;
        // private long tempLong = 0;
        //  private float tempFloat = 0.0f;
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
            ///<ReaFromGcsLibrary> 
            ///Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary 
            ///</ReafoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={DPSlave.OTypeValue}",
                null, $"{GcproTable.SubType.FieldSub_Type_Desc.Name} ASC",
                GcproTable.SubType.FieldSubType.Name, GcproTable.SubType.FieldSub_Type_Desc.Name);
            // List<string> list = OleDb.GetColumnData<string>(dataTable, "SubType");

            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.SubType.TableName) + AppGlobal.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>($"{GcproTable.SubType.FieldSub_Type_Desc.Name}");
                ComboEquipmentSubType.Items.Add(itemInfo);

            }
          
            ComboEquipmentSubType.SelectedIndex = 2;
            ///<ProcessFct> Read [ProcessFct] </ProcessFct>
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {DPSlave.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + DPSlave.OTypeValue}'",
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

                ComboHornCode.Items.Add(column.ToString());
            }
            ComboHornCode.SelectedIndex = 0;      
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
            txtSymbolRule.Text = DPSlave.Rule.Common.NameRule;
            txtSymbolIncRule.Text = DPSlave.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = DPSlave.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = DPSlave.Rule.Common.DescriptionRuleInc;
            txtIPAddressIncRule.Text = DPSlave.Rule.IPAddressInc;
            txtParSlaveNoIncRule.Text = DPSlave.Rule.SlaveNoInc;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + DPSlave.OType);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_DPSlave);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_DPSlave);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_DPSlave);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_DPSlave);
            toolTip.SetToolTip(BtnRegenerateDPNode, AppGlobal.MSG_REGENERATE_DPNODE);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;          
            dataTable=oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{DPSlave.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);         
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{DPSlave.ImpExpRuleName}'", null);
                    CreateDPSlaveImpExp(oledb);
                }
                else
                { 
                    return; 
                }
            }
            else
            { 
                CreateDPSlaveImpExp(oledb); 
            }

        }
        public void Default()
        {
            txtSymbol.Focus();     
         
            txtIPAddress.Text = myDPSlave.IPAddr;
            txtParSlaveNo.Text = myDPSlave.SlaveNo.ToString();
            txtWatchDogFactor.Text = myDPSlave.WatchDogFactor.ToString();
            txtUpdateTime.Text = myDPSlave.UpdateTime.ToString();

            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
          //ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            txtValue31.Text = "0";
            
            ComboEquipmentSubType.SelectedIndex = 2;       
            var e = new KeyEventArgs(Keys.Enter);
            txtIPAddress_KeyDown(txtIPAddress, e);
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "DPSlave导入文件 " + " " + myDPSlave.FilePath;         
        }

        #endregion
        private void CreateDPSlaveImpExp(OleDb oledb)
        {
            bool result = myDPSlave.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormDPSlave_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormDPSlave_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>

        private (string,string) GetIPSegment(string ip)
        {
            if (string.IsNullOrEmpty(ip))
                return (string.Empty, string.Empty);

            int lastIndex = ip.LastIndexOf('.');
            if (lastIndex != -1 && lastIndex < ip.Length - 1)
            {
                return (ip.Remove(lastIndex +1),ip.Substring(lastIndex + 1));
            }
            return (string.Empty,string.Empty);
        }     
        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
          
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtDescription.Text, false);
        
        }
        private void txtIPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Regex.IsMatch(txtIPAddress.Text, AppGlobal.PATTERN_IP))
                {
                    ip = GetIPSegment(txtIPAddress.Text);
                   
                }
                else
                {
                    MessageBox.Show(AppGlobal.MSG_NOT_VALID_IP, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void txtIPAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtParSlaveNo_TextChanged(object sender, EventArgs e)
        {
            if (!AppGlobal.CheckNumericString(txtParSlaveNo.Text))
            {
                DPSlave.Rule.Common.NameRule = txtSymbolRule.Text;
                AppGlobal.MessageNotNumeric();
            }
        
        }
        private void txtParSlaveNoIncRule_TextChanged(object sender, EventArgs e)
        {
             if (AppGlobal.CheckNumericString(txtParSlaveNoIncRule.Text))
                {
                    DPSlave.Rule.SlaveNoInc = txtParSlaveNoIncRule.Text;                  
                }
             else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtIPAddressIncRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtIPAddressIncRule.Text))
            {
                DPSlave.Rule.IPAddressInc = txtIPAddressIncRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }
        }

        private void txtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                DPSlave.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    DPSlave.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
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
                DPSlave.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
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
                    DPSlave.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        #endregion
        #region <------ Check and unchek "Value31" and "Value10------>"    
    
        private void chkUpdateTimeManCalc_CheckedChanged(object sender, EventArgs e)
        {
            value31 = int.Parse(txtValue31.Text);
            if (chkUpdateTimeManCalc.Checked)

            { AppGlobal.SetBit(ref value31, (byte)0); }
            else
            { AppGlobal.ClearBit(ref value31, (byte)0); }
            myDPSlave.Value31 = value31.ToString();
            txtValue31.Text = myDPSlave.Value31;
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
        private void ComboHornCode_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value2";
        }
        private void ComboDPNode1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "DPNode1";
        }
        private void txtIPAddress_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Text6";
        }

        private void txtParSlaveNo_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "OIndex";
        }
        private void txtUpdateTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value32";
        }

        private void txtWatchDogFactor_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value33";
        }

        private void txtWatchDogTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value34";
        }
        private void chkUpdateTimeManCalc_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31.Bit0";
        }
        #endregion
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.OIndex.Name;
            objectBrowser.OType = Convert.ToString(DPSlave.OTypeValue);
            objectBrowser.Show();
        }
        void SubTypeChanged(string subType)
        {
            txtIPAddress.Enabled = subType != DPSlave.Profibus;
        }
    
        void GetValue31BitValue(long value)
        {
        
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myDPSlave.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SubTypeChanged(myDPSlave.SubType);
              
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
            BML.DPSlave.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_BML}.{AppGlobal.JS_DPSLAVE}.Path", BML.DPSlave.BMLPath);
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
           // AddWorkSheets();
        }
        private void comboWorkSheetsBML_SelectedIndexChanged(object sender, EventArgs e)
        {

            excelFileHandle.WorkSheet = comboWorkSheetsBML.SelectedItem.ToString();
            if (! String.IsNullOrEmpty(excelFileHandle.WorkSheet))
            {
                btnReadBML.Enabled= true;   
            }
        }
        private void dataGridBML_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dataGridBML.Refresh();
         
            TxtQuantity.Text = dataGridBML.Rows.Count.ToString();
        }
        private void chkUserDifinedExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUserDifinedExcel.Checked)
            {
                dataGridBML.Columns[nameof(BML.ColumnType)].HeaderText = BML.ColumnIPAddr;
                dataGridBML.Columns[nameof(BML.ColumnType)].Name = nameof(BML.ColumnIPAddr);

                dataGridBML.Columns[nameof(BML.ColumnControlMethod)].HeaderText =BML.ColumnSlaveNo;
                dataGridBML.Columns[nameof(BML.ColumnControlMethod)].Name = nameof(BML.ColumnSlaveNo);
            }
            else
            {
                dataGridBML.Columns[nameof(BML.ColumnIPAddr)].HeaderText = BML.ColumnType;
                dataGridBML.Columns[nameof(BML.ColumnIPAddr)].Name = nameof(BML.ColumnType);

                dataGridBML.Columns[nameof(BML.ColumnSlaveNo)].HeaderText = BML.ColumnControlMethod;
                dataGridBML.Columns[nameof(BML.ColumnSlaveNo)].Name = nameof(BML.ColumnControlMethod);
            }
            comboStartRow.SelectedItem = chkUserDifinedExcel.Checked ? BML.StartRowUser : BML.StartRow;
            BMLColumName();
            if (dataGridBML.Rows.Count > 0 && !string.IsNullOrEmpty(comboWorkSheetsBML.Text))

            { btnReadBML_Click(btnReadBML, e); }
        }
        private void BMLColumName()
        {
            if (chkUserDifinedExcel.Checked)
            {
                lblType_IPAddr.Text = BML.ColumnIPAddr;
                lblControl_SlaveNo.Text = BML.ColumnSlaveNo;
                comboNameBML.SelectedItem = "C";
                comboDescBML.SelectedItem = "E";
                comboControl_SlaveNoBML.SelectedItem = "F";
                comboType_IPAddrBML.SelectedItem = "I";

                comboFloorBML.SelectedItem = "L";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
            }
            else
            {
                lblType_IPAddr.Text = BML.ColumnType;
                lblControl_SlaveNo.Text = BML.ColumnControlMethod;
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboType_IPAddrBML.SelectedItem = "C";
                comboControl_SlaveNoBML.SelectedItem = "H";
                comboFloorBML.SelectedItem = "L";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
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
                comboFloorBML.Items.Add(item);
                comboSectionBML.Items.Add(item);
                comboCabinetBML.Items.Add(item);
                comboType_IPAddrBML.Items.Add(item);
                comboControl_SlaveNoBML.Items.Add(item);      
            }
            BMLColumName();

            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = chkUserDifinedExcel.Checked?BML.StartRowUser: BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text=BML.DPSlave.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText =BML.ColumnName; 
            nameColumn.Name = nameof(BML.ColumnName);                                                
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.ColumnDesc;
            descColumn.Name = nameof(BML.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);
            DataGridViewTextBoxColumn type_IPColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn control_SlaveNoColumn = new DataGridViewTextBoxColumn();
            if (chkUserDifinedExcel.Checked)
            {   
                type_IPColumn.HeaderText = BML.ColumnIPAddr;
                type_IPColumn.Name = nameof(BML.ColumnIPAddr);
               
                control_SlaveNoColumn.HeaderText = BML.ColumnSlaveNo;
                control_SlaveNoColumn.Name = nameof(BML.ColumnSlaveNo);      
            }
            else
            {          
                type_IPColumn.HeaderText = BML.ColumnType;
                type_IPColumn.Name = nameof(BML.ColumnType);
                     
                control_SlaveNoColumn.HeaderText = BML.ColumnControlMethod;
                control_SlaveNoColumn.Name = nameof(BML.ColumnControlMethod);             
            }
            dataGridBML.Columns.Add(type_IPColumn);
            dataGridBML.Columns.Add(control_SlaveNoColumn);
            //DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            //floorColumn.HeaderText = BML.ColumnFloor;
            //floorColumn.Name = nameof(BML.ColumnFloor);
            //dataGridBML.Columns.Add(floorColumn);

            //DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            //cabinetColumn.HeaderText = BML.ColumnCabinet;
            //cabinetColumn.Name = nameof(BML.ColumnCabinet);
            //dataGridBML.Columns.Add(cabinetColumn);

            //DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            //cabinetColumnGroup.HeaderText = BML.ColumnCabinetGroup;
            //cabinetColumnGroup.Name = nameof(BML.ColumnCabinetGroup);
            //dataGridBML.Columns.Add(cabinetColumnGroup);

        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text, comboType_IPAddrBML.Text, comboControl_SlaveNoBML.Text };
            StringBuilder sbNameFilters = new StringBuilder();
            sbNameFilters.Append($@"Value NOT LIKE ""{string.Empty}""");
            DataTable dataTable = new DataTable();
            string[] filters = { sbNameFilters.ToString()};
            string[] filterColumns = { comboNameBML.Text };
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);      
            dataGridBML.Columns[0].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[1].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[2].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[3].DataPropertyName = dataTable.Columns[3].ColumnName;
            //dataGridBML.Columns[nameof(BML.ColumnFloor)].DataPropertyName = dataTable.Columns[4].ColumnName;
            //dataGridBML.Columns[nameof(BML.ColumnCabinet)].DataPropertyName = dataTable.Columns[5].ColumnName;
            //dataGridBML.Columns[nameof(BML.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[6].ColumnName;
            dataGridBML.AllowUserToAddRows = false;
            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            TxtQuantity.Text = dataGridBML.Rows.Count.ToString();
            dataTable.Dispose();
            dataTable = null;
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
                txtSymbolRule.Text = DPSlave.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DPSlave.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                grpSymbolRule.Visible = true;
                lblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_DPSlave;
                txtDescription.Text= DEMO_DESCRIPTION_DPSlave;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;
               
            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = DPSlave.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DPSlave.Rule.Common.NameRuleInc;
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
            DataTable dataTable=null;
            dataGridBML.DataSource = dataTable;
            
        }
        private void toolStripMenuReload_Click(object sender, EventArgs e)
        {
            btnReadBML_Click(sender, e);
        }
        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridBML.SelectedRows)
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
       
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_CLEAR_FILE, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)

            {
                myDPSlave.Clear();
                ProgressBar.Value = 0;  
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            MDDx.SaveFileAs(myDPSlave.FilePath, LibGlobalSource.CREATE_OBJECT);
           
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
                OleDb oledb = new OleDb();
                oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                oledb.IsNewOLEDBDriver = isNewOledbDriver;
                DPSlave.ReGenerateDPNode(oledb);
            }
        }
        void AppendInfoToBuilder(CheckBox checkBox, string info, StringBuilder builder)
        {
            if (checkBox.Checked)
            {
                builder.Append(info);
            }
        }
        private void CreateObjectBML()
        {
            OleDb oledb = new OleDb();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            DataTable dataTable = new DataTable();
            ProgressBar.Maximum = dataGridBML.Rows.Count-1;
            for (int i = 0; i < dataGridBML.Rows.Count; i++)
            {
                DataGridViewCell cell;
                cell = dataGridBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                { continue; }
                myDPSlave.Name = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.ColumnName)].Value);
                myDPSlave.Description = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value);
                myDPSlave.IPAddr = Convert.ToString(dataGridBML.Rows[i].Cells[2].Value);
                myDPSlave.SlaveNo = Convert.ToInt32(dataGridBML.Rows[i].Cells[3].Value);
                #region Subtype and PType                                          
                myDPSlave.SubType = string.IsNullOrEmpty(myDPSlave.IPAddr) ? DPSlave.Profibus : DPSlave.Profinet;
                #endregion                
                myDPSlave.CreateObject(Encoding.Unicode);
                ProgressBar.Value = i;
            }
            ProgressBar.Value = ProgressBar.Maximum;
        }
        private void CreateObjectRule()
        {
            OleDb oledb = new OleDb();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            DataTable dataTable = new DataTable();
            //   bool needDPNodeChanged = false;
            StringBuilder descTotalBuilder = new StringBuilder();
            int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
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
         
            #region Prepare export DPSlave file
            ///<OType>is set when object generated</OType>
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                myDPSlave.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                myDPSlave.SubType = DPSlave.Profinet;
            }
            ///<PType></PType>
            string selectedPTypeItem;
            if (ComboEquipmentInfoType.SelectedItem != null)
            {
                selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                myDPSlave.PType = selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            else
            {
                myDPSlave.PType = DPSlave.P7895.ToString();
            }
            ///<Value31</Value31>
            myDPSlave.Value31 = value31.ToString();
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            myDPSlave.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            if (ComboProcessFct.SelectedItem != null)
            {
                selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                myDPSlave.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                myDPSlave.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            }

            ///<Page></Page>
            myDPSlave.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling = "--";
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                myDPSlave.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                myDPSlave.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                myDPSlave.Panel_ID = selectedPanel_ID;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            myDPSlave.FieldBusNode = LibGlobalSource.NOCHILD; ;

            if (ComboHornCode.SelectedItem != null)
            {
                string hornCode = ComboHornCode.SelectedItem.ToString();
                myDPSlave.HornCode = hornCode.Substring(0, 2);
            }
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

            ProgressBar.Maximum = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt - 1 : 1;
            ProgressBar.Value = 0;
            ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
            int symbolInc, symbolRule, descriptionInc;
            int slaveNoInc,slaveNoStart;
            int ipRuleInc, _ipRule;
            tempBool = AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
            tempBool = AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
            tempBool = AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
            tempBool = AppGlobal.ParseInt(txtIPAddressIncRule.Text, out ipRuleInc);
            tempBool = AppGlobal.ParseInt(ip.ipRule, out _ipRule);
            tempBool = AppGlobal.ParseInt(txtParSlaveNoIncRule.Text, out slaveNoInc);
            tempBool = AppGlobal.ParseInt(txtParSlaveNo.Text, out slaveNoStart);
            for (int i = 0; i < quantityNeedToBeCreate ; i++)
            {
                name.Inc = i * symbolInc;
                name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                myDPSlave.IPAddr = ip.ipAddrPrevSegment + (_ipRule + i*ipRuleInc).ToString();
                myDPSlave.SlaveNo = slaveNoStart + i* slaveNoInc;
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
                myDPSlave.Name = name.Name;
                myDPSlave.Description = description.Name;                                                                    
                myDPSlave.CreateObject(Encoding.Unicode);
                ProgressBar.Value = i;
            }
            ProgressBar.Value = ProgressBar.Maximum;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
              
              
                if (createMode.BML)
                {

                    CreateObjectBML();
                       
                }
                else if (createMode.AutoSearch)
                {
                    
                }
                else if (createMode.Rule)
                {
                
                    CreateObjectRule();
                
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
