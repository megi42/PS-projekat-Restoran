using Domain;
using Storage;
using Storage.Implementation.Database;
using System;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IGenericRepository repository;

        public SystemOperationBase()
        {
            repository = new GenericRepository();
        }

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity);
    }
}
