namespace Lab1
{
    partial class Module1Form
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
            txtInput = new TextBox();
            btnYes = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(40, 40);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Введіть текст...";
            txtInput.Size = new Size(300, 39);
            txtInput.TabIndex = 0;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(40, 100);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(130, 46);
            btnYes.TabIndex = 1;
            btnYes.Text = "Так";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 46);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Відміна";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Module1Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 190);
            Controls.Add(btnCancel);
            Controls.Add(btnYes);
            Controls.Add(txtInput);
            Name = "Module1Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Стрічка вводу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnYes;
        private Button btnCancel;
    }
}