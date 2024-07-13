using GcproExtensionLibrary.FileHandle;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class GcObject
    {
        public static OTypeCollection OType { get; protected set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string SubType { get; set; }
        public abstract string ProcessFct { get; set; }
        public abstract string Building { get; set; }
        public abstract string Elevation { get; set; }
        public abstract string FieldBusNode { get; set; }
        public abstract string Panel_ID { get; set; }
        public abstract string Diagram { get; set; }
        public abstract string Page { get; set; }
        public abstract string IsNew { get; set; }
        public abstract string FilePath { get; set; }
        protected static void SetOTypeProperty(OTypeCollection value)
        {
            OType = value;
        }
        /// <summary>
        /// 清除[filePath]文件类容
        /// </summary>
        /// <param name="filePath"></param>
        public static void Clear(string filePath)
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = filePath;
            textFileHandle.ClearContents();
        }
        /// <summary>
        /// 创建Gcobject之间的关联关系
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <param name="connectedFiled"></param>
        /// <param name="filePath"></param>
        /// <param name="encoding"></param>
        public static void CreateRelation(string parent, string child, string connectedFiled, string filePath, Encoding encoding)
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = filePath;
            string output = parent + LibGlobalSource.TAB + child + LibGlobalSource.TAB + connectedFiled;
            textFileHandle.WriteToTextFile(output, encoding);
        }
        /// <summary>
        /// 文件另存为
        /// </summary>
        /// <param name="sourceFilePath"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool SaveFileAs(string sourceFilePath, string title)
        {
            bool result;
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = sourceFilePath;
            result = textFileHandle.SaveFileAs(title);
            return result;
        }
    }
}
