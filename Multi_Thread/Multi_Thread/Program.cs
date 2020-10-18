using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Multi_Thread
{
    class Program
    {
        const int MAX_CONNECTION = 10;
        const int PORT_NUMBER = 9999;
        static int _connectionsCount = 0;
        static TcpListener listener;

        static Dictionary<string, string> _data = new Dictionary<string, string>
        {
            {"1", "Minh Tin" },
            {"2", "Hua Vinh" },
            {"3", "Nhat Nam" },
            {"4", "Phuc Thinh" },
            {"5", "Anh Tu" }
        };

        static void Main(string[] args)
        {
            IPAddress address = IPAddress.Parse("127.0.0.1");
            listener = new TcpListener(address, PORT_NUMBER);
            Console.WriteLine("Waiting for connection...");
            listener.Start();

            while(_connectionsCount < MAX_CONNECTION || MAX_CONNECTION == 0)
            {
                Socket socket = listener.AcceptSocket();
                _connectionsCount++;
                Thread thread = new Thread((obj) =>
                {
                    DoWork((Socket)obj);
                });
                thread.Start(socket);
            }
        }

        static void DoWork(Socket socket)
        {
            Console.WriteLine("Connect received from: {0}", socket.RemoteEndPoint);

            try
            {
                var stream = new NetworkStream(socket);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);

                writer.WriteLine("Welcome to Student TCP Server");
                writer.WriteLine("Please enter student ID: ");

                while(true)
                {
                    string id = reader.ReadLine();
                    if (String.IsNullOrEmpty(id))
                    {
                        break;
                    }

                    if (_data.ContainsKey(id))
                    {
                        writer.WriteLine("Student's name: {0}", _data[id]);
                    } else
                    {
                        writer.WriteLine("Can't find name for student id '{0}'", id);
                    }
                }
                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.WriteLine("Client disconnected: {0}", socket.RemoteEndPoint);
            socket.Close();
        }
    }
}