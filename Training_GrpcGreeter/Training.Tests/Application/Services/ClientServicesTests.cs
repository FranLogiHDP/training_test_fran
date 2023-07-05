using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.App;
using Training.App.Application.Services.ClientService;
using Training.App.Utils;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;

namespace Training.Tests.Application.Services
{
    [TestClass]
    public class ClientServicesTest
    {
        private IClientService _service;
        private DbContextOptions<TrainingDbContext>? _context;

        private Mock<ILogger<ClientService>>? _loggerMock;


        [TestInitialize]
        public void Setup()
        {
            _context = InitContextFixture();
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            mappingConfig.CreateMapper();
            _loggerMock = new Mock<ILogger<ClientService>>();
            _service = new ClientService(_loggerMock.Object, _context);

        }

        [TestMethod]
        public async Task GetClientList_WhenFilteredByAccommodationIdsBookingIdsSendTypeIdsClientIds()
        {
            var clientIds = new List<int>() { 1, 2 };
            var doctumetationList = new List<string>() { "1111111X", "2222222Y" };

            var clientRequest = new ClientListRequest();
            clientRequest.ClientIds.AddRange(clientIds);
            clientRequest.DocumentationNumber.AddRange(doctumetationList);

            var clientSendTypeList = new List<ClientResponse>
            {
                new ClientResponse
                {
                    ClientId = 1,
                    Name = "Fran Test1",
                    DocumentationNumber = "1111111X",
                    Phone = "",
                    Email = ""

                },
                new ClientResponse
                {
                    ClientId = 2,
                    Name = "Mitchell Test2",
                    DocumentationNumber = "2222222Y",
                    Phone = "",
                    Email = ""
                }
            };
            ClientListResponse expected = new ClientListResponse() { Failed = false };
            expected.Clients.AddRange(clientSendTypeList);

            ClientListResponse result = await _service.GetListClientAsync(clientRequest);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetClientList_WhenNotFiltered()
        {
            var clientRequest = new ClientListRequest();

            ClientListResponse expected = new ClientListResponse() { Failed = true };
            expected.ApplicationErrors.Add(new ApplicationError { Code = "204", Description = "Null or empty data request" });

            ClientListResponse result = await _service.GetListClientAsync(clientRequest);

            Assert.AreEqual(expected, result);
        }

        private DbContextOptions<TrainingDbContext> InitContextFixture()
        {
            DbContextOptions<TrainingDbContext> options = new DbContextOptionsBuilder<TrainingDbContext>().UseInMemoryDatabase(databaseName: "test5").Options;

            using (TrainingDbContext context = new TrainingDbContext(options))
            {
                InitClients(context);
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
                    Surname = "Test1",
                    NumDocument = "1111111X",
                    Phone = "",
                    Email = ""


                },
                new Client
                {
                    Id = 2,
                    Name = "Mitchell",
                    Surname = "Test2",
                    NumDocument = "2222222Y",
                    Phone = "",
                    Email = ""
                }
            };

            context.Clients.AddRange(clients);
        }
    }
}
