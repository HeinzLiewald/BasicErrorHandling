using System;
using System.Collections.Generic;

using BasicErrorHandling.Models;
using BasicErrorHandling.Services.LoggerService.Resolver;

namespace BasicErrorHandling.Services {
    public class ClientService {
        private const string URL_CLIENTS = "https://myservice.com/clients";

        public List<Client> GetClients(HttpService httpService) {
            var clients = new List<Client>();

            try {
                clients = httpService.Get<List<Client>>(URL_CLIENTS);
            } catch(Exception ex) {
                Logger.Instance.Log(ex);
            }

            return clients;
        }
    }
}
