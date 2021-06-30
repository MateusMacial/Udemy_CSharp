using System;
using System.IO;
using System.Globalization;
using Arquivos.Entities;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path file: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\sumary.txt";

                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach(String line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + ", $" + prod.TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
                    }
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
