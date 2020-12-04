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
using Forme.Helpers;
using ControllerBL;

namespace Forme.UserControls
{
    public partial class UCProduct : UserControl
    {
        public UCProduct()
        {
            InitializeComponent();
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            cbType.DataSource = Enum.GetValues(typeof(ProductType));
            cbCurrency.DataSource = Enum.GetValues(typeof(Currency));

            cbType.SelectedIndex = -1;
            cbCurrency.SelectedIndex = -1;

            cbType.Text = "Izaberite tip proizvoda";
            cbCurrency.Text = "Izaberite valutu";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtName) | !UserControlHelpers.EmptyFieldValidation(txtPrice) | !UserControlHelpers.EmptyFieldValidation(txtVAT) | !UserControlHelpers.EmptyFieldValidationCB(cbType) | !UserControlHelpers.EmptyFieldValidationCB(cbCurrency))
            {
                MessageBox.Show("Sva polja su obavezna!");
                return;
            }
            if(!UserControlHelpers.CheckDoubleType(txtPrice) | !UserControlHelpers.CheckDoubleType(txtVAT))
            {
                MessageBox.Show("Pogrešan unos!");
                return;
            }

            try
            {
                Product p = new Product();
                p.Name = txtName.Text;
                p.PriceWithoutVAT = Double.Parse(txtPrice.Text);
                p.VAT = Double.Parse(txtVAT.Text);
                p.Currency = (Currency)cbCurrency.SelectedItem;
                p.Type = (ProductType)cbType.SelectedItem;
                Controller.Instance.SaveProduct(p);
                MessageBox.Show("Proizvod je sačuvan");
                this.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da sačuva proizvod!");
            }
        }
    }
}
