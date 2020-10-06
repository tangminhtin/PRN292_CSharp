using DemoCodePhanHe.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoCodePhanHe.Manager
{
    public class HocKyManager
    {
        public String fileName;
        List<HocKy> hocKys = new List<HocKy>();

        public HocKyManager()
        {
            this.fileName = "../../../Data/txtHocKy.txt";
            readData();
        }
        public Boolean insertHocKy(String maHK, String MaNH, String HK)
        {
            HocKy hocKy = hocKys.Find(x => x.getMaHK().Equals(maHK));

            if (hocKy != null)
            {
                return false;
            }
            hocKy = new HocKy(maHK, MaNH, HK);
            hocKys.Add(hocKy);

            return true;
        }

        public Boolean updateHocKy(String maHK, String maNH, String HK)
        {

            HocKy hocKy = hocKys.Find(x => x.getMaHK().Equals(maHK));
            if (hocKy != null)
            {
                return false;
            }
            hocKy.setMaNH(maNH);
            hocKy.setHK(HK);

            return true;
        }
        List<HocKy> getAll()
        {
            return hocKys;
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

            String maHK;
            maHK = rd.ReadLine();
            while (maHK != null)
            {
                HocKy hocKy = new HocKy();
                hocKy.setMaHK(maHK);
                hocKy.setMaNH(rd.ReadLine());
                hocKy.setHK(rd.ReadLine());
                hocKys.Add(hocKy);

                maHK = rd.ReadLine();
            }

            return true;
        }
        public Boolean writeData()
        {
            StreamWriter wt = new StreamWriter(this.fileName);

            String tmp = "";
            hocKys.ForEach(x =>
            {
                tmp += x.getMaHK() + "\n";
                tmp += x.getMaNH() + "\n";
                tmp += x.getHK() + "\n";
            });

            wt.Write(tmp);
            wt.Close();

            return true;
        }
    }
}

