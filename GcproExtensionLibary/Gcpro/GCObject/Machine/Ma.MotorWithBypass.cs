﻿using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;


namespace GcproExtensionLibrary.Gcpro.GCObject
{

    public class MotorWithBypass : Machine
    {
        public struct MotorWithBypassRule
        {
            public GcBaseRule Common;
            public string Mon1, Mon1Rule, Mon1RuleInc;
            public string Mon2, Mon2Rule, Mon2RuleInc;
            public string VLS1, VLS1Rule, VLS1RuleInc;
            public string VLS2, VLS2Rule, VLS2RuleInc;
            public string Seal, SealRule, SealRuleInc;
            public string AI, AIRule, AIRuleInc;
            public string Pressure, PressureRule, PressureRuleInc;
        }
        private string filePath;
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string motorWithBypassFileName = $@"\{OTypeCollection.MA_MotorWithBypass}";
        public static MotorWithBypassRule Rule;
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
        private string pType;
        private string value10;
        private string value9;
        private string parCleaningTime;
        private string mon1;
        private string motor;
        private string vls1;
        private string mon2;
        private string vls2;
        private string seal;
        private string ai;
        private string pressure;
        private string isNew;
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
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        #endregion
        #region Application properties 
        public override string Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public string Value9
        {
            get { return value9; }
            set { value9 = value; }
        }
        public string ParCleaningTime
        {
            get { return parCleaningTime; }
            set { parCleaningTime = value; }
        }
        public string Mon1
        {
            get { return mon1; }
            set { mon1 = value; }
        }
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        public string VLS1
        {
            get { return vls1; }
            set { vls1 = value; }
        }
        public string Mon2
        {
            get { return mon2; }
            set { mon2 = value; }
        }
        public string VLS2
        {
            get { return vls2; }
            set { vls2 = value; }
        }
        public string Seal
        {
            get { return seal; }
            set { seal = value; }
        }
        public string AI
        {
            get { return ai; }
            set { ai = value; }
        }
        public string Pressure
        {
            get { return pressure; }
            set { pressure = value; }
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
        #region Readonly ptype property
        public static string ALL { get; } = "FB52";
        public static string MJZG { get; } = "MJZG";
        public static float P2052 { get; } = 2052f;
        public static string ImpExpRuleName { get; } = "IE_MA_MotorWithBypass";
        public static int OTypeValue { get; } = (int)OTypeCollection.MA_MotorWithBypass;
        #endregion

        public MotorWithBypass()
        {
            pType = P2052.ToString();
            value10 = "40";
            value9 = "0";
            parCleaningTime = "600.0";
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.Mon1RuleInc = Rule.Mon1RuleInc = "1";
            Rule.Mon2RuleInc = Rule.Mon2RuleInc = "1";
            Rule.VLS1RuleInc = Rule.VLS2RuleInc = "1";
            Rule.AIRuleInc = "1";
            Rule.SealRuleInc = "1";
            Rule.PressureRuleInc = "1";
            SetOTypeProperty(OTypeCollection.MA_MotorWithBypass);
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorWithBypassFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorWithBypassFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorWithBypassFileName + "_FindConnector.Txt";
        }
        public MotorWithBypass(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorWithBypassFileName + ".Txt" : filePath + motorWithBypassFileName + ".Txt");
            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorWithBypassFileName + "_Relation.Txt" : filePath + motorWithBypassFileName + "_Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + motorWithBypassFileName + "_FindConnector.Txt" : filePath + motorWithBypassFileName + "_FindConnector.Txt");
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
                isNew = "False";
                StringBuilder objFields = new StringBuilder();
                ///<summary>
                ///生产Standard字符串部分
                ///</summary> 
                objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
                    .Append(base.CreateObjectStandardPart(encoding)).Append(LibGlobalSource.TAB);
                ///<summary>
                ///生成Application 字符串部分
                ///</summary>         
                objFields.Append(Value9).Append(LibGlobalSource.TAB)
                    .Append(parCleaningTime).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD);
                textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
                objFields = null;
            }

            var relations = new List<Relation>
            {
               new Relation(name ,mon1 , GcproTable.ObjData.Value11.Name),
               new Relation(name ,motor , GcproTable.ObjData.Value12.Name),
               new Relation(name ,vls1 , GcproTable.ObjData.Value13.Name),
               new Relation(name ,mon2 , GcproTable.ObjData.Value14.Name),
               new Relation(name ,vls2 , GcproTable.ObjData.Value15.Name),
               new Relation(name ,seal , GcproTable.ObjData.Value16.Name),
               new Relation(name ,ai , GcproTable.ObjData.Value17.Name),
               new Relation(name ,pressure , GcproTable.ObjData.Value30.Name),
            };
            CreateRelations(relations, this.fileRelationPath, encoding);
        }
        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            textFileHandle.ClearContents();
            textFileHandle.FilePath = this.fileRelationPath;
            textFileHandle.ClearContents();
            textFileHandle.FilePath = this.fileConnectorPath;
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue9"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value9.Name }
            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParCleaningTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }
            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Mon1"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Motor"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "VLS1"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Mon2"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "VLS2"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value15.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Seal" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value16.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "AI"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value17.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Pressure"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value30.Name}

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}