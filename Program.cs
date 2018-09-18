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

            Console.WriteLine("Hit me up fam, I will disclose the Swedishness of your sentence!");  // Läs in en mening från användaren
            string text = Console.ReadLine();   //Var försiktig med texterna du skriver ut, snällare.
            int aacount = 0;                  // Ansätt några variabler
            int aecount = 0;
            int oecount = 0;

            foreach (char c in text)
            {
                if (c == 'å' || c == 'Å')        // Hur många å:n finns i meningen?he 
                {  
                    aacount++;
                }

                if (c == 'ä' || c == 'Ä')        // Hur många ä:n finns i meningen?
                {
                    aacount++;                  //fel variabelnamn
                }

                if (c == 'ö' || c == 'Ö')        // Hur många ö:n finns i meningen?
                {
                    aacount++;                  //fel variabelnamn
                }
            }

            bool aabool = aacount == 0;                 //istället för dessa tre, skriv "if (sum == 0)" för samma resultat
            bool aebool = aecount == 0;
            bool oebool = oecount == 0;
            int sum = aacount + aecount + oecount;     // Är antalet å, ä och ö noll?

            if (aabool && aebool && oebool)            // Om det inte finns å, ä, eller ö så tror vi att texten inte är svenska    
            {
                Console.Write("THIS IS (probably) NOT SWEDISH YOU FOOL, 0 SWEDISH LETTERS! ");
            }
            else
            {                                     //annars är det antagligen det.        
                Console.Write("Svenska it is! Väl? Den har ändå " + sum + " svenska bokstäver: ");
            }

            Console.WriteLine(aacount + " st å:n, " + aecount + " st ä:n, " + oecount + " och st ö:n");  // Printa antalet å, ä och ö.
            Console.ReadKey();
        }
    }
}
