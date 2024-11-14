using BTG_Pactual.Model;
using BTG_Pactual.Repository;
using BTG_Pactual.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BTG_Pactual.ViewModel
{
    public partial class FirstViewModel : ObservableObject
    {
        public ObservableCollection<Client> Clients { get; set; } = new ObservableCollection<Client>();      

        private readonly IClientRepository _repository;
        public FirstViewModel(IClientRepository repository)
        {
            _repository = repository;

            GetAllClients();
        }


        [RelayCommand]
        public void GoToAddClientView()
        {
            Shell.Current.GoToAsync(nameof(AddClientView));
        }

        [RelayCommand]
        public async Task UpdateScreen()
        {
            Clients.Clear();

            await GetAllClients();
        }

        public async Task GetAllClients()
        {
            await _repository.InitializeAsync();

            List<Client> allClients = await _repository.GetAllClientsAsync();

            foreach (var client in allClients)
            {
                Client oldclient = new Client(client.Id,client.Name, client.LastName, client.Age, client.Address);              

                Clients.Add(oldclient);
            }

           
        }
       

        [RelayCommand]
        public void GoToEditClientView(Client client)
        {
            if (client is null)
                return;

            var navigationParams = new Dictionary<string, object>
            {
                {"Clients", client }
            };

            Shell.Current.GoToAsync(nameof(EditClientView),navigationParams);
        }

    }
}
