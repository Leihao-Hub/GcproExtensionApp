using GcproExtensionLibrary.FileHandle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GcproExtensionLibrary.Gcpro.GCObject.Motor;

namespace GcproExtensionLibrary.Gcpro.GCObject
{
    public class Roll8Stand:Machine
    {
        public struct Roll8StandRule
        {
            public GcBaseRule Common;
        }
        private string filePath;
        private string fileRelationPath;
        private string fileConnectorPath;
        private static string roll8StandFileName = $@"\{OTypeCollection.MA_Roll8Stand}";
        public static Roll8StandRule Rule;
        private string name;
        private string description;
        private string subType;
        private string processFct;
        private string building;
        private string elevation;
        private string fieldBusNode;
        private string panel_ID;
        private string diagram;
        private string page;
        private string pType;
        private string value10;
        private Roll8Stand8Side side1;
        private Roll8Stand8Side side2;
        private string mddx;
        private string isNew;
        #region Standard properties
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
        public override string PType
        {
            get { return pType; }
            set { pType = value; }

        }
        public override string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        #endregion
        #region Application properties

     
        public override string Value10 { get; set; }
        public Roll8Stand8Side Side1
        { 
          get { return side1; }
          set { side1 = value; } 
        }
        public Roll8Stand8Side Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public string MDDx
        {
            get { return mddx; }
            set { mddx = value; }
        }
        public override string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string FileRelationPath
        {
            get { return fileRelationPath; }
        }
        public string FileConnectorPath
        {
            get { return fileConnectorPath; }
        }
        #endregion
        #region Readonly ptype property
        public static string ROLL4 { get; } = "4ROLL";
        public static string ROLL4M { get; } = "4ROLLM";
        public static string ROLL8 { get; } = "8ROLL";
        public static string ROLL8M { get; } = "8ROLLM";
        public static string ROLL8M2M { get; } = "8ROLLM2M";
        public static string P2046 { get; } = "2046";
        public static int OTypeValue { get; } = (int)OTypeCollection.MA_Roll8Stand;
        #endregion
 
        public Roll8Stand()
        {
            side1 = new Roll8Stand8Side();
            side2 = new Roll8Stand8Side();
            pType =P2046;
            SetOTypeProperty(OTypeCollection.MA_Roll8Stand);
            this.filePath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + ".Txt";
            this.fileRelationPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + "_Relation.Txt";
            this.fileConnectorPath = LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + "_FindConnector.Txt";
        }
        public Roll8Stand(string filePath = null) : this()
        {
            this.filePath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + ".Txt" : filePath + roll8StandFileName + ".Txt");
            this.fileRelationPath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + "_Relation.Txt" : filePath + roll8StandFileName + "_Relation.Txt");
            this.fileConnectorPath = (string.IsNullOrWhiteSpace(filePath) ?
                LibGlobalSource.DEFAULT_GCPRO_WORK_TEMP_PATH + roll8StandFileName + "_FindConnector.Txt" : filePath + roll8StandFileName + "_FindConnector.Txt");
        }
        public void CreateObject(Encoding encoding, bool onlyRelation = false)
        {
            if (!onlyRelation)
            {
                TextFileHandle textFileHandle = new TextFileHandle();
                textFileHandle.FilePath = this.filePath;
                isNew = "false";
                StringBuilder objFields = new StringBuilder();
                ///<summary>
                ///生产Standard字符串部分
                ///</summary> 
                objFields.Append(OTypeValue).Append(LibGlobalSource.TAB)
                    .Append(name).Append(LibGlobalSource.TAB)
                    .Append(description).Append(LibGlobalSource.TAB)
                    .Append(subType).Append(LibGlobalSource.TAB)
                    .Append(processFct).Append(LibGlobalSource.TAB)
                    .Append(building).Append(LibGlobalSource.TAB)
                    .Append(elevation).Append(LibGlobalSource.TAB)
                    .Append(fieldBusNode).Append(LibGlobalSource.TAB)
                    .Append(panel_ID).Append(LibGlobalSource.TAB)
                    .Append(diagram).Append(LibGlobalSource.TAB)
                    .Append(page).Append(LibGlobalSource.TAB)
                    .Append(pType).Append(LibGlobalSource.TAB);
                ///<summary>
                ///生成Application 字符串部分
                ///</summary>         
                objFields.Append(value10).Append(LibGlobalSource.TAB)                                
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(LibGlobalSource.NOCHILD).Append(LibGlobalSource.TAB)
                    .Append(isNew);
                textFileHandle.WriteToTextFile(objFields.ToString(), encoding);
                objFields = null;
            }
            //if (subType == M11)
            //{
            //    CreateRelation(name, inpFwd, GcproTable.ObjData.Value11.Name, this.fileRelationPath, encoding);
            //    CreateRelation(name, outpFwd, GcproTable.ObjData.Value12.Name, this.fileRelationPath, encoding);
            //    if (!string.IsNullOrEmpty(inpContactor))
            //    {
            //        CreateRelation(name, inpContactor, GcproTable.ObjData.Value38.Name, this.fileRelationPath, encoding);
            //    }
            //}
            //else if (subType == M12)
            //{
            //    CreateRelation(name, inpFwd, GcproTable.ObjData.Value11.Name, this.fileRelationPath, encoding);
            //    CreateRelation(name, outpFwd, GcproTable.ObjData.Value12.Name, this.fileRelationPath, encoding);
            //    CreateRelation(name, inpRev, GcproTable.ObjData.Value13.Name, this.fileRelationPath, encoding);
            //    CreateRelation(name, outpRev, GcproTable.ObjData.Value14.Name, this.fileRelationPath, encoding);
            //}
            //else if (subType == M1VFC || subType == M2VFC)
            //{
            //    CreateRelation(name, adapter, GcproTable.ObjData.Value34.Name, this.fileRelationPath, encoding);
            //}
        }

        public void Clear()
        {
            TextFileHandle textFileHandle = new TextFileHandle();
            textFileHandle.FilePath = this.filePath;
            textFileHandle.ClearContents();
            textFileHandle.FilePath = this.fileRelationPath;
            textFileHandle.ClearContents();
            textFileHandle.FilePath = this.fileConnectorPath;
            textFileHandle.ClearContents();
        }
        public class Roll8Stand8Side
        {
            private string motorLow;
            private string motorUp;
            private string hlBackupLeft;
            private string hlBackupRight;
            private string hlInlet;
            private string divHLInlet;
            private string sm1;
            private string hlOutlet3;
            private string inpPressure;
            private string feedroll;
            private string divFeedroll;
            private string hlOutlet1;
            private string hlOutlet2;
            private string motorLowCur;
            private string motorUpCur;
            public string MotorLow
            {
                get { return motorLow; }
                set { motorLow = value; }
            }

            public string MotorUp
            {
                get { return motorUp; }
                set { motorUp = value; }
            }

            public string HLBackupLeft
            {
                get { return hlBackupLeft; }
                set { hlBackupLeft = value; }
            }

            public string HLBackupRight
            {
                get { return hlBackupRight; }
                set { hlBackupRight = value; }
            }

            public string HLInlet
            {
                get { return hlInlet; }
                set { hlInlet = value; }
            }

            public string DivHLInlet
            {
                get { return divHLInlet; }
                set { divHLInlet = value; }
            }

            public string SM1
            {
                get { return sm1; }
                set { sm1 = value; }
            }

            public string HLOutlet3
            {
                get { return hlOutlet3; }
                set { hlOutlet3 = value; }
            }

            public string InpPressure
            {
                get { return inpPressure; }
                set { inpPressure = value; }
            }

            public string Feedroll
            {
                get { return feedroll; }
                set { feedroll = value; }
            }

            public string DivFeedroll
            {
                get { return divFeedroll; }
                set { divFeedroll = value; }
            }

            public string HLOutlet1
            {
                get { return hlOutlet1; }
                set { hlOutlet1 = value; }
            }

            public string HLOutlet2
            {
                get { return hlOutlet2; }
                set { hlOutlet2 = value; }
            }

            public string MotorLowCur
            {
                get { return motorLowCur; }
                set { motorLowCur = value; }
            }

            public string MotorUpCur
            {
                get { return motorUpCur; }
                set { motorUpCur = value; }
            }
        }
    }
}