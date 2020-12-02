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
        public void OpenConnection()
        {
            connection.Open();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> res = new List<Product>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from product";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    ProductId = (int)reader["Id"],
                    Name = (string)reader[1],
                    PriceWithoutVAT = (double)reader[2],
                    VAT = (double)reader[3],
                    PriceWithVAT = (double)reader[4],
                    Currency = (Currency)reader[5],
                    Type = (ProductType)reader[6],
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

        public int GetNewProductId()
        {
            object result = 0;
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select max(id) from product";
            result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return ((int)result + 1);
            }
        }

        public void SaveProduct(Product p)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into product values ({p.ProductId}, '{p.Name}', {p.PriceWithoutVAT}, {p.VAT}, {p.PriceWithVAT}, {(int)p.Currency}, {(int)p.Type})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }
    }
}
