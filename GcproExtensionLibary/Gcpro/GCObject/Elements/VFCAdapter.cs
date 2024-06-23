using GcproExtensionLibrary.FileHandle;
using System.Data.SqlTypes;
using System.Text;
using System.Xml.Linq;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class VFCAdapter : Element
    {
        public struct VFCAdapterRule
        {
            public GcBaseRule Common;
            public string ioByteInc;
            public string slaveIndexInc;
        }
        public static VFCAdapterRule Rule;
        private string filePath;
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string vfcFileName = $@"\{OTypeCollection.EL_VFCAdapter}";
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
        private string hornCode;
        private string pType;
        private string value9;
        private string value10;
        private string dpNode1;
        private string meagGateway;
        private string slaveIndex;
        private string outpHardwareStop;
        private string speedMaxDigits;
        private string speedUnitsByZeroDigits;
        private string speedUnitsByMaxDigits;
        private string unitsPerDigits;
        private string speedLimitMin;
        private string speedLimitMax;
        private string ioByteNo;
        private string lenPKW;
        private string lenPZD;
        private string lenPZDInp;
        private string refCurrent;
        private string refTorque;
        private string refPower;
        private VFCTelegram telegram1;
        private VFCTelegram telegram2;
        private VFCTelegram telegram3;
        private VFCTelegram telegram4;
        private VFCTelegram telegram5;
   
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
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
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
        public string MeagGateway
        {
            get { return meagGateway; }
            set { meagGateway = value; }
        }

        public string SlaveIndex
        {
            get { return slaveIndex; }
            set { slaveIndex = value; }
        }

        public string OutpHardwareStop
        {
            get { return outpHardwareStop; }
            set { outpHardwareStop = value; }
        }
   
        public string SpeedMaxDigits
        {
            get { return speedMaxDigits; }
            set { speedMaxDigits = value; }
        }

        public string SpeedUnitsByZeroDigits
        {
            get { return speedUnitsByZeroDigits; }
            set { speedUnitsByZeroDigits = value; }
        }

        public string SpeedUnitsByMaxDigits
        {
            get { return speedUnitsByMaxDigits; }
            set { speedUnitsByMaxDigits = value; }
        }
        public string UnitsPerDigits
        {
            get { return unitsPerDigits; }
            set { unitsPerDigits = value; }
        }
        public string SpeedLimitMin
        {
            get { return speedLimitMin; }
            set { speedLimitMin = value; }
        }

        public string SpeedLimitMax
        {
            get { return speedLimitMax; }
            set { speedLimitMax = value; }
        }

        public string IoByteNo
        {
            get { return ioByteNo; }
            set { ioByteNo = value; }
        }

        public string LenPKW
        {
            get { return lenPKW; }
            set { lenPKW = value; }
        }

        public string LenPZD
        {
            get { return lenPZD; }
            set { lenPZD = value; }
        }

        public string LenPZDInp
        {
            get { return lenPZDInp; }
            set { lenPZDInp = value; }
        }
        public string RefCurrent
        {
            get { return refCurrent; }
            set { refCurrent = value; }
        }

        public string RefTorque
        {
            get { return refTorque; }
            set { refTorque = value; }
        }

        public string RefPower
        {
            get { return refPower; }
            set { refPower = value; }
        }
        public VFCTelegram Telegram1
        {
            get { return telegram1; }
            set { telegram1 = value; }
        }

        public VFCTelegram Telegram2
        {
            get { return telegram2; }
            set { telegram2 = value; }
        }

        public VFCTelegram Telegram3
        {
            get { return telegram3; }
            set { telegram3= value; }
        }

        public VFCTelegram Telegram4
        {
            get { return telegram4; }
            set { telegram4 = value; }
        }
        public VFCTelegram Telegram5
        {
            get { return telegram5; }
            set { telegram5 = value; }
        }
        #endregion
        #region Readonly subtype property
        public static string ATVASYNCDP { get; } = "ATVASYNCDP";
        public static string ATVDP { get; } = "ATVDP";
        public static string ATVM { get; } = "ATVM";
        public static string SST01DP { get; } = "SST01DP";
        public static string SST02DP { get; } = "SST02DP";
        public static string VFCA0 { get; } = "VFCA0";
        public static string VFCA1 { get; } = "VFCA1";
        public static string VFCA10 { get; } = "VFCA10";
        public static string VFCA11 { get; } = "VFCA11";
        public static string VFCA12 { get; } = "VFCA12";
        public static string VFCA13 { get; } = "VFCA13";
        public static string VFCA2 { get; } = "VFCA2";
        public static string VFCA3 { get; } = "VFCA3";
        public static string VFCA4 { get; } = "VFCA4";
        public static string VFCA5 { get; } = "VFCA5";
        public static string VFCA6 { get; } = "VFCA6";
        public static string VFCA7 { get; } = "VFCA7";
        public static string VFCANALOG { get; } = "VFCANALOG";
        public static string VFCLS { get; } = "VFCLS";
        public static string VFCMS3RK { get; } = "VFCMS3RK";
        public static string VFCPNG { get; } = "VFCPNG";
        public static string ImpExpRuleName { get; } = "ImpExpVFCAdapter";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_VFCAdapter;
        #endregion
        public VFCAdapter()
        {
            telegram1 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            telegram2 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            telegram3 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            telegram4 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            telegram5 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            SetOTypeProperty(OTypeCollection.EL_VFCAdapter);
            pType = LibGlobalSource.NOCHILD;
            hornCode= LibGlobalSource.NOCHILD;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.slaveIndexInc = "1";
            Rule.ioByteInc= "12";
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vfcFileName + ".Txt";
            //this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vfcFileName + "_Relation.Txt";
            //this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vfcFileName + "_FindConnector.Txt";
        }
        public VFCAdapter(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vfcFileName + ".Txt" : filePath + vfcFileName + ".Txt");

            //this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
            //              LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vfcFileName + "_Relation.Txt" : filePath + vfcFileName + "_Relation.Txt");
            //this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
            //         LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vfcFileName + "_FindConnector.Txt" : filePath + vfcFileName + "_FindConnector.Txt");
        }
        public void CreateObject(Encoding encoding)
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            isNew = "false";
            string stdString, appString;
            stdString = OTypeValue + LibGlobalSource.TAB +
                name + LibGlobalSource.TAB +
                description + LibGlobalSource.TAB +
                subType + LibGlobalSource.TAB +
                processFct + LibGlobalSource.TAB +
                building + LibGlobalSource.TAB +
                elevation + LibGlobalSource.TAB +
                fieldBusNode + LibGlobalSource.TAB +
                panel_ID + LibGlobalSource.TAB +
                diagram + LibGlobalSource.TAB +
                page + LibGlobalSource.TAB;


            appString = dpNode1 + LibGlobalSource.TAB +               
                value10 + LibGlobalSource.TAB +
                speedLimitMin + LibGlobalSource.TAB +
                speedLimitMax + LibGlobalSource.TAB +
                speedMaxDigits + LibGlobalSource.TAB +
                speedUnitsByZeroDigits + LibGlobalSource.TAB +
                speedUnitsByMaxDigits + LibGlobalSource.TAB +
                unitsPerDigits + LibGlobalSource.TAB +
                ioByteNo + LibGlobalSource.TAB +
                lenPKW + LibGlobalSource.TAB +
                lenPZD + LibGlobalSource.TAB +
                lenPZDInp + LibGlobalSource.TAB +
                meagGateway + LibGlobalSource.TAB +
                slaveIndex + LibGlobalSource.TAB +
                outpHardwareStop + LibGlobalSource.TAB +
                telegram1.ParPNO + LibGlobalSource.TAB +
                telegram1.ParUnitsPerDigit + LibGlobalSource.TAB +
                telegram2.ParPNO + LibGlobalSource.TAB +
                telegram2.ParUnitsPerDigit + LibGlobalSource.TAB +
                telegram3.ParPNO + LibGlobalSource.TAB +
                telegram3.ParUnitsPerDigit + LibGlobalSource.TAB +
                telegram4.ParPNO + LibGlobalSource.TAB +
                telegram4.ParUnitsPerDigit + LibGlobalSource.TAB +
                telegram5.ParPNO + LibGlobalSource.TAB +
                telegram5.ParUnitsPerDigit + LibGlobalSource.TAB +
                refCurrent+ LibGlobalSource.TAB +
                refTorque+ LibGlobalSource.TAB +
                refPower + LibGlobalSource.TAB +
                isNew;
            textFileHandle.WriteToTextFile(stdString + appString, encoding);
        }
        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            textFileHandle.ClearContents();
            //textFileHandle.FilePath = this.fileRelationPath;
            //textFileHandle.ClearContents();
            //textFileHandle.FilePath = this.fileConnectorPath;
            //textFileHandle.ClearContents();
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
    public class VFCTelegram
    {
        public string ParPNO { get; set; }
        public string ParUnitsPerDigit { get; set; }
        public VFCTelegram()
        {
        }
    }

}
