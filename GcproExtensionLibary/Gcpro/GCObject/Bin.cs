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
        private string fieldBusNode;
        private string panel_ID;
        private string diagram;
        private string page;
        private string isNew;

        private string filePath;
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string binFileName = $@"\{OTypeCollection.Bin}";
        private string parBinNo;
        private string parEmptyingTime;
        private string parOverfillingWeight;
        private string parDryFillingWeight;
        private string parRestdischargeWeight;
        private string highLevel;
        private string middleLevel;
        private string lowLevel;
        private string analogLevel;
        private string highLevelRemote;
        private string middleLevelRemote;
        private string lowLevelRemote;
        private string inFillLevelRemote;
        private string value24;
        private string value30;
        private string value31;
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
        public override string FieldBusNode
        {
            get { return fieldBusNode; }
            set { fieldBusNode = value; }
        }
        public override string Panel_ID
        {
            get { return panel_ID; }
            set { panel_ID = value; }
        }
        public override string Diagram
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
        public string ParBinNo
        {
            get { return parBinNo; }
            set { parBinNo = value; }
        }
        public string ParEmptyingTime
        {
            get { return parEmptyingTime; }
            set { parEmptyingTime = value; }
        }
        public string ParOverfillingWeight
        {
            get { return parOverfillingWeight; }
            set { parOverfillingWeight = value; }
        }
        public string ParDryFillingWeight
        {
            get { return parDryFillingWeight; }
            set { parDryFillingWeight = value; }
        }
        public string ParRestdischargeWeight
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
        public string Value24
        {
            get { return value24; }
            set { value24 = value; }
        }
        public string Value30
        {
            get { return value30; }
            set { value30 = value; }
        }
        public string Value31
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
            Rule.Common.DescriptionRuleInc = "1";
            Rule.Common.NameRuleInc = "1";
            subType = BINB;
            parEmptyingTime = LibGlobalSource.NOCHILD;
            parOverfillingWeight = "100";
            parDryFillingWeight = LibGlobalSource.NOCHILD;
            parRestdischargeWeight = LibGlobalSource.NOCHILD;
            highLevel = string.Empty;
            middleLevel = string.Empty;
            lowLevel = string.Empty;
            analogLevel = string.Empty;
            highLevelRemote = LibGlobalSource.NOCHILD;
            middleLevelRemote = LibGlobalSource.NOCHILD;
            lowLevelRemote = LibGlobalSource.NOCHILD;
            inFillLevelRemote = LibGlobalSource.NOCHILD;
            value24 = "4";
            value30 = LibGlobalSource.NOCHILD;
            value31 = "4";
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
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
            $"{commonDefaultFilePath}.Txt" : $"{commonUserFilePath}.Txt");
            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                $"{commonDefaultFilePath}._Relation.Txt" : $"{commonUserFilePath}._Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                $"{commonDefaultFilePath}._FindConnector.Txt" : $"{commonUserFilePath}._FindConnector.Txt");       
        }
        /// <summary>
        /// 创建GCPRO对象与与对象关系文件
        /// </summary>
        /// <param name="encoding">文本文件的导入编码</param>
        /// <param name="onlyRelation">=true时,仅创建关系文件；=false时,同时创建对象与对象关系导入文件</param>
        public void CreateObject(Encoding encoding, bool onlyRelation = false)
        {
            if (!onlyRelation)
            {
                TextFileHandle textFileHandle = new TextFileHandle();
                textFileHandle.FilePath = this.filePath;
                isNew = "false";
                StringBuilder objFields = new StringBuilder();
                ///<summary>
                ///生产Standard字符串部分
                ///</summary> 
                objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
                  .Append(base.CreateObjectStandardPart(encoding)).Append(LibGlobalSource.TAB);
                ///<summary>
                ///生成Application 字符串部分
                ///</summary>
                objFields.Append(parBinNo).Append(LibGlobalSource.TAB)
                  .Append(parEmptyingTime).Append(LibGlobalSource.TAB)
                  .Append(parOverfillingWeight).Append(LibGlobalSource.TAB)
                  .Append(parDryFillingWeight).Append(LibGlobalSource.TAB)
                  .Append(parRestdischargeWeight).Append(LibGlobalSource.TAB)
                  .Append(highLevelRemote).Append(LibGlobalSource.TAB)
                  .Append(middleLevelRemote).Append(LibGlobalSource.TAB)
                  .Append(lowLevelRemote).Append(LibGlobalSource.TAB)
                  .Append(inFillLevelRemote).Append(LibGlobalSource.TAB)
                  .Append(value24).Append(LibGlobalSource.TAB)
                  .Append(value30).Append(LibGlobalSource.TAB)
                  .Append(value31).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD);
                textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
                objFields = null;
            }

            var relations = new List<Relation>
            {
                new Relation(name,highLevel, GcproTable.ObjData.Value2.Name),
                new Relation(name,middleLevel, GcproTable.ObjData.Value4.Name),
                new Relation(name,lowLevel, GcproTable.ObjData.Value3.Name),
                new Relation(name,analogLevel, GcproTable.ObjData.Value14.Name),
            };
            CreateRelations(relations, this.fileRelationPath, encoding);

            //if (!string.IsNullOrEmpty(highLevel))
            //{
            //    CreateRelation(name, highLevel, GcproTable.ObjData.Value2.Name, this.fileRelationPath, encoding);
            //}
            //if (!string.IsNullOrEmpty(middleLevel))
            //{
            //    CreateRelation(name, middleLevel, GcproTable.ObjData.Value4.Name, this.fileRelationPath, encoding);
            //}
            //if (!string.IsNullOrEmpty(lowLevel))
            //{
            //    CreateRelation(name, lowLevel, GcproTable.ObjData.Value3.Name, this.fileRelationPath, encoding);
            //}
            //if (!string.IsNullOrEmpty(analogLevel))
            //{
            //    CreateRelation(name, analogLevel, GcproTable.ObjData.Value14.Name, this.fileRelationPath, encoding);
            //}
        }

        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
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
