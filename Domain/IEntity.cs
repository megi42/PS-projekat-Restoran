using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string InsertValues { get; }
        string IdName { get; }
        string JoinCondition { get; }
        string JoinTable { get; }
        string TableAlias { get; }
        string DeleteCondition { get; }
        string SearchCondition { get; }
        string SelectValues { get; } 
        string UpdateValues { get; }
        string UpdateCondition { get; }

        List<IEntity> GetEntities(SqlDataReader reader);
    }
}
