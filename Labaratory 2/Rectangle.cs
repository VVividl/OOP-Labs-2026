using System;
using System.Drawing;

namespace Lab2.Shapes
{
    public class RectShape : Shape
    {
        public override void Show(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);

            int rectX = Math.Min(x1, x2);
            int rectY = Math.Min(y1, y2);
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);

            g.DrawRectangle(pen, rectX, rectY, width, height);
        }
    }
}