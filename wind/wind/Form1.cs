namespace wind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool siker = int.TryParse(textBox1.Text, out int val);

            if (!siker) return;

            Random random = new Random();

            for (int i = 0; i < val; i++)
            {
                Button b = new Button();
                b.Left = random.Next(500);
                b.Top = random.Next(500);
                b.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                Controls.Add(b);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool succes = int.TryParse(textBox1.Text, out int text);

            if (!succes)
            {
                textBox1.BackColor = Color.Salmon;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int méret = 20;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    //VillogoGomb vg = new VillogoGomb();
                    //SzinezodoGomb vg = new SzinezodoGomb();
                    SzamoloGomb vg = new SzamoloGomb();


                    vg.Top = sor * méret;
                    vg.Left = oszlop * méret;
                    vg.Height = méret;
                    vg.Width = méret;

                    //int szam = int.Parse(vg.Text);
                    //if (szam>5)
                    //{
                    //    vg.Szám = 1;
                    //}

                    Controls.Add(vg);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Random r = new Random();

            int width = r.Next(20, 51);
            int height = r.Next(20, 51);
            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                b.Top = r.Next();
                b.Left = r.Next();
                b.Width = r.Next(this.ClientSize.Width - width);
                b.Height = r.Next(this.ClientSize.Height - height);

                this.Controls.Add(b);
            }
        }
    }
}