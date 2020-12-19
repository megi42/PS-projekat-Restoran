using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.SqlServer
{
    public class StorageInvoiceSqlServer : IStorageInvoice
    {
        private Broker broker = new Broker();

        public List<Invoice> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllInvoices();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Save(Invoice invoice)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();
                invoice.InvoiceId = broker.SaveInvoice(invoice);

                foreach (InvoiceItem ii in invoice.InvoiceItems)
                {
                    ii.InvoiceId = invoice.InvoiceId;
                    broker.SaveInvoiceItem(ii);
                }

                Payment payment = invoice.Payment;
                payment.InvoiceId = invoice.InvoiceId;
                payment.PaymentID = broker.SavePayment(payment);

                Card card = payment.Card;
                if(card != null)
                {
                    card.PaymentID = payment.PaymentID;
                    card.InvoiceId = invoice.InvoiceId;
                    broker.SaveCard(card);
                }

                Cache cache = payment.Cache;
                if(cache != null)
                {
                    cache.PaymentID = payment.PaymentID;
                    cache.InvoiceId = invoice.InvoiceId;
                    broker.SaveCache(cache);
                }

                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
