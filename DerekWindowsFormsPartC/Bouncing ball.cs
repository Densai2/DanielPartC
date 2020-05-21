using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerekWindowsFormsPartC
{
    public partial class Bouncing_ball : Form
    {
        int x = 200, y = 50;        // start position of ball
        int xmove = 10, ymove = 10; // amount of movement for each tick

        int x2 = 150, y2 = 30;        // start position of ball
        int xmove2 = 10, ymove2 = 10;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;      // get a graphics object

            // draw a red ball, size 30, at x, y position
            g.FillEllipse(Brushes.Red, x, y, size, size);

            g.FillEllipse(Brushes.Green, x2, y2, size, size);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += xmove;             // add 10 to x and y positions
            if (x < 0)
            {
                xmove = -xmove;
            }
            else if (x + 30 > ClientSize.Width)
            {
                xmove = -xmove;
            }
            y += ymove;
            if (y < 0)
            {
                ymove = -ymove;
            }
            else if (y + 30 > ClientSize.Height)
            {
                ymove = -ymove;
            }
            x2 += xmove2;
            if (x < 0)
            {
                xmove2 = -xmove2;
            }
            else if (x2 + 30 > ClientSize.Width)
            {
                xmove2 = -xmove2;
            }
            y2 += ymove2;
            if (y < 0)
            {
                ymove2 = -ymove2;
            }
            else if (y2 + 30 > ClientSize.Height)
            {
                ymove2 = -ymove2;
            }
            Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int size = 30;

        public Bouncing_ball()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string input;

            input = keyData.ToString();

            if (input == "Up")
            {
                size = size + 10;
                return true;
            }
            if (input == "Down")
            {
                size = size - 10;
                return true;
            }
            if (input == "C")
            {
                Random rand = new Random();
                Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                pictureBox1.BackColor = randomColor;
                return true;
            }

            return false;    // return true if key processed, otherwise false
        }



    }
}
