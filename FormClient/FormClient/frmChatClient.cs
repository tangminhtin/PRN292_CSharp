using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClient
{
    public partial class frmChatClient : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

        public frmChatClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] outStream = Encoding.ASCII.GetBytes(txtMessage.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            readData = "Connected to Chat Server...";
            msg();
            clientSocket.Connect("127.0.0.1", 8888);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(txtMessage.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }

        private void getMessage()
        {
            while(true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[65536];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                string returnData = Encoding.ASCII.GetString(inStream);
                readData = "" + returnData;
                msg();
            }
        }

        private void msg()
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(msg));
            } else
            {
                txtChat.Text = txtChat.Text + Environment.NewLine + " >> " + readData;
            }
        }
    }
}
