using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1D_bz5462
{
    internal class SmileyButton : Label
    {
        
        public SmileyButton()
        {
            AutoSize = true;
            BackColor = Color.Gray;
            Text = "🙁";
            
            MouseClick += SmileyButton_MouseClick;

        }
        public int szoveg = 1;
        private void SmileyButton_MouseClick(object? sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            
            
            if (szoveg > 4)
            {
                szoveg = 1;
            }
            

            string sz1 = "😮";
            string sz2 = "😡";
            string sz3 = "😀";
            string sz4 = "🙁";

            if (szoveg== 1) { Text = sz1; }
            if (szoveg == 2) { Text = sz2; }
            if (szoveg== 3) {  Text = sz3; }
            if (szoveg== 4) {  Text = sz4; }

            szoveg++;
        }
    }
}
