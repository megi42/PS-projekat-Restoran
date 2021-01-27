using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.InvoiceSO
{
    public class AddInvoiceSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Save(entity);

            Invoice invoice = (Invoice)entity;
            invoice.InvoiceId = repository.GetNewId(entity);

            foreach (InvoiceItem ii in invoice.InvoiceItems)
            {
                ii.InvoiceId = invoice.InvoiceId;
                IEntity ie = (IEntity)ii;
                repository.Save(ie);
            }

            Payment payment = invoice.Payment;
            payment.InvoiceId = invoice.InvoiceId;
            IEntity entity1 = (IEntity)payment;
            repository.Save(entity1);

            payment.PaymentID = repository.GetNewId(entity1);

            Card card = payment.Card;
            if (card != null)
            {
                card.PaymentID = payment.PaymentID;
                card.InvoiceId = invoice.InvoiceId;
                IEntity entity2 = (IEntity)card;
                repository.Save(entity2);
            }

            Cache cache = payment.Cache;
            if (cache != null)
            {
                cache.PaymentID = payment.PaymentID;
                cache.InvoiceId = invoice.InvoiceId;
                IEntity entity2 = (IEntity)cache;
                repository.Save(entity2);
            }

        }
    }
}
