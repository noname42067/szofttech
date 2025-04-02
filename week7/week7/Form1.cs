using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace week7
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();







            StreamReader sr = new StreamReader("coutries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();

            foreach (var i in tömb)
            {
                countryList.Add(i);
            }

            countryDataBindingSource.DataSource = countryList;
        }

        private void countryDataBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}