﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LæreGreier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;
            //this.WindowState = FormWindowState.Maximized;
            ferdigBilde.Visible = false;
            lydSpiller.Visible = false; 
        }

        public static int poeng = 0;
        ferdigboks form2 = new ferdigboks();
        private Point MouseDownLocation;
        int startPosX = 0;
        int startPosY = 0;
        List<Image> bildeListe = new List<Image>();
        string path = "";
        bool erRiktig = false;
        int memeNummer = 1;

        private void BildePlassering()
        {
            int i = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            i = RandomizeBilder(0,4);
            bilde1.Image = bildeListe[i];
            do
            {
                a = RandomizeBilder(0, 4);
            } while (a == i);
            bilde2.Image = bildeListe[a];
            do
            {
                b = RandomizeBilder(0, 4);
            } while (b == i || b == a); 
            bilde3.Image = bildeListe[b];
            do
            {
                c = RandomizeBilder(0, 4);
            } while (c == i || c == a || c == b);
            bilde4.Image = bildeListe[c];
        }
        
        private int RandomizeBilder(int min,int max)
        {
            Random rnd = new Random();
            return rnd.Next(min,max);
        }

        private void TrykkePåBilde(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                startPosX = p.Left;
                startPosY = p.Top;
                p.BringToFront();
            }
        }

        private void SjekkRiktig()
        {
            ferdigBilde.Location = new System.Drawing.Point(437, 146);
            ferdigBilde.Size= new System.Drawing.Size(781, 460);

            if (memeNummer == 5)
            {
                form2.Show();
            }
            else if (erRiktig)
            {
                ferdigBilde.Image = Properties.Resources.HappyPepe;
                poeng++;
            }
            else if (!erRiktig)
            {
                ferdigBilde.Image = Properties.Resources.MadPepe;
            }
            ferdigBilde.Visible = true;
        }

        private void Dra(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                p.Left = e.X + p.Left - MouseDownLocation.X;
                p.Top = e.Y + p.Top - MouseDownLocation.Y;
            }
        }

        private void btnSjekk_Click(object sender, EventArgs e)
        {
            path = @"Bilder\Velgebilder\Oppgave 1";
            //form2.Show();
            try
            {
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.TopDirectoryOnly);

                foreach (var filename in files)
                {
                    Bitmap bmp = null;
                        bmp = new Bitmap(filename);
                        bildeListe.Add(bmp);                                    
                 }
                BildePlassering();
            }
            catch
            {
            }
        }

        private void Slipp(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;

            if (memeSjekk.Bounds.Contains(Cursor.Position))
            {
                memeSjekk.BackgroundImage = p.Image;
            }
            p.Left = startPosX;
            p.Top = startPosY;
        }

    }
}
