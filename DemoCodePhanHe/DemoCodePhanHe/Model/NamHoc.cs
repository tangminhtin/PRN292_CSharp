using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCodePhanHe.Model
{
    class NamHoc
    {
        public String MaNH { get; set; }
        public String TenNH { get; set; }

        public NamHoc()
        {
        }

        public NamHoc(string maNH, string tenNH)
        {
            MaNH = maNH;
            TenNH = tenNH;
        }
    }
}
