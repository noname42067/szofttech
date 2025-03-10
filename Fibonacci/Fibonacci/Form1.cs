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

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button b = new Button();
                    b.Left = i*20;
                    b.Top = j*20;
                    b.Width = 20;
                    b.Height = 20;
                    Controls.Add(b);
                }
            }

            
        }
    }
}