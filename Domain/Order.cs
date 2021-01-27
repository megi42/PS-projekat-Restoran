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
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public Table Table { get; set; }
        public double TotalWithoutVAT { get; set; }
        public double TotalWithVAT { get; set; }
        public Currency Currency { get; set; }
        public User User { get; set; }
        public string State { get; set; }
        public List<OrderItem> OrderItems { get; set; }


        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }


        [Browsable(false)]
        public string TableName => "Orderr";
        [Browsable(false)]
        public string InsertValues => $"'{DateTime}', '{Table.TableNumber}', '{TotalWithoutVAT}', '{TotalWithVAT}', '{(int)Currency}', '{User.Id}', '{State}'";
        [Browsable(false)]
        public string IdName => "Id"; 
        [Browsable(false)]
        public string JoinCondition => "on (o.UserID=u.Id)";
        [Browsable(false)]
        public string JoinTable => "join userr u";
        [Browsable(false)]
        public string TableAlias => "o";
        [Browsable(false)]
        public string DeleteCondition => $"Id={OrderId}";
        [Browsable(false)]
        public string SearchCondition => $"o.TableNumber={Table.TableNumber} and o.UserID={User.Id} and (o.DateTime >='{DateFrom}' and o.DateTime<='{DateTo}')";
        [Browsable(false)]
        public string SelectValues => "o.Id, o.DateTime, o.TableNumber, o.TotalWithoutVAT, o.TotalWithVAT, o.Currency, o.State, u.Id, u.Username, u.Password, u.FirstName, u.LastName";
        [Browsable(false)]
        public string UpdateValues => $"DateTime='{DateTime}', TableNumber={Table.TableNumber}, TotalWithoutVAT={TotalWithoutVAT}, TotalWithVAT={TotalWithVAT}, Currency={(int)Currency}, UserID={User.Id}, State='{State}'";
        [Browsable(false)]
        public string UpdateCondition => $"Id={OrderId}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Order o = new Order
                {

                    OrderId = (int)reader[0],
                    DateTime = (DateTime)reader[1],
                    Table = new Table
                    {
                        TableNumber = (int)reader[2]
                    },
                    TotalWithoutVAT = (double)reader[3],
                    TotalWithVAT = (double)reader[4],
                    Currency = (Currency)reader[5],
                    State = (string)reader[6],
                    User = new User
                    {
                        Id = (int)reader[7],
                        Username = (string)reader[8],
                        Password = (string)reader[9],
                        FirstName = (string)reader[10],
                        LastName = (string)reader[11],
                    }
                };
                result.Add(o);
            }
            return result;
        }
    }
}
