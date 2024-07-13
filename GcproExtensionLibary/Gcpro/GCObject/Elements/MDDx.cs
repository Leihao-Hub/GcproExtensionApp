using GcproExtensionLibrary.FileHandle;
using System.Data.SqlTypes;
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
        private string fileConnectorPath;
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
        public string FileConnectorPath
        {
            get { return fileConnectorPath; }
        }
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
        public static string P7365{ get; } = "7365";
        public static string P7366 { get; } = "7366";
        public static string ImpExpRuleName { get; } = "ImpExpMDDx";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_MDDx;
        #endregion
        public MDDx()
        {
        
            SetOTypeProperty(OTypeCollection.EL_MDDx);
            side1Top = new MYTARef("", 1);
            side1Bottom = new MYTARef("", 2);
            side2Top = new MYTARef("", 3);
            side2Bottom = new MYTARef("", 4);
            pType = P7366;
            hornCode= LibGlobalSource.NOCHILD;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.ioByteInc= "72";
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddxFileName + ".Txt";
        }
        public MDDx(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddxFileName + ".Txt" : filePath + mddxFileName + ".Txt");
        }
        public void CreateObject(Encoding encoding, bool onlyRelation = false)
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            isNew = "false";          
            StringBuilder objFields = new StringBuilder();
            ///<summary>
            ///生产Standard字符串部分
            ///</summary> 
            objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
              .Append(name).Append(LibGlobalSource.TAB)
              .Append(description).Append(LibGlobalSource.TAB)
              .Append(subType).Append(LibGlobalSource.TAB)
              .Append(processFct).Append(LibGlobalSource.TAB)
              .Append(building).Append(LibGlobalSource.TAB)
              .Append(elevation).Append(LibGlobalSource.TAB)
              .Append(fieldBusNode).Append(LibGlobalSource.TAB)
              .Append(panel_ID).Append(LibGlobalSource.TAB)
              .Append(diagram).Append(LibGlobalSource.TAB)
              .Append(page).Append(LibGlobalSource.TAB)
              .Append(pType).Append(LibGlobalSource.TAB)
              .Append(hornCode).Append(LibGlobalSource.TAB);
            ///<summary>
            ///生成Application 字符串部分
            ///</summary>   
            objFields.Append(dpNode1).Append(LibGlobalSource.TAB)
              .Append(ioByteNo).Append(LibGlobalSource.TAB)
              .Append(value10).Append(LibGlobalSource.TAB)
              .Append(value25).Append(LibGlobalSource.TAB)
              .Append(value26).Append(LibGlobalSource.TAB)
              .Append(value27).Append(LibGlobalSource.TAB)
              .Append(value28).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(isNew);

            textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            objFields = null;
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
        public MYTARef(string myta,int passageNo) 
        {
            this.myta = myta;   
            this.passageNo= passageNo;   
        }
    }
}
