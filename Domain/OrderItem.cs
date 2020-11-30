using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Pieces { get; set; }
        public double PriceWithoutVAT { get; set; }
        public double PriceWithVAT { get; set; }
        public Currency Currency { get; set; }
        public double Total { get; set; }
    }
}
