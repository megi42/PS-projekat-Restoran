using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.SqlServer
{
    public class StorageOrderSqlServer : IStorageOrder
    {
        private Broker broker = new Broker();
        public List<Order> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllOrders();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<OrderItem> GetOrderItems(Order order)
        {
            try
            {
                broker.OpenConnection();
                return broker.GetOrderItems(order);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Save(Order order)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                order.OrderId = broker.SaveOrder(order);
                foreach (OrderItem oi in order.OrderItems)
                {
                    oi.OrderId = order.OrderId;
                    broker.SaveOrderItem(oi);
                }
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void SaveChanges(Order order, int orderId)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                broker.SaveChangesToOrder(order, orderId);
                broker.DeleteOrderItems(orderId);
                foreach (OrderItem oi in order.OrderItems)
                {
                    oi.OrderId = orderId;
                    broker.SaveOrderItem(oi);
                }
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
