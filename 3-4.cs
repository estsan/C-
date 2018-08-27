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
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            for (int i = 1; i <= 100; i++)
            {
                bool tre = i % 3 == 0;
                bool fem = i % 5 == 0;

                if (tre && fem)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (tre)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fem)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
