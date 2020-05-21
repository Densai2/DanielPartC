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
