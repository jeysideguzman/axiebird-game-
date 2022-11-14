namespace FLOPPY_BIRD
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
            this.axiebird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scorelbl = new System.Windows.Forms.Label();
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.clouds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axiebird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).BeginInit();
            this.SuspendLayout();
            // 
            // axiebird
            // 
            this.axiebird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("axiebird.BackgroundImage")));
            this.axiebird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.axiebird.Image = ((System.Drawing.Image)(resources.GetObject("axiebird.Image")));
            this.axiebird.Location = new System.Drawing.Point(89, 144);
            this.axiebird.Name = "axiebird";
            this.axiebird.Size = new System.Drawing.Size(60, 52);
            this.axiebird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.axiebird.TabIndex = 0;
            this.axiebird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-4, 383);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(840, 90);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scorelbl.Location = new System.Drawing.Point(314, 428);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(149, 31);
            this.scorelbl.TabIndex = 3;
            this.scorelbl.Text = "SCORE: 0";
            // 
            // pipeup
            // 
            this.pipeup.Image = ((System.Drawing.Image)(resources.GetObject("pipeup.Image")));
            this.pipeup.Location = new System.Drawing.Point(464, 0);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(100, 153);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 4;
            this.pipeup.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = ((System.Drawing.Image)(resources.GetObject("pipedown.Image")));
            this.pipedown.Location = new System.Drawing.Point(320, 271);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(100, 116);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 5;
            this.pipedown.TabStop = false;
            // 
            // clouds
            // 
            this.clouds.Image = ((System.Drawing.Image)(resources.GetObject("clouds.Image")));
            this.clouds.Location = new System.Drawing.Point(147, 12);
            this.clouds.Name = "clouds";
            this.clouds.Size = new System.Drawing.Size(120, 88);
            this.clouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds.TabIndex = 6;
            this.clouds.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(834, 469);
            this.Controls.Add(this.clouds);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.axiebird);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Axie Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.axiebird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox axiebird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox clouds;
    }
}

