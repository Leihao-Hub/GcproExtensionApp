using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
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
        public abstract string FieldBusNode { get; set; }
        public abstract string Panel_ID { get; set; }
        public abstract string Diagram { get; set; }
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
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = filePath;
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
            bool result;
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = sourceFilePath;
            result = textFileHandle.SaveFileAs(title);
            return result;
        }
        /// <summary>
        /// 创建对象标准部分字符串
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string CreateObjectStandardPart(Encoding encoding)
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
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = filePath;
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
        public string EncodingDesc(ref GcBaseRule baseRule, string namePrefix, bool withLineInfo = true, bool withFloorInfo = true, bool withNameInfo = true, bool withCabinet = false,bool withPower =false ,bool nameOnlyWithNumber = true,bool removeNamePrefix = true)
        {
            StringBuilder desc = new StringBuilder();
            baseRule.NameRule = LibGlobalSource.StringHelper.ExtractNumericPart(baseRule.Name, false);
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
                string name = baseRule.Name;
                if (removeNamePrefix)
                { name = name.Contains(namePrefix) ? name.Replace(namePrefix, string.Empty) : name; }              
                baseRule.DescName = nameOnlyWithNumber ? $"({baseRule.NameRule})" : $"({name})";
                desc.Append(baseRule.DescName);
            }

            desc.Append(baseRule.DescObject);
            if (withCabinet && !String.IsNullOrEmpty(baseRule.Cabinet) || withPower && String.IsNullOrEmpty(baseRule.Power))
            {
                desc.Append("[");
                if (withCabinet)
                {
                    desc.Append($"{baseRule.Cabinet}");
                }
                if (withPower)
                {
                    desc.Append(" ");
                    desc.Append(baseRule.Power);
                }
                desc.Append("]");
            }
        
            baseRule.Description = desc.ToString();
            return baseRule.Description;
        } 
        public void DecodingDesc(ref GcBaseRule baseRule, string descSeparator)
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
 
    }
}
