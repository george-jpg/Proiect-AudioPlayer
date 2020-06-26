namespace AudioPlayerApp
{
    partial class AudioPlayerApp
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
             if (disposing)
            {

                if (mp3Player != null) mp3Player.Dispose();
            }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioPlayerApp));
            this.ToppANEL = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.Label();
            this.Developped = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.ToppANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ToppANEL
            // 
            this.ToppANEL.BackColor = System.Drawing.Color.Aqua;
            this.ToppANEL.Controls.Add(this.pictureBox1);
            this.ToppANEL.Controls.Add(this.Logo);
            this.ToppANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToppANEL.Location = new System.Drawing.Point(0, 0);
            this.ToppANEL.Name = "ToppANEL";
            this.ToppANEL.Size = new System.Drawing.Size(760, 51);
            this.ToppANEL.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Logo.Location = new System.Drawing.Point(180, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(182, 37);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Audio Player";
            // 
            // Developped
            // 
            this.Developped.AutoSize = true;
            this.Developped.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Developped.Location = new System.Drawing.Point(215, 463);
            this.Developped.Name = "Developped";
            this.Developped.Size = new System.Drawing.Size(200, 17);
            this.Developped.TabIndex = 3;
            this.Developped.Text = "Developed by George Predoiu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(517, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(37, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 57);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(133, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 57);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(218, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 85);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(354, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 57);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(460, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 57);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(536, 70);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(191, 292);
            this.listBoxSongs.TabIndex = 10;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // AudioPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 489);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Developped);
            this.Controls.Add(this.ToppANEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AudioPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudioPlayerApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToppANEL.ResumeLayout(false);
            this.ToppANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToppANEL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label Developped;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBoxSongs;
    }
}

