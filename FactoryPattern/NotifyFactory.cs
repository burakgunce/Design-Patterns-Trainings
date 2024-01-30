using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NotifyFactory
    {
        //neye göre neyin instance ını oluşturcağını belirleddiği için factory pattern
        // if bloklarından kurtulmak için ise chain of  responsibility pattern
        public INotify CreateNotify(string notifyType)
        {
            if (notifyType == "SMS")
            {
                return new SmsNotify();
            }
            else if (notifyType == "Email")
            {
                return new MailNotify();
            }
            else if (notifyType == "Push")
            {
                return new PushNotify();
            }
            return null;
        }
    }
}
