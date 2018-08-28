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

            Console.Write("Text plax: ");
            string text = Console.ReadLine();
            string lowText = text.ToLower();
            int n = lowText.Length;
            string shortText = "";
            int counter = 0; //ELLER?
            string backward = "";

            for (int i = 0; i < n; i++)
            {
                if (lowText[i] >= 'a' && lowText[i] <= 'z')
                {
                    shortText += lowText[i];
                    counter++;
                }
            }

            counter = 0;
            int m = shortText.Length;

            for (int i = 0; i < m; i++)
            {
                backward += shortText[m-i-1];
                counter++;
            }

            if (backward == shortText)
            {
                Console.WriteLine("Yay! Palindrom!");
            }
            else
            {
                Console.WriteLine("SUKKAH!");
            }

            Console.ReadKey();

        }
    }
}
