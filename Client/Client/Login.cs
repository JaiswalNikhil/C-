using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Client
{
    public partial class Login : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
        );


        public Login()
        {
            InitializeComponent();
            txtName.Text = "Name";
            txtRollno.Text = "Roll No";
            panel259.BorderStyle = BorderStyle.None;
            panel259.AutoSize = false;
            panel259.Height = 400;// 307, 365 // location 73, 141 34, 34, 34
            panel259.Width = 270;
            panel259.Region = Region.FromHrgn(CreateRoundRectRgn(10,10, panel259.Width, panel259.Height, 20, 20));

            
            txtName.BorderStyle = BorderStyle.None;
            txtName.AutoSize = false;
            txtName.Height =25;// 307, 365 // location 73, 141 34, 34, 34
            txtName.Width = 180;
            txtName.Region = Region.FromHrgn(CreateRoundRectRgn(0,0, txtName.Width, txtName.Height, 10, 10));

            txtRollno.BorderStyle = BorderStyle.None;
            txtRollno.AutoSize = false;
            txtRollno.Height = 25;// 307, 365 // location 73, 141 34, 34, 34
            txtRollno.Width = 180;
            txtRollno.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtRollno.Width, txtRollno.Height, 10, 10));
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel259_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if(txtName.Text == "Name")
            {
                txtName.Text = "";
            }
        }

        private void txtRollno_Enter(object sender, EventArgs e)
        {
            if (txtRollno.Text == "Roll No")
            {
                txtRollno.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
            }
        }

        private void txtRollno_Leave(object sender, EventArgs e)
        {
            if (txtRollno.Text == "")
            {
                txtRollno.Text = "Roll No";
            }
        }

        private void Submit(object sender, EventArgs e)
        {
        }
    }
}
