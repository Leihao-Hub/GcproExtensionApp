using GcproExtensionLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static GcproExtensionLibrary.LibGlobalSource;
using GcproExtensionLibrary.Gcpro.GCObject;

namespace GcproExtensionApp
{
    public class BML
    {
        private static string prefixLocalPanel;
        private static MachineType machineType = new MachineType();
        private static Sections sections = new Sections();
        private static Bins bins = new Bins();
        #region Properties
        public static string PrefixLocalPanel
        {
            get { return prefixLocalPanel; }
            set { prefixLocalPanel = value; }
        }
        public static MachineType MachineType
        {
            get { return machineType; }
        }
        public static Sections Sections
        {
            get { return sections; }
        }
        public static Bins Bins
        {
            get { return bins; }
        }
        #endregion
        static BML()
        {
            try
            {
                string keySections = $"{AppGlobal.JS_BML}.{AppGlobal.JS_SECTION}.";
                string keyBins = $"{AppGlobal.JS_BML}.{AppGlobal.JS_BIN}.";
                var keys = new Dictionary<string, Action<string>>
                 {
                    {"BML.Prefix.LocalPanel",value => prefixLocalPanel= value },
                    {$"{keySections}Common",value => sections.Common= value },
                    {$"{keySections}PreCleaning",value => sections.PreCleaning= value },
                    {$"{keySections}Cleaning",value => sections.Cleaning= value },
                    {$"{keySections}Screenings",value => sections.Screenings= value },
                    {$"{keySections}Milling",value => sections.Milling =value },
                    {$"{keySections}Flour",value => sections.Flour= value },
                    {$"{keySections}Stacking",value => sections.Stacking= value },
                    {$"{keySections}Outload",value => sections.Outload= value },
                    {$"{keySections}Byproduct",value => sections.Byproduct= value },
                    {$"{keyBins}Silo",value => bins.Silo= value },
                    {$"{keyBins}RawWheat",value => bins.RawWheat= value },
                    {$"{keyBins}Screenings",value => bins.Screenings= value },
                    {$"{keyBins}Tempering",value => bins.Tempering= value },
                    {$"{keyBins}BaseFlour",value => bins.BaseFlour= value },
                    {$"{keyBins}Mixing",value => bins.Mixing= value },
                    {$"{keyBins}Bagging",value => bins.Bagging= value },
                    {$"{keyBins}Outload",value => bins.Outload= value },
                    {$"{keyBins}ByProduct",value => bins.ByProduct= value },
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
                MessageBox.Show(ex.ToString(), $"{AppGlobal.JS_BML} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static int StartRow { get; } = 7;
      
        public static class Motor
        {
            #region Fields for properties
            private static string bmlPath;
            private static string type;
            private static string columnName;
            private static string columnDesc;
            private static string columnPower;
            private static string columnFloor;
            private static string columnCabinet;
            private static string columnCabinetGroup;
            private static string columnMachine;
            private static string columnIORemark;
            private static string columnIsVFC;
            private static string columnLine;
            private static string prefixName;
            private static string nameDelimiter;
            //  private static string ioRemarkString;
            private static string prefixVFC;
            #endregion
            #region Properties
            public static string BMLPath
            {
                get { return bmlPath; }
                set { bmlPath = value; }
            }
            public static string ColumnIsVFC
            {
                get { return columnIsVFC; }
            }
            public static string ColumnName
            {
                get { return columnName; }
            }

            public static string ColumnDesc
            {
                get { return columnDesc; }
            }

            public static string ColumnPower
            {
                get { return columnPower; }
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
            public static string ColumnLine
            {
                get { return columnLine; }
            }
            public static string Type
            {
                get { return type; }
            }
            public static string PrefixName
            {
                get { return prefixName; }
                set { prefixName = value; }
            }
            public static string NameDelimiter
            {
                get { return nameDelimiter; }
                set { nameDelimiter = value; }
            }
            public static string PrefixVFC
            {
                get { return prefixVFC; }
                set { prefixVFC = value; }
            }
            public static string IORemarkString { get; }
            #endregion     
            static Motor()
            {
                string keyPath = $"{AppGlobal.JS_BML}.{AppGlobal.JS_MOTOR}.";
                string keyColums = $"{keyPath}{AppGlobal.JS_COLUMNS}.";
                string keyFilter = $"{keyPath}{AppGlobal.JS_FILTER}.";
                try
                {               
                    var keys = new Dictionary<string, Action<string>>
                    {
                        {$"{keyColums}Name",value => columnName= value },
                        {$"{keyColums}Desc", value => columnDesc= value },
                        {$"{keyColums}Power", value => columnPower = value },
                        {$"{keyColums}Floor", value => columnFloor = value },
                        {$"{keyColums}Cabinet", value => columnCabinet = value },
                        {$"{keyColums}CabinetGroup", value => columnCabinetGroup = value },
                        {$"{keyColums}Machine",value => columnMachine = value },
                        {$"{keyColums}IORemark",value => columnIORemark = value },
                        {$"{keyColums}IsVFC",value => columnIsVFC= value },
                        {$"{keyColums}Line",value => columnLine= value },
                        {$"{keyFilter}VFC",value => prefixVFC= value },
                        {$"{keyFilter}Motor",value => type= value },
                        {$"{keyPath}Path",value => bmlPath = value },
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
                    MessageBox.Show(ex.ToString(), $"{keyPath} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static class VFCAdapter
        {
            public static string BMLPath { get; set; }
            public static string Type { get; } = "Motor";
            public static string ColumnName { get; } = "变频名称";
            public static string ColumnDesc { get; } = "变频描述";
            public static string ColumnPower { get; } = "功率";
            public static string ColumnFloor { get; } = "楼层";
            public static string ColumnCabinet { get; } = "电柜号";
            public static string ColumnCabinetGroup { get; } = "电柜组";
            public static string ColumnControlMethod { get; } = "控制方式";
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
            public class VFCAdapterParameters
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
                public VFCAdapterParametersSet par = new VFCAdapterParametersSet();
                public VFCAdapterParametersSet Par
                {
                    get { return par; }
                    set { par = value; }
                }
                public VFCAdapterParameters()
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
                        if (name == TypeEnmu.ATV320)
                        {
                            par.LenPKW = "8";
                            par.LenPZD = "12";
                            par.LenPZDInp = "0";
                            par.UnitsPerDigits = "0.1";
                            par.SpeedMaxDigits = "500";
                            par.SpeedUnitsByMaxDigits = "100";
                            par.SpeedUnitsByZeroDigits = "0";
                            par.SpeedLimitMax = "100";
                            par.SpeedLimitMin = "0";
                            par.ParPZDConsistent = false;
                        }
                        else if (name == TypeEnmu.ATV930 || name == TypeEnmu.ATV61 || name == TypeEnmu.ATV71)
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
                        else if (name == TypeEnmu.NORD || name == TypeEnmu.MicroMaster || name == TypeEnmu.Sinamics || name == TypeEnmu.DanfossFC)
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
            #region Fields for properties
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
            private static string columnLine;
            private static string manualFlap;
            private static string pneFlap;
            private static string pneSlideGate;
            private static string manualSlideGate;
            private static string pneTwoWayValve;
            private static string pneShutOffValve;
            private static string pneAspValve;
            private static string ioRemarkString;
            private static string suffixVLS;
            private static string prefixName;
            private static string nameDelimiter;
            #endregion   
            private static string dirToBin;
            private static string dirToValve;
            private static string dirToFlap;
            private static string dirToHopper;
            private static string dirBypass;
            private static string dirSelect;
            private static string dirTo;
            private static string binOf;
            #region Properties
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
            public static string ColumnLine
            {
                get { return columnLine; }
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
            public static string PneAspValve
            {
                get { return pneAspValve; }
            }
            public static string PrefixName
            {
                get { return prefixName; }
                set { prefixName = value; }
            }
            public static string NameDelimiter
            {
                get { return nameDelimiter; }
                set { nameDelimiter = value; }
            }
            public static string SuffixVLS
            {
                get { return suffixVLS; }
                set { suffixVLS = value; }
            }
            public static string IORemarkString { get; }
            #endregion
            static VLS()
            {
                string keyPath = $"{AppGlobal.JS_BML}.{AppGlobal.JS_VLS}.";
                string keyColumns = $"{keyPath}{AppGlobal.JS_COLUMNS}.";
                string keyFilter= $"{keyPath}{AppGlobal.JS_FILTER}.";
                string keyIORemark = $"{keyPath}{AppGlobal.JS_IO_REMARK}.";
                string keyIOType = $"{keyPath}{AppGlobal.JS_IO_TYPE}.";
                try
                {
                  
                    string[] ioRemarks = new string[7];
                    var keys = new Dictionary<string, Action<string>>
                    {
                        {$"{keyColumns}Name",value => columnName= value },
                        {$"{keyColumns}Desc", value => columnDesc= value },
                        {$"{keyColumns}Floor", value => columnFloor = value },
                        {$"{keyColumns}Cabinet", value => columnCabinet = value },
                        {$"{keyColumns}CabinetGroup", value => columnCabinetGroup = value },
                        {$"{keyColumns}Machine",value => columnMachine = value },
                        {$"{keyColumns}IORemark",value => columnIORemark = value },
                        {$"{keyColumns}Line",value => columnLine= value },
                        {$"{keyFilter}ManualFlap",value => manualFlap= value },
                        {$"{keyFilter}PneFlap",value => pneFlap = value },
                        {$"{keyFilter}ManualSlideGate",value => manualSlideGate = value },
                        {$"{keyFilter}PneSlideGate",value => pneSlideGate= value },
                        {$"{keyFilter}PneTwoWayValve",value => pneTwoWayValve = value },
                        {$"{keyFilter}PneShutOffValve",value => pneShutOffValve = value },
                        {$"{keyFilter}PneAspValve",value => pneAspValve = value },
                        {$"{keyIOType}Output",value =>  typeOutput = value },
                        {$"{keyIOType}Input",value =>  typeInput = value },
                        {$"{keyIORemark}DirToBin",value => dirToBin= value },
                        {$"{keyIORemark}DirToValve",value => dirToValve = value },
                        {$"{keyIORemark}DirToFlap",value => dirToFlap= value },
                        {$"{keyIORemark}DirToHopper",value => dirToHopper = value },
                        {$"{keyIORemark}DirBypass",value =>  dirBypass = value },
                        {$"{keyIORemark}DirSelect",value =>  dirSelect = value },
                        {$"{keyIORemark}DirTo",value =>  dirTo = value },
                        {$"{keyIORemark}BinOf",value =>  binOf = value },
                        {$"{keyPath}Path",value => bmlPath = value },
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
                    ioRemarks[0] = dirToBin;
                    ioRemarks[1] = dirToValve;
                    ioRemarks[2] = dirToHopper;
                    ioRemarks[3] = dirBypass;
                    ioRemarks[4] = dirSelect;
                    ioRemarks[5] = dirTo;
                    ioRemarks[6] = binOf;
                    ioRemarkString = string.Join(", ", ioRemarks);
                    keyValueRead = null;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), $"{keyPath} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static string ParseIORemark(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return string.Empty;
                }
                else
                {
                    if (input.IndexOf(dirToBin, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return GcObjectInfo.Bin.BinPrefix + Regex.Replace(input, Regex.Escape(dirToBin), "", RegexOptions.IgnoreCase).Replace(" ", "");
                    }
                    else if (input.IndexOf(dirToValve, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        string nameString = Regex.Replace(input, Regex.Escape(dirToValve), "", RegexOptions.IgnoreCase).Replace(" ", "");
                        // nameString = (nameString.EndsWith(nameDelimiter) ? prefixName + nameString : prefixName + nameString + nameDelimiter) +suffixVLS;
                        nameString = (nameString.StartsWith(prefixName) ? nameString : prefixName + nameString);
                        nameString = (nameString.EndsWith(nameDelimiter) ? nameString : nameString + nameDelimiter) + suffixVLS;
                        return nameString;
                    }
                    else if (input.IndexOf(dirToFlap, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        string nameString = Regex.Replace(input, Regex.Escape(dirToFlap), "", RegexOptions.IgnoreCase).Replace(" ", "");
                        // nameString = (nameString.EndsWith(nameDelimiter) ? prefixName + nameString : prefixName + nameString + nameDelimiter) + suffixVLS;
                        nameString = (nameString.StartsWith(prefixName) ? nameString : prefixName + nameString);
                        nameString = (nameString.EndsWith(nameDelimiter) ? nameString : nameString + nameDelimiter) + suffixVLS;
                        return nameString;
                    }
                    else if (input.IndexOf(binOf, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return GcObjectInfo.Bin.BinPrefix + Regex.Replace(input, Regex.Escape(binOf), "", RegexOptions.IgnoreCase).Replace(" ", "");
                    }
                    else if (input.IndexOf(dirTo, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        string nameString = input;
                        nameString = StringHelper.ExtractStringPart($@"{Engineering.PatternNameWithoutTypeLL}(-[A-Za-z]{{3}}\\d{{1,3}})?", nameString);
                        nameString = string.IsNullOrEmpty(nameString) ? string.Empty : (nameString.StartsWith(prefixName) ? nameString : prefixName + nameString);
                        return nameString;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }

        }
        public static class DI
        {
            #region Fields for properties
            private static string bmlPath;
          //  private static string type;
            private static string columnName;
            private static string columnDesc;
            private static string columnFloor;
            private static string columnCabinet;
            private static string columnCabinetGroup;
            private static string columnDIType;
            private static string columnIORemark;
            private static string columnLine;
            private static string prefixName;
            private static string nameDelimiter;
            private static string beltMonitor;
            private static string emergencyStop;
            private static string explosion;
            private static string highLevel;
            private static string limitSwitch;
            private static string lowLevel;
            private static string middleLevel;
            private static string overflow;
            private static string pSw;
            private static string pushButton;
            private static string safetySwitch;
            private static string speedMonitor;
            private static string temperatureSwitch;
            private static string vibrationSwitch;
            private static string zeroSpeedMonitor;
            private static string binOf;
            #endregion
            #region Properties
            public static string BMLPath
            {
                get { return bmlPath; }
                set { bmlPath = value; }
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
            public static string ColumnDIType
            {
                get { return columnDIType; }
            }
            public static string ColumnIORemark
            {
                get { return columnIORemark; }
            }
            public static string ColumnLine
            {
                get { return columnLine; }
            }
            //public static string Type
            //{
            //    get { return type; }
            //}
            public static string PrefixName
            {
                get { return prefixName; }
                set { prefixName = value; }
            }
            public static string NameDelimiter
            {
                get { return nameDelimiter; }
                set { nameDelimiter = value; }
            }
            public static string IORemarkString { get; }
            public static string BeltMonitor
            {
                get { return beltMonitor; }
            }
            public static string EmergencyStop
            {
                get { return emergencyStop; }
            }
            public static string Explosion
            {
                get { return explosion; }
            }
            public static string HighLevel
            {
                get { return highLevel; }
            }
            public static string LimitSwitch
            {
                get { return limitSwitch; }
            }
            public static string LowLevel
            {
                get { return lowLevel; }
            }
            public static string MiddleLevel
            {
                get { return middleLevel; }
            }
            public static string Overflow
            {
                get { return overflow; }
            }
            public static string PSw
            {
                get { return pSw; }
            }
            public static string PushButton
            {
                get { return pushButton; }
            }
            public static string SafetySwitch
            {
                get { return safetySwitch; }
            }
            public static string SpeedMonitor
            {
                get { return speedMonitor; }
            }
            public static string TemperatureSwitch
            {
                get { return temperatureSwitch; }
            }
            public static string VibrationSwitch
            {
                get { return vibrationSwitch; }
            }
            public static string ZeroSpeedMonitor
            {
                get { return zeroSpeedMonitor; }
            }
            public static string BinOf
            {
                get { return binOf; }
            }
            #endregion
            static DI()
            {
                string keyPath = $"{AppGlobal.JS_BML}.{AppGlobal.JS_DI}.";
                string keyColumns = $"{keyPath}{AppGlobal.JS_COLUMNS}.";
                string keyFilter = $"{keyPath}{AppGlobal.JS_FILTER}.";
                string keyIORemark = $"{keyPath}{AppGlobal.JS_IO_REMARK}.";
                string keyIOType = $"{keyPath}{AppGlobal.JS_IO_TYPE}.";
                try
                {
                    string[] ioRemarks = new string[7];
                    var keys = new Dictionary<string, Action<string>>
                    {
                        {$"{keyColumns}Name",value => columnName= value },
                        {$"{keyColumns}Desc", value => columnDesc= value },
                        {$"{keyColumns}Floor", value => columnFloor = value },
                        {$"{keyColumns}Cabinet", value => columnCabinet = value },
                        {$"{keyColumns}CabinetGroup", value => columnCabinetGroup = value },
                        {$"{keyColumns}DIType",value => columnDIType = value },
                        {$"{keyColumns}IORemark",value => columnIORemark = value },
                        {$"{keyColumns}Line",value => columnLine= value },
                        {$"{keyFilter}BeltMonitor",value => beltMonitor= value },
                        {$"{keyFilter}EmergencyStopSwitch",value => emergencyStop = value },
                        {$"{keyFilter}Explosion",value => explosion = value },
                        {$"{keyFilter}HighLevel",value => highLevel= value },
                        {$"{keyFilter}LimitSwitch",value => limitSwitch = value },
                        {$"{keyFilter}LowLevel",value => lowLevel = value },
                        {$"{keyFilter}MiddleLevel",value => middleLevel = value },
                        {$"{keyFilter}Overflow",value => overflow = value },
                        {$"{keyFilter}PSW",value => pSw = value },
                        {$"{keyFilter}PushButton",value => pushButton = value },
                        {$"{keyFilter}SafetySwitch",value =>  safetySwitch = value },
                        {$"{keyFilter}SpeedMonitor",value =>  speedMonitor = value },
                        {$"{keyFilter}TemperatureSwitch",value =>  temperatureSwitch = value },
                        {$"{keyFilter}VibrationSwitch",value => vibrationSwitch = value },
                        {$"{keyFilter}ZeroSpeedMonitor",value => zeroSpeedMonitor = value },
                        {$"{keyIORemark}.BinOf",value => binOf = value },
                        {$"{keyPath}Path",value => bmlPath = value },
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
                    //   ioRemarkString = string.Join(", ", ioRemarks);
                    keyValueRead = null;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), $"{keyPath} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            public static string ParseIORemark(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    return string.Empty;
                }
                else
                {
                    if (input.IndexOf(binOf, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return GcObjectInfo.Bin.BinPrefix + Regex.Replace(input, Regex.Escape(binOf), "", RegexOptions.IgnoreCase).Replace(" ", "");
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
        }
        public static class MDDx
        {
            #region Fields for properties
            private static string bmlPath;
            private static string columnName;
            private static string columnDesc;
            private static string columnFloor;
            private static string columnCabinet;
            private static string columnCabinetGroup;
            private static string columnControlMethod;
            private static string columnLine;
            private static string filterMDDx;
            private static string filterMDDY;
            private static string filterKCL;
            #endregion

            #region Properties 
            public static string BMLPath
            {
                get { return bmlPath; }
                set { bmlPath = value; }
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

            public static string ColumnControlMethod
            {
                get { return columnControlMethod; }
            }

            public static string ColumnLine
            {
                get { return columnLine; }
            }
            public static string TypeMDDx
            {
                get { return filterMDDx; }
            }
            public static string TypeMDDY
            {
                get { return filterMDDY; }
            }
            public static string TypeKCL
            {
                get { return filterKCL; }
            }
            #endregion
            static MDDx()
            {
                string keyPath = $"{AppGlobal.JS_BML}.{AppGlobal.JS_MDDX}.";
                string keyColumns = $"{keyPath}{AppGlobal.JS_COLUMNS}.";
                string keyFilter = $"{keyPath}{AppGlobal.JS_FILTER}.";
                try
                {
              
                    var keys = new Dictionary<string, Action<string>>
                    {
                        {$"{keyColumns}Name",value => columnName= value },
                        {$"{keyColumns}Desc", value => columnDesc= value },
                        {$"{keyColumns}Floor", value => columnFloor = value },
                        {$"{keyColumns}Cabinet", value => columnCabinet = value },
                        {$"{keyColumns}CabinetGroup", value => columnCabinetGroup = value },
                        {$"{keyColumns}ControlMethod",value => columnControlMethod = value },
                        {$"{keyColumns}Line",value => columnLine= value },
                        {$"{keyFilter}MDDx",value => filterMDDx = value },
                        {$"{keyFilter}MDDY",value => filterMDDY = value },
                        {$"{keyFilter}KCL",value => filterKCL = value },
                        {$"{keyPath}Path",value => bmlPath = value },
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
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), $"{keyPath} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }         
        }
        public static class AI
        {
            #region Fields for properties
            private static string bmlPath;
            private static string columnName;
            private static string columnDesc;
            public static string columnPower;
            private static string columnFloor;
            private static string columnCabinet;
            private static string columnCabinetGroup;
            private static string columnLine;
            //private static string filterMotor;
            //private static string filterRollerMill;
            #endregion

            #region Properties 
            public static string BMLPath
            {
                get { return bmlPath; }
                set { bmlPath = value; }
            }
            public static string ColumnName
            {
                get { return columnName; }
            }

            public static string ColumnDesc
            {
                get { return columnDesc; }
            }
            public static string ColumnPower
            {
                get { return columnPower; }
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

            public static string ColumnLine
            {
                get { return columnLine; }
            }
            //public static string TypeMotor
            //{
            //    get { return filterMotor; }
            //}
            //public static string TypeRollerMill
            //{
            //    get { return filterRollerMill; }
            //}
            #endregion
            static AI()
            {
                string keyPath = $"{AppGlobal.JS_BML}.{AppGlobal.JS_AI}.";
                string keyColumns = $"{keyPath}{AppGlobal.JS_COLUMNS}.";
                string keyFilter = $"{keyPath}{AppGlobal.JS_FILTER}.";
                try
                {
                    var keys = new Dictionary<string, Action<string>>
                    {
                        {$"{keyColumns}Name",value => columnName= value },
                        {$"{keyColumns}Desc", value => columnDesc= value },
                        {$"{keyColumns}Power", value => columnPower= value },
                        {$"{keyColumns}Floor", value => columnFloor = value },
                        {$"{keyColumns}Cabinet", value => columnCabinet = value },
                        {$"{keyColumns}CabinetGroup", value => columnCabinetGroup = value },
                        {$"{keyColumns}Line",value => columnLine= value },
                        {$"{keyPath}Path",value => bmlPath = value },
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
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), $"{keyPath} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static class Roll8Stand
        {
            #region Fields for properties
            private static string bmlPath;
            private static string columnName;
            private static string columnDesc;
            public static string  columnType;
            private static string columnFloor;
            private static string columnLine;
            private static string filterMDDx;
            #endregion

            #region Properties 
            public static string BMLPath
            {
                get { return bmlPath; }
                set { bmlPath = value; }
            }
            public static string ColumnName
            {
                get { return columnName; }
            }

            public static string ColumnDesc
            {
                get { return columnDesc; }
            }
            public static string ColumnType
            {
                get { return columnType; }
            }

            public static string ColumnFloor
            {
                get { return columnFloor; }
            }
            public static string ColumnLine
            {
                get { return columnLine; }
            }
            public static string TypeMDDx
            {
                get { return filterMDDx; }
            }

            #endregion
            static Roll8Stand()
            {
                string keyPath = $"{AppGlobal.JS_BML}.{AppGlobal.JS_ROLL8STAND}.";
                string keyColumns = $"{keyPath}{AppGlobal.JS_COLUMNS}.";
                string keyFilter = $"{keyPath}{AppGlobal.JS_FILTER}.";
                try
                {
                    var keys = new Dictionary<string, Action<string>>
                    {
                        {$"{keyColumns}Name",value => columnName= value },
                        {$"{keyColumns}Desc", value => columnDesc= value },
                        {$"{keyColumns}Type", value => columnType= value },
                        {$"{keyColumns}Floor", value => columnFloor = value },
                        {$"{keyColumns}Line",value => columnLine= value },
                        {$"{keyFilter}MDDx",value => filterMDDx= value },
                        {$"{keyPath}Path",value => bmlPath = value },
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
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), $"{keyPath} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
