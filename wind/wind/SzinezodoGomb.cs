using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wind
{
    internal class SzinezodoGomb : Button
    {
        int size = 20;
        public SzinezodoGomb()
        {
            Height = size;
            Width = size;
            Click += SzinezodoGomb_Click;
        }

        private void SzinezodoGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
