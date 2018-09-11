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
            string USA = Console.ReadLine();

            Console.WriteLine("Hur gammal är du? ");
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine("Hur många gånger har du blivit vald till USA:s president tidigare? ");
            int mandat = int.Parse(Console.ReadLine());


            Console.WriteLine("Är du man? ");
            string bae = Console.ReadLine();

            bool president = Presedent(USA, age, mandat, bae);


            if (president)
            {
                Console.WriteLine("Du kan bli");
            }
            else
            {
                Console.WriteLine("Du kan inte bli");
            }

            Console.ReadLine();
        }
        static bool Presedent(string medborgare, double age, int mandatperioder, string bae)
        {
            bool aktuell = true;
            if ((bae == "Nej") || ((medborgare == "Ja") && (age >= 35) && (mandatperioder < 1)))
            {
                aktuell = true;            }
            else
            {
                aktuell = false;
            }
            return aktuell;
        }
    }
}
