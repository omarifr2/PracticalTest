namespace Case2;

public class PaymentProcessor
{
    public void ProcessPayment(string paymentMethod, double amount)
    {
        if (paymentMethod == "CreditCard")
        {
            // Process credit card payment
            Console.WriteLine("Processing credit card payment.");
        }
        else if (paymentMethod == "PayPal")
        {
            // Process PayPal payment
            Console.WriteLine("Processing PayPal payment.");
        }
    }
}