using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit6
{
    public enum Shapes
    {
        CIRCLE,
        ELLIPSE,
        FIGURE,
        LINE,
        RECTANGLE,
        SQUARE,

    }

    /// <summary>
    /// This form demonstrates the drawing of simple geometric shapes
    /// including rectangles, ellipses, polygons and lines.
    /// 
    /// Unit 6: Tasks 6.1 to 6.5
    /// Derek Peacock
    /// </summary>
    public partial class GraphicsForm : Form
    {
        public const int BYTE = 256;

        private int x, y, w, h;

        private Shapes shape = Shapes.LINE;

        private Random generator = new Random();

        private Brush myBrush;

        public GraphicsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the method that is called every time the screen is
        /// refreshed.  e contains the Graphics object required for
        /// any drawing operation
        /// </summary>
        private void DrawGraphics(object sender, PaintEventArgs e)
        {
            if (radioButton1.Checked)
            {
                drawStrings(e.Graphics, 50, 20);     // Task 6.1
                drawRectangles(e.Graphics, 600, 20); // Task 6.2
            }
            else if(radioButton2.Checked)
            {
                drawHexagon(e.Graphics);             // Task 6.3 
            }
            else if(radioButton3.Checked)            // Task 6.4
            {
                drawShape(e.Graphics);
            }
            else if (radioButton4.Checked)           // Task 6.5
            {
                drawCircles(e.Graphics);
            }
        }

        private void drawCircles(Graphics g)
        {
            x = 400; y = 100;

            int size = 400; int decrease = 15;

            Color color;

            Rectangle rectangle;

            for(int n = 1; n <= 10; n++)
            {
                myBrush = new SolidBrush(getRandomColor());
                rectangle = new Rectangle(x, y, size, size);

                g.FillEllipse(myBrush, rectangle);

                size = size - 2 * decrease;
                x = x + decrease;
                y = y + decrease;

            }
        }

        /// <summary>
        /// This is the Form Paint event handler
        /// </summary>
        /// <param name="g"></param>
        public void drawShape(Graphics g)
        {
            Color color = getRandomColor();
            Pen myPen = new Pen(color, 10);
            Point p1 = getRandomPoint();
            int size = 50 + generator.Next(200);

            if (shape == Shapes.LINE)
            {
                Point p2 = getRandomPoint();
                g.DrawLine(myPen, p1.X, p1.Y, p2.X, p2.Y);
            }
            else if(shape == Shapes.CIRCLE)
            {
                g.DrawEllipse(myPen, p1.X, p1.Y, size, size);
            }
            else if (shape == Shapes.RECTANGLE)
            {
                g.DrawRectangle(myPen, p1.X, p1.Y, 2 * size, size);
            }
            else if (shape == Shapes.ELLIPSE)
            {
                g.DrawEllipse(myPen, p1.X, p1.Y, 2 * size, size);
            }
            else if (shape == Shapes.SQUARE)
            {
                g.DrawRectangle(myPen, p1.X, p1.Y, 200, 200);
            }
            else if (shape == Shapes.FIGURE)
            {
                g.DrawEllipse(myPen, 400, 100, 60, 60); // head
                g.DrawLine(myPen, 430, 160, 430, 300);  // body
                g.DrawLine(myPen, 330, 200, 530, 200);  // Arms
                g.DrawLine(myPen, 430, 300, 330, 400);  // Legs
                g.DrawLine(myPen, 430, 300, 530, 400);  // Legs
            }
        }


        /// <summary>
        /// Task 6.1 Drawing 6 Strings
        /// </summary>
        private void drawStrings(Graphics g, int x, int y)
        {
            int fontSize = 30;
            Font myFont = new Font("Courier", fontSize);
            BackColor = Color.Yellow;

            for(int i = 1; i <= 6; i++)
            {
                g.Clear(BackColor);
                g.DrawString("Derek's Graphics Drawing", myFont, Brushes.Red, x, y);

                System.Threading.Thread.Sleep(200);
                y = y + fontSize;
            }
        }

        private void drawRectangles(Graphics g, int x, int y)
        {
            w = 300; h = 200; int size = 20;

            Pen myPen = new Pen(Color.Blue, 10);

            g.DrawRectangle(myPen, x, y, w, h);
            g.FillRectangle(Brushes.Red, x, y, w, h);
            g.FillEllipse(Brushes.Yellow, x, y, w, h);

            y = 300;

            for(int i = 1; i <= 6; i++)
            {
                g.DrawRectangle(myPen, x, y, w, h);

                x = x + size; 
                y = y + size;
                w = w - 2 * size; 
                h = h - 2 * size;
            }
        }

        /// <summary>
        /// Task 6.3
        /// </summary>
        private void drawHexagon(Graphics g)
        {
            x = 100; y = 200; int size = 100;

            Pen myPen = new Pen(Color.Red, 10);

            Point[] hexagon = new Point[]
            {
                new Point(x, y),
                new Point(x + size, y - size),
                new Point(x + 2 * size, y - size),
                new Point(x + 3 * size, y),
                new Point(x + 2 * size, y + size),
                new Point(x + size, y + size)
            };

            g.DrawPolygon(myPen, hexagon);
            g.FillPolygon(Brushes.Yellow, hexagon);

            Font myFont = new Font("Courier", 30);
            g.DrawString("Derek's Hexagon", myFont, Brushes.Red, 120, 320);
        }

        private void quitForm(object sender, System.EventArgs e)
        {
            Close();
        }

        private void selectTasks(object sender, System.EventArgs e)
        {
            Refresh();
        }

        private Color getRandomColor()
        {
            int r, g, b;

            r = generator.Next(BYTE);
            g = generator.Next(BYTE);
            b = generator.Next(BYTE);

            return Color.FromArgb(r, g, b);
        }


        private Point getRandomPoint()
        {
            x = generator.Next(Width);
            y = generator.Next(Height);

            Point point = new Point(x, y);

            return point;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string key = keyData.ToString();
            drawShape(key);

            return false;
        }


        private void drawShape(string key)
        {
            if(key == "L")
            {
                shape = Shapes.LINE;
            }
            else if(key == "C")
            {
                shape = Shapes.CIRCLE;
            }
            else if (key == "E")
            {
                shape = Shapes.ELLIPSE;
            }
            else if (key == "F")
            {
                shape = Shapes.FIGURE;
            }
            else if (key == "R")
            {
                shape = Shapes.RECTANGLE;
            }
            else if (key == "S")
            {
                shape = Shapes.SQUARE;
            }

            Refresh();
        }

    }
}
