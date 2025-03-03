using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class ScaleAdapter : Element
    {
        public struct ScaleAdapterRule
        {
            public GcBaseRule Common;
            public int ioByteInc;
        }
        public static ScaleAdapterRule Rule;
        private string filePath;
        private readonly string fileRelationPath;
        //   private string fileConnectorPath;
        private readonly static string scaleAdapterFileName = $@"\{OTypeCollection.EL_ScaleAdapter}";
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
        private double dpNode2;
        private string hwStop;
        private string inpFaultDev;
        private string inpWeightPulse;
        private string outpFaultReset;
        private double parTimeoutStart;
        private double parPulseWeight;
        private double inFlowrate;
        private double inPreCutoffWeight;
        private double inFlowrateLowLimit;
        private double inFlowrateHighLimit;
        private double inDumpWeight;
        private double value9;
        private double value10;
        private double value60;
        private double ioByteNo;
        private string refSenderBin;
        private string refFluidliftAirlock;
        private string refAdapter;
        private string refChannelID;
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
        public double DPNode2
        {
            get { return dpNode2; }
            set { dpNode2 = value; }
        }
        public string HwStop
        {
            get { return hwStop; }
            set { hwStop = value; }
        }

        public string InpFaultDev
        {
            get { return inpFaultDev; }
            set { inpFaultDev = value; }
        }

        public string InpWeightPulse
        {
            get { return inpWeightPulse; }
            set { inpWeightPulse = value; }
        }

        public string OutpFaultReset
        {
            get { return outpFaultReset; }
            set { outpFaultReset = value; }
        }

        public double ParTimeoutStart
        {
            get { return parTimeoutStart; }
            set { parTimeoutStart = value; }
        }

        public double ParPulseWeight
        {
            get { return parPulseWeight; }
            set { parPulseWeight = value; }
        }
        public double InFlowrate
        {
            get { return inFlowrate; }
            set { inFlowrate = value; }
        }

        public double InPreCutoffWeight
        {
            get { return inPreCutoffWeight; }
            set { inPreCutoffWeight = value; }
        }

        public double InFlowrateLowLimit
        {
            get { return inFlowrateLowLimit; }
            set { inFlowrateLowLimit = value; }
        }

        public double InFlowrateHighLimit
        {
            get { return inFlowrateHighLimit; }
            set { inFlowrateHighLimit = value; }
        }

        public double InDumpWeight
        {
            get { return inDumpWeight; }
            set { inDumpWeight = value; }
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
        public double Value60
        {
            get { return value60; }
            set { value60 = value; }
        }
        public double IoByteNo
        {
            get { return ioByteNo; }
            set { ioByteNo = value; }
        }
    
        public string RefSenderBin
        {
            get { return refSenderBin; }
            set { refSenderBin = value; }
        }

        public string RefFluidliftAirlock
        {
            get { return refFluidliftAirlock; }
            set { refFluidliftAirlock = value; }
        }

        public string RefAdapter
        {
            get { return refAdapter; }
            set { refAdapter = value; }
        }

        public string RefChannelID
        {
            get { return refChannelID; }
            set { refChannelID = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
  
        #endregion
        #region Readonly  property
        public static string FB801 { get; } = "FB801";
        public static string FB801DP { get; } = "FB801DP";
        public static string _1801SwiscaCervo { get; } = "1801SwiscaCervo";
        public static string _1801SwiscaFloba { get; } = "1801SwiscaFloba";
        public static string _1801SwiscaGrano { get; } = "1801SwiscaGrano";
        public static string _1801SwiscaMicro { get; } = "1801SwiscaMicro";
        public static float P7601 { get; } = 7601f;
        public static float P7602 { get; } = 7602f;
        public static string ImpExpRuleName { get; } = "IE_EL_ScaleAdapter";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_ScaleAdapter;
        #endregion
        public ScaleAdapter()
        {
            string commonDefaultFilePath;
            value10 = 66;
            value9 =196608;
            value60 = 0;
            pType = P7601;
            hornCode = 0;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            SetOTypeProperty(OTypeCollection.EL_MDDx);
            objectRecord = new List<string>();
            objectRelation = new List<string>();
            relation = new Relation();
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{scaleAdapterFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
        }
        public ScaleAdapter(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{scaleAdapterFileName}";
            commonUserFilePath = $"{filePath}{scaleAdapterFileName}";
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
                  .Append(ioByteNo).Append(tab)
                  .Append(value9).Append(tab)
                  .Append(value60).Append(tab)
                  .Append(parTimeoutStart * 10).Append(tab)
                  .Append(parPulseWeight).Append(tab)
                  .Append(inFlowrate).Append(tab)
                  .Append(inPreCutoffWeight).Append(tab)
                  .Append(inFlowrateLowLimit).Append(tab)
                  .Append(inFlowrateHighLimit).Append(tab)
                  .Append(inDumpWeight).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild);
                objectRecord.Add(sb.ToString());
                sb.Clear();
            }
            if (refSenderBin != null)
            {
                CreateRelation(sb,  name, refSenderBin, GcproTable.ObjData.Value42.Name);
            }
            if (refFluidliftAirlock != null)
            {
                CreateRelation(sb,  name, refFluidliftAirlock, GcproTable.ObjData.Value43.Name);
            }
            
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "IOByteNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue60"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value60.Name }

            });      
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTimeOutStarts" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value51.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParPulseWeight"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InFlowrate"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value28.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InPreCutoffWeight"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InFlowrateLowLimit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InFlowrateHighLimit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value27.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InDumpWeight"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Sender Bin" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="FluidLift Airlock"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value43.Name }

            });      
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }

}
