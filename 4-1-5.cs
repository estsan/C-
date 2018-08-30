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
            int n = text.Length;

            for (int i = 0; i < n-1; i += 2)
            {
                magi += text[i];
                magi += '*';
            }

            if (n % 2 == 1)
            {
                magi += text[n - 1];
            }

            Console.WriteLine("Här får du samma text fast lite kortare. \"" + magi + "\". Ett tack är på sin plats tycker jag nog.");
            Console.ReadLine();

        }
    }
}
