using DemoCodePhanHe.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoCodePhanHe.Manager
{
    class ChiTietDTManager
    {
        public String fileName;
        List<ChiTietDT> chiTietDTs = new List<ChiTietDT>();

        public ChiTietDTManager()
        {
            this.fileName = "../../../Data/txtChiTietDT.txt";
        }
        public Boolean insertChiTietDT(String iDMH, String maNganh)
        {
            ChiTietDT chiTietDT = chiTietDTs.Find(x => x.getIDMH().Equals(iDMH));

            if (chiTietDT != null)
            {
                return false;
            }
            chiTietDT = new ChiTietDT(iDMH, maNganh);
            chiTietDTs.Add(chiTietDT);

            return true;
        }

        public Boolean updateChiTietDT(String iDMH, String maNganh)
        {

            ChiTietDT chiTietDT = chiTietDTs.Find(x => x.getIDMH().Equals(iDMH));
            if (chiTietDT != null)
            {
                return false;
            }
            chiTietDT.setIDMH(iDMH);
            chiTietDT.setMaNganh(maNganh);

            return true;
        }
        List<ChiTietDT> getAll()
        {
            return chiTietDTs;
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

            //String idMH, ma_HK, tenMH;
            //int soTC, lyThuyet, thucHanh;

            String idMH;
            idMH = rd.ReadLine();
            while (idMH != null)
            {
                ChiTietDT chiTietDT = new ChiTietDT();
                chiTietDT.setIDMH(idMH);
                chiTietDT.setMaNganh(rd.ReadLine());
                chiTietDTs.Add(chiTietDT);

                idMH = rd.ReadLine();
            }

            return true;
        }
        public Boolean writeData()
        {
            StreamWriter wt = new StreamWriter(this.fileName);

            String tmp = "";
            chiTietDTs.ForEach(x =>
            {
                tmp += x.getIDMH() + "\n";
                tmp += x.getMaNganh() + "\n";
            });

            wt.Write(tmp);
            wt.Close();

            return true;
        }
    }
}

