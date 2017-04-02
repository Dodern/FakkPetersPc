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

            //this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            ferdigBilde.Visible = false;
            lydSpiller.Visible = false;
            neste.Visible = false;
        }

        public static int endeligPoeng = 0;
        int poeng = 0;
        ferdigboks form2 = new ferdigboks();
        private Point MouseDownLocation;
        int startPosX = 0;
        int startPosY = 0;
        List<Image> bildeListe = new List<Image>();
        List<Image> memeListe = new List<Image>();
        bool erRiktig = false;
        public static int memeNummer = 1;
        Button neste = new System.Windows.Forms.Button();

        private void Randomize_Bilder()
        {
            try
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
            catch
            {}
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
            }
        }

        private void SjekkRiktig()
        {
            ferdigBilde.Location = new System.Drawing.Point(437, 146);
            ferdigBilde.Size= new System.Drawing.Size(781, 460);

            if (memeSjekk.BackgroundImage == bildeListe[3])
            {
                erRiktig = true;
            }
            else
            {
                erRiktig = false;
            }

            if (memeNummer >= 6)
            {
                neste.Text = "Fullfør spillet";            
            }
            else if (erRiktig)
            {
                ferdigBilde.Image = Properties.Resources.HappyPepe;
                try
                {
                    lydSpiller.URL = "Lyd\\positivLyd.mp3";
                }
                catch
                {}               
                poeng++;
            }
            else if (!erRiktig)
            {
                ferdigBilde.Image = Properties.Resources.MadPepe;
                try
                {
                    lydSpiller.URL = "Lyd\\negativLyd.mp3";
                }
                catch
                {}
            }
            ferdigBilde.Visible = true;
        }

        private void Dra(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                p.Left = e.X + p.Left;
                p.Top = e.Y + p.Top;
            }
        }

        private void Finn_Bilder()
        {
            bildeListe.Clear();
            memeListe.Clear();      
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

                string[] memeFiles = Directory.GetFiles(memePath, "*.jpg", SearchOption.TopDirectoryOnly);

                foreach (var filename in memeFiles)
                {
                    Bitmap bmp = null;
                    bmp = new Bitmap(filename);
                    memeListe.Add(bmp);
                }
                meme1.Width = memeListe[0].Width;
                meme1.Height = memeListe[0].Height;
                meme1.Image = memeListe[0];              
            }
            catch
            {
            }
        }
        
        public void Neste_Meme()
        {            
            Randomize_Bilder();
            ferdigBilde.Visible = false;
            neste.Visible = false;
            btnSjekk.Enabled = true;
            memeSjekk.BackgroundImage = null;
            lbPoeng.Text = "Poeng: " + poeng;
        }

        private void btnSjekk_Click(object sender, EventArgs e)
        {
            SjekkRiktig();
            btnSjekk.Enabled = false;
            neste.Visible = true;       
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

        private void neste_Click(object sender, EventArgs e)
        {
            memeNummer++;
            if (memeNummer >= 6)
            {
                endeligPoeng = poeng;
                poeng = 0;
                form2.Show();
                neste.Text = "Neste meme";
                memeNummer = 1;
                Randomize_Bilder();
                lbPoeng.Text = "Poeng: " + poeng;
                Neste_Meme();

            }
            else
            {
                Neste_Meme();
            }           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Randomize_Bilder();
            neste.Location = new System.Drawing.Point(437 + 15, 146 + 400);
            neste.Name = "Neste";
            neste.Size = new System.Drawing.Size(100, 50);
            neste.TabIndex = 18;
            neste.Text = "Neste meme";
            neste.UseVisualStyleBackColor = true;
            neste.Click += new System.EventHandler(this.neste_Click);
            Controls.Add(this.neste);          
            Neste_Meme();
            neste.BringToFront();
        }
    }
}
