namespace Odev2;

public class Order
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Order(string productName, int quantity, double price)
    {
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }

    public override string ToString() // string ovveride
    {
        return $"Product: {ProductName}, Quantity: {Quantity}, Price: {Price * Quantity:C}";
    }
}