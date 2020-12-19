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

namespace Forme.UserControls
{
    public partial class UCChangeOrder : UserControl
    {
        List<Order> orders;
        List<Invoice> invoices;
        List<Order> ordersNoInvoice = new List<Order>();
        public UCChangeOrder()
        {
            InitializeComponent();
        }

        private void UCChangeOrder_Load(object sender, EventArgs e)
        {
            orders = Controller.Instance.GetAllOrders();
            invoices = Controller.Instance.GetAllInvoices();

            ordersNoInvoice = UserControlHelpers.OrdersNoInvoice(orders, invoices);

            dgvOrders.DataSource = ordersNoInvoice;

            dgvOrders.Columns["OrderId"].Visible = false;
            dgvOrders.Columns["DateTime"].HeaderText = "Datum";
            dgvOrders.Columns["Table"].HeaderText = "Sto";
            dgvOrders.Columns["TotalWithoutVAT"].HeaderText = "Cena";
            dgvOrders.Columns["TotalWithVAT"].HeaderText = "Cena(PDV)";
            dgvOrders.Columns["Currency"].HeaderText = "Valuta";
            dgvOrders.Columns["User"].HeaderText = "Radnik";

            cbTable.DataSource = Controller.Instance.GetAllTables();
            cbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTable.SelectedIndex = -1;
            cbUser.DataSource = Controller.Instance.GetALLUsers();
            cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUser.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserControlHelpers.SearchOrders(cbTable, cbUser, txtDateFrom, txtDateTo, dgvOrders, ordersNoInvoice);
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = ordersNoInvoice;
            cbTable.SelectedIndex = -1;
            cbUser.SelectedIndex = -1;
            txtDateFrom.Text = string.Empty;
            txtDateTo.Text = string.Empty;
        }

        BindingList<OrderItem> orderItems;

        double total;
        double totalVAT;

        int orderId;
        Table table;
        Currency currency;

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOrders.SelectedRows[0];
                Order order = (Order)row.DataBoundItem;
                orderId = order.OrderId;
                table = order.Table;
                currency = order.Currency;

                orderItems = new BindingList<OrderItem>(Controller.Instance.GetOrderItems(order));
                dgvItems.DataSource = orderItems;

                dgvItems.Columns["OrderId"].Visible = false;
                dgvItems.Columns["Number"].HeaderText = "RB";
                dgvItems.Columns["Product"].HeaderText = "Proizvod";
                dgvItems.Columns["Pieces"].HeaderText = "Komada";
                dgvItems.Columns["PriceWithoutVAT"].HeaderText = "Cena";
                dgvItems.Columns["PriceWithVAT"].HeaderText = "Cena(PDV)";
                dgvItems.Columns["Currency"].HeaderText = "Valuta";
                dgvItems.Columns["TotalWithoutVAT"].HeaderText = "Ukupno";
                dgvItems.Columns["TotalWithVAT"].HeaderText = "Ukupno(PDV)";

                cbTableI.Text = order.Table.ToString();
                cbProduct.Enabled = true;
                cbProduct.DataSource = Controller.Instance.GetAllProducts();
                cbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
                cbProduct.SelectedIndex = -1;
                txtPieces.Enabled = true;

                lblUser.Text = order.User.ToString();
                txtCurrency.Text = order.Currency.ToString();
                txtTotal.Text = order.TotalWithoutVAT.ToString();
                txtTotalVAT.Text = order.TotalWithVAT.ToString();
                txtDate.Text = order.DateTime.ToString();

                total = order.TotalWithoutVAT;
                totalVAT = order.TotalWithVAT;

                btnAdd.Enabled = true;
                btnCancel.Enabled = true;
                btnRemove.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nije odabrana porudžbina za izmenu!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!UserControlHelpers.EmptyFieldValidationCB(cbProduct) | !UserControlHelpers.EmptyFieldValidation(txtPieces))
            {
                MessageBox.Show("Popunite polja 'Proizvod' i 'Količina' ako želite da dodate stavku!");
                return;
            }
            if (!int.TryParse(txtPieces.Text, out _))
            {
                MessageBox.Show("Pogrešan unos u polje 'Količina'! Neophodno uneti ceo broj!");
                return;
            }

            Product p = new Product();
            p = (Product)cbProduct.SelectedItem;

            OrderItem orderItem = new OrderItem
            {
                Number = orderItems.Count+ 1,
                Product = p,
                Pieces = int.Parse(txtPieces.Text),
                PriceWithoutVAT = p.PriceWithoutVAT,
                PriceWithVAT = p.PriceWithVAT,
                Currency = p.Currency,
                TotalWithoutVAT = p.PriceWithoutVAT * int.Parse(txtPieces.Text),
                TotalWithVAT = p.PriceWithVAT * int.Parse(txtPieces.Text)
            };
            orderItems.Add(orderItem);

            total += orderItem.TotalWithoutVAT;
            totalVAT += orderItem.TotalWithVAT;

            txtTotal.Text = total.ToString();
            txtTotalVAT.Text = totalVAT.ToString();

            cbProduct.SelectedIndex = -1;
            txtPieces.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblUser.Text = string.Empty;
            txtCurrency.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtTotalVAT.Text = string.Empty;
            txtDate.Text = string.Empty;
            cbTableI.Text = string.Empty;

            dgvItems.DataSource = new List<OrderItem>();

            cbProduct.Enabled = false;
            txtPieces.Enabled = false;

            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvItems.SelectedRows[0];
                OrderItem orderItem = (OrderItem)row.DataBoundItem;
                orderItems.Remove(orderItem);

                for (int i = 0; i < orderItems.Count; i++)
                {
                    orderItems[i].Number = i + 1;
                }

                total -= orderItem.TotalWithoutVAT;
                totalVAT -= orderItem.TotalWithVAT;

                txtTotal.Text = total.ToString();
                txtTotalVAT.Text = totalVAT.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            txtDate.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            Table t = table;
            double totalWithoutVAT = double.Parse(txtTotal.Text);
            double totalWithVAT = double.Parse(txtTotalVAT.Text);
            Currency c = currency;
            User user = Controller.Instance.LoggedInUser;
            List<OrderItem> items = orderItems.ToList();
            

            try
            {
                Order order = new Order
                {
                    DateTime = dateTime,
                    Table = t,
                    TotalWithoutVAT = totalWithoutVAT,
                    TotalWithVAT = totalWithVAT,
                    Currency = c,
                    User = user,
                    OrderItems = items
                };
                Controller.Instance.SaveChangesToOrder(order, orderId);
                MessageBox.Show("Izmene su sačuvane!");
                this.Visible = false;
               
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti izmene!");
            }

            dgvItems.DataSource = null;
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = Controller.Instance.GetAllOrders();

            cbTable.SelectedIndex = -1;
            cbUser.SelectedIndex = -1;
            txtDateFrom.Text = string.Empty;
            txtDateTo.Text = string.Empty;

            lblUser.Text = string.Empty;
            txtCurrency.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtTotalVAT.Text = string.Empty;
            txtDate.Text = string.Empty;
            cbTableI.Text = string.Empty;


            cbProduct.Enabled = false;
            txtPieces.Enabled = false;

            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = false;
        }
    }
}

