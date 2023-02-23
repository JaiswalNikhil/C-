using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatclient
{
    public partial class Client : Form
    {

        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Thread t1;
        byte[] receivedBuf = new byte[1716964]; //1716964 450560


        public Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReceiveData(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            if(socket.Connected)
            {
                int received = socket.EndReceive(ar);
                byte[] dataBuf = new byte[received];
                Array.Copy(receivedBuf, dataBuf, received);
                string text = Encoding.ASCII.GetString(dataBuf);

                switch(text)
                {
                    case "Capture":
                        capture();
                        break;

                    case "Monitor":
                        t1 = new Thread(new ThreadStart(Monitor));
                        t1.Start();
                        break;

                    case "Stop":
                        t1.Abort();
                        break;

                    case "Shutdown":
                        Command_operation("shutdown.exe","-s");
                        break;

                    case "Lock":
                        Command_operation("Rundll32.exe", "User32.dll, LockWorkStation");
                        break;

                    case "Restart":
                        Command_operation("shutdown.exe", "-r");
                        break;

                    default:
                        txtchat.Invoke((MethodInvoker)(() => txtchat.AppendText(text + "\r\n")));
                        break;

                }

                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
            }
          
        }
        private void Command_operation(string filename , string arguments)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo(filename, arguments);
            Process.Start(startinfo);            
        }
       
        private void Monitor()
        {
            while(true)
            {
                try
                {
                    capture();
                    Thread.Sleep(100);
                }
                catch (Exception) {}
            }

        }

            private void capture()
            {

                Bitmap memoryImage = new Bitmap(1920, 1080);
                Size s = new Size(memoryImage.Width, memoryImage.Height);

                Graphics memoryGraphics = Graphics.FromImage(memoryImage);

                memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);

               _clientSocket.Send(converterDemo(memoryImage));

            }


        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
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
            Connectbtn.Enabled = false;
           
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

        private void close_connection()
        {

           _clientSocket.Shutdown(SocketShutdown.Both);
           _clientSocket.Close();
           _clientSocket = null;

        }
        private void Closebtn_Click(object sender, EventArgs e)
        {

            closebtn.Enabled = false;
            byte[] buffer = Encoding.ASCII.GetBytes($"{txtName.Text.ToUpper()} : Closed Connection");
            _clientSocket.Send(buffer);
            _clientSocket.Shutdown(SocketShutdown.Both);
           
        }

        private void Client_CLose(object sender, FormClosingEventArgs e)
        {
            if (_clientSocket.Connected)
            {
                byte[] buffer = Encoding.ASCII.GetBytes($"{txtName.Text.ToUpper()} : Closed Connection");
                _clientSocket.Send(buffer);
                close_connection();
            } 
            else
            {
                _clientSocket.Close();
                _clientSocket = null;
            }
        }
    }
}
