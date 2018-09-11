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
            Console.WriteLine("Har du en tid i sekunder och vill uttrycka den i timmar, minuter och sekunder istället? Ge mig antalet!");
            int s = int.Parse(Console.ReadLine());

            int[] tider = Sekunder(s);

            Console.WriteLine("AH, lätt! Det blir " + tider[0] + " timmar, " + tider[2] + " minuter, och " + tider[3] + " sekunder!");
            Console.WriteLine("Var det rätt? Noice! Klicka enter nu och fortsätt knacka kod");
            Console.ReadLine();
        }
        static int[] Sekunder(int s)
        {
            int[] tider = new int[4];
            tider[0] = s / 3600;        //hur många timmar
            tider[1] = s % 3600;        //rest, sekunder efter timmar
            tider[2] = tider[1] / 60;   //hur många minuter
            tider[3] = tider[1] % 60;   //rest, efter timmar och minuter a.k.a. hur många sekunder
            return tider;
        }
    }
}
