﻿using System;
using System.Collections.Generic;

namespace _08_Exercicio_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            Console.Write("How many students for course A?");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                int studentCode = int.Parse(Console.ReadLine());
                set.Add(studentCode);
            }

            Console.Write("How many students for course B?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int studentCode = int.Parse(Console.ReadLine());
                set.Add(studentCode);
            }

            Console.Write("How many students for course C?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int studentCode = int.Parse(Console.ReadLine());
                set.Add(studentCode);
            }

            Console.WriteLine();
            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
