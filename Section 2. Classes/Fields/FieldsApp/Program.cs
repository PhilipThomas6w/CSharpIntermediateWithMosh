namespace FieldsApp;

public class Program
{
    static void Main()
    {
        Customer customer = new Customer(1);
        customer.Orders.Add(new Order());
        customer.Orders.Add(new Order());

        customer.Promote();

    }
}