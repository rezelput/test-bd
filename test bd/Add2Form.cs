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
    public partial class Add2Form : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adapt;
        public Add2Form()
        {
            InitializeComponent();
        }

        void DisplayData()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = test_tt_4_edit.mdb");
            
            DataTable dt = new DataTable();
            adapt = new OleDbDataAdapter("select id from phone_type_id", con);
            Form_test_tt newtt = new Form_test_tt();

            adapt.Fill(dt);
            newtt.dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form_test_tt main = this.Owner as Form_test_tt;
            
            if (main != null)
            {
                DataRow nRow = main.test_tt_4_editDataSet.Tables[0].NewRow();
              

                int rc = main.dataGridView1.RowCount + 1;
               
                nRow[1] = rc;
                nRow[2] = main.dataGridView1.RowCount + 1;
                
                nRow[4] = tbPhone_em.Text;
               
                if (BoxType.SelectedIndex == 0)
                {
                    nRow[3] = BoxType.SelectedIndex == 0;
                }
                else if (BoxType.SelectedIndex == 1)
                {
                    nRow[3] = BoxType.SelectedIndex == 1;
                }
                else if (BoxType.SelectedIndex == 2)
                {
                    nRow[3] = BoxType.SelectedIndex == 2; 
                }
                main.test_tt_4_editDataSet.Tables[0].Rows.Add(nRow);
                main.test_tt_4_editDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbPhone_em.Text = "";
              
            }

        }
        
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_tt_4_edit1DataSet.phone_type". При необходимости она может быть перемещена или удалена.
            this.phone_typeTableAdapter.Fill(this.test_tt_4_edit1DataSet.phone_type);
            /*this.contactsTableAdapter.Fill(this.test_ttDataSet.contacts);*/
        }

        private void tp2_Click(object sender, EventArgs e)
        {
            
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (BoxType.SelectedIndex == 0)
                {
                    this.tbPhone_em.Mask = @"+00-000-000";
                }
                else if (BoxType.SelectedIndex == 1)
                {
                    this.tbPhone_em.Mask = @"+00-000-000";
                   
                }
                else if (BoxType.SelectedIndex == 2)
                {
                    this.tbPhone_em.Mask = @"L#LLL@LLLLL.ru";
                    
                }
        }

        private void tbPhone_em_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
            
        }
    }
}
