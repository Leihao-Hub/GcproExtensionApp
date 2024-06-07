using System;
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class GcObject
    {
        public abstract OTypeCollection OType { get; set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string SubType { get; set; }
        public abstract string ProcessFct { get; set; }
        public abstract string Building { get; set; }
        public abstract string Elevation { get; set; }
        public abstract string FieldBusNode { get; set; }
        public abstract string Panel_ID { get; set; }
        public abstract string Diagram { get; set; }
        public abstract string Page { get; set; }
        public abstract string IsNew { get; set; }
        public abstract string FilePath { get; set; }

    }
}
