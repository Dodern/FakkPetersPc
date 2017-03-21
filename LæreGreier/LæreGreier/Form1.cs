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

        int forrigeX = 0;
        int forrigeY = 0;
        public static int poeng = 0;
        ferdigboks form2 = new ferdigboks();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void memeSjekk_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void memeSjekk_DragDrop(object sender, DragEventArgs e)
        {
            e.Data.GetData(DataFormats.FileDrop, false);
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            memeSjekk.BackgroundImage = bmp;
        }


        private void bilde1_MouseDown(object sender, MouseEventArgs e)
        {
            var img = bilde1.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            { }
        }

        private void bilde2_MouseDown(object sender, MouseEventArgs e)
        {
            var img = bilde2.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            { }
        }

        private void bilde3_MouseDown(object sender, MouseEventArgs e)
        {
            var img = bilde3.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
            }
        }

        private void bilde4_MouseDown(object sender, MouseEventArgs e)
        {
            var img = bilde4.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
            }
        }

        private void btnSjekk_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        /*private void bilde3_DragOver(object sender, DragEventArgs e)
        {
            if (e.X != forrigeX || e.Y != forrigeY)
            {
                bilde3.Location = new Point(e.X, e.Y);
                forrigeX = e.X;
                forrigeY = e.Y;
            }
        }*/
    }
}
