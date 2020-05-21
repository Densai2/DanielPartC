using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit5
{
    /// <summary>
    /// This form shows an animation of a helicopter which will fly across
    /// and down the screen.
    /// </summary>
    public partial class FlyMeForm : Form
    {
        public const int VERTICAL_SPEED = 100;

        public const string BACKGROUND_IMAGE_1 = "../../Images/Town and Sky/City1.wmf";
        public const string BACKGROUND_IMAGE_2 = "../../Images/Town and Sky/City2.wmf";

        private string background = BACKGROUND_IMAGE_2;

        private int horizontalSpeed = 10;

        private Animation animation = new Animation(4);

        public FlyMeForm()
        {
            InitializeComponent();
        }

        private void quitForm(object sender, EventArgs e)
        {
            Close();
        }

        private void startStopAnimation(object sender, EventArgs e)
        {
            if(stopRadioButton.Checked)
            {
                animationTimer.Enabled = false;
            }
            else
            {
                animationTimer.Enabled = true;
            }
        }

        private void updateCopter(object sender, EventArgs e)
        {
            copterPictureBox.Image = animation.GetNextImage();

            copterPictureBox.Left += horizontalSpeed;

            // If the copter goes off the right hand side

            if (copterPictureBox.Left > this.Width)
            {
                copterPictureBox.Top += VERTICAL_SPEED;
                copterPictureBox.Left = -copterPictureBox.Width;

                //Image image = Image.FromFile("../../Images/Town and Sky/City1.wmf");

                if (background == BACKGROUND_IMAGE_1)
                {
                    background = BACKGROUND_IMAGE_2;
                }
                else
                {
                    background = BACKGROUND_IMAGE_1;
                }

                Bitmap bitmap = new Bitmap(background);
                BackgroundImage = bitmap;
            }

        }

        private void changeSpeed(object sender, EventArgs e)
        {
            int speed = (int)speedNumericUpDown.Value;

            switch (speed)
            {
                case 1: animationTimer.Interval = 80; break;
                case 2: animationTimer.Interval = 60; break;
                case 3: animationTimer.Interval = 40; break;
                case 4: animationTimer.Interval = 20; break;
                case 5: animationTimer.Interval = 10; break;

                default: animationTimer.Interval = 80; break;
            }
        }

        private void loadImages(object sender, EventArgs e)
        {
            string baseFileName = "../../Images/Copter/copter";
            animation.LoadImages(baseFileName);
        }
    }
}
