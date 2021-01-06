using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerBL;
using Domain;
using Forme.Helpers;
using Forme.Controller;

namespace Forme.UserControls
{
    public partial class UCOrder : UserControl
    {
        private OrderController orderController;
        public UCOrder(OrderController orderController)
        {
            InitializeComponent();
            this.orderController = orderController;
            orderController.InitUCOrder(this);
        }

        public DataGridView DgvItems { get => dgvItems; }
        public ComboBox CbTable { get => cbTable; }
        public ComboBox CbProduct { get => cbProduct; }
        public TextBox TxtDate { get => txtDate; }
        public TextBox TxtCurrency { get => txtCurrency; }
        public TextBox TxtPieces { get => txtPieces; }
        public TextBox TxtTotal { get => txtTotal; }
        public TextBox TxtTotalVAT { get => txtTotalVAT; }
        public Label LblUser { get => lblUser; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            orderController.AddItem(this);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            orderController.RemoveItem(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            orderController.SaveOrder(this);
        }
    }
}
