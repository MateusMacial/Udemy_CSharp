using System;
using System.Collections.Generic;

namespace _04_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("mario");
            set.Add("maria");
            set.Add("jose");

            foreach(string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
