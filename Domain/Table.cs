using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Table : IEntity
    {
        public int TableNumber { get; set; }

        public string TableName => "Tablee";

        public string InsertValues => throw new NotImplementedException();

        public string IdName => throw new NotImplementedException();

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "t";

        public string DeleteCondition => throw new NotImplementedException();

        public string SearchCondition => throw new NotImplementedException();

        public string SelectValues => "t.Number";

        public string UpdateValues => throw new NotImplementedException();

        public string UpdateCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Table t = new Table
                {
                    TableNumber = (int)reader[0]
                };
                result.Add(t);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{TableNumber}";
        }
    }
}
