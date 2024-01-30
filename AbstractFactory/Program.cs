namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomDatabaseOperations _dbSql = new CustomDatabaseOperations(new MSSQLDatabaseFactory());
            _dbSql.GetAll();
            _dbSql.GetById(1);
            _dbSql.RemoveById(2);

            Console.WriteLine("Oracle");

            CustomDatabaseOperations _dbOracle = new CustomDatabaseOperations(new OracleDatabaseFactory());
            _dbOracle.GetAll();
            _dbOracle.GetById(1);
            _dbOracle.RemoveById(2);
        }
    }
}