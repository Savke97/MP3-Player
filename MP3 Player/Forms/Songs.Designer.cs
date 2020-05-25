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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Songs));
            this.panelPlay = new System.Windows.Forms.Panel();
            this.Mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.IzaberiPesme = new Bunifu.Framework.UI.BunifuImageButton();
            this.Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.sledecaPesma = new Bunifu.Framework.UI.BunifuImageButton();
            this.predhodnaPesma = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlaySong = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelPesma = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timeToSongsEnd = new System.Windows.Forms.Label();
            this.songVolumen = new Bunifu.Framework.UI.BunifuSlider();
            this.songTime = new Bunifu.Framework.UI.BunifuSlider();
            this.panelSongDisplay = new System.Windows.Forms.Panel();
            this.panelSongs = new System.Windows.Forms.Panel();
            this.player2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzaberiPesme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sledecaPesma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predhodnaPesma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaySong)).BeginInit();
            this.panelSongDisplay.SuspendLayout();
            this.panelSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPlay
            // 
            this.panelPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelPlay.Controls.Add(this.Mute);
            this.panelPlay.Controls.Add(this.IzaberiPesme);
            this.panelPlay.Controls.Add(this.Stop);
            this.panelPlay.Controls.Add(this.sledecaPesma);
            this.panelPlay.Controls.Add(this.predhodnaPesma);
            this.panelPlay.Controls.Add(this.PlaySong);
            this.panelPlay.Controls.Add(this.labelPesma);
            this.panelPlay.Controls.Add(this.labelTime);
            this.panelPlay.Controls.Add(this.timeToSongsEnd);
            this.panelPlay.Controls.Add(this.songVolumen);
            this.panelPlay.Controls.Add(this.songTime);
            this.panelPlay.Location = new System.Drawing.Point(-3, 430);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(768, 105);
            this.panelPlay.TabIndex = 0;
            // 
            // Mute
            // 
            this.Mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Mute.BackColor = System.Drawing.Color.Black;
            this.Mute.Image = ((System.Drawing.Image)(resources.GetObject("Mute.Image")));
            this.Mute.ImageActive = null;
            this.Mute.Location = new System.Drawing.Point(536, 46);
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
            this.IzaberiPesme.Location = new System.Drawing.Point(490, 46);
            this.IzaberiPesme.Name = "IzaberiPesme";
            this.IzaberiPesme.Size = new System.Drawing.Size(32, 32);
            this.IzaberiPesme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IzaberiPesme.TabIndex = 11;
            this.IzaberiPesme.TabStop = false;
            this.IzaberiPesme.Zoom = 10;
            this.IzaberiPesme.Click += new System.EventHandler(this.IzaberiPesme_Click_1);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Black;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.ImageActive = null;
            this.Stop.Location = new System.Drawing.Point(147, 46);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(32, 32);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Stop.TabIndex = 10;
            this.Stop.TabStop = false;
            this.Stop.Zoom = 5;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // sledecaPesma
            // 
            this.sledecaPesma.BackColor = System.Drawing.Color.Black;
            this.sledecaPesma.Image = ((System.Drawing.Image)(resources.GetObject("sledecaPesma.Image")));
            this.sledecaPesma.ImageActive = null;
            this.sledecaPesma.Location = new System.Drawing.Point(98, 49);
            this.sledecaPesma.Name = "sledecaPesma";
            this.sledecaPesma.Size = new System.Drawing.Size(24, 24);
            this.sledecaPesma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sledecaPesma.TabIndex = 8;
            this.sledecaPesma.TabStop = false;
            this.sledecaPesma.Zoom = 10;
            this.sledecaPesma.Click += new System.EventHandler(this.sledecaPesma_Click);
            // 
            // predhodnaPesma
            // 
            this.predhodnaPesma.BackColor = System.Drawing.Color.Black;
            this.predhodnaPesma.Image = ((System.Drawing.Image)(resources.GetObject("predhodnaPesma.Image")));
            this.predhodnaPesma.ImageActive = null;
            this.predhodnaPesma.Location = new System.Drawing.Point(30, 49);
            this.predhodnaPesma.Name = "predhodnaPesma";
            this.predhodnaPesma.Size = new System.Drawing.Size(24, 24);
            this.predhodnaPesma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.predhodnaPesma.TabIndex = 7;
            this.predhodnaPesma.TabStop = false;
            this.predhodnaPesma.Zoom = 10;
            this.predhodnaPesma.Click += new System.EventHandler(this.predhodnaPesma_Click);
            // 
            // PlaySong
            // 
            this.PlaySong.BackColor = System.Drawing.Color.Black;
            this.PlaySong.Image = ((System.Drawing.Image)(resources.GetObject("PlaySong.Image")));
            this.PlaySong.ImageActive = null;
            this.PlaySong.Location = new System.Drawing.Point(60, 46);
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
            this.labelPesma.Location = new System.Drawing.Point(193, 56);
            this.labelPesma.Name = "labelPesma";
            this.labelPesma.Size = new System.Drawing.Size(0, 13);
            this.labelPesma.TabIndex = 4;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTime.Location = new System.Drawing.Point(726, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 3;
            // 
            // timeToSongsEnd
            // 
            this.timeToSongsEnd.AutoSize = true;
            this.timeToSongsEnd.ForeColor = System.Drawing.Color.GhostWhite;
            this.timeToSongsEnd.Location = new System.Drawing.Point(26, 10);
            this.timeToSongsEnd.Name = "timeToSongsEnd";
            this.timeToSongsEnd.Size = new System.Drawing.Size(0, 13);
            this.timeToSongsEnd.TabIndex = 2;
            // 
            // songVolumen
            // 
            this.songVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.songVolumen.BackColor = System.Drawing.Color.Transparent;
            this.songVolumen.BackgroudColor = System.Drawing.Color.DarkGray;
            this.songVolumen.BorderRadius = 5;
            this.songVolumen.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(184)))));
            this.songVolumen.Location = new System.Drawing.Point(584, 49);
            this.songVolumen.MaximumValue = 100;
            this.songVolumen.Name = "songVolumen";
            this.songVolumen.Size = new System.Drawing.Size(131, 30);
            this.songVolumen.TabIndex = 1;
            this.songVolumen.Value = 0;
            this.songVolumen.ValueChanged += new System.EventHandler(this.songVolumen_ValueChanged);
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
            this.songTime.Size = new System.Drawing.Size(655, 30);
            this.songTime.TabIndex = 0;
            this.songTime.Value = 0;
            this.songTime.ValueChanged += new System.EventHandler(this.songTime_ValueChanged);
            // 
            // panelSongDisplay
            // 
            this.panelSongDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSongDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelSongDisplay.Controls.Add(this.panelSongs);
            this.panelSongDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelSongDisplay.Name = "panelSongDisplay";
            this.panelSongDisplay.Size = new System.Drawing.Size(765, 428);
            this.panelSongDisplay.TabIndex = 1;
            // 
            // panelSongs
            // 
            this.panelSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelSongs.Controls.Add(this.player2);
            this.panelSongs.Location = new System.Drawing.Point(-3, 0);
            this.panelSongs.Name = "panelSongs";
            this.panelSongs.Size = new System.Drawing.Size(768, 428);
            this.panelSongs.TabIndex = 0;
            // 
            // player2
            // 
            this.player2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2.Enabled = true;
            this.player2.Location = new System.Drawing.Point(0, 0);
            this.player2.Name = "player2";
            this.player2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player2.OcxState")));
            this.player2.Size = new System.Drawing.Size(768, 431);
            this.player2.TabIndex = 0;
            this.player2.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player2_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.listBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSongs.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.ForeColor = System.Drawing.Color.White;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 14;
            this.listBoxSongs.Location = new System.Drawing.Point(767, 0);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(202, 532);
            this.listBoxSongs.TabIndex = 2;
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(970, 534);
            this.Controls.Add(this.listBoxSongs);
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
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sledecaPesma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predhodnaPesma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaySong)).EndInit();
            this.panelSongDisplay.ResumeLayout(false);
            this.panelSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Panel panelSongDisplay;
        private Bunifu.Framework.UI.BunifuSlider songTime;
        private Bunifu.Framework.UI.BunifuSlider songVolumen;
        private System.Windows.Forms.Label labelPesma;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label timeToSongsEnd;
        private Bunifu.Framework.UI.BunifuImageButton PlaySong;
        private Bunifu.Framework.UI.BunifuImageButton sledecaPesma;
        private Bunifu.Framework.UI.BunifuImageButton predhodnaPesma;
        private Bunifu.Framework.UI.BunifuImageButton Stop;
        private Bunifu.Framework.UI.BunifuImageButton IzaberiPesme;
        private Bunifu.Framework.UI.BunifuImageButton Mute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelSongs;
        private AxWMPLib.AxWindowsMediaPlayer player2;
        private System.Windows.Forms.ListBox listBoxSongs;
    }
}