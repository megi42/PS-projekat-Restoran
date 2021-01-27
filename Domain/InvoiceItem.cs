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
    public class InvoiceItem : IEntity
    {
        public int InvoiceId { get; set; }
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
        public string TableName => "InvoiceItem";
        [Browsable(false)]
        public string InsertValues => $"'{InvoiceId}', '{OrderId}', '{Number}', '{Product.ProductId}', '{PriceWithoutVAT}', '{PriceWithVAT}', '{Pieces}', '{TotalWithoutVAT}', '{TotalWithVAT}', '{(int)Currency}'";
        [Browsable(false)]
        public string IdName => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string JoinTable => throw new NotImplementedException();
        [Browsable(false)]
        public string TableAlias => throw new NotImplementedException();
        [Browsable(false)]
        public string DeleteCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string SearchCondition => throw new NotImplementedException();
        [Browsable(false)]
        public string SelectValues => throw new NotImplementedException();
        [Browsable(false)]
        public string UpdateValues => throw new NotImplementedException();
        [Browsable(false)]
        public string UpdateCondition => throw new NotImplementedException();

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
