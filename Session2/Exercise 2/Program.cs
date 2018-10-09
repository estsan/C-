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
            Console.WriteLine("Hur gammal är du? ");
            double age = double.Parse(Console.ReadLine());


            if (age < 18)
            {
                Console.WriteLine("Okej, då får du stanna utanför tyvärr.");
            }

            else
            {
                Console.WriteLine("Välkommen in, här är det party vettu!");
            }
            Console.ReadLine();

        }
    }
}