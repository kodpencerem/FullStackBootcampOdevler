namespace Odev2;

public class ECommerceSystem
{
    // Event tanımı
    public event OrderProcessedEventHandler? OrderProcessed;

    // Sipariş işleme metodu
    public void ProcessOrder(Order order)
    {
        // Sipariş işleme mantığı (örneğin, veritabanına kaydetme vs.)

        // Event tetikleme
        OnOrderProcessed(order);
    }

    // Event tetikleme metodu
    protected virtual void OnOrderProcessed(Order order)
    {
        if (OrderProcessed != null)
        {
            OrderProcessed(this, new OrderEventArgs(order.ToString()));
        }
    }
}