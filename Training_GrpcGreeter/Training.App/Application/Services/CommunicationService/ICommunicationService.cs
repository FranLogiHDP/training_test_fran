using Training.Infrastucture.DbModels;

namespace Training.App.Application.Services.SendMessageService
{
    public interface ICommunicationService
    {
        public void SendMessagge(Booking booking);
        string CreateMessagge(Booking booking);
    }
}
