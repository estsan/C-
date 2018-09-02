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

            Console.Write("Ge mig några heltal, avsluta med enter när du är nöjd: ");
            string hej = Console.ReadLine();
            string[] split = hej.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            int n = split.Length;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += Convert.ToInt32(split[i]);
            }

            Console.Write("Summan av talen du just gav mig är: ");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
