using System;
using System.Globalization;
using Praticando_Classes_06_Increase_Payment.Entities;

namespace Praticando_Classes_06_Increase_Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee func = new Employee();

            Console.Write("Nome: ");
            func.Name = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine();

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
