using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region GcproExtensionLibary
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro.GCObject;
using GcproExtensionLibrary.FileHandle;
using System.Threading;
#endregion

namespace GcproExtensionApp
{
    public partial class AppStart : Form
    {
        public AppStart()
        {
            InitializeComponent();
            this.Size = new Size(846, 228);

        }

        private void BtnOpenProjectDB_Click(object sender, EventArgs e)
        {
            AppGlobalSource.GcproDBInfo.ProjectDBPath = AccessFileHandle.BrowseFile();
            TxtProjectPath.Text = AppGlobalSource.GcproDBInfo.ProjectDBPath;
            Environment.SetEnvironmentVariable("GcsProjectDBPath", TxtProjectPath.Text, EnvironmentVariableTarget.User);
        
        }
        private void BtnOpenGcsLibraryDB_Click(object sender, EventArgs e)
        {

            AppGlobalSource.GcproDBInfo.GcsLibaryPath = AccessFileHandle.BrowseFile();
            TxtGcsLibraryPath.Text = AppGlobalSource.GcproDBInfo.GcsLibaryPath;
            Environment.SetEnvironmentVariable("GcsLibraryPath", TxtGcsLibraryPath.Text, EnvironmentVariableTarget.User);
        }
        private void BtnOpenGcproTempPath_Click(object sender, EventArgs e)
        {
            string returnFilePath = BaseFileHandle.BrowseFolder();
            AppGlobalSource.GcproDBInfo.GcproTempPath = (string.IsNullOrWhiteSpace(returnFilePath) ? AppGlobalSource.DEFAULT_GCPRO_TEMP_PATH : returnFilePath);
            txtGcproTempPath.Text = AppGlobalSource.GcproDBInfo.GcproTempPath;
            Environment.SetEnvironmentVariable("GcproTempPath", txtGcproTempPath.Text, EnvironmentVariableTarget.User);
        }

        private void Main_Load(object sender, EventArgs e)
        {

            AppGlobalSource.GcproDBInfo.ProjectDBPath = Environment.GetEnvironmentVariable("GcsProjectDBPath", EnvironmentVariableTarget.User);
            AppGlobalSource.GcproDBInfo.GcsLibaryPath = Environment.GetEnvironmentVariable("GcsLibraryPath", EnvironmentVariableTarget.User);
            AppGlobalSource.GcproDBInfo.GcproTempPath = (string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("GcproTempPath", EnvironmentVariableTarget.User)) ?
                                                       AppGlobalSource.DEFAULT_GCPRO_TEMP_PATH : Environment.GetEnvironmentVariable("GcproTempPath", EnvironmentVariableTarget.User));
            TxtProjectPath.Text = AppGlobalSource.GcproDBInfo.ProjectDBPath;
            TxtGcsLibraryPath.Text = AppGlobalSource.GcproDBInfo.GcsLibaryPath;
            txtGcproTempPath.Text = AppGlobalSource.GcproDBInfo.GcproTempPath;
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

            string assemblyTitle = titleAttribute != null ? titleAttribute.Title : "N/A";
            string assemblyVersion = versionAttribute != null ? versionAttribute.Version : "N/A";

            AppGlobalSource.AppInfo.Title = $"Title: {assemblyTitle}";
            AppGlobalSource.AppInfo.Version = $"Version: {assemblyVersion}";
            AppGlobalSource.AppInfo.Author= $"Author: {assemblyVersion}";
        }



        private void btnAddMotor_Click(object sender, EventArgs e)
        {
            FormMotor formMotor = new FormMotor();
            formMotor.Show();

        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabPage2)
            {
                this.Size = new Size(846, 333);
            }
            else
            {
                this.Size = new Size(846, 228);
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
    }
}
