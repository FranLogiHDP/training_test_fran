using Microsoft.EntityFrameworkCore;
using Training.App.Application.Services.SendMessageService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.BookingService
{
    public class BookingService : IBookingService
    {
        private readonly ILogger<BookingService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;
        private readonly ICommunicationService _communicationService;

        public BookingService(ILogger<BookingService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions,
        ICommunicationService communicationService)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
            _communicationService = communicationService;
        }
        public async Task<BookingListResponse> GetBookingListAsync(BookingListRequest request)
        {
            var bookingResponse = new BookingListResponse();

            var mapper = MapperProfile.InitializeAutomapper();
            try
            {
                if (request is null || !request.SendTypeId.Any() && !request.ClientId.Any() && !request.BookingId.Any() && !request.AccommodationId.Any())
                {
                    bookingResponse = new BookingListResponse { Failed = true };
                    bookingResponse.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });
                    return bookingResponse;
                }

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var booingList = await trainingContext.Bookings
                        .Include(b => b.Client)
                        .Include(b => b.Accommodation)
                        .Where(x => request.BookingId.Contains(x.Id) || request.ClientId.Contains(x.ClientId) || request.SendTypeId.Contains(x.SendTypeId)).ToListAsync();

                    foreach (var booking in booingList)
                    {
                        var mapBookingResponse = mapper.Map<Booking, BookingResponse>(booking);
                        bookingResponse.Bookings.Add(mapBookingResponse);
                    }
                }
                return bookingResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Working Area in data base");

                bookingResponse = new BookingListResponse { Failed = true };
                bookingResponse.ApplicationErrors.Add(new ApplicationError { Code = ex.Data.Values.ToString(), Description = ex.Message });

                return bookingResponse;
            }
        }

        public async Task<BookingUpsertResponse> UpsertBookingAsync(BookingUpsertRequest request)
        {
            var bookingResponse = new BookingUpsertResponse();
            try
            {
                if (request is null || request.Booking is null)
                {
                    return new BookingUpsertResponse { Success = false, Message = "Null or empty data request" };
                }

                if (!request.Booking.BookingId.HasValue || !IsBookingExist(request.Booking.BookingId.Value))
                {
                    bookingResponse = await CreateBookingAsync(request.Booking);
                }
                else
                {
                    bookingResponse = await UpdateBookingAsync(request.Booking);
                }

                return bookingResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Working Area in data base");

                return new BookingUpsertResponse { Success = false, Message = ex.Message };
            }
        }

        public async Task<BookingUpsertResponse> CreateBookingAsync(BookingResponse request)
        {
            try
            {
                var newBooking = new Booking()
                {
                    AccommodationId = request.AccommodationId,
                    BookingDate = DateOnly.FromDateTime(DateTime.Today),
                    CheckinDate = DateOnly.Parse(request.CheckInDate),
                    CheckoutDate = DateOnly.Parse(request.CheckOutDate),
                    ClientId = request.ClientId,
                    SendTypeId = request.SendTypeId,
                    Price = request.Price
                };


                await using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    trainingContext.Add(newBooking);
                    trainingContext.SaveChanges();
                    _communicationService.SendMessagge(newBooking);
                }
                return new BookingUpsertResponse { Message = "New Booking Create", Success = true };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "Not found Client Send Type in data base");
                return new BookingUpsertResponse { Message = ex.Message, Success = false };
            }
        }
        public async Task<BookingUpsertResponse> UpdateBookingAsync(BookingResponse request)
        {
            try
            {
                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var bookingResult = await trainingContext.Bookings
                        .Where(x => x.Id.Equals(request.BookingId)).FirstOrDefaultAsync();

                    if (bookingResult is not null)
                    {
                        bookingResult.BookingDate = DateOnly.Parse(request.BookingDate);
                        bookingResult.CheckinDate = DateOnly.Parse(request.CheckInDate);
                        bookingResult.CheckoutDate = DateOnly.Parse(request.CheckOutDate);
                        bookingResult.ClientId = request.ClientId;
                        bookingResult.SendTypeId = request.SendTypeId;
                        bookingResult.Price = request.Price;

                        trainingContext.SaveChanges();
                        _communicationService.SendMessagge(bookingResult);
                    }
                }
                return new BookingUpsertResponse { Message = "Update Booking Create", Success = true };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.InnerException?.Message, "Not found data request in data base");
                return new BookingUpsertResponse { Message = ex.InnerException?.Message, Success = false };
            }
        }
        public bool IsBookingExist(int bookingId)
        {
            bool bookingResult = false;
            using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
            {
                bookingResult = trainingContext.Bookings
                .Select(x => x.Id.Equals(bookingId)).Count() > 0;
            }

            return bookingResult;
        }
    }
}
