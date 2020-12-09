using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True;");
        }

        public List<Table> GetAllTables()
        {
            List<Table> tables = new List<Table>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Tablee";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Table t = new Table()
                {
                    TableNumber = (int)reader[0]
                };
                tables.Add(t);
            }
            reader.Close();
            return tables;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Userr";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User u = new User()
                {
                    Id = (int)reader[0],
                    Username = (string)reader[1],
                    Password = (string)reader[2],
                    FirstName = (string)reader[3],
                    LastName = (string)reader[4],
                };
                users.Add(u);
            }
            reader.Close();
            return users;
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> res = new List<Product>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from product p join Userr u on (p.UserId=u.Id)";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product p = new Product()
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
                        Username = (string)reader[9],
                        Password = (string)reader[10],
                        FirstName = (string)reader[11],
                        LastName = (string)reader[12],
                    }
                    
                };
                res.Add(p);
            }
            reader.Close();
            return res;
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void SaveProduct(Product p)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into product values (@Name, @PriceWithoutVAT, @VAT, @PriceWithVAT, @Currency, @Type, @User)";

            command.Parameters.AddWithValue("@Name", p.Name);
            command.Parameters.AddWithValue("@PriceWithoutVAT", p.PriceWithoutVAT);
            command.Parameters.AddWithValue("@VAT", p.VAT);
            command.Parameters.AddWithValue("@PriceWithVAT", p.PriceWithVAT);
            command.Parameters.AddWithValue("@Currency", p.Currency);
            command.Parameters.AddWithValue("@Type", p.Type);
            command.Parameters.AddWithValue("@User", p.User.Id);

            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Greška u bazi podataka!");
            }
        }
    }
}
