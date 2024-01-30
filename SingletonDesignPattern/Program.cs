namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database firstInstance = Database.GetInstance();
            Database secondInstance = Database.GetInstance();

            bool same = firstInstance == secondInstance;
            Console.WriteLine(same);
            Console.ReadLine();
        }
    }
}