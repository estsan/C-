using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperativeToFunctional
{
    class City
    {
        public string Name;
        public int Population;
        public double Area;
        public int Founded;
    }
    class Program
    {       
        static void Main(string[] args)
        {
            City[] cities =
            {
                new City
                {
                    Name = "Stockholm",
                    Area = 381.63,
                    Population = 1515017,
                    Founded = 1252
                },
                new City
                {
                    Name = "Göteborg",
                    Area = 215.13,
                    Population = 590580,
                    Founded = 1621
                },
                new City
                {
                    Name = "Malmö",
                    Area = 77.06,
                    Population = 312012,
                    Founded = 1250
                },
                new City
                {
                    Name = "Uppsala",
                    Area = 43.74,
                    Population = 156854,
                    Founded = 1286
                },
                new City
                {
                    Name = "Västerås",
                    Area = 48.07,
                    Population = 121806,
                    Founded = 990
                },
                new City
                {
                    Name = "Örebro",
                    Area = 50.64,
                    Population = 119091,
                    Founded = 1200
                }
            };
            int highestPopulation = cities.Max(city => city.Population);
            Console.WriteLine("Highest population: " + highestPopulation);
            
            int earliestFounding = cities.Min(city => city.Founded);
            Console.WriteLine("Earliest founding: " + earliestFounding);

            double averagePopulationDensity = Math.Round(cities.Select(city => (double)city.Population / city.Area).ToArray().Sum() / cities.Length);
            Console.WriteLine("Average population density: " + averagePopulationDensity + " people per square kilometer");

            List<string> longNames = cities.Where(city => city.Name.Length > 6).ToList().Select(city => city.Name).ToList();
            Console.WriteLine("Cities with names longer than six letters: " + String.Join(", ", longNames));
        }
    }
}