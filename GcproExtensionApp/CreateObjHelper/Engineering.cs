using GcproExtensionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GcproExtensionApp
{
    public static class Engineering
    {
        private static string patternMachineName;
        private static string patternNameNumber;
        private static string patternElementNamePrefix;
        public static string PatternMachineName
        {
            get { return patternMachineName; }
            set { patternMachineName = value; }
        }
        public static string PatternNameNumber
        {
            get { return patternNameNumber; }
            set { patternNameNumber = value; }
        }
        public static string PatternElementNamePrefix
        {
            get { return patternElementNamePrefix; }
            set { patternElementNamePrefix = value; }
        }
        static Engineering()
        {
            string keyPattern = $"{AppGlobal.JS_ENGINEERING}.{AppGlobal.JS_PATTERN}.";
            try
            {
                
                var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPattern}MachineName", value => patternMachineName = value },
                        { $"{keyPattern}NameNumber", value => patternNameNumber = value },
                        { $"{keyPattern}ElementNamePrefix", value => patternElementNamePrefix = value },
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
                MessageBox.Show(ex.ToString(), $"{keyPattern} Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
