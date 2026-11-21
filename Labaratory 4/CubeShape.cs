using System;
using System.Drawing;

namespace Lab4.Shapes
{
    public class CubeShape : Shape
    {
        private RectShape frontFace = new RectShape();
        private RectShape backFace = new RectShape();
        private LineShape edge = new LineShape();

        public override void Show(Graphics g)
        {
            int rx = Math.Abs(x2 - x1);
            int ry = Math.Abs(y2 - y1);

            int dx = rx / 2;
            int dy = -ry / 2;

            frontFace.x1 = x1;
            frontFace.y1 = y1;
            frontFace.x2 = x2;
            frontFace.y2 = y2;
            frontFace.Show(g);

            backFace.x1 = x1 + dx;
            backFace.y1 = y1 + dy;
            backFace.x2 = x2 + dx;
            backFace.y2 = y2 + dy;
            backFace.Show(g);

            int[] cx = { x1 - rx, x1 + rx, x1 + rx, x1 - rx };
            int[] cy = { y1 - ry, y1 - ry, y1 + ry, y1 + ry };

            for (int i = 0; i < 4; i++)
            {
                edge.x1 = cx[i];
                edge.y1 = cy[i];
                edge.x2 = cx[i] + dx;
                edge.y2 = cy[i] + dy;
                edge.Show(g);
            }
        }
    }
}