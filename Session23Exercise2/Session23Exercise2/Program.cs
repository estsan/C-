using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session23Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter password to validate: ");
                string input = Console.ReadLine();

                Console.WriteLine(ValidPassword(input));

                Console.WriteLine();
            }
        }

        static bool ValidPassword(string password)
        {
            bool valid = false;

            if (password.Length >= 8)
            {
                valid = true;
            }

            int upperCaseCount = password.Count(c => Char.IsUpper(c));
            valid = valid && upperCaseCount > 0;

            int lowerCaseCount = password.Count(c => Char.IsLower(c));
            valid = valid && lowerCaseCount > 0;                        // valid = lowerCaseCount > 0; , Saknar "valid &&"

            int numberCount = password.Count(c => Char.IsNumber(c));
            valid = valid && numberCount > 0;

            return valid;
        }
    }
}
