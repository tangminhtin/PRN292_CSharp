using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;

/// <summary>
/// CE130438 Tang Minh Tin
/// </summary>
namespace LAB2_CE130438_TangMinhTin
{
    class Program
    {
        public void StartConnection()
        {
            try
            {
                //Tao cong de cho client nhan
                TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 1999);

                //khoi dong cong
                listener.Start();
                //thong bao len console
                Console.WriteLine("Server started on " + listener.LocalEndpoint);
                Console.WriteLine("Waiting for a connection");
                //Accepts  a pending connection request
                Socket socket = listener.AcceptSocket();

                Console.WriteLine("Connection received from " + socket.RemoteEndPoint);

                //chuyen socket vao NetworkStream
                NetworkStream stream = new NetworkStream(socket);
                //Tao streamReader de truyen networkStream vao
                StreamReader sr = new StreamReader(stream);
                //Tao streamWriter de truyen networkStream vao
                StreamWriter sw = new StreamWriter(stream);
                sw.AutoFlush = true;
                //Neu nguoi dung nhap Y thi chuong trinh ket thuc va nguoc lai
                while (true)
                {
                    string str = sr.ReadLine();

                    if (str.ToLower() == "yes" || str.ToLower() == "y")
                    {

                        sw.WriteLine("bye");
                        Console.WriteLine("EXITED");
                        break;
                    }

                    //ghi lai so client da nhap
                    Console.WriteLine("Client: " + str);

                    //Ham nhan tham so ma client da nhap
                    if (!str.Any(char.IsLetter))
                    {
                        string[] listNum = str.Split(" ");

                        int a = Int32.Parse(listNum[0]);

                        str = ChuyenString(a);
                    }


                    sw.WriteLine("Client: " + str);

                }
                //dong stream
                stream.Close();
                //dong socket
                socket.Close();
                //dong cong lai
                listener.Stop();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();

        }
        /**
         * Ham chuyen doi so
         * */
        private string ChuyenString(int a)
        {
            //try catch neu nguoi dung nhap khac dieu kien tuc la khac so nguyen hoac so le
            try
            {
                //Khi a duoc vao thi se cho vao if, else if
                //Neu thoa dieu kien nao thi rerun tuong ung
                if (a == 0)
                {
                    return $"Khong";
                }
                else if (a == 1)
                {
                    return $"Mot";
                }
                else if (a == 2)
                {
                    return $"Hai";
                }
                else if (a == 3)
                {
                    return $"Ba";
                }
                else if (a == 4)
                {
                    return $"Bon";
                }
                else if (a == 5)
                {
                    return $"Nam";
                }
                else if (a == 6)
                {
                    return $"Sau";
                }
                else if (a == 7)
                {
                    return $"Bay";
                }
                else if (a == 8)
                {
                    return $"Tam";
                }
                else if (a == 9)
                {
                    return $"Chin";
                }
                else
                    throw new Exception();
            }
            catch (Exception e)
            {
                return $"Nhap so nguyen";
            }

        }
        //goi ham StartConnection 
        static void Main(string[] args)
        {
            new Program().StartConnection();
        }
    }
}
