using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;


namespace AutoShutdown
{ 
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        string serverip = "127.0.0.1";

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            server.Broadcast("shutdown.exe,-s -t 00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(serverip);
            server.Start(ip,139);
        }                          
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {           
        }                             
        private void btnLock_Click(object sender, EventArgs e)
        {
            server.Broadcast("Rundll32.exe,User32.dll,LockWorkStation");
        }
    }
}
