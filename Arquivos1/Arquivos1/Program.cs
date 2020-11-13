using System;
using System.IO;

namespace Arquivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\CSharpProjects\file1.txt";
            string targetPath = @"D:\CSharpProjects\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An ERROR occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
