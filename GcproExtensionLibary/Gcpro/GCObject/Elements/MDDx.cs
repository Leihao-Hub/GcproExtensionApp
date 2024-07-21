using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml.Linq;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class MDDx : Element, IGcpro
    {
        public struct MDDxRule
        {
            public GcBaseRule Common;
            public string ioByteInc;
        }
        public static MDDxRule Rule;
        private string filePath;
        private string fileRelationPath;
     //   private string fileConnectorPath;
        private static string mddxFileName = $@"\{OTypeCollection.EL_MDDx}";
        private string name;
        private string description;
        private string subType;
        private string processFct;
        private string building;
        private string elevation;
        private string fieldBusNode;
        private string panel_ID;
        private string diagram;
        private string page;
        private string isNew;
        private string pType;
        private string hornCode;
        private string dpNode1;
        private string value10;
        private string value25;
        private string value26;
        private string value27;
        private string value28;
        private string ioByteNo;
        private MYTARef side1Top;
        private MYTARef side1Bottom;
        private MYTARef side2Top;
        private MYTARef side2Bottom;

        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string FileRelationPath
        {
            get { return fileRelationPath; }
        }
        //public string FileConnectorPath
        //{
        //    get { return fileConnectorPath; }
        //}
        #region Standard properties  
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string Description
        {
            get { return description; }
            set { description = value; }
        }
        public override string SubType
        {
            get { return subType; }
            set { subType = value; }
        }

        public override string ProcessFct
        {
            get { return processFct; }
            set { processFct = value; }
        }
        public override string Building
        {
            get { return building; }
            set { building = value; }
        }
        public override string Elevation
        {
            get { return elevation; }
            set { elevation = value; }
        }
        public override string FieldBusNode
        {
            get { return fieldBusNode; }
            set { fieldBusNode = value; }
        }
        public override string Panel_ID
        {
            get { return panel_ID; }
            set { panel_ID = value; }
        }
        public override string Diagram
        {
            get { return diagram; }
            set { diagram = value; }
        }
        public override string Page
        {
            get { return page; }
            set { page = value; }
        }
        public override string PType
        {
            get { return pType; }
            set { pType = value; }

        }
        public override string HornCode
        {
            get { return hornCode; }
            set { hornCode = value; }
        }
        public override string DPNode1
        {
            get { return dpNode1; }
            set { dpNode1 = value; }
        }
        #endregion
        #region Application properties

        public string IoByteNo
        {
            get { return ioByteNo; }
            set { ioByteNo = value; }
        }
        public override string Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public string Value25
        {
            get { return value25; }
            set { value25 = value; }
        }
        public string Value26
        {
            get { return value26; }
            set { value26 = value; }
        }
        public string Value27
        {
            get { return value27; }
            set { value27 = value; }
        }
        public string Value28
        {
            get { return value28; }
            set { value28 = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
        public MYTARef Side1Top
        {
            get { return side1Top; }
            set { Side1Top = value; }
        }
        public MYTARef Side1Bottom
        {
            get { return side1Bottom; }
            set { Side1Bottom = value; }
        }
        public MYTARef Side2Top
        {
            get { return side2Top; }
            set { Side2Top = value; }
        }
        public MYTARef Side2Bottom
        {
            get { return side2Bottom; }
            set { Side2Bottom = value; }
        }
        #endregion
        #region Readonly subtype property
        public static string MDDRDP { get; } = "MDDRDP";
        public static string MDDTDP { get; } = "MDDTDP";
        public static string MDDTDP2M { get; } = "MDDTDP2M";
        public static float P7365 { get; } = 7365f;
        public static float P7366 { get; } = 7366f;
        public static string ImpExpRuleName { get; } = "ImpExpMDDx";
        public static string IOByteLen { get; } = "72";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_MDDx;
        #endregion
        public MDDx()
        {
            value10 = "0";
            value25 = value27 = "0";
            Value26 = "286752";
            Value28 = "804672";
            SetOTypeProperty(OTypeCollection.EL_MDDx);
            side1Top = new MYTARef("", 1);
            side1Bottom = new MYTARef("", 2);
            side2Top = new MYTARef("", 3);
            side2Bottom = new MYTARef("", 4);
            pType = P7366.ToString();
            hornCode = LibGlobalSource.NOCHILD;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.ioByteInc = "72";
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddxFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddxFileName + "_Relation.Txt";
        }
        public MDDx(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddxFileName + ".Txt" : filePath + mddxFileName + ".Txt");
            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                        LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddxFileName + ".Txt" : filePath + mddxFileName + "_Relation.Txt");
        }
        /// <summary>
        /// 创建GCPRO对象与与对象关系文件
        /// </summary>
        /// <param name="encoding">文本文件的导入编码</param>
        /// <param name="onlyRelation">=true时,仅创建关系文件；=false时,同时创建对象与对象关系导入文件</param>
        public void CreateObject(Encoding encoding, bool onlyRelation = false)
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            isNew = "false";
            StringBuilder objFields = new StringBuilder();
            ///<summary>
            ///生产Standard字符串部分-使用父类中方法实现
            ///</summary> 
            objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
              .Append(base.CreateObjectStandardPart(encoding)).Append(LibGlobalSource.TAB);
            ///<summary>
            ///生成Application字符串部分-子类中自身完成
            ///</summary>  
             objFields.Append(ioByteNo).Append(LibGlobalSource.TAB)          
              .Append(value25).Append(LibGlobalSource.TAB)
              .Append(value26).Append(LibGlobalSource.TAB)
              .Append(value27).Append(LibGlobalSource.TAB)
              .Append(value28).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(Convert.ToString(side1Top.PassageNo)).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(Convert.ToString(side1Bottom.PassageNo)).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(Convert.ToString(side2Top.PassageNo)).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(Convert.ToString(side2Bottom.PassageNo)).Append(LibGlobalSource.TAB)
              .Append(isNew);
            textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            objFields = null;

            var relations = new List<Relation>
            {
                new Relation(name,side1Top.MYTA, GcproTable.ObjData.Value32.Name),
                new Relation(name,side1Bottom.MYTA, GcproTable.ObjData.Value33.Name),
                new Relation(name,side2Top.MYTA, GcproTable.ObjData.Value34.Name),
                new Relation(name,side2Bottom.MYTA, GcproTable.ObjData.Value35.Name),
            };
            CreateRelations(relations, this.fileRelationPath, encoding);       
        }
        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            textFileHandle.ClearContents();
        }

    }
    public class MYTARef
    {
        private string myta;
        private int passageNo;
        public string MYTA
        {
            get { return myta; }
            set { myta = value; }
        }
        public int PassageNo
        {
            get { return passageNo; }
            set { passageNo = value; }
        }
        public MYTARef(string myta, int passageNo)
        {
            this.myta = myta;
            this.passageNo = passageNo;
        }

    }
}
