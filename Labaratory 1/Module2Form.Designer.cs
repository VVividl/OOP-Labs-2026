namespace Lab1
{
    partial class Module2Form
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
            label1 = new Label();
            scroll = new HScrollBar();
            lblValue = new Label();
            btnYes = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 20);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 0;
            label1.Text = "Оберіть число від 1 до 100:";
            // 
            // scroll
            // 
            scroll.Location = new Point(40, 114);
            scroll.Maximum = 109;
            scroll.Minimum = 1;
            scroll.Name = "scroll";
            scroll.Size = new Size(300, 67);
            scroll.TabIndex = 1;
            scroll.Value = 1;
            scroll.ValueChanged += scroll_ValueChanged;
            // 
            // lblValue
            // 
            lblValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValue.ForeColor = SystemColors.Highlight;
            lblValue.Location = new Point(45, 52);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(300, 62);
            lblValue.TabIndex = 2;
            lblValue.Text = "1";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(40, 184);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(130, 46);
            btnYes.TabIndex = 3;
            btnYes.Text = "Так";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 46);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Відміна";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Module2Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 286);
            Controls.Add(btnCancel);
            Controls.Add(btnYes);
            Controls.Add(lblValue);
            Controls.Add(scroll);
            Controls.Add(label1);
            Name = "Module2Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вибір числа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private HScrollBar scroll;
        private Label lblValue;
        private Button btnYes;
        private Button btnCancel;
    }
}