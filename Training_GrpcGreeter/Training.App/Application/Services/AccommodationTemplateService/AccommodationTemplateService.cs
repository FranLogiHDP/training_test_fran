using Microsoft.EntityFrameworkCore;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.AccommodationTemplateService
{
    public class AccommodationTemplateService : IAccommodationTemplateService
    {
        private readonly ILogger<AccommodationTemplateService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public AccommodationTemplateService(ILogger<AccommodationTemplateService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }
        public async Task<AccommodationTemplateListResponse> GetAccommodationTemplateListAsync(AccommodationTemplateListRequest request)
        {
            var accommodationTemplateResponse = new AccommodationTemplateListResponse();

            var mapper = MapperProfile.InitializeAutomapper();
            try
            {
                if (request is null || !request.AccommodationTemplateId.Any() && !request.AccommodationId.Any())
                {
                    accommodationTemplateResponse = new AccommodationTemplateListResponse { Failed = true };
                    accommodationTemplateResponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return accommodationTemplateResponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var accommodationList = await trainingContext.AccommodationTemplates
                        .Where(x => request.AccommodationTemplateId.Contains(x.Id) || request.AccommodationId.Contains(x.AccommodationId.HasValue ? x.AccommodationId.Value : 0)).ToListAsync();

                    foreach (var accommodation in accommodationList)
                    {
                        var mapAccommodationTemplate = mapper.Map<AccommodationTemplate, AccommodationTemplateResponse>(accommodation);
                        accommodationTemplateResponse.AccommodationTemplates.Add(mapAccommodationTemplate);
                    }
                }
                return accommodationTemplateResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Working Area in data base");

                accommodationTemplateResponse = new AccommodationTemplateListResponse { Failed = true };
                accommodationTemplateResponse.ApplicationErrors.Add(new ApplicationError { Code = ex.Data.Values.ToString(), Description = ex.Message });

                return accommodationTemplateResponse;
            }
        }
    }
}
