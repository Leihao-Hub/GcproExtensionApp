using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class AI : Element, IGcpro
    {
        public struct AIRule
        {
            public GcBaseRule Common;
        }
        private string filePath;
        private readonly string fileRelationPath;
        private readonly string fileConnectorPath;
        private readonly static string aiFileName = $@"\{OTypeCollection.EL_AI}";
        public static AIRule Rule;
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
        private double pType;
        private double hornCode;
        private double dpNode1;
        private double value9;
        private double value10;
        private string inpValue;
        private string inpFaultDev;
        private string inHWStop;
        private string inpLowLow;
        private string inpLow;
        private string inpHighHigh;
        private string inpHigh;
        private double unitsBy100;
        private double offsetUnits;
        private double delayTimeDown;
        private double delayTimeUp;
        private double delayFaultTime;
        private double limitLowLow;
        private double limitLow;
        private double limitHighHigh;
        private double limitHigh;
        private double monTimeLowLow;
        private double monTimeLow;
        private double monTimeMiddle;
        private double monTimeHighHigh;
        private double monTimeHigh;
        private double unit;
        private string reference;
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
        public string InpValue
        {
            get { return inpValue; }
            set { inpValue = value; }
        }
        public string InpFaultDev
        {
            get { return inpFaultDev; }
            set { inpFaultDev = value; }
        }
        public string InHWStop
        {
            get { return inHWStop; }
            set { inHWStop = value; }
        }
        public string InpLowLow
        {
            get { return inpLowLow; }
            set { inpLowLow = value; }
        }
        public string InpLow
        {
            get { return inpLow; }
            set { inpLow = value; }
        }
        public string InpHighHigh
        {
            get { return inpHighHigh; }
            set { inpHighHigh = value; }
        }
        public string InpHigh
        {
            get { return inpHigh; }
            set { inpHigh = value; }
        }

        public double UnitsBy100
        {
            get { return unitsBy100; }
            set { unitsBy100 = value; }
        }
        public double OffsetUnits
        {
            get { return offsetUnits; }
            set { offsetUnits = value; }
        }

        public double DelayTimeDown
        {
            get { return delayTimeDown; }
            set { delayTimeDown = value; }
        }

        public double DelayTimeUp
        {
            get { return delayTimeUp; }
            set { delayTimeUp = value; }
        }

        public double DelayFaultTime
        {
            get { return delayFaultTime; }
            set { delayFaultTime = value; }
        }

        public double LimitLowLow
        {
            get { return limitLowLow; }
            set { limitLowLow = value; }
        }

        public double LimitLow
        {
            get { return limitLow; }
            set { limitLow = value; }
        }

        public double LimitHighHigh
        {
            get { return limitHighHigh; }
            set { limitHighHigh = value; }
        }

        public double LimitHigh
        {
            get { return limitHigh; }
            set { limitHigh = value; }
        }

        public double MonTimeLowLow
        {
            get { return monTimeLowLow; }
            set { monTimeLowLow = value; }
        }

        public double MonTimeLow
        {
            get { return monTimeLow; }
            set { monTimeLow = value; }
        }

        public double MonTimeMiddle
        {
            get { return monTimeMiddle; }
            set { monTimeMiddle = value; }
        }

        public double MonTimeHighHigh
        {
            get { return monTimeHighHigh; }
            set { monTimeHighHigh = value; }
        }

        public double MonTimeHigh
        {
            get { return monTimeHigh; }
            set { monTimeHigh = value; }
        }
        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }
        public double Unit
        {
            get { return unit; }
            set { unit = value; }
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
        public static string AIT { get; } = "AIT";
        public static string AIDI { get; } = "AIDI";
        public static string AIMF { get; } = "AIMF";
        public static string AIMT { get; } = "AIMT";
        public static string AIWT { get; } = "AIWT";
        public static string AVG { get; } = "AVG";
        public static string SEL { get; } = "SEL";
        public static float P7252 { get; } = 7252;
        public static float P7253 { get; } = 7253;
        public static float P7254 { get; } = 7254;
        public static float P7400 { get; } = 7400;
        public static float P7401 { get; } = 7401;
        public static float P7402 { get; } = 7402;
        public static float P7403 { get; } = 7403;
        public static float P7403_1 { get; } = 7403.1f;
        public static float P7404 { get; } = 7404;
        public static float P7404_1 { get; } = 7404.1f;
        public static float P7405 { get; } = 7405;
        public static float P7406 { get; } = 7406;
        public static float P7407 { get; } = 7407;
        public static float P7408 { get; } = 7408;
        public static float P7408_1 { get; } = 7408.1f;
        public static float P7409 { get; } = 7405;
        public static float P7410 { get; } = 7410;
        public static float P7411 { get; } = 7411;
        public static float P7420 { get; } = 7420;
        public static string ImpExpRuleName { get; } = "IE_EL_AI";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_AI;
        #endregion
        public AI()
        {
            string commonDefaultFilePath;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-AI";
            description = "EL_AI";
            subType = "AIT";
            processFct = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = 0;
            panel_ID = string.Empty;
            diagram = 0;
            page = string.Empty;
            pType = P7252;
            hornCode = 0;
            dpNode1 = 0;
            value9 = 32;
            value10 = 32;
            OffsetUnits = 0;
            delayTimeDown = 1.0;
            delayTimeUp = 1.0;
            delayFaultTime = 1.0;
            monTimeLowLow = 1.0;
            monTimeLow = 1.0;
            monTimeMiddle = 1.0;
            monTimeHigh =  0.0;
            monTimeHighHigh = 2.0;
            inpValue = string.Empty;
            inpLowLow = string.Empty;
            inpLow = string.Empty;
            inpHigh = string.Empty;
            inpHighHigh = string.Empty;
            inpFaultDev = string.Empty;
            inHWStop = string.Empty;
            reference = string.Empty;
            SetOTypeProperty(OTypeCollection.EL_AI);
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{aiFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_FindConnector.Txt";
        }
        public AI(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{aiFileName}";
            commonUserFilePath = $"{filePath}{aiFileName}";
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
        /// <param name="textFileHandle">TextFileHandle类实例</param>
        /// <param name="sbObjFields">StringBuilder类实例</param>
        /// <param name="encoding">文本文件的导入编码</param>
        /// <param name="onlyRelation">=true时,仅创建关系文件；=false时,同时创建对象与对象关系导入文件</param>
        public void CreateObject(TextFileHandle textFileHandle,StringBuilder sb,Encoding encoding, bool onlyRelation = false)
        {
            if (!onlyRelation)
            {
                textFileHandle.FilePath = this.filePath;
                isNew = "False";
                string tab = LibGlobalSource.TAB;
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
                sb.Append(value9).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(unitsBy100).Append(tab)
                  .Append(offsetUnits).Append(tab)
                  .Append(delayTimeDown * 10).Append(tab)
                  .Append(delayTimeUp * 10).Append(tab)
                  .Append(delayFaultTime * 10).Append(tab)
                  .Append(unit).Append(tab)
                  .Append(limitLowLow).Append(tab)
                  .Append(limitLow).Append(tab)
                  .Append(limitHigh).Append(tab)
                  .Append(limitHighHigh).Append(tab)
                  .Append(monTimeLowLow * 10).Append(tab)
                  .Append(monTimeLow * 10).Append(tab)
                  .Append(monTimeMiddle * 10).Append(tab)
                  .Append(monTimeHigh * 10).Append(tab)
                  .Append(monTimeHighHigh * 10).Append(tab)
                  .Append(string.Empty).Append(tab)
                  .Append(string.Empty);
                textFileHandle.WriteToTextFile(sb.ToString(), encoding);
                sb.Clear();
            }
                var relations = new List<Relation>
                {
                    new Relation(name,inpValue, GcproTable.ObjData.Value11.Name),
                    new Relation(name,inpFaultDev, GcproTable.ObjData.Value19.Name),
                    new Relation(name,inpLowLow, GcproTable.ObjData.Value12.Name),
                    new Relation(name,inpLow, GcproTable.ObjData.Value13.Name),
                    new Relation(name,inpHigh, GcproTable.ObjData.Value14.Name),
                    new Relation(name,inpHighHigh, GcproTable.ObjData.Value15.Name),
                    new Relation(name,inHWStop, GcproTable.ObjData.Value47.Name),
                    new Relation(name,reference, GcproTable.ObjData.Value39.Name),
                };
            textFileHandle.FilePath = this.fileRelationPath;
            sb.Clear();
            CreateRelations(textFileHandle, sb,relations, encoding);
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue9"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value9.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpValue"},
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpLowLow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpLow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpHigh" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpHighHigh"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value15.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParUnitsBy100"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParOffsetUnits"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value41.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayTimeDown" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value33.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="ParDelayTimeUp"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayFaultTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value35.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Unit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParLimitLowLow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParLimitLow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParLimitHigh"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParLimitHighHigh"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value27.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTimeLowLow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value28.Name}


            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTimeLow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value29.Name}


            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTimeMiddle"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value30.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTimeHigh"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParMonTimeHighHigh"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InHWStop"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value47.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Reference"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value39.Name}

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}
