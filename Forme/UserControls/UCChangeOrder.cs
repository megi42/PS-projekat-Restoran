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
    public partial class UCChangeOrder : UserControl
    {
        OrderController orderController;

        public UCChangeOrder(OrderController orderController)
        {
            InitializeComponent();
            this.orderController = orderController;
            orderController.InitUCChangeOrder(this);
        }

        public DataGridView DgvOrders { get => dgvOrders; }
        public DataGridView DgvItems { get => dgvItems; }
        public ComboBox CbTable { get => cbTable; }
        public ComboBox CbUser { get => cbUser; }
        public TextBox TxtDateFrom { get => txtDateFrom; }
        public TextBox TxtDateTo { get => txtDateTo; }
        public ComboBox CbProduct { get => cbProduct; }
        public TextBox TxtDate { get => txtDate; }
        public TextBox TxtCurrency { get => txtCurrency; }
        public TextBox TxtPieces { get => txtPieces; }
        public TextBox TxtTotal { get => txtTotal; }
        public TextBox TxtTotalVAT { get => txtTotalVAT; }
        public Label LblUser { get => lblUser; }
        public ComboBox CbTableI { get => cbTableI; }
        public Button BtnAdd { get => btnAdd; }
        public Button BtnCancel { get => btnCancel; }
        public Button BtnRemove { get => btnRemove; }
        public Button BtnSave { get => btnSave; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            orderController.SearchOrder(this);
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            orderController.RemoveFilters_1(this);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            orderController.ChangeOrder(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            orderController.AddItem_1(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            orderController.Cancel(this);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            orderController.RemoveItem_1(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            orderController.SaveChanges(this);
        }
    }
}

