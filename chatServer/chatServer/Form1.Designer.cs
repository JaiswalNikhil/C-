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
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(12, 13);
            this.txtmsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(247, 258);
            this.txtmsg.TabIndex = 0;
            this.txtmsg.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtchat
            // 
            this.txtchat.Location = new System.Drawing.Point(31, 300);
            this.txtchat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtchat.Multiline = true;
            this.txtchat.Name = "txtchat";
            this.txtchat.Size = new System.Drawing.Size(275, 38);
            this.txtchat.TabIndex = 1;
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(325, 302);
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
            this.checked_list.Location = new System.Drawing.Point(741, 11);
            this.checked_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checked_list.Name = "checked_list";
            this.checked_list.Size = new System.Drawing.Size(197, 310);
            this.checked_list.TabIndex = 5;
            this.checked_list.SelectedIndexChanged += new System.EventHandler(this.Checked_list_SelectedIndexChanged);
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(453, 302);
            this.Connectbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(119, 38);
            this.Connectbtn.TabIndex = 4;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.RollNo,
            this.Address,
            this.Port});
            this.dataGridView1.Location = new System.Drawing.Point(280, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 271);
            this.dataGridView1.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // RollNo
            // 
            this.RollNo.HeaderText = "RollNo";
            this.RollNo.Name = "RollNo";
            this.RollNo.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(963, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 292);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 401);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

