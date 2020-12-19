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
    public partial class UCRemoveProduct : UserControl
    {
        private BindingList<Product> bindingProducts;
        public UCRemoveProduct()
        {
            InitializeComponent();
        }

        private void UCRemoveProduct_Load(object sender, EventArgs e)
        {
            List<Product> products = Controller.Instance.GetAllProducts();
            bindingProducts = new BindingList<Product>(products);

            dgvProducts.DataSource = bindingProducts;
            dgvProducts.Columns["ProductId"].Visible = false;
            dgvProducts.Columns["Name"].HeaderText = "Naziv";
            dgvProducts.Columns["PriceWithoutVAT"].HeaderText = "Cena";
            dgvProducts.Columns["VAT"].HeaderText = "PDV";
            dgvProducts.Columns["PriceWithVAT"].HeaderText = "Cena sa PDV-om";
            dgvProducts.Columns["Currency"].HeaderText = "Valuta";
            dgvProducts.Columns["Type"].HeaderText = "Tip";
            dgvProducts.Columns["User"].HeaderText = "Radnik";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingList<Product> newBindingProducts = new BindingList<Product>();

            string searchText = txtSearch.Text;
            string searchTextToLower = searchText.ToLower();

            foreach (Product p in bindingProducts)
            {
                string pNameToLower = p.Name.ToLower();
                if (pNameToLower.Contains(searchTextToLower))
                {
                    newBindingProducts.Add(p);
                }
            }
            dgvProducts.DataSource = newBindingProducts;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                Product product = (Product)row.DataBoundItem;
                try
                {
                    Controller.Instance.DeleteProduct(product);
                    MessageBox.Show("Proizvod je obrisan!");
                    this.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistem ne može da obriše proizvod!");
                }
            }
            else
            {
                MessageBox.Show("Nije odabran proizvod za prisanje!");
            }
        }
    }
}
