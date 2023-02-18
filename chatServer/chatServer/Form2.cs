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
//using System.Windows.Forms;

namespace chatServer
{
    public partial class Form2 : Form 
    {
        public static Form2 instance;
        public PictureBox pic;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            pic = pictureBox1;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
        }

        private void Capbtn_Click(object sender, EventArgs e)
        {

            Form1.instance.SendMsg();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
