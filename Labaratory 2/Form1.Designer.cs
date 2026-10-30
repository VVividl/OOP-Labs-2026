namespace Lab2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuObjects,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(62, 34);
            this.menuFile.Text = "File";
            // 
            // menuObjects
            // 
            this.menuObjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPoint,
            this.menuLine,
            this.menuRect,
            this.menuEllipse});
            this.menuObjects.Name = "menuObjects";
            this.menuObjects.Size = new System.Drawing.Size(107, 34);
            this.menuObjects.Text = "Objects";
            // 
            // menuPoint
            // 
            this.menuPoint.Name = "menuPoint";
            this.menuPoint.Size = new System.Drawing.Size(359, 40);
            this.menuPoint.Text = "Point";
            this.menuPoint.Click += new System.EventHandler(this.menuPoint_Click);
            // 
            // menuLine
            // 
            this.menuLine.Name = "menuLine";
            this.menuLine.Size = new System.Drawing.Size(359, 40);
            this.menuLine.Text = "Line";
            this.menuLine.Click += new System.EventHandler(this.menuLine_Click);
            // 
            // menuRect
            // 
            this.menuRect.Name = "menuRect";
            this.menuRect.Size = new System.Drawing.Size(359, 40);
            this.menuRect.Text = "Rectangle";
            this.menuRect.Click += new System.EventHandler(this.menuRect_Click);
            // 
            // menuEllipse
            // 
            this.menuEllipse.Name = "menuEllipse";
            this.menuEllipse.Size = new System.Drawing.Size(359, 40);
            this.menuEllipse.Text = "Ellipse";
            this.menuEllipse.Click += new System.EventHandler(this.menuEllipse_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(75, 34);
            this.menuHelp.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab 2 - Shape Editor";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}