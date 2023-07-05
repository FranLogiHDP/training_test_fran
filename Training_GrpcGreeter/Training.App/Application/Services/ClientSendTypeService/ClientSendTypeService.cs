using Microsoft.EntityFrameworkCore;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.ClientSendTypeService
{
    public class ClientSendTypeService : IClientSendTypeService
    {
        private readonly ILogger<ClientSendTypeService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public ClientSendTypeService(ILogger<ClientSendTypeService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }
        public async Task<ClientSendTypeListResponse> GetClientSendTypeListAsync(ClientSendTypeListRequest request)
        {
            var clientSendTypeResponse = new ClientSendTypeListResponse();

            var mapper = MapperProfile.InitializeAutomapper();
            try
            {
                if (request is null || !request.SendTypeId.Any() && !request.ClientId.Any())
                {
                    clientSendTypeResponse = new ClientSendTypeListResponse { Failed = true };
                    clientSendTypeResponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return clientSendTypeResponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var clientSendTypeList = await trainingContext.ClientSendTypes
                        .Where(x => request.ClientId.Contains(x.Id) || request.SendTypeId.Contains(x.SendTypeId.HasValue ? x.SendTypeId.Value : 0)).ToListAsync();

                    foreach (var clientSendtype in clientSendTypeList)
                    {
                        var mapClientSendtypeResponse = mapper.Map<ClientSendType, ClientSendTypeResponse>(clientSendtype);
                        clientSendTypeResponse.ClientSendTypes.Add(mapClientSendtypeResponse);
                    }
                }
                return clientSendTypeResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Client Send Type in data base");

                clientSendTypeResponse = new ClientSendTypeListResponse { Failed = true };
                clientSendTypeResponse.ApplicationErrors.Add(new ApplicationError { Code = ex.Data.Values.ToString(), Description = ex.Message });

                return clientSendTypeResponse;
            }
        }
    }
}
