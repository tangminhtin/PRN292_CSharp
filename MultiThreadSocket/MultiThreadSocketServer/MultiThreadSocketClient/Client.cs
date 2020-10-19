using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadSocketClient
{
    public partial class Client : Form
    {
        System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            msg("Client Started");
            client.Connect("127.0.0.1", 8888);
            lblTitle.Text = "Client Socket Program - Server Connected ...";
        }

        public void msg(string msg)
        {
            txtChat.Text += Environment.NewLine + " >> " + msg;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream networkStream = client.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Message from Client$");
            networkStream.Write(outStream, 0, outStream.Length);
            networkStream.Flush();

            byte[] inStream = new byte[655365];
            networkStream.Read(inStream, 0, (int)client.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            msg("Data from Server : " + returndata);
        }
    }
}
