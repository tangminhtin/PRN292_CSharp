using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace FormServer
{
    class Program
    {
        // list client ket noi
        public static Hashtable clientsList = new Hashtable(); 
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
            TcpClient clientSocket = new TcpClient();

            serverSocket.Start();   // bat socket
            Console.WriteLine("Chat Server Started...");

            while(true)
            {
                clientSocket = serverSocket.AcceptTcpClient();

                byte[] bytesFrom = new byte[65536];
                string dataFromClient = null;
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, clientSocket.ReceiveBufferSize);
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                clientsList.Add(dataFromClient, clientSocket);
                broadcast(dataFromClient + " Joined", dataFromClient, false);
                Console.WriteLine(dataFromClient + "Joined chat room");
                handleClient client = new handleClient();
                client.startClient(clientSocket, dataFromClient); // cung cấp luồng kết nói cho client
            }
            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine("exit");
            Console.ReadLine();
        }


        public static void broadcast(String msg, String uName, bool flag)
        {
            foreach(DictionaryEntry item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                byte[] broadcastBytes = null;

                if(flag==true)
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(uName + " says: " + msg);
                } else
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(msg);
                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }

        public class handleClient
        {
            TcpClient clientSocket;
            string clNo;

            public void startClient(TcpClient clientSocket, string clNo)
            {
                this.clientSocket = clientSocket;
                this.clNo = clNo;
                Thread ctThread = new Thread(doChat);
                ctThread.Start();
            }

            public void doChat()
            {
                byte[] bytesFrom = new byte[65536];
                string dataFromClient = null;
                while (true)
                {
                    try
                    {
                        NetworkStream networkStream = clientSocket.GetStream();
                        networkStream.Read(bytesFrom, 0, clientSocket.ReceiveBufferSize);
                        dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine("From client - " + clNo, " : " + dataFromClient);

                        Program.broadcast(dataFromClient, clNo, true);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }
    }
}
