
using DelegateAssignment;

internal class Program
{

    public static void Main(string[] args)
    {
        // List of customers
        var customers = new List<Client>
        {
            new Client("Amer khaled", "1234567890", "amrkhald144@gmail.com"),
            new Client("mohab ahmed", "9876543210", "mohab@gmail.com"),
            new Client("yousif walid", "4846548646", "yousif@gmail.com")
        };

        // Perform action to print customer details
        Console.WriteLine("Customer Details:");
        Client.PerformActionOnCustomers(customers, Client.PrintClientDetails);

        // Perform action to send welcome email
        Console.WriteLine("\nSending Welcome Emails:");
        Client.PerformActionOnCustomers(customers, Client.SendWelcomeMessage);
    }
}