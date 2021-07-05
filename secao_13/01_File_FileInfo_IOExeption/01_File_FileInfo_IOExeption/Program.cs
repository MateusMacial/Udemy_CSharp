using System;
using System.IO;

namespace _01_File_FileInfo_IOExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Pichau\Documents\GitHubProjetos\Udemy_C#\ws_vs\secao_13\00_manipulando_arquivos\file1.txt";
            string targetPath = @"C:\Users\Pichau\Documents\GitHubProjetos\Udemy_C#\ws_vs\secao_13\00_manipulando_arquivos\file2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
