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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLoginApp_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm form = new CalculatorForm();
            form.Show();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            ExpenseTrackerForm form = new ExpenseTrackerForm();
            form.Show();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            Quizform form = new Quizform();
            form.Show();
        }
    }
}
