using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System;
using Microsoft.Win32;

namespace GcproExtensionLibrary.Gcpro
{
    /// <summary>
    /// Types of Gcpro supported by the library
    /// </summary>
    public enum OTypeCollection
    {
        /// <summary>
        /// DP Slave
        /// </summary>
        DP_Slave = 590,

        /// <summary>
        /// EL DO
        /// </summary>
        EL_DO = 1011,

        /// <summary>
        /// EL Motor
        /// </summary>
        EL_Motor = 1012,

        /// <summary>
        /// EL VLS
        /// </summary>
        EL_VLS = 1013,

        /// <summary>
        /// EL DI
        /// </summary>
        EL_DI = 1014,

        /// <summary>
        /// EL AI
        /// </summary>
        EL_AI = 1019,

        /// <summary>
        /// EL MDDx DP
        /// </summary>
        EL_MDDx = 1037,

        /// <summary>
        /// EL RollStandPhoenix
        /// </summary>
        EL_RollStandPhoenix = 1755,

        /// <summary>
        /// EL VFCAdapter
        /// </summary>
        EL_VFCAdapter = 1818,

        /// <summary>
        /// EL PowerApp
        /// </summary>
        EL_PowerApp = 1818,

        /// <summary>
        /// MA_Roll8Stand
        /// </summary>
        MA_Roll8Stand = 2046,

        /// <summary>
        /// MA_MotorWithBypass
        /// </summary>
        MA_MotorWithBypass = 2052,

        /// <summary>
        /// MA_MDDYZPhoenix 
        /// </summary>
        MA_Discharger = 2056,

        /// <summary>
        /// MA_MDDYZPhoenix 
        /// </summary>
        MA_MDDYZPhoenix = 2757,

        /// <summary>
        /// Bin
        /// </summary>
        Bin = 2900,

        /// <summary>
        /// DischargerVertex
        /// </summary>
        DischargerVertex = 2901,

        /// <summary>
        /// Vertex
        /// </summary>
        Vertex = 3103,
    }

    /// <summary>
    /// Stand data fields for GCObjects
    /// </summary>
    public struct CommonObjectFields
    { 
        public string Name;
        public string Description;
        public string SubType;
        public string ProcessFct;
        public string Building;
        public string Elevation;
        public string FieldBusNode;
        public string Panel_ID;
        public string Diagram;
        public string Page;

    }

    public struct RuleSubPos
    {
        public bool StartPos;
        public bool EndPos;
        public bool MidPos;
        public int Len;
        public int PosInString;
    }
    public struct RuleSubDataSet
    { 
        public string Name;

        public int Inc;
        public string[] Sub;
        public RuleSubPos PosInfo ;

    }
    public struct GcBaseRule
    {
        public string Name,Description;
        public string NameRule, DescriptionRule;
        public string NameRuleInc, DescriptionRuleInc;
    }
    
    /// <summary>
    /// Colums in Gcpro Database
    /// </summary>


    /// <summary>
    /// Colums in Gcpro Database
    /// </summary>
    public struct GcproDataBase
    {
        public string ProjectDBPath;
        public string GcsLibaryPath;
        public string GcproGcsLibaryConnectionString;
        public string GcproProjectDBConnectionString;
        public string GcproTempPath;
    }
  
}
