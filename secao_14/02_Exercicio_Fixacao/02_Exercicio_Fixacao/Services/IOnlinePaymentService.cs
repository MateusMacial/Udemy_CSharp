using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Exercicio_Fixacao.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
