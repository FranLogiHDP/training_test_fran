using Microsoft.EntityFrameworkCore;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.LogService
{
    public class LogService : ILogService
    {
        private readonly ILogger<LogService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public LogService(ILogger<LogService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }
        public async Task<LogListResponse> GetLogListAsync(LogListRequest request)
        {
            var logReponse = new LogListResponse();

            var mapper = MapperProfile.InitializeAutomapper();
            try
            {
                if (request is null || !request.SendTypeId.Any() && !request.ClientId.Any() && !request.LogId.Any())
                {
                    logReponse = new LogListResponse { Failed = true };
                    logReponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return logReponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var logList = await trainingContext.Logs
                        .Where(x => request.LogId.Contains(x.Id)
                                 || request.ClientId.Contains(x.Id)
                                 || request.AccommodationId.Contains(x.AccommodationId.HasValue ? x.AccommodationId.Value : 0)
                                 || request.SendTypeId.Contains(x.SendTypeId.HasValue ? x.SendTypeId.Value : 0)
                         ).ToListAsync();

                    foreach (var log in logList)
                    {
                        var mapLogResponse = mapper.Map<Log, LogResponse>(log);
                        logReponse.Logs.Add(mapLogResponse);
                    }
                }
                return logReponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Working Area in data base");

                logReponse = new LogListResponse { Failed = true };
                logReponse.ApplicationErrors.Add(new ApplicationError { Code = ex.Data.Values.ToString(), Description = ex.Message });

                return logReponse;
            }
        }
    }
}
