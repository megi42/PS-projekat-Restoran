using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.InvoiceSO
{
    public class GetAllInvoicesSO : SystemOperationBase
    {
        public List<Invoice> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Invoice()).Cast<Invoice>().ToList();
        }
    }
}
