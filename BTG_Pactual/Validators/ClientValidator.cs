using BTG_Pactual.Model;
using Flunt.Validations;

namespace BTG_Pactual.Validators
{
    public class ClientValidator : Contract<Client>
    {
        public ClientValidator(Client client)
        {
            Requires()
                .IsNotNullOrEmpty(client.Name, nameof(client.Name), "Usuário Deve Ser Preenchido")
                .IsNotNullOrEmpty(client.LastName, nameof(client.LastName), "Último Nome Deve Ser Preenchido")
                .IsGreaterThan(client.Age, 0, nameof(client.Age), "Idade Não Pode Ser Menor que 1 ano")
                .IsNotNullOrEmpty(client.Address, nameof(client.Address), "Endereço Deve Ser Preenchido");

        }
    }
}
