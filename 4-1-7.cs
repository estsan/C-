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
            int counter = 0;

            while (text[counter] == ' ')
            {
                counter++;
            }

            for (int i = counter; i < n; i++)
            {
                magi += text[i];
            }
                
            Console.WriteLine(magi);
            Console.ReadLine();

        }
    }
}
