namespace Training.App.Application.Services.ClientService
{
    public interface IClientService
    {
        Task<ClientResponse> GetClientAsync(ClientRequest request);
        Task<ClientListResponse> GetListClientAsync(ClientListRequest request);
    }
}
