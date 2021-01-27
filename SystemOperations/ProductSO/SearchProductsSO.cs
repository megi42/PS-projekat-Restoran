using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProductSO
{
    public class SearchProductsSO : SystemOperationBase
    {
        public List<Product> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.Search((Product)entity).Cast<Product>().ToList();
        }
    }
}
