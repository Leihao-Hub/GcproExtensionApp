using System;
using System.Collections.Generic;
using System.Text;
using static GcproExtensionLibrary.Gcpro.GcproTable;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class Machine : GcObject

    {
        public abstract double PType { get; set; }
        public abstract double Value10 { get; set; }

        public Machine()
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
              .Append(Value10);
            return objFields.ToString();
        }
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
                new Gcpro.DbParameter { Name = ImpExpDef.FieldDescription.Name, Value = "ParValue10" },
                new Gcpro.DbParameter { Name = ImpExpDef.FieldFieldName.Name, Value = ObjData.Value10.Name }
            });
        }

    }
}
