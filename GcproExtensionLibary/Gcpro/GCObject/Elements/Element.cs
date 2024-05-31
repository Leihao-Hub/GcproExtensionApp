using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class Element:GcObject
    {
        public abstract string PType{ get; set; }   
        public abstract string HornCode { get; set; }
        public abstract string Value9 { get; set; }
        public abstract string Value10 { get; set; }
        public abstract string DPNode1 { get; set; }
        public Element()
        {

        }
    }
}
