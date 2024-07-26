using GcproExtensionLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GcproExtensionApp.AppGlobal;

namespace GcproExtensionApp
{
    public class VFCAdapterParametersSet
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
        public bool ParPZDConsistent { get; set; } = false;
    }
    public class MachineType
    {
        private string feederRollerMiller;
        private string rollerMiller;
        private string elevator;
        private string filter;
        private string highLevel;
        private string lowLevel;
        private string chainConveyor;
        private string airLock;
        private string branFinisher;
        private string detacher;
        private string fan;
        #region Properties
        public string Elevator
        {
            get { return elevator; }
        }
        public string Filter
        {
            get { return filter; }
        }
        public string HighLevel
        {
            get { return highLevel; }
        }
        public string LowLevel
        {
            get { return lowLevel; }
        }
        public string ChainConveyor
        {
            get { return chainConveyor; }
        }
        public string AirLock
        {
            get { return airLock; }
        }
        public string BranFinisher
        {
            get { return branFinisher; }
        }
        public string Detacher
        {
            get { return detacher; }
        }
        public string Fan
        {
            get { return fan; }
        }
        public string RollerMiller
        {
            get { return rollerMiller; }
        }
        public string FeederRollerMiller
        {
            get { return feederRollerMiller; }
        }
        #endregion Properties
        public MachineType()
        {
            string keyMachines = $"{AppGlobal.JS_BML}.{AppGlobal.JS_MACHINE}.";
            try
            {
            
                var keys = new Dictionary<string, Action<string>>
                 {
                    {$"{keyMachines}Elevator",value => elevator = value },
                    {$"{keyMachines}Filter",value => filter = value },
                    {$"{keyMachines}HighLevel",value => highLevel = value },
                    {$"{keyMachines}LowLevel",value => lowLevel = value },
                    {$"{keyMachines}ChainConveyor",value => chainConveyor = value },
                    {$"{keyMachines}Airlock",value => airLock = value },
                    {$"{keyMachines}BranFinisher",value => branFinisher= value },
                    {$"{keyMachines}Detacher",value => detacher = value },
                    {$"{keyMachines}Fan",value => fan = value },
                    {$"{keyMachines}RollerMiller",value => rollerMiller = value },
                    {$"{keyMachines}FeederRollerMiller",value => feederRollerMiller = value },
                 };
                Dictionary<string, string> keyValueRead;
                keyValueRead = LibGlobalSource.JsonHelper.ReadKeyValues(AppGlobal.JSON_FILE_PATH, keys.Keys.ToArray());
                foreach (var key in keys)
                {
                    if (keyValueRead.TryGetValue(key.Key, out var value))
                    {
                        key.Value(value);
                    }
                }
                keyValueRead = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), $"{keyMachines} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class Sections
    {
        private string common;
        private string preCleaning;
        private string cleaning;
        private string screenings;
        private string milling;
        private string flour;
        private string stacking;
        private string outload;
        private string byproduct;
        #region Properties
        public string Common
        {
            get { return common; }
            set { common = value; }
        }
        public string PreCleaning
        {
            get { return preCleaning; }
            set { preCleaning = value; }
        }

        public string Cleaning
        {
            get { return cleaning; }
            set { cleaning= value; }
        }
        public string Screenings
        {
            get { return screenings; }
            set { screenings = value; }
        }

        public string Milling
        {
            get { return milling; }
            set { milling = value; }
        }

        public string Flour
        {
            get { return flour; }
            set { flour = value; }
        }

        public string Stacking
        {
            get { return stacking; }
            set { stacking = value; }
        }

        public string Outload
        {
            get { return outload; }
            set { outload = value; }
        }

        public string Byproduct
        {
            get { return byproduct; }
            set { byproduct = value; }
        }
        #endregion Properties
        public Sections()
        { 
            
        }
    }
    public class Bins
    {
        private string silo;
        private string rawWheat;
        private string tempering;
        private string screenings;
        private string baseFlour;
        private string mixing;
        private string bagging;
        private string outload;
        private string byProduct;
        public string Silo
        {
            get { return silo; }
            set { silo = value; }
        }
        public string RawWheat
        {
            get { return rawWheat; }
            set { rawWheat = value; }
        }
        public string Tempering
        {
            get { return tempering; }
            set { tempering = value; }
        }
        public string Screenings
        {
            get { return screenings; }
            set { screenings = value; }
        }
        public string BaseFlour
        {
            get { return baseFlour; }
            set { baseFlour = value; }
        }
        public string Mixing
        {
            get { return mixing; }
            set { mixing = value; }
        }
        public string Bagging
        {
            get { return bagging; }
            set { bagging = value; }
        }
        public string Outload
        {
            get { return outload; }
            set { outload = value; }
        }
        public string ByProduct
        {
            get { return byProduct; }
            set { byProduct = value; }
        }
        public Bins()
        {

        }
    }
    public class SuffixObject
    {
        private Dictionary<string, string> suffixObjectType = new Dictionary<string, string>();
        public SuffixObject()
        {
            string keySuffixObjectType = $"{AppGlobal.JS_BML}.{AppGlobal.JS_SUFFIX}.{AppGlobal.JS_OBJECT_TYPE}.";
            suffixObjectType = new Dictionary<string, string>
            {
                { "MXZ", string.Empty},
                { "PAZ", string.Empty},
                { "PAL", string.Empty},
                { "PAM", string.Empty},
                { "BZA", string.Empty},
                { "KCU", string.Empty},
                { "SHE", string.Empty},
                { "FYX", string.Empty},
                { "KFC", string.Empty},
                { "BFT", string.Empty},
                { "BFE", string.Empty},
                { "BLH", string.Empty},
                { "BLM", string.Empty},
                { "BME", string.Empty},
                { "ETZ", string.Empty},
                { "KCL", string.Empty},
                { "BLE", string.Empty},
                { "BLL", string.Empty},
                { "BWE", string.Empty},
                { "BZS", string.Empty},
                { "EXL", string.Empty},
                { "FTA", string.Empty},
                { "BQS", string.Empty},
                { "FIA", string.Empty},
                { "BPE", string.Empty},
                { "BPS", string.Empty},
                { "BST", string.Empty},
                { "SHC", string.Empty},
                { "QYS", string.Empty},
                { "BTE", string.Empty},
                { "BTS", string.Empty},
                { "TSC", string.Empty},
                { "KVC", string.Empty},
                { "PWC", string.Empty},
                { "KWT", string.Empty},
                { "BSA", string.Empty},
                { "SIB", string.Empty},
                { "LLI", string.Empty},
                { "PPW", string.Empty}
            };
            try
            {              
                var keys = new Dictionary<string, Action<string>>
                 {
                    { $"{keySuffixObjectType}MXZ", value => suffixObjectType["MXZ"] = value },
                    { $"{keySuffixObjectType}PAZ", value => suffixObjectType["PAZ"] = value },
                    { $"{keySuffixObjectType}PAL", value => suffixObjectType["PAL"] = value },
                    { $"{keySuffixObjectType}PAM", value => suffixObjectType["PAM"] = value },
                    { $"{keySuffixObjectType}BZA", value => suffixObjectType["BZA"] = value },
                    { $"{keySuffixObjectType}KCU", value => suffixObjectType["KCU"] = value },
                    { $"{keySuffixObjectType}SHE", value => suffixObjectType["SHE"] = value },
                    { $"{keySuffixObjectType}FYX", value => suffixObjectType["FYX"] = value },
                    { $"{keySuffixObjectType}KFC", value => suffixObjectType["KFC"] = value },
                    { $"{keySuffixObjectType}BFT", value => suffixObjectType["BFT"] = value },
                    { $"{keySuffixObjectType}BFE", value => suffixObjectType["BFE"] = value },
                    { $"{keySuffixObjectType}BLH", value => suffixObjectType["BLH"] = value },
                    { $"{keySuffixObjectType}BLM", value => suffixObjectType["BLM"] = value },
                    { $"{keySuffixObjectType}BME", value => suffixObjectType["BME"] = value },
                    { $"{keySuffixObjectType}ETZ", value => suffixObjectType["ETZ"] = value },
                    { $"{keySuffixObjectType}KCL", value => suffixObjectType["KCL"] = value },
                    { $"{keySuffixObjectType}BLE", value => suffixObjectType["BLE"] = value },
                    { $"{keySuffixObjectType}BLL", value => suffixObjectType["BLL"] = value },
                    { $"{keySuffixObjectType}BWE", value => suffixObjectType["BWE"] = value },
                    { $"{keySuffixObjectType}BZS", value => suffixObjectType["BZS"] = value },
                    { $"{keySuffixObjectType}EXL", value => suffixObjectType["EXL"] = value },
                    { $"{keySuffixObjectType}FTA", value => suffixObjectType["FTA"] = value },
                    { $"{keySuffixObjectType}BQS", value => suffixObjectType["BQS"] = value },
                    { $"{keySuffixObjectType}FIA", value => suffixObjectType["FIA"] = value },
                    { $"{keySuffixObjectType}BPE", value => suffixObjectType["BPE"] = value },
                    { $"{keySuffixObjectType}BPS", value => suffixObjectType["BPS"] = value },
                    { $"{keySuffixObjectType}BST", value => suffixObjectType["BST"] = value },
                    { $"{keySuffixObjectType}SHC", value => suffixObjectType["SHC"] = value },
                    { $"{keySuffixObjectType}QYS", value => suffixObjectType["QYS"] = value },
                    { $"{keySuffixObjectType}BVS", value => suffixObjectType["BVS"] = value },
                    { $"{keySuffixObjectType}BTE", value => suffixObjectType["BTE"] = value },
                    { $"{keySuffixObjectType}BTS", value => suffixObjectType["BTS"] = value },
                    { $"{keySuffixObjectType}TSC", value => suffixObjectType["TSC"] = value },
                    { $"{keySuffixObjectType}KVC", value => suffixObjectType["KVC"] = value },
                    { $"{keySuffixObjectType}PWC", value => suffixObjectType["PWC"] = value },
                    { $"{keySuffixObjectType}KWT", value => suffixObjectType["KWT"] = value },
                    { $"{keySuffixObjectType}BSA", value => suffixObjectType["BSA"] = value },
                    { $"{keySuffixObjectType}SIB", value => suffixObjectType["SIB"] = value },
                    { $"{keySuffixObjectType}LLI", value => suffixObjectType["LLI"] = value },
                    { $"{keySuffixObjectType}PPW", value => suffixObjectType["PPW"] = value }
                 };
                Dictionary<string, string> keyValueRead;
                // suffixObjectType= LibGlobalSource.JsonHelper.ReadKeyValues(AppGlobal.JSON_FILE_PATH, keys.Keys.ToArray());
                keyValueRead = LibGlobalSource.JsonHelper.ReadKeyValues(AppGlobal.JSON_FILE_PATH, keys.Keys.ToArray());
                foreach (var key in keys)
                {
                    if (keyValueRead.TryGetValue(key.Key, out var value))
                    {
                        key.Value(value);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), $"{keySuffixObjectType} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Dictionary<string, string> SuffixObjectType
        {
            get { return suffixObjectType; }

        }
        public string GetKey(string key)
        {
            return suffixObjectType.ContainsKey(key) ? key : null;
        }
    }
    public class MotorCurrent
    {
        private float ratedCurrent;
        private float ctRatio;
        public float RatedCurrent
        {
            get { return ratedCurrent; }
            set { ratedCurrent = value; }
        }
        public float CTRatio
        {
            get { return ctRatio; }
            set { ctRatio = value; }
        }
        public MotorCurrent(float rc=0.0f, float ctr=0.0f)
        {
            ratedCurrent = rc;
            ctRatio = ctr;
        }
        protected bool ParseCurrent(string rcAndCtr)
        {
            string[] parts = rcAndCtr.Split(',');
            if (parts.Length == 2 &&
                float.TryParse(parts[0], out float rc) &&
                float.TryParse(parts[1], out float ctr))
            {
                this.ratedCurrent = rc;
                this.ctRatio = ctr;
                return true;
            }
            else
            {
                this.ratedCurrent = 0.0f;
                this.ctRatio = 0.0f;
                return false;
            }
        }
    }
    public class MotorHelper: MotorCurrent
    {
        /// <summary>
        /// 根据电机功率，计算理论上的电机额定电流
        /// </summary>
        /// <param name="motorPower">额定功率KW</param>
        /// <param name="voltage">额定电压，默认380V</param>
        /// <param name="efficiency">电机效率，默认0.9</param>
        /// <param name="powerFactor">功率因素，默认0.85</param>
        /// <returns>电机额定电流</returns>
        public float CalcRateCurrent(float motorPower,int voltage=380,float efficiency=0.9f,float powerFactor=0.85f)
        {
            float powerW = motorPower * 1000;
            return  (float)(powerW / (Math.Sqrt(3) * voltage * efficiency * powerFactor)); 
        }
        public bool  GetConfig(string motorPower)
    
        {
            try
            {
                string keyMotorPower = $"{AppGlobal.JS_ENGINEERING}.{AppGlobal.JS_MOTORPOWER}";
                string actValueMotorPower =string.Empty;
                var keys = new Dictionary<string, Action<string>>
                 {
                    //Json配置文件中键名规范严格，同时使用"."来分割键名，因此当某个键值名称中含有特殊字符
                    //"."时，需要对键值访问路径进行特殊处理，比如"Engineering.MotorPower.0.37KW"此时
                    //键"0.37KW"包含"."，因此，访问改键值需要特殊处理为"Engineering.MotorPower['0.37KW']".
                     { $@"{keyMotorPower}['{motorPower}KW']", value => actValueMotorPower = value },
                 };
                Dictionary<string, string> keyValueRead;
                keyValueRead = LibGlobalSource.JsonHelper.ReadKeyValues(AppGlobal.JSON_FILE_PATH, keys.Keys.ToArray());
                foreach (var key in keys)
                {
                    if (keyValueRead.TryGetValue(key.Key, out var value))
                    {
                       key.Value(value);
                    }
                }
                if (actValueMotorPower == "未找到配置项" || String.IsNullOrEmpty(actValueMotorPower))
                {
                    return false;
                }
                else
                {
                    return ParseCurrent(actValueMotorPower)?true:false;
                }          
            }
            catch
            {
               return false;
            }
        }
        public MotorHelper()
        {
        
        }
     
    }
}
