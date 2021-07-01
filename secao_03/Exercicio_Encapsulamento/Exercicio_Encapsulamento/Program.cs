using System;
using System.Globalization;

namespace Exercicio_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = Char.Parse(Console.ReadLine());

            Conta c;

            if(resp == 's')
            {
                Console.Write("Deposito inicial: ");
                double Valor = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new Conta(NumeroConta, Titular, Valor);
            }
            else
            {
                c = new Conta(NumeroConta, Titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Valor para deposito: ");
            double Deposito = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(Deposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Valor para saque: ");
            double Saque = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(Saque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

        }
    }
}
