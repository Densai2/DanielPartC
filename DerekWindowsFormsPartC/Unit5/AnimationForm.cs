using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit5
{
    /// <summary>
    /// Tasks 5.1 and 5.2
    /// This form will display an animated animal moving randomly about on
    /// the form.  The animated character can be selected from a horse and
    /// a butterfly.
    /// 
    /// Author      : Derek Peacock
    /// Modified by : Student Name
    /// </summary>
    public partial class AnimationForm : Form
    {
        private const int MAXN_IMAGES = 8;

        private Image[] images = new Image[MAXN_IMAGES];

        private int imageNo = 0;

        private Random generator = new Random();

        public AnimationForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Load MAXN_IMAGES from gif files and add them to the animation
        /// Picture Box when the form loads or when the animation character
        /// is changed.
        /// </summary>
        private void LoadImages(object sender, EventArgs e)
        {
            string baseFileName = "../../Images/Butterflies/bfly"; ;

            for (imageNo = 0; imageNo < MAXN_IMAGES; imageNo++)
            {
                string filename = baseFileName + imageNo + ".gif";
                images[imageNo] = Image.FromFile(filename);
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Change the image in the picture box to the next image
        /// in the array with every animation timer click.  
        /// Cycle continuously.
        /// 
        /// FIND THE DELIBERATE ERROR!!!
        /// </summary>
        private void UpdateImage(object sender, EventArgs e)
        {
            if (imageNo >= MAXN_IMAGES)
                imageNo = 0;
            else
                imageNo++;

            animationPictureBox.Image = images[imageNo];

            int x = generator.Next(20) - 10;
            int y = generator.Next(20) - 10;

            animationPictureBox.Top += y;
            animationPictureBox.Left += x;

            Refresh();
        }

        private void StartAnimation(object sender, EventArgs e)
        {
            animationTimer.Start();
        }

        private void StopAnimation(object sender, EventArgs e)
        {
            animationTimer.Stop();
        }

    }
}
