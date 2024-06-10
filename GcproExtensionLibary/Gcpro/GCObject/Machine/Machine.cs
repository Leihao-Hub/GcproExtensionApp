namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class Machine : GcObject

    {
        public abstract string PType { get; set; }
        public abstract string Value9 { get; set; }
        public abstract string Value10 { get; set; }
        public Machine()
        {
        }

    }
}
