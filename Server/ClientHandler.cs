using Common;
using ControllerBL;
using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket client;

        public ClientHandler(Socket client)
        {
            this.client = client;
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
                    response.Result = Controller.Instance.Login((User)request.RequestObject);
                    break;
                case Operation.SaveProduct:
                    Controller.Instance.SaveProduct((Product)request.RequestObject);
                    break;
                case Operation.GetAllProducts:
                    response.Result = Controller.Instance.GetAllProducts();
                    break;
                case Operation.RemoveProduct:
                    Controller.Instance.DeleteProduct((Product)request.RequestObject);
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
                    response.Result = Controller.Instance.GetOrderItems((Order)request.RequestObject);
                    break;
                case Operation.SaveOrder:
                    Controller.Instance.SaveOrder((Order)request.RequestObject);
                    break;
                case Operation.SaveChangesToOrder:
                    OrderChanges oc = (OrderChanges)request.RequestObject;
                    Controller.Instance.SaveChangesToOrder(oc.Order, oc.Id);
                    break;
                case Operation.SaveInvoice:
                    Controller.Instance.SaveInvoice((Invoice)request.RequestObject);
                    break;
            }
            return response;
        }
    }
}
