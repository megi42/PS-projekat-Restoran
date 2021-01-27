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
    public class OrderItem : IEntity
    {
        public int OrderId { get; set; }
        public int Number { get; set; }
        public Product Product { get; set; }
        public double PriceWithoutVAT { get; set; }
        public double PriceWithVAT { get; set; }
        public int Pieces { get; set; }
        public double TotalWithoutVAT { get; set; }
        public double TotalWithVAT { get; set; }
        public Currency Currency { get; set; }

        [Browsable(false)]
        public string TableName => "OrderItem";
        [Browsable(false)]
        public string InsertValues => $"'{OrderId}', '{Number}', '{Product.ProductId}', '{Pieces}', '{PriceWithoutVAT}', '{PriceWithVAT}', '{(int)Currency}', '{TotalWithoutVAT}', '{TotalWithVAT}'";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => "on (oi.ProductID=p.Id)";
        [Browsable(false)]
        public string JoinTable => "join Product p";
        [Browsable(false)]
        public string TableAlias => "oi";
        [Browsable(false)]
        public string DeleteCondition => $"OrderId={OrderId}";
        [Browsable(false)]
        public string SearchCondition => $"OrderId={OrderId}";
        [Browsable(false)]
        public string SelectValues => "oi.OrderId, oi.Number, p.Id, p.Name, p.PriceWithoutVAT, p.VAT, p.PriceWithVAT, p.Currency, p.ProductType, p.UserId, oi.Pieces, oi.PriceWithoutVAT, oi.PriceWithVAT, oi.Currency, oi.TotalWithoutVAT, oi.TotalWithVAT";
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string UpdateCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                OrderItem oi = new OrderItem
                {

                    OrderId = (int)reader[0],
                    Number = (int)reader[1],
                    Product = new Product
                    {
                        ProductId = (int)reader[2],
                        Name = (string)reader[3],
                        PriceWithoutVAT = (double)reader[4],
                        VAT = (double)reader[5],
                        PriceWithVAT = (double)reader[6],
                        Currency = (Currency)reader[7],
                        Type = (ProductType)reader[8],
                        User = new User
                        {
                            Id = (int)reader[9]
                        }
                    },
                    Pieces = (int)reader[10],
                    PriceWithoutVAT = (double)reader[11],
                    PriceWithVAT = (double)reader[12],
                    Currency = (Currency)reader[13],
                    TotalWithoutVAT = (double)reader[14],
                    TotalWithVAT = (double)reader[15],
                };
                result.Add(oi);
            }
            return result;
        }
    }
}
