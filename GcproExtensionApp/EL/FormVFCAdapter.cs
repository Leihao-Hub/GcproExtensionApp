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
#endregion
namespace GcproExtensionApp
{

    public partial class FormVFCAdapter : Form, IGcForm
    {
        public FormVFCAdapter()
        {
            InitializeComponent();
        }
        #region Public object in this class
        VFCAdapter myVFCAdapter = new VFCAdapter(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        //private string CONNECT_VFC = "关联VFC";
        //private string CONNECT_AO = "关联AO";
        private string DEMO_NAME_VFC = "=A-1001-MXZ01-VFC";
        private string DEMO_NAME_VFC_SUFFIX = "-VFC";
        private string DEMO_NAME_RULE_VFC = "1001";
        private string DEMO_DESCRIPTION_VFC = "100号基粉仓活化器变频器/或者空白";
        private string DEMO_DESCRIPTION_RULE_VFC = "100/或者空白";
        private int value9 = 0;
        private int value10 = 1;
        private int tempInt = 0;
        private long tempLong = 0;
        private float tempFloat = (float)0.0;
        private bool tempBool = false;
        #endregion
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
            txtSymbolRule.Text = VFCAdapter.Rule.Common.NameRule;
            txtSymbolIncRule.Text = VFCAdapter.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = VFCAdapter.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = VFCAdapter.Rule.Common.DescriptionRuleInc;
            txtIOByteIncRule.Text = VFCAdapter.Rule.ioByteInc;
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
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
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
            txtVFCPrefixBML.Text = "FCC_";
            txtVFCSufffixBML.Text = "-VFC";
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
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboPowerBML.SelectedItem = "E";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
                comboControlBML.SelectedItem = "H";
            }
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            ComboEquipmentSubType.SelectedIndex = 2;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "变频导入文件 " + " " + myVFCAdapter.FilePath;
        }
        #endregion
        #region <---Rule and autosearch part---> 
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value21.Name;
            objectBrowser.OType = Convert.ToString(VFCAdapter.OTypeValue);

            objectBrowser.Show();
        }
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            myVFCAdapter.Name = txtSymbol.Text;
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BML.VFCAdapter.VFC vfc=new BML.VFCAdapter.VFC();
            string selectedItem = Convert.ToString(ComboEquipmentSubType.SelectedItem);
            myVFCAdapter.SubType = String.IsNullOrEmpty(selectedItem) ? VFCAdapter.ATVDP :
                selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            ///<ATV>  
            if (myVFCAdapter.SubType.StartsWith("ATV"))
            {

                vfc.Name =BML.VFCAdapter.TypeEnmu.ATV930;
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
                vfc.Name = BML.VFCAdapter.TypeEnmu.ABB;
                txtParLenPZDInp.Enabled = false;
              
            }
            ///</ABB>

            ///<ATVMEAGGateWay>
            if (myVFCAdapter.SubType == VFCAdapter.ATVM)
            {
                txtParIOByte.Text = "0";
                txtParLenPKW.Text = "0";
                txtParLenPZD.Text = "16";
                txtParLenPZDInp.Text = "0";
                txtParUnitsPerDigits.Text = "0.1";
                txtParSpeedMaxDigits.Text = "1000";
                txtParSpeedUnitsByMaxDigits.Text = "100";
                txtParSpeedUnitsByZeroDigits.Text = "0";
                //TxtParSpeedLimitMax.Text = "100";
                //TxtParSpeedLimitMax.Text = "0";
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
                txtParIOByte.Text = "0";
                txtParLenPKW.Text = "0";
                txtParLenPZD.Text = "16";
                txtParLenPZDInp.Text = "0";
                txtParUnitsPerDigits.Text = "0.1";
                txtParSpeedMaxDigits.Text = "1000";
                txtParSpeedUnitsByMaxDigits.Text = "100";
                txtParSpeedUnitsByZeroDigits.Text = "0";
                //TxtParSpeedLimitMax.Text = "100";
                //TxtParSpeedLimitMax.Text = "0";
                txtParLenPZDInp.Enabled = false;
                //txtMEAGGateway.Enabled = true;
                //txtParSalveIndex.Enabled = true;
                //txtOutpHardwareStop.Enabled = true;
                //chkParPZDConsistent.Checked = true;
            }
            ///</VFCPNGateWay>
            ///
            ///<DanfossFC>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA4)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.DanfossFC;          
                txtParLenPZDInp.Enabled = false;
                txtParPNO_T1.Text = "414";
                txtParUnitsPerDigit_T1.Text = "0.1";
                txtParPNO_T2.Text = "120";
                txtParUnitsPerDigit_T2.Text = "0.01";
            }
            ///</DanfossFC>
            ///
            ///<DanfossProfidrive>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA5)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.DanfossProfidrive;
                txtParLenPZDInp.Enabled = false;
                txtParPNO_T1.Text = "414";
                txtParUnitsPerDigit_T1.Text = "0.1";
                txtParPNO_T2.Text = "120";
                txtParUnitsPerDigit_T2.Text = "0.01";
                txtParPNO_T1.BackColor = txtParUnitsPerDigit_T1.BackColor = Color.LightGreen;
                txtParPNO_T2.BackColor = txtParUnitsPerDigit_T2.BackColor = Color.LightGreen;
            }
            ///</DanfossProfidrive>
            ///
            ///<ET200SMotorStarter>
            if (myVFCAdapter.SubType == VFCAdapter.VFCMS3RK)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.SSET200S;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</ET200SMotorStarter>
            ///
            ///<Lenze>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA11)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.Lenze;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</Lenze>
            ///
            ///<LenzePos>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA12)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.Lenze;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;

            }
            ///</LenzePos>
            ///
            ///<Leroy>
            if (myVFCAdapter.SubType == VFCAdapter.VFCLS)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.Leroy;          
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;

            }
            ///</<Leroy>
            ///
            ///<MOVIDRIVEIpos>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA10)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.MOVIDRIVE;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;

            }
            ///</MOVIDRIVEIpos>
            ///
            ///<MOVIDRIVESpeed>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA0)
            {

                vfc.Name = BML.VFCAdapter.TypeEnmu.MOVIDRIVE;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;

            }
            ///</MOVIDRIVESpeed>
            ///
            ///<MOVIKIT>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA13)
            {

                vfc.Name = BML.VFCAdapter.TypeEnmu.MOVIDRIVE;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
                txtParPNO_T1.Text = "8326";
                txtParUnitsPerDigit_T1.Text = "0.001";
                txtParPNO_T2.Text = "8323";
                txtParUnitsPerDigit_T2.Text = "0.001";
                txtParPNO_T1.BackColor = txtParUnitsPerDigit_T1.BackColor = Color.LightGreen;
                txtParPNO_T2.BackColor = txtParUnitsPerDigit_T2.BackColor = Color.LightGreen;
            }
            ///</MOVIKIT>
            ///
            ///<MOVITRAC>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA6)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.MOVIDRIVE;              
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</MOVITRAC>
            ///
            ///<MicroMaster>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA1)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.MicroMaster;            
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</MicroMaster>
            ///
            ///<Nord>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA3)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.NORD;       
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</Nord>
            ///
            ///<Sinamics>
            if (myVFCAdapter.SubType == VFCAdapter.VFCA2)
            {
                vfc.Name = BML.VFCAdapter.TypeEnmu.Sinamics;
               
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

                vfc.Name = BML.VFCAdapter.TypeEnmu.SS3RW44;
                txtParLenPZDInp.Enabled = false;
                chkParWithActivePower.Enabled = false;
            }
            ///</<SoftStarter3RW44>
            ///
            ///   ///<SoftStarter3RW44>
            if (myVFCAdapter.SubType == VFCAdapter.SST02DP)
            {

                vfc.Name = BML.VFCAdapter.TypeEnmu.SS3RW5x;
                txtParLenPZDInp.Enabled = true;
                chkParWithActivePower.Enabled = false;
            }
            ///<CommonUsedPar></CommonUsedPar>

            txtParLenPKW.Text = vfc.Par.LenPKW;
            txtParLenPZD.Text = vfc.Par.LenPZD;
            txtParLenPZDInp.Text = vfc.Par.LenPZDInp;
            txtParUnitsPerDigits.Text = vfc.Par.UnitsPerDigits;
            txtParSpeedMaxDigits.Text = vfc.Par.SpeedMaxDigits;
            txtParSpeedUnitsByMaxDigits.Text = vfc.par.SpeedUnitsByMaxDigits;
            txtParSpeedUnitsByZeroDigits.Text = vfc.par.SpeedUnitsByZeroDigits;
            txtParSpeedLimitMax.Text = vfc.par.SpeedLimitMax;
            txtParSpeedLimitMin.Text = vfc.par.SpeedLimitMin;
            chkParPZDConsistent.Checked = vfc.par.ParPZDConsistent;
        }
        #region <------Check and store rule event------>
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
            if (!string.IsNullOrEmpty(txtDescriptionRule.Text))
            {
                if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
                {
                    VFCAdapter.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
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
                    VFCAdapter.Rule.ioByteInc = txtIOByteIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"

        private void chkParPZDConsistent_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParPZDConsistent.Checked)
            { AppGlobal.SetBit(ref value10, (byte)0); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)0); }

            myVFCAdapter.Value10 = value10.ToString();
            txtValue10.Text = myVFCAdapter.Value10;
        }

        private void chkParProfinet_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParProfinet.Checked)
            { AppGlobal.SetBit(ref value10, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myVFCAdapter.Value10 = value10.ToString();
            txtValue10.Text = myVFCAdapter.Value10;
        }

        private void chkParWithActivePower_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithActivePower.Checked)
            { AppGlobal.SetBit(ref value10, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }

            myVFCAdapter.Value10 = value10.ToString();
            txtValue10.Text = myVFCAdapter.Value10;
        }

        private void chkWithMultiMotorCfg_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkWithMultiMotorCfg.Checked)
            { AppGlobal.SetBit(ref value10, (byte)16); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)16); }

            myVFCAdapter.Value10 = value10.ToString();
            txtValue10.Text = myVFCAdapter.Value10;
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
        #endregion            
        #endregion
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
        private void BtnOpenProjectBML_Click(object sender, EventArgs e)
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
            BML.VFCAdapter.BMLPath = excelFileHandle.FilePath;
        }
        private void comboWorkSheetsBML_MouseDown(object sender, MouseEventArgs e)
        {
            AddWorkSheets();
        }
        private void comboWorkSheetsBML_SelectedIndexChanged(object sender, EventArgs e)
        {

            excelFileHandle.WorkSheet = comboWorkSheetsBML.SelectedItem.ToString();
            if (! String.IsNullOrEmpty(excelFileHandle.WorkSheet))
            {
                btnReadBML.Enabled= true;   
            }
        }
        private void CreateBMLDefault()
        {
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text = BML.VFCAdapter.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.VFCAdapter.ColumnName; 
            nameColumn.Name = nameof(BML.VFCAdapter.ColumnName);                                              
            dataGridBML.Columns.Add(nameColumn);
         
           DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.VFCAdapter.ColumnDesc;
            descColumn.Name = nameof(BML.VFCAdapter.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);

            DataGridViewTextBoxColumn powerColumn = new DataGridViewTextBoxColumn();
            powerColumn.HeaderText = BML.VFCAdapter.ColumnPower;
            powerColumn.Name = nameof(BML.VFCAdapter.ColumnPower);
            dataGridBML.Columns.Add(powerColumn);
 

            DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            floorColumn.HeaderText = BML.VFCAdapter.ColumnFloor;
            floorColumn.Name = nameof(BML.VFCAdapter.ColumnFloor);
            dataGridBML.Columns.Add(floorColumn);

            DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            cabinetColumn.HeaderText = BML.VFCAdapter.ColumnCabinet;
            cabinetColumn.Name = nameof(BML.VFCAdapter.ColumnCabinet);
            dataGridBML.Columns.Add(cabinetColumn);
            

            DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            cabinetColumnGroup.HeaderText = BML.VFCAdapter.ColumnCabinetGroup;
            cabinetColumnGroup.Name = nameof(BML.VFCAdapter.ColumnCabinetGroup);
            dataGridBML.Columns.Add(cabinetColumnGroup);
          

            DataGridViewTextBoxColumn controlMethod = new DataGridViewTextBoxColumn();
            controlMethod.HeaderText = BML.VFCAdapter.ColumnControlMethod;
            controlMethod.Name = nameof(BML.VFCAdapter.ColumnControlMethod);
            dataGridBML.Columns.Add(controlMethod);

            dataGridBML.Columns[descColumn.Name].Width = 126;
            dataGridBML.Columns[powerColumn.Name].Width = 56;
            dataGridBML.Columns[floorColumn.Name].Width = 56;
            dataGridBML.Columns[cabinetColumnGroup.Name].Width = 66;
            dataGridBML.Columns[cabinetColumn.Name].Width = 66;
            dataGridBML.Columns[controlMethod.Name].Width = 188;

        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            // List<List<object>> allData = new List<List<object>>();
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboPowerBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboControlBML.Text};
            DataTable dataTable = new DataTable();
            string[] filters = { $"Value=={BML.VFCAdapter.Type}", $@"Value LIKE ""{txtVFCPrefixBML.Text}%""" };
            string[] filterColumns = { comboTypeBML.Text, comboControlBML.Text };
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns,comboNameBML.Text, true);
            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;

            dataGridBML.Columns[nameof(BML.VFCAdapter.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;   
            dataGridBML.Columns[nameof(BML.VFCAdapter.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.VFCAdapter.ColumnPower)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.VFCAdapter.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.VFCAdapter.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.VFCAdapter.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.VFCAdapter.ColumnControlMethod)].DataPropertyName = dataTable.Columns[6].ColumnName;

            TxtQuantity.Text = dataTable.Rows.Count.ToString();
        }
        #endregion
        #region Common used
        private void CreateVFCAdapterImpExp(OleDb oledb)
        {

            List<List<GcproExtensionLibrary.Gcpro.DbParameter>> recordList = new List<List<GcproExtensionLibrary.Gcpro.DbParameter>>
                    {
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value =VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Type" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.OType.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Name" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Text0.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Description" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.Text1.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SubType" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.SubType.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ProcessFct" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.ProcessFct.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Building" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Building.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Elevation" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Elevation.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "FieldBusNode" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.FieldbusNode.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Panel ID"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Panel_ID.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Diagram"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DiagramNo.Name}

                    },
                        new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Page"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.PageName.Name}

                    },

                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DP node1"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode1.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Object parameters"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value10.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedLimitMin"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value18.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedLimitMax"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value19.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedMaxDigits"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value15.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedUnitsByZeroDigits"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value16.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedUnitsByMaxDigits"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value17.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "UnitsPerDigits"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "IOByteNo"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LenPKW"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LenPZD"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LenPZDInp"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value44.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "MEAGGateway"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SlaveIndex"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "outpHardwareStop"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram1_ParPNO"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram1_ParUnitsPerDigit"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value35.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram2_ParPNO"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram2_ParUnitsPerDigit"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value36.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram3_ParPNO"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value27.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram3_ParUnitsPerDigit"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value37.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram4_ParPNO"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value28.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram4_ParUnitsPerDigit"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram5_ParPNO"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value29.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram5_ParUnitsPerDigit"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value39.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParRefCurrent"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value40.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParRefTorque"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value41.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParRefPower"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VFCAdapter.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Is new" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.IsNew.Name }

                    }
                };
            if (oledb.InsertMultipleRecords(GcproTable.ImpExpDef.TableName, recordList))
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
                txtSymbol.Text = DEMO_NAME_VFC;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;
               
            }
            //else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            //{
            //    tabCreateMode.SelectedTab = tabRule;
            //    createMode.Rule = false;
            //    createMode.BML = false;
            //    createMode.AutoSearch = true;
            //    txtSymbolRule.Text = VFCAdapter.Rule.Common.NameRule;
            //    txtSymbolIncRule.Text =VFCAdapter.Rule.Common.NameRuleInc;
            //    LblQuantity.Visible = false;
            //    TxtQuantity.Visible = false;
            //    GrpSymbolRule.Visible = false;
            //    LblSymbol.Text = AppGlobalSource.KEY_WORD_AUTOSEARCH;
            //    txtSymbol.Text = "-VFC";
            //    tabRule.Text = CreateMode.ObjectCreateMode.AutoSearch;
                
            //}

            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.BML)
            {
                createMode.Rule = false;
                createMode.BML = true;
                createMode.AutoSearch = false;
                tabCreateMode.SelectedTab = tabBML;
                txtSymbol.Text = DEMO_NAME_VFC_SUFFIX;
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

            myVFCAdapter.SaveFileAs(myVFCAdapter.FilePath, LibGlobalSource.CREATE_OBJECT);
            myVFCAdapter.SaveFileAs(myVFCAdapter.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
                AppGlobal.ReGenerateDPNode(oledb);
            }
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            int slaveIndexInc= AppGlobal.ParseInt(txtParSlaveIndexIncRule.Text, out tempInt) ? tempInt : 1;
            int ioByteInc= AppGlobal.ParseInt(txtIOByteIncRule.Text, out tempInt) ? tempInt : 0;
            int ioByte = AppGlobal.ParseInt(txtParIOByte.Text, out tempInt) ? tempInt : 0;
           
            if (myVFCAdapter.SubType == VFCAdapter.ATVM)
            {
                TxtQuantity.Text = quantityNeedToBeCreate >= 63 ? "63" : Convert.ToString(quantityNeedToBeCreate);
                if (slaveIndexInc >= 1)
                {
                    DialogResult result = MessageBox.Show("站地址最大为63，确定要将规则设为大于1的数？", $"{AppGlobal.AppInfo.Title}:{AppGlobal.INFO}"
                         , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Cancel)
                    {
                        slaveIndexInc = 1;
                        txtParSlaveIndexIncRule.Text = Convert.ToString(slaveIndexInc);
                    }
                }
            }
            try
            {
                OleDb oledb = new OleDb();
                DataTable dataTable = new DataTable();
                oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                #region common used variables declaration
                bool needDPNodeChanged = false;
             
                bool moreThanOne = quantityNeedToBeCreate > 1;
                bool onlyOne = quantityNeedToBeCreate == 1;
                int objCreated = 0;

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
                ///<Name>Value is set in TxtSymbol text changed event</Name>
                ///<Description></Description>
                myVFCAdapter.Description = txtDescription.Text;
                ///<SubType></SubType>
                string selectedSubTypeItem;
                if (ComboEquipmentSubType.SelectedItem != null)
                {
                    selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                    myVFCAdapter.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                   
                }
                else
                {
                    myVFCAdapter.SubType = VFCAdapter.ATVDP;
                }                                             
                ///<ProcessFct></ProcessFct>
                string selectedProcessFct = string.Empty;
                if (ComboProcessFct.SelectedItem != null)
                {
                    selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                    myVFCAdapter.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Building></Building>
                string selectedBudling = "--";
                if (ComboBuilding.SelectedItem != null)
                {
                    selectedBudling = ComboBuilding.SelectedItem.ToString();
                    myVFCAdapter.Building = selectedBudling;
                }
                ///<Elevation></Elevation>
                string selectedElevation;
                if (ComboElevation.SelectedItem != null)
                {
                    selectedElevation = ComboElevation.SelectedItem.ToString();
                    myVFCAdapter.Elevation = selectedElevation;
                }
                ///<FieldBusNode></FieldBusNode>  
                myVFCAdapter.FieldBusNode = LibGlobalSource.NOCHILD;
                ///<Panel_ID></Panel_ID>
                string selectedPanel_ID;
                if (ComboPanel.SelectedItem != null)
                {
                    selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                    myVFCAdapter.Panel_ID = selectedPanel_ID;
                }
                ///<Diagram></Diagram>
                string selectedDiagram;
                if (ComboDiagram.SelectedItem != null)
                {
                    selectedDiagram = ComboDiagram.SelectedItem.ToString();
                    myVFCAdapter.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Page></Page>
                myVFCAdapter.Page = txtPage.Text;
                ///<DPNode1></DPNode1>
                string selectDPNode1 = String.Empty;
                if (ComboDPNode1.SelectedItem != null)
                {
                    selectDPNode1 = ComboDPNode1.SelectedItem.ToString();
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    myVFCAdapter.DPNode1 = AppGlobal.FindDPNodeNo(oledb, selectDPNode1);
                    int dpnode1 = int.Parse(myVFCAdapter.DPNode1);
                    myVFCAdapter.FieldBusNode = AppGlobal.FindFieldbusNodeKey(oledb, dpnode1);
                }
                ///<Value9>Value9 is not used here</Value9>
                ///<Value10>Value is set when corresponding check box's check state changed</Value10>
                if (createMode.Rule)
                {
                    ///<ParSpeedLimitMin></ParSpeedLimitMin>
                    myVFCAdapter.SpeedLimitMin = AppGlobal.ParseInt(txtParSpeedLimitMin.Text, out tempInt) ? (tempInt).ToString() : "0";
                    ///<ParSpeedLimitMax></ParSpeedLimitMax>
                    myVFCAdapter.SpeedLimitMax = AppGlobal.ParseInt(txtParSpeedLimitMax.Text, out tempInt) ? (tempInt).ToString() : "100";
                    ///<ParSpeedMaxDigits></ParSpeedMaxDigits>
                    myVFCAdapter.SpeedMaxDigits = AppGlobal.ParseInt(txtParSpeedMaxDigits.Text, out tempInt) ? (tempInt).ToString() : "500";
                    ///<ParSpeedUnitsByZeroDigits></ParSpeedUnitsByZeroDigits>
                    myVFCAdapter.SpeedUnitsByZeroDigits = AppGlobal.ParseInt(txtParSpeedUnitsByZeroDigits.Text, out tempInt) ? (tempInt).ToString() : "0";
                    ///<ParSpeedUnitsByZeroDigits></ParSpeedUnitsByZeroDigits>
                    myVFCAdapter.SpeedUnitsByMaxDigits = AppGlobal.ParseInt(txtParSpeedUnitsByMaxDigits.Text, out tempInt) ? (tempInt).ToString() : "100";
                    ///<ParUnitsPerDigits</ParUnitsPerDigits>
                    myVFCAdapter.UnitsPerDigits = AppGlobal.ParseFloat(txtParUnitsPerDigits.Text, out tempFloat) ? (tempFloat).ToString("F1") : "0.1";
                    ///<ParLenPKW</ParLenPKW>
                    myVFCAdapter.LenPKW = AppGlobal.ParseInt(txtParLenPKW.Text, out tempInt) ? (tempInt).ToString() : "0";
                    ///<ParLenPZD</ParLenPZD>
                    myVFCAdapter.LenPZD = AppGlobal.ParseInt(txtParLenPZD.Text, out tempInt) ? (tempInt).ToString() : "6";
                    ///<ParLenPZDInp</ParLenPZDInp>
                    myVFCAdapter.LenPZDInp = AppGlobal.ParseInt(txtParLenPZDInp.Text, out tempInt) ? (tempInt).ToString() : "0";
                    
                }
                ///<ParIOByteNo</ParIOByteNo>
                myVFCAdapter.IoByteNo = AppGlobal.ParseInt(txtParIOByte.Text, out tempInt) ? (tempInt).ToString() : "20000";
                ///<MEAGGateway</MEAGGateway<>
                myVFCAdapter.MeagGateway = myVFCAdapter.SubType == VFCAdapter.ATVM ? txtMEAGGateway.Text : "0";
                ///<SlaveIndex</SlaveIndex>      
                myVFCAdapter.SlaveIndex = myVFCAdapter.SubType == VFCAdapter.ATVM ? 
                    (AppGlobal.ParseInt(txtParSalveIndex.Text, out tempInt) ? (tempInt).ToString() : "0") : "0";
                ///<OutpHardwareStop</OutpHardwareStop>
                myVFCAdapter.OutpHardwareStop = myVFCAdapter.SubType == VFCAdapter.ATVM ? txtOutpHardwareStop.Text : "0";

                ///<Telegram1</Telegram1>
                myVFCAdapter.Telegram1.ParPNO = String.IsNullOrEmpty(txtParPNO_T1.Text) ? "0.0" :
                                    (AppGlobal.ParseFloat(txtParPNO_T1.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                myVFCAdapter.Telegram1.ParUnitsPerDigit= String.IsNullOrEmpty(txtParUnitsPerDigit_T1.Text) ? "0.0" :
                        (AppGlobal.ParseFloat(txtParUnitsPerDigit_T1.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                ///<Telegram2</Telegram2>
                myVFCAdapter.Telegram2.ParPNO = String.IsNullOrEmpty(txtParPNO_T2.Text) ? "0.0" :
                                    (AppGlobal.ParseFloat(txtParPNO_T2.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                myVFCAdapter.Telegram2.ParUnitsPerDigit = String.IsNullOrEmpty(txtParUnitsPerDigit_T2.Text) ? "0.0" :
                        (AppGlobal.ParseFloat(txtParUnitsPerDigit_T2.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                ///<Telegram3</Telegram3>
                myVFCAdapter.Telegram3.ParPNO = String.IsNullOrEmpty(txtParPNO_T3.Text) ? "0.0" :
                                    (AppGlobal.ParseFloat(txtParPNO_T3.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                myVFCAdapter.Telegram3.ParUnitsPerDigit = String.IsNullOrEmpty(txtParUnitsPerDigit_T3.Text) ? "0.0" :
                        (AppGlobal.ParseFloat(txtParUnitsPerDigit_T3.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                ///<Telegram4</Telegram4>
                myVFCAdapter.Telegram4.ParPNO = String.IsNullOrEmpty(txtParPNO_T4.Text) ? "0.0" :
                                    (AppGlobal.ParseFloat(txtParPNO_T4.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                myVFCAdapter.Telegram4.ParUnitsPerDigit = String.IsNullOrEmpty(txtParUnitsPerDigit_T4.Text) ? "0.0" :
                        (AppGlobal.ParseFloat(txtParUnitsPerDigit_T4.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                ///<Telegram5</Telegram5>
                myVFCAdapter.Telegram5.ParPNO = String.IsNullOrEmpty(txtParPNO_T5.Text) ? "0.0" :
                                    (AppGlobal.ParseFloat(txtParPNO_T5.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                myVFCAdapter.Telegram5.ParUnitsPerDigit = String.IsNullOrEmpty(txtParUnitsPerDigit_T5.Text) ? "0.0" :
                        (AppGlobal.ParseFloat(txtParUnitsPerDigit_T5.Text, out tempFloat) ? (tempFloat).ToString() : "0.0");
                ///<Sinamics>
                ///[RefCurrent],[RefTorque],[RefPower]
                ///don't need ,they will read from VFC            
                ///<IsNew>is set when object generated,Default value is "No"</IsNew>
                #endregion
                if (createMode.BML)
                {
                    ProgressBar.Maximum = dataGridBML.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    BML.VFCAdapter.VFC vfc = new BML.VFCAdapter.VFC();
                    int nextIOByte = ioByte;
                    for (int i = 0; i < dataGridBML.Rows.Count; i++)
                    {
                        
                        DataGridViewCell cell;
                        cell = dataGridBML.Rows[i].Cells[nameof(BML.VFCAdapter.ColumnName)];
                        if (cell.Value==null || cell.Value ==DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                            continue;
                        ///<Name>   </Name>
                        myVFCAdapter.Name = Convert.ToString(cell.Value)+txtVFCSufffixBML.Text;
                        ///<Description>   </Description>           
                        myVFCAdapter.Description = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.VFCAdapter.ColumnDesc)].Value);

                      
                        ///<Panel_ID>   </Panel_ID>  
                        myVFCAdapter.Panel_ID= Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.VFCAdapter.ColumnCabinetGroup)].Value)+
                            Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.VFCAdapter.ColumnCabinet)].Value);
                        ///<Elevation>   </Elevation>  
                        myVFCAdapter.Elevation= Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.VFCAdapter.ColumnFloor)].Value);
                        ///<IOByteNo>   </IOByteNo> 
                        string controlMethod = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.VFCAdapter.ColumnControlMethod)].Value);
                     
                        if (controlMethod.Contains(BML.VFCAdapter.TypeEnmu.ATV320))
                        {
                            vfc.Name = BML.VFCAdapter.TypeEnmu.ATV320;                           
                        }
                        else if (controlMethod.Contains(BML.VFCAdapter.TypeEnmu.ATV930))
                        {
                            vfc.Name = BML.VFCAdapter.TypeEnmu.ATV930;
                               
                        }
                        ///<ParSpeedLimitMin></ParSpeedLimitMin>
                        myVFCAdapter.SpeedLimitMin = vfc.Par.SpeedLimitMin;
                        ///<ParSpeedLimitMax></ParSpeedLimitMax>
                        myVFCAdapter.SpeedLimitMax = vfc.Par.SpeedLimitMax;
                        ///<ParSpeedMaxDigits></ParSpeedMaxDigits>
                        myVFCAdapter.SpeedMaxDigits = myVFCAdapter.Description.Contains("磨粉机")?"1000":vfc.Par.SpeedMaxDigits;
                        ///<ParSpeedUnitsByZeroDigits></ParSpeedUnitsByZeroDigits>
                        myVFCAdapter.SpeedUnitsByZeroDigits = vfc.Par.SpeedUnitsByZeroDigits;
                        ///<ParSpeedUnitsByZeroDigits></ParSpeedUnitsByZeroDigits>
                        myVFCAdapter.SpeedUnitsByMaxDigits = vfc.Par.SpeedUnitsByMaxDigits;
                        ///<ParUnitsPerDigits</ParUnitsPerDigits>
                        myVFCAdapter.UnitsPerDigits = vfc.Par.UnitsPerDigits;
                        ///<ParLenPKW</ParLenPKW>
                        myVFCAdapter.LenPKW = vfc.Par.LenPKW;
                        ///<ParLenPZD</ParLenPZD>
                        myVFCAdapter.LenPZD = vfc.Par.LenPZD;
                        ///<ParLenPZDInp</ParLenPZDInp>
                        myVFCAdapter.LenPZDInp = vfc.Par.LenPZDInp;

                        ioByteInc = Convert.ToInt32(vfc.Par.LenPZD);
                        // myVFCAdapter.IoByteNo = Convert.ToString(ioByte + i * ioByteInc);
                        myVFCAdapter.IoByteNo = Convert.ToString(nextIOByte);
                        nextIOByte = nextIOByte + ioByteInc;
                        ///<DPNode1>   </DPNode1>                         
                        string dpNode1BML= Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.VFCAdapter.ColumnName)].Value);
                        myVFCAdapter.DPNode1 = AppGlobal.FindDPNodeNo(oledb, dpNode1BML);
                        myVFCAdapter.FieldBusNode = String.IsNullOrEmpty(myVFCAdapter.DPNode1 )?string.Empty:
                            AppGlobal.FindFieldbusNodeKey(oledb, int.Parse(myVFCAdapter.DPNode1));
                        ///<CreateObject>   </CreateObject>
                        myVFCAdapter.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = i;
                    }
                    ProgressBar.Value = ProgressBar.Maximum;
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
                    if (!String.IsNullOrEmpty(txtDescriptionRule.Text))
                    {
                        description.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtDescription.Text, txtDescriptionRule.Text);
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
                    tempBool = AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
                    tempBool = AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
                    tempBool = AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
                 
                    for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
                    {
                        name.Inc = i * symbolInc;
                        name.Name = LibGlobalSource.StringHelper.GenerateObjectName(name.Sub, name.PosInfo, (symbolRule + name.Inc).ToString().PadLeft(name.PosInfo.Len, '0'));
                                      
                       
                        if (needDPNodeChanged && moreThanOne)
                        {
                            dpNode1.Inc = i * symbolInc;
                            dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());
                            myVFCAdapter.DPNode1 = AppGlobal.FindDPNodeNo(oledb, dpNode1.Name);
                            myVFCAdapter.FieldBusNode = AppGlobal.FindFieldbusNodeKey(oledb, int.Parse(myVFCAdapter.DPNode1));
                        }

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
                            description.Name = "变频器";
                        }
                        myVFCAdapter.Name = name.Name;
                        myVFCAdapter.Description = description.Name;
                        myVFCAdapter.IoByteNo=Convert.ToString(ioByte + i* ioByteInc);
                        objCreated = i;
                        myVFCAdapter.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = objCreated;
                    }
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