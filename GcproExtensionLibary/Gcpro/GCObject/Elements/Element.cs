namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class Element : GcObject
    {
        public abstract string PType { get; set; }
        public abstract string HornCode { get; set; }
        public abstract string Value9 { get; set; }
        public abstract string Value10 { get; set; }
        public abstract string DPNode1 { get; set; }
        public Element()
        {

        }
    }
}
