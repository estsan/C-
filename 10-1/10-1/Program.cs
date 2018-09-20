using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    class Product
    {
        public string Serial;
        public string Name;
        public string Description;
        public int Prize;

        public Product PaySalary()
        {
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] inventoryString = new string[0];
            bool apa = false;
            try
            {
                inventoryString = File.ReadAllLines("ProductList.txt");
                Console.WriteLine("Följande produkter finns i affären:");
            }
            catch
            {
                Console.WriteLine("Det här är inte en affär.");
                apa = true;
            }
            int m = inventoryString.Length;
            string[,] inventory = new string[m, 4];
            int i = 0;
            foreach (string line in inventoryString)
            {
                string[] troll = line.Split(new char[] { ',' });

                try
                {
                    for (int j = 0; j < 4; j++)
                    {
                        inventory[i, j] = troll[j].Trim(' ');
                    }
                    Console.WriteLine("{0}: {1} - {2} ({3} kr)", inventory[i, 0], inventory[i, 1], inventory[i, 2], inventory[i, 3]);
                    i++;
                }
                catch
                {
                    //Inget händer i så fall
                }
            }

            Console.WriteLine("");

            bool exit = false;
            int sum = 0;
            Dictionary<string, int> slutResultat = new Dictionary<string, int> { };
            while (!exit)
            {
                if (i == 0 && !apa)
                {
                    Console.WriteLine("Vi har slut på allt tyvärr, kom tillbaka en annan gång.");
                    break;
                }
                Console.Write("Ange serienummer att köpa: ");
                string bought = Console.ReadLine();
                string[] index = new string[2];

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
                else if (bought == "spara")
                {
                    string text = "";
                    foreach (KeyValuePair<string, int> pair in slutResultat)
                    {
                        text += pair.Value + " st " + pair.Key + Environment.NewLine;
                    }                    
                    File.WriteAllText(@"C:\Windows\Temp\NyFil.txt", text, Encoding.UTF8);
                    exit = true;
                }
                else
                {
                    try
                    {
                        index = Index(inventory, bought);
                        Console.Write("Ange antal att köpa: ");
                        int antal = int.Parse(Console.ReadLine());
                        Console.WriteLine(antal + " exemplar av \"" + index[0] + "\" har lagts till i varukorgen");
                        sum += antal * int.Parse(index[1]);
                        if (slutResultat.ContainsKey(index[0]))
                        {
                            slutResultat[index[0]] += antal;
                        }
                        else
                        {
                            slutResultat[index[0]] = antal;
                        }
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
