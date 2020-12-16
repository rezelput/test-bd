
namespace test_bd
{
    partial class catalog
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
            this.components = new System.ComponentModel.Container();
            this.phone_typeTableAdapter1 = new test_bd.test_ttDataSet1TableAdapters.phone_typeTableAdapter();
            this.test_ttDataSet1 = new test_bd.test_ttDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testttDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_typeTableAdapter = new test_bd.test_ttDataSetTableAdapters.phone_typeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.test_ttDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testttDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phone_typeTableAdapter1
            // 
            this.phone_typeTableAdapter1.ClearBeforeFill = true;
            // 
            // test_ttDataSet1
            // 
            this.test_ttDataSet1.DataSetName = "test_ttDataSet";
            this.test_ttDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.phonetypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phonetypeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // phonetypeDataGridViewTextBoxColumn
            // 
            this.phonetypeDataGridViewTextBoxColumn.DataPropertyName = "phone_type";
            this.phonetypeDataGridViewTextBoxColumn.HeaderText = "phone_type";
            this.phonetypeDataGridViewTextBoxColumn.Name = "phonetypeDataGridViewTextBoxColumn";
            // 
            // phonetypeBindingSource
            // 
            this.phonetypeBindingSource.DataMember = "phone_type";
            this.phonetypeBindingSource.DataSource = this.testttDataSet1BindingSource;
            // 
            // testttDataSet1BindingSource
            // 
            this.testttDataSet1BindingSource.DataSource = this.test_ttDataSet1;
            this.testttDataSet1BindingSource.Position = 0;
            // 
            // phone_typeTableAdapter
            // 
            this.phone_typeTableAdapter.ClearBeforeFill = true;
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 293);
            this.Controls.Add(this.dataGridView1);
            this.Name = "catalog";
            this.Text = "catalog";
            this.Load += new System.EventHandler(this.catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test_ttDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testttDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private test_ttDataSet1TableAdapters.phone_typeTableAdapter phone_typeTableAdapter1;
        private test_ttDataSet test_ttDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource testttDataSet1BindingSource;
        private System.Windows.Forms.BindingSource phonetypeBindingSource;
        private test_ttDataSetTableAdapters.phone_typeTableAdapter phone_typeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonetypeDataGridViewTextBoxColumn;
    }
}