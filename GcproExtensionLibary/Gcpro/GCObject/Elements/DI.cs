using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class DI:Element, IGcpro
    {
        public struct DIRule
        {
            public GcBaseRule Common;
            public string AORule;
            public string AORuleInc;
            public string VFCRule;
            public string VFCRuleInc;
            public string PowerAppRule;
            public string PowerAppRuleInc;
        }
        private string filePath;
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string diFileName = $@"\{OTypeCollection.EL_DI}";

        public static DIRule Rule;
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
        private string pType;
        private string hornCode;
        private string dpNode1;
        private string value9;
        private string value10;
        private string inpTrue;
        private string inpFaultDev;
        private string inHWStop;
        private string outpFaultReset;
        private string outpPowerOff;
        private string outpLamp;      
        private string delayChange;
        private string delayTrue;
        private string delayFalse;
        private string timeoutTrue;
        private string timeoutFalse;
        private string refSpecial;
        private string refMRMAMixer;
        private string isNew;
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
        public override string Value9
        {
            get { return value9; }
            set { value9 = value; }
        }
        public override string Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public string InpTrue
        {
            get { return inpTrue; }
            set { inpTrue = value; }
        }
        public string InpFaultDev
        {
            get { return inpFaultDev; }
            set { inpFaultDev = value; }
        }
        public string InHWStop
        {
            get { return inHWStop; }
            set { inHWStop = value; }
        }
        public string OutpFaultReset
        {
            get { return outpFaultReset; }
            set { outpFaultReset = value; }
        }
        public string OutpPowerOff
        {
            get { return outpPowerOff; }
            set { outpPowerOff = value; }
        }
        public string OutpLamp
        {
            get { return outpLamp; }
            set { outpLamp = value; }
        }
        public string DelayChange
        {
            get { return delayChange; }
            set { delayChange = value; }
        }
        public string DelayTrue
        {
            get { return delayTrue; }
            set { delayTrue = value; }
        }
        public string DelayFalse
        {
            get { return delayFalse; }
            set { delayFalse = value; }
        }
        public string TimeoutTrue
        {
            get { return timeoutTrue; }
            set { timeoutTrue = value; }
        }
        public string TimeoutFalse
        {
            get { return timeoutFalse; }
            set { timeoutFalse = value; }
        }
        public string RefSpecial
        {
            get { return refSpecial ; }
            set { refSpecial = value; }
        }
   
        public string RefMRMAMixer
        {
            get { return refMRMAMixer; }
            set { refMRMAMixer = value; }
        }
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

        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        public static string ImpExpRuleName { get; } = "ImpExpDI";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_DI;
        #endregion
        #region Readonly property
        public static string DIC { get; } = "DIC";
        public static string DICFU { get; } = "DICFU";
        public static string FLOW { get; } = "FLOW";
        public static string HLBIN { get; } = "HLBIN";
       public static string HLMA { get; } = "HLMA";
        public static string LLMA { get; } = "LLMA";
        public static string MON1 { get; } = "MON1";
        public static string MON1MPPS { get; } = "MON1MPPS";
        public static string MON1MVC { get; } = "MON1MVC";
        public static string MON1OBAT { get; } = "MON1OBAT";
        public static string MON1OMAN { get; } = "MON1OMAN";
        public static string MON1OPCC { get; } = "MON1OPCC";
        public static string MON1OPLC { get; } = "MON1OPLC";
        public static string MON1OSYS { get; } = "MON1OSYS";
        public static string MON1OYIELD { get; } = "MON1OYIELD";
        public static string MON2 { get; } = "MON2";
        public static string P7135 { get; } = "7135";
        public static string P7136 { get; } = "7136";
        public static string P7137 { get; } = "7137";
        public static string P7139 { get; } = "7139";
        public static string P7140 { get; } = "7140";
        public static string P7141 { get; } = "7141";
        public static string P7142 { get; } = "7142";
        public static string P7143 { get; } = "7143";
        public static string P7144 { get; } = "7144";
        public static string P7145 { get; } = "7145";
        public static string P7146 { get; } = "7146";
        public static string P7147 { get; } = "7147";
        public static string P7148 { get; } = "7148";
        public static string P7149 { get; } = "7149";
        public static string P7150 { get; } = "7150";
        public static string P7151 { get; } = "7151";
        public static string P7152 { get; } = "7152";
        public static string P7153 { get; } = "7153";
        public static string P7154 { get; } = "7154";
        public static string P7155 { get; } = "7155";
        public static string P7156 { get; } = "7156";
        public static string P7158 { get; } = "7158";
        public static string P7159 { get; } = "7159";
        public static string P7161 { get; } = "7161";
        public static string P7161_1 { get; } = "7161.1";
        public static string P7162 { get; } = "7162";
        public static string P7163 { get; } = "7163";
        public static string P7164 { get; } = "7164";
        public static string P7165 { get; } = "7165";
        public static string P7166 { get; } = "7166";
        public static string P7167 { get; } = "7167";
        public static string P7168 { get; } = "7168";
        public static string P7169 { get; } = "7169";
        public static string P7170 { get; } = "7170";
        public static string P7171 { get; } = "7171";
        public static string P7172 { get; } = "7172";
        public static string P7173 { get; } = "7173";
        public static string P7174 { get; } = "7174";
        public static string P7175 { get; } = "7175";
        public static string P7176 { get; } = "7176";
        public static string P7177 { get; } = "7177";
        public static string P7188 { get; } = "7188";
        #endregion
        public DI()
        {
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-BLH01";
            description = "EL_DI";
            subType = "DIC";
            processFct = string.Empty;
            page = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = string.Empty;
            panel_ID = string.Empty;
            diagram = string.Empty;
            page = string.Empty;
            pType = P7147;
            hornCode = LibGlobalSource.NOCHILD;
            dpNode1 = LibGlobalSource.NOCHILD;
            value9 = "0";
            value10 = "10";
            inpTrue = LibGlobalSource.NOCHILD;
            inpFaultDev = LibGlobalSource.NOCHILD;
            inHWStop = LibGlobalSource.NOCHILD;
            outpFaultReset = LibGlobalSource.NOCHILD;
            outpPowerOff = LibGlobalSource.NOCHILD;
            outpLamp = LibGlobalSource.NOCHILD;
            delayChange = "5";
            delayTrue = "20";
            delayFalse = "5";
            timeoutTrue = "0";
            timeoutFalse = "0";
            refSpecial = LibGlobalSource.NOCHILD;
            refMRMAMixer = LibGlobalSource.NOCHILD;
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_FindConnector.Txt";
        }
        public DI(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + ".Txt" : filePath + diFileName + ".Txt");

            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                          LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_Relation.Txt" : filePath + diFileName + "_Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                     LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_FindConnector.Txt" : filePath + diFileName + "_FindConnector.Txt");
        }
        public void CreateObject(Encoding encoding)
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
              .Append(value9).Append(LibGlobalSource.TAB)
              .Append(value10).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(delayChange).Append(LibGlobalSource.TAB)
              .Append(delayTrue).Append(LibGlobalSource.TAB)
              .Append(delayFalse).Append(LibGlobalSource.TAB)
              .Append(timeoutTrue).Append(LibGlobalSource.TAB)
              .Append(timeoutFalse).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(isNew);
            textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            objFields = null;
                        CreateRelation(name, inpTrue, GcproTable.ObjData.Value11.Name, this.fileRelationPath, encoding);
                              
            if (!string.IsNullOrEmpty(refSpecial))
            {
                CreateRelation(name, refSpecial, GcproTable.ObjData.Value46.Name, this.fileRelationPath, encoding);
            }
            if (!string.IsNullOrEmpty(refMRMAMixer))
            {
                CreateRelation(name, refMRMAMixer, GcproTable.ObjData.Value31.Name, this.fileRelationPath, encoding);
            }                
        }
        public void CreateRelation(string parent, string child, string connectedFiled, string filePath, Encoding encoding)
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = filePath;
            string output = parent + LibGlobalSource.TAB + child + LibGlobalSource.TAB + connectedFiled;
            textFileHandle.WriteToTextFile(output, encoding);
        }
        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            textFileHandle.ClearContents();
            textFileHandle.FilePath = this.fileRelationPath;
            textFileHandle.ClearContents();
            textFileHandle.FilePath = this.fileConnectorPath;
            textFileHandle.ClearContents();
        }
        public bool SaveFileAs(string sourceFilePath, string title)
        {
            bool result;
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = sourceFilePath;
            result = textFileHandle.SaveFileAs(title);
            return result;
           
        }
       
    }
}
