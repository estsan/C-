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

            int n = 5;
            int[] numbers = new int[n];
            Console.WriteLine("Ge mig " + n + " (heltal)!");
            for (int i=0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int overTen = 0;
            
            for (int j=0; j < n; j++)
            {
                if (numbers[j] < 0)
                {
                    underZero++;
                }
            
            }
            Console.WriteLine(numbers[0] + ", " + numbers[1] + ", " + numbers[2] + ", " + numbers[3] + ", " + numbers[4]);
            Console.WriteLine(overTen + "st element över 10.");

            Console.ReadLine();

        }
    }
}
