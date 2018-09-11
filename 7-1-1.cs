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
            Console.WriteLine("Vad är temperaturen i Fahrenheit? ");
            double fahr = double.Parse(Console.ReadLine());

            double cels = Celsius(fahr);

            Console.WriteLine(cels);



            Console.ReadKey();
        }
        static double Celsius(double temp)
        {
            return (temp - 32) * 0.56;
        }
    }
}
