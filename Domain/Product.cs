using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double PriceWithoutVAT { get; set; }
        public double VAT { get; set; }
        public double PriceWithVAT { get; set; }
        public Currency Currency { get; set; }
        public ProductType Type { get; set; }
    }
}
