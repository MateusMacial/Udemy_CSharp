using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int big = Bigger(n1, n2, n3);

            Console.WriteLine("The biggest number is: " + big);
        }

        static int Bigger(int a, int b, int c)
        {
            int big = 0;

            if(a > b && a > c)
            {
                big = a;
            }
            else if(b > c)
            {
                big = b;
            }
            else
            {
                big = c;
            }
            return big;
        }
    }
}
