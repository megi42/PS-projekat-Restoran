﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorageInvoice
    {
        List<Invoice> GetAll();
        void Save(Invoice invoice);
    }
}
