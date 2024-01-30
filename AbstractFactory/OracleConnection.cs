using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class OracleConnection : Connection
    {
        public override bool CloseConnection()
        {
            // business logic codes
            return true;
        }

        public override bool OpenConnection()
        {
            // business logic codes
            return true;
        }
    }
}
