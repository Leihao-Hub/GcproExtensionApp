using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.TextFormatting;
namespace GcproExtensionLibrary.FileHandle
{
    public class TextFileHandle: BaseFileHandle
    {
        public static string FileFilter = @"Text File   (*.txt)|*.txt|All Files (*.*)|*.*";
        private readonly static string fileType = "Text 文本文件";
        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public TextFileHandle()
        {
        }
        public void WriteLinesToTextFile(IEnumerable<string> textLines, Encoding encoder)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true, encoder))
            {
                foreach (string line in textLines)
                {
                    writer.WriteLine(line);
                }
            }
        }
        public void WriteLineToTextFile(string textLine, Encoding encoder)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true, encoder))
            {         
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
            return Browse(FileFilter, 1, false, true, "请选择一个" + fileType + "文件");
        }
        public bool SaveFileAs(string title)
        {
            return SaveFileAs(filePath, FileFilter, 1, title + LibGlobalSource.FILE_SAVE_AS);
        }
    }

}
