using PH2_QuanLyMonHocTheoCTDT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PH2_QuanLyMonHocTheoCTDT.Manager
{
    class MonHocManager
    {
        private String FILENAME = Directory.GetCurrentDirectory() + "/../../../Data/MonHoc.dat";
        List<MonHoc> listMonHoc;

        public MonHocManager()
        {
            listMonHoc = new List<MonHoc>();
            this.ReadFile();
        }

        public bool InsertMonHoc(string iDMH, string maHK, string tenMH, int soTC, int lyThuyet, int thucHanh)
        {
            bool existed = listMonHoc.Exists(x => x.IDMH.Equals(iDMH));
            if (existed)
            {
                return false;
            }
            listMonHoc.Add(new MonHoc(iDMH, maHK, tenMH, soTC, lyThuyet, thucHanh));
            WriteFile();
            return true;
        }

        public bool UpdateMonHoc(string iDMH, string maHK, string tenMH, int soTC, int lyThuyet, int thucHanh)
        {
            MonHoc monHoc = listMonHoc.Find(x => x.IDMH.Equals(iDMH));
            if (monHoc == null)
            {
                return false;
            }
            monHoc.IDMH = iDMH;
            monHoc.MaHK = maHK;
            monHoc.TenMH = tenMH;
            monHoc.SoTC = soTC;
            monHoc.LyThuyet = lyThuyet;
            monHoc.ThucHanh = thucHanh;
            WriteFile();
            return true;
        }

        public bool DeleteMonHoc(String iDMH)
        {
            MonHoc monHoc = listMonHoc.Find(x => x.IDMH.Equals(iDMH));
            if (monHoc == null)
            {
                return false;
            }
            listMonHoc.Remove(monHoc);
            WriteFile();
            return true;
        }
        public void PrintMonHoc()
        {
            Console.WriteLine("------------ List Of BacDT ------------");
            Console.WriteLine("IDMH \tMaHK \tTenMH \tSoTC \tLyThuyet \tThucHanh");
            listMonHoc.ForEach(x => Console.WriteLine(x));
        }

        public List<MonHoc> GetMonHocs()
        {
            return listMonHoc;
        }

        public void WriteFile()
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(FILENAME, FileMode.Create)))
                {
                    listMonHoc.ForEach(x =>
                    {
                        writer.Write(x.IDMH);
                        writer.Write(x.MaHK);
                        writer.Write(x.TenMH);
                        writer.Write(x.SoTC);
                        writer.Write(x.LyThuyet);
                        writer.Write(x.ThucHanh);
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
            }
        }

        public void ReadFile()
        {
            try
            {
                if (File.Exists(FILENAME))
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(FILENAME, FileMode.Open)))
                    {
                        while ((int)reader.PeekChar() != -1)
                        {
                            String iDMH = reader.ReadString();
                            String maHK = reader.ReadString();
                            String tenMH = reader.ReadString();
                            int soTC = reader.ReadInt32();
                            int lyThuyet = reader.ReadInt32();
                            int thucHanh = reader.ReadInt32();
                            listMonHoc.Add(new MonHoc(iDMH, maHK, tenMH, soTC, lyThuyet, thucHanh));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
            }
        }
    }
}
