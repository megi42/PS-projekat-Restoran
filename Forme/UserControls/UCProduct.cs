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
using Forme.Controller;

namespace Forme.UserControls
{
    public partial class UCProduct : UserControl
    {
        private ProductController productController;

        public ComboBox CbType { get => cbType; }
        public ComboBox CbCurrency { get => cbCurrency; }
        public TextBox TxtName { get => txtName; }
        public TextBox TxtPrice { get => txtPrice; }
        public TextBox TxtVAT { get => txtVAT; }


    public UCProduct(ProductController productController)
        {
            InitializeComponent();
            this.productController = productController;
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            productController.InitUCProduct(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            productController.Save(this);
        }
    }
}
