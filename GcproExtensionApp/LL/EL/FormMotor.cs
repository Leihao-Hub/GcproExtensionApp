using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
#region GcproExtensionLibary
using GcproExtensionLibrary.Gcpro.GCObject;
using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using System.Linq;
#endregion
namespace GcproExtensionApp
{

    public partial class FormMotor : Form, IGcForm
    {

        public FormMotor()
        {
            InitializeComponent();
        }
        #region Public object in this class
        Motor myMotor = new Motor(AppGlobal.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        //OleDb oledb = new OleDb();
       // DataTable dataTable = new DataTable();
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        //private string CONNECT_VFC = "关联VFC";
        //private string CONNECT_AO = "关联AO";
        private string DEMO_NAME_MOTOR = "=A-1001-MXZ01";
        private string DEMO_NAME_RULE_MOTOR = "1001";
        private string DEMO_DESCRIPTION_MOTOR = "100号基粉仓活化器/或者空白";
        private string DEMO_DESCRIPTION_RULE_MOTOR = "100/或者空白";
        #endregion
        private int value9 = 2;
        private int value10 = 2;
        private int tempInt = 0;
        private float tempFloat = (float)0.0;
        private bool tempBool = false;
        private string namePrefix = string.Empty;
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
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={Motor.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {Motor.OTypeValue}",
                null, $"{GcproTable.ProcessFct.FieldFct_Desc.Name} ASC",
                 GcproTable.ProcessFct.FieldProcessFct.Name, GcproTable.ProcessFct.FieldFct_Desc.Name);
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.ProcessFct.FieldProcessFct.Name) + AppGlobal.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>(GcproTable.ProcessFct.FieldFct_Desc.Name);
                ComboProcessFct.Items.Add(itemInfo);
            }
            ///<Unit>Read [unit] </Unit>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_UnitCfg}%'",
                null, $"{GcproTable.TranslationCbo.FieldValue.Name} ASC",
                GcproTable.TranslationCbo.FieldValue.Name, GcproTable.TranslationCbo.FieldText.Name);
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {

                itemInfo = dataTable.Rows[count].Field<double>(GcproTable.TranslationCbo.FieldValue.Name) + AppGlobal.FIELDS_SEPARATOR +
                      dataTable.Rows[count].Field<string>(GcproTable.TranslationCbo.FieldText.Name);
                comboUnit.Items.Add(itemInfo);
            }
            comboUnit.SelectedIndex = 2;

            ///<ReadInfoFromProjectDB> 
            ///Read [PType],[Building],[Elevation],[Panel]
            ///Read [DPNode1],[DPNode2],[HornCode]
            ///</ReadInfoFromProjectDB>
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            ///<PType> Read [PType] </PType>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + Motor.OTypeValue}'",
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
            txtSymbolRule.Text = Motor.Rule.Common.NameRule;
            txtSymbolIncRule.Text = Motor.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = Motor.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = Motor.Rule.Common.DescriptionRuleInc;
            txtVFCSuffix.Text = Motor.Rule.VFCRule;     
            txtAOSuffix.Text = Motor.Rule.AORule;

        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + Motor.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobal.CONNECT_CONNECTOR);          
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_MOTOR);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_MOTOR);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_MOTOR);
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_MOTOR);
        }
        public void CreateImpExp()
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;          
            dataTable=oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Motor.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);         
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{Motor.ImpExpRuleName}'", null);
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
            txtInpFwdSuffix.Text = GcObjectInfo.Motor.SuffixInpRunFwd;
            txtOutpFwdSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunFwd;
            txtInpRevSuffix.Text = GcObjectInfo.Motor.SuffixInpRunRev;
            txtOutpRevSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunRev;
            txtVFCSuffix.Text = GcObjectInfo.Motor.SuffixVFC;
            txtPowerAppSuffix.Text = GcObjectInfo.Motor.SuffixPowerApp;
            txtAOSuffix.Text = GcObjectInfo.Motor.SuffixAO;
            txtAO.Text=String.Empty;    
            txtInpRunFwd.Text = txtSymbol.Text + txtInpFwdSuffix.Text;
            txtOutpRunFwd.Text = txtSymbol.Text + txtOutpFwdSuffix.Text;
            
            txtSymbolIncRule.Text = "1";
            txtDescriptionIncRule.Text = "1";
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            TxtValue9.Text = "2";
            myMotor.Value9 = "2";
        
           // comboWorkSheetsBML.Enabled = false;
      
            CreateBMLDefault();
            ComboEquipmentSubType.SelectedIndex = 1;
          
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "电机导入文件 " + " " + myMotor.FilePath;
        }
        #endregion

        private void CreateMotorImpExp(OleDb oledb)
        {

            List<List<GcproExtensionLibrary.Gcpro.DbParameter>> recordList = new List<List<GcproExtensionLibrary.Gcpro.DbParameter>>
                    {
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value =Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Type" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.OType.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Name" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Text0.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Description" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.Text1.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SubType" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.SubType.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ProcessFct" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.ProcessFct.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Building" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Building.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Elevation" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Elevation.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "FieldBusNode" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.FieldbusNode.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Panel ID"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Panel_ID.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Diagram"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DiagramNo.Name}

                    },
                        new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Page"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.PageName.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "PType"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value5.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Horn Code"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value2.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DP node1"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode1.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Object parameters"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value10.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DP node2"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode2.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Gcpro parameters"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value9.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpFwd"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpFwd"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpRev"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpRev"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpContactor" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InHWStop" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value47.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Adapter"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "PowerApp"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value50.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "VFC Analog"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value33.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTime"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStartDelay"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStartingTime"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStoppingTime"},
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParIdlingTime" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParFaultDelayTime" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParPowerNominal" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value49.Name }

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParSpeedService" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value52.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Unit" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value40.Name}

                    },
                    new List<GcproExtensionLibrary.Gcpro.DbParameter>
                    {
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = Motor.ImpExpRuleName },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Is new" },
                        new GcproExtensionLibrary.Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.IsNew.Name }

                    }
                };
            if (oledb.InsertMultipleRecords(GcproTable.ImpExpDef.TableName, recordList))
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FormMotor_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormMotor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                Motor.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    Motor.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
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
                Motor.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
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
                    Motor.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }

        }
        private void TxtMonTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobal.CheckNumericString(TxtMonTime.Text)))
            {
                AppGlobal.MessageNotNumeric();
            }

        }
        #endregion
        #region <------ Check and unchek "Value9" and "Value10------>"
        private void ChkRunInterlock_CheckedChanged(object sender, EventArgs e)
        {
            value9 = int.Parse(TxtValue9.Text);
            if (ChkRunInterlock.Checked)

            { AppGlobal.SetBit(ref value9, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value9, (byte)1); }

            myMotor.Value9 = value9.ToString();
            TxtValue9.Text = myMotor.Value9;
        }

        private void ChkStartingInterlock_CheckedChanged(object sender, EventArgs e)
        {
            {
                value9 = int.Parse(TxtValue9.Text);
                if (ChkStartingInterlock.Checked)
                { AppGlobal.SetBit(ref value9, (byte)0); }

                else
                { AppGlobal.ClearBit(ref value9, (byte)0); }

                myMotor.Value9 = value9.ToString();
                TxtValue9.Text = myMotor.Value9;
            }
        }
        private void ChkParManual_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(TxtValue10.Text);
            if (ChkParManual.Checked)
            { AppGlobal.SetBit(ref value10, (byte)1); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)1); }

            myMotor.Value10 = value10.ToString();
            TxtValue10.Text = myMotor.Value10;
        }

        private void ChkRestartDelay_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(TxtValue10.Text);
            if (ChkRestartDelay.Checked)
            { AppGlobal.SetBit(ref value10, (byte)2); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)2); }

            myMotor.Value10 = value10.ToString();
            TxtValue10.Text = myMotor.Value10;
        }

        private void ChkRevNotAllowed_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(TxtValue10.Text);
            if (ChkRevNotAllowed.Checked)
            { AppGlobal.SetBit(ref value10, (byte)7); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)7); }

            myMotor.Value10 = value10.ToString();
            TxtValue10.Text = myMotor.Value10;
        }

        private void ChKPower_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(TxtValue10.Text);
            if (ChKPower.Checked)
            { AppGlobal.SetBit(ref value10, (byte)8); }

            else
            { AppGlobal.ClearBit(ref value10, (byte)8); }

            myMotor.Value10 = value10.ToString();
            TxtValue10.Text = myMotor.Value10;
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

        private void TxtInpRunFwd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value11";
        }
        private void TxtOutpRunFwd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value12";
        }
        private void TxtInHWStop_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value47";
        }

        private void TxtVFCAdapter_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value34";
        }

        private void TxtAO_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value33";
        }

        private void ComboUnit_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value40";
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

        private void TxtMonTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value21";
        }

        private void TxtStartDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value26";
        }

        private void TxtStartingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value22";
        }

        private void TxtStoppingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value23";
        }

        private void TxtIdlingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value24";
        }

        private void TxtFaultDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value25";
        }

        private void TxtKW_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value49";
        }
        private void txtPowerApp_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value50";
        }

        private void txtDosingBin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value32";
        }
        private void ChkParManual_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit1";
        }

        private void ChkRestartDelay_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit2";
        }

        private void ChkRevNotAllowed_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit7";
        }

        private void ChKPower_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value10.Bit8";
        }

        private void ChkRunInterlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit1";
        }

        private void ChkStartingInterlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + "Value9.Bit0";
        }
        #endregion
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser();
            objectBrowser.OtherAdditionalFiled = GcproTable.ObjData.Value21.Name;
            objectBrowser.OType=Convert.ToString(Motor.OTypeValue); 

            objectBrowser.Show();
        }
        private void TxtSymbol_TextChanged(object sender, EventArgs e)
        {

            txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text, false);
            if (myMotor.SubType == Motor.M1VFC ||
                myMotor.SubType == Motor.M1VFC)
            { 
                txtVFCAdapter.Text = txtSymbol.Text + txtVFCSuffix.Text;
            }
            else if (myMotor.SubType == Motor.M12)
            {
                txtInpRunRev.Text = txtSymbol.Text + txtInpRevSuffix.Text;
                txtOutpRunRev.Text = txtSymbol.Text + txtOutpRevSuffix.Text;
            }
            else
            { 
                txtVFCAdapter.Text = AppGlobal.MOTOR_WITHOUT_VFC;
                txtInpRunFwd.Text = txtSymbol.Text + txtInpFwdSuffix.Text;
                txtOutpRunFwd.Text = txtSymbol.Text + txtOutpFwdSuffix.Text;
            }         
            myMotor.Name = txtSymbol.Text;
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
                myMotor.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR)); 
            }
    
            SubtypeChanged();
            try
            {
                if (myMotor.SubType == Motor.M1VFC)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7042.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myMotor.SubType == Motor.M2VFC)
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7041.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                else if (myMotor.SubType == Motor.M11)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7053.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (myMotor.SubType == Motor.M12)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7056.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }     
                }
                else if (myMotor.SubType == Motor.M21)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7052.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (myMotor.SubType == Motor.M22)
                {
                    foreach (var item in ComboEquipmentInfoType.Items)
                    {
                        if (item.ToString().StartsWith(Motor.P7051.ToString()))
                        {
                            ComboEquipmentInfoType.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtInpFwdSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRunFwd.Text = txtSymbol.Text + txtInpFwdSuffix.Text;
        }
        private void txtInpFwdSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpFwdSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.Motor.Suffix.InpRunFwd", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixInpRunFwd = newJsonKeyValue;
            }
        }
        private void txtOutpFwdSuffix_TextChanged(object sender, EventArgs e)
        {
            txtOutpRunFwd.Text = txtSymbol.Text + txtOutpFwdSuffix.Text;
        }
        private void txtOutpFwdSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpFwdSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.Motor.Suffix.OutpRunFwd", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixOutpRunFwd = newJsonKeyValue;
            }
        }
    
        private void txtInpRevSuffix_TextChanged(object sender, EventArgs e)
        {
            txtInpRunRev.Text = txtSymbol.Text + txtInpRevSuffix.Text;
        }
        private void txtInpRevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtInpRevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.Motor.Suffix.InpRunRev", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixInpRunRev = newJsonKeyValue;
            }
        }
        private void txtOutRevSuffix_TextChanged(object sender, EventArgs e)
        {
            txtOutpRunRev.Text = txtSymbol.Text + txtOutpRevSuffix.Text;
        }
        private void txtOutpRevSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtOutpRevSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.Motor.Suffix.OutpRunRev", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixOutpRunRev = newJsonKeyValue;
            }
        }
        private void BtnConnectVFC_Click(object sender, EventArgs e)
        {

        }
        private void txtVFCSuffix_TextChanged(object sender, EventArgs e)
        {
            txtVFCAdapter.Text = txtSymbol.Text + txtVFCSuffix.Text;
        }
        private void txtVFCSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtVFCSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.Motor.Suffix.VFC", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixVFC = newJsonKeyValue;
            }
        }
        private void txtAOSuffix_TextChanged(object sender, EventArgs e)
        {
           // txtAO.Text = txtSymbol.Text + txtAOSuffix.Text;
        }
        private void txtAOSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtAOSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.Motor.Suffix.AO", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixAO = newJsonKeyValue;
            }
        }
        private void txtPowerAppSuffix_TextChanged(object sender, EventArgs e)
        {
          //  txtPowerApp.Text = txtSymbol.Text + txtPowerAppSuffix.Text;
        }
        private void txtPowerAppSuffix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtPowerAppSuffix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "GcObjectInfo.Motor.Suffix.PowerApp", newJsonKeyValue);
                GcObjectInfo.Motor.SuffixPowerApp = newJsonKeyValue;
            }
        }
        private void TxtInpContactorSuffix_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txtInpHWSuffix_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void txtPowerApp_TextChanged(object sender, EventArgs e)
        {

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
            BML.Motor.BMLPath = excelFileHandle.FilePath;
            LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, "BML.Motor.Path", BML.Motor.BMLPath);
          
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
            txtVFCPrefixBML.Text = BML.Motor.PrefixVFC;
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
                comboLineBML.Items.Add(item);
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboPowerBML.SelectedItem = "E";
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
            TxtExcelPath.Text = BML.Motor.BMLPath;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.Motor.ColumnName; // 列头的名称
            nameColumn.Name = nameof(BML.Motor.ColumnName); // 列的唯一名称，方便查找                                                 
            dataGridBML.Columns.Add(nameColumn);

       
            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.Motor.ColumnDesc;
            descColumn.Name = nameof(BML.Motor.ColumnDesc);
            dataGridBML.Columns.Add(descColumn);

            DataGridViewCheckBoxColumn isVFC = new DataGridViewCheckBoxColumn();
            isVFC.HeaderText = BML.Motor.ColumnIsVFC;
            isVFC.Name = nameof(BML.Motor.ColumnIsVFC);
            dataGridBML.Columns.Add(isVFC);

            DataGridViewTextBoxColumn powerColumn = new DataGridViewTextBoxColumn();
            powerColumn.HeaderText = BML.Motor.ColumnPower;
            powerColumn.Name = nameof(BML.Motor.ColumnPower);
            dataGridBML.Columns.Add(powerColumn);

            DataGridViewTextBoxColumn floorColumn = new DataGridViewTextBoxColumn();
            floorColumn.HeaderText = BML.Motor.ColumnFloor;
            floorColumn.Name = nameof(BML.Motor.ColumnFloor);
            dataGridBML.Columns.Add(floorColumn);

            DataGridViewTextBoxColumn cabinetColumn = new DataGridViewTextBoxColumn();
            cabinetColumn.HeaderText = BML.Motor.ColumnCabinet;
            cabinetColumn.Name = nameof(BML.Motor.ColumnCabinet);
            dataGridBML.Columns.Add(cabinetColumn);

            DataGridViewTextBoxColumn cabinetGroupColumn = new DataGridViewTextBoxColumn();
            cabinetGroupColumn.HeaderText = BML.Motor.ColumnCabinetGroup;
            cabinetGroupColumn.Name = nameof(BML.Motor.ColumnCabinetGroup);
            dataGridBML.Columns.Add(cabinetGroupColumn);

            DataGridViewTextBoxColumn lineColumn = new DataGridViewTextBoxColumn();
            lineColumn.HeaderText = BML.Motor.ColumnLine;
            lineColumn.Name = nameof(BML.Motor.ColumnLine);
            dataGridBML.Columns.Add(lineColumn);

        }
        private void btnReadBML_Click(object sender, EventArgs e)
        {
            // List<List<object>> allData = new List<List<object>>();
            string[] columnList = { comboNameBML.Text, comboDescBML.Text, comboControlBML.Text,comboPowerBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text,comboLineBML.Text};
            DataTable dataTable = new DataTable();
            dataTable = excelFileHandle.ReadAsDataTable(int.Parse(comboStartRow.Text), columnList, BML.Motor.Type, comboTypeBML.Text);

            dataGridBML.DataSource = dataTable;
            dataGridBML.AutoGenerateColumns = false;

            dataGridBML.Columns[nameof(BML.Motor.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnPower)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnFloor)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnCabinet)].DataPropertyName = dataTable.Columns[5].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[6].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnLine)].DataPropertyName = dataTable.Columns[7].ColumnName;
            TxtQuantity.Text = dataTable.Rows.Count.ToString();
            foreach (DataRow row in dataTable.Rows)
            {
                bool startsWithCondition = row[2].ToString().StartsWith(!String.IsNullOrEmpty(txtVFCPrefixBML.Text)?txtVFCPrefixBML.Text:BML.Motor.PrefixVFC);
                int rowIndex = dataTable.Rows.IndexOf(row);
                DataGridViewRow dataGridViewRow = dataGridBML.Rows[rowIndex];
                dataGridViewRow.Cells[nameof(BML.Motor.ColumnIsVFC)].Value = startsWithCondition;
            }
        }
        #endregion
        #region Common used
        #region Genate elements name
    
        private void NamePrefix()
        {
            namePrefix = txtSymbol.Text;
        }
        private void M11SubElements(string _namePrefix)
        {
            txtInpFwdSuffix.Text = GcObjectInfo.Motor.SuffixInpRunFwd;
            txtOutpFwdSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunFwd;
            txtInpRunFwd.Text = _namePrefix + txtInpFwdSuffix.Text;
            txtOutpRunFwd.Text = _namePrefix + txtOutpFwdSuffix.Text;  
            txtInpRunRev.Text = string.Empty;
            txtOutpRunRev.Text = string.Empty;
            txtVFCAdapter.Text = AppGlobal.MOTOR_WITHOUT_VFC;
        }
        private void M12SubElements(string _namePrefix)
        {
            M11SubElements(_namePrefix);
            txtInpFwdSuffix.Text = GcObjectInfo.Motor.SuffixInpRunFwd+"1";
            txtOutpFwdSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunFwd+"1";

            txtInpRevSuffix.Text = GcObjectInfo.Motor.SuffixInpRunRev;
            txtOutpRevSuffix.Text = GcObjectInfo.Motor.SuffixOutpRunRev;

            txtInpRunFwd.Text = _namePrefix + txtInpFwdSuffix.Text;
            txtOutpRunFwd.Text = _namePrefix + txtOutpFwdSuffix.Text;
            txtInpRunRev.Text = _namePrefix + txtInpRevSuffix.Text;
            txtOutpRunRev.Text = _namePrefix + txtOutpRevSuffix.Text;
    
        }
        private void VFCSubElements(string _namePrefix)
        {
            
            txtInpRunFwd.Text = string.Empty;
            txtOutpRunFwd.Text = string.Empty;
            txtInpRunRev.Text = string.Empty;
            txtOutpRunRev.Text = string.Empty;
            txtVFCAdapter.Text = _namePrefix + txtVFCSuffix.Text;
        }
        private void SubtypeChanged()
        {
            NamePrefix();
            if (myMotor.SubType == Motor.M11)
            {
                M11SubElements(namePrefix);
            }
            else if (myMotor.SubType == Motor.M12)
            {
                M12SubElements(namePrefix);
            }
            else if (myMotor.SubType == Motor.M1VFC || myMotor.SubType == Motor.M2VFC)
            {
                VFCSubElements(namePrefix);
            }
        }
        private void NameSubElements(string _namePrefix)
        {
           // NamePrefix();
            if (myMotor.SubType == Motor.M11)
            {
                
            }
            else if (myMotor.SubType == Motor.M12)
            {
                

            }
            else if (myMotor.SubType == Motor.M1VFC || myMotor.SubType == Motor.M2VFC)
            {
              

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
                txtSymbolRule.Text = Motor.Rule.Common.NameRule;
                txtSymbolIncRule.Text = Motor.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobal.NAME;
                txtSymbol.Text = DEMO_NAME_MOTOR;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;
               
            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = Motor.Rule.Common.NameRule;
                txtSymbolIncRule.Text = Motor.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                GrpSymbolRule.Visible = false;
                LblSymbol.Text = AppGlobal.KEY_WORD_AUTOSEARCH;
               // txtSymbol.Text = "-MXZ";
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
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={Motor.OTypeValue}", null,
                        $"{GcproTable.ObjData.Text0.Name} ASC", GcproTable.ObjData.Text0.Name, GcproTable.ObjData.SubType.Name, 
                        GcproTable.ObjData.Value11.Name, GcproTable.ObjData.Value12.Name, GcproTable.ObjData.Value13.Name,
                        GcproTable.ObjData.Value14.Name, GcproTable.ObjData.Value38.Name, GcproTable.ObjData.Value47.Name,
                         GcproTable.ObjData.Value34.Name, GcproTable.ObjData.Value50.Name);
                    ProgressBar.Maximum = dataTable.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    Motor.Clear(myMotor.FileConnectorPath);
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        objName = dataTable.Rows[count].Field<string>(GcproTable.ObjData.Text0.Name);
                        objSubType = dataTable.Rows[count].Field<string>(GcproTable.ObjData.SubType.Name);
                        if (objSubType == Motor.M11)
                        {
                            string inpFwd, outpFwd;
                            inpFwd = objName + txtInpFwdSuffix.Text;
                            outpFwd = objName + txtOutpFwdSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name)==0 || all)
                            {
                               Motor.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, outpFwd, GcproTable.ObjData.Value12.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }                           
                        }
                        else if (objSubType == Motor.M12)
                        {
                            string inpFwd, outpFwd, inpRev, outpRev;
                            inpFwd = objName + txtInpFwdSuffix.Text;
                            outpFwd = objName + txtOutpFwdSuffix.Text;
                            inpRev = objName + txtInpRevSuffix.Text;
                            outpRev = objName + txtOutpRevSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, outpFwd, GcproTable.ObjData.Value12.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field< double>(GcproTable.ObjData.Value13.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, inpRev, GcproTable.ObjData.Value13.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value14.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, outpRev, GcproTable.ObjData.Value14.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        else if (objSubType == Motor.M1VFC || objSubType == Motor.M2VFC)
                        {
                            if (all)
                            {
                                string vfc=objName +txtVFCSuffix.Text;
                                Motor.CreateRelation(objName, vfc, GcproTable.ObjData.Value34.Name, myMotor.FileConnectorPath, Encoding.Unicode);
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
                                            string vfc = objName + txtVFCSuffix.Text;
                                            Motor.CreateRelation(objName, vfc, GcproTable.ObjData.Value34.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                                        }
                                    }
                                    connectorTable.Rows.Clear();
                                }
                            }   
                            
                        }
                        else
                        {
                            string inpFwd, outPFwd;
                            inpFwd = objName + txtInpFwdSuffix.Text;
                            outPFwd = objName + txtOutpFwdSuffix.Text;
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value11.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, inpFwd, GcproTable.ObjData.Value11.Name, myMotor.FileConnectorPath,Encoding.Unicode);
                            }
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value12.Name) == 0 || all)
                            {
                                Motor.CreateRelation(objName, outPFwd, GcproTable.ObjData.Value12.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        if (!String.IsNullOrEmpty(txtInpContactor.Text))
                        {
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value38.Name) == 0 || all)
                            {
                                string inpContactor=objName +txtInpContactor.Text;
                                Motor.CreateRelation(objName, inpContactor, GcproTable.ObjData.Value38.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        if (!String.IsNullOrEmpty(txtInHWStop.Text))
                        {
                            if (dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value47.Name) == 0 || all)
                            {
                                string InHWStop= objName + txtInHWStop.Text; ;
                                Motor.CreateRelation(objName, InHWStop, GcproTable.ObjData.Value47.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                        }
                        if (!String.IsNullOrEmpty(txtPowerApp.Text))
                        {
                            if (all)
                            {
                                string powerApp= objName + txtPowerAppSuffix.Text; ;
                                Motor.CreateRelation(objName, powerApp, GcproTable.ObjData.Value50.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            else
                            {
                                double connectorKey = dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value50.Name);
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
                                            string powerApp = objName + txtPowerAppSuffix.Text;
                                            Motor.CreateRelation(objName, powerApp, GcproTable.ObjData.Value50.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                                        }
                                    }
                                    connectorTable.Rows.Clear();
                                }                                  
                            }                           
                        }
                        if (!String.IsNullOrEmpty(txtAO.Text))
                        {
                            if (all)
                            {
                                string ao= objName + txtAOSuffix.Text;
                                Motor.CreateRelation(objName, ao, GcproTable.ObjData.Value33.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                            }
                            else
                            {
                                double connectorKey = dataTable.Rows[count].Field<double>(GcproTable.ObjData.Value33.Name);
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
                                            string ao = objName + txtAOSuffix.Text;
                                            Motor.CreateRelation(objName, ao, GcproTable.ObjData.Value33.Name, myMotor.FileConnectorPath, Encoding.Unicode);
                                        }
                                    }
                                    connectorTable.Rows.Clear();
                                }
                            }

                        }
                        ProgressBar.Value=count;
                    }
                    Motor.SaveFileAs(myMotor.FileConnectorPath, LibGlobalSource.CREATE_RELATION);
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
                myMotor.Clear();
                ProgressBar.Value = 0;  
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            Motor.SaveFileAs(myMotor.FilePath, LibGlobalSource.CREATE_OBJECT);
            Motor.SaveFileAs(myMotor.FileRelationPath, LibGlobalSource.CREATE_RELATION);
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
                oledb.DataSource = AppGlobal.GcproDBInfo.GcsLibaryPath;
                oledb.IsNewOLEDBDriver = isNewOledbDriver;
                DataTable dataTable = new DataTable();
                #region common used variables declaration
                bool motorWithVFC = false;
                bool needDPNodeChanged = false;
                int quantityNeedToBeCreate = AppGlobal.ParseInt(TxtQuantity.Text, out tempInt) ? tempInt : 0;
                bool moreThanOne = quantityNeedToBeCreate > 1;
                bool onlyOne = quantityNeedToBeCreate == 1;
                bool additionInfToDesc = false;
                StringBuilder descTotalBuilder = new StringBuilder();
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
                ///<SubType></SubType>
                string selectedSubTypeItem;
                if (ComboEquipmentSubType.SelectedItem != null)
                {
                    selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                    myMotor.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                    motorWithVFC= (myMotor.SubType == Motor.M1VFC || myMotor.SubType == Motor.M2VFC)? true : false;
                }
                else
                {
                    myMotor.SubType = Motor.M11;
                }
                ///<PType></PType>
                string selectedPTypeItem;
                if (ComboEquipmentInfoType.SelectedItem != null)
                {
                    selectedPTypeItem = ComboEquipmentInfoType.SelectedItem.ToString();
                    myMotor.PType = selectedPTypeItem.Substring(0, selectedPTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                else
                {
                    myMotor.PType = Motor.P7053.ToString();
                }
                ///<ParMonTime></ParMonTime>
                myMotor.ParMonTime = AppGlobal.ParseFloat(TxtMonTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "20.0";
                ///<ParStartDelay></ParStartDelay>
                myMotor.ParStartDelay = AppGlobal.ParseFloat(TxtStartDelayTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "20.0";
                ///<ParStartingTime></ParStartingTime>
                myMotor.ParStartingTime = AppGlobal.ParseFloat(TxtStartingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "20.0";
                ///<ParStoppingTime></ParStoppingTime>
                myMotor.ParStoppingTime = AppGlobal.ParseFloat(TxtStoppingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "0.0";
                ///<ParIdlingTime></ParIdlingTime>
                myMotor.ParIdlingTime = AppGlobal.ParseFloat(TxtIdlingTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "10.0";
                ///<ParFaultDelayTime></ParFaultDelayTime>
                myMotor.ParFaultDelayTime = AppGlobal.ParseFloat(TxtFaultDelayTime.Text, out tempFloat) ? (tempFloat * 10.0).ToString("F1") : "10.0";
                ///<ParPowerNominal></ParPowerNominal>
                myMotor.ParPowerNominal = AppGlobal.ParseFloat(TxtKW.Text, out tempFloat) ? tempFloat.ToString("F2") : string.Empty;
                ///<Value9>Value is set when corresponding check box's check state changed</Value9>
                ///<Value10>Value is set when corresponding check box's check state changed</Value10>
                ///<Name>Value is set in TxtSymbol text changed event</Name>
                ///<Description></Description>
                myMotor.Description = txtDescription.Text;
                ///<ProcessFct></ProcessFct>
                string selectedProcessFct = string.Empty;
                if (ComboProcessFct.SelectedItem != null)
                {
                    selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
                    myMotor.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Diagram></Diagram>
                string selectedDiagram;
                if (ComboDiagram.SelectedItem != null)
                {
                    selectedDiagram = ComboDiagram.SelectedItem.ToString();
                    myMotor.Diagram = selectedDiagram.Substring(0, selectedDiagram.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Unit></Unit>
                string selectedUnit;
                if (comboUnit.SelectedItem != null)
                {
                    selectedUnit = comboUnit.SelectedItem.ToString();
                    myMotor.Unit = selectedUnit.Substring(0, selectedUnit.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                ///<Page></Page>
                myMotor.Page = txtPage.Text;
                ///<Building></Building>
                string selectedBudling = "--";
                if (ComboBuilding.SelectedItem != null)
                {
                    selectedBudling = ComboBuilding.SelectedItem.ToString();
                    myMotor.Building = selectedBudling;
                }
                ///<Elevation></Elevation>
                string selectedElevation;
                if (ComboElevation.SelectedItem != null)
                {
                    selectedElevation = ComboElevation.SelectedItem.ToString();
                    myMotor.Elevation = selectedElevation;
                }
                ///<Panel_ID></Panel_ID>
                string selectedPanel_ID;
                if (ComboPanel.SelectedItem != null)
                {
                    selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                    myMotor.Panel_ID = selectedPanel_ID;
                }
                ///<IsNew>is set when object generated,Default value is "No"</IsNew>
                ///<FieldBusNode></FieldBusNode>
                myMotor.FieldBusNode = LibGlobalSource.NOCHILD; ;
                ///<DPNode1></DPNode1>
                string selectDPNode1 = String.Empty;
                if (ComboDPNode1.SelectedItem != null)
                {
                    selectDPNode1 = ComboDPNode1.SelectedItem.ToString();
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    myMotor.DPNode1 = AppGlobal.FindDPNodeNo(oledb, selectDPNode1);
                    int dpnode1 = int.Parse(myMotor.DPNode1);
                    myMotor.FieldBusNode = AppGlobal.FindFieldbusNodeKey(oledb, dpnode1);
                }
                ///<DPNode2></DPNode2>
                string selectDPNode2 = String.Empty;
                if (ComboDPNode2.SelectedItem != null)
                {
                    selectDPNode2 = ComboDPNode2.SelectedItem.ToString();
                    myMotor.DPNode2 = AppGlobal.FindDPNodeNo(oledb, selectDPNode2);
                }
                if (ComboHornCode.SelectedItem != null)
                {
                    string hornCode = ComboHornCode.SelectedItem.ToString();
                    myMotor.HornCode = hornCode.Substring(0, 2);
                }
                ///<InpFwd></InpFwd>
                myMotor.InpFwd = LibGlobalSource.NOCHILD;
                ///<OutpFwd></OutFwd>
                myMotor.OutpFwd = LibGlobalSource.NOCHILD;
                ///<InpRev></InpRev>
                myMotor.InpRev = LibGlobalSource.NOCHILD;
                ///<OutpRev></OutpRev>
                myMotor.OutpRev = LibGlobalSource.NOCHILD;
                ///<InpContactor></InpContactor>
                myMotor.InpContactor = txtInpContactor.Text;
                ///<InHWStop></InHWStop>
               
                ///<Adapter></Adapter>
                myMotor.Adapter = LibGlobalSource.NOCHILD;
                ///<PowerApp></PowerApp>

                ///<AO></AO>
                #endregion
                if (createMode.BML)
                {
                    ProgressBar.Maximum = dataGridBML.Rows.Count - 1;
                    ProgressBar.Value = 0;
                    string _nameNumberString=string.Empty;
                    bool numeric;
                    float power;
                    string desc = string.Empty;
                    int monTime;
                    bool isMDDxFeeder = false;
                    for (int i = 0; i < dataGridBML.Rows.Count; i++)
                    {
                        DataGridViewCell cell;
                        cell = dataGridBML.Rows[i].Cells[nameof(BML.Motor.ColumnName)];
                        if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                            continue;
                        myMotor.InpFwd = LibGlobalSource.NOCHILD;
                        myMotor.OutpFwd = LibGlobalSource.NOCHILD;
                        myMotor.Name = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.Motor.ColumnName)].Value);
                        motorWithVFC = Convert.ToBoolean(dataGridBML.Rows[i].Cells[nameof(BML.Motor.ColumnIsVFC)].Value);
                        myMotor.SubType = motorWithVFC ? Motor.M1VFC : Motor.M11;
                        myMotor.PType = motorWithVFC ? Motor.P7042.ToString() : Motor.P7053.ToString();                    
                        numeric = AppGlobal.ParseFloat(Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.Motor.ColumnPower)].Value), out power);
                        monTime = Motor.GetStartingTime(power);
                        myMotor.ParMonTime = numeric ? (monTime * 10.0).ToString("F1") : "100.0";
                        myMotor.ParStartingTime = numeric ? (monTime * 10.0 - 10.0).ToString("F1") : "30.0";
                        myMotor.ParPowerNominal = power.ToString();
                        desc = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.Motor.ColumnDesc)].Value).Replace(" ","");
                        myMotor.Adapter = motorWithVFC ? $"{myMotor.Name}{txtVFCSuffix.Text}" : LibGlobalSource.NOCHILD;
                        isMDDxFeeder = (((myMotor.Name.Contains("MXZ03") || myMotor.Name.Contains("MXZ07")) && motorWithVFC) &&
                             desc.Contains(BML.MachineType.RollerMiller)) || myMotor.Description.Contains(BML.MachineType.RollerMiller);
                        myMotor.ProcessFct = isMDDxFeeder ? Motor.PF1012MDDXFEED : string.Empty;

                        if (myMotor.SubType == Motor.M11)
                        {
                            myMotor.InpFwd = $"{myMotor.Name}{txtInpFwdSuffix.Text}";
                            myMotor.OutpFwd = $"{myMotor.Name}{txtOutpFwdSuffix.Text}";
                        }
                        else if (myMotor.SubType == Motor.M12)
                        {
                            myMotor.InpFwd = $"{name.Name}{txtInpFwdSuffix.Text}";
                            myMotor.OutpFwd = $"{name.Name}{txtOutpFwdSuffix.Text}";
                            myMotor.InpRev = $"{name.Name}{txtInpRevSuffix.Text}";
                            myMotor.OutpRev = $"{name.Name}{txtOutpRevSuffix.Text}";
                        }
                        myMotor.Panel_ID = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.Motor.ColumnCabinetGroup)].Value) +
                            Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.Motor.ColumnCabinet)].Value);
                        myMotor.Elevation = Convert.ToString(dataGridBML.Rows[i].Cells[nameof(BML.Motor.ColumnFloor)].Value);
                        ///<AdditionInfoToDesc>
                        ///</AdditionInfoToDesc>
                        descTotalBuilder.Clear();

                        additionInfToDesc = chkAddNameToDesc.Checked || chkAddFloorToDesc.Checked || 
                            chkAddCabinetToDesc.Checked || chkAddPowerToDesc.Checked;
                        if (chkAddSectionToDesc.Checked)
                        {
                             _nameNumberString = LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameOnlyWithNumber, myMotor.Name);
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
                            AppendInfoToBuilder(chkAddFloorToDesc, $"{myMotor.Elevation}{GcObjectInfo.General.AddInfoElevation}", descTotalBuilder);
                            string descName = chkNameOnlyNumber.Checked ? _nameNumberString : LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameWithoutTypeLL, myMotor.Name);
                            descName = descName.Contains(GcObjectInfo.General.PrefixName) ? descName.Replace(GcObjectInfo.General.PrefixName, string.Empty) : descName;
                            AppendInfoToBuilder(chkAddNameToDesc, $"({descName})", descTotalBuilder);
                        }
                        descTotalBuilder.Append($"{desc}");
                        if (additionInfToDesc)
                        {
                            descTotalBuilder.Append("[");
                          //  AppendInfoToBuilder(chkAddNameToDesc, $"{GcObjectInfo.General.AddInfoSymbol}{LibGlobalSource.StringHelper.ExtractStringPart(Engineering.PatternNameWithoutTypeLL, myMotor.Name)}", descTotalBuilder);
                          //  AppendInfoToBuilder(chkAddFloorToDesc, $" {GcObjectInfo.General.AddInfoElevation}{myMotor.Elevation}", descTotalBuilder);
                            AppendInfoToBuilder(chkAddCabinetToDesc, $"{GcObjectInfo.General.AddInfoCabinet}{myMotor.Panel_ID}", descTotalBuilder);
                            AppendInfoToBuilder(chkAddPowerToDesc, $" {GcObjectInfo.General.AddInfoPower}{myMotor.ParPowerNominal}KW", descTotalBuilder);
                            descTotalBuilder.Append("]");
                        }

                        myMotor.Description = descTotalBuilder.ToString();

                        myMotor.CreateObject(Encoding.Unicode);
                        ProgressBar.Value = i;
                    }
                    ProgressBar.Value = ProgressBar.Maximum;
                }
                else if (createMode.AutoSearch)
                {
                    List<Dictionary<string,string>> objSubList = new List<Dictionary<string,string>>();                  
                    List<GcObjectInfo.Motor.SimpleInfo> obj = new List<GcObjectInfo.Motor.SimpleInfo>();
            
                    string filter = $@"({GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.DOC} OR {GcproTable.ObjData.OType.Name} = {VFCAdapter.OTypeValue}) " + 
                                    $@"AND {GcproTable.ObjData.Owner.Name} = {LibGlobalSource.NO_OWNER} AND {GcproTable.ObjData.Text0.Name} LIKE '%{GcObjectInfo.Motor.SuffixMotor}%'";
                    filter = string.IsNullOrEmpty(txtSymbol.Text)?filter:$@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtSymbol.Text}%'";
                    oledb.IsNewOLEDBDriver = isNewOledbDriver;
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter, null, $"[{GcproTable.ObjData.Key.Name}] ASC", $"[{GcproTable.ObjData.Key.Name}]", $"[{GcproTable.ObjData.Text0.Name}]", $"[{GcproTable.ObjData.OType.Name}]");
                    objSubList = OleDb.GetColumnsData<string>(dataTable, GcproTable.ObjData.Text0.Name, GcproTable.ObjData.OType.Name);            
                    for (int listIndex = 0; listIndex <= objSubList.Count - 1; listIndex++)
                    {
                        var dictionary = objSubList[listIndex];
                        var keys = new List<string>(dictionary.Keys);          
                        bool isVFC= dictionary[keys[1]]==VFCAdapter.OTypeValue.ToString()?true:false;  
                        string _nameIO= AppGlobal.GetObjectSymbolFromIO(dictionary[keys[0]]);
                        string _nameVFC = AppGlobal.GetObjectSymbolFromIO(dictionary[keys[0]],GcObjectInfo.Motor.SuffixVFC);
                        string _name = string.IsNullOrEmpty(_nameIO)? _nameVFC: _nameIO;
                        byte _count = 1;
                        if (listIndex == 0)
                        {
                            obj.Add(new GcObjectInfo.Motor.SimpleInfo(_name, isVFC, _count));
                           
                        }                   
                        else if(listIndex > 0)
                        {
                            bool found = false;
                            for (int listIndexPrev = 0; listIndexPrev <= listIndex - 1; listIndexPrev++)
                            {
                                var dictionaryPrev = objSubList[listIndexPrev];
                                var keysPrev = new List<string>(dictionaryPrev.Keys);
                                string _nameIOPrev = AppGlobal.GetObjectSymbolFromIO(dictionaryPrev[keysPrev[0]]);
                                string _nameVFCPrev = AppGlobal.GetObjectSymbolFromIO(dictionaryPrev[keysPrev[0]], GcObjectInfo.Motor.SuffixVFC);
                                string _namePrev = string.IsNullOrEmpty(_nameIOPrev) ? _nameVFCPrev : _nameIOPrev;
                               
                                if (_name.Equals(_namePrev))
                                {
                                    found = true;
                                    for (int indexObj=0; indexObj<= obj.Count-1; indexObj++)
                                    {
                                        GcObjectInfo.Motor.SimpleInfo updatedItem = obj[indexObj];
                                        if (updatedItem.Name.Equals(_name))
                                        {
                                            updatedItem.Count += 1;
                                            obj[indexObj] = updatedItem;
                                           
                                        }
                                    }
                                    continue;
                                }
                              
                            }
                           if (!found)
                            {
                                obj.Add(new GcObjectInfo.Motor.SimpleInfo(_name, isVFC, _count));
                            }
                        }                 
                    }                
                    ProgressBar.Maximum = obj.Count-1;
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
                    for (int i = 0; i <= obj.Count-1; i++)
                    {
                        GcObjectInfo.Motor.SimpleInfo updatedItem = obj[i];
                        myMotor.Name = obj[i].Name;
                        if  (obj[i].IsVFC)
                        {
                            myMotor.SubType = Motor.M1VFC;
                            myMotor.PType = Motor.P7042.ToString();
                            myMotor.Adapter = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixVFC}";
                        }
                        else if(obj[i].Count==2)
                        {
                            myMotor.SubType = Motor.M12;
                            myMotor.PType = Motor.P7056.ToString();
                            myMotor.OutpFwd= $"{obj[i].Name}{GcObjectInfo.Motor.SuffixOutpRunFwd}1";
                            myMotor.InpFwd = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixInpRunFwd}1";
                            myMotor.OutpRev = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixOutpRunRev}";
                            myMotor.InpRev = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixInpRunRev}";
                        }
                        else
                        {
                            myMotor.SubType = Motor.M11;
                            myMotor.PType = Motor.P7053.ToString();
                            myMotor.OutpFwd = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixOutpRunFwd}";
                            myMotor.InpFwd = $"{obj[i].Name}{GcObjectInfo.Motor.SuffixInpRunFwd}";
                        }
 
                        myMotor.CreateObject(Encoding.Unicode);
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
                        needDPNodeChanged = motorWithVFC;
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
                        if (!motorWithVFC)
                        {
                            // myMotor.InpFwd = AppGlobalSource.FindIOKey(oledb, $"{name.Name}:I");
                            // myMotor.OutpFwd = AppGlobalSource.FindIOKey(oledb, $"{name.Name}:O");
                            if (myMotor.SubType == Motor.M11)
                            {
                                myMotor.InpFwd = $"{name.Name}:{txtInpFwdSuffix}";
                                myMotor.OutpFwd = $"{name.Name}:{txtOutpFwdSuffix}";
                            }
                            else if (myMotor.SubType == Motor.M12)
                            {
                                myMotor.InpFwd = $"{name.Name}{txtInpFwdSuffix.Text}";
                                myMotor.OutpFwd = $"{name.Name}{txtOutpFwdSuffix.Text}";
                                myMotor.InpRev = $"{name.Name}{txtInpRevSuffix.Text}";
                                myMotor.OutpRev = $"{name.Name}{txtOutpRevSuffix.Text}";
                            }
                        }
                        else 
                        {
                            myMotor.Adapter = $"{name.Name}{txtVFCSuffix.Text}";
                        }                     
                        myMotor.PowerApp = String.IsNullOrEmpty(txtPowerApp.Text)? string.Empty:$"{name.Name}{txtPowerAppSuffix.Text}";
                        myMotor.AO = String.IsNullOrEmpty(txtAO.Text)? string.Empty : $"{name.Name}{txtAOSuffix.Text}";   
                        myMotor.HWStop = String.IsNullOrEmpty(txtInHWStop.Text)?string.Empty:txtInHWStop.Text;

                        if (needDPNodeChanged && moreThanOne)
                        {
                            dpNode1.Inc = i * symbolInc;
                            dpNode1.Name = LibGlobalSource.StringHelper.GenerateObjectName(dpNode1.Sub, dpNode1.PosInfo, (symbolRule + dpNode1.Inc).ToString());
                            myMotor.DPNode1 = AppGlobal.FindDPNodeNo(oledb, dpNode1.Name);
                            int dpnode1 = 0;
                            myMotor.FieldBusNode = AppGlobal.ParseInt(myMotor.DPNode1,out dpnode1)? AppGlobal.FindFieldbusNodeKey(oledb, dpnode1):LibGlobalSource.NOCHILD;
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
                            description.Name = "电机";
                        }
                        myMotor.Name = name.Name;
                        myMotor.Description = description.Name;
                    
                        myMotor.CreateObject(Encoding.Unicode);
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
