using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Module2Form : Form
    {
        public int SelectedValue { get; private set; } = 50;

        public Module2Form()
        {
            InitializeComponent();
        }

        private void scroll_ValueChanged(object sender, EventArgs e)
        {
            lblValue.Text = scroll.Value.ToString();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            SelectedValue = scroll.Value;
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