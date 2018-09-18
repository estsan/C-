using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Person
    {
        public string Name;
        public int Age;
        public int Fortune;
        public int Salary; //per month

        public Person PaySalary()
        {
            Fortune += Salary;
            return this;
        }
        public Person CelebrateBirthday()
        {
            Age++;
            Fortune += 500;
            return this;
        }
        public Person WinLottery(int prize)
        {
            Fortune += prize;
            return this;
        }
        public string Show()
        {
            string info = "";
            info = Age + " year old " + Name + " has a salary of " + Salary + " swedish krona and " + Fortune + " swedish krona in the bank.";
            return info;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personens namn, ålder tillgångar och månadslön: ");
            Person p1 = new Person
            {
                Name = Console.ReadLine(),
                Age = int.Parse(Console.ReadLine()),
                Fortune = int.Parse(Console.ReadLine()),
                Salary = int.Parse(Console.ReadLine())

            };

            p1.PaySalary();
            p1.CelebrateBirthday();
            p1.WinLottery(2000);
            p1.Show();
            Console.Write("{0} är {1} år gammal, har {2} kr, och tjänar {3} varje månad", p1.Name, p1.Age, p1.Fortune, p1.Salary);
            Console.ReadKey();
        }
    }
}
