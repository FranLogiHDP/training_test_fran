using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Infrastucture.Repository.BookingRepository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ILogger<BookingRepository> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;

        public BookingRepository(
            ILogger<BookingRepository> logger,
            DbContextOptions<TrainingDbContext> trainingDbOptions)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
        }

        public Booking GetBookingById(int bookingId)
        {
            Booking booking = new Booking();

            try
            {
                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var bookingFound = trainingContext.Bookings
                        .Include(b => b.Client).ThenInclude(b => b.SendTypes)
                        .Include(b => b.Accommodation).ThenInclude(b => b.AccommodationTemplates)
                        .Include(b => b.Accommodation).ThenInclude(b => b.WorkingArea)
                        .Where(x => bookingId == x.Id).First();

                    booking = bookingFound;
                }
                return booking;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Working Area in data base");
                return booking;
            }
        }
    }
}
