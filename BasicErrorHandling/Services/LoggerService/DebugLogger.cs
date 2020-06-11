using System;
using System.Diagnostics;

namespace BasicErrorHandling.Services.LoggerService {
    internal class DebugLogger : ILoggerService {
        public void Log(Exception ex) {
            Log(ex.ToString());
        }

        public void Log(string message) {
            Debug.WriteLine(message);
        }
    }
}
