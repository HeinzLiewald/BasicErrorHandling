using System;

namespace BasicErrorHandling.Services.LoggerService {
    internal class DummyLogger : ILoggerService {
        public void Log(Exception ex) {
            // Nothing to do here
        }

        public void Log(string message) {
            // Nothing to do here
        }
    }
}
