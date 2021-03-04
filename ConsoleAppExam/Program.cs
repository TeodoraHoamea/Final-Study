using System;

namespace ConsoleAppExam
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var _account = new SavingsAccount();
            _account.Deposite(600);

            var card = new Card("Nume Random");
            card.AddAccount(_account);
            ATM.instance.Insert(card);
            ATM.instance.SelectAccount(_account);
            ATM.instance.withdraw(400);

           /* Console.WriteLine($"Current Balance is {_account.Balance}");

            try
            {
                _account.withdraw(300);
            }catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Current Balance is {_account.Balance}");*/
        }
    }
}
