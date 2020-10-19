using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MultiThreadSocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(8888);
            TcpClient client = default(TcpClient);
            int counter = 0;

            listener.Start();
            Console.WriteLine(" >> Server Started");

            counter = 0;
            while (true)
            {
                counter++;
                client = listener.AcceptTcpClient();
                Console.WriteLine(" >> Client No: " + Convert.ToString(counter));
                HandleClient handleClient = new HandleClient();
                handleClient.StartClient(client, Convert.ToString(counter));
            }

            client.Close();
            listener.Stop();
            Console.WriteLine(" >> exit");
            Console.ReadLine();
        }
    }

    public class HandleClient
    {
        TcpClient client;
        string counter;

        public void StartClient(TcpClient client, string counter)
        {
            this.client = client;
            this.counter = counter;

            Thread thread = new Thread(DoChat);
            thread.Start();
        }

        private void DoChat()
        {
            int reqCount = 0;
            byte[] bytesFrom = new byte[655536];
            string dataClient = null;

            string resCount = null;
            byte[] sendBytes = null;
            string dataServer = null;
           
            while (true)
            {
                try
                {
                    reqCount++;
                    NetworkStream networkStream = client.GetStream();
                    networkStream.Read(bytesFrom, 0, (int)client.ReceiveBufferSize);

                    dataClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataClient = dataClient.Substring(0, dataClient.IndexOf("$"));
                    Console.WriteLine(" >> From Client " + counter + ": " + dataClient);

                    dataServer = "Server to client (" + counter + ")" + resCount;
                    sendBytes = Encoding.ASCII.GetBytes(dataServer);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + dataServer);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }
    }
}
