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
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            int[] dubbel = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                dubbel[i] = numbers[i];
                dubbel[i+n] = numbers[i];
            }
            Console.Write("{");
            for (int j = 0; j < n * 2 - 1; j++)
            {
                Console.Write(dubbel[j] + ", ");
            }
            Console.Write(dubbel[n*2-1] + "}");
      

            Console.ReadLine();

        }
    }
}
