using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.SqlServer
{
    public class StorageTableSqlServer : IStorageTable
    {
        private Broker broker = new Broker();
        public List<Table> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllTables();
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
