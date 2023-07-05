namespace Training.App.Application.Services.AccommodationTemplateService
{
    public interface IAccommodationTemplateService
    {
        Task<AccommodationTemplateListResponse> GetAccommodationTemplateListAsync(AccommodationTemplateListRequest request);
    }
}
