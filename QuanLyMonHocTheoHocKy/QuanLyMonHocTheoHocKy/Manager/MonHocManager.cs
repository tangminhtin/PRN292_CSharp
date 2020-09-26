using QuanLyMonHocTheoHocKy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyMonHocTheoHocKy.Manager
{
    class MonHocManager
    {
        private String filename;
        List<MonHoc> monHocList = new List<MonHoc>();

        public MonHocManager()
        {
            this.filename = "../../../Data/txtMonHoc.txt";
        }
        public Boolean insertMonHoc(string iDMH, string maHK, string tenHK, int soTC, int lyThuyet, int thucHanh)
        {
            MonHoc monHoc = monHocList.Find(x => x.getIDMH().Equals(iDMH));
            if(monHoc != null)
            {
                return false;
            }
            return true;
        }

        public Boolean updateMonHoc(string iDMH, string maHK, string tenHK, int soTC, int lyThuyet, int thucHanh)
        {

            return;
        }

        public List<MonHoc> getMonHocList()
        {
            return monHocList;
        }
        public Boolean readData()
        {
            StreamReader rd;
            if(!File.Exists(filename))
            {
                FileStream fs = File.Create(filename);
                rd = new StreamReader(fs, Encoding.UTF8);
            } else
            {
                rd = new StreamReader(this.filename);
            }

            String IDMH = rd.ReadLine();
            while(IDMH !=null)
            {
                MonHoc monHoc = new MonHoc();
                monHoc.setIDMH(IDMH);
                monHoc.setMaHK(rd.ReadLine());
                monHoc.setTenHK(rd.ReadLine());
                monHoc.setThucHanh(Convert.ToInt32(rd.ReadLine()));
                monHoc.setSoTC(Convert.ToInt32(rd.ReadLine()));
                monHoc.setLyThuyet(Convert.ToInt32(rd.ReadLine()));
                monHocList.Add(monHoc);
                IDMH = rd.ReadLine();
            }
            return true;
        }
        public Boolean writeData()
        {
            String tmp = "";
            StreamWriter streamWriter = new StreamWriter(this.filename);
            monHocList.ForEach(x =>
            {
                tmp += x.getIDMH() + "\t";
                tmp += x.getMaHK() + "\t";
                tmp += x.getTenHK() + "\t";
                tmp += x.getSoTC() + "\t";
                tmp += x.getLyThuyet() + "\t";
                tmp += x.getThucHanh() + "\t";
            });

            streamWriter.Close();

            return true;
        }

    }
}
