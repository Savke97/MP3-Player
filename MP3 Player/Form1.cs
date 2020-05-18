﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Player
{
    public partial class Form1 : Form
    {
        private Button trenutnoDugme;
        private Random random;
        private int tempIndex;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }  
        

        private Color SelektujBojuTheme()
        {
            int index = random.Next(ThemeColor.listaBoja.Count);
            //Ako je boja vec selektovana da selektujemo drugu
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.listaBoja.Count);
            }
            tempIndex = index;
            string boja = ThemeColor.listaBoja[index];
            return ColorTranslator.FromHtml(boja);
        }

        private void AktiviranoDugme(object btnSender)
        {
            if(btnSender != null)
            {
                if(trenutnoDugme != (Button)btnSender)
                {
                    Deaktivirajdugme();
                    Color boja = SelektujBojuTheme();
                    trenutnoDugme = (Button)btnSender;
                    trenutnoDugme.BackColor = boja;
                    trenutnoDugme.ForeColor = Color.White;
                    trenutnoDugme.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Deaktivirajdugme()
        {
            foreach(Control predhodnoDugme in Options.Controls)
            {
                if(predhodnoDugme.GetType() == typeof(Button))
                {
                    predhodnoDugme.BackColor = Color.FromArgb(51, 51, 76);
                    predhodnoDugme.ForeColor = Color.Gainsboro;
                    predhodnoDugme.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Boja(object btnSender, string n)
        {
            trenutnoDugme = (Button)btnSender;
            trenutnoDugme.BackColor = ColorTranslator.FromHtml(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AktiviranoDugme(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AktiviranoDugme(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AktiviranoDugme(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AktiviranoDugme(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AktiviranoDugme(sender);
        }


        //Dugme za Gasenje programa
        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button6_Hover(object sender, EventArgs e)
        {
            Boja(sender, "173, 44, 29");
        }
        private void button6_Leave(object sender, EventArgs e)
        {
            Boja(sender, "51, 51, 76");
        }


        // Dugme za Uvelicavanje i smanjivanje
        private void button7_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            Boja(sender, "51, 51, 76");
        }
        private void button7_MouseHover(object sender, EventArgs e)
        {
            Boja(sender, "217, 187, 15");
        }


        //Dugme za Minimiziranje
        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            Boja(sender, "51, 51, 76");
        }
        private void button8_MouseHover(object sender, EventArgs e)
        {
            Boja(sender, "42, 153, 23");
        }
    }
}
