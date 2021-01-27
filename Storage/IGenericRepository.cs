using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IGenericRepository
    {
        void Save(IEntity entity);
        List<IEntity> GetAll(IEntity e);
        void Delete(IEntity entity);
        List<IEntity> Search(IEntity entity);
        int GetNewId(IEntity e);


        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Update(IEntity entity);
        void Rollback();
    }
}
