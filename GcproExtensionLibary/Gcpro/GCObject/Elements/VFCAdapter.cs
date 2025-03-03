using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class VFCAdapter : Element
    {
        public struct VFCAdapterRule
        {
            public GcBaseRule Common;
            public int ioByteInc;
            public int slaveIndexInc;
        }
        public static VFCAdapterRule Rule;
        private string filePath;
        private readonly static string vfcFileName = $@"\{OTypeCollection.EL_VFCAdapter}";
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
        private string isNew;
        private double hornCode;
        private double pType;
        private double value10;
        private double dpNode1;
        private string meagGateway;
        private double slaveIndex;
        private string outpHardwareStop;
        private double speedMaxDigits;
        private double speedUnitsByZeroDigits;
        private double speedUnitsByMaxDigits;
        private double unitsPerDigits;
        private double speedLimitMin;
        private double speedLimitMax;
        private double ioByteNo;
        private double lenPKW;
        private double lenPZD;
        private double lenPZDInp;
        private double refCurrent;
        private double refTorque;
        private double refPower;
        private VFCTelegram telegram1;
        private VFCTelegram telegram2;
        private VFCTelegram telegram3;
        private VFCTelegram telegram4;
        private VFCTelegram telegram5;
        #region cosnt
        private const string _ATVASYNCDP = "ATVASYNCDP";
        private const string _ATVDP = "ATVDP";
        private const string _ATVM = "ATVM";
        private const string _SST01DP = "SST01DP";
        private const string _SST02DP = "SST02DP";
        private const string _VFCA0 = "VFCA0";
        private const string _VFCA1 = "VFCA1";
        private const string _VFCA10 = "VFCA10";
        private const string _VFCA11 = "VFCA11";
        private const string _VFCA12 = "VFCA12";
        private const string _VFCA13 = "VFCA13";
        private const string _VFCA2 = "VFCA2";
        private const string _VFCA3 = "VFCA3";
        private const string _VFCA4 = "VFCA4";
        private const string _VFCA5 = "VFCA5";
        private const string _VFCA6 = "VFCA6";
        private const string _VFCA7 = "VFCA7";
        private const string _VFCANALOG = "VFCANALOG";
        private const string _VFCLS = "VFCLS";
        private const string _VFCMS3RK = "VFCMS3RK";
        private const string _VFCPNG = "VFCPNG";
        #endregion
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
            set 
            {
                if (name != value)
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
        public override double Value10
        {
            get { return value10; }
            set { value10 = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
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
        public string MeagGateway
        {
            get { return meagGateway; }
            set { meagGateway = value; }
        }
        public double SlaveIndex
        {
            get { return slaveIndex; }
            set { slaveIndex = value; }
        }
        public string OutpHardwareStop
        {
            get { return outpHardwareStop; }
            set { outpHardwareStop = value; }
        }
        public double SpeedMaxDigits
        {
            get { return speedMaxDigits; }
            set { speedMaxDigits = value; }
        }
        public double SpeedUnitsByZeroDigits
        {
            get { return speedUnitsByZeroDigits; }
            set { speedUnitsByZeroDigits = value; }
        }
        public double SpeedUnitsByMaxDigits
        {
            get { return speedUnitsByMaxDigits; }
            set { speedUnitsByMaxDigits = value; }
        }
        public double UnitsPerDigits
        {
            get { return unitsPerDigits; }
            set { unitsPerDigits = value; }
        }
        public double SpeedLimitMin
        {
            get { return speedLimitMin; }
            set { speedLimitMin = value; }
        }
        public double SpeedLimitMax
        {
            get { return speedLimitMax; }
            set { speedLimitMax = value; }
        }
        public double IoByteNo
        {
            get { return ioByteNo; }
            set { ioByteNo = value; }
        }
        public double LenPKW
        {
            get { return lenPKW; }
            set { lenPKW = value; }
        }
        public double LenPZD
        {
            get { return lenPZD; }
            set { lenPZD = value; }
        }
        public double LenPZDInp
        {
            get { return lenPZDInp; }
            set { lenPZDInp = value; }
        }
        public double RefCurrent
        {
            get { return refCurrent; }
            set { refCurrent = value; }
        }
        public double RefTorque
        {
            get { return refTorque; }
            set { refTorque = value; }
        }
        public double RefPower
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
        public static string ATVASYNCDP { get; } = _ATVASYNCDP;
        public static string ATVDP { get; } = _ATVDP;
        public static string ATVM { get; } = _ATVM;
        public static string SST01DP { get; } = _SST01DP;
        public static string SST02DP { get; } = _SST02DP;
        public static string VFCA0 { get; } = _VFCA0;
        public static string VFCA1 { get; } = _VFCA1;
        public static string VFCA10 { get; } = _VFCA10;
        public static string VFCA11 { get; } = _VFCA11;
        public static string VFCA12 { get; } = _VFCA12;
        public static string VFCA13 { get; } = _VFCA13;
        public static string VFCA2 { get; } = _VFCA2;
        public static string VFCA3 { get; } = _VFCA3;
        public static string VFCA4 { get; } = _VFCA4;
        public static string VFCA5 { get; } = _VFCA5;
        public static string VFCA6 { get; } = _VFCA6;
        public static string VFCA7 { get; } = _VFCA7;
        public static string VFCANALOG { get; } = _VFCANALOG;
        public static string VFCLS { get; } = _VFCLS;
        public static string VFCMS3RK { get; } = _VFCMS3RK;
        public static string VFCPNG { get; } = _VFCPNG;
        public static string ImpExpRuleName { get; } = "IE_VFCAdapter";
        public static int OTypeValue { get; } = (int)OTypeCollection.EL_VFCAdapter;
        #endregion
        public VFCAdapter()
        {
            telegram1 = new VFCTelegram { ParPNO = 0, ParUnitsPerDigit = 0 };
            telegram2 = new VFCTelegram { ParPNO = 0, ParUnitsPerDigit = 0 };
            telegram3 = new VFCTelegram { ParPNO = 0, ParUnitsPerDigit = 0 };
            telegram4 = new VFCTelegram { ParPNO = 0, ParUnitsPerDigit = 0 };
            telegram5 = new VFCTelegram { ParPNO = 0, ParUnitsPerDigit = 0 };
            pType = 0;
            hornCode = 0;
            ///Default parameters
            subType = _ATVDP;
            slaveIndex = 0;
            speedLimitMin = 0;
            speedLimitMax = 100;
            speedMaxDigits = 500;
            speedUnitsByZeroDigits = 0;
            speedUnitsByMaxDigits = 100;
            unitsPerDigits = 0.1;
            lenPZDInp = 0;
            ///Default parameters 
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.slaveIndexInc = 1;
            Rule.ioByteInc = 12;
            SetOTypeProperty(OTypeCollection.EL_VFCAdapter);
            objectRecord = new List<string>();
            objectRelation = new List<string>();
            relation = new Relation();
            this.filePath =$"{ LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH }{ vfcFileName }.Txt";
        }
        public VFCAdapter(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            $"{ LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{vfcFileName }.Txt" : $"{ filePath }{ vfcFileName }.Txt");
        }

        /// <summary>
        /// 创建对象文本与关系文件，暂存与内存中
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="onlyRelation"></param>
        public void CreateObjectRecordAndRelation(StringBuilder sb, bool onlyRelation = false)
        {       
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
            sb.Append(speedLimitMin).Append(tab)
              .Append(speedLimitMax).Append(tab)
              .Append(speedMaxDigits).Append(tab)
              .Append(speedUnitsByZeroDigits).Append(tab)
              .Append(speedUnitsByMaxDigits).Append(tab)
              .Append(Math.Round(unitsPerDigits, 6)).Append(tab)
              .Append(ioByteNo).Append(tab)
              .Append(lenPKW).Append(tab)
              .Append(lenPZD).Append(tab)
              .Append(lenPZDInp).Append(tab)
              .Append(meagGateway).Append(tab)
              .Append(slaveIndex).Append(tab)
              .Append(outpHardwareStop).Append(tab)
              .Append(telegram1.ParPNO).Append(tab)
              .Append(telegram1.ParUnitsPerDigit).Append(tab)
              .Append(telegram2.ParPNO).Append(tab)
              .Append(telegram2.ParUnitsPerDigit).Append(tab)
              .Append(telegram3.ParPNO).Append(tab)
              .Append(telegram3.ParUnitsPerDigit).Append(tab)
              .Append(telegram4.ParPNO).Append(tab)
              .Append(telegram4.ParUnitsPerDigit).Append(tab)
              .Append(telegram5.ParPNO).Append(tab)
              .Append(telegram5.ParUnitsPerDigit).Append(tab)
              .Append(refCurrent).Append(tab)
              .Append(refTorque).Append(tab)
              .Append(refPower);
            objectRecord.Add(sb.ToString());
            sb.Clear();
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
        private void SetSpeedParameters(int min, int max, int maxDigits, int unitsZeroDigits, int unitsMaxUnits, float speedUnitsPerDigits)
        {
            speedLimitMin = min;
            speedLimitMax = max;
            speedMaxDigits = maxDigits;
            speedUnitsByZeroDigits = unitsZeroDigits;
            speedUnitsByMaxDigits = unitsMaxUnits;
            unitsPerDigits = speedUnitsPerDigits;
        }
        private void ATVCommonParameters()
        {
            slaveIndex = 0;
            SetSpeedParameters(0,100,500,0,100,0.1f);
            lenPZDInp = 0;
        }
  
        private void SubTypeChangeAfterEvent()
        {
            if (!string.IsNullOrEmpty(subType))
            {
                switch (subType) 
                {           
                    case _ATVDP://ATV Fieldbus (only synch)
                        {
                            ATVCommonParameters(); 
                            telegram1.ParPNO = 0;
                            telegram1.ParUnitsPerDigit = 0;
                            telegram2.ParPNO = 0;
                            telegram2.ParUnitsPerDigit = 0;
                            telegram3.ParPNO = 0;
                            telegram3.ParUnitsPerDigit = 0;
                            telegram4.ParPNO = 0;
                            telegram4.ParUnitsPerDigit = 0;
                            telegram5.ParPNO = 0;
                            telegram5.ParUnitsPerDigit = 0;
                            break;
                        }
                    case _ATVASYNCDP://ATV Fieldbus with Async
                        {
                            ATVCommonParameters();                                   
                            break;
                        }                       
                    case _VFCA0://MOVIDRIVE Speed
                    case _VFCA10://MOVIDRIVE IPos
                    case _VFCA6://MOVITRAC
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(-100, 100, 16384, 0, 100, 0f);               
                            lenPZDInp = 0;
                            lenPKW = 0;
                            lenPZD = 6;
                            break;
                        }
                    case _VFCA1://MicroMaster
                    case _VFCA2://Sinamics
                    case _VFCA3://NORD
                    case _VFCA4://Danfoss FC
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(-100, 100, 16384, 0, 100, 0f);                      
                            lenPKW = 0;
                            lenPZD = 12;
                            break;
                        }            
                    case _VFCA5://Danfoss Profidrive
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(-100, 100, 16384, 0, 100, 0f);                       
                            lenPKW = 8;
                            lenPZD = 20;
                            telegram1.ParPNO = 414;
                            telegram1.ParUnitsPerDigit = 0.1;
                            telegram2.ParPNO = 120;
                            telegram2.ParUnitsPerDigit = 0.01;
                            break;
                        }
                    case _VFCA7://ABB
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(-100, 100, 20000, 0, 100, 0f);                        
                            lenPZDInp = 0;
                            break;
                        }
                      
                     case _SST01DP://Softstart Sirius 3RW44
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(0, 0, 0, 0, 0, 0f);                   
                            lenPZDInp = 0;
                            lenPKW = 0;
                            lenPZD = 2;
                            break;
                        }
                    case _SST02DP://Softstart Sirius 3RW5x
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(0, 0, 0, 0, 0, 0f);                       
                            lenPZDInp = 16;
                            lenPKW = 0;
                            lenPZD = 4;
                            break;
                        }
                    case _VFCA11://Lenze
                    case _VFCA12://Lenze Pos
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(0, 0, 0, 0, 0, 0f);                      
                            lenPZDInp = 16;
                            lenPKW = 0;
                            lenPZD = 4;
                            break;
                        }
                    case _VFCA13://MOVIKIT
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(0, 0, 0, 0, 0, 0f);                  
                            lenPZDInp = 16;
                            lenPKW = 0;
                            lenPZD = 4;
                            telegram1.ParPNO = 8326;
                            telegram1.ParUnitsPerDigit = 0.001;
                            telegram2.ParPNO = 8323;
                            telegram2.ParUnitsPerDigit = 0.001;
                            break;
                        }
                    case _VFCLS://Leroy-Somer
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(0, 100, 1000, 0, 100, 0f);                     
                            lenPZDInp = 0;
                            lenPKW = 0;
                            lenPZD = 12;
                            break;
                        }
                    case _VFCMS3RK://ET200SP Motor Starter
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(0, 100, 27648, 0, 100, 0f);                      
                            unitsPerDigits = 0;
                            lenPZDInp = 0;
                            lenPKW = 0;
                            lenPZD = 4;
                            break;
                        }
                    case _ATVM://ATV MEAG
                        {
                            SetSpeedParameters(0, 100, 1000, 0, 100, 0.1f);                     
                            lenPZDInp = 0;
                            lenPKW = 0;
                            lenPZD = 16;
                            ioByteNo = 0;
                            break;
                        }
                    case _VFCPNG://ATV Profinte gateway
                        {
                            ATVCommonParameters();
                            speedMaxDigits = 1000;                    
                            lenPKW = 0;
                            lenPZD = 16;
                            ioByteNo = 0;
                            break;
                        }
                    default:
                        {
                            slaveIndex = 0;
                            SetSpeedParameters(0, 100, 500, 0, 100, 0.1f);               
                            lenPZDInp = 0;
                            lenPKW = 8;
                            lenPZD = 12;
                            break;
                        }                       
                }
                       
            }
        }
        #endregion
    }

    public class VFCTelegram
    {
        public double ParPNO { get; set; }
        public double ParUnitsPerDigit { get; set; }
        public VFCTelegram()
        {
        }
    }

}
