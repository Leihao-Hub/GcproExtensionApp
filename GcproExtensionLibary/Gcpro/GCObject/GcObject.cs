using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static GcproExtensionLibrary.Gcpro.GcproTable;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class GcObject
    {
        public static OTypeCollection OType { get; protected set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string SubType { get; set; }
        public abstract string ProcessFct { get; set; }
        public abstract string Building { get; set; }
        public abstract string Elevation { get; set; }
        public abstract double FieldBusNode { get; set; }
        public abstract string Panel_ID { get; set; }
        public abstract double Diagram { get; set; }
        public abstract string Page { get; set; }
        public abstract string IsNew { get; set; }
        public abstract string FilePath { get; set; }
        protected static void SetOTypeProperty(OTypeCollection value)
        {
            OType = value;
        }
        /// <summary>
        /// 清除[filePath]文件类容
        /// </summary>
        /// <param name="filePath"></param>
        public static void Clear(string filePath)
        {
            TextFileHandle textFileHandle = new TextFileHandle
            {
                FilePath = filePath
            };
            textFileHandle.ClearContents();
        }
        /// <summary>
        /// 文件另存为
        /// </summary>
        /// <param name="sourceFilePath"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool SaveFileAs(string sourceFilePath, string title)
        {
            TextFileHandle textFileHandle = new TextFileHandle
            {
                FilePath = sourceFilePath
            };
            return textFileHandle.SaveFileAs(title);      
        }
        /// <summary>
        /// 创建对象标准部分字符串
        /// </summary>
        /// <returns></returns>
        public string CreateObjectStandardPart()
        {
            StringBuilder objFields = new StringBuilder();
            objFields.Append(IsNew).Append(LibGlobalSource.TAB)
              .Append(Name).Append(LibGlobalSource.TAB)
              .Append(Description).Append(LibGlobalSource.TAB)
              .Append(SubType).Append(LibGlobalSource.TAB)
              .Append(ProcessFct).Append(LibGlobalSource.TAB)
              .Append(Building).Append(LibGlobalSource.TAB)
              .Append(Elevation).Append(LibGlobalSource.TAB)
              .Append(FieldBusNode).Append(LibGlobalSource.TAB)
              .Append(Panel_ID).Append(LibGlobalSource.TAB)
              .Append(Diagram).Append(LibGlobalSource.TAB)
              .Append(Page);
            return objFields.ToString();
        }
        /// <summary>
        /// 创建对象之间的关联关系
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <param name="connectedFiled"></param>
        /// <param name="filePath"></param>
        /// <param name="encoding"></param>
        public static void CreateRelation(string parent, string child, string connectedFiled, string filePath, Encoding encoding)
        {
            TextFileHandle textFileHandle = new TextFileHandle
            {
                FilePath = filePath
            };
            string output = parent + LibGlobalSource.TAB + child + LibGlobalSource.TAB + connectedFiled;
            textFileHandle.WriteToTextFile(output, encoding);
        }
        /// <summary>
        /// 一次性根据relations中"Child"值是否为空,来创建relations中对象的关系
        /// </summary>
        /// <param name="relations"></param>
        /// <param name="filePath"></param>
        /// <param name="encoding"></param>
        protected void CreateRelations(List<Relation> relations, string filePath, Encoding encoding)
        {
            foreach (var relation in relations)
            {
                if (!String.IsNullOrEmpty(relation.Child))
                {
                    CreateRelation(
                    parent: relation.Parent,
                    child: relation.Child,
                    connectedFiled: relation.ConnectedFiled,
                    filePath: filePath,
                    encoding: encoding
                    );
                }
            }
        }
        /// <summary>
        /// 从描述中提取信息,比如Diagram,InfoType以及HorCdoe等信息
        /// 00 ¦ Group horncode 提取 0;
        /// 7147   | off/on     提取 7147;
        /// 11  | +C21A         提取 11  ;  
        /// </summary>
        /// <param name="infoValueAndDesc"></param>
        /// <param name="separator">分隔符，比如InfoType为"   |";HornCode为" ¦"</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static double ParseInfoValue(string infoValueAndDesc,string separator,double defaultValue = 0)
        {
            return double.TryParse(infoValueAndDesc.Substring(0, infoValueAndDesc.IndexOf(separator)), out double tempDouble) ? tempDouble : defaultValue;
        }
        protected void CreateImpExpDef(List<List<Gcpro.DbParameter>> impExpList, string impExpRuleName)
        {

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "Type" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.OType.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "IsNew" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.IsNew.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "Name" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.Text0.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "Description" },
                new Gcpro.DbParameter { Name =  ImpExpDef.FieldFieldName.Name, Value = ObjData.Text1.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "SubType" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name ,Value = ObjData.SubType.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "ProcessFct" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.ProcessFct.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "Building" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.Building.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "Elevation" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.Elevation.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "FieldBusNode" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.FieldbusNode.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "Panel ID" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.Panel_ID.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "Diagram" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.DiagramNo.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "Page" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.PageName.Name }
            });
        }
        /// <summary>
        /// 根据相关信息返回对象的描述
        /// </summary>
        /// <param name="baseRule">对象规则数据</param>
        /// <param name="withLineinfo">描述里包含生产线信息</param>
        /// <param name="withFloorInfo">描述里面包含楼层信息</param>
        /// <param name="withNameInfo">描述内包含名称信息</param>
        /// <param name="nameOnlyWithNumber">名称仅包含数字部分</param>
        /// <returns></returns>
        public static string EncodingDesc(ref GcBaseRule baseRule, string namePrefix,string nameRule, 
            bool withLineInfo = true, bool withFloorInfo = true, bool withNameInfo = true, bool withCabinet = false,
            bool withPower =false ,bool nameOnlyWithNumber = true,bool removeNamePrefix = true)
        {
            StringBuilder desc = new StringBuilder();
            string nameWithoutSuffix;
            baseRule.NameRule = LibGlobalSource.StringHelper.ExtractNumericPart(baseRule.Name, false);
            nameWithoutSuffix = LibGlobalSource.StringHelper.ExtractStringPart(nameRule,baseRule.Name);
            if (withLineInfo)
            {
                desc.Append(baseRule.DescLine);
            }
            if (withFloorInfo)
            {
                desc.Append(baseRule.DescFloor);
            }
            if (withNameInfo)
            {
                string name = nameWithoutSuffix;           
                if (removeNamePrefix)
                { name = name.Contains(namePrefix) ? name.Replace(namePrefix, string.Empty) : name; }
                baseRule.DescName = nameOnlyWithNumber ? $"({baseRule.NameRule})" : $"({name})";
                desc.Append(baseRule.DescName);

            }
            desc.Append(baseRule.DescObject);
            bool _withCabinet, _withPower;
            _withCabinet = withCabinet && !String.IsNullOrEmpty(baseRule.Cabinet);
            _withPower = withPower && !String.IsNullOrEmpty(baseRule.Power);
            if (_withCabinet || _withPower)
            {
                desc.Append("[");
                if (_withCabinet)
                {
                    desc.Append($"{baseRule.Cabinet}");
                }
                if (_withPower)
                {
                    desc.Append(" ");
                    desc.Append($"{baseRule.Power}kW");
                }
                desc.Append("]");
            }
        
            baseRule.Description = desc.ToString();
            return baseRule.Description;
        }
        public static void DecodingDesc(ref GcBaseRule baseRule, string descSeparator)
        {
    
            if (String.IsNullOrEmpty(baseRule.Description))
            {
                baseRule.DescLine = string.Empty;
                baseRule.DescFloor = string.Empty;
                baseRule.DescName = string.Empty;
                baseRule.DescObject = string.Empty;
                return ;

            }
            string[] parts = baseRule.Description.Split(new string[] { descSeparator }, StringSplitOptions.None);
            if (parts[0].Length == baseRule.Description.Length)
            {
                baseRule.DescLine = string.Empty;
                baseRule.DescFloor = string.Empty;
                baseRule.DescName = string.Empty;
                baseRule.DescObject = baseRule.Description;
                return ;
            }
            if (parts.Length ==2 )
            {                 
                baseRule.DescLine = parts[0];                   
                baseRule.DescObject = parts[1];
                return;
            }
            if (parts.Length == 3 )
            {
                baseRule.DescLine = parts[0];
                baseRule.DescFloor = parts[1];
                baseRule.DescObject = parts[2];
                return;
            }
            if (parts.Length >3)
            {
                baseRule.DescLine = parts[0];
                baseRule.DescFloor = parts[1];
                baseRule.DescName = parts[2];
                baseRule.DescObject = parts[3];
            }
            bool hasCabinet = !String.IsNullOrEmpty(baseRule.Cabinet);
            bool hasPower = !String.IsNullOrEmpty(baseRule.Power);
            //if (hasCabinet)
            //{ baseRule.DescObject.Replace(baseRule.Cabinet,string.Empty); }
            //if (hasPower)
            //{ baseRule.DescObject.Replace(baseRule.Power, string.Empty); }
            if (hasCabinet || hasPower)
            {
                //baseRule.DescObject.Replace("[", string.Empty);             
                //baseRule.DescObject.Replace("]", string.Empty);
                baseRule.DescObject= baseRule.DescObject.Remove(baseRule.DescObject.IndexOf("["));
            }
           
        }
        /// <summary>
        /// 重新翻译DPNode
        /// </summary>
        /// <param name="oledb"></param>
        public static void ReGenerateDPNode(OleDb oledb)
        {
            oledb.DeleteRecord(GcproTable.TranslationCbo.TableName, $"{GcproTable.TranslationCbo.FieldClass.Name}='{GcproTable.TranslationCbo.Class_ASWInDPFault}'", null);
            DataTable data ;
            data = oledb.QueryDataTable(GcproTable.ObjData.TableName, $"{GcproTable.ObjData.OType.Name}={DPSlave.OTypeValue}", null, null,
                GcproTable.ObjData.Text0.Name, GcproTable.ObjData.Text1.Name, GcproTable.ObjData.DPNode1.Name);

            /* ------------------old code
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
           ------------------old code */
            var recordList = new List<List<GcproExtensionLibrary.Gcpro.DbParameter>>();

            foreach (DataRow row in data.Rows)
            {
                var symbol = row.Field<string>(GcproTable.ObjData.Text0.Name);
                var description = row.Field<string>(GcproTable.ObjData.Text1.Name);
                var dpNode1 = row.Field<double>(GcproTable.ObjData.DPNode1.Name);
                var recordParameters = new List<GcproExtensionLibrary.Gcpro.DbParameter>
                {
                    new GcproExtensionLibrary.Gcpro.DbParameter
                    {
                        Name = GcproTable.TranslationCbo.FieldClass.Name,
                        Value = GcproTable.TranslationCbo.Class_ASWInDPFault
                    },
                    new GcproExtensionLibrary.Gcpro.DbParameter
                    {
                        Name = GcproTable.TranslationCbo.FieldValue.Name,
                        Value = dpNode1
                    },
                    new GcproExtensionLibrary.Gcpro.DbParameter
                    {
                        Name = GcproTable.TranslationCbo.FieldText.Name,
                        Value = symbol
                    },
                    new GcproExtensionLibrary.Gcpro.DbParameter
                    {
                        Name = GcproTable.TranslationCbo.FieldDescription.Name,
                        Value = description
                    }
                };

                recordList.Add(recordParameters);
            }

            oledb.InsertRecords(GcproTable.TranslationCbo.TableName, recordList);

        }

        /// <summary>
        /// Return the Field [Key] in table [ObjData]
        /// </summary>
        /// <param name="queryDataTable">OleDb类中的QueryDataTable方法的委托/param>
        /// <param name="objIOName">IO符号名称[Text0]字段</param>
        /// <returns></returns>
        public static string FindIOKey(Func<string, string, IDictionary<string, object>, string, string[], DataTable> queryDataTable, string objIOName)
        {
            string key ;
            DataTable data;
            string tableName, whereClause;
            tableName = GcproTable.ObjData.TableName;
            string[] fieldList = { GcproTable.ObjData.Key.Name };
            whereClause = $"{GcproTable.ObjData.Text0.Name} LIKE'{objIOName}%'";
            data = queryDataTable(tableName, whereClause, null, null, fieldList);
            if (data.Rows.Count != 0)
            { key = data.Rows[0].Field<int>(GcproTable.ObjData.Key.Name).ToString(); }
            else
            { key = string.Empty; }
            return key;
        }
        /// <summary>
        /// 自定义分隔符提取名称；
        /// 比如分隔符为"-VFC",输入名称"=A-1001-MXZ01-VFC"
        /// 返回字符串为"=A-1001-MXZ01"
        /// </summary>
        /// <param name="input">输入源字符串</param>
        /// <param name="delimiter">自定义分隔符</param>
        /// <returns></returns>
        public static string GetObjectSymbolFromIO(string input, string delimiter)
        {
          //  string ret = string.Empty;
            if (input.Length >= LibGlobalSource.MIN_IO_SYMBOL_LENGTH)
            {
                int index = input.IndexOf(delimiter);
                return index >= 0 ? input.Substring(0, index) : string.Empty;
            }
            else
            { return LibGlobalSource.MSG_INVALID_IO_SYMBOL; }
            
        }
        /// <summary>
        /// 根据正则表达式，提取符号名
        /// 返回除正则表达式外的字符串
        /// </summary>
        /// <param name="input">输入源字符串</param>
        /// <param name="pattern">正则表达式</param>
        /// <returns></returns>
        public static string GetObjectSymbolFromPattern(string input, string pattern)
        {
            string match = LibGlobalSource.StringHelper.ExtractStringPart(pattern, input);
            return string.IsNullOrEmpty(match) ? String.Empty : match.Replace(pattern, "");
        //    return ret;
        }
        /// <summary>
        /// Return the FieldbusNodeKeyin table [ObjData]
        /// </summary>
        /// <param name="queryDataTable">OleDb类中的QueryDataTable方法的委托/param>
        /// <param name="nodeName">DPNode名称[FieldText]字段</param>
        /// <returns></returns>
        public static (double, double) ParseFieldbusNodeKey(Func<string, string, IDictionary<string, object>, string, string[], DataTable> queryDataTable, string nodeName)
        {
            double dpNodeNo = LibGlobalSource.NO_DP_NODE;
            double fieldbusNodeKey = LibGlobalSource.NO_DP_NODE;
            if (string.IsNullOrEmpty(nodeName))
            {
                return (dpNodeNo, fieldbusNodeKey);
            }
            else
            { 
                DataTable data;
                string tableName, whereClause;
                tableName = GcproTable.TranslationCbo.TableName;
                string[] fieldList = { GcproTable.TranslationCbo.FieldValue.Name };
                whereClause = $@"{GcproTable.TranslationCbo.FieldText.Name} LIKE '{nodeName}%' AND {GcproTable.TranslationCbo.FieldClass.Name} = '{GcproTable.TranslationCbo.Class_ASWInDPFault}'";
                data = queryDataTable(tableName, whereClause, null, null, fieldList);
                if (data.Rows.Count != 0)
                { dpNodeNo = data.Rows[0].Field<double>(GcproTable.TranslationCbo.FieldValue.Name); }
                else
                {
                    dpNodeNo = fieldbusNodeKey = LibGlobalSource.NO_DP_NODE;
                    return (dpNodeNo, fieldbusNodeKey);
                }
                tableName = GcproTable.ObjData.TableName;
                fieldList = new string[] { GcproTable.ObjData.Key.Name };
                whereClause = $"({GcproTable.ObjData.SubType.Name}='Profinet' OR {GcproTable.ObjData.SubType.Name}='Profibus') AND {GcproTable.ObjData.DPNode1.Name}={dpNodeNo}";
                data = queryDataTable(tableName, whereClause, null, null, fieldList);
                fieldbusNodeKey = data.Rows.Count != 0 ? data.Rows[0].Field<int>(GcproTable.ObjData.Key.Name) : LibGlobalSource.NO_DP_NODE;
                return (dpNodeNo, fieldbusNodeKey);
            }
        }
        /// <summary>
        /// Return the FieldbusNode
        /// </summary>
        /// <param name="queryDataTable">OleDb类中的QueryDataTable方法的委托/param>
        /// <param name="nodeNo">DPNode</param>
        /// <returns></returns>
        public static double FindFieldbusNodeKey(Func<string, string, IDictionary<string,object>, string, string[], DataTable> queryDataTable, double nodeNo)
        {
            double key ;
            DataTable data;    
            string tableName, whereClause;
            tableName = GcproTable.ObjData.TableName;
            string[] fieldList = { GcproTable.ObjData.Key.Name };
            whereClause = $"({GcproTable.ObjData.SubType.Name}='Profinet' OR {GcproTable.ObjData.SubType.Name}='Profibus') AND {GcproTable.ObjData.DPNode1.Name}={nodeNo}";  
            data = queryDataTable(tableName, whereClause,null,null, fieldList);
            if (data.Rows.Count != 0)
            { key = data.Rows[0].Field<double>(GcproTable.ObjData.Key.Name); }
            else
            { key = 0; }
            return key;
        }

        /// <summary>
        /// Return the DPNodeNo in table [TranslationCbo]
        /// </summary>
        /// <param name="queryDataTable">OleDb类中的QueryDataTable方法的委托/param>
        /// <param name="nodeName">DPNode名称[FieldText]字段</param>
        /// <returns></returns>
        public static double FindDPNodeNo(Func<string, string, IDictionary<string, object>, string, string[], DataTable> queryDataTable, string nodeName)
        {
            double key ;
            DataTable data;          
            string tableName, whereClause;
            tableName = GcproTable.TranslationCbo.TableName;
            string[] fieldList = { GcproTable.TranslationCbo.FieldValue.Name };
            whereClause = $@"{GcproTable.TranslationCbo.FieldText.Name} LIKE '{nodeName}%' AND {GcproTable.TranslationCbo.FieldClass.Name} = '{GcproTable.TranslationCbo.Class_ASWInDPFault}'";
            data = queryDataTable(tableName, whereClause, null, null, fieldList);
            if (data.Rows.Count != 0)
            { key = data.Rows[0].Field<double>(GcproTable.TranslationCbo.FieldValue.Name); }
            else
            { key = 0; }
            return key;
        }
        /// <summary>
        /// 定义事件委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void GcObjectEventHandler(object sender, EventArgs e);
         /// <summary>
         /// 
         /// </summary>
        protected void SetObjParameters()
        {

        }
    }
}
