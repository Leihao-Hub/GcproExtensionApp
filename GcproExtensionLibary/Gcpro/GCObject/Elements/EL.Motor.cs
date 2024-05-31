
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary.Gcpro;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    ///  <summary>
    ///  Motor
    ///  </summary>

    public class GcMotor : BaseMotor, IGcpro
    {
        #region Public struct
        public struct MotorAppFieldCollection
        {
            public string InpFwd;
            public string OutpFwd;
            public string InpRev;
            public string OutpRev;
            public string InpContactor;
            public string Adapter;
            public string ParMonTime;
            public string ParStartDelay;
            public string ParStartingTime;
            public string ParStoppingTime;
            public string ParIdlingTime;
            public string ParFaultDelayTime;
            public string ParPowerNominal;
            public string ParSpeedService;
            public string Unit;

            //public MotorAppFieldCollection(bool s)
            //{
            //    InpFwd = LibGlobalSource.NOCHILD;
            //    OutpFwd = LibGlobalSource.NOCHILD;
            //    InpRev = LibGlobalSource.NOCHILD;
            //    OutpRev = LibGlobalSource.NOCHILD;
            //    InpContactor = LibGlobalSource.NOCHILD;
            //    Adapter = LibGlobalSource.NOCHILD;
            //    ParMonTime = "50";
            //    ParStartDelay = "0";
            //    ParStartingTime = "10";
            //    ParStoppingTime = "10";
            //    ParIdlingTime = "10";
            //    ParFaultDelayTime = "10";
            //    ParPowerNominal = "0";
            //    ParSpeedService = "20";
            //    Unit = "2";
            //}
        }
        #endregion
        public struct MotorRule
        {
            public GcBaseRule Common;
            public string AORule;
            public string AORuleInc;
            public string VFCRule;
            public string VFCRuleInc;
        }
        private string filePath;
        private static string MotorFileName = $@"\{OTypeCollection.EL_Motor}.Txt";
        private CommonObjectFields comObjectFields;
        private string hornCode;
        private string pType;
        private string value9;
        private string value10;
        private string dpNode1;
        private string dpNode2;
        private MotorAppFieldCollection motorAppFields;
        private string isNew;
        public static MotorRule Rule;

        #region Property:Gcpro motor data fields
        public override CommonObjectFields ComObjectFields
        {
            get
            {
                return comObjectFields;
            }
            set
            {
                comObjectFields = value;
            }
        }
        public override string PType
        {
            get
            {
                return pType;
            }
            set
            {
                pType = value;
            }
        }
        public override string HornCode
        {
            get
            {
                return hornCode;
            }
            set
            {
                hornCode = value;
            }
        }
        public override string DPNode1
        {
            get
            {
                return dpNode1;
            }
            set
            {
                dpNode1 = value;
            }
        }
        public override string DPNode2
        {
            get
            {
                return dpNode2;
            }
            set
            {
                dpNode2 = value;
            }
        }
        public override string Value9
        {
            get
            {
                return value9;
            }
            set
            {
                value9 = value;
            }
        }
        public override string Value10
        {
            get
            {
                return value10;
            }
            set
            {
                value10 = value;
            }
        }
        public MotorAppFieldCollection MotorAppFields
        {
            get
            {
                return motorAppFields;
            }
            set

            {
                motorAppFields = value;
            }
        }
        public override string IsNew
        {
            get
            {
                return isNew;
            }
            set
            {
                isNew = value;
            }
        }
        #endregion
        public override string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }

        }

        #region Readonly property
        public static string M11 { get; } = "M11";
        public static string M12 { get; } = "M12";
        public static string M21 { get; } = "M21";
        public static string M22 { get; } = "M22";
        public static string M12AIAO { get; } = "M12AIAO";
        public static string M1VFC { get; } = "M1VFC";
        public static string M2VFC { get; } = "M2VFC";
        public static string M11ELV { get; } = "M11ELV";
        public static string ImpExpRuleName { get; } = "ImpExpMotor";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_Motor;
        #endregion
        public GcMotor()
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
            comObjectFields.Name = "-MXZ01";
            comObjectFields.Description = "Motor";
            comObjectFields.SubType = M11;
            comObjectFields.ProcessFct = string.Empty;
            comObjectFields.Page = string.Empty;
            comObjectFields.Building = "--";
            comObjectFields.Elevation = "--";
            comObjectFields.FieldBusNode = string.Empty;
            comObjectFields.Panel_ID = string.Empty;
            comObjectFields.Diagram = string.Empty;
            comObjectFields.Page = string.Empty;

            pType = "7053";
            hornCode = LibGlobalSource.NOCHILD;
            dpNode1 = LibGlobalSource.NOCHILD;
            dpNode2 = LibGlobalSource.NOCHILD;
            value9 = "2";
            value10 = "130";
            motorAppFields.InpFwd = LibGlobalSource.NOCHILD;
            motorAppFields.OutpFwd = LibGlobalSource.NOCHILD;
            motorAppFields.InpRev = LibGlobalSource.NOCHILD;
            motorAppFields.OutpRev = LibGlobalSource.NOCHILD;
            motorAppFields.InpContactor = LibGlobalSource.NOCHILD;
            motorAppFields.Adapter = LibGlobalSource.NOCHILD;
            motorAppFields.ParMonTime = "50";
            motorAppFields.ParStartDelay = "0";
            motorAppFields.ParStartingTime = "10";
            motorAppFields.ParStoppingTime = "10";
            motorAppFields.ParIdlingTime = "10";
            motorAppFields.ParFaultDelayTime = "10";
            motorAppFields.ParPowerNominal = "0";
            motorAppFields.ParSpeedService = "20";
            motorAppFields.Unit = "2";
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + MotorFileName;
        }
        public GcMotor(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ? 
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + MotorFileName : filePath + MotorFileName);
        }
        public void CreateObject()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            isNew = "No";
            string stdString, appString;
            stdString = (int)OType + LibGlobalSource.TAB +
                comObjectFields.Name + LibGlobalSource.TAB +
                comObjectFields.Description + LibGlobalSource.TAB +
                comObjectFields.SubType + LibGlobalSource.TAB +
                comObjectFields.ProcessFct + LibGlobalSource.TAB +
                comObjectFields.Building + LibGlobalSource.TAB +
                comObjectFields.Elevation + LibGlobalSource.TAB +
                comObjectFields.FieldBusNode + LibGlobalSource.TAB +
                comObjectFields.Panel_ID + LibGlobalSource.TAB +
                comObjectFields.Diagram + LibGlobalSource.TAB +
                comObjectFields.Page + LibGlobalSource.TAB +
                pType + LibGlobalSource.TAB +
                hornCode + LibGlobalSource.TAB;

            appString = dpNode1 + LibGlobalSource.TAB +
                dpNode2 + LibGlobalSource.TAB +
                value9 + LibGlobalSource.TAB +
                value10 + LibGlobalSource.TAB +
                motorAppFields.InpFwd + LibGlobalSource.TAB +
                motorAppFields.OutpFwd + LibGlobalSource.TAB +
                motorAppFields.InpRev + LibGlobalSource.TAB +
                motorAppFields.OutpRev + LibGlobalSource.TAB +
                motorAppFields.InpContactor + LibGlobalSource.TAB +
                motorAppFields.Adapter + LibGlobalSource.TAB +
                motorAppFields.ParMonTime + LibGlobalSource.TAB +
                motorAppFields.ParStartDelay + LibGlobalSource.TAB +
                motorAppFields.ParStartingTime + LibGlobalSource.TAB +
                motorAppFields.ParIdlingTime + LibGlobalSource.TAB +
                motorAppFields.ParFaultDelayTime + LibGlobalSource.TAB +
                motorAppFields.ParPowerNominal + LibGlobalSource.TAB +
                motorAppFields.ParSpeedService + LibGlobalSource.TAB +
                motorAppFields.Unit + LibGlobalSource.TAB +
                isNew;
            textFileHandle.WriteToTextFile(stdString + appString);

        }
        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            textFileHandle.ClearContents();
        }
        public bool SaveFileAs()
        {

        TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            return textFileHandle.SaveFileAs();

       
        }   
}
    public abstract class BaseMotor : Element
    {
        public override OTypeCollection OType { get; set; }
        public abstract string DPNode2 { get; set; }
        public BaseMotor()
        {
            OType = OTypeCollection.EL_Motor;
        }

    }
}
