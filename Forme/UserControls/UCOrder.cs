using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerBL;

namespace Forme.UserControls
{
    public partial class UCOrder : UserControl
    {
        public UCOrder()
        {
            InitializeComponent();
            lblUser.Text = $"Prijavljen korisnik: {Controller.Instance.LoggedInUser.FirstName} {Controller.Instance.LoggedInUser.LastName}";
        }
    }
}
