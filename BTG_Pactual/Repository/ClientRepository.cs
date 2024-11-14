using BTG_Pactual.Model;
using SQLite;

namespace BTG_Pactual.Repository
{
    public class ClientRepository : IClientRepository
    {
        private SQLiteAsyncConnection _dbConnection;
        public async Task InitializeAsync()
        {
            await SetUpDb();
        }
        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.
                GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3");

                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Client>();
            }
        }
        public async Task<int> DeleteClientAsync(Client client)
        {
            await InitializeAsync();
            return await _dbConnection.DeleteAsync(client);
        }

        public async Task<List<Client>> GetAllClientsAsync()
        {
            await InitializeAsync();
            return await _dbConnection.Table<Client>().ToListAsync();
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            await InitializeAsync();
            return await _dbConnection.Table<Client>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> InsertClientAsync(Client client)
        {
            await InitializeAsync();
            return await _dbConnection.InsertAsync(client);
        }

        public async Task<int> UpdateClientAsync(Client client)
        {
            await InitializeAsync();
            return await _dbConnection.UpdateAsync(client);
        }
    }
}
