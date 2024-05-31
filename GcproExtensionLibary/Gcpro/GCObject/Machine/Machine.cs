using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract  class Machine : GcObject

    {
        public abstract string PType { get; set; }
        public abstract string Value9 { get; set; }
        public abstract string Value10 { get; set; }
        public Machine()
        { 
        }

    }
}
