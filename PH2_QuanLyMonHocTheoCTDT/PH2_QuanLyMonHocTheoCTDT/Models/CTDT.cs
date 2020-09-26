using System;
using System.Collections.Generic;
using System.Text;

namespace PH2_QuanLyMonHocTheoCTDT.Models
{
    class CTDT
    {
        public String IDMH { get; set; }
        public String MaNganh { get; set; }

        public CTDT()
        {
        }

        public CTDT(string iDMH, string maNganh)
        {
            IDMH = iDMH;
            MaNganh = maNganh;
        }
    }
}
