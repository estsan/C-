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
            string m = Console.ReadLine();
            Console.Write("Integer, halp: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                Console.Write(m);

            Console.ReadKey();

        }
    }
}
