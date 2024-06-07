namespace GcproExtensionApp
{
    partial class ObjectBroswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectBroswer));
            this.LblFilterDescription = new System.Windows.Forms.Label();
            this.TxtFilterDescription = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblOType = new System.Windows.Forms.Label();
            this.TxtOType = new System.Windows.Forms.TextBox();
            this.DGVGcpro = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGcpro)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFilterDescription
            // 
            this.LblFilterDescription.AutoSize = true;
            this.LblFilterDescription.Location = new System.Drawing.Point(193, 9);
            this.LblFilterDescription.Name = "LblFilterDescription";
            this.LblFilterDescription.Size = new System.Drawing.Size(31, 13);
            this.LblFilterDescription.TabIndex = 15;
            this.LblFilterDescription.Text = "筛选";
            // 
            // TxtFilterDescription
            // 
            this.TxtFilterDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFilterDescription.Location = new System.Drawing.Point(238, 10);
            this.TxtFilterDescription.Name = "TxtFilterDescription";
            this.TxtFilterDescription.Size = new System.Drawing.Size(333, 13);
            this.TxtFilterDescription.TabIndex = 14;
            this.TxtFilterDescription.Text = "可以通过描述再次筛选，完成按下回车键！";
            // 
            // BtnOK
            // 
            this.BtnOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Image = global::GcproExtensionApp.Properties.Resources.Confirm2;
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.Location = new System.Drawing.Point(807, 32);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(89, 27);
            this.BtnOK.TabIndex = 13;
            this.BtnOK.Text = "       确定";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // LblOType
            // 
            this.LblOType.AutoSize = true;
            this.LblOType.Location = new System.Drawing.Point(9, 9);
            this.LblOType.Name = "LblOType";
            this.LblOType.Size = new System.Drawing.Size(39, 13);
            this.LblOType.TabIndex = 12;
            this.LblOType.Text = "OType";
            // 
            // TxtOType
            // 
            this.TxtOType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOType.Enabled = false;
            this.TxtOType.Location = new System.Drawing.Point(54, 10);
            this.TxtOType.Name = "TxtOType";
            this.TxtOType.Size = new System.Drawing.Size(100, 13);
            this.TxtOType.TabIndex = 11;
            this.TxtOType.Text = "OType";
            // 
            // DGVGcpro
            // 
            this.DGVGcpro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVGcpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGcpro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Description,
            this.Value});
            this.DGVGcpro.Location = new System.Drawing.Point(5, 32);
            this.DGVGcpro.Name = "DGVGcpro";
            this.DGVGcpro.Size = new System.Drawing.Size(796, 620);
            this.DGVGcpro.TabIndex = 10;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol[名称]";
            this.Symbol.Name = "Symbol";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description[描述]";
            this.Description.Name = "Description";
            this.Description.Width = 500;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 136;
            // 
            // ObjectBroswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 657);
            this.Controls.Add(this.LblFilterDescription);
            this.Controls.Add(this.TxtFilterDescription);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblOType);
            this.Controls.Add(this.TxtOType);
            this.Controls.Add(this.DGVGcpro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObjectBroswer";
            this.Text = "对象浏览器";
            ((System.ComponentModel.ISupportInitialize)(this.DGVGcpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblFilterDescription;
        internal System.Windows.Forms.TextBox TxtFilterDescription;
        internal System.Windows.Forms.Button BtnOK;
        internal System.Windows.Forms.Label LblOType;
        internal System.Windows.Forms.TextBox TxtOType;
        internal System.Windows.Forms.DataGridView DGVGcpro;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Description;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}