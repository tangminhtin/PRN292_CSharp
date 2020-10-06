using System;
using System.IO;
using System.Net.Sockets;

namespace Client
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("127.0.0.1", 1999);

                Stream stream = client.GetStream();
                Console.WriteLine("Connected to server");

                while(true)
                {
                    Console.Write("Enter a: ");
                    string a = Console.ReadLine();

                    Console.Write("Enter b: ");
                    string b = Console.ReadLine();
                    
                    Console.Write("Enter c: ");
                    string c = Console.ReadLine();

                    var reader = new StreamReader(stream);
                    var writer = new StreamWriter(stream);

                    writer.AutoFlush = true;
                    writer.WriteLine($"{a} {b} {c}");

                    string read = reader.ReadLine();
                    Console.WriteLine(read);

                    Console.WriteLine("Do you want to exit? (Y/N)");
                    string choice = Console.ReadLine();

                    writer.WriteLine(choice);
                    read = reader.ReadLine();

                    if(read.ToLower().Equals("bye"))
                    {
                        Console.WriteLine("EXITED");
                        break;
                    }
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
