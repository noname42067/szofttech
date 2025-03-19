using System.Security.Cryptography.X509Certificates;

namespace ZH1D_bz5462
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> s = new List<Sor>();

            for (int j = 1; j <= 10; j++)
            {
                Sor sor = new Sor();
                sor.Sorszám = j;
                sor.Faktoriális = faktorialis(j);

                s.Add(sor);
            }
            dataGridView1.DataSource = s;
        }

        long faktorialis(long n)
        {
            long eredmeny = 1;
            for (int i = 1; i <= n; i++)
            {
                eredmeny = eredmeny * i;
            }
            return eredmeny;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = 20;
            bool success = int.TryParse(textBox1.Text, out int x);
            if (success)
            {
                for (int i = 0; i < x; i++)
                {
                    SmileyButton b = new SmileyButton();
                    b.Height = height;
                    b.Top = i * height;

                    Controls.Add(b);
                }
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}