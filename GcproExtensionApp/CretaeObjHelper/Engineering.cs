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
        private static string patternNameWithoutTypeLL;
        private static string patternNameOnlyWithNumber;
        private static string patternNamePrefix;
        public static string PatternNameWithoutTypeLL
        {
            get { return patternNameWithoutTypeLL; }
            set { patternNameWithoutTypeLL = value; }
        }
        public static string PatternNameOnlyWithNumber
        {
            get { return patternNameOnlyWithNumber; }
            set { patternNameOnlyWithNumber = value; }
        }
        public static string PatternNamePrefix
        {
            get { return patternNamePrefix; }
            set { patternNamePrefix = value; }
        }
        static Engineering()
        {
            try
            {
                string keyPattern = "Engineering.Pattern.";
                var keys = new Dictionary<string, Action<string>>
                    {
                        { $"{keyPattern}NameWithoutTypeLL", value => patternNameWithoutTypeLL = value },
                        { $"{keyPattern}NameOnlyWithNumber", value => patternNameOnlyWithNumber = value },
                        { $"{keyPattern}NamePrefix", value => patternNamePrefix = value },
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
                MessageBox.Show(ex.ToString(), "GcObjectInfo.Engineering Json配置文件", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
