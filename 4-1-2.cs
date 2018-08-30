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

            Console.Write("Skriv in ett svårläst ord: ");
            string text = Console.ReadLine();
            string magi = "";

            for (int i = 0; i<text.Length-1; i++)
            {
                magi += text[i];
                magi += '-';
            }

            magi += text[text.Length -1];

            Console.WriteLine("Här får du samma ord fast lite glesare. \"" + magi + "\". Ett tack är på sin plats tycker jag nog.");
            Console.ReadLine();

        }
    }
}
