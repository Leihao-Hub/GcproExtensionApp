using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    ///  <summary>
    ///  Motor
    ///  </summary>
    public class Motor : Element, IGcpro
    {
        public struct MotorRule
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
        private readonly static string motorFileName = $@"\{OTypeCollection.EL_Motor}";
        private double hornCode;
        private double pType;
        private double value9;
        private double value10;
        private double dpNode1;
        private double dpNode2;
        private string isNew;
        public static MotorRule Rule;
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
        private string inpFwd;
        private string outpFwd;
        private string inpRev;
        private string outpRev;
        private string inpContactor;
        private string hwStop;
        private string adapter;
        private string powerApp;
        private string ao;
        private double parMonTime;
        private double parStartDelay;
        private double parStartingTime;
        private double parStoppingTime;
        private double parIdlingTime;
        private double parFaultDelayTime;
        private double parPowerNominal;
        private double parSpeedService;
        private double unit;

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

        public string InpFwd
        {
            get { return inpFwd; }
            set { inpFwd = value; }
        }
        public string OutpFwd
        {
            get { return outpFwd; }
            set { outpFwd = value; }
        }
        public string InpRev
        {
            get { return inpRev; }
            set { inpRev = value; }
        }
        public string OutpRev
        {
            get { return outpRev; }
            set { outpRev = value; }
        }
        public string InpContactor
        {
            get { return inpContactor; }
            set { inpContactor = value; }
        }
        public string HWStop
        {
            get { return hwStop; }
            set { hwStop = value; }
        }
        public string Adapter
        {
            get { return adapter; }
            set { adapter = value; }
        }

        public string PowerApp
        {
            get { return powerApp; }
            set { powerApp = value; }
        }

        public string AO
        {
            get { return ao; }
            set { ao = value; }
        }
        public double ParMonTime
        {
            get { return parMonTime; }
            set { parMonTime = value; }
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
        public double ParStoppingTime
        {
            get { return parStoppingTime; }
            set { parStoppingTime = value; }
        }
        public double ParIdlingTime
        {
            get { return parIdlingTime; }
            set { parIdlingTime = value; }
        }
        public double ParFaultDelayTime
        {
            get { return parFaultDelayTime; }
            set { parFaultDelayTime = value; }
        }

        public double ParPowerNominal
        {
            get { return parPowerNominal; }
            set
            {
                if (parPowerNominal != value)
                { 
                    parPowerNominal = value;
                    OnPowerChange(EventArgs.Empty);               
                }
            }
        }
        public double ParSpeedService
        {
            get { return parSpeedService; }
            set { parSpeedService = value; }
        }
        public double Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }


        #endregion

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
        #region Readonly subtype property
        public static string M11 { get; } = "M11";
        public static string M12 { get; } = "M12";
        public static string M21 { get; } = "M21";
        public static string M22 { get; } = "M22";
        public static string M12AIAO { get; } = "M12AIAO";
        public static string M1VFC { get; } = "M1VFC";
        public static string M2VFC { get; } = "M2VFC";
        public static string M11ELV { get; } = "M11ELV";
        public static float P7031 { get; } = 7031f;
        public static float P7032 { get; } = 7032f;
        public static float P7033 { get; } = 7033f;
        public static float P7034 { get; } = 7034f;
        public static float P7035 { get; } = 7035f;
        public static float P7036 { get; } = 7036f;
        public static float P7041 { get; } = 7041f;
        public static float P7042 { get; } = 7042f;
        public static float P7043 { get; } = 7043f;
        public static float P7044 { get; } = 7044f;
        public static float P7045 { get; } = 7045f;
        public static float P7046 { get; } = 7046f;
        public static float P7051 { get; } = 7051f;
        public static float P7052 { get; } = 7052f;
        public static float P7053 { get; } = 7053f;
        public static float P7054 { get; } = 7054f;
        public static float P7055 { get; } = 7055f;
        public static float P7056 { get; } = 7056f;
        public static float P7056_1 { get; } = 7056.1f;
        public static float P7056_2 { get; } = 7056.2f;
        public static float P7057 { get; } = 7057f;
        public static float P7058 { get; } = 7058f;
        public static float P7059 { get; } = 7059f;
        public static float P7060 { get; } = 7060f;
        public static float P9051 { get; } = 9051f;
        public static float P9052 { get; } = 9052f;  // Note: Corrected from 9053 to 9052
        public static float P9053 { get; } = 9053f;
        public static float P9056 { get; } = 9056f;
        public static string PF1012BBDFUTV { get; } = "1012BBDFUTV";
        public static string PF1012MASPEED { get; } = "1012MASPEED";
        public static string PF1012MDDXFEED { get; } = "1012MDDXFEED";
        public static string PF1012MDGXDET { get; } = "1012MDGXDET";
        public static string PF1012MDGXFED { get; } = "1012MDGXFED";
        public static string PF1012MDGXGRM { get; } = "1012MDGXGRM";
        public static string PF1012MDGXHYDP { get; } = "1012MDGXHYDP";
        public static string PF1012PNFAN { get; } = "1012PNFAN";
        public static string ImpExpRuleName { get; } = "IE_EL_Motor";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_Motor;
        #endregion  


        public Motor()
        {
            string commonDefaultFilePath;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-MXZ01";
            description = "Motor";
            subType = M11;
            processFct = string.Empty;
            page = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = 0;
            panel_ID = string.Empty;
            diagram = 0;
            page = string.Empty;
            pType = P7053;
            hornCode = 0;
            dpNode1 = 0;
            dpNode2 = 0;
            value9 = 2;
            value10 = 130;
            inpFwd = LibGlobalSource.NOCHILD;
            outpFwd = LibGlobalSource.NOCHILD;
            inpRev = LibGlobalSource.NOCHILD;
            outpRev = LibGlobalSource.NOCHILD;
            inpContactor = LibGlobalSource.NOCHILD;
            hwStop = LibGlobalSource.NOCHILD;
            adapter = LibGlobalSource.NOCHILD;
            powerApp = LibGlobalSource.NOCHILD;
            ao = LibGlobalSource.NOCHILD;
            parMonTime = 5.0;
            parStartDelay = 0;
            parStartingTime = 1;
            parStoppingTime = 1;
            parIdlingTime = 1;
            parFaultDelayTime = 1;
            parPowerNominal = 0;
            parSpeedService = 20;
            unit = 2;
            SetOTypeProperty(OTypeCollection.EL_Motor);
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{motorFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_FindConnector.Txt";
        }
        public Motor(string filePath = null) : this()
        {

            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{motorFileName}";
            commonUserFilePath = $"{filePath}{motorFileName}";
            bool defaultPath = string.IsNullOrWhiteSpace(filePath);
            this.filePath = defaultPath ?
                $"{commonDefaultFilePath}.Txt" : $"{commonUserFilePath}.Txt";
            this.fileRelationPath = defaultPath ?
                $"{commonDefaultFilePath}_Relation.Txt" : $"{commonUserFilePath}_Relation.Txt";
            this.fileConnectorPath = defaultPath ?
                $"{commonDefaultFilePath}_FindConnector.Txt" : $"{commonUserFilePath}_FindConnector.Txt";
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
                TextFileHandle textFileHandle = new TextFileHandle
                {
                    FilePath = this.filePath
                };
                isNew = "False";
                StringBuilder objFields = new StringBuilder();
                ///<summary>
                ///生产Standard字符串部分
                ///</summary> 
                objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
                    .Append(base.CreateObjectStandardPart()).Append(LibGlobalSource.TAB);
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
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(parMonTime * 10).Append(LibGlobalSource.TAB)
                    .Append(parStartDelay * 10).Append(LibGlobalSource.TAB)
                    .Append(parStartingTime * 10).Append(LibGlobalSource.TAB)
                    .Append(parStoppingTime * 10).Append(LibGlobalSource.TAB)
                    .Append(parIdlingTime * 10).Append(LibGlobalSource.TAB)
                    .Append(parFaultDelayTime * 10).Append(LibGlobalSource.TAB)
                    .Append(parPowerNominal).Append(LibGlobalSource.TAB)
                    .Append(parSpeedService).Append(LibGlobalSource.TAB)
                    .Append(unit);
                textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            }
                var relations = new List<Relation>();
            if (subType == M11)
            {
                relations.Add(new Relation(name, inpFwd, GcproTable.ObjData.Value11.Name));
                relations.Add(new Relation(name, outpFwd, GcproTable.ObjData.Value12.Name));
                if (!string.IsNullOrEmpty(inpContactor))
                {
                    relations.Add(new Relation(name, inpContactor, GcproTable.ObjData.Value38.Name));
                }
            }
            else if (subType == M12)
            {
                relations.Add(new Relation(name, inpFwd, GcproTable.ObjData.Value11.Name));
                relations.Add(new Relation(name, outpFwd, GcproTable.ObjData.Value12.Name));
                relations.Add(new Relation(name, inpRev, GcproTable.ObjData.Value13.Name));
                relations.Add(new Relation(name, outpRev, GcproTable.ObjData.Value14.Name));
            }
           else if (subType == M1VFC || subType == M2VFC)
           { 
                relations.Add(new Relation(name, adapter, GcproTable.ObjData.Value34.Name));
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
            textFileHandle.FilePath = this.fileConnectorPath;
            textFileHandle.ClearContents();
        }
        #region Power change event
        /// <summary>
        /// 使用委托声明事件
        /// </summary>
        public event GcObjectEventHandler PowerChange;
        /// <summary>
        /// 触发事件的方法
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnPowerChange(EventArgs e)
        {
            PowerChange?.Invoke(this, e);
            PowerChangeAfterEvent();
        }
        /// <summary>
        /// 供外部触发事件方法
        /// </summary>
        public void TriggerPowerChange()
        {
            OnPowerChange(EventArgs.Empty);
        }
        private void PowerChangeAfterEvent()
        {
            parMonTime = GetStartingTime(parPowerNominal);
            parStartingTime = parMonTime -1 >= 0 ? parMonTime : 3.0;
        }
        #endregion
        public static int GetStartingTime(float power)
        {
            int time;
            if (power < 3.0)
            {
                time = 3;
            }
            else if (3.0 <= power && power < 7.5)
            {
                time = 5;
            }
            else if (7.5 <= power && power < 15.0)
            {
                time = 8;
            }
            else if (15.0 <= power && power < 22.0)
            {
                time = 10;
            }
            else if (22.0 <= power && power < 30.0)
            {
                time = 15;
            }
            else if (30.0 <= power && power < 37.0)
            {
                time = 19;
            }
            else if (37.0 <= power && power < 45.0)
            {
                time = 25;
            }
            else if (45.0 <= power && power < 55.0)
            {
                time = 30;
            }
            else if (55.0 <= power && power < 75.0)
            {
                time = 35;
            }
            else if (75.0 <= power)
            {
                time = 40;
            }
            else
            {
                time = 10;
            }
            return time;
        }
        public static int GetStartingTime(double power)
        {
            int time;
            if (power < 3.0)
            {
                time = 3;
            }
            else if (3.0 <= power && power < 7.5)
            {
                time = 5;
            }
            else if (7.5 <= power && power < 15.0)
            {
                time = 8;
            }
            else if (15.0 <= power && power < 22.0)
            {
                time = 10;
            }
            else if (22.0 <= power && power < 30.0)
            {
                time = 15;
            }
            else if (30.0 <= power && power < 37.0)
            {
                time = 19;
            }
            else if (37.0 <= power && power < 45.0)
            {
                time = 25;
            }
            else if (45.0 <= power && power < 55.0)
            {
                time = 30;
            }
            else if (55.0 <= power && power < 75.0)
            {
                time = 35;
            }
            else if (75.0 <= power)
            {
                time = 40;
            }
            else
            {
                time = 10;
            }
            return time;
        }
        public static float GetCTRatio(float power)
        {
            if (power <= 1.5f)
            {
                return 5.0f;
            }
            else if (power <= 3.0f)
            {
                return 10.0f;
            }
            else if (power <= 4.0f)
            {
                return 15.0f;
            }
            else if (power <= 5.5f)
            {
                return 20.0f;
            }
            else if (power <= 7.5f)
            {
                return 25.0f;
            }
            else if (power <= 9.2f)
            {
                return 30.0f;
            }
            else if (power <= 11.0f)
            {
                return 40.0f;
            }
            else if (power <= 15.0f)
            {
                return 50.0f;
            }
            else if (power <= 18.5f)
            {
                return 60.0f;
            }
            else if (power <= 22.0f)
            {
                return 75.0f;
            }
            else if (power <= 30.0f)
            {
                return 100.0f;
            }
            else
            {
                return 150.0f;
            }
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
            #region Add records list
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpFwd" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpFwd"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpRev"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpRev"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpContactor" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="InHWStop"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value47.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Adapter"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "PowerApp"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value50.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "VFC Analog"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value33.Name}

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name}

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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParStoppingTime"},
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParPowerNominal"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value49.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParSpeedService"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value52.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Unit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value40.Name}

            });
            #endregion 
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }


}
