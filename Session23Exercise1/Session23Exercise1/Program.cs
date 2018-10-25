using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session23Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter text to repeat: ");
                string input = Console.ReadLine();

                Console.Write("Enter number of times to repeat: ");
                int count = int.Parse(Console.ReadLine());

                Console.WriteLine(Repeat(input, count));

                Console.WriteLine();
            }
        }

        static string Repeat(string original, int count)
        {
            string repeated = "";
            for (int i = 0; i < count; i++) // for (int i = 0; i <= count; i++) , ett off-by-one error.
            {
                repeated += original;
            }
            return repeated;
        }
    }
}
