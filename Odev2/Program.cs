

using Odev2;

var order = new Order("Laptop", 1, 1500.00);

var ecommerceSystem = new ECommerceSystem();
var emailNotifier = new EmailNotifier();
var smsNotifier = new SmsNotifier();

// Event abonelikleri
ecommerceSystem.OrderProcessed += emailNotifier.OnOrderProcessed;
ecommerceSystem.OrderProcessed += smsNotifier.OnOrderProcessed;

// Sipariş işleme
ecommerceSystem.ProcessOrder(order);

Console.WriteLine("Çıkış için herhangi bir tuşa basınız...");
Console.ReadKey();