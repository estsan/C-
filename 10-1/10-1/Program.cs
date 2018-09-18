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
            string[] inventoryString = File.ReadAllLines("ProductList.txt");
            int m = inventoryString.Length;
            Console.WriteLine("Följande produkter finns i affären:");
            string[,] inventory = new string[m, 4];
            int i = 0;
            foreach (string line in inventoryString)
            {
                string[] troll = line.Split(new char[] { ',' });

                for (int j = 0; j < 4; j++)
                {
                    inventory[i, j] = troll[j].Trim(' ');
                }
                Console.WriteLine("{0}: {1} - {2} ({3} kr)", inventory[i, 0], inventory[i, 1], inventory[i, 2], inventory[i, 3]);
                i++;
            }

            Console.WriteLine("");

            bool exit = false;
            int sum = 0;
            Dictionary<string, int> slutResultat = new Dictionary<string, int> { };
            while (!exit)
            {
                //int index = 0;
                Console.Write("Ange serienummer att köpa: ");
                string bought = Console.ReadLine();
                if (bought == "beställ")
                {
                    Console.WriteLine("");
                    exit = true;
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
                    try
                    {
                        string[] index = Index(inventory, bought);
                        Console.Write("Ange antal att köpa: ");
                        int antal = int.Parse(Console.ReadLine());
                        Console.WriteLine(antal + " exemplar av \"" + index[0] + "\" har lagts till i varukorgen");
                        sum += antal * int.Parse(index[1]);
                        slutResultat[index[0]] = antal;
                    }
                    catch
                    {
                        Console.WriteLine("Det är inte ett giltigt serienummer.");

                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
        static string[] Index(string[,] Produktlista, string artikel)
        {
            bool loopa = true;
            int i = 0;
            string[] name= new string[2];
            while (loopa)
            {
                if (Produktlista[i, 0] == artikel)
                {
                    loopa = false;
                    name[0] = Produktlista[i, 1];
                    name[1] = Produktlista[i, 3];
                }
                i++;
            }
            return name;

        }
    }
}
