using System;
using System.Drawing;

namespace Lab3.Shapes
{
    public class RectShape : Shape
    {
        public override void Show(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);

            int rx = Math.Abs(x2 - x1);
            int ry = Math.Abs(y2 - y1);

            int rectX = x1 - rx;
            int rectY = y1 - ry;

            int width = 2 * rx;
            int height = 2 * ry;

            g.DrawRectangle(pen, rectX, rectY, width, height);
        }
    }
}