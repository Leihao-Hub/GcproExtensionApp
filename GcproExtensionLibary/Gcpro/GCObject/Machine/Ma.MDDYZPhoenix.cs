using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;


namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class MDDYZPhoenix : Machine
    {
        public struct MDDYZPhoenixRule
        {
            public GcBaseRule Common;
        }
        private string filePath;
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string roll8StandFileName = $@"\{OTypeCollection.MA_MDDYZPhoenix}";
        public static MDDYZPhoenixRule Rule;
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
        private string value10;
        private RollermillSide side1;
        private RollermillSide side2;
        private string lc_COM;
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
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        #endregion
        #region Application properties 
        public override string Value10
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
        public string LC_COM
        {
            get { return lc_COM; }
            set { lc_COM = value; }
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
        #region Readonly  property
        public static string ROLL4 { get; } = "4ROLLDM";
        public static string ROLL8 { get; } = "8ROLLDM";
        public static float P2757 { get; } = 2757f;
        public static string ImpExpRuleName { get; } = "IE_MA_MDDYZPhoenix";
        public static int OTypeValue { get; } = (int)OTypeCollection.MA_MDDYZPhoenix;
        #endregion

        public MDDYZPhoenix()
        {
            side1 = new RollermillSide();
            side2 = new RollermillSide();
            pType = P2757.ToString();
            value10 = "96";
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            SetOTypeProperty(OTypeCollection.MA_Roll8Stand);
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + "_FindConnector.Txt";
        }
        public MDDYZPhoenix(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + ".Txt" : filePath + roll8StandFileName + ".Txt");
            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + "_Relation.Txt" : filePath + roll8StandFileName + "_Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + "_FindConnector.Txt" : filePath + roll8StandFileName + "_FindConnector.Txt");
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
                objFields.Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD);
                textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
                objFields = null;
            }

            var relations = new List<Relation>
            {
               new Relation(name , side1.MotorLow , GcproTable.ObjData.Value12.Name),
               new Relation(name , side1.MotorUp , GcproTable.ObjData.Value11.Name),
               new Relation(name , side1.HLBackupLeft , GcproTable.ObjData.Value13.Name),
               new Relation(name , side1.HLBackupRight , GcproTable.ObjData.Value42.Name),
               new Relation(name , side1.HLInlet , GcproTable.ObjData.Value14.Name),
               new Relation(name , side1.DivHLInlet , GcproTable.ObjData.Value24.Name),
               new Relation(name , side1.HLOutlet3 , GcproTable.ObjData.Value43.Name),
               new Relation(name , side1.FeedRoll , GcproTable.ObjData.Value26.Name),
               new Relation(name , side1.DivFeedRoll , GcproTable.ObjData.Value27.Name),
               new Relation(name , side1.HLOutlet1 , GcproTable.ObjData.Value35.Name),
               new Relation(name , side1.HLOutlet2 , GcproTable.ObjData.Value36.Name),
               new Relation(name , side1.MotorLowCur , GcproTable.ObjData.Value31.Name),
               new Relation(name , side1.MotorUpCur , GcproTable.ObjData.Value30.Name),

               new Relation(name ,side2.MotorLow , GcproTable.ObjData.Value18.Name),
               new Relation(name ,side2.MotorUp , GcproTable.ObjData.Value17.Name),
               new Relation(name ,side2.HLBackupLeft , GcproTable.ObjData.Value19.Name),
               new Relation(name ,side2.HLBackupRight , GcproTable.ObjData.Value44.Name),
               new Relation(name ,side2.HLInlet , GcproTable.ObjData.Value20.Name),
               new Relation(name ,side2.DivHLInlet , GcproTable.ObjData.Value25.Name),
               new Relation(name ,side2.HLOutlet3 , GcproTable.ObjData.Value45.Name),
               new Relation(name ,side2.FeedRoll , GcproTable.ObjData.Value28.Name),
               new Relation(name ,side2.DivFeedRoll , GcproTable.ObjData.Value29.Name),
               new Relation(name ,side2.HLOutlet1 , GcproTable.ObjData.Value37.Name),
               new Relation(name ,side2.HLOutlet2 , GcproTable.ObjData.Value38.Name),
               new Relation(name ,side2.MotorLowCur , GcproTable.ObjData.Value33.Name),
               new Relation(name ,side2.MotorUpCur , GcproTable.ObjData.Value32.Name),

               new Relation(name ,lc_COM, GcproTable.ObjData.Value41.Name),
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 MotorUp"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 MotorLow"},
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side1 HLOutlet3"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value43.Name}

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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 MotorUp"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value17.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 MotorLow"},
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Side2 HLOutlet3"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value45.Name}

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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LC_COM"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value41.Name}

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}