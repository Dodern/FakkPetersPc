namespace LæreGreier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSjekk = new System.Windows.Forms.Button();
            this.btnNeste = new System.Windows.Forms.Button();
            this.lbPoeng = new System.Windows.Forms.Label();
            this.lbRegler = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.memeSjekk = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lydSpiller = new AxWMPLib.AxWindowsMediaPlayer();
            this.ferdigBilde = new System.Windows.Forms.PictureBox();
            this.bilde2 = new System.Windows.Forms.PictureBox();
            this.bilde4 = new System.Windows.Forms.PictureBox();
            this.bilde3 = new System.Windows.Forms.PictureBox();
            this.bilde1 = new System.Windows.Forms.PictureBox();
            this.meme1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lydSpiller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferdigBilde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilde4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilde3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meme1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSjekk
            // 
            this.btnSjekk.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSjekk.Location = new System.Drawing.Point(980, 720);
            this.btnSjekk.Name = "btnSjekk";
            this.btnSjekk.Size = new System.Drawing.Size(154, 53);
            this.btnSjekk.TabIndex = 11;
            this.btnSjekk.Text = "Sjekk Svar";
            this.btnSjekk.UseVisualStyleBackColor = true;
            this.btnSjekk.Click += new System.EventHandler(this.btnSjekk_Click);
            // 
            // lbPoeng
            // 
            this.lbPoeng.AutoSize = true;
            this.lbPoeng.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoeng.Location = new System.Drawing.Point(1062, 60);
            this.lbPoeng.Name = "lbPoeng";
            this.lbPoeng.Size = new System.Drawing.Size(46, 15);
            this.lbPoeng.TabIndex = 14;
            this.lbPoeng.Text = "Poeng : ";
            // 
            // lbRegler
            // 
            this.lbRegler.AutoSize = true;
            this.lbRegler.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegler.Location = new System.Drawing.Point(842, 793);
            this.lbRegler.Name = "lbRegler";
            this.lbRegler.Size = new System.Drawing.Size(601, 15);
            this.lbRegler.TabIndex = 15;
            this.lbRegler.Text = "Velg bildet til høyre du mener passer innn i memeserien til venstre. Dra bildet o" +
    "ver i det tomme feltet på venstre side.";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(498, -15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(386, 90);
            this.lbTitle.TabIndex = 16;
            this.lbTitle.Text = "Meme Quiz";
            // 
            // memeSjekk
            // 
            this.memeSjekk.AllowDrop = true;
            this.memeSjekk.BackColor = System.Drawing.Color.Transparent;
            this.memeSjekk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memeSjekk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memeSjekk.Location = new System.Drawing.Point(188, 578);
            this.memeSjekk.Name = "memeSjekk";
            this.memeSjekk.Size = new System.Drawing.Size(404, 290);
            this.memeSjekk.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lydSpiller
            // 
            this.lydSpiller.Enabled = true;
            this.lydSpiller.Location = new System.Drawing.Point(1230, 50);
            this.lydSpiller.Name = "lydSpiller";
            this.lydSpiller.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("lydSpiller.OcxState")));
            this.lydSpiller.Size = new System.Drawing.Size(81, 33);
            this.lydSpiller.TabIndex = 19;
            // 
            // ferdigBilde
            // 
            this.ferdigBilde.BackColor = System.Drawing.SystemColors.Control;
            this.ferdigBilde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ferdigBilde.Image = global::LæreGreier.Properties.Resources.MadPepe;
            this.ferdigBilde.Location = new System.Drawing.Point(1355, 50);
            this.ferdigBilde.Name = "ferdigBilde";
            this.ferdigBilde.Size = new System.Drawing.Size(86, 58);
            this.ferdigBilde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ferdigBilde.TabIndex = 18;
            this.ferdigBilde.TabStop = false;
            // 
            // bilde2
            // 
            this.bilde2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bilde2.Image = ((System.Drawing.Image)(resources.GetObject("bilde2.Image")));
            this.bilde2.Location = new System.Drawing.Point(1148, 178);
            this.bilde2.Name = "bilde2";
            this.bilde2.Size = new System.Drawing.Size(293, 182);
            this.bilde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bilde2.TabIndex = 10;
            this.bilde2.TabStop = false;
            this.bilde2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrykkePåBilde);
            this.bilde2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dra);
            this.bilde2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slipp);
            // 
            // bilde4
            // 
            this.bilde4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bilde4.Image = ((System.Drawing.Image)(resources.GetObject("bilde4.Image")));
            this.bilde4.Location = new System.Drawing.Point(1148, 390);
            this.bilde4.Name = "bilde4";
            this.bilde4.Size = new System.Drawing.Size(293, 182);
            this.bilde4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bilde4.TabIndex = 9;
            this.bilde4.TabStop = false;
            this.bilde4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrykkePåBilde);
            this.bilde4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dra);
            this.bilde4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slipp);
            // 
            // bilde3
            // 
            this.bilde3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bilde3.Image = ((System.Drawing.Image)(resources.GetObject("bilde3.Image")));
            this.bilde3.Location = new System.Drawing.Point(815, 390);
            this.bilde3.Name = "bilde3";
            this.bilde3.Size = new System.Drawing.Size(293, 182);
            this.bilde3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bilde3.TabIndex = 8;
            this.bilde3.TabStop = false;
            this.bilde3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrykkePåBilde);
            this.bilde3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dra);
            this.bilde3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slipp);
            // 
            // bilde1
            // 
            this.bilde1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bilde1.Image = ((System.Drawing.Image)(resources.GetObject("bilde1.Image")));
            this.bilde1.Location = new System.Drawing.Point(815, 178);
            this.bilde1.Name = "bilde1";
            this.bilde1.Size = new System.Drawing.Size(293, 182);
            this.bilde1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bilde1.TabIndex = 7;
            this.bilde1.TabStop = false;
            this.bilde1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrykkePåBilde);
            this.bilde1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dra);
            this.bilde1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Slipp);
            // 
            // meme1
            // 
            this.meme1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.meme1.Location = new System.Drawing.Point(12, 85);
            this.meme1.Name = "meme1";
            this.meme1.Size = new System.Drawing.Size(762, 487);
            this.meme1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meme1.TabIndex = 0;
            this.meme1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 873);
            this.Controls.Add(this.lydSpiller);
            this.Controls.Add(this.ferdigBilde);
            this.Controls.Add(this.memeSjekk);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbRegler);
            this.Controls.Add(this.lbPoeng);
            this.Controls.Add(this.btnNeste);
            this.Controls.Add(this.btnSjekk);
            this.Controls.Add(this.bilde2);
            this.Controls.Add(this.bilde4);
            this.Controls.Add(this.bilde3);
            this.Controls.Add(this.bilde1);
            this.Controls.Add(this.meme1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Meme Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lydSpiller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferdigBilde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilde4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilde3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meme1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox meme1;
        private System.Windows.Forms.PictureBox bilde1;
        private System.Windows.Forms.PictureBox bilde3;
        private System.Windows.Forms.PictureBox bilde4;
        private System.Windows.Forms.PictureBox bilde2;
        private System.Windows.Forms.Button btnSjekk;
        private System.Windows.Forms.Button btnNeste;
        private System.Windows.Forms.Label lbPoeng;
        private System.Windows.Forms.Label lbRegler;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel memeSjekk;
        private System.Windows.Forms.PictureBox ferdigBilde;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private AxWMPLib.AxWindowsMediaPlayer lydSpiller;
    }
}

