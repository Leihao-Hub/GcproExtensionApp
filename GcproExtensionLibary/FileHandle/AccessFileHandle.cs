using System.IO;
namespace GcproExtensionLibrary.FileHandle
{
    public class AccessFileHandle : OleDb

    {
        public static string FileFilter = @"Access Database (*.mdb)|*.mdb|Access Database (*.accdb)|*.accdb|All Files (*.*)|*.*";
        private static string fileType = "Access 数据库文件";
        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public AccessFileHandle()
        {

        }
        public static string BrowseFile()
        {
            return BaseFileHandle.Browse(FileFilter, 1, false, true, "请选择一个" + fileType);
        }
        public static bool CheckAccessFileType(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            switch (extension)
            {
                case ".mdb":
                    return false;
                case ".accdb":
                    return true;
                default:
                    return false;
            }
        }
        public bool SaveFileAs()
        {
            return BaseFileHandle.SaveFileAs(filePath, FileFilter, 1, LibGlobalSource.FILE_SAVE_AS);
        }
    }
}
