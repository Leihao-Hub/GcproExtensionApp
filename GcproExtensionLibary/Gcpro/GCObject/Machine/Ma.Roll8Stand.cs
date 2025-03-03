using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;



namespace GcproExtensionLibrary.Gcpro.GCObject
{

    public class Roll8Stand : Machine
    {
        public struct Roll8StandRule
        {
            public GcBaseRule Common;
        }
        private string filePath;
        private readonly string fileRelationPath;
        private readonly string fileConnectorPath;
        private readonly static string roll8StandFileName = $@"\{OTypeCollection.MA_Roll8Stand}";
        public static Roll8StandRule Rule;
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
        private RollermillSide side1;
        private RollermillSide side2;
        private string mddx;
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
        public RollermillSide Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public RollermillSide Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public string MDDx
        {
            get { return mddx; }
            set { mddx = value; }
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
        public static string ROLL4 { get; } = "4ROLL";
        public static string ROLL4M { get; } = "4ROLLM";
        public static string ROLL8 { get; } = "8ROLL";
        public static string ROLL8M { get; } = "8ROLLM";
        public static string ROLL8M2M { get; } = "8ROLLM2M";
        public static float P2046 { get; } = 2046f;
        public static string ImpExpRuleName { get; } = "IE_MA_Roll8Stand";
        public static int OTypeValue { get; } = (int)OTypeCollection.MA_Roll8Stand;
        #endregion

        public Roll8Stand()
        {
            side1 = new RollermillSide();
            side2 = new RollermillSide();
            pType = P2046;
            value10 = 786656;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            SetOTypeProperty(OTypeCollection.MA_Roll8Stand);
            objectRecord = new List<string>();
            objectRelation = new List<string>();
            relation = new Relation();
            string commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{roll8StandFileName}";
            this.filePath = $"{commonDefaultFilePath}.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_Relation.Txt";
            this.fileRelationPath = $"{commonDefaultFilePath}_FindConnector.Txt";
        }
        public Roll8Stand(string filePath = null) : this()
        {
            string commonDefaultFilePath, commonUserFilePath;
            commonDefaultFilePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{roll8StandFileName}";
            commonUserFilePath = $"{filePath}{roll8StandFileName}";
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
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild).Append(tab)
                  .Append(noChild);
                objectRecord.Add(sb.ToString());
                sb.Clear();
            }
            CreateRelation(sb, name, side1.MotorLow, GcproTable.ObjData.Value11.Name);
            CreateRelation(sb, name, side1.MotorUp, GcproTable.ObjData.Value12.Name);
            CreateRelation(sb, name, side1.HLBackupLeft, GcproTable.ObjData.Value13.Name);
            CreateRelation(sb, name, side1.HLBackupRight, GcproTable.ObjData.Value42.Name);
            CreateRelation(sb, name, side1.HLInlet, GcproTable.ObjData.Value14.Name);
            CreateRelation(sb, name, side1.DivHLInlet, GcproTable.ObjData.Value24.Name);
            CreateRelation(sb, name, side1.SM1, GcproTable.ObjData.Value15.Name);
            CreateRelation(sb, name, side1.HLOutlet3, GcproTable.ObjData.Value43.Name);
            CreateRelation(sb, name, side1.InpPressure, GcproTable.ObjData.Value16.Name);
            CreateRelation(sb, name, side1.FeedRoll, GcproTable.ObjData.Value26.Name);
            CreateRelation(sb, name, side1.DivFeedRoll, GcproTable.ObjData.Value27.Name);
            CreateRelation(sb, name, side1.HLOutlet1, GcproTable.ObjData.Value35.Name);
            CreateRelation(sb, name, side1.HLOutlet2, GcproTable.ObjData.Value36.Name);
            CreateRelation(sb, name, side1.MotorLowCur, GcproTable.ObjData.Value31.Name);
            CreateRelation(sb, name, side1.MotorUpCur, GcproTable.ObjData.Value30.Name);
            CreateRelation(sb, name, side2.MotorLow, GcproTable.ObjData.Value17.Name);
            CreateRelation(sb, name, side2.MotorUp, GcproTable.ObjData.Value18.Name);
            CreateRelation(sb, name, side2.HLBackupLeft, GcproTable.ObjData.Value19.Name);
            CreateRelation(sb, name, side2.HLBackupRight, GcproTable.ObjData.Value44.Name);
            CreateRelation(sb, name, side2.HLInlet, GcproTable.ObjData.Value20.Name);
            CreateRelation(sb, name, side2.DivHLInlet, GcproTable.ObjData.Value25.Name);
            CreateRelation(sb, name, side2.SM1, GcproTable.ObjData.Value21.Name);
            CreateRelation(sb, name, side2.HLOutlet3, GcproTable.ObjData.Value45.Name);
            CreateRelation(sb, name, side2.InpPressure, GcproTable.ObjData.Value22.Name);
            CreateRelation(sb, name, side2.FeedRoll, GcproTable.ObjData.Value28.Name);
            CreateRelation(sb, name, side2.DivFeedRoll, GcproTable.ObjData.Value29.Name);
            CreateRelation(sb, name, side2.HLOutlet1, GcproTable.ObjData.Value37.Name);
            CreateRelation(sb, name, side2.HLOutlet2, GcproTable.ObjData.Value38.Name);
            CreateRelation(sb, name, side2.MotorLowCur, GcproTable.ObjData.Value33.Name);
            CreateRelation(sb, name, side2.MotorUpCur, GcproTable.ObjData.Value32.Name);
            CreateRelation(sb, name, MDDx, GcproTable.ObjData.Value41.Name);

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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 MotorLow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 MotorUp"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 HLBackupLeft"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 HLBackupRight"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 HLInlet"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1Div HLInlet" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 SM1"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value15.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 HLOutlet3"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value43.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 InpPressure"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value16.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 Feedroll" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="Side1Div Feedroll"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value27.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 HLOutlet1"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value35.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 HLOutlet2"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value36.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 MotorLowCur"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 MotorUpCur"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value30.Name}

            });


            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 MotorLow"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value17.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 MotorUp"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value18.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 HLBackupLeft"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value19.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 HLBackupRight"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value44.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 HLInlet"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value20.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2Div HLInlet" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 SM1"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 HLOutlet3"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value45.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 InpPressure"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 Feedroll" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value28.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="Side2Div Feedroll"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value29.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 HLOutlet1"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value37.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 HLOutlet2"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 MotorLowCur"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value33.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 MotorUpCur"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "MDDx"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value41.Name}

            });

            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}