﻿using System;
using System.IO;

namespace Arquivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\CSharpProjects\file1.txt";

            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path);//new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
               //if (fs != null) fs.Close();
            }
        }
    }
}
