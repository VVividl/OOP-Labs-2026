using System.Drawing;

namespace Lab2.Shapes
{
    public abstract class Shape
    {
        public int x1, y1, x2, y2;

        public abstract void Show(Graphics g);
    }
}