using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorageOrder
    {
        List<Order> GetAll();
        void Save(Order order);
        List<OrderItem> GetOrderItems(Order order);
        void SaveChanges(Order order, int orderId);
    }
}
