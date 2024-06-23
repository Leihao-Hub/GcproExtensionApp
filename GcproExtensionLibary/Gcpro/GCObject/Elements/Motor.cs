using GcproExtensionLibrary.FileHandle;
using System.Data;
using System.Data.SqlTypes;
using System.Text;
using System.Xml.Linq;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    ///  <summary>
    ///  Motor
    ///  </summary>
    public class Motor : BaseMotor, IGcpro
    {
        public struct MotorRule
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
        private static string motorFileName = $@"\{OTypeCollection.EL_Motor}";
        private string hornCode;
        private string pType;
        private string value9;
        private string value10;
        private string dpNode1;
        private string dpNode2;
        private string isNew;
        public static MotorRule Rule;
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

        private string inpFwd;
        private string outpFwd;
        private string inpRev;
        private string outpRev;
        private string inpContactor;
        private string hwStop;
        private string adapter;
        private string powerApp;
        private string ao;
        private string parMonTime;
        private string parStartDelay;
        private string parStartingTime;
        private string parStoppingTime;
        private string parIdlingTime;
        private string parFaultDelayTime;
        private string parPowerNominal;
        private string parSpeedService;
        private string unit;

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
        public override string DPNode2
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

        public string InpFwd
        {
            get { return inpFwd; }
            set { inpFwd = value; }
        }
        public string OutpFwd
        {
            get { return outpFwd; }
            set { outpFwd = value; }
        }
        public string InpRev
        {
            get { return inpRev; }
            set { inpRev = value; }
        }
        public string OutpRev
        {
            get { return outpRev; }
            set { outpRev = value; }
        }
        public string InpContactor
        {
            get { return inpContactor; }
            set { inpContactor = value; }
        }
        public string HWStop
        {
            get { return hwStop; }
            set { hwStop = value; }
        }
        public string Adapter
        {
            get { return adapter; }
            set { adapter = value; }
        }

        public string PowerApp
        {
            get { return powerApp; }
            set { powerApp = value; }
        }

        public string AO
        {
            get { return ao; }
            set { ao = value; }
        }
        public string ParMonTime
        {
            get { return parMonTime; }
            set { parMonTime = value; }
        }
        public string ParStartDelay
        {
            get { return parStartDelay; }
            set { parStartDelay = value; }
        }
        public string ParStartingTime
        {
            get { return parStartingTime; }
            set { parStartingTime = value; }
        }
        public string ParStoppingTime
        {
            get { return parStoppingTime; }
            set { parStoppingTime = value; }
        }
        public string ParIdlingTime
        {
            get { return parIdlingTime; }
            set { parIdlingTime = value; }
        }
        public string ParFaultDelayTime
        {
            get { return parFaultDelayTime; }
            set { parFaultDelayTime = value; }
        }

        public string ParPowerNominal
        {
            get { return parPowerNominal; }
            set { parPowerNominal = value; }
        }
        public string ParSpeedService
        {
            get { return parSpeedService; }
            set { parSpeedService = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        public static string ImpExpRuleName { get; } = "ImpExpMotor";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_Motor;
        #endregion

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
        #region Readonly subtype property
        public static string M11 { get; } = "M11";
        public static string M12 { get; } = "M12";
        public static string M21 { get; } = "M21";
        public static string M22 { get; } = "M22";
        public static string M12AIAO { get; } = "M12AIAO";
        public static string M1VFC { get; } = "M1VFC";
        public static string M2VFC { get; } = "M2VFC";
        public static string M11ELV { get; } = "M11ELV";
    
        #endregion
        #region Readonly ptype property
        public static string P7031 { get; } = "7031";
        public static string P7032 { get; } = "7032";
        public static string P7033 { get; } = "7033";
        public static string P7034 { get; } = "7034";
        public static string P7035 { get; } = "7035";
        public static string P7036 { get; } = "7036";
        public static string P7041 { get; } = "7041";
        public static string P7042 { get; } = "7042";
        public static string P7043 { get; } = "7043";
        public static string P7044 { get; } = "7044";
        public static string P7045 { get; } = "7045";
        public static string P7046 { get; } = "7046";
        public static string P7051 { get; } = "7051";
        public static string P7052 { get; } = "7052";
        public static string P7053 { get; } = "7053";
        public static string P7054 { get; } = "7054";
        public static string P7055 { get; } = "7055";
        public static string P7056 { get; } = "7056";
        public static string P7056_1 { get; } = "7056.1";
        public static string P7056_2 { get; } = "7056.2";
        public static string P7057 { get; } = "7057";
        public static string P7058 { get; } = "7058";
        public static string P7059 { get; } = "7059";
        public static string P7060 { get; } = "7060";
        public static string P9051 { get; } = "9051";
        public static string P9052 { get; } = "9053";
        public static string P9053 { get; } = "9053";
        public static string P9056 { get; } = "9056";
        #endregion
        public Motor()
        {
            /// < StandardFileds >
            /// string Name;
            /// string Description;
            /// string SubType;
            /// string ProcessFct;
            /// string Building;
            /// string Elevation;
            /// string FieldBusNode;
            /// string Panel_ID;
            /// string Diagram;
            /// string Page;
            /// </ StandardFileds >
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-MXZ01";
            description = "Motor";
            subType = M11;
            processFct = string.Empty;
            page = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = string.Empty;
            panel_ID = string.Empty;
            diagram = string.Empty;
            page = string.Empty;

            pType = P7053;
            hornCode = LibGlobalSource.NOCHILD;
            dpNode1 = LibGlobalSource.NOCHILD;
            dpNode2 = LibGlobalSource.NOCHILD;
            value9 = "2";
            value10 = "130";
            inpFwd = LibGlobalSource.NOCHILD;
            outpFwd = LibGlobalSource.NOCHILD;
            inpRev = LibGlobalSource.NOCHILD;
            outpRev = LibGlobalSource.NOCHILD;
            inpContactor = LibGlobalSource.NOCHILD;
            hwStop = LibGlobalSource.NOCHILD;
            adapter = LibGlobalSource.NOCHILD;
            powerApp = LibGlobalSource.NOCHILD;
            ao=LibGlobalSource.NOCHILD; 
            parMonTime = "50";
            parStartDelay = "0";
            parStartingTime = "10";
            parStoppingTime = "10";
            parIdlingTime = "10";
            parFaultDelayTime = "10";
            parPowerNominal = "0";
            parSpeedService = "20";
            unit = "2";
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorFileName+".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorFileName + "_FindConnector.Txt";
        }
        public Motor(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorFileName+ ".Txt" : filePath + motorFileName+ ".Txt");

            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                          LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorFileName+ "_Relation.Txt" : filePath + motorFileName+ "_Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                     LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorFileName + "_FindConnector.Txt" : filePath + motorFileName + "_FindConnector.Txt");
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
                page + LibGlobalSource.TAB +
                pType + LibGlobalSource.TAB +
                hornCode + LibGlobalSource.TAB;

            appString = dpNode1 + LibGlobalSource.TAB +
                dpNode2 + LibGlobalSource.TAB +
                value9 + LibGlobalSource.TAB +
                value10 + LibGlobalSource.TAB +
                inpFwd + LibGlobalSource.TAB +
                outpFwd + LibGlobalSource.TAB +
                inpRev + LibGlobalSource.TAB +
                outpRev + LibGlobalSource.TAB +
                inpContactor + LibGlobalSource.TAB +
                hwStop + LibGlobalSource.TAB +
                adapter + LibGlobalSource.TAB +
                powerApp+ LibGlobalSource.TAB +
                ao+LibGlobalSource.TAB +    
                parMonTime + LibGlobalSource.TAB +
                parStartDelay + LibGlobalSource.TAB +
                parStartingTime + LibGlobalSource.TAB +
                parStoppingTime + LibGlobalSource.TAB +
                parIdlingTime + LibGlobalSource.TAB +
                parFaultDelayTime + LibGlobalSource.TAB +
                parPowerNominal + LibGlobalSource.TAB +
                parSpeedService + LibGlobalSource.TAB +
                unit + LibGlobalSource.TAB +
                isNew;
            textFileHandle.WriteToTextFile(stdString + appString, encoding);
            if (subType == M11)
            {
                CreateRelation(name, inpFwd, GcproTable.ObjData.Value11.Name, this.fileRelationPath,encoding);
                CreateRelation(name, outpFwd, GcproTable.ObjData.Value12.Name, this.fileRelationPath, encoding);
                if (!string.IsNullOrEmpty(inpContactor))
                {
                    CreateRelation(name, inpContactor, GcproTable.ObjData.Value38.Name, this.fileRelationPath, encoding);
                }
            }
            else if (subType == M12)
            {
                CreateRelation(name, inpFwd, GcproTable.ObjData.Value11.Name, this.fileRelationPath, encoding);
                CreateRelation(name, outpFwd, GcproTable.ObjData.Value12.Name, this.fileRelationPath, encoding);
                CreateRelation(name, inpRev, GcproTable.ObjData.Value13.Name, this.fileRelationPath,encoding);
                CreateRelation(name, outpRev, GcproTable.ObjData.Value14.Name, this.fileRelationPath, encoding);
            }
            else if (subType == M1VFC || subType == M2VFC)
            {
                CreateRelation(name, adapter, GcproTable.ObjData.Value34.Name, this.fileRelationPath, encoding);             
            }
        }
        public void CreateRelation(string parent,string child,string connectedFiled, string filePath,Encoding encoding)
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = filePath;
            string output = parent+LibGlobalSource.TAB + child+LibGlobalSource.TAB + connectedFiled;
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
        public bool SaveFileAs(string sourceFilePath,string title)
        {
            bool result;
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = sourceFilePath;
            result=textFileHandle.SaveFileAs(title);  
            return result;
        }
    }
    public abstract class BaseMotor : Element
    {
       public abstract string DPNode2 { get; set; }

        public BaseMotor()
        {
            SetOTypeProperty(OTypeCollection.EL_Motor);
        }

        public static int GetStartingTime(float power)
        {
            int time = 0;
            if (power < 3.0)
            {
                time = 3;
            }
            else if (3.0 <= power && power < 7.5)
            {
                time = 5;
            }
            else if (7.5 <= power && power < 15.0)
            {
                time = 8;
            }
            else if (15.0 <= power && power < 22.0)
            {
                time = 10;
            }
            else if (22.0 <= power && power < 30.0)
            {
                time = 15;
            }
            else if (30.0 <= power && power < 37.0)
            {
                time = 19;
            }
            else if (37.0 <= power && power < 45.0)
            {
                time = 25;
            }
            else if (45.0 <= power && power < 55.0)
            {
                time = 30;
            }
            else if (55.0 <= power && power < 75.0)
            {
                time = 35;
            }
            else if (75.0 <= power)
            {
                time = 40;
            }
            else
            {
                time = 10;
            }
            return time;
        }
        public static int GetStartingTime(double power)
        {
            int time = 0;
            if (power < 3.0)
            {
                time = 3;
            }
            else if (3.0 <= power && power < 7.5)
            {
                time = 5;
            }
            else if (7.5 <= power && power < 15.0)
            {
                time = 8;
            }
            else if (15.0 <= power && power < 22.0)
            {
                time = 10;
            }
            else if (22.0 <= power && power < 30.0)
            {
                time = 15;
            }
            else if (30.0 <= power && power < 37.0)
            {
                time = 19;
            }
            else if (37.0 <= power && power < 45.0)
            {
                time = 25;
            }
            else if (45.0 <= power && power < 55.0)
            {
                time = 30;
            }
            else if (55.0 <= power && power < 75.0)
            {
                time = 35;
            }
            else if (75.0 <= power)
            {
                time = 40;
            }
            else
            {
                time = 10;
            }
            return time;
        }
    }
    //public class MotorPower
    //{
    //    public float Power { get; set; }
    //    public int StartingTime { get; set; }
    //}
}
