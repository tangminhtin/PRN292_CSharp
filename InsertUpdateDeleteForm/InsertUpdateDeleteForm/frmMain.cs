using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertUpdateDeleteForm
{
    public partial class frmMain : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=TANGMINHTIN;Initial Catalog=Account;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        int id = 0;


        public frmMain()
        {
            InitializeComponent();
            ShowData();
        }

        public void ShowData()
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM [User]", connection);
            adapter.Fill(dataTable);
            gvUser.DataSource = dataTable;
            connection.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
