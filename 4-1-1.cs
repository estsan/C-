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

            Console.Write("Vill du se magi? Skriv vad som helst!: ");
            string text = Console.ReadLine();
            string magi = "";

            for (int i = 0; i<text.Length-1; i++)
            {
                magi += text[i];
            }

            Console.WriteLine("Heppa! Sista bokstaven är borta!: \"" + magi + "\"");
            Console.ReadKey();

        }
    }
}
