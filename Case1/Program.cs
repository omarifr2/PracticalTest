namespace Case1;

public class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        // Process the order
        Console.WriteLine("Order processed.");

        // Send email confirmation
        SendEmail(order);

        // Generate invoice
        GenerateInvoice(order);
    }

    private void SendEmail(Order order)
    {
        Console.WriteLine("Email sent to customer.");
    }

    private void GenerateInvoice(Order order)
    {
        Console.WriteLine("Invoice generated.");
    }
}

public class Order
{
    public int OrderId { get; set; }
    public string CustomerEmail { get; set; }
    public double OrderAmount { get; set; }
    // Other order-related properties
}