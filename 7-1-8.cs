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

            Console.Write("Text: ");
            string text = Console.ReadLine();

            string uttext = NoVowel(text);

            Console.WriteLine(uttext);
            Console.ReadKey();
        }
        static string NoVowel(string s)
        {
            string ya = "";
            foreach (char c in s)
            {
               if ((c=='a') || (c == 'A') || (c == 'o') || (c == 'O') || (c == 'u') || (c == 'U') || (c == 'e') || (c == 'E') || (c == 'i') || (c == 'I') || (c == 'y') || (c == 'Y'))
                {
                }
                else
                {
                    ya += c;
                }
            }
            return ya;
        }
    }
}
