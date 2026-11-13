using System;
using System.Drawing;

namespace Lab3.Shapes
{
    public class EllipseShape : Shape
    {
        public override void Show(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);

            Brush brush = new SolidBrush(Color.LightBlue);

            int ex = Math.Min(x1, x2);
            int ey = Math.Min(y1, y2);

            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);

            g.FillEllipse(brush, ex, ey, width, height);

            g.DrawEllipse(pen, ex, ey, width, height);
        }
    }
}