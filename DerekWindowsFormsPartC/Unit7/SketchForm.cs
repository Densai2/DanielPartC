using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit7
{
    public partial class SketchForm : Form
    {
        private Bitmap canvas;

        private int x = 300;
        private int y = 200;

        private int penSize = 10;

        private bool keyPressed = false;
        private string keyName;
        DialogResult response;

        public SketchForm()
        {
            InitializeComponent();
        }

        private void SketchForm_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(sketchPanel.Width, sketchPanel.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.FillEllipse(Brushes.Red, x, y, penSize, penSize);
            sketchPanel.BackgroundImage = canvas;
        }

        private void drawPoint(Graphics g)
        {
            if (keyName == "Right")
            {
                x = x + penSize / 2;
            }
            else if (keyName == "Left")
            {
                x = x - penSize / 2;
            }
            else if (keyName == "Up")
            {
                y = y - penSize / 2;
            }
            else if (keyName == "Down")
            {
                y = y + penSize / 2;
            }
            else if (keyName == "C")
            {
            }
            else if (keyName == "Escape")
            {
                response = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
            else if(keyName == "F1")
            {
                Random rnd = new Random();
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                
            }

            if (keyPressed)
                g.FillEllipse(Brushes.Red, x, y, penSize, penSize);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            keyName = keyData.ToString();
            keyPressed = true;

            Refresh();
            return true;
        }

        private void sketchPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(sketchPanel.BackgroundImage);
            drawPoint(g);
        }

    }
}
