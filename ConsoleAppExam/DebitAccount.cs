using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExam
{
    public class DebitAccount : Account
    {
        protected override decimal CalculateWithDraw(decimal ammount)
        {
            return 0m;
        }
    }
}
