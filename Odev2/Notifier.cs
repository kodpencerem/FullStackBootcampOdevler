namespace Odev2;

public class EmailNotifier
{
    // Event handler metodu
    public void OnOrderProcessed(object source, OrderEventArgs args)
    {
        Console.WriteLine("Email Bilgi: Siparişiniz alındı. En kısa sürede tarafınıza kargolanacaktır..");
        Console.WriteLine($"Sipariş Detay: {args.OrderDetails}");
    }
}

public class SmsNotifier
{
    // Event handler metodu
    public void OnOrderProcessed(object source, OrderEventArgs args)
    {
        Console.WriteLine("SMS Bilgi: Siparişiniz alındı. En kısa sürede tarafınıza kargolanacaktır..");
        Console.WriteLine($"Sipariş Detay: {args.OrderDetails}");
    }
}