
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class Project : GcObject

    {
        private string isNew;
        private string name;
        private string description;
        private string subType;
        private string processFct;
        private string building;
        private string elevation;
        private double fieldBusNode;
        private string panel_ID;
        private double diagram;
        private string page;
        public Project()
        {
            SetOTypeProperty(OTypeCollection.Project);
        }
        #region Standard propertys
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
        public override double FieldBusNode
        {
            get { return fieldBusNode; }
            set { fieldBusNode = value; }
        }
        public override string Panel_ID
        {
            get { return panel_ID; }
            set { panel_ID = value; }
        }
        public override double Diagram
        {
            get { return diagram; }
            set { diagram = value; }
        }
        public override string Page
        {
            get { return page; }
            set { page = value; }
        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
        public override string FilePath { get; set; }
        #endregion
        #region Readonly subtype propertys
        public static string PROBSAO { get; } = "PROBSAO";
        public static string PROEP { get; } = "PROEP";
        public static string PROGP { get; } = "PROGP";
        public static string PROGPFU { get; } = "PROGPFU";
        public static string PROSSW { get; } = "PROSSW";
        #endregion
        public static int OTypeValue { get; } = (int)(OTypeCollection.Project);
    }
}
