using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExam
{
    public class Card
    {   



        public Card(string cardHolder)
        {
            Holder = cardHolder;
            Accounts = new List<Account>();
        }

        public string Holder { get; private set; }

        public IEnumerable<Account> Accounts { get; private set; }

        internal void AddAccount(SavingsAccount _account)
        {
            (Accounts as List<Account>).Add(_account);
        }
    }
}
