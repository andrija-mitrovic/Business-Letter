using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLetter.Validation
{
    public class Valid
    {
        public static void f_int(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            int broj;
            if (Int32.TryParse(((TextBox)sender).Text, out broj)) e.Cancel = false;
            if (broj == 0) e.Cancel = true;
            if (e.Cancel)
            {
                ((TextBox)sender).Clear();
                MessageBox.Show("U ovo polje mozete unjeti samo broj ...", "Greska !");
            }
        }
        public static void _KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
