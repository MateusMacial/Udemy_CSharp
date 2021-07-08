﻿using System;
using System.Linq;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using _09_Exercicio_Resolvido.Entities;

namespace _09_Exercicio_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter full file path:");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);

                        list.Add(new Product(name, price));
                    }
                }

                var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();

                Console.WriteLine("Product names white price is lower than avarage, order by name:");
                var names = list.Where(x => x.Price <= avg).OrderByDescending(x => x.Name).Select(x => x.Name);

                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
