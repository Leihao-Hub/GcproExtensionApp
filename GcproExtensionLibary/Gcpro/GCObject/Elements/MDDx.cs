using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class MDDx : Element, IGcpro
    {
        public struct MDDxRule
        {
            public GcBaseRule Common;
        }
        public static MDDxRule Rule;
        private string filePath;
        private readonly string fileRelationPath;
        //   private string fileConnectorPath;
        private readonly static string mddxFileName = $@"\{OTypeCollection.EL_MDDx}";
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
        private double value25;
        private double value26;
        private double value27;
        private double value28;
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
        public double Value25
        {
            get { return value25; }
            set { value25 = value; }
        }
        public double Value26
        {
            get { return value26; }
            set { value26 = value; }
        }
        public double Value27
        {
            get { return value27; }
            set { value27 = value; }
        }
        public double Value28
        {
            get { return value28; }
            set { value28 = value; }
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
        #region Readonly  property
        public static string MDDRDP { get; } = "MDDRDP";
        public static string MDDTDP { get; } = "MDDTDP";
        public static string MDDTDP2M { get; } = "MDDTDP2M";
        public static float P7365 { get; } = 7365f;
        public static float P7366 { get; } = 7366f;
        public static string ImpExpRuleName { get; } = "IE_EL_MDDx";
        public static string IOByteLen { get; } = "72";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_MDDx;
        #endregion
        public MDDx()
        {
            string commonDefaultFilePath;
            value10 = 0;
            value25 = value27 = 0;
            Value26 = 286752;
            Value28 = 804672;
            side1Top = new MYTARef("", 1);
            side1Bottom = new MYTARef("", 2);
            side2Top = new MYTARef("", 3);
            side2Bottom = new MYTARef("", 4);
            pType = P7366;
            hornCode = 0;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            SetOTypeProperty(OTypeCollection.EL_MDDx);
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{mddxFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
        }
        public MDDx(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{mddxFileName}";
            commonUserFilePath = $"{filePath}{mddxFileName}";
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
        public void CreateObject(TextFileHandle textFileHandle, StringBuilder sb,Encoding encoding, bool onlyRelation = false)
        {

            textFileHandle.FilePath = this.filePath;
            isNew = "False";
            string tab = LibGlobalSource.TAB;
            string noChild = LibGlobalSource.NOCHILD;
            ///<summary>
            ///生产Standard字符串部分-使用父类中方法实现
            ///</summary> 
            string objBase = base.CreateObjectStandardPart(sb);
            sb.Clear();
            sb.Append(OTypeValue).Append(tab)
              .Append(objBase).Append(tab);
            ///<summary>
            ///生成Application字符串部分-子类中自身完成
            ///</summary>  
            sb.Append(ioByteNo).Append(tab)
             .Append(value25).Append(tab)
             .Append(value26).Append(tab)
             .Append(value27).Append(tab)
             .Append(value28).Append(tab)
             .Append(noChild).Append(tab)
             .Append(Convert.ToString(side1Top.PassageNo)).Append(tab)
             .Append(noChild).Append(tab)
             .Append(Convert.ToString(side1Bottom.PassageNo)).Append(tab)
             .Append(noChild).Append(tab)
             .Append(Convert.ToString(side2Top.PassageNo)).Append(tab)
             .Append(noChild).Append(tab)
             .Append(Convert.ToString(side2Bottom.PassageNo));
            textFileHandle.WriteToTextFile(sb.ToString(), encoding);
            var relations = new List<Relation>
            {
                new Relation(name,side1Top.MYTA, GcproTable.ObjData.Value32.Name),
                new Relation(name,side1Bottom.MYTA, GcproTable.ObjData.Value33.Name),
                new Relation(name,side2Top.MYTA, GcproTable.ObjData.Value34.Name),
                new Relation(name,side2Bottom.MYTA, GcproTable.ObjData.Value35.Name),
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue25"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue26"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue27"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value27.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue28"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value28.Name }

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
