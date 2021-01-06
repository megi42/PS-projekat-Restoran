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
using System.Globalization;
using Forme.Helpers;
using Forme.Controller;

namespace Forme.UserControls
{
    public partial class UCInvoice : UserControl
    {
        OrderController orderController;
        public UCInvoice(OrderController orderController) 
        {
            InitializeComponent();
            this.orderController = orderController;
            orderController.InitUCInvoice(this);
        }
        public DataGridView DgvOrders { get => dgvOrders; }
        public DataGridView DgvItems { get => dgvItems; }
        public ComboBox CbTable { get => cbTable; }
        public ComboBox CbUser { get => cbUser; }
        public TextBox TxtDateFrom { get => txtDateFrom; }
        public TextBox TxtDateTo { get => txtDateTo; }
        public TextBox TxtDate { get => txtDate; }
        public TextBox TxtCurrency { get => txtCurrency; }
        public TextBox TxtTotal { get => txtTotal; }
        public TextBox TxtTotalVAT { get => txtTotalVAT; }
        public Button BtnCancel { get => btnCancel; }
        public Button BtnSave { get => btnSave; }
        public TextBox TxtTable { get => txtTable; }
        public Button BtnPay { get => btnPay; }
        public TextBox TxtUser { get => txtUser; }
        public TextBox TxtTotalToPay { get => txtTotalToPay; } 
        public ComboBox CbPayment { get => cbPayment; }
        public TextBox TxtCache { get => txtCache; }
        public TextBox TxtCard { get => txtCard; }
        public TextBox TxtCardNumber { get => txtCardNumber; }
        public ComboBox CbCardType { get => cbCardType; }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            orderController.SearchOrder_1(this);
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            orderController.RemoveFilters_3(this);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            orderController.CreateInvoice(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            orderController.Cancel_1(this);
        }


        private void cbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderController.PaymentChanged(this);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            orderController.Pay(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            orderController.SaveInvoice(this);
        }
    }
}
