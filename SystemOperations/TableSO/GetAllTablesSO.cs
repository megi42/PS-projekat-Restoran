using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TableSO
{
    public class GetAllTablesSO : SystemOperationBase
    {
        public List<Table> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Table()).Cast<Table>().ToList();
        }
    }
}
