using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        [Browsable(false)]
        public string TableName => "Userr";
        [Browsable(false)]
        public string InsertValues => throw new NotImplementedException();
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "u";
        [Browsable(false)]
        public string DeleteCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string SearchCondition => $"username='{Username}' and password='{Password}'";
        [Browsable(false)]
        public string SelectValues => "Id, Username, Password, FirstName, LastName";

        public string UpdateValues => throw new NotImplementedException();

        public string UpdateCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                User u = new User
                {
                    Id = (int)reader[0],
                    Username = (string)reader[1],
                    Password = (string)reader[2],
                    FirstName = (string)reader[3],
                    LastName = (string)reader[4],
                };
                result.Add(u);
            }
            return result;
        }

    }
}
