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
    public partial class Quizform : Form
    {
        public Quizform()
        {
            InitializeComponent();
        }

        private void Quizform_Load(object sender, EventArgs e)
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int score = 0;

            if (radioButton2.Checked) // assuming option 2 is correct
                score++;

            lblResult.Text = $"Your score: {score}/1";
        }
    }
}
