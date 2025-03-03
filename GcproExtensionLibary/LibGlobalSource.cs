using GcproExtensionLibrary.FileHandle;
using GcproExtensionLibrary.Gcpro;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace GcproExtensionLibrary
{
    public class Relation
    {
        public string Parent { get; set; }
        public string Child { get; set; }
        public string ConnectedFiled { get; set; }

        public Relation()
        {
        }
        public Relation(string parent, string child, string connectedField)
        {
            Parent = parent;
            Child = child;
            ConnectedFiled = connectedField;
        }
        public void SetRelation(string parent, string child, string connectedField)
        {
            Parent = parent;
            Child = child;
            ConnectedFiled = connectedField;
        }
    }

    public static class LibGlobalSource
    {
        #region Public const declaration
        public const string TAB = "\t";
        public const string NOCHILD = "0";
        public const string DEFAULT_GCPRO_WORK_TEMP_PATH = @"C:\temp";
        public const string SELECT_A_FOLDER = "选择一个文件夹";
        public const string FILE_SAVE_AS = "文件另存为";
        public const string CREATE_OBJECT = "创建对象:";
        public const string CREATE_RELATION = "对象关系:";
        public const string OLEDB_PROVIDER_MDB = "Provider=Microsoft.Jet.OLEDB.4.0;";
        public const string OLEDB_PROVIDER_ACCDB = "Provider=Microsoft.ACE.OLEDB.12.0;";
        public const string EMPTY_TABLENAME_OR_FIELDNAME = "查询表名称和字段名称不能为空";
        public const string EX_FILE_NOT_FOUND = "文件未找到，请确保文件路径正确并且文件存在。";
        public const string EX_READING_FILE = "读取文件时发生错误。";
        public const string EX_IO_ERROR = "发生I/O错误";
        public const string EX_UNKNOW = "未知错误";
        public const string EX_UNAUTHORIZED_ACCESS = "没有权限访问文件。请检查文件权限。";
        public const string EX_SPECIFIED_COLUMN = "未指定读取列。";
        public const string DESC_SEPARATOR = ",";
        public const int MIN_IO_SYMBOL_LENGTH = 3;
        public const string MSG_INVALID_IO_SYMBOL = "无效的IO名称！";
        public const int NO_OWNER = 1;
        public const int NO_PARENT = 0;
        public const int MEAG_EXT_LONG = 72;
        public const int MEAG_NORMAL = 24;
        public const int NONE_UNIT = 0;
        public const double NO_DP_NODE = 0;
        public const int NO_DIAGRAM = 0;
        public const double GROUP_HORNCODE = 0; 
        public const string FIELDS_SEPARATOR = "   |";
        public const string HORNCODE_FIELDS_SEPARATOR = " ¦";

        #endregion
        public static class StringHelper
        {
            public static string[] SplitStringWithRule(string source, string rule)
            {
                string[] result = source.Split(new string[] { rule }, StringSplitOptions.RemoveEmptyEntries);
                return result;
            }   
            public static string GenerateObjectName(string[] source, RuleSubPos ruleSubPos, string rule)
            {
                StringBuilder result = new StringBuilder();
                if (ruleSubPos.StartPos)
                {
                     result.Append(rule).Append(source[0]);                
                }
                else if (ruleSubPos.EndPos)
                {
                    result.Append(source[0]).Append(rule);                
                }
                else if (ruleSubPos.PosInString > 0)
                {
                    result.Append(source[0]).Append(rule).Append(source[1]);                  
                }
                return result.ToString();
            }
            public static RuleSubPos RuleSubPos(string source, string rule)
            {
                bool startsWithRule = source.StartsWith(rule);
                bool endsWithRule = source.EndsWith(rule);
                RuleSubPos ruleSubPos = new RuleSubPos
                {
                    StartPos = startsWithRule,
                    EndPos = endsWithRule,
                    MidPos = !startsWithRule && !endsWithRule,
                    PosInString = startsWithRule ? 0 : source.IndexOf(rule),
                    Len = rule.Length
                };
                return ruleSubPos;
            }
    
            public static string ExtractStringPart(string pattern, string stringTobeExtract,bool ignoreCase = false)
            {
                string result;
                if (!string.IsNullOrEmpty(stringTobeExtract))
                {
                    RegexOptions options = ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.None;
                    Match match = Regex.Match(stringTobeExtract, pattern, options);
                    result = match.Success ? match.Value : string.Empty;
                    return result;
                }
                else
                {
                    return string.Empty;
                }
            }
            public static string ExtractNumericPart(string stringTobeExtract, bool withSign)
            {
                string result;
                string pattern = withSign ? @"[+-]?\d+(\.\d+)?" : @"\d+(\.\d+)?";
                result = ExtractStringPart(pattern, stringTobeExtract);
                return result;
            }
            public static string ExtractOnlyString(string stringTobeExtract)
            {
                return stringTobeExtract.Replace(ExtractNumericPart(stringTobeExtract, false), string.Empty);
            }
            /*
            static string RemoveParts(string input, string[] partsToRemove,bool removeSpace)
            {
                string result = input;

                foreach (string part in partsToRemove)
                {
                    result = result.Replace(part, "");
                }
                if (removeSpace)
                {
                    result = result.Replace(" ", "");
                }
                return result;
            }
            public static string ExtractStringBetween(string input, char startChar, char endChar)
            {
                string pattern = $@"\{startChar}([a-zA-Z0-9].*?)\{endChar}";
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
                else
                {
                    return "No match found!";
                }
            }
            public static string ExtractStringBetween(string input, string startString, string endString)
            {
                string pattern = $@"{Regex.Escape(startString)}([a-zA-Z0-9].*?){Regex.Escape(endString)}";
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    return match.Groups[1].Value;
                }
                else
                {
                    return "No match found!";
                }
            }
            public static string FindLongestCommonSubstring(string str1, string str2)
            {
                int[,] table = new int[str1.Length + 1, str2.Length + 1];
                int longestLength = 0;
                int endIndexStr1 = 0;

                for (int i = 1; i <= str1.Length; i++)
                {
                    for (int j = 1; j <= str2.Length; j++)
                    {
                        if (str1[i - 1] == str2[j - 1])
                        {
                            table[i, j] = table[i - 1, j - 1] + 1;
                            if (table[i, j] > longestLength)
                            {
                                longestLength = table[i, j];
                                endIndexStr1 = i;
                            }
                        }
                        else
                        {
                            table[i, j] = 0;
                        }
                    }
                }

                return str1.Substring(endIndexStr1 - longestLength, longestLength);
            }   
            */
            public static string FindContinuousAndSameSubstring(string str1, string str2, int minLen = 0, int maxLen = 0)
            {
                int[,] lcs = new int[str1.Length + 1, str2.Length + 1];
                int length = 0;
                int row = 0, col = 0;
                for (int i = 1; i <= str1.Length; i++)
                {
                    for (int j = 1; j <= str2.Length; j++)
                    {
                        if (str1[i - 1] == str2[j - 1])
                        {
                            lcs[i, j] = lcs[i - 1, j - 1] + 1;
                            if (lcs[i, j] > length)
                            {
                                length = lcs[i, j];
                                row = i;
                                col = j;
                            }
                        }
                        else
                        {
                            lcs[i, j] = 0;
                        }
                    }
                }

                if (length == 0)
                {
                    return string.Empty;
                }
                string result = string.Empty;
                while (lcs[row, col] != 0)
                {
                    result = str1[row - 1] + result;
                    row--;
                    col--;
                }
                if (minLen == 0 && maxLen == 0)
                {
                    return result;
                }
                else
                {
                    if (result.Length < minLen)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        if (result.Length > maxLen && result.Length != 0)
                        { return result.Substring(0, maxLen); }
                        else
                        { return result; }
                    }
                }
            }
            public static string ExtendPrefixToSeparator(string prefix, List<string> columnValues)
            {
                foreach (var value in columnValues)
                {
                    if (value.StartsWith(prefix))
                    {
                        int index = value.IndexOf(prefix) + prefix.Length;
                        while (index < value.Length && !char.IsLetterOrDigit(value[index]))
                        {
                            index++;
                        }
                        return value.Substring(0, index);
                    }
                }
                return prefix;
            }
        }
        public static class BMLHelper
        {
            /// <summary>
            /// 提取数据表上，某列数据上共同部分字符串
            /// </summary>
            /// <param name="dataTable"></param>
            /// <param name="columnName"></param>
            /// <param name="minLen">返回字符串最小长度</param>
            /// <param name="maxLen">返回字符串最大长度</param>
            /// <returns></returns>
            public static List<KeyValuePair<string, int>> ExtractUniqueCommonSubstringsWithCount(DataTable dataTable, string columnName, int minLen = 0, int maxLen = 0)
            {
                List<string> columnValues = dataTable.AsEnumerable().Select(row => row.Field<string>(columnName)).ToList();
                List<KeyValuePair<string, int>> finalResults = new List<KeyValuePair<string, int>>();
                int timeLimit = columnValues.Count * 5;
                DateTime startTime = DateTime.Now;
                while (columnValues.Count > 0)
                {
                    if ((DateTime.Now - startTime).TotalMilliseconds > timeLimit)
                    {
                        break;
                    }
                    Dictionary<string, int> substringWithCount = new Dictionary<string, int>();
                    for (int i = 0; i < columnValues.Count; i++)
                    {
                        for (int j = i + 1; j < columnValues.Count; j++)
                        {
                            string commonSubstring = StringHelper.FindContinuousAndSameSubstring(columnValues[i], columnValues[j], minLen, maxLen);
                            if (!string.IsNullOrEmpty(commonSubstring))
                            {
                                for (int k = minLen; k <= commonSubstring.Length; k++)
                                {
                                    string prefix = commonSubstring.Substring(0, k);
                                    //string prefix = commonSubstring;
                                    if (!string.IsNullOrEmpty(prefix))
                                    {
                                        if (substringWithCount.ContainsKey(prefix))
                                        {
                                            substringWithCount[prefix]++;
                                        }
                                        else
                                        {
                                            substringWithCount[prefix] = 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var bestMatch = substringWithCount
                        .Where(x => x.Value >= 2 && x.Value <= 10)
                        .OrderByDescending(x => x.Key.Length)
                        .ThenByDescending(x => x.Value)
                        .FirstOrDefault();

                    if (bestMatch.Key == null) break;

                    string bestPrefix = StringHelper.ExtendPrefixToSeparator(bestMatch.Key, columnValues);
                    int count = columnValues.Count(value => value.StartsWith(bestPrefix));
                    if (count == 0)
                    {
                        bestMatch = substringWithCount
                        .Where(x => x.Value >= 1 && x.Value <= 10)
                        .OrderByDescending(x => x.Key.Length)
                        .ThenByDescending(x => x.Value)
                        .FirstOrDefault();
                        bestPrefix = StringHelper.ExtendPrefixToSeparator(bestMatch.Key, columnValues);
                        count = columnValues.Count(value => value.StartsWith(bestPrefix));
                    }
                    finalResults.Add(new KeyValuePair<string, int>(bestPrefix, count));
                    columnValues.RemoveAll(value => value.StartsWith(bestPrefix));
                }
                return finalResults;
            }
            public static List<KeyValuePair<string, int>> ExtractUniqueCommonSubstringsWithCount(DataGridView dataGridView, string columnName, int minLen = 0, int maxLen = 0)
            {
                List<string> columnValues = dataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => row.Cells[columnName].Value != null)
                    .Select(row => row.Cells[columnName].Value.ToString())
                    .ToList();
                List<KeyValuePair<string, int>> finalResults = new List<KeyValuePair<string, int>>();
                int timeLimit = columnValues.Count * 5;
                DateTime startTime = DateTime.Now;
                while (columnValues.Count > 0)
                {
                    if ((DateTime.Now - startTime).TotalMilliseconds > timeLimit)
                    {
                        break;
                    }
                    Dictionary<string, int> substringWithCount = new Dictionary<string, int>();
                    for (int i = 0; i < columnValues.Count; i++)
                    {
                        for (int j = i + 1; j < columnValues.Count; j++)
                        {
                            string commonSubstring = StringHelper.FindContinuousAndSameSubstring(columnValues[i], columnValues[j], minLen, maxLen);
                            if (!string.IsNullOrEmpty(commonSubstring))
                            {
                                for (int k = minLen; k <= commonSubstring.Length; k++)
                                {
                                    string prefix = commonSubstring.Substring(0, k);
                                    if (substringWithCount.ContainsKey(prefix))
                                    {
                                        substringWithCount[prefix]++;
                                    }
                                    else
                                    {
                                        substringWithCount[prefix] = 1;
                                    }
                                }
                            }
                        }
                    }
                    ///<summary>
                    ///非手动闸门等设备名称字符串通常情况下至少出现2次
                    ///</summary>               
                    var bestMatch = substringWithCount
                        .Where(x => x.Value >= 2 && x.Value <= 10)
                        .OrderByDescending(x => x.Key.Length)
                        .ThenByDescending(x => x.Value)
                        .FirstOrDefault();

                    if (bestMatch.Key == null) break;

                    string bestPrefix = StringHelper.ExtendPrefixToSeparator(bestMatch.Key, columnValues);
                    int count = columnValues.Count(value => value.StartsWith(bestPrefix));
                    ///<summary>
                    ///手动闸门等,搜索到的最符合字符串，只有一次，按照至少
                    ///出现2次规则提取字符串，会截取中间字符串作为设备名称，
                    ///故改变筛选规则；
                    ///</summary>
                    if (count == 0)
                    {
                        bestMatch = substringWithCount
                        .Where(x => x.Value >= 1 && x.Value <= 10)
                        .OrderByDescending(x => x.Key.Length)
                        .ThenByDescending(x => x.Value)
                        .FirstOrDefault();
                        bestPrefix = StringHelper.ExtendPrefixToSeparator(bestMatch.Key, columnValues);
                        count = columnValues.Count(value => value.StartsWith(bestPrefix));
                    }
                    finalResults.Add(new KeyValuePair<string, int>(bestPrefix, count));
                    columnValues.RemoveAll(value => value.StartsWith(bestPrefix));
                }

                return finalResults;
            }
            public static List<KeyValuePair<string, int>> ExtractMachineNameWithCount(DataTable dataTable, string columnName, string pattern)
            {
                List<string> columnValues = dataTable.AsEnumerable().Select(row => row.Field<string>(columnName)).ToList();
                List<KeyValuePair<string, int>> finalResults = new List<KeyValuePair<string, int>>();
                int timeLimit = columnValues.Count * 5;
                DateTime startTime = DateTime.Now;
                Dictionary<string, int> substringWithCount = new Dictionary<string, int>();
                for (int i = 0; i < columnValues.Count; i++)
                {
                    if ((DateTime.Now - startTime).TotalMilliseconds > timeLimit)
                    {
                        break;
                    }
                    string commonSubstring = StringHelper.ExtractStringPart(pattern, columnValues[i]);
                    if (!string.IsNullOrEmpty(commonSubstring))
                    {
                        if (substringWithCount.ContainsKey(commonSubstring))
                        {
                            substringWithCount[commonSubstring]++;
                        }
                        else
                        {
                            substringWithCount[commonSubstring] = 1;
                        }
                    }
                }
                foreach (var subs in substringWithCount)
                {
                    finalResults.Add(subs);
                }

                return finalResults;
            }

            public static List<KeyValuePair<string, int>> ExtractMachineNameWithCount(DataGridView dataGridView, string columnName, string pattern)
            {
                List<string> columnValues = dataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => row.Cells[columnName].Value != null)
                    .Select(row => row.Cells[columnName].Value.ToString())
                    .ToList();
                List<KeyValuePair<string, int>> finalResults = new List<KeyValuePair<string, int>>();
                int timeLimit = columnValues.Count * 5;
                DateTime startTime = DateTime.Now;
                Dictionary<string, int> substringWithCount = new Dictionary<string, int>();
                for (int i = 0; i < columnValues.Count; i++)
                {
                    if ((DateTime.Now - startTime).TotalMilliseconds > timeLimit)
                    {
                        break;
                    }
                    string commonSubstring = StringHelper.ExtractStringPart(pattern, columnValues[i]);
                    if (!string.IsNullOrEmpty(commonSubstring))
                    {
                        if (substringWithCount.ContainsKey(commonSubstring))
                        {
                            substringWithCount[commonSubstring]++;
                        }
                        else
                        {
                            substringWithCount[commonSubstring] = 1;
                        }
                    }
                }
                foreach (var subs in substringWithCount)
                {
                    finalResults.Add(subs);
                }

                return finalResults;
            }
        }
        public static class JsonHelper
        {
            public static JObject ReadConfig(string filePath)
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"配置文件 '{filePath}' 未找到.");

                string json = File.ReadAllText(filePath);
                return JObject.Parse(json);
            }

            public static void WriteConfig(string filePath, JObject jObject)
            {
                string json = jObject.ToString(Formatting.Indented);
                File.WriteAllText(filePath, json);
            }

            public static string ReadKeyValue(string filePath, string key)
            {
                JObject jObject = ReadConfig(filePath);
                JToken token = jObject.SelectToken(key);
                return token?.ToString();
            }
            /// <summary>
            /// 返回参数数组keys中包含的键的值
            /// </summary>
            /// <param name="filePath"></param>
            /// <param name="keys"></param>
            /// <returns></returns>
            public static Dictionary<string, string> ReadKeyValues(string filePath, params string[] keys)
            {
                JObject jObject = ReadConfig(filePath);

                var values = new Dictionary<string, string>();
                foreach (var key in keys)
                {
                    string value = jObject.SelectToken(key)?.ToString();
                    values[key] = value ?? "未找到配置项";
                }

                return values;
            }
            /// <summary>
            /// Write the Value to key
            /// </summary>
            /// <param name="filePath">The Json file name</param>
            /// <param name="key">The key name</param>
            /// <param name="value">The value to be write</param>
            public static void WriteKeyValue(string filePath, string key, JToken value)
            {
                JObject jObject = ReadConfig(filePath);
                AddNestedValue(jObject, key, value);
                WriteConfig(filePath, jObject);
            }

            public static void WriteKeyValues(string filePath, Dictionary<string, JToken> keyValues)
            {
                JObject jObject = ReadConfig(filePath);

                foreach (var kvp in keyValues)
                {
                    AddNestedValue(jObject, kvp.Key, kvp.Value);
                }

                WriteConfig(filePath, jObject);
            }

            private static void AddNestedValue(JObject jObject, string keyPath, JToken value)
            {
                var pathSegments = keyPath.Split('.');
                JObject currentObject = jObject;

                for (int i = 0; i < pathSegments.Length; i++)
                {
                    string pathSegment = pathSegments[i];
                    if (i == pathSegments.Length - 1)
                    {
                        currentObject[pathSegment] = value;
                    }
                    else
                    {
                        if (currentObject[pathSegment] == null)
                        {
                            currentObject[pathSegment] = new JObject();
                        }
                        currentObject = (JObject)currentObject[pathSegment];
                    }
                }
            }

            public static Dictionary<string, JToken> ReadKeyValuePairs(string filePath, params string[] keys)
            {
                JObject jObject = ReadConfig(filePath);

                var keyValuePairs = new Dictionary<string, JToken>();
                foreach (var key in keys)
                {
                    JToken token = jObject.SelectToken(key);
                    keyValuePairs[key] = token ?? JValue.CreateNull();
                }

                return keyValuePairs;
            }

            public static void WriteKeyValuePairs(string filePath, Dictionary<string, JToken> keyValues)
            {
                JObject jObject = ReadConfig(filePath);

                foreach (var kvp in keyValues)
                {
                    var token = jObject.SelectToken(kvp.Key);
                    if (token != null)
                    {
                        token.Replace(kvp.Value);
                    }
                    else
                    {
                        AddNestedValue(jObject, kvp.Key, kvp.Value);
                    }
                }

                WriteConfig(filePath, jObject);
            }
        }
    }
    public interface IGcpro
    {
        void CreateObject(TextFileHandle textFileHandle,  Encoding encoding, bool onlyRelation = false);
    }
}
