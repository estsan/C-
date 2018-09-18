﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] contents = File.ReadAllLines("TextFile1.txt");
            string newContents = "";

            foreach (string line in contents)
            {
                try
                {
                    int number = int.Parse(line);
                    int largerNumber = number * 2;
                    Console.WriteLine(largerNumber);
                    //newContents += largerNumber + "\r\n";         //eller Enviroment.NewLine
                }
                catch
                {
                    Console.WriteLine(line);
                }
            }
            File.WriteAllText(@"C:\Windows\Temp\NewNumbers.txt", newContents);


            Console.ReadKey();
        }
    }
}