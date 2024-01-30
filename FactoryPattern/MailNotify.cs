using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MailNotify : INotify
    {
        public void SendNotification(User user)
        {
            // mail gönderme implementasyonu
            // SMTP, POP3, SendGrid
            Console.WriteLine($"Email : {user.Email} adresine mail gönderildi");
        }
    }
}
