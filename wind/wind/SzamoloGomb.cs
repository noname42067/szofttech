using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wind
{
    internal class SzamoloGomb : Button
    {
        int szám;
        public SzamoloGomb()
        {
            int mer = 20;
            Height = mer;
            Width = mer;

            Click += SzamoloGomb_Click;

            szám = 1;
            Text = szám.ToString();
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            
            szám++;

            if (szám>5)
            {
                szám = 1;

            }
            Text = szám.ToString();


        }
    }
}
