using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
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
            menuStrip1 = new MenuStrip();
            Work1 = new ToolStripMenuItem();
            Work2 = new ToolStripMenuItem();
            lblResult = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();

            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Work1, Work2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(580, 40);
            menuStrip1.TabIndex = 0;

            // 
            // Work1
            // 
            Work1.Name = "Work1";
            Work1.Size = new Size(110, 36);
            Work1.Text = "Робота 1";
            Work1.Click += Work1_Click;

            // 
            // Work2
            // 
            Work2.Name = "Work2";
            Work2.Size = new Size(110, 36);
            Work2.Text = "Робота 2";
            Work2.Click += Work2_Click;

            // 
            // lblResult
            // 
            lblResult.Dock = DockStyle.Fill;
            lblResult.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = Color.DimGray;
            lblResult.Location = new Point(0, 40);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(580, 310);
            lblResult.TabIndex = 1;
            lblResult.Text = "Результат з'явиться тут...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(580, 350);
            Controls.Add(lblResult);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №1 - Матюшенко Анастасія";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Work1;
        private ToolStripMenuItem Work2;
        private Label lblResult;
    }
}