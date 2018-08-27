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

            Console.Write("Minimisumma?: ");
            int n = int.Parse(Console.ReadLine());

            int d1 = 6;
            int d2 = 8;

            for (int i = 1; i < d1 + 1; i++)
            {
                for (int j = 1; j < d2 + 1; j++)
                {
                    if (i == 6 && j == 6)
                    {
                        if (i + j >= n)
                        {
                            Console.Write("(" + d1 + ", " + d2 + "), ");
                        }
                    }
                    else
                    {
                        if (i + j >= n)
                        {
                            Console.Write("(" + i + ", " + j + "), ");
                        }
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
