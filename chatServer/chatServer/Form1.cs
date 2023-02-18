using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatServer
{

    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Socket _serversocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private  List<SocketT2h> _clientsockets = new List<SocketT2h>();
        private byte[] _buffer = new byte[450560];
      


        public Form1()
        {
            InitializeComponent();
            instance = this;
          
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupServer();
        }

        private void SetupServer()
        {
          
            _serversocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serversocket.Listen(1);
            _serversocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = _serversocket.EndAccept(ar);
            _clientsockets.Add(new SocketT2h(socket));

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _serversocket.BeginAccept(new AsyncCallback(AppceptCallback), null);

        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;

            if(socket.Connected)
            {
                int received;
                try
                {
                     received = socket.EndReceive(ar);
                }
                catch(Exception)
                {
                    for (int i = 0; i < _clientsockets.Count; i++)
                    {
                        if (_clientsockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            _clientsockets.RemoveAt(i);
                        }
                    }
                    return;
                }

                if(received!=0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(_buffer, dataBuf, received);
                    try
                    {
                        
                        
                        
                         Form2.instance.pic.Invoke((MethodInvoker)(() => Form2.instance.pic.Image = byteArrayToImage(dataBuf)));
                        
                    }
                    catch (Exception) { }
                    string text = Encoding.ASCII.GetString(dataBuf);
                    string[] txt = text.Split(',');
                    string address = (string)socket.RemoteEndPoint.ToString();
                    string[] ip_port = address.Split(':');

                    try
                    {
                        if (txt[2].Equals("Connect"))
                        {
                            checked_list.Invoke((MethodInvoker)(() => checked_list.Items.Add(socket.RemoteEndPoint.ToString() + ":" + txt[0] + ":" + txt[1])));
                            dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.Rows.Add(txt[0].ToUpper(), txt[1], ip_port[0], ip_port[1])));
                        }
                        //else if(text.Contains("?"))
                        //{
                        //    Form2.instance.pic.Invoke((MethodInvoker)(() => Form2.instance.pic.Image = byteArrayToImage(dataBuf)));
                        //}
                        //Form2.instance.pic.Invoke((MethodInvoker)(() => Form2.instance.pic.Image = byteArrayToImage(dataBuf)));
                        // Form2.instance.pic.Invoke((MethodInvoker)(() => Form2.instance.pic.Image = byteArrayToImage(dataBuf)));

                        //else if(imagetxt[0].Equals("PNG"))
                        //{
                        //    Form2.instance.pic.Invoke((MethodInvoker)(() => Form2.instance.pic.Image = byteArrayToImage(Encoding.ASCII.GetBytes(imagetxt[1]))));
                        //}

                    }
                    catch(Exception)
                    {

                        txtmsg.Invoke((MethodInvoker)(() => txtmsg.AppendText(text + "\r\n")));
                    }

                }
                else
                {
                    for (int i = 0; i < _clientsockets.Count; i++)
                    {
                        if (_clientsockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            _clientsockets.RemoveAt(i);
                            dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.Rows.RemoveAt(i)));
                            checked_list.Invoke((MethodInvoker)(() => checked_list.Items.RemoveAt(i)));

                            

                        }
                    }
                }
            }
            

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);

        }


        private Image byteArrayToImage(byte[] bytesArr)
        {

            return (Bitmap)(new ImageConverter()).ConvertFrom(bytesArr);
            //     pictureBox1.Image = bmp;

        }

        public void Sendata(Socket socket, string text)
        {
            byte[] data = Encoding.ASCII.GetBytes(text);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            _serversocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void SendCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndSend(ar);
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {

            List<int> list = new List<int>();


            
            foreach(int index in checked_list.CheckedIndices)
            {
                list.Add(index);
            }
          
            for (int i = 0; i < checked_list.CheckedItems.Count; i++)
            {
               
                    Sendata(_clientsockets[list[i]]._Socket, "Server : " + txtchat.Text);
                   
            }
            
            txtmsg.AppendText("You : " + txtchat.Text + "\r\n");
            txtchat.Text = "";
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Checked_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SendMsg()
        {

            List<int> list = new List<int>();

            foreach (int index in checked_list.CheckedIndices)
            {
                list.Add(index);
            }

            for (int i = 0; i < checked_list.CheckedItems.Count; i++)
            {
                Sendata(_clientsockets[list[i]]._Socket,"Capture");
            }

        }


        private void Ssbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            //this.Hide();
        }
    }
}
