using GcproExtensionLibrary.FileHandle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{

    public class Discharger : Machine
    {
        public struct DischargerdRule
        {
            public GcBaseRule Common;
            public string Discharger, DischargerRule;
            public string Vibro, VibroRule;
            public string LSFlow, LSFlowRule;
            public string LLBin, LLBinRule;
            public string Receiver, ReceiverRule;
            public string SenderBin, SenderBinRule;
            public int DischargerRuleInc, VibroRuleInc, LSFlowRuleInc,LLBinRuleInc, ReceiverRuleInc, SenderBinRuleInc;
        }
        private string filePath;
        private readonly string fileRelationPath;
        private readonly string fileConnectorPath;
        private readonly static string dischargerFileName = $@"\{OTypeCollection.MA_Discharger}";
        public static DischargerdRule Rule;
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
        private double pType;
        private double value10;
        private string discharger;
        private string vibro;
        private string lsFlow;
        private string llBin;
        private double parVibrOnTime;
        private double parVibrOffTime;
        private double parRestDischargeTime;
        private string refReceiver;
        private string refSenderBin;
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
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        #endregion
        #region Application properties 
        public override double Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
     
        public string DischargerChild
        {
            get { return discharger; }
            set { discharger = value; }
        }
        public string Vibro
        {
            get { return vibro; }
            set { vibro = value; }
        }

        public string LSFlow
        {
            get { return lsFlow; }
            set { lsFlow = value; }
        }
        public string LLBin
        {
            get { return llBin; }
            set { llBin = value; }
        }
        public double ParVibroOnTime
        {
            get { return parVibrOnTime; }
            set { parVibrOnTime = value; }
        }
        public double ParVibroOffTime
        {
            get { return parVibrOffTime; }
            set { parVibrOffTime = value; }
        }

        public double ParRestDischargeTime
        {
            get { return parRestDischargeTime; }
            set { parRestDischargeTime = value; }
        }
        public string RefReceiver
        {
            get { return refReceiver; }
            set { refReceiver = value; }
        }

        public string RefSenderBin
        {
            get { return refSenderBin; }
            set { refSenderBin = value; }
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
        public static string FB56 { get; } = "FB56";
        public static string FB56BRAN { get; } = "FB56BRAN";
        public static string FB56FLOUR { get; } = "FB56FLOUR";
        public static float P2056 { get; } = 2045f;
        public static string ImpExpRuleName { get; } = "IE_MA_Discharger";
        public static int OTypeValue { get; } = (int)OTypeCollection.MA_Discharger;
        #endregion

        public Discharger()
        {
            string commonDefaultFilePath;
            pType = P2056;
            value10 = 16;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.DischargerRuleInc =  1;
            Rule.VibroRuleInc = 1;
            Rule.LLBinRuleInc = Rule.LSFlowRuleInc = 1;
            Rule.ReceiverRuleInc = Rule.SenderBinRuleInc = 1;
            SetOTypeProperty(OTypeCollection.MA_Discharger);
            objectRecord = new List<string>();
            objectRelation = new List<string>();
            relation = new Relation();
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{dischargerFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_FindConnector.Txt";
        }
        public Discharger(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{dischargerFileName}";
            commonUserFilePath = $"{filePath}{dischargerFileName}";
            bool defaultPath = string.IsNullOrWhiteSpace(filePath);
            this.filePath = defaultPath ?
                $"{commonDefaultFilePath}.Txt" : $"{commonUserFilePath}.Txt";
            this.fileRelationPath = defaultPath ?
                $"{commonDefaultFilePath}_Relation.Txt" : $"{commonUserFilePath}_Relation.Txt";
            this.fileConnectorPath = defaultPath ?
                $"{commonDefaultFilePath}_FindConnector.Txt" : $"{commonUserFilePath}_FindConnector.Txt";
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
                sb.Append(noChild).Append(tab)
                    .Append(noChild).Append(tab)
                    .Append(noChild).Append(tab)
                    .Append(noChild).Append(tab)
                    .Append(parVibrOnTime * 10).Append(tab)
                    .Append(parVibrOffTime * 10).Append(tab)
                    .Append(parRestDischargeTime * 10).Append(tab)
                    .Append(noChild).Append(tab)
                    .Append(noChild);
                objectRecord.Add(sb.ToString());
                sb.Clear();
            }

            CreateRelation(sb, name, discharger, GcproTable.ObjData.Value11.Name);
            CreateRelation(sb, name, vibro, GcproTable.ObjData.Value12.Name);
            CreateRelation(sb, name, llBin, GcproTable.ObjData.Value13.Name);
            CreateRelation(sb, name, lsFlow, GcproTable.ObjData.Value14.Name);
            CreateRelation(sb, name, refReceiver, GcproTable.ObjData.Value41.Name);
            CreateRelation(sb, name, refSenderBin, GcproTable.ObjData.Value42.Name);

            sb.Clear();
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Discharger"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Vibro"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LS Flow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LL Bin"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "VibroOnTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "VibroOffTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "RestDischargeTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Receiver"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value41.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Sender bin"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name }

            });                  
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}