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

            // Läs in en mening från användaren
            Console.WriteLine("Hit me up fam, I will disclose the Swedishness of your sentence!");
            string text = Console.ReadLine();

            // Kolla hur lång meningen är
            int n = text.Length;
            // Ansätt några variabler
            int i;
            int aacount = 0;
            int aecount = 0;
            int oecount = 0;

            // Hur många å:n finns i meningen?
            for (i = 0; i < n; i++)
                if (text[i] == char.Parse("å") || text[i] == char.Parse("Å"))
                    aacount++;

            //Hur många ä:n finns i meningen?
            for (i = 0; i < n; i++)
                if (text[i] == char.Parse("ä") || text[i] == char.Parse("Ä"))
                    aecount++;

            // Hur många ö:n finns det i meningen?
            for (i = 0; i < n; i++)
                if (text[i] == char.Parse("ö") || text[i] == char.Parse("Ö"))
                    oecount++;

            // Är antalet å, ä och ö noll?

            bool aabool = aacount == 0;
            bool aebool = aecount == 0;
            bool oebool = oecount == 0;
            int sum = aacount + aecount + oecount;

            // Om det inte finns å, ä, eller ö så tror vi att texten inte är svenska, annar är det antagligen det.            
            if (aabool && aebool && oebool)
                Console.WriteLine("THIS IS (probably) NOT SWEDISH YOU FOOL, 0 SWEDISH LETTERS!");
            else
                Console.WriteLine("Svenska it is! Väl? Den har ändå " + sum + " svenska bokstäver");

            // Printa antalet å, ä och ö.
            Console.WriteLine("Antal å: " + aacount + ", antal ä: " + aecount + ", och antal ö: " + oecount);

            // En lite överraskning för att testa Sleep.
            System.Threading.Thread.Sleep(4000);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write("o");
            System.Threading.Thread.Sleep(500);
            Console.Write("0");
            System.Threading.Thread.Sleep(500);
            Console.Write("O");
            System.Threading.Thread.Sleep(500);
            Console.Write("0");
            System.Threading.Thread.Sleep(500);
            Console.Write("o");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            Console.ReadKey();
        }
    }
}

