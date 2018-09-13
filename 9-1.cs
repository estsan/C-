using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public string Mening()
        {
            string result = "";
            result += FirstName;
            result += " ";
            result += LastName;
            result += " is ";
            result += Age;
            result += " years old.";
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                FirstName = "Brad",
                LastName = "Pitt",
                Age = 54
            };
            Person p2 = new Person
            {
                FirstName = "Jakob",
                LastName = "Kallin",
                Age = 31
            };
            string bradText = p1.Mening();
            string jakoText = p2.Mening();
        }
    }
}
