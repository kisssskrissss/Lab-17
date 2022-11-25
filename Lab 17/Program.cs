using System;

namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());

            Account<int> account2 = new Account<int>();
            account2.Input();
            Console.WriteLine(account1.GetInfo());
            Console.ReadKey();
        }
    }
}
