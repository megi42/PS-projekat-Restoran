using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Payment
    {
        public int PaymentID { get; set; }
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public double Total { get; set; }
        public Currency Currency { get; set; }
        public PaymentType PaymentType { get; set; }
        public Cache Cache { get; set; }
        public Card Card { get; set; }
    }
}
