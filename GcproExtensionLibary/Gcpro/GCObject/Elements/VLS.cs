using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class VLS : Element
    {
        public struct VLSRule
        {
            public GcBaseRule Common;
            public string AORule;
            public int AORuleInc;
            public string VFCRule;
            public int VFCRuleInc;
            public string PowerAppRule;
            public int PowerAppRuleInc;
        }
        private string filePath;
        private readonly string fileRelationPath;
        private readonly string fileConnectorPath;
        private readonly static string vlsFileName = $@"\{OTypeCollection.EL_VLS}";
        public static VLSRule Rule;
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
        private double hornCode;
        private double pType;
        private double dpNode1;
        private double dpNode2;
        private double value9;
        private double value10;
        private string inpLN;
        private string inpHN;
        private string outpLN;
        private string outpHN;
        private string inpRunRev;
        private string inpRunFwd;
        private double monTime;
        private double pulseTimeLN;
        private double pulseTimeHN;
        private double idlingTime;
        private double faultDelay;
        private double startDelay;
        private string hwStop;
        private string refRcvLN;
        private string refRcvHN;
        private string refSndBin;
        private string refAsp;
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
        public string InpLN
        {
            get { return inpLN; }
            set { inpLN = value; }
        }
        public string InpHN
        {
            get { return inpHN; }
            set { inpHN = value; }
        }
        public string OutpLN
        {
            get { return outpLN; }
            set { outpLN = value; }
        }
        public string OutpHN
        {
            get { return outpHN; }
            set { outpHN = value; }
        }
        public string InpRunRev
        {
            get { return inpRunRev; }
            set { inpRunRev = value; }
        }
        public string InpRunFwd
        {
            get { return inpRunFwd; }
            set { inpRunFwd = value; }
        }
        public double MonTime
        {
            get { return monTime; }
            set { monTime = value; }
        }
        public double PulseTimeLN
        {
            get { return pulseTimeLN; }
            set { pulseTimeLN = value; }
        }
        public double PulseTimeHN
        {
            get { return pulseTimeHN; }
            set { pulseTimeHN = value; }
        }
        public double IdlingTime
        {
            get { return idlingTime; }
            set { idlingTime = value; }
        }
        public double FaultDelay
        {
            get { return faultDelay; }
            set { faultDelay = value; }
        }
        public double StartDelay
        {
            get { return startDelay; }
            set { startDelay = value; }
        }
        public string HwStop
        {
            get { return hwStop; }
            set { hwStop = value; }
        }
        public string RefRcvLN
        {
            get { return refRcvLN; }
            set { refRcvLN = value; }
        }
        public string RefRcvHN
        {
            get { return refRcvHN; }
            set { refRcvHN = value; }
        }
        public string RefSndBin
        {
            get { return refSndBin; }
            set { refSndBin = value; }
        }
        public string RefAsp
        {
            get { return refAsp; }
            set { refAsp = value; }
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
        public static string VCO { get; } = "VCO";
        public static string VMF { get; } = "VMF";
        public static string VPO { get; } = "VPO";
        public static string VPOM { get; } = "VPOM";
        public static string VPOR { get; } = "VPOR";
        public static float P7081 { get; } = 7081f;
        public static float P7082 { get; } = 7082f;
        public static float P7083 { get; } = 7083f;
        public static float P7084 { get; } = 7084f;
        public static float P7085 { get; } = 7085f;
        public static float P7086 { get; } = 7086f;
        public static float P7087 { get; } = 7087f;
        public static float P7087_1 { get; } = 7087.1f;
        public static string ImpExpRuleName { get; } = "IE_EL_VLS";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_VLS;
        #endregion
        public VLS()
        {
            string commonDefaultFilePath;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-01/02";
            description = "VLS";
            subType = VCO;
            processFct = string.Empty;
            page = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = 0;
            panel_ID = string.Empty;
            diagram = 0;
            page = string.Empty;
            pType = P7081;
            hornCode = 0;
            dpNode1 = 0;
            dpNode2 = 0;
            value9 = 0;
            value10 = 10;
            inpLN = LibGlobalSource.NOCHILD;
            outpLN = LibGlobalSource.NOCHILD;
            inpHN = LibGlobalSource.NOCHILD;
            outpHN = LibGlobalSource.NOCHILD;
            inpRunRev = LibGlobalSource.NOCHILD;
            inpRunFwd = LibGlobalSource.NOCHILD;
            monTime = 20.0;
            pulseTimeLN = 0.5;
            pulseTimeHN = 0.5;
            idlingTime = 1.0;
            faultDelay = 3.0;
            startDelay = 0;
            hwStop = LibGlobalSource.NOCHILD;
            refRcvLN = LibGlobalSource.NOCHILD;
            refRcvHN = LibGlobalSource.NOCHILD;
            refSndBin = LibGlobalSource.NOCHILD;
            refAsp = LibGlobalSource.NOCHILD;
            SetOTypeProperty(OTypeCollection.EL_VLS);
            objectRecord = new List<string>();
            objectRelation = new List<string>();
            relation = new Relation();
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{vlsFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_FindConnector.Txt";
        }
        public VLS(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{vlsFileName}";
            commonUserFilePath = $"{filePath}{vlsFileName}";
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
                  .Append(value9).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(monTime * 10).Append(tab)
                  .Append(pulseTimeHN * 10).Append(tab)
                  .Append(pulseTimeLN * 10).Append(tab)
                  .Append(idlingTime * 10).Append(tab)
                  .Append(faultDelay * 10).Append(tab)
                  .Append(startDelay * 10).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(tab).Append(tab)
                  .Append(tab).Append(tab)
                  .Append(tab);
                objectRecord.Add(sb.ToString());
                sb.Clear();
            }

            if (subType == VPO || subType == VPOM || subType == VPOR)
            {
                CreateRelation(sb, name, inpLN, GcproTable.ObjData.Value11.Name);
                CreateRelation(sb, name, outpLN, GcproTable.ObjData.Value12.Name);
                CreateRelation(sb, name, inpHN, GcproTable.ObjData.Value13.Name);
                CreateRelation(sb, name, outpHN, GcproTable.ObjData.Value14.Name);
                if (subType == VPOM)
                {
                    CreateRelation(sb, name, inpHN, GcproTable.ObjData.Value15.Name);
                    CreateRelation(sb, name, outpHN, GcproTable.ObjData.Value16.Name);
                }
            }
            else if (subType == VCO)
            {
                CreateRelation(sb, name, inpLN, GcproTable.ObjData.Value11.Name);
                CreateRelation(sb, name, inpHN, GcproTable.ObjData.Value13.Name);
                CreateRelation(sb, name, outpHN, GcproTable.ObjData.Value14.Name);   
            }
            else if (subType == VMF)
            {
                CreateRelation(sb, name, inpLN, GcproTable.ObjData.Value11.Name);
                CreateRelation(sb, name, inpHN, GcproTable.ObjData.Value13.Name);
            }
            if (!string.IsNullOrEmpty(refRcvLN))
            {
                CreateRelation(sb, name, refRcvLN, GcproTable.ObjData.Value30.Name);
            }
            if (!string.IsNullOrEmpty(refRcvHN))
            {
                CreateRelation(sb, name, refRcvHN, GcproTable.ObjData.Value31.Name);
            }
            if (!string.IsNullOrEmpty(refSndBin))
            {
                CreateRelation(sb, name, refSndBin, GcproTable.ObjData.Value32.Name);
            }
            if (!string.IsNullOrEmpty(refAsp))
            {
                CreateRelation(sb, name, refAsp, GcproTable.ObjData.Value34.Name);
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue9"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value9.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpLN"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpHN"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpLN"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpHN" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpRunRev"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value15.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpRunFwd"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value16.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "HWStop"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value47.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTime" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="ParPulseHN"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParPulseLN"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParIdlingTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParFaultDelayTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name}

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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Receiver LN"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value30.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Receiver HN"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Sender Bin"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Aspiration"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name}

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}
