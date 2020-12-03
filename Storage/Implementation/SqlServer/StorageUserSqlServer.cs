using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.SqlServer
{
    public class StorageUserSqlServer : IStorageUser
    {
        private Broker broker = new Broker();
        public List<User> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllUsers();
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
