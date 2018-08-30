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

            Console.Write("Text plax: ");
            string forward = Console.ReadLine();

            int n = forward.Length;

            Console.Write("Baklänges: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(forward[n - i-1]);
            }

            Console.ReadKey();

        }
    }
}
