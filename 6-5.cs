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

            Console.Write("Text plax: ");
            string pangram = Console.ReadLine();
            pangram = pangram.ToLower();
            Console.Write("alfabet: ");
            string alfabet = Console.ReadLine();
            string nystrin = "";

            for (int i = 0; i < alfabet.Length; i++)
            {
                for (int j = 0; j < pangram.Length; j++)
                {
                    if (alfabet[i] == pangram[j])
                    {
                        nystrin += pangram[j];
                        break;
                    }
                    
                }
            }

            if (nystrin == alfabet)
            {
                Console.WriteLine("Pangram!");
            }
            else
            {
                Console.WriteLine("No pangram :(");
            }

            Console.ReadKey();

        }
    }
}
