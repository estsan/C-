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
            Console.WriteLine("Skriv tre heltal, så ska vi se om vi kan hitta det minsta");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int t = Minimus(a, b, c);



            Console.Write("Det minsta torde vara ");
            Console.WriteLine(t);
            Console.WriteLine("Var det rätt? Noice! Klicka enter nu och fortsätt knacka kod");
            Console.ReadLine();
        }
        static int Minimus(int x, int y, int z)
        {
            int s = Math.Min(x, y);
            int t = Math.Min(s, z);
            return t;
        }
    }
}
