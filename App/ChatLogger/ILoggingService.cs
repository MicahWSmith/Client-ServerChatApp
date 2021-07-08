using BusinessClass;

namespace ChatLogger
{
    public interface ILoggingService
    {
        // Log Message
        void Log(string message);

        // Create new File
        void NewLog();

        // Delegate Logger
        void LogMessage(object sender, MessageArgs e);
    }
}