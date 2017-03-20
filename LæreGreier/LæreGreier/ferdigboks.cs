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
    public partial class ferdigboks : Form
    {
        public ferdigboks()
        {
            InitializeComponent();
        }

        Button avslutt = new System.Windows.Forms.Button(); 

        private void ferdigboks_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized; 

            if (Form1.poeng == 5)
            {
                label1.Text = "Gratulerer! Du fikk full score. Kos deg med en bra boi.";
                pictureBox1.Image = Properties.Resources.braDatBoi;
            }
            else if (Form1.poeng == 3 || Form1.poeng == 4)
            {
                label1.Text = "Dette var ok. Ha deg en middels boi.";
                pictureBox1.Image = Properties.Resources.okDatBoi;
            }
            else if (Form1.poeng <= 2)
            {
                label1.Text = "Dette var dritt. Her har du en dårlig boi.";
                pictureBox1.Image = Properties.Resources.dårligDatBoi;
            }

            avslutt.Location = new System.Drawing.Point(Width - 100, Height - 70);
            avslutt.Name = "avslutt";
            avslutt.Size = new System.Drawing.Size(100, 50);
            avslutt.TabIndex = 18;
            avslutt.Text = "Avslutt spill";
            avslutt.UseVisualStyleBackColor = true;
            avslutt.Click += new System.EventHandler(this.avslutt_Click);
            Controls.Add(this.avslutt);
            avslutt.BringToFront(); 
        }

        private void avslutt_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
