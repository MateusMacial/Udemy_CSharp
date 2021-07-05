using System;
using System.IO;
using System.Collections.Generic;
using _05_Interface_IComparable.Entities;

namespace _05_Interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Pichau\Documents\GitHubProjetos\Udemy_C#\ws_vs\secao_14\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path)){
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
