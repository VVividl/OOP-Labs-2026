using System.Drawing;

namespace Lab2.Shapes
{
    public class PointShape : Shape
    {
        public override void Show(Graphics g)
        {
            g.FillEllipse(Brushes.Black, x1 - 2, y1 - 2, 4, 4);
        }
    }
}