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
using System.Xml.Linq;
using OfficeOpenXml.Packaging.Ionic.Zlib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
#endregion
namespace GcproExtensionApp
{
    #pragma warning disable IDE1006
    public partial class FormDischargerVertex : Form, IGcForm
    {
        public FormDischargerVertex()
        {
            InitializeComponent();
        }

        #region Public object in this class
        readonly DischargerVertex myDischargerVertex = new DischargerVertex(AppGlobal.GcproDBInfo.GcproTempPath);
       // readonly ExcelFileHandle excelFileHandle = new ExcelFileHandle();
        readonly System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        readonly CreateMode createMode = new CreateMode();
        private bool isNewOledbDriver;
        private readonly string DEMO_NAME_DischargerVertex = "Vertex01Bin501D0";
        private readonly string DEMO_NAME_RULE_DischargerVertex = "501";
        private readonly string DEMO_DESCRIPTION_DischargerVertex = "配粉A线4楼501配粉仓卸料器/或者空白";
        private readonly string DEMO_DESCRIPTION_RULE_DischargerVertex = "";
        private readonly string DischargerVertexPrefix = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_DISCHARGER_VERTEX}.{AppGlobal.JS_PREFIX}.";
        private readonly string Discharger = "卸料器";
        private int value10;
        private int tempInt;
        private double tempDouble;
        private GcBaseRule objDefaultInfo;
        #endregion

        #region Public interfaces
        public void GetInfoFromDatabase()
        {
            string itemInfo;
            List<string> list;
            DataTable dataTable;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.GcsLibaryPath, isNewOledbDriver);
            ///<ReaDischargerVertexnfoFromGcsLibrary> 
            ///Read [SubType], [Unit] ,[ProcessFct]from GcsLibrary 
            ///</ReaDischargerVertexnfoFromGcsLibrary>
            ///<SubType> Read [SubType] </SubType>
            dataTable = oledb.QueryDataTable(GcproTable.SubType.TableName, $"{GcproTable.SubType.FieldOType.Name}={DischargerVertex.OTypeValue}",
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
            dataTable = oledb.QueryDataTable(GcproTable.ProcessFct.TableName, $"{GcproTable.ProcessFct.FieldOType.Name} = {DischargerVertex.OTypeValue}",
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
            objDefaultInfo.NameRule = "501";
            objDefaultInfo.DescLine = "配粉A线";
            objDefaultInfo.DescFloor = "4楼";
            objDefaultInfo.Name = "Vertex01Bin501D0";
            objDefaultInfo.DescObject = "501号配粉仓卸料器";
   
            objDefaultInfo.DescriptionRuleInc = DischargerVertex.Rule.Common.DescriptionRuleInc;
            objDefaultInfo.NameRuleInc = DischargerVertex.Rule.Common.NameRuleInc;
            DischargerVertex.Rule.Common.Cabinet = DischargerVertex.Rule.Common.Power = string.Empty;

            objDefaultInfo.Description = DischargerVertex.EncodingDesc(
                baseRule: ref objDefaultInfo,
                namePrefix: GcObjectInfo.General.PrefixName,
                nameRule: Engineering.PatternMachineName,
                withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
                withFloorInfo: chkAddFloorToDesc.Checked,
                withNameInfo: chkAddNameToDesc.Checked,
                withCabinet: chkAddCabinetToDesc.Checked,
                withPower: false,
                nameOnlyWithNumber: chkNameOnlyNumber.Checked);
            if (String.IsNullOrEmpty(DischargerVertex.Rule.Common.Description))
            { 
                DischargerVertex.Rule.Common.Description = objDefaultInfo.Description; 
            }
            if (String.IsNullOrEmpty(DischargerVertex.Rule.Common.Name))
            { 
                DischargerVertex.Rule.Common.Name = objDefaultInfo.Name;
            }
            if (String.IsNullOrEmpty(DischargerVertex.Rule.Common.DescLine))
            { 
                DischargerVertex.Rule.Common.DescLine = objDefaultInfo.DescLine; 
            }
            if (String.IsNullOrEmpty(DischargerVertex.Rule.Common.DescFloor))
            { 
                DischargerVertex.Rule.Common.DescFloor = objDefaultInfo.DescFloor; 
            }
            if (String.IsNullOrEmpty(DischargerVertex.Rule.Common.DescObject))
            {
                DischargerVertex.Rule.Common.DescObject = objDefaultInfo.DescObject;
            }         
            txtSymbolRule.Text = DischargerVertex.Rule.Common.NameRule;
            txtSymbolIncRule.Text = DischargerVertex.Rule.Common.NameRuleInc;
            txtDescriptionRule.Text = DischargerVertex.Rule.Common.DescriptionRule;
            txtDescriptionIncRule.Text = DischargerVertex.Rule.Common.DescriptionRuleInc;
            txtSymbol.Text = DischargerVertex.Rule.Common.Name;
            txtDescription.Text = DischargerVertex.Rule.Common.Description;
            txtBin.Text = "Bin501";
            txtVertex.Text = "Vertex01";
            txtParBinNo.Text = "501";
            txtParScaleNo.Text ="1";
        }
        public void CreateTips()
        {
            toolTip.SetToolTip(BtnNewImpExpDef, AppGlobal.CREATE_IMPORT_RULE + DischargerVertex.OType);
            toolTip.SetToolTip(txtSymbol, AppGlobal.DEMO_NAME + DEMO_NAME_DischargerVertex);
            toolTip.SetToolTip(txtSymbolRule, AppGlobal.DEMO_NAME_RULE + DEMO_NAME_RULE_DischargerVertex);
            toolTip.SetToolTip(txtDescription, AppGlobal.DEMO_DESCRIPTION + DEMO_DESCRIPTION_DischargerVertex);
           
            toolTip.SetToolTip(txtDescriptionRule, AppGlobal.DEMO_DESCRIPTION_RULE + DEMO_DESCRIPTION_RULE_DischargerVertex);
        }
        private void CreateDischargerVertexImpExp(OleDb oledb)
        {
            bool result = myDischargerVertex.CreateImpExpDef((tableName, impExpList) =>
            {
                return oledb.InsertRecords(tableName, impExpList);
            });
            if (result)
            {
                MessageBox.Show(AppGlobal.MSG_RULE_CREATE_SUCESSFULL, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void CreateImpExp()
        {
            DataTable dataTable;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            dataTable = oledb.QueryDataTable(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{DischargerVertex.ImpExpRuleName}'",
            null, null, GcproTable.ImpExpDef.FieldType.Name);
            if (dataTable.Rows.Count > 0)
            {
                if (MessageBox.Show(AppGlobal.MSG_RULE_ALREADY_EXITS, AppGlobal.INFO,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oledb.DeleteRecord(GcproTable.ImpExpDef.TableName, $"{GcproTable.ImpExpDef.FieldType.Name} LIKE '{DischargerVertex.ImpExpRuleName}'", null);
                    CreateDischargerVertexImpExp(oledb);
                }
                else
                {
                    return;
                }
            }
            else
            {
                CreateDischargerVertexImpExp(oledb);
            }
        }

        public void Default()
        {
            txtSymbol.Focus();
            ///Get parameters from DischargerVertex
            txtParDosingSpeedFast.Text = myDischargerVertex.ParDosingSpeedFast.ToString();
            txtParDosingSpeedSlow.Text = myDischargerVertex.ParDosingSpeedSlow.ToString();
            txtParSwitchTimeFtoS.Text = myDischargerVertex.ParSwitchOverTimeFToS.ToString();
            txtParDosingTimeSlow.Text = myDischargerVertex.ParDosingTimeSlow.ToString();
            txtParCutOffWeightCorrMax.Text = myDischargerVertex.ParCutoffWeightCorrMax.ToString();

            txtParLevelCompensationMax.Text = myDischargerVertex.ParLevelCompensationMax.ToString();
            txtParDosingTimeMax.Text = myDischargerVertex.ParDosingTimeMax.ToString();
            txtParFineDosingWeight.Text = myDischargerVertex.ParFineDosingWeight.ToString();
            txtParCutoffWeight.Text = myDischargerVertex.ParCutoffWeight.ToString();
            txtParFlowrateFast.Text = myDischargerVertex.ParFlowrateFast.ToString();   
            txtParFlowrateSlow.Text = myDischargerVertex.ParFlowrateSlow.ToString();
            txtParTipPulseLen.Text = myDischargerVertex.ParTipPulseLen.ToString();

            txtParTolPosWeight.Text = myDischargerVertex.ParTolPosWeight.ToString();
            txtParTolPosRel.Text = myDischargerVertex.ParTolPosRel.ToString();
            txtParAutoPosWeight.Text = myDischargerVertex.ParTolAutoPosWeight.ToString();
            txtParAutoPosRel.Text = myDischargerVertex.ParTolAutoPosRel.ToString();
            txtParTolNegWeight.Text = myDischargerVertex.ParTolNegWeight.ToString();
            txtParTolNegRel.Text = myDischargerVertex.ParTolNegRel.ToString();
            txtBinIncRule.Text = DischargerVertex.Rule.BinNoInc.ToString();

            txtParHeightDropMax.Text = myDischargerVertex.ParHeightDropMax.ToString();
            txtParDownPipeWeight.Text = myDischargerVertex.ParDownPipeWeight.ToString();
            //txtSymbolIncRule.Text = DischargerVertex.Rule.Common.NameRuleInc;
            //txtSymbolRule.Text = DischargerVertex.Rule.Common.NameRule;
            //txtDescriptionIncRule.Text = DischargerVertex.Rule.Common.DescriptionRuleInc;
            LblFieldInDatabase.Text = AppGlobal.OBJECT_FIELD + GcproTable.ObjData.Text0.Name;
            ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.Rule);
            //ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.BML);
            //ComboCreateMode.Items.Add(CreateMode.ObjectCreateMode.AutoSearch);
            ComboCreateMode.SelectedItem = CreateMode.ObjectCreateMode.Rule;
            ComboEquipmentSubType.SelectedIndex = 2;     
            toolStripMenuClearList.Click += new EventHandler(ToolStripMenuClearList_Click);
            toolStripMenuReload.Click += new EventHandler(toolStripMenuReload_Click);
            toolStripMenuDelete.Click += new EventHandler(toolStripMenuDelete_Click);
            this.Text = "DischargerVertex导入文件 " + " " + myDischargerVertex.FilePath;
        }

        #endregion

        private void UpdateDesc()
        {
            DischargerVertex.EncodingDesc(
            baseRule: ref DischargerVertex.Rule.Common,
            namePrefix: GcObjectInfo.General.PrefixName,
            nameRule: Engineering.PatternMachineName,
            withLineInfo: (chkAddSectionToDesc.Checked || chkAddUserSectionToDesc.Checked),
            withFloorInfo: chkAddFloorToDesc.Checked,
            withNameInfo: chkAddNameToDesc.Checked,
            withCabinet: chkAddCabinetToDesc.Checked,
            withPower: false,
            nameOnlyWithNumber: chkNameOnlyNumber.Checked
            );
            txtDescription.Text = DischargerVertex.Rule.Common.Description;
        }
        private void FormDischargerVertex_Load(object sender, EventArgs e)
        {
            isNewOledbDriver = AccessFileHandle.CheckAccessFileType(AppGlobal.GcproDBInfo.ProjectDBPath);

            ///<ImplementIGcForm>   </ImplementIGcForm>
            GetLastObjRule();
            GetInfoFromDatabase();
            CreateTips();
            Default();
        }
        private void FormDischargerVertex_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        #region <---Rule and autosearch part--->
        private string GetInfoFromName(string pattern,string name,bool ingoreCase)
        {
            return LibGlobalSource.StringHelper.ExtractStringPart(pattern, name, ingoreCase);                  
        }
        private string GetInfoValueFromName(string pattern, string name, bool ingoreCase)
        {
            return LibGlobalSource.StringHelper.ExtractNumericPart(
            GetInfoFromName(pattern, name, true), ingoreCase);
        }
        private string GetScaleNameFromName(string prefixCWA, string prefixVertex, string name, bool ingoreCase)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }
            string pattern = $@"{prefixVertex}\d+";
            string result = GetInfoFromName(pattern, name, ingoreCase);
            pattern = $@"{prefixCWA}\d+";
            return string.IsNullOrEmpty(result) ? GetInfoFromName(pattern, name, ingoreCase): result;
        }

        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            myDischargerVertex.Name = txtSymbol.Text;
            DischargerVertex.Rule.Common.Name = txtSymbol.Text;
            txtBin.Text = GetInfoFromName($@"{GcObjectInfo.Bin.BinPrefix}\d+", txtSymbol.Text, true);
            txtParDischargerNo.Text = GetInfoValueFromName($@"{GcObjectInfo.DischargerVertex.PrefixDischargerNo}\d+", txtSymbol.Text, true);
            txtVertex.Text = GetScaleNameFromName(GcObjectInfo.DischargerVertex.PrefixCWA, GcObjectInfo.DischargerVertex.PrefixVertex, txtSymbol.Text, true);
            UpdateDesc();
            DischargerVertex.Rule.Common.NameRule = txtSymbolRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtSymbol.Text.Substring(
               txtSymbol.Text.IndexOf(GcObjectInfo.Bin.BinPrefix, StringComparison.OrdinalIgnoreCase)), false);
        }

        private void DescObject()
        {
            string stringNumber = LibGlobalSource.StringHelper.ExtractNumericPart(txtBin.Text, false);
            if (AppGlobal.ParseValue<int>(stringNumber, out tempInt))
            {
                txtDescriptionRule.Text = stringNumber;
                DischargerVertex.Rule.Common.DescObject = objDefaultInfo.DescObject = $"{stringNumber}号{GcObjectInfo.Bin.ReturnBin(tempInt)}{Discharger}";
            }
        }

        private void TxtBin_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={Bin.OTypeValue} And {GcproTable.ObjData.Text0.Name}='{txtBin.Text}'",
                          null, null, GcproTable.ObjData.Value1.Name);
           if (dataTable.Rows.Count == 0)
            {
                txtParBinNo.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtBin.Text, false);
            }
            else
            {
                txtParBinNo.Text = dataTable.Rows[0].Field<double>(GcproTable.ObjData.Value1.Name).ToString();
            }
  
           txtBinRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtBin.Text, false);
           myDischargerVertex.Bin = txtBin.Text;
           string discharger = txtSymbol.Text.Substring(txtSymbol.Text.IndexOf("D"));
           txtSymbol.Text = $"{txtVertex.Text}{txtBin.Text}{discharger}";
           DescObject();
           UpdateDesc();
        }

        private void TxtVertex_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable;
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
           dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name} = {(int)OTypeCollection.Vertex} And {GcproTable.ObjData.Text0.Name}='{txtVertex.Text}'",
                          null, null, GcproTable.ObjData.Value1.Name);
            if (dataTable.Rows.Count ==0)
            {
                txtParScaleNo.Text = LibGlobalSource.StringHelper.ExtractNumericPart(txtVertex.Text, false);
            }
            else
            {
                txtParScaleNo.Text = dataTable.Rows[0].Field<double>(GcproTable.ObjData.Value1.Name).ToString();
            }
            myDischargerVertex.Vertex = txtVertex.Text;
            string discharger = txtSymbol.Text.Substring(txtSymbol.Text.IndexOf("D"));
            txtSymbol.Text = $"{txtVertex.Text}{txtBin.Text}{discharger}";
        }
        private void txtSymbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value21.Name,
                OType = Convert.ToString(DischargerVertex.OTypeValue)
            };
            objectBrowser.Show();
        }
        private void TxtBin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value1.Name,
                OType = Convert.ToString(Bin.OTypeValue),
                SubType = Bin.BINB
            };
        
            objectBrowser.ShowDialog();
            if (!string.IsNullOrEmpty(objectBrowser.ReturnedItem))
            {
                txtBin.Text = objectBrowser.ReturnedItem;
            }
        }

        private void TxtVertex_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Value1.Name,
                OType = Convert.ToString((int)OTypeCollection.Vertex),
                SubType = string.Empty
            };
            objectBrowser.ShowDialog();
            if (!string.IsNullOrEmpty(objectBrowser.ReturnedItem))
            {
                txtVertex.Text = objectBrowser.ReturnedItem;
            }        
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!DischargerVertex.Rule.Common.Description.Equals(txtDescription.Text))
            {
                DischargerVertex.Rule.Common.Description = txtDescription.Text;
            }
            txtDescriptionRule.Text = LibGlobalSource.StringHelper.ExtractNumericPart(DischargerVertex.Rule.Common.DescObject, false);
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
                    DischargerVertex.Rule.Common.Description = txtDescription.Text;
                    DischargerVertex.DecodingDesc(ref DischargerVertex.Rule.Common, AppGlobal.DESC_SEPARATOR);
                    UpdateDesc();
                }
                catch
                {
                }
            }
        }
        private void TxtParDosingSpeedFast_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParDosingSpeedFast.Text, out tempDouble);
            myDischargerVertex.ParDosingSpeedFast = tempDouble;
        }
        private void TxtParDosingSpeedSlow_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParDosingSpeedSlow.Text, out tempDouble);
            myDischargerVertex.ParDosingSpeedSlow = tempDouble;
        }

        private void TxtParSwitchTimeFtoS_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParSwitchTimeFtoS.Text, out tempDouble);
            myDischargerVertex.ParSwitchOverTimeFToS= tempDouble;
        }

        private void TxtParDosingTimeSlow_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParDosingTimeSlow.Text, out tempDouble);
            myDischargerVertex.ParDosingTimeSlow = tempDouble;
        }

        private void TxtParCutOffWeightCorrMax_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParCutOffWeightCorrMax.Text, out tempDouble);
            myDischargerVertex.ParCutoffWeightCorrMax = tempDouble;
        }

        private void TxtParDosingTimeMax_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParDosingTimeMax.Text, out tempDouble);
            myDischargerVertex.ParDosingTimeMax = tempDouble;
        }

        private void TxtParFineDosingWeight_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParFineDosingWeight.Text, out tempDouble);
            myDischargerVertex.ParFineDosingWeight = tempDouble;
        }

        private void TxtParCutoffWeight_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParCutoffWeight.Text, out tempDouble);
            myDischargerVertex.ParCutoffWeight = tempDouble;
        }

        private void TxtParFlowrateFast_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParFlowrateFast.Text, out tempDouble);
            myDischargerVertex.ParFlowrateFast = tempDouble;
        }

        private void TxtParFlowrateSlow_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParFlowrateSlow.Text, out tempDouble);
            myDischargerVertex.ParFlowrateSlow = tempDouble;
        }

        private void TxtParTipPulseLen_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParTipPulseLen.Text, out tempDouble);
            myDischargerVertex.ParTipPulseLen = tempDouble;
        }

        private void TxtParTolPosWeight_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParTolPosWeight.Text, out tempDouble);
            myDischargerVertex.ParTolPosWeight = tempDouble;
        }

        private void TxtParTolPosRel_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParTolPosRel.Text, out tempDouble);
            myDischargerVertex.ParTolPosRel = tempDouble;
        }

        private void TxtParAutoPosWeight_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParAutoPosWeight.Text, out tempDouble);
            myDischargerVertex.ParTolAutoPosWeight= tempDouble;
        }

        private void TxtParAutoPosRel_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParAutoPosRel.Text, out tempDouble);
            myDischargerVertex.ParTolAutoPosRel = tempDouble;
        }

        private void TxtParTolNegWeight_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParTolNegWeight.Text, out tempDouble);
            myDischargerVertex.ParTolNegWeight = tempDouble;
        }

        private void TxtParTolNegRel_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParTolNegRel.Text, out tempDouble);
            myDischargerVertex.ParTolNegRel = tempDouble;
        }
        private void TxtParHeightDropMax_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParHeightDropMax.Text, out tempDouble);
            myDischargerVertex.ParHeightDropMax = tempDouble;
        }

        private void TxtParDownPipeWeight_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParDownPipeWeight.Text, out tempDouble);
            myDischargerVertex.ParDownPipeWeight = tempDouble;
        }

        private void TxtParScaleNo_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParScaleNo.Text, out tempDouble);
            myDischargerVertex.ParScaleNo = tempDouble;
        }

        private void TxtParBinNo_TextChanged(object sender, EventArgs e)
        {
            AppGlobal.ParseValue<double>(txtParBinNo.Text, out tempDouble);
            myDischargerVertex.ParBinNo = tempDouble;
        }
        #region <------Check and store rule event------>

        private void txtSymbolRule_TextChanged(object sender, EventArgs e)
        {
            if (AppGlobal.CheckNumericString(txtSymbolRule.Text))
            {
                DischargerVertex.Rule.Common.NameRule = txtSymbolRule.Text;
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
                    DischargerVertex.Rule.Common.NameRuleInc = txtSymbolIncRule.Text;
                }
                else
                {
                    AppGlobal.MessageNotNumeric();
                }
            }
        }

        private void txtDescriptionRule_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescriptionRule.Text))
            { 
                return; 
            }
            if (!txtDescription.Text.Contains(txtDescriptionRule.Text))
            { txtDescription.BackColor = Color.Red; }
            else
            { txtDescription.BackColor = Color.White; }
            if (AppGlobal.CheckNumericString(txtDescriptionRule.Text))
            {
                string descObjectNumber = LibGlobalSource.StringHelper.ExtractNumericPart(DischargerVertex.Rule.Common.DescObject, false);
                if (!string.IsNullOrEmpty(descObjectNumber))
                {
                    DischargerVertex.Rule.Common.DescriptionRule = txtDescriptionRule.Text;
                    DischargerVertex.Rule.Common.DescObject = DischargerVertex.Rule.Common.DescObject.Replace(descObjectNumber, DischargerVertex.Rule.Common.DescriptionRule);
                    UpdateDesc();
                }
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
                    DischargerVertex.Rule.Common.DescriptionRuleInc = txtDescriptionIncRule.Text;
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
                value10 = AppGlobal.ParseValue<int>(txtValue10.Text, out tempInt) ? tempInt : value10;
                GetValue10BitValue(value10);
            }
        }

        #endregion <------Check and store rule event------>

        #region <------ Check and unchek "Value9" and "Value10------>    

        private void ChkParManualAdd_CheckedChanged(object sender, EventArgs e)
        {
        //    value10 = int.Parse(txtValue10.Text);
        //    if (chkParManualAdd.Checked)
        //    { AppGlobal.SetBit<int>(ref value10, (byte)0); }

        //    else
        //    { AppGlobal.ResetBit<int>(ref value10, (byte)0); }

        //    myDischargerVertex.Value10 = value10;
        //    txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        private void ChkPar1Speed_CheckedChanged(object sender, EventArgs e)
        {
            //value10 = int.Parse(txtValue10.Text);
            //if (chkPar1Speed.Checked)
            //{ AppGlobal.SetBit<int>(ref value10, (byte)1); }

            //else
            //{ AppGlobal.ResetBit<int>(ref value10, (byte)1); }

            //myDischargerVertex.Value10 = value10;
            //txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        private void ChkPar2Speed_CheckedChanged(object sender, EventArgs e)
        {
            //value10 = int.Parse(txtValue10.Text);
            //if (chkPar2Speed.Checked)
            //{ AppGlobal.SetBit<int>(ref value10, (byte)2); }

            //else
            //{ AppGlobal.ResetBit<int>(ref value10, (byte)2); }

            //myDischargerVertex.Value10 = value10;
            //txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        private void ChkParFrequency_CheckedChanged(object sender, EventArgs e)
        {
            //value10 = int.Parse(txtValue10.Text);
            //if (chkParFrequency.Checked)
            //{ AppGlobal.SetBit<int>(ref value10, (byte)3); }

            //else
            //{ AppGlobal.ResetBit<int>(ref value10, (byte)3); }

            //myDischargerVertex.Value10 = value10;
            //txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        private void ChkParFlowmeter_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParFlowmeter.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)5); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)5); }

            myDischargerVertex.Value10 = value10;
            txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        private void ChkParScrew_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParScrew.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)6); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)6); }

            myDischargerVertex.Value10 = value10;
            txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        private void ChkParWithIngrInfo_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithIngrInfo.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)7); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)7); }

            myDischargerVertex.Value10 = value10;
            txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        private void ChkParModeFineDosingWeight_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParModeFineDosingWeight.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)4); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)4); }

            myDischargerVertex.Value10 = value10;
            txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        private void ChkParWithDynmicTipPluse_CheckedChanged(object sender, EventArgs e)
        {
            value10 = int.Parse(txtValue10.Text);
            if (chkParWithDynmicTipPluse.Checked)
            { AppGlobal.SetBit<int>(ref value10, (byte)8); }

            else
            { AppGlobal.ResetBit<int>(ref value10, (byte)8); }

            myDischargerVertex.Value10 = value10;
            txtValue10.Text = myDischargerVertex.Value10.ToString();
        }

        #endregion <------ Check and unchek "Value9" and "Value10------> 

        #region <------Field in database display------>

        private void TxtSymbol_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Text0");
        }
        private void TxtDescription_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Text1");
        }
        private void TxtParDischargerNo_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value13");
        }

        private void TxtBin_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value41");
        }

        private void TxtVertex_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value42");
        }

        private void TxtConcheMeteringSystem_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value43");
        }

        private void TxtDestination_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value44");
        }

        private void TxtParScaleNo_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value11");
        }

        private void TxtParBinNo_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value1");
        }

        private void TxtParHeightDropMax_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value29");
        }

        private void TxtParDownPipeWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value33");
        }

        private void TxtParDosingSpeedFast_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value27");
        }

        private void TxtParDosingSpeedSlow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value28");
        }

        private void TxtParSwitchTimeFtoS_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value20");
        }

        private void TxtParDosingTimeSlow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value19");
        }

        private void TxtParCutOffWeightCorrMax_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value18");
        }

        private void TxtParLevelCompensationMax_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value30");
        }

        private void TxtParDosingTimeMax_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value22");
        }

        private void TxtParTolPosWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value16");
        }

        private void TxtParTolPosRel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value23");
        }

        private void TxtParAutoPosWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value25");
        }

        private void TxtParAutoPosRel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value26");
        }

        private void TxtParTolNegWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value17");
        }

        private void TxtParTolNegRel_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value24");
        }

        private void TxtParFineDosingWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value14");
        }

        private void TxtParCutoffWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value15");
        }

        private void TxtParFlowrateFast_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value31");
        }

        private void TxtParFlowrateSlow_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value32");
        }

        private void TxtParTipPulseLen_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value21");
        }
        private void ChkParManualAdd_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit0");
        }

        private void ChkPar1Speed_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit1");
        }

        private void ChkPar2Speed_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit2");
        }

        private void ChkParFrequency_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit3");
        }

        private void ChkParFlowmeter_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit5");
        }

        private void ChkParScrew_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit6");
        }

        private void ChkParWithIngrInfo_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit7");
        }

        private void ChkParModeFineDosingWeight_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit4");
        }

        private void ChkParWithDynmicTipPluse_MouseEnter(object sender, EventArgs e)
        {
            LblFieldInDatabase.Text = AppGlobal.FieldDisplay("Value10 Bit8");
        }
        #endregion  <------Field in database display------>

        void SubTypeChanged()
        {          
            value10 = Convert.ToInt32(myDischargerVertex.Value10);
            txtValue10.Text = value10.ToString();
            chkParModeFineDosingWeight.Enabled = myDischargerVertex.SubType == DischargerVertex.DSFU;
            GetValue10BitValue(value10);
        }
        void GetValue10BitValue(int value)
        {
            chkParManualAdd.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 0);
            chkPar1Speed.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 1);
            chkPar2Speed.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 2);
            chkParFrequency.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 3);
            chkParFlowmeter.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 5);
            chkParScrew.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 6);
            chkParWithIngrInfo.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 7);
            chkParModeFineDosingWeight.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 4);
            chkParWithDynmicTipPluse.Checked = AppGlobal. GetBit<int>(Convert.ToInt32(value), 8);
        }
      
        private void ComboEquipmentSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ComboEquipmentSubType.SelectedItem.ToString();
                if (!String.IsNullOrEmpty(selectedItem))
                {
                    myDischargerVertex.SubType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                SubTypeChanged();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion <---Rule and autosearch part--->
     
        #region <---Common used--->

        private void ChkAddSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddSectionToDesc.Checked)
            { chkAddUserSectionToDesc.Checked = false; }
            UpdateDesc();
        }
        private void ChkAddUserSectionToDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddUserSectionToDesc.Checked)
            { chkAddSectionToDesc.Checked = false; }
            UpdateDesc();
        }
        private void ChkAddNameToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }

        private void ChkAddFloorToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }

        private void ChkNameOnlyNumber_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ChkAddCabinetToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }

        private void ChkAddPowerToDesc_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ChkNameOnlyNumber_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateDesc();
        }
        private void ComboPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboPanel.Text))
            {
                DischargerVertex.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{ComboPanel.Text}";
                UpdateDesc();
            }
        }
        private void ComboElevation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DischargerVertex.Rule.Common.DescFloor = ComboElevation.Text;
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
                txtSymbolRule.Text = DischargerVertex.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DischargerVertex.Rule.Common.NameRuleInc;
                LblQuantity.Visible = true;
                TxtQuantity.Visible = true;
                grpSymbolRule.Visible = true;
                lblSymbol.Text = AppGlobal.NAME;
             //   txtSymbol.Text = DEMO_NAME_DischargerVertex;
                tabRule.Text = CreateMode.ObjectCreateMode.Rule;

            }
            else if (ComboCreateMode.SelectedItem.ToString() == CreateMode.ObjectCreateMode.AutoSearch)
            {
                tabCreateMode.SelectedTab = tabRule;
                createMode.Rule = false;
                createMode.BML = false;
                createMode.AutoSearch = true;
                txtSymbolRule.Text = DischargerVertex.Rule.Common.NameRule;
                txtSymbolIncRule.Text = DischargerVertex.Rule.Common.NameRuleInc;
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
        private void toolStripMenuReload_Click(object sender, EventArgs e)
        {
          
        }
        private void toolStripMenuDelete_Click(object sender, EventArgs e)
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
        private void BtnConnectIO_Click(object sender, EventArgs e)
        {

        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppGlobal.MSG_CLEAR_FILE, AppGlobal.INFO, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)

            {
                myDischargerVertex.Clear();
                ProgressBar.Value = 0;
            }
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {

            DischargerVertex.SaveFileAs(myDischargerVertex.FilePath, LibGlobalSource.CREATE_OBJECT);
       
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
                DischargerVertex.ReGenerateDPNode(oledb);
            }
        }   
        
        public void CreateObjectBML(DataGridView dataFromBML, DischargerVertex objDischargerVertex,
            (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
            out (int Value, int Max) processValue)
        {
           
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
            StringBuilder objBuilder = new StringBuilder();
            TextFileHandle objTextFileHandle = new TextFileHandle();
            int quantityNeedToBeCreate = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            SuffixObject suffixObject = new SuffixObject();
            string cabinet, cabinetGroup;
            string _nameNumberString = string.Empty;
            objDefaultInfo = DischargerVertex.Rule.Common;
            for (int i = 0; i < quantityNeedToBeCreate; i++)
            {
                processValue.Value = i;
                DataGridViewCell cell;
                cell = dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)];
                if (cell.Value == null || cell.Value == DBNull.Value || String.IsNullOrEmpty(cell.Value.ToString()))
                { continue; }

                cabinet = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinet)].Value);
                cabinetGroup = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnCabinetGroup)].Value);
                objDischargerVertex.Panel_ID = cabinet.StartsWith(BML.PrefixLocalPanel) ? cabinet : cabinetGroup + cabinet;
                objDischargerVertex.Elevation = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnFloor)].Value);

                #region Subtype and PType                                          
                // SubTypeChanged(objDischargerVertex.SubType);
                #endregion
                ///<AdditionInfoToDesc>
                ///</AdditionInfoToDesc>
                string desc = $"{Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnDesc)].Value)}{suffixObject.SuffixObjectType["KCL"]}";

                objDischargerVertex.Name = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnName)].Value);
                if (addtionToDesc.Section)
                {
                    _nameNumberString = LibGlobalSource.StringHelper.ExtractNumericPart(objDischargerVertex.Name, false);
                    if (!string.IsNullOrEmpty(_nameNumberString))
                    {
                        if (AppGlobal.ParseValue<int>(_nameNumberString, out tempInt))
                        {
                            DischargerVertex.Rule.Common.DescLine = GcObjectInfo.Section.ReturnSection(tempInt);
                        }
                    }
                }
                else if (addtionToDesc.UserDefSection)
                {
                    DischargerVertex.Rule.Common.DescLine = Convert.ToString(dataFromBML.Rows[i].Cells[nameof(BML.ColumnLine)].Value); ;
                }

                DischargerVertex.Rule.Common.Name = objDischargerVertex.Name;
                DischargerVertex.Rule.Common.DescFloor = $"{objDischargerVertex.Elevation}{GcObjectInfo.General.AddInfoElevation}";
                DischargerVertex.Rule.Common.DescObject = desc;
                DischargerVertex.Rule.Common.Cabinet = $"{GcObjectInfo.General.AddInfoCabinet}{objDischargerVertex.Panel_ID}";
                objDischargerVertex.Description = DischargerVertex.EncodingDesc(
                    baseRule: ref DischargerVertex.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
                objDischargerVertex.CreateObject(objTextFileHandle, objBuilder, Encoding.Unicode);
            }
            DischargerVertex.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
    
        private void CreateObjectRule(DischargerVertex objDischargerVertex, (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) addtionToDesc,
      ref (int Value, int Max) processValue)
        {
            #region common used variables declaration 
            OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, isNewOledbDriver);
           // StringBuilder descTotalBuilder = new StringBuilder();
            StringBuilder objBuilder = new StringBuilder();
            TextFileHandle objTextFileHandle = new TextFileHandle();
            int quantityNeedToBeCreate = AppGlobal.ParseValue<int>(TxtQuantity.Text, out tempInt) ? tempInt : 0;
            bool moreThanOne = quantityNeedToBeCreate > 1;
            bool onlyOne = quantityNeedToBeCreate == 1;
            RuleSubDataSet description, name,bin;
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
            bin= new RuleSubDataSet
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

            #region Prepare export DischargerVertex file
            ///<OType>is set when object generated</OType>
            ///<SubType></SubType>
            string selectedSubTypeItem;
            if (ComboEquipmentSubType.SelectedItem != null)
            {
                selectedSubTypeItem = ComboEquipmentSubType.SelectedItem.ToString();
                objDischargerVertex.SubType = selectedSubTypeItem.Substring(0, selectedSubTypeItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));

            }
            else
            {
                objDischargerVertex.SubType = DischargerVertex.DSFU;
            }
           
            objDischargerVertex.Elevation = ComboElevation.Text;
            ///<Value10</Value10>
        
            ///<Value10>Value is set when corresponding check box's check state changed</Value10>
            ///<Name>Value is set in TxtSymbol text changed event</Name>
            ///<Description></Description>
            objDischargerVertex.Description = txtDescription.Text;
            ///<ProcessFct></ProcessFct>
            string selectedProcessFct = string.Empty;
            //if (ComboProcessFct.SelectedItem != null)
            //{
            //    selectedProcessFct = Convert.ToString(ComboProcessFct.SelectedItem);
            //    objDischargerVertex.ProcessFct = selectedProcessFct.Substring(0, selectedProcessFct.IndexOf(AppGlobal.FIELDS_SEPARATOR));
            //}
            ///<Diagram></Diagram>
            string selectedDiagram;
            if (ComboDiagram.SelectedItem != null)
            {
                selectedDiagram = ComboDiagram.SelectedItem.ToString();
                objDischargerVertex.Diagram = (int)DischargerVertex.ParseInfoValue(selectedDiagram,AppGlobal.FIELDS_SEPARATOR,AppGlobal.NO_DIAGRAM);              
            }

            ///<Page></Page>
            objDischargerVertex.Page = txtPage.Text;
            ///<Building></Building>
            string selectedBudling ;
            if (ComboBuilding.SelectedItem != null)
            {
                selectedBudling = ComboBuilding.SelectedItem.ToString();
                objDischargerVertex.Building = selectedBudling;
            }
            ///<Elevation></Elevation>
            string selectedElevation;
            if (ComboElevation.SelectedItem != null)
            {
                selectedElevation = ComboElevation.SelectedItem.ToString();
                objDischargerVertex.Elevation = selectedElevation;
            }
            ///<Panel_ID></Panel_ID>
            string selectedPanel_ID;
            if (ComboPanel.SelectedItem != null)
            {
                selectedPanel_ID = ComboPanel.SelectedItem.ToString();
                objDischargerVertex.Panel_ID = selectedPanel_ID;
            }
            ///<IsNew>is set when object generated,Default value is "No"</IsNew>
            ///<FieldBusNode></FieldBusNode>
            objDischargerVertex.FieldBusNode =AppGlobal.NO_DP_NODE; 
          
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
            string desc = DischargerVertex.Rule.Common.DescObject;
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

            ///<BinRule>生成名称规则</BinRule>
            bin.PosInfo = LibGlobalSource.StringHelper.RuleSubPos(txtBin.Text, txtBinRule.Text);
            if (bin.PosInfo.Len == -1)
            {
                if (moreThanOne)
                {
                    AppGlobal.RuleNotSetCorrect($"{lblSymbolRule.Text}" + "\n" + $"{AppGlobal.MSG_CREATE_WILL_TERMINATE}");
                    return;
                }
            }
            else
            {
                bin.Sub = LibGlobalSource.StringHelper.SplitStringWithRule(txtBin.Text, txtBinRule.Text);
            }

            #endregion

            processValue.Max = quantityNeedToBeCreate;
            processValue.Value = 0;
            ///<CreateObj>
            ///Search IO key,DPNode
            ///</CreateObj>
            AppGlobal.ParseValue<int>(txtSymbolIncRule.Text, out int symbolInc);
            AppGlobal.ParseValue<int>(txtSymbolRule.Text, out int symbolRule);
            AppGlobal.ParseValue<int>(txtDescriptionIncRule.Text, out int descriptionInc);
            AppGlobal.ParseValue<int>(txtBinIncRule.Text, out int binInc);
            objDefaultInfo = DischargerVertex.Rule.Common;
            for (int i = 0; i <= quantityNeedToBeCreate - 1; i++)
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
                    description.Name = "--";
                }
                if (!String.IsNullOrEmpty(bin.Name))
                {
                    if (!String.IsNullOrEmpty(txtBinIncRule.Text) && !String.IsNullOrEmpty(txtBinRule.Text)
                        && AppGlobal.CheckNumericString(txtBinIncRule.Text) && AppGlobal.CheckNumericString(txtBinIncRule.Text)
                        && (bin.PosInfo.Len != -1))
                    {
                        bin.Inc = i * descriptionInc;
                        bin.Name = LibGlobalSource.StringHelper.GenerateObjectName(bin.Sub, bin.PosInfo, (int.Parse(txtDescriptionRule.Text) + bin.Inc).ToString().PadLeft(bin.PosInfo.Len, '0'));
                    }
                    else
                    {
                        bin.Name = txtBin.Text;
                    }

                }
                else
                {
                    bin.Name = txtBin.Text;
                }
                txtBin.Text = bin.Name;
                objDischargerVertex.Name = name.Name;
                DischargerVertex.Rule.Common.Name = name.Name;
                DischargerVertex.Rule.Common.DescObject = description.Name;
                objDischargerVertex.Description = DischargerVertex.EncodingDesc(
                    baseRule: ref DischargerVertex.Rule.Common,
                    namePrefix: GcObjectInfo.General.PrefixName,
                    nameRule: Engineering.PatternMachineName,
                    withLineInfo: addtionToDesc.Section || addtionToDesc.UserDefSection,
                    withFloorInfo: addtionToDesc.Elevation,
                    withNameInfo: addtionToDesc.IdentNumber,
                    withCabinet: addtionToDesc.Cabinet,
                    withPower: addtionToDesc.Power,
                    nameOnlyWithNumber: addtionToDesc.OnlyNumber
                 );
             
              
                objDischargerVertex.CreateObject(objTextFileHandle, objBuilder, Encoding.Unicode);
                processValue.Value = i;
            }
            DischargerVertex.Rule.Common = objDefaultInfo;
            processValue.Value = processValue.Max;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                AppGlobal.AdditionDesc.Section = chkAddSectionToDesc.Checked;
                AppGlobal.AdditionDesc.UserDefSection = chkAddUserSectionToDesc.Checked;
                AppGlobal.AdditionDesc.Elevation = chkAddFloorToDesc.Checked;
                AppGlobal.AdditionDesc.IdentNumber = chkAddNameToDesc.Checked;
                AppGlobal.AdditionDesc.Cabinet = chkAddCabinetToDesc.Checked;
                AppGlobal.AdditionDesc.Power = false;
                AppGlobal.AdditionDesc.OnlyNumber = chkNameOnlyNumber.Checked;
                AppGlobal.ProcessValue.Value = ProgressBar.Value = 0;
                if (createMode.BML)
                {
                    CreateObjectBML(
                         dataFromBML: dataGridBML,
                         objDischargerVertex: myDischargerVertex,
                         addtionToDesc: AppGlobal.AdditionDesc,
                         processValue: out AppGlobal.ProcessValue
                         );
                }
                else if (createMode.AutoSearch)
                {

                }
                else if (createMode.Rule)
                {
                    CreateObjectRule(    
                         objDischargerVertex: myDischargerVertex,
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
