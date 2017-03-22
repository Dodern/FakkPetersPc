using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LæreGreier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        public static int poeng = 0;
        ferdigboks form2 = new ferdigboks();
        private Point MouseDownLocation;
        int startPosX = 0;
        int startPosY = 0;

        private void BildePlassering()
        {
            int i = 0;
            i = RandomizeBilder(1, 16);
            if (i <= 4 && i >= 1)
            {
                bilde1.ImageLocation = "Bock.jpg";
                //bilde1.ImageLocation = "C:\Users\jacob\Documents\GitHub\FakkPetersPc\LæreGreier\Bilder\Velgebilder\Oppgave 1";
            }
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
            form2.Show();
            bilde2.ImageLocation  = "Bock.jpg";
            MessageBox.Show(RandomizeBilder(1,16).ToString());
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
