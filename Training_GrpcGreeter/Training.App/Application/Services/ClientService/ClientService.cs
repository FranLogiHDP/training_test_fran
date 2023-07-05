using Microsoft.EntityFrameworkCore;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.ClientService
{
    public class ClientService : IClientService
    {
        private readonly ILogger<ClientService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public ClientService(ILogger<ClientService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }

        public async Task<ClientResponse> GetClientAsync(ClientRequest request)
        {
            var clientResponse = new ClientResponse();

            var mapper = MapperProfile.InitializeAutomapper();
            try
            {
                if (request.ClientId is not null && string.IsNullOrEmpty(request.DocumentationNumber))
                {
                    clientResponse = new ClientResponse { Failed = true };
                    clientResponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return clientResponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var client = await trainingContext.Clients
                         .Where(x => x.Id == request.ClientId).FirstOrDefaultAsync();

                    if (client != null)
                    {
                        clientResponse = mapper.Map<Client, ClientResponse>(client);
                    }
                }

                return clientResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Client in data base");

                clientResponse = new ClientResponse { Failed = true };
                clientResponse.ApplicationErrors.Add(new ApplicationError { Code = ex.Data.Values.ToString(), Description = ex.Message });

                return clientResponse;
            }
        }

        public async Task<ClientListResponse> GetListClientAsync(ClientListRequest request)
        {
            var clientListResponse = new ClientListResponse();
            var mapper = MapperProfile.InitializeAutomapper();

            try
            {
                if (request is null || !request.ClientIds.Any())
                {
                    clientListResponse = new ClientListResponse { Failed = true };
                    clientListResponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return clientListResponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var clientList = await trainingContext.Clients
                         .Where(x => request.ClientIds.Contains(x.Id) || request.DocumentationNumber.Contains(x.NumDocument)).ToListAsync();

                    foreach (var client in clientList)
                    {

                        var mapClientResponse = mapper.Map<Client, ClientResponse>(client);
                        clientListResponse.Clients.Add(mapClientResponse);
                    }
                }
                return clientListResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not Exit Client in BBDD");
                return new ClientListResponse { Failed = true };
            }
        }
    }
}
