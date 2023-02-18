namespace chatServer
{
    partial class Form1
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
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.txtchat = new System.Windows.Forms.TextBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.checked_list = new System.Windows.Forms.CheckedListBox();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(85, 13);
            this.txtmsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(247, 258);
            this.txtmsg.TabIndex = 0;
            this.txtmsg.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtchat
            // 
            this.txtchat.Location = new System.Drawing.Point(85, 302);
            this.txtchat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtchat.Multiline = true;
            this.txtchat.Name = "txtchat";
            this.txtchat.Size = new System.Drawing.Size(275, 38);
            this.txtchat.TabIndex = 1;
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(396, 302);
            this.Sendbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(97, 38);
            this.Sendbtn.TabIndex = 2;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // checked_list
            // 
            this.checked_list.FormattingEnabled = true;
            this.checked_list.Location = new System.Drawing.Point(878, 13);
            this.checked_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checked_list.Name = "checked_list";
            this.checked_list.Size = new System.Drawing.Size(197, 310);
            this.checked_list.TabIndex = 5;
            this.checked_list.SelectedIndexChanged += new System.EventHandler(this.Checked_list_SelectedIndexChanged);
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(544, 302);
            this.Connectbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(119, 38);
            this.Connectbtn.TabIndex = 4;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.RollNo,
            this.Address,
            this.Port});
            this.dataGridView1.Location = new System.Drawing.Point(338, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(534, 271);
            this.dataGridView1.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // RollNo
            // 
            this.RollNo.HeaderText = "RollNo";
            this.RollNo.MinimumWidth = 6;
            this.RollNo.Name = "RollNo";
            this.RollNo.ReadOnly = true;
            this.RollNo.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.MinimumWidth = 6;
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            this.Port.Width = 125;
            // 
            // ssbtn
            // 
            this.ssbtn.Location = new System.Drawing.Point(4, 32);
            this.ssbtn.Name = "ssbtn";
            this.ssbtn.Size = new System.Drawing.Size(75, 23);
            this.ssbtn.TabIndex = 8;
            this.ssbtn.Text = "ss";
            this.ssbtn.UseVisualStyleBackColor = true;
            this.ssbtn.Click += new System.EventHandler(this.Ssbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1082, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 417);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ssbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.checked_list);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.txtchat);
            this.Controls.Add(this.txtmsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
           
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.TextBox txtchat;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.CheckedListBox checked_list;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.Button ssbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

