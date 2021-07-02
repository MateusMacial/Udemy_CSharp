using System;
using System.Globalization;
using System.Collections.Generic;
using Heranca_Polimorfismo.Entities;

namespace Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Employee #"+ (i+1) +" data: ");

                Console.Write("Outsourced (y/n)? ");
                char answer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(answer == 'n')
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }          
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
