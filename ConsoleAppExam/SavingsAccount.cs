using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExam
{
    public class SavingsAccount : Account
    {
        protected override decimal CalculateWithDraw(decimal ammount)
        {
            return ammount * 0.5m / 100m;
        }
    }
}
