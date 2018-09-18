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
            Console.Write("Please enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                int result = 10 / number;
                Console.WriteLine("10 divided by your number is: " + result);
            }
            catch(FormatException)
            {
                Console.WriteLine("You did not enter a number.");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division by 0 is not allowed!");
            }
            Console.ReadKey();
        }
    }
}
