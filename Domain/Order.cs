using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public Table Table { get; set; }
        public double TotalWithoutVAT { get; set; }
        public double TotalWithVAT { get; set; }
        public Currency Currency { get; set; }
    }
}
