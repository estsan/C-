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

            Console.Write("Fakuliteten av vaddå: ");
            int n = int.Parse(Console.ReadLine());
            int p = Fakulitet(n);
            Console.WriteLine("Fakuliteten av " + n + " är " + p);
            Console.ReadLine();
        }
        static int Fakulitet(int n)
        {
            int p = 1;

            for (int i = 1; i < n + 1; i++)
            {
                p = p * i;
            }
            return p;
        }
    }
}
