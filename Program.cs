
            // Läs in en mening från användaren
            Console.WriteLine("Hit me up fam, I will disclose the Swedishness of your sentence!");
            string text = Console.ReadLine();

            string lowerText = text.ToLower();
                
            // Kolla hur lång meningen är
            int n = lowerText.Length;
            // Ansätt några variabler
            int i;
            int aacount = 0;
            int aecount = 0;
            int oecount = 0;

            // Hur många å:n finns i meningen?
            for (i = 0; i < n; i++)
                if (lowerText[i] == char.Parse("å")) // || text[i] == char.Parse("Å"))
                    aacount++;

            //Hur många ä:n finns i meningen?
            for (i = 0; i < n; i++)
                if (lowerText[i] == char.Parse("ä")) // || text[i] == char.Parse("Ä"))
                    aecount++;

            // Hur många ö:n finns det i meningen?
            for (i = 0; i < n; i++)
                if (lowerText[i] == char.Parse("ö")) // || text[i] == char.Parse("Ö"))
                    oecount++;

            // Är antalet å, ä och ö noll?

            bool aabool = aacount == 0;
            bool aebool = aecount == 0;
            bool oebool = oecount == 0;

            // Om det inte finns å, ä, eller ö så tror vi att texten inte är svenska, annar är det antagligen det.            
            if (aabool && aebool && oebool)
                Console.WriteLine("THIS IS (probably) NOT SWEDISH YOU FOOL");
            else
                Console.WriteLine("Svenska it is! Väl?");

            // Printa antalet å, ä och ö.
            Console.WriteLine("Antal å: " + aacount + ", antal ä: " + aecount + ", och antal ö: " + oecount);

            // En lite överraskning för att testa Sleep.
            System.Threading.Thread.Sleep(5000);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write("o");
            System.Threading.Thread.Sleep(500);
            Console.Write("0");
            System.Threading.Thread.Sleep(500);
            Console.Write("O");
            System.Threading.Thread.Sleep(500);
            Console.Write("0");
            System.Threading.Thread.Sleep(500);
            Console.Write("o");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            Console.ReadKey();

