using BTG_Pactual.Model;
using BTG_Pactual.Repository;
using BTG_Pactual.Validators;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;

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
            var client = new Client(Name, LastName, Age, Address);

            var contract = new ClientValidator(client);

            if (!contract.IsValid)
            {
                var messages = contract.Notifications.Select(x => x.Message);

                var sb = new StringBuilder();

                foreach (var message in messages)
                    sb.Append($"{message}\n");

                await Shell.Current.DisplayAlert("Atenção", sb.ToString(), "OK");

                return;
            }


            //Até Aqui
            var newClient = new Client(Name,LastName, Age, Address);

            await _repository.InsertClientAsync(newClient);

            var newtoast = Toast.Make("Cliente Cadastrado Com Sucesso", CommunityToolkit.Maui.Core.ToastDuration.Long);

            await newtoast.Show();

            await Shell.Current.GoToAsync("..");
        }

        //private bool CanExecuteAddClient()
        //{
        //    var client = new Client(Name, LastName,Age,Address);

        //    var contract = new ClientValidator(client);

        //    if (!contract.IsValid)
        //        return false;

        //    return true;
        //}

    }
}
