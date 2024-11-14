using BTG_Pactual.Model;
using BTG_Pactual.Repository;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BTG_Pactual.ViewModel
{
    public partial class AddClientViewModel : ObservableObject
    {
        [ObservableProperty]
        string name = string.Empty;

        [ObservableProperty]
        string lastName = string.Empty;

        [ObservableProperty]
        int age;

        [ObservableProperty]
        string address = string.Empty;

        private readonly IClientRepository _repository;
        public AddClientViewModel(IClientRepository repository)
        {
            _repository = repository;
        }

        [RelayCommand]
        public async Task AddClient()
        {
            var newClient = new Client(Name,LastName, Age, Address);

            await _repository.InsertClientAsync(newClient);

            var newtoast = Toast.Make("Cliente Cadastrado Com Sucesso", CommunityToolkit.Maui.Core.ToastDuration.Long);

            await newtoast.Show();

            await Shell.Current.GoToAsync("..");
        }

    }
}
