using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19Exercise1
{
    class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("ej negativ ålder");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { };
            p.Age = -5;
        }
    }
}
