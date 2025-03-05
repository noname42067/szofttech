using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wind
{
    internal class VillogoGomb:Button
    {
        public VillogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Salmon;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();

            BackColor = Color.Fuchsia;
        }
    }
}
