using _8gyak.Models;

namespace _8gyak
{
    public partial class Form1 : Form
    {
        StudentContext context = new StudentContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = context.Students.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = (from x in context.Students
                                               where x.IsActive == false
                                               select x).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                //throw;
            }
            

        }
    }
}