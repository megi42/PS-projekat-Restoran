using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class Server
    {
        private Socket listener;
        private List<ClientHandler> clients = new List<ClientHandler>();
        private BindingList<User> users = new BindingList<User>();
        public BindingList<User> Users
        {
            get { return users; }
        }
        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            listener.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.7"), int.Parse(ConfigurationManager.AppSettings["port"])));
        }

        public void Listen()
        {
            listener.Listen(5);
            bool kraj = false;
            while (!kraj)
            {
                try
                {

                    Socket client = listener.Accept();
                    ClientHandler handler = new ClientHandler(client, users);
                    clients.Add(handler);
                    Thread thread = new Thread(handler.StartHandler);
                    thread.IsBackground = true;
                    thread.Start();

                }
                catch (SocketException)
                {
                    Console.WriteLine("Kraj rada");
                    kraj = true;
                }
            }
        }

        internal void Stop()
        {
            listener.Close();
            foreach (ClientHandler c in clients)
            {
                c.Stop();
            }
            clients.Clear();
        }
    }
}
