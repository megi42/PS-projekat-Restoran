﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Cache
    {
        public int PaymentID { get; set; }
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public double TotalInCache { get; set; }
    }
}
