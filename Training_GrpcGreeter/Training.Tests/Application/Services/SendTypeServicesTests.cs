using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.App;
using Training.App.Application.Services.SendTypeService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Tests.Application.Services
{
    [TestClass]
    public class SendTypeServicesTests
    {
        private ISendTypeService _service;
        private DbContextOptions<TrainingDbContext>? _context;

        private Mock<ILogger<SendTypeService>>? _loggerMock;


        [TestInitialize]
        public void Setup()
        {
            _context = InitContextFixture();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            mappingConfig.CreateMapper();
            _loggerMock = new Mock<ILogger<SendTypeService>>();
            _service = new SendTypeService(_loggerMock.Object, _context);

        }

        [TestMethod]
        public async Task GetSendTypeList_WhenFilteredByAccommodationIdsBookingIdsSendTypeIdsClientIds()
        {
            var sendTypeIds = new List<int>() { 1, 2 };
            var clientIds = new List<int>() { 1, 2 };

            var sendTypeRequest = new SendTypeListRequest();
            sendTypeRequest.SendTypeId.AddRange(sendTypeIds);
            sendTypeRequest.ClientId.AddRange(clientIds);

            var clientSendTypeList = new List<SendTypeResponse>
            {
                new SendTypeResponse
                {
                    SendTypeId = 1,
                    ClientId = 1,
                    TypeMessage = "Test1"
                },
                new SendTypeResponse
                {
                    SendTypeId = 2,
                    ClientId = 2,
                    TypeMessage = "Test2"
                }
            };
            SendTypeListResponse? expected = new SendTypeListResponse() { Failed = false };
            expected.SendTypes.AddRange(clientSendTypeList);

            SendTypeListResponse result = await _service.GetSendTypeListAsync(sendTypeRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetClientSendTypeList_WhenNotFiltered()
        {
            var clientRequest = new SendTypeListRequest();

            SendTypeListResponse expected = new SendTypeListResponse() { Failed = true };
            expected.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });

            SendTypeListResponse result = await _service.GetSendTypeListAsync(clientRequest);

            Assert.AreEqual(expected, result);
        }

        private DbContextOptions<TrainingDbContext> InitContextFixture()
        {
            DbContextOptions<TrainingDbContext> options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase(databaseName: "test7").Options;

            using (TrainingDbContext context = new TrainingDbContext(options))
            {
                InitClients(context);
                InitSendTypes(context);
                context.SaveChanges();
            }

            return options;
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
                    ClientId = 1,
                    Message = "Test1"
                },
                new SendType
                {
                    Id = 2,
                    ClientId = 2,
                    Message = "Test2"
                }
            };

            context.SendTypes.AddRange(sendTypes);
        }
    }
}
