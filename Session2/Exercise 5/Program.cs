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

            if (!(!(true && false)))
            {
                Console.WriteLine("Sant");
            }
            else
            {
                Console.WriteLine("Falskt");
            }
            Console.ReadLine();

        }
    }
}

//byt ut rad 15