using System;
using System.Drawing;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
#region GcproExtensionLirbary
using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using static GcproExtensionLibrary.Gcpro.GcproTable;
using GcproExtensionLibrary.Gcpro.GCObject;
using System.Xml.Linq;
using System.Collections.Generic;
#endregion

namespace GcproExtensionApp
{
    #pragma warning disable IDE1006
    public partial class AppStart : Form
    {
        public AppStart()
        {
            InitializeComponent();
            this.Size = new Size(846, 260);

        }

        private void BtnOpenProjectDB_Click(object sender, EventArgs e)
        {
            AppGlobal.GcproDBInfo.ProjectDBPath = AccessFileHandle.BrowseFile();
            TxtProjectPath.Text = AppGlobal.GcproDBInfo.ProjectDBPath;
            Environment.SetEnvironmentVariable("GcsProjectDBPath", TxtProjectPath.Text, EnvironmentVariableTarget.User);
            if (!string.IsNullOrEmpty(TxtProjectPath.Text))
            {
                try
                {

                    OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath,false);
                    DataTable dataTable ;
                    string subQuery = $"SELECT {ObjData.SubType.Name} FROM [{ObjData.TableName}] WHERE {ObjData.OType.Name} = {Project.OTypeValue}";
                    string whereClause = $"{SubType.FieldSubType.Name} IN";
                    dataTable = oledb.NestQueryDataTable(SubType.TableName, whereClause, null, null, subQuery, SubType.FieldSubType.Name, SubType.FieldSub_Type_Desc.Name);
                    comboProjectType.Items.Clear();
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        string itemInfo = dataTable.Rows[count].Field<string>(SubType.FieldSubType.Name) + AppGlobal.FIELDS_SEPARATOR +
                            dataTable.Rows[count].Field<string>(SubType.FieldSub_Type_Desc.Name);
                        comboProjectType.Items.Add(itemInfo);
                    }
                    comboProjectType.SelectedIndex = 0;
                    string selectedProjectType = comboProjectType.Text;
                    AppGlobal.GcproDBInfo.ProjectType = selectedProjectType.Substring(0, selectedProjectType.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询错误: " + ex.Message, AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TabHideOrShow();
        }
        private void BtnOpenGcsLibraryDB_Click(object sender, EventArgs e)
        {

            AppGlobal.GcproDBInfo.GcsLibaryPath = AccessFileHandle.BrowseFile();
            TxtGcsLibraryPath.Text = AppGlobal.GcproDBInfo.GcsLibaryPath;
            Environment.SetEnvironmentVariable("GcsLibraryPath", TxtGcsLibraryPath.Text, EnvironmentVariableTarget.User);
            TabHideOrShow();
        }
        private void BtnOpenGcproTempPath_Click(object sender, EventArgs e)
        {
            string returnFilePath = BaseFileHandle.BrowseFolder();
            AppGlobal.GcproDBInfo.GcproTempPath = (string.IsNullOrWhiteSpace(returnFilePath) ? AppGlobal.DEFAULT_GCPRO_TEMP_PATH : returnFilePath);
            txtGcproTempPath.Text = AppGlobal.GcproDBInfo.GcproTempPath;
            Environment.SetEnvironmentVariable("GcproTempPath", txtGcproTempPath.Text, EnvironmentVariableTarget.User);
        }

        private void AppStart_Load(object sender, EventArgs e)
        {
        //    AppGlobal.GetJsonConfiguration();   
            AppGlobal.GcproDBInfo.ProjectDBPath = Environment.GetEnvironmentVariable("GcsProjectDBPath", EnvironmentVariableTarget.User);
            AppGlobal.GcproDBInfo.GcsLibaryPath = Environment.GetEnvironmentVariable("GcsLibraryPath", EnvironmentVariableTarget.User);
            AppGlobal.GcproDBInfo.GcproTempPath = (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("GcproTempPath", EnvironmentVariableTarget.User)) ?
                                                       AppGlobal.DEFAULT_GCPRO_TEMP_PATH : Environment.GetEnvironmentVariable("GcproTempPath", EnvironmentVariableTarget.User));
            TxtProjectPath.Text = AppGlobal.GcproDBInfo.ProjectDBPath;
            TxtGcsLibraryPath.Text = AppGlobal.GcproDBInfo.GcsLibaryPath;
            txtGcproTempPath.Text = AppGlobal.GcproDBInfo.GcproTempPath;
            txtRegexNameWithoutTypeLL.Text = Engineering.PatternMachineName;
            txtRegexNameOnlyWithNumberTypeLL.Text=Engineering.PatternNameNumber;     
            txtRegexNamePrefix.Text = Engineering.PatternElementNamePrefix;
            tabPage3.ImageIndex = 2;
            if (!string.IsNullOrEmpty(TxtProjectPath.Text))
            {
                try
                {
                    OleDb oledb = new OleDb(AppGlobal.GcproDBInfo.ProjectDBPath, false);
                    DataTable dataTable;
                    string subQuery = $"SELECT {ObjData.SubType.Name} FROM [{ObjData.TableName}] WHERE {ObjData.OType.Name} = {(int)(OTypeCollection.Project)}";
                    string whereClause = $"{SubType.FieldSubType.Name} IN";
                    dataTable = oledb.NestQueryDataTable(SubType.TableName, whereClause, null, null, subQuery, SubType.FieldSubType.Name,SubType.FieldSub_Type_Desc.Name);
                    comboProjectType.Items.Clear();
                    for (var count = 0; count <= dataTable.Rows.Count - 1; count++)
                    {
                        string itemInfo = dataTable.Rows[count].Field<string>(SubType.FieldSubType.Name) + AppGlobal.FIELDS_SEPARATOR +
                             dataTable.Rows[count].Field<string>(SubType.FieldSub_Type_Desc.Name);
                        comboProjectType.Items.Add(itemInfo);
                    }
                    comboProjectType.SelectedIndex = 0;
                   string selectedProjectType= comboProjectType.Text;
                    AppGlobal.GcproDBInfo.ProjectType = selectedProjectType.Substring(0, selectedProjectType.IndexOf(AppGlobal.FIELDS_SEPARATOR));
                }
                catch(Exception ex) 
                {                           
                    MessageBox.Show("查询错误: " + ex.Message,AppGlobal.AppInfo.Title,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            TabHideOrShow();

        }
        private void TabHideOrShow()
        {
            if (!string.IsNullOrEmpty(TxtProjectPath.Text) && (!string.IsNullOrEmpty(TxtGcsLibraryPath.Text)))
            { 
                    
                btnQuery.Enabled = true;
                tabMain.TabPages.Clear();
                tabPage1.Parent = tabMain;
                tabPage2.Parent = tabMain;
                tabPage3.Parent = tabMain;
                tabMain.Refresh();  
            }
            else
            { 
                tabPage2.Parent = null;
                btnQuery.Enabled = false;
            }
        }

        private void txtGcproTempPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Environment.SetEnvironmentVariable("GcproTempPath", txtGcproTempPath.Text, EnvironmentVariableTarget.User);
            }
        }
        private void GetAppInfo()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyTitleAttribute titleAttribute = assembly.GetCustomAttribute<AssemblyTitleAttribute>();
            AssemblyFileVersionAttribute versionAttribute =  assembly.GetCustomAttribute<AssemblyFileVersionAttribute>();
            AssemblyCopyrightAttribute copyright= assembly.GetCustomAttribute<AssemblyCopyrightAttribute>();
            AssemblyDescriptionAttribute description =assembly.GetCustomAttribute<AssemblyDescriptionAttribute>();
            AssemblyCompanyAttribute company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            AppGlobal.AppInfo.Title = titleAttribute.Title;
            AppGlobal.AppInfo.Version = $"Version: {versionAttribute.Version}";
            AppGlobal.AppInfo.Description =description.Description;
            AppGlobal.AppInfo.CopyRight = copyright.Copyright;
            AppGlobal.AppInfo.Company=company.Company;
        }
       
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabPage2)
            {
                this.Size = new Size(846, 422);
            }
            else if (tabMain.SelectedTab == tabPage3)
            {
                this.Size = new Size(846, 236);
                GetAppInfo();
                lblApplicationTitle.Text= AppGlobal.AppInfo.Title;
                lblVersion.Text = $"<{AppGlobal.AppInfo.Version}>";
                txtDescription.Text = AppGlobal.AppInfo.Description;
                lblCopyright.Text = AppGlobal.AppInfo.CopyRight;
                lblCompanyName.Text = AppGlobal.AppInfo.Company;
            }
            else
            {
                this.Size = new Size(846, 260);
            }

        }
        private void TxtProjectPath_DoubleClick(object sender, EventArgs e)
        {
            BtnOpenProjectDB_Click(sender, e);
        }

        private void TxtGcsLibraryPath_DoubleClick(object sender, EventArgs e)
        {
            BtnOpenGcsLibraryDB_Click(sender, e);
        }

        private void txtGcproTempPath_DoubleClick(object sender, EventArgs e)
        {
            BtnOpenGcproTempPath_Click(sender, e);
        }
        #region Engineering
        private void textRegexNameWithoutTypeLL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtRegexNameWithoutTypeLL.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_ENGINEERING}.{AppGlobal.JS_PATTERN}.MachineName", newJsonKeyValue);
                Engineering.PatternMachineName = newJsonKeyValue;
            }
        }
        private void txtRegexNameOnlyWithNumberTypeLL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtRegexNameOnlyWithNumberTypeLL.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_ENGINEERING}.{AppGlobal.JS_PATTERN}.NameNumber", newJsonKeyValue);
                Engineering.PatternNameNumber = newJsonKeyValue;
            }
        }
        private void txtNamePrefix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newJsonKeyValue = txtRegexNamePrefix.Text;
                LibGlobalSource.JsonHelper.WriteKeyValue(AppGlobal.JSON_FILE_PATH, $"{AppGlobal.JS_ENGINEERING}.{AppGlobal.JS_PATTERN}.ElementNamePrefix", newJsonKeyValue);
                Engineering.PatternElementNamePrefix = newJsonKeyValue;
            }
        }
    
        #endregion Engineering

        #region Open form
        private void btnAddMotor_Click(object sender, EventArgs e)
        {
            FormMotor formMotor = new FormMotor();
            formMotor.Show();
        }
        private void btnAddVFC_Click(object sender, EventArgs e)
        {
            FormVFCAdapter formVFCAdapter = new FormVFCAdapter();
            formVFCAdapter.Show();
        }
        private void btnAddValve_Click(object sender, EventArgs e)
        {
            FormVLS formVLS = new FormVLS();
            formVLS.Show();
        }
        private void btnAddDI_Click(object sender, EventArgs e)
        {
            FormDI formDI = new FormDI();
            formDI.Show();
        }
        private void btnAddDO_Click(object sender, EventArgs e)
        {
            FormDO formDO = new FormDO();
            formDO.Show();
        }
        private void btnAddAI_Click(object sender, EventArgs e)
        {
            FormAI formAI = new FormAI();
            formAI.Show();
        }
        private void btnAddFBAL_Click(object sender, EventArgs e)
        {
            FormFBAL formFBAL = new FormFBAL();
            formFBAL.Show();
        }
        private void btnAddScaleAdapter_Click(object sender, EventArgs e)
        {
            FormScaleAdapter formScaleAdapter = new FormScaleAdapter();
            formScaleAdapter.Show();
        }
        private void btnAddRollStandPhoenix_Click(object sender, EventArgs e)
        {
            FormRollStandPhoenix formRollStandPhoenix = new FormRollStandPhoenix();
            formRollStandPhoenix.Show();
        }
        private void btnAddBin_Click(object sender, EventArgs e)
        {
            FormBin formBin = new FormBin();
            formBin.Show();
        }
        private void btnAddMDDx_Click(object sender, EventArgs e)
        {
            FormMDDx formMDDx = new FormMDDx();
            formMDDx.Show();
        } 
        private void btnAddDPSlave_Click(object sender, EventArgs e)
        {
            FormDPSlave formMA_DPSlave = new FormDPSlave();
            formMA_DPSlave.Show();
        }
        private void btnAddMA_Roll8Stand_Click(object sender, EventArgs e)
        {
            FormMA_Roll8Stand formMA_Roll8Stand = new FormMA_Roll8Stand();
            formMA_Roll8Stand.Show();
        }
        private void btnAddMA_MDDY_Click(object sender, EventArgs e)
        {
            FormMA_MDDYZPhoenix formMA_MDDYZPhoenix = new FormMA_MDDYZPhoenix();
            formMA_MDDYZPhoenix.Show();
        }
        private void btnAddMotorWithBypass_Click(object sender, EventArgs e)
        {
            FormMA_MotorWithBypass formMA_MotorWithBypass = new FormMA_MotorWithBypass();
            formMA_MotorWithBypass.Show();
        }

        private void btnAddMADischarger_Click(object sender, EventArgs e)
        {
            FormMA_Discharger formMA_Discharger = new FormMA_Discharger();
            formMA_Discharger.Show();
        }

   
    
        private void btnAddDischargerVertex_Click(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ObjectBrowser objectBrowser = new ObjectBrowser
            {
                OtherAdditionalFiled = GcproTable.ObjData.Key.Name,
                OType = Convert.ToString(Motor.OTypeValue)
            };         
            objectBrowser.Show();
        }


    }
        #endregion
}
