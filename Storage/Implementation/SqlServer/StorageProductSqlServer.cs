using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.SqlServer
{
    public class StorageProductSqlServer : IStorageProduct
    {
        private Broker broker = new Broker();

        public void Delete(Product product)
        {
            try
            {
                broker.OpenConnection();
                broker.DeleteProduct(product);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllProducts();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Save(Product product)
        {
            try
            {
                broker.OpenConnection();
                product.PriceWithVAT = (product.PriceWithoutVAT + (product.PriceWithoutVAT * product.VAT) / 100);
                broker.SaveProduct(product);
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
