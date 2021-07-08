using System;
using System.Net.Sockets;

namespace ChatLib
{
    ///<summary>
    /// Initializes a client to communicate and connect to server instance
    ///</summary>
    public class Client:NetworkingBase
    {
        ///<summary>
        /// Initializes tcp client method which starts the connection
        ///</summary>
        public Client()
        {
            StartTcpClient();
        }
        ///<summary>
        /// Starts client based on port and ip supplied by parent class
        /// Listens for connection and notifies based on success
        /// Sets stream variable for transmission of data
        ///</summary>
        public void StartTcpClient()
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = PORT;
                client = new TcpClient(IPADDRESS, port);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();
                stream = client.GetStream();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }

    }
}
