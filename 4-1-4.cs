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

            Console.Write("Text tack: ");
            string text = Console.ReadLine();
            string magi = "";

            foreach (char c in text)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y' || c == 'å' || c == 'ä' || c == 'ö' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y' || c == 'Å' || c == 'Ä' || c == 'Ö')
                {

                }
                else
                {
                    magi += c;
                }
            }


            Console.WriteLine("Här får du samma text fast lite kortare. \"" + magi + "\". Ett tack är på sin plats tycker jag nog.");
            Console.ReadLine();

        }
    }
}
