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
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string diFileName = $@"\{OTypeCollection.EL_AI}";
        public static AIRule Rule;
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
        private string hornCode;
        private string dpNode1;
        private string value9;
        private string value10;
        private string inpValue;
        private string inpFaultDev;
        private string inHWStop;
        private string inpLowLow;
        private string inpLow;
        private string inpHighHigh;
        private string inpHigh;
        private string unitsBy100;
        private string offsetUnits;
        private string delayTimeDown;
        private string delayTimeUp;
        private string delayFaultTime;
        private string limitLowLow;
        private string limitLow;
        private string limitHighHigh;
        private string limitHigh;
        private string monTimeLowLow;
        private string monTimeLow;
        private string monTimeMiddle;
        private string monTimeHighHigh;
        private string monTimeHigh;
        private string unit;
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

        public string UnitsBy100
        {
            get { return unitsBy100; }
            set { unitsBy100 = value; }
        }
        public string OffsetUnits
        {
            get { return offsetUnits; }
            set { offsetUnits = value; }
        }

        public string DelayTimeDown
        {
            get { return delayTimeDown; }
            set { delayTimeDown = value; }
        }

        public string DelayTimeUp
        {
            get { return delayTimeUp; }
            set { delayTimeUp = value; }
        }

        public string DelayFaultTime
        {
            get { return delayFaultTime; }
            set { delayFaultTime = value; }
        }

        public string LimitLowLow
        {
            get { return limitLowLow; }
            set { limitLowLow = value; }
        }

        public string LimitLow
        {
            get { return limitLow; }
            set { limitLow = value; }
        }

        public string LimitHighHigh
        {
            get { return limitHighHigh; }
            set { limitHighHigh = value; }
        }

        public string LimitHigh
        {
            get { return limitHigh; }
            set { limitHigh = value; }
        }

        public string MonTimeLowLow
        {
            get { return monTimeLowLow; }
            set { monTimeLowLow = value; }
        }

        public string MonTimeLow
        {
            get { return monTimeLow; }
            set { monTimeLow = value; }
        }

        public string MonTimeMiddle
        {
            get { return monTimeMiddle; }
            set { monTimeMiddle = value; }
        }

        public string MonTimeHighHigh
        {
            get { return monTimeHighHigh; }
            set { monTimeHighHigh = value; }
        }

        public string MonTimeHigh
        {
            get { return monTimeHigh; }
            set { monTimeHigh = value; }
        }
        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }
        public string Unit
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

            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-AI";
            description = "EL_AI";
            subType = "AIT";
            processFct = string.Empty;
            building = "--";
            elevation = "--";
            fieldBusNode = string.Empty;
            panel_ID = string.Empty;
            diagram = string.Empty;
            page = string.Empty;
            pType = P7252.ToString();
            hornCode = LibGlobalSource.NOCHILD;
            dpNode1 = LibGlobalSource.NOCHILD;
            value9 = "32";
            value10 = "32";
            OffsetUnits = "0";
            delayTimeDown = "10.0";
            delayTimeUp = "10.0";
            delayFaultTime = "10.0";
            monTimeLowLow = "10.0";
            monTimeLow = "10.0";
            monTimeMiddle = "10.0";
            monTimeHigh = "10.0";
            monTimeHighHigh = "20.0";
            inpValue = string.Empty;
            inpLowLow = string.Empty;
            inpLow = string.Empty;
            inpHigh = string.Empty;
            inpHighHigh = string.Empty;
            inpFaultDev = string.Empty;
            inHWStop = string.Empty;
            reference = string.Empty;
            SetOTypeProperty(OTypeCollection.EL_AI);
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_FindConnector.Txt";
        }
        public AI(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + ".Txt" : filePath + diFileName + ".Txt");

            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                          LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_Relation.Txt" : filePath + diFileName + "_Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                     LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_FindConnector.Txt" : filePath + diFileName + "_FindConnector.Txt");
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
                objFields.Append(value9).Append(LibGlobalSource.TAB)
                  .Append(string.Empty).Append(LibGlobalSource.TAB)
                  .Append(string.Empty).Append(LibGlobalSource.TAB)
                  .Append(string.Empty).Append(LibGlobalSource.TAB)
                  .Append(string.Empty).Append(LibGlobalSource.TAB)
                  .Append(string.Empty).Append(LibGlobalSource.TAB)
                  .Append(string.Empty).Append(LibGlobalSource.TAB)
                  .Append(unitsBy100).Append(LibGlobalSource.TAB)
                  .Append(offsetUnits).Append(LibGlobalSource.TAB)
                  .Append(delayTimeDown).Append(LibGlobalSource.TAB)
                  .Append(delayTimeUp).Append(LibGlobalSource.TAB)
                  .Append(delayFaultTime).Append(LibGlobalSource.TAB)
                  .Append(unit).Append(LibGlobalSource.TAB)
                  .Append(limitLowLow).Append(LibGlobalSource.TAB)
                  .Append(limitLow).Append(LibGlobalSource.TAB)
                  .Append(limitHigh).Append(LibGlobalSource.TAB)
                  .Append(limitHighHigh).Append(LibGlobalSource.TAB)
                  .Append(monTimeLowLow).Append(LibGlobalSource.TAB)
                  .Append(monTimeLow).Append(LibGlobalSource.TAB)
                  .Append(monTimeMiddle).Append(LibGlobalSource.TAB)
                  .Append(monTimeHigh).Append(LibGlobalSource.TAB)
                  .Append(monTimeHighHigh).Append(LibGlobalSource.TAB)
                  .Append(string.Empty).Append(LibGlobalSource.TAB)
                  .Append(string.Empty);
                textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
                objFields = null;
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
