using System;
using System.IO;
using System.Windows.Forms;
namespace GcproExtensionLibrary.FileHandle
{
    public  class BaseFileHandle
    {
        public static bool SaveFileAs(string sourceFileName, string filter, int filterIndex, string title)
        {
            if (!File.Exists(sourceFileName))
            {
                return false;
            }

            using (SaveFileDialog sfdObject = new SaveFileDialog())
            {
                sfdObject.Filter = filter;
                sfdObject.FilterIndex = filterIndex;
                sfdObject.Title = title;
                sfdObject.OverwritePrompt = true;
                if (sfdObject.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(sourceFileName, sfdObject.FileName, true);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new IOException("文件保存错误", ex);
                    }
                }
            }
            return false;
        }

        public static string Browse(string filter, int filterIndex, bool multiselect, bool readOnlyChecked, string title)
        {
            // 使用 using 块确保资源的释放
            using (OpenFileDialog ofdObject = new OpenFileDialog())
            {
                ofdObject.Filter = filter;
                ofdObject.FilterIndex = filterIndex;
                ofdObject.Multiselect = multiselect;
                ofdObject.ReadOnlyChecked = readOnlyChecked;
                ofdObject.Title = title;

                // 显示对话框并处理用户的操作
                if (ofdObject.ShowDialog() == DialogResult.OK)
                {
                    return ofdObject.FileName; // 方法正确执行完毕，返回文件名
                }
            }

            // 用户取消了对话框，返回 null
            return null;
        }
        public static string BrowseFolder()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = LibGlobalSource.SELECT_A_FOLDER;

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    return folderBrowserDialog.SelectedPath;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
