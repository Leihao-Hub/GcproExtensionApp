using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml.Linq;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class DI:Element, IGcpro
    {
        public struct DIRule
        {
            public GcBaseRule Common;
        }
        private string filePath;
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string diFileName = $@"\{OTypeCollection.EL_DI}";
        public static DIRule Rule;
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
        private string inpTrue;
        private string inpFaultDev;
        private string inHWStop;
        private string outpFaultReset;
        private string outpPowerOff;
        private string outpLamp;      
        private string delayChange;
        private string delayTrue;
        private string delayFalse;
        private string timeoutTrue;
        private string timeoutFalse;
        private string refSpecial;
        private string refMRMAMixer;
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
        public  string Value9
        {
            get { return value9; }
            set { value9 = value; }
        }
        public override string Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public string InpTrue
        {
            get { return inpTrue; }
            set { inpTrue = value; }
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
        public string OutpFaultReset
        {
            get { return outpFaultReset; }
            set { outpFaultReset = value; }
        }
        public string OutpPowerOff
        {
            get { return outpPowerOff; }
            set { outpPowerOff = value; }
        }
        public string OutpLamp
        {
            get { return outpLamp; }
            set { outpLamp = value; }
        }
        public string DelayChange
        {
            get { return delayChange; }
            set { delayChange = value; }
        }
        public string DelayTrue
        {
            get { return delayTrue; }
            set { delayTrue = value; }
        }
        public string DelayFalse
        {
            get { return delayFalse; }
            set { delayFalse = value; }
        }
        public string TimeoutTrue
        {
            get { return timeoutTrue; }
            set { timeoutTrue = value; }
        }
        public string TimeoutFalse
        {
            get { return timeoutFalse; }
            set { timeoutFalse = value; }
        }
        public string RefSpecial
        {
            get { return refSpecial ; }
            set { refSpecial = value; }
        }
   
        public string RefMRMAMixer
        {
            get { return refMRMAMixer; }
            set { refMRMAMixer = value; }
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
        public static string DIC { get; } = "DIC";
        public static string DICFU { get; } = "DICFU";
        public static string FLOW { get; } = "FLOW";
        public static string HLBIN { get; } = "HLBIN";
        public static string LLBIN { get; } = "LLBIN";
        public static string HLMA { get; } = "HLMA";
        public static string LLMA { get; } = "LLMA";
        public static string MON1 { get; } = "MON1";
        public static string MON1MPPS { get; } = "MON1MPPS";
        public static string MON1M_LS { get; } = "MON1M_LS";
        public static string MON1M_TS { get; } = "MON1M_TS";
        public static string MON2PRLSS { get; } = "MON2PRLSS";
        public static string MON1MPH { get; } = "MON1MPH";
        public static string MON1MDS { get; } = "MON1MDS";
        public static string MON1MVC { get; } = "MON1MVC";
        public static string MON1OBAT { get; } = "MON1OBAT";
        public static string MON1OMAN { get; } = "MON1OMAN";
        public static string MON1OPCC { get; } = "MON1OPCC";
        public static string MON1OPLC { get; } = "MON1OPLC";
        public static string MON1OSYS { get; } = "MON1OSYS";
        public static string MON1OYIELD { get; } = "MON1OYIELD";
        public static string MON2 { get; } = "MON2";
        public static string MON2SS { get; } = "MON2SS";
        public static string MON2SSP { get; } = "MON2SSP";
        public static string MON2BS { get; } = "MON2BS";
        public static float P7131 { get; } = 7131f;
        public static float P7135 { get; } = 7135f;
        public static float P7136 { get; } = 7136f;
        public static float P7137 { get; } = 7137f;
        public static float P7139 { get; } = 7139f;
        public static float P7140 { get; } = 7140f;
        public static float P7141 { get; } = 7141f;
        public static float P7142 { get; } = 7142f;
        public static float P7143 { get; } = 7143f;
        public static float P7144 { get; } = 7144f;
        public static float P7145 { get; } = 7145f;
        public static float P7146 { get; } = 7146f;
        public static float P7147 { get; } = 7147f;
        public static float P7148 { get; } = 7148f;
        public static float P7149 { get; } = 7149f;
        public static float P7150 { get; } = 7150f;
        public static float P7151 { get; } = 7151f;
        public static float P7152 { get; } = 7152f;
        public static float P7153 { get; } = 7153f;
        public static float P7154 { get; } = 7154f;
        public static float P7155 { get; } = 7155f;
        public static float P7156 { get; } = 7156f;
        public static float P7158 { get; } = 7158f;
        public static float P7159 { get; } = 7159f;
        public static float P7161 { get; } = 7161f;
        public static float P7161_1 { get; } = 7161.1f;
        public static float P7162 { get; } = 7162f;
        public static float P7163 { get; } = 7163f;
        public static float P7164 { get; } = 7164f;
        public static float P7165 { get; } = 7165f;
        public static float P7166 { get; } = 7166f;
        public static float P7167 { get; } = 7167f;
        public static float P7168 { get; } = 7168f;
        public static float P7169 { get; } = 7169f;
        public static float P7170 { get; } = 7170f;
        public static float P7171 { get; } = 7171f;
        public static float P7172 { get; } = 7172f;
        public static float P7173 { get; } = 7173f;
        public static float P7174 { get; } = 7174f;
        public static float P7175 { get; } = 7175f;
        public static float P7176 { get; } = 7176f;
        public static float P7177 { get; } = 7177f;
        public static float P7188 { get; } = 7188f;
        public static string ImpExpRuleName { get; } = "IE_EL_DI";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_DI;
        #endregion
        public DI()
        {
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            name = "-BLH01";
            description = "EL_DI";
            subType = "DIC";
            processFct = string.Empty;          
            building = "--";
            elevation = "--";
            fieldBusNode = string.Empty;
            panel_ID = string.Empty;
            diagram = string.Empty;
            page = string.Empty;
            pType = P7147.ToString();
            hornCode = LibGlobalSource.NOCHILD;
            dpNode1 = LibGlobalSource.NOCHILD;
            value9 = "0";
            value10 = "10";
            inpTrue = LibGlobalSource.NOCHILD;
            inpFaultDev = LibGlobalSource.NOCHILD;
            inHWStop = LibGlobalSource.NOCHILD;
            outpFaultReset = LibGlobalSource.NOCHILD;
            outpPowerOff = LibGlobalSource.NOCHILD;
            outpLamp = LibGlobalSource.NOCHILD;
            delayChange = "5";
            delayTrue = "20";
            delayFalse = "5";
            timeoutTrue = "0";
            timeoutFalse = "0";
            refSpecial = string.Empty;
            refMRMAMixer = string.Empty;
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + diFileName + "_FindConnector.Txt";
        }
        public DI(string filePath = null) : this()
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
                ///生产Standard字符串部分-使用父类中方法实现
                ///</summary> 
                objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
                  .Append(base.CreateObjectStandardPart(encoding)).Append(LibGlobalSource.TAB);
                ///<summary>
                ///生成Application 字符串部分
                ///</summary>
                objFields.Append(value9).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(delayChange).Append(LibGlobalSource.TAB)
                  .Append(delayTrue).Append(LibGlobalSource.TAB)
                  .Append(delayFalse).Append(LibGlobalSource.TAB)
                  .Append(timeoutTrue).Append(LibGlobalSource.TAB)
                  .Append(timeoutFalse).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                  .Append(LibGlobalSource.NOCHILD);
                textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
                objFields = null;
            }
           

            var relations = new List<Relation>
            {
                new Relation(name,inpTrue, GcproTable.ObjData.Value11.Name),
                new Relation(name,refSpecial, GcproTable.ObjData.Value46.Name),
                new Relation(name,refMRMAMixer, GcproTable.ObjData.Value31.Name),
            };
           CreateRelations(relations,this.fileRelationPath,encoding);           
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InpTrue"},
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "InHWStop"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value47.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpFaultReset"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpPowerOff" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "OutpLamp"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayChange"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value21.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayTrue"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value22.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParDelayFalse" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="ParTimeoutTrue"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParTimeoutFalse"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Special"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value46.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "MRMAMixer"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name}

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }

    }
}
