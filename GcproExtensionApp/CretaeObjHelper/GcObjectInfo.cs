using GcproExtensionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
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
            private static string prefixLocalPanel;
            private static string commonSection;
            private static string preCleaningSection;
            private static string cleaningSection;
            private static string screeningsSection;
            private static string millingSection;
            private static string flourSection;
            private static string stackingSection;
            private static string outloadSection;
            private static string byproductSection;
            private static string silo;
            private static string rawWheatBin;
            private static string temperingBin;
            private static string screeningsBin;
            private static string baseFlourBin;
            private static string mixingBin;
            private static string bagingBin;
            private static string outLoadBin;
            private static string byProductBin;     
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
                try
                {
                    string keyGeneral = "GcObjectInfo.General.";
                    string NameNumberRule = "GcObjectInfo.NameNumberRule.";
                    string keyAddInfoToDesc = "GcObjectInfo.General.AddInfoToDesc.";
                    var keys = new Dictionary<string, Action<string>>
                        {
                            { $"{keyGeneral}Prefix.Name",value => prefixName= value },
                            { $"{keyGeneral}Delimiter.Symbol", value => delimiterSymbol= value },
                            { $"{keyGeneral}Suffix.IO.DI", value => suffixIO.DI = value },
                            { $"{keyGeneral}Suffix.IO.DO", value => suffixIO.DO = value },
                            { $"{keyGeneral}Suffix.IO.AI", value => suffixIO.AI = value },
                            { $"{keyGeneral}Suffix.IO.AO", value => suffixIO.AO = value },
                            { $"{keyGeneral}Suffix.IO.Delimiter", value => suffixIO.Delimiter = value },
                            { $"{NameNumberRule}Section.Common",value => commonSection= value },
                            { $"{NameNumberRule}Section.PreCleaning",value => preCleaningSection= value },
                            { $"{NameNumberRule}Section.Cleaning",value => cleaningSection= value },
                            { $"{NameNumberRule}Section.Screenings",value => screeningsSection= value },
                            { $"{NameNumberRule}Section.Milling",value => millingSection= value },
                            { $"{NameNumberRule}Section.Flour",value => flourSection= value },
                            { $"{NameNumberRule}Section.Stacking",value => stackingSection= value },
                            { $"{NameNumberRule}Section.Outload",value => outloadSection= value },
                            { $"{NameNumberRule}Section.Byproduct",value => byproductSection= value },
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
                    MessageBox.Show(ex.ToString(), "GcObjectInfo.General Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
        public class Bin
        {
            private static string binPrefix;
            private static AppGlobal.Range silo = new AppGlobal.Range(001, 199);
            private static AppGlobal.Range rawWheatBin = new AppGlobal.Range(201, 259);
            private static AppGlobal.Range temperingBin = new AppGlobal.Range(260, 299);
            private static AppGlobal.Range screeningsBin = new AppGlobal.Range(301, 399);
            private static AppGlobal.Range baseFlourBin = new AppGlobal.Range(401, 499);
            private static AppGlobal.Range mixingBin = new AppGlobal.Range(501, 599);
            private static AppGlobal.Range baggingBin = new AppGlobal.Range(601, 699);
            private static AppGlobal.Range outloadBin = new AppGlobal.Range(701, 799);
            private static AppGlobal.Range byproductBin = new AppGlobal.Range(801, 899);
            private static Bins bins = new Bins();
            public static string BinPrefix
            {
                get { return binPrefix; }
                set { binPrefix = value; }
            }
            public static Bins Bins
            {
                get { return bins; }
                set { bins = value; }
            }
            private static Dictionary<string, Action<string>> GetKeyValueDictionary()
            {
                string keyBin = "GcObjectInfo.Bin.";              
                   return new Dictionary<string, Action<string>>
                    {
                        {$"{keyBin}Prefix",value => binPrefix= value },
                        {$"{keyBin}NameNumberRule.Silo",value => bins.Silo= value },
                        {$"{keyBin}NameNumberRule.RawWheat",value => bins.RawWheat= value },
                        {$"{keyBin}NameNumberRule.Tempering",value => bins.Tempering= value },
                        {$"{keyBin}NameNumberRule.Screenings",value => bins.Screenings = value },
                        {$"{keyBin}NameNumberRule.BaseFlour",value => bins.BaseFlour= value },
                        {$"{keyBin}NameNumberRule.Mixing",value => bins.Mixing= value },
                        {$"{keyBin}NameNumberRule.Bagging",value => bins.Bagging= value },
                        {$"{keyBin}NameNumberRule.Outload",value => bins.Outload= value },
                        {$"{keyBin}NameNumberRule.ByProduct",value => bins.ByProduct= value },
                    };
            }
            private static void ParseAllRanges()
            {
                silo = AppGlobal.Range.ParseRange(bins.Silo);
                rawWheatBin = AppGlobal.Range.ParseRange(bins.RawWheat);
                temperingBin = AppGlobal.Range.ParseRange(bins.Tempering);
                screeningsBin = AppGlobal.Range.ParseRange(bins.Screenings);
                baseFlourBin = AppGlobal.Range.ParseRange(bins.BaseFlour);
                mixingBin = AppGlobal.Range.ParseRange(bins.Mixing);
                baggingBin= AppGlobal.Range.ParseRange(bins.Bagging);
                outloadBin = AppGlobal.Range.ParseRange(bins.Outload);
                byproductBin= AppGlobal.Range.ParseRange(bins.ByProduct);
            }
            static Bin()
            {
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
                    MessageBox.Show(ex.ToString(), "GcObjectInfo.Bin.NameNumberRule Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            static VLS()
            {
                try
                {
                    string keyVLS = "GcObjectInfo.VLS.";
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyVLS}Suffix.VLS", value => suffixVLS = value },
                        { $"{keyVLS}Suffix.VLSPattern", value => suffixVLSPattern = value },
                        { $"{keyVLS}Suffix.InpLN", value => suffixInpLN = value },
                        { $"{keyVLS}Suffix.OutpLN", value => suffixOutpLN = value },
                        { $"{keyVLS}Suffix.InpHN", value => suffixInpHN = value },
                        { $"{keyVLS}Suffix.OutpHN", value => suffixOutpHN = value },
                        { $"{keyVLS}Suffix.InpRunRev", value => suffixInpRunRev = value },
                        { $"{keyVLS}Suffix.OutpRunRev", value => suffixOutpRunRev = value },
                        { $"{keyVLS}Suffix.InpRunFwd", value => suffixInpRunFwd = value },
                        { $"{keyVLS}Suffix.OutpRunFwd", value => suffixOutpRunFwd = value },
                        { $"{keyVLS}Suffix.InpPattern", value => suffixInpPattern= value },
                        { $"{keyVLS}Suffix.OutpPattern", value => suffixOutpPattern = value },
                        { $"{keyVLS}Suffix.InpRunPattern", value => suffixInpRunPattern = value },
                        { $"{keyVLS}Suffix.OutpRunPattern", value => suffixOutpRunPattern = value },
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
            private static string suffixMotor;
            private static string suffixInpRunFwd;
            private static string suffixOutpRunFwd;
            private static string suffixInpRunRev;
            private static string suffixOutpRunRev;
            private static string suffixVFC;
            private static string suffixPowerApp;
            private static string suffixAO;
            private static string prefixName;
            private static string nameDelimiter;
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
            static Motor()
            {
                try
                {
                    string keyMotor = "GcObjectInfo.Motor.";
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyMotor}Suffix.Motor", value => suffixMotor = value },
                        { $"{keyMotor}Suffix.InpRunFwd", value => suffixInpRunFwd= value },
                        { $"{keyMotor}Suffix.OutpRunFwd", value => suffixOutpRunFwd = value },
                        { $"{keyMotor}Suffix.InpRunRev", value => suffixInpRunRev = value },
                        { $"{keyMotor}Suffix.OutpRunRev", value => suffixOutpRunRev = value },
                        { $"{keyMotor}Suffix.VFC", value => suffixVFC = value },
                        { $"{keyMotor}Suffix.PowerApp", value => suffixPowerApp = value },
                        { $"{keyMotor}Suffix.AO", value => suffixAO= value },
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
                    MessageBox.Show(ex.ToString(), "GcObjectInfo.Motor Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            static DI()
            {
                try
                {
                    string keyVLS = "GcObjectInfo.DI.";
                    var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyVLS}Suffix.InpTrue", value => suffixInpTrue = value },
                        { $"{keyVLS}Suffix.InpFaultDev", value => suffixInpFaultDev = value },
                        { $"{keyVLS}Suffix.OutpFaultReset", value => suffixOutpFaultReset = value },
                        { $"{keyVLS}Suffix.OutpPowerOff", value => suffixOutpPowerOff = value },
                        { $"{keyVLS}Suffix.OutpLamp", value => suffixOutpLamp = value },
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
                    MessageBox.Show(ex.ToString(), "GcObjectInfo.DI Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            private static Sections sections =new Sections();         
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
                string keySections = "GcObjectInfo.General.NameNumberRule.Section.";
                return new Dictionary<string, Action<string>>
                {
                    { $"{keySections}Common", value => sections.Common = value },
                    { $"{keySections}PreCleaning", value => sections.PreCleaning = value },
                    { $"{keySections}Cleaning", value => sections.Cleaning= value },
                    { $"{keySections}Screenings", value => sections.Screenings= value },
                    { $"{keySections}Milling", value => sections.Milling = value },
                    { $"{keySections}Flour", value => sections.Flour = value },
                    { $"{keySections}Stacking", value => sections.Stacking = value },
                    { $"{keySections}Outload", value => sections.Outload = value },
                    { $"{keySections}Byproduct", value => sections.Byproduct = value }
                };
            }
            private static void ParseAllRanges()
            {
                commonSection = AppGlobal.Range.ParseRange(sections.Common);
                preCleaningSection = AppGlobal.Range.ParseRange(sections.PreCleaning);
                cleaningSection = AppGlobal.Range.ParseRange(sections.Cleaning );
                screeningsSection = AppGlobal.Range.ParseRange(sections.Screenings);
                millingSection = AppGlobal.Range.ParseRange(sections.Milling);
                flourSection = AppGlobal.Range.ParseRange(sections.Flour);
                stackingSection = AppGlobal.Range.ParseRange(sections.Stacking);
                outloadSection = AppGlobal.Range.ParseRange(sections.Outload);
                byproductSection = AppGlobal.Range.ParseRange(sections.Byproduct);
            }
            static Section()
            {
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
                    MessageBox.Show(ex.ToString(), "GcObjectInfo.General.NameNumberRule.Section Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
   
}
