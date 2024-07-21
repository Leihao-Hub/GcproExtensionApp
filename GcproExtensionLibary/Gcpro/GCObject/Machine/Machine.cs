using System.Text;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class Machine : GcObject

    {
        public abstract string PType { get; set; }
        public abstract string Value10 { get; set; }
        public Machine()
        {
        }
        public new string CreateObjectStandardPart(Encoding encoding)
        {
            StringBuilder objFields = new StringBuilder();
            ///<summary>
            ///生产Standard字符串部分
            ///</summary> 
            string baseObject = base.CreateObjectStandardPart(encoding);
            objFields.Append(baseObject).Append(LibGlobalSource.TAB)
              .Append(PType).Append(LibGlobalSource.TAB)
              .Append(Value10);
            return objFields.ToString();
        }
    }
}
