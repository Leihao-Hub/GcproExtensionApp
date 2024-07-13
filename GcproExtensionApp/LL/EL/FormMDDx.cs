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
#endregion
namespace GcproExtensionApp
{
    public partial class FormMDDx : Form, IGcForm
    {
        public FormMDDx()
        {
            InitializeComponent();
        }
 
        #region Public object in this class
        MDDx myMDDx = new MDDx(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private string DEMO_NAME_MDDx = "=A-4001-KCL30";
        private string DEMO_NAME_RULE_MDDx = "4001";
        private string DEMO_DESCRIPTION_MDDx = "xxx磨机控制器/或者空白";
        private string DEMO_DESCRIPTION_RULE_MDDx = "";
        #endregion
        private long value25 = 0;
        private long value26 = 0;
        private long value27 = 0;
        private long value28 = 0;
        private int value10 = 0;
        private int tempInt = 0;
        private long tempLong = 0;
        private float tempFloat = (float)0.0;
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
            ///<ReaMDDxnfoFromGcsLibrary> 
            ///Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary 
            ///</ReaMDDxnfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={MDDx.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {MDDx.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + MDDx.OTypeValue}'",
                null, "Text ASC", "Text");
            list = OleDb.GetColumnData<string>(dataTable, GcproTable.TranslationCbo.FieldText.Name);
            foreach (var column in list)
            {

                ComboEquipmentInfoType.Items.Add(column.ToString());
            }
            ComboEquipmentInfoType.SelectedIndex = 1;
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
            txtSymbolRule.Text = MDDx.Rule.Common.NameRule;
            txtSymbolIncRule.Text = MDDx.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = MDDx.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = MDDx.Rule.Common.DescriptionRuleInc;

        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + MDDx.OType);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_MDDx);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_MDDx);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_MDDx);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_MDDx);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;          
            dataTable=oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{MDDx.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);         
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{MDDx.ImpExpRuleName}'", null);
                    CreateDIImpExp(oledb);
                }
                else
                { 
                    return; 
                }
            }
            else
            { 
                CreateDIImpExp(oledb); 
            }

        }
        public void Default()
        {
            txtSymbol.Focus();
            
            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            txtValue10.Text = "0";
            myMDDx.Value10 = "0";            
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "MDDx导入文件 " + " " + myMDDx.FilePath;         
        }

        #endregion
        private void CreateDIImpExp(OleDb oledb)
        {

            List<List<GcproExtensionLibrary.Gcpro.DbParameter>> recordList = new List<List<GcproExtensionLibrary.Gcpro.DbParameter>>
                    {
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value =MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Type" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.OType.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Name" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Text0.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Description" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.Text1.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SubType" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.SubType.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ProcessFct" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.ProcessFct.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Building" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Building.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Elevation" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Elevation.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "FieldBusNode" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.FieldbusNode.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Panel ID"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Panel_ID.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Diagram"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DiagramNo.Name}

                    },
                        new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Page"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.PageName.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "PType"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value5.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Horn Code"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value2.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DP node1"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode1.Name }

                    },      
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Gcpro parameters"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value9.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Object parameters"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value10.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpTrue"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpFaultDev"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value19.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InHWStop"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value47.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpFaultReset"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpPowerOff" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpLamp" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayChange"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayTrue"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayFalse"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTimeoutTrue"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTimeoutFalse"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Special"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value46.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "MRMAMixer"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Is new" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.IsNew.Name }

                    }
                };
            if (oledb.InsertMultipleRecords(GcproTable.ImpExpDef.TableName, recordList))
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormMDDx_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormMDDx_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
       
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                MDDx.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    MDDx.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }

        private void TxtDescriptionRule_TextChanged(object sender, EventArgs e)
        {

            if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
            {
                MDDx.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
            }
            else
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        private void TxtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobal.CheckNumericString(txtDescriptionIncRule.Text))
                {
                    MDDx.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }
  
        private void txtValue10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value10 = AppGlobal.ParseInt(txtValue10.Text, out tempInt) ? tempInt : value10;
                GetValue10BitValue(value10);
            }
        }

        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"    
   
        //private void chkMonCovered_CheckedChanged(object sender, EventArgs e)
        //{
        //    value9 = int.Parse(txtValue9.Text);
        //    if (chkMonCovered.Checked)

        //    { AppGlobal.SetBit(ref value9, (byte)12); }

        //    else
        //    { AppGlobal.ClearBit(ref value9, (byte)12); }

        //    myMDDx.Value9 = value9.ToString();
        //    txtValue9.Text = myMDDx.Value9;
        //}
      
      
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
        private void txtInpTrue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        } 
        private void txtInHWStop_MouseEnter(object sender, EventArgs e)
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
        private void txtDelayChange_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }
        private void txtDelayTrue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }
        private void txtDelayFalse_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }
        private void txtTimeoutTrue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }
        private void txtTimeoutFalse_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }
        private void chkParLogOff_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit0";
        }
        private void chkParPulsing_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }
        private void chkParFaultRetry_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit3";
        }
        private void chkParBinLevel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit4";
        }
        private void chkInterlockNextObject_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit0";
        }
        private void chkInvertInput_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit1";
        }
        private void chkMonTrue_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit2";
        }
        private void chkMonCovered_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit12";
        }
        private void chkMonFalse_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit3";
        }
        private void chkMonUnCovered_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit13";
        }
        private void chkInPreAlarm_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit4";
        }
        private void chKInpFaultDev_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit6";
        }
        #endregion
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            
            myMDDx.Name = txtSymbol.Text;
        }
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value21.Name;
            objectBrowser.OType = Convert.ToString(MDDx.OTypeValue);
            objectBrowser.Show();
        }
        void SubTypeChanged(string subType)
        {
            if (subType == DI.MON2BS)
            {
               
            }
          
         
        }
        void GetValue10BitValue(int value)
        {
            chkParLogOff.Checked = AppGlobal.GetBitValue(value, 0);
           
        }
        void GetValue25BitValue(long value)
        {
        
        }
        void GetValue26BitValue(long value)
        {

        }
        void GetValue27BitValue(long value)
        {

        }
        void GetValue28BitValue(long value)
        {

        }
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myMDDx.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SubTypeChanged(myMDDx.SubType);
                if (myMDDx.SubType == DI.DIC || myMDDx.SubType == DI.MON1MVC)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(DI.P7154))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }                
                }
                                                          
                GetValue10BitValue(value10);
                GetValue25BitValue(value25);
                GetValue26BitValue(value26);
                GetValue27BitValue(value27);
                GetValue28BitValue(value28);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
   

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
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.MDDx.Path", BML.DI.BMLPath);
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
        private void dataGridBML_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TxtQuantity.Text = dataGridBML.Rows.Count.ToString();
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
                comboIORemarkBML.Items.Add(item);
                comboLineBML.Items.Add(item);
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
                comboControlBML.SelectedItem = "H";
                comboIORemarkBML.SelectedItem = "R";
                comboLineBML.SelectedItem = "X";
            }
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text=BML.DI.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.DI.ColumnName; 
            nameColumn.Name = nameof(BML.DI.ColumnName);                                                
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.DI.ColumnDesc;
            descColumn.Name = nameof(BML.DI.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);

            DataGridViewTextBoxColumn diTypeColumn = new DataGridViewTextBoxColumn();
            diTypeColumn.HeaderText = BML.DI.ColumnDIType;
            diTypeColumn.Name = nameof(BML.DI.ColumnDIType);
            dataGridBML.Columns.Add(diTypeColumn);

            DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            floorColumn.HeaderText = BML.DI.ColumnFloor;
            floorColumn.Name = nameof(BML.DI.ColumnFloor);
            dataGridBML.Columns.Add(floorColumn);

            DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            cabinetColumn.HeaderText = BML.DI.ColumnCabinet;
            cabinetColumn.Name = nameof(BML.DI.ColumnCabinet);
            dataGridBML.Columns.Add(cabinetColumn);

            DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            cabinetColumnGroup.HeaderText = BML.DI.ColumnCabinetGroup;
            cabinetColumnGroup.Name = nameof(BML.DI.ColumnCabinetGroup);
            dataGridBML.Columns.Add(cabinetColumnGroup);

            DataGridViewTextBoxColumn ioRemarkColumn = new DataGridViewTextBoxColumn();
            ioRemarkColumn.HeaderText = BML.DI.ColumnIORemark;
            ioRemarkColumn.Name = nameof(BML.DI.ColumnIORemark);
            dataGridBML.Columns.Add(ioRemarkColumn);

            DataGridViewTextBoxColumn lineColumn = new DataGridViewTextBoxColumn();
            lineColumn.HeaderText = BML.DI.ColumnLine;
            lineColumn.Name = nameof(BML.DI.ColumnLine);
            dataGridBML.Columns.Add(lineColumn);

        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboTypeBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboIORemarkBML.Text,comboLineBML.Text};
           StringBuilder sbFilters = new StringBuilder();
            sbFilters.Append($@"Value LIKE ""%{BML.DI.BeltMonitor}"" || ").Append($@"Value LIKE ""%{BML.DI.EmergencyStop}"" || ").Append($@"Value LIKE ""%{BML.DI.Explosion}"" || ")
                 .Append($@"Value LIKE ""%{BML.DI.HighLevel}"" || ").Append($@"Value LIKE ""%{BML.DI.LimitSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.LowLevel}"" || ")
                 .Append($@"Value LIKE ""%{BML.DI.MiddleLevel}"" || ").Append($@"Value LIKE ""%{BML.DI.Overflow}"" ||").Append($@"Value LIKE ""%{BML.DI.PSw}"" || ")
                 .Append($@"Value LIKE ""%{BML.DI.PushButton}"" || ").Append($@"Value LIKE ""%{BML.DI.SafetySwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.SpeedMonitor}"" || ")
                 .Append($@"Value LIKE ""%{BML.DI.TemperatureSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.VibrationSwitch}"" || ").Append($@"Value LIKE ""%{BML.DI.ZeroSpeedMonitor}""");
            StringBuilder sbValveFilters = new StringBuilder();
            sbValveFilters.Append($@"Value NOT LIKE ""%{BML.VLS.ManualFlap}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneFlap}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneTwoWayValve}"" && ")
           .Append($@"Value NOT LIKE ""%{BML.VLS.PneSlideGate}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.ManualSlideGate}"" && ").Append($@"Value NOT LIKE ""%{BML.VLS.PneShutOffValve}"" && ")
           .Append($@"Value NOT LIKE ""%{BML.VLS.PneAspValve}""");
            DataTable dataTable = new DataTable();
            string[] filters = {sbFilters .ToString(), sbValveFilters.ToString()};
            string[] filterColumns = { comboTypeBML.Text ,comboDescBML.Text};
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);

            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.DI.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.DI.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.DI.ColumnDIType)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.DI.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.DI.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.DI.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.DI.ColumnIORemark)].DataPropertyName = dataTable.Columns[6].ColumnName;
            dataGridBML.Columns[nameof(BML.DI.ColumnLine)].DataPropertyName = dataTable.Columns[7].ColumnName;
            TxtQuantity.Text = dataTable.Rows.Count.ToString();
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
                txtSymbolRule.Text = MDDx.Rule.Common.NameRule;
                txtSymbolIncRule.Text = MDDx.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_MDDx;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;
               
            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = DI.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DI.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                GrpSymbolRule.Visible = false;
                LblSymbol.Text = AppGlobal.KEY_WORD_AUTOSEARCH;
                txtSymbol.Text = "-BLH01";
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
                myMDDx.Clear();
                ProgressBar.Value = 0;  
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            MDDx.SaveFileAs(myMDDx.FilePath, LibGlobalSource.CREATE_OBJECT);
            MDDx.SaveFileAs(myMDDx.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
        void AppendInfoToBuilder(CheckBox checkBox, string info, StringBuilder builder)
        {
            if (checkBox.Checked)
            {
                builder.Append(info);
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
                StringBuilder descTotalBuilder = new StringBuilder();
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
                #region Prepare export DI file
                ///<OType>is set when object generated</OType>
                ///<SubType></SubType>
                string selectedSubTypeItem;
                if (ComboEquipmentSubType.SelectedItem != null)
                {
                    selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                    myMDDx.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                 
                }
                else
                {
                    myMDDx.SubType = DI.DIC;
                }
                ///<PType></PType>
                string selectedPTypeItem;
                if (ComboEquipmentInfoType.SelectedItem != null)
                {
                    selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                    myMDDx.PType = selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                else
                {
                    myMDDx.PType = DI.P7154;
                }
                ///<Value10</Value10
                myMDDx.Value10= value10.ToString();            
                ///<Value10>Value is set when corresponding check box's check state changed</Value10>
                ///<Name>Value is set in TxtSymbol text changed event</Name>
                ///<Description></Description>
                myMDDx.Description = txtDescription.Text;
                ///<ProcessFct></ProcessFct>
                string selectedProcessFct = string.Empty;
                if (ComboProcessFct.SelectedItem != null)
                {
                    selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                    myMDDx.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Diagram></Diagram>
                string selectedDiagram;
                if (ComboDiagram.SelectedItem != null)
                {
                    selectedDiagram = ComboDiagram.SelectedItem.ToString();
                    myMDDx.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
         
                ///<Page></Page>
                myMDDx.Page = txtPage.Text;
                ///<Building></Building>
                string selectedBudling = "--";
                if (ComboBuilding.SelectedItem != null)
                {
                    selectedBudling = ComboBuilding.SelectedItem.ToString();
                    myMDDx.Building = selectedBudling;
                }
                ///<Elevation></Elevation>
                string selectedElevation;
                if (ComboElevation.SelectedItem != null)
                {
                    selectedElevation = ComboElevation.SelectedItem.ToString();
                    myMDDx.Elevation = selectedElevation;
                }
                ///<Panel_ID></Panel_ID>
                string selectedPanel_ID;
                if (ComboPanel.SelectedItem != null)
                {
                    selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                    myMDDx.Panel_ID = selectedPanel_ID;
                }
                ///<IsNew>is set when object generated,Default value is "No"</IsNew>
                ///<FieldBusNode></FieldBusNode>
                myMDDx.FieldBusNode = LibGlobalSource.NOCHILD; ;
                ///<DPNode1></DPNode1>
                string selectDPNode1 = String.Empty;
                if (ComboDPNode1.SelectedItem != null)
                {
                    selectDPNode1 = ComboDPNode1.SelectedItem.ToString();
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    myMDDx.DPNode1 = AppGlobal.FindDPNodeNo(oledb, selectDPNode1);
                    int dpnode1 = int.Parse(myMDDx.DPNode1);
                    myMDDx.FieldBusNode = AppGlobal.FindFieldbusNodeKey(oledb, dpnode1);
                }            
                if (ComboHornCode.SelectedItem != null)
                {
                    string hornCode = ComboHornCode.SelectedItem.ToString();
                    myMDDx.HornCode = hornCode.Substring(0, 2);
                }
                ///<IOByteNo></IOByteNo>
                myMDDx.IoByteNo= LibGlobalSource.NOCHILD;              
                #endregion
                if (createMode.BML)
                {
                    ProgressBar.Maximum = dataGridBML.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    SuffixObject suffixObject = new SuffixObject();
                    string cabinet,cabinetGroup;
                    string _nameNumberString;
                    string _nameBin;
                    Bin _bin = new Bin(AppGlobal.GcproDBInfo.GcproTempPath);
                    for (int i = 0; i < dataGridBML.Rows.Count; i++)
                    {
                        DataGridViewCell cell;
                        cell = dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnName)];
                        if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                        { continue; }
                        string _subType = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnDIType)].Value);
                        string desc = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnDesc)].Value);

                        if (_subType == BML.DI.SpeedMonitor && desc == BML.MachineType.Elevator)
                        { continue; }
                        ///<AdditionInfoToDesc></AdditionInfoToDesc>
                        descTotalBuilder.Clear();
                        myMDDx.Name = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnName)].Value);
                        string ioRemark = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnIORemark)].Value);
                        if (chkAddSectionToDesc.Checked)
                        {
                            _nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameOnlyWithNumber, myMDDx.Name);
                            if (!string.IsNullOrEmpty(_nameNumberString))
                            {
                                if (AppGlobal.ParseInt(_nameNumberString, out tempInt))
                                {
                                    descTotalBuilder.Append(GcObjectInfo.Section.ReturnSection(tempInt));
                                }
                            }
                        }
                       
                        if (!(myMDDx.Name.Contains(suffixObject.GetKey("BLH")) || myMDDx.Name.Contains(suffixObject.GetKey("BLL"))))
                        {
                            descTotalBuilder.Append($"{desc}");
                        }
                      
                        cabinet = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnCabinet)].Value);
                        cabinetGroup = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnCabinetGroup)].Value);
                        myMDDx.Panel_ID = cabinet.StartsWith(BML.PrefixLocalPanel) ? cabinet : cabinetGroup + cabinet;
                        myMDDx.Elevation = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnFloor)].Value);
                       
                        #region Subtype and PType           
                                
                        SubTypeChanged(myMDDx.SubType);
                        #endregion
                        ///<AdditionInfoToDesc>
                        ///</AdditionInfoToDesc>
                        bool additionInfToDesc = chkAddNameToDesc.Checked || chkAddFloorToDesc.Checked ||
                              chkAddCabinetToDesc.Checked;
                        if (additionInfToDesc)
                        {
                            descTotalBuilder.Append("[");
                            AppendInfoToBuilder(chkAddNameToDesc, $"{GcObjectInfo.General.AddInfoSymbol}{LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameWithoutTypeLL, myMDDx.Name)}", descTotalBuilder);
                            AppendInfoToBuilder(chkAddFloorToDesc, $" {GcObjectInfo.General.AddInfoElevation}{myMDDx.Elevation}", descTotalBuilder);
                            AppendInfoToBuilder(chkAddCabinetToDesc, $" {GcObjectInfo.General.AddInfoCabinet}{myMDDx.Panel_ID}", descTotalBuilder);
                            descTotalBuilder.Append("]");
                        }                                        
                        myMDDx.Description = descTotalBuilder.ToString();                     
                        myMDDx.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = i;
                    }
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
                        myMDDx.Name = objList[i];
                        //myMDDx.InpFwd = objInpKeyList[i].ToString();
                        //myMDDx.OutpFwd = AppGlobal.FindIOKey(oledb, $"{objList[i]}:O");
                        objCreated = i;
                        myMDDx.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = objCreated;
                    }
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
                                                                                                         
                     //   myMDDx.HWStop = String.IsNullOrEmpty(txtInHWStop.Text)?string.Empty:txtInHWStop.Text;

                        if (needDPNodeChanged && moreThanOne)
                        {
                            dpNode1.Inc = i * symbolInc;
                            dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());
                            myMDDx.DPNode1 = AppGlobal.FindDPNodeNo(oledb, dpNode1.Name);

                            int dpnode1 = int.Parse(myMDDx.DPNode1);
                            myMDDx.FieldBusNode = AppGlobal.FindFieldbusNodeKey(oledb, dpnode1);
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
                            description.Name = "--";
                        }
                        myMDDx.Name = name.Name;
                        myMDDx.Description = description.Name;
                        objCreated = i;
                        myMDDx.CreateObject(Encoding.Unicode);
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
