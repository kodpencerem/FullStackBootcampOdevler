// See https://aka.ms/new-console-template for more information

using Odev1;


INotifier emailNotifier = new EmailNotifier();
NotificationService emailService = new NotificationService(emailNotifier);
emailService.Notify("Bu bir mail bildirimi.");

INotifier smsNotifier = new SmsNotifier();
NotificationService smsService = new NotificationService(smsNotifier);
smsService.Notify("Bu bir sms bildirimi.");

INotifier pushNotifier = new PushNotifier();
NotificationService pushService = new NotificationService(pushNotifier);
pushService.Notify("Bu bir push bildirimidir.");
