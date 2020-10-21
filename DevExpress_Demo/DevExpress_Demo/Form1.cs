using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress_Demo
{
    public partial class t : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public t()
        {
            InitializeComponent();
            skin();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormThongTin frmThongTin = new FormThongTin();
            frmThongTin.MdiParent = this;
            frmThongTin.StartPosition = FormStartPosition.CenterScreen;
            frmThongTin.Show();
        }
        
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }
        private void t_Load(object sender, EventArgs e)
        {

        }
    }
}
