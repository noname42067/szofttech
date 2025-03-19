using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class QuestionUserControl1 : UserControl
    {
        int ans;

        public QuestionUserControl1()
        {
            InitializeComponent();
        }

        public QuestionUserControl1(string q, string a1, string a2, string a3, string a4, int ans)
        {
            InitializeComponent();

            label1.Text = q;
            button1.Text = a1;
            button2.Text = a2;
            button3.Text = a3;
            button4.Text = a4;

            this.ans = ans;

        }

        void Good()
        {
            if (ans == 1) button1.BackColor = Color.Green;
            if (ans==2) button2.BackColor = Color.Green;
            if (ans == 3) button3.BackColor = Color.Green;
            if (ans == 4) button4.BackColor = Color.Green;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            Good();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            Good();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            Good();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            Good();
        }
    }
}
