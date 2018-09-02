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
            string[] split = text.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            int n = split.Length;
            Dictionary<string, int> antal = new Dictionary<string, int> { };
            int counter = 0;
            Dictionary<string, int> sista = new Dictionary<string, int> { };


            for (int i = 0; i < n; i++)
            {
                if (!antal.ContainsKey(split[i]))
                {
                    antal[split[i]] = 0;
                    counter++;
                }
            }

            int[] numret = new int[counter];
            counter = 0;



            foreach (KeyValuePair<string, int> pair in antal)
            {
                for (int j = 0; j < n; j++)
                {
                    if (pair.Key == split[j])
                    {
                        numret[counter]++;
                    }
                }
                sista.Add(pair.Key, numret[counter]);
                counter++;
            }
            //int m = numret.Max();
            //int p = Array.IndexOf(numret, m);
            Console.WriteLine("Hur kommer jag ens åt nån av all data jag har? \""  );
            Console.ReadKey();
        }
    }
}
