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
using System.Windows.Documents;
#endregion
namespace GcproExtensionApp
{

    public partial class FormVLS : Form, IGcForm
    {

        public FormVLS()
        {
            InitializeComponent();
        }
        #region Public object in this class
        VLS myVLS = new VLS(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();

        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;

        private string DEMO_NAME_VLS = "=A-1001-01/02";
        private string DEMO_NAME_RULE_MOTOR = "1001";
        private string DEMO_DESCRIPTION_VLS = "100号毛麦仓下闸门/或者空白";
        private string DEMO_DESCRIPTION_RULE_VLS = "100/或者空白";
        private string namePrefix=string.Empty;
        #endregion
        private int value9 = 0;
        private int value10 = 10;
        private int tempInt = 0;
        private long tempLong = 0;
        private float tempFloat = (float)0.0;
        private bool tempBool = false;
        List<KeyValuePair<string, int>> listBMLName = new List<KeyValuePair<string, int>>();
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
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={VLS.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {VLS.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + VLS.OTypeValue}'",
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
            txtSymbolRule.Text = VLS.Rule.Common.NameRule;
            txtSymbolIncRule.Text = VLS.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = VLS.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = VLS.Rule.Common.DescriptionRuleInc;          
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + VLS.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);
        
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_VLS);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_MOTOR);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_VLS);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_VLS);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;          
            dataTable=oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{VLS.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);         
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{VLS.ImpExpRuleName}'", null);
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
            txtInpLNSuffix.Text = BML.VLS.SuffixInpLN;
            txtInpHNSuffix.Text = BML.VLS.SuffixInpHN;
            txtOutpLNSuffix.Text = BML.VLS.SuffixOutpLN;
            txtOutpHNSuffix.Text = BML.VLS.SuffixOutpHN;
            txtInpRunFwdSuffix.Text = BML.VLS.SuffixInpRunFwd;
            txtInpRunRevSuffix.Text = BML.VLS.SuffixInpRunRev;
            txtInpRunFwd.Text = txtSymbol.Text + txtInpLNSuffix.Text;
           
            
            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
          
            myVLS.Value9 = "0";
            btnReadBML.Enabled = false;
            //txtVFCPrefixBML.Text = ;
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
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";             
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
                comboIORemarkBML.SelectedItem = "S";

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
            this.Text = "VLS导入文件 " + " " + myVLS.FilePath;
        }

        #endregion

        private void CreateMotorImpExp(OleDb oledb)
        {

            List<List<GcproExtensionLibrary.Gcpro.DbParameter>> recordList = new List<List<GcproExtensionLibrary.Gcpro.DbParameter>>
                    {
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value =VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Type" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.OType.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Name" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Text0.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Description" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.Text1.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SubType" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.SubType.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ProcessFct" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.ProcessFct.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Building" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Building.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Elevation" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Elevation.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "FieldBusNode" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.FieldbusNode.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Panel ID"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Panel_ID.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Diagram"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DiagramNo.Name}

                    },
                        new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Page"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.PageName.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "PType"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value5.Name }
                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Horn Code"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value2.Name }

                    },                
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DP node1"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode1.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DP node2"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode2.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Gcpro parameters"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value9.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Object parameters"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value10.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpLN"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpHN"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpLN"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpHN"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpRunRev" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value15.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpRunFwd" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value16.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "HWStop" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value47.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTime"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParPulseHN"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParPulseLN"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParIdlingTime" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }
                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParFaultDelayTime" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }
                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStartDelay"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name }

                    },                    
                   new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Receiver LN" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value30.Name}

                    },
                   new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Receiver HN" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name}

                    },
                   new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Sender Bin" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name}

                    },
                   new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Aspiration" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = VLS.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Is new" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.IsNew.Name }

                    }
                };
            if (oledb.InsertMultipleRecords(GcproTable.ImpExpDef.TableName, recordList))
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormVLS_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormVLS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                VLS.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    VLS.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
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
                    VLS.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
        private void TxtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    VLS.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }

        }   
        private void TxtInpFaultDevSuffix_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpHWSuffix_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpFaultDev_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInHWStop_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtOutpLN_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtOutpHN_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtInpLN_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpLNSuffix_TextChanged(object sender, EventArgs e)
        {
            TxtInpLN.Text = namePrefix + txtInpLNSuffix.Text;
        }
        private void txtInpLNSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpLNSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Suffix.InpLN", newJsonKeyValue);
                BML.VLS.SuffixInpLN = newJsonKeyValue;

            }
        }
        private void txtOutpLNSuffix_TextChanged(object sender, EventArgs e)
        {
            TxtOutpLN.Text = namePrefix + txtOutpLNSuffix.Text;
        }
        private void txtOutpLNSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpLNSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Suffix.OutpLN", newJsonKeyValue);
                BML.VLS.SuffixOutpLN = newJsonKeyValue;
               
            }
        }
        private void TxtInpHN_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtInpHN_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txtInpHNSuffix_TextChanged(object sender, EventArgs e)
        {
            TxtInpHN.Text = namePrefix + txtInpHNSuffix.Text;
        }
        private void txtInpHNSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpHNSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Suffix.InpHN", newJsonKeyValue);
                BML.VLS.SuffixInpHN = newJsonKeyValue;

            }
        }
        private void txtOutpHNSuffix_TextChanged(object sender, EventArgs e)
        {
            TxtOutpHN.Text = namePrefix + txtOutpHNSuffix.Text;
        }
        private void txtOutpHNSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpHNSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Suffix.OutpHN", newJsonKeyValue);
                BML.VLS.SuffixOutpHN = newJsonKeyValue;              
            }
        }

        private void txtInpRunRev_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpRunRevSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRunRev.Text = namePrefix + txtInpRunRevSuffix.Text;
        }
        private void txtInpRunRevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpRunRevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Suffix.InpRunRev", newJsonKeyValue);
                BML.VLS.SuffixInpRunRev = newJsonKeyValue;
            }
        }
        private void txtInpRunFwd_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtInpRunFwdSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRunFwd.Text = namePrefix + txtInpRunFwdSuffix.Text;
        } 
        private void txtInpRunFwdSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpRunFwdSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Suffix.InpRunFwd", newJsonKeyValue);
                BML.VLS.SuffixInpRunFwd = newJsonKeyValue;
            }
        }

        private void TxtMonTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(txtMonTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"     
        private void chkParLogOff_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParLogOff.Checked)
            { AppGlobal.SetBit(ref value10, (byte)0); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)0); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }
        private void chkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParManual.Checked)
            { AppGlobal.SetBit(ref value10, (byte)1); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }
        private void chkPulseValve_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkPulseValve.Checked)
            { AppGlobal.SetBit(ref value10, (byte)2); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }

        private void chkContValve_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkContValve.Checked)
            { AppGlobal.SetBit(ref value10, (byte)3); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)3); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }

        private void chkManualFlap_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkManualFlap.Checked)
            { AppGlobal.SetBit(ref value10, (byte)4); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)4); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }

        private void chkStartwarningLN_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkStartwarningLN.Checked)
            { AppGlobal.SetBit(ref value10, (byte)5); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)5); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
        }

        private void chkStartwarningHN_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkStartwarningHN.Checked)
            { AppGlobal.SetBit(ref value10, (byte)6); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)6); }

            myVLS.Value10 = value10.ToString();
            txtValue10.Text = myVLS.Value10;
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
        private void TxtInpLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }
        private void TxtInpHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value13";
        }
        private void TxtOutpLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }
        private void TxtOutpHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value14";
        }
        private void txtInpRunRev_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value15";
        }
        private void txtInpRunFwd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value16";
        }
        private void txtInpFaultDev_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value19";
        }

        private void TxtInHWStop_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value47";
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

        private void txtMonTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void txtPulseTimeLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }

        private void txtPulseTimeHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }
        private void txtStartDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }

        private void txtIdlingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }
        private void txtFaultDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }
        #region Check value10
        private void chkParLogOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value0.Bit0";
        }
        private void chkParManual_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }  
        private void chkPulseValve_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit2";
        }
        private void chkContValve_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit3";
        }
        private void chkManualFlap_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit4";
        }

        private void chkStartwarningLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit5";
        }
        private void chkStartwarningHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit6";
        }
        #endregion
        private void txtRcvLN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value30";
        }

        private void txtRcvHN_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value31";
        }

        private void txtSndBin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value32";
        }

        private void txtAsp_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value34";
        }
        #endregion

        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            NamePrefix();
            NameSubElements(namePrefix);
            myVLS.Name = txtSymbol.Text;
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtDescription.Text, false);
        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(selectedItem))
            {

                myVLS.SubType= selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                NameSubElements(namePrefix);
            }  
            try
            {
                if (myVLS.SubType == VLS.VCO)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(VLS.P7081))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myVLS.SubType == VLS.VPO)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(VLS.P7082))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myVLS.SubType == VLS.VPOM)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(VLS.P7081))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }          
                  
                }         
                else if (myVLS.SubType == VLS.VMF)
                {
                    //foreach (var item in ComboEquipmentInfoType.Items)
                    //{
                    //    if (item.ToString().StartsWith(VLS.P7081))
                    //    {
                    //        ComboEquipmentInfoType.SelectedItem = item;
                    //        break;
                    //    }
                    //}
                }
                else if (myVLS.SubType == VLS.VPOM)
                {
                    //foreach (var item in ComboEquipmentInfoType.Items)
                    //{
                    //    if (item.ToString().StartsWith(VLS.P7081))
                    //    {
                    //        ComboEquipmentInfoType.SelectedItem = item;
                    //        break;
                    //    }
                    //}
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region <---BML part--->
        private void txtVLSSuffixBML_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtVLSSuffixBML.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Suffix.VLS", newJsonKeyValue);
                BML.VLS.SuffixVLS = newJsonKeyValue;
            }
        }

        private void txtLocalPanelPrefix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtLocalPanelPrefix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.VLS.Prefix.LocalPanel", newJsonKeyValue);
                BML.VLS.PrefixLocalPanel = newJsonKeyValue;
            }
        }
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
            BML.VLS.BMLPath = excelFileHandle.FilePath;
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
        //    TxtExcelPath.Text = BML.VLS.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.VLS.ColumnName; 
            nameColumn.Name = nameof(BML.VLS.ColumnName);                                              
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.VLS.ColumnDesc;
            descColumn.Name = nameof(BML.VLS.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);


            DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            floorColumn.HeaderText = BML.VLS.ColumnFloor;
            floorColumn.Name = nameof(BML.VLS.ColumnFloor);
            dataGridBML.Columns.Add(floorColumn);

            DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            cabinetColumn.HeaderText = BML.VLS.ColumnCabinet;
            cabinetColumn.Name = nameof(BML.VLS.ColumnCabinet);
            dataGridBML.Columns.Add(cabinetColumn);

            DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            cabinetColumnGroup.HeaderText = BML.VLS.ColumnCabinetGroup;
            cabinetColumnGroup.Name = nameof(BML.VLS.ColumnCabinetGroup);
            dataGridBML.Columns.Add(cabinetColumnGroup);

            DataGridViewTextBoxColumn ioRemarkColumn = new DataGridViewTextBoxColumn();
            ioRemarkColumn.HeaderText = BML.VLS.ColumnIORemark;
            ioRemarkColumn.Name = nameof(BML.VLS.ColumnIORemark);
            dataGridBML.Columns.Add(ioRemarkColumn);
        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboIORemarkBML.Text};
            DataTable dataTable = new DataTable();
            string[] filters = { $@"Value LIKE ""{BML.VLS.ManualFlap}"" || Value LIKE ""{BML.VLS.PneFlap}"" || Value LIKE ""{BML.VLS.PneTwoWayValve}"" ||
             Value LIKE ""%{BML.VLS.PneSlideGate}"" || Value LIKE ""%{BML.VLS.ManualSlideGate}"" || Value LIKE ""%{BML.VLS.PneShutOffValve}""" };
            string[] filterColumns = {  comboDescBML.Text };
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);

            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;

            dataGridBML.Columns[nameof(BML.VLS.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnFloor)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnCabinet)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.VLS.ColumnIORemark)].DataPropertyName = dataTable.Columns[5].ColumnName;
            listBMLName = LibGlobalSource.BMLHelper.ExtractUniqueCommonSubstringsWithCount(dataTable, dataTable.Columns[0].ColumnName);
            TxtQuantity.Text = listBMLName.Count.ToString();
            listBMLName.Clear();
        }
        #endregion
        #region Common used
        #region Genate elements name
        private void NamePrefix()
        {
            namePrefix = txtSymbol.Text.Substring(0, txtSymbol.Text.IndexOf(txtSymbolRule.Text)) + txtSymbolRule.Text + "-";
        }
        private void InpSubElements(string _namePrefix)
        {
            TxtInpLN.Text = _namePrefix + txtInpLNSuffix.Text;
            TxtInpHN.Text = _namePrefix + txtInpHNSuffix.Text;
            txtInpRunRev.Text = string.Empty;
            txtInpRunFwd.Text = string.Empty;
        }
        private void InpMSubElements(string _namePrefix)
        {
            txtInpRunRev.Text = _namePrefix + txtInpRunRevSuffix.Text;
            txtInpRunFwd.Text = _namePrefix + txtInpRunRevSuffix.Text;
        }
        private void VMFSubElements(string _namePrefix)
        {
            InpSubElements(_namePrefix);
            TxtOutpLN.Text = string.Empty;  
            TxtOutpHN.Text = string.Empty;
        }
        private void VCOSubElements(string _namePrefix) 
        {
            InpSubElements(_namePrefix);
            TxtOutpHN.Text = _namePrefix + txtOutpHNSuffix.Text;
            TxtOutpLN.Text= string.Empty;   
        }
        private void VPOSubElements(string _namePrefix)
        {
            VCOSubElements(_namePrefix);
            TxtOutpLN.Text = _namePrefix + txtOutpLNSuffix.Text;         
        }
        private void VPOMSubElements(string _namePrefix)
        {
            VPOSubElements(_namePrefix);
            txtInpRunRev.Text = _namePrefix+txtInpRunRevSuffix.Text; 
            txtInpRunFwd.Text = _namePrefix + txtInpRunFwdSuffix.Text;
        }

        private void NameSubElements(string _namePrefix)
        {
            if (myVLS.SubType == VLS.VCO)          
            {
                VCOSubElements(_namePrefix);
            }
            else if (myVLS.SubType == VLS.VPO || myVLS.SubType==VLS.VPOR)
            {
                VPOSubElements(_namePrefix);

            }
            else if (myVLS.SubType == VLS.VPOM )
            {
                VPOMSubElements(_namePrefix);

            }
            else if (myVLS.SubType == VLS.VMF)
            {
                VMFSubElements(_namePrefix);
            }
        }
        #endregion
        private void ComboCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.Rule)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = true;
                createMode.BML = false;
                createMode.AutoSearch = false;
                txtSymbolRule.Text = VLS.Rule.Common.NameRule;
                txtSymbolIncRule.Text = VLS.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_VLS;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;
               
            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = VLS.Rule.Common.NameRule;
                txtSymbolIncRule.Text = VLS.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                GrpSymbolRule.Visible = false;
                LblSymbol.Text = AppGlobal.KEY_WORD_AUTOSEARCH;
                txtSymbol.Text = "-01/02";
                tabRule.Text = CreateMode.ObjectCreateMode.AutoSearch;
                
            }

            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.BML)
            {
                createMode.Rule = false;
                createMode.BML = true;
                createMode.AutoSearch = false;
                tabCreateMode.SelectedTab = tabBML;
                txtVLSSuffixBML.Text = BML.VLS.SuffixVLS;
                txtLocalPanelPrefix.Text = BML.VLS.PrefixLocalPanel;
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
        private void BtnConnectIO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.CONNECT_IO, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                try
                {
                    bool all=!chkOnlyFree.Checked;
                    string objName = String.Empty;
                    string objSubType = String.Empty;
                    OleDb oledb= new OleDb();
                    DataTable dataTable = new DataTable();
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={VLS.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.SubType.Name, 
                        GcproTable.ObjData.Value11.Name, GcproTable.ObjData.Value12.Name, GcproTable.ObjData.Value13.Name,
                        GcproTable.ObjData.Value14.Name, GcproTable.ObjData.Value38.Name, GcproTable.ObjData.Value47.Name,
                         GcproTable.ObjData.Value34.Name, GcproTable.ObjData.Value50.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        if (objSubType == VLS.VPO)
                        {
                            string inpFwd, outpFwd;
                            inpFwd = objName + txtInpLNSuffix.Text;
                            outpFwd = objName + txtInpHNSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name)==0 || all)
                            {
                                myVLS.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                myVLS.CreateRelation(objName, outpFwd, GcproTable.ObjData.Value12.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }                           
                        }
                        else if (objSubType == VLS.VCO)
                        {
                            string inpFwd, outpFwd, inpRev, outpRev;
                            inpFwd = objName + txtInpLNSuffix.Text;
                            outpFwd = objName + txtInpHNSuffix.Text;
                            inpRev = objName + txtOutpLNSuffix.Text;
                            outpRev = objName + txtOutpHNSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                myVLS.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                myVLS.CreateRelation(objName, outpFwd, GcproTable.ObjData.Value12.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field< double>(GcproTable.ObjData.Value13.Name) == 0 || all)
                            {
                                myVLS.CreateRelation(objName, inpRev, GcproTable.ObjData.Value13.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value14.Name) == 0 || all)
                            {
                                myVLS.CreateRelation(objName, outpRev, GcproTable.ObjData.Value14.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else if (objSubType == VLS.VCO|| objSubType == VLS.VPO)
                        {
                            if (all)
                            {
                                //string vfc=objName +txtVFCSuffix.Text; 
                               // myVLS.CreateRelation(objName, vfc, GcproTable.ObjData.Value34.Name, myVLS.FileConnectorPath, Encoding.Unicode);
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
                                          //  string vfc = objName + txtVFCSuffix.Text;
                                          //  myVLS.CreateRelation(objName, vfc, GcproTable.ObjData.Value34.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                                        }
                                    }
                                    connectorTable.Rows.Clear();
                                }
                            }   
                            
                        }
                        else
                        {
                            string inpFwd, outPFwd;
                            inpFwd = objName + txtInpLNSuffix.Text;
                            outPFwd = objName + txtInpHNSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                myVLS.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myVLS.FileConnectorPath,Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                myVLS.CreateRelation(objName, outPFwd, GcproTable.ObjData.Value12.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        if (!String.IsNullOrEmpty(txtInpFaultDev.Text))
                        {
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value38.Name) == 0 || all)
                            {
                                string inpContactor=objName +txtInpFaultDev.Text;
                                myVLS.CreateRelation(objName, inpContactor, GcproTable.ObjData.Value38.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        if (!String.IsNullOrEmpty(txtInHWStop.Text))
                        {
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value47.Name) == 0 || all)
                            {
                                string InHWStop= objName + txtInHWStop.Text; ;
                                myVLS.CreateRelation(objName, InHWStop, GcproTable.ObjData.Value47.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        //if (!String.IsNullOrEmpty(txtPowerApp.Text))
                        //{
                        //    if (all)
                        //    {
                        //        string powerApp= objName + txtPowerAppSuffix.Text; ;
                        //        myVLS.CreateRelation(objName, powerApp, GcproTable.ObjData.Value50.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                        //    }
                        //    else
                        //    {
                        //        double connectorKey = dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value50.Name);
                        //        if (connectorKey != 0)
                        //        {
                        //            DataTable connectorTable = new DataTable();
                        //            connectorTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Key.Name}={connectorKey}", null,
                        //            null, GcproTable.ObjData.Value11.Name);
                        //            if (connectorTable != null)
                        //            {
                        //                double connector = connectorTable.Rows[0].Field<double>(GcproTable.ObjData.Value11.Name);
                        //                if (connector == LibGlobalSource.NO_PARENT)
                        //                {
                        //                    string powerApp = objName + txtPowerAppSuffix.Text;
                        //                    myVLS.CreateRelation(objName, powerApp, GcproTable.ObjData.Value50.Name, myVLS.FileConnectorPath, Encoding.Unicode);
                        //                }
                        //            }
                        //            connectorTable.Rows.Clear();
                        //        }                                  
                        //    }                           
                        //}
                       
                        ProgressBar.Value=count;
                    }
                    myVLS.SaveFileAs(myVLS.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
                    dataTable.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("寻找IO与关联过程出错:"+ex, AppGlobal.INFO+":"+AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }   
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_CLEAR_FILE, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)

            {
                myVLS.Clear();
                ProgressBar.Value = 0;  
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            myVLS.SaveFileAs(myVLS.FilePath, LibGlobalSource.CREATE_OBJECT);
            myVLS.SaveFileAs(myVLS.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
            try
            {
                OleDb oledb = new OleDb();
                DataTable dataTable = new DataTable();
                #region common used variables declaration
                bool needDPNodeChanged = false;
                int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
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
                myVLS.Description = txtDescription.Text;
                ///<ProcessFct></ProcessFct>
                string selectedProcessFct = string.Empty;
                if (ComboProcessFct.SelectedItem != null)
                {
                    selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                    myVLS.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Building></Building>
                string selectedBudling = "--";
                if (ComboBuilding.SelectedItem != null)
                {
                    selectedBudling = ComboBuilding.SelectedItem.ToString();
                    myVLS.Building = selectedBudling;
                }
                ///<Diagram></Diagram>
                string selectedDiagram;
                if (ComboDiagram.SelectedItem != null)
                {
                    selectedDiagram = ComboDiagram.SelectedItem.ToString();
                    myVLS.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Page></Page>
                myVLS.Page = txtPage.Text;
                ///<HornCode></HornCode>
                myVLS.HornCode = "00";
                ///<ParMonTime></ParMonTime>
                myVLS.MonTime = AppGlobal.ParseFloat(txtMonTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "20.0";              
                ///<ParpulseTimeLN></ParpulseTimeLN>
                myVLS.PulseTimeLN = AppGlobal.ParseFloat(txtPulseTimeLN.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.5";
                ///<ParpulseTimeHN></ParpulseTimeHN>
                myVLS.PulseTimeHN = AppGlobal.ParseFloat(txtPulseTimeHN.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.5";
                ///<ParIdlingTime></ParIdlingTime>
                myVLS.IdlingTime = AppGlobal.ParseFloat(txtIdlingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "10.0";
                ///<ParFaultDelayTime></ParFaultDelayTime>
                myVLS.FaultDelay = AppGlobal.ParseFloat(txtFaultDelayTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "30.0";
                ///<ParStartDelay></ParStartDelay>
                myVLS.StartDelay = AppGlobal.ParseFloat(txtStartDelayTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";                 
                ///<Value10>Value is set when corresponding check box's check state changed</Value10>
                ///                       
                ///<InpLN></InpLN>
                myVLS.InpLN= LibGlobalSource.NOCHILD;
                ///<OutpFwd></OutFwd>
                myVLS.OutpLN = LibGlobalSource.NOCHILD;
                ///<InpRHN></InpHN>
                myVLS.InpHN = LibGlobalSource.NOCHILD;
                ///<OutpHN</OutpHN>
                myVLS.OutpHN = LibGlobalSource.NOCHILD;
                ///<InpFaultDev></InpFaultDev>
                myVLS.InpRunRev = txtInpFaultDev.Text;     
                ///<InpRunRev></InpRunRev>
                myVLS.InpRunFwd = LibGlobalSource.NOCHILD;
                ///<InpRunRev></InpRunRev>
                myVLS.InpRunRev = LibGlobalSource.NOCHILD;
                ///<InHWStop></InHWStop>
                myVLS.HwStop = LibGlobalSource.NOCHILD;
                ///<RefRcvLN></RefRcvLN>
                myVLS.RefRcvLN = LibGlobalSource.NOCHILD;
                ///<RefRcvHN></RefRcvHN>
                myVLS.RefRcvHN = LibGlobalSource.NOCHILD;
                ///<RefSndBin></RefSndBin>
                myVLS.RefSndBin = LibGlobalSource.NOCHILD;
                ///<RefAsp></RefAsp>
                myVLS.RefAsp = LibGlobalSource.NOCHILD;
                #endregion
                if (createMode.BML)
                {
                    string commName;
                    int noOfSubIO = 0;
                    int IO = dataGridBML.Rows.Count;
                    bool[] objChecked=new bool[dataGridBML.Rows.Count];
                    string vlsSubtype;
                    string vlsCabniet=string.Empty;
                    string vlsCabnietGroup = string.Empty;
                    string vlsElevation=string.Empty;   
                    DataGridViewCell cell;
                    //DataGridViewCell cell;
                    listBMLName = LibGlobalSource.BMLHelper.ExtractUniqueCommonSubstringsWithCount(dataGridBML, nameof(BML.VLS.ColumnName));  
                    ProgressBar.Maximum = quantityNeedToBeCreate - 1;
                    ProgressBar.Value = 0;
                                   
                    for (int i = 0; i < quantityNeedToBeCreate; i++)
                    {
                        commName = Convert.ToString(listBMLName[i].Key.ToString());
                        noOfSubIO = (int)listBMLName[i].Value;
                        int noOfSubChecked = 0;
                        //cell = dataGridBML.Rows[i].Cells[nameof(BML.VLS.ColumnName)];
                        if (String.IsNullOrEmpty(myVLS.Name))
                        { 
                            continue;
                        }
                        myVLS.Name= commName + txtVLSSuffixBML.Text;
                        for (int row = 0; row < dataGridBML.Rows.Count; row++)
                        {                    
                            if (objChecked[row])
                            { continue; }     
                            if (noOfSubChecked>= noOfSubIO)
                            { break; }
                            cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnName)];
                            if(Convert.ToString(cell.Value).StartsWith(commName))
                            {
                                noOfSubChecked += 1;
                                objChecked[row] = true;
                                cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnDesc)];
                                vlsSubtype = Convert.ToString(cell.Value);
                                if (vlsSubtype.Equals(BML.VLS.ManualFlap))
                                {
                                    myVLS.SubType = VLS.VMF;
                                    myVLS.PType = VLS.P7082;
                                }
                                else if(vlsSubtype.Equals(BML.VLS.PneFlap))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                    }
                                    myVLS.PType = VLS.P7082;
                                }
                                else if (vlsSubtype.Equals(BML.VLS.ManualSlideGate))
                                {
                                    myVLS.SubType = VLS.VMF;
                                    myVLS.PType = VLS.P7081;
                                }
                                else if (vlsSubtype.Equals(BML.VLS.PneSlideGate))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                    }
                                    myVLS.PType = VLS.P7081;
                                }
                                else if (vlsSubtype.Equals(BML.VLS.PneTwoWayValve))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                    }
                                    myVLS.PType = VLS.P7082;
                                }
                                else if (vlsSubtype.Equals(BML.VLS.PneShutOffValve))
                                {
                                    switch (noOfSubIO)
                                    {
                                        case 3:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                        case 4:
                                            myVLS.SubType = VLS.VPO;
                                            break;
                                        default:
                                            myVLS.SubType = VLS.VCO;
                                            break;
                                    }
                                        myVLS.PType = VLS.P7081;
                                }
                                if  (noOfSubChecked==1)
                                {
                                    cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnCabinet)];
                                    vlsCabniet = Convert.ToString(cell.Value);
                                    cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnCabinetGroup)];
                                    vlsCabnietGroup = Convert.ToString(cell.Value);
                                    cell = dataGridBML.Rows[row].Cells[nameof(BML.VLS.ColumnFloor)];
                                    vlsElevation = Convert.ToString(cell.Value);
                                }
                            }        
                        }                  
                        NameSubElements(commName);
                        myVLS.InpLN =String.IsNullOrEmpty(TxtInpLN.Text)?LibGlobalSource.NOCHILD: TxtInpLN.Text;
                        myVLS.OutpLN = String.IsNullOrEmpty(TxtOutpLN.Text) ? LibGlobalSource.NOCHILD : TxtOutpLN.Text;
                        myVLS.InpHN = String.IsNullOrEmpty(TxtInpHN.Text) ? LibGlobalSource.NOCHILD : TxtInpHN.Text;
                        myVLS.OutpHN = String.IsNullOrEmpty(TxtOutpHN.Text) ? LibGlobalSource.NOCHILD : TxtOutpHN.Text;
                        myVLS.InpRunRev = String.IsNullOrEmpty(txtInpRunRev.Text) ? LibGlobalSource.NOCHILD : txtInpRunRev.Text;
                        myVLS.InpRunFwd = String.IsNullOrEmpty(txtInpRunFwd.Text) ? LibGlobalSource.NOCHILD : txtInpRunFwd.Text;
                        myVLS.Description = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.VLS.ColumnDesc)].Value);
                        myVLS.Panel_ID = vlsCabniet.StartsWith(BML.VLS.PrefixLocalPanel) ? vlsCabniet : vlsCabnietGroup + vlsCabniet;
                        myVLS.Elevation= vlsElevation;
                        myVLS.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = i;
                    }
                    listBMLName.Clear();
                }
                else if (createMode.AutoSearch)
                {
                    List<string> objList = new List<string>();
                    List<int> objOutpKeyList = new List<int>();
                    List<int> objInpKeyList = new List<int>();
                    string filter = $@"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.DIC} AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, null, GcproTable.ObjData.Key.Name, GcproTable.ObjData.Text0.Name);

                    objInpKeyList = OleDb.GetColumnData<int>(dataTable, GcproTable.ObjData.Key.Name);
                    objList = OleDb.GetColumnData<string>(dataTable, GcproTable.ObjData.Text0.Name);
                    for (int i = 0; i <= objList.Count - 1; i++)
                    {
                        objList[i] = AppGlobal.GetObjectSymbolFromIO(objList[i]);
                    }
                    quantityNeedToBeCreate = objInpKeyList.Count;
                    ProgressBar.Maximum = quantityNeedToBeCreate - 1;
                    ProgressBar.Value = 0;
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
                        { description.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtDescription.Text, txtDescriptionRule.Text); }
                    }
                    for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
                    {
                        myVLS.Name = objList[i];
                        myVLS.InpLN = objInpKeyList[i].ToString();
                        myVLS.InpHN = AppGlobal.FindIOKey(oledb, $"{objList[i]}:O");
                        objCreated = i;
                        myVLS.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = objCreated;
                    }
                }
                else if (createMode.Rule)
                {
                    ///<Elevation></Elevation>
                    string selectedElevation;
                    if (ComboElevation.SelectedItem != null)
                    {
                        selectedElevation = ComboElevation.SelectedItem.ToString();
                        myVLS.Elevation = selectedElevation;
                    }
                    ///<Panel_ID></Panel_ID>
                    string selectedPanel_ID;
                    if (ComboPanel.SelectedItem != null)
                    {
                        selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                        myVLS.Panel_ID = selectedPanel_ID;
                    }
                    ///<IsNew>is set when object generated,Default value is "No"</IsNew>

                    ///<SubType></SubType>
                    string selectedSubTypeItem;
                    if (ComboEquipmentSubType.SelectedItem != null)
                    {
                        selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                        myVLS.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                        //   motorWithVFC= (myVLS.SubType == VLS.VCO|| myVLS.SubType == VLS.VPO)? true : false;
                    }
                    else
                    {
                        myVLS.SubType = VLS.VCO;
                    }
                    ///<PType></PType>
                    string selectedPTypeItem;
                    if (ComboEquipmentInfoType.SelectedItem != null)
                    {
                        selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                        myVLS.PType = selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                    }
                    else
                    {
                        myVLS.PType = VLS.P7081;
                    }
                    ///<FieldBusNode></FieldBusNode>
                    myVLS.FieldBusNode = LibGlobalSource.NOCHILD; ;
                    ///<DPNode1></DPNode1>
                    string selectDPNode1 = String.Empty;
                    if (ComboDPNode1.SelectedItem != null)
                    {
                        selectDPNode1 = ComboDPNode1.SelectedItem.ToString();
                        oledb.IsNewOLEDBDriver = isNewOledbDriver;
                        oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                        myVLS.DPNode1 = AppGlobal.FindDPNodeNo(oledb, selectDPNode1);
                        int dpnode1 = int.Parse(myVLS.DPNode1);
                        myVLS.FieldBusNode = AppGlobal.FindFieldbusNodeKey(oledb, dpnode1);
                    }
                    ///<DPNode2></DPNode2>
                    string selectDPNode2 = String.Empty;
                    if (ComboDPNode2.SelectedItem != null)
                    {
                        selectDPNode2 = ComboDPNode2.SelectedItem.ToString();
                        myVLS.DPNode2 = AppGlobal.FindDPNodeNo(oledb, selectDPNode2);
                    }
                    if (ComboHornCode.SelectedItem != null)
                    {
                        string hornCode = ComboHornCode.SelectedItem.ToString();
                        myVLS.HornCode = hornCode.Substring(0, 2);
                    }
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
                       // needDPNodeChanged = motorWithVFC;
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
                        //if (!motorWithVFC)
                        //{
                        //    // myVLS.InpFwd = AppGlobalSource.FindIOKey(oledb, $"{name.Name}:I");
                        //    // myVLS.OutpFwd = AppGlobalSource.FindIOKey(oledb, $"{name.Name}:O");
                        //    if (myVLS.SubType == VLS.VCO)
                        //    {
                        //        myVLS.InpFwd = $"{name.Name}:{txtInpFwdSuffix}";
                        //        myVLS.OutpFwd = $"{name.Name}:{txtOutpFwdSuffix}";
                        //    }
                        //    else if (myVLS.SubType == VLS.M12)
                        //    {
                        //        myVLS.InpFwd = $"{name.Name}{txtInpFwdSuffix.Text}";
                        //        myVLS.OutpFwd = $"{name.Name}{txtOutpFwdSuffix.Text}";
                        //        myVLS.InpRev = $"{name.Name}{txtInpRevSuffix.Text}";
                        //        myVLS.OutpRev = $"{name.Name}{txtOutpRevSuffix.Text}";
                        //    }
                        //}
                        //else 
                        //{
                        //    myVLS.Adapter = $"{name.Name}{txtVFCSuffix.Text}";
                        //}                     
               
                        myVLS.HwStop = String.IsNullOrEmpty(txtInHWStop.Text)?string.Empty:txtInHWStop.Text;

                        if (needDPNodeChanged && moreThanOne)
                        {
                            dpNode1.Inc = i * symbolInc;
                            dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());
                            myVLS.DPNode1 = AppGlobal.FindDPNodeNo(oledb, dpNode1.Name);

                            int dpnode1 = int.Parse(myVLS.DPNode1);
                            myVLS.FieldBusNode = AppGlobal.FindFieldbusNodeKey(oledb, dpnode1);
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
                            description.Name = "阀门";
                        }
                        myVLS.Name = name.Name;
                        myVLS.Description = description.Name;
                        objCreated = i;
                        myVLS.CreateObject(Encoding.Unicode);
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
