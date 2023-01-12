using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;




namespace Record_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        SimpleTcpClient client;
        const string serverIP = "127.0.0.1";
        const int Port = 139;
        //  string[] msg;
        Thread t1;

        private void Form1_Load(object sender, EventArgs e)
        {

            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;           
            client.DataReceived += Client_DataRecieved;
            t1 = new Thread(new ThreadStart(capture));
            t1.Start();
            
        }


        private void Client_DataRecieved(object sender, SimpleTCP.Message e)
        {          
                txtRequest.Invoke((MethodInvoker)delegate ()
                {
                    txtRequest.Text = "";
                    txtRequest.Text += e.MessageString;

                });         
        }


        private void capture()
        {
            do
            {
                try
                {

                    if(txtRequest.Text.Equals("Record"))
                    {

                        Bitmap memoryImage = new Bitmap(1920, 1080);
                        Size s = new Size(memoryImage.Width, memoryImage.Height);

                        Graphics memoryGraphics = Graphics.FromImage(memoryImage);

                        memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);

                        //string fileName = string.Format(Path.GetFullPath(@"C:\Nikhil\New folder")
                        //     + @"\Screenshot" + "_" + DateTime.Now.ToString(" dd_MMMM_hh_mm_ss_tt ") +
                        //     ".png");

                       // Image i = memoryImage;

                        client.Write(converterDemo(memoryImage));
                        Thread.Sleep(2000);
                    } 
                }
                catch (Exception ex) { }
            } while (txtRequest.Text != "stop");


        }

        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.Connect(serverIP, Port);
        }
    }
}
