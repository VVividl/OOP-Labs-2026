using Lab4.Shapes;
using System.Drawing.Drawing2D;

namespace Lab4
{
    public class MyEditor : IDisposable
    {
        private const int MaxShapes = 109;
        private Shape[] pcshape = new Shape[MaxShapes];
        private int shapeCount = 0;

        private bool isDrawing = false;
        private int startX, startY, currentX, currentY;
        private int currentShapeType = 1;

        public void SetShapeType(int type)
        {
            currentShapeType = type;
        }

        public void OnLBdown(int x, int y)
        {
            if (shapeCount >= MaxShapes) return;

            isDrawing = true;
            startX = x;
            startY = y;
            currentX = x;
            currentY = y;
        }

        public void OnMouseMove(int x, int y)
        {
            if (isDrawing)
            {
                currentX = x;
                currentY = y;
            }
        }

        public void OnLBup(int x, int y)
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
                case 4: newShape = new LineOOShape(); break;
                case 5: newShape = new CubeShape(); break;
            }

            if (newShape != null)
            {
                newShape.x1 = startX;
                newShape.y1 = startY;
                newShape.x2 = x;
                newShape.y2 = y;

                pcshape[shapeCount] = newShape;
                shapeCount++;
            }
        }

        public void OnPaint(Graphics g)
        {
            for (int i = 0; i < shapeCount; i++)
            {
                if (pcshape[i] != null)
                {
                    pcshape[i].Show(g);
                }
            }

            if (isDrawing)
            {
                using (Pen rubberPen = new Pen(Color.Black, 1))
                {
                    rubberPen.DashStyle = DashStyle.Dash;

                    switch (currentShapeType)
                    {
                        case 0:
                            g.DrawEllipse(rubberPen, currentX - 2, currentY - 2, 4, 4);
                            break;
                        case 1:
                            g.DrawLine(rubberPen, startX, startY, currentX, currentY);
                            break;
                        case 2:
                            int rx = Math.Abs(currentX - startX);
                            int ry = Math.Abs(currentY - startY);
                            g.DrawRectangle(rubberPen, startX - rx, startY - ry, 2 * rx, 2 * ry);
                            break;
                        case 3:
                            int ex = Math.Min(startX, currentX);
                            int ey = Math.Min(startY, currentY);
                            g.DrawEllipse(rubberPen, ex, ey, Math.Abs(currentX - startX), Math.Abs(currentY - startY));
                            break;
                        case 4:
                            g.DrawLine(rubberPen, startX, startY, currentX, currentY);
                            g.DrawEllipse(rubberPen, startX - 10, startY - 10, 20, 20);
                            g.DrawEllipse(rubberPen, currentX - 10, currentY - 10, 20, 20);
                            break;
                        case 5:
                            int crx = Math.Abs(currentX - startX);
                            int cry = Math.Abs(currentY - startY);
                            int cdx = crx / 2;
                            int cdy = -cry / 2;
                            g.DrawRectangle(rubberPen, startX - crx, startY - cry, 2 * crx, 2 * cry);
                            g.DrawRectangle(rubberPen, startX - crx + cdx, startY - cry + cdy, 2 * crx, 2 * cry);
                            break;
                    }
                }
            }
        }

        public void Dispose()
        {
            Array.Clear(pcshape, 0, pcshape.Length);
            shapeCount = 0;
        }
    }
}