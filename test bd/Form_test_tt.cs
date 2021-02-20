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
/*using Microsoft.PowerBI.Api.Models;*/

namespace test_bd
{
    /*public void Information()
        {
            DataTable table = new OleDbEnumerator().GetElements();
            string inf = "";
            foreach (DataRow row in table.Rows)
                inf += row["SOURCES_NAME"] + "\n";

            MessageBox.Show(inf);
        }*/
    
    public partial class Form_test_tt : Form
    {
        OleDbConnection cot1;
        OleDbDataAdapter da, sa;
      //  OleDbCommand cmd;
        DataSet ds, fs;
        public Form_test_tt()
        {
          /*  SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=true;");
            SqlCommand cmd;
            SqlDataAdapter adapt;
            //ID variable used in Updating and Deleting Record
            int ID = 0;
        */
            InitializeComponent();
            test_tt();
            ForLoad_testTT();
          //  DisplayData();
        }
        void ForLoad_testTT()
        {
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = test_tt 4 edit1.mdb";
            connect.Open();
            //MessageBox.Show("База подключена");

            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT phone_type FROM phone_type";

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
               // phonetypeidDataGridViewTextBoxColumn.Items.Add(reader["phone_type"].ToString());
                //comboBox1.Items.Add(course);
            }

            connect.Close();
        }
        void test_tt()
        {
            
            cot1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = test_tt_4_edit.mdb");
            da = new OleDbDataAdapter("SELECT *FROM contacts", cot1);
            sa = new OleDbDataAdapter("select * from phone", cot1);
             ds = new DataSet();
              fs = new DataSet();
              cot1.Open();
               da.Fill(ds, "contacts");
              sa.Fill(fs, "phone");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            test_tt();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_tt_4_editDataSet.contacts". При необходимости она может быть перемещена или удалена.
            this.contactsTableAdapter.Fill(this.test_tt_4_editDataSet.tablecontacts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_tt_4_editDataSet.contacts". При необходимости она может быть перемещена или удалена.
            
            
        }
       
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            contactsBindingSource.Filter = "dd = " + id.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add2Form af = new Add2Form();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            user_name f = new user_name();
            f.ShowDialog();
            this.Close();
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            phone ph = new phone();
            ph.ShowDialog();
            this.Close();
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Закрыть форму?", "форма", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No) //Если нажал нет
            {
                string net = "-->";
                MessageBox.Show(net);
            }

            if (result == DialogResult.Yes) //Если нажал Да
            {
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.Update(test_tt_4_editDataSet);
            dataGridView1.Refresh();
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }
    }
    
}
