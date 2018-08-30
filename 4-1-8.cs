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
            string before = Console.ReadLine();
            string between = "";
            int n = before.Length;
            int counter1 = 0;


            while (before[counter1] == ' ')
            {
                counter1++;
            }

            for (int i = counter1; i < n; i++)
            {
                between += before[i];
            }

            Console.WriteLine("|" + between + "|");

            string finnish = "";
            int counter2 = between.Length - 1;

            while (between[counter2] == ' ')
            {
                counter2--;
            }
            
            for (int j = 0; j <= counter2; j++)
            {
                finnish += between[j];
            }
                


            Console.WriteLine("|" + finnish + "|");
            Console.ReadLine();

        }
    }
}
