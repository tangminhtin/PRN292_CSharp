using System;
using System.IO;
using System.Net.Sockets;
/// <summary>
/// CE130438 Tang Minh Tin
/// </summary>
namespace LAB2_CE130438_TangMinhTin_Client
{
    class Program
    {
        public void StartConnection()
        {

            try
            {
                //Tao mot client
                TcpClient client = new TcpClient();
                client.Connect("127.0.0.1", 1999);
                Stream stream = client.GetStream();
                Console.WriteLine("Connected to server");

                while (true)
                {
                    // Nhap so nguyen
                    Console.Write("Nhap vao so nguyen: ");
                    string a = Console.ReadLine();
                    Boolean check = IsNumber(a);
                    // Kiem tra check tra ve false
                    if (check != false)
                    {   //tao StreamReader
                        var sr = new StreamReader(stream);
                        //tao StreamWriter
                        var sw = new StreamWriter(stream);

                        sw.AutoFlush = true;
                        //Chuyen so vua nhap a vao StreamWriter
                        sw.WriteLine(string.Format("{0} ", a));

                        string read = sr.ReadLine();
                        //Doc so vua nhap
                        Console.WriteLine(read);
                        //Thong bao nguoi dung co muon thoat, neu y thi se thoat ctrinh, va nguoc lai
                        Console.WriteLine("Ban co muon thoat ? (Y/N)");
                        string choice = Console.ReadLine();
                        //ghi lai lua chon
                        sw.WriteLine(choice);

                        read = sr.ReadLine();
                        //doc lua chon
                        //neu y thi se hoat
                        if (read.ToLower() == "bye")
                        {
                            Console.WriteLine("EXITED");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Loi nhap vao so nguyen");
                    }

                }
                stream.Close();
                client.Close();


            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }

            Console.Read();


        }
        //Ham check nguoi nhap co phai la so hay khong
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                //isDigit la check co phai la so le hay k
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            new Program().StartConnection();
        }
    }
}
