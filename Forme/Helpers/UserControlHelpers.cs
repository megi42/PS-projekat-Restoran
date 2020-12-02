using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Helpers
{
    class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool EmptyFieldValidationCB(ComboBox cb)
        {
            if (cb.SelectedIndex == -1)
            {
                cb.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                cb.BackColor = Color.White;
                return true;
            }
        }
    }
}
