using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class Bin : GcObject
    {
        public struct BinRule
        {
            public GcBaseRule Common;

        }
        public static BinRule Rule;
        private string name;
        private string description;
        private string subType;
        private string processFct;
        private string building;
        private string elevation;
        private double fieldBusNode;
        private string panel_ID;
        private int diagram;
        private string page;
        private string isNew;

        private string filePath;
        private readonly string fileRelationPath;
        private readonly string fileConnectorPath;
        private readonly static string binFileName = $@"\{OTypeCollection.Bin}";
        private double parBinNo;
        private double parEmptyingTime;
        private double parOverfillingWeight;
        private double parDryFillingWeight;
        private double parRestdischargeWeight;
        private string highLevel;
        private string middleLevel;
        private string lowLevel;
        private string analogLevel;
        private string highLevelRemote;
        private string middleLevelRemote;
        private string lowLevelRemote;
        private string inFillLevelRemote;
        private double value24;
        private double value30;
        private double value31;
        #region Standard properties
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string Description
        {
            get { return description; }
            set { description = value; }
        }
        public override string SubType
        {
            get { return subType; }
            set { subType = value; }
        }
        public override string ProcessFct
        {
            get { return processFct; }
            set { processFct = value; }
        }
        public override string Building
        {
            get { return building; }
            set { building = value; }
        }
        public override string Elevation
        {
            get { return elevation; }
            set { elevation = value; }
        }
        public override double FieldBusNode
        {
            get { return fieldBusNode; }
            set { fieldBusNode = value; }
        }
        public override string Panel_ID
        {
            get { return panel_ID; }
            set { panel_ID = value; }
        }
        public override int Diagram
        {
            get { return diagram; }
            set { diagram = value; }
        }
        public override string Page
        {
            get { return page; }
            set { page = value; }
        }
        #endregion
        #region Application properties
        public double ParBinNo
        {
            get { return parBinNo; }
            set { parBinNo = value; }
        }
        public double ParEmptyingTime
        {
            get { return parEmptyingTime; }
            set { parEmptyingTime = value; }
        }
        public double ParOverfillingWeight
        {
            get { return parOverfillingWeight; }
            set { parOverfillingWeight = value; }
        }
        public double ParDryFillingWeight
        {
            get { return parDryFillingWeight; }
            set { parDryFillingWeight = value; }
        }
        public double ParRestdischargeWeight
        {
            get { return parRestdischargeWeight; }
            set { parRestdischargeWeight = value; }
        }
        public string HighLevel
        {
            get { return highLevel; }
            set { highLevel = value; }
        }
        public string MiddleLevel
        {
            get { return middleLevel; }
            set { middleLevel = value; }
        }
        public string LowLevel
        {
            get { return lowLevel; }
            set { lowLevel = value; }
        }
        public string AnalogLevel
        {
            get { return analogLevel; }
            set { analogLevel = value; }
        }
        public string HighLevelRemote
        {
            get { return highLevelRemote; }
            set { highLevelRemote = value; }
        }
        public string MiddleLevelRemote
        {
            get { return middleLevelRemote; }
            set { middleLevelRemote = value; }
        }
        public string LowLevelRemote
        {
            get { return lowLevelRemote; }
            set { lowLevelRemote = value; }
        }
        public string InFillLevel
        {
            get { return inFillLevelRemote; }
            set { inFillLevelRemote = value; }
        }
        public double Value24
        {
            get { return value24; }
            set { value24 = value; }
        }
        public double Value30
        {
            get { return value30; }
            set { value30 = value; }
        }
        public double Value31
        {
            get { return value31; }
            set { value31 = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string FileRelationPath
        {
            get { return fileRelationPath; }
        }
        public string FileConnectorPath
        {
            get { return fileConnectorPath; }
        }
        #endregion
        #region Readonly property
        public static string BINB { get; } = "BINB";
        public static string BING { get; } = "BING";
        public static string BINM { get; } = "BINM";
        public static string ImpExpRuleName { get; } = "IE_Bin";
        public static int OTypeValue { get; } = (int)OTypeCollection.Bin;
        #endregion
        public Bin()
        {
            string noChild = LibGlobalSource.NOCHILD;
            Rule.Common.DescriptionRuleInc = "1";
            Rule.Common.NameRuleInc = "1";
            subType = BINB;
            parEmptyingTime = 0;
            parOverfillingWeight = 100;
            parDryFillingWeight = 0;
            parRestdischargeWeight = 0;
            highLevel = string.Empty;
            middleLevel = string.Empty;
            lowLevel = string.Empty;
            analogLevel = string.Empty;
            highLevelRemote = noChild;
            middleLevelRemote = noChild;
            lowLevelRemote = noChild;
            inFillLevelRemote = noChild;
            value24 = 4;
            value30 = 0;
            value31 = 4;
            SetOTypeProperty(OTypeCollection.Bin);
            string commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{binFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_FindConnector.Txt";
        }
        public Bin(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{binFileName}";
            commonUserFilePath = $"{filePath}{binFileName}";
            bool defaultPath = string.IsNullOrWhiteSpace(filePath);
            this.filePath = defaultPath ?
                $"{commonDefaultFilePath}.Txt" : $"{commonUserFilePath}.Txt";
            this.fileRelationPath = defaultPath ?
                $"{commonDefaultFilePath}_Relation.Txt" : $"{commonUserFilePath}_Relation.Txt";
            this.fileConnectorPath = defaultPath ?
                $"{commonDefaultFilePath}_FindConnector.Txt" : $"{commonUserFilePath}_FindConnector.Txt";
        }
        /// 创建GCPRO对象与与对象关系文件
        /// </summary>
        /// <param name="textFileHandle">TextFileHandle类实例</param>
        /// <param name="sbObjFields">StringBuilder类实例</param>
        /// <param name="encoding">文本文件的导入编码</param>
        /// <param name="onlyRelation">=true时,仅创建关系文件；=false时,同时创建对象与对象关系导入文件</param>
        public void CreateObject(TextFileHandle textFileHandle, StringBuilder sb, Encoding encoding, bool onlyRelation = false)
        {
            if (!onlyRelation)
            {
                textFileHandle.FilePath = this.filePath;
                isNew = "False";
                string tab = LibGlobalSource.TAB;
                string noChild = LibGlobalSource.NOCHILD;
                ///<summary>
                ///生产Standard字符串部分
                ///</summary> 
                string objBase = base.CreateObjectStandardPart(sb);
                sb.Clear();
                sb.Append(OTypeValue).Append(tab)
                  .Append(objBase).Append(tab);
                ///<summary>
                ///生成Application 字符串部分
                ///</summary>
                sb.Append(parBinNo).Append(tab)
                  .Append(parEmptyingTime).Append(tab)
                  .Append(parOverfillingWeight).Append(tab)
                  .Append(parDryFillingWeight).Append(tab)
                  .Append(parRestdischargeWeight).Append(tab)
                  .Append(highLevelRemote).Append(tab)
                  .Append(middleLevelRemote).Append(tab)
                  .Append(lowLevelRemote).Append(tab)
                  .Append(inFillLevelRemote).Append(tab)
                  .Append(value24).Append(tab)
                  .Append(value30).Append(tab)
                  .Append(value31).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild);
                textFileHandle.WriteToTextFile(sb.ToString(), encoding);
                sb.Clear();
            }

            var relations = new List<Relation>
            {
                new Relation(name,highLevel, GcproTable.ObjData.Value2.Name),
                new Relation(name,middleLevel, GcproTable.ObjData.Value4.Name),
                new Relation(name,lowLevel, GcproTable.ObjData.Value3.Name),
                new Relation(name,analogLevel, GcproTable.ObjData.Value14.Name),
            };
            textFileHandle.FilePath = this.fileRelationPath;
            sb.Clear();
            CreateRelations(textFileHandle, sb, relations, encoding);  
        }

        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle
            {
                FilePath = this.filePath
            };
            textFileHandle.ClearContents();
            textFileHandle.FilePath = this.fileRelationPath;
            textFileHandle.ClearContents();
            //textFileHandle.FilePath = this.fileConnectorPath;
            //textFileHandle.ClearContents();
        }
        /// <summary>
        /// 向数据库ImpExpDef中插入对象的导入定义
        /// </summary>
        /// <param name="insertMultipleRecords">传入一个Oledb类中InsertMultipleRecords方法的委托</param>
        /// <returns></returns>
        public bool CreateImpExpDef(Func<string, List<List<Gcpro.DbParameter>>, bool> insertMultipleRecords)
        {
            List<List<Gcpro.DbParameter>> impExpList = new List<List<Gcpro.DbParameter>>();
            string tableName = GcproTable.ImpExpDef.TableName;
            base.CreateImpExpDef(impExpList, ImpExpRuleName);
            #region  #region Add records list
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "BinNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value1.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "EmptyingTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OverfillingWeight"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DryFillingWeight"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "RestdischargeWeight"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "HighLevelRemote" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value41.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "MiddleLevelRemote"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LowLevelRemote"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value43.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InFillLevelRemote"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value44.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue24" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="GCPRO"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value30.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "WinCos.r2"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "HighLevel"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value2.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "MiddleLevel"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value4.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LowLevel"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value3.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "AnalogLevel"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name}

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }

    }
}
