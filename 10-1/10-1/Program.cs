using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange serienummer på varan du vill köpa: ");
            bool exit = false;
            while (!exit)
            {
                string bought = Console.ReadLine();
                if (bought == "beställ")
                {
                    exit = true;
                }
                else
                {

                }
            }
        }
    }
}
