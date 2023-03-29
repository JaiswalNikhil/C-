namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.header = new System.Windows.Forms.Panel();
            this.light_mode = new System.Windows.Forms.CheckBox();
            this.lbName = new System.Windows.Forms.Label();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.IP_Address = new System.Windows.Forms.TextBox();
            this.Disconnect_btn = new System.Windows.Forms.Button();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.Menu_btn = new System.Windows.Forms.Panel();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel259 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel261 = new System.Windows.Forms.Panel();
            this.panel260 = new System.Windows.Forms.Panel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.MsgBox = new System.Windows.Forms.RichTextBox();
            this.Send_btn = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel259.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.header.Controls.Add(this.light_mode);
            this.header.Controls.Add(this.lbName);
            resources.ApplyResources(this.header, "header");
            this.header.Name = "header";
            // 
            // light_mode
            // 
            resources.ApplyResources(this.light_mode, "light_mode");
            this.light_mode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.light_mode.Name = "light_mode";
            this.light_mode.UseVisualStyleBackColor = true;
            this.light_mode.CheckedChanged += new System.EventHandler(this.Changing_Theme);
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.ForeColor = System.Drawing.Color.SeaShell;
            this.lbName.Name = "lbName";
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.chatBox, "chatBox");
            this.chatBox.ForeColor = System.Drawing.Color.SeaShell;
            this.chatBox.Name = "chatBox";
            this.chatBox.TabStop = false;
            this.chatBox.Tag = "";
            this.chatBox.Enter += new System.EventHandler(this.chatBox_Enter);
            this.chatBox.Leave += new System.EventHandler(this.chatBox_Leave);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(18)))));
            this.sideBar.Controls.Add(this.IP_Address);
            this.sideBar.Controls.Add(this.Disconnect_btn);
            this.sideBar.Controls.Add(this.Connect_btn);
            this.sideBar.Controls.Add(this.Menu_btn);
            resources.ApplyResources(this.sideBar, "sideBar");
            this.sideBar.Name = "sideBar";
            // 
            // IP_Address
            // 
            this.IP_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(18)))));
            this.IP_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.IP_Address, "IP_Address");
            this.IP_Address.ForeColor = System.Drawing.Color.SeaShell;
            this.IP_Address.Name = "IP_Address";
            this.IP_Address.Enter += new System.EventHandler(this.IP_Address_Enter);
            this.IP_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IP_Address_Pressed);
            this.IP_Address.Leave += new System.EventHandler(this.IP_Address_Leave);
            // 
            // Disconnect_btn
            // 
            resources.ApplyResources(this.Disconnect_btn, "Disconnect_btn");
            this.Disconnect_btn.ForeColor = System.Drawing.Color.SeaShell;
            this.Disconnect_btn.Name = "Disconnect_btn";
            this.Disconnect_btn.UseVisualStyleBackColor = true;
            this.Disconnect_btn.MouseLeave += new System.EventHandler(this.BtnDisconnect_Leave);
            this.Disconnect_btn.MouseHover += new System.EventHandler(this.BtnDisconnect_Hover);
            // 
            // Connect_btn
            // 
            resources.ApplyResources(this.Connect_btn, "Connect_btn");
            this.Connect_btn.ForeColor = System.Drawing.Color.SeaShell;
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.MouseLeave += new System.EventHandler(this.BtnConnect_Leave);
            this.Connect_btn.MouseHover += new System.EventHandler(this.BtnConnect_Hover);
            // 
            // Menu_btn
            // 
            this.Menu_btn.BackgroundImage = global::Client.Properties.Resources.menu_dark_theme;
            this.Menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Menu_btn, "Menu_btn");
            this.Menu_btn.Name = "Menu_btn";
            this.Menu_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_btn_Click);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 40;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.panel259);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel259
            // 
            this.panel259.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel259.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel259.Controls.Add(this.panel3);
            this.panel259.Controls.Add(this.panel1);
            this.panel259.Controls.Add(this.pictureBox3);
            this.panel259.Controls.Add(this.pictureBox2);
            this.panel259.Controls.Add(this.pictureBox1);
            this.panel259.Controls.Add(this.panel261);
            this.panel259.Controls.Add(this.panel260);
            this.panel259.Controls.Add(this.lbLogin);
            this.panel259.Controls.Add(this.txtRollno);
            this.panel259.Controls.Add(this.txtName);
            resources.ApplyResources(this.panel259, "panel259");
            this.panel259.Name = "panel259";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Client.Properties.Resources.Rollno_;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Client.Properties.Resources.name;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Client.Properties.Resources.submit1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Submit);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.Submit_Leave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.Submit_Hover);
            // 
            // panel261
            // 
            this.panel261.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(234)))));
            resources.ApplyResources(this.panel261, "panel261");
            this.panel261.Name = "panel261";
            // 
            // panel260
            // 
            this.panel260.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(234)))));
            resources.ApplyResources(this.panel260, "panel260");
            this.panel260.Name = "panel260";
            // 
            // lbLogin
            // 
            resources.ApplyResources(this.lbLogin, "lbLogin");
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(234)))));
            this.lbLogin.Name = "lbLogin";
            // 
            // txtRollno
            // 
            this.txtRollno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRollno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtRollno, "txtRollno");
            this.txtRollno.ForeColor = System.Drawing.Color.SeaShell;
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Enter += new System.EventHandler(this.txtRollno_Enter);
            this.txtRollno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRollno_keypressed);
            this.txtRollno.Leave += new System.EventHandler(this.txtRollno_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.ForeColor = System.Drawing.Color.Ivory;
            this.txtName.Name = "txtName";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_Keypresed);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // MsgBox
            // 
            this.MsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.MsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.MsgBox, "MsgBox");
            this.MsgBox.ForeColor = System.Drawing.Color.SeaShell;
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.ReadOnly = true;
            this.MsgBox.TabStop = false;
            // 
            // Send_btn
            // 
            this.Send_btn.BackgroundImage = global::Client.Properties.Resources.send;
            resources.ApplyResources(this.Send_btn, "Send_btn");
            this.Send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_btn.Name = "Send_btn";
            // 
            // Client
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.chatBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Client";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel259.ResumeLayout(false);
            this.panel259.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Panel Send_btn;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel Menu_btn;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.CheckBox light_mode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel259;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel261;
        private System.Windows.Forms.Panel panel260;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox MsgBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Button Disconnect_btn;
        private System.Windows.Forms.TextBox IP_Address;
    }
}

