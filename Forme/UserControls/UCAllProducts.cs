﻿using System;
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
        List<Product> products;
        public UCAllProducts()
        {
            InitializeComponent();
        }

        private void UCAllProducts_Load(object sender, EventArgs e)
        {
            products = Controller.Instance.GetAllProducts();

            dgvProducts.DataSource = products;
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

            foreach (Product p in products)
            {
                string pNameToLower = p.Name.ToLower();
                if (pNameToLower.Contains(searchTextToLower))
                {
                    newBindingProducts.Add(p);
                }
            }
            dgvProducts.DataSource = newBindingProducts;
        }
    }
}
