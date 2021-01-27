using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.OrderSO
{
    public class GetOrderItemsSO : SystemOperationBase
    {
        public List<OrderItem> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.Search((OrderItem)entity).Cast<OrderItem>().ToList();
        }
    }
}
