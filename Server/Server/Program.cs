using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        public void StartConnection()
        {
            try
            {
                // create tcp protocol object and passing ip address and port
                TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 1999);

                // start tcp protocol
                listener.Start();

                // display info of port
                Console.WriteLine("Server started on " + listener.LocalEndpoint);
                Console.WriteLine("Waiting for a connection");

                // this method will pause until some client get connected and return socket
                Socket socket = listener.AcceptSocket();

                // display info-port of user
                Console.WriteLine("Connection received from " + socket.RemoteEndPoint);

                // create stream to store data
                NetworkStream stream = new NetworkStream(socket);

                // reader to read data from client
                StreamReader reader = new StreamReader(stream);

                // writer to write data and send to client
                StreamWriter writer = new StreamWriter(stream);

                // flush when cache already fully
                writer.AutoFlush = true;
                while (true)
                {
                    // read data from client
                    string str = reader.ReadLine();

                    // if == yes or y will be exited
                    if (str.ToLower().Equals("yes") || str.ToLower().Equals("y"))
                    {
                        writer.WriteLine("bye");
                        Console.WriteLine("EXITED");
                        break;
                    }

                    // show message from client
                    Console.WriteLine("Client: {0}", str);

                    // check string is containing any character
                    if (!str.Any(char.IsLetter))
                    {
                        string[] listNum = str.Split(" ");

                        // split and assign to a b c
                        int a = Int32.Parse(listNum[0]);
                        int b = Int32.Parse(listNum[1]);
                        int c = Int32.Parse(listNum[2]);

                        // formula can bac 2;
                        str = PhuongTrinhBac2(a, b, c);
                    }

                    // send it to client
                    writer.WriteLine("Client: {0}", str);
                }

                // stop all
                stream.Close();
                socket.Close();
                listener.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }

        private string PhuongTrinhBac2(int a, int b, int c)
        {
            if (a != 0)
            {
                double d, x1, x2;

                d = Math.Pow(b, 2) - 4 * a * c;

                if (d == 0)
                {
                    x1 = -b / (2.0 * a);
                    x2 = x1;

                    return $"Nghiem duy nhat cua phuong trinh la {x1}";
                }
                else if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    return $"Nghiem thu nhat: {x1} va Nghiem thu 2: {x2}";
                }
                return "Phuong trinh khong co nghiem";
            }
            else
            {
                if (b == 0 && c == 0)
                {
                    return "Phuong trinh vo so nghiem";
                }
                else if (b == 0 && c != 0)
                {
                    return "Phuong trinh vo nghiem";
                }
                else
                {
                    return $"Phuong trinh co 1 nghiem {-c / b}";
                }
            }
        }
        static void Main(string[] args)
        {
            new Program().StartConnection();
        }
    }


}
