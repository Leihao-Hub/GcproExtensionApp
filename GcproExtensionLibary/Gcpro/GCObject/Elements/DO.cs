using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class DO : Element
    {
        public struct DORule
        {
            public GcBaseRule Common;
        }
        private string filePath;
        private readonly string fileRelationPath;
        private readonly string fileConnectorPath;
        private readonly static string doFileName = $@"\{OTypeCollection.EL_DO}";
        public static DORule Rule;
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
        private double hornCode;
        private double dpNode1;
        private double dpNode2;
        private double value9;
        private double value10;
        private string inpRun;
        private string inpFaultDev;
        private string inpAlarmReset;
        private string inHWStop;
        private string outpRun;
        private string outpFaultReset;      
        private string outpLamp;
        private string outpFinalClearing;
        private double parStartDelay;
        private double parStartingTime;
        private double parOnTime;
        private double parOffTime;
        private double parIdlingTime;
        private double parDelayFaultTime;     
        private string refInEnable;
        private string refSenderBin;
        private string refSafetyStop;
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
        public double DPNode2
        {
            get { return dpNode2; }
            set { dpNode2 = value; }
        }
        public double Value9
        {
            get { return value9; }
            set { value9 = value; }
        }
        public override double Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public string InpRun
        {
            get { return inpRun; }
            set { inpRun = value; }
        }
        public string InpFaultDev
        {
            get { return inpFaultDev; }
            set { inpFaultDev = value; }
        }
        public string InpAlarmReset
        {
            get { return inpAlarmReset; }
            set { inpAlarmReset = value; }
        }

        public string InHWStop
        {
            get { return inHWStop; }
            set { inHWStop = value; }
        }
        public string OutpFaultReset
        {
            get { return outpFaultReset; }
            set { outpFaultReset = value; }
        }
        public string OutpRun
        {
            get { return outpRun; }
            set { outpRun = value; }
        }
        public string OutpLamp
        {
            get { return outpLamp; }
            set { outpLamp = value; }
        }
        public string OutpFinalClearing
        {
            get { return outpFinalClearing; }
            set { outpFinalClearing = value; }
        }

        public double ParStartDelay
        {
            get { return parStartDelay; }
            set { parStartDelay = value; }
        }
        public double ParStartingTime
        {
            get { return parStartingTime; }
            set { parStartingTime = value; }
        }
        public double ParOnTime
        {
            get { return parOnTime; }
            set { parOnTime = value; }
        }
        public double ParOffTime
        {
            get { return parOffTime; }
            set { parOffTime = value; }
        }
        public double ParIdlingTime
        {
            get { return parIdlingTime; }
            set { parIdlingTime = value; }
        }
        public double ParDelayFaultTime
        {
            get { return parDelayFaultTime; }
            set { parDelayFaultTime = value; }
        }
        public string RefInEnable
        {
            get { return refInEnable; }
            set { refInEnable = value; }
        }
        public string RefSenderBin
        {
            get { return refSenderBin; }
            set { refSenderBin = value; }
        }
        public string RefSafetyStop
        {
            get { return refSafetyStop; }
            set { refSafetyStop = value; }
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

        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        #endregion
        #region Readonly property
        public static string DOC { get; } = "DOC";
        public static string DOCADJREQ { get; } = "DOCADJREQ";
        public static string DOCFilter { get; } = "DOCFilter";
        public static string DOCTARWT { get; } = "DOCTARWT";
        public static string DON { get; } = "DON";
        public static string DOP { get; } = "DOP";
        public static string DOPHORN { get; } = "DOPHORN";
        public static float P7001 { get; } = 7001f;
        public static float P7002 { get; } = 7002f;
        public static float P7003 { get; } = 7003f;
        public static float P7004 { get; } = 7004f;
        public static float P7005 { get; } = 7005f;
        public static float P7006 { get; } = 7006f;
        public static float P7007 { get; } = 7007f;
        public static float P7008 { get; } = 7008f;
        public static float P7009 { get; } = 7009f;
        public static float P7010 { get; } = 7010f;
        public static float P9001 { get; } = 9001f;
        public static float P9002 { get; } = 9002f;            
        public static string ImpExpRuleName { get; } = "IE_EL_DO";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_DO;
        #endregion
        public DO()
        {
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-KFC01";
            description = "EL_DO";
            subType = "DOCFilter";
            processFct = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = 0;
            panel_ID = string.Empty;
            diagram = 0;
            page = string.Empty;
            pType = P7002;
            hornCode = 0;
            dpNode1 = 0;
            dpNode2 = 0;
            value9 = 0;
            value10 = 102;
            inpRun = LibGlobalSource.NOCHILD;
            inpFaultDev = LibGlobalSource.NOCHILD;
            inHWStop = LibGlobalSource.NOCHILD;
            outpFaultReset = LibGlobalSource.NOCHILD;
            outpRun = LibGlobalSource.NOCHILD;
            outpLamp = LibGlobalSource.NOCHILD;
            parStartDelay = 0;
            parStartingTime= 1;
            parOnTime = 0.5;
            parOffTime = 5.0;
            parIdlingTime = 0;
            parDelayFaultTime = 0;
            refInEnable = string.Empty;
            refSenderBin = string.Empty;
            refSafetyStop = string.Empty;
            SetOTypeProperty(OTypeCollection.EL_DO);
            objectRecord = new List<string>();
            objectRelation = new List<string>();
            relation = new Relation();
            string commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{doFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_FindConnector.Txt";
        }
        public DO(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{doFileName}";
            commonUserFilePath = $"{filePath}{doFileName}";
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
                sb.Append(dpNode2).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(parStartDelay).Append(tab)
                 .Append(parStartingTime).Append(tab)
                 .Append(parOnTime).Append(tab)
                 .Append(parOffTime).Append(tab)
                 .Append(parIdlingTime).Append(tab)
                 .Append(noChild).Append(tab)
                 .Append(noChild);
                objectRecord.Add(sb.ToString());
                sb.Clear();
            }

            CreateRelation(sb, name, inpRun, GcproTable.ObjData.Value11.Name);
            CreateRelation(sb, name, outpRun, GcproTable.ObjData.Value12.Name);

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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "DPNode2"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.DPNode2.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpRun"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpFaultDev"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value19.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpAlarmFaultReset"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value18.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InHWStop"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value47.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpRun"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpFaultReset"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpLamp"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpFinalClearing"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStartDelay"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStartingTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value20.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParOnTime" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParOffTime" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="ParIdlingTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayFaultTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Interlocking InEnable"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Sender Bin"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value39.Name}

            });         
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }

    }
}
