using DemoCodePhanHe.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoCodePhanHe.Manager
{
    class NamHocManager
    {
        public String fileName;
        List<NamHoc> namHocs = new List<NamHoc>();

        public NamHocManager()
        {
            this.fileName = "../../../Data/txtMonHoc.txt";
        }
        public Boolean insertNamHoc(String maNH, String tenNH)
        {
            NamHoc namHoc = namHocs.Find(x => x.MaNH.Equals(maNH));

            if (namHoc != null)
            {
                return false;
            }
            namHoc = new NamHoc(maNH, tenNH);
            namHocs.Add(namHoc);

            return true;
        }

        public Boolean updateNamHoc(String maNH, String tenNH)
        {

            NamHoc namHoc = namHocs.Find(x => x.MaNH.Equals(maNH));
            if (namHoc != null)
            {
                return false;
            }
            namHoc.MaNH = maNH;
            namHoc.TenNH = tenNH;

            return true;
        }
        List<NamHoc> getAll()
        {
            return namHocs;
        }
        public Boolean readData()
        {

            StreamReader rd;
            if (!File.Exists(fileName))
            {
                FileStream fs = File.Create(fileName);
                rd = new StreamReader(fs, Encoding.UTF8);
            }
            else
            {
                rd = new StreamReader(this.fileName);
            }

            String idMH;
            idMH = rd.ReadLine();
            while (idMH != null)
            {
                NamHoc namHoc = new NamHoc();
                namHoc.MaNH = idMH;
                namHoc.TenNH = rd.ReadLine();
                namHocs.Add(namHoc);

                idMH = rd.ReadLine();
            }

            return true;
        }
        public Boolean writeData()
        {
            StreamWriter wt = new StreamWriter(this.fileName);

            String tmp = "";
            namHocs.ForEach(x =>
            {
                tmp += x.MaNH + "\n";
                tmp += x.TenNH + "\n";
            });

            wt.Write(tmp);
            wt.Close();

            return true;
        }
    }
}
 