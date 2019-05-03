using NLog;
using System;

namespace ConsoleNlog
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //To configure programmatically, then one can do this in code:

            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "file.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            NLog.LogManager.Configuration = config;*/

            var logger = NLog.LogManager.GetCurrentClassLogger();

            logger.Trace("Sample trace message");
            logger.Debug("Sample debug message");
            logger.Info("Sample informational message");
            logger.Warn("Sample warning message");
            logger.Error("Sample error message");
            logger.Fatal("Sample fatal error message");

            // alternatively you can call the Log() method
            // and pass log level as the parameter.
            logger.Log(LogLevel.Info, "Sample informational message");


            // Example of logging an exception
            try
            {
                throw new Exception("Error");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ow noos!"); // render the exception with ${exception}
            }

            Console.ReadLine();
        }
    }
}
