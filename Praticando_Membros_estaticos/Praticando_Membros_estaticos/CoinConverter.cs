using System;
using System.Collections.Generic;
using System.Text;

namespace Praticando_Membros_estaticos
{
    class CoinConverter
    {
        public static double Iof = 0.06;
        
        public static double Converter(double dollarQuotation, double value)
        {
            double total;
            total = value * dollarQuotation;
            return total += (total * Iof);
        }
    }
}
