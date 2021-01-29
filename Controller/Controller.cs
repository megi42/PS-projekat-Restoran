using Domain;
using Storage;
using System.Collections.Generic;
using Storage.Implementation.Database;
using SystemOperations.ProductSO;
using SystemOperations.UserSO;
using SystemOperations.InvoiceSO;
using SystemOperations.OrderSO;
using SystemOperations.TableSO;

namespace ControllerBL
{
    public class Controller
    {
        private IGenericRepository repository;

        public User User { get; set; }

        #region singleton
        private static Controller instance;

        private static object _lock = new object();
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        private Controller()
        {
            repository = new GenericRepository();
        }
        #endregion

        public User Login(User user)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(user);
            return so.Result;
        }

        public List<Product> GetAllProducts()
        {
            GetAllProductsSO so = new GetAllProductsSO();
            so.ExecuteTemplate(new Product());
            return so.Result;
        }

        public void SaveProduct(Product p)
        {
            AddNewProductSO so = new AddNewProductSO();
            so.ExecuteTemplate(p);
        }

        public void DeleteProduct(Product p)
        {
            DeleteProductSO so = new DeleteProductSO();
            so.ExecuteTemplate(p);
        }

        public List<Product> SearchProducts(Product p)
        {
            SearchProductsSO so = new SearchProductsSO();
            so.ExecuteTemplate(p);
            return so.Result;
        }

        public void SaveOrder(Order o)
        {
            AddNewOrderSO so = new AddNewOrderSO();
            so.ExecuteTemplate(o);
        }

        public List<Table> GetAllTables()
        {
            GetAllTablesSO so = new GetAllTablesSO();
            so.ExecuteTemplate(new Table());
            return so.Result;
        }

        public List<Order> GetAllOrders()
        {
            GetAllOrdersSO so = new GetAllOrdersSO();
            so.ExecuteTemplate(new Order());
            return so.Result;
        }

        public List<User> GetALLUsers()
        {
            GetAllUsersSO so = new GetAllUsersSO();
            so.ExecuteTemplate(new User());
            return so.Result;
        }

        public List<Order> SearchOrders(Order o)
        {
            SearchOrdersSO so = new SearchOrdersSO();
            so.ExecuteTemplate(o);
            return so.Result;
        }

        public List<Invoice> GetAllInvoices()
        {
            GetAllInvoicesSO so = new GetAllInvoicesSO();
            so.ExecuteTemplate(new Invoice());
            return so.Result;
        }

        public List<OrderItem> GetOrderItems(OrderItem oi)
        {
            GetOrderItemsSO so = new GetOrderItemsSO();
            so.ExecuteTemplate(oi);
            return so.Result;
        }

        public void UpdateOrder(Order o)
        {
            ChangeOrderSO so = new ChangeOrderSO();
            so.ExecuteTemplate(o);
        }

        public void SaveInvoice(Invoice i)
        {
            AddInvoiceSO so = new AddInvoiceSO();
            so.ExecuteTemplate(i);
        }

    }
}
