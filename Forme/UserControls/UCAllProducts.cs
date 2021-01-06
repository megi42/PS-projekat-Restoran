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
using Forme.Controller;

namespace Forme.UserControls
{
    public partial class UCAllProducts : UserControl
    {
        private ProductController productController;

        public UCAllProducts(ProductController productController)
        {
            InitializeComponent();
            this.productController = productController;
            productController.InitUCAllProducts(this);
        }

        public DataGridView DgvProducts { get => dgvProducts; }
        public TextBox TxtSearch { get => txtSearch; }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            productController.Search(this);
        }
    }
}
