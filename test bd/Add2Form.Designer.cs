
namespace test_bd
{
    partial class Add2Form
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.add2form1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cls_form = new System.Windows.Forms.Button();
            this.tbPhone_em = new System.Windows.Forms.MaskedTextBox();
            this.phone_typeTableAdapter1 = new test_bd.test_tt_4_editDataSetTableAdapters.phone_typeTableAdapter();
            this.BoxType = new System.Windows.Forms.ComboBox();
            this.test_tt_4_editDataSet = new test_bd.test_tt_4_editDataSet();
            this.phonetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.test_tt_4_edit1DataSet = new test_bd.test_tt_4_edit1DataSet();
            this.phonetypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phone_typeTableAdapter = new test_bd.test_tt_4_edit1DataSetTableAdapters.phone_typeTableAdapter();
            this.testtt4edit1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonetypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_editDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonetypeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_edit1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonetypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtt4edit1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonetypeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(81, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 20);
            this.tbName.TabIndex = 0;
            // 
            // add2form1
            // 
            this.add2form1.Location = new System.Drawing.Point(38, 236);
            this.add2form1.Name = "add2form1";
            this.add2form1.Size = new System.Drawing.Size(75, 23);
            this.add2form1.TabIndex = 1;
            this.add2form1.Text = "Add2form";
            this.add2form1.UseVisualStyleBackColor = true;
            this.add2form1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Телефон";
            // 
            // cls_form
            // 
            this.cls_form.Location = new System.Drawing.Point(132, 236);
            this.cls_form.Name = "cls_form";
            this.cls_form.Size = new System.Drawing.Size(75, 23);
            this.cls_form.TabIndex = 6;
            this.cls_form.Text = "Close";
            this.cls_form.UseVisualStyleBackColor = true;
            this.cls_form.Click += new System.EventHandler(this.cls_form_Click);
            // 
            // tbPhone_em
            // 
            this.tbPhone_em.Location = new System.Drawing.Point(81, 80);
            this.tbPhone_em.Name = "tbPhone_em";
            this.tbPhone_em.Size = new System.Drawing.Size(170, 20);
            this.tbPhone_em.TabIndex = 7;
            // 
            // phone_typeTableAdapter1
            // 
            this.phone_typeTableAdapter1.ClearBeforeFill = true;
            // 
            // BoxType
            // 
            this.BoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phonetypeBindingSource, "phone_type", true));
            this.BoxType.DataSource = this.phonetypeBindingSource2;
            this.BoxType.DisplayMember = "phone_type";
            this.BoxType.FormattingEnabled = true;
            this.BoxType.Location = new System.Drawing.Point(25, 30);
            this.BoxType.Name = "BoxType";
            this.BoxType.Size = new System.Drawing.Size(121, 21);
            this.BoxType.TabIndex = 8;
            this.BoxType.ValueMember = "phone_type";
            this.BoxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // test_tt_4_editDataSet
            // 
            this.test_tt_4_editDataSet.DataSetName = "test_tt_4_editDataSet";
            this.test_tt_4_editDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonetypeBindingSource
            // 
            this.phonetypeBindingSource.DataMember = "phone_type";
            this.phonetypeBindingSource.DataSource = this.test_tt_4_editDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbPhone_em);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 207);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BoxType);
            this.groupBox2.Location = new System.Drawing.Point(81, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 77);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "выбрать тип значения";
            // 
            // test_tt_4_edit1DataSet
            // 
            this.test_tt_4_edit1DataSet.DataSetName = "test_tt_4_edit1DataSet";
            this.test_tt_4_edit1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonetypeBindingSource1
            // 
            this.phonetypeBindingSource1.DataMember = "phone_type";
            this.phonetypeBindingSource1.DataSource = this.test_tt_4_edit1DataSet;
            // 
            // phone_typeTableAdapter
            // 
            this.phone_typeTableAdapter.ClearBeforeFill = true;
            // 
            // testtt4edit1DataSetBindingSource
            // 
            this.testtt4edit1DataSetBindingSource.DataSource = this.test_tt_4_edit1DataSet;
            this.testtt4edit1DataSetBindingSource.Position = 0;
            // 
            // phonetypeBindingSource2
            // 
            this.phonetypeBindingSource2.DataMember = "phone_type";
            this.phonetypeBindingSource2.DataSource = this.testtt4edit1DataSetBindingSource;
            // 
            // Add2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cls_form);
            this.Controls.Add(this.add2form1);
            this.Name = "Add2Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_editDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonetypeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.test_tt_4_edit1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonetypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtt4edit1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonetypeBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button add2form1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cls_form;
        private System.Windows.Forms.MaskedTextBox tbPhone_em;
        public test_tt_4_editDataSetTableAdapters.phone_typeTableAdapter phone_typeTableAdapter1;
        private System.Windows.Forms.ComboBox BoxType;
        private System.Windows.Forms.BindingSource phonetypeBindingSource;
        private test_tt_4_editDataSet test_tt_4_editDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private test_tt_4_edit1DataSet test_tt_4_edit1DataSet;
        private System.Windows.Forms.BindingSource phonetypeBindingSource1;
        private test_tt_4_edit1DataSetTableAdapters.phone_typeTableAdapter phone_typeTableAdapter;
        private System.Windows.Forms.BindingSource testtt4edit1DataSetBindingSource;
        private System.Windows.Forms.BindingSource phonetypeBindingSource2;
    }
}