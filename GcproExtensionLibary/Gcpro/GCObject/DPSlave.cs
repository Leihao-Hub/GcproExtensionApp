using GcproExtensionLibrary.Gcpro.GCObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GcproExtensionLibrary.Gcpro.GcproTable;
using System.Xml.Linq;
using GcproExtensionLibrary.Gcpro;

namespace GcproExtensionLibary.Gcpro.GCObject
{
    public class DPSlave : GcObject

    {
        private string name;
        private string description;
        private string subType;
        private string processFct;
        private string building;
        private string elevation;
        private string fieldBusNode;
        private string panel_ID;
        private string diagram;
        private string isNew;
        private string page;
        private string filePath;

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
        public override string FieldBusNode
        {
            get { return fieldBusNode; }
            set { fieldBusNode = value; }
        }
        public override string Panel_ID
        {
            get { return panel_ID; }
            set { panel_ID = value; }
        }
        public override string Diagram
        {
            get { return diagram; }
            set { diagram = value; }
        }
        public override string Page
        {
            get { return page; }
            set { page = value; }
        }
        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
        public static int OTypeValue { get; } = (int)OTypeCollection.DP_Slave;
    }
}
