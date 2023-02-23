namespace chatServer
{
    partial class ScreenShot
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Capbtn = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Capbtn
            // 
            this.Capbtn.Location = new System.Drawing.Point(1027, 27);
            this.Capbtn.Name = "Capbtn";
            this.Capbtn.Size = new System.Drawing.Size(141, 49);
            this.Capbtn.TabIndex = 1;
            this.Capbtn.Text = "Capture";
            this.Capbtn.UseVisualStyleBackColor = true;
            this.Capbtn.Click += new System.EventHandler(this.Capbtn_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(1027, 169);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(141, 49);
            this.btnErase.TabIndex = 2;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(1027, 97);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(141, 48);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // ScreenShot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 581);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.Capbtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ScreenShot";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreenShot_Close);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Capbtn;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button Savebtn;
    }
}