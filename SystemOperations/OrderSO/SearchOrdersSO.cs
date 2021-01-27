using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.OrderSO
{
    public class SearchOrdersSO : SystemOperationBase
    {
        public List<Order> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.Search((Order)entity).Cast<Order>().ToList();
        }
    }
}
