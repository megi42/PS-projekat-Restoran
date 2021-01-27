using Domain;
using Forme.Helpers;
using Forme.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class OrderController
    {
        BindingList<Order> orders = new BindingList<Order>();
        BindingList<OrderItem> bindingItems = new BindingList<OrderItem>();
        BindingList<OrderItem> orderItems = new BindingList<OrderItem>();

        internal void InitUCOrder(UCOrder uCOrder)
        {
            uCOrder.LblUser.Text = $"Korisnik: {MainCoordinator.Instance.User.FirstName} {MainCoordinator.Instance.User.LastName}";

            uCOrder.CbTable.DataSource = Communication.Communication.Instance.GetAllTables();
            uCOrder.CbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            uCOrder.CbTable.SelectedIndex = -1;
            uCOrder.CbProduct.DataSource = Communication.Communication.Instance.GetAllProducts();
            uCOrder.CbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            uCOrder.CbProduct.SelectedIndex = -1;

            bindingItems = new BindingList<OrderItem>();
            uCOrder.DgvItems.DataSource = bindingItems;
            uCOrder.DgvItems.Columns["OrderId"].Visible = false;
            uCOrder.DgvItems.Columns["Number"].HeaderText = "RB";
            uCOrder.DgvItems.Columns["Product"].HeaderText = "Proizvod";
            uCOrder.DgvItems.Columns["Pieces"].HeaderText = "Komada";
            uCOrder.DgvItems.Columns["PriceWithoutVAT"].HeaderText = "Cena";
            uCOrder.DgvItems.Columns["PriceWithVAT"].HeaderText = "Cena(PDV)";
            uCOrder.DgvItems.Columns["Currency"].HeaderText = "Valuta";
            uCOrder.DgvItems.Columns["TotalWithoutVAT"].HeaderText = "Ukupno";
            uCOrder.DgvItems.Columns["TotalWithVAT"].HeaderText = "Ukupno(PDV)";
        }

        internal void InitUCAllOrders(UCAllOrders uCAllOrders)
        {
            orders = new BindingList<Order>(Communication.Communication.Instance.GetAllOrders());
            uCAllOrders.DgvOrders.DataSource = orders;

            uCAllOrders.DgvOrders.Columns["OrderId"].Visible = false;
            uCAllOrders.DgvOrders.Columns["DateTime"].HeaderText = "Datum";
            uCAllOrders.DgvOrders.Columns["Table"].HeaderText = "Sto";
            uCAllOrders.DgvOrders.Columns["TotalWithoutVAT"].HeaderText = "Cena";
            uCAllOrders.DgvOrders.Columns["TotalWithVAT"].HeaderText = "Cena(PDV)";
            uCAllOrders.DgvOrders.Columns["Currency"].HeaderText = "Valuta";
            uCAllOrders.DgvOrders.Columns["User"].HeaderText = "Radnik";
            uCAllOrders.DgvOrders.Columns["State"].HeaderText = "Status";
            uCAllOrders.DgvOrders.Columns["DateFrom"].Visible = false;
            uCAllOrders.DgvOrders.Columns["DateTo"].Visible = false;

            uCAllOrders.CbTable.DataSource = Communication.Communication.Instance.GetAllTables();
            uCAllOrders.CbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            uCAllOrders.CbTable.SelectedIndex = -1;
            uCAllOrders.CbUser.DataSource = Communication.Communication.Instance.GetALLUsers();
            uCAllOrders.CbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            uCAllOrders.CbUser.SelectedIndex = -1;
        }

        internal void InitUCChangeOrder(UCChangeOrder uCChangeOrder)
        {
            List<Order> ordersNoInvoice = Communication.Communication.Instance.GetAllOrders();

            uCChangeOrder.DgvOrders.DataSource = ordersNoInvoice;

            uCChangeOrder.DgvOrders.Columns["OrderId"].Visible = false;
            uCChangeOrder.DgvOrders.Columns["DateTime"].HeaderText = "Datum";
            uCChangeOrder.DgvOrders.Columns["Table"].HeaderText = "Sto";
            uCChangeOrder.DgvOrders.Columns["TotalWithoutVAT"].HeaderText = "Cena";
            uCChangeOrder.DgvOrders.Columns["TotalWithVAT"].HeaderText = "Cena(PDV)";
            uCChangeOrder.DgvOrders.Columns["Currency"].HeaderText = "Valuta";
            uCChangeOrder.DgvOrders.Columns["User"].HeaderText = "Radnik";
            uCChangeOrder.DgvOrders.Columns["State"].HeaderText = "Status";
            uCChangeOrder.DgvOrders.Columns["DateFrom"].Visible = false;
            uCChangeOrder.DgvOrders.Columns["DateTo"].Visible = false;

            uCChangeOrder.CbTable.DataSource = Communication.Communication.Instance.GetAllTables();
            uCChangeOrder.CbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            uCChangeOrder.CbTable.SelectedIndex = -1;
            uCChangeOrder.CbUser.DataSource = Communication.Communication.Instance.GetALLUsers();
            uCChangeOrder.CbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            uCChangeOrder.CbUser.SelectedIndex = -1;
        }

        internal void InitUCInvoice(UCInvoice uCInvoice)
        {
            List<Order> orders = Communication.Communication.Instance.GetAllOrders();
            
            uCInvoice.DgvOrders.DataSource = orders;

            uCInvoice.DgvOrders.Columns["OrderId"].Visible = false;
            uCInvoice.DgvOrders.Columns["DateTime"].HeaderText = "Datum";
            uCInvoice.DgvOrders.Columns["Table"].HeaderText = "Sto";
            uCInvoice.DgvOrders.Columns["TotalWithoutVAT"].HeaderText = "Cena";
            uCInvoice.DgvOrders.Columns["TotalWithVAT"].HeaderText = "Cena(PDV)";
            uCInvoice.DgvOrders.Columns["Currency"].HeaderText = "Valuta";
            uCInvoice.DgvOrders.Columns["User"].HeaderText = "Radnik";
            uCInvoice.DgvOrders.Columns["State"].HeaderText = "Status";
            uCInvoice.DgvOrders.Columns["DateFrom"].Visible = false;
            uCInvoice.DgvOrders.Columns["DateTo"].Visible = false;

            uCInvoice.CbTable.DataSource = Communication.Communication.Instance.GetAllTables();
            uCInvoice.CbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            uCInvoice.CbTable.SelectedIndex = -1;
            uCInvoice.CbUser.DataSource = Communication.Communication.Instance.GetALLUsers();
            uCInvoice.CbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            uCInvoice.CbUser.SelectedIndex = -1;
        }

        internal void RemoveFilters(UCAllOrders uCAllOrders)
        {
            List<Order> orders = Communication.Communication.Instance.GetAllOrders();
            uCAllOrders.DgvOrders.DataSource = null;
            uCAllOrders.DgvOrders.DataSource = orders;

            uCAllOrders.DgvOrders.Columns["OrderId"].Visible = false;
            uCAllOrders.DgvOrders.Columns["DateTime"].HeaderText = "Datum";
            uCAllOrders.DgvOrders.Columns["Table"].HeaderText = "Sto";
            uCAllOrders.DgvOrders.Columns["TotalWithoutVAT"].HeaderText = "Cena";
            uCAllOrders.DgvOrders.Columns["TotalWithVAT"].HeaderText = "Cena(PDV)";
            uCAllOrders.DgvOrders.Columns["Currency"].HeaderText = "Valuta";
            uCAllOrders.DgvOrders.Columns["User"].HeaderText = "Radnik";
            uCAllOrders.DgvOrders.Columns["State"].HeaderText = "Status";
            uCAllOrders.DgvOrders.Columns["DateFrom"].Visible = false;
            uCAllOrders.DgvOrders.Columns["DateTo"].Visible = false;

            uCAllOrders.CbTable.SelectedIndex = -1;
            uCAllOrders.CbUser.SelectedIndex = -1;
            uCAllOrders.TxtDateFrom.Text = string.Empty;
            uCAllOrders.TxtDateTo.Text = string.Empty;
            uCAllOrders.DgvItems.DataSource = null;
        }

        internal void Search(UCAllOrders uCAllOrders)
        {
            if (uCAllOrders.CbTable.SelectedIndex == -1 || uCAllOrders.CbUser.SelectedIndex == -1 || string.IsNullOrEmpty(uCAllOrders.TxtDateFrom.Text) || string.IsNullOrEmpty(uCAllOrders.TxtDateTo.Text))
            {
                MessageBox.Show("Ukoliko želite da pretražite porudžbine, morate popuniti sva polja za pretragu");
                return;
            }

            if (!DateTime.TryParseExact(uCAllOrders.TxtDateFrom.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("'Datum od', koji je unet, nije u odgovarajućem formatu! Datume unesite u formatu:dd.MM.yyyy.!");
                return;
            }


            if (!DateTime.TryParseExact(uCAllOrders.TxtDateTo.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("'Datum do', koji je unet, nije u odgovarajućem formatu! Datume unesite u formatu:dd.MM.yyyy.!");
                return;
            }


            Order order = new Order();
            order.Table = (Table)uCAllOrders.CbTable.SelectedItem;
            order.User = (User)uCAllOrders.CbUser.SelectedItem;
            order.DateFrom = DateTime.ParseExact(uCAllOrders.TxtDateFrom.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            order.DateTo = DateTime.ParseExact(uCAllOrders.TxtDateTo.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            List<Order> orders = Communication.Communication.Instance.SearchOrders(order);
            uCAllOrders.DgvOrders.DataSource = orders;
        }

        internal void Show(UCAllOrders uCAllOrders)
        {
            if (uCAllOrders.DgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = uCAllOrders.DgvOrders.SelectedRows[0];
                Order order = (Order)row.DataBoundItem;
                OrderItem orderItem = new OrderItem();
                orderItem.OrderId = order.OrderId;

                List<OrderItem> orderItems = Communication.Communication.Instance.GetOrderItems(orderItem);
                uCAllOrders.DgvItems.DataSource = orderItems;

                uCAllOrders.DgvItems.Columns["OrderId"].Visible = false;
                uCAllOrders.DgvItems.Columns["Number"].HeaderText = "RB";
                uCAllOrders.DgvItems.Columns["Product"].HeaderText = "Proizvod";
                uCAllOrders.DgvItems.Columns["Pieces"].HeaderText = "Komada";
                uCAllOrders.DgvItems.Columns["PriceWithoutVAT"].HeaderText = "Cena";
                uCAllOrders.DgvItems.Columns["PriceWithVAT"].HeaderText = "Cena(PDV)";
                uCAllOrders.DgvItems.Columns["Currency"].HeaderText = "Valuta";
                uCAllOrders.DgvItems.Columns["TotalWithoutVAT"].HeaderText = "Ukupno";
                uCAllOrders.DgvItems.Columns["TotalWithVAT"].HeaderText = "Ukupno(PDV)";
            }
            else
            {
                MessageBox.Show("Nije odabrana porudžbina!");
            }
        }

        double total = 0;
        double totalVAT = 0;
        Currency currency;

        internal void AddItem(UCOrder uCOrder)
        {
            if (!UserControlHelpers.EmptyFieldValidationCB(uCOrder.CbProduct) | !UserControlHelpers.EmptyFieldValidation(uCOrder.TxtPieces))
            {
                MessageBox.Show("Polja 'Proizvod' i 'Količina' su obavezna!");
                return;
            }
            if (!int.TryParse(uCOrder.TxtPieces.Text, out _))
            {
                MessageBox.Show("Pogrešan unos u polje 'Količina'! Neophodno uneti ceo broj!");
                return;
            }

            Product p = new Product();
            p = (Product)uCOrder.CbProduct.SelectedItem;

            currency = p.Currency;

            OrderItem orderItem = new OrderItem
            {
                Number = bindingItems.Count + 1,
                Product = p,
                Pieces = int.Parse(uCOrder.TxtPieces.Text),
                PriceWithoutVAT = p.PriceWithoutVAT,
                PriceWithVAT = p.PriceWithVAT,
                Currency = p.Currency,
                TotalWithoutVAT = p.PriceWithoutVAT * int.Parse(uCOrder.TxtPieces.Text),
                TotalWithVAT = p.PriceWithVAT * int.Parse(uCOrder.TxtPieces.Text)
            };
            bindingItems.Add(orderItem);

            total += orderItem.TotalWithoutVAT;
            totalVAT += orderItem.TotalWithVAT;

            uCOrder.TxtTotal.Text = total.ToString();
            uCOrder.TxtTotalVAT.Text = totalVAT.ToString();

            uCOrder.CbProduct.SelectedIndex = -1;
            uCOrder.TxtPieces.Clear();
            uCOrder.TxtCurrency.Text = currency.ToString();
        }

        internal void RemoveItem(UCOrder uCOrder)
        {
            if (uCOrder.DgvItems.SelectedRows.Count > 0)
            {
                DataGridViewRow row = uCOrder.DgvItems.SelectedRows[0];
                OrderItem orderItem = (OrderItem)row.DataBoundItem;
                bindingItems.Remove(orderItem);

                for (int i = 0; i < bindingItems.Count; i++)
                {
                    bindingItems[i].Number = i + 1;
                }

                total -= orderItem.TotalWithoutVAT;
                totalVAT -= orderItem.TotalWithVAT;

                uCOrder.TxtTotal.Text = total.ToString();
                uCOrder.TxtTotalVAT.Text = totalVAT.ToString();
            }
            else
            {
                MessageBox.Show("Nije izabrana stavka za brisanje!");
            }
        }

        internal void SaveOrder(UCOrder uCOrder)
        {
            if (!UserControlHelpers.EmptyFieldValidationCB(uCOrder.CbTable))
            {
                MessageBox.Show("Polje 'Broj stola' je obavezno!");
                return;
            }

            DateTime dateTime = DateTime.Now;
            uCOrder.TxtDate.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");

            try
            {
                Order order = new Order
                {
                    DateTime = dateTime,
                    Table = (Table)uCOrder.CbTable.SelectedItem,
                    TotalWithoutVAT = double.Parse(uCOrder.TxtTotal.Text),
                    TotalWithVAT = double.Parse(uCOrder.TxtTotalVAT.Text),
                    Currency = currency,
                    State = "Nije placeno",
                    User = MainCoordinator.Instance.User,
                    OrderItems = bindingItems.ToList()
                };
                Communication.Communication.Instance.SaveOrder(order);
                MessageBox.Show("Porudžbina je sačuvana!");
                uCOrder.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti porudžbinu!");
            }
        }

        internal void SearchOrder(UCChangeOrder uCChangeOrder)
        {
            if (uCChangeOrder.CbTable.SelectedIndex == -1 || uCChangeOrder.CbUser.SelectedIndex == -1 || string.IsNullOrEmpty(uCChangeOrder.TxtDateFrom.Text) || string.IsNullOrEmpty(uCChangeOrder.TxtDateTo.Text))
            {
                MessageBox.Show("Ukoliko želite da pretražite porudžbine, morate popuniti sva polja za pretragu");
                return;
            }

            if (!DateTime.TryParseExact(uCChangeOrder.TxtDateFrom.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("'Datum od', koji je unet, nije u odgovarajućem formatu! Datume unesite u formatu:dd.MM.yyyy.!");
                return;
            }


            if (!DateTime.TryParseExact(uCChangeOrder.TxtDateTo.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("'Datum do', koji je unet, nije u odgovarajućem formatu! Datume unesite u formatu:dd.MM.yyyy.!");
                return;
            }


            Order order = new Order();
            order.Table = (Table)uCChangeOrder.CbTable.SelectedItem;
            order.User = (User)uCChangeOrder.CbUser.SelectedItem;
            order.DateFrom = DateTime.ParseExact(uCChangeOrder.TxtDateFrom.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            order.DateTo = DateTime.ParseExact(uCChangeOrder.TxtDateTo.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            List<Order> orders = Communication.Communication.Instance.SearchOrders(order);
            uCChangeOrder.DgvOrders.DataSource = orders;
        }

        internal void RemoveFilters_1(UCChangeOrder uCChangeOrder)
        {
            List<Order> orders = Communication.Communication.Instance.GetAllOrders();
            uCChangeOrder.DgvOrders.DataSource = null;
            uCChangeOrder.DgvOrders.DataSource = orders;

            uCChangeOrder.DgvOrders.Columns["OrderId"].Visible = false;
            uCChangeOrder.DgvOrders.Columns["DateTime"].HeaderText = "Datum";
            uCChangeOrder.DgvOrders.Columns["Table"].HeaderText = "Sto";
            uCChangeOrder.DgvOrders.Columns["TotalWithoutVAT"].HeaderText = "Cena";
            uCChangeOrder.DgvOrders.Columns["TotalWithVAT"].HeaderText = "Cena(PDV)";
            uCChangeOrder.DgvOrders.Columns["Currency"].HeaderText = "Valuta";
            uCChangeOrder.DgvOrders.Columns["User"].HeaderText = "Radnik";
            uCChangeOrder.DgvOrders.Columns["State"].HeaderText = "Status";
            uCChangeOrder.DgvOrders.Columns["DateFrom"].Visible = false;
            uCChangeOrder.DgvOrders.Columns["DateTo"].Visible = false;

            uCChangeOrder.CbTable.SelectedIndex = -1;
            uCChangeOrder.CbUser.SelectedIndex = -1;
            uCChangeOrder.TxtDateFrom.Text = string.Empty;
            uCChangeOrder.TxtDateTo.Text = string.Empty;
            uCChangeOrder.DgvItems.DataSource = null;
        }

        int orderId;
        Table table;

        internal void ChangeOrder(UCChangeOrder uCChangeOrder)
        {
            if (uCChangeOrder.DgvOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow row = uCChangeOrder.DgvOrders.SelectedRows[0];
                Order order = (Order)row.DataBoundItem;

                if(order.State == "Placeno")
                {
                    MessageBox.Show("Porudžbina je plaćena. Nije moguće izmeniti je!");
                    return;
                }

                orderId = order.OrderId;
                table = order.Table;
                currency = order.Currency;

                OrderItem orderItem = new OrderItem();
                orderItem.OrderId = orderId;

                List<OrderItem> orderItemsList = Communication.Communication.Instance.GetOrderItems(orderItem);
                orderItems = new BindingList<OrderItem>(orderItemsList);
                uCChangeOrder.DgvItems.DataSource = orderItems;

                uCChangeOrder.DgvItems.Columns["OrderId"].Visible = false;
                uCChangeOrder.DgvItems.Columns["Number"].HeaderText = "RB";
                uCChangeOrder.DgvItems.Columns["Product"].HeaderText = "Proizvod";
                uCChangeOrder.DgvItems.Columns["Pieces"].HeaderText = "Komada";
                uCChangeOrder.DgvItems.Columns["PriceWithoutVAT"].HeaderText = "Cena";
                uCChangeOrder.DgvItems.Columns["PriceWithVAT"].HeaderText = "Cena(PDV)";
                uCChangeOrder.DgvItems.Columns["Currency"].HeaderText = "Valuta";
                uCChangeOrder.DgvItems.Columns["TotalWithoutVAT"].HeaderText = "Ukupno";
                uCChangeOrder.DgvItems.Columns["TotalWithVAT"].HeaderText = "Ukupno(PDV)";

                uCChangeOrder.CbTableI.Text = order.Table.ToString();
                uCChangeOrder.CbProduct.Enabled = true;
                uCChangeOrder.CbProduct.DataSource = Communication.Communication.Instance.GetAllProducts();
                uCChangeOrder.CbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
                uCChangeOrder.CbProduct.SelectedIndex = -1;
                uCChangeOrder.TxtPieces.Enabled = true;

                uCChangeOrder.LblUser.Text = order.User.ToString();
                uCChangeOrder.TxtCurrency.Text = order.Currency.ToString();
                uCChangeOrder.TxtTotal.Text = order.TotalWithoutVAT.ToString();
                uCChangeOrder.TxtTotalVAT.Text = order.TotalWithVAT.ToString();
                uCChangeOrder.TxtDate.Text = order.DateTime.ToString();

                total = order.TotalWithoutVAT;
                totalVAT = order.TotalWithVAT;

                uCChangeOrder.BtnAdd.Enabled = true;
                uCChangeOrder.BtnCancel.Enabled = true;
                uCChangeOrder.BtnRemove.Enabled = true;
                uCChangeOrder.BtnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nije odabrana porudžbina za izmenu!");
            }
        }

        internal void AddItem_1(UCChangeOrder uCChangeOrder)
        {
            if (!UserControlHelpers.EmptyFieldValidationCB(uCChangeOrder.CbProduct) | !UserControlHelpers.EmptyFieldValidation(uCChangeOrder.TxtPieces))
            {
                MessageBox.Show("Popunite polja 'Proizvod' i 'Količina' ako želite da dodate stavku!");
                return;
            }
            if (!int.TryParse(uCChangeOrder.TxtPieces.Text, out _))
            {
                MessageBox.Show("Pogrešan unos u polje 'Količina'! Neophodno uneti ceo broj!");
                return;
            }

            Product p = new Product();
            p = (Product)uCChangeOrder.CbProduct.SelectedItem;

            OrderItem orderItem = new OrderItem
            {
                Number = orderItems.Count + 1,
                Product = p,
                Pieces = int.Parse(uCChangeOrder.TxtPieces.Text),
                PriceWithoutVAT = p.PriceWithoutVAT,
                PriceWithVAT = p.PriceWithVAT,
                Currency = p.Currency,
                TotalWithoutVAT = p.PriceWithoutVAT * int.Parse(uCChangeOrder.TxtPieces.Text),
                TotalWithVAT = p.PriceWithVAT * int.Parse(uCChangeOrder.TxtPieces.Text)
            };
            orderItems.Add(orderItem);

            total += orderItem.TotalWithoutVAT;
            totalVAT += orderItem.TotalWithVAT;

            uCChangeOrder.TxtTotal.Text = total.ToString();
            uCChangeOrder.TxtTotalVAT.Text = totalVAT.ToString();

            uCChangeOrder.CbProduct.SelectedIndex = -1;
            uCChangeOrder.TxtPieces.Clear();
        }

        internal void Cancel(UCChangeOrder uCChangeOrder)
        {
            uCChangeOrder.LblUser.Text = string.Empty;
            uCChangeOrder.TxtCurrency.Text = string.Empty;
            uCChangeOrder.TxtTotal.Text = string.Empty;
            uCChangeOrder.TxtTotalVAT.Text = string.Empty;
            uCChangeOrder.TxtDate.Text = string.Empty;
            uCChangeOrder.CbTableI.Text = string.Empty;

            uCChangeOrder.DgvItems.DataSource = null;

            uCChangeOrder.CbProduct.Enabled = false;
            uCChangeOrder.TxtPieces.Enabled = false;

            uCChangeOrder.BtnAdd.Enabled = false;
            uCChangeOrder.BtnCancel.Enabled = false;
            uCChangeOrder.BtnRemove.Enabled = false;
            uCChangeOrder.BtnSave.Enabled = false;
        }

        internal void RemoveItem_1(UCChangeOrder uCChangeOrder)
        {
            if (uCChangeOrder.DgvItems.SelectedRows.Count > 0)
            {
                DataGridViewRow row = uCChangeOrder.DgvItems.SelectedRows[0];
                OrderItem orderItem = (OrderItem)row.DataBoundItem;
                orderItems.Remove(orderItem);

                for (int i = 0; i < orderItems.Count; i++)
                {
                    orderItems[i].Number = i + 1;
                }

                total -= orderItem.TotalWithoutVAT;
                totalVAT -= orderItem.TotalWithVAT;

                uCChangeOrder.TxtTotal.Text = total.ToString();
                uCChangeOrder.TxtTotalVAT.Text = totalVAT.ToString();
            }
        }

        internal void SaveChanges(UCChangeOrder uCChangeOrder)
        {
            DateTime dateTime = DateTime.Now;
            uCChangeOrder.TxtDate.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            Table t = table;
            double totalWithoutVAT = double.Parse(uCChangeOrder.TxtTotal.Text);
            double totalWithVAT = double.Parse(uCChangeOrder.TxtTotalVAT.Text);
            Currency c = currency;
            User user = MainCoordinator.Instance.User;
            List<OrderItem> items = orderItems.ToList();


            try
            {
                Order order = new Order
                {
                    OrderId = orderId,
                    DateTime = dateTime,
                    Table = t,
                    TotalWithoutVAT = totalWithoutVAT,
                    TotalWithVAT = totalWithVAT,
                    Currency = c,
                    User = user,
                    State = "Nije placeno",
                    OrderItems = items
                };

                Communication.Communication.Instance.UpdateOrder(order);
                MessageBox.Show("Izmene su sačuvane!");
                uCChangeOrder.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti izmene!");
            }
        }

        internal void SearchOrder_1(UCInvoice uCInvoice)
        {
            if (uCInvoice.CbTable.SelectedIndex == -1 || uCInvoice.CbUser.SelectedIndex == -1 || string.IsNullOrEmpty(uCInvoice.TxtDateFrom.Text) || string.IsNullOrEmpty(uCInvoice.TxtDateTo.Text))
            {
                MessageBox.Show("Ukoliko želite da pretražite porudžbine, morate popuniti sva polja za pretragu");
                return;
            }

            if (!DateTime.TryParseExact(uCInvoice.TxtDateFrom.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("'Datum od', koji je unet, nije u odgovarajućem formatu! Datume unesite u formatu:dd.MM.yyyy.!");
                return;
            }


            if (!DateTime.TryParseExact(uCInvoice.TxtDateTo.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("'Datum do', koji je unet, nije u odgovarajućem formatu! Datume unesite u formatu:dd.MM.yyyy.!");
                return;
            }


            Order order = new Order();
            order.Table = (Table)uCInvoice.CbTable.SelectedItem;
            order.User = (User)uCInvoice.CbUser.SelectedItem;
            order.DateFrom = DateTime.ParseExact(uCInvoice.TxtDateFrom.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            order.DateTo = DateTime.ParseExact(uCInvoice.TxtDateTo.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            List<Order> orders = Communication.Communication.Instance.SearchOrders(order);
            uCInvoice.DgvOrders.DataSource = orders;
        }

        internal void RemoveFilters_3(UCInvoice uCInvoice)
        {
            List<Order> orders = Communication.Communication.Instance.GetAllOrders();
            uCInvoice.DgvOrders.DataSource = null;
            uCInvoice.DgvOrders.DataSource = orders;

            uCInvoice.DgvOrders.Columns["OrderId"].Visible = false;
            uCInvoice.DgvOrders.Columns["DateTime"].HeaderText = "Datum";
            uCInvoice.DgvOrders.Columns["Table"].HeaderText = "Sto";
            uCInvoice.DgvOrders.Columns["TotalWithoutVAT"].HeaderText = "Cena";
            uCInvoice.DgvOrders.Columns["TotalWithVAT"].HeaderText = "Cena(PDV)";
            uCInvoice.DgvOrders.Columns["Currency"].HeaderText = "Valuta";
            uCInvoice.DgvOrders.Columns["User"].HeaderText = "Radnik";
            uCInvoice.DgvOrders.Columns["State"].HeaderText = "Status";
            uCInvoice.DgvOrders.Columns["DateFrom"].Visible = false;
            uCInvoice.DgvOrders.Columns["DateTo"].Visible = false;

            uCInvoice.CbTable.SelectedIndex = -1;
            uCInvoice.CbUser.SelectedIndex = -1;
            uCInvoice.TxtDateFrom.Text = string.Empty;
            uCInvoice.TxtDateTo.Text = string.Empty;
            uCInvoice.DgvItems.DataSource = null;
        }

        private List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
        Order order;
        internal void CreateInvoice(UCInvoice uCInvoice)
        {
            if (uCInvoice.DgvOrders.SelectedRows.Count > 0)
            {
                invoiceItems = new List<InvoiceItem>();

                DataGridViewRow row = uCInvoice.DgvOrders.SelectedRows[0];
                order = (Order)row.DataBoundItem;

                if (order.State == "Placeno")
                {
                    MessageBox.Show("Za ovu porudžbinu je već kreiran račun!");
                    return;
                }

                currency = order.Currency;

                uCInvoice.TxtTable.Text = order.Table.ToString();
                uCInvoice.TxtTotal.Text = order.TotalWithoutVAT.ToString();
                uCInvoice.TxtTotalVAT.Text = order.TotalWithVAT.ToString();
                uCInvoice.TxtCurrency.Text = order.Currency.ToString();

                uCInvoice.BtnCancel.Enabled = true;
                uCInvoice.BtnPay.Enabled = true;

                DateTime dateTime = DateTime.Now;
                uCInvoice.TxtDate.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");

                User user = MainCoordinator.Instance.User;
                uCInvoice.TxtUser.Text = user.ToString();

                double totalToPay = Math.Ceiling(order.TotalWithVAT);
                uCInvoice.TxtTotalToPay.Text = totalToPay.ToString();

                uCInvoice.CbPayment.Enabled = true;
                uCInvoice.CbPayment.DataSource = Enum.GetValues(typeof(PaymentType));
                uCInvoice.CbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
                uCInvoice.CbPayment.SelectedIndex = -1;

                OrderItem orderItem = new OrderItem();
                orderItem.OrderId = order.OrderId;

                orderItems = new BindingList<OrderItem>(Communication.Communication.Instance.GetOrderItems(orderItem));
                order.OrderItems = orderItems.ToList();

                foreach (OrderItem oi in orderItems)
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

                uCInvoice.DgvItems.DataSource = invoiceItems;

                uCInvoice.DgvItems.Columns["InvoiceId"].Visible = false;
                uCInvoice.DgvItems.Columns["OrderId"].Visible = false;
                uCInvoice.DgvItems.Columns["Number"].HeaderText = "RB";
                uCInvoice.DgvItems.Columns["Product"].HeaderText = "Proizvod";
                uCInvoice.DgvItems.Columns["Pieces"].HeaderText = "Komada";
                uCInvoice.DgvItems.Columns["PriceWithoutVAT"].HeaderText = "Cena";
                uCInvoice.DgvItems.Columns["PriceWithVAT"].HeaderText = "Cena(PDV)";
                uCInvoice.DgvItems.Columns["Currency"].HeaderText = "Valuta";
                uCInvoice.DgvItems.Columns["TotalWithoutVAT"].HeaderText = "Ukupno";
                uCInvoice.DgvItems.Columns["TotalWithVAT"].HeaderText = "Ukupno(PDV)";
            }
            else
            {
                MessageBox.Show("Nije odabrana porudžbina za kreiranje računa!");
            }
        }

        internal void Cancel_1(UCInvoice uCInvoice)
        {
            uCInvoice.TxtTable.Text = string.Empty;
            uCInvoice.TxtTotal.Text = string.Empty;
            uCInvoice.TxtTotalVAT.Text = string.Empty;
            uCInvoice.TxtCurrency.Text = string.Empty;
            uCInvoice.TxtUser.Text = string.Empty;
            uCInvoice.TxtTotalToPay.Text = string.Empty;
            uCInvoice.TxtDate.Text = string.Empty;

            uCInvoice.DgvItems.DataSource = null;

            uCInvoice.CbPayment.SelectedIndex = -1;
            uCInvoice.CbPayment.Enabled = false;

            uCInvoice.BtnCancel.Enabled = false;
            uCInvoice.BtnPay.Enabled = false;
            uCInvoice.BtnSave.Enabled = false;

            uCInvoice.TxtCache.Text = string.Empty;
            uCInvoice.TxtCache.Enabled = false;
            uCInvoice.TxtCard.Text = string.Empty;
            uCInvoice.TxtCard.Enabled = false;
            uCInvoice.CbCardType.SelectedIndex = -1;
            uCInvoice.CbCardType.Enabled = false;
            uCInvoice.TxtCardNumber.Text = string.Empty;
            uCInvoice.TxtCardNumber.Enabled = false;
        }

        internal void PaymentChanged(UCInvoice uCInvoice)
        {
            uCInvoice.BtnSave.Enabled = false;

            uCInvoice.TxtCache.Text = string.Empty;
            uCInvoice.TxtCache.Enabled = false;
            uCInvoice.TxtCard.Text = string.Empty;
            uCInvoice.TxtCard.Enabled = false;
            uCInvoice.CbCardType.SelectedIndex = -1;
            uCInvoice.CbCardType.Enabled = false;
            uCInvoice.TxtCardNumber.Text = string.Empty;
            uCInvoice.TxtCardNumber.Enabled = false;
        }

        internal void Pay(UCInvoice uCInvoice)
        {
            if (!UserControlHelpers.EmptyFieldValidationCB(uCInvoice.CbPayment))
            {
                MessageBox.Show("Odaberite način plaćanja");
                return;
            }

            if (uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Gotovina))
            {
                uCInvoice.TxtCache.Text = uCInvoice.TxtTotalToPay.Text;

                uCInvoice.TxtCard.Text = string.Empty;
                uCInvoice.TxtCardNumber.Text = string.Empty;
                uCInvoice.CbCardType.SelectedIndex = -1;

                uCInvoice.TxtCache.Enabled = false;
                uCInvoice.TxtCard.Enabled = false;
                uCInvoice.CbCardType.Enabled = false;
                uCInvoice.TxtCardNumber.Enabled = false;

            }

            if (uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Kartica))
            {
                uCInvoice.TxtCard.Text = uCInvoice.TxtTotalToPay.Text;

                uCInvoice.TxtCache.Text = string.Empty;
                uCInvoice.TxtCardNumber.Text = string.Empty;
                uCInvoice.CbCardType.SelectedIndex = -1;

                uCInvoice.TxtCache.Enabled = false;
                uCInvoice.TxtCard.Enabled = false;
                uCInvoice.CbCardType.Enabled = true;
                uCInvoice.CbCardType.DataSource = Enum.GetValues(typeof(CardType));
                uCInvoice.CbCardType.SelectedIndex = -1;
                uCInvoice.CbCardType.DropDownStyle = ComboBoxStyle.DropDownList;
                uCInvoice.TxtCardNumber.Enabled = true;
            }

            if (uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Kombinovano))
            {
                uCInvoice.TxtCache.Text = string.Empty;
                uCInvoice.TxtCard.Text = string.Empty;
                uCInvoice.TxtCardNumber.Text = string.Empty;
                uCInvoice.CbCardType.SelectedIndex = -1;

                uCInvoice.TxtCache.Enabled = true;
                uCInvoice.TxtCard.Enabled = true;
                uCInvoice.CbCardType.Enabled = true;
                uCInvoice.CbCardType.DataSource = Enum.GetValues(typeof(CardType));
                uCInvoice.CbCardType.SelectedIndex = -1;
                uCInvoice.CbCardType.DropDownStyle = ComboBoxStyle.DropDownList;
                uCInvoice.TxtCardNumber.Enabled = true;
            }

            uCInvoice.BtnSave.Enabled = true;
        }

        internal void SaveInvoice(UCInvoice uCInvoice)
        {
            if (uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Kartica) || uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Kombinovano))
            {
                if (!UserControlHelpers.EmptyFieldValidationCB(uCInvoice.CbCardType) | !UserControlHelpers.EmptyFieldValidation(uCInvoice.TxtCardNumber))
                {
                    MessageBox.Show("Neophodno je uneti 'tip kartice' i broj kartice'");
                    return;
                }
                if (!UserControlHelpers.CheckLongIntType(uCInvoice.TxtCardNumber))
                {
                    MessageBox.Show("Broj kartice nije ispravano unet.");
                    return;
                }
            }

            double totalToPay = int.Parse(uCInvoice.TxtTotalToPay.Text);
            double card;
            double cache;

            if (uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Kombinovano))
            {
                if (string.IsNullOrEmpty(uCInvoice.TxtCache.Text) | string.IsNullOrEmpty(uCInvoice.TxtCard.Text))
                {
                    MessageBox.Show("Neophodno je popuniti polja: 'Iznos koji se plaća gotovinom', 'Iznos koji se plaća karticom'");
                    return;
                }

                if (!UserControlHelpers.CheckDoubleType(uCInvoice.TxtCache) | !UserControlHelpers.CheckDoubleType(uCInvoice.TxtCard))
                {
                    MessageBox.Show("Neispravan unos iznosa za plaćanje. Unete vrednosti moraju biti brojevi.");
                    return;
                }

                cache = double.Parse(uCInvoice.TxtCache.Text);
                card = double.Parse(uCInvoice.TxtCard.Text);

                if ((card + cache) != totalToPay)
                {
                    MessageBox.Show($"Neispravan unos iznosa za plaćanje. Ukupan iznos za plaćanje iznosi {totalToPay}.");
                    return;
                }

            }

            Cache cache1 = null;
            Card card1 = null;

            DateTime dateTime = DateTime.Now;
            uCInvoice.TxtDate.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss");

            Table table = new Table
            {
                TableNumber = int.Parse(uCInvoice.TxtTable.Text)
            };

            try
            {
                if (uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Gotovina))
                {
                    cache = totalToPay;

                    cache1 = new Cache
                    {
                        OrderId = order.OrderId,
                        TotalInCache = cache
                    };
                }

                if (uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Kartica))
                {
                    card = totalToPay;

                    card1 = new Card
                    {
                        OrderId = order.OrderId,
                        CardType = (CardType)uCInvoice.CbCardType.SelectedItem,
                        CardNumber = long.Parse(uCInvoice.TxtCardNumber.Text),
                        TotalByCard = card
                    };
                }

                if (uCInvoice.CbPayment.SelectedItem.Equals(PaymentType.Kombinovano))
                {
                    card = double.Parse(uCInvoice.TxtCard.Text);
                    cache = double.Parse(uCInvoice.TxtCache.Text);

                    card1 = new Card
                    {
                        OrderId = order.OrderId,
                        CardType = (CardType)uCInvoice.CbCardType.SelectedItem,
                        CardNumber = long.Parse(uCInvoice.TxtCardNumber.Text),
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
                    PaymentType = (PaymentType)uCInvoice.CbPayment.SelectedItem,
                    Cache = cache1,
                    Card = card1
                };

                Invoice invoice = new Invoice
                {
                    DateTime = dateTime,
                    User = MainCoordinator.Instance.User,
                    Table = table,
                    Currency = currency,
                    TotalWithoutVAT = double.Parse(uCInvoice.TxtTotal.Text),
                    TotalWithVAT = double.Parse(uCInvoice.TxtTotalVAT.Text),
                    TotalToPay = double.Parse(uCInvoice.TxtTotalToPay.Text),
                    InvoiceItems = invoiceItems,
                    OrderId = order.OrderId,
                    Payment = payment
                };

                Communication.Communication.Instance.SaveInvoice(invoice);

                order.State = "Placeno";
                Communication.Communication.Instance.UpdateOrder(order);

                MessageBox.Show("Račun je sačuvan!");
                uCInvoice.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti račun!");
            }
        }

    }
}
