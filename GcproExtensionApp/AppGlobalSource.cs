using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region GcproExtensionLibrary
using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using GcproExtensionLibrary.Gcpro.GCObject;
using GcproExtensionLibrary.FileHandle;
using System.Drawing.Text;
using System.IO;
#endregion
namespace GcproExtensionApp
{
    public static class AppGlobalSource
    {
        #region Const
       
      

        public const string ERROR_ENTER_TYPE = "输入类型错误";
        public const string ENTER_NUMERIC = "请输入一个数字类型";
        public const string FIELDS_SEPARATOR = "   |";
        public const string CREATE_IMPORT_RULE = "创建导入规则";
        public const string CONNECT_IO = "关联IO";
        public const string SET_RELATION = "设置从属关系";
        public const string DEMO_NAME = "示例名称：";
        public const string DEMO_NAME_RULE = "示例规则：";
        public const string DEMO_DESCRIPTION = "示例描述：";
        public const string DEMO_DESCRIPTION_RULE = "示例描述：";
        public const string FILE_NOT_EXITS = "示例描述：";
        public const string KEY_WORD_AUTOSEARCH = "搜寻关键字";
        public const string FILE_SAVE_AS_FAILURE = "文件保存失败";

        public const string NULL = "null";
        public const string DEFAULT_GCPRO_TEMP_PATH = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH;
        public const string OBJECT_FIELD = "数据库字段: ";

        public const string MSG_INVALID_IO_SYMBOL = "无效的IO名称！";
        public const char IO_SYMBOL_SUFFIX_SPLIT = ':';
        public const string INFO = "信息提示";
        public const string MSG_RULE_CREATE_SUCESSFULL = "规则创建成功";
        public const string MSG_RULE_ALREADY_EXITS = "规则已经存在，需要重新创建吗";
        public const string EX_FILE_NOT_FOUND = "文件未找到，请确保文件路径正确并且文件存在。";
        public const string EX_IO_ERROR = "发生I/O错误";
        public const string EX_UNKNOW = "未知错误";
        public const string EX_UNAUTHORIZED_ACCESS = "没有权限访问文件。请检查文件权限。";
        public const int MIN_IO_SYMBOL_LENGTH = 3;
        #endregion
    
        public static bool NewOLEDBDriver;
        public static GcproDataBase GcproDBInfo;

        static AppGlobalSource()
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
        public static bool CheckNumericString(string sourceString)
        {
            // 直接尝试解析字符串，如果有异常在调用处抛出 out _表示不必关注参数
            bool isInt = int.TryParse(sourceString, out _);
            bool isLong = long.TryParse(sourceString, out _);
            bool isFloat = float.TryParse(sourceString, out _);
            return isInt || isLong || isFloat;
        }

        public static string GetObjectSymbolFromIO(string source )
        {
            string ret=string.Empty;
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

    public static class BML
    {
        public static class Motor
        {
            public static string TypeMotor { get; } = "Motor";
            public static string ColumnName { get; } = "电机名称";
            public static string ColumnDesc { get; } = "电机描述";
            public static string ColumnPower { get; } = "功率";
            public static string ColumnFloor { get; } = "楼层";
            public static string ColumnCabinet{ get; } = "电柜号";
            public static string ColumnCabinetGroup { get; } = "电柜组";
        }
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
        public bool Rule { get; set;}
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
