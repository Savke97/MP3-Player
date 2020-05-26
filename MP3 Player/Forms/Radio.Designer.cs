namespace MP3_Player.Forms
{
    partial class Radio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radio));
            this.panelPlay = new System.Windows.Forms.Panel();
            this.Mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.IzaberiPesme = new Bunifu.Framework.UI.BunifuImageButton();
            this.Stop = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlaySong = new Bunifu.Framework.UI.BunifuImageButton();
            this.timeToSongsEnd = new System.Windows.Forms.Label();
            this.songVolumen = new Bunifu.Framework.UI.BunifuSlider();
            this.player2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzaberiPesme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaySong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPlay
            // 
            this.panelPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelPlay.Controls.Add(this.Mute);
            this.panelPlay.Controls.Add(this.IzaberiPesme);
            this.panelPlay.Controls.Add(this.Stop);
            this.panelPlay.Controls.Add(this.PlaySong);
            this.panelPlay.Controls.Add(this.timeToSongsEnd);
            this.panelPlay.Controls.Add(this.songVolumen);
            this.panelPlay.Location = new System.Drawing.Point(-1, 440);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(781, 118);
            this.panelPlay.TabIndex = 1;
            // 
            // Mute
            // 
            this.Mute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Mute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Mute.Image = ((System.Drawing.Image)(resources.GetObject("Mute.Image")));
            this.Mute.ImageActive = null;
            this.Mute.Location = new System.Drawing.Point(612, 37);
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
            this.IzaberiPesme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.IzaberiPesme.Image = ((System.Drawing.Image)(resources.GetObject("IzaberiPesme.Image")));
            this.IzaberiPesme.ImageActive = null;
            this.IzaberiPesme.Location = new System.Drawing.Point(574, 37);
            this.IzaberiPesme.Name = "IzaberiPesme";
            this.IzaberiPesme.Size = new System.Drawing.Size(32, 32);
            this.IzaberiPesme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IzaberiPesme.TabIndex = 11;
            this.IzaberiPesme.TabStop = false;
            this.IzaberiPesme.Zoom = 10;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.ImageActive = null;
            this.Stop.Location = new System.Drawing.Point(53, 37);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(32, 32);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Stop.TabIndex = 10;
            this.Stop.TabStop = false;
            this.Stop.Zoom = 5;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // PlaySong
            // 
            this.PlaySong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PlaySong.Image = ((System.Drawing.Image)(resources.GetObject("PlaySong.Image")));
            this.PlaySong.ImageActive = null;
            this.PlaySong.Location = new System.Drawing.Point(3, 37);
            this.PlaySong.Name = "PlaySong";
            this.PlaySong.Size = new System.Drawing.Size(32, 32);
            this.PlaySong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlaySong.TabIndex = 6;
            this.PlaySong.TabStop = false;
            this.PlaySong.Zoom = 5;
            this.PlaySong.Click += new System.EventHandler(this.PlaySong_Click);
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
            this.songVolumen.Location = new System.Drawing.Point(650, 39);
            this.songVolumen.MaximumValue = 100;
            this.songVolumen.Name = "songVolumen";
            this.songVolumen.Size = new System.Drawing.Size(131, 30);
            this.songVolumen.TabIndex = 1;
            this.songVolumen.Value = 0;
            this.songVolumen.ValueChanged += new System.EventHandler(this.songVolumen_ValueChanged);
            // 
            // player2
            // 
            this.player2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2.Enabled = true;
            this.player2.Location = new System.Drawing.Point(-1, 0);
            this.player2.Name = "player2";
            this.player2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player2.OcxState")));
            this.player2.Size = new System.Drawing.Size(781, 486);
            this.player2.TabIndex = 2;
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
            this.listBoxSongs.Location = new System.Drawing.Point(781, 6);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(206, 546);
            this.listBoxSongs.TabIndex = 3;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(986, 556);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.player2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Radio";
            this.Text = "Radio";
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzaberiPesme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaySong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlay;
        private Bunifu.Framework.UI.BunifuImageButton Mute;
        private Bunifu.Framework.UI.BunifuImageButton IzaberiPesme;
        private Bunifu.Framework.UI.BunifuImageButton Stop;
        private Bunifu.Framework.UI.BunifuImageButton PlaySong;
        private System.Windows.Forms.Label timeToSongsEnd;
        private Bunifu.Framework.UI.BunifuSlider songVolumen;
        private AxWMPLib.AxWindowsMediaPlayer player2;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}