using System;
using System.IO;
using System.Collections.Generic;

namespace _10_Dictionary_Exercicio_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter file full path:");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dic = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] votesRecord = sr.ReadLine().Split(',');

                        string candidate = votesRecord[0];
                        int votes = int.Parse(votesRecord[1]);

                        if (dic.ContainsKey(candidate))
                        {
                            dic[candidate] += votes;
                        }
                        else
                        {
                            dic[candidate] = votes;
                        }
                    }

                    Console.WriteLine("Votes");
                    foreach(var item in dic)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
