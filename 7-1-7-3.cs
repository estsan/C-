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

            int[] sum = Summa(n);
           
            Console.WriteLine("Summan av alla jämna tal upp till " + n + " är " + sum[0] + " och summan av alla udda är " + sum[1]);
            Console.ReadLine();
        }
        static int[] Summa(int n)
        {

            int[] sum = new int[2];

            for (int i = 2; i < n + 1; i += 2)
            {
                sum[0] += i;
            }

            for (int i = 1; i < n + 1; i += 2)
            {
                sum[1] += i;
            }
            return sum;
        }
    }
}
