using SQLite;

namespace BTG_Pactual.Model
{
    [Table("Client")]
    public class Client
    {
        public Client(int id,string name, string lastName, int age, string address)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
            Address = address;
        }

        public Client(string name, string lastName, int age, string address)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Address = address;
        }

        public Client()
        {
            
        }

        [PrimaryKey,AutoIncrement]
        [Column("client_id")]
        public int Id { get; set; }

        [NotNull, MaxLength(100)]
        [Column("cliente_name")]
        public string Name { get; set; } 

        [NotNull, MaxLength(100)]
        [Column("client_lastname")]
        public string? LastName { get; set; }

        [Column("age")]
        public int Age { get; set; }

        [Column("client_address")]
        public string Address { get; set; }
    }
}
