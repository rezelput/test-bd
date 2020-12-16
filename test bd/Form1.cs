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
    
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da, sa;
      //  OleDbCommand cmd;
        DataSet ds, fs;
        public Form1()
        {
          /*  SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=true;");
            SqlCommand cmd;
            SqlDataAdapter adapt;
            //ID variable used in Updating and Deleting Record
            int ID = 0;
        */
            InitializeComponent();
          //  DisplayData();
        }
        void test_tt()
        {
            //con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\Пример приложения для работы с Access базой\Пример приложения для работы с Access базой\bin\Debug\dbSchool.accdb");
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=test_tt.mdb");
            da = new OleDbDataAdapter("SELECT *FROM contacts", con);
            sa = new OleDbDataAdapter("select * from phone_type", con);
            ds = new DataSet();
            fs = new DataSet();
            con.Open();
            da.Fill(ds, "contacts");
            sa.Fill(fs, "phone_type");
            dataGridView1.DataSource = ds.Tables["contacts"];
            dataGridView1.DataSource = fs.Tables["phone_type"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            test_tt();
            // TODO: This line of code loads data into the 'accountDataSet.Account' table. You can move, or remove it, as needed.
           // this.contactsTableAdapter.Fill(this.test_ttDataSet.contacts);

            // TODO: This line of code loads data into the 'accountDataSet.Worker' table. You can move, or remove it, as needed.
          //  this.phone_typeTableAdapter.Fill(this.test_ttDataSet.phone_type);
        }
        //Display Data in DataGridView
        /* private void DisplayData()
         {
             con.Open();
             DataTable dt = new DataTable();
             adapt = new SqlDataAdapter("select * from contacts", con);
             adapt.Fill(dt);
             dataGridView1.DataSource = dt;
             con.Close();
         }*/
        /* private void Form1_Load(object sender, EventArgs e)
         {

             // TODO: данная строка кода позволяет загрузить данные в таблицу "test_ttDataSet.contacts". При необходимости она может быть перемещена или удалена.
             /*   this.contactsTableAdapter.Fill(this.test_ttDataSet.contacts);

         }*/
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
            AddForm af = new AddForm();
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

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog af = new catalog();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contactsTableAdapter.Update(test_ttDataSet);
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            /* 
             DataGridViewColumn column1 = new DataGridViewColumn();
             DataGridViewComboBoxCell cell1 = new DataGridViewComboBoxCell();

             column1.HeaderText = "phone_type";
             column1.Name = "Test";
             column1.CellTemplate = cell1;
             dataGridView1.Columns.Add(column1);

             //Добавление данных

             DataGridViewRow row = new DataGridViewRow();
             DataGridViewComboBoxCell cell_CB = new DataGridViewComboBoxCell();
             cell_CB.Items.AddRange(new string[] { "сотовый", "email" });
             row.Cells.Add(cell_CB);

             this.dataGridView1.Rows.Add(row);
            */
                // соединяемся с сервером
          /*      OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=\\\\SRV\\1\\1\\test_tt.mdb");
            // подготавливаем команду
            OleDbCommand command = new OleDbCommand("SELECT * FROM phone_type");
            command.Connection = connection;
            // создаем адаптер и набор данных
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            // заполняем набор данных
            adapter.Fill(Dataset);
            bindingSource1.DataSource = dataset.Tables[0];
            dataGridView1.DataSource = bindingSource1;*/
        }
    }
    
}
