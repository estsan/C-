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

            Console.Write("Input integer: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input higher integer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++)
                Console.Write(i + " ");

            Console.ReadKey();

        }
    }
}
