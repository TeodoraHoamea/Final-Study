using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExam
{
    public abstract class Account
    {
        public decimal Balance { get; private set; }

        public void Deposite(decimal ammount)
        {
            this.Balance += ammount;
        }

        public decimal withdraw(decimal ammount)
        {
            var fee = CalculateWithDraw(ammount);
            ammount = ammount + fee;
            if(Balance < ammount)
            {
                throw new InvalidOperationException("Insufficient funds!!! ");
            }
            else
            {
                this.Balance -= ammount;
            }
            return ammount;
        }

        protected abstract decimal CalculateWithDraw(decimal ammount);
    }
}
