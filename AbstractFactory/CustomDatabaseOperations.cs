using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CustomDatabaseOperations
    {
        IDatabaseFactory databaseFactory;
        Connection connection;
        Command command;

        public CustomDatabaseOperations(IDatabaseFactory _databaseFactory )
        {
            databaseFactory = _databaseFactory;
            connection = databaseFactory.CreateConnection();
            command = databaseFactory.CreateCommand();
        }

        public void RemoveById(int id)
        {
            connection.OpenConnection();
            command.ExecuteCommand("delete user where user ıd = "+ id);
            connection.CloseConnection();
            Console.WriteLine($"delete user with ıd --- type : {databaseFactory.GetType()}");
        }

        public void GetById(int id)
        {
            connection.OpenConnection();
            command.ExecuteCommand("selec user ....." +  id);
            connection.CloseConnection();
            Console.WriteLine($"get user with ıd --- type : {databaseFactory.GetType()}");
        }

        public void GetAll()
        {
            connection.OpenConnection();
            command.ExecuteCommand("select * from users");
            connection.CloseConnection();
            Console.WriteLine($"get all user data - type : {databaseFactory.GetType()}");
        }

        

    }
}
