using System;
using System.Drawing;
using System.Windows.Forms;
using Lab2.Shapes;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private Shape[] pcshape = new Shape[108];
        private int shapeCount = 0;

        private bool isDrawing = false;
        private int startX, startY, currentX, currentY;

        private int currentShapeType = 1;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            menuLine.Checked = true;
        }

        private void menuPoint_Click(object sender, EventArgs e) { SetShapeType(0, menuPoint); }
        private void menuLine_Click(object sender, EventArgs e) { SetShapeType(1, menuLine); }
        private void menuRect_Click(object sender, EventArgs e) { SetShapeType(2, menuRect); }
        private void menuEllipse_Click(object sender, EventArgs e) { SetShapeType(3, menuEllipse); }

        private void SetShapeType(int type, ToolStripMenuItem clickedMenu)
        {
            currentShapeType = type;
            menuPoint.Checked = false;
            menuLine.Checked = false;
            menuRect.Checked = false;
            menuEllipse.Checked = false;
            clickedMenu.Checked = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (shapeCount >= 108) return;

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
                if (pcshape[i] != null)
                {
                    pcshape[i].Show(e.Graphics);
                }
            }

            if (isDrawing)
            {
                Pen rubberPen = new Pen(Color.Black, 1);

                switch (currentShapeType)
                {
                    case 0:
                        e.Graphics.FillEllipse(Brushes.Black, currentX - 2, currentY - 2, 4, 4);
                        break;
                    case 1:
                        e.Graphics.DrawLine(rubberPen, startX, startY, currentX, currentY);
                        break;
                    case 2:
                        int rx = Math.Min(startX, currentX);
                        int ry = Math.Min(startY, currentY);
                        e.Graphics.DrawRectangle(rubberPen, rx, ry, Math.Abs(currentX - startX), Math.Abs(currentY - startY));
                        break;
                    case 3:
                        int rx_e = Math.Abs(currentX - startX);
                        int ry_e = Math.Abs(currentY - startY);
                        e.Graphics.DrawEllipse(rubberPen, startX - rx_e, startY - ry_e, 2 * rx_e, 2 * ry_e);
                        break;
                }
            }
        }
    }
}