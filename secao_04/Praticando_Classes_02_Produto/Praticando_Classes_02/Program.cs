using System;
using System.Globalization;

namespace Praticando_Classes_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product();

            Console.WriteLine("Enter the data: ");
            Console.WriteLine("Product name: ");
            prod.Name = Console.ReadLine();
            Console.WriteLine("Product price: ");
            prod.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the product quantity: ");
            prod.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(prod);

            Console.WriteLine("Enter the quantity to ADD: ");
            int qAdd = int.Parse(Console.ReadLine());

            prod.AddProd(qAdd);

            Console.WriteLine(prod);

            Console.WriteLine("Enter the quantity to REMOVE: ");
            int qRemove = int.Parse(Console.ReadLine());

            prod.RemoveProd(qRemove);

            Console.WriteLine(prod);
        }
    }
}
