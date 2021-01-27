using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Cache : IEntity
    {
        public int PaymentID { get; set; }
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public double TotalInCache { get; set; }

        public string TableName => "Cache";

        public string InsertValues => $"'{PaymentID}', '{InvoiceId}', '{OrderId}', '{TotalInCache}'";

        public string IdName => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string DeleteCondition => throw new NotImplementedException();

        public string SearchCondition => throw new NotImplementedException();

        public string SelectValues => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string UpdateCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
