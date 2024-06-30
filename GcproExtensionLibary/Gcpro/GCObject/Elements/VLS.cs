using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary.Gcpro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class VLS : Element, IGcpro
    {
        public struct VLSRule
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
        private static string vlsFileName = $@"\{OTypeCollection.EL_VLS}";

        public static VLSRule Rule;
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
        private string hornCode;
        private string pType;
        private string dpNode1;
        private string dpNode2;
        private string value9;
        private string value10;
        private string inpLN;
        private string inpHN;
        private string outpLN;
        private string outpHN;
        private string inpRunRev;
        private string inpRunFwd;
        private string monTime;
        private string pulseTimeLN;
        private string pulseTimeHN;
        private string idlingTime;
        private string faultDelay;
        private string startDelay;
        private string hwStop;
        private string refRcvLN;
        private string refRcvHN;
        private string refSndBin;
        private string refAsp;
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
        public string DPNode2
        {
            get { return dpNode2; }
            set { dpNode2 = value; }

        }

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
        public string InpLN
        {
            get { return inpLN; }
            set { inpLN = value; }
        }
        public string InpHN
        {
            get { return inpHN; }
            set { inpHN = value; }
        }
        public string OutpLN
        {
            get { return outpLN; }
            set { outpLN = value; }
        }
        public string OutpHN
        {
            get { return outpHN; }
            set { outpHN = value; }
        }
        public string InpRunRev
        {
            get { return inpRunRev; }
            set { inpRunRev = value; }
        }
        public string InpRunFwd
        {
            get { return inpRunFwd; }
            set { inpRunFwd = value; }
        }
        public string MonTime
        {
            get { return monTime; }
            set { monTime = value; }
        }
        public string PulseTimeLN
        {
            get { return pulseTimeLN; }
            set { pulseTimeLN = value; }
        }
        public string PulseTimeHN
        {
            get { return pulseTimeHN; }
            set { pulseTimeHN = value; }
        }
        public string IdlingTime
        {
            get { return idlingTime; }
            set { idlingTime = value; }
        }
        public string FaultDelay
        {
            get { return faultDelay; }
            set { faultDelay = value; }
        }
        public string StartDelay
        {
            get { return startDelay; }
            set { startDelay = value; }
        }
        public string HwStop
        {
            get { return hwStop; }
            set { hwStop = value; }
        }
        public string RefRcvLN
        {
            get { return refRcvLN; }
            set { refRcvLN = value; }
        }
        public string RefRcvHN
        {
            get { return refRcvHN; }
            set { refRcvHN = value; }
        }
        public string RefSndBin
        {
            get { return refSndBin; }
            set { refSndBin = value; }
        }
        public string RefAsp
        {
            get { return refAsp; }
            set { refAsp = value; }
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

        public static string ImpExpRuleName { get; } = "ImpExpVLS";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_VLS;
        #endregion
        #region Readonly property
        public static string VCO{ get; }="VCO";
        public static string VMF { get; } = "VMF";
        public static string VPO { get; } = "VPO";
        public static string VPOM { get; } = "VPOM";
        public static string VPOR { get; } = "VPOR";
        public static string P7081 { get; } = "7081";
        public static string P7082 { get; } = "7082";
        public static string P7083 { get; } = "7083";
        public static string P7084 { get; } = "7084";
        public static string P7085 { get; } = "7085";
        public static string P7086 { get; } = "7086";
        public static string P7087 { get; } = "7087";
        public static string P7087_1 { get; } = "7087.1";
        #endregion
        public VLS()
        {
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-01/02";
            description = "VLS";
            subType = VCO;
            processFct = string.Empty;
            page = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = string.Empty;
            panel_ID = string.Empty;
            diagram = string.Empty;
            page = string.Empty;

            pType = P7081;
            hornCode = LibGlobalSource.NOCHILD;
            dpNode1 = LibGlobalSource.NOCHILD;
            dpNode2 = LibGlobalSource.NOCHILD;
            value9 = "0";
            value10 = "10";
            inpLN = LibGlobalSource.NOCHILD;
            outpLN = LibGlobalSource.NOCHILD;
            inpHN = LibGlobalSource.NOCHILD;
            outpHN = LibGlobalSource.NOCHILD;
            inpRunRev = LibGlobalSource.NOCHILD;
            inpRunFwd = LibGlobalSource.NOCHILD;
            monTime = "200";
            pulseTimeLN = "5";
            pulseTimeHN = "5";
            idlingTime = "10";
            faultDelay = "30";
            startDelay = "0";
            hwStop = LibGlobalSource.NOCHILD;
            refRcvLN = LibGlobalSource.NOCHILD;
            refRcvHN= LibGlobalSource.NOCHILD;
            refSndBin= LibGlobalSource.NOCHILD;
            refAsp= LibGlobalSource.NOCHILD;
 
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + "_FindConnector.Txt";
        }
        public VLS(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + ".Txt" : filePath + vlsFileName + ".Txt");

            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                          LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + "_Relation.Txt" : filePath + vlsFileName + "_Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                     LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + "_FindConnector.Txt" : filePath + vlsFileName + "_FindConnector.Txt");
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
              .Append(dpNode2).Append(LibGlobalSource.TAB)
              .Append(value9).Append(LibGlobalSource.TAB)
              .Append(value10).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(monTime).Append(LibGlobalSource.TAB)
              .Append(pulseTimeHN).Append(LibGlobalSource.TAB)
              .Append(pulseTimeLN).Append(LibGlobalSource.TAB)
              .Append(idlingTime).Append(LibGlobalSource.TAB)
              .Append(faultDelay).Append(LibGlobalSource.TAB)
              .Append(startDelay).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
              .Append(isNew);
            textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            objFields = null;
            if (subType == VPO || subType == VPOM || subType == VPOR)
            {
                CreateRelation(name, inpLN, GcproTable.ObjData.Value11.Name, this.fileRelationPath, encoding);
                CreateRelation(name, outpLN, GcproTable.ObjData.Value12.Name, this.fileRelationPath, encoding);
                CreateRelation(name, inpHN, GcproTable.ObjData.Value13.Name, this.fileRelationPath, encoding);
                CreateRelation(name, outpHN, GcproTable.ObjData.Value14.Name, this.fileRelationPath, encoding);    
                if (subType == VPOM)
                {
                    CreateRelation(name, inpRunRev, GcproTable.ObjData.Value15.Name, this.fileRelationPath, encoding);
                    CreateRelation(name, inpRunFwd, GcproTable.ObjData.Value16.Name, this.fileRelationPath, encoding);
                }
            }
            else if (subType == VCO)
            {
                CreateRelation(name, inpLN, GcproTable.ObjData.Value11.Name, this.fileRelationPath, encoding);
                CreateRelation(name, inpHN, GcproTable.ObjData.Value13.Name, this.fileRelationPath, encoding);
                CreateRelation(name, outpHN, GcproTable.ObjData.Value14.Name, this.fileRelationPath, encoding);
            }
            else if (subType == VMF)
            {
                CreateRelation(name, inpLN, GcproTable.ObjData.Value11.Name, this.fileRelationPath, encoding);
                CreateRelation(name, inpHN, GcproTable.ObjData.Value13.Name, this.fileRelationPath, encoding);
            }
            if (!string.IsNullOrEmpty(refRcvLN))
            {
                CreateRelation(name, refRcvLN, GcproTable.ObjData.Value30.Name, this.fileRelationPath, encoding);
            }
            if (!string.IsNullOrEmpty(refRcvHN))
            {
                CreateRelation(name, refRcvHN, GcproTable.ObjData.Value31.Name, this.fileRelationPath, encoding);
            }
            if (!string.IsNullOrEmpty(refSndBin))
            {
                CreateRelation(name, refSndBin, GcproTable.ObjData.Value32.Name, this.fileRelationPath, encoding);
            }
            if (!string.IsNullOrEmpty(refAsp))
            {
                CreateRelation(name, refAsp, GcproTable.ObjData.Value34.Name, this.fileRelationPath, encoding);
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
