using Microsoft.EntityFrameworkCore;
using Training.Infrastucture.Context;

namespace Training.Infrastucture.Repository.ClientRepository
{
    public class ClientRepository
    {
        readonly DbContextOptions<TrainingDbContext> _context;

        public ClientRepository(DbContextOptions<TrainingDbContext> context)
        {
            _context = context;
        }

        //public static async Task<IEnumerable<Client>> GetClientAsync(int? clientId, string? name)
        //{
        //    var trainingClientsList = Enumerable.Empty<Client>();


        //    using (var trainingContext = new TrainingDbContext())
        //    {
        //        trainingClientsList = await trainingContext.Clients
        //            .Where(x => x.Id == clientId).ToListAsync();
        //    }
        //    return trainingClientsList;
        //}
    }
}
