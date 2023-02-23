using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatServer
{
    public partial class ScreenShot : Form 
    {
        public static ScreenShot instance;
        public PictureBox pic;

        public ScreenShot()
        {
            InitializeComponent();
            instance = this;
            pic = pictureBox1;
        }

        private void Capbtn_Click(object sender, EventArgs e)
        {
            Server.instance.SendMsg("Capture");
        }

        private void Form2_Load(object sender, EventArgs e)
        {}

        private void BtnErase_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PNG(*.PNG)|*.png|JPG(*.JPG)|*.jpg";

            sf.FileName = @"Screenshot" + "_" + DateTime.Now.ToString(" dd_MMMM_hh_mm_ss_tt ");
                      
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }
        

        private void ScreenShot_Close(object sender, FormClosingEventArgs e)
        {
            Server.instance.b2.Enabled = true;
            pictureBox1.Image = null;
        }
    }

}
