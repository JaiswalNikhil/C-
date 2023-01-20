using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatclient
{
    public partial class Form1 : Form
    {

        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        byte[] receivedBuf = new byte[1024];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReceiveData(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int received = socket.EndReceive(ar);
            byte[] dataBuf = new byte[received];
            Array.Copy(receivedBuf, dataBuf, received);
            string text = Encoding.ASCII.GetString(dataBuf);



            txtchat.Invoke((MethodInvoker)(() => txtchat.AppendText(text + "\r\n")));
           
           

            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
        }


        private void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {
                   label2.Text = ("Connection attempts: " + attempts.ToString());
                }
            }
            label.Text = ("Connected!");
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {

            string name = $"{txtName.Text},{txtroll.Text},Connect";

            LoopConnect();

            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);

            byte[] buffer = Encoding.ASCII.GetBytes(name);
            _clientSocket.Send(buffer);

        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected)
            { 
                byte[] buffer = Encoding.ASCII.GetBytes(txtName.Text.ToUpper() + " : " + txtmsg.Text);
                _clientSocket.Send(buffer);
                txtchat.AppendText("You : " + txtmsg.Text + "\r\n");
                txtmsg.Text = "";
            }
        }
    }
}
