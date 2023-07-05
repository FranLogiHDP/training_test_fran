using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Infrastucture.Repository.AccommodationRepository
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly ILogger<AccommodationRepository> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public AccommodationRepository(
            ILogger<AccommodationRepository> logger,
            DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }
        public List<Accommodation> GetAccommodationListByZoneId(int? zoneId)
        {
            var accommodationList = new List<Accommodation>();

            try
            {
                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var accommodationFoundList = trainingContext.Accommodations
                        .Where(x => zoneId == x.WorkingAreaId).ToList();

                    accommodationList.AddRange(accommodationFoundList);
                }
                return accommodationList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Accommodation this zone in data base");
                return accommodationList;
            }
        }
    }
}
