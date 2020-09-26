using System;
using System.Collections.Generic;


namespace EX_01_Product
{
    class ProMananger
    {
        List<Product> listPro = new List<Product>();

        public void input()
        {
            Console.Write("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<num; i++)
            {
                Console.WriteLine("- Product {0}:", i + 1);
                Product tmp = new Product();
                tmp.input();
                listPro.Add(tmp);
            }
        }

        public void output()
        {
            Console.WriteLine("=================== List Product ===================");
            Console.WriteLine("|ID\t|Name\t|Price\t|Quantity");
            
            foreach(Product p in listPro)
            {
                p.output();
                p.writeFile();
            }
        }

        public void showMenu()
        {
            while (true)
            {
                Console.WriteLine("----------MENU----------");
                Console.WriteLine("1. Input product.");
                Console.WriteLine("2. Show list product.");
                Console.WriteLine("0. Exit.");
                Console.Write("Please choose: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("SEE YOU AGAIN!");
                        Environment.Exit(0);
                        break;
                    case 1:
                        input();
                        break;
                    case 2:
                        output();
                        break;
                }
            }
        }

        
    }

    
}
