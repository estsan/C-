using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            int age = int.Parse(Console.ReadLine());
            int newAge = age + 1;
            Console.WriteLine("Next year you will be " + newAge + " years old");
        }
    }
}
