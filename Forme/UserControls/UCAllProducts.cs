using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using ControllerBL;

namespace Forme.UserControls
{
    public partial class UCAllProducts : UserControl
    {
        public UCAllProducts()
        {
            InitializeComponent();
        }

        private void UCAllProducts_Load(object sender, EventArgs e)
        {
            List<Product> products = Controller.Instance.GetAllProducts();
            dgvProducts.DataSource = products;
            dgvProducts.Columns["ProductId"].Visible = false;
            dgvProducts.Columns["Name"].HeaderText = "Naziv";
            dgvProducts.Columns["PriceWithoutVAT"].HeaderText = "Cena";
            dgvProducts.Columns["VAT"].HeaderText = "PDV";
            dgvProducts.Columns["PriceWithVAT"].HeaderText = "Cena sa PDV-om";
            dgvProducts.Columns["Currency"].HeaderText = "Valuta";
            dgvProducts.Columns["Type"].HeaderText = "Tip";
            //dgvProducts.Columns["UserId"].HeaderText = "Radnik";
            dgvProducts.Columns["UserId"].Visible = false;
            //??kako da mi se prikaze ime i prezime radnika koji je uneo proizvod???

        }
    }
}
