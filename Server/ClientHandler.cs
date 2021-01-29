using Common;
using ControllerBL;
using Domain;
using System;
using System.ComponentModel;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public class ClientHandler
    {
        private Socket client;
        private readonly BindingList<User> users;

        private User loggedInUser;
        public ClientHandler(Socket client, System.ComponentModel.BindingList<User> users)
        {
            this.client = client;
            this.users = users;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
            switch (request.Operation)
            {
                case Operation.Login:
                    loggedInUser= Controller.Instance.Login((User)request.RequestObject);
                    response.Result = loggedInUser;
                    break;
                case Operation.SaveProduct:
                    Product product = (Product)request.RequestObject;
                    product.User = loggedInUser;
                    product.PriceWithVAT = (product.PriceWithoutVAT + (product.PriceWithoutVAT * product.VAT) / 100);
                    Controller.Instance.SaveProduct(product);
                    break;
                case Operation.GetAllProducts:
                    response.Result = Controller.Instance.GetAllProducts();
                    break;
                case Operation.RemoveProduct:
                    Controller.Instance.DeleteProduct((Product)request.RequestObject);
                    break;
                case Operation.SearchProducts:
                    response.Result = Controller.Instance.SearchProducts((Product)request.RequestObject);
                    break;
                case Operation.SearchOrders:
                    response.Result = Controller.Instance.SearchOrders((Order)request.RequestObject);
                    break;
                case Operation.GetAllOrders:
                    response.Result = Controller.Instance.GetAllOrders();
                    break;
                case Operation.GetAllTables:
                    response.Result = Controller.Instance.GetAllTables();
                    break;
                case Operation.GetAllUsers:
                    response.Result = Controller.Instance.GetALLUsers();
                    break;
                case Operation.GetAllInvoices:
                    response.Result = Controller.Instance.GetAllInvoices();
                    break;
                case Operation.GetOrderItems:
                    response.Result = Controller.Instance.GetOrderItems((OrderItem)request.RequestObject);
                    break;
                case Operation.SaveOrder:
                    Controller.Instance.SaveOrder((Order)request.RequestObject);
                    break;
                case Operation.SaveChangesToOrder:
                    Controller.Instance.UpdateOrder((Order)request.RequestObject);
                    break;
                case Operation.SaveInvoice:
                    Controller.Instance.SaveInvoice((Invoice)request.RequestObject);
                    break;
            }
            return response;
        }

        internal void Stop()
        {
            client.Close();
        }
    }
}
