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
        public const string BACKGROUND_IMAGE_3 = "../../Images/Town and Sky/City3.wmf";

        private string background = BACKGROUND_IMAGE_2;
        private string background1 = BACKGROUND_IMAGE_3;

        private int horizontalSpeed = 10;
        string baseFileName;

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
            if (stopRadioButton.Checked)
            {
                animationTimer.Enabled = false;
            }
            else
            {
                animationTimer.Enabled = true;
            }
        }
        /// <summary>
        /// Updates image for animation, detects when the left of the helicopter
        /// is touching the edge of the screen and then chances to a new background.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateImages(object sender, EventArgs e)
        {
            copterPictureBox.Image = animation.GetNextImage();

            copterPictureBox.Left += horizontalSpeed;


            if (copterPictureBox.Left > this.Width)
            {
                copterPictureBox.Top += VERTICAL_SPEED;
                copterPictureBox.Left = -copterPictureBox.Width;

                if (background == BACKGROUND_IMAGE_1)
                {
                    background = BACKGROUND_IMAGE_2;
                }
                else
                {
                    background = BACKGROUND_IMAGE_3;
                }

                Bitmap bitmap = new Bitmap(background);
                BackgroundImage = bitmap;
            }
            if (pigPictureBox.Left > this.Width)
            {
                pigPictureBox.Top += VERTICAL_SPEED;
                pigPictureBox.Left = -pigPictureBox.Width;

                if (background1 == BACKGROUND_IMAGE_3)
                {
                    background = BACKGROUND_IMAGE_2;
                }
                else
                {
                    background1 = BACKGROUND_IMAGE_3;
                }
                Bitmap bitmap = new Bitmap(background1);
                BackgroundImage = bitmap;
            }
            if (copterPictureBox.Top > this.Height - copterPictureBox.Height)
            {
                copterPictureBox.Top = VERTICAL_SPEED;
            }

            if (pigPictureBox.Top > this.Height - pigPictureBox.Height)
            {
                pigPictureBox.Top = VERTICAL_SPEED;
            }
        }
        private void loadImages(object sender, EventArgs e)
        {
            ///baseFileName = "../../Images/Copter/copter";
            ///animation.LoadImages(baseFileName);

            baseFileName = "../../Images/Pigs/pig";
            animation.LoadImages(baseFileName);
        }

        /// <summary>
        /// Depending on the speed chosen, the animation
        /// timer will be increased or decreased.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
} 
