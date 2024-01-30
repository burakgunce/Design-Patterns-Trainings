using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class OracleCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            // oracle için query çalıştıracak implementasyon
        }
    }
}
