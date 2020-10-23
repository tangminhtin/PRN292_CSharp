using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress_Demo
{
    public partial class FormThongTin : DevExpress.XtraEditors.XtraForm
    {
        dbDemoEntities db = new dbDemoEntities();
        bool add = false;
        public FormThongTin()
        {
            InitializeComponent();
        }

        private void FormThongTin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDemoDataSet.tbDemo' table. You can move, or remove it, as needed.
            this.tbDemoTableAdapter.Fill(this.dbDemoDataSet.tbDemo);
            tbDemoBindingSource.DataSource = db.tbDemoes.ToList();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add = true;
            tbDemoBindingSource.AddNew();
            txtName.Focus();
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (add)
            {
                tbDemo tb = new tbDemo();
                tb.uName = txtName.Text.Trim();
                tb.DiaChi = txtDiaChi.Text.Trim();
                tb.SoDienThoai = txtSoDienThoai.Text.Trim();
                db.tbDemoes.Add(tb);
                db.SaveChanges();
                add = false;
            } else
            {
                int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
                tbDemo tb = db.tbDemoes.Find(id);
                tb.uName = txtName.Text.Trim();
                tb.DiaChi = txtDiaChi.Text.Trim();
                tb.SoDienThoai = txtSoDienThoai.Text.Trim();
                db.SaveChanges();
            }
        }
    }
}