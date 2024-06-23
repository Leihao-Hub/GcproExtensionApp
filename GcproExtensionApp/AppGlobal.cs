using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
#region GcproExtensionLibrary
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using GcproExtensionLibary.Gcpro.GCObject;
using System.Xml.Linq;
using System.Configuration;
using System.Security.AccessControl;
using Newtonsoft.Json.Linq;
using static GcproExtensionLibrary.LibGlobalSource;
using System.Linq;
using static OfficeOpenXml.ExcelErrorValue;
#endregion
namespace GcproExtensionApp
{
    public static class AppGlobal
    {
        #region Const
        public const string JSON_FILE_PATH = "appsettings.json";
        public const string ERROR_ENTER_TYPE = "输入类型错误";
        public const string ENTER_NUMERIC = "请输入一个数字类型";
        public const string FIELDS_SEPARATOR = "   |";
        public const string CREATE_IMPORT_RULE = "创建导入规则";
        public const string CONNECT_IO = "关联IO";
        public const string CONNECT_CONNECTOR = "关联对象";
        public const string SET_RELATION = "设置从属关系";
        public const string DEMO_NAME = "示例名称：";
        public const string DEMO_NAME_RULE = "示例名称规则：";
        public const string DEMO_DESCRIPTION = "示例描述：";
        public const string DEMO_DESCRIPTION_RULE = "示例描述规则：";
        public const string FILE_NOT_EXITS = "示例描述：";
        public const string KEY_WORD_AUTOSEARCH = "搜寻关键字";
        public const string FILE_SAVE_AS_FAILURE = "文件保存失败";
        public const string MOTOR_WITHOUT_VFC = "非变频控制";
        public const string NAME = "名称";
        public const string NULL = "null";
        public const string DEFAULT_GCPRO_TEMP_PATH = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH;
        public const string OBJECT_FIELD = "数据库字段: ";

        public const string MSG_INVALID_IO_SYMBOL = "无效的IO名称！";
        public const char IO_SYMBOL_SUFFIX_SPLIT = ':';
        public const string INFO = "信息提示";
        public const string MSG_REGENERATE_DPNODE = "确定要重新生成DPNode？";
        public const string MSG_CLEAR_FILE = "确定要清除文件类容？";
        public const string MSG_RULE_NOT_CORRECT = "规则不正确或者未设置:";
        public const string MSG_CREATE_WILL_TERMINATE = "新建进程将终止";
        public const string MSG_RULE_CREATE_SUCESSFULL = "规则创建成功";
        public const string MSG_RULE_ALREADY_EXITS = "规则已经存在，需要重新创建吗";
        public const string EX_FILE_NOT_FOUND = "文件未找到，请确保文件路径正确并且文件存在。";
        public const string EX_IO_ERROR = "发生I/O错误";
        public const string EX_UNKNOW = "未知错误";
        public const string EX_UNAUTHORIZED_ACCESS = "没有权限访问文件。请检查文件权限。";
        public const int MIN_IO_SYMBOL_LENGTH = 3;
        #endregion
        public static class AppInfo
        {
            public static string Title { get; set; }
            public static string Version { get; set; }
            public static string Description { get; set; }
            public static string CopyRight { get; set; }
        }

        public static bool NewOLEDBDriver;
        public static GcproDataBase GcproDBInfo;

        static AppGlobal()
        {

        }
        /// <summary>
        /// Func<char, T> converter 使用泛型委托，传入一个函数，可以灵活将字符返回个指定类型的数据到列表中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="startLetter"></param>
        /// <param name="endLetter"></param>
        /// <param name="converter"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static List<T> CreateAlphabetList<T>(char startLetter, char endLetter, Func<char, T> converter)
        {
            if (startLetter < 'A' || startLetter > 'Z' || endLetter < 'A' || endLetter > 'Z' || startLetter > endLetter)
                throw new ArgumentException("非26个大写字母");

            var list = new List<T>();

            for (char letter = startLetter; letter <= endLetter; letter++)
            {
                list.Add(converter(letter));
            }

            return list;
        }
        public static void MessageNotNumeric()
        {
            MessageBox.Show(ENTER_NUMERIC, ENTER_NUMERIC, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageNotNumeric(string addition)
        {
            MessageBox.Show(ENTER_NUMERIC + addition, ENTER_NUMERIC, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void RuleNotSetCorrect()
        {
            MessageBox.Show(AppGlobal.MSG_RULE_NOT_CORRECT, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void RuleNotSetCorrect(string addition)
        {
            MessageBox.Show(AppGlobal.MSG_RULE_NOT_CORRECT + addition, AppGlobal.INFO, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static bool CheckNumericString(string sourceString)
        {
            // 直接尝试解析字符串，如果有异常在调用处抛出 out _表示不必关注参数
            if (!string.IsNullOrEmpty(sourceString))
            {
                bool isInt = int.TryParse(sourceString, out _);
                bool isLong = long.TryParse(sourceString, out _);
                bool isFloat = float.TryParse(sourceString, out _);
                return isInt || isLong || isFloat;
            }
            else
                return false;

        }
        public static bool ParseInt(string sourceString, out int outValue)
        {
            int tempInt;
            bool isInt = int.TryParse(sourceString, out tempInt);
            outValue = tempInt;
            return isInt;
        }

        public static bool ParseLong(string sourceString, out long outValue)
        {
            long tempLong;
            bool isLong = long.TryParse(sourceString, out tempLong);
            outValue = tempLong;
            return isLong;
        }

        public static bool ParseFloat(string sourceString, out float outValue)
        {
            float tempFloat;
            bool isFloat = float.TryParse(sourceString, out tempFloat);
            outValue = tempFloat;
            return isFloat;
        }
        #region Find info form database when create object
        public static string FindIOKey(OleDb dataSource, string objIOName)
        {
            string key = string.Empty;
            DataTable data;
            data = dataSource.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.Text0.Name} LIKE'{objIOName}%'", null, null,
                           GcproTable.ObjData.Key.Name);
            if (data.Rows.Count != 0)
            { key = data.Rows[0].Field<int>(GcproTable.ObjData.Key.Name).ToString(); }
            else
            { key = string.Empty; }
            return key;
        }
        public static string FindDPNodeNo(OleDb dataSource, string nodeName)
        {
            string key = string.Empty;
            DataTable data;
            data = dataSource.QueryDataTable(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldText.Name} LIKE'{nodeName}%' AND {GcproTable.TranslationCbo.FieldClass.Name}='{GcproTable.TranslationCbo.Class_ASWInDPFault}'",
                          null, null, GcproTable.TranslationCbo.FieldValue.Name);
            if (data.Rows.Count != 0)
            { key = data.Rows[0].Field<double>(GcproTable.TranslationCbo.FieldValue.Name).ToString(); }
            else
            { key = string.Empty; }
            return key;
        }
        public static string FindFieldbusNodeKey(OleDb dataSource, int nodeNo)
        {
            string key = string.Empty;
            DataTable data;
            data = dataSource.QueryDataTable(GcproTable.ObjData.TableName, $"({GcproTable.ObjData.SubType.Name}='Profinet' OR {GcproTable.ObjData.SubType.Name}='Profibus') AND {GcproTable.ObjData.DPNode1.Name}={nodeNo}",
                         null, null, GcproTable.ObjData.Key.Name);
            if (data.Rows.Count != 0)
            { key = data.Rows[0].Field<int>(GcproTable.ObjData.Key.Name).ToString(); }
            else
            { key = string.Empty; }
            return key;
        }
        public static void ReGenerateDPNode(OleDb dataSource)
        {
            dataSource.DeleteRecord(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name}='{GcproTable.TranslationCbo.Class_ASWInDPFault}'", null);
            DataTable data = new DataTable();
            data = dataSource.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={DPSlave.OTypeValue}", null, null,
                GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name, GcproTable.ObjData.DPNode1.Name);
            string description = string.Empty;
            string symbol = string.Empty;
            double dpNode1 = 0;
            List<List<GcproExtensionLibrary.Gcpro.DbParameter>> recordList = new List<List<GcproExtensionLibrary.Gcpro.DbParameter>>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (i <= data.Rows.Count - 1)
                {
                    symbol = data.Rows[i].Field<string>(GcproTable.ObjData.Text0.Name);
                    description = data.Rows[i].Field<string>(GcproTable.ObjData.Text1.Name);
                    dpNode1 = data.Rows[i].Field<double>(GcproTable.ObjData.DPNode1.Name);
                }
                List<GcproExtensionLibrary.Gcpro.DbParameter> recordParameters = new List<GcproExtensionLibrary.Gcpro.DbParameter>();
                recordParameters.Add(new GcproExtensionLibrary.Gcpro.DbParameter
                { Name = GcproTable.TranslationCbo.FieldClass.Name, Value = GcproTable.TranslationCbo.Class_ASWInDPFault });
                recordParameters.Add(new GcproExtensionLibrary.Gcpro.DbParameter
                { Name = GcproTable.TranslationCbo.FieldValue.Name, Value = dpNode1 });
                recordParameters.Add(new GcproExtensionLibrary.Gcpro.DbParameter
                { Name = GcproTable.TranslationCbo.FieldText.Name, Value = symbol });
                recordParameters.Add(new GcproExtensionLibrary.Gcpro.DbParameter
                { Name = GcproTable.TranslationCbo.FieldDescription.Name, Value = description });
                recordList.Add(recordParameters);
            }
            dataSource.InsertMultipleRecords(GcproTable.TranslationCbo.TableName, recordList);

        }
        #endregion
        public static string GetObjectSymbolFromIO(string source)
        {
            string ret = string.Empty;
            if (source.Length >= MIN_IO_SYMBOL_LENGTH)
            { ret = source.Substring(0, source.IndexOf(IO_SYMBOL_SUFFIX_SPLIT)); }
            else
            { ret = MSG_INVALID_IO_SYMBOL; }
            return ret;
        }
        #region Operate bit 
        public static void SetBit(ref long sourceValue, byte position)
        {
            long mask = 1L << position;
            sourceValue = sourceValue | mask;

        }
        public static void SetBit(ref int sourceValue, byte position)
        {
            int mask = 1 << position;
            sourceValue = sourceValue | mask;

        }

        public static void SetBit(ref byte sourceValue, byte position)
        {
            byte mask = (byte)(1 << position);
            sourceValue = (byte)(sourceValue | mask);

        }

        public static void SetBit(ref ushort sourceValue, byte position)
        {
            ushort mask = (ushort)(1 << position);
            sourceValue = (ushort)(sourceValue | mask);

        }

        public static void ClearBit(ref long sourceValue, byte position)
        {
            long mask = ~(1L << position);
            sourceValue = sourceValue & mask;

        }

        public static void ClearBit(ref int sourceValue, byte position)
        {
            int mask = ~(1 << position);
            sourceValue = sourceValue & mask;

        }


        public static void ClearBit(ref byte sourceValue, byte position)
        {
            byte mask = (byte)~(1 << position);
            sourceValue = (byte)(sourceValue & mask);

        }

        public static void ClearBit(ref ushort sourceValue, byte position)
        {
            ushort mask = (ushort)~(1 << position);
            sourceValue = (ushort)(sourceValue & mask);

        }
        #endregion
    }



    #region BML
    public class VFCAdapterParameters
    {
        public string LenPKW { get; set; } = "0";
        public string LenPZD { get; set; } = "12";
        public string LenPZDInp { get; set; } = "0";
        public string UnitsPerDigits { get; set; } = "0.1";
        public string SpeedMaxDigits { get; set; } = "500";
        public string SpeedUnitsByMaxDigits { get; set; } = "100";
        public string SpeedUnitsByZeroDigits { get; set; } = "0";
        public string SpeedLimitMax { get; set; } = "100";
        public string SpeedLimitMin { get; set; } = "0";
        public bool ParPZDConsistent {  get; set; } = false;    
        //private string RefCurrent { get; set; }
        //private string RefTorque { get; set; }
        //private string RefPower { get; set; }
    }
    public static class BML
    {
   
        public static int StartRow { get; } = 7;
        public static string LocalPanelPrefix { get; set; } = "+F";
        public static class Motor
        {
            public static string BMLPath { get; set; }
            public static string Type { get; } = "Motor";
            public static string ColumnIsVFC { get; } = "是否变频";
            public static string ColumnName { get; } = "电机名称";
            public static string ColumnDesc { get; } = "电机描述";
            public static string ColumnPower { get; } = "功率";
            public static string ColumnFloor { get; } = "楼层";
            public static string ColumnCabinet { get; } = "电柜号";
            public static string ColumnCabinetGroup { get; } = "电柜组";

            public const string PrefixVFC = "FCC";
        }
        public static class VFCAdapter
        {
            public static string BMLPath { get; set; }
            public static string Type { get; } = "Motor";
            public static string ColumnName { get; } = "变频名称";
            public static string ColumnDesc { get; } = "变频描述";
            //public static string ColumnCurrent { get; } = "电流";
            //public static string ColumnTorque { get; } = "扭矩";
            public static string ColumnPower { get; } = "功率";
            public static string ColumnFloor { get; } = "楼层";
            public static string ColumnCabinet { get; } = "电柜号";
            public static string ColumnCabinetGroup { get; } = "电柜组";
            public static string ColumnControlMethod { get; } = "控制方式";
            public const string PrefixVFC = "FCC";
            public static class TypeEnmu
            {
                public static string ATV320 { get; } = "ATV320";
                public static string ATV930 { get; } = "ATV930";
                public static string ATV61 { get; } = "ATV61";
                public static string ATV71 { get; } = "ATV71";
                public static string NORD { get; } = "NORD";
                public static string ABB { get; } = "ABB";
                public static string MOVIDRIVE { get; } = "MOVIDRIVE";
                public static string MicroMaster { get; } = "MicroMaster";
                public static string Sinamics { get; } = "Sinamics";
                public static string DanfossFC { get; } = "DanfossFC";
                public static string DanfossProfidrive { get; } = "DanfossProfidrive";
                public static string Lenze { get; } = "Lenze";
                public static string LenzePos { get; } = "LenzePos";
                public static string Leroy { get; } = "Leroy";
                public static string SS3RW44 { get; } = "3RW44";
                public static string SS3RW5x { get; } = "3RW5x";
                public static string SSET200S { get; } = "SSET200S";
            }

            public class VFC
            {
                private string name;
                public string Name
                {
                    get { return name; }
                    set
                    {
                        if (name != value)
                        {
                            name = value;
                            OnNameChange(EventArgs.Empty);
                        }
                    }
                }
                public VFCAdapterParameters par=new VFCAdapterParameters();
                public VFCAdapterParameters Par
                {
                    get { return par; }
                    set { par = value; }
                }
                public VFC()
                {
                    name = null;
                }
                #region Name change event
                public delegate void NameChangeEventHandler(object sender, EventArgs e);

                public event NameChangeEventHandler NameChange;

                protected virtual void OnNameChange(EventArgs e)
                {
                    NameChange?.Invoke(this, e);
                    NameChangeAfterEvent();
                }

                private void NameChangeAfterEvent()
                {
                   if (!string.IsNullOrEmpty(name))
                    {
                        if (name== TypeEnmu.ATV320)
                        {
                            par.LenPKW = "8";
                            par.LenPZD = "12";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits= "0.1";
                            par.SpeedMaxDigits = "500";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits= "0";
                            par.SpeedLimitMax= "100";
                            par.SpeedLimitMin = "0";
                            par.ParPZDConsistent= false;    
                        }
                        else if(name == TypeEnmu.ATV930 || name == TypeEnmu.ATV61 || name == TypeEnmu.ATV71)
                        {
                            par.LenPKW = "8";
                            par.LenPZD = "16";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0.1";
                            par.SpeedMaxDigits = "500";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "0";
                            par.ParPZDConsistent = false;
                        }
                        else if (name == TypeEnmu.ABB)
                        {
                            par.LenPKW = "0";
                            par.LenPZD = "12";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "2000";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "-100";
                            par.ParPZDConsistent = false;                         
                        }
                        else if (name == TypeEnmu.NORD || name == TypeEnmu.MicroMaster || name == TypeEnmu.Sinamics || name==TypeEnmu.DanfossFC)
                        {
                            par.LenPKW = "0";
                            par.LenPZD = "12";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "16384";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "-100";
                            par.ParPZDConsistent = false;
                        }
                        else if (name == TypeEnmu.MOVIDRIVE)
                        {
                            par.LenPKW = "0";
                            par.LenPZD = "6";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "16384";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "-100";
                            par.ParPZDConsistent = false;
                        }
                        else if (name == TypeEnmu.DanfossProfidrive)
                        {
                            par.LenPKW = "8";
                            par.LenPZD = "20";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "16384";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "-100";
                            par.ParPZDConsistent = true;
                        }
                        else if (name == TypeEnmu.SS3RW44)
                        {
                            par.LenPKW = "0";
                            par.LenPZD = "2";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "0";
                            par.SpeedUnitsByMaxDigits = "0";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "0";
                            par.SpeedLimitMin = "0";
                            par.ParPZDConsistent = false;
                        }
                        else if (name == TypeEnmu.SS3RW5x)
                        {
                            par.LenPKW = "0";
                            par.LenPZD = "4";
                            par.LenPZDInp = "16";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "0";
                            par.SpeedUnitsByMaxDigits = "0";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "0";
                            par.SpeedLimitMin = "0";
                            par.ParPZDConsistent = false;
                        }
                        else if (name == TypeEnmu.Lenze || name == TypeEnmu.LenzePos)
                        {
                            par.LenPKW = "0";
                            par.LenPZD = "6";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "16384";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "0";
                            par.ParPZDConsistent = false;
                        }
                        else if (name == TypeEnmu.Leroy)
                        {                      
                            par.LenPKW = "0";
                            par.LenPZD = "12";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "1000";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "0";
                            par.ParPZDConsistent = false;
                        }
                        else if (name == TypeEnmu.SSET200S)
                        {                        
                            par.LenPKW = "0";
                            par.LenPZD = "4";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0";
                            par.SpeedMaxDigits = "27648";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "0";
                            par.ParPZDConsistent = false;
                        }
                    }
                }
                #endregion


            }
        }

        public static class VLS
        {           
            private static string bmlPath;
            private static string typeOutput;
            private static string typeInput;
            private static string columnName;
            private static string columnDesc;
            private static string columnFloor;
            private static string columnCabinet;
            private static string columnCabinetGroup;
            private static string columnMachine;
            private static string columnIORemark;

            private static string suffixVLS;
            private static string prefixLocalPanel;
            private static string suffixInpLN;
            private static string suffixInpHN;
            private static string suffixOutpLN;
            private static string suffixOutpHN;
            private static string suffixInpRunRev;
            private static string suffixInpRunFwd;    
            private static string manualFlap;
            private static string pneFlap;
            private static string pneSlideGate;
            private static string manualSlideGate;
            private static string pneTwoWayValve;
            private static string pneShutOffValve;
            static  VLS()
            {        
                string key= "BML.VLS.";
                string[] keysToRead= new string[]
                    {
                        $"{key}Columns.Name",
                        $"{key}Columns.Desc",
                        $"{key}Columns.Floor",
                        $"{key}Columns.Cabinet",
                        $"{key}Columns.CabinetGroup",
                        $"{key}Columns.Machine",
                        $"{key}Columns.IORemark",
                        $"{key}MachineType.ManualFlap",
                        $"{key}MachineType.PneFlap",
                        $"{key}MachineType.ManualSlideGate",
                        $"{key}MachineType.PneSlideGate",
                        $"{key}MachineType.PneTwoWayValve",
                        $"{key}MachineType.PneShutOffValve",
                        $"{key}Suffix.VLS",
                        $"{key}Suffix.InpLN",
                        $"{key}Suffix.OutpLN",
                        $"{key}Suffix.InpHN",
                        $"{key}Suffix.OutpHN",
                        $"{key}Suffix.InpRunRev",
                        $"{key}Suffix.InpRunFwd",
                        $"{key}Prefix.LocalPanel",
                        $"{key}IOType.Output",
                        $"{key}IOType.Input",
                    };
                Dictionary<string, string> keyValueRead;
                keyValueRead = LibGlobalSource.JsonHelper.ReadKeyValues(AppGlobal.JSON_FILE_PATH, keysToRead);
                columnName = keyValueRead[$"{key}Columns.Name"];
                columnDesc = keyValueRead[$"{key}Columns.Desc"];
                columnFloor = keyValueRead[$"{key}Columns.Floor"];
                columnCabinet = keyValueRead[$"{key}Columns.Cabinet"];
                columnCabinetGroup = keyValueRead[$"{key}Columns.CabinetGroup"];
                columnMachine = keyValueRead[$"{key}Columns.Machine"];
                columnIORemark = keyValueRead[$"{key}Columns.IORemark"];
                manualFlap = keyValueRead[$"{key}MachineType.ManualFlap"];
                pneFlap = keyValueRead[$"{key}MachineType.PneFlap"];
                manualSlideGate = keyValueRead[$"{key}MachineType.ManualSlideGate"];
                pneSlideGate = keyValueRead[$"{key}MachineType.PneSlideGate"];
                pneTwoWayValve = keyValueRead[$"{key}MachineType.PneTwoWayValve"];
                pneShutOffValve = keyValueRead[$"{key}MachineType.PneShutOffValve"];
                suffixVLS = keyValueRead[$"{key}Suffix.VLS"];
                suffixInpLN = keyValueRead[$"{key}Suffix.InpLN"];
                suffixInpHN = keyValueRead[$"{key}Suffix.InpHN"];
                suffixOutpLN = keyValueRead[$"{key}Suffix.OutpLN"];
                suffixOutpHN = keyValueRead[$"{key}Suffix.OutpHN"];
                suffixInpRunRev = keyValueRead[$"{key}Suffix.InpRunRev"];
                suffixInpRunFwd = keyValueRead[$"{key}Suffix.InpRunFwd"];
                prefixLocalPanel = keyValueRead[$"{key}Prefix.LocalPanel"];
                typeOutput = keyValueRead[$"{key}IOType.Output"];
                typeInput = keyValueRead[$"{key}IOType.Input"];
                bmlPath =string.Empty;

                keyValueRead = null;
            }
    
            public static string BMLPath
            {
                get { return bmlPath; }
                set { bmlPath = value; }
            }

            public static string TypeOutput
            {
                get { return typeOutput; }
            }

            public static string TypeInput
            {
                get { return typeInput; }
            }

            public static string ColumnName
            {
                get { return columnName; }
            }

            public static string ColumnDesc
            {
                get { return columnDesc; }
            }

            public static string ColumnFloor
            {
                get { return columnFloor; }
            }

            public static string ColumnCabinet
            {
                get { return columnCabinet; }
            }

            public static string ColumnCabinetGroup
            {
                get { return columnCabinetGroup; }
            }

            public static string ColumnMachine
            {
                get { return columnMachine; }
            }

            public static string ColumnIORemark
            {
                get { return columnIORemark; }
            }

            public static string SuffixVLS
            {
                get { return suffixVLS; }
                set { suffixVLS = value;  }
            }

            public static string PrefixLocalPanel
            {
                get { return prefixLocalPanel; }
                set {  prefixLocalPanel = value; }
            }

            public static string ManualFlap
            {
                get { return manualFlap; }
            }

            public static string PneFlap
            {
                get { return pneFlap; }
            }
            public static string ManualSlideGate
            {
                get { return manualSlideGate; }
            }
            public static string PneSlideGate
            {
                get { return pneSlideGate; }
            }
       
            public static string PneTwoWayValve
            {
                get { return pneTwoWayValve; }
            }
            public static string PneShutOffValve
            {
                get { return pneShutOffValve; }
            }
            public static string SuffixInpLN
            {
                get { return suffixInpLN; }
                set { suffixInpLN = value; }
            }
            public static string SuffixInpHN
            {
                get { return suffixInpHN; }
                set { suffixInpHN = value; }
            }

            public static string SuffixOutpLN
            {
                get { return suffixOutpLN; }
                set { suffixOutpLN = value; }
            }

            public static string SuffixOutpHN
            {
                get { return suffixOutpHN; }
                set { suffixOutpHN = value; }
            }

            public static string SuffixInpRunRev
            {
                get { return suffixInpRunRev; }
                set { suffixInpRunRev = value; }
            }

            public static string SuffixInpRunFwd
            {
                get { return suffixInpRunFwd; }
                set { suffixInpRunFwd = value; }
            }
        }
    }
    #endregion

    public class CreateMode
    {
        public struct ObjectCreateModeCollection
        {
            public string Rule;
            public string AutoSearch;
            public string BML;
        }
        private static ObjectCreateModeCollection objectCreateMode;
        public static ObjectCreateModeCollection ObjectCreateMode
        {
            get { return objectCreateMode; }
        }
        public bool Rule { get; set; }
        public bool BML { get; set; }
        public bool AutoSearch { get; set; }

        public CreateMode()
        {
            Rule = true;
            BML = false;
            AutoSearch = false;
            objectCreateMode.Rule = "按规则创建";
            objectCreateMode.BML = "BML导入";
            objectCreateMode.AutoSearch = "数据库搜寻";
        }

    }
    public interface IGcForm
    {
        void GetInfoFromDatabase();
        void GetLastObjRule();
        void CreateTips();
        void CreateImpExp();
        void Default();

    }

}
