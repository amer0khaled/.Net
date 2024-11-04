namespace DelegateAssignment;


public class Client
{
    
    public Client(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public static void PerformActionOnCustomers(List<Client> clients, Action<Client> action)
    {
        foreach (var client in clients)
        {
            action(client);
        }
    }

    public static void PrintClientDetails(Client client)
    {
        Console.WriteLine($"Name: {client.Name}, Email: {client.Email}, Phone: {client.Phone}");
    }

    public static void SendWelcomeMessage(Client client)
    {
        Console.WriteLine($"Welcome to {client.Name}");
    }
    
    
}