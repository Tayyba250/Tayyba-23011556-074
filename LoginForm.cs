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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                MessageBox.Show($"Welcome {txtUser.Text}!");
            }
            else
            {
                lblMsg.Text = "Invalid username or password.";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
