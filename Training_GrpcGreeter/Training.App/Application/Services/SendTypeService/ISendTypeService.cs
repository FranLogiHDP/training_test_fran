namespace Training.App.Application.Services.SendTypeService
{
    public interface ISendTypeService
    {
        Task<SendTypeListResponse> GetSendTypeListAsync(SendTypeListRequest request);
    }
}
