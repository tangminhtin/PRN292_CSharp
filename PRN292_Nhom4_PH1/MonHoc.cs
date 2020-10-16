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

namespace PRN292_Nhom4_PH1
{
    public partial class MonHoc : Form
    {
        SqlConnection conn;
        public MonHoc()
        {
            InitializeComponent();
            String conString = ConfigurationManager.ConnectionStrings["PH1"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            show();
            getHocKy();
        }

        public void show()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from MonHoc", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            conn.Close();
            dtMonHoc.DataSource = table;
            dtMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtMonHoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void getHocKy()
        {
            conn.Open();// mo connection
            SqlCommand cmd = new SqlCommand("Select * from HocKy", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            conn.Close();
            cbbHK.DataSource = table;
            cbbHK.ValueMember = "Ma_HK";
            cbbHK.DisplayMember = "HocKy";

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into MonHoc values" +
                "(@IDMH, @Ma_HK, @TenMH, @SoTC, @Lythuyet, @ThucHanh)", conn);
            cmd.Parameters.AddWithValue("@IDMH", txtIDMH.Text);
            cmd.Parameters.AddWithValue("@Ma_HK", cbbHK.SelectedValue);
            cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text);
            cmd.Parameters.AddWithValue("@SoTC", numberUDSOTC.Value);
            cmd.Parameters.AddWithValue("@LyThuyet", checkbLythuyet.CheckState==CheckState.Checked ? 1 : 0);
            cmd.Parameters.AddWithValue("@ThucHanh", checkbThucHanh.CheckState == CheckState.Checked ? 1 : 0);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert success ");
            show();
        }

        private void dtMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDMH.Text = dtMonHoc.Rows[e.RowIndex].Cells["IDMH"].Value.ToString();
                cbbHK.Text = dtMonHoc.Rows[e.RowIndex].Cells["Ma_HK"].Value.ToString();
                txtTenMH.Text = dtMonHoc.Rows[e.RowIndex].Cells["TenMH"].Value.ToString();
                numberUDSOTC.Value = Convert.ToInt32(dtMonHoc.Rows[e.RowIndex].Cells["SoTC"].Value.ToString());

                int LT = Convert.ToInt32(dtMonHoc.Rows[e.RowIndex].Cells["LyThuyet"].Value.ToString());
                checkbLythuyet.CheckState = LT == 1 ? CheckState.Checked : CheckState.Unchecked;

                int TH = Convert.ToInt32(dtMonHoc.Rows[e.RowIndex].Cells["ThucHanh"].Value.ToString());
                checkbThucHanh.CheckState = TH == 1 ? CheckState.Checked : CheckState.Unchecked;
            }
            catch (Exception)
            {

                MessageBox.Show("Loi roi ciu");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDMH.Text == "")
            {
                MessageBox.Show("Chon du lieu truoc khi cap nhat");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE MonHoc set Ma_HK=@mahk, " +
                    "TenMH=@ten, SoTC=@tc, LyThuyet=@lt, ThucHanh=@th WHERE IDMH=@id", conn);
                cmd.Parameters.AddWithValue("@id", txtIDMH.Text);
                cmd.Parameters.AddWithValue("@mahk", cbbHK.SelectedValue);
                cmd.Parameters.AddWithValue("@ten", txtTenMH.Text);
                cmd.Parameters.AddWithValue("@tc", numberUDSOTC.Value);
                cmd.Parameters.AddWithValue("@lt", checkbLythuyet.CheckState == CheckState.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@th", checkbThucHanh.CheckState == CheckState.Checked ? 1 : 0);
                
                int count = cmd.ExecuteNonQuery();
                if (count > 0) MessageBox.Show("Success");
                else MessageBox.Show("Fail");
                conn.Close();
                show();
                
                //clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIDMH.Text == "") MessageBox.Show("Chon du lieu truoc");
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM MonHoc WHERE IDMH=@IDMH", conn);
                cmd.Parameters.AddWithValue("@IDMH", txtIDMH.Text);
                int count = cmd.ExecuteNonQuery();
                conn.Close();

                if (count > 0) MessageBox.Show("Success");
                else MessageBox.Show("Fail");
                show();
                //clear();
            }
        }
    }
}
