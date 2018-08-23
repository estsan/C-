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

            Console.WriteLine("Svårt att välja semester? Svara på några enkla frågor och få förslag på det perfekta resmålet för dig!");
            Console.WriteLine("Vad gillar du bäst, skog(s), berg(b), eller stadsmiljö(c)?");
            string enviroment = Console.ReadLine();

            if (enviroment == "s")
            {
                Console.WriteLine("Åk till Småland! Fantastiska skogar att tappa bort sig i!");
            }
            else if (enviroment == "b")
            {
                Console.WriteLine("Lappland är resemålet för dig, hisnande vandringsstigar och underbar utsikt!");
            }
            else if (enviroment == "c")
            {
                Console.WriteLine("Bra val! Vi har många finfina städer i Sverige, hur ska jag kunna välja? Gillar du ordvitsar? (j/n)");
                string ordvits = Console.ReadLine();
                if (ordvits == "j")
                {
                    Console.WriteLine("Götelaborg är staden på G! Kom och träffa göteborgare, ät göteburgare, och åk götebergodalbana!");
                }
                else
                {
                    Console.WriteLine("Stockholm är staden för dig. Strosa i Gamla Stan eller på djurgården, shoppa på NK eller ta en tur i tunnelbanan. Men kanske viktigast av allt: slipp de förbenade ordvitsarna!");
                }
            }
            Console.ReadLine();

        }
    }
}
