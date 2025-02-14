using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Reflection;

#region GcproExtensionLibrary
using GcproExtensionLibrary.Gcpro.GCObject;
using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using static GcproExtensionLibrary.Gcpro.GcproTable;
using System.Linq;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;
using OfficeOpenXml.Drawing.Slicer.Style;
using System.Net.NetworkInformation;
#endregion
namespace GcproExtensionApp
{

    public static class AppGlobal
    {      
        #region Const
        public const int MEAG_EXT_LONG = LibGlobalSource.MEAG_EXT_LONG;
        public const int MEAG_NORMAL = LibGlobalSource.MEAG_NORMAL;
        public const int NONE_UNIT = LibGlobalSource.NONE_UNIT;
        public const double NO_DP_NODE = LibGlobalSource.NO_DP_NODE;
        public const double NO_DIAGRAM = LibGlobalSource.NO_DIAGRAM;
        public const double GROUP_HORNCODE = LibGlobalSource.GROUP_HORNCODE;
        public const string FIELDS_SEPARATOR = LibGlobalSource.FIELDS_SEPARATOR;
        public const string DESC_SEPARATOR = LibGlobalSource.DESC_SEPARATOR;
        public const string HORNCODE_FIELDS_SEPARATOR = LibGlobalSource.HORNCODE_FIELDS_SEPARATOR;
        public const string JSON_FILE_PATH = "appsettings.json";
        public const string ERROR_ENTER_TYPE = "输入类型错误";
        public const string ENTER_NUMERIC = "请输入一个数字类型";
        public const string UPDATE_AI_UNITSMAXDIGITS = "自动更新模拟量输入点[UnitsByMaxDigits]值";
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
        public const string VFC= "变频器";
        public const string NAME = "名称";
        public const string FC_FAN = "风扇";
        public const string NULL = "null";
        public const string DEFAULT_GCPRO_TEMP_PATH = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH;
        public const string OBJECT_FIELD = "数据库字段: ";
        public const string USER_DEFINED_DESC = "仅使用BML中描述？";
        public const string MSG_INVALID_IO_SYMBOL = LibGlobalSource.MSG_INVALID_IO_SYMBOL;
        public const string INFO = "信息提示";
        public const string MSG_NOT_VALID_IP = "非法IP地址";
        public const string MSG_REGENERATE_DPNODE = "确定要重新生成DPNode翻译？";
        public const string MSG_CLEAR_FILE = "确定要清除文件类容？";
        public const string MSG_RULE_NOT_CORRECT = "规则不正确或者未设置:";
        public const string MSG_CREATE_WILL_TERMINATE = "新建进程将终止";
        public const string MSG_RULE_CREATE_SUCESSFULL = "规则创建成功";
        public const string MSG_STRING_CONVERT_TO = "字符串转换为";
        public const string MSG_FAILURE = "失败";
        public const string MSG_RULE_ALREADY_EXITS = "规则已经存在，需要重新创建吗";
        public const string EX_FILE_NOT_FOUND = "文件未找到，请确保文件路径正确并且文件存在。";
        public const string EX_IO_ERROR = "发生I/O错误";
        public const string EX_UNKNOW = "未知错误";
        public const string EX_UNAUTHORIZED_ACCESS = "没有权限访问文件。请检查文件权限。";
        public const int MIN_IO_SYMBOL_LENGTH = LibGlobalSource.MIN_IO_SYMBOL_LENGTH;
        public const string PATTERN_IP = @"^(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)$";
        #region<---Appsetting struct--->
        public const string JS_BML = "BML";
        public const string JS_GCOBJECT_INFO = "GcObjectInfo";
        public const string JS_PATH = "Path";
        public const string JS_PREFIX = "Prefix";
        public const string JS_SUFFIX = "Suffix";
        public const string JS_SECTION = "Section";
        public const string JS_BIN = "Bin";
        public const string JS_MACHINE= "Machine";
        public const string JS_VLS = "VLS";
        public const string JS_MOTOR = "Motor";
        public const string JS_DI = "DI";
        public const string JS_DO = "DO";
        public const string JS_SCALE_ADAPTER = "ScaleAdapter";
        public const string JS_FBAL = "ScaleAdapter";
        public const string JS_AI = "AI";
        public const string JS_MDDX = "MDDx";
        public const string JS_ROLL8STAND = "MA_Roll8Stand";
        public const string JS_MDDYZPHOENIX = "MA_MDDYZPhoenix";
        public const string JS_MOTOR_WITH_BYPASS= "MA_MotorWithBypass";
        public const string JS_DISCHARGER = "MA_Discharger";
        public const string JS_DISCHARGER_VERTEX = "DischargerVertex";
        public const string JS_DPSLAVE= "DPSlave";
        public const string JS_GENERAL= "General";
        public const string JS_NAME_NUMBER_RULE="NameNumberRule";
        public const string JS_ADDINFO_TO_DESC = "AddInfoToDesc";
        #region<-----Sub struct----->
        public const string JS_OBJECT_TYPE = "ObjectType";
        public const string JS_IDENT_DESC_SEPARATOR = "IdentDescSeparator";
        public const string JS_IP_ADDR = "IPAddr";
        public const string JS_SLAVE_NO = "SlaveNo";
        public const string JS_COLUMNS = "Columns";
        public const string JS_IO_TYPE = "IOType";
        public const string JS_IO_REMARK = "IORemark";
        public const string JS_FILTER = "Filter";
        public const string JS_DELIMITER = "Delimiter";
        public const string JS_IO = "IO";
        public const string JS_STOPPING_TIME= "StoppingTime";
        #endregion<-----Sub struct----->
        public static (int Value, int Max) ProcessValue = (0, 100);
        public static (int IOByteStart, int Len) IOAddr = (1000, 1);
        public static (bool Section, bool UserDefSection, bool Elevation, bool IdentNumber, bool Cabinet, bool Power, bool OnlyNumber) AdditionDesc = (true, false, true, true, false, false, true);
        public static (double DPNodeNo, double FieldBusNodeKey) FieldbusNodeInfo = (AppGlobal.NO_DP_NODE, AppGlobal.NO_DP_NODE);
        #region<-----Engineer----->
        public const string JS_ENGINEERING = "Engineering";
        public const string JS_MOTORPOWER = "MotorPower";
        public const string JS_PATTERN = "Pattern";
        #endregion<-----Engineer----->

        #endregion<---Appsetting struct--->

        #endregion Const
        public static class AppInfo
        {
            public static string Title { get; set; }
            public static string Version { get; set; }
            public static string Description { get; set; }
            public static string CopyRight { get; set; }
            public static string Company { get; set; }
        }
        public class Range
        {

            private int min, max;
            public int Min
            {
                get { return min;}
                set{ min = value;} 
            }
            public int Max
            {
                get { return max; }
                set { max = value; }
            }

            public Range(int min, int max)
            {
                this.min = min;
                this.max= max;
            }
            public bool IsInRange(int value)
            {
                return value >= Min && value <= Max;
            }

            public void ParseRange(string rangeStr)
            {
                string[] parts = rangeStr.Split('-');
                if (parts.Length == 2 &&
                    int.TryParse(parts[0], out int min) &&
                    int.TryParse(parts[1], out int max))
                {                
                 this.min = min;
                 this.max = max;

                }
                else
                {
                    throw new ArgumentException("Invalid range format");
                }
            }

            public static Range ReturnNewRange(string rangeStr)
            {
                string[] parts = rangeStr.Split('-');
                if (parts.Length == 2 &&
                    int.TryParse(parts[0], out int min) &&
                    int.TryParse(parts[1], out int max))
                {
                     return new Range(min, max);                   
                }
                else
                {
                    throw new ArgumentException("Invalid range format");
                }
            }
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
        /// 
        public static string FieldDisplay(string fieldName)
        {
            return OBJECT_FIELD + fieldName;
        }
        public static void AppendInfoToBuilder(bool add, string info, StringBuilder builder)
        {
            if (add)
            {
                builder.Append(info);
            }
        }
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
        /// <summary>
        /// Check whether string can be convert to a number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool CheckNumericString(string input)
        {
            Regex numberCheck = new Regex(@"^[+-]?\d+(\.\d+)?$");
            if (numberCheck.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 使用泛型与模式匹配来实现解析字符串中的数字
        /// 同时使用泛型约束 where T : struct 约束参数类型必须为值类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceString"></param>
        /// <param name="outValue"></param>
        /// <returns></returns>
        public static bool ParseValue<T>(string sourceString, out T outValue) where T : struct
        {
            outValue = default;
            bool isValid = false;
            if (typeof(T) == typeof(int) && int.TryParse(sourceString, out var intValue))
            {
                outValue = (T)(object)intValue;
                isValid = true;
            }
            else if (typeof(T) == typeof(long) && long.TryParse(sourceString, out var longValue))
            {
                outValue = (T)(object)longValue;
                isValid = true;
            }
            else if (typeof(T) == typeof(double) && double.TryParse(sourceString, out var doubleValue))
            {
                outValue = (T)(object)doubleValue;
                isValid = true;
            }
            else if (typeof(T) == typeof(float) && float.TryParse(sourceString, out var floatValue))
            {
                outValue = (T)(object)floatValue;
                isValid = true;
            }
            return isValid;
        }
        public static bool ParseInt(string sourceString, out int outValue)
        {
           ;
            bool isInt = int.TryParse(sourceString, out int tempInt);
            outValue = tempInt;
            return isInt;
        }
        public static bool ParseLong(string sourceString, out long outValue)
        {
            bool isLong = long.TryParse(sourceString, out long tempLong);
            outValue = tempLong;
            return isLong;
        }
        public static bool ParseFloat(string sourceString, out float outValue)
        {
            bool isFloat = float.TryParse(sourceString, out float tempFloat);
            outValue = tempFloat;
            return isFloat;
        }
        public static bool ParseDouble(string sourceString, out double outValue)
        {
            bool isDouble = double.TryParse(sourceString, out double tempDouble);
            outValue = tempDouble;
            return isDouble;
        }
        /// <summary>
        /// 获取枚举类型成员个数
        /// </summary>
        /// <returns>整形</returns>
        public static int GetEnumMemberCount<T>(this T enumType) where T : Enum
        {
            return Enum.GetValues(typeof(T)).Length;
        }
        /// <summary>
        /// 获取枚举类型成员值
        /// </summary>
        /// <returns>
        /// <return>Array of Enum</return>
        /// <TypeConvert>比如(int).returns[]得到相应的数值</TypeConvert>
        /// </returns>
        public static T[] GetEnumValues<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToArray();
        }
        /// <summary>
        /// 获取指定类型的所有属性名称
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="includeNonPublic">是否包含非公共属性</param>
        /// <returns>属性名称列表</returns>
        public static List<string> GetPropertyNames(Type type, bool includeNonPublic = false)
        {
            var propertyNames = new List<string>();
            BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Static;

            if (includeNonPublic)
            {
                bindingFlags |= BindingFlags.NonPublic;
            }

            foreach (var property in type.GetProperties(bindingFlags))
            {
                propertyNames.Add(property.Name);
            }

            return propertyNames;
        }

        #region Operate bit 
        /// <summary>
        /// 返回一个整形数上指定位的值
        /// </summary>
        /// <param name="number"></param>
        /// <param name="n"></param>
        /// <returns>如果指定位"n"是1，则返回"true"否则返回"false"</returns>
        public static bool GetBitValue(int number, byte n)
        {           
            return ((number >> n) & 1) == 1;
        }
        /// <summary>
        /// 返回一个长整形数上指定位的值
        /// </summary>
        /// <param name="number"></param>
        /// <param name="n"></param>
        /// <returns>如果指定位"n"是1，则返回"true"否则返回"false"</returns>
        public static bool GetBitValue(long number, byte n)
        {
            return ((number >> n) & 1) == 1;
        }
        public static void SetBit(ref long sourceValue, byte position)
        {
            long mask = 1L << position;
            sourceValue |= mask;

        }
        public static void SetBit(ref int sourceValue, byte position)
        {
            int mask = 1 << position;
            sourceValue |= mask;
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
            sourceValue &= mask;

        }
        public static void ClearBit(ref int sourceValue, byte position)
        {
            int mask = ~(1 << position);
            sourceValue  &= mask;

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
        #endregion Operate bit 
    }
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
            objectCreateMode.Rule = "自定义规则";
            objectCreateMode.BML = "BML导入";
            objectCreateMode.AutoSearch = "IO搜寻";
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
