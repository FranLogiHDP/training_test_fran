using Microsoft.EntityFrameworkCore;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.AccommodationService
{
    public class AccommodationService : IAccommodationService
    {
        private readonly ILogger<AccommodationService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public AccommodationService(ILogger<AccommodationService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }
        public async Task<AccommodationListResponse> GetAccommodationListAsync(AccommodationListRequest request)
        {
            var accommodationResponse = new AccommodationListResponse();

            var mapper = MapperProfile.InitializeAutomapper();
            try
            {
                if (request is null || !request.AccommodationId.Any())
                {
                    accommodationResponse = new AccommodationListResponse { Failed = true };
                    accommodationResponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return accommodationResponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var accommodationList = await trainingContext.Accommodations
                        .Where(x => request.AccommodationId.Contains(x.Id)).ToListAsync();

                    foreach (var accommodation in accommodationList)
                    {
                        var mapAccommodationResponse = mapper.Map<Accommodation, AccommodationResponse>(accommodation);
                        accommodationResponse.Accommodations.Add(mapAccommodationResponse);
                    }
                }
                return accommodationResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Working Area in data base");

                accommodationResponse = new AccommodationListResponse { Failed = true };
                accommodationResponse.ApplicationErrors.Add(new ApplicationError { Code = ex.Data.Values.ToString(), Description = ex.Message });

                return accommodationResponse;
            }
        }
    }
}
