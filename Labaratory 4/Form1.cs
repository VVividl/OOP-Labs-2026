using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private MyEditor editor;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            editor = new MyEditor();
            this.Text = "Lab 4 - Selected: Line";
        }

        private void SetShapeType(int type, string shapeName)
        {
            editor?.SetShapeType(type);
            this.Text = "Lab 4 - Selected: " + shapeName;
        }

        private void menuPoint_Click(object sender, EventArgs e) { SetShapeType(0, "Point"); }
        private void menuLine_Click(object sender, EventArgs e) { SetShapeType(1, "Line"); }
        private void menuRect_Click(object sender, EventArgs e) { SetShapeType(2, "Rectangle"); }
        private void menuEllipse_Click(object sender, EventArgs e) { SetShapeType(3, "Ellipse"); }

        private void Point_Click(object sender, EventArgs e) { SetShapeType(0, "Point"); }
        private void Line_Click(object sender, EventArgs e) { SetShapeType(1, "Line"); }
        private void Rectangle_Click(object sender, EventArgs e) { SetShapeType(2, "Rectangle"); }
        private void Ellipse_Click(object sender, EventArgs e) { SetShapeType(3, "Ellipse"); }
        private void LineWithCircles_Click(object sender, EventArgs e) { SetShapeType(4, "Line with circles"); }
        private void Cube_Click(object sender, EventArgs e) { SetShapeType(5, "Cube"); }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            editor?.OnLBdown(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            editor?.OnMouseMove(e.X, e.Y);
            this.Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            editor?.OnLBup(e.X, e.Y);
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            editor?.OnPaint(e.Graphics);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            editor?.Dispose();
            editor = null;
            base.OnFormClosed(e);
        }
    }
}