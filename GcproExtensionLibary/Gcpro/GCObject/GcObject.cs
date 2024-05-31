using System;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class GcObject
    {
        public abstract OTypeCollection OType { get; set; }
        public abstract CommonObjectFields ComObjectFields { get; set; }
        public abstract string IsNew { get; set; }
        public abstract string FilePath { get; set; }

    }
}
