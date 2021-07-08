using System;
using System.Net.Sockets;

namespace ChatLib
{
    ///<summary>
    /// set shared properties and methods of netWorkingBase objects
    ///</summary>
    public abstract class NetworkingBase
    {
        ///<remarks>
        /// Shared IP of client/server
        ///</remarks>
        public static string IPADDRESS = "127.0.0.1";
        ///<remarks>
        /// Shared stream var of client/server
        ///</remarks>
        public NetworkStream stream;
        ///<remarks>
        /// Shared client var of client/server
        ///</remarks>
        public TcpClient client;
        ///<remarks>
        /// Shared Port var of client/server
        ///</remarks>
        public static int PORT=5555;

        ///<remarks>
        ///Close connection
        ///</remarks>
        public void Disconnect() {
            stream.Close();
            client.Close();
        }
        ///<summary>
        /// To read from stream: Buffer for reading data 
        /// Translate the passed message from ASCII and store it as a string.
        ///</summary>
        public string GetMessage() {
            Byte[] data = new Byte[256];
            String responseData = String.Empty;
            
            if (stream.DataAvailable)
            {
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            }
            return responseData;
        }
        /// <summary>
        /// Takes in a string to encode as bytes and send over current net stream
        /// </summary>
        /// <param name="str"></param>
        public void SendMessage(String str) {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(str);
            stream.Write(data, 0, data.Length);
        }
    }
}
