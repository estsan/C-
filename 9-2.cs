using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Company
    {
        public string Name;
        public string Location;
        public int Est;

        public Company Merge(Company p2)
        {
            Company NewCompany = new Company
            {
                Name = Name + "-" + p2.Name,
                Location = Location,
                Est = 0
            };
            return NewCompany;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Företagets namn, Säte, och etableringsår: ");
            Company p1 = new Company
            {
                Name = Console.ReadLine(),
                Location = Console.ReadLine(),
                Est = int.Parse(Console.ReadLine())
            };

            Console.WriteLine("Andra företagets namn, Säte, och etableringsår: ");
            Company p2 = new Company
            {
                Name = Console.ReadLine(),
                Location = Console.ReadLine(),
                Est = int.Parse(Console.ReadLine())
            };
            Company bradText = p1.Merge(p2);
        }
    }
}
