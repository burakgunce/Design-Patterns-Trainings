namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotifyFactory _factory = new NotifyFactory();

            INotify _notifySms = _factory.CreateNotify("SMS");
            _notifySms.SendNotification(new User { Gsm = "123456789" });

            INotify _notifyMail = _factory.CreateNotify("Email");
            _notifyMail.SendNotification(new User { Email = "john@doe.com" });

            INotify _notifyPush = _factory.CreateNotify("Push");
            _notifyPush.SendNotification(new User { DeviceToken = "6161tsts6161", DeviceId = "616161" });
        }
    }
}