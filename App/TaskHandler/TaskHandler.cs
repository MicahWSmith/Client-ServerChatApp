using System;
using ChatLib;

namespace BusinessClass
{
    /// <summary>
    /// TaskHandler object to handle most functionality
    /// </summary>
    public class TaskHandler : IMessaging
    {
        // thread stop flag
        public volatile bool StopThread = false;
        // Client/server objects
        public Client Client;
        public Server Server;

        // on message received event
        public event EventHandler<MessageArgs> GetMessage;
        /// <summary>
        /// create new client connection in global Obj
        /// </summary>
        public void Connect()
        {
            Client = new Client();
        }
        /// <summary>
        /// Call clients disconnect method from networking base
        /// </summary>
        public void EndConnection()
        {
            Client.Disconnect();
        }
        /// <summary>
        /// Loops to listen for a message and if it exists, passes params to delegate
        /// </summary>
        public void ListenMode()
        {
            // Check for stop flag to prevent ui halt
            while (true&&!StopThread)
            {
                try
                {
                    // check for message content and call event accordingly
                    
                    String message = Client.GetMessage();
                    if (message != "")
                    {
                        GetMessage(this, new MessageArgs() { Message = "Server: " + message });
                    }

                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Error recieving message from server: "+ex);
                }
            }
            StopThread = false;
            // reset thread halt var
        }
        /// <summary>
        /// Send message via clients send message method inherited from networking base
        /// References messageArgs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="mes"></param>
        public void SendClient(object sender, MessageArgs mes)
        {
            Client.SendMessage(mes.Message);
        }
        /// <summary>
        /// Send message via servers send message method inherited from networking base
        /// References messageArgs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="mes"></param>
        public void SendServer(object sender, MessageArgs mes)
        {
            Server.SendMessage(mes.Message);
        }

        public void StopTasks()
        {
            StopThread = true;
        }
    }
}
