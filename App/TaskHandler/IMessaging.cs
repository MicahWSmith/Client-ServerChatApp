using System;

namespace BusinessClass
{
    public interface IMessaging
    {
        // on message received event
        event EventHandler<MessageArgs> GetMessage;

        void StopTasks();

        void Connect();

        void EndConnection();

        void ListenMode();

        void SendClient(object sender, MessageArgs mes);

        void SendServer(object sender, MessageArgs mes);
    }
}