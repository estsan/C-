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
            Console.InputEncoding = Encoding.GetEncoding("ISO-8859-1");

            Console.Write("e-mail adress: ");
            string mejl = Console.ReadLine();

            int i = mejl.IndexOf('@')+1;
            string domain = "";

            while (mejl[i] != '.')
            {
                domain += mejl[i];
                i++;
            }

            Console.WriteLine("");
            Console.WriteLine("Domän: " + domain);
            Console.ReadKey();
        }
    }
}
