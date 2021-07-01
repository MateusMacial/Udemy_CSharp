using System;
using System.Globalization;
using Praticando_Classes_05_Rectangle.Entities;

namespace Praticando_Classes_05_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            rec.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rec.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + rec.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + rec.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rec.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
