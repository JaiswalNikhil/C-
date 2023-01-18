namespace chatclient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.txtchat = new System.Windows.Forms.TextBox();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtroll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // Connectbtn
            // 
            resources.ApplyResources(this.Connectbtn, "Connectbtn");
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Sendbtn
            // 
            resources.ApplyResources(this.Sendbtn, "Sendbtn");
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // txtchat
            // 
            resources.ApplyResources(this.txtchat, "txtchat");
            this.txtchat.Name = "txtchat";
            // 
            // txtmsg
            // 
            resources.ApplyResources(this.txtmsg, "txtmsg");
            this.txtmsg.Name = "txtmsg";
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            // 
            // txtroll
            // 
            resources.ApplyResources(this.txtroll, "txtroll");
            this.txtroll.Name = "txtroll";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtroll);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.txtchat);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.Connectbtn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.TextBox txtchat;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtroll;
    }
}

