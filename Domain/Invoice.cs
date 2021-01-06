using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public Table Table { get; set; }
        public double TotalWithoutVAT { get; set; }
        public double TotalWithVAT { get; set; }
        public double TotalToPay { get; set; }
        public Currency Currency { get; set; }
        public User User { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
        public Payment Payment { get; set; }
    }
}
