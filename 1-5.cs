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
            Console.WriteLine("Skriv 4 koordinater, x1, y1, x2 och y2, så ska vi se om jag kan gissa avståndet mellan punkterna");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine("Avståndet torde vara " + d + ", gissningsvis.");
            Console.WriteLine("Var det rätt? Noice! Klicka enter nu och fortsätt knacka kod");
            Console.ReadLine();

         
        }
    }
}
