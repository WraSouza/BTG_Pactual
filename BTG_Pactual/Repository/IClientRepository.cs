using BTG_Pactual.Model;

namespace BTG_Pactual.Repository
{
    public interface IClientRepository
    {
        Task InitializeAsync();
        Task<List<Client>> GetAllClientsAsync();
        Task<Client> GetClientByIdAsync(int id);
        Task<int> InsertClientAsync(Client client);
        Task<int> UpdateClientAsync(Client client);
        Task<int> DeleteClientAsync(Client client);
    }
}
