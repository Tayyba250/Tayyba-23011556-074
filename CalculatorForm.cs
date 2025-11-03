using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAssignment02
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = $"Result: {a + b}";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = $"Result: {a - b}";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = $"Result: {a * b}";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            if (b != 0)
                lblResult.Text = $"Result: {a / b}";
            else
                lblResult.Text = "Cannot divide by zero!";
        }
    }
}
