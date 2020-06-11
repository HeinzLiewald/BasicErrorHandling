using System;
using BasicErrorHandling.Services;

namespace BasicErrorHandling {
    public class Program {
        private static void Main() {
            var httpService = new HttpService();
            var clientService = new ClientService();

            var clients = clientService.GetClients(httpService);

            Console.WriteLine($"Result: {clients?.Count}");

            Console.ReadKey();
        }
    }
}
