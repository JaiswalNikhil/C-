using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SimpleTCP;
using DirectShowLib;
using System.Net.Sockets;


//https://www.codeproject.com/Tips/1136407/Screen-Recorder


namespace Record
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        SimpleTcpServer server;
        const string serverIP = "127.0.0.1";
        const int Port = 139;
      

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            IPAddress IP = IPAddress.Parse(serverIP);
            server.Start(IP, Port);
            server.StringEncoder = Encoding.UTF8;
            server.Delimiter = 0x13;
            btnStop.Enabled = true;
            server.DataReceived += Server_DataReceived;

        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
           
                try
                {
                    txtReceive.Invoke((MethodInvoker)delegate ()
                    {
                        byte[] data;
                        txtReceive.Text += e.MessageString;
                        data = e.Data;
                        //   byteArrayToImage(msg);
                        pictureBox1.Image = byteArrayToImage(data);

                    });
                
                }   
                catch(Exception ex) 
                { txtReceive.Text = ex.Message; }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            server.Broadcast("Record");
        }


        //public Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    MemoryStream ms = new MemoryStream(byteArrayIn);
        //    Image returnImage = Image.FromStream(ms);
        //    return returnImage;
        //}

        private Image byteArrayToImage(byte[] bytesArr)
        {
           
             return(Bitmap)(new ImageConverter()).ConvertFrom(bytesArr);
        //     pictureBox1.Image = bmp;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Broadcast("stop");
            btnStop.Enabled = false;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            string fileName = string.Format(Path.GetFullPath(@"C:\Nikhil\New folder")
                 + @"\Screenshot" + "_" + DateTime.Now.ToString(" dd_MMMM_hh_mm_ss_tt ") +
                 ".png");

            pictureBox1.Image.Save(fileName);

        }
    }
}
