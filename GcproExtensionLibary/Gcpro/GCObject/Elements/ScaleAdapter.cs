using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class ScaleAdapter : Element, IGcpro
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
        private string inpFaultDev;
        private string inpWeightPulse;
        private string outpFaultReset;
        private string parTimeoutStart;
        private string parPulseWeight;
        private string inFlowrate;
        private string inPreCutoffWeight;
        private string inFlowrateLowLimit;
        private string inFlowrateHighLimit;
        private string inDumpWeight;
        private string value9;
        private string value10;
        private string value60;
        private string ioByteNo;
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

        public string ParTimeoutStart
        {
            get { return parTimeoutStart; }
            set { parTimeoutStart = value; }
        }

        public string ParPulseWeight
        {
            get { return parPulseWeight; }
            set { parPulseWeight = value; }
        }
        public string InFlowrate
        {
            get { return inFlowrate; }
            set { inFlowrate = value; }
        }

        public string InPreCutoffWeight
        {
            get { return inPreCutoffWeight; }
            set { inPreCutoffWeight = value; }
        }

        public string InFlowrateLowLimit
        {
            get { return inFlowrateLowLimit; }
            set { inFlowrateLowLimit = value; }
        }

        public string InFlowrateHighLimit
        {
            get { return inFlowrateHighLimit; }
            set { inFlowrateHighLimit = value; }
        }

        public string InDumpWeight
        {
            get { return inDumpWeight; }
            set { inDumpWeight = value; }
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
        public string Value60
        {
            get { return value60; }
            set { value60 = value; }
        }
        public string IoByteNo
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
            value10 = "66";
            value9 ="196608";
            value60 = "0";
            pType = P7601.ToString();
            hornCode = LibGlobalSource.NOCHILD;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            SetOTypeProperty(OTypeCollection.EL_MDDx);
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
            objFields.Append(dpNode2).Append(LibGlobalSource.TAB)
             .Append(ioByteNo).Append(LibGlobalSource.TAB)
             .Append(value9).Append(LibGlobalSource.TAB)
             .Append(value60).Append(LibGlobalSource.TAB)
             .Append(parTimeoutStart).Append(LibGlobalSource.TAB)
             .Append(parPulseWeight).Append(LibGlobalSource.TAB)
             .Append(inFlowrate).Append(LibGlobalSource.TAB)
             .Append(inPreCutoffWeight).Append(LibGlobalSource.TAB)
             .Append(inFlowrateLowLimit).Append(LibGlobalSource.TAB)
             .Append(inFlowrateHighLimit).Append(LibGlobalSource.TAB)
             .Append(inDumpWeight).Append(LibGlobalSource.TAB)
             .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
             .Append(LibGlobalSource.NOCHILD);
            textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            var relations = new List<Relation>();       
            if (refSenderBin != null)
            {
                relations.Add(new Relation(name, refSenderBin, GcproTable.ObjData.Value42.Name));
            }
            if (refFluidliftAirlock != null)
            {
                relations.Add(new Relation(name, refFluidliftAirlock, GcproTable.ObjData.Value43.Name));
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
