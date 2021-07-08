using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using _10_Exercicio_Proposto.Entities;

namespace _10_Exercicio_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double searchSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            List<Employee> list = new List<Employee>();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }
                }

                var emailSearch = list.Where(x => x.Salary > searchSalary).Select(x => x.Email);
                Console.WriteLine("Email of people whose salary is more than " + searchSalary.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();
                foreach(string str in emailSearch)
                {
                    Console.WriteLine(str);
                }

                Console.WriteLine();
                var sum = list.Where(x => x.Name[0] == 'M').Select(x => x.Salary).Sum();
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum);
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
