using System;
using System.IO;

namespace _05_Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Pichau\Documents\GitHubProjetos\Udemy_C#\ws_vs\secao_13\00_manipulando_arquivos";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");

                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");

                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
