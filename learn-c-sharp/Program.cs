using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BackAccount("Jannik", 1000);
            Console.WriteLine($"Account {account.Number} was created {account.Owner} with {account.Balance} initial balance");
            Console.ReadKey();
        }
    }
}