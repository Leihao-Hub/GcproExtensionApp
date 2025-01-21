using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro.GCObject;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static GcproExtensionLibrary.Gcpro.GCObject.Roll8Stand;
namespace GcproExtensionApp
{
    public static class GcObjectInfo
    {
        public class General
        {
            public class IOSuffix
            {
                public string DI, DO, AI, AO, Delimiter;
            }
            private static IOSuffix suffixIO = new IOSuffix();
            private static string delimiterSymbol;
            private static string prefixName;
            //   private static string prefixLocalPanel;
            private static string commonSection;
            private static string preCleaningSection;
            private static string cleaningSection;
            private static string screeningsSection;
            private static string millingSection;
            private static string flourSection;
            private static string stackingSection;
            private static string outloadSection;
            private static string byproductSection;
            private static string addInfoSymbol;
            private static string addInfoCabinet;
            private static string addInfoElevation;
            private static string addInfoPower;
            #region Properties
            public static string DelimiterSymbol
            {
                get { return delimiterSymbol; }
                set { delimiterSymbol = value; }
            }
            public static string PrefixName
            {
                get { return prefixName; }
                set { prefixName = value; }
            }
            public static IOSuffix SuffixIO
            {
                get { return suffixIO; }
                set { suffixIO = value; }
            }

            public static string CommonSection
            {
                get { return commonSection; }
                set { commonSection = value; }
            }

            public static string PreCleaningSection
            {
                get { return preCleaningSection; }
                set { preCleaningSection = value; }
            }

            public static string CleaningSection
            {
                get { return cleaningSection; }
                set { cleaningSection = value; }
            }
            public static string ScreeningsSection
            {
                get { return screeningsSection; }
                set { screeningsSection = value; }
            }

            public static string MillingSection
            {
                get { return millingSection; }
                set { millingSection = value; }
            }

            public static string FlourSection
            {
                get { return flourSection; }
                set { flourSection = value; }
            }

            public static string StackingSection
            {
                get { return stackingSection; }
                set { stackingSection = value; }
            }

            public static string OutloadSection
            {
                get { return outloadSection; }
                set { outloadSection = value; }
            }

            public static string ByproductSection
            {
                get { return byproductSection; }
                set { byproductSection = value; }
            }
            public static string AddInfoSymbol
            {
                get { return addInfoSymbol; }
                set { addInfoSymbol = value; }
            }
            public static string AddInfoCabinet
            {
                get { return addInfoCabinet; }
                set { addInfoCabinet = value; }
            }
            public static string AddInfoElevation
            {
                get { return addInfoElevation; }
                set { addInfoElevation = value; }
            }
            public static string AddInfoPower
            {
                get { return addInfoPower; }
                set { addInfoPower = value; }
            }
            #endregion
            static General()
            {
                string keyGeneral = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_GENERAL}.";
                string keyPrefix = $"{keyGeneral}{AppGlobal.JS_PREFIX}.";
                string keySuffix = $"{keyGeneral}{AppGlobal.JS_SUFFIX}.";
                string keySuffixIO = $"{keySuffix}{AppGlobal.JS_IO}.";
                string keyDelimiter = $"{keyGeneral}{AppGlobal.JS_DELIMITER}.";
                string NameNumberRule = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_NAME_NUMBER_RULE}.";
                string NameNumberRuleSec = $"{NameNumberRule}{AppGlobal.JS_SECTION}.";
                string keyAddInfoToDesc = $"{keyGeneral}{AppGlobal.JS_ADDINFO_TO_DESC}.";
                try
                {

                    var keys = new Dictionary<string, Action<string>>
                        {
                            { $"{keyPrefix}Name",value => prefixName= value },
                            { $"{keyDelimiter}Symbol", value => delimiterSymbol= value },
                            { $"{keySuffixIO}DI", value => suffixIO.DI = value },
                            { $"{keySuffixIO}DO", value => suffixIO.DO = value },
                            { $"{keySuffixIO}AI", value => suffixIO.AI = value },
                            { $"{keySuffixIO}AO", value => suffixIO.AO = value },
                            { $"{keySuffixIO}{AppGlobal.JS_DELIMITER}", value => suffixIO.Delimiter = value },
                            { $"{NameNumberRuleSec}Common",value => commonSection= value },
                            { $"{NameNumberRuleSec}PreCleaning",value => preCleaningSection= value },
                            { $"{NameNumberRuleSec}Cleaning",value => cleaningSection= value },
                            { $"{NameNumberRuleSec}Screenings",value => screeningsSection= value },
                            { $"{NameNumberRuleSec}Milling",value => millingSection= value },
                            { $"{NameNumberRuleSec}Flour",value => flourSection= value },
                            { $"{NameNumberRuleSec}Stacking",value => stackingSection= value },
                            { $"{NameNumberRuleSec}Outload",value => outloadSection= value },
                            { $"{NameNumberRuleSec}Byproduct",value => byproductSection= value },
                            { $"{keyAddInfoToDesc}Symbol",value => addInfoSymbol= value },
                            { $"{keyAddInfoToDesc}Cabinet",value => addInfoCabinet= value },
                            { $"{keyAddInfoToDesc}Elevation",value => addInfoElevation= value },
                            { $"{keyAddInfoToDesc}Power",value => addInfoPower= value },
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
                    MessageBox.Show(ex.ToString(), $"{keyGeneral} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static class Section
        {
            private static AppGlobal.Range commonSection = new AppGlobal.Range(9001, 9999);
            private static AppGlobal.Range preCleaningSection = new AppGlobal.Range(1001, 1999);
            private static AppGlobal.Range cleaningSection = new AppGlobal.Range(2001, 2999);
            private static AppGlobal.Range screeningsSection = new AppGlobal.Range(3001, 3999);
            private static AppGlobal.Range millingSection = new AppGlobal.Range(4001, 4999);
            private static AppGlobal.Range flourSection = new AppGlobal.Range(6001, 6800);
            private static AppGlobal.Range stackingSection = new AppGlobal.Range(6801, 6999);
            private static AppGlobal.Range outloadSection = new AppGlobal.Range(7001, 7999);
            private static AppGlobal.Range byproductSection = new AppGlobal.Range(8001, 8999);
            private readonly static Sections sections = new Sections();
            #region Properties
            public static AppGlobal.Range CommonSection
            {
                get { return commonSection; }
                set { commonSection = value; }
            }
            public static AppGlobal.Range PreCleaningSection
            {
                get { return preCleaningSection; }
                set { preCleaningSection = value; }
            }

            public static AppGlobal.Range CleaningSection
            {
                get { return cleaningSection; }
                set { cleaningSection = value; }
            }

            public static AppGlobal.Range ScreeningsSection
            {
                get { return screeningsSection; }
                set { screeningsSection = value; }
            }

            public static AppGlobal.Range MillingSection
            {
                get { return millingSection; }
                set { millingSection = value; }
            }

            public static AppGlobal.Range FlourSection
            {
                get { return flourSection; }
                set { flourSection = value; }
            }

            public static AppGlobal.Range StackingSection
            {
                get { return stackingSection; }
                set { stackingSection = value; }
            }

            public static AppGlobal.Range OutloadSection
            {
                get { return outloadSection; }
                set { outloadSection = value; }
            }

            public static AppGlobal.Range ByproductSection
            {
                get { return byproductSection; }
                set { byproductSection = value; }
            }
            #endregion

            private static Dictionary<string, Action<string>> GetKeyValueDictionary()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_GENERAL}.{AppGlobal.JS_NAME_NUMBER_RULE}.{AppGlobal.JS_SECTION}.";
                return new Dictionary<string, Action<string>>
                {
                    { $"{keyPath}Common", value => sections.Common = value },
                    { $"{keyPath}PreCleaning", value => sections.PreCleaning = value },
                    { $"{keyPath}Cleaning", value => sections.Cleaning= value },
                    { $"{keyPath}Screenings", value => sections.Screenings= value },
                    { $"{keyPath}Milling", value => sections.Milling = value },
                    { $"{keyPath}Flour", value => sections.Flour = value },
                    { $"{keyPath}Stacking", value => sections.Stacking = value },
                    { $"{keyPath}Outload", value => sections.Outload = value },
                    { $"{keyPath}Byproduct", value => sections.Byproduct = value }
                };
            }
            private static void ParseAllRanges()
            {
                commonSection.ParseRange(sections.Common);
                preCleaningSection.ParseRange(sections.PreCleaning);
                cleaningSection.ParseRange(sections.Cleaning);
                screeningsSection.ParseRange(sections.Screenings);
                millingSection.ParseRange(sections.Milling);
                flourSection.ParseRange(sections.Flour);
                stackingSection.ParseRange(sections.Stacking);
                outloadSection.ParseRange(sections.Outload);
                byproductSection.ParseRange(sections.Byproduct);
            }
            static Section()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_GENERAL}.{AppGlobal.JS_NAME_NUMBER_RULE}.{AppGlobal.JS_SECTION}.";
                try
                {
                    var keySections = GetKeyValueDictionary();
                    Dictionary<string, string> keyValueRead = LibGlobalSource.JsonHelper.ReadKeyValues(AppGlobal.JSON_FILE_PATH, keySections.Keys.ToArray());
                    foreach (var key in keySections)
                    {
                        if (keyValueRead.TryGetValue(key.Key, out var value))
                        {
                            key.Value(value);
                        }
                    }
                    ParseAllRanges();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), $"{keyPath} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            private static readonly Dictionary<AppGlobal.Range, string> RangeToSectionMap = new Dictionary<AppGlobal.Range, string>
            {
                { commonSection, BML.Sections.Common },
                { preCleaningSection, BML.Sections.PreCleaning },
                { cleaningSection, BML.Sections.Cleaning },
                { screeningsSection, BML.Sections.Screenings },
                { millingSection, BML.Sections.Milling },
                { flourSection, BML.Sections.Flour },
                { stackingSection, BML.Sections.Stacking},
                { outloadSection, BML.Sections.Outload},
                { byproductSection, BML.Sections.Byproduct },
            };
            /// <summary>
            /// 根据设备名称，返回所属的工段名称
            /// </summary>
            /// <param name="NameNumber">设备名称包含的数字</param>
            public static string ReturnSection(int nameNumber)
            {
                foreach (var entry in RangeToSectionMap)
                {
                    if (entry.Key.IsInRange(nameNumber))
                    {
                        return entry.Value;
                    }
                }
                return string.Empty;
            }
        }

        public class Bin
        {
            private static string binPrefix;
            private static string identDescSeparator;
            private readonly static AppGlobal.Range silo = new AppGlobal.Range(001, 199);
            private readonly static AppGlobal.Range rawWheatBin = new AppGlobal.Range(201, 259);
            private readonly static AppGlobal.Range temperingBin = new AppGlobal.Range(260, 299);
            private readonly static AppGlobal.Range screeningsBin = new AppGlobal.Range(301, 399);
            private readonly static AppGlobal.Range baseFlourBin = new AppGlobal.Range(401, 499);
            private readonly static AppGlobal.Range mixingBin = new AppGlobal.Range(501, 599);
            private readonly static AppGlobal.Range baggingBin = new AppGlobal.Range(601, 699);
            private readonly static AppGlobal.Range outloadBin = new AppGlobal.Range(701, 799);
            private readonly static AppGlobal.Range byproductBin = new AppGlobal.Range(801, 899);
            private static Bins bins = new Bins();
            public static string BinPrefix
            {
                get { return binPrefix; }
                set { binPrefix = value; }
            }
            public static string IdentDescSeparator
            {
                get { return identDescSeparator; }
                set { identDescSeparator = value; }
            }
            public static Bins Bins
            {
                get { return bins; }
                set { bins = value; }
            }
            private static Dictionary<string, Action<string>> GetKeyValueDictionary()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_BIN}.";
                string keySeparator = $"{keyPath}{AppGlobal.JS_IDENT_DESC_SEPARATOR}.";
                string keyPathNameNumberRule = $"{keyPath}{AppGlobal.JS_NAME_NUMBER_RULE}.";
                return new Dictionary<string, Action<string>>
                    {
                        {$"{keyPath}Prefix",value => binPrefix= value },
                        {$"{keyPath}IdentDescSeparator",value => identDescSeparator= value },
                        {$"{keyPathNameNumberRule}Silo",value => bins.Silo= value },
                        {$"{keyPathNameNumberRule}RawWheat",value => bins.RawWheat= value },
                        {$"{keyPathNameNumberRule}Tempering",value => bins.Tempering= value },
                        {$"{keyPathNameNumberRule}Screenings",value => bins.Screenings = value },
                        {$"{keyPathNameNumberRule}BaseFlour",value => bins.BaseFlour= value },
                        {$"{keyPathNameNumberRule}Mixing",value => bins.Mixing= value },
                        {$"{keyPathNameNumberRule}Bagging",value => bins.Bagging= value },
                        {$"{keyPathNameNumberRule}Outload",value => bins.Outload= value },
                        {$"{keyPathNameNumberRule}ByProduct",value => bins.ByProduct= value },
                    };
            }
            private static void ParseAllRanges()
            {
                silo.ParseRange(bins.Silo);
                rawWheatBin.ParseRange(bins.RawWheat);
                temperingBin.ParseRange(bins.Tempering);
                screeningsBin.ParseRange(bins.Screenings);
                baseFlourBin.ParseRange(bins.BaseFlour);
                mixingBin.ParseRange(bins.Mixing);
                baggingBin.ParseRange(bins.Bagging);
                outloadBin.ParseRange(bins.Outload);
                byproductBin.ParseRange(bins.ByProduct);
            }
            static Bin()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_BIN}.";
                try
                {
                    var keys = GetKeyValueDictionary();
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
                    ParseAllRanges();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), $"{keyPath} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            private static readonly Dictionary<AppGlobal.Range, string> RangeToSectionMap = new Dictionary<AppGlobal.Range, string>
            {
                { silo, BML.Bins.Silo },
                { rawWheatBin, BML.Bins.RawWheat },
                { temperingBin, BML.Bins.Tempering },
                { screeningsBin, BML.Bins.Screenings },
                { baseFlourBin, BML.Bins.BaseFlour },
                { mixingBin, BML.Bins.Mixing },
                { baggingBin, BML.Bins.Bagging},
                { outloadBin, BML. Bins.Outload},
                { byproductBin, BML.Bins.ByProduct },
            };
            /// <summary>
            /// 根据设备名称，返回所属的工段名称
            /// </summary>
            /// <param name="NameNumber">设备名称包含的数字</param>
            public static string ReturnBin(int nameNumber)
            {
                foreach (var entry in RangeToSectionMap)
                {
                    if (entry.Key.IsInRange(nameNumber))
                    {
                        return entry.Value;
                    }
                }
                return string.Empty;
            }

        }
        public static class VLS
        {
            public struct SimpleInfo
            {
                public string Name;
                public bool IsMotorValve;
                public byte Count;
                public byte CountInp;
                public byte CountOutp;
                public SimpleInfo(string name, bool isMotorValve, byte count, byte countInp, byte countOutp)
                {
                    Name = name;
                    IsMotorValve = isMotorValve;
                    Count = count;
                    CountInp = countInp;
                    CountOutp = countOutp;
                }
            }
            private static string suffixVLS;
            private static string suffixVLSPattern;
            private static string suffixInpLN;
            private static string suffixInpHN;
            private static string suffixOutpLN;
            private static string suffixOutpHN;
            private static string suffixOutpRunRev;
            private static string suffixOutpRunFwd;
            private static string suffixInpRunRev;
            private static string suffixInpRunFwd;
            private static string suffixInpPattern;
            private static string suffixOutpPattern;
            private static string suffixInpRunPattern;
            private static string suffixOutpRunPattern;
            private static string prefixName;
            private static string nameDelimiter;
            #region Properties
            public static string SuffixVLS
            {
                get { return suffixVLS; }
                set { suffixVLS = value; }
            }
            public static string SuffixVLSPattern
            {
                get { return suffixVLSPattern; }
                set { suffixVLSPattern = value; }
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
            public static string SuffixOutpRunRev
            {
                get { return suffixOutpRunRev; }
                set { suffixOutpRunRev = value; }
            }
            public static string SuffixOutpRunFwd
            {
                get { return suffixOutpRunFwd; }
                set { suffixOutpRunFwd = value; }
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
            public static string SuffixInpPattern
            {
                get { return suffixInpPattern; }
                set { suffixInpPattern = value; }
            }
            public static string SuffixOutpPattern
            {
                get { return suffixOutpPattern; }
                set { suffixOutpPattern = value; }
            }
            public static string SuffixInpRunPattern
            {
                get { return suffixInpRunPattern; }
                set { suffixInpRunPattern = value; }
            }
            public static string SuffixOutpRunPattern
            {
                get { return suffixOutpRunPattern; }
                set { suffixOutpRunPattern = value; }
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
            #endregion Properties
            static VLS()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_VLS}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}VLS", value => suffixVLS = value },
                        { $"{keyPathSuffix}VLSPattern", value => suffixVLSPattern = value },
                        { $"{keyPathSuffix}InpLN", value => suffixInpLN = value },
                        { $"{keyPathSuffix}OutpLN", value => suffixOutpLN = value },
                        { $"{keyPathSuffix}InpHN", value => suffixInpHN = value },
                        { $"{keyPathSuffix}OutpHN", value => suffixOutpHN = value },
                        { $"{keyPathSuffix}InpRunRev", value => suffixInpRunRev = value },
                        { $"{keyPathSuffix}OutpRunRev", value => suffixOutpRunRev = value },
                        { $"{keyPathSuffix}InpRunFwd", value => suffixInpRunFwd = value },
                        { $"{keyPathSuffix}OutpRunFwd", value => suffixOutpRunFwd = value },
                        { $"{keyPathSuffix}InpPattern", value => suffixInpPattern= value },
                        { $"{keyPathSuffix}OutpPattern", value => suffixOutpPattern = value },
                        { $"{keyPathSuffix}InpRunPattern", value => suffixInpRunPattern = value },
                        { $"{keyPathSuffix}OutpRunPattern", value => suffixOutpRunPattern = value },
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
                    MessageBox.Show(ex.ToString(), "GcObjectInfo.VLS Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static class Motor
        {
            public struct SimpleInfo
            {
                public string Name;
                public bool IsVFC;
                public byte Count;
                public SimpleInfo(string name, bool isVFC, byte count)
                {
                    Name = name;
                    IsVFC = isVFC;
                    Count = count;
                }
            }
            #region Fields for properties
            private static string suffixMotor;
            private static string suffixInpRunFwd;
            private static string suffixOutpRunFwd;
            private static string suffixInpRunRev;
            private static string suffixOutpRunRev;
            private static string suffixVFC;
            private static string suffixPowerApp;
            private static string suffixAO;
            #endregion
            #region Properties
            public static string SuffixMotor
            {
                get { return suffixMotor; }
                set { suffixMotor = value; }
            }
            public static string SuffixInpRunFwd
            {
                get { return suffixInpRunFwd; }
                set { suffixInpRunFwd = value; }
            }
            public static string SuffixInpRunRev
            {
                get { return suffixInpRunRev; }
                set { suffixInpRunRev = value; }
            }
            public static string SuffixOutpRunFwd
            {
                get { return suffixOutpRunFwd; }
                set { suffixOutpRunFwd = value; }
            }
            public static string SuffixOutpRunRev
            {
                get { return suffixOutpRunRev; }
                set { suffixOutpRunRev = value; }
            }
            public static string SuffixVFC
            {
                get { return suffixVFC; }
                set { suffixVFC = value; }
            }
            public static string SuffixPowerApp
            {
                get { return suffixPowerApp; }
                set { suffixPowerApp = value; }
            }
            public static string SuffixAO
            {
                get { return suffixAO; }
                set { suffixAO = value; }
            }
            #endregion
            static Motor()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_MOTOR}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}Motor", value => suffixMotor = value },
                        { $"{keyPathSuffix}InpRunFwd", value => suffixInpRunFwd= value },
                        { $"{keyPathSuffix}OutpRunFwd", value => suffixOutpRunFwd = value },
                        { $"{keyPathSuffix}InpRunRev", value => suffixInpRunRev = value },
                        { $"{keyPathSuffix}OutpRunRev", value => suffixOutpRunRev = value },
                        { $"{keyPathSuffix}VFC", value => suffixVFC = value },
                        { $"{keyPathSuffix}PowerApp", value => suffixPowerApp = value },
                        { $"{keyPathSuffix}AO", value => suffixAO= value },
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
        public static class DI
        {
            private static string suffixInpTrue;
            private static string suffixInpFaultDev;
            private static string suffixOutpFaultReset;
            private static string suffixOutpPowerOff;
            private static string suffixOutpLamp;
            #region Properties
            public static string SuffixInpTrue
            {
                get { return suffixInpTrue; }
                set { suffixInpTrue = value; }
            }
            public static string SuffixInpFaultDev
            {
                get { return suffixInpFaultDev; }
                set { suffixInpFaultDev = value; }
            }
            public static string SuffixOutpFaultReset
            {
                get { return suffixOutpFaultReset; }
                set { suffixOutpFaultReset = value; }
            }

            public static string SuffixOutpPowerOff
            {
                get { return suffixOutpPowerOff; }
                set { suffixOutpPowerOff = value; }
            }

            public static string SuffixOutpLamp
            {
                get { return suffixOutpLamp; }
                set { suffixOutpLamp = value; }
            }
            #endregion Properties
            static DI()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_DI}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}InpTrue", value => suffixInpTrue = value },
                        { $"{keyPathSuffix}InpFaultDev", value => suffixInpFaultDev = value },
                        { $"{keyPathSuffix}OutpFaultReset", value => suffixOutpFaultReset = value },
                        { $"{keyPathSuffix}OutpPowerOff", value => suffixOutpPowerOff = value },
                        { $"{keyPathSuffix}OutpLamp", value => suffixOutpLamp = value },
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
        public static class DO
        {
            private static string suffixInpRun;
            private static string suffixInpFaultDev;
            private static string suffixInpAlarmReset;
            private static string suffixOutpFaultReset;
            private static string suffixOutpRun;
            private static string suffixOutpLamp;
            private static string suffixOutpFinalClearing;
            #region Properties
            public static string SuffixInpRun
            {
                get { return suffixInpRun; }
                set { suffixInpRun = value; }
            }
            public static string SuffixInpFaultDev
            {
                get { return suffixInpFaultDev; }
                set { suffixInpFaultDev = value; }
            }
            public static string SuffixInpAlarmReset
            {
                get { return suffixInpAlarmReset; }
                set { suffixInpAlarmReset = value; }
            }
            public static string SuffixOutpFaultReset
            {
                get { return suffixOutpFaultReset; }
                set { suffixOutpFaultReset = value; }
            }          
            public static string SuffixOutpRun
            {
                get { return suffixOutpRun; }
                set { suffixOutpRun = value; }
            }

            public static string SuffixOutpLamp
            {
                get { return suffixOutpLamp; }
                set { suffixOutpLamp = value; }
            }
            public static string SuffixOutpFinalClearing
            {
                get { return suffixOutpFinalClearing; }
                set { suffixOutpFinalClearing = value; }
            }
            #endregion Properties
            static DO()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_DO}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}InpRun", value => suffixInpRun = value },
                        { $"{keyPathSuffix}InpFaultDev", value => suffixInpFaultDev = value },
                        { $"{keyPathSuffix}InpAlarmReset", value => suffixInpAlarmReset = value },
                        { $"{keyPathSuffix}OutpFaultReset", value => suffixOutpFaultReset = value },
                        { $"{keyPathSuffix}OutpRun", value => suffixOutpRun = value },
                        { $"{keyPathSuffix}OutpLamp", value => suffixOutpLamp = value },
                        { $"{keyPathSuffix}OutpFinalClearing", value => suffixOutpFinalClearing = value },
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
        public static class AI
        {
            private static string suffixName;
            private static string suffixInpValue;
            private static string suffixInpFaultDev;
            private static string suffixInpLowLow;
            private static string suffixInpLow;
            private static string suffixInpHigh;
            private static string suffixInpHighHigh;
            private static string suffixTemperature;
            private static string suffixPressure;
            private static string suffixCurrent;
            private static string suffixDescTemperature;
            private static string suffixDescPressure;
            private static string suffixDescCurrent;
      
            #region Propeeties
            public static string SuffixName
            {
                get { return suffixName; }
                set { suffixName = value; }
            }
            public static string SuffixInpValue
            {
                get { return suffixInpValue; }
                set { suffixInpValue = value; }
            }
            public static string SuffixInpFaultDev
            {
                get { return suffixInpFaultDev; }
                set { suffixInpFaultDev = value; }
            }
            public static string SuffixInpLowLow
            {
                get { return suffixInpLowLow; }
                set { suffixInpLowLow = value; }
            }

            public static string SuffixInpLow
            {
                get { return suffixInpLow; }
                set { suffixInpLowLow = value; }
            }

            public static string SuffixInpHigh
            {
                get { return suffixInpHigh; }
                set { suffixInpHigh = value; }
            }
            public static string SuffixInpHighHigh
            {
                get { return suffixInpHighHigh; }
                set { suffixInpHighHigh = value; }
            }
            public static string SuffixTemperature
            {
                get { return suffixTemperature; }
                set { suffixTemperature = value; }
            }
            public static string SuffixPressure
            {
                get { return suffixPressure; }
                set { suffixPressure = value; }
            }
            public static string SuffixCurrent
            {
                get { return suffixCurrent; }
                set { suffixCurrent = value; }
            }
            public static string SuffixDescCurrent
            {
                get { return suffixDescCurrent; }
                set { suffixDescCurrent = value; }
            }
            public static string SuffixDescTemperature
            {
                get { return suffixDescTemperature; }
                set { suffixDescTemperature = value; }
            }
            public static string SuffixDescPressure
            {
                get { return suffixDescPressure; }
                set { suffixDescPressure = value; }
            }
            #endregion Propeeties
            static AI()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_AI}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}AI", value => suffixName = value },
                        { $"{keyPathSuffix}InpValue", value => suffixInpValue = value },
                        { $"{keyPathSuffix}InpFaultDev", value => suffixInpFaultDev = value },
                        { $"{keyPathSuffix}InpLowLow", value => suffixInpLowLow = value },
                        { $"{keyPathSuffix}InpLow", value => suffixInpLow = value },
                        { $"{keyPathSuffix}InpHigh", value => suffixInpHigh = value },
                        { $"{keyPathSuffix}InpHighHigh", value => suffixInpHighHigh = value },
                        { $"{keyPathSuffix}Temperature", value => suffixTemperature = value },
                        { $"{keyPathSuffix}Pressure", value => suffixPressure = value },
                        { $"{keyPathSuffix}Current", value => suffixCurrent = value },
                        { $"{keyPathSuffix}DescTemperature", value => suffixDescTemperature = value },
                        { $"{keyPathSuffix}DescPressure", value => suffixDescPressure = value },
                        { $"{keyPathSuffix}DescCurrent", value => suffixDescCurrent = value },
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
        public static class MDDx
        {
            private static string suffixMDDx;
            public static string SuffixMDDx
            {
                get { return suffixMDDx; }
            }
            static MDDx()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_MDDX}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {

                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}MDDx", value => suffixMDDx = value },
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
        public static class MA_Roll8Stand
        {
            private static string suffixMDDx;
            private static string suffixCurrent;
            private static RollermillSide suffixSide1;
            private static RollermillSide suffixSide2;
            public static string SuffixMDDx
            {
                get { return suffixMDDx; }
                set { suffixMDDx = value; }
            }
            public static string SuffixCurrent
            {
                get { return suffixCurrent; }
                set { suffixCurrent = value; }
            }
            public static RollermillSide SiffixSide1
            {
                get { return suffixSide1; }
                set { suffixSide1 = value; }
            }
            public static RollermillSide SiffixSide2
            {
                get { return suffixSide2; }
                set { suffixSide2 = value; }
            }
            static MA_Roll8Stand()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_ROLL8STAND}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {
                    suffixSide1 = new RollermillSide();
                    suffixSide2 = new RollermillSide();

                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}MDDx", value => suffixMDDx = value },
                        { $"{keyPathSuffix}Current", value => suffixCurrent = value },
                        { $"{keyPathSuffix}Side1.MotorLow", value => suffixSide1.MotorLow = value },
                        { $"{keyPathSuffix}Side1.MotorUp", value => suffixSide1.MotorUp = value },
                        { $"{keyPathSuffix}Side1.HLBackupLeft", value => suffixSide1.HLBackupLeft = value },
                        { $"{keyPathSuffix}Side1.HLBackupRight", value => suffixSide1.HLBackupRight = value },
                        { $"{keyPathSuffix}Side1.HLInlet", value => suffixSide1.HLInlet = value },
                        { $"{keyPathSuffix}Side1.DivHLInlet", value => suffixSide1.DivHLInlet = value },
                        { $"{keyPathSuffix}Side1.SM1", value => suffixSide1.SM1 = value },
                        { $"{keyPathSuffix}Side1.InpPressure", value => suffixSide1.InpPressure = value },
                        { $"{keyPathSuffix}Side1.FeedRoll", value => suffixSide1.FeedRoll = value },
                        { $"{keyPathSuffix}Side1.DivFeedRoll", value => suffixSide1.DivFeedRoll = value },
                        { $"{keyPathSuffix}Side1.HLOutlet1", value => suffixSide1.HLOutlet1 = value },
                        { $"{keyPathSuffix}Side1.HLOutlet2", value => suffixSide1.HLOutlet2 = value },
                        { $"{keyPathSuffix}Side1.HLOutlet3", value => suffixSide1.HLOutlet3 = value },
                        { $"{keyPathSuffix}Side2.MotorLow", value => suffixSide2.MotorLow = value },
                        { $"{keyPathSuffix}Side2.MotorUp", value => suffixSide2.MotorUp = value },
                        { $"{keyPathSuffix}Side2.HLBackupLeft", value => suffixSide2.HLBackupLeft = value },
                        { $"{keyPathSuffix}Side2.HLBackupRight", value => suffixSide2.HLBackupRight = value },
                        { $"{keyPathSuffix}Side2.HLInlet", value => suffixSide2.HLInlet = value },
                        { $"{keyPathSuffix}Side2.DivHLInlet", value => suffixSide2.DivHLInlet = value },
                        { $"{keyPathSuffix}Side2.SM1", value => suffixSide2.SM1 = value },
                        { $"{keyPathSuffix}Side2.InpPressure", value => suffixSide2.InpPressure = value },
                        { $"{keyPathSuffix}Side2.FeedRoll", value => suffixSide2.FeedRoll = value },
                        { $"{keyPathSuffix}Side2.DivFeedRoll", value => suffixSide2.DivFeedRoll = value },
                        { $"{keyPathSuffix}Side2.HLOutlet1", value => suffixSide2.HLOutlet1 = value },
                        { $"{keyPathSuffix}Side2.HLOutlet2", value => suffixSide2.HLOutlet2 = value },
                        { $"{keyPathSuffix}Side2.HLOutlet3", value => suffixSide2.HLOutlet3 = value },
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
        public static class MA_MDDYZPhoenix
        {
            private static string suffixLC_COM;
            private static string suffixCurrent;
            private static RollermillSide suffixSide1;
            private static RollermillSide suffixSide2;
            public static string SuffixLC_COM
            {
                get { return suffixLC_COM; }
                set { suffixLC_COM = value; }
            }
            public static string SuffixCurrent
            {
                get { return suffixCurrent; }
                set { suffixCurrent = value; }
            }
            public static RollermillSide SiffixSide1
            {
                get { return suffixSide1; }
                set { suffixSide1 = value; }
            }
            public static RollermillSide SiffixSide2
            {
                get { return suffixSide2; }
                set { suffixSide2 = value; }
            }
            static MA_MDDYZPhoenix()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_MDDYZPHOENIX}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {
                    suffixSide1 = new RollermillSide();
                    suffixSide2 = new RollermillSide();

                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}LC_COM", value => suffixLC_COM = value },
                        { $"{keyPathSuffix}Current", value => suffixCurrent = value },
                        { $"{keyPathSuffix}Side1.MotorLow", value => suffixSide1.MotorLow = value },
                        { $"{keyPathSuffix}Side1.MotorUp", value => suffixSide1.MotorUp = value },
                        { $"{keyPathSuffix}Side1.HLBackupLeft", value => suffixSide1.HLBackupLeft = value },
                        { $"{keyPathSuffix}Side1.HLBackupRight", value => suffixSide1.HLBackupRight = value },
                        { $"{keyPathSuffix}Side1.HLInlet", value => suffixSide1.HLInlet = value },
                        { $"{keyPathSuffix}Side1.DivHLInlet", value => suffixSide1.DivHLInlet = value },
                        { $"{keyPathSuffix}Side1.FeedRoll", value => suffixSide1.FeedRoll = value },
                        { $"{keyPathSuffix}Side1.DivFeedRoll", value => suffixSide1.DivFeedRoll = value },
                        { $"{keyPathSuffix}Side1.HLOutlet1", value => suffixSide1.HLOutlet1 = value },
                        { $"{keyPathSuffix}Side1.HLOutlet2", value => suffixSide1.HLOutlet2 = value },
                        { $"{keyPathSuffix}Side1.HLOutlet3", value => suffixSide1.HLOutlet3 = value },
                        { $"{keyPathSuffix}Side2.MotorLow", value => suffixSide2.MotorLow = value },
                        { $"{keyPathSuffix}Side2.MotorUp", value => suffixSide2.MotorUp = value },
                        { $"{keyPathSuffix}Side2.HLBackupLeft", value => suffixSide2.HLBackupLeft = value },
                        { $"{keyPathSuffix}Side2.HLBackupRight", value => suffixSide2.HLBackupRight = value },
                        { $"{keyPathSuffix}Side2.HLInlet", value => suffixSide2.HLInlet = value },
                        { $"{keyPathSuffix}Side2.DivHLInlet", value => suffixSide2.DivHLInlet = value },
                        { $"{keyPathSuffix}Side2.FeedRoll", value => suffixSide2.FeedRoll = value },
                        { $"{keyPathSuffix}Side2.DivFeedRoll", value => suffixSide2.DivFeedRoll = value },
                        { $"{keyPathSuffix}Side2.HLOutlet1", value => suffixSide2.HLOutlet1 = value },
                        { $"{keyPathSuffix}Side2.HLOutlet2", value => suffixSide2.HLOutlet2 = value },
                        { $"{keyPathSuffix}Side2.HLOutlet3", value => suffixSide2.HLOutlet3 = value },
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
        public static class MA_MotorWithBypass
        {
            private static string suffixTempeatureSensor;
            private static string suffixOscillationSensor;
            private static string suffixMotor;
            private static string suffixSeal;
            private static string suffixVLS1;
            private static string suffixMon1;
            public static string SuffixMotor
            {
                get { return suffixMotor; }
                set { suffixMotor = value; }
            }
            public static string SuffixSeal
            {
                get { return suffixSeal; }
                set { suffixSeal = value; }
            }
            public static string SuffixVLS1
            {
                get { return suffixVLS1; }
                set { suffixVLS1 = value; }
            }
            public static string SuffixMon1
            {
                get { return suffixMon1; }
                set { suffixMon1 = value; }
            }
            public static string SuffixTempeatureSensor
            {
                get { return suffixTempeatureSensor; }
                set { suffixTempeatureSensor = value; }
            }
            public static string SuffixOscillationSensor
            {
                get { return suffixOscillationSensor; }
                set { suffixOscillationSensor = value; }
            }
   
            static MA_MotorWithBypass()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_MOTOR_WITH_BYPASS}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {    
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}OscillationSensor", value => suffixOscillationSensor = value },
                        { $"{keyPathSuffix}TempeatureSensor", value => suffixTempeatureSensor= value },
                        { $"{keyPathSuffix}Motor", value => suffixMotor= value },
                        { $"{keyPathSuffix}Seal", value => suffixSeal = value },
                        { $"{keyPathSuffix}VLS1", value => suffixVLS1 = value },
                        { $"{keyPathSuffix}Mon1", value => suffixMon1 = value },
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
        public static class MA_Discharger
        {
            private static string suffixMotor;
            private static string suffixLSFlow;
            private static string suffixLLBin;
            public static string SuffixMotor
            {
                get { return suffixMotor; }
                set { suffixMotor = value; }
            }
            public static string SuffixLSFlow
            {
                get { return suffixLSFlow; }
                set { suffixLSFlow = value; }
            }
            public static string SuffixLLBin
            {
                get { return suffixLLBin; }
                set { suffixLLBin = value; }
            }
            static MA_Discharger()
            {
                string keyPath = $"{AppGlobal.JS_GCOBJECT_INFO}.{AppGlobal.JS_DISCHARGER}.";
                string keyPathSuffix = $"{keyPath}{AppGlobal.JS_SUFFIX}.";
                try
                {
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPathSuffix}Motor", value => suffixMotor= value },
                        { $"{keyPathSuffix}LLBin", value => suffixLLBin = value },
                        { $"{keyPathSuffix}LSFlow", value => suffixLSFlow = value },
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
    }
   
}
