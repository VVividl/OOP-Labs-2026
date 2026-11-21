namespace Lab4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuObjects = new ToolStripMenuItem();
            menuPoint = new ToolStripMenuItem();
            menuLine = new ToolStripMenuItem();
            menuRect = new ToolStripMenuItem();
            menuEllipse = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            Point = new ToolStripButton();
            Line = new ToolStripButton();
            Rectangle = new ToolStripButton();
            Ellipse = new ToolStripButton();
            LineWithCircles = new ToolStripButton();
            Cube = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuObjects, menuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(867, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(71, 36);
            menuFile.Text = "File";
            // 
            // menuObjects
            // 
            menuObjects.DropDownItems.AddRange(new ToolStripItem[] { menuPoint, menuLine, menuRect, menuEllipse });
            menuObjects.Name = "menuObjects";
            menuObjects.Size = new Size(114, 36);
            menuObjects.Text = "Objects";
            // 
            // menuPoint
            // 
            menuPoint.Name = "menuPoint";
            menuPoint.Size = new Size(251, 44);
            menuPoint.Text = "Point";
            menuPoint.Click += menuPoint_Click;
            // 
            // menuLine
            // 
            menuLine.Name = "menuLine";
            menuLine.Size = new Size(251, 44);
            menuLine.Text = "Line";
            menuLine.Click += menuLine_Click;
            // 
            // menuRect
            // 
            menuRect.Name = "menuRect";
            menuRect.Size = new Size(251, 44);
            menuRect.Text = "Rectangle";
            menuRect.Click += menuRect_Click;
            // 
            // menuEllipse
            // 
            menuEllipse.Name = "menuEllipse";
            menuEllipse.Size = new Size(251, 44);
            menuEllipse.Text = "Ellipse";
            menuEllipse.Click += menuEllipse_Click;
            // 
            // menuHelp
            // 
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(84, 36);
            menuHelp.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Point, Line, Rectangle, Ellipse, LineWithCircles, Cube });
            toolStrip1.Location = new Point(0, 40);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(867, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // Point
            // 
            Point.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Point.Image = (Image)resources.GetObject("Point.Image");
            Point.ImageTransparentColor = Color.Magenta;
            Point.Name = "Point";
            Point.Size = new Size(46, 36);
            Point.Text = "Point";
            Point.ToolTipText = "Point";
            Point.Click += Point_Click;
            // 
            // Line
            // 
            Line.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Line.Image = (Image)resources.GetObject("Line.Image");
            Line.ImageTransparentColor = Color.Magenta;
            Line.Name = "Line";
            Line.Size = new Size(46, 36);
            Line.Text = "Line";
            Line.ToolTipText = "Line";
            Line.Click += Line_Click;
            // 
            // Rectangle
            // 
            Rectangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Rectangle.Image = (Image)resources.GetObject("Rectangle.Image");
            Rectangle.ImageTransparentColor = Color.Magenta;
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(46, 36);
            Rectangle.Text = "Rectangle";
            Rectangle.ToolTipText = "Rectangle";
            Rectangle.Click += Rectangle_Click;
            // 
            // Ellipse
            // 
            Ellipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Ellipse.Image = (Image)resources.GetObject("Ellipse.Image");
            Ellipse.ImageTransparentColor = Color.Magenta;
            Ellipse.Name = "Ellipse";
            Ellipse.Size = new Size(46, 36);
            Ellipse.Text = "Ellipse";
            Ellipse.ToolTipText = "Ellipse";
            Ellipse.Click += Ellipse_Click;
            // 
            // LineWithCircles
            // 
            LineWithCircles.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LineWithCircles.Image = (Image)resources.GetObject("LineWithCircles.Image");
            LineWithCircles.ImageTransparentColor = Color.Magenta;
            LineWithCircles.Name = "LineWithCircles";
            LineWithCircles.Size = new Size(46, 36);
            LineWithCircles.Text = "LineWithCircles";
            LineWithCircles.ToolTipText = "LineWithCircles";
            LineWithCircles.Click += LineWithCircles_Click;
            // 
            // Cube
            // 
            Cube.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Cube.Image = (Image)resources.GetObject("Cube.Image");
            Cube.ImageTransparentColor = Color.Magenta;
            Cube.Name = "Cube";
            Cube.Size = new Size(46, 36);
            Cube.Text = "Cube";
            Cube.ToolTipText = "Cube";
            Cube.Click += Cube_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(867, 480);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Lab 2 - Shape Editor";
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuObjects;
        private System.Windows.Forms.ToolStripMenuItem menuPoint;
        private System.Windows.Forms.ToolStripMenuItem menuLine;
        private System.Windows.Forms.ToolStripMenuItem menuRect;
        private System.Windows.Forms.ToolStripMenuItem menuEllipse;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private ToolStrip toolStrip1;
        private ToolStripButton Point;
        private ToolStripButton Line;
        private ToolStripButton Rectangle;
        private ToolStripButton Ellipse;
        private ToolStripButton LineWithCircles;
        private ToolStripButton Cube;
    }
}