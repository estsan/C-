using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inventoryString = File.ReadAllText("ProductList.txt");
            string[] inventory = inventoryString.Split(new Char[] { ',' });

            Console.WriteLine("Följande produkter finns i affären:");
            int i = 0;
            while (i < inventory.Length-1)
            {
                Console.WriteLine("{0}: {1} - {2} ({3} kr)",inventory[i], inventory[i+1], inventory[i+2], inventory[i+3]);
                i += 4;
            }

            Console.WriteLine("");

            bool exit = false;
            int sum = 0;
            Dictionary<string, int> slutResultat = new Dictionary<string, int> { };
            while (!exit)
            {
                int index = 0;
                Console.Write("Ange serienummer att köpa: ");
                string bought = Console.ReadLine();
                if (bought == "beställ")
                {
                    Console.WriteLine("");
                    exit = true;
                    index = inventory.Length-2;
                    Console.WriteLine("Du har lagt följande beställning: ");
                    foreach (KeyValuePair<string, int> pair in slutResultat)
                    {
                        Console.WriteLine(pair.Key + ": " + pair.Value);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Totalsumma: " + sum);
                    Console.WriteLine("");
                    Console.WriteLine("Välkommen åter!");

                }
                else
                {
                    Console.Write("Ange antal att köpa: ");
                    int antal = int.Parse(Console.ReadLine());
                    index = Array.IndexOf(inventory, bought);
                    Console.WriteLine(antal + " exemplar av \"" + inventory[index + 1] + "\" har lagts till i varukorgen");
                    sum += antal * int.Parse(inventory[index + 3]);
                    slutResultat[inventory[index + 1]] = antal;
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
