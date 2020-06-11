using System;

namespace BasicErrorHandling.Services.LoggerService {
    internal interface ILoggerService {
        void Log(Exception ex);
        void Log(string message);
    }
}
