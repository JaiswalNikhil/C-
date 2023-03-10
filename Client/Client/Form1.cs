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
//96,235,225
//84,195,234
namespace Client
{
    public partial class Client : Form
    {
        bool sidebarExpand;

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

        public Client()
        {
            InitializeComponent();

            Rounded_TextBox(chatBox, 40, 250);
            Rounded_TextBox(txtName, 30, 180);
            Rounded_TextBox(txtRollno, 30, 180);

            MsgBox.BorderStyle = BorderStyle.None;
            MsgBox.AutoSize = false;
            MsgBox.Height = 410;
            MsgBox.Width = 301;
            MsgBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, MsgBox.Width, MsgBox.Height, 20, 20));

            panel259.BorderStyle = BorderStyle.None;
            panel259.AutoSize = false;
            panel259.Height = 400;
            panel259.Width = 270;
            panel259.Region = Region.FromHrgn(CreateRoundRectRgn(10, 10, panel259.Width, panel259.Height, 20, 20));
        }

        private void Rounded_TextBox(TextBox txtBox, int height, int width)
        {
            txtBox.BorderStyle = BorderStyle.None;
            txtBox.AutoSize = false;
            txtBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, width, height, 10, 10));
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 40;
                sideBar.Height -= 40;

                if (sideBar.Width == sideBar.MinimumSize.Width && sideBar.Height == sideBar.MinimumSize.Height)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Height += 40;
                sideBar.Width += 40;

                if (sideBar.Width == sideBar.MaximumSize.Width && sideBar.Height == sideBar.MaximumSize.Height)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void Menu_btn_Click(object sender, MouseEventArgs e)
        {
            sideBarTimer.Start();
        }

        private void BtnDisconnect_Hover(object sender, EventArgs e)
        {
            BtnDisconnect_Hover_ColorChange();
        }
        private void BtnDisconnect_Leave(object sender, EventArgs e)
        {
            BtnDisconnect_Leave_ColorChange();
        }

        private void BtnDisconnect_Hover_ColorChange()
        {
            Disconnect_btn.BackColor = Color.WhiteSmoke;
            Disconnect_btn.ForeColor = Color.Red;
        }

        private void BtnDisconnect_Leave_ColorChange()
        {
            Disconnect_btn.BackColor = Color.Black;
            Disconnect_btn.ForeColor = Color.SeaShell;
        }

        private void BtnConnect_Hover_ColorChange()
        {
            Connect_btn.BackColor = Color.WhiteSmoke;
            Connect_btn.ForeColor = Color.Green;

        }

        private void BtnConnect_Leave_ColorChange()
        {
            Connect_btn.BackColor = Color.Black;
            Connect_btn.ForeColor = Color.SeaShell;

        }
        private void BtnConnect_Hover(object sender, EventArgs e)
        {
            BtnConnect_Hover_ColorChange();
        }

        private void BtnConnect_Leave(object sender, EventArgs e)
        {
            BtnConnect_Leave_ColorChange();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chatBox.Text = "\n\n  Message";
            txtName.Text = "Name";
            txtRollno.Text = "Roll no.";
        }

        private void chatBox_Enter(object sender, EventArgs e)
        {
            if (chatBox.Text == "\n\n  Message")
            {
                chatBox.Text = "";
            }
        }
        private void chatBox_Leave(object sender, EventArgs e)
        {
            if (chatBox.Text == "")
            {
                chatBox.Text = "\n\n  Message";
            }
        }

        private void Changing_Theme(object sender, EventArgs e)
        {
            if (light_mode.Checked)
            {
                MsgBox.BackColor = Color.WhiteSmoke;
                chatBox.BackColor = Color.WhiteSmoke;
                MsgBox.ForeColor = Color.Black;
                chatBox.ForeColor = Color.Black;
                header.BackColor = Color.WhiteSmoke;
                lbName.ForeColor = Color.Black;
                sideBar.BackColor = Color.WhiteSmoke;
                Menu_btn.BackgroundImage = Properties.Resources.menu_light_theme;
            }
            else
            {
                MsgBox.BackColor = Color.FromArgb(34, 34, 34);
                MsgBox.ForeColor = Color.WhiteSmoke;
                chatBox.BackColor = Color.FromArgb(34, 34, 34);
                chatBox.ForeColor = Color.WhiteSmoke;
                header.BackColor = Color.FromArgb(20, 20, 20);
                lbName.ForeColor = Color.SeaShell;
                sideBar.BackColor = Color.FromArgb(23, 20, 18);
                Menu_btn.BackgroundImage = Properties.Resources.menu_dark_theme;

            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.BackColor = Color.SeaShell;
                txtName.ForeColor = Color.Black;
                txtName.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void txtRollno_Enter(object sender, EventArgs e)
        {
            if (txtRollno.Text == "Roll no.")
            {
                txtRollno.Text = "";
                txtRollno.BackColor = Color.SeaShell;
                txtRollno.ForeColor = Color.Black;
                txtRollno.TextAlign = HorizontalAlignment.Center;

            }

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.BackColor = Color.FromArgb(51, 51, 51);
                txtName.ForeColor = Color.SeaShell;
                txtName.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void txtRollno_Leave(object sender, EventArgs e)
        {
            if (txtRollno.Text == "")
            {
                txtRollno.Text = "Roll no.";
                txtRollno.BackColor = Color.FromArgb(51, 51, 51);
                txtRollno.ForeColor = Color.SeaShell;
                txtRollno.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void Submit(object sender, EventArgs e)
        {

            if (txtName.Text == "Name" && txtRollno.Text == "Roll no." || txtName.Text == "Name" && txtRollno.Text == "" || txtName.Text == "" && txtRollno.Text == "Roll no.")
            {
                MessageBox.Show("Please enter your Details", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtName.Text == "Name" && txtRollno.Text != "Roll no." || txtName.Text == "" && txtRollno.Text != "Roll no.")
            {
                MessageBox.Show("Please enter your Name ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtName.Text != "Name" && txtRollno.Text == "Roll no." || txtName.Text != "Name" && txtRollno.Text == "")
            {
                MessageBox.Show("Please enter your Roll no. ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                panel259.Hide();
                txtName.Hide();
                txtRollno.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                lbLogin.Hide();
                panel2.Hide();
                panel260.Hide();
                panel261.Hide();

                string[] name = txtName.Text.Split(' ');
                lbName.Text = "Hii  " + name[0].ToUpper();

            }
        }

        private void Submit_Hover(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(Properties.Resources.Hover_Arrow);
            pictureBox1.Image = b;
        }

        private void Submit_Leave(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(Properties.Resources.submit1);
            pictureBox1.Image = b;
        }

        private void txtRollno_keypressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_Keypresed(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}