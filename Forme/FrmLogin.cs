using Domain;
using Forme.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtUsername) | !UserControlHelpers.EmptyFieldValidation(txtPassword))
            {
                MessageBox.Show("Sva polja su obavezna!");
                return;
            }
            try
            {
                FrmMain frmMain = new FrmMain();
                this.Visible = false;
                frmMain.ShowDialog();
                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
