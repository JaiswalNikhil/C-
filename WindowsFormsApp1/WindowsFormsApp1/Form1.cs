using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private int Charcount()
        {
            StreamReader sr = new StreamReader(@"C:\count2.txt");

            string msg =  sr.ReadToEnd();
            int  count = msg.Length;
            Thread.Sleep(5000);

            return count;
        }
        private async void  btn_clicked(object sender, EventArgs e)
        {
            Task<int> task  = new Task<int>(Charcount);
            task.Start();

            label1.Text = "Processing ..... ";
            int count = await task;
            label1.Text = count + " Characters";
            
        }
    }
}
    