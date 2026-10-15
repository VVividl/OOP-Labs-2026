using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Module1Form : Form
    {
        public string EnteredText { get; private set; } = string.Empty;

        public Module1Form()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            EnteredText = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}