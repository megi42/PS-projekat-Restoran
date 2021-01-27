using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Invoice : IEntity
    {
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public Table Table { get; set; }
        public double TotalWithoutVAT { get; set; }
        public double TotalWithVAT { get; set; }
        public double TotalToPay { get; set; }
        public Currency Currency { get; set; }
        public User User { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
        public Payment Payment { get; set; }

        public string TableName => "Invoice";

        public string InsertValues => $"'{OrderId}', '{DateTime}', '{Table.TableNumber}', '{TotalWithoutVAT}', '{TotalWithVAT}', '{TotalToPay}', '{(int)Currency}', '{User.Id}'";

        public string IdName => "Id";

        public string JoinCondition => "on (i.UserId=u.Id)";

        public string JoinTable => "join userr u";

        public string TableAlias => "i";

        public string DeleteCondition => throw new NotImplementedException();

        public string SearchCondition => throw new NotImplementedException();

        public string SelectValues => "i.Id, i.OrderId, i.DateTime, i.TableNumber, i.TotalWithoutVAT, i.TotalWithVAT, i.TotalToPay, i.Currency, u.Id, u.Username, u.Password, u.FirstName, u.LastName";

        public string UpdateValues => throw new NotImplementedException();

        public string UpdateCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Invoice i = new Invoice
                {

                    InvoiceId = (int)reader[0],
                    OrderId = (int)reader[1],
                    DateTime = (DateTime)reader[2],
                    Table = new Table
                    {
                        TableNumber = (int)reader[3]
                    },
                    TotalWithoutVAT = (double)reader[4],
                    TotalWithVAT = (double)reader[5],
                    TotalToPay = (double)reader[6],
                    Currency = (Currency)reader[7],
                    User = new User
                    {
                        Id = (int)reader[8],
                        Username = (string)reader[9],
                        Password = (string)reader[10],
                        FirstName = (string)reader[11],
                        LastName = (string)reader[12],
                    }
                };
                result.Add(i);
            }
            return result;
        }
    }
}
