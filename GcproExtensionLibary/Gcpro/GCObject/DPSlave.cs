﻿using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class DPSlave : Element

    {
        public struct DPSlaveRule
        {
            public GcBaseRule Common;
            public int IPAddressInc;
            public int SlaveNoInc;
        }
        private string filePath;
        //private string fileRelationPath;
        //private string fileConnectorPath;
        private readonly static string dpSlaveFileName = $@"\{OTypeCollection.DP_Slave}";
        public static DPSlaveRule Rule;
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
        private double value10;
        private double value31;
        private string ipAddr;
        private int slaveNo;
        private int updateTime;
        private int watchDogFactor;
        private int watchDogTime;
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
        public double Value31
        {
            get { return value31; }
            set { value31 = value; }
        }
        public string IPAddr
        {
            get { return ipAddr; }
            set { ipAddr = value; }
        }
        public int SlaveNo
        {
            get { return slaveNo; }
            set { slaveNo = value; }
        }
        public int UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        public int WatchDogFactor
        {
            get { return watchDogFactor; }
            set { watchDogFactor = value; }
        }
        public int WatchDogTime
        {
            get { return watchDogTime; }
            set { watchDogTime = value; }
        }
        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        #endregion
        #region Readonly property
        public static string Profibus { get; } = "Profibus";
        public static string Profinet { get; } = "Profinet";
        public static string ProfinetIOLINKIFM { get; } = "ProfinetIOLINKIFM";
        public static string WAGO { get; } = "WAGO";
        public static float P7895 { get; } = 7895f;
        public static string ImpExpRuleName { get; } = "IE_DPSlave";
        public static int OTypeValue { get; } = (int)OTypeCollection.DP_Slave;
        #endregion
        public DPSlave()
        {
            Rule.Common.DescriptionRuleInc = Rule.Common.NameRuleInc = "1";
            Rule.IPAddressInc = Rule.SlaveNoInc = 1;
            ipAddr = "192.168.1.2";
            updateTime = 1;
            slaveNo = 3;
            watchDogFactor = 200;
            pType = P7895;
            fieldBusNode = 0;
            panel_ID = string.Empty;
            diagram = 0;
            page = string.Empty;
            hornCode = 00;
            dpNode1 = 0;
            value10 = 0;
            SetOTypeProperty(OTypeCollection.DP_Slave);
            this.filePath = $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{dpSlaveFileName}.Txt";
        }
        public DPSlave(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                            $"{LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH}{dpSlaveFileName}.Txt" : $"{filePath}{dpSlaveFileName}.Txt");
        }
        /// 创建GCPRO对象与与对象关系文件
        /// </summary>
        /// <param name="textFileHandle">TextFileHandle类实例</param>
        /// <param name="sbObjFields">StringBuilder类实例</param>
        /// <param name="encoding">文本文件的导入编码</param>
        /// <param name="onlyRelation">=true时,仅创建关系文件；=false时,同时创建对象与对象关系导入文件</param>
        public void CreateObject(TextFileHandle textFileHandle, StringBuilder sb, Encoding encoding, bool onlyRelation = false)
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
                sb.Append(value31).Append(tab)
                   .Append(ipAddr).Append(tab)
                   .Append(slaveNo).Append(tab)
                   .Append(updateTime).Append(tab)
                   .Append(watchDogFactor).Append(tab)
                   .Append(watchDogTime);
                textFileHandle.WriteToTextFile(sb.ToString(), encoding);
                sb.Clear();          
            }
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
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParValue31"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value31.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "IPAddress"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Text6.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "ParSlaveNo"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.OIndex.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "UpdateTime"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value32.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "WatchDogFactor"},
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value33.Name }

            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldType.Name, Value = ImpExpRuleName },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldDescription.Name, Value = "WatchDogTime" },
                new Gcpro.DbParameter{ Name = GcproTable.ImpExpDef.FieldFieldName.Name, Value = GcproTable.ObjData.Value34.Name }

            });
            #endregion
            bool result = insertMultipleRecords(tableName, impExpList);
            impExpList.Clear();
            return result;
        }
    }
}
