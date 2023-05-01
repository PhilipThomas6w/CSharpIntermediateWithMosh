namespace Testability;



public class Program
{
    static void Main()
    {
        var orderProcessor = new OrderProcessor();
        var order = new OrderProcessor {DatePlaced = DateTime.Now, TotalPrice = 100f};
        orderProcessor.Process(order);

    }
}