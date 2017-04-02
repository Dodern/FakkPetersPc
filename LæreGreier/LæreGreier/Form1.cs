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

        /* Metode som velger en tilfeldig plassering på bildene. Bildene blir lagt til i en liste og deretter
         blir den listen brukt for å lage plasseringen tilfeldig. Bildene blir hentet fra en mappe som inneholder
         bildene til den relevante memen. Gir et tilfeldig tall for hvert bile og gir bildene en plass
         i forhold til det tallet*/
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

        /* Event som skjer når man trykker på et av de fire alternativene, lagrer posisjonen til bildet 
        slik at det kan bli brukt senere*/
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

        /* Metode som sjekker om brukeren har valgt riktig bilde. Sjekker om det bildet som brukeren dro inn på memeSjekk panelet
         er det riktige bildet, vil spille av lyder og vise et bilde basert på om svaret er riktig eller galt*/
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

        /* Event som skjer når du klikker på en av de fire alternativene og drar den rundt. 
         Posisjonen til det venstre hjørnet i bildet blir det samme som der musen er pluss lengden
         og høyden på det valgte bildet. Gjør så bildet synlig kan bli dratt rundt*/
        private void Dra(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                p.Left = e.X + p.Left;
                p.Top = e.Y + p.Top;
            }
        }

        /* Metode som skal finne bilder. Finner bildene fra en mappe i forhold til memeNummer. memeNummer blir brukt for
         å finne den riktige mappen og henter bildene fra den*/
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

        //Metode som blir brukt for å oppdatere poeng og finne nye bilder etter du har klikket på neste knappen
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

        /* Event som skjer når du slipper den valgte bildet du har dratt rundt. Hvis musen er over memeSjekk når du slipper,
         så vil den sjekke bildet, hvis den er noe annet sted så vil bildet gå tilbake dit det startet*/
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

        //Den genererte knappen som kommer etter du har sjekket bildet via btnSjekk
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
            //Generer en knapp som kommer etter du har sjekket svar via btnSjekk
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
