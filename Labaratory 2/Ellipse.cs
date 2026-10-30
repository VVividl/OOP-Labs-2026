using System;
using System.Drawing;

namespace Lab2.Shapes
{
    public class EllipseShape : Shape
    {
        public override void Show(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.LightGreen);

            int rx = Math.Abs(x2 - x1);
            int ry = Math.Abs(y2 - y1);

            int rectX = x1 - rx;
            int rectY = y1 - ry;
            int width = 2 * rx;
            int height = 2 * ry;

            g.FillEllipse(brush, rectX, rectY, width, height);
            g.DrawEllipse(pen, rectX, rectY, width, height);
        }
    }
}