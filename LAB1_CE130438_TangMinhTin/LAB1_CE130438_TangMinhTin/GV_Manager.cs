using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1_CE130438_TangMinhTin
{
    class GV_Manager
    {
        private String FILENAME = Directory.GetCurrentDirectory() + "/../../../giangvien.txt";
        private List<GiangVien> giangVienList;

        public GV_Manager()
        {
            this.giangVienList = new List<GiangVien>();
            this.ReadFile();
        }

        public Boolean Add()
        {
            Console.Write("Nhap so luong: ");
            int soLuong = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < soLuong; i++)
            {
                GiangVien gv = new GiangVien();
                gv.Input();
                giangVienList.Add(gv);
            }

            return true;
        }

        public Boolean Show()
        {
            Console.WriteLine("---- Danh Sach Giang Vien ----");
            Console.WriteLine("ID \tName \tNam Sinh \t\tTrinh Do \tHe So Luong");
            giangVienList.ForEach(x => x.Output());
            return true;
        }
        public Boolean Menu()
        {
            while (true)
            {
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        this.Add();
                        break;
                    case 2:
                        this.Show();
                        break;
                    case 3:
                        this.WriteFile();
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private void WriteFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(File.Open(FILENAME, FileMode.Create)))
                {
                    giangVienList.ForEach(x =>
                    {
                        writer.Write(x.Id + "\n");
                        writer.Write(x.Name + "\n");
                        writer.Write(x.NamSinh + "\n");
                        writer.Write(x.TrinhDo + "\n");
                        writer.Write(x.HeSoLuong + "\n");
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
            }
        }


        private void ReadFile()
        {
            try
            {
                if (File.Exists(FILENAME))
                {
                    using (StreamReader reader = new StreamReader(File.Open(FILENAME, FileMode.Open)))
                    {
                        while (reader != null)
                        {
                            GiangVien gv = new GiangVien();
                            gv.Id = reader.ReadLine();
                            gv.Name = reader.ReadLine();
                            gv.NamSinh = DateTime.Parse(reader.ReadLine());
                            gv.TrinhDo = reader.ReadLine();
                            gv.HeSoLuong = Convert.ToDouble(reader.ReadLine());
                            giangVienList.Add(gv);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message + "\n Cannot read from file.");
            }
        }

    }
}
