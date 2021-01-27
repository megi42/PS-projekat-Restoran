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
using System.Globalization;
using Forme.Helpers;
using Forme.Controller;

namespace Forme.UserControls
{
    public partial class UCAllOrders : UserControl
    {

        OrderController orderController;

        public UCAllOrders(OrderController orderController)
        {
            InitializeComponent();
            this.orderController = orderController;
            orderController.InitUCAllOrders(this);
        }

        public DataGridView DgvOrders { get => dgvOrders; }
        public DataGridView DgvItems { get => dgvItems; }
        public ComboBox CbTable { get => cbTable; }
        public ComboBox CbUser { get => cbUser; }
        public TextBox TxtDateFrom { get => txtDateFrom; }
        public TextBox TxtDateTo { get => txtDateTo; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            orderController.Search(this);
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            orderController.RemoveFilters(this);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            orderController.Show(this);
        }
    }
}

