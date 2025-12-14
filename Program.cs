
using OOPinCsharp;

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer(1, "Test Navn", "test@email.com");
        Console.WriteLine($"Customer: {customer.Name}, {customer.Email}");

        
    }
}
