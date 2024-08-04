using System;
using System.IO;
using System.Text;
namespace GcproExtensionLibrary.FileHandle
{
    public class TextFileHandle
    {
        public static string FileFilter = @"Text File   (*.txt)|*.txt|All Files (*.*)|*.*";
        private static string fileType = "Text 文本文件";
        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public TextFileHandle()
        {

        }
        public void WriteToTextFile(string textLine, Encoding encoder)
        {
            /// <使用技巧>
            /// 首选使用 using 语句：
            /// 当你在 using 语句中创建 StreamReader 或 StreamWriter 时，它会创建一个作用域，
            /// 在这个作用域最后，不管有没有异常抛出，资源都会被自动释放（Dispose方法将被调用）
            /// Append方法中文件名称所包含的文件夹必须存在，文件名称如果不存在方法会自动创建
            /// </使用技巧>
            using (StreamWriter writer = new StreamWriter(filePath, true, encoder))
            {
                // StreamWriter writer = File.AppendText(filePath))

                writer.WriteLine(textLine);
            }

        }

        public void ClearContents()
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("文件路径不能为空", nameof(filePath));
            }
            try
            {
                File.WriteAllText(filePath, string.Empty);
            }
            catch (IOException ex)
            {
                throw new Exception("清空文件内容时发生IO异常", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception("没有写入文件的权限", ex);
            }
        }

        public static string BrowseFile()
        {
            return BaseFileHandle.Browse(FileFilter, 1, false, true, "请选择一个" + fileType + "文件");
        }
        public bool SaveFileAs(string title)
        {
            bool result = false;
            result = BaseFileHandle.SaveFileAs(filePath, FileFilter, 1, title + LibGlobalSource.FILE_SAVE_AS);
            return result;
        }
    }

}
