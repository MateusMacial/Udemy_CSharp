using System;
using System.Globalization;

namespace Praticando_Membros_estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the dollar quotation: ");
            double dollarQuotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter the value to trade: ");
            double valueToTrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = CoinConverter.Converter(dollarQuotation, valueToTrade);

            Console.WriteLine("Value to pay: " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
