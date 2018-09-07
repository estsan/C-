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

            Console.WriteLine("När är du född? ");

            string date1 = Console.ReadLine();
            DateTime birfdey = DateTime.Parse(date1, System.Globalization.CultureInfo.InvariantCulture);

            DateTime nu = DateTime.Now;
            int dagar = 0;
            int days = DateTime.DaysInMonth(nu.Year, nu.Month);
            DateTime counter = birfdey;

            while (nu.Day != counter.Day)
            {
                dagar += 1;
                counter = counter.AddDays(1);
            }

            while (nu.Month != counter.Month)
            {
                dagar += DateTime.DaysInMonth(birfdey.Year, birfdey.Month);
                counter = counter.AddMonths(1);
            }

            while (nu.Year != counter.Year)
            {
                dagar += 365;
                counter = counter.AddYears(1);
            }

            int s = 0;
            int n = 0;


            if (birfdey.Month < 3)
            {
                s = birfdey.Year;
            }
            else
            {
                s = birfdey.Year + 1;
            }
            if (nu.Month > 2)
            {
                n = nu.Year;
            }
            else
            {
                n = nu.Year - 1;
            }
            for (int i = s; i <= n; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    dagar++;
                }
            }



            Console.WriteLine(dagar);

            Console.ReadKey();
        }
    }
}
