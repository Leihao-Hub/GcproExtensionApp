using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class VFCAdapter : Element, IGcpro
    {
        public struct VFCAdapterRule
        {
            public GcBaseRule Common;
            public string ioByteInc;
            public string slaveIndexInc;
        }
        public static VFCAdapterRule Rule;
        private string filePath;
        private static string vfcFileName = $@"\{OTypeCollection.EL_VFCAdapter}";
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
        private string hornCode;
        private string pType;
        private string value10;
        private string dpNode1;
        private string meagGateway;
        private string slaveIndex;
        private string outpHardwareStop;
        private string speedMaxDigits;
        private string speedUnitsByZeroDigits;
        private string speedUnitsByMaxDigits;
        private string unitsPerDigits;
        private string speedLimitMin;
        private string speedLimitMax;
        private string ioByteNo;
        private string lenPKW;
        private string lenPZD;
        private string lenPZDInp;
        private string refCurrent;
        private string refTorque;
        private string refPower;
        private VFCTelegram telegram1;
        private VFCTelegram telegram2;
        private VFCTelegram telegram3;
        private VFCTelegram telegram4;
        private VFCTelegram telegram5;

        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        //public string FileRelationPath
        //{
        //    get { return fileRelationPath; }
        //}
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
        public override string Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
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
        public string MeagGateway
        {
            get { return meagGateway; }
            set { meagGateway = value; }
        }
        public string SlaveIndex
        {
            get { return slaveIndex; }
            set { slaveIndex = value; }
        }
        public string OutpHardwareStop
        {
            get { return outpHardwareStop; }
            set { outpHardwareStop = value; }
        }
        public string SpeedMaxDigits
        {
            get { return speedMaxDigits; }
            set { speedMaxDigits = value; }
        }
        public string SpeedUnitsByZeroDigits
        {
            get { return speedUnitsByZeroDigits; }
            set { speedUnitsByZeroDigits = value; }
        }
        public string SpeedUnitsByMaxDigits
        {
            get { return speedUnitsByMaxDigits; }
            set { speedUnitsByMaxDigits = value; }
        }
        public string UnitsPerDigits
        {
            get { return unitsPerDigits; }
            set { unitsPerDigits = value; }
        }
        public string SpeedLimitMin
        {
            get { return speedLimitMin; }
            set { speedLimitMin = value; }
        }
        public string SpeedLimitMax
        {
            get { return speedLimitMax; }
            set { speedLimitMax = value; }
        }
        public string IoByteNo
        {
            get { return ioByteNo; }
            set { ioByteNo = value; }
        }
        public string LenPKW
        {
            get { return lenPKW; }
            set { lenPKW = value; }
        }
        public string LenPZD
        {
            get { return lenPZD; }
            set { lenPZD = value; }
        }
        public string LenPZDInp
        {
            get { return lenPZDInp; }
            set { lenPZDInp = value; }
        }
        public string RefCurrent
        {
            get { return refCurrent; }
            set { refCurrent = value; }
        }
        public string RefTorque
        {
            get { return refTorque; }
            set { refTorque = value; }
        }
        public string RefPower
        {
            get { return refPower; }
            set { refPower = value; }
        }
        public VFCTelegram Telegram1
        {
            get { return telegram1; }
            set { telegram1 = value; }
        }
        public VFCTelegram Telegram2
        {
            get { return telegram2; }
            set { telegram2 = value; }
        }
        public VFCTelegram Telegram3
        {
            get { return telegram3; }
            set { telegram3 = value; }
        }
        public VFCTelegram Telegram4
        {
            get { return telegram4; }
            set { telegram4 = value; }
        }
        public VFCTelegram Telegram5
        {
            get { return telegram5; }
            set { telegram5 = value; }
        }
        #endregion
        #region Readonly  property
        public static string ATVASYNCDP { get; } = "ATVASYNCDP";
        public static string ATVDP { get; } = "ATVDP";
        public static string ATVM { get; } = "ATVM";
        public static string SST01DP { get; } = "SST01DP";
        public static string SST02DP { get; } = "SST02DP";
        public static string VFCA0 { get; } = "VFCA0";
        public static string VFCA1 { get; } = "VFCA1";
        public static string VFCA10 { get; } = "VFCA10";
        public static string VFCA11 { get; } = "VFCA11";
        public static string VFCA12 { get; } = "VFCA12";
        public static string VFCA13 { get; } = "VFCA13";
        public static string VFCA2 { get; } = "VFCA2";
        public static string VFCA3 { get; } = "VFCA3";
        public static string VFCA4 { get; } = "VFCA4";
        public static string VFCA5 { get; } = "VFCA5";
        public static string VFCA6 { get; } = "VFCA6";
        public static string VFCA7 { get; } = "VFCA7";
        public static string VFCANALOG { get; } = "VFCANALOG";
        public static string VFCLS { get; } = "VFCLS";
        public static string VFCMS3RK { get; } = "VFCMS3RK";
        public static string VFCPNG { get; } = "VFCPNG";
        public static string ImpExpRuleName { get; } = "IE_VFCAdapter";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_VFCAdapter;
        #endregion
        public VFCAdapter()
        {
            telegram1 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            telegram2 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            telegram3 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            telegram4 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            telegram5 = new VFCTelegram { ParPNO = LibGlobalSource.NOCHILD, ParUnitsPerDigit = LibGlobalSource.NOCHILD };
            pType = LibGlobalSource.NOCHILD;
            hornCode = LibGlobalSource.NOCHILD;
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.slaveIndexInc = "1";
            Rule.ioByteInc = "12";
            SetOTypeProperty(OTypeCollection.EL_VFCAdapter);
            this.filePath =$"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{vfcFileName}.Txt";
        }
        public VFCAdapter(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{vfcFileName}.Txt" : $"{ filePath}{ vfcFileName}.Txt");
        }
        public void CreateObject(Encoding encoding, bool onlyRelation = false)
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
            objFields.Append(speedLimitMin).Append(LibGlobalSource.TAB)
              .Append(speedLimitMax).Append(LibGlobalSource.TAB)
              .Append(speedMaxDigits).Append(LibGlobalSource.TAB)
              .Append(speedUnitsByZeroDigits).Append(LibGlobalSource.TAB)
              .Append(speedUnitsByMaxDigits).Append(LibGlobalSource.TAB)
              .Append(unitsPerDigits).Append(LibGlobalSource.TAB)
              .Append(ioByteNo).Append(LibGlobalSource.TAB)
              .Append(lenPKW).Append(LibGlobalSource.TAB)
              .Append(lenPZD).Append(LibGlobalSource.TAB)
              .Append(lenPZDInp).Append(LibGlobalSource.TAB)
              .Append(meagGateway).Append(LibGlobalSource.TAB)
              .Append(slaveIndex).Append(LibGlobalSource.TAB)
              .Append(outpHardwareStop).Append(LibGlobalSource.TAB)
              .Append(telegram1.ParPNO).Append(LibGlobalSource.TAB)
              .Append(telegram1.ParUnitsPerDigit).Append(LibGlobalSource.TAB)
              .Append(telegram2.ParPNO).Append(LibGlobalSource.TAB)
              .Append(telegram2.ParUnitsPerDigit).Append(LibGlobalSource.TAB)
              .Append(telegram3.ParPNO).Append(LibGlobalSource.TAB)
              .Append(telegram3.ParUnitsPerDigit).Append(LibGlobalSource.TAB)
              .Append(telegram4.ParPNO).Append(LibGlobalSource.TAB)
              .Append(telegram4.ParUnitsPerDigit).Append(LibGlobalSource.TAB)
              .Append(telegram5.ParPNO).Append(LibGlobalSource.TAB)
              .Append(telegram5.ParUnitsPerDigit).Append(LibGlobalSource.TAB)
              .Append(refCurrent).Append(LibGlobalSource.TAB)
              .Append(refTorque).Append(LibGlobalSource.TAB)
              .Append(refPower);

            textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
            objFields = null;
        }
        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedLimitMin"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value18.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedLimitMax"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value19.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedMaxDigits"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value15.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedUnitsByZeroDigits"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value16.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SpeedUnitsByMaxDigits"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value17.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "UnitsPerDigits" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value14.Name }

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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LenPKW"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value23.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LenPZD"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value24.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "LenPZDInp" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value44.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value ="MEAGGateway"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value11.Name }

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "SlaveIndex"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value12.Name}

             });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "outpHardwareStop"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value13.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram1_ParPNO"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value25.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram1_ParUnitsPerDigit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value35.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram2_ParPNO"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value26.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram2_ParUnitsPerDigit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value36.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram3_ParPNO"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value27.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram3_ParUnitsPerDigit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value37.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram4_ParPNO"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value28.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram4_ParUnitsPerDigit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value38.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram5_ParPNO"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value29.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "Telegram5_ParUnitsPerDigit"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value39.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParRefCurrent"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value40.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParRefTorque"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value41.Name}

            });
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParRefPower"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value42.Name}

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }

    public class VFCTelegram
    {
        public string ParPNO { get; set; }
        public string ParUnitsPerDigit { get; set; }
        public VFCTelegram()
        {
        }
    }

}
