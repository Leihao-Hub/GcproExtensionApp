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
        private long value26 = 286752;
        private long value27 = 0;
        private long value28 = 804672;
        private int value10 = 0;
        private int tempInt = 0;
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
                    CreateMDDxImpExp(oledb);
                }
                else
                { 
                    return; 
                }
            }
            else
            { 
                CreateMDDxImpExp(oledb); 
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
            txtValue26.Text = "286752";
            txtValue28.Text = "804672";
            txtIOByteIncRule.Text = MDDx.IOByteLen;
            ComboEquipmentSubType.SelectedIndex = 0;
            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "MDDx导入文件 " + " " + myMDDx.FilePath;         
        }

        #endregion
        private void CreateMDDxImpExp(OleDb oledb)
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
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Object parameters"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value10.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "IOByteNo"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Value25"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Value26"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Value27"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value27.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Value28" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value28.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Top MYTA" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Top PassageNo"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value36.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Bottom MYTA"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value33.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Bottom PassageNo"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value37.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 Top MYTA" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="Side2 Top PassageNo"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name }

                    },
                      new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 Bottom MYTA"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value35.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = MDDx.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 Bottom PassageNo"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value39.Name}

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
       
        private void txtSymbolRule_TextChanged(object sender, EventArgs e)
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

        private void txtSymbolIncRule_KeyDown(object sender, KeyEventArgs e)
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

        private void txtDescriptionRule_TextChanged(object sender, EventArgs e)
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
        private void txtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
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
        private void txtParIOByte_TextChanged(object sender, EventArgs e)
        {
         
                if (AppGlobal.CheckNumericString(txtParIOByte.Text))
                {
                    MDDx.Rule.Common.DescriptionRuleInc = txtParIOByte.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
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
        private void chkParLogOff_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParLogOff.Checked)

            { AppGlobal.SetBit(ref value10, (byte)0); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)0); }
            myMDDx.Value10 = value10.ToString();
            txtValue10.Text = myMDDx.Value10;
        }

        private void chkParSide1Divided_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParSide1Divided.Checked)

            { AppGlobal.SetBit(ref value10, (byte)1); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }
            myMDDx.Value10 = value10.ToString();
            txtValue10.Text = myMDDx.Value10;
        }

        private void chkParSide2Divided_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParSide2Divided.Checked)

            { AppGlobal.SetBit(ref value10, (byte)2); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }
            myMDDx.Value10 = value10.ToString();
            txtValue10.Text = myMDDx.Value10;
        }

        private void chkParWithBearTemp_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithBearTemp.Checked)

            { AppGlobal.SetBit(ref value10, (byte)3); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)3); }
            myMDDx.Value10 = value10.ToString();
            txtValue10.Text = myMDDx.Value10;
        }

        private void chkParWithFeedRollRecipe_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithFeedRollRecipe.Checked)

            { AppGlobal.SetBit(ref value10, (byte)4); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)4); }
            myMDDx.Value10 = value10.ToString();
            txtValue10.Text = myMDDx.Value10;
        }

        private void chkParWithRollerTemp_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithRollerTemp.Checked)

            { AppGlobal.SetBit(ref value10, (byte)5); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)5); }
            myMDDx.Value10 = value10.ToString();
            txtValue10.Text = myMDDx.Value10;
        }

        private void chkParWithRollerGapRecipe_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithRollerGapRecipe.Checked)

            { AppGlobal.SetBit(ref value10, (byte)6); }
            else
            { AppGlobal.ClearBit(ref value10, (byte)6); }
            myMDDx.Value10 = value10.ToString();
            txtValue10.Text = myMDDx.Value10;
        }


        private void chkWarningAx07Range_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningAx07Range.Checked)

            { AppGlobal.SetBit(ref value26, (byte)7); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)7); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningA018Battery_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningA018Battery.Checked)

            { AppGlobal.SetBit(ref value26, (byte)5); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)5); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningA024Empty_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningA024Empty.Checked)

            { AppGlobal.SetBit(ref value26, (byte)18); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)18); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningAx30Zero_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningAx30Zero.Checked)

            { AppGlobal.SetBit(ref value26, (byte)6); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)6); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningAx32Rod_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningAx32Rod.Checked)

            { AppGlobal.SetBit(ref value26, (byte)8); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)8); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningAx50FRoll1_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningAx50FRoll1.Checked)

            { AppGlobal.SetBit(ref value26, (byte)9); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)9); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningAx51FRoll2_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningAx51FRoll2.Checked)

            { AppGlobal.SetBit(ref value26, (byte)10); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)10); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningA052RollUp_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningA052RollUp.Checked)

            { AppGlobal.SetBit(ref value26, (byte)11); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)11); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningA053RollLow_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningA053RollLow.Checked)

            { AppGlobal.SetBit(ref value26, (byte)12); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)12); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningA054MotUp_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningA054MotUp.Checked)

            { AppGlobal.SetBit(ref value26, (byte)13); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)13); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningA055MotLow_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningA055MotLow.Checked)

            { AppGlobal.SetBit(ref value26, (byte)14); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)14); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningA056STBYUP_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningA056STBYUP.Checked)

            { AppGlobal.SetBit(ref value26, (byte)15); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)15); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningA057STBYDN_CheckedChanged(object sender, EventArgs e)
        {
            value26 = int.Parse(txtValue26.Text);
            if (chkWarningA057STBYDN.Checked)

            { AppGlobal.SetBit(ref value26, (byte)16); }
            else
            { AppGlobal.ClearBit(ref value26, (byte)16); }
            myMDDx.Value26 = value26.ToString();
            txtValue26.Text = myMDDx.Value26;
        }

        private void chkWarningAx60HLInlet_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningAx60HLInlet.Checked)

            { AppGlobal.SetBit(ref value28, (byte)1); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)1); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningA061HLOut1_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningA061HLOut1.Checked)

            { AppGlobal.SetBit(ref value28, (byte)2); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)2); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningA062HLOut2_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningA062HLOut2.Checked)

            { AppGlobal.SetBit(ref value28, (byte)3); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)3); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningA063HLOut3_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningA063HLOut3.Checked)

            { AppGlobal.SetBit(ref value28, (byte)4); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)4); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningA064HLBackupLeft_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningA064HLBackupLeft.Checked)

            { AppGlobal.SetBit(ref value28, (byte)5); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)5); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningW065HLBackupLeft_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningW065HLBackupLeft.Checked)

            { AppGlobal.SetBit(ref value28, (byte)6); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)6); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningA066HLBackupRight_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningA066HLBackupRight.Checked)

            { AppGlobal.SetBit(ref value28, (byte)7); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)7); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningW067HLBackupRight_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningW067HLBackupRight.Checked)

            { AppGlobal.SetBit(ref value28, (byte)8); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)8); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningAx68InletFull_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningAx68InletFull.Checked)

            { AppGlobal.SetBit(ref value28, (byte)9); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)9); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }

        private void chkWarningAx69DosMax_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningAx69DosMax.Checked)

            { AppGlobal.SetBit(ref value28, (byte)10); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)10); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }
        private void chkWarningW075WarnTemp_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningW075WarnTemp.Checked)

            { AppGlobal.SetBit(ref value28, (byte)14); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)14); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }
        private void chkWarningA110Gap_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningA110Gap.Checked)

            { AppGlobal.SetBit(ref value28, (byte)18); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)18); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
        }
        private void chkWarningA111GapSet_CheckedChanged(object sender, EventArgs e)
        {
            value28 = int.Parse(txtValue28.Text);
            if (chkWarningA111GapSet.Checked)

            { AppGlobal.SetBit(ref value28, (byte)19); }
            else
            { AppGlobal.ClearBit(ref value28, (byte)19); }
            myMDDx.Value28 = value28.ToString();
            txtValue28.Text = myMDDx.Value28;
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
        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            myMDDx.Name = txtSymbol.Text;
        }
        #endregion
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value21.Name;
            objectBrowser.OType = Convert.ToString(MDDx.OTypeValue);
            objectBrowser.Show();
        }
        void SubTypeChanged(string subType)
        {
            if (subType == MDDx.MDDRDP)

            {
                chkParSide1Divided.Enabled = chkParSide1Divided.Enabled=true;
            }         
            else
            {
                chkParSide1Divided.Enabled = chkParSide1Divided.Enabled = false;
            }
        }
        void GetValue10BitValue(int value)
        {
            chkParLogOff.Checked = AppGlobal.GetBitValue(value, 0);
            chkParSide1Divided.Checked = AppGlobal.GetBitValue(value, 1);
            chkParSide2Divided.Checked = AppGlobal.GetBitValue(value, 2);
            chkParWithBearTemp.Checked = AppGlobal.GetBitValue(value, 3);
            chkParWithFeedRollRecipe.Checked = AppGlobal.GetBitValue(value, 4);
            chkParWithRollerTemp.Checked = AppGlobal.GetBitValue(value, 5);
            chkParWithRollerGapRecipe.Checked = AppGlobal.GetBitValue(value, 6);
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
               // GetValue10BitValue(value10);
                //GetValue25BitValue(value25);
                //GetValue26BitValue(value26);
                //GetValue27BitValue(value27);
                //GetValue28BitValue(value28);
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
            BML.MDDx.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.MDDx.Path", BML.MDDx.BMLPath);
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
                comboLineBML.Items.Add(item);
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboCabinetBML.SelectedItem = "P";
                comboSectionBML.SelectedItem = "Q";
                comboControlBML.SelectedItem = "H";
                comboLineBML.SelectedItem = "X";
            }
            for (int i = 1; i <= 20; i++)
            {
                comboStartRow.Items.Add(i);
            }
            comboStartRow.SelectedItem = BML.StartRow;
            dataGridBML.AutoGenerateColumns = false;
            TxtExcelPath.Text=BML.MDDx.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.MDDx.ColumnName; 
            nameColumn.Name = nameof(BML.MDDx.ColumnName);                                                
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.MDDx.ColumnDesc;
            descColumn.Name = nameof(BML.MDDx.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);

            DataGridViewTextBoxColumn diTypeColumn = new DataGridViewTextBoxColumn();
            diTypeColumn.HeaderText = BML.MDDx.ColumnControlMethod;
            diTypeColumn.Name = nameof(BML.MDDx.ColumnControlMethod);
            dataGridBML.Columns.Add(diTypeColumn);

            DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            floorColumn.HeaderText = BML.MDDx.ColumnFloor;
            floorColumn.Name = nameof(BML.MDDx.ColumnFloor);
            dataGridBML.Columns.Add(floorColumn);

            DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            cabinetColumn.HeaderText = BML.MDDx.ColumnCabinet;
            cabinetColumn.Name = nameof(BML.MDDx.ColumnCabinet);
            dataGridBML.Columns.Add(cabinetColumn);

            DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            cabinetColumnGroup.HeaderText = BML.MDDx.ColumnCabinetGroup;
            cabinetColumnGroup.Name = nameof(BML.MDDx.ColumnCabinetGroup);
            dataGridBML.Columns.Add(cabinetColumnGroup);

            DataGridViewTextBoxColumn lineColumn = new DataGridViewTextBoxColumn();
            lineColumn.HeaderText = BML.MDDx.ColumnLine;
            lineColumn.Name = nameof(BML.MDDx.ColumnLine);
            dataGridBML.Columns.Add(lineColumn);

        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            string[] columnList = { comboNameBML.Text, comboDescBML.Text,comboControlBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboLineBML.Text,comboTypeBML.Text};
            StringBuilder sbControlFilters = new StringBuilder();
            sbControlFilters.Append($@"Value LIKE ""%{BML.MDDx.TypeMDDx}%""");
            StringBuilder sbTypeFilters = new StringBuilder();
            sbTypeFilters.Append($@"Value LIKE ""%{BML.MDDx.TypeKCL}""");
            DataTable dataTable = new DataTable();
            string[] filters = { sbControlFilters.ToString(), sbTypeFilters.ToString()};
            string[] filterColumns = { comboControlBML.Text ,comboTypeBML.Text};
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, filters, filterColumns, comboNameBML.Text, true);

            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;
            dataGridBML.Columns[nameof(BML.MDDx.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.MDDx.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.MDDx.ColumnControlMethod)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.MDDx.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.MDDx.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.MDDx.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.MDDx.ColumnLine)].DataPropertyName = dataTable.Columns[6].ColumnName;
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
                grpSymbolRule.Visible = true;
                lblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_MDDx;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;
               
            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = MDDx.Rule.Common.NameRule;
                txtSymbolIncRule.Text = MDDx.Rule.Common.NameRuleInc;
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
                oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                oledb.IsNewOLEDBDriver= isNewOledbDriver;
                DataTable dataTable = new DataTable();
                #region common used variables declaration       
                bool needDPNodeChanged = false;
                StringBuilder descTotalBuilder = new StringBuilder();
                int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
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
                #region Prepare export MDDx file
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
                    myMDDx.SubType = MDDx.MDDRDP;
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
                    myMDDx.PType = MDDx.P7366.ToString();
                }
                ///<Value10</Value10>
                myMDDx.Value10= value10.ToString();
                ///<Value25</Value25>
                myMDDx.Value25 = value25.ToString();
                ///<Value26</Value26>
                myMDDx.Value26 = value26.ToString();
                ///<Value27</Value27>
                myMDDx.Value27 = value27.ToString();
                ///<Value28</Value28>
                myMDDx.Value28 = value28.ToString();
                ///<Value10>Value is set when corresponding check box's check state changed</Value10>
                ///<Name>Value is set in TxtSymbol text changed event</Name>
                ///<Description></Description>
                myMDDx.Description = txtDescription.Text;
                ///<ProcessFct></ProcessFct>
                string selectedProcessFct = string.Empty;
                //if (ComboProcessFct.SelectedItem != null)
                //{
                //    selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                //    myMDDx.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                //}
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
                    string _nameNumberString=string.Empty;
                    Bin _bin = new Bin(AppGlobal.GcproDBInfo.GcproTempPath);
                    for (int i = 0; i < dataGridBML.Rows.Count; i++)
                    {
                        DataGridViewCell cell;
                        cell = dataGridBML.Rows[i].Cells[nameof(BML.MDDx.ColumnName)];
                        if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                        { continue; }
                                           
                        cabinet = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.MDDx.ColumnCabinet)].Value);
                        cabinetGroup = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.MDDx.ColumnCabinetGroup)].Value);
                        myMDDx.Panel_ID = cabinet.StartsWith(BML.PrefixLocalPanel) ? cabinet : cabinetGroup + cabinet;
                        myMDDx.Elevation = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.MDDx.ColumnFloor)].Value);
                       
                        #region Subtype and PType                                          
                       // SubTypeChanged(myMDDx.SubType);
                        #endregion
                        ///<AdditionInfoToDesc>
                        ///</AdditionInfoToDesc>
                        string desc = $"{Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.MDDx.ColumnDesc)].Value)}{suffixObject.SuffixObjectType["KCL"]}";
                        descTotalBuilder.Clear();
                        myMDDx.Name = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.DI.ColumnName)].Value);
                        bool additionInfToDesc = chkAddNameToDesc.Checked || chkAddFloorToDesc.Checked ||
                         chkAddCabinetToDesc.Checked;

                        if (chkAddSectionToDesc.Checked)
                        {
                            _nameNumberString = LibGlobalSource.StringHelper.ExtractNumericPart(myMDDx.Name, false);
                            if (!string.IsNullOrEmpty(_nameNumberString))
                            {
                                if (AppGlobal.ParseInt(_nameNumberString, out tempInt))
                                {
                                    descTotalBuilder.Append(GcObjectInfo.Section.ReturnSection(tempInt));
                                }
                            }
                        }
                        if (additionInfToDesc)
                        {                                                 
                            AppendInfoToBuilder(chkAddFloorToDesc, $"{myMDDx.Elevation}{GcObjectInfo.General.AddInfoElevation}", descTotalBuilder);
                            string descName = chkNameOnlyNumber.Checked ? _nameNumberString : LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameWithoutTypeLL, myMDDx.Name);
                            descName = descName.Contains(GcObjectInfo.General.PrefixName) ? descName.Replace(GcObjectInfo.General.PrefixName, string.Empty) : descName;
                            AppendInfoToBuilder(chkAddNameToDesc, $"({descName})", descTotalBuilder);
                                                    
                        }
                        descTotalBuilder.Append(desc);
                   
                        if (additionInfToDesc)
                        {
                            descTotalBuilder.Append("[");
                         //   AppendInfoToBuilder(chkAddNameToDesc, $"{GcObjectInfo.General.AddInfoSymbol}{LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameWithoutTypeLL, myMDDx.Name)}", descTotalBuilder);
                         //   AppendInfoToBuilder(chkAddFloorToDesc, $" {GcObjectInfo.General.AddInfoElevation}{myMDDx.Elevation}", descTotalBuilder);
                            AppendInfoToBuilder(chkAddCabinetToDesc, $"{GcObjectInfo.General.AddInfoCabinet}{myMDDx.Panel_ID}", descTotalBuilder);
                            descTotalBuilder.Append("]");
                        }                                        
                        myMDDx.Description = descTotalBuilder.ToString();

                        myMDDx.IoByteNo = (int.Parse(txtParIOByte.Text) + int.Parse(txtIOByteIncRule.Text) * i).ToString();
                        ///<DPNode1>   </DPNode1>                         
                        string dpNode1BML = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.MDDx.ColumnName)].Value);
                        myMDDx.DPNode1 = AppGlobal.FindDPNodeNo(oledb, dpNode1BML);
                        myMDDx.FieldBusNode = String.IsNullOrEmpty(myMDDx.DPNode1) ? string.Empty :
                            AppGlobal.FindFieldbusNodeKey(oledb, int.Parse(myMDDx.DPNode1));
                        myMDDx.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = i;
                    }
                    ProgressBar.Value = ProgressBar.Maximum ;
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
                            AppGlobal.RuleNotSetCorrect($"{grpSymbolRule.Text}.{lblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
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
                    tempBool = AppGlobal.ParseInt(txtSymbolIncRule.Text, out symbolInc);
                    tempBool = AppGlobal.ParseInt(txtSymbolRule.Text, out symbolRule);
                    tempBool = AppGlobal.ParseInt(txtDescriptionIncRule.Text, out descriptionInc);
                    for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
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
                        myMDDx.Name = name.Name;
                        myMDDx.Description = description.Name;
                        myMDDx.IoByteNo = (int.Parse(txtParIOByte.Text) + int.Parse(txtIOByteIncRule.Text) * i).ToString();
                        ///<DPNode1>   </DPNode1>                                               
                        myMDDx.DPNode1 = AppGlobal.FindDPNodeNo(oledb, myMDDx.Name);
                        myMDDx.FieldBusNode = String.IsNullOrEmpty(myMDDx.DPNode1) ? string.Empty :
                            AppGlobal.FindFieldbusNodeKey(oledb, int.Parse(myMDDx.DPNode1));
                        myMDDx.CreateObject(Encoding.Unicode);
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