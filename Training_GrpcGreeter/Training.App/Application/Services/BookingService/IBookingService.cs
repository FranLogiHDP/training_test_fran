namespace Training.App.Application.Services.BookingService
{
    public interface IBookingService
    {
        Task<BookingListResponse> GetBookingListAsync(BookingListRequest request);
        Task<BookingUpsertResponse> UpsertBookingAsync(BookingUpsertRequest request);
        Task<BookingUpsertResponse> CreateBookingAsync(BookingResponse request);
        Task<BookingUpsertResponse> UpdateBookingAsync(BookingResponse request);
    }
}
