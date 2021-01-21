using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_bd
{
    public partial class user_name : Form
    {
        public string CmdText = "SELECT * FROM [phone_type]";
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=test_tt_4_edit.mdb";//"Provider=Microsoft.Jet.OLEDB.4.0;DataSource=C:\\Programs\\C_Sharp\\WindowsFormsApplication1\\test_tt.mdb";

        
        public user_name()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            // создаем объект DataSet
            DataSet ds = new DataSet();
            // заполняем таблицу Order  
            // данными из базы данных
            dataAdapter.Fill(ds, "[phone_type]");
            // dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void data_phone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void catalog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_ttDataSet1.phone_type". При необходимости она может быть перемещена или удалена.
            //this.phone_typeTableAdapter.Fill(this.test_ttDataSet1.phone_type);

        }

        private void user_name_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_tt_4_editDataSet.user_name". При необходимости она может быть перемещена или удалена.
            this.user_nameTableAdapter.Fill(this.test_tt_4_editDataSet.user_name);

        }

        

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Hide();
            Form_test_tt f = new Form_test_tt();
            f.ShowDialog();
            this.Close();
        }

       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
