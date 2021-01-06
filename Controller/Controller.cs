using Domain;
using System;
using Storage;
using Storage.Implementation.SqlServer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerBL
{
    public class Controller
    {
        private IStorageUser storageUser;
        private IStorageProduct storageProduct;
        private IStorageTable storageTable;
        private IStorageOrder storageOrder;
        private IStorageInvoice storageInvoice;
        public User LoggedInUser { get; set; }

        private static Controller controller;
        public static Controller Instance
        {
            get
            {
                if (controller == null)
                {
                    controller = new Controller();
                }
                return controller;
            }
        }

        private Controller()
        {
            storageProduct = new StorageProductSqlServer();
            storageUser = new StorageUserSqlServer();
            storageTable = new StorageTableSqlServer();
            storageOrder = new StorageOrderSqlServer();
            storageInvoice = new StorageInvoiceSqlServer();
        }
        public User Login(User user)
        {
            foreach (User u in storageUser.GetAll())
            {
                if (u.Username == user.Username && u.Password == user.Password)
                {
                    LoggedInUser = u;
                    return u;
                }
            }
            throw new Exception("Sistem ne može da prepozna korisnika!");
        }

        public List<Order> GetAllOrders()
        {
            return storageOrder.GetAll();
        }

        public List<Invoice> GetAllInvoices()
        {
            return storageInvoice.GetAll();
        }

        public List<Table> GetAllTables()
        {
            return storageTable.GetAll();
        }

        public List<Product> GetAllProducts()
        {
            return storageProduct.GetAll();
        }

        public void SaveProduct(Product p)
        {
            p.User = LoggedInUser;
            storageProduct.Save(p);
        }

        public List<User> GetALLUsers()
        {
            return storageUser.GetAll();
        }

        public void SaveOrder(Order order)
        {
            storageOrder.Save(order);
        }

        public void DeleteProduct(Product product)
        {
            storageProduct.Delete(product);
        }

        public List<OrderItem> GetOrderItems(Order order)
        {
            return storageOrder.GetOrderItems(order);
        }

        public void SaveChangesToOrder(Order order, int orderId)
        {
            storageOrder.SaveChanges(order, orderId);
        }

        public void SaveInvoice(Invoice invoice)
        {
            storageInvoice.Save(invoice);
        }
    }
}
