﻿using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class MDDYZ : Element, IGcpro
    {
        public struct MDDYZRule
        {
            public GcBaseRule Common;
        }
        public static MDDYZRule Rule;
        private string filePath;
        private string fileRelationPath;
        //   private string fileConnectorPath;
        private static string mddyzFileName = $@"\{OTypeCollection.EL_MDDYZ}";
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
        private string value10;
        private string value21;
        private string ioByteNo;
        private MYTARef side1Top;
        private MYTARef side1Bottom;
        private MYTARef side2Top;
        private MYTARef side2Bottom;

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

        public string IoByteNo
        {
            get { return ioByteNo; }
            set { ioByteNo = value; }
        }
        public override string Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public string ParTimeOutStart
        {
            get { return value21; }
            set { value21 = value; }
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
            value10 = "80";
            value21 = "100";
            SetOTypeProperty(OTypeCollection.EL_MDDYZ);
            side1Top = new MYTARef("", 1);
            side1Bottom = new MYTARef("", 2);
            side2Top = new MYTARef("", 3);
            side2Bottom = new MYTARef("", 4);
            pType = P7755_1.ToString();
            hornCode = LibGlobalSource.NOCHILD;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddyzFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddyzFileName + "_Relation.Txt";
        }
        public MDDYZ(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddyzFileName + ".Txt" : filePath + mddyzFileName + ".Txt");
            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                        LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + mddyzFileName + ".Txt" : filePath + mddyzFileName + "_Relation.Txt");
        }
        /// <summary>
        /// 创建GCPRO对象与与对象关系文件
        /// </summary>
        /// <param name="encoding">文本文件的导入编码</param>
        /// <param name="onlyRelation">=true时,仅创建关系文件；=false时,同时创建对象与对象关系导入文件</param>
        public void CreateObject(Encoding encoding, bool onlyRelation = false)
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            isNew = "False";
            StringBuilder objFields = new StringBuilder();
            ///<summary>
            ///生产Standard字符串部分-使用父类中方法实现
            ///</summary> 
            objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
              .Append(base.CreateObjectStandardPart(encoding)).Append(LibGlobalSource.TAB);
            ///<summary>
            ///生成Application字符串部分-子类中自身完成
            ///</summary>  
            objFields.Append(ioByteNo).Append(LibGlobalSource.TAB)
              .Append(value21).Append(LibGlobalSource.TAB)
             .Append(string.Empty).Append(LibGlobalSource.TAB)
             .Append(Convert.ToString(side1Top.PassageNo)).Append(LibGlobalSource.TAB)
             .Append(string.Empty).Append(LibGlobalSource.TAB)
             .Append(Convert.ToString(side1Bottom.PassageNo)).Append(LibGlobalSource.TAB)
             .Append(string.Empty).Append(LibGlobalSource.TAB)
             .Append(Convert.ToString(side2Top.PassageNo)).Append(LibGlobalSource.TAB)
             .Append(string.Empty).Append(LibGlobalSource.TAB)
             .Append(Convert.ToString(side2Bottom.PassageNo));
            textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            objFields = null;

            var relations = new List<Relation>
            {
                new Relation(name,side1Top.MYTA, GcproTable.ObjData.Value32.Name),
                new Relation(name,side1Bottom.MYTA, GcproTable.ObjData.Value33.Name),
                new Relation(name,side2Top.MYTA, GcproTable.ObjData.Value34.Name),
                new Relation(name,side2Bottom.MYTA, GcproTable.ObjData.Value35.Name),
            };
            CreateRelations(relations, this.fileRelationPath, encoding);
        }
        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
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
