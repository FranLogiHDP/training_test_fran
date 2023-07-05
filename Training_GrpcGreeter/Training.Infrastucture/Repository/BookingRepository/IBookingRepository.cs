using Training.Infrastucture.DbModels;

namespace Training.Infrastucture.Repository.BookingRepository
{
    public interface IBookingRepository
    {
        Booking GetBookingById(int bookingId);
    }
}
