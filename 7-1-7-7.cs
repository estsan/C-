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


            // Antal rutor
            Console.Write("Witty text: Hur många rutor?: ");
            double rutor = double.Parse(Console.ReadLine());

            double korn = Rutor(rutor);

            Console.WriteLine(korn);
            Console.ReadKey();
        }
        static double Rutor(double rutor)
        {
            double korn = 0;

            for (int i = 0; i < rutor; i++)
            {
                korn = korn + Math.Pow(2, i);
            }
            return korn;
        }
    }
}
