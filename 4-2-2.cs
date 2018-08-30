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

            //Console.Write("Text tack: ");
            // int before = int.Parse(Console.ReadLine());
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
            int n = numbers.Length;

            for (int i = 1; i < n; i += 2)
            {
                numbers[i] = 0;
                Console.Write(numbers[i - 1] + " " + numbers[i] + " ");
            }

            if (n % 2 == 1)
            {
                Console.Write(numbers[n - 1]);
            }


            Console.ReadLine();

        }
    }
}
