using System;
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
        List<Image> memeListe = new List<Image>();
        bool erRiktig = false;
        int memeNummer = 1;

        private void Randomize_Bilder()
        {
            Finn_Bilder();

                int i = 0;
                int a = 0;
                int b = 0;
                int c = 0;
                i = RandomTall(0, 4);
                bilde1.Image = bildeListe[i];
                do
                {
                    a = RandomTall(0, 4);
                } while (a == i);
                bilde2.Image = bildeListe[a];
                do
                {
                    b = RandomTall(0, 4);
                } while (b == i || b == a);
                bilde3.Image = bildeListe[b];
                do
                {
                    c = RandomTall(0, 4);
                } while (c == i || c == a || c == b);
                bilde4.Image = bildeListe[c];
        }
        
        private int RandomTall(int min,int max)
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
<<<<<<< HEAD
            ferdigBilde.Visible = true;           
=======
            ferdigBilde.Visible = true;
>>>>>>> origin/master
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

        private void Finn_Bilder()
        {         
            try
            {
                string bildePath = @"Bilder\Velgebilder\Oppgave " + memeNummer;                             
                string[] bildeFiles = Directory.GetFiles(bildePath, "*.jpg", SearchOption.TopDirectoryOnly);

                foreach (var filename in bildeFiles)
                {
                    Bitmap bmp = null;
                    bmp = new Bitmap(filename);
                    bildeListe.Add(bmp);
                }

                string memePath = @"Bilder\Memes\Oppgave " + memeNummer;

                string[] memeFiles = Directory.GetFiles(bildePath, "*.jpg", SearchOption.TopDirectoryOnly);

                foreach (var filename in memeFiles)
                {
                    Bitmap bmp = null;
                    bmp = new Bitmap(filename);
                    memeListe.Add(bmp);
                }
                meme1.Image = memeListe[0];
                meme2.Image = memeListe[1];
                meme3.Image = memeListe[2];
            }
            catch
            {
            }
        }
        
        private void Neste_Meme()
        {
            Randomize_Bilder();
        }

        private void btnSjekk_Click(object sender, EventArgs e)
        {
            SjekkRiktig();
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

<<<<<<< HEAD
        private void btnNeste_Click(object sender, EventArgs e)
        {
            memeNummer++;
            Neste_Meme();
            ferdigBilde.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Randomize_Bilder();
        }
=======
>>>>>>> origin/master
    }
}
