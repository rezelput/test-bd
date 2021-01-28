
namespace test_bd
{
    partial class phone
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_tt_4_edit1DataSet = new test_bd.test_tt_4_editDataSet();
            this.phoneTableAdapter = new test_bd.test_tt_4_editDataSetTableAdapters.phoneTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toFormTestttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test_tt_4_edit1DataSet1 = new test_bd.test_tt_4_edit1DataSet();
            this.testtt4edit1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_tt_4_edit1DataSet11 = new test_bd.test_tt_4_edit1DataSet1();
            this.testtt4edit1DataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTableAdapter1 = new test_bd.test_tt_4_edit1DataSet1TableAdapters.phoneTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonetypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_edit1DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_edit1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtt4edit1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_edit1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtt4edit1DataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.phonetypeidDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.phoneBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(147, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "phone";
            this.phoneBindingSource.DataSource = this.test_tt_4_edit1DataSet;
            // 
            // test_tt_4_edit1DataSet
            // 
            this.test_tt_4_edit1DataSet.DataSetName = "test_tt_4_editDataSet";
            this.test_tt_4_edit1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneTableAdapter
            // 
            this.phoneTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toFormTestttToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.formToolStripMenuItem.Text = "form...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItem2.Text = "sync form test_tt";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItem3.Text = "update this form";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toFormTestttToolStripMenuItem
            // 
            this.toFormTestttToolStripMenuItem.Name = "toFormTestttToolStripMenuItem";
            this.toFormTestttToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.toFormTestttToolStripMenuItem.Text = "to form test_tt";
            this.toFormTestttToolStripMenuItem.Click += new System.EventHandler(this.toFormTestttToolStripMenuItem_Click);
            // 
            // test_tt_4_edit1DataSet1
            // 
            this.test_tt_4_edit1DataSet1.DataSetName = "test_tt_4_edit1DataSet";
            this.test_tt_4_edit1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testtt4edit1DataSet1BindingSource
            // 
            this.testtt4edit1DataSet1BindingSource.DataSource = this.test_tt_4_edit1DataSet1;
            this.testtt4edit1DataSet1BindingSource.Position = 0;
            // 
            // test_tt_4_edit1DataSet11
            // 
            this.test_tt_4_edit1DataSet11.DataSetName = "test_tt_4_edit1DataSet1";
            this.test_tt_4_edit1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testtt4edit1DataSet11BindingSource
            // 
            this.testtt4edit1DataSet11BindingSource.DataSource = this.test_tt_4_edit1DataSet11;
            this.testtt4edit1DataSet11BindingSource.Position = 0;
            // 
            // phoneBindingSource1
            // 
            this.phoneBindingSource1.DataMember = "phone";
            this.phoneBindingSource1.DataSource = this.testtt4edit1DataSet11BindingSource;
            // 
            // phoneTableAdapter1
            // 
            this.phoneTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // phonetypeidDataGridViewTextBoxColumn
            // 
            this.phonetypeidDataGridViewTextBoxColumn.DataPropertyName = "phone_type_id";
            this.phonetypeidDataGridViewTextBoxColumn.HeaderText = "phone_type_id";
            this.phonetypeidDataGridViewTextBoxColumn.Name = "phonetypeidDataGridViewTextBoxColumn";
            this.phonetypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phonetypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 346);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "phone";
            this.Text = "phone";
            this.Load += new System.EventHandler(this.phone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_edit1DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_edit1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtt4edit1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_edit1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtt4edit1DataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource phoneBindingSource;
        public test_tt_4_editDataSetTableAdapters.phoneTableAdapter phoneTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toFormTestttToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView2;
        public test_tt_4_editDataSet test_tt_4_edit1DataSet;
        private System.Windows.Forms.BindingSource testtt4edit1DataSet11BindingSource;
        private test_tt_4_edit1DataSet1 test_tt_4_edit1DataSet11;
        private test_tt_4_edit1DataSet test_tt_4_edit1DataSet1;
        private System.Windows.Forms.BindingSource testtt4edit1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource phoneBindingSource1;
        private test_tt_4_edit1DataSet1TableAdapters.phoneTableAdapter phoneTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn phonetypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}