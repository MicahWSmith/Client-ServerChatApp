using System;
using System.Net;
using System.Net.Sockets;

namespace ChatLib
{
    ///<summary>
    /// Builds a server object for listening and communication
    ///</summary>
    public class Server:NetworkingBase
    {
        ///<summary>
        /// Constructor initiates the StartServer method
        ///</summary>
        public Server()
        {
            StartServer();
        }

        ///<summary>
        /// Starts server based on port and ip supplied by parent class
        /// Listens for connection and notifies based on success
        /// Sets stream variable for transmission of data
        ///</summary>
        public void StartServer()
        {
            TcpListener server = null;
            try
            {
                Int32 port = PORT;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                Console.Write("Waiting for a connection... ");

                // Perform a blocking call to accept requests.
                // You could also use server.AcceptSocket() here.
                client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");
  
                // Get a stream object for reading and writing
                stream = client.GetStream();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
    }
}
