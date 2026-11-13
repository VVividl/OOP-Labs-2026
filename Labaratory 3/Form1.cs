using System;
using System.Drawing;
using System.Windows.Forms;
using Lab3.Shapes;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private const int MaxShapes = 109;
        private Shape[] pcshape = new Shape[MaxShapes];
        private int shapeCount = 0;

        private bool isDrawing = false;
        private int startX, startY, currentX, currentY;
        private int currentShapeType = 1;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            this.Text = "Lab 3 - Обрано: Лінія";
        }

        private void menuPoint_Click(object sender, EventArgs e) { SetShapeType(0, "Крапка"); }
        private void menuLine_Click(object sender, EventArgs e) { SetShapeType(1, "Лінія"); }
        private void menuRect_Click(object sender, EventArgs e) { SetShapeType(2, "Прямокутник"); }
        private void menuEllipse_Click(object sender, EventArgs e) { SetShapeType(3, "Еліпс"); }

        private void SetShapeType(int type, string shapeName)
        {
            currentShapeType = type;
            this.Text = "Lab 3 - Обрано: " + shapeName;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (shapeCount >= MaxShapes) return;

            isDrawing = true;
            startX = e.X;
            startY = e.Y;
            currentX = e.X;
            currentY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentX = e.X;
                currentY = e.Y;
                this.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;

            Shape newShape = null;

            switch (currentShapeType)
            {
                case 0: newShape = new PointShape(); break;
                case 1: newShape = new LineShape(); break;
                case 2: newShape = new RectShape(); break;
                case 3: newShape = new EllipseShape(); break;
            }

            if (newShape != null)
            {
                newShape.x1 = startX;
                newShape.y1 = startY;
                newShape.x2 = e.X;
                newShape.y2 = e.Y;

                pcshape[shapeCount] = newShape;
                shapeCount++;
            }

            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < shapeCount; i++)
            {
                if (pcshape[i] != null) pcshape[i].Show(e.Graphics);
            }

            if (isDrawing)
            {
                Pen rubberPen = new Pen(Color.Red, 1);

                switch (currentShapeType)
                {
                    case 0:
                        e.Graphics.FillEllipse(Brushes.Red, currentX - 2, currentY - 2, 4, 4);
                        break;
                    case 1:
                        e.Graphics.DrawLine(rubberPen, startX, startY, currentX, currentY);
                        break;
                    case 2:
                        int rx = Math.Abs(currentX - startX);
                        int ry = Math.Abs(currentY - startY);
                        e.Graphics.DrawRectangle(rubberPen, startX - rx, startY - ry, 2 * rx, 2 * ry);
                        break;
                    case 3:
                        int ex = Math.Min(startX, currentX);
                        int ey = Math.Min(startY, currentY);
                        e.Graphics.DrawEllipse(rubberPen, ex, ey, Math.Abs(currentX - startX), Math.Abs(currentY - startY));
                        break;
                }
            }
        }

        private void Point_Click(object sender, EventArgs e)
        {
            SetShapeType(0, "Point");
        }

        private void Line_Click(object sender, EventArgs e)
        {
            SetShapeType(1, "Line");
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            SetShapeType(2, "Rectangle");
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            SetShapeType(3, "Ellipse");
        }
    }
}