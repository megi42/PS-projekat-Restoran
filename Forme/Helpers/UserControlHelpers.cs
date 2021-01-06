using ControllerBL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Helpers
{
    class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool EmptyFieldValidationCB(ComboBox cb)
        {
            if (cb.SelectedIndex == -1)
            {
                cb.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                cb.BackColor = Color.White;
                return true;
            }
        }

        public static bool CheckDoubleType(TextBox txt)
        {
            bool uspesno = double.TryParse(txt.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out _);
            if(uspesno == false)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            return true;
        }

        public static bool CheckIntType(TextBox txt)
        {
            bool uspesno = int.TryParse(txt.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out _);
            if (uspesno == false)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            return true;
        }

        public static bool CheckLongIntType(TextBox txt)
        {
            bool uspesno = long.TryParse(txt.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out _);
            if (uspesno == false)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            return true;
        }

        public static List<Order> OrdersNoInvoice(List<Order> orders, List<Invoice> invoices)
        {
            List<Order> ordersNoInvoice = new List<Order>();
            int signal = 0;

            foreach (Order o in orders)
            {
                foreach (Invoice i in invoices)
                {
                    if (o.OrderId == i.OrderId)
                    {
                        signal = -1;
                    }
                }
                if (signal == 0)
                {
                    ordersNoInvoice.Add(o);
                }
                signal = 0;
            }
            return ordersNoInvoice;
        }

        public static bool IsOrderPayed(Order order)
        {
            List<Order> orders = Communication.Communication.Instance.GetAllOrders();
            List<Invoice> invoices = Communication.Communication.Instance.GetAllInvoices();

            List<Order> ordersNoInvoice = OrdersNoInvoice(orders, invoices);

            foreach (Order o in ordersNoInvoice)
            {
                if (o.OrderId == order.OrderId)
                {
                    return false;
                }
            }
            return true;
        }

        public static void SearchOrders(ComboBox cbTable, ComboBox cbUser, TextBox txtDateFrom, TextBox txtDateTo, DataGridView dgvOrders, List<Order> orders)
        {
            BindingList<Order> newBindingOrders = new BindingList<Order>();
            BindingList<Order> bOrdersUser = new BindingList<Order>();
            BindingList<Order> bOrdersDate1 = new BindingList<Order>();
            BindingList<Order> bOrdersDate2 = new BindingList<Order>();

            if (cbTable.SelectedIndex > -1)
            {
                Table t = (Table)cbTable.SelectedItem;
                foreach (Order o in orders)
                {
                    if (o.Table.TableNumber == t.TableNumber)
                    {
                        newBindingOrders.Add(o);
                    }
                }
                dgvOrders.DataSource = newBindingOrders;
            }
            else
            {
                newBindingOrders = new BindingList<Order>(orders);
                dgvOrders.DataSource = orders;
            }

            if (cbUser.SelectedIndex > -1)
            {
                User u = (User)cbUser.SelectedItem;
                foreach (Order o in newBindingOrders)
                {
                    if (o.User.Id == u.Id)
                    {
                        bOrdersUser.Add(o);
                    }
                }
                dgvOrders.DataSource = bOrdersUser;
            }
            else
            {
                bOrdersUser = newBindingOrders;
                dgvOrders.DataSource = newBindingOrders;
            }

            if (!string.IsNullOrEmpty(txtDateFrom.Text))
            {
                if (!DateTime.TryParseExact(txtDateFrom.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show("'Datum od', koji je unet, nije u odgovarajućem formatu! Datume unesite u formatu:dd.MM.yyyy.!");
                    dgvOrders.DataSource = orders;
                    return;
                }
                Order or = new Order();
                or.DateTime = DateTime.ParseExact(txtDateFrom.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
                foreach (Order o in bOrdersUser)
                {
                    if (o.DateTime.Date.Equals(or.DateTime) || o.DateTime.Date > or.DateTime)
                    {
                        bOrdersDate1.Add(o);
                    }
                }
                dgvOrders.DataSource = bOrdersDate1;
            }
            else
            {
                bOrdersDate1 = bOrdersUser;
                dgvOrders.DataSource = bOrdersUser;
            }

            if (!string.IsNullOrEmpty(txtDateTo.Text))
            {
                if (!DateTime.TryParseExact(txtDateTo.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show("'Datum do', koji je unet, nije u odgovarajućem formatu! Datume unesite u formatu:dd.MM.yyyy.!");
                    dgvOrders.DataSource = orders;
                    return;
                }
                Order or = new Order();
                or.DateTime = DateTime.ParseExact(txtDateTo.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
                foreach (Order o in bOrdersDate1)
                {
                    if (o.DateTime.Date.Equals(or.DateTime) || o.DateTime.Date < or.DateTime)
                    {
                        bOrdersDate2.Add(o);
                    }
                }
                dgvOrders.DataSource = bOrdersDate2;
            }
            else
            {
                dgvOrders.DataSource = bOrdersDate1;
            }
        }
    }
}
