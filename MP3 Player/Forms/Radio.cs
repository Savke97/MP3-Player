using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Player.Forms
{
    public partial class Radio : Form
    {
        string[] strItemName = new string[11];

        public Radio()
        {
            InitializeComponent();
            string[] imeStanice = new string[11];

            strItemName[0] = "https://stream.playradio.rs:8443/play.aac";
            strItemName[1] = "http://streaming.tdiradio.com:8000/tdiradiobezreklama.mp3";
            strItemName[2] = "https://streaming.hitfm.rs/hit.mp3";
            strItemName[3] = "https://stream.playradio.rs:8443/party.aac";
            strItemName[4] = "http://naxi64.streaming.rs:9160/;stream.nsv";
            strItemName[5] = "https://securestreams3.autopo.st:1423/;*.mp3";
            strItemName[6] = "https://sradio1.ipradio.rs:9000/;*.mp3";
            strItemName[7] = "https://radio3-64ssl.streaming.rs:9212/;*.mp3";
            strItemName[8] = "https://live.radioskay.com/;*.mp3";
            strItemName[9] = "https://gal.bitsyu.net/8102.php";
            strItemName[10] = "https://eu4.fastcast4u.com/proxy/svidakov?mp=/1";

            imeStanice[0] = "Play Radio";
            imeStanice[1] = "TDI";
            imeStanice[2] = "HIT FM";
            imeStanice[3] = "Play Radio Party";
            imeStanice[4] = "Naxi Radio";
            imeStanice[5] = "Ok Radio";
            imeStanice[6] = "S Radio";
            imeStanice[7] = "Radio 3";
            imeStanice[8] = "Radio Sky";
            imeStanice[9] = "Bum Radio";
            imeStanice[10] = "Moj Radio";

            for (int i = 0; i<11; i++)
            {
                listBoxSongs.Items.Add(imeStanice[i]);
            }
            songVolumen.Value = 50;
        }


        //Za Pustanje izabrane stanice
        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = listBoxSongs.SelectedIndex;
            player2.URL = strItemName[indeks];
            player2.Ctlcontrols.play();
        }


        // Za stopiranje radio stanice
        private void Stop_Click(object sender, EventArgs e)
        {
            player2.Ctlcontrols.stop();
        }


        //Kontrola zvuka
        private void songVolumen_ValueChanged(object sender, EventArgs e)
        {
            player2.settings.volume = songVolumen.Value;
        }

        //Mute zvuk
        private void Mute_Click(object sender, EventArgs e)
        {
            if (player2.settings.mute == false)
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

        //Pauza i ponovno pustanje
        private void PlaySong_Click(object sender, EventArgs e)
        {
            if (player2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player2.Ctlcontrols.pause();
                PlaySong.Image = MP3_Player.Properties.Resources.pause_button;
            }
            else
            {
                player2.Ctlcontrols.play();
                PlaySong.Image = MP3_Player.Properties.Resources.multimedia;
            }
        }
    }
}