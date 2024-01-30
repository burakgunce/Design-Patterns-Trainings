using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SmsNotify : INotify
    {
        public void SendNotification(User user)
        {
            // sms göndderim implemantasyonu
            Console.WriteLine($"GSM : {user.Gsm} için mesaj gönderildi");
        }
    }
}
