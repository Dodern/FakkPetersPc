﻿using System;
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
        Button igjen = new System.Windows.Forms.Button();

        /*Eventen som vil skje når du klikker på den generete knappen avslutt. Blir brukt hvis 
        brukeren skal avslutte applikasjonen*/
        private void avslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Eventen som vil skje når du klikker på den generete knappen igjen. Blir brukt hvis 
        brukeren skal ta et nytt spill*/
        private void igjen_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ferdigboks_Shown(object sender, EventArgs e)
        {
            this.TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            //Generer to knapper som kommer oppå formen ferdigboks når den blir vist
            #region Genererte knapper 
            avslutt.Location = new System.Drawing.Point(Width - 115, Height - 65);
            avslutt.Name = "avslutt";
            avslutt.Size = new System.Drawing.Size(100, 50);
            avslutt.TabIndex = 18;
            avslutt.Text = "Avslutt spill";
            avslutt.UseVisualStyleBackColor = true;
            avslutt.Click += new System.EventHandler(this.avslutt_Click);
            Controls.Add(this.avslutt);
            avslutt.BringToFront();

            igjen.Location = new System.Drawing.Point(Width - 115, Height - 125);
            igjen.Name = "igjen";
            igjen.Size = new System.Drawing.Size(100, 50);
            igjen.TabIndex = 17;
            igjen.Text = "Spill igjen";
            igjen.UseVisualStyleBackColor = true;
            igjen.Click += new System.EventHandler(this.igjen_Click);
            Controls.Add(this.igjen);
            igjen.BringToFront();
            #endregion

            /*Når formen ferdigboks blir vist så vil den sjekke ved hjelp av int'en 
            endeligPoeng hvordan brukeren skal bli belønnet*/
            if (Form1.endeligPoeng == 5)
            {
                pictureBox1.Image = Properties.Resources.braDatBoi;
            }
            else if (Form1.endeligPoeng == 3 || Form1.endeligPoeng == 4)
            {
                pictureBox1.Image = Properties.Resources.okDatBoi;
            }
            else if (Form1.endeligPoeng <= 2)
            {
                pictureBox1.Image = Properties.Resources.dårligDatBoi;
            }
        }
    }
}
