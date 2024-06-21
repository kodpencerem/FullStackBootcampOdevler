namespace Odev1;


public partial class EmailNotifier
{
    public void SendEmail(string message)
    {
    }
}

public partial class SmsNotifier
{
    public void SendSms(string message)
    {
    }
}

public partial class NotificationService
{
    private EmailNotifier _emailNotifier;
    private SmsNotifier _smsNotifier;

    public NotificationService()
    {
        _emailNotifier = new EmailNotifier();
        _smsNotifier = new SmsNotifier();
    }

    public void Notify(string message, string type)
    {
        if (type == "email")
        {
            _emailNotifier.SendEmail(message);
        }
        else if (type == "sms")
        {
            _smsNotifier.SendSms(message);
        }
    }
}


public interface INotifier
{
    void Send(string message);
}

public partial class EmailNotifier : INotifier
{
    public void Send(string message)
    {
    }
}

public partial class SmsNotifier : INotifier
{
    public void Send(string message)
    {
        
    }
}


public class PushNotifier : INotifier
{
    public void Send(string message)
    {
    }
}

public partial class NotificationService
{
    private readonly INotifier _notifier;

    public NotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Notify(string message)
    {
        _notifier.Send(message);
    }
}