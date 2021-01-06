using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket listener;

        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public void Start()
        {
            listener.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.2"), 9999));
        }

        public void Listen()
        {
            listener.Listen(5);

            while (true)
            {
                Socket client = listener.Accept();
                ClientHandler handler = new ClientHandler(client);
                Thread thread = new Thread(handler.StartHandler);
                thread.IsBackground = true;
                thread.Start();
            }
        }
    }
}
