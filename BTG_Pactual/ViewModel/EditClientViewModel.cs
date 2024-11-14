using BTG_Pactual.Model;
using BTG_Pactual.Repository;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BTG_Pactual.ViewModel
{
    [QueryProperty(nameof(Clients), nameof(Clients))]
    public partial class EditClientViewModel : ObservableObject
    {
        private Client _client;

        private readonly IClientRepository _repository;
        public EditClientViewModel(IClientRepository repository)
        {
            _repository = repository;
        }

        public Client Clients
        {
            get => _client;
            set
            {
                SetProperty(ref _client, value);

                if(value is not null)
                {
                    id = value.Id;
                    Name = value.Name;
                    LastName = value.LastName;
                    Age = value.Age;
                    Address = value.Address;
                }
            }
        }

        [ObservableProperty]
        int id;

        [ObservableProperty]
        string name = string.Empty;

        [ObservableProperty]
        string lastName = string.Empty;

        [ObservableProperty]
        int age;

        [ObservableProperty]
        string address = string.Empty;

        [RelayCommand]
        public async Task DeleteClient()
        {
            bool confirmDelete = await Shell.Current.DisplayAlert("", "Gostaria de Excluir o Cliente Selecionado?", "Sim", "Não");

            if(confirmDelete)
            {                
                Client client = new Client(Id,Name, LastName, Age, Address);

                await _repository.DeleteClientAsync(client);

                var newtoast = Toast.Make("Cliente Excluído Com Sucesso", CommunityToolkit.Maui.Core.ToastDuration.Long);

                await newtoast.Show();

                await Shell.Current.GoToAsync("..");
            }
        }

        [RelayCommand]
        public async Task UpdateClient()
        {

            Client client = new Client(id,Name, LastName, Age, Address);

            await _repository.InitializeAsync();

            await _repository.UpdateClientAsync(client);

            var newtoast = Toast.Make("Cliente Atualizado Com Sucesso", CommunityToolkit.Maui.Core.ToastDuration.Long);

            await newtoast.Show();

            await Shell.Current.GoToAsync("..");

        }
            
    }
}
