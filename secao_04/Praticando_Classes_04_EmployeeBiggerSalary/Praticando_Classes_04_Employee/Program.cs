using System;
using System.Globalization;
using Praticando_Classes_04_Employee.Entities;

namespace Praticando_Classes_04_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            emp1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            emp1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            emp2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            emp2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (emp1.Salary + emp2.Salary) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
