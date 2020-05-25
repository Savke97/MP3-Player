using AxWMPLib;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MP3_Player.Forms
{
    public partial class Songs : Form
    {
        String[] paths, files;
        int index = 0, br = 0;
        public Songs()
        {
            InitializeComponent();
            player2.uiMode = "None";
        }

        //Vraca indeks trenutne pesme u playlisti
        private int indeksTrenutnrPesme(AxWindowsMediaPlayer p)
        {
            for (int i = 0; i < p.currentPlaylist.count; i++)
            {
                if (player2.currentMedia.isIdentical[p.currentPlaylist.Item[i]])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // Za ubacivanje preko pesama
        private void IzaberiPesme_Click_1(object sender, EventArgs e)
        {
            WMPLib.IWMPPlaylist playlist = player2.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia media;
            OpenFileDialog fDialog = new OpenFileDialog();

            //Samo da moze da se ubacuje mp3 i ostali muzicki failovi
            fDialog.Filter = "MP3|*.mp3";


            //Da moze vise od jedne pesme da se ubaci od jednom
            fDialog.Multiselect = true;

            //Ubacivanje u kreiranu playListu
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                files = fDialog.SafeFileNames;
                paths = fDialog.FileNames;
                foreach (string file in fDialog.FileNames)
                {
                    media = player2.newMedia(file);
                    playlist.appendItem(media);
                    br++;
                }
            }

            player2.currentPlaylist = playlist;
            index = indeksTrenutnrPesme(player2);
            labelPesma.Text = files[index];


            //Za display u listBoxSong
            for (int i = 0; i < playlist.count; i++)
            {
                string strItemName = playlist.get_Item(i).name;
                listBoxSongs.Items.Add(strItemName);
            }
            

        }

        //Dugme za play i pauzu
        private void PlaySong_Click(object sender, EventArgs e)
        {
            if(player2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player2.Ctlcontrols.pause();
            }
            else
            {
                player2.Ctlcontrols.play();
            }
        }

        //Za kontrolu zvuka
        private void songVolumen_ValueChanged(object sender, EventArgs e)
        {
            player2.settings.volume = songVolumen.Value;
        }


        //Dugme da se psema zaustavi
        private void Stop_Click(object sender, EventArgs e)
        {
            player2.Ctlcontrols.stop();
        }


        //Code za tracBar, da moze da prati trajnost pesme
        //Kao i ako je pesma pauzirana da se dugme za play promeni u paus btn i okrenuto
        private void player2_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(player2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlaySong.Image = MP3_Player.Properties.Resources.pause_button;
                songVolumen.Value = 50;
                songTime.MaximumValue = (int)player2.Ctlcontrols.currentItem.duration;
                timer1.Start();
                index = indeksTrenutnrPesme(player2);
                labelPesma.Text = files[index];
            }
            else if(player2.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                PlaySong.Image = MP3_Player.Properties.Resources.multimedia;
                timer1.Stop();
            }
            else if(player2.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                PlaySong.Image = MP3_Player.Properties.Resources.multimedia;
                timer1.Stop();
                songTime.Value = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeToSongsEnd.Text = player2.Ctlcontrols.currentPositionString;
            labelTime.Text = player2.Ctlcontrols.currentItem.durationString.ToString();
            if (player2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                songTime.Value = (int)player2.Ctlcontrols.currentPosition;
            }
        }


        //Za prebacivanje na sledecu pesmu
        private void sledecaPesma_Click(object sender, EventArgs e)
        {
            player2.Ctlcontrols.next();
            index = indeksTrenutnrPesme(player2);
            labelPesma.Text = files[index];
        }

        //Za vracanje na predhodnu pesmu
        private void predhodnaPesma_Click(object sender, EventArgs e)
        {
            player2.Ctlcontrols.previous();
            index = indeksTrenutnrPesme(player2);
            labelPesma.Text = files[index];
        }

        //Za kontrolu vremena u pesmi
        private void songTime_ValueChanged(object sender, EventArgs e)
        {
            player2.Ctlcontrols.currentPosition = songTime.Value;
        }


        //Za mutovanje zvuka
        private void Mute_Click(object sender, EventArgs e)
        {
            if(player2.settings.mute == false)
            {
                player2.settings.mute = true;
                Mute.Image = MP3_Player.Properties.Resources.mute;
            }
            else
            {
                Mute.Image = MP3_Player.Properties.Resources.audio;
                player2.settings.mute = false;
            }
        }
    }
}
