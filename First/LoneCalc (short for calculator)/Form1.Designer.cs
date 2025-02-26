namespace LoneCalc__short_for_calculator_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbLoanAmount = new TextBox();
            tbMonthlyInterest = new TextBox();
            tbMonthlyPayment = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            tbMonthCount = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbLoanAmount
            // 
            tbLoanAmount.Location = new Point(12, 32);
            tbLoanAmount.Name = "tbLoanAmount";
            tbLoanAmount.Size = new Size(173, 23);
            tbLoanAmount.TabIndex = 0;
            tbLoanAmount.Text = "10000000";
            // 
            // tbMonthlyInterest
            // 
            tbMonthlyInterest.Location = new Point(12, 82);
            tbMonthlyInterest.Name = "tbMonthlyInterest";
            tbMonthlyInterest.Size = new Size(173, 23);
            tbMonthlyInterest.TabIndex = 1;
            tbMonthlyInterest.Text = "1";
            // 
            // tbMonthlyPayment
            // 
            tbMonthlyPayment.Location = new Point(12, 132);
            tbMonthlyPayment.Name = "tbMonthlyPayment";
            tbMonthlyPayment.Size = new Size(173, 23);
            tbMonthlyPayment.TabIndex = 2;
            tbMonthlyPayment.Text = "200000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 3;
            label1.Text = "Loan Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 4;
            label2.Text = "Monthly Interest";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 5;
            label3.Text = "Monthly Payment";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(56, 185);
            button1.Name = "button1";
            button1.Size = new Size(60, 24);
            button1.TabIndex = 6;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbMonthCount
            // 
            tbMonthCount.BackColor = SystemColors.Info;
            tbMonthCount.Enabled = false;
            tbMonthCount.Location = new Point(12, 243);
            tbMonthCount.Name = "tbMonthCount";
            tbMonthCount.Size = new Size(173, 23);
            tbMonthCount.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(396, 331);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 403);
            Controls.Add(dataGridView1);
            Controls.Add(tbMonthCount);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMonthlyPayment);
            Controls.Add(tbMonthlyInterest);
            Controls.Add(tbLoanAmount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLoanAmount;
        private TextBox tbMonthlyInterest;
        private TextBox tbMonthlyPayment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox tbMonthCount;
        private DataGridView dataGridView1;
    }
}