using Microsoft.EntityFrameworkCore;
using Training.Infrastucture.Context;
using Training.Infrastucture.DbModels;
using Training.Infrastucture.Repository.AccommodationRepository;
using Training.Infrastucture.Repository.BookingRepository;

namespace Training.App.Application.Services.SendMessageService
{
    public class CommunicationService : ICommunicationService
    {
        private readonly ILogger<CommunicationService> _logger;
        private readonly DbContextOptions<TrainingDbContext> _trainingDbOptions;
        private readonly IBookingRepository _bookingRepository;
        private readonly IAccommodationRepository _accommodationRepository;

        public CommunicationService(ILogger<CommunicationService> logger,
        DbContextOptions<TrainingDbContext> trainingDbOptions,
        IBookingRepository bookingRepository,
        IAccommodationRepository accommodationRepository)
        {
            _logger = logger;
            _trainingDbOptions = trainingDbOptions;
            _bookingRepository = bookingRepository;
            _accommodationRepository = accommodationRepository;
        }

        public void SendMessagge(Booking booking)
        {
            try
            {
                var message = CreateMessagge(booking);

                using (var trainingContext = new TrainingDbContext(_trainingDbOptions))
                {
                    var newLog = new Log
                    {
                        AccommodationId = booking.AccommodationId,
                        ClientId = booking.ClientId,
                        SendTypeId = booking.SendTypeId,
                        Message = message,
                    };

                    trainingContext.Add(newLog);
                    trainingContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Not found Working Area in data base");
            }
        }

        public string CreateMessagge(Booking booking)
        {
            var message = string.Empty;
            var bookingData = _bookingRepository.GetBookingById(booking.Id);

            var messageTemplate = GenerateTemplate(bookingData);
            var messageLogitravel = GenerateMessageLogitravel(bookingData.Accommodation.WorkingAreaId);
            message = messageTemplate + ". " + messageLogitravel;

            return message;
        }


        private string GenerateTemplate(Booking booking)
        {
            var templateMessage = string.Empty;
            var clientData = booking.Client;
            var accommodationData = booking.Accommodation;
            var sendTypeData = clientData.SendTypes.First().Message;
            var template = accommodationData.AccommodationTemplates.FirstOrDefault(tmp => tmp.SendTypeId == booking.SendTypeId && tmp.AccommodationId == booking.AccommodationId);

            if (template != null)
            {
                templateMessage = template.Message;

                if (!string.IsNullOrEmpty(templateMessage))
                {
                    var completeName = clientData.Name + " " + clientData.Surname;
                    templateMessage = templateMessage.Replace("send_type", sendTypeData);
                    templateMessage = templateMessage.Replace("Client", completeName);
                    templateMessage = templateMessage.Replace("Accommodation", accommodationData.AccommodationName);
                    return templateMessage;
                }
            }

            return !string.IsNullOrEmpty(templateMessage) ? templateMessage : "Not Created Template by hotel";
        }

        private string GenerateMessageLogitravel(int? accommodationZoneId)
        {
            var messageLogitravel = string.Empty;
            var nameHotelList = _accommodationRepository.GetAccommodationListByZoneId(accommodationZoneId).Select(acc => acc.AccommodationName).ToList();

            if (nameHotelList.Any())
            {
                var nameHotel = String.Join(", ", nameHotelList);
                messageLogitravel = $"Bienvenido a Logitravel, esperamos que disfrute de su estancía. Le recomendamos estos {nameHotel} de la zona. Gracias por confiar en nosotros.";
            }
            return !string.IsNullOrEmpty(messageLogitravel) ? messageLogitravel : "Not Accommodation this zone";
        }
    }
}
