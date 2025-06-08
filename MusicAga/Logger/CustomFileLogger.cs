using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAga.Logger
{
    public class CustomFileLogger
    {
        private static ILogger logger;
        protected static CustomFileLogger instance;

        public delegate void DebugLogHandler(string message);
        public delegate void InfoLogHandler(string message);
        public delegate void WarnLogHandler(string message);
        public delegate void ErrorLogHandler(string message);

        public event DebugLogHandler? DebugLog;
        public event InfoLogHandler? InfoLog;
        public event WarnLogHandler? WarnLog;
        public event ErrorLogHandler? ErrorLog;

        protected CustomFileLogger()
        {
            logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("log.txt").CreateLogger();

            DebugLog += (string message) =>
            {
                logger.Debug(message);
            };
            InfoLog += (string message) =>
            {
                logger.Information(message);
            };
            WarnLog += (string message) =>
            {
                message += "\n!!!!!!!!!!!";
                logger.Warning(message);
            };
            ErrorLog += (string message) =>
            {
                message += "\n!!!!!!!!!!!\nERROR LOG";
                logger.Error(message);
            };
        }

        public static CustomFileLogger GetLogger()
        {
            if(instance == null)
            {
                instance = new CustomFileLogger();
            }
            return instance;
        }

        public void Log(string message, LogLevel logLevel)
        {
            switch(logLevel)
            {
                case LogLevel.Debug:
                    DebugLog?.Invoke(message); return;
                case LogLevel.Info:
                    InfoLog?.Invoke(message); return;
                case LogLevel.Warn:
                    WarnLog?.Invoke(message); return;
                case LogLevel.Error:
                    ErrorLog?.Invoke(message); return;
            }
        }
    }
}
