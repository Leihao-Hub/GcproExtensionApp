namespace GcproExtensionApp
{
    partial class ObjectBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectBrowser));
            this.LblFilterDescription = new System.Windows.Forms.Label();
            this.txtFilterDescription = new System.Windows.Forms.TextBox();
            this.LblOType = new System.Windows.Forms.Label();
            this.dataGridObjData = new System.Windows.Forms.DataGridView();
            this.lblOtherFilter = new System.Windows.Forms.Label();
            this.comboAdditionalField = new System.Windows.Forms.ComboBox();
            this.comboOType = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblUserDefinedFilter = new System.Windows.Forms.Label();
            this.txtUserDefinedFilter = new System.Windows.Forms.TextBox();
            this.grpDataQuery = new System.Windows.Forms.GroupBox();
            this.lblAnd = new System.Windows.Forms.Label();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.lblFilterName = new System.Windows.Forms.Label();
            this.txtUpdateFilter = new System.Windows.Forms.TextBox();
            this.lblUpdateFilter = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtFieldNewVale = new System.Windows.Forms.TextBox();
            this.lblFieldNewVale = new System.Windows.Forms.Label();
            this.lblUpdateField = new System.Windows.Forms.Label();
            this.comboUpdateField = new System.Windows.Forms.ComboBox();
            this.lblFilterField1 = new System.Windows.Forms.Label();
            this.comboFilterField1 = new System.Windows.Forms.ComboBox();
            this.comboOperator1 = new System.Windows.Forms.ComboBox();
            this.txtFilterField1Text = new System.Windows.Forms.TextBox();
            this.txtFilterField2Text = new System.Windows.Forms.TextBox();
            this.comboOperator2 = new System.Windows.Forms.ComboBox();
            this.comboFilterField2 = new System.Windows.Forms.ComboBox();
            this.lblFilterField2 = new System.Windows.Forms.Label();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.comboFilterLogic = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObjData)).BeginInit();
            this.grpDataQuery.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFilterDescription
            // 
            this.LblFilterDescription.AutoSize = true;
            this.LblFilterDescription.Location = new System.Drawing.Point(527, 26);
            this.LblFilterDescription.Name = "LblFilterDescription";
            this.LblFilterDescription.Size = new System.Drawing.Size(79, 13);
            this.LblFilterDescription.TabIndex = 15;
            this.LblFilterDescription.Text = "根据描述筛选";
            // 
            // txtFilterDescription
            // 
            this.txtFilterDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterDescription.Location = new System.Drawing.Point(616, 26);
            this.txtFilterDescription.Name = "txtFilterDescription";
            this.txtFilterDescription.Size = new System.Drawing.Size(176, 13);
            this.txtFilterDescription.TabIndex = 14;
            // 
            // LblOType
            // 
            this.LblOType.AutoSize = true;
            this.LblOType.Location = new System.Drawing.Point(6, 26);
            this.LblOType.Name = "LblOType";
            this.LblOType.Size = new System.Drawing.Size(39, 13);
            this.LblOType.TabIndex = 12;
            this.LblOType.Text = "OType";
            // 
            // dataGridObjData
            // 
            this.dataGridObjData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridObjData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridObjData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridObjData.Location = new System.Drawing.Point(6, 198);
            this.dataGridObjData.Name = "dataGridObjData";
            this.dataGridObjData.Size = new System.Drawing.Size(907, 454);
            this.dataGridObjData.TabIndex = 10;
            // 
            // lblOtherFilter
            // 
            this.lblOtherFilter.AutoSize = true;
            this.lblOtherFilter.Location = new System.Drawing.Point(5, 55);
            this.lblOtherFilter.Name = "lblOtherFilter";
            this.lblOtherFilter.Size = new System.Drawing.Size(79, 13);
            this.lblOtherFilter.TabIndex = 16;
            this.lblOtherFilter.Text = "读取其它字段";
            // 
            // comboAdditionalField
            // 
            this.comboAdditionalField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAdditionalField.FormattingEnabled = true;
            this.comboAdditionalField.Location = new System.Drawing.Point(84, 51);
            this.comboAdditionalField.Name = "comboAdditionalField";
            this.comboAdditionalField.Size = new System.Drawing.Size(125, 21);
            this.comboAdditionalField.TabIndex = 17;
            this.comboAdditionalField.SelectedIndexChanged += new System.EventHandler(this.comboAdditionalField_SelectedIndexChanged);
            // 
            // comboOType
            // 
            this.comboOType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboOType.FormattingEnabled = true;
            this.comboOType.Location = new System.Drawing.Point(84, 23);
            this.comboOType.Name = "comboOType";
            this.comboOType.Size = new System.Drawing.Size(125, 21);
            this.comboOType.TabIndex = 18;
            // 
            // btnQuery
            // 
            this.btnQuery.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Image = global::GcproExtensionApp.Properties.Resources.Access;
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(811, 17);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(89, 27);
            this.btnQuery.TabIndex = 19;
            this.btnQuery.Text = "       查询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblUserDefinedFilter
            // 
            this.lblUserDefinedFilter.AutoSize = true;
            this.lblUserDefinedFilter.Location = new System.Drawing.Point(215, 57);
            this.lblUserDefinedFilter.Name = "lblUserDefinedFilter";
            this.lblUserDefinedFilter.Size = new System.Drawing.Size(91, 13);
            this.lblUserDefinedFilter.TabIndex = 20;
            this.lblUserDefinedFilter.Text = "其它自定义筛选";
            // 
            // txtUserDefinedFilter
            // 
            this.txtUserDefinedFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserDefinedFilter.Location = new System.Drawing.Point(312, 59);
            this.txtUserDefinedFilter.Name = "txtUserDefinedFilter";
            this.txtUserDefinedFilter.Size = new System.Drawing.Size(480, 13);
            this.txtUserDefinedFilter.TabIndex = 21;
            this.txtUserDefinedFilter.TextChanged += new System.EventHandler(this.txtUserDefinedFilter_TextChanged);
            // 
            // grpDataQuery
            // 
            this.grpDataQuery.Controls.Add(this.lblAnd);
            this.grpDataQuery.Controls.Add(this.txtFilterName);
            this.grpDataQuery.Controls.Add(this.lblFilterName);
            this.grpDataQuery.Controls.Add(this.LblOType);
            this.grpDataQuery.Controls.Add(this.btnQuery);
            this.grpDataQuery.Controls.Add(this.txtUserDefinedFilter);
            this.grpDataQuery.Controls.Add(this.txtFilterDescription);
            this.grpDataQuery.Controls.Add(this.lblUserDefinedFilter);
            this.grpDataQuery.Controls.Add(this.LblFilterDescription);
            this.grpDataQuery.Controls.Add(this.lblOtherFilter);
            this.grpDataQuery.Controls.Add(this.comboOType);
            this.grpDataQuery.Controls.Add(this.comboAdditionalField);
            this.grpDataQuery.Location = new System.Drawing.Point(7, 12);
            this.grpDataQuery.Name = "grpDataQuery";
            this.grpDataQuery.Size = new System.Drawing.Size(906, 87);
            this.grpDataQuery.TabIndex = 22;
            this.grpDataQuery.TabStop = false;
            this.grpDataQuery.Text = "数据库查询";
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.ForeColor = System.Drawing.Color.Blue;
            this.lblAnd.Location = new System.Drawing.Point(496, 26);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(30, 13);
            this.lblAnd.TabIndex = 39;
            this.lblAnd.Text = "AND";
            // 
            // txtFilterName
            // 
            this.txtFilterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterName.Location = new System.Drawing.Point(312, 26);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(176, 13);
            this.txtFilterName.TabIndex = 30;
            // 
            // lblFilterName
            // 
            this.lblFilterName.AutoSize = true;
            this.lblFilterName.Location = new System.Drawing.Point(214, 26);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(91, 13);
            this.lblFilterName.TabIndex = 29;
            this.lblFilterName.Text = "根据符号名筛选";
            // 
            // txtUpdateFilter
            // 
            this.txtUpdateFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateFilter.Location = new System.Drawing.Point(313, 56);
            this.txtUpdateFilter.Name = "txtUpdateFilter";
            this.txtUpdateFilter.Size = new System.Drawing.Size(480, 13);
            this.txtUpdateFilter.TabIndex = 28;
            // 
            // lblUpdateFilter
            // 
            this.lblUpdateFilter.AutoSize = true;
            this.lblUpdateFilter.Location = new System.Drawing.Point(216, 55);
            this.lblUpdateFilter.Name = "lblUpdateFilter";
            this.lblUpdateFilter.Size = new System.Drawing.Size(79, 13);
            this.lblUpdateFilter.TabIndex = 27;
            this.lblUpdateFilter.Text = "其它筛选条件";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = global::GcproExtensionApp.Properties.Resources.Access;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(811, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 27);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "       更新";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFieldNewVale
            // 
            this.txtFieldNewVale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFieldNewVale.Location = new System.Drawing.Point(85, 56);
            this.txtFieldNewVale.Name = "txtFieldNewVale";
            this.txtFieldNewVale.Size = new System.Drawing.Size(125, 13);
            this.txtFieldNewVale.TabIndex = 25;
            // 
            // lblFieldNewVale
            // 
            this.lblFieldNewVale.AutoSize = true;
            this.lblFieldNewVale.Location = new System.Drawing.Point(6, 55);
            this.lblFieldNewVale.Name = "lblFieldNewVale";
            this.lblFieldNewVale.Size = new System.Drawing.Size(55, 13);
            this.lblFieldNewVale.TabIndex = 24;
            this.lblFieldNewVale.Text = "字段新值";
            // 
            // lblUpdateField
            // 
            this.lblUpdateField.AutoSize = true;
            this.lblUpdateField.Location = new System.Drawing.Point(7, 22);
            this.lblUpdateField.Name = "lblUpdateField";
            this.lblUpdateField.Size = new System.Drawing.Size(55, 13);
            this.lblUpdateField.TabIndex = 22;
            this.lblUpdateField.Text = "更新字段";
            // 
            // comboUpdateField
            // 
            this.comboUpdateField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboUpdateField.FormattingEnabled = true;
            this.comboUpdateField.Location = new System.Drawing.Point(85, 18);
            this.comboUpdateField.Name = "comboUpdateField";
            this.comboUpdateField.Size = new System.Drawing.Size(125, 21);
            this.comboUpdateField.TabIndex = 23;
            // 
            // lblFilterField1
            // 
            this.lblFilterField1.AutoSize = true;
            this.lblFilterField1.Location = new System.Drawing.Point(216, 22);
            this.lblFilterField1.Name = "lblFilterField1";
            this.lblFilterField1.Size = new System.Drawing.Size(31, 13);
            this.lblFilterField1.TabIndex = 31;
            this.lblFilterField1.Text = "条件";
            // 
            // comboFilterField1
            // 
            this.comboFilterField1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFilterField1.FormattingEnabled = true;
            this.comboFilterField1.Location = new System.Drawing.Point(253, 19);
            this.comboFilterField1.Name = "comboFilterField1";
            this.comboFilterField1.Size = new System.Drawing.Size(78, 21);
            this.comboFilterField1.TabIndex = 32;
            // 
            // comboOperator1
            // 
            this.comboOperator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboOperator1.ForeColor = System.Drawing.Color.Blue;
            this.comboOperator1.FormattingEnabled = true;
            this.comboOperator1.Location = new System.Drawing.Point(331, 19);
            this.comboOperator1.Name = "comboOperator1";
            this.comboOperator1.Size = new System.Drawing.Size(50, 21);
            this.comboOperator1.TabIndex = 33;
            // 
            // txtFilterField1Text
            // 
            this.txtFilterField1Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterField1Text.Location = new System.Drawing.Point(383, 23);
            this.txtFilterField1Text.Name = "txtFilterField1Text";
            this.txtFilterField1Text.Size = new System.Drawing.Size(87, 13);
            this.txtFilterField1Text.TabIndex = 34;
            // 
            // txtFilterField2Text
            // 
            this.txtFilterField2Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterField2Text.Location = new System.Drawing.Point(703, 21);
            this.txtFilterField2Text.Name = "txtFilterField2Text";
            this.txtFilterField2Text.Size = new System.Drawing.Size(87, 13);
            this.txtFilterField2Text.TabIndex = 38;
            // 
            // comboOperator2
            // 
            this.comboOperator2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboOperator2.ForeColor = System.Drawing.Color.Blue;
            this.comboOperator2.FormattingEnabled = true;
            this.comboOperator2.Location = new System.Drawing.Point(648, 18);
            this.comboOperator2.Name = "comboOperator2";
            this.comboOperator2.Size = new System.Drawing.Size(50, 21);
            this.comboOperator2.TabIndex = 37;
            // 
            // comboFilterField2
            // 
            this.comboFilterField2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFilterField2.FormattingEnabled = true;
            this.comboFilterField2.Location = new System.Drawing.Point(566, 18);
            this.comboFilterField2.Name = "comboFilterField2";
            this.comboFilterField2.Size = new System.Drawing.Size(78, 21);
            this.comboFilterField2.TabIndex = 36;
            // 
            // lblFilterField2
            // 
            this.lblFilterField2.AutoSize = true;
            this.lblFilterField2.Location = new System.Drawing.Point(529, 21);
            this.lblFilterField2.Name = "lblFilterField2";
            this.lblFilterField2.Size = new System.Drawing.Size(31, 13);
            this.lblFilterField2.TabIndex = 35;
            this.lblFilterField2.Text = "条件";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.comboFilterLogic);
            this.grpUpdate.Controls.Add(this.comboFilterField1);
            this.grpUpdate.Controls.Add(this.lblFilterField1);
            this.grpUpdate.Controls.Add(this.txtFilterField2Text);
            this.grpUpdate.Controls.Add(this.lblUpdateFilter);
            this.grpUpdate.Controls.Add(this.txtFieldNewVale);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.comboOperator1);
            this.grpUpdate.Controls.Add(this.comboOperator2);
            this.grpUpdate.Controls.Add(this.lblFieldNewVale);
            this.grpUpdate.Controls.Add(this.txtUpdateFilter);
            this.grpUpdate.Controls.Add(this.txtFilterField1Text);
            this.grpUpdate.Controls.Add(this.comboFilterField2);
            this.grpUpdate.Controls.Add(this.lblUpdateField);
            this.grpUpdate.Controls.Add(this.comboUpdateField);
            this.grpUpdate.Controls.Add(this.lblFilterField2);
            this.grpUpdate.Location = new System.Drawing.Point(7, 105);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(906, 87);
            this.grpUpdate.TabIndex = 39;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "更新字段";
            // 
            // comboFilterLogic
            // 
            this.comboFilterLogic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFilterLogic.ForeColor = System.Drawing.Color.Blue;
            this.comboFilterLogic.FormattingEnabled = true;
            this.comboFilterLogic.Location = new System.Drawing.Point(476, 18);
            this.comboFilterLogic.Name = "comboFilterLogic";
            this.comboFilterLogic.Size = new System.Drawing.Size(50, 21);
            this.comboFilterLogic.TabIndex = 39;
            // 
            // ObjectBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 657);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpDataQuery);
            this.Controls.Add(this.dataGridObjData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObjectBrowser";
            this.Text = "对象浏览器";
            this.Load += new System.EventHandler(this.ObjectBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObjData)).EndInit();
            this.grpDataQuery.ResumeLayout(false);
            this.grpDataQuery.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LblFilterDescription;
        internal System.Windows.Forms.TextBox txtFilterDescription;
        internal System.Windows.Forms.Label LblOType;
        internal System.Windows.Forms.DataGridView dataGridObjData;
        internal System.Windows.Forms.Label lblOtherFilter;
        private System.Windows.Forms.ComboBox comboAdditionalField;
        private System.Windows.Forms.ComboBox comboOType;
        internal System.Windows.Forms.Button btnQuery;
        internal System.Windows.Forms.Label lblUserDefinedFilter;
        internal System.Windows.Forms.TextBox txtUserDefinedFilter;
        private System.Windows.Forms.GroupBox grpDataQuery;
        internal System.Windows.Forms.TextBox txtFieldNewVale;
        internal System.Windows.Forms.Label lblFieldNewVale;
        internal System.Windows.Forms.Label lblUpdateField;
        private System.Windows.Forms.ComboBox comboUpdateField;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.TextBox txtUpdateFilter;
        internal System.Windows.Forms.Label lblUpdateFilter;
        internal System.Windows.Forms.TextBox txtFilterName;
        internal System.Windows.Forms.Label lblFilterName;
        internal System.Windows.Forms.TextBox txtFilterField1Text;
        private System.Windows.Forms.ComboBox comboOperator1;
        private System.Windows.Forms.ComboBox comboFilterField1;
        internal System.Windows.Forms.Label lblFilterField1;
        internal System.Windows.Forms.TextBox txtFilterField2Text;
        private System.Windows.Forms.ComboBox comboOperator2;
        private System.Windows.Forms.ComboBox comboFilterField2;
        internal System.Windows.Forms.Label lblFilterField2;
        internal System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.ComboBox comboFilterLogic;
    }
}