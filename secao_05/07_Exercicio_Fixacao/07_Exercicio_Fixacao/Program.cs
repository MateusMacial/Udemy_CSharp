using System;
using System.Globalization;
using _07_Exercicio_Fixacao.Entities;

namespace _07_Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char answer = char.Parse(Console.ReadLine());

            BankAccount bankAccount;

            if(answer == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                bankAccount = new BankAccount(number, holder, initialDeposit);
            }
            else
            {
                bankAccount = new BankAccount(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(bankAccount);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            bankAccount.Deposit(deposit);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(bankAccount);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            bankAccount.Withdraw(withdraw);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(bankAccount);

        }
    }
}
