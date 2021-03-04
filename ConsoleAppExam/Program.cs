using System;

namespace ConsoleAppExam
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var _account = new SavingsAccount();
            _account.Deposite(600);
            Console.WriteLine($"Current Balance is {_account.Balance}");

            try
            {
                _account.withdraw(300);
            }catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Current Balance is {_account.Balance}");
        }
    }
}
