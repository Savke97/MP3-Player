
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MP3_Player
{
    class PomeranjeProzora : Control
    {
        private Control izvrsiPomeranje;

        public Control IzaberiKontrolu
        {
            get
            {
                return this.izvrsiPomeranje;
            }
            set
            {
                this.izvrsiPomeranje = value;
                this.izvrsiPomeranje.MouseDown += new MouseEventHandler(this.DragForm_MousDown);
            }
        }
        // import funkcije za dodeljvonje kontrole nekoj formi
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(System.IntPtr a, int msg, int wParm, int lParm);

        // importovanje metode ReleaseCapture koja oslobadja prozor kad levi klik nije stisnut
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern bool ReleaseCapture();
        private void DragForm_MousDown(object sender, MouseEventArgs e)
        {
            // osigurava da je levi klik stisnut
            bool flag = e.Button == MouseButtons.Left;
            // ako jeste pokrecu se ove dve funkcije koje su importovane
            if (flag)
            {
                PomeranjeProzora.ReleaseCapture();
                PomeranjeProzora.SendMessage(this.IzaberiKontrolu.FindForm().Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
