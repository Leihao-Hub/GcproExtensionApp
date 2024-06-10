namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public abstract class MotorWithBypass : Machine
    {
        private string filePath;
        public override string PType { get; set; }
        public override string Value9 { get; set; }
        public override string Value10 { get; set; }
      //  public override OTypeCollection OType { get; set; }
        public override string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }

        }
        public MotorWithBypass()
        {
            SetOTypeProperty(OTypeCollection.MA_MotorWithBypass);
           // OType = OTypeCollection.MA_MotorWithBypass;
        }
    }
}
