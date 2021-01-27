using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.Database
{
    public class GenericRepository : IGenericRepository
    {
        private Broker broker = new Broker();
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Delete(IEntity entity)
        {
            broker.Delete(entity);
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            return broker.GetAll(entity);
        }

        public int GetNewId(IEntity e)
        {
            return broker.GetMaxId(e);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Save(IEntity entity)
        {
            broker.Save(entity);
        }

        public List<IEntity> Search(IEntity entity)
        {
            return broker.Search(entity);
        }

        public void Update(IEntity entity)
        {
            broker.Update(entity);
        }
    }
}
