using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Heranca.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
        }

    }
}
