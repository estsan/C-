using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session22Exercise1
{
    public interface IProduct
    {
        double Price { get; set; }
    }
    class Yarn : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Weight { get; set; }
    }
    class Fabric : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Length;
    }
    class Needle : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Size;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Yarn cotton = new Yarn
            {
                Name = "cotton",
                Price = 39,
                Weight = "Light Weight"
            };
            Yarn merinoWool = new Yarn
            {
                Name = "MerinoWool",
                Price = 99.90,
                Weight = "Bulky"
            };
            Fabric mariMekko = new Fabric
            {
                Name = "Mari Mekko",
                Price = 126.50,
                Length = 1
            };
            Needle yarnNeedle = new Needle
            {
                Name = "Yarn Needle",
                Price = 12,
                Size = 55,
            };
            List<IProduct> products = new List<IProduct>();
            products.Add(cotton);
            products.Add(yarnNeedle);
            products.Add(mariMekko);
            products.Add(merinoWool);

            double totalPrice = TotalPrice(products);
        }
        static double TotalPrice(List<IProduct> product)
        {
            double price = 0;
            foreach(IProduct p in product)
            {
                price += p.Price;
            }
            return price;
        }
    }
}
