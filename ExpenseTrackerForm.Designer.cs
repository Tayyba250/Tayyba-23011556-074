namespace WinFormsAssignment02
{
    partial class ExpenseTrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbType = new ComboBox();
            txtAmount = new TextBox();
            txtDesc = new TextBox();
            dtDate = new DateTimePicker();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            Date = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.AutoCompleteCustomSource.AddRange(new string[] { "Food", "Travel", "Bill" });
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(122, 77);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 0;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(71, 140);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(101, 23);
            txtAmount.TabIndex = 1;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(197, 140);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(101, 23);
            txtDesc.TabIndex = 2;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(358, 40);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(200, 23);
            dtDate.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(124, 208);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Type, Amount, Description });
            dataGridView1.Location = new Point(58, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 143);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 143);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Description";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // ExpenseTrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(dtDate);
            Controls.Add(txtDesc);
            Controls.Add(txtAmount);
            Controls.Add(cmbType);
            Name = "ExpenseTrackerForm";
            Text = "ExpenseTrackerForm";
            Load += ExpenseTrackerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbType;
        private TextBox txtAmount;
        private TextBox txtDesc;
        private DateTimePicker dtDate;
        private Button btnSave;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Description;
    }
}
