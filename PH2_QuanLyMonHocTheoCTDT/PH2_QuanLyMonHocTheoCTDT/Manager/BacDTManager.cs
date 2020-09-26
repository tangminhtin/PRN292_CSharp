using PH2_QuanLyMonHocTheoCTDT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PH2_QuanLyMonHocTheoCTDT.Manager
{
    class BacDTManager
    {
        private const String FILENAME = "./../../BacDT.dat";
        private List<BacDT> listBacDT;

        public BacDTManager()
        {
            listBacDT = new List<BacDT>();
            this.ReadFile();
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("================= MENU =================");
                Console.WriteLine("1. List BacDT");
                Console.WriteLine("2. Insert");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("0. Exit");
                Console.Write("Your choice >> ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        PrintListBacDT();
                        break;
                    case 2:
                        Console.Write("IDBDT: ");
                        String iBDT = Console.ReadLine();
                        Console.Write("TenBacDT: ");
                        String tenBacDT = Console.ReadLine();

                        InsertBacDT(iBDT, tenBacDT);
                        break;
                    case 3:
                        Console.Write("IDBDT: ");
                        iBDT = Console.ReadLine();
                        Console.Write("TenBacDT: ");
                        tenBacDT = Console.ReadLine();
                        UpdateBacDT(iBDT, tenBacDT);
                        break;
                    case 4:
                        Console.Write("IDBDT: ");
                        iBDT = Console.ReadLine();
                        DeleteBacDT(iBDT);
                        break;
                }
            }
        }

        public List<BacDT> GetBacDTs()
        {
            return listBacDT;
        }

        public bool InsertBacDT(String IDBDT, String TenBacDT)
        {
            bool existed = listBacDT.Exists(x => x.IDBDT.Equals(IDBDT));
            if (existed)
            {
                return false;
            }

            listBacDT.Add(new BacDT(IDBDT, TenBacDT));
            WriteFile();
            return true;
        }

        public bool UpdateBacDT(String IDBDT, String TenBacDT)
        {
            BacDT bacDT = listBacDT.Find(x => x.IDBDT.Equals(IDBDT));
            if (bacDT == null)
            {
                return false;
            }
            bacDT.TenBacDT = TenBacDT;
            WriteFile();
            return true;
        }

        public bool DeleteBacDT(String IDBDT)
        {
            BacDT bacDT = listBacDT.Find(x => x.IDBDT.Equals(IDBDT));
            if (bacDT == null)
            {
                return false;
            }
            listBacDT.Remove(bacDT);
            WriteFile();
            return true;
        }

        public void PrintListBacDT()
        {
            Console.WriteLine("------------ List Of BacDT ------------");
            Console.WriteLine("ID \tTenBacDT");
            listBacDT.ForEach(x => Console.WriteLine(x));
        }

        private void WriteFile()
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(FILENAME, FileMode.Create)))
                {
                    listBacDT.ForEach(x =>
                    {
                        writer.Write(x.IDBDT);
                        writer.Write(x.TenBacDT);
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
                    using (BinaryReader reader = new BinaryReader(File.Open(FILENAME, FileMode.Open)))
                    {
                        while ((int)reader.PeekChar() != -1)
                        {
                            String IDBDT = reader.ReadString();
                            String TenBacDT = reader.ReadString();
                            listBacDT.Add(new BacDT(IDBDT, TenBacDT));
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
