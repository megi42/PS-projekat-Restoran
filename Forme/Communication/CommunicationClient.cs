using Common;
using Forme.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Communication
{
    internal class CommunicationClient
    {
        private Receiver receiver;
        private Sender sender;
        public CommunicationClient(Socket socket)
        {
            receiver = new Receiver(socket);
            sender = new Sender(socket);
        }

        public void SendRequest(Request request)
        {
            sender.Send(request);
        }
        public object GetResponseResult()
        {
            Response response = (Response)receiver.Receive();
            if (response.IsSuccessful)
            {
                return response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Error);
            }
        }
    }
}
