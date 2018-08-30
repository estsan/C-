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

            int n = 5;
            int[] numbers = new int[n];
            Console.WriteLine("Ge mig " + n + " (heltal)!");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            

            foreach (char c in numbers)
            {
                if (c != 0)
                    counter++;
            }
            
            int[] newArray = new int [counter];
            counter = 0;

            for (int i=0; i <n;i++)
            {
                if (numbers[i] != 0)
                {
                    newArray[counter] = numbers[i];
                    Console.Write(newArray[counter] + ", ");
                    counter++;
                }
            }


            Console.ReadLine();

        }
    }
}
