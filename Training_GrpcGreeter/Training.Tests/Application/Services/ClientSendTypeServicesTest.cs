using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.App;
using Training.App.Application.Services.ClientSendTypeService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Tests.Application.Services
{
    [TestClass]
    public class ClientSendTypeServicesTest
    {
        private IClientSendTypeService _service;
        private DbContextOptions<TrainingDbContext>? _context;

        private Mock<ILogger<ClientSendTypeService>>? _loggerMock;


        [TestInitialize]
        public void Setup()
        {
            _context = InitContextFixture();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            mappingConfig.CreateMapper();
            _loggerMock = new Mock<ILogger<ClientSendTypeService>>();
            _service = new ClientSendTypeService(_loggerMock.Object, _context);

        }

        [TestMethod]
        public async Task GetClientSendTypeList_WhenFilteredByAccommodationIdsBookingIdsSendTypeIdsClientIds()
        {
            var sendTypeIds = new List<int>() { 1, 2 };
            var clientIds = new List<int>() { 1, 2 };

            var clientRequest = new ClientSendTypeListRequest();
            clientRequest.SendTypeId.AddRange(sendTypeIds);
            clientRequest.ClientId.AddRange(clientIds);

            var clientSendTypeList = new List<ClientSendTypeResponse>
            {
                new ClientSendTypeResponse
                {
                    ClientSendTypeId = 1,
                    SendTypeId = 1,
                    ClientId = 1
                },
                new ClientSendTypeResponse
                {
                    ClientSendTypeId = 2,
                    SendTypeId = 2,
                    ClientId = 2
                }
            };
            ClientSendTypeListResponse expected = new ClientSendTypeListResponse() { Failed = false };
            expected.ClientSendTypes.AddRange(clientSendTypeList);

            ClientSendTypeListResponse result = await _service.GetClientSendTypeListAsync(clientRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetClientSendTypeList_WhenNotFiltered()
        {
            var clientRequest = new ClientSendTypeListRequest();

            ClientSendTypeListResponse expected = new ClientSendTypeListResponse() { Failed = true };
            expected.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });

            ClientSendTypeListResponse result = await _service.GetClientSendTypeListAsync(clientRequest);

            Assert.AreEqual(expected, result);
        }

        private DbContextOptions<TrainingDbContext> InitContextFixture()
        {
            DbContextOptions<TrainingDbContext> options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase(databaseName: "test4").Options;

            using (TrainingDbContext context = new TrainingDbContext(options))
            {
                InitAccommodations(context);
                InitClients(context);
                InitSendTypes(context);
                InitClientSendTypes(context);
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
        private void InitClientSendTypes(TrainingDbContext context)
        {
            List<ClientSendType> bookings = new List<ClientSendType>
            {
                new ClientSendType
                {
                 Id = 1,
                 ClientId = 1,
                 SendTypeId = 1
                },
                new ClientSendType
                {
                    Id = 2,
                    ClientId = 2,
                    SendTypeId = 2
                }
            };

            context.ClientSendTypes.AddRange(bookings);
        }
    }
}
