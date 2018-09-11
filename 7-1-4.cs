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
            Console.WriteLine("Hur många barn är det på ditt kalas?");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Och hur många godisar har du?");
            double g = double.Parse(Console.ReadLine());

            double d = Godis(g, b);

            Console.WriteLine("Varje barn får " + d + " godisar");
            Console.WriteLine("Var det rätt? Noice! Klicka enter nu och fortsätt knacka kod");
            Console.ReadLine();
        }
        static double Godis(double g, double b)
        {
            return g / b;
        }
    }
}
