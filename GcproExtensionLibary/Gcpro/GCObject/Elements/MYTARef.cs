
namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class MYTARef
    {
        private string myta;
        private int passageNo;
        public string MYTA
        {
            get { return myta; }
            set { myta = value; }
        }
        public int PassageNo
        {
            get { return passageNo; }
            set { passageNo = value; }
        }
        public MYTARef(string myta, int passageNo)
        {
            this.myta = myta;
            this.passageNo = passageNo;
        }

    }
}
