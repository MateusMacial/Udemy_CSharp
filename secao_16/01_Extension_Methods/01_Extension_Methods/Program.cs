using System;

namespace _01_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 07, 05, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
