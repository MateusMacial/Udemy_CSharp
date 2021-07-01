using System;

namespace Praticando_Classes_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("Enter the first person data: ");
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second person data: ");
            Console.Write("Name: ");
            p2.Name = Console.ReadLine();
            Console.WriteLine("Age: ");
            p2.Age = int.Parse(Console.ReadLine());

            string older = mostOld(p1, p2);

            Console.WriteLine("The older one is: " + older);

        }

        static string mostOld(Person p1, Person p2)
        {
            string older;
            if(p1.Age > p2.Age)
            {
                older = p1.Name;
            }
            else
            {
                older = p2.Name;
            }
            return older;
        }
    }
}
