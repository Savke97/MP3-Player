using System;
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
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        String[] paths, files;
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
            player.URL = paths[SongList.SelectedIndex];
            player.controls.play();
            player.settings.volume = 50;
            songVolumen.Value = 50;
        }

        //Dugme za play u listi
        private void playTrenutnuPesmu_Click(object sender, EventArgs e)
        {
            player.URL = paths[SongList.SelectedIndex];
            player.controls.play();
        }
        //Dugme za play 
        private void PlaySong_Click(object sender, EventArgs e)
        {
            player.URL = paths[SongList.SelectedIndex];
            player.controls.play();
        }

        

        private void Mute_Click(object sender, EventArgs e)
        {
            if(player.settings.mute == false)
            {
                player.settings.mute = true;
                Mute.Image = MP3_Player.Properties.Resources.mute;
            }
            else
            {
                Mute.Image = MP3_Player.Properties.Resources.audio;
                player.settings.mute = false;
            }
        }

        
    }
}
