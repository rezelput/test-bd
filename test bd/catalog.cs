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
    public partial class catalog : Form
    {
        public string CmdText = "SELECT * FROM [phone_type]";
        public string ConnString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=test_tt.mdb";//"Provider=Microsoft.Jet.OLEDB.4.0;DataSource=C:\\Programs\\C_Sharp\\WindowsFormsApplication1\\test_tt.mdb";
        public catalog()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            // создаем объект DataSet
            DataSet ds = new DataSet();
            // заполняем таблицу Order  
            // данными из базы данных
            dataAdapter.Fill(ds, "[phone_type]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void data_phone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void catalog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_ttDataSet1.phone_type". При необходимости она может быть перемещена или удалена.
            //this.phone_typeTableAdapter.Fill(this.test_ttDataSet1.phone_type);

        }
    }
}
