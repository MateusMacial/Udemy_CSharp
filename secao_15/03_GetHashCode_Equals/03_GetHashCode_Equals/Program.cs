using System;
using _03_GetHashCode_Equals.Entities;

namespace _03_GetHashCode_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client("joao", "joao@gmail");
            Client b = new Client("jose", "jose@gmail");

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
