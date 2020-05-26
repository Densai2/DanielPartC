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
    /// <summary>
    /// This program has a ball bounce around the
    /// screen when the start button is pushed. The
    /// background colour and size of ball can be 
    /// changed.
    /// </summary>
    public partial class Bouncing_ball : Form
    {
        // start position of ball
        int x = 200, y = 50;
        // amount of movement for each tick
        int xmove = 10, ymove = 10;

        private void redBall(object sender, PaintEventArgs e)
        {
            // get a graphics object
            Graphics g = e.Graphics;      

            // draw a red ball, size 30, at x, y position
            g.FillEllipse(Brushes.Red, x, y, size, size);

        }

        private void timerMove(object sender, EventArgs e)
        {
            // add 10 to x and y positions
            x += xmove;             
            if (x < 0)
            {
                xmove = -xmove;
            }
            else if (x + 5 > AreaPictureBox.Width)
            {
                xmove = -xmove;
            }
            y += ymove;
            if (y < 0)
            {
                ymove = -ymove;
            }
            else if (y + 5 > AreaPictureBox.Height)
            {
                ymove = -ymove;
            }
            Refresh();
        }

        private void StartButton(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void exitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int size = 30;

        private void stopButton(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        public Bouncing_ball()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Depending on the button pressed the ball can change size.
        /// </summary>
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
            // return true if key processed, otherwise false
            return false;
        }



    }
}
