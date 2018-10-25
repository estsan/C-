using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session23Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter text to check for palindrome: ");
                string input = Console.ReadLine();

                Console.WriteLine(IsPalindrome(input));

                Console.WriteLine();
            }
        }

        static bool IsPalindrome(string text)
        {
            string normalized = "";
            foreach (char c in text)
            {
                if (Char.IsLetter(c))               // if (Char.IsLetter(c) || c == ' ') , vill att mellanslagen ska satisfiera palindromkravet.
                {
                    normalized += c;
                }
            }
            normalized = normalized.ToLower();

            string reversed = "";
            foreach (char c in normalized)
            {
                reversed = c + reversed;
            }

            return normalized == reversed;
        }
    }
}
