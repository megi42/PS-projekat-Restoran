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

namespace Forme.UserControls
{
    public partial class UCInvoice : UserControl
    {
        public UCInvoice()
        {
            InitializeComponent();
        }

        List<Order> orders;
        List<Invoice> invoices;
        List<Order> ordersNoInvoice = new List<Order>();

        private void UCInvoice_Load(object sender, EventArgs e)
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
            dgvItems.DataSource = null;
        }

        Order order;
        List<OrderItem> orderItems;
        List<InvoiceItem> invoiceItems;
        Currency currency;
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                invoiceItems = new List<InvoiceItem>();

                DataGridViewRow row = dgvOrders.SelectedRows[0];
                order = (Order)row.DataBoundItem;

                currency = order.Currency;

                txtTable.Text = order.Table.ToString();
                txtTotal.Text = order.TotalWithoutVAT.ToString();
                txtTotalVAT.Text = order.TotalWithVAT.ToString();
                txtCurrency.Text = order.Currency.ToString();

                btnCancel.Enabled = true;
                btnPay.Enabled = true;

                DateTime dateTime = DateTime.Now;
                txtDate.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");

                User user = Controller.Instance.LoggedInUser;
                txtUser.Text = user.ToString();

                double totalToPay = Math.Ceiling(order.TotalWithVAT);
                txtTotalToPay.Text = totalToPay.ToString();

                cbPayment.Enabled = true;
                cbPayment.DataSource = Enum.GetValues(typeof(PaymentType));
                cbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
                cbPayment.SelectedIndex = -1;

                orderItems = Controller.Instance.GetOrderItems(order);

                foreach(OrderItem oi in orderItems)
                {
                    InvoiceItem ii = new InvoiceItem
                    {
                        OrderId = oi.OrderId,
                        Number = oi.Number,
                        Product = oi.Product,
                        PriceWithoutVAT = oi.PriceWithoutVAT,
                        PriceWithVAT = oi.PriceWithVAT,
                        Pieces = oi.Pieces,
                        TotalWithoutVAT = oi.TotalWithoutVAT,
                        TotalWithVAT = oi.TotalWithVAT,
                        Currency = oi.Currency
                    };

                    invoiceItems.Add(ii);
                }

                dgvItems.DataSource = invoiceItems;

                dgvItems.Columns["InvoiceId"].Visible = false;
                dgvItems.Columns["OrderId"].Visible = false;
                dgvItems.Columns["Number"].HeaderText = "RB";
                dgvItems.Columns["Product"].HeaderText = "Proizvod";
                dgvItems.Columns["Pieces"].HeaderText = "Komada";
                dgvItems.Columns["PriceWithoutVAT"].HeaderText = "Cena";
                dgvItems.Columns["PriceWithVAT"].HeaderText = "Cena(PDV)";
                dgvItems.Columns["Currency"].HeaderText = "Valuta";
                dgvItems.Columns["TotalWithoutVAT"].HeaderText = "Ukupno";
                dgvItems.Columns["TotalWithVAT"].HeaderText = "Ukupno(PDV)";
            }
            else
            {
                MessageBox.Show("Nije odabrana porudžbina za kreiranje računa!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTable.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtTotalVAT.Text = string.Empty;
            txtCurrency.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtTotalToPay.Text = string.Empty;
            txtDate.Text = string.Empty;

            dgvItems.DataSource = null;

            cbPayment.SelectedIndex = -1;
            cbPayment.Enabled = false;

            btnCancel.Enabled = false;
            btnPay.Enabled = false;
            btnSave.Enabled = false;

            txtCache.Text = string.Empty;
            txtCache.Enabled = false;
            txtCard.Text = string.Empty;
            txtCard.Enabled = false;
            cbCardType.SelectedIndex = -1;
            cbCardType.Enabled = false;
            txtCardNumber.Text = string.Empty;
            txtCardNumber.Enabled = false;
            
        }


        private void cbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            txtCache.Text = string.Empty;
            txtCache.Enabled = false;
            txtCard.Text = string.Empty;
            txtCard.Enabled = false;
            cbCardType.SelectedIndex = -1;
            cbCardType.Enabled = false;
            txtCardNumber.Text = string.Empty;
            txtCardNumber.Enabled = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!UserControlHelpers.EmptyFieldValidationCB(cbPayment))
            {
                MessageBox.Show("Odaberite način plaćanja");
                return;
            }

            if (cbPayment.SelectedItem.Equals(PaymentType.Gotovina))
            {
                txtCache.Text = txtTotalToPay.Text;

                txtCard.Text = string.Empty;
                txtCardNumber.Text = string.Empty;
                cbCardType.SelectedIndex = -1;

                txtCache.Enabled = false;
                txtCard.Enabled = false;
                cbCardType.Enabled = false;
                txtCardNumber.Enabled = false;

            }

            if (cbPayment.SelectedItem.Equals(PaymentType.Kartica))
            {
                txtCard.Text = txtTotalToPay.Text;

                txtCache.Text = string.Empty;
                txtCardNumber.Text = string.Empty;
                cbCardType.SelectedIndex = -1;

                txtCache.Enabled = false;
                txtCard.Enabled = false;
                cbCardType.Enabled = true;
                cbCardType.DataSource = Enum.GetValues(typeof(CardType));
                cbCardType.SelectedIndex = -1;
                cbCardType.DropDownStyle = ComboBoxStyle.DropDownList;
                txtCardNumber.Enabled = true;
            }

            if (cbPayment.SelectedItem.Equals(PaymentType.Kombinovano))
            {
                txtCache.Text = string.Empty;
                txtCard.Text = string.Empty;
                txtCardNumber.Text = string.Empty;
                cbCardType.SelectedIndex = -1;

                txtCache.Enabled = true;
                txtCard.Enabled = true;
                cbCardType.Enabled = true;
                cbCardType.DataSource = Enum.GetValues(typeof(CardType));
                cbCardType.SelectedIndex = -1;
                cbCardType.DropDownStyle = ComboBoxStyle.DropDownList;
                txtCardNumber.Enabled = true;
            }

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbPayment.SelectedItem.Equals(PaymentType.Kartica) || cbPayment.SelectedItem.Equals(PaymentType.Kombinovano))
            {
                if (!UserControlHelpers.EmptyFieldValidationCB(cbCardType) | !UserControlHelpers.EmptyFieldValidation(txtCardNumber))
                {
                    MessageBox.Show("Neophodno je uneti 'tip kartice' i broj kartice'");
                    return;
                }
                if (!UserControlHelpers.CheckLongIntType(txtCardNumber))
                {
                    MessageBox.Show("Broj kartice nije ispravano unet.");
                    return;
                }
            }

            double totalToPay = int.Parse(txtTotalToPay.Text);
            double card;
            double cache;

            if (cbPayment.SelectedItem.Equals(PaymentType.Kombinovano))
            {
                if (string.IsNullOrEmpty(txtCache.Text) | string.IsNullOrEmpty(txtCard.Text))
                {
                    MessageBox.Show("Neophodno je popuniti polja: 'Iznos koji se plaća gotovinom', 'Iznos koji se plaća karticom'");
                    return;
                }

                if(!UserControlHelpers.CheckDoubleType(txtCache) | !UserControlHelpers.CheckDoubleType(txtCard))
                {
                    MessageBox.Show("Neispravan unos iznosa za plaćanje. Unete vrednosti moraju biti brojevi.");
                    return;
                }

                cache = double.Parse(txtCache.Text);
                card = double.Parse(txtCard.Text);

                if((card + cache) != totalToPay)
                {
                    MessageBox.Show($"Neispravan unos iznosa za plaćanje. Ukupan iznos za plaćanje iznosi {totalToPay}.");
                    return;
                }
               
            }

            Cache cache1 = null;
            Card card1 = null;

            DateTime dateTime = DateTime.Now;
            txtDate.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");

            Table table = new Table
            {
                TableNumber = int.Parse(txtTable.Text)
            };

            try
            {
                if (cbPayment.SelectedItem.Equals(PaymentType.Gotovina))
                {
                    cache = totalToPay;

                    cache1 = new Cache
                    {
                        OrderId = order.OrderId,
                        TotalInCache = cache
                    };
                }

                if (cbPayment.SelectedItem.Equals(PaymentType.Kartica))
                {
                    card = totalToPay;

                    card1 = new Card
                    {
                        OrderId = order.OrderId,
                        CardType = (CardType)cbCardType.SelectedItem,
                        CardNumber = long.Parse(txtCardNumber.Text),
                        TotalByCard = card
                    };
                }

                if (cbPayment.SelectedItem.Equals(PaymentType.Kombinovano))
                {
                    card = double.Parse(txtCard.Text);
                    cache = double.Parse(txtCache.Text);

                    card1 = new Card
                    {
                        OrderId = order.OrderId,
                        CardType = (CardType)cbCardType.SelectedItem,
                        CardNumber = long.Parse(txtCardNumber.Text),
                        TotalByCard = card
                    };

                    cache1 = new Cache
                    {
                        OrderId = order.OrderId,
                        TotalInCache = cache
                    };
                }

                Payment payment = new Payment
                {
                    OrderId = order.OrderId,
                    Total = totalToPay,
                    Currency = currency,
                    PaymentType = (PaymentType)cbPayment.SelectedItem,
                    Cache = cache1,
                    Card = card1
                };

                Invoice invoice = new Invoice
                {
                    DateTime = dateTime,
                    User = Controller.Instance.LoggedInUser,
                    Table = table,
                    Currency = currency,
                    TotalWithoutVAT = double.Parse(txtTotal.Text),
                    TotalWithVAT = double.Parse(txtTotalVAT.Text),
                    TotalToPay = double.Parse(txtTotalToPay.Text),
                    InvoiceItems = invoiceItems,
                    OrderId = order.OrderId,
                    Payment = payment
                };

                Controller.Instance.SaveInvoice(invoice);
                MessageBox.Show("Račun je sačuvan!");
                this.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti račun!");
            }

        }
    }
}
