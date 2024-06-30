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
#endregion

namespace GcproExtensionApp
{
    public partial class AppStart : Form
    {
        public AppStart()
        {
            InitializeComponent();
            this.Size = new Size(846, 265);

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

                    OleDb oledb = new OleDb();
                    DataTable dataTable = new DataTable();
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    oledb.IsNewOLEDBDriver = false;
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
        }
        private void BtnOpenGcsLibraryDB_Click(object sender, EventArgs e)
        {

            AppGlobal.GcproDBInfo.GcsLibaryPath = AccessFileHandle.BrowseFile();
            TxtGcsLibraryPath.Text = AppGlobal.GcproDBInfo.GcsLibaryPath;
            Environment.SetEnvironmentVariable("GcsLibraryPath", TxtGcsLibraryPath.Text, EnvironmentVariableTarget.User);         
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
            AppGlobal.GcproDBInfo.ProjectDBPath = Environment.GetEnvironmentVariable("GcsProjectDBPath", EnvironmentVariableTarget.User);
            AppGlobal.GcproDBInfo.GcsLibaryPath = Environment.GetEnvironmentVariable("GcsLibraryPath", EnvironmentVariableTarget.User);
            AppGlobal.GcproDBInfo.GcproTempPath = (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("GcproTempPath", EnvironmentVariableTarget.User)) ?
                                                       AppGlobal.DEFAULT_GCPRO_TEMP_PATH : Environment.GetEnvironmentVariable("GcproTempPath", EnvironmentVariableTarget.User));
            TxtProjectPath.Text = AppGlobal.GcproDBInfo.ProjectDBPath;
            TxtGcsLibraryPath.Text = AppGlobal.GcproDBInfo.GcsLibaryPath;
            txtGcproTempPath.Text = AppGlobal.GcproDBInfo.GcproTempPath;

            if (!string.IsNullOrEmpty(TxtProjectPath.Text))
            {
                try
                {

                    OleDb oledb = new OleDb();
                    DataTable dataTable = new DataTable();
                    oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                    oledb.IsNewOLEDBDriver = false;
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
            AssemblyFileVersionAttribute versionAttribute = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>();
            AssemblyCopyrightAttribute copyright= assembly.GetCustomAttribute<AssemblyCopyrightAttribute>();
            AssemblyDescriptionAttribute description =assembly.GetCustomAttribute<AssemblyDescriptionAttribute>();   
            AppGlobal.AppInfo.Title = titleAttribute.Title;
            AppGlobal.AppInfo.Version = $"Version: {versionAttribute.Version}";
            AppGlobal.AppInfo.Description = $"{description.Description}";
            AppGlobal.AppInfo.CopyRight= $"{copyright.Copyright}";
        }
       
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabPage2)
            {
                this.Size = new Size(846, 333);
            }
            else if (tabMain.SelectedTab == tabPage3)
            {
                this.Size = new Size(846, 228);
                GetAppInfo();
                ApplicationTitle.Text= AppGlobal.AppInfo.Title;
                Version.Text = $"<{AppGlobal.AppInfo.Version}>";
                lblDescription.Text = AppGlobal.AppInfo.Description;
            }
            else
            {
                this.Size = new Size(846, 265);
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
        #endregion
    }
}
