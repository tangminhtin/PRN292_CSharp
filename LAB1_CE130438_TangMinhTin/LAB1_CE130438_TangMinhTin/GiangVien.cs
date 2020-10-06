using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1_CE130438_TangMinhTin
{
    class GiangVien
    {
        public string Id { get; set; }
        public String Name { get; set; }
        public DateTime NamSinh { get; set; }
        public String TrinhDo { get; set; }
        public double HeSoLuong { get; set; }

        private string a;
        public GiangVien()
        {
        }

        public GiangVien(string id, string name, DateTime namSinh, string trinhDo, double heSoLuong)
        {
            Id = id;
            Name = name;
            NamSinh = namSinh;
            TrinhDo = trinhDo;
            HeSoLuong = heSoLuong;
        }

        public void Input()
        {
            Console.WriteLine("---- input ----");
            Console.Write("Enter id: ");
            this.Id = Console.ReadLine();
            
            Console.Write("Enter name: ");
            this.Name = Console.ReadLine(); 
            
            Console.Write("Enter nam sinh: ");
            this.NamSinh = DateTime.Parse(Console.ReadLine()); 
            
            Console.Write("Enter trinh do: ");
            this.TrinhDo = Console.ReadLine(); 
            
            Console.Write("Enter he so luong: ");
            this.HeSoLuong = Convert.ToDouble(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"{Id} \t{Name} \t{NamSinh} \t{TrinhDo} \t{HeSoLuong}"); ;
        }
    }
}
