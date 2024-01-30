using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MSSQLCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            //sql server için query çalıştırılacak implmentasyon
        }
    }
}
