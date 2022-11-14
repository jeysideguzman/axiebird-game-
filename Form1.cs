using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLOPPY_BIRD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravity = 10;
        int speed = 25;
        int score = 0;
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 25;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -20;
            else if (e.KeyCode == Keys.Enter)
                timer1.Start();
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            axiebird.Top += gravity;
            pipedown.Left -= speed;
            pipeup.Left -= speed;
            clouds.Left -= speed;
            scorelbl.Text = $"SCORE: {score}";
            // adding score
            if (pipedown.Left < -170)
            {
                pipedown.Left = rnd.Next(100, 600);
                score++;
            }
            if (pipeup.Left < -170)
            {
                int up = rnd.Next(300, 700);
                pipeup.Left = up;
                clouds.Left = rnd.Next (up + 50, 800);
                score++;
            }
            if (axiebird.Bounds.IntersectsWith(pipeup.Bounds) || axiebird.Bounds.IntersectsWith(pipedown.Bounds) || axiebird.Bounds.IntersectsWith(ground.Bounds))
            {
                timer1.Stop();
                scorelbl.Text += "GAME OVER!";
            }
            if (score > 10)
                speed += 5;
        }
    }
}
