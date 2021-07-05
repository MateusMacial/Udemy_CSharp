using System;
using System.IO;

namespace _02_FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Pichau\Documents\GitHubProjetos\Udemy_C#\ws_vs\secao_13\00_manipulando_arquivos\file1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
