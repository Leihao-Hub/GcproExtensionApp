using GcproExtensionLibrary;
using GcproExtensionLibrary.Gcpro;
using OfficeOpenXml.Table.PivotTable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static GcproExtensionLibrary.Gcpro.GcproTable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GcproExtensionApp
{
    public partial class ObjectBrowser : Form
    {
        IDictionary<string, Object> queryParameters = new Dictionary<string, Object>();
        private string oType;
        private string otherAdditionalFiled;
        private string updateFiled;
        private string subType=string.Empty;
        private string subQuery;
        private string returnedItem;
        private static ToolTip toolTip=new ToolTip();

        public string OType
        {
            get {  return oType; }
            set { oType = value; }
        }
        public string SubType
        {
            get { return subType; }
            set { subType = value; }
        }
        public string OtherAdditionalFiled
        {
            get { return otherAdditionalFiled; }
            set { otherAdditionalFiled = value; }
        }
        public string UpdateFiled
        {
            get { return updateFiled; }
            set { updateFiled = value; }
        }
        public string ReturnedItem
        {
            get { return returnedItem; }         
        }
        public ObjectBrowser()
        {
            InitializeComponent();
        }

        private void ObjectBrowser_Load(object sender, System.EventArgs e)
        {

            toolTip.SetToolTip(BtnConfirm, "返回表格中选择项");
            dataGridObjData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn nameField = new DataGridViewTextBoxColumn();
            nameField.HeaderText = "[Text0-名称]";
            nameField.Name = nameof(GcproTable.ObjData.Text0.Name);           
            dataGridObjData.Columns.Add(nameField);
            dataGridObjData.Columns[0].Width = 136;
            dataGridObjData.Columns[0].ReadOnly = true; 

            DataGridViewTextBoxColumn descField = new DataGridViewTextBoxColumn();      
            descField.HeaderText = "[Text1-描述]";
            descField.Name = nameof(GcproTable.ObjData.Text1.Name);
            dataGridObjData.Columns.Add(descField);
            dataGridObjData.Columns[1].Width = 300;
            dataGridObjData.Columns[1].ReadOnly = true;

            DataGridViewTextBoxColumn otherFiled = new DataGridViewTextBoxColumn();
            otherFiled.HeaderText = $"[{OtherAdditionalFiled}]";
            otherFiled.Name = nameof(otherAdditionalFiled);
            dataGridObjData.Columns.Add(otherFiled);

            comboOType.Items.Clear();
            int membersEnum = OTypeCollection.EL_Motor.GetEnumMemberCount();
            string[] enumNames = Enum.GetNames(typeof(OTypeCollection));
            OTypeCollection[] enumeValues = AppGlobal.GetEnumValues<OTypeCollection>();
            for (int i= 0; i < membersEnum; i++)
            {             
                string item;
                item = (int)enumeValues[i] + AppGlobal.FIELDS_SEPARATOR + enumNames[i];
                comboOType.Items.Add(item);
            }
            foreach (var item in comboOType.Items)
            {
                if (item.ToString().StartsWith(OType))
                {
                    comboOType.SelectedItem = item;
                    break;
                }
            }
            comboAdditionalField.Items.Clear();
            List<string> propertyNames=AppGlobal.GetPropertyNames(typeof(GcproTable.ObjData));
            foreach (string item in propertyNames) 
            {
                comboAdditionalField.Items.Add(item);
                comboUpdateField.Items.Add(item);
                comboFilterField1.Items.Add(item);
                comboFilterField2.Items.Add(item);
             
            }
            comboAdditionalField.Items.RemoveAt(0);
            comboFilterField1.Items.RemoveAt(0);
            comboFilterField2.Items.RemoveAt(0);
            comboOperator1.Items.Add("=");
            comboOperator1.Items.Add("<>");
            comboOperator1.Items.Add(">=");
            comboOperator1.Items.Add("<=");
            comboOperator1.Items.Add(">");
            comboOperator1.Items.Add("<");
            comboOperator1.Items.Add("LIKE");
            comboOperator1.SelectedIndex = 6;
            comboOperator2.Items.Add("=");
            comboOperator2.Items.Add("<>");
            comboOperator2.Items.Add(">=");
            comboOperator2.Items.Add("<=");
            comboOperator2.Items.Add(">");
            comboOperator2.Items.Add("<");
            comboOperator2.Items.Add("LIKE");
            comboOperator2.SelectedIndex = 0;
            comboFilterLogic.Items.Add("AND");
            comboFilterLogic.Items.Add("OR");
            comboFilterLogic.SelectedIndex = 0;
            foreach (var item in comboAdditionalField.Items)
            {
                if (item.ToString().StartsWith(OtherAdditionalFiled))
                {
                    comboAdditionalField.SelectedItem = item;
                    break;
                }
            }  
            QueryObj();
        }
        private void comboOType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem;
            selectedItem=comboOType.SelectedItem.ToString();
            oType = selectedItem.Substring(0, selectedItem.IndexOf(AppGlobal.FIELDS_SEPARATOR));
        }
        private void SetFiledValue(Type type, (string Name, string Value) field)
        {

         
        }
        private void SetCmdParameterFiledValue(Type type, (string Name, string Value) field, IDictionary<string, Object> CmdParameter)
        {
            if (type == typeof(string))
            {
                CmdParameter.Add(field.Name, field.Value);
            }
            else if (type == typeof(double))
            {
                CmdParameter.Add(field.Name, Convert.ToDouble(field.Value));
            }
            else if (type == typeof(long))
            {
                CmdParameter.Add(field.Name, Convert.ToInt64(field.Value));
            }
            else if (type == typeof(int))
            {
                CmdParameter.Add(field.Name, Convert.ToInt32(field.Value));
            }
            else if (type == typeof(bool))
            {
                CmdParameter.Add(field.Name, Convert.ToBoolean(field.Value));
            }
        }
        private void SetCmdParameterFiledValue(Type type, (string Name, string Value) field, List<GcproExtensionLibrary.Gcpro.DbParameter> CmdParameter)
        {
            if (type == typeof(string))
            {
                CmdParameter.Add(new GcproExtensionLibrary.Gcpro.DbParameter { Name = field.Name, Value = field.Value });          
            }
            else if (type == typeof(double))
            {
                CmdParameter.Add(new GcproExtensionLibrary.Gcpro.DbParameter { Name = field.Name, Value = Convert.ToDouble(field.Value) });     
            }
            else if (type == typeof(long))
            {
                CmdParameter.Add(new GcproExtensionLibrary.Gcpro.DbParameter { Name = field.Name, Value = Convert.ToInt64(field.Value) });          
            }
            else if (type == typeof(int))
            {
                CmdParameter.Add(new GcproExtensionLibrary.Gcpro.DbParameter { Name = field.Name, Value = Convert.ToInt32(field.Value) });               
            }
            else if (type == typeof(bool))
            {
                CmdParameter.Add(new GcproExtensionLibrary.Gcpro.DbParameter { Name = field.Name, Value = Convert.ToBoolean(field.Value) });
            }
        }
        private void QueryObj()
        {
            queryParameters.Clear(); 
            int _oType = 0;
            if (AppGlobal.ParseInt(oType, out _oType))
            {
                OleDb oledb = new OleDb();
                DataTable dataTable = new DataTable();
                oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
                oledb.IsNewOLEDBDriver = false;
                string subFilter;
                string filter = $"{GcproTable.ObjData.OType.Name} = {OleDb.ParPlaceholder}";
                subFilter = $"{GcproTable.ObjData.OType.Name} = {_oType}";
                queryParameters.Add(GcproTable.ObjData.OType.Name, (double)_oType);
               //参数化查询，涉及文本字段的比较不需要使用单引号；
                if (!string.IsNullOrEmpty(subType))
                {
                    filter = $@"{filter} AND {GcproTable.ObjData.SubType.Name} = {OleDb.ParPlaceholder}";
                    subFilter = $@"{filter} AND {GcproTable.ObjData.SubType.Name} = {subType}";
                    queryParameters.Add(GcproTable.ObjData.SubType.Name, subType);
                }

                if (!string.IsNullOrEmpty(txtFilterName.Text))
                {
                    filter = $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE {OleDb.ParPlaceholder}";
                    subFilter = $@"{filter} AND {GcproTable.ObjData.Text0.Name} LIKE '%{txtFilterName.Text}%'";
                    queryParameters.Add(GcproTable.ObjData.Text0.Name, $"%{txtFilterName.Text}%"); 
                }

                if (!string.IsNullOrEmpty(txtFilterDescription.Text))
                {
                    filter = $@"{filter} AND {GcproTable.ObjData.Text1.Name} LIKE {OleDb.ParPlaceholder}";
                    queryParameters.Add(GcproTable.ObjData.Text1.Name, $"%{txtFilterDescription.Text}%"); 
                }
                filter = string.IsNullOrEmpty(txtUserDefinedFilter.Text) ? filter : $@"{filter} AND {txtUserDefinedFilter.Text}";
                subFilter = string.IsNullOrEmpty(txtUserDefinedFilter.Text) ? subFilter : $@"{subFilter} AND {txtUserDefinedFilter.Text}";
                List<string> fields = new List<string>();
                fields.Add(GcproTable.ObjData.Text0.Name);
                fields.Add(GcproTable.ObjData.Text1.Name);
                bool _hasAddidtionFiled = false;
                if (!String.IsNullOrEmpty(comboAdditionalField.SelectedItem.ToString()))
                {
                    fields.Add(comboAdditionalField.SelectedItem.ToString());
                    _hasAddidtionFiled = true;
                }
                string[] fieldsArray;
                fieldsArray = fields.ToArray();
                try
                {
                    //  string fieldList = string.Join(", ", fieldsArray);
                    // subQuery = $@"SELECT 1 FROM [{GcproTable.ObjData.TableName}] WHERE {filter}";
                    subQuery = $@"SELECT 1 FROM [{GcproTable.ObjData.TableName}] WHERE {subFilter}";
                    dataTable = oledb.QueryDataTable(GcproTable.ObjData.TableName, filter,
                    queryParameters, $"{GcproTable.ObjData.Text0.Name} ASC", fieldsArray);

                    dataGridObjData.DataSource = dataTable;

                    dataGridObjData.Columns[0].DataPropertyName = dataTable.Columns[0].ColumnName;
                    dataGridObjData.Columns[1].DataPropertyName = dataTable.Columns[1].ColumnName;
                    if (_hasAddidtionFiled)
                    {
                        dataGridObjData.Columns[2].DataPropertyName = dataTable.Columns[2].ColumnName;
                    }

                }
                catch
                {
                    MessageBox.Show("查询语法错误", AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dataTable = null;
                    oledb = null;
                    fields.Clear();
                }
            }
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryObj();
        }
        private void txtUserDefinedFilter_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDb oledb = new OleDb();
            DataTable dataTable = new DataTable();
            oledb.DataSource = AppGlobal.GcproDBInfo.ProjectDBPath;
            oledb.IsNewOLEDBDriver = false;
            List<GcproExtensionLibrary.Gcpro.DbParameter> updateFields = new List<GcproExtensionLibrary.Gcpro.DbParameter>();
            //  IDictionary<string, Object> updateparameters = new Dictionary<string, Object>(parameters);
            IDictionary<string, Object> updateparameters = new Dictionary<string, Object>();
            try
            {
                Type objPropertyValueType;         
                if (!string.IsNullOrEmpty(comboUpdateField.Text))
                {
                    objPropertyValueType = GcproTable.ObjData.GetPropertyValueType(comboUpdateField.Text);
                    SetCmdParameterFiledValue(objPropertyValueType, (comboUpdateField.Text, txtFieldNewVale.Text), updateFields);
                //    updateFields.Add(new GcproExtensionLibrary.Gcpro.DbParameter { Name = comboUpdateField.Text, Value = txtFieldNewVale.Text });
                    string whereClause = string.Empty;
                    string filter1, Operator1, filter2, Operator2, filterLogic;
                    string filter1Name, filter2Name;             
                    filter1Name = Convert.ToString(comboFilterField1.SelectedItem);          
                    filter1 = filter1Name;
                    
                    Operator1 = comboOperator1.SelectedItem.ToString();
                    filter2Name = Convert.ToString(comboFilterField2.SelectedItem);
                    filter2 = filter2Name;
                    Operator2 = Convert.ToString(comboOperator2.SelectedItem);
                    filterLogic = Convert.ToString(comboFilterLogic.SelectedItem);

                    if (!string.IsNullOrEmpty(filter1) &&
                        !string.IsNullOrEmpty(Operator1) &&
                        !string.IsNullOrEmpty(txtFilterField1Text.Text))
                    {
                        string filter = $@"{filter1}{" "}{Operator1}";
                        whereClause = $@"{filter}{" "}{OleDb.ParPlaceholder}";
                        objPropertyValueType = GcproTable.ObjData.GetPropertyValueType(filter1Name);
                        SetCmdParameterFiledValue(objPropertyValueType, (filter1Name, txtFilterField1Text.Text), updateparameters);
                      //  string filter = filter1 + " " + Operator1; ;
                       // whereClause = filter1Name.StartsWith("Text") ? filter + $"'{txtFilterField1Text.Text}'" : filter + txtFilterField1Text.Text;
                    }
                    if (!string.IsNullOrEmpty(filter2) &&
                       !string.IsNullOrEmpty(Operator2) &&
                       !string.IsNullOrEmpty(txtFilterField2Text.Text) &&
                       !string.IsNullOrEmpty(filterLogic))
                      
                    {
                        string filter = $@"{filter2}{" "}{Operator2}";
                        whereClause = $@"{whereClause} {filterLogic} {filter}{" "}{OleDb.ParPlaceholder}";
                        objPropertyValueType = GcproTable.ObjData.GetPropertyValueType(filter2Name);
                        SetCmdParameterFiledValue(objPropertyValueType, (filter2Name, txtFilterField2Text.Text), updateparameters);
                        //string filter = filter2 + " " + Operator2;
                        //filter = filter2Name.StartsWith("Text") ? filter + $"'{txtFilterField2Text.Text}'" : filter + txtFilterField2Text.Text;
                        //whereClause = string.IsNullOrEmpty(whereClause) ? filter : $@"{whereClause} {filterLogic} {filter}";
                    }
                    whereClause = string.IsNullOrEmpty(txtUpdateFilter.Text) ? whereClause : $@"{whereClause} {txtUpdateFilter.Text}";
                    string _tableName, _oType, _name;
                    _tableName = GcproTable.ObjData.TableName;
                    _oType = GcproTable.ObjData.OType.Name;
                    _name= GcproTable.ObjData.Text0.Name;
                    // string _subQuery=$@"{subQuery} AND [{_tableName}].{_oType}= MainTable.{_oType} AND [{_tableName}].{_name} = MainTable.{_name} ";
                   // subQuery = "SELECT 1 FROM[ObjData] WHERE OType = 1019";
                    string _subQuery = $@"{subQuery} AND [{_tableName}].{_name} = MainTable.{_name}";
                    //foreach ( var subPar in queryParameters)
                    //{
                    //    if (!updateparameters.ContainsKey(subPar.Key))
                    //    {
                    //        updateparameters[subPar.Key] = subPar.Value;
                    //    }
                    //}

                    oledb.UpdateRecordWithSubQuery(_tableName, updateFields, whereClause, updateparameters, _subQuery);
                }
            }
            catch 
            {
                MessageBox.Show("更新字段出错", AppGlobal.AppInfo.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataTable = null;
                oledb = null;
                updateFields.Clear();
                updateparameters.Clear();   

            }
        }

        private void comboAdditionalField_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridObjData.Columns[2].HeaderText=comboAdditionalField.SelectedItem.ToString();
        }

        public string ReturnSelectItem()
        {
            return dataGridObjData.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            returnedItem= ReturnSelectItem();
            this.Close();
        }

       
    }
}
