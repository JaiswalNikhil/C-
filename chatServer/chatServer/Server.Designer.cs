namespace chatServer
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.txtchat = new System.Windows.Forms.TextBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.checked_list = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssbtn = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Restart_Btn = new System.Windows.Forms.Button();
            this.Lock_Btn = new System.Windows.Forms.Button();
            this.btnpdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(106, 13);
            this.txtmsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(247, 258);
            this.txtmsg.TabIndex = 0;
            this.txtmsg.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtchat
            // 
            this.txtchat.Location = new System.Drawing.Point(106, 302);
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
            this.checked_list.Location = new System.Drawing.Point(985, 13);
            this.checked_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checked_list.Name = "checked_list";
            this.checked_list.Size = new System.Drawing.Size(197, 310);
            this.checked_list.TabIndex = 5;
            this.checked_list.SelectedIndexChanged += new System.EventHandler(this.Checked_list_SelectedIndexChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(359, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 268);
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
            this.ssbtn.Size = new System.Drawing.Size(96, 32);
            this.ssbtn.TabIndex = 8;
            this.ssbtn.Text = "Screenshot";
            this.ssbtn.UseVisualStyleBackColor = true;
            this.ssbtn.Click += new System.EventHandler(this.Ssbtn_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(4, 79);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(96, 27);
            this.btnMonitor.TabIndex = 9;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.BtnMonitor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Shutdown";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Restart_Btn
            // 
            this.Restart_Btn.Location = new System.Drawing.Point(262, 347);
            this.Restart_Btn.Name = "Restart_Btn";
            this.Restart_Btn.Size = new System.Drawing.Size(119, 49);
            this.Restart_Btn.TabIndex = 11;
            this.Restart_Btn.Text = "Restart";
            this.Restart_Btn.UseVisualStyleBackColor = true;
            this.Restart_Btn.Click += new System.EventHandler(this.Restart_Btn_Click);
            // 
            // Lock_Btn
            // 
            this.Lock_Btn.Location = new System.Drawing.Point(407, 347);
            this.Lock_Btn.Name = "Lock_Btn";
            this.Lock_Btn.Size = new System.Drawing.Size(115, 49);
            this.Lock_Btn.TabIndex = 12;
            this.Lock_Btn.Text = "Lock";
            this.Lock_Btn.UseVisualStyleBackColor = true;
            this.Lock_Btn.Click += new System.EventHandler(this.Lock_Btn_Click);
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(792, 291);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(132, 49);
            this.btnpdf.TabIndex = 13;
            this.btnpdf.Text = "Generate Pdf";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.Btnpdf_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 408);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.Lock_Btn);
            this.Controls.Add(this.Restart_Btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.ssbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checked_list);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.txtchat);
            this.Controls.Add(this.txtmsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
           // this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Monitoring System";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.Button ssbtn;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Restart_Btn;
        private System.Windows.Forms.Button Lock_Btn;
        private System.Windows.Forms.Button btnpdf;
    }
}

