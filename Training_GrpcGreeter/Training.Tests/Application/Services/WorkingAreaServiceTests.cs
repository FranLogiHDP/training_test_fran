using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.App;
using Training.App.Application.Services.WorkingAreaService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Tests.Application.Services
{
    [TestClass]
    public class WorkingAreaServicesTests
    {
        private IWorkingAreaService _service;
        private DbContextOptions<TrainingDbContext>? _context;

        private Mock<ILogger<WorkingAreaService>>? _loggerMock;


        [TestInitialize]
        public void Setup()
        {
            _context = InitContextFixture();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            mappingConfig.CreateMapper();
            _loggerMock = new Mock<ILogger<WorkingAreaService>>();
            _service = new WorkingAreaService(_loggerMock.Object, _context);
        }

        [TestMethod]
        public async Task GetClientSendTypeList_WhenFilteredBySendTypeIds()
        {
            var sendTypeIds = new List<int>() { 1, 2 };

            var clientRequest = new WorkingAreaListRequest();
            clientRequest.WorkingAreaId.AddRange(sendTypeIds);

            var clientSendTypeList = new List<WorkingAreaResponse>
            {
                new WorkingAreaResponse
                {
                    WorkingAreaId = 1,
                    Zone = "Balearic"
                },
                new WorkingAreaResponse
                {
                    WorkingAreaId = 2,
                    Zone = "Italia"
                }
            };
            WorkingAreaListResponse expected = new WorkingAreaListResponse() { Failed = false };
            expected.WorkingAreas.AddRange(clientSendTypeList);

            WorkingAreaListResponse result = await _service.GetWorkingAreaListAsync(clientRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetWorkingAreaList_WhenNotFiltered()
        {
            var workingAreaRequest = new WorkingAreaListRequest();

            WorkingAreaListResponse expected = new WorkingAreaListResponse() { Failed = true };
            expected.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });

            WorkingAreaListResponse result = await _service.GetWorkingAreaListAsync(workingAreaRequest);

            Assert.AreEqual(expected, result);
        }

        private DbContextOptions<TrainingDbContext> InitContextFixture()
        {
            DbContextOptions<TrainingDbContext> options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase(databaseName: "test8").Options;

            using (TrainingDbContext context = new TrainingDbContext(options))
            {
                InitWorkingAreas(context);
                context.SaveChanges();
            }

            return options;
        }
        private void InitWorkingAreas(TrainingDbContext context)
        {
            List<WorkingArea> workingAreas = new List<WorkingArea>
            {
                new WorkingArea
                {
                    Id = 1,
                    Zone = "Balearic",


                },
                new WorkingArea
                {
                    Id = 2,
                    Zone = "Italia"
                }
            };

            context.WorkingAreas.AddRange(workingAreas);
        }
    }
}
