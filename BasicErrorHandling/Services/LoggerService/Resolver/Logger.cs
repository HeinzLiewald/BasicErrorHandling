namespace BasicErrorHandling.Services.LoggerService.Resolver {
    internal class Logger {
        private static ILoggerService _instance;
        public static ILoggerService Instance {
            get {
                if(_instance == null) {
#if DEBUG
                    _instance = new DebugLogger();
#else
                    _instance = new DummyLogger();
#endif
                }
                return _instance;
            }
        }
    }
}
