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
    public partial class ExpenseTrackerForm : Form
    {
        List<string> expenses = new List<string>();
        string filePath = "expenses.txt";
        public ExpenseTrackerForm()
        {
            InitializeComponent();
            cmbType.Items.AddRange(new string[] { "Food", "Travel", "Bills", "Other" });
            LoadExpenses();
        }

        private void ExpenseTrackerForm_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string record = $"{dtDate.Value.ToShortDateString()} | {cmbType.Text} | {txtAmount.Text} | {txtDesc.Text}";
            expenses.Add(record);
            File.AppendAllLines(filePath, new[] { record });
            LoadExpenses();
        }

        private void LoadExpenses()
        {
            dataGridView1.Rows.Clear();
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split('|');
                    dataGridView1.Rows.Add(parts);
                }
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
