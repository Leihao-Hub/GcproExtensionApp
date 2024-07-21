using GcproExtensionLibrary.FileHandle;
using System.Text;
using static GcproExtensionLibrary.Gcpro.GcproTable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

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
        /// <summary>
        /// 创建对象标准部分字符串
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string CreateObjectStandardPart(Encoding encoding) 
        {
            StringBuilder objFields = new StringBuilder();
            objFields.Append(Name).Append(LibGlobalSource.TAB)
              .Append(Description).Append(LibGlobalSource.TAB)
              .Append(SubType).Append(LibGlobalSource.TAB)
              .Append(ProcessFct).Append(LibGlobalSource.TAB)
              .Append(Building).Append(LibGlobalSource.TAB)
              .Append(Elevation).Append(LibGlobalSource.TAB)
              .Append(FieldBusNode).Append(LibGlobalSource.TAB)
              .Append(Panel_ID).Append(LibGlobalSource.TAB)
              .Append(Diagram).Append(LibGlobalSource.TAB)
              .Append(Page);
            return objFields.ToString();
        }
        /// <summary>
        /// 创建对象之间的关联关系
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
        /// 一次性根据relations中"child"值是否为空,来创建relations中对象的关系
        /// </summary>
        /// <param name="relations"></param>
        /// <param name="filePath"></param>
        /// <param name="encoding"></param>
        protected void CreateRelations( List<Relation> relations, string filePath, Encoding encoding)
        {
            foreach (var relation in relations)
            {
                if (!String.IsNullOrEmpty(relation.Child))
                {                  
                      CreateRelation(
                      parent: relation.Parent,
                      child: relation.Child,
                      connectedFiled: relation.ConnectedFiled,
                      filePath: filePath,
                      encoding: encoding
                      );
                }
            }
        }
    }
}
