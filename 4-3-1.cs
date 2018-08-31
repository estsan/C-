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

            Console.WriteLine("Classify:");
            string hemligText = Console.ReadLine();
            int n = hemligText.Length;
            string hemligastText = "";

            if (hemligText.StartsWith("Classified:"))
            {
                string hemligareText = hemligText.Replace("Area 51", "[AN UNDISCLOSED LOCATION]");
                hemligastText = hemligareText.Remove(0, 12);
            }
            else
            {
                hemligastText = hemligText;
            }


            Console.WriteLine(hemligastText);


            Console.ReadLine();
        }
    }
}
