using DerekWindowsFormsPartC;
using System;
using System.Windows.Forms;
using WindowsFormsPartC.Unit5;
using WindowsFormsPartC.Unit6;
using WindowsFormsPartC.Unit7;

namespace WindowsFormsPartC
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void runProgram(object sender, EventArgs e)
        {
            if (animationRadioButton.Checked)
            {
                // Tasks 5.1 and 5.2

                AnimationForm form = new AnimationForm();
                form.Show();
            }
            else if (flyMeRadioButton.Checked)
            {
                // Tasks 5.3, 5.4 and 5.5
                FlyMeForm form = new FlyMeForm();
                form.Show();
            }
            else if (unit6RadioButton.Checked)
            {
                // Tasks 6.1 to 6.6
                GraphicsForm form = new GraphicsForm();
                form.Show();

            }
            else if (bouncingBallRadio.Checked)
            {
                Bouncing_ball bouncing_Ball = new Bouncing_ball();
                bouncing_Ball.Show();
            }
            else if (unit7RadioButton.Checked)
            {
                SketchForm sketchForm = new SketchForm();
                sketchForm.Show();
            }
        }

        private void quitForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}