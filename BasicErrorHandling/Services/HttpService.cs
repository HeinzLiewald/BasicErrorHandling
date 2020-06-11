using System;

namespace BasicErrorHandling.Services {
    public class HttpService {
        internal T Get<T>(string url) {
            throw new Exception("Something went wrong!");
        }
    }
}
