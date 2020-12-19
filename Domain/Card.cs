using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Card
    {
        public int PaymentID { get; set; }
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public CardType CardType { get; set; }
        public long CardNumber { get; set; }
        public double TotalByCard { get; set; }
    }
}
