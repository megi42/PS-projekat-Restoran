using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.OrderSO
{
    public class ChangeOrderSO :SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Update(entity);

            Order order = (Order)entity;

            OrderItem item = new OrderItem();
            item.OrderId = order.OrderId;
            repository.Delete(item);

            foreach (OrderItem oi in order.OrderItems)
            {
                oi.OrderId = order.OrderId;
                IEntity ie = (IEntity)oi;
                repository.Save(ie);
            }

        }
    }
}
