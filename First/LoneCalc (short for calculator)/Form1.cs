namespace LoneCalc__short_for_calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal loanAmount = decimal.Parse(tbLoanAmount.Text);
            decimal monthlyInterest = decimal.Parse(tbMonthlyInterest.Text);
            decimal monthlyPayment = decimal.Parse(tbMonthlyPayment.Text);

            decimal balance = loanAmount;
            decimal totalPaid = 0;

            int month = 1;

            List<Row> rows = new List<Row>();

            while (balance > 0)
            {
                balance += (monthlyInterest / 100m) * balance;
                balance -= monthlyPayment;
                totalPaid += monthlyPayment;
                month++;

                Row r = new();
                r.Balance = balance;
                r.Month = month;
                rows.Add(r);
            }

            tbMonthCount.Text = month.ToString();

            dataGridView1.DataSource = rows;
        }
    }
}