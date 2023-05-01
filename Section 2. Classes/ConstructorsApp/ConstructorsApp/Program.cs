namespace ConstructorsApp;

public class Program
{
    static void Main()
    {
        Customer customer1 = new(1, "Philip");
        Console.WriteLine(customer1.Id);
        Console.WriteLine(customer1.Name);

        var customer2 = new Customer();
        customer2.Id = 2;
        customer2.Name = "Luke";
        Console.WriteLine($"Customer ID: {customer2.Id} - Customer Name: {customer2.Name}");

        var order = new Order();
        customer1.Orders.Add(order);

        

    }
}