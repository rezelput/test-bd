using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace test_bd
{
    public partial class AddForm : Form
    {
        
        public AddForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.test_ttDataSet.Tables[0].NewRow();

                int rc = main.dataGridView1.RowCount + 1;
                int tc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[4] = tbPhone_em.Text;
                nRow[4] = tbPhone_em.Text;
                nRow[2] = tc;
                main.test_ttDataSet.Tables[0].Rows.Add(nRow);
                main.test_ttDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbPhone_em.Text = "";
            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void телефонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbPhone_em.Mask = @"00-000-000";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cls_form_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            /*this.contactsTableAdapter.Fill(this.test_ttDataSet.contacts);*/
        }

        private void tp2_Click(object sender, EventArgs e)
        {
            this.tbPhone_em.Mask = @"L#LLL@LLLLL.ru";
            
        }
    }
}
