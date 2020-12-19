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

namespace Forme.UserControls
{
    public partial class UCOrder : UserControl
    {
        private BindingList<OrderItem> bindingItems = new BindingList<OrderItem>();
        public UCOrder()
        {
            InitializeComponent();
            lblUser.Text = $"Korisnik: {Controller.Instance.LoggedInUser.FirstName} {Controller.Instance.LoggedInUser.LastName}";

            cbTable.DataSource = Controller.Instance.GetAllTables();
            cbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTable.SelectedIndex = -1;
            cbProduct.DataSource = Controller.Instance.GetAllProducts();
            cbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProduct.SelectedIndex = -1;

            InitDataGridView(); 
        }

        private void InitDataGridView()
        {
            dgvItems.DataSource = bindingItems;
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

        double total = 0;
        double totalVAT = 0;
        Currency currency;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!UserControlHelpers.EmptyFieldValidationCB(cbProduct) | !UserControlHelpers.EmptyFieldValidation(txtPieces))
            {
                MessageBox.Show("Polja 'Proizvod' i 'Količina' su obavezna!");
                return;
            }
            if (!int.TryParse(txtPieces.Text, out _))
            {
                MessageBox.Show("Pogrešan unos u polje 'Količina'! Neophodno uneti ceo broj!");
                return;
            }

            Product p = new Product();
            p = (Product)cbProduct.SelectedItem;

            currency = p.Currency;

            OrderItem orderItem = new OrderItem
            {
                Number = bindingItems.Count + 1,
                Product = p,
                Pieces = int.Parse(txtPieces.Text),
                PriceWithoutVAT = p.PriceWithoutVAT,
                PriceWithVAT = p.PriceWithVAT,
                Currency = p.Currency,
                TotalWithoutVAT = p.PriceWithoutVAT * int.Parse(txtPieces.Text),
                TotalWithVAT = p.PriceWithVAT * int.Parse(txtPieces.Text)
            };
            bindingItems.Add(orderItem);

            total += orderItem.TotalWithoutVAT;
            totalVAT += orderItem.TotalWithVAT;

            txtTotal.Text = total.ToString();
            txtTotalVAT.Text = totalVAT.ToString();

            cbProduct.SelectedIndex = -1;
            txtPieces.Clear();
            txtCurrency.Text = currency.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvItems.SelectedRows[0];
                OrderItem orderItem = (OrderItem)row.DataBoundItem;
                bindingItems.Remove(orderItem);

                for (int i = 0; i < bindingItems.Count; i++)
                {
                    bindingItems[i].Number = i + 1;
                }

                total -= orderItem.TotalWithoutVAT;
                totalVAT -= orderItem.TotalWithVAT;

                txtTotal.Text = total.ToString();
                txtTotalVAT.Text = totalVAT.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!UserControlHelpers.EmptyFieldValidationCB(cbTable))
            {
                MessageBox.Show("Polje 'Broj stola' je obavezno!");
                return;
            }

            DateTime dateTime = DateTime.Now;
            txtDate.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");

            try
            {
                Order order = new Order
                {
                    DateTime = dateTime,
                    Table = (Table)cbTable.SelectedItem,
                    TotalWithoutVAT = double.Parse(txtTotal.Text),
                    TotalWithVAT = double.Parse(txtTotalVAT.Text),
                    Currency = currency,
                    User = Controller.Instance.LoggedInUser,
                    OrderItems = bindingItems.ToList()
                };
                Controller.Instance.SaveOrder(order);
                MessageBox.Show("Porudžbina je sačuvana!");
                this.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti porudžbinu!");
            }
        }
    }
}
