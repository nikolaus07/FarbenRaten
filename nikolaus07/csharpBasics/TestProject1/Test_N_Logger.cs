﻿using NLog;

namespace BasicsCS
{
    public class Test_N_Logger
    {
        private static readonly ILogger _NLogger = LogManager.GetCurrentClassLogger();

        public static void testLogger()
        {
            _NLogger.Info("das ist INFO-logger");
            _NLogger.Warn("das ist WARN-logger");
            _NLogger.Error("das ist ERROR-logger");
            _NLogger.Fatal("das ist FATAL-logger");
        }


    }
}
