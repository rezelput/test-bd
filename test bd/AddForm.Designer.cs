
namespace test_bd
{
    partial class AddForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.add2form1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.типКонтактаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tp2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cls_form = new System.Windows.Forms.Button();
            this.tbPhone_em = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(181, 20);
            this.tbName.TabIndex = 0;
            // 
            // add2form1
            // 
            this.add2form1.Location = new System.Drawing.Point(36, 193);
            this.add2form1.Name = "add2form1";
            this.add2form1.Size = new System.Drawing.Size(75, 23);
            this.add2form1.TabIndex = 1;
            this.add2form1.Text = "Add2form";
            this.add2form1.UseVisualStyleBackColor = true;
            this.add2form1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.типКонтактаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(107, 111);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(110, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(12, 20);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // типКонтактаToolStripMenuItem
            // 
            this.типКонтактаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tp1,
            this.tp2});
            this.типКонтактаToolStripMenuItem.Name = "типКонтактаToolStripMenuItem";
            this.типКонтактаToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.типКонтактаToolStripMenuItem.Text = "Тип контакта";
            // 
            // tp1
            // 
            this.tp1.Name = "tp1";
            this.tp1.Size = new System.Drawing.Size(180, 22);
            this.tp1.Text = "Сотовый";
            this.tp1.Click += new System.EventHandler(this.телефонToolStripMenuItem_Click);
            // 
            // tp2
            // 
            this.tp2.Name = "tp2";
            this.tp2.Size = new System.Drawing.Size(180, 22);
            this.tp2.Text = "email";
            this.tp2.Click += new System.EventHandler(this.tp2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Телефон";
            // 
            // cls_form
            // 
            this.cls_form.Location = new System.Drawing.Point(130, 193);
            this.cls_form.Name = "cls_form";
            this.cls_form.Size = new System.Drawing.Size(75, 23);
            this.cls_form.TabIndex = 6;
            this.cls_form.Text = "Close";
            this.cls_form.UseVisualStyleBackColor = true;
            this.cls_form.Click += new System.EventHandler(this.cls_form_Click);
            // 
            // tbPhone_em
            // 
            this.tbPhone_em.Location = new System.Drawing.Point(107, 78);
            this.tbPhone_em.Name = "tbPhone_em";
            this.tbPhone_em.Size = new System.Drawing.Size(181, 20);
            this.tbPhone_em.TabIndex = 7;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 240);
            this.Controls.Add(this.tbPhone_em);
            this.Controls.Add(this.cls_form);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add2form1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button add2form1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem типКонтактаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tp1;
        private System.Windows.Forms.ToolStripMenuItem tp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cls_form;
        private System.Windows.Forms.MaskedTextBox tbPhone_em;
    }
}