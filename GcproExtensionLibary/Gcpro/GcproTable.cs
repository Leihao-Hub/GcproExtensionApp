using System;

namespace GcproExtensionLibrary.Gcpro
{
    public class DbParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
    public static class GcproTable
    {
        public static class ObjData
        {
            #region Private fields for properties 
            private readonly static DbParameter key;
            private readonly static DbParameter idold;
            private readonly static DbParameter idaepro;
            private readonly static DbParameter otype;
            private readonly static DbParameter owner;
            private readonly static DbParameter subtype;
            private readonly static DbParameter oindex;
            private readonly static DbParameter valide;
            private readonly static DbParameter multipleUsed;
            private readonly static DbParameter building;
            private readonly static DbParameter elevation;
            private readonly static DbParameter alarm_area;
            private readonly static DbParameter panel_id;
            private readonly static DbParameter revision;
            private readonly static DbParameter text0;
            private readonly static DbParameter text1;
            private readonly static DbParameter text2;
            private readonly static DbParameter text4;
            private readonly static DbParameter text5;
            private readonly static DbParameter text6;
            private readonly static DbParameter text7;
            private readonly static DbParameter text8;
            private readonly static DbParameter text9;
            private readonly static DbParameter value0;
            private readonly static DbParameter value1;
            private readonly static DbParameter value2;
            private readonly static DbParameter value3;
            private readonly static DbParameter value4;
            private readonly static DbParameter value5;
            private readonly static DbParameter value6;
            private readonly static DbParameter value7;
            private readonly static DbParameter value8;
            private readonly static DbParameter value9;
            private readonly static DbParameter value10;
            private readonly static DbParameter value11;
            private readonly static DbParameter value12;
            private readonly static DbParameter value13;
            private readonly static DbParameter value14;
            private readonly static DbParameter value15;
            private readonly static DbParameter value16;
            private readonly static DbParameter value17;
            private readonly static DbParameter value18;
            private readonly static DbParameter value19;
            private readonly static DbParameter value20;
            private readonly static DbParameter value21;
            private readonly static DbParameter value22;
            private readonly static DbParameter value23;
            private readonly static DbParameter value24;
            private readonly static DbParameter value25;
            private readonly static DbParameter value26;
            private readonly static DbParameter value27;
            private readonly static DbParameter value28;
            private readonly static DbParameter value29;
            private readonly static DbParameter value30;
            private readonly static DbParameter value31;
            private readonly static DbParameter value32;
            private readonly static DbParameter value33;
            private readonly static DbParameter value34;
            private readonly static DbParameter value35;
            private readonly static DbParameter value36;
            private readonly static DbParameter value37;
            private readonly static DbParameter value38;
            private readonly static DbParameter value39;
            private readonly static DbParameter value40;
            private readonly static DbParameter value41;
            private readonly static DbParameter value42;
            private readonly static DbParameter value43;
            private readonly static DbParameter value44;
            private readonly static DbParameter value45;
            private readonly static DbParameter value46;
            private readonly static DbParameter value47;
            private readonly static DbParameter value48;
            private readonly static DbParameter value49;
            private readonly static DbParameter value50;
            private readonly static DbParameter objCnt;
            private readonly static DbParameter nameS7;
            private readonly static DbParameter isNew;
            private readonly static DbParameter dpnode1;
            private readonly static DbParameter dpnode2;
            private readonly static DbParameter processFct;
            private readonly static DbParameter s5Otype;
            private readonly static DbParameter text3;
            private readonly static DbParameter subProject;
            private readonly static DbParameter pageName;
            private readonly static DbParameter diagramNo;
            private readonly static DbParameter aeproNo;
            private readonly static DbParameter masterCopy;
            private readonly static DbParameter masterCopyName;
            private readonly static DbParameter value51;
            private readonly static DbParameter value52;
            private readonly static DbParameter value53;
            private readonly static DbParameter value54;
            private readonly static DbParameter value55;
            private readonly static DbParameter value56;
            private readonly static DbParameter value57;
            private readonly static DbParameter value58;
            private readonly static DbParameter value59;
            private readonly static DbParameter value60;
            private readonly static DbParameter value61;
            private readonly static DbParameter value62;
            private readonly static DbParameter value63;
            private readonly static DbParameter value64;
            private readonly static DbParameter value65;
            private readonly static DbParameter value66;
            private readonly static DbParameter value67;
            private readonly static DbParameter value68;
            private readonly static DbParameter value69;
            private readonly static DbParameter value70;
            private readonly static DbParameter singleInstanceDB;
            private readonly static DbParameter status;
            private readonly static DbParameter memo1;
            private readonly static DbParameter memo2;
            private readonly static DbParameter isVirtual;
            private readonly static DbParameter communication;
            private readonly static DbParameter notUsed;
            private readonly static DbParameter fieldbusNode;
            #endregion
            static ObjData()
            {
                key = new DbParameter { Name = "Key", Value = (long)0 };
                idold = new DbParameter { Name = "IDOld", Value = (double)0.0 };
                idaepro = new DbParameter { Name = "IDAepro", Value = (double)0.0 };
                otype = new DbParameter { Name = "OType", Value = (double)0.0 };
                owner = new DbParameter { Name = "Owner", Value = (long)0 };
                subtype = new DbParameter { Name = "SubType", Value = string.Empty };
                oindex = new DbParameter { Name = "OIndex", Value = (double)0.0 };
                valide = new DbParameter { Name = "Valide", Value = (int)0 };
                multipleUsed = new DbParameter { Name = "MultipleUsed", Value = string.Empty };
                building = new DbParameter { Name = "Building", Value = string.Empty };
                elevation = new DbParameter { Name = "Elevation", Value = string.Empty };
                alarm_area = new DbParameter { Name = "Alarm_Area", Value = (long)0 };
                panel_id = new DbParameter { Name = "Panel_ID", Value = string.Empty };
                revision = new DbParameter { Name = "Revision", Value = (long)0 };
                text0 = new DbParameter { Name = "Text0", Value = string.Empty };
                text1 = new DbParameter { Name = "Text1", Value = string.Empty };
                text2 = new DbParameter { Name = "Text2", Value = string.Empty };
                text4 = new DbParameter { Name = "Text4", Value = string.Empty };
                text5 = new DbParameter { Name = "Text5", Value = string.Empty };
                text6 = new DbParameter { Name = "Text6", Value = string.Empty };
                text7 = new DbParameter { Name = "Text7", Value = string.Empty };
                text8 = new DbParameter { Name = "Text8", Value = string.Empty };
                text9 = new DbParameter { Name = "Text9", Value = string.Empty };
                value0 = new DbParameter { Name = "Value0", Value = (double)0.0 };
                value1 = new DbParameter { Name = "Value1", Value = (double)0.0 };
                value2 = new DbParameter { Name = "Value2", Value = (double)0.0 };
                value3 = new DbParameter { Name = "Value3", Value = (double)0.0 };
                value4 = new DbParameter { Name = "Value4", Value = (double)0.0 };
                value5 = new DbParameter { Name = "Value5", Value = (double)0.0 };
                value6 = new DbParameter { Name = "Value6", Value = (double)0.0 };
                value7 = new DbParameter { Name = "Value7", Value = (double)0.0 };
                value8 = new DbParameter { Name = "Value8", Value = (double)0.0 };
                value9 = new DbParameter { Name = "Value9", Value = (double)0.0 };
                value10 = new DbParameter { Name = "Value10", Value = (double)0.0 };
                value11 = new DbParameter { Name = "Value11", Value = (double)0.0 };
                value12 = new DbParameter { Name = "Value12", Value = (double)0.0 };
                value13 = new DbParameter { Name = "Value13", Value = (double)0.0 };
                value14 = new DbParameter { Name = "Value14", Value = (double)0.0 };
                value15 = new DbParameter { Name = "Value15", Value = (double)0.0 };
                value16 = new DbParameter { Name = "Value16", Value = (double)0.0 };
                value17 = new DbParameter { Name = "Value17", Value = (double)0.0 };
                value18 = new DbParameter { Name = "Value18", Value = (double)0.0 };
                value19 = new DbParameter { Name = "Value19", Value = (double)0.0 };
                value20 = new DbParameter { Name = "Value20", Value = (double)0.0 };
                value21 = new DbParameter { Name = "Value21", Value = (double)0.0 };
                value22 = new DbParameter { Name = "Value22", Value = (double)0.0 };
                value23 = new DbParameter { Name = "Value23", Value = (double)0.0 };
                value24 = new DbParameter { Name = "Value24", Value = (double)0.0 };
                value25 = new DbParameter { Name = "Value25", Value = (double)0.0 };
                value26 = new DbParameter { Name = "Value26", Value = (double)0.0 };
                value27 = new DbParameter { Name = "Value27", Value = (double)0.0 };
                value28 = new DbParameter { Name = "Value28", Value = (double)0.0 };
                value29 = new DbParameter { Name = "Value29", Value = (double)0.0 };
                value30 = new DbParameter { Name = "Value30", Value = (double)0.0 };
                value31 = new DbParameter { Name = "Value31", Value = (double)0.0 };
                value32 = new DbParameter { Name = "Value32", Value = (double)0.0 };
                value33 = new DbParameter { Name = "Value33", Value = (double)0.0 };
                value34 = new DbParameter { Name = "Value34", Value = (double)0.0 };
                value35 = new DbParameter { Name = "Value35", Value = (double)0.0 };
                value36 = new DbParameter { Name = "Value36", Value = (double)0.0 };
                value37 = new DbParameter { Name = "Value37", Value = (double)0.0 };
                value38 = new DbParameter { Name = "Value38", Value = (double)0.0 };
                value39 = new DbParameter { Name = "Value39", Value = (double)0.0 };
                value40 = new DbParameter { Name = "Value40", Value = (double)0.0 };
                value41 = new DbParameter { Name = "Value41", Value = (double)0.0 };
                value42 = new DbParameter { Name = "Value42", Value = (double)0.0 };
                value43 = new DbParameter { Name = "Value43", Value = (double)0.0 };
                value44 = new DbParameter { Name = "Value44", Value = (double)0.0 };
                value45 = new DbParameter { Name = "Value45", Value = (double)0.0 };
                value46 = new DbParameter { Name = "Value46", Value = (double)0.0 };
                value47 = new DbParameter { Name = "Value47", Value = (double)0.0 };
                value48 = new DbParameter { Name = "Value48", Value = (double)0.0 };
                value49 = new DbParameter { Name = "Value49", Value = (double)0.0 };
                value50 = new DbParameter { Name = "Value50", Value = (double)0.0 };
                objCnt = new DbParameter { Name = "ObjCnt", Value = (int)0 };
                nameS7 = new DbParameter { Name = "NameS7", Value = string.Empty };
                isNew = new DbParameter { Name = "IsNew", Value = (bool)false };
                dpnode1 = new DbParameter { Name = "DPNode1", Value = (double)0.0 };
                dpnode2 = new DbParameter { Name = "DPNode2", Value = (double)0.0 };
                processFct = new DbParameter { Name = "ProcessFct", Value = string.Empty };
                s5Otype = new DbParameter { Name = "S5OType", Value = (long)0 };
                text3 = new DbParameter { Name = "Text3", Value = string.Empty };
                subProject = new DbParameter { Name = "SubProject", Value = (long)0 };
                pageName = new DbParameter { Name = "PageName", Value = string.Empty };
                diagramNo = new DbParameter { Name = "DiagramNo", Value = (double)0 };
                aeproNo = new DbParameter { Name = "AEPRONo", Value = (long)0 };
                masterCopy = new DbParameter { Name = "MasterCopy", Value = (bool)false };
                masterCopyName = new DbParameter { Name = "MasterCopyName", Value = string.Empty };
                value51 = new DbParameter { Name = "Value51", Value = (double)0.0 };
                value52 = new DbParameter { Name = "Value52", Value = (double)0.0 };
                value53 = new DbParameter { Name = "Value53", Value = (double)0.0 };
                value54 = new DbParameter { Name = "Value54", Value = (double)0.0 };
                value55 = new DbParameter { Name = "Value55", Value = (double)0.0 };
                value56 = new DbParameter { Name = "Value56", Value = (double)0.0 };
                value57 = new DbParameter { Name = "Value57", Value = (double)0.0 };
                value58 = new DbParameter { Name = "Value58", Value = (double)0.0 };
                value59 = new DbParameter { Name = "Value59", Value = (double)0.0 };
                value60 = new DbParameter { Name = "Value60", Value = (double)0.0 };
                value61 = new DbParameter { Name = "Value61", Value = (double)0.0 };
                value62 = new DbParameter { Name = "Value62", Value = (double)0.0 };
                value63 = new DbParameter { Name = "Value63", Value = (double)0.0 };
                value64 = new DbParameter { Name = "Value64", Value = (double)0.0 };
                value65 = new DbParameter { Name = "Value65", Value = (double)0.0 };
                value66 = new DbParameter { Name = "Value66", Value = (double)0.0 };
                value67 = new DbParameter { Name = "Value67", Value = (double)0.0 };
                value68 = new DbParameter { Name = "Value68", Value = (double)0.0 };
                value69 = new DbParameter { Name = "Value69", Value = (double)0.0 };
                value70 = new DbParameter { Name = "Value70", Value = (double)0.0 };
                singleInstanceDB = new DbParameter { Name = "SingleInstanceDB", Value = (bool)false };
                status = new DbParameter { Name = "Status", Value = (int)0 };
                memo1 = new DbParameter { Name = "Memo1", Value = string.Empty };
                memo2 = new DbParameter { Name = "Memo2", Value = string.Empty };
                isVirtual = new DbParameter { Name = "IsVirtual", Value = (bool) false};
                communication = new DbParameter { Name = "Communication", Value = (long)0 };
                notUsed = new DbParameter { Name = "NotUsed", Value = (bool) false };
                fieldbusNode = new DbParameter { Name = "FieldbusNode", Value = (long)0 };
            }
            #region Public  properties
            public static string TableName { get; } = "ObjData";
            public static DbParameter Key
            {
                get { return key; }
                set { key.Value = value.Value; }
            }
            public static DbParameter IDOld
            {
                get { return idold; }
                set { idold.Value = value.Value; }
            }
            public static DbParameter IDAepro
            {
                get { return idaepro; }
                set { idaepro.Value = value.Value; }
            }
            public static DbParameter OType
            {
                get { return otype; }
                set { otype.Value = value.Value; }
            }
            public static DbParameter Owner
            {
                get { return owner; }
                set { owner.Value = value.Value; }
            }
            public static DbParameter SubType
            {
                get { return subtype; }
                set { subtype.Value = value.Value; }
            }

            public static DbParameter OIndex
            {
                get { return oindex; }
                set { oindex.Value = value.Value; }
            }
            public static DbParameter Valide
            {
                get { return valide; }
                set { valide.Value = value.Value; }
            }
            public static DbParameter MultipleUsed
            {
                get { return multipleUsed; }
                set { multipleUsed.Value = value.Value; }
            }
            public static DbParameter Building
            {
                get { return building; }
                set { building.Value = value.Value; }
            }
            public static DbParameter Elevation
            {
                get { return elevation; }
                set { elevation.Value = value.Value; }
            }
            public static DbParameter Alarm_Area
            {
                get { return alarm_area; }
                set { alarm_area.Value = value.Value; }
            }
            public static DbParameter Panel_ID
            {
                get { return panel_id; }
                set { panel_id.Value = value.Value; }
            }
            public static DbParameter Revision
            {
                get { return revision; }
                set { revision.Value = value.Value; }
            }
            public static DbParameter Text0
            {
                get { return text0; }
                set { text0.Value = value.Value; }
            }
            public static DbParameter Text1
            {
                get { return text1; }
                set { text1.Value = value.Value; }
            }
            public static DbParameter Text2
            {
                get { return text2; }
                set { text2.Value = value.Value; }
            }
            public static DbParameter Text4
            {
                get { return text4; }
                set { text4.Value = value.Value; }
            }
            public static DbParameter Text5
            {
                get { return text5; }
                set { text5.Value = value.Value; }
            }
            public static DbParameter Text6
            {
                get { return text6; }
                set { text6.Value = value.Value; }
            }
            public static DbParameter Text7
            {
                get { return text7; }
                set { text7.Value = value.Value; }
            }
            public static DbParameter Text8
            {
                get { return text8; }
                set { text8.Value = value.Value; }
            }
            public static DbParameter Text9
            {
                get { return text9; }
                set { text9.Value = value.Value; }
            }
            public static DbParameter Value0
            {
                get { return value0; }
                set { value0.Value = value.Value; }
            }
            public static DbParameter Value1
            {
                get { return value1; }
                set { value1.Value = value.Value; }
            }
            public static DbParameter Value2
            {
                get { return value2; }
                set { value2.Value = value.Value; }
            }
            public static DbParameter Value3
            {
                get { return value3; }
                set { value3.Value = value.Value; }
            }
            public static DbParameter Value4
            {
                get { return value4; }
                set { value4.Value = value.Value; }
            }
            public static DbParameter Value5
            {
                get { return value5; }
                set { value5.Value = value.Value; }
            }
            public static DbParameter Value6
            {
                get { return value6; }
                set { value6.Value = value.Value; }
            }
            public static DbParameter Value7
            {
                get { return value7; }
                set { value7.Value = value.Value; }
            }
            public static DbParameter Value8
            {
                get { return value8; }
                set { value8.Value = value.Value; }
            }
            public static DbParameter Value9
            {
                get { return value9; }
                set { value9.Value = value.Value; }
            }
            public static DbParameter Value10
            {
                get { return value10; }
                set { value10.Value = value.Value; }
            }
            public static DbParameter Value11
            {
                get { return value11; }
                set { value11.Value = value.Value; }
            }
            public static DbParameter Value12
            {
                get { return value12; }
                set { value12.Value = value.Value; }
            }
            public static DbParameter Value13
            {
                get { return value13; }
                set { value13.Value = value.Value; }
            }
            public static DbParameter Value14
            {
                get { return value14; }
                set { value14.Value = value.Value; }
            }
            public static DbParameter Value15
            {
                get { return value15; }
                set { value15.Value = value.Value; }
            }
            public static DbParameter Value16
            {
                get { return value16; }
                set { value16.Value = value.Value; }
            }
            public static DbParameter Value17
            {
                get { return value17; }
                set { value17.Value = value.Value; }
            }
            public static DbParameter Value18
            {
                get { return value18; }
                set { value18.Value = value.Value; }
            }
            public static DbParameter Value19
            {
                get { return value19; }
                set { value19.Value = value.Value; }
            }
            public static DbParameter Value20
            {
                get { return value20; }
                set { value20.Value = value.Value; }
            }
            public static DbParameter Value21
            {
                get { return value21; }
                set { value21.Value = value.Value; }
            }
            public static DbParameter Value22
            {
                get { return value22; }
                set { value22.Value = value.Value; }
            }
            public static DbParameter Value23
            {
                get { return value23; }
                set { value23.Value = value.Value; }
            }
            public static DbParameter Value24
            {
                get { return value24; }
                set { value24.Value = value.Value; }
            }
            public static DbParameter Value25
            {
                get { return value25; }
                set { value25.Value = value.Value; }
            }
            public static DbParameter Value26
            {
                get { return value26; }
                set { value26.Value = value.Value; }
            }
            public static DbParameter Value27
            {
                get { return value27; }
                set { value27.Value = value.Value; }
            }
            public static DbParameter Value28
            {
                get { return value28; }
                set { value28.Value = value.Value; }
            }
            public static DbParameter Value29
            {
                get { return value29; }
                set { value29.Value = value.Value; }
            }
            public static DbParameter Value30
            {
                get { return value30; }
                set { value30.Value = value.Value; }
            }
            public static DbParameter Value31
            {
                get { return value31; }
                set { value31.Value = value.Value; }
            }
            public static DbParameter Value32
            {
                get { return value32; }
                set { value32.Value = value.Value; }
            }
            public static DbParameter Value33
            {
                get { return value33; }
                set { value33.Value = value.Value; }
            }
            public static DbParameter Value34
            {
                get { return value34; }
                set { value34.Value = value.Value; }
            }
            public static DbParameter Value35
            {
                get { return value35; }
                set { value35.Value = value.Value; }
            }
            public static DbParameter Value36
            {
                get { return value36; }
                set { value36.Value = value.Value; }
            }
            public static DbParameter Value37
            {
                get { return value37; }
                set { value37.Value = value.Value; }
            }
            public static DbParameter Value38
            {
                get { return value38; }
                set { value38.Value = value.Value; }
            }
            public static DbParameter Value39
            {
                get { return value39; }
                set { value39.Value = value.Value; }
            }
            public static DbParameter Value40
            {
                get { return value40; }
                set { value40.Value = value.Value; }
            }
            public static DbParameter Value41
            {
                get { return value41; }
                set { value41.Value = value.Value; }
            }
            public static DbParameter Value42
            {
                get { return value42; }
                set { value42.Value = value.Value; }
            }
            public static DbParameter Value43
            {
                get { return value43; }
                set { value43.Value = value.Value; }
            }
            public static DbParameter Value44
            {
                get { return value44; }
                set { value44.Value = value.Value; }
            }
            public static DbParameter Value45
            {
                get { return value45; }
                set { value45.Value = value.Value; }
            }
            public static DbParameter Value46
            {
                get { return value46; }
                set { value46.Value = value.Value; }
            }
            public static DbParameter Value47
            {
                get { return value47; }
                set { value47.Value = value.Value; }
            }
            public static DbParameter Value48
            {
                get { return value48; }
                set { value48.Value = value.Value; }
            }
            public static DbParameter Value49
            {
                get { return value49; }
                set { value49.Value = value.Value; }
            }
            public static DbParameter Value50
            {
                get { return value50; }
                set { value50.Value = value.Value; }
            }
            public static DbParameter ObjCnt
            {
                get { return objCnt; }
                set { objCnt.Value = value.Value; }
            }
            public static DbParameter NameS7
            {
                get { return nameS7; }
                set { nameS7.Value = value.Value; }
            }
            public static DbParameter IsNew
            {
                get { return isNew; }
                set { isNew.Value = value.Value; }
            }
            public static DbParameter DPNode1
            {
                get { return dpnode1; }
                set { dpnode1.Value = value.Value; }
            }
            public static DbParameter DPNode2
            {
                get { return dpnode2; }
                set { dpnode2.Value = value.Value; }
            }
            public static DbParameter ProcessFct
            {
                get { return processFct; }
                set { processFct.Value = value.Value; }
            }
            public static DbParameter S5OType
            {
                get { return s5Otype; }
                set { s5Otype.Value = value.Value; }
            }
            public static DbParameter Text3
            {
                get { return text3; }
                set { text3.Value = value.Value; }
            }
            public static DbParameter SubProject
            {
                get { return subProject; }
                set { subProject.Value = value.Value; }
            }
            public static DbParameter PageName
            {
                get { return pageName; }
                set { pageName.Value = value.Value; }
            }
            public static DbParameter DiagramNo
            {
                get { return diagramNo; }
                set { diagramNo.Value = value.Value; }
            }
            public static DbParameter AEPRONo
            {
                get { return aeproNo; }
                set { aeproNo.Value = value.Value; }
            }
            public static DbParameter MasterCopy
            {
                get { return masterCopy; }
                set { masterCopy.Value = value.Value; }
            }
            public static DbParameter MasterCopyName
            {
                get { return masterCopyName; }
                set { masterCopyName.Value = value.Value; }
            }
            public static DbParameter Value51
            {
                get { return value51; }
                set { value51.Value = value.Value; }
            }
            public static DbParameter Value52
            {
                get { return value52; }
                set { value52.Value = value.Value; }
            }
            public static DbParameter Value53
            {
                get { return value53; }
                set { value53.Value = value.Value; }
            }
            public static DbParameter Value54
            {
                get { return value54; }
                set { value54.Value = value.Value; }
            }
            public static DbParameter Value55
            {
                get { return value55; }
                set { value55.Value = value.Value; }
            }
            public static DbParameter Value56
            {
                get { return value56; }
                set { value56.Value = value.Value; }
            }
            public static DbParameter Value57
            {
                get { return value57; }
                set { value57.Value = value.Value; }
            }
            public static DbParameter Value58
            {
                get { return value58; }
                set { value58.Value = value.Value; }
            }
            public static DbParameter Value59
            {
                get { return value59; }
                set { value59.Value = value.Value; }
            }
            public static DbParameter Value60
            {
                get { return value60; }
                set { value60.Value = value.Value; }
            }
            public static DbParameter Value61
            {
                get { return value61; }
                set { value61.Value = value.Value; }
            }
            public static DbParameter Value62
            {
                get { return value62; }
                set { value62.Value = value.Value; }
            }
            public static DbParameter Value63
            {
                get { return value63; }
                set { value63.Value = value.Value; }
            }
            public static DbParameter Value64
            {
                get { return value64; }
                set { value64.Value = value.Value; }
            }
            public static DbParameter Value65
            {
                get { return value65; }
                set { value65.Value = value.Value; }
            }
            public static DbParameter Value66
            {
                get { return value66; }
                set { value66.Value = value.Value; }
            }
            public static DbParameter Value67
            {
                get { return value67; }
                set { value67.Value = value.Value; }
            }
            public static DbParameter Value68
            {
                get { return value68; }
                set { value68.Value = value.Value; }
            }
            public static DbParameter Value69
            {
                get { return value69; }
                set { value69.Value = value.Value; }
            }
            public static DbParameter Value70
            {
                get { return value70; }
                set { value70.Value = value.Value; }
            }
            public static DbParameter SingleInstanceDB
            {
                get { return singleInstanceDB; }
                set { singleInstanceDB.Value = value.Value; }
            }
            public static DbParameter Status
            {
                get { return status; }
                set { status.Value = value.Value; }
            }
            public static DbParameter Memo1
            {
                get { return memo1; }
                set { memo1.Value = value.Value; }
            }
            public static DbParameter Memo2
            {
                get { return memo2; }
                set { memo2.Value = value.Value; }
            }
            public static DbParameter IsVirtual
            {
                get { return isVirtual; }
                set { isVirtual.Value = value.Value; }
            }
            public static DbParameter Communication
            {
                get { return communication; }
                set { communication.Value = value.Value; }
            }
            public static DbParameter NotUsed
            {
                get { return notUsed; }
                set { notUsed.Value = value.Value; }
            }
            public static DbParameter FieldbusNode
            {
                get { return fieldbusNode; }
                set { fieldbusNode.Value = value.Value; }
            }
            #endregion
            public static Type GetPropertyValueType(string propertyName)
            {
      
                //var prop = typeof(ObjData).GetProperty(propertyName);

                //if (prop == null) throw new ArgumentException($@"属性：{propertyName}在{typeof(ObjData)}不存在");

                var prop = typeof(ObjData).GetProperty(propertyName)
                            ?? throw new ArgumentException($"属性：{propertyName}在{typeof(ObjData)}不存在");

                var dbParameter = prop.GetValue(null) as DbParameter;
                if (dbParameter != null && dbParameter.Value != null)
                {
                    return dbParameter.Value.GetType();
                }

                //if (prop.GetValue(null) is DbParameter dbParameter && dbParameter.Value is not null)
                //{
                //    return dbParameter.Value.GetType();
                //}

                return typeof(object); 
            }
        }
        public static class ImpExpDef
        {
            #region Private fields for properties 
            private readonly static DbParameter id;
            private readonly static DbParameter type;
            private readonly static DbParameter description;
            private readonly static DbParameter fieldName;
            private readonly static DbParameter level;
            private readonly static DbParameter width;
            private readonly static DbParameter position;
            #endregion
            static ImpExpDef()
            {
                id = new DbParameter { Name = "ID", Value = (double)0.0 };
                type = new DbParameter { Name = "Type", Value = string.Empty };
                description = new DbParameter { Name = "Description", Value = string.Empty };
                fieldName = new DbParameter { Name = "FieldName", Value = string.Empty };
                level = new DbParameter { Name = "Level", Value = string.Empty };
                width = new DbParameter { Name = "Width", Value = (int)0 };
                position = new DbParameter { Name = "Position", Value = (int)0 };
            }
            #region Public properties
            public static string TableName { get; } = "ImpExpDef";
            public static DbParameter FieldID
            {
                get { return id; }

                set { id.Value = value.Value; }

            }
            public static DbParameter FieldType
            {
                get { return type; }

                set { type.Value = value.Value; }

            }
            public static DbParameter FieldDescription
            {
                get { return description; }

                set { description.Value = value.Value; }

            }
            public static DbParameter FieldFieldName
            {
                get { return fieldName; }

                set { fieldName.Value = value.Value; }

            }

            public static DbParameter FieldLevel
            {
                get { return level; }

                set { level.Value = value.Value; }

            }
            public static DbParameter FieldWidth
            {
                get { return width; }

                set { width.Value = value.Value; }

            }
            public static DbParameter FieldPosition
            {
                get { return position; }

                set { position.Value = value.Value; }

            }
            #endregion
        }
        public static class SubType
        {
            #region Private fields for properties 
            private readonly static DbParameter otype;
            private readonly static DbParameter subType;
            private readonly static DbParameter revision;
            private readonly static DbParameter sub_type_desc;
            private readonly static DbParameter asw;
            private readonly static DbParameter instancefb;
            private readonly static DbParameter favorit;
            #endregion
            static SubType()
            {
                otype = new DbParameter { Name = "OType", Value = (int)0 };
                subType = new DbParameter { Name = "SubType", Value = string.Empty };
                revision = new DbParameter { Name = "Revision", Value = (int)0 };
                sub_type_desc = new DbParameter { Name = "Sub_Type_Desc", Value = string.Empty };
                asw = new DbParameter { Name = "ASW", Value = "No" };
                instancefb = new DbParameter { Name = "InstanceFB", Value = string.Empty };
                favorit = new DbParameter { Name = "Favorit", Value = "No" };
            }
            #region Public properties
            public static string TableName { get; } = "SubType";
            public static DbParameter FieldOType
            {
                get { return otype; }

                set { otype.Value = value.Value; }

            }
            public static DbParameter FieldSubType
            {
                get { return subType; }

                set { subType.Value = value.Value; }

            }
            public static DbParameter FieldRevision
            {
                get { return revision; }

                set { revision.Value = value.Value; }

            }
            public static DbParameter FieldSub_Type_Desc
            {
                get { return sub_type_desc; }

                set { sub_type_desc.Value = value.Value; }

            }

            public static DbParameter FieldASW
            {
                get { return asw; }

                set { asw.Value = value.Value; }

            }
            public static DbParameter FieldInstanceFB
            {
                get { return instancefb; }

                set { instancefb.Value = value.Value; }

            }
            public static DbParameter FieldFavorit
            {
                get { return favorit; }

                set { favorit.Value = value.Value; }

            }
            #endregion
        }
        public static class TranslationCbo
        {
            #region Private fields for properties 
            private readonly static DbParameter fieldClass;
            private readonly static DbParameter fieldValue;
            private readonly static DbParameter text;
            private readonly static DbParameter description;
            #endregion
            static TranslationCbo()
            {
                fieldClass = new DbParameter { Name = "Class", Value = string.Empty };
                fieldValue = new DbParameter { Name = "Value", Value = (double)0.0 };
                text = new DbParameter { Name = "Text", Value = string.Empty };
                description = new DbParameter { Name = "Description", Value = string.Empty };
            }
            #region Public properties
            #region Readonly properties
            public static string Class_UnitCfg { get; } = "UnitCfg";
            public static string Class_STATUS { get; } = "STATUS";
            public static string Class_PanelID { get; } = "PanelID";
            public static string Class_ASICHANNEL { get; } = "ASICHANNEL";
            public static string Class_ASWMsgType { get; } = "ASWMsgType";
            public static string Class_BinType { get; } = "BINTYPE";
            public static string Class_Language { get; } = "Language";
            public static string Class_Building { get; } = "Building";
            public static string Class_Elevation { get; } = "Elevation";
            public static string Class_FastCall { get; } = "FASTCALL";
            public static string Class_MEAGPIN { get; } = "MEAGPIN";
            public static string Class_WincosVersion { get; } = "WincosVersion";
            public static string Class_ASWIdxCLine { get; } = "ASWIdxCLine";
            public static string Class_ASWInDPFault { get; } = "ASWInDPFault";
            public static string Class_ASWParHornCode { get; } = "ASWParHornCode";
            public static string Class_ASWStartwarningArea { get; } = "ASWStartwarningArea";
            public static string Class_ASWDiagram { get; } = "ASWDiagram";
            #endregion
            public static string TableName { get; } = "TranslationCbo";
            public static DbParameter FieldClass
            {
                get { return fieldClass; }

                set { fieldClass.Value = value.Value; }

            }
            public static DbParameter FieldValue
            {
                get { return fieldValue; }

                set { fieldValue.Value = value.Value; }

            }
            public static DbParameter FieldText
            {
                get { return text; }

                set { text.Value = value.Value; }

            }
            public static DbParameter FieldDescription
            {
                get { return description; }

                set { description.Value = value.Value; }

            }
            #endregion
        }
        public static class ProcessFct
        {
            #region Private fields for properties 
            private readonly static DbParameter id;
            private readonly static DbParameter oType;
            private readonly static DbParameter processFct;
            private readonly static DbParameter fct_desc;
            private readonly static DbParameter projectType;
            private readonly static DbParameter asw;
            private readonly static DbParameter subForm;
            #endregion
            static ProcessFct()
            {
                id = new DbParameter { Name = "ID", Value = (int)0 };
                oType = new DbParameter { Name = "OType", Value = (int)0 };
                projectType = new DbParameter { Name = "ProjectType ", Value = string.Empty };
                processFct = new DbParameter { Name = "ProcessFct", Value = string.Empty };
                fct_desc = new DbParameter { Name = "Fct_Desc", Value = string.Empty };
                asw = new DbParameter { Name = "ASW", Value = string.Empty };
                subForm = new DbParameter { Name = "SubForm", Value = string.Empty };
            }
            #region Public properties
            public static string TableName { get; } = "ProcessFct";
            public static DbParameter FieldID
            {
                get { return id; }

                set { id.Value = value.Value; }

            }
            public static DbParameter FieldOType
            {
                get { return oType; }

                set { oType.Value = value.Value; }

            }
            public static DbParameter FieldProcessFct
            {
                get { return processFct; }

                set { processFct.Value = value.Value; }

            }
            public static DbParameter FieldFct_Desc
            {
                get { return fct_desc; }

                set { fct_desc.Value = value.Value; }

            }
            public static DbParameter FieldProjectType
            {
                get { return projectType; }

                set { projectType.Value = value.Value; }

            }
            public static DbParameter FieldASW
            {
                get { return asw; }

                set { asw.Value = value.Value; }

            }
            public static DbParameter FieldSubForm
            {
                get { return subForm; }

                set { subForm.Value = value.Value; }

            }
            #endregion
        }
    }
}