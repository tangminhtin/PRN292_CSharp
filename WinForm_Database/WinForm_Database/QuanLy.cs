using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Database
{
    public partial class QuanLy : Form
    {
        SqlConnection conn;
        public QuanLy()
        {
            InitializeComponent();
            String connectionString = ConfigurationManager.ConnectionStrings["PH1"].ConnectionString.ToString();
            conn = new SqlConnection(connectionString);
            show();
        }

        public void show()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM MonHoc", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            gvMonHoc.DataSource = dt;
            gvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvMonHoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void getHocKy()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HocKy", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            cbHocKy.ValueMember = "Ma_HK";
            cbHocKy.DisplayMember = "Hoc Ky E";

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO MonHoc VALUES (@IDMH, @Ma_HK, @TenMH, @SoTC, @LyThuyet, @ThucHanh", conn);
            cmd.Parameters.AddWithValue("@IDMH", txtIDMH.Text);
            cmd.Parameters.AddWithValue("@Ma_HK", cbHocKy.SelectedValue);
            cmd.Parameters.AddWithValue("@TenMH", txtMH.Text);
            cmd.Parameters.AddWithValue("@SoTC", numNumber.Value);
            cmd.Parameters.AddWithValue("@LyThuyet", cbLyThuyet.CheckState == CheckState.Checked ? 1 : 0);
            cmd.Parameters.AddWithValue("@ThucHanh", cbThucHanh.CheckState == CheckState.Checked ? 1 : 0);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert success");
            show();
        }
    }
}
