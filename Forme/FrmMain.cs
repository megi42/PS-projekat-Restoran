using ControllerBL;
using Forme.Controller;
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
        private readonly MainController mainController;

        public FrmMain(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            lblWelcome.Text = $"Dobro došli, {MainCoordinator.Instance.User.FirstName} {MainCoordinator.Instance.User.LastName}!";
        }

        private void unesiProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCProduct(this);
        }

        public void SetUserControl(UserControl ucUser)
        {
            pnlMainContainer.Controls.Clear();
            ucUser.Parent = pnlMainContainer;
            ucUser.Dock = DockStyle.Fill;
        }

        private void unesiPorudzbenicuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCOrder(this);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllProducts(this);
        }

        private void brisanjeProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCRemoveProduct(this);
        }

        private void pretragaPorudžbineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllOrders(this);
        }

        private void izmenaPorudžbineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCChangeOrder(this);
        }

        private void kreiranjeRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCInvoice(this);
        }
    }
}
