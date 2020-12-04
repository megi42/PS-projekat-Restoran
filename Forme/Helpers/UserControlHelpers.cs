using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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

        public static bool CheckDoubleType(TextBox txt)
        {
            bool uspesno = double.TryParse(txt.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out _);
            if(uspesno == false)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            return true;
        }
    }
}
