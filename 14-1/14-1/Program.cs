using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{ 
    class Flags
    {
        public int country;

        public void Flag()
        {
            if (country == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("    ");

                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("    ");

                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("    ");

                Console.WriteLine();
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Countries to choose from: ");
            Console.WriteLine("1. France");
            Console.WriteLine("2. Denmark");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Flags land = new Flags
            {
                country =int.Parse(Console.ReadLine())
            };
            land.Flag();


            Console.ReadKey();
        }
    }
}
