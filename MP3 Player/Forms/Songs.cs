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
        Timer t;
        public Songs()
        {
            InitializeComponent();
        }

        // Za drag i drop opciju kod
        private void SongList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void SongList_DragEnter(object sender, DragEventArgs e)
        {
            string[] dropFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            
            paths = (string[])e.Data.GetData(DataFormats.FileDrop);
           

            foreach (string file in dropFiles)
            {
                string fileName = getFileName(file);
                SongList.Items.Add(fileName);
            }
        }

        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        // Za ubacivanje preko dugmeta
        private void IzaberiPesme_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();

            fDialog.Multiselect = true;
            if (fDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = fDialog.SafeFileNames;
                paths = fDialog.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    SongList.Items.Add(files[i]);
                }
            }
        }


        // za dubel klik da se iz liste pusmi pesma
        private void doubleKlikNapesmu(object sender, EventArgs e)
        {
            player2.URL = paths[SongList.SelectedIndex];
            player2.Ctlcontrols.play();
            labelPesma.Text = files[SongList.SelectedIndex];
        }
        //Dugme za play 
        private void PlaySong_Click(object sender, EventArgs e)
        {
            player2.URL = paths[SongList.SelectedIndex];
            player2.Ctlcontrols.play();
            labelPesma.Text = files[SongList.SelectedIndex];
        }

        

        private void songVolumen_ValueChanged(object sender, EventArgs e)
        {
            player2.settings.volume = songVolumen.Value;
        }

        private void Pauza_Click(object sender, EventArgs e)
        {
            player2.Ctlcontrols.stop();
        }

        private void songTime_ValueChanged(object sender, EventArgs e)
        {
            this.player2.Ctlcontrols.currentPosition = songTime.Value;
        }

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
