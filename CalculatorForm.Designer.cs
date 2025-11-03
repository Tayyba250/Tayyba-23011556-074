namespace WinFormsAssignment02
{
    partial class CalculatorForm
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(219, 59);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(219, 114);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(67, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(171, 168);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 3;
            btnSub.Text = "Sub";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(272, 168);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(75, 23);
            btnMul.TabIndex = 4;
            btnMul.Text = "Mul";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(373, 168);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 23);
            btnDiv.TabIndex = 5;
            btnDiv.Text = "Div";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(217, 247);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 62);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 117);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Num2";
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Label lblResult;
        private Label label1;
        private Label label2;
    }
}
