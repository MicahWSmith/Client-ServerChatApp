using BusinessClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ChatLogger
{
    public class ConsoleLogger : ILoggingService
    {
        public NLog.Logger logger;

        public void Log(string message)
        {
            logger.Info(message);
        }

        public void LogMessage(object sender, MessageArgs e)
        {
            Log(e.Message);
        }

        public void NewLog()
        {
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: Console
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);

            // Apply config           
            NLog.LogManager.Configuration = config;

            logger = NLog.LogManager.GetCurrentClassLogger();
        }
    }
}
