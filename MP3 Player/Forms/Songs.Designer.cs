namespace MP3_Player.Forms
{
    partial class Songs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Songs));
            this.panelPlay = new System.Windows.Forms.Panel();
            this.Mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.IzaberiPesme = new Bunifu.Framework.UI.BunifuImageButton();
            this.Pauza = new Bunifu.Framework.UI.BunifuImageButton();
            this.napredMalo = new Bunifu.Framework.UI.BunifuImageButton();
            this.nazadMalo = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlaySong = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelPesma = new System.Windows.Forms.Label();
            this.labelPevac = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timeToSongsEnd = new System.Windows.Forms.Label();
            this.songVolumen = new Bunifu.Framework.UI.BunifuSlider();
            this.songTime = new Bunifu.Framework.UI.BunifuSlider();
            this.panelSongDisplay = new System.Windows.Forms.Panel();
            this.panelSongs = new System.Windows.Forms.Panel();
            this.panelSong = new System.Windows.Forms.Panel();
            this.playTrenutnuPesmu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SongList = new System.Windows.Forms.ListBox();
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzaberiPesme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pauza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napredMalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazadMalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaySong)).BeginInit();
            this.panelSongDisplay.SuspendLayout();
            this.panelSongs.SuspendLayout();
            this.panelSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playTrenutnuPesmu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPlay
            // 
            this.panelPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelPlay.Controls.Add(this.Mute);
            this.panelPlay.Controls.Add(this.IzaberiPesme);
            this.panelPlay.Controls.Add(this.Pauza);
            this.panelPlay.Controls.Add(this.napredMalo);
            this.panelPlay.Controls.Add(this.nazadMalo);
            this.panelPlay.Controls.Add(this.PlaySong);
            this.panelPlay.Controls.Add(this.labelPesma);
            this.panelPlay.Controls.Add(this.labelPevac);
            this.panelPlay.Controls.Add(this.labelTime);
            this.panelPlay.Controls.Add(this.timeToSongsEnd);
            this.panelPlay.Controls.Add(this.songVolumen);
            this.panelPlay.Controls.Add(this.songTime);
            this.panelPlay.Location = new System.Drawing.Point(-3, 346);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(804, 105);
            this.panelPlay.TabIndex = 0;
            // 
            // Mute
            // 
            this.Mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Mute.BackColor = System.Drawing.Color.Black;
            this.Mute.Image = ((System.Drawing.Image)(resources.GetObject("Mute.Image")));
            this.Mute.ImageActive = null;
            this.Mute.Location = new System.Drawing.Point(590, 47);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(32, 32);
            this.Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mute.TabIndex = 12;
            this.Mute.TabStop = false;
            this.Mute.Zoom = 10;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // IzaberiPesme
            // 
            this.IzaberiPesme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IzaberiPesme.BackColor = System.Drawing.Color.Black;
            this.IzaberiPesme.Image = ((System.Drawing.Image)(resources.GetObject("IzaberiPesme.Image")));
            this.IzaberiPesme.ImageActive = null;
            this.IzaberiPesme.Location = new System.Drawing.Point(547, 47);
            this.IzaberiPesme.Name = "IzaberiPesme";
            this.IzaberiPesme.Size = new System.Drawing.Size(32, 32);
            this.IzaberiPesme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IzaberiPesme.TabIndex = 11;
            this.IzaberiPesme.TabStop = false;
            this.IzaberiPesme.Zoom = 10;
            this.IzaberiPesme.Click += new System.EventHandler(this.IzaberiPesme_Click_1);
            // 
            // Pauza
            // 
            this.Pauza.BackColor = System.Drawing.Color.Black;
            this.Pauza.Image = ((System.Drawing.Image)(resources.GetObject("Pauza.Image")));
            this.Pauza.ImageActive = null;
            this.Pauza.Location = new System.Drawing.Point(241, 47);
            this.Pauza.Name = "Pauza";
            this.Pauza.Size = new System.Drawing.Size(32, 32);
            this.Pauza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pauza.TabIndex = 10;
            this.Pauza.TabStop = false;
            this.Pauza.Zoom = 5;
            // 
            // napredMalo
            // 
            this.napredMalo.BackColor = System.Drawing.Color.Black;
            this.napredMalo.Image = ((System.Drawing.Image)(resources.GetObject("napredMalo.Image")));
            this.napredMalo.ImageActive = null;
            this.napredMalo.Location = new System.Drawing.Point(185, 50);
            this.napredMalo.Name = "napredMalo";
            this.napredMalo.Size = new System.Drawing.Size(24, 24);
            this.napredMalo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.napredMalo.TabIndex = 8;
            this.napredMalo.TabStop = false;
            this.napredMalo.Zoom = 10;
            // 
            // nazadMalo
            // 
            this.nazadMalo.BackColor = System.Drawing.Color.Black;
            this.nazadMalo.Image = ((System.Drawing.Image)(resources.GetObject("nazadMalo.Image")));
            this.nazadMalo.ImageActive = null;
            this.nazadMalo.Location = new System.Drawing.Point(110, 50);
            this.nazadMalo.Name = "nazadMalo";
            this.nazadMalo.Size = new System.Drawing.Size(24, 24);
            this.nazadMalo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nazadMalo.TabIndex = 7;
            this.nazadMalo.TabStop = false;
            this.nazadMalo.Zoom = 10;
            // 
            // PlaySong
            // 
            this.PlaySong.BackColor = System.Drawing.Color.Black;
            this.PlaySong.Image = ((System.Drawing.Image)(resources.GetObject("PlaySong.Image")));
            this.PlaySong.ImageActive = null;
            this.PlaySong.Location = new System.Drawing.Point(145, 47);
            this.PlaySong.Name = "PlaySong";
            this.PlaySong.Size = new System.Drawing.Size(32, 32);
            this.PlaySong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlaySong.TabIndex = 6;
            this.PlaySong.TabStop = false;
            this.PlaySong.Zoom = 5;
            this.PlaySong.Click += new System.EventHandler(this.PlaySong_Click);
            // 
            // labelPesma
            // 
            this.labelPesma.AutoSize = true;
            this.labelPesma.ForeColor = System.Drawing.Color.SlateGray;
            this.labelPesma.Location = new System.Drawing.Point(26, 66);
            this.labelPesma.Name = "labelPesma";
            this.labelPesma.Size = new System.Drawing.Size(39, 13);
            this.labelPesma.TabIndex = 5;
            this.labelPesma.Text = "Pesma";
            // 
            // labelPevac
            // 
            this.labelPevac.AutoSize = true;
            this.labelPevac.ForeColor = System.Drawing.Color.SlateGray;
            this.labelPevac.Location = new System.Drawing.Point(26, 39);
            this.labelPevac.Name = "labelPevac";
            this.labelPevac.Size = new System.Drawing.Size(38, 13);
            this.labelPevac.TabIndex = 4;
            this.labelPevac.Text = "Pevac";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTime.Location = new System.Drawing.Point(773, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(28, 13);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "5:00";
            // 
            // timeToSongsEnd
            // 
            this.timeToSongsEnd.AutoSize = true;
            this.timeToSongsEnd.ForeColor = System.Drawing.Color.GhostWhite;
            this.timeToSongsEnd.Location = new System.Drawing.Point(26, 10);
            this.timeToSongsEnd.Name = "timeToSongsEnd";
            this.timeToSongsEnd.Size = new System.Drawing.Size(28, 13);
            this.timeToSongsEnd.TabIndex = 2;
            this.timeToSongsEnd.Text = "0:00";
            // 
            // songVolumen
            // 
            this.songVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.songVolumen.BackColor = System.Drawing.Color.Transparent;
            this.songVolumen.BackgroudColor = System.Drawing.Color.DarkGray;
            this.songVolumen.BorderRadius = 5;
            this.songVolumen.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(184)))));
            this.songVolumen.Location = new System.Drawing.Point(636, 49);
            this.songVolumen.MaximumValue = 100;
            this.songVolumen.Name = "songVolumen";
            this.songVolumen.Size = new System.Drawing.Size(131, 30);
            this.songVolumen.TabIndex = 1;
            this.songVolumen.Value = 0;
            // 
            // songTime
            // 
            this.songTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songTime.BackColor = System.Drawing.Color.Transparent;
            this.songTime.BackgroudColor = System.Drawing.Color.DarkGray;
            this.songTime.BorderRadius = 5;
            this.songTime.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(184)))));
            this.songTime.Location = new System.Drawing.Point(60, 4);
            this.songTime.MaximumValue = 100;
            this.songTime.Name = "songTime";
            this.songTime.Size = new System.Drawing.Size(707, 30);
            this.songTime.TabIndex = 0;
            this.songTime.Value = 0;
            // 
            // panelSongDisplay
            // 
            this.panelSongDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSongDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelSongDisplay.Controls.Add(this.SongList);
            this.panelSongDisplay.Controls.Add(this.panelSongs);
            this.panelSongDisplay.Location = new System.Drawing.Point(0, -3);
            this.panelSongDisplay.Name = "panelSongDisplay";
            this.panelSongDisplay.Size = new System.Drawing.Size(801, 347);
            this.panelSongDisplay.TabIndex = 1;
            // 
            // panelSongs
            // 
            this.panelSongs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelSongs.Controls.Add(this.button1);
            this.panelSongs.Controls.Add(this.panelSong);
            this.panelSongs.Location = new System.Drawing.Point(0, 3);
            this.panelSongs.Name = "panelSongs";
            this.panelSongs.Size = new System.Drawing.Size(435, 344);
            this.panelSongs.TabIndex = 0;
            // 
            // panelSong
            // 
            this.panelSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSong.Controls.Add(this.playTrenutnuPesmu);
            this.panelSong.Controls.Add(this.bunifuImageButton4);
            this.panelSong.Location = new System.Drawing.Point(0, 0);
            this.panelSong.Name = "panelSong";
            this.panelSong.Size = new System.Drawing.Size(434, 93);
            this.panelSong.TabIndex = 0;
            // 
            // playTrenutnuPesmu
            // 
            this.playTrenutnuPesmu.BackColor = System.Drawing.Color.Black;
            this.playTrenutnuPesmu.Image = ((System.Drawing.Image)(resources.GetObject("playTrenutnuPesmu.Image")));
            this.playTrenutnuPesmu.ImageActive = null;
            this.playTrenutnuPesmu.Location = new System.Drawing.Point(142, 35);
            this.playTrenutnuPesmu.Name = "playTrenutnuPesmu";
            this.playTrenutnuPesmu.Size = new System.Drawing.Size(32, 32);
            this.playTrenutnuPesmu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playTrenutnuPesmu.TabIndex = 9;
            this.playTrenutnuPesmu.TabStop = false;
            this.playTrenutnuPesmu.Zoom = 5;
            this.playTrenutnuPesmu.Click += new System.EventHandler(this.playTrenutnuPesmu_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(12, 15);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(83, 68);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 0;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SongList
            // 
            this.SongList.AccessibleName = "Songs";
            this.SongList.AllowDrop = true;
            this.SongList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongList.BackColor = System.Drawing.SystemColors.InfoText;
            this.SongList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(184)))));
            this.SongList.FormattingEnabled = true;
            this.SongList.Location = new System.Drawing.Point(440, 3);
            this.SongList.Name = "SongList";
            this.SongList.Size = new System.Drawing.Size(361, 342);
            this.SongList.TabIndex = 1;
            this.SongList.DragDrop += new System.Windows.Forms.DragEventHandler(this.SongList_DragDrop);
            this.SongList.DragEnter += new System.Windows.Forms.DragEventHandler(this.SongList_DragEnter);
            this.SongList.DoubleClick += new System.EventHandler(this.doubleKlikNapesmu);
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSongDisplay);
            this.Controls.Add(this.panelPlay);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Songs";
            this.Text = "Songs";
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzaberiPesme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pauza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napredMalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazadMalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaySong)).EndInit();
            this.panelSongDisplay.ResumeLayout(false);
            this.panelSongs.ResumeLayout(false);
            this.panelSong.ResumeLayout(false);
            this.panelSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playTrenutnuPesmu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Panel panelSongDisplay;
        private Bunifu.Framework.UI.BunifuSlider songTime;
        private Bunifu.Framework.UI.BunifuSlider songVolumen;
        private System.Windows.Forms.Label labelPesma;
        private System.Windows.Forms.Label labelPevac;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label timeToSongsEnd;
        private Bunifu.Framework.UI.BunifuImageButton PlaySong;
        private Bunifu.Framework.UI.BunifuImageButton napredMalo;
        private Bunifu.Framework.UI.BunifuImageButton nazadMalo;
        private System.Windows.Forms.Panel panelSongs;
        private System.Windows.Forms.Panel panelSong;
        private Bunifu.Framework.UI.BunifuImageButton playTrenutnuPesmu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton Pauza;
        private Bunifu.Framework.UI.BunifuImageButton IzaberiPesme;
        private Bunifu.Framework.UI.BunifuImageButton Mute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox SongList;
    }
}