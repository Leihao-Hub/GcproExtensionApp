using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region GcproExtensionLibary
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro.GCObject;
using GcproExtensionLibary.Gcpro;
using GcproExtensionLibrary.FileHandle;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Data.Common;
using GcproExtensionLibary;
using GcproExtensionLibary.FileHandle;
using System.IO;
using System.Windows.Controls;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
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
        GcMotor myMotor = new GcMotor(AppGlobalSource.GcproDBInfo.GcproTempPath);
        ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        OleDb oledb = new OleDb();
        DataTable dataTable = new DataTable();
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
        #region Public interfaces
        public void GetInfoFromDatabase()
        {
            string itemInfo;
            List<string> list;
            oledb.DataSource = AppGlobalSource.GcproDBInfo.GcsLibaryPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;

            ///<ReadInfoFromGcsLibrary> Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary </ReadInfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={GcMotor.OTypeValue}",
                null, $"{GcproTable.SubType.FieldSub_Type_Desc.Name} ASC",
                GcproTable.SubType.FieldSubType.Name, GcproTable.SubType.FieldSub_Type_Desc.Name);
            // List<string> list = OleDb.GetColumnData<string>(dataTable, "SubType");

            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.SubType.TableName) + AppGlobalSource.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>($"{GcproTable.SubType.FieldSub_Type_Desc.Name}");
                ComboEquipmentSubType.Items.Add(itemInfo);

            }
            ComboEquipmentSubType.SelectedIndex = 0;
            ///<ProcessFct> Read [ProcessFct] </ProcessFct>
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {GcMotor.OTypeValue}",
                null, $"{GcproTable.ProcessFct.FieldFct_Desc.Name} ASC",
                 GcproTable.ProcessFct.FieldProcessFct.Name, GcproTable.ProcessFct.FieldFct_Desc.Name);
            //list = OleDb.GetColumnData<string>(dataTable, "Fct_Desc");
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {
                itemInfo = dataTable.Rows[count].Field<string>(GcproTable.ProcessFct.FieldProcessFct.Name) + AppGlobalSource.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>(GcproTable.ProcessFct.FieldFct_Desc.Name);
                ComboProcessFct.Items.Add(itemInfo);
            }
            ///<Unit>Read [unit] </Unit>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_UnitCfg}%'",
                null, $"{GcproTable.TranslationCbo.FieldValue.Name} ASC",
                GcproTable.TranslationCbo.FieldValue.Name, GcproTable.TranslationCbo.FieldText.Name);
            for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
            {

                itemInfo = dataTable.Rows[count].Field<double>(GcproTable.TranslationCbo.FieldValue.Name) + AppGlobalSource.FIELDS_SEPARATOR +
                      dataTable.Rows[count].Field<string>(GcproTable.TranslationCbo.FieldText.Name);
                ComboUnit.Items.Add(itemInfo);
            }
            ComboUnit.SelectedIndex = 2;

            ///<ReadInfoFromProjectDB> 
            ///Read [PType],[Building],[Elevation],[Panel]
            ///Read [DPNode1],[DPNode2],[HornCode]
            ///</ReadInfoFromProjectDB>
            oledb.DataSource = AppGlobalSource.GcproDBInfo.ProjectDBPath;
            ///<PType> Read [PType] </PType>
            dataTable = oledb.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name} LIKE '{GcproTable.TranslationCbo.Class_ASWMsgType + GcMotor.OTypeValue}'",
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
                itemInfo = dataTable.Rows[count].Field<double>(GcproTable.TranslationCbo.FieldValue.Name) + AppGlobalSource.FIELDS_SEPARATOR +
                       dataTable.Rows[count].Field<string>(GcproTable.TranslationCbo.FieldText.Name);
                ComboDiagram.Items.Add(itemInfo);
            }


        }
        public void GetLastObjRule()
        {
            TxtSymbolRule.Text = GcMotor.Rule.Common.NameRule;
            TxtSymbolIncRule.Text = GcMotor.Rule.Common.NameRuleInc;
            TxtDescriptionRule.Text = GcMotor.Rule.Common.DescriptionRule;
            TxtDescriptionIncRule.Text = GcMotor.Rule.Common.DescriptionRuleInc;
            TxtVFCRule.Text = GcMotor.Rule.VFCRule;
            TxtVFCIncRule.Text = GcMotor.Rule.VFCRuleInc;
            TxtAORule.Text = GcMotor.Rule.AORule;
            TxtAOIncRule.Text = GcMotor.Rule.AORuleInc;
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobalSource.CREATE_IMPORT_RULE + myMotor.OType);
            toolTip.SetToolTip(BtnConnectIO, AppGlobalSource.CONNECT_IO);
            toolTip.SetToolTip(BtnConnectVFC, AppGlobalSource.SET_RELATION);
            toolTip.SetToolTip(TxtSymbol, AppGlobalSource.DEMO_NAME + DEMO_NAME_MOTOR);
            toolTip.SetToolTip(TxtSymbolRule, AppGlobalSource.DEMO_NAME_RULE + DEMO_NAME_RULE_MOTOR);
            toolTip.SetToolTip(TxtDescription, AppGlobalSource.DEMO_DESCRIPTION + DEMO_DESCRIPTION_MOTOR);
            toolTip.SetToolTip(TxtDescriptionRule, AppGlobalSource.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_MOTOR);
        }
        public void CreateImpExp()
        {
            oledb.DataSource = AppGlobalSource.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = isNewOledbDriver;
            oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{GcMotor.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobalSource.MSG_RULE_ALREADY_EXITS, AppGlobalSource.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{GcMotor.ImpExpRuleName}'", null);
                    CreateMotorImpExp();
                }
                else
                    { return; }
            }
            else
                { CreateMotorImpExp(); }
        }

        public void Default()
        {
           
            TxtSymbol.Focus();
            TxtInpRunFwd.Text = TxtSymbol.Text + ":I";
            TxtOutpRunFwd.Text = TxtSymbol.Text + ":O";
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;

            var alphabetList = AppGlobalSource.CreateAlphabetList<string>('A', 'Z', letter => letter.ToString());
            foreach (var item in alphabetList)
            {
                comboNameBML.Items.Add(item);
                comboDescBML.Items.Add(item);
                comboTypeBML.Items.Add(item);
                comboFloorBML.Items.Add(item);
                comboPowerBML.Items.Add(item);
                comboSectionBML.Items.Add(item);
                comboCabinetBML.Items.Add(item);
                comboNameBML.SelectedItem = "B";
                comboDescBML.SelectedItem = "N";
                comboTypeBML.SelectedItem = "C";
                comboFloorBML.SelectedItem = "L";
                comboPowerBML.SelectedItem = "E";
                comboCabinetBML.SelectedItem= "P";
                comboSectionBML.SelectedItem = "Q";

            }
            for (int i = 1; i <= 20; i++)     
                { comboStartRow.Items.Add(i); }
            comboStartRow.SelectedItem = 2;

            CreateBMLDefault();
            toolStripMenuClearList.Click += new EventHandler(toolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
        }

        #endregion

        private void CreateMotorImpExp()
        {

            List<List<GcproExtensionLibary.DbParameter>> recordList = new List<List<GcproExtensionLibary.DbParameter>>
                    {
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value =GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Type" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.OType.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Name" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Text0.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Description" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value =GcproTable.ObjData.Text1.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SubType" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.SubType.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ProcessFct" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.ProcessFct.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Building" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Building.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Elevation" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Elevation.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "FieldBusNode" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.FieldbusNode.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Panel ID"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Panel_ID.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Diagram"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DiagramNo.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "PType"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value5.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Horn Code"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value2.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DP node1"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode1.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DP node2"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode2.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Gcpro parameters"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value9.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Object parameters"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value10.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpFwd"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpFwd"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpRev"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpRev"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpContactor" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Adapter"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTime"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStartDelay"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name }

                    },
                        new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStartingTime"},
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParIdlingTime" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParFaultDelayTime" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParPowerNominal" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value49.Name }

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParSpeedService" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value52.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Unit" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value40.Name}

                    },
                    new List<GcproExtensionLibary.DbParameter>
                    {
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldType.Name, Value = GcMotor.ImpExpRuleName },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Is new" },
                        new GcproExtensionLibary.DbParameter { Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.IsNew.Name }

                    }
                };
            if (oledb.InsertMultipleRecords(GcproTable.ImpExpDef.TableName, recordList))
            {
                MessageBox.Show(AppGlobalSource.MSG_RULE_CREATE_SUCESSFULL, AppGlobalSource.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void FormMotor_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobalSource.GcproDBInfo.ProjectDBPath);
            Default();
            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
        }

        #region <---Rule and autosearch part--->

        #region <------Check and store rule event------>
        private void TxtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobalSource.CheckNumericString(TxtSymbolRule.Text))
            {
                GcMotor.Rule.Common.NameRule = TxtSymbolRule.Text;
            }
            else
            {
                AppGlobalSource.MessageNotNumeric();
            }
        }

        private void TxtSymbolIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobalSource.CheckNumericString(TxtSymbolRule.Text))
                {
                    GcMotor.Rule.Common.NameRuleInc = TxtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobalSource.MessageNotNumeric();
                }
            }
        }

        private void TxtDescriptionRule_TextChanged(object sender, EventArgs e)
        {

            if (AppGlobalSource.CheckNumericString(TxtDescriptionRule.Text))
            {
                GcMotor.Rule.Common.DescriptionRule = TxtDescriptionRule.Text;
            }
            else
            {
                AppGlobalSource.MessageNotNumeric();
            }

        }
        private void TxtDescriptionIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobalSource.CheckNumericString(TxtDescriptionIncRule.Text))
                {
                    GcMotor.Rule.Common.DescriptionRuleInc = TxtDescriptionIncRule.Text;
                }
                else
                {
                    AppGlobalSource.MessageNotNumeric();
                }
            }

        }

        private void TxtVFCRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobalSource.CheckNumericString(TxtVFCRule.Text))
            {
                GcMotor.Rule.VFCRule = TxtVFCRule.Text;
            }
            else
            {
                AppGlobalSource.MessageNotNumeric();
            }
        }
        private void TxtVFCIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobalSource.CheckNumericString(TxtVFCIncRule.Text))
                {
                    GcMotor.Rule.VFCRuleInc = TxtVFCIncRule.Text;
                }
                else
                {
                    AppGlobalSource.MessageNotNumeric();
                }
            }
        }
        private void TxtAORule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobalSource.CheckNumericString(TxtAORule.Text))
            {
                GcMotor.Rule.AORule = TxtAORule.Text;
            }
            else
            {
                AppGlobalSource.MessageNotNumeric();
            }
        }

        private void TxtAOIncRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AppGlobalSource.CheckNumericString(TxtAOIncRule.Text))
                {
                    GcMotor.Rule.AORuleInc = TxtAOIncRule.Text;
                }
                else
                {
                    AppGlobalSource.MessageNotNumeric();
                }
            }
        }

        private void TxtMonTime_TextChanged(object sender, EventArgs e)
        {
            if (!(AppGlobalSource.CheckNumericString(TxtMonTime.Text)))
            {
                AppGlobalSource.MessageNotNumeric();
            }

        }
        #endregion

        #region <------Field in database display
        private void TxtSymbol_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Text0";
        }

        private void TxtDescription_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Text1";
        }

        private void TxtInpRunFwd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value11";
        }
        private void TxtOutpRunFwd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value12";
        }
        private void TxtInHWStop_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value47";
        }

        private void TxtVFCAdapter_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value34";
        }

        private void TxtAO_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value33";
        }

        private void ComboUnit_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value40";
        }

        private void ComboEquipmentInfoType_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value5";
        }

        private void ComboHornCode_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value2";
        }

        private void ComboDPNode1_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "DPNode1";
        }

        private void ComboDPNode2_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "DPNode2";
        }

        private void TxtMonTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value21";
        }

        private void TxtStartDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value26";
        }

        private void TxtStartingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value22";
        }

        private void TxtStoppingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value23";
        }

        private void TxtIdlingTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value24";
        }

        private void TxtFaultDelayTime_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value25";
        }

        private void TxtKW_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value49";
        }

        private void ChkParManual_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value10.Bit1";
        }

        private void ChkRestartDelay_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value10.Bit2";
        }

        private void ChkRevNotAllowed_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value10.Bit7";
        }

        private void ChKPower_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value10.Bit8";
        }

        private void ChkRunInterlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value9.Bit1";
        }

        private void ChkStartingInterlock_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobalSource.OBJECT_FIELD + "Value9.Bit0";
        }
        #endregion
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            myMotor.CreateObject();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            myMotor.Clear();
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            myMotor.SaveFileAs();
        }

        private void BtnNewImpExpDef_Click(object sender, EventArgs e)
        {
            CreateImpExp();
        }
        #endregion

        #region <---BML part--->

        private void BtnOpenProjectDB_Click(object sender, EventArgs e)
        {
            TxtExcelPath.Text = ExcelFileHandle.BrowseFile();
            excelFileHandle.FilePath = TxtExcelPath.Text;           
        }
        private void TxtExcelPath_DoubleClick(object sender, EventArgs e)
        {
            TxtExcelPath.Text = ExcelFileHandle.BrowseFile(); 
        }
        private void TxtExcelPath_TextChanged(object sender, EventArgs e)
        {
            excelFileHandle.FilePath = TxtExcelPath.Text;
        }
        private void comboWorkSheetsBML_MouseEnter(object sender, EventArgs e)
        {
            comboWorkSheetsBML.Items.Clear();   
            try
            {
                List<string> workSheets = new List<string>();
                workSheets=excelFileHandle.GetWorkSheets();
                foreach (string sheet in workSheets) 
                { 
                    comboWorkSheetsBML.Items.Add(sheet);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(AppGlobalSource.EX_FILE_NOT_FOUND,AppGlobalSource.INFO,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(AppGlobalSource.EX_UNAUTHORIZED_ACCESS, AppGlobalSource.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(AppGlobalSource.EX_IO_ERROR+$"{ ex.Message}", AppGlobalSource.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(AppGlobalSource.EX_UNKNOW + $"{ex.Message}", AppGlobalSource.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        private void comboWorkSheetsBML_SelectedIndexChanged(object sender, EventArgs e)
        {

            excelFileHandle.WorkSheet=comboWorkSheetsBML.SelectedItem.ToString();
        }
        private void CreateBMLDefault()
        {
            dataGridBML.AutoGenerateColumns =false;
 
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = BML.Motor.ColumnName; // 列头的名称
            nameColumn.Name =nameof(BML.Motor.ColumnName); // 列的唯一名称，方便查找                                                 
            dataGridBML.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.HeaderText = BML.Motor.ColumnDesc; 
            descColumn.Name = nameof(BML.Motor.ColumnDesc); 
            dataGridBML.Columns.Add(descColumn);

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
            DataGridViewTextBoxColumn cabinetColumnGroup = new DataGridViewTextBoxColumn();
            cabinetColumnGroup.HeaderText = BML.Motor.ColumnCabinetGroup;
            cabinetColumnGroup.Name = nameof(BML.Motor.ColumnCabinetGroup);
            dataGridBML.Columns.Add(cabinetColumnGroup);
        }

        private void btnReadBML_Click(object sender, EventArgs e)
        {
            List<List<object>> allData = new List<List<object>>();
            string[] columnList = { comboNameBML.Text, comboDescBML.Text, comboPowerBML.Text,comboFloorBML.Text,
                comboCabinetBML.Text ,comboSectionBML.Text};           
            allData = excelFileHandle.ReadFileAsList(int.Parse(comboStartRow.Text), columnList, BML.Motor.TypeMotor, comboTypeBML.Text);
         
            foreach (var list in allData)
            {
               // dataGridBML.DataSource = allData;
             
                //for (var i = 0; i < list.Count; i++)
                //{ dataGridBML.DataMember = list; }
            }
           
            dataTable.Rows.Clear();   
            dataTable= excelFileHandle.ReadFileAsDataTable(int.Parse(comboStartRow.Text), columnList, BML.Motor.TypeMotor, comboTypeBML.Text);
            dataGridBML.DataSource= dataTable;
            dataGridBML.AutoGenerateColumns = false;

            dataGridBML.Columns[nameof(BML.Motor.ColumnName)].DataPropertyName = dataTable.Columns[0].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnDesc)].DataPropertyName = dataTable.Columns[1].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnPower)].DataPropertyName = dataTable.Columns[2].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnFloor)].DataPropertyName = dataTable.Columns[3].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnCabinet)].DataPropertyName = dataTable.Columns[4].ColumnName;
            dataGridBML.Columns[nameof(BML.Motor.ColumnCabinetGroup)].DataPropertyName = dataTable.Columns[5].ColumnName;
           
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
                TxtSymbolRule.Text = GcMotor.Rule.Common.NameRule;
                TxtSymbolIncRule.Text = GcMotor.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                GrpSymbolRule.Visible = true;
                LblSymbol.Text = AppGlobalSource.KEY_WORD_AUTOSEARCH;
                TxtSymbol.Text = DEMO_NAME_MOTOR;
            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                TxtSymbolRule.Text = GcMotor.Rule.Common.NameRule;
                TxtSymbolIncRule.Text = GcMotor.Rule.Common.NameRuleInc;
                LblQuantity.Visible = false;
                TxtQuantity.Visible = false;
                GrpSymbolRule.Visible = false;
                LblSymbol.Text = AppGlobalSource.KEY_WORD_AUTOSEARCH;
                TxtSymbol.Text = "-MXZ";
            }
      
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.BML)
            {
                createMode.Rule = false;
                createMode.BML = true;
                createMode.AutoSearch =false;
                tabCreateMode.SelectedTab = tabBML;
            }
         
        }
        private void tabCreateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCreateMode.SelectedTab == tabRule)

            { ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule; }
            else
            { ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.BML; }            
           
        }

        private void toolStripMenuClearList_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
        }
        private void toolStripMenuReload_Click(object sender, EventArgs e)
        {
            btnReadBML_Click(sender,e);
        }

     
    }
}
