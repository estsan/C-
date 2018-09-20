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
            if (IsLarge(100.0))
            {
                Console.WriteLine("This is large");
            }
            else
            {
                Console.WriteLine("This is not large");
            }
            Console.ReadKey();
        }
        static bool IsLarge(string s)
        {
            bool isLarge = true;
            if (s.Length < 7)
            {
                isLarge = false;
            }
            return isLarge;
        }
        static bool IsLarge(int x)
        {
            bool isLarge = true;
            if (x < 1000)
            {
                isLarge = false;
            }
            return isLarge;
        }
        static bool IsLarge(double x)
        {
            bool isLarge = true;
            if (x < 50)
            {
                isLarge = false;
            }
            return isLarge;
        }
    }
}
