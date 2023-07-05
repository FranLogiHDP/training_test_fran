namespace Training.App.Application.Services.AccommodationService
{
    public interface IAccommodationService
    {
        Task<AccommodationListResponse> GetAccommodationListAsync(AccommodationListRequest request);
    }
}
