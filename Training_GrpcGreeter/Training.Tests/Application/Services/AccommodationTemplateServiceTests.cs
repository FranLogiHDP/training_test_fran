using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.App;
using Training.App.Application.Services.AccommodationTemplateService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Tests.Application.Services
{
    [TestClass]
    public class AccommodationTemplateServiceTests
    {
        private IAccommodationTemplateService _service;
        private DbContextOptions<TrainingDbContext>? _context;

        private Mock<ILogger<AccommodationTemplateService>>? _loggerMock;


        [TestInitialize]
        public void Setup()
        {
            _context = InitContextFixture();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            mappingConfig.CreateMapper();
            _loggerMock = new Mock<ILogger<AccommodationTemplateService>>();
            _service = new AccommodationTemplateService(_loggerMock.Object, _context);

        }

        [TestMethod]
        public async Task GetLisAccommodationTemplate_WhenFilteredByAccommodationIds()
        {
            var accommodationIds = new List<int>() { 1, 2 };
            var accommodationTemplateListRequest = new AccommodationTemplateListRequest();
            accommodationTemplateListRequest.AccommodationId.AddRange(accommodationIds);

            var accommodationTemplateList = new List<AccommodationTemplateResponse>
            {
                new AccommodationTemplateResponse
                {
                    AccommodationTemplateId = 1,
                    AccommodationId = 1,
                    Name = "Welcome hotel test",
                },
                new AccommodationTemplateResponse
                {
                    AccommodationTemplateId = 2,
                    AccommodationId = 2,
                    Name = "Welcome hotel2 test2",
                }
            };
            AccommodationTemplateListResponse expected = new AccommodationTemplateListResponse() { Failed = false };
            expected.AccommodationTemplates.AddRange(accommodationTemplateList);

            AccommodationTemplateListResponse result = await _service.GetAccommodationTemplateListAsync(accommodationTemplateListRequest);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public async Task GetLisAccommodationTemplate_WhenFilteredByAccommodationTemplatesIdsAndAccommodationIds()
        {
            var accommodationTemplateIds = new List<int>() { 1, 2 };
            var accommodationIds = new List<int>() { 1, 2 };
            var accommodationTemplateListRequest = new AccommodationTemplateListRequest();
            accommodationTemplateListRequest.AccommodationTemplateId.AddRange(accommodationTemplateIds);
            accommodationTemplateListRequest.AccommodationId.AddRange(accommodationIds);

            var accommodationTemplateList = new List<AccommodationTemplateResponse>
            {
                new AccommodationTemplateResponse
                {
                    AccommodationTemplateId = 1,
                    AccommodationId = 1,
                    Name = "Welcome hotel test",
                },
                new AccommodationTemplateResponse
                {
                    AccommodationTemplateId = 2,
                    AccommodationId = 2,
                    Name = "Welcome hotel2 test2",
                }
            };
            AccommodationTemplateListResponse expected = new AccommodationTemplateListResponse() { Failed = false };
            expected.AccommodationTemplates.AddRange(accommodationTemplateList);

            AccommodationTemplateListResponse result = await _service.GetAccommodationTemplateListAsync(accommodationTemplateListRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetLisAccommodationTemplate_WhenFilteredByAccommodationTemplateIds()
        {
            var accommodationTemplateIds = new List<int>() { 1, 2 };
            var accommodationTemplateListRequest = new AccommodationTemplateListRequest();
            accommodationTemplateListRequest.AccommodationTemplateId.AddRange(accommodationTemplateIds);

            var accommodationTemplateList = new List<AccommodationTemplateResponse>
            {
                new AccommodationTemplateResponse
                {
                    AccommodationTemplateId = 1,
                    AccommodationId = 1,
                    Name = "Welcome hotel test",
                },
                new AccommodationTemplateResponse
                {
                    AccommodationTemplateId = 2,
                    AccommodationId = 2,
                    Name = "Welcome hotel2 test2",
                }
            };
            AccommodationTemplateListResponse expected = new AccommodationTemplateListResponse() { Failed = false };
            expected.AccommodationTemplates.AddRange(accommodationTemplateList);

            AccommodationTemplateListResponse result = await _service.GetAccommodationTemplateListAsync(accommodationTemplateListRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetLisAccommodationTemplate_WhenNotFilteredAccommodationIdsAndAccommodationTemplatesIds()
        {
            var accommodationTemplateListRequest = new AccommodationTemplateListRequest();

            AccommodationTemplateListResponse expected = new AccommodationTemplateListResponse() { Failed = true };
            expected.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });

            AccommodationTemplateListResponse result = await _service.GetAccommodationTemplateListAsync(accommodationTemplateListRequest);

            Assert.AreEqual(expected, result);
        }

        private DbContextOptions<TrainingDbContext> InitContextFixture()
        {
            DbContextOptions<TrainingDbContext> options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase(databaseName: "test2").Options;

            using (TrainingDbContext context = new TrainingDbContext(options))
            {
                InitAccommodations(context);
                InitAccommodationTemplates(context);
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
        private void InitAccommodationTemplates(TrainingDbContext context)
        {
            List<AccommodationTemplate> accommodationTemplates = new List<AccommodationTemplate>
            {
                new AccommodationTemplate
                {
                    Id = 1,
                    AccommodationId = 1,
                    Message = "Welcome hotel test",
                    SendTypeId = 1,
                },
                new AccommodationTemplate
                {
                    Id = 2,
                    AccommodationId = 2,
                    Message = "Welcome hotel2 test2",
                    SendTypeId = 2,
                }
            };

            context.AccommodationTemplates.AddRange(accommodationTemplates);
        }
    }
}
