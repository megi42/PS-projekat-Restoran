using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UserSO
{
    public class LoginSO : SystemOperationBase
    {
        public User Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {

            Result = repository.Search((User)entity).Cast<User>().ToList()[0];

            if(Result == null)
            {
                throw new Exception("Uneti su pogrešni podaci!");
            }

        }
    }
}
