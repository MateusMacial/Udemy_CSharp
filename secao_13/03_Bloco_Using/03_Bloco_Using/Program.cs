using System;
using System.IO;

namespace _03_Bloco_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Pichau\Documents\GitHubProjetos\Udemy_C#\ws_vs\secao_13\00_manipulando_arquivos\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
