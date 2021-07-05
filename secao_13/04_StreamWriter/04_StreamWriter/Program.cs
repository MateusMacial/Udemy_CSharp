using System;
using System.IO;

namespace _04_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Pichau\Documents\GitHubProjetos\Udemy_C#\ws_vs\secao_13\00_manipulando_arquivos\file1.txt";
            string targetPath = @"C:\Users\Pichau\Documents\GitHubProjetos\Udemy_C#\ws_vs\secao_13\00_manipulando_arquivos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
