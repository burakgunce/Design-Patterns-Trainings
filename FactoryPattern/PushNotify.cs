using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PushNotify : INotify
    {
        public void SendNotification(User user)
        {
            // onesignal ya dad native ios, android kütüphaneler kullanılarak push message gönderilecek implemantasyon
            Console.WriteLine($"Push Message : {user.DeviceToken} - {user.DeviceId} gönderildi");
        }
    }
}
