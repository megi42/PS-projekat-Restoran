using ControllerBL;
using Forme.UserControls;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblWelcome.Text = $"Dobro došli, {Controller.Instance.LoggedInUser.FirstName} {Controller.Instance.LoggedInUser.LastName}!";
        }

        private void unesiProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUserControl(new UCProduct());
        }

        private void SetUserControl(UserControl ucUser)
        {
            pnlMainContainer.Controls.Clear();
            ucUser.Parent = pnlMainContainer;
            ucUser.Dock = DockStyle.Fill;
        }

        private void unesiPorudzbenicuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUserControl(new UCOrder());
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUserControl(new UCAllProducts());
        }

        private void brisanjeProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUserControl(new UCAllProducts());
        }
    }
}
