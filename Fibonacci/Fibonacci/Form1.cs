namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool siker = double.TryParse(textBox1.Text, out double d);
            if (siker)
            {
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Salmon;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<FibonacciRow> szamok = new();

            bool succes = int.TryParse(textBox1.Text, out int count);
            if (!succes) { return; }

            for (int i = 0; i < count; i++)
            {
                FibonacciRow r = new FibonacciRow();
                r.RowNumber = i;
                r.Value = Fibonacci(i);

                szamok.Add(r);
            }

            dataGridView1.DataSource = szamok;
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) { return 1; }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}