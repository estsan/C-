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
            //string magi = "";
            int counter = 0;

            foreach (char c in text)
                if (c == 'a' || c == 'A')
                {
                    counter++;
                }
                
            Console.WriteLine(counter + " st A:n");
            Console.ReadLine();

        }
    }
}
