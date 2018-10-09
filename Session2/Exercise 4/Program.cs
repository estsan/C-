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

            Console.WriteLine("Svara på föjande frågor med Ja, Nej, eller ett nummer:");

            Console.WriteLine("Är du amerikansk medborgare? ");
            string medborgare = Console.ReadLine();

            Console.WriteLine("Hur gammal är du? ");
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine("Hur många gånger har du blivit vald till USA:s president tidigare? ");
            int mandatperioder = int.Parse(Console.ReadLine());


            Console.WriteLine("Är du man? ");
            string bae = Console.ReadLine();



            if ((bae == "Nej") || ((medborgare == "Ja") && (age >= 35) && (mandatperioder < 1)))
            {
                Console.WriteLine("Du kan absolut bli president, sätt igång med kampanjen direkt");
            }
            else
            {
                Console.WriteLine("Nah Brah!");
            }
            Console.ReadLine();

        }
    }
}