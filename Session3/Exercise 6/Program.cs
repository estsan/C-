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

            double vetekorn = 0;

            // Antal rutor
            int max = 4;

            for (int i = 0; i < max; i++)
            {
                vetekorn = vetekorn + Math.Pow(2, i);
            }
            Console.WriteLine(vetekorn);
            Console.ReadLine();

        }
    }
}