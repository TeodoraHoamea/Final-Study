using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExam
{
    class TestAccount : IAccount
    {
        public decimal Balance { get; private set; }

        public void Deposite(decimal ammount) { }



        public decimal withdraw(decimal ammount)
        {
            return 0m;
        }
    }
}
