using System;
using System.Collections.Generic;
using System.Text;

namespace PH2_QuanLyMonHocTheoCTDT.Models
{
    class MonHoc
    {
        public String IDMH { get; set; }
        public String MaHK { get; set; }
        public String TenMH { get; set; }
        public int SoTC { get; set; }
        public int LyThuyet { get; set; }
        public int ThucHanh { get; set; }

        public MonHoc()
        {
        }

        public MonHoc(string iDMH, string maHK, string tenMH, int soTC, int lyThuyet, int thucHanh)
        {
            IDMH = iDMH;
            MaHK = maHK;
            TenMH = tenMH;
            SoTC = soTC;
            LyThuyet = lyThuyet;
            ThucHanh = thucHanh;
        }

        public override string ToString()
        {
            return String.Format("{0} \t{1} \t{2} \t{3} \t{4} \t{5}",
                IDMH, MaHK, TenMH, SoTC, LyThuyet, ThucHanh);
        }
    }
}
