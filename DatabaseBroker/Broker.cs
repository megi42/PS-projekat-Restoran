using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True;");
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();
        }

        public List<Table> GetAllTables()
        {
            List<Table> tables = new List<Table>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Tablee";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Table t = new Table()
                {
                    TableNumber = (int)reader[0]
                };
                tables.Add(t);
            }
            reader.Close();
            return tables;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Userr";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User u = new User()
                {
                    Id = (int)reader[0],
                    Username = (string)reader[1],
                    Password = (string)reader[2],
                    FirstName = (string)reader[3],
                    LastName = (string)reader[4],
                };
                users.Add(u);
            }
            reader.Close();
            return users;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> res = new List<Product>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from product p join Userr u on (p.UserId=u.Id)";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    ProductId = (int)reader[0],
                    Name = (string)reader[1],
                    PriceWithoutVAT = (double)reader[2],
                    VAT = (double)reader[3],
                    PriceWithVAT = (double)reader[4],
                    Currency = (Currency)reader[5],
                    Type = (ProductType)reader[6],
                    User = new User
                    {
                        Id = (int)reader[7],
                        Username = (string)reader[9],
                        Password = (string)reader[10],
                        FirstName = (string)reader[11],
                        LastName = (string)reader[12],
                    }
                    
                };
                res.Add(p);
            }
            reader.Close();
            return res;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> res = new List<Order>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Orderr o join Userr u on (o.UserID=u.Id)";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Order o = new Order()
                {
                    OrderId = (int)reader[0],
                    DateTime = (DateTime)reader[1],
                    Table = new Table
                    {
                        TableNumber = (int)reader[2]
                    },
                    TotalWithoutVAT = (double)reader[3],
                    TotalWithVAT = (double)reader[4],
                    Currency = (Currency)reader[5],
                    User = new User
                    {
                        Id = (int)reader[6],
                        Username = (string)reader[8],
                        Password = (string)reader[9],
                        FirstName = (string)reader[10],
                        LastName = (string)reader[11],
                    }
                };
                res.Add(o);
            }
            reader.Close();
            return res;
        }

        public List<Invoice> GetAllInvoices()
        {
            List<Invoice> res = new List<Invoice>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from invoice i join Userr u on (i.UserID=u.Id)";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Invoice i = new Invoice()
                {
                    InvoiceId = (int)reader[0],
                    OrderId = (int)reader[1],
                    DateTime = (DateTime)reader[2],
                    Table = new Table
                    {
                        TableNumber = (int)reader[3]
                    },
                    TotalWithoutVAT = (double)reader[4],
                    TotalWithVAT = (double)reader[5],
                    TotalToPay = (double)reader[6],
                    Currency = (Currency)reader[7],
                    User = new User
                    {
                        Id = (int)reader[8],
                        Username = (string)reader[10],
                        Password = (string)reader[11],
                        FirstName = (string)reader[12],
                        LastName = (string)reader[13],
                    }
                };
                res.Add(i);
            }
            reader.Close();
            return res;
        }

        public void SaveProduct(Product p)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into product values (@Name, @PriceWithoutVAT, @VAT, @PriceWithVAT, @Currency, @Type, @User)";

            command.Parameters.AddWithValue("@Name", p.Name);
            command.Parameters.AddWithValue("@PriceWithoutVAT", p.PriceWithoutVAT);
            command.Parameters.AddWithValue("@VAT", p.VAT);
            command.Parameters.AddWithValue("@PriceWithVAT", p.PriceWithVAT);
            command.Parameters.AddWithValue("@Currency", p.Currency);
            command.Parameters.AddWithValue("@Type", p.Type);
            command.Parameters.AddWithValue("@User", p.User.Id);

            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greška u bazi podataka!");
            }
        }

        public void DeleteProduct(Product product)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"delete from product where Id = {product.ProductId}";

            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greška u bazi podataka!");
            }
        }

        public int SaveOrder(Order order)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;

            command.CommandText = $"insert into orderr output inserted.Id values (@DateTime, @TableNumber, @TotalWithoutVAT, @TotalWithVAT, @Currency, @UserID)";
            command.Parameters.AddWithValue("@DateTime", order.DateTime.ToString("yyyyMMdd HH:mm"));
            command.Parameters.AddWithValue("@TableNumber", order.Table.TableNumber);
            command.Parameters.AddWithValue("@TotalWithoutVAT", order.TotalWithoutVAT);
            command.Parameters.AddWithValue("@TotalWithVAT", order.TotalWithVAT);
            command.Parameters.AddWithValue("@Currency", order.Currency);
            command.Parameters.AddWithValue("@UserID", order.User.Id);

            return (int)command.ExecuteScalar();
        }

        public void SaveOrderItem(OrderItem oi)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "insert into orderitem values(@OrderId, @Number, @ProductID, @Pieces, @PriceWithoutVAT, @PriceWithVAT, @Currency, @TotalWithoutVAT, @TotalWithVAT)";
            
            command.Parameters.AddWithValue("@OrderId", oi.OrderId);
            command.Parameters.AddWithValue("@Number", oi.Number);
            command.Parameters.AddWithValue("@ProductID", oi.Product.ProductId);
            command.Parameters.AddWithValue("@Pieces", oi.Pieces);
            command.Parameters.AddWithValue("@PriceWithoutVAT", oi.PriceWithoutVAT);
            command.Parameters.AddWithValue("@PriceWithVAT", oi.PriceWithVAT);
            command.Parameters.AddWithValue("@Currency", oi.Currency);
            command.Parameters.AddWithValue("@TotalWithoutVAT", oi.TotalWithoutVAT);
            command.Parameters.AddWithValue("@TotalWithVAT", oi.TotalWithVAT);

            command.ExecuteNonQuery();
        }

        public List<OrderItem> GetOrderItems(Order order)
        {
            List<OrderItem> res = new List<OrderItem>();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from OrderItem oi join Product p on (oi.ProductID=p.Id) where oi.OrderId= {order.OrderId}";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OrderItem oi = new OrderItem()
                {
                    OrderId = (int)reader[0],
                    Number = (int)reader[1],
                    Product = new Product
                    {
                        ProductId = (int)reader[2],
                        Name = (string)reader[10],
                        PriceWithoutVAT = (double)reader[11],
                        VAT = (double)reader[12],
                        PriceWithVAT= (double)reader[13],
                        Currency = (Currency)reader[14],
                        Type = (ProductType)reader[15],
                        User = new User
                        {
                            Id = (int)reader[16]
                        }
                    },
                    Pieces = (int)reader[3],
                    PriceWithoutVAT = (double)reader[4],
                    PriceWithVAT = (double)reader[5],
                    Currency = (Currency)reader[6],
                    TotalWithoutVAT = (double)reader[7],
                    TotalWithVAT = (double)reader[8],
                };
                res.Add(oi);
            }
            reader.Close();
            return res;
        }

        public void DeleteOrderItems(int orderId)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = $"delete from OrderItem where OrderId = {orderId}";
            command.ExecuteNonQuery();
        }

        public void SaveChangesToOrder(Order order, int orderId)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;

            command.CommandText = $"update Orderr set DateTime=@DateTime, TableNumber=@TableNumber, TotalWithoutVAT=@TotalWithoutVAT, TotalWithVAT=@TotalWithVAT, Currency=@Currency, UserID=@UserID where Id={orderId}";
            command.Parameters.AddWithValue("@DateTime", order.DateTime.ToString("yyyyMMdd HH:mm"));
            command.Parameters.AddWithValue("@TableNumber", order.Table.TableNumber);
            command.Parameters.AddWithValue("@TotalWithoutVAT", order.TotalWithoutVAT);
            command.Parameters.AddWithValue("@TotalWithVAT", order.TotalWithVAT);
            command.Parameters.AddWithValue("@Currency", order.Currency);
            command.Parameters.AddWithValue("@UserID", order.User.Id);

            command.ExecuteScalar();
        }

        public int SaveInvoice(Invoice invoice)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;

            command.CommandText = $"insert into invoice output inserted.Id values (@OrderId, @DateTime, @TableNumber, @TotalWithoutVAT, @TotalWithVAT, @TotalToPay, @Currency, @UserID)";
            
            command.Parameters.AddWithValue("@OrderId", invoice.OrderId);
            command.Parameters.AddWithValue("@DateTime", invoice.DateTime.ToString("yyyyMMdd HH:mm"));
            command.Parameters.AddWithValue("@TableNumber", invoice.Table.TableNumber);
            command.Parameters.AddWithValue("@TotalWithoutVAT", invoice.TotalWithoutVAT);
            command.Parameters.AddWithValue("@TotalWithVAT", invoice.TotalWithVAT);
            command.Parameters.AddWithValue("@TotalToPay", invoice.TotalToPay);
            command.Parameters.AddWithValue("@Currency", invoice.Currency);
            command.Parameters.AddWithValue("@UserID", invoice.User.Id);

            return (int)command.ExecuteScalar();
        }

        public void SaveInvoiceItem(InvoiceItem ii)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "insert into invoiceitem values(@InvoiceId, @OrderId, @Number, @ProductID, @PriceWithoutVAT, @PriceWithVAT, @Pieces, @TotalWithoutVAT, @TotalWithVAT, @Currency)";

            command.Parameters.AddWithValue("@InvoiceId", ii.InvoiceId);
            command.Parameters.AddWithValue("@OrderId", ii.OrderId);
            command.Parameters.AddWithValue("@Number", ii.Number);
            command.Parameters.AddWithValue("@ProductID", ii.Product.ProductId);
            command.Parameters.AddWithValue("@PriceWithoutVAT", ii.PriceWithoutVAT);
            command.Parameters.AddWithValue("@PriceWithVAT", ii.PriceWithVAT);
            command.Parameters.AddWithValue("@Pieces", ii.Pieces);
            command.Parameters.AddWithValue("@TotalWithoutVAT", ii.TotalWithoutVAT);
            command.Parameters.AddWithValue("@TotalWithVAT", ii.TotalWithVAT);
            command.Parameters.AddWithValue("@Currency", ii.Currency);

            command.ExecuteNonQuery();
        }

        public int SavePayment(Payment payment)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "insert into payment output inserted.Id values(@InvoiceId, @OrderId, @Total, @Currency, @PaymentType)";

            command.Parameters.AddWithValue("@InvoiceId", payment.InvoiceId);
            command.Parameters.AddWithValue("@OrderId", payment.OrderId);
            command.Parameters.AddWithValue("@Total", payment.Total);
            command.Parameters.AddWithValue("@Currency", payment.Currency);
            command.Parameters.AddWithValue("@PaymentType", payment.PaymentType);

            return (int)command.ExecuteScalar();
        }

        public void SaveCache(Cache cache)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "insert into cache values(@PaymentId, @InvoiceId, @OrderId, @TotalInCache)";

            command.Parameters.AddWithValue("@PaymentId", cache.PaymentID);
            command.Parameters.AddWithValue("@InvoiceId", cache.InvoiceId);
            command.Parameters.AddWithValue("@OrderId", cache.OrderId);
            command.Parameters.AddWithValue("@TotalInCache", cache.TotalInCache);

            command.ExecuteNonQuery();
        }

        public void SaveCard(Card card)
        {
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            command.CommandText = "insert into card values(@PaymentId, @InvoiceId, @OrderId, @CardType, @TotalByCard, @CardNumber)";

            command.Parameters.AddWithValue("@PaymentId", card.PaymentID);
            command.Parameters.AddWithValue("@InvoiceId", card.InvoiceId);
            command.Parameters.AddWithValue("@OrderId", card.OrderId);
            command.Parameters.AddWithValue("@CardType", card.CardType);
            command.Parameters.AddWithValue("@TotalByCard", card.TotalByCard);
            command.Parameters.AddWithValue("@CardNumber", card.CardNumber);

            command.ExecuteNonQuery();
        }

    }
}
