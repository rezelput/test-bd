
namespace test_bd
{
    partial class Form_test_tt
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonetypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_tt_4_editDataSet = new test_bd.test_tt_4_editDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsTableAdapter = new test_bd.test_tt_4_editDataSetTableAdapters.contactsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_editDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddForm
            // 
            this.AddForm.Location = new System.Drawing.Point(15, 324);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(80, 23);
            this.AddForm.TabIndex = 1;
            this.AddForm.Text = "Add";
            this.AddForm.UseVisualStyleBackColor = true;
            this.AddForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ddDataGridViewTextBoxColumn,
            this.idnameDataGridViewTextBoxColumn,
            this.phoneidDataGridViewTextBoxColumn,
            this.phonetypeidDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 131);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ddDataGridViewTextBoxColumn
            // 
            this.ddDataGridViewTextBoxColumn.DataPropertyName = "dd";
            this.ddDataGridViewTextBoxColumn.HeaderText = "dd";
            this.ddDataGridViewTextBoxColumn.Name = "ddDataGridViewTextBoxColumn";
            // 
            // idnameDataGridViewTextBoxColumn
            // 
            this.idnameDataGridViewTextBoxColumn.DataPropertyName = "id_name";
            this.idnameDataGridViewTextBoxColumn.HeaderText = "id_name";
            this.idnameDataGridViewTextBoxColumn.Name = "idnameDataGridViewTextBoxColumn";
            // 
            // phoneidDataGridViewTextBoxColumn
            // 
            this.phoneidDataGridViewTextBoxColumn.DataPropertyName = "phone_id";
            this.phoneidDataGridViewTextBoxColumn.HeaderText = "phone_id";
            this.phoneidDataGridViewTextBoxColumn.Name = "phoneidDataGridViewTextBoxColumn";
            // 
            // phonetypeidDataGridViewTextBoxColumn
            // 
            this.phonetypeidDataGridViewTextBoxColumn.DataPropertyName = "phone_type_id";
            this.phonetypeidDataGridViewTextBoxColumn.HeaderText = "phone_type_id";
            this.phonetypeidDataGridViewTextBoxColumn.Name = "phonetypeidDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "contacts";
            this.contactsBindingSource.DataSource = this.test_tt_4_editDataSet;
            // 
            // test_tt_4_editDataSet
            // 
            this.test_tt_4_editDataSet.DataSetName = "test_tt_4_editDataSet";
            this.test_tt_4_editDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.phoneToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.справочникToolStripMenuItem.Text = "handbook";
            this.справочникToolStripMenuItem.Click += new System.EventHandler(this.справочникToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem.Text = "user";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phoneToolStripMenuItem.Text = "phone";
            this.phoneToolStripMenuItem.Click += new System.EventHandler(this.phoneToolStripMenuItem_Click);
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_test_tt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_test_tt";
            this.Text = "test_tt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_editDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddForm;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        public test_tt_4_editDataSetTableAdapters.phone_typeTableAdapter phone_typeTableAdapter;
        public test_tt_4_editDataSet test_tt_4_editDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private test_tt_4_editDataSetTableAdapters.contactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonetypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem;
    }
}

