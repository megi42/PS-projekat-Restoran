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
    public partial class UCAllOrders : UserControl
    {
        List<Order> orders;

        public UCAllOrders()
        {
            InitializeComponent();
        }

        private void UCAllOrders_Load(object sender, EventArgs e)
        {
            orders = Controller.Instance.GetAllOrders();
            dgvOrders.DataSource = orders;
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
            UserControlHelpers.SearchOrders(cbTable, cbUser, txtDateFrom, txtDateTo, dgvOrders, orders);
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            dgvOrders.DataSource = orders;
            cbTable.SelectedIndex = -1;
            cbUser.SelectedIndex = -1;
            txtDateFrom.Text = string.Empty;
            txtDateTo.Text = string.Empty;
            dgvItems.DataSource = null;
            lblPayed.Text = "Status plaćanja";
        }

        List<OrderItem> orderItems;

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOrders.SelectedRows[0];
                Order order = (Order)row.DataBoundItem;

                if (UserControlHelpers.IsOrderPayed(order))
                {
                    lblPayed.Text = "Plaćeno";
                }
                else
                {
                    lblPayed.Text = "Nije plaćeno";
                }

                orderItems = Controller.Instance.GetOrderItems(order);
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
            }
            else
            {
                MessageBox.Show("Nije odabrana porudžbina za izmenu!");
            }
        }
    }
}

