using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double PriceWithoutVAT { get; set; }
        public double VAT { get; set; }
        public double PriceWithVAT { get; set; }
        public Currency Currency { get; set; }
        public ProductType Type { get; set; }
        public User User { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Product p = new Product
                {
                    ProductId = (int)reader[0],
                    Name = (string)reader[1],
                    PriceWithoutVAT = (double)reader[2],
                    VAT = (double)reader[3],
                    PriceWithVAT = (double)reader[4],
                    Currency = (Currency)reader[5],
                    Type = (ProductType)reader[6],
                    User = new User
                    {
                        Id = (int)reader[7],
                        Username = (string)reader[8],
                        Password = (string)reader[9],
                        FirstName = (string)reader[10],
                        LastName = (string)reader[11]
                    }
                };
                result.Add(p);
            }
            return result;
        }


        [Browsable(false)]
        public string TableName => "Product";
        [Browsable(false)]
        public string InsertValues => $"'{Name}', '{PriceWithoutVAT}', '{VAT}', '{PriceWithVAT}', '{(int)Currency}', '{(int)Type}', '{User.Id}'";
        [Browsable(false)]
        public string IdName => "ProductId";
        [Browsable(false)]
        public string JoinCondition => "on (p.UserId=u.Id)"; 
        [Browsable(false)]
        public string JoinTable => "join userr u"; 
        [Browsable(false)]
        public string TableAlias => "p";
        [Browsable(false)]
        public string DeleteCondition => $"Id={ProductId}";
        [Browsable(false)]
        public string SearchCondition => $"p.Name like '%{Name}%'";
        [Browsable(false)]
        public string SelectValues => "p.Id, p.Name, p.PriceWithoutVAT, p.VAT, p.PriceWithVAT, p.Currency, p.ProductType, u.Id, u.Username, u.Password, u.FirstName, u.LastName";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string UpdateCondition => throw new NotImplementedException();
    }
}
