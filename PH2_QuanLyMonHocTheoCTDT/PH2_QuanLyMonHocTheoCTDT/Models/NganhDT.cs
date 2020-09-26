using System;
using System.Collections.Generic;
using System.Text;

namespace PH2_QuanLyMonHocTheoCTDT.Models
{
    class NganhDT
    {
        public String MaNghanh { get; set; }
        public String IDBDT { get; set; }
        public String TenNganh { get; set; }

        public NganhDT()
        {
        }

        public NganhDT(string maNghanh, string iDBDT, string tenNganh)
        {
            MaNghanh = maNghanh;
            IDBDT = iDBDT;
            TenNganh = tenNganh;
        }
    }
}
