using System.Drawing;

namespace Lab2.Shapes
{
    public class LineShape : Shape
    {
        public override void Show(Graphics g)
        {
            g.DrawLine(Pens.Black, x1, y1, x2, y2);
        }
    }
}