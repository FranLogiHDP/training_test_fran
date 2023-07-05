using Microsoft.EntityFrameworkCore;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.SendTypeService
{
    public class SendTypeService : ISendTypeService
    {
        private readonly ILogger<SendTypeService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public SendTypeService(ILogger<SendTypeService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }
        public async Task<SendTypeListResponse> GetSendTypeListAsync(SendTypeListRequest request)
        {
            var sendTypeResponse = new SendTypeListResponse();
            var mapper = MapperProfile.InitializeAutomapper();

            try
            {
                if (request is null || !request.SendTypeId.Any() && !request.ClientId.Any())
                {
                    sendTypeResponse = new SendTypeListResponse { Failed = true };
                    sendTypeResponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return sendTypeResponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var sendTypeList = await trainingContext.SendTypes
                        .Where(x => request.SendTypeId.Contains(x.Id) || request.ClientId.Contains(x.ClientId.HasValue ? x.ClientId.Value : 0)).ToListAsync();

                    foreach (var sendType in sendTypeList)
                    {
                        var mapSendTypeRespone = mapper.Map<SendType, SendTypeResponse>(sendType);
                        sendTypeResponse.SendTypes.Add(mapSendTypeRespone);
                    }
                }
                return sendTypeResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found send type in data base");

                sendTypeResponse = new SendTypeListResponse { Failed = true };
                sendTypeResponse.ApplicationErrors.Add(new ApplicationError { Code = ex.Data.Values.ToString(), Description = ex.Message });

                return sendTypeResponse;
            }
        }
    }
}
