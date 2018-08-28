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

            Console.Write("Lösentest: ");
            string password = Console.ReadLine();

            int n = password.Length;
            bool longEnough = n >= 8;

            string lowercase = password.ToLower();
            bool isUppercase = lowercase != password;

            string uppercase = password.ToUpper();
            bool isLowercase = uppercase != password;

            bool anyNumbers = password.All(char.IsLetter); //Falsk om siffra med

            if (!longEnough)
            {
                Console.WriteLine("Ditt lösenord är för kort.");
            }

            if (!isUppercase)
            {
                Console.WriteLine("Ditt lösenord saknar stor bokstav.");
            }

            if (!isLowercase)
            {
                Console.WriteLine("Ditt lösenord saknar liten bokstav.");
            }

            if (anyNumbers)
            {
                Console.WriteLine("Ditt lösenord saknar siffra.");
            }

            if (isUppercase && isLowercase && !anyNumbers && longEnough)
                Console.WriteLine("Ditt lösenord är tillräckligt starkt.");

            Console.ReadKey();

        }
    }
}
