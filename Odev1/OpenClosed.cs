namespace Odev1;

public partial class PaymentProcessor
{
    public void ProcessCreditCardPayment(double amount)
    {
        
    }

    public void ProcessPayPalPayment(double amount)
    {
       
    }
}

public abstract class PaymentMethod
{
    public abstract void ProcessPayment(double amount);
}

public class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(double amount)
    {
    }
}

public class PayPalPayment : PaymentMethod
{
    public override void ProcessPayment(double amount)
    {
    }
}

public partial class PaymentProcessor
{
    public void ProcessPayment(PaymentMethod paymentMethod, double amount)
    {
        paymentMethod.ProcessPayment(amount);
    }
}

public class BitcoinPayment : PaymentMethod
{
    public override void ProcessPayment(double amount)
    {
    }
}
