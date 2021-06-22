using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Room[] vect = new Room[10];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Aluguel #" + (i+1));
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Room(name, email);
            }

            Console.WriteLine("Quartos ocupados: ");
            for(int i=0; i<10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + " : " + vect[i]);
                }
            }
        }
    }
}
