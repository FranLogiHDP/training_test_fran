using Microsoft.EntityFrameworkCore;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.WorkingAreaService
{
    public class WorkingAreaService : IWorkingAreaService
    {
        private readonly ILogger<WorkingAreaService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public WorkingAreaService(ILogger<WorkingAreaService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }
        public async Task<WorkingAreaListResponse> GetWorkingAreaListAsync(WorkingAreaListRequest request)
        {
            var workingAreaResponse = new WorkingAreaListResponse();

            var mapper = MapperProfile.InitializeAutomapper();
            try
            {
                if (request is null || !request.WorkingAreaId.Any() && !request.Zone.Any())
                {
                    workingAreaResponse = new WorkingAreaListResponse { Failed = true };
                    workingAreaResponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return workingAreaResponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var workingAreaList = await trainingContext.WorkingAreas
                        .Where(x => request.WorkingAreaId.Contains(x.Id) || request.Zone.Contains(x.Zone)).ToListAsync();

                    foreach (var workingArea in workingAreaList)
                    {
                        var mapWorkingAreaResponse = mapper.Map<WorkingArea, WorkingAreaResponse>(workingArea);
                        workingAreaResponse.WorkingAreas.Add(mapWorkingAreaResponse);
                    }
                }
                return workingAreaResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Working Area in data base");

                workingAreaResponse = new WorkingAreaListResponse { Failed = true };
                workingAreaResponse.ApplicationErrors.Add(new ApplicationError { Code = ex.Data.Values.ToString(), Description = ex.Message });

                return workingAreaResponse;
            }
        }
    }
}
