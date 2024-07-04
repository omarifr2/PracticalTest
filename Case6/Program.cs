namespace Case6;

public class PaymentProcessor
{
    public void ProcessPayment(string paymentMethod)
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
        else if (paymentMethod == "BankTransfer")
        {
            // Process bank transfer payment
            Console.WriteLine("Processing bank transfer payment.");
        }
        else
        {
            throw new ArgumentException("Invalid payment method");
        }
    }
}