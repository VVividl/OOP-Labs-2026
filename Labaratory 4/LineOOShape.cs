using System.Drawing;

namespace Lab4.Shapes
{
    public class LineOOShape : Shape
    {
        private LineShape line = new LineShape();
        private EllipseShape circle1 = new EllipseShape();
        private EllipseShape circle2 = new EllipseShape();

        public override void Show(Graphics g)
        {
            line.x1 = x1;
            line.y1 = y1;
            line.x2 = x2;
            line.y2 = y2;
            line.Show(g);

            int r = 10;

            circle1.x1 = x1 - r;
            circle1.y1 = y1 - r;
            circle1.x2 = x1 + r;
            circle1.y2 = y1 + r;
            circle1.Show(g);

            circle2.x1 = x2 - r;
            circle2.y1 = y2 - r;
            circle2.x2 = x2 + r;
            circle2.y2 = y2 + r;
            circle2.Show(g);
        }
    }
}