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
            Console.WriteLine("Vad är temperaturen?? ");
            double temperature = double.Parse(Console.ReadLine());

            bool lagom = Lagom(temperature);

            if (lagom)
            {
                Console.WriteLine("Lagom");
            }
            else
            {
                Console.WriteLine("Ej bra temperatur");
            }
            
            Console.ReadLine();
        }
        static bool Lagom(double temp)
        {
            bool lagom;
            if ((temp <= 26) && (temp >= 18))
            {
                lagom = true;
            }
            else
            {
                lagom = false;
            }
            return lagom;
        }
    }
}
