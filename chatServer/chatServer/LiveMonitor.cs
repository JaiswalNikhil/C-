using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatServer
{
    public partial class LiveMonitor : Form
    {

        public PictureBox pic1;
        public static LiveMonitor instance;

        public LiveMonitor()
        {
            InitializeComponent();
            pic1 = Screen;
            instance = this;  
        }

        private void BtnMonitor_Click(object sender, EventArgs e)
        {
            btnMonitor.Enabled = false;
            Server.instance.SendMsg("Monitor");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PNG(*.PNG)|*.png|JPG(*.JPG)|*.jpg";

            sf.FileName = @"Screenshot" + "_" + DateTime.Now.ToString(" dd_MMMM_hh_mm_ss_tt ");

            if (sf.ShowDialog() == DialogResult.OK)
            {
                Screen.Image.Save(sf.FileName);
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            btnMonitor.Enabled = true;
            Server.instance.SendMsg("Stop");
            Screen.Image = null;
        }

        private void LiveMonitor_Load(object sender, EventArgs e)
        {
            
        }

        private void Livemonitor_Close(object sender, FormClosingEventArgs e)
        {
            Server.instance.b1.Enabled = true;
            Server.instance.SendMsg("Stop");
        }
    }
}
