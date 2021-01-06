using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Communication
{
    public class Communication
    {
        private static Communication instance;

        private Socket socket;
        private CommunicationClient client;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        private Communication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Connect()
        {
            if (socket != null && !socket.Connected)
            {
                socket.Connect("192.168.1.2", 9999);
                client = new CommunicationClient(socket);
            }
        }

        internal List<Product> GetAllProducts()
        {
            Request request = new Request() { Operation = Operation.GetAllProducts };
            client.SendRequest(request);
            return (List<Product>)client.GetResponseResult();
        }

        internal List<Table> GetAllTables()
        {
            Request request = new Request() { Operation = Operation.GetAllTables };
            client.SendRequest(request);
            return (List<Table>)client.GetResponseResult();
        }

        internal List<Order> GetAllOrders()
        {
            Request request = new Request() { Operation = Operation.GetAllOrders };
            client.SendRequest(request);
            return (List<Order>)client.GetResponseResult();
        }

        internal List<User> GetALLUsers()
        {
            Request request = new Request() { Operation = Operation.GetAllUsers };
            client.SendRequest(request);
            return (List<User>)client.GetResponseResult();
        }

        internal User Login(string username, string password)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = new User { Username = username, Password = password }
            };
            client.SendRequest(request);
            return (User)client.GetResponseResult();
        }

        internal void SaveProduct(Product p)
        {
            Request request = new Request() { Operation = Operation.SaveProduct, RequestObject = p };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void RemoveProduct(Product product)
        {
            Request request = new Request() { Operation = Operation.RemoveProduct, RequestObject = product };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<Invoice> GetAllInvoices()
        {
            Request request = new Request() { Operation = Operation.GetAllInvoices };
            client.SendRequest(request);
            return (List<Invoice>)client.GetResponseResult();
        }

        internal List<OrderItem> GetOrderItems(Order order)
        {
            Request request = new Request() { Operation = Operation.GetOrderItems, RequestObject = order };
            client.SendRequest(request);
            return (List<OrderItem>)client.GetResponseResult();
        }

        internal void SaveOrder(Order order)
        {
            Request request = new Request() { Operation = Operation.SaveOrder, RequestObject = order };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SaveChangesToOrder(OrderChanges orderChanges)
        {
            Request request = new Request() { Operation = Operation.SaveChangesToOrder, RequestObject = orderChanges };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SaveInvoice(Invoice invoice)
        {
            Request request = new Request() { Operation = Operation.SaveInvoice, RequestObject = invoice };
            client.SendRequest(request);
            client.GetResponseResult();
        }
    }
}
