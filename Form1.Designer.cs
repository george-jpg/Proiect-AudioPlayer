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
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.buttonSelectSongs = new System.Windows.Forms.Button();
            this.Developped = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.ToppANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // ToppANEL
            // 
            this.ToppANEL.BackColor = System.Drawing.Color.SkyBlue;
            this.ToppANEL.Controls.Add(this.pictureBox1);
            this.ToppANEL.Controls.Add(this.Logo);
            this.ToppANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToppANEL.Location = new System.Drawing.Point(0, 0);
            this.ToppANEL.Name = "ToppANEL";
            this.ToppANEL.Size = new System.Drawing.Size(851, 51);
            this.ToppANEL.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(796, 0);
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
            this.Logo.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(24, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(136, 28);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Audio Player";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(621, 69);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(214, 340);
            this.listBoxSongs.TabIndex = 1;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // buttonSelectSongs
            // 
            this.buttonSelectSongs.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonSelectSongs.ForeColor = System.Drawing.Color.White;
            this.buttonSelectSongs.Location = new System.Drawing.Point(621, 427);
            this.buttonSelectSongs.Name = "buttonSelectSongs";
            this.buttonSelectSongs.Size = new System.Drawing.Size(214, 53);
            this.buttonSelectSongs.TabIndex = 2;
            this.buttonSelectSongs.Text = "Select Songs";
            this.buttonSelectSongs.UseVisualStyleBackColor = false;
            this.buttonSelectSongs.Click += new System.EventHandler(this.buttonSelectSongs_Click);
            // 
            // Developped
            // 
            this.Developped.AutoSize = true;
            this.Developped.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Developped.Location = new System.Drawing.Point(287, 487);
            this.Developped.Name = "Developped";
            this.Developped.Size = new System.Drawing.Size(200, 17);
            this.Developped.TabIndex = 3;
            this.Developped.Text = "Developed by George Predoiu";
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(12, 57);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(396, 330);
            this.axWindowsMediaPlayerMusic.TabIndex = 4;
            // 
            // AudioPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 513);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.Developped);
            this.Controls.Add(this.buttonSelectSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.ToppANEL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AudioPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudioPlayerApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToppANEL.ResumeLayout(false);
            this.ToppANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToppANEL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button buttonSelectSongs;
        private System.Windows.Forms.Label Developped;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
    }
}

