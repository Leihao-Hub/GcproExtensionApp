using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class MDDYZ : Element
    {
        public struct MDDYZRule
        {
            public GcBaseRule Common;
        }
        public static MDDYZRule Rule;
        private string filePath;
        private readonly string fileRelationPath;
        //   private string fileConnectorPath;
        private readonly static string mddyzFileName = $@"\{OTypeCollection.EL_MDDYZ}";
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
        private double pType;
        private double hornCode;
        private double dpNode1;
        private double value10;
        private double parTimeOutStart;
        private double ioByteNo;
        private readonly MYTARef side1Top;
        private readonly MYTARef side1Bottom;
        private readonly MYTARef side2Top;
        private readonly MYTARef side2Bottom;

        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string FileRelationPath
        {
            get { return fileRelationPath; }
        }
        //public string FileConnectorPath
        //{
        //    get { return fileConnectorPath; }
        //}
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
        public override double PType
        {
            get { return pType; }
            set { pType = value; }

        }
        public override double HornCode
        {
            get { return hornCode; }
            set { hornCode = value; }
        }
        public override double DPNode1
        {
            get { return dpNode1; }
            set { dpNode1 = value; }
        }
        #endregion
        #region Application properties
        public double IoByteNo
        {
            get { return ioByteNo; }
            set { ioByteNo = value; }
        }
        public override double Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public double ParTimeOutStart
        {
            get { return parTimeOutStart; }
            set { parTimeOutStart = value; }
        }

        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
        public MYTARef Side1Top
        {
            get { return side1Top; }
            set { Side1Top = value; }
        }
        public MYTARef Side1Bottom
        {
            get { return side1Bottom; }
            set { Side1Bottom = value; }
        }
        public MYTARef Side2Top
        {
            get { return side2Top; }
            set { Side2Top = value; }
        }
        public MYTARef Side2Bottom
        {
            get { return side2Bottom; }
            set { Side2Bottom = value; }
        }
        #endregion
        #region Readonly property
        public static string MDDYDP { get; } = "MDDYDP";
        public static string MDDZDP { get; } = "MDDZDP";
        public static string MRRA_4DP { get; } = "MRRA-4DP";
        public static string MRRA_8DP { get; } = "MRRA-8DP";
        public static float P7755 { get; } = 7755f;
        public static float P7755_1 { get; } = 7755.1f;
        public static string ImpExpRuleName { get; } = "IE_EL_MDDYZ";
        public static string IOByteLen { get; } = "48";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_MDDYZ;
        #endregion
        public MDDYZ()
        {
            string commonDefaultFilePath;
            value10 = 80;
            parTimeOutStart = 100;
            side1Top = new MYTARef("", 1);
            side1Bottom = new MYTARef("", 2);
            side2Top = new MYTARef("", 3);
            side2Bottom = new MYTARef("", 4);
            pType = P7755_1;
            hornCode = 0;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            SetOTypeProperty(OTypeCollection.EL_MDDYZ);
            objectRecord = new List<string>();
            objectRelation = new List<string>();
            relation = new Relation();
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{mddyzFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
        }
        public MDDYZ(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{mddyzFileName}";
            commonUserFilePath = $"{filePath}{mddyzFileName}";
            bool defaultPath = string.IsNullOrWhiteSpace(filePath);
            this.filePath = defaultPath ?
                $"{commonDefaultFilePath}.Txt" : $"{commonUserFilePath}.Txt";
            this.fileRelationPath = defaultPath ?
                $"{commonDefaultFilePath}_Relation.Txt" : $"{commonUserFilePath}_Relation.Txt";           
        }
        /// <summary>
        /// 创建对象文本与关系文件，暂存与内存中
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="onlyRelation"></param>
        public void CreateObjectRecordAndRelation(StringBuilder sb, bool onlyRelation = false)
        {
            if (!onlyRelation)
            {
                isNew = "False";
                string tab = LibGlobalSource.TAB;
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
                sb.Append(ioByteNo).Append(tab)
                   .Append(parTimeOutStart * 10).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(Convert.ToString(side1Top.PassageNo)).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(Convert.ToString(side1Bottom.PassageNo)).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(Convert.ToString(side2Top.PassageNo)).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(Convert.ToString(side2Bottom.PassageNo));
                objectRecord.Add(sb.ToString());
                sb.Clear();
            }

            CreateRelation(sb,  name, side1Top.MYTA, GcproTable.ObjData.Value32.Name);
            CreateRelation(sb,  name, side1Bottom.MYTA, GcproTable.ObjData.Value33.Name);
            CreateRelation(sb,  name, side2Top.MYTA, GcproTable.ObjData.Value34.Name);
            CreateRelation(sb,  name, side2Bottom.MYTA, GcproTable.ObjData.Value35.Name);

            sb.Clear();
        }  
        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle
            {
                FilePath = this.filePath
            };
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value20.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTimeOutStart"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Top MYTA" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Top PassageNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value36.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Bottom MYTA"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value33.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Bottom PassageNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value37.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 Top MYTA" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="Side2 Top PassageNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 Bottom MYTA"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value35.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 Bottom PassageNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value39.Name}

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}
