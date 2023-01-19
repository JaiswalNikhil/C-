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
            
            txtchat.TextAlign = HorizontalAlignment.Left;
            txtchat.Invoke((MethodInvoker)(() => txtchat.AppendText("Server : " + Encoding.ASCII.GetString(dataBuf) + "\r\n")));
            
            //rb_chat.AppendText("\nServer: " + lb_stt.Text);
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
        }


        private void SendLoop()
        {
            while (true)
            {
                //Console.WriteLine("Enter a request: ");
                //string req = Console.ReadLine();
                //byte[] buffer = Encoding.ASCII.GetBytes(req);
                //_clientSocket.Send(buffer);

                byte[] receivedBuf = new byte[1024];
                int rev = _clientSocket.Receive(receivedBuf);
                if (rev != 0)
                {
                    byte[] data = new byte[rev];
                    Array.Copy(receivedBuf, data, rev);
                    label.Text = ("\nReceived : " + Encoding.ASCII.GetString(data));
                    txtchat.AppendText("\nServer : " + Encoding.ASCII.GetString(data));
                }
                else _clientSocket.Close();

            }
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
                    //Console.Clear();
                   label.Text = ("Connection attempts: " + attempts.ToString());
                }
            }
            label.Text = ("Connected!");
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            Connectbtn.Enabled = false;
            string name = $"{txtName.Text.ToUpper()},{txtroll.Text},Connect";
            LoopConnect();
             //SendLoop();
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
            byte[] buffer = Encoding.ASCII.GetBytes(name);
            _clientSocket.Send(buffer);
            // "," + txtroll.Text +
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {

            if (_clientSocket.Connected)
            { 
                byte[] buffer = Encoding.ASCII.GetBytes(txtName.Text.ToUpper() + " : " + txtmsg.Text);
                _clientSocket.Send(buffer);
                txtchat.Text.PadRight(100);
                txtchat.TextAlign = HorizontalAlignment.Left;
                txtchat.AppendText(" You : " + txtmsg.Text + "\r\n");
                txtmsg.Text = "";
            }

        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            _clientSocket.Close();
            Connectbtn.Enabled = true;
        }
    }
}
