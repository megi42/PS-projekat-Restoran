using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.OrderSO
{
    public class AddNewOrderSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Save(entity);

            Order order = (Order)entity;
            order.OrderId = repository.GetNewId(entity);

            foreach (OrderItem oi in order.OrderItems)
            {
                oi.OrderId = order.OrderId;
                IEntity ie = (IEntity)oi;
                repository.Save(ie);
            }

            //ovo ne moze jer cuva samo u tabeli order, a
            //treba sacuvati i sve stavke!!! :)
        }
    }
}
