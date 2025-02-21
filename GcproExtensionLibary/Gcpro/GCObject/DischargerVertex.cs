using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class DischargerVertex : GcObject

    {
        public struct DischargerVertexRule
        {
            public GcBaseRule Common;
            public int BinNoInc;
            public int VertexNoInc;
        }
        private string filePath;
        private string fileRelationPath;
        //private string fileConnectorPath;
        private readonly static string dischargerVertexFileName = $@"\{OTypeCollection.DischargerVertex}";
        public static DischargerVertexRule Rule;
        private string name;
        private string description;
        private string subType;
        private string processFct;
        private string building;
        private string elevation;
        private double fieldBusNode;
        private string panel_ID;
        private double diagram;
        private string page;
        private string parDischargerNo;
        private string bin;
        private string vertex;
        private string conche;
        private string destination;
        private double parScaleNo;
        private double parBinNo;
        private double parHeightDropMax;
        private double parDownPipeWeight;
        private double parDosingSpeedFast;
        private double parDosingSpeedSlow;
        private double parSwitchOverTimeFToS;
        private double parDosingTimeSlow;
        private double parCutoffWeightCorrMax;
        private double parLevelCompensationMax;
        private double parDosingTimeMax;
        private double parFineDosingWeight;
        private double parCutoffWeight;
        private double parFlowrateFast;
        private double parFlowrateSlow;
        private double parTipPulseLen;
        private double parTolPosWeight;
        private double parTolPosRel;
        private double parTolAutoPosWeight;
        private double parTolAutoPosRel;
        private double parTolNegWeight;
        private double parTolNegRel;
        private double value10;    
        private string isNew;
        private const string _DSFU = "DSFU";
        private const string _DSMAN = "DSMAN";
        private const string _DSS1 = "DSS1";
        private const string _DSS2 = "DSS2";
        private const string _DSSIMPLE = "DSSIMPLE";
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
            set
            {
                if (subType != value)
                {
                    subType = value;
                    OnSubTypeChange(EventArgs.Empty);
                }
            }
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
        public override double Diagram
        {
            get { return diagram; }
            set { diagram = value; }
        }
        public override string Page
        {
            get { return page; }
            set { page = value; }
        }
 
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
        #endregion
        #region Application properties
        public string ParDischargerNo
        {
            get { return parDischargerNo; }
            set { parDischargerNo = value; }
        }

        public string Bin
        {
            get { return bin; }
            set { bin = value; }
        }

        public string Vertex
        {
            get { return vertex; }
            set { vertex = value; }
        }

        public string Conche
        {
            get { return conche; }
            set { conche = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public double ParScaleNo
        {
            get { return parScaleNo; }
            set { parScaleNo = value; }
        }

        public double ParBinNo
        {
            get { return parBinNo; }
            set { parBinNo = value; }
        }

        public double ParHeightDropMax
        {
            get { return parHeightDropMax; }
            set { parHeightDropMax = value; }
        }

        public double ParDownPipeWeight
        {
            get { return parDownPipeWeight; }
            set { parDownPipeWeight = value; }
        }

        public double ParDosingSpeedFast
        {
            get { return parDosingSpeedFast; }
            set { parDosingSpeedFast = value; }
        }

        public double ParDosingSpeedSlow
        {
            get { return parDosingSpeedSlow; }
            set { parDosingSpeedSlow = value; }
        }

        public double ParSwitchOverTimeFToS
        {
            get { return parSwitchOverTimeFToS; }
            set { parSwitchOverTimeFToS = value; }
        }

        public double ParDosingTimeSlow
        {
            get { return parDosingTimeSlow; }
            set { parDosingTimeSlow = value; }
        }

        public double ParCutoffWeightCorrMax
        {
            get { return parCutoffWeightCorrMax; }
            set { parCutoffWeightCorrMax = value; }
        }

        public double ParLevelCompensationMax
        {
            get { return parLevelCompensationMax; }
            set { parLevelCompensationMax = value; }
        }

        public double ParDosingTimeMax
        {
            get { return parDosingTimeMax; }
            set { parDosingTimeMax = value; }
        }

        public double ParFineDosingWeight
        {
            get { return parFineDosingWeight; }
            set { parFineDosingWeight = value; }
        }

        public double ParCutoffWeight
        {
            get { return parCutoffWeight; }
            set { parCutoffWeight = value; }
        }

        public double ParFlowrateFast
        {
            get { return parFlowrateFast; }
            set { parFlowrateFast = value; }
        }

        public double ParFlowrateSlow
        {
            get { return parFlowrateSlow; }
            set { parFlowrateSlow = value; }
        }

        public double ParTipPulseLen
        {
            get { return parTipPulseLen; }
            set { parTipPulseLen = value; }
        }

        public double ParTolPosWeight
        {
            get { return parTolPosWeight; }
            set { parTolPosWeight = value; }
        }

        public double ParTolPosRel
        {
            get { return parTolPosRel; }
            set { parTolPosRel = value; }
        }

        public double ParTolAutoPosWeight
        {
            get { return parTolAutoPosWeight; }
            set { parTolAutoPosWeight = value; }
        }

        public double ParTolAutoPosRel
        {
            get { return parTolAutoPosRel; }
            set { parTolAutoPosRel = value; }
        }

        public double ParTolNegWeight
        {
            get { return parTolNegWeight; }
            set { parTolNegWeight = value; }
        }

        public double ParTolNegRel
        {
            get { return parTolNegRel; }
            set { parTolNegRel = value; }
        }

        public double Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        #endregion
        #region Readonly property
        public static string DSFU { get; } = _DSFU;
        public static string DSMAN { get; } = _DSMAN;
        public static string DSS1 { get; } = _DSS1;
        public static string DSS2 { get; } = _DSS2;
        public static string DSSIMPLE { get; } = _DSSIMPLE;
        public static string ImpExpRuleName { get; } = "IE_DischargerVertex";
        public static int OTypeValue { get; } = (int)OTypeCollection.DischargerVertex;
        #endregion
        private void Default()
        {
            subType = _DSFU;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.BinNoInc = Rule.VertexNoInc = 1;
            Rule.Common.NameRule = "501";
            parDosingSpeedFast = 100;
            parDosingSpeedSlow = 20;
            parSwitchOverTimeFToS = 3.0;
            parDosingTimeSlow = 4.0;
            parCutoffWeightCorrMax = 5;
            parLevelCompensationMax = 0;
            parFineDosingWeight = 20.0;
            parCutoffWeight = 5.000;
            parFlowrateFast = 0;
            parFlowrateSlow = 0;
            parTipPulseLen = 0.5;
            parTolPosWeight = 5.0;
            parTolPosRel = 50.0;
            parTolNegWeight = 5.0;
            parTolNegRel = 50.0;
            parTolAutoPosWeight = 0.0;
            parTolAutoPosRel = 0.0;
            parHeightDropMax = 500;
            parDownPipeWeight = 1.0;
            fieldBusNode = 0;
            panel_ID = string.Empty;
            diagram = 0;
            page = string.Empty;
            value10 = 72;
        }
        public DischargerVertex()
        {
            Default();
            SetOTypeProperty(OTypeCollection.DischargerVertex);

            string commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{dischargerVertexFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
        }
        public DischargerVertex(string filePath = null) : this()
        {        
            string commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{dischargerVertexFileName}";
            string commonUserFilePath = $"{filePath}{dischargerVertexFileName}";
            bool defaultPath = string.IsNullOrWhiteSpace(filePath);
            this.filePath = defaultPath ?
                $"{commonDefaultFilePath}.Txt" : $"{commonUserFilePath}.Txt";
            this.fileRelationPath = defaultPath ?
                $"{commonDefaultFilePath}_Relation.Txt" : $"{commonUserFilePath}_Relation.Txt";
        }
        #region SubType change event
        /// <summary>
        /// 使用委托声明事件
        /// </summary>
        public event GcObjectEventHandler SubTypeChange;
        /// <summary>
        /// 触发事件的方法
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnSubTypeChange(EventArgs e)
        {
            SubTypeChange?.Invoke(this, e);
            SubTypeChangeAfterEvent();
        }
        /// <summary>
        /// 供外部触发事件方法
        /// </summary>
        public void TriggerSubTypeChange()
        {
            OnSubTypeChange(EventArgs.Empty);
        }
        private void SubTypeChangeAfterEvent()
        {
            switch (subType)
            {
                case _DSFU:
                    value10 = 72;
                    break;
                case _DSS1:
                    value10 = 66;
                    break;
                case _DSS2:
                    value10 = 68;
                    break;
                case _DSMAN:
                case _DSSIMPLE:
                    value10 = 1;
                    break;
                default:
                    value10 = 88;
                    break;
            } 
        }
        #endregion
        /// 创建GCPRO对象与与对象关系文件
        /// </summary>
        /// <param name="textFileHandle">TextFileHandle类实例</param>
        /// <param name="sbObjFields">StringBuilder类实例</param>
        /// <param name="encoding">文本文件的导入编码</param>
        /// <param name="onlyRelation">=true时,仅创建关系文件；=false时,同时创建对象与对象关系导入文件</param>
        public void CreateObject(TextFileHandle textFileHandle, StringBuilder sb, Encoding encoding, bool onlyRelation = false)
        {
            if (!onlyRelation)
            {
                textFileHandle.FilePath = this.filePath;
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
                sb.Append(parDischargerNo).Append(tab)
                   .Append(noChild).Append(tab)
                   .Append(noChild).Append(tab)
                   .Append(noChild).Append(tab)
                   .Append(noChild).Append(tab)
                   .Append(parScaleNo).Append(tab)
                   .Append(parBinNo).Append(tab)
                   .Append(parHeightDropMax).Append(tab)
                   .Append(parDownPipeWeight * 1000).Append(tab)
                   .Append(parDosingSpeedFast).Append(tab)
                   .Append(parDosingSpeedSlow).Append(tab)
                   .Append(parSwitchOverTimeFToS * 10).Append(tab)
                   .Append(parDosingTimeSlow * 10).Append(tab)
                   .Append(parCutoffWeightCorrMax * 1000).Append(tab)
                   .Append(parLevelCompensationMax).Append(tab)
                   .Append(parDosingTimeMax).Append(tab)
                   .Append(parFineDosingWeight * 1000).Append(tab)
                   .Append(parCutoffWeight * 1000).Append(tab)
                   .Append(parFlowrateFast).Append(tab)
                   .Append(parFlowrateSlow).Append(tab)
                   .Append(parTipPulseLen * 10).Append(tab)
                   .Append(parTolPosWeight * 1000).Append(tab)
                   .Append(parTolPosRel *10).Append(tab)
                   .Append(parTolAutoPosWeight * 1000).Append(tab)
                   .Append(parTolAutoPosRel * 10).Append(tab)
                   .Append(parTolNegWeight * 1000).Append(tab)
                   .Append(parTolNegRel *10).Append(tab)
                   .Append(Value10);
                textFileHandle.WriteToTextFile(sb.ToString(), encoding);
                sb.Clear();           
            }
            var relations = new List<Relation>
            {
                new Relation(name,bin, GcproTable.ObjData.Value41.Name),
                new Relation(name,vertex, GcproTable.ObjData.Value42.Name),
                new Relation(name,conche, GcproTable.ObjData.Value43.Name),
                new Relation(name,destination, GcproTable.ObjData.Value44.Name),                 
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDischargerNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Bin"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value41.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Vertex"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Conche"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value43.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Destination"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value44.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParScaleNo" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParBinNo" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value1.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParHeightDropMax" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value29.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDownPipeWeight" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value33.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDosinSpeedFast" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value27.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDosingSpeedSlow" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value28.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParSwitchOverTimeFToS" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value20.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDosingTimeSlow" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value19.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParCutoffWeightCorrMax" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value18.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParLevelCompensationMax" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value30.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDosingTimeMax" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParFineDosingWeight" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParCutoffWeight" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value15.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParFlowrateFast" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParFlowrateSlow" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTipPulseLen" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTolPosWeight" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value16.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTolPosRel" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTolAutoPosWeight" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTolAutoPosRel" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTolNegsWeight" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value17.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTolNegRel" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue10" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value10.Name }

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}
