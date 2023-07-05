namespace Training.App.Application.Services.ClientSendTypeService
{
    public interface IClientSendTypeService
    {
        Task<ClientSendTypeListResponse> GetClientSendTypeListAsync(ClientSendTypeListRequest request);
    }
}
