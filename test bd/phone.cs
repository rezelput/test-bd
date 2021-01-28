using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace test_bd
{
    public partial class phone : Form
    {

        DataTable dt;
        BindingSource bs;
        OleDbDataAdapter adapter,sa;
        OleDbConnection cot1;
        DataSet fs;
        public phone()
        {
            InitializeComponent();

            this.Load += (sender, e) =>
            {
                DataTable dt = CreateDataTable();
                dataGridView2.DataSource = dt;
            };
            ForLoad_testTT();
         /*   Form_test_tt ftt = new Form_test_tt();
            if (ftt.ShowDialog() == DialogResult.OK)
            {
                toolStripMenuItem2.Click += (sender, e) =>
            {
                dataGridView2.DataSource = ftt.dataGridView1.DataSource;
            };
            };*/


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

                //phonetypeidDataGridViewTextBoxColumn.Items.Add(reader["phone_type"].ToString());
                //comboBox1.Items.Add(course);
            }

            connect.Close();
        }
        private void phone_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_tt_4_edit1DataSet11.phone". При необходимости она может быть перемещена или удалена.
            //this.phoneTableAdapter1.Fill(this.test_tt_4_edit1DataSet11.phone);
            cot1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = test_tt_4_edit.mdb");
            sa = new OleDbDataAdapter("select * from phone", cot1);
            cot1.Open();
            fs = new DataSet();
            sa.Fill(fs, "phone");
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_tt_4_editDataSet.phone". При необходимости она может быть перемещена или удалена.
            this.phoneTableAdapter.Fill(this.test_tt_4_edit1DataSet.phone);

        }

        private DataTable CreateDataTable()
        {
            DataTable iddt = new DataTable("phone");
            DataColumn id = new DataColumn("id");
            DataColumn phone_t_id = new DataColumn("phone_type_id");
            DataColumn phnum = new DataColumn("phone");

            iddt.Columns.AddRange(new DataColumn[] { id, phone_t_id, phnum });
            return iddt;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateDataTable();
            string catBD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = test_tt_4_edit.mdb";
            string conBD = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=test_tt_4_edit.mdb", catBD);

            OleDbConnection connection = new OleDbConnection(conBD);

            connection.Open();

            string query1 = "SELECT * FROM phone";
            OleDbCommand cmd1 = new OleDbCommand(query1, connection);

            dt = new DataTable();

            adapter = new OleDbDataAdapter(cmd1);
           // OleDbCommandBuilder = OleDbCommandBuilder(adapter);
            adapter.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void toFormTestttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form_test_tt f = new Form_test_tt();
            f.ShowDialog();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //void Update()
        /* {
             dataGridView1.Rows.Clear();
              string fname = patсh;
              string[] lines = File.ReadAllLines(fname);
              string[] inpstr;
              char[] delim = new char[] { '|' }; // Разделители

              for (int i = 0; i < lines.Length; i++)
              {
                  if (lines[i] != null || lines[i] != "")
                  {
                      inpstr = lines[i].Split(delim);
                      dataGridView1.Rows.Add(inpstr);
                  }
              }


             }*/
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Update();
            int i = dataGridView2.CurrentRow.Index;
            this.phoneTableAdapter.Fill(this.test_tt_4_edit1DataSet.phone);
            dataGridView2.CurrentCell = dataGridView2[0, i];
        }

        
    }
}
