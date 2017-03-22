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
        }

        public static int poeng = 0;
        ferdigboks form2 = new ferdigboks();
        private Point MouseDownLocation;
        int startPosX = 0;
        int startPosY = 0;
        List<Image> bildeListe = new List<Image>();

        private void BildePlassering()
        {
            int i = 0;
            i = RandomizeBilder(1, 16);
            if (i <= 4 && i >= 1)
            {
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
            try
            {
                var files = Directory.GetFiles(@"C:\Users\jacob\Documents\GitHub\FakkPetersPc\LæreGreier\Resources\Bilder\Velgebilder","*.*",
                    SearchOption.AllDirectories).Where(s => s.EndsWith(".jpg") || s.EndsWith (".png"));
                
                foreach (string filename in files)
                {
                    Bitmap B = new Bitmap(filename);
                    bildeListe.Add(B);
                }
                bilde2.Image = bildeListe[0];
            }
            catch
            {
            }
            MessageBox.Show(RandomizeBilder(0,4).ToString());
            
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
