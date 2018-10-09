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

            Console.Write("Ge mig ett tal: ");
            int n = int.Parse(Console.ReadLine());
            int sj = 0;
            int su = 0;

            for (int i = 2; i < n + 1; i += 2)
            {
                sj = sj + i;
            }

            for (int i = 1; i < n + 1; i += 2)
            {
                su = su + i;
            }
            Console.WriteLine("Summan av alla jämna tal upp till " + n + " är " + sj + " och summan av alla udda är " + su);
            Console.ReadLine();

        }
    }
}