using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Work1_Click(object sender, EventArgs e)
        {
            Module1Form work1 = new Module1Form();

            DialogResult result = work1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                string text = work1.EnteredText;
                lblResult.Text = $"Введений текст: {text}";
            }
            else
            {
                lblResult.Text = "Дію скасовано (Робота 1)";
            }
        }
        private void Work2_Click(object sender, EventArgs e)
        {
            Module2Form work2 = new Module2Form();

            DialogResult result = work2.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                int chosenNumber = work2.SelectedValue;
                lblResult.Text = $"Вибрано число з повзунка: {chosenNumber}";
            }
            else
            {
                lblResult.Text = "Дію скасовано (Робота 2)";
            }
        }
    }
}