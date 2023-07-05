using Training.Infrastucture.DbModels;

namespace Training.Infrastucture.Repository.ClientRepository
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClientAsync(int? clientId, string? name);
    }
}
