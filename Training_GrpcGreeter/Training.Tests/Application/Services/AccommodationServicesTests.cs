using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.App;
using Training.App.Application.Services.AccommodationService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Tests.Application.Services
{
    [TestClass]
    public class AccommodationServicesTests
    {
        private IAccommodationService _service;
        private DbContextOptions<TrainingDbContext>? _context;

        private Mock<ILogger<AccommodationService>>? _loggerMock;


        [TestInitialize]
        public void Setup()
        {
            _context = InitContextFixture();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            mappingConfig.CreateMapper();
            _loggerMock = new Mock<ILogger<AccommodationService>>();
            _service = new AccommodationService(_loggerMock.Object, _context);

        }

        [TestMethod]
        public async Task GetAccommodationList_WhenFilteredByAccommodationId()
        {
            var accommodationIds = new List<int>() { 1, 2 };
            var accommodationListRequest = new AccommodationListRequest();
            accommodationListRequest.AccommodationId.AddRange(accommodationIds);

            var accommodationList = new List<AccommodationResponse>
            {
                new AccommodationResponse
                {
                    AccommodationId = 1,
                    Name = "Hotel1",
                    WorkingAreaId = 1,
                },
                new AccommodationResponse
                {
                    AccommodationId = 2,
                    Name = "Hotel2",
                    WorkingAreaId = 1
                }
            };
            AccommodationListResponse expected = new AccommodationListResponse() { Failed = false };
            expected.Accommodations.AddRange(accommodationList);

            AccommodationListResponse result = await _service.GetAccommodationListAsync(accommodationListRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetAccommodationList_WhenFilteredWhitAAccommodationIdNotRegistered()
        {
            var accommodationIds = new List<int>() { 3 };
            var accommodationListRequest = new AccommodationListRequest();
            accommodationListRequest.AccommodationId.AddRange(accommodationIds);

            AccommodationListResponse expected = new AccommodationListResponse() { Failed = false };

            AccommodationListResponse result = await _service.GetAccommodationListAsync(accommodationListRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetAccommodationList_WhenNotFilteredAccommodationId()
        {
            var accommodationListRequest = new AccommodationListRequest();

            AccommodationListResponse expected = new AccommodationListResponse() { Failed = true };
            expected.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });

            AccommodationListResponse result = await _service.GetAccommodationListAsync(accommodationListRequest);

            Assert.AreEqual(expected, result);
        }
        public DbContextOptions<TrainingDbContext> InitContextFixture()
        {
            DbContextOptions<TrainingDbContext> options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase(databaseName: "test").Options;

            using (TrainingDbContext context = new TrainingDbContext(options))
            {
                InitAccommodations(context);
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
    }
}
