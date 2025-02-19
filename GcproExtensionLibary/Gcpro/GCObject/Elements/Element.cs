using System;
using System.Collections.Generic;
using System.Text;
using static GcproExtensionLibrary.Gcpro.GcproTable;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class Element : GcObject
    {
        public abstract double PType { get; set; }
        public abstract double HornCode { get; set; }
        //   public abstract string Value9 { get; set; }
        public abstract double Value10 { get; set; }
        public abstract double DPNode1 { get; set; }
        public Element()
        {

        }
        public new string CreateObjectStandardPart()
        {
            StringBuilder objFields = new StringBuilder();
            ///<summary>
            ///生产Standard字符串部分
            ///</summary> 
            string baseObject = base.CreateObjectStandardPart();
            objFields.Append(baseObject).Append(LibGlobalSource.TAB)
              .Append(Math.Round(PType,1)).Append(LibGlobalSource.TAB)
              .Append(HornCode).Append(LibGlobalSource.TAB)
              .Append(DPNode1).Append(LibGlobalSource.TAB)
              .Append(Value10);
            return objFields.ToString();
        }
        //protected double ParseHornCode(string hornCodeAndDesc)
        //{
        //    return double.TryParse(hornCodeAndDesc.Substring(0, 2),out double tempDouble)? tempDouble : LibGlobalSource.GROUP_HORNCODE;
        //}
        protected new void CreateImpExpDef(List<List<Gcpro.DbParameter>> impExpList, string impExpRuleName)
        {
            base.CreateImpExpDef(impExpList, impExpRuleName);
            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "MsgType" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.Value5.Name}
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "HornCode" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.Value2.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "DPNode1" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value =  ObjData.DPNode1.Name }
            });

            impExpList.Add(new List<Gcpro.DbParameter>
            {
                new Gcpro.DbParameter { Name = ImpExpDef.FieldType.Name, Value = impExpRuleName },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "ParValue10" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.Value10.Name }
            });
        }
    }
}
