using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class VLS : Element, IGcpro
    {
        public struct VLSRule
        {
            public GcBaseRule Common;
            public string AORule;
            public string AORuleInc;
            public string VFCRule;
            public string VFCRuleInc;
            public string PowerAppRule;
            public string PowerAppRuleInc;
        }
        private string filePath;
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string vlsFileName = $@"\{OTypeCollection.EL_VLS}";
        public static VLSRule Rule;
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
        private string hornCode;
        private string pType;
        private string dpNode1;
        private string dpNode2;
        private string value9;
        private string value10;
        private string inpLN;
        private string inpHN;
        private string outpLN;
        private string outpHN;
        private string inpRunRev;
        private string inpRunFwd;
        private string monTime;
        private string pulseTimeLN;
        private string pulseTimeHN;
        private string idlingTime;
        private string faultDelay;
        private string startDelay;
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
        public string MonTime
        {
            get { return monTime; }
            set { monTime = value; }
        }
        public string PulseTimeLN
        {
            get { return pulseTimeLN; }
            set { pulseTimeLN = value; }
        }
        public string PulseTimeHN
        {
            get { return pulseTimeHN; }
            set { pulseTimeHN = value; }
        }
        public string IdlingTime
        {
            get { return idlingTime; }
            set { idlingTime = value; }
        }
        public string FaultDelay
        {
            get { return faultDelay; }
            set { faultDelay = value; }
        }
        public string StartDelay
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
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-01/02";
            description = "VLS";
            subType = VCO;
            processFct = string.Empty;
            page = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = string.Empty;
            panel_ID = string.Empty;
            diagram = string.Empty;
            page = string.Empty;
            pType = P7081.ToString();
            hornCode = LibGlobalSource.NOCHILD;
            dpNode1 = LibGlobalSource.NOCHILD;
            dpNode2 = LibGlobalSource.NOCHILD;
            value9 = "0";
            value10 = "10";
            inpLN = LibGlobalSource.NOCHILD;
            outpLN = LibGlobalSource.NOCHILD;
            inpHN = LibGlobalSource.NOCHILD;
            outpHN = LibGlobalSource.NOCHILD;
            inpRunRev = LibGlobalSource.NOCHILD;
            inpRunFwd = LibGlobalSource.NOCHILD;
            monTime = "200";
            pulseTimeLN = "5";
            pulseTimeHN = "5";
            idlingTime = "10";
            faultDelay = "30";
            startDelay = "0";
            hwStop = LibGlobalSource.NOCHILD;
            refRcvLN = LibGlobalSource.NOCHILD;
            refRcvHN = LibGlobalSource.NOCHILD;
            refSndBin = LibGlobalSource.NOCHILD;
            refAsp = LibGlobalSource.NOCHILD;

            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + "_FindConnector.Txt";
        }
        public VLS(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + ".Txt" : filePath + vlsFileName + ".Txt");

            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                          LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + "_Relation.Txt" : filePath + vlsFileName + "_Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                     LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + vlsFileName + "_FindConnector.Txt" : filePath + vlsFileName + "_FindConnector.Txt");
        }
        public void CreateObject(Encoding encoding, bool onlyRelation = false)
        {
            if (!onlyRelation)
            {
                TextFileHandle textFileHandle = new TextFileHandle();
                textFileHandle.FilePath = this.filePath;
                isNew = "false";
                StringBuilder objFields = new StringBuilder();
                ///<summary>
                ///生产Standard字符串部分-使用父类中方法实现
                ///</summary> 
                objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
                  .Append(base.CreateObjectStandardPart(encoding)).Append(LibGlobalSource.TAB);
                ///<summary>
                ///生成Application 字符串部分
                ///</summary>     
                objFields.Append(dpNode2).Append(LibGlobalSource.TAB)
                  .Append(value9).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(monTime).Append(LibGlobalSource.TAB)
                  .Append(pulseTimeHN).Append(LibGlobalSource.TAB)
                  .Append(pulseTimeLN).Append(LibGlobalSource.TAB)
                  .Append(idlingTime).Append(LibGlobalSource.TAB)
                  .Append(faultDelay).Append(LibGlobalSource.TAB)
                  .Append(startDelay).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD);
                textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
                objFields = null;
            }
            var relations = new List<Relation>();
            Relation inpLNRel = new Relation (name, inpLN, GcproTable.ObjData.Value11.Name);
            Relation outpLNRel = new Relation(name, outpLN, GcproTable.ObjData.Value12.Name);
            Relation inpHNRel = new Relation(name, inpHN, GcproTable.ObjData.Value13.Name);
            Relation outpHNRel = new Relation(name, outpHN, GcproTable.ObjData.Value14.Name);
          
            if (subType == VPO || subType == VPOM || subType == VPOR)
            {            
                relations.Add(inpLNRel);
                relations.Add(outpLNRel);
                relations.Add(inpHNRel);
                relations.Add(outpHNRel);
                if (subType == VPOM)
                {
                    relations.Add(new Relation(name, inpHN, GcproTable.ObjData.Value15.Name));
                    relations.Add(new Relation(name, outpHN, GcproTable.ObjData.Value16.Name));
                }
            }
            else if (subType == VCO)
            {

                relations.Add(inpLNRel);
                relations.Add(inpHNRel);
                relations.Add(outpHNRel);
            }
            else if (subType == VMF)
            {
                relations.Add(inpLNRel);
                relations.Add(inpHNRel);
            }
            if (!string.IsNullOrEmpty(refRcvLN))
            {
                relations.Add( new Relation (name, refRcvLN, GcproTable.ObjData.Value30.Name));
            }
            if (!string.IsNullOrEmpty(refRcvHN))
            {
                relations.Add(new Relation(name, refRcvHN, GcproTable.ObjData.Value31.Name));
            }
            if (!string.IsNullOrEmpty(refSndBin))
            {
                relations.Add(new Relation(name, refSndBin, GcproTable.ObjData.Value32.Name));
            }
            if (!string.IsNullOrEmpty(refAsp))
            {
                relations.Add(new Relation(name, refAsp, GcproTable.ObjData.Value34.Name));
        
            }
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
