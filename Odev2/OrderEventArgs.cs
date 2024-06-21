namespace Odev2;


// Delegate tanımı
public delegate void OrderProcessedEventHandler(object source, OrderEventArgs args);

// EventArgs türevi ile event verilerini tutmak için sınıf
public class OrderEventArgs : EventArgs
{
    public string OrderDetails { get; set; }
    public OrderEventArgs(string orderDetails)
    {
        OrderDetails = orderDetails;
    }
}