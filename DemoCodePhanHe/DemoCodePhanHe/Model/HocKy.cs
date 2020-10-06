using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCodePhanHe.Model
{
    class HocKy
    {
        private String MaHK;
        private String MaNH;
        private String HK;

        public HocKy()
        {

        }
        public HocKy(string maHK, string maNH, string hK)
        {
            MaHK = maHK;
            MaNH = maNH;
            HK = hK;
        }

        public void setMaHK(String MaHK)
        {
            this.MaHK = MaHK;
        }

        public String getMaHK()
        {
            return MaHK;
        }
        public void setMaNH(String MaNH)
        {
            this.MaHK = MaNH;
        }

        public String getMaNH()
        {
            return MaNH;
        }
        public void setHK(String HK)
        {
            this.HK = HK;
        }

        public String getHK()
        {
            return HK;
        }
    }
}
