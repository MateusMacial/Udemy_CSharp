using System;
using Program_Product_Construtores.Entities;
using System.Globalization;

namespace Praticando_Classes_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the data: ");
            Console.Write("Product name: ");
            string name = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the product quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product prod = new Product(name, price, quantity);

            Console.WriteLine(prod);

            Console.Write("Enter the quantity to ADD: ");
            int qAdd = int.Parse(Console.ReadLine());

            prod.AddProd(qAdd);

            Console.WriteLine(prod);

            Console.Write("Enter the quantity to REMOVE: ");
            int qRemove = int.Parse(Console.ReadLine());

            prod.RemoveProd(qRemove);

            Console.WriteLine(prod);
        }
    }
}
