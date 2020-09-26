using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EX_01_Product
{
    class Product
    {
        // Khai bao thuoc tinh
        String idPro;
        String namePro;
        Double price;
        Double quantity;

        public Product()
        {

        }
        public Product(string idPro, string namePro, double price, double quantity)
        {
            this.idPro = idPro;
            this.namePro = namePro;
            this.price = price;
            this.quantity = quantity;
        }

        public void input() {
            Console.Write("--Please enter id number: ");
            idPro = Console.ReadLine();

            Console.Write("--Please enter name: ");
            namePro = Console.ReadLine();

            Console.Write("--Please enter price: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("--Please enter quantity: ");
            quantity = Convert.ToDouble(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("|{0}\t|{1}\t|{2}\t|{3}", idPro, namePro, price, quantity);
        }

        public void writeFile()
        {
            FileStream fileStream = new FileStream(Directory.GetCurrentDirectory() + "test.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(idPro);
            streamWriter.WriteLine(namePro);
            streamWriter.WriteLine(price);
            streamWriter.WriteLine(quantity);



            fileStream.Close();
            streamWriter.Close();
        }
    }
}
