using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.App;
using Training.App.Application.Services.BookingService;
using Training.App.Application.Services.SendMessageService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Tests.Application.Services
{
    [TestClass]
    public class BookingServicesTest
    {
        private IBookingService _service;
        private ICommunicationService? _serviceCommunication;
        private DbContextOptions<TrainingDbContext>? _context;

        private Mock<ILogger<BookingService>>? _loggerMock;


        [TestInitialize]
        public void Setup()
        {
            _context = InitContextFixture();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            mappingConfig.CreateMapper();
            _loggerMock = new Mock<ILogger<BookingService>>();
            _serviceCommunication = new Mock<ICommunicationService>().Object;
            _service = new BookingService(_loggerMock.Object, _context, _serviceCommunication);

        }

        [TestMethod]
        public async Task GetBookingList_WhenFilteredByAccommodationIdsBookingIdsSendTypeIdsClientIds()
        {
            var accommodationIds = new List<int>() { 1, 2 };
            var BookingIds = new List<int>() { 1, 2 };
            var sendTypeIds = new List<int>() { 1, 2 };
            var clientIds = new List<int>() { 1, 2 };

            var bookingRequest = new BookingListRequest();
            bookingRequest.AccommodationId.AddRange(accommodationIds);
            bookingRequest.BookingId.AddRange(BookingIds);
            bookingRequest.SendTypeId.AddRange(sendTypeIds);
            bookingRequest.ClientId.AddRange(clientIds);

            var bookingList = new List<BookingResponse>
            {
                new BookingResponse
                {
                    BookingId = 1,
                    AccommodationId = 1,
                    SendTypeId = 1,
                    ClientId = 1,
                    CheckInDate = "7/13/2023",
                    CheckOutDate = "7/15/2023",
                    BookingDate = "7/3/2023",
                    Price = 100
                },
                new BookingResponse
                {
                    BookingId = 2,
                    AccommodationId = 2,
                    SendTypeId = 2,
                    ClientId = 2,
                    CheckInDate = "8/3/2023",
                    CheckOutDate = "8/12/2023",
                    BookingDate = "3/13/2023",
                    Price = 300,
                }
            };
            BookingListResponse expected = new BookingListResponse() { Failed = false };
            expected.Bookings.AddRange(bookingList);

            BookingListResponse result = await _service.GetBookingListAsync(bookingRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetBookingList_WhenNotFiltered()
        {
            var bookingListRequest = new BookingListRequest();

            BookingListResponse expected = new BookingListResponse() { Failed = true };
            expected.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });

            BookingListResponse result = await _service.GetBookingListAsync(bookingListRequest);

            Assert.AreEqual(expected, result);
        }

        private DbContextOptions<TrainingDbContext> InitContextFixture()
        {
            DbContextOptions<TrainingDbContext> options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase(databaseName: "test3").Options;

            using (TrainingDbContext context = new TrainingDbContext(options))
            {
                InitAccommodations(context);
                InitClients(context);
                InitSendTypes(context);
                InitBookings(context);
                context.SaveChanges();
            }

            return options;
        }
        private void InitAccommodations(TrainingDbContext context)
        {
            List<Accommodation> accommodations = new List<Accommodation>
            {
                new Accommodation
                {
                    Id = 1,
                    AccommodationName = "Hotel1",
                    WorkingAreaId = 1,
                },
                new Accommodation
                {
                    Id = 2,
                    AccommodationName = "Hotel2",
                    WorkingAreaId = 1
                }
            };

            context.Accommodations.AddRange(accommodations);
        }
        private void InitClients(TrainingDbContext context)
        {
            List<Client> clients = new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Name = "Fran",


                },
                new Client
                {
                    Id = 2,
                    Name = "Test"
                }
            };

            context.Clients.AddRange(clients);
        }
        private void InitSendTypes(TrainingDbContext context)
        {
            List<SendType> sendTypes = new List<SendType>
            {
                new SendType
                {
                    Id = 1,
                    ClientId = 1
                },
                new SendType
                {
                    Id = 2,
                    ClientId = 2
                }
            };

            context.SendTypes.AddRange(sendTypes);
        }
        private void InitBookings(TrainingDbContext context)
        {
            List<Booking> bookings = new List<Booking>
            {
                new Booking
                {
                    Id = 1,
                    ClientId = 1,
                    AccommodationId = 1,
                    SendTypeId = 1,
                    CheckinDate = DateOnly.Parse("2023-7-13"),
                    CheckoutDate = DateOnly.Parse("2023-7-15"),
                    BookingDate = DateOnly.Parse("2023-7-3"),
                    Price = 100
                },
                new Booking
                {
                    Id = 2,
                    ClientId = 2,
                    AccommodationId = 2,
                    SendTypeId = 2,
                    CheckinDate = DateOnly.Parse("2023-8-3"),
                    CheckoutDate = DateOnly.Parse("2023-8-12"),
                    BookingDate = DateOnly.Parse("2023-3-13"),
                    Price = 300
                }
            };

            context.Bookings.AddRange(bookings);
        }
    }
}

