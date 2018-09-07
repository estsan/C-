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

            string text = Console.ReadLine();
            text = text.ToLower();
            string[] ordlista = text.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            int n = ordlista.Length;
            Dictionary<string, int> antal = new Dictionary<string, int> { };


            for (int i = 0; i < n; i++)
            {
                if (!antal.ContainsKey(ordlista[i]))
                {
                    antal[ordlista[i]] = 0;
                }
            }

            foreach (string ord in ordlista)
            {
                if (antal.ContainsKey(ord))
                {
                    antal[ord]++;
                }
            }            

            int m = 0;
            string vanligasteOrdet = "";

            foreach (KeyValuePair<string, int> pair in antal)
            {
                if ((pair.Value > m) && (pair.Key != ""))
                {
                    m = pair.Value;
                    vanligasteOrdet = pair.Key;
                }
            }

            Console.WriteLine("Det vanligaste ordet är \"{0}\" vilket förekommer {1} gånger.", vanligasteOrdet, m);
            Console.ReadKey();
        }
    }
}
