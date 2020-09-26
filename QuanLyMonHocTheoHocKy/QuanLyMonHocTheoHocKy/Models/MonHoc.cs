using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyMonHocTheoHocKy.Models
{
    class MonHoc
    {
        private String IDMH;
        private String MaHK;
        private String TenHK;
        private int SoTC;
        private int LyThuyet;
        private int ThucHanh;

        public MonHoc()
        {

        }
        public MonHoc(string iDMH, string maHK, string tenHK, int soTC, int lyThuyet, int thucHanh)
        {
            IDMH = iDMH;
            MaHK = maHK;
            TenHK = tenHK;
            SoTC = soTC;
            LyThuyet = lyThuyet;
            ThucHanh = thucHanh;
        }

        public int getThucHanh()
        {
            return this.ThucHanh;
        }
        public void setThucHanh(int ThucHanh)
        {
            this.ThucHanh = ThucHanh;
        }

        public String getIDMH()
        {
            return this.IDMH;
        }
        public void setIDMH(string IDMH)
        {
            this.IDMH = IDMH;
        }

        public String getMaHK()
        {
            return this.MaHK;
        }
        public void setMaHK(String MaHK)
        {
            this.MaHK = MaHK;
        }

        public String getTenHK()
        {
            return this.TenHK;
        }
        public void setTenHK(String TenHK)
        {
            this.TenHK = TenHK;
        }

        public int getSoTC()
        {
            return this.SoTC;
        }
        public void setSoTC(int SoTC)
        {
            this.SoTC = SoTC;
        }
        public int getLyThuyet()
        {
            return this.LyThuyet;
        }
        public void setLyThuyet(int LyThuyet)
        {
            this.LyThuyet = LyThuyet;
        }
    }
}
