using System;

namespace Praticando_Classes_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Enter the student name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter the three scores: ");
            student.Score1 = double.Parse(Console.ReadLine());
            student.Score2 = double.Parse(Console.ReadLine());
            student.Score3 = double.Parse(Console.ReadLine());

            double finalScore = student.FinalScore();

            Console.WriteLine("Final score = " + finalScore);

            if(finalScore >= 60.00)
            {
                Console.WriteLine("APPROVED!!!");
            }
            else
            {
                Console.WriteLine("REPROVED!!!");
                Console.WriteLine("Missing " + (60.00 - finalScore) + " points");
            }
        }
    }
}
