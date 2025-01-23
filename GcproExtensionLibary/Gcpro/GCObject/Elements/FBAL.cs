using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class FBAL : Element, IGcpro
    {
        public struct FBALRule
        {
            public GcBaseRule Common;
            public int ioByteInc;
        }
        public static FBALRule Rule;
        private string filePath;
        private readonly string fileRelationPath;
        //   private string fileConnectorPath;
        private readonly static string fbalFileName = $@"\{OTypeCollection.EL_FBAL}";
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
        private string pType;
        private string hornCode;
        private string dpNode1;
        private string dpNode2;
        private string hwStop;
        private string outpDosingEnable;
        private string parMonTime;
        private string value9;
        private string value10;
        private string value30;
        private string value31;
        private string ioByteNo;
        private string ioByteNoExt;
        private string parLoopNo;
        private string parLCAddr;
        private string refSenderBin;
        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string FileRelationPath
        {
            get { return fileRelationPath; }
        }
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
        public override string PType
        {
            get { return pType; }
            set { pType = value; }

        }
        public override string HornCode
        {
            get { return hornCode; }
            set { hornCode = value; }
        }
        public override string DPNode1
        {
            get { return dpNode1; }
            set { dpNode1 = value; }
        }
        #endregion
        #region Application properties
        public string DPNode2
        {
            get { return dpNode2; }
            set { dpNode2 = value; }
        }
        public string HwStop
        {
            get { return hwStop; }
            set { hwStop = value; }
        }
        public string OutpDosingEnable
        {
            get { return outpDosingEnable; }
            set { outpDosingEnable = value; }
        }
        public string ParMonTime
        {
            get { return parMonTime; }
            set { parMonTime = value; }
        }
        public string Value9
        {
            get { return value9; }
            set { value9 = value; }
        }
        public override string Value10
        {
            get { return value10; }
            set { value10 = value; }
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
        public string IoByteNo
        {
            get { return ioByteNo; }
            set { ioByteNo = value; }
        }
        public string IoByteNoExt
        {
            get { return ioByteNoExt; }
            set { ioByteNoExt = value; }
        }
        public string ParLoopNo
        {
            get { return parLoopNo; }
            set { parLoopNo = value; }
        }
        public string ParLCAddr
        {
            get { return parLCAddr; }
            set { parLCAddr= value; }
        }
        public string RefSenderBin
        {
            get { return refSenderBin; }
            set { refSenderBin = value; }
        }
    
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
  
        #endregion
        #region Readonly  property
        public static string MZAG22 { get; } = "MZAG22";
        public static string MZAH22 { get; } = "MZAH22";
        public static string MZAHDP { get; } = "MZAHDP";
        public static string MZDE22 { get; } = "MZDE22";
        public static string MZDEDP { get; } = "MZDEDP";
        public static string DTWxDP { get; } = "DTWxDP";
        public static float P7372 { get; } = 7372f;
        public static float P7373 { get; } = 7373f;
        public static string ImpExpRuleName { get; } = "IE_EL_FBAL";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_FBAL;
        #endregion
        public FBAL()
        {
            string commonDefaultFilePath;
            value10 = "10";
            value9 ="196608";
            value30 = "1";
            value31 = "0";
            pType = P7372.ToString();
            hornCode = LibGlobalSource.NOCHILD;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            SetOTypeProperty(OTypeCollection.EL_MDDx);
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{fbalFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
        }
        public FBAL(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{fbalFileName}";
            commonUserFilePath = $"{filePath}{fbalFileName}";
            bool defaultPath = string.IsNullOrWhiteSpace(filePath);
            this.filePath = defaultPath ?
                $"{commonDefaultFilePath}.Txt" : $"{commonUserFilePath}.Txt";
            this.fileRelationPath = defaultPath ?
                $"{commonDefaultFilePath}_Relation.Txt" : $"{commonUserFilePath}_Relation.Txt";     
        }
        /// <summary>
        /// 创建GCPRO对象与与对象关系文件
        /// </summary>
        /// <param name="encoding">文本文件的导入编码</param>
        /// <param name="onlyRelation">=true时,仅创建关系文件；=false时,同时创建对象与对象关系导入文件</param>
        public void CreateObject(Encoding encoding, bool onlyRelation = false)
        {
            TextFileHandle textFileHandle = new TextFileHandle
            {
                FilePath = this.filePath
            };
            isNew = "False";
            StringBuilder objFields = new StringBuilder();
            ///<summary>
            ///生产Standard字符串部分-使用父类中方法实现
            ///</summary> 
            objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
              .Append(base.CreateObjectStandardPart()).Append(LibGlobalSource.TAB);
            ///<summary>
            ///生成Application字符串部分-子类中自身完成
            ///</summary>  
            objFields.Append(ioByteNo).Append(LibGlobalSource.TAB)
             .Append(ioByteNoExt).Append(LibGlobalSource.TAB)
             .Append(parLoopNo).Append(LibGlobalSource.TAB)
             .Append(parLCAddr).Append(LibGlobalSource.TAB)
             .Append(value9).Append(LibGlobalSource.TAB)
             .Append(value30).Append(LibGlobalSource.TAB)
             .Append(value31).Append(LibGlobalSource.TAB)
             .Append(parMonTime).Append(LibGlobalSource.TAB)
             .Append(LibGlobalSource.NOCHILD);
            textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            var relations = new List<Relation>();       
            if (refSenderBin != null)
            {
                relations.Add(new Relation(name, refSenderBin, GcproTable.ObjData.Value42.Name));
            }
            CreateRelations(relations, this.fileRelationPath, encoding);
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
        }
        /// <summary>
        /// 向数据库ImpExpDef中插入对向的导入定义
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "IOByteNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }
            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "IOByteNoExt"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }
            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParLoopNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name }
            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParLCAddr"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name }
            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue9"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value9.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue30"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value30.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue31"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name }

            });
                     
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Sender Bin" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name}

            });     
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }

}
