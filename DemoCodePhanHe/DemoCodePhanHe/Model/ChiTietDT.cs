using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCodePhanHe.Model
{
    class ChiTietDT
    {
        private String IDMH;
        private String MaNganh;

        public ChiTietDT()
        {

        }
        public ChiTietDT(string iDMH, string maNganh)
        {
            IDMH = iDMH;
            MaNganh = maNganh;
        }

        public void setIDMH(String IDMH)
        {
            this.IDMH = IDMH;
        }

        public String getIDMH()
        {
            return IDMH;
        }

        public void setMaNganh(String MaNganh)
        {
            this.MaNganh = MaNganh;
        }

        public String getMaNganh()
        {
            return MaNganh;
        }
    }
}
