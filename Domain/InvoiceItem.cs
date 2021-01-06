using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class InvoiceItem
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
    }
}
