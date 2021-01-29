using Domain;
using Forme.Helpers;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class ProductController
    {
        private BindingList<Product> products = new BindingList<Product>();

        internal void InitUCProduct(UCProduct ucProduct)
        {
            ucProduct.CbType.DataSource = Enum.GetValues(typeof(ProductType));
            ucProduct.CbCurrency.DataSource = Enum.GetValues(typeof(Currency));

            ucProduct.CbType.DropDownStyle = ComboBoxStyle.DropDownList;
            ucProduct.CbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;

            ucProduct.CbType.SelectedIndex = -1;
            ucProduct.CbCurrency.SelectedIndex = -1;
        }

        internal void InitUCAllProducts(UCAllProducts uCAllProducts)
        {
            uCAllProducts.DgvProducts.DataSource = Communication.Communication.Instance.GetAllProducts();

            uCAllProducts.DgvProducts.Columns["ProductId"].Visible = false;
            uCAllProducts.DgvProducts.Columns["Name"].HeaderText = "Naziv";
            uCAllProducts.DgvProducts.Columns["PriceWithoutVAT"].HeaderText = "Cena";
            uCAllProducts.DgvProducts.Columns["VAT"].HeaderText = "PDV";
            uCAllProducts.DgvProducts.Columns["PriceWithVAT"].HeaderText = "Cena sa PDV-om";
            uCAllProducts.DgvProducts.Columns["Currency"].HeaderText = "Valuta";
            uCAllProducts.DgvProducts.Columns["Type"].HeaderText = "Tip";
            uCAllProducts.DgvProducts.Columns["User"].HeaderText = "Radnik";
        }

        internal void InitUCRemoveProduct(UCRemoveProduct uCRemoveProduct)
        {
            uCRemoveProduct.DgvProducts.DataSource = Communication.Communication.Instance.GetAllProducts();

            uCRemoveProduct.DgvProducts.Columns["ProductId"].Visible = false;
            uCRemoveProduct.DgvProducts.Columns["Name"].HeaderText = "Naziv";
            uCRemoveProduct.DgvProducts.Columns["PriceWithoutVAT"].HeaderText = "Cena";
            uCRemoveProduct.DgvProducts.Columns["VAT"].HeaderText = "PDV";
            uCRemoveProduct.DgvProducts.Columns["PriceWithVAT"].HeaderText = "Cena sa PDV-om";
            uCRemoveProduct.DgvProducts.Columns["Currency"].HeaderText = "Valuta";
            uCRemoveProduct.DgvProducts.Columns["Type"].HeaderText = "Tip";
            uCRemoveProduct.DgvProducts.Columns["User"].HeaderText = "Radnik";
        }

        internal void Search(UCAllProducts uCAllProducts)
        {
            string text = uCAllProducts.TxtSearch.Text;
            Product product = new Product { Name = text };
            List<Product> products = Communication.Communication.Instance.SearchProducts(product);
            uCAllProducts.DgvProducts.DataSource = products;
            if(products.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe proizvode po zadatoj vrednosti!");
            }
        }

        internal void Search_1(UCRemoveProduct uCRemoveProduct)
        {
            string text = uCRemoveProduct.TxtSearch.Text;
            Product product = new Product { Name = text };
            List<Product> products = Communication.Communication.Instance.SearchProducts(product);
            uCRemoveProduct.DgvProducts.DataSource = products;
            if (products.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe proizvode po zadatoj vrednosti!");
            }
        }

        internal void Save(UCProduct ucProduct)
        {
            if (!UserControlHelpers.EmptyFieldValidation(ucProduct.TxtName) | !UserControlHelpers.EmptyFieldValidation(ucProduct.TxtPrice) | !UserControlHelpers.EmptyFieldValidation(ucProduct.TxtVAT) | !UserControlHelpers.EmptyFieldValidationCB(ucProduct.CbType) | !UserControlHelpers.EmptyFieldValidationCB(ucProduct.CbCurrency))
            {
                MessageBox.Show("Sva polja su obavezna!");
                return;
            }
            if (!UserControlHelpers.CheckDoubleType(ucProduct.TxtPrice) | !UserControlHelpers.CheckDoubleType(ucProduct.TxtVAT))
            {
                MessageBox.Show("Pogrešan unos!");
                return;
            }

            try
            {
                Product p = new Product();
                p.Name = ucProduct.TxtName.Text;
                p.PriceWithoutVAT = Math.Ceiling(Double.Parse(ucProduct.TxtPrice.Text));
                p.VAT = Math.Ceiling(Double.Parse(ucProduct.TxtVAT.Text));
                p.Currency = (Currency)ucProduct.CbCurrency.SelectedItem;
                p.Type = (ProductType)ucProduct.CbType.SelectedItem;

                Communication.Communication.Instance.SaveProduct(p);
                MessageBox.Show("Sistem je zapamtio proizvod!");
                ucProduct.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti proizvod!");
            }
        }

        internal void Remove(UCRemoveProduct uCRemoveProduct)
        {
            if (uCRemoveProduct.DgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = uCRemoveProduct.DgvProducts.SelectedRows[0];
                Product product = (Product)row.DataBoundItem;
                try
                {
                    Communication.Communication.Instance.RemoveProduct(product);
                    MessageBox.Show("Sistem je obrisao proizvod!");
                    uCRemoveProduct.Visible = false;
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
