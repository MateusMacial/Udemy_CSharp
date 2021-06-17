using System;
using System.Globalization;

namespace Exercicio_Entrada_Dados_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yoy full name: ");
            string name = Console.ReadLine();
            Console.WriteLine("How many rooms you have in home? ");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a product price: ");
            double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter your last name, age and height (same line): ");
            string[] line = Console.ReadLine().Split(' ');

            string lastName = line[0];
            int lineAge = int.Parse(line[1]);
            double lineHeight = double.Parse(line[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("SAIDA: ");

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Rooms at home: " + rooms);
            Console.WriteLine("Product price: " + prodPrice.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Last name (of the line): " + lastName);
            Console.WriteLine("Age (of the line): " + lineAge);
            Console.WriteLine("Height (of the line): " + lineHeight.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
