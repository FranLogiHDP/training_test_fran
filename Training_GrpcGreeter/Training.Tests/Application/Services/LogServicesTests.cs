using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.App;
using Training.App.Application.Services.LogService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Tests.Application.Services
{
    [TestClass]
    public class LogServicesTests
    {
        private ILogService _service;
        private DbContextOptions<TrainingDbContext>? _context;

        private Mock<ILogger<LogService>>? _loggerMock;


        [TestInitialize]
        public void Setup()
        {
            _context = InitContextFixture();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            mappingConfig.CreateMapper();
            _loggerMock = new Mock<ILogger<LogService>>();
            _service = new LogService(_loggerMock.Object, _context);

        }

        [TestMethod]
        public async Task GetLogList_WhenFilteredByAccommodationIdsBookingIdsSendTypeIdsClientIds()
        {
            var clientIds = new List<int>() { 1, 2 };
            var logsIds = new List<int>() { 1, 2 };
            var sendTypeIds = new List<int>() { 1, 2 };
            var accommodationIds = new List<int>() { 1, 2 };

            var logRequest = new LogListRequest();
            logRequest.ClientId.AddRange(clientIds);
            logRequest.LogId.AddRange(logsIds);
            logRequest.SendTypeId.AddRange(sendTypeIds);
            logRequest.AccommodationId.AddRange(accommodationIds);

            var logList = new List<LogResponse>
            {
                new LogResponse
                {
                    LogId = 1,
                    ClientId = 1,
                    AccommodationId = 1,
                    SendTypeId = 1,
                    Message = "Test Test"
                },
                new LogResponse
                {
                    LogId = 2,
                    ClientId = 2,
                    AccommodationId = 2,
                    SendTypeId = 2,
                    Message = "Test2 Test2"
                }
            };
            LogListResponse expected = new LogListResponse() { Failed = false };
            expected.Logs.AddRange(logList);

            LogListResponse result = await _service.GetLogListAsync(logRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetLogList_WhenNotFiltered()
        {
            var logRequest = new LogListRequest();

            LogListResponse expected = new LogListResponse() { Failed = true };
            expected.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });

            LogListResponse result = await _service.GetLogListAsync(logRequest);

            Assert.AreEqual(expected, result);
        }

        private DbContextOptions<TrainingDbContext> InitContextFixture()
        {
            DbContextOptions<TrainingDbContext> options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase(databaseName: "test6").Options;

            using (TrainingDbContext context = new TrainingDbContext(options))
            {
                InitLogs(context);
                InitClients(context);
                InitAccommodations(context);
                InitSendTypes(context);

                context.SaveChanges();
            }

            return options;
        }
        private void InitLogs(TrainingDbContext context)
        {
            List<Log> clients = new List<Log>
            {
                new Log
                {
                    Id = 1,
                    AccommodationId = 1,
                    ClientId = 1,
                    SendTypeId = 1,
                    Message = "Test Test"
                },
                new Log
                {
                    Id = 2,
                    AccommodationId = 2,
                    ClientId = 2,
                    SendTypeId = 2,
                    Message = "Test2 Test2"

                }
            };

            context.Logs.AddRange(clients);
        }
        private void InitClients(TrainingDbContext context)
        {
            List<Client> clients = new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Name = "Fran"
                },
                new Client
                {
                    Id = 2,
                    Name = "Mitchell"
                }
            };

            context.Clients.AddRange(clients);
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
    }
}
